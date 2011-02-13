namespace WindowsApplication1
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_run = new System.Windows.Forms.Button();
            this.numericUpDown_timer = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_iteration = new System.Windows.Forms.NumericUpDown();
            this.button_stop = new System.Windows.Forms.Button();
            this.numericUpDown_atm = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_play_count = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderPhone = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderDescr = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.numericUpDown_vls = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_port = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_timer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_iteration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_atm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_play_count)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_vls)).BeginInit();
            this.SuspendLayout();
            // 
            // button_run
            // 
            this.button_run.Location = new System.Drawing.Point(12, 308);
            this.button_run.Name = "button_run";
            this.button_run.Size = new System.Drawing.Size(113, 23);
            this.button_run.TabIndex = 5;
            this.button_run.Text = "Пуск";
            this.button_run.UseVisualStyleBackColor = true;
            this.button_run.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown_timer
            // 
            this.numericUpDown_timer.Location = new System.Drawing.Point(81, 229);
            this.numericUpDown_timer.Maximum = new decimal(new int[] {
            70000000,
            0,
            0,
            0});
            this.numericUpDown_timer.Minimum = new decimal(new int[] {
            7000,
            0,
            0,
            0});
            this.numericUpDown_timer.Name = "numericUpDown_timer";
            this.numericUpDown_timer.Size = new System.Drawing.Size(57, 20);
            this.numericUpDown_timer.TabIndex = 2;
            this.numericUpDown_timer.Value = new decimal(new int[] {
            7000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Период (мс)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Итераций";
            // 
            // numericUpDown_iteration
            // 
            this.numericUpDown_iteration.Location = new System.Drawing.Point(81, 255);
            this.numericUpDown_iteration.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_iteration.Name = "numericUpDown_iteration";
            this.numericUpDown_iteration.Size = new System.Drawing.Size(57, 20);
            this.numericUpDown_iteration.TabIndex = 4;
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(150, 307);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(113, 23);
            this.button_stop.TabIndex = 6;
            this.button_stop.Text = "Стоп";
            this.button_stop.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_atm
            // 
            this.numericUpDown_atm.Location = new System.Drawing.Point(206, 281);
            this.numericUpDown_atm.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown_atm.Name = "numericUpDown_atm";
            this.numericUpDown_atm.Size = new System.Drawing.Size(57, 20);
            this.numericUpDown_atm.TabIndex = 11;
            this.numericUpDown_atm.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "ATM";
            // 
            // numericUpDown_play_count
            // 
            this.numericUpDown_play_count.Location = new System.Drawing.Point(81, 281);
            this.numericUpDown_play_count.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown_play_count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_play_count.Name = "numericUpDown_play_count";
            this.numericUpDown_play_count.Size = new System.Drawing.Size(57, 20);
            this.numericUpDown_play_count.TabIndex = 13;
            this.numericUpDown_play_count.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Повт. сообщ.";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderPhone,
            this.columnHeaderDescr});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(275, 223);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderPhone
            // 
            this.columnHeaderPhone.Text = "№ телефона";
            this.columnHeaderPhone.Width = 150;
            // 
            // columnHeaderDescr
            // 
            this.columnHeaderDescr.Text = "Комментарий";
            this.columnHeaderDescr.Width = 139;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBox_log);
            this.groupBox1.Location = new System.Drawing.Point(0, 337);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 178);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Лог";
            // 
            // textBox_log
            // 
            this.textBox_log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_log.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_log.Location = new System.Drawing.Point(3, 16);
            this.textBox_log.Multiline = true;
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_log.Size = new System.Drawing.Size(269, 159);
            this.textBox_log.TabIndex = 9;
            // 
            // numericUpDown_vls
            // 
            this.numericUpDown_vls.Location = new System.Drawing.Point(206, 255);
            this.numericUpDown_vls.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown_vls.Name = "numericUpDown_vls";
            this.numericUpDown_vls.Size = new System.Drawing.Size(57, 20);
            this.numericUpDown_vls.TabIndex = 20;
            this.numericUpDown_vls.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "AT+VLS=";
            // 
            // comboBox_port
            // 
            this.comboBox_port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_port.FormattingEnabled = true;
            this.comboBox_port.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10"});
            this.comboBox_port.Location = new System.Drawing.Point(206, 228);
            this.comboBox_port.Name = "comboBox_port";
            this.comboBox_port.Size = new System.Drawing.Size(57, 21);
            this.comboBox_port.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(168, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Порт";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 513);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox_port);
            this.Controls.Add(this.numericUpDown_vls);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.numericUpDown_play_count);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown_atm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown_iteration);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_timer);
            this.Controls.Add(this.button_run);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.Text = "Программа извещения абонентов по телефонной линии (Свободно распространяемое бесп" +
                "латное ПО)";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_timer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_iteration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_atm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_play_count)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_vls)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_run;
        private System.Windows.Forms.NumericUpDown numericUpDown_timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_iteration;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.NumericUpDown numericUpDown_atm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_play_count;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderPhone;
        private System.Windows.Forms.ColumnHeader columnHeaderDescr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_log;
        private System.Windows.Forms.NumericUpDown numericUpDown_vls;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_port;
        private System.Windows.Forms.Label label6;
    }
}

