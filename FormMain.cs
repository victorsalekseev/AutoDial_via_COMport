using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.IO;
using System.Text.RegularExpressions;
using Netcode.AT;

namespace WindowsApplication1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            FormClosing += new FormClosingEventHandler(FormMain_FormClosing);
            Shown += new EventHandler(FormMain_Shown);
            button_stop.Click += new EventHandler(button_stop_Click);
        }

        bool isStop = false;
        string _message_file = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "message.wav");
        string _phones_file = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "phones.txt");

        void FormMain_Shown(object sender, EventArgs e)
        {
            if (!File.Exists(_message_file))
            {
                MessageBox.Show("Необходимый файл " + _message_file + Environment.NewLine + "НЕ НАЙДЕН. Программа будет закрыта.");
                Application.Exit();
            }

            if (File.Exists(_phones_file))
            {
                using (StreamReader sr = new StreamReader(_phones_file, Encoding.GetEncoding(1251)))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        if (!string.IsNullOrEmpty(line.Trim()))
                        {
                            string[] phones = new string[2];
                            phones = Regex.Split(line, ";");
                            ListViewItem lvi = new ListViewItem();
                            lvi.Name = phones[0];
                            lvi.Text = phones[0];
                            if (phones.Length > 1)
                            {
                                lvi.SubItems.Add(phones[1]);
                            }
                            listView1.Items.Add(lvi);
                        }
                    }
                }
                WriteLog("--=== СПИСОК ТЕЛЕФОНОВ ЗАГРУЖЕН... at " + DateTime.Now.ToString() + " ===--");
            }

            comboBox_port.Text = "COM1";
        }

        void button_stop_Click(object sender, EventArgs e)
        {
            isStop = true;
            WriteLog("--=== STOPPING DIAL... at " + DateTime.Now.ToString() + " ===--");
        }

        void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            isStop = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string count_dial = "На каждый номер будет произведено вызовов: " + numericUpDown_iteration.Value.ToString();
            if (numericUpDown_iteration.Value == 0)
            {
                count_dial = "На каждый номер будет произведено НЕОГРАНИЧЕННОЕ ЧИСЛО ВЫЗОВОВ, ПОКА ВЫ НЕ ЗАКРОЕТЕ ПРОГРАММУ.";
            }
            if (MessageBox.Show("Вы выбрали обзвон телефонов с периодом "+string.Format("{0}", numericUpDown_timer.Value/1000)+" секунд."+Environment.NewLine+Environment.NewLine+
                count_dial + Environment.NewLine+Environment.NewLine+
                "Помните о возможной правовой ответственности за ваши действия в случае несанкционированной рассылки сообщений (спама) и блокирования доступа абоненту, в адрес которого проводится автоматический дозвон"
                 + Environment.NewLine+Environment.NewLine+
                 "Если вы желаете начать дозвон, нажмите кнопку \"Да\" (Yes), если отказываетесь - кнопку \"Нет\" (No)", "Внимание",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ATGSM at = new ATGSM(comboBox_port.Text);
                WriteLog(at.ATZ());
                WriteLog(at.RunAT("AT+MS=V34"));

                WriteLog("--=== BEGIN OF DIAL ===--");
                WriteLog(at.RunAT("ATI4"));

                switch ((int)numericUpDown_iteration.Value)
                {
                    case 0:
                        {
                            int i = 0;
                            for (; ; )
                            {

                                if (isStop)
                                {
                                    ATZ(at);
                                    break;
                                }
                                else
                                {
                                    i++;
                                    WriteLog("--=== ITERATION " + i.ToString() + " ===--");
                                    StartDial(at);
                                }
                            }
                        }
                        break;
                    default:
                        {
                            for (int i = 0; i < (int)numericUpDown_iteration.Value; i++)
                            {

                                if (isStop)
                                {
                                    ATZ(at);
                                    break;
                                }
                                else
                                {
                                    WriteLog("--=== ITERATION " + string.Format("{0}", i + 1) + " ===--");
                                    StartDial(at);
                                }
                            }
                        }
                        break;
                }

                StartDial(at);
                WriteLog("--=== END OF DIAL ===--");
                at.ClosePort();
            }
        }

        private void StartDial(ATGSM at)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                string num = listView1.Items[i].Text.Trim();
                if (!string.IsNullOrEmpty(num))
                {
                    try
                    {
                        System.Media.SoundPlayer myPlayer = new System.Media.SoundPlayer();
                        myPlayer.SoundLocation = _message_file;

                        ATZ(at);

                        WriteLog(at.RunAT("AT+FCLASS=8"));//голосовой
                        WriteLog(at.RunAT("AT+VLS=" + numericUpDown_vls.Value.ToString()));//6-микрофон
                        WriteLog(at.RunAT("ATM" + numericUpDown_atm.Value.ToString()));//выкл.дин

                        listView1.Items[i].BackColor = Color.SpringGreen;
                        Application.DoEvents();

                        WriteLog(at.RunAT("ATDT" + num + ";"));//набор номера
                        WriteLog(at.RunAT("VTX", "OK"));//передача нач

                        Thread.Sleep(3000);//перед проигрыванием ждем 3 с
                        for (int j = 0; j < Convert.ToInt32(numericUpDown_play_count.Value); j++)
                        {
                            myPlayer.PlaySync();//j раз играем файл
                        }

                        //WriteLog(at.DLE_ETX());//<DLE><ETX>
                        WriteLog(at.RunAT("ATH"));

                        listView1.Items[i].BackColor = Color.White;
                        Application.DoEvents();

                        WriteLog("Done at "+DateTime.Now.ToString()+"...");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.TargetSite.ToString() + " | " + ex.Message.ToString());
                    }
                    Application.DoEvents();
                    Thread.Sleep((int)numericUpDown_timer.Value);
                }
            }
        }

        private void ATZ(ATGSM at)
        {
            WriteLog(at.RunAT("ATZ"));//Сброс  
        }

        private void WriteLog(string log)
        {
            log = log.Replace(Environment.NewLine + Environment.NewLine, Environment.NewLine);
            string mess = log.Replace(Environment.NewLine, " --> ");
            textBox_log.AppendText(mess + Environment.NewLine);
            using (StreamWriter sw = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "report.log"), true, Encoding.UTF8))
            {
                sw.WriteLine(mess);
                sw.Close();
            }
        }
    }
}