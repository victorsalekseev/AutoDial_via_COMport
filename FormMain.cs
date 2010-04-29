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

        void FormMain_Shown(object sender, EventArgs e)
        {
            if (!File.Exists(_message_file))
            {
                MessageBox.Show("Необходимый файл " + _message_file + Environment.NewLine + "НЕ НАЙДЕН. Программа будет закрыта.");
                Application.Exit();
            }
        }

        bool isStop = false;
        string _message_file = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Message.wav");

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
            ATGSM at = new ATGSM("COM1");
            WriteLog(at.ATZ());
            WriteLog(at.RunAT("AT+MS=V34"));

            WriteLog("--=== BEGIN OF DIAL ===--");
            WriteLog(at.RunAT("ATI4"));

            switch ((int)numericUpDown_iteration.Value)
            {
                case 0:
                    {
                        int i = 0;
                        for (; ;)
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

        private void StartDial(ATGSM at)
        {
            foreach (string num in textBox_num.Lines)
            {
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


                        WriteLog(at.RunAT("ATDT" + num + ";"));//набор номера
                        WriteLog(at.RunAT("VTX", "OK"));//передача нач

                        Thread.Sleep(Convert.ToInt32(numericUpDown_wait_b_message.Value));//перед проигрыванием ждем 2 минуты
                        for (int i = 0; i < Convert.ToInt32(numericUpDown_play_count.Value); i++)
                        {
                            myPlayer.PlaySync();//i раз играем файл
                        }

                        //WriteLog(at.DLE_ETX());//<DLE><ETX>
                        WriteLog(at.RunAT("ATH"));

                        WriteLog("Done at "+DateTime.Now.ToString()+"...");
                    }
                    catch (Exception ex)
                    {
                        textBox_num.AppendText(ex.TargetSite.ToString() + " | " + ex.Message.ToString());
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