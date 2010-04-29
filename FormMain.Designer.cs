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
            this.textBox_num = new System.Windows.Forms.TextBox();
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.numericUpDown_timer = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_iteration = new System.Windows.Forms.NumericUpDown();
            this.button_stop = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_vls = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_atm = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_play_count = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_wait_b_message = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_timer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_iteration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_vls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_atm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_play_count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_wait_b_message)).BeginInit();
            this.SuspendLayout();
            // 
            // button_run
            // 
            this.button_run.Location = new System.Drawing.Point(248, 229);
            this.button_run.Name = "button_run";
            this.button_run.Size = new System.Drawing.Size(40, 23);
            this.button_run.TabIndex = 5;
            this.button_run.Text = "Пуск";
            this.button_run.UseVisualStyleBackColor = true;
            this.button_run.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_num
            // 
            this.textBox_num.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_num.Location = new System.Drawing.Point(0, 0);
            this.textBox_num.Multiline = true;
            this.textBox_num.Name = "textBox_num";
            this.textBox_num.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_num.Size = new System.Drawing.Size(333, 221);
            this.textBox_num.TabIndex = 0;
            this.textBox_num.Text = "980014\r\n980014";
            // 
            // textBox_log
            // 
            this.textBox_log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_log.Location = new System.Drawing.Point(0, 313);
            this.textBox_log.Multiline = true;
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_log.Size = new System.Drawing.Size(333, 181);
            this.textBox_log.TabIndex = 7;
            // 
            // numericUpDown_timer
            // 
            this.numericUpDown_timer.Location = new System.Drawing.Point(81, 229);
            this.numericUpDown_timer.Maximum = new decimal(new int[] {
            7000,
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
            this.label1.Location = new System.Drawing.Point(-4, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Интервал (мс)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Итер.";
            // 
            // numericUpDown_iteration
            // 
            this.numericUpDown_iteration.Location = new System.Drawing.Point(185, 230);
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
            this.button_stop.Enabled = false;
            this.button_stop.Location = new System.Drawing.Point(294, 229);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(39, 23);
            this.button_stop.TabIndex = 6;
            this.button_stop.Text = "Стоп";
            this.button_stop.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "AT+VLS=";
            // 
            // numericUpDown_vls
            // 
            this.numericUpDown_vls.Location = new System.Drawing.Point(81, 255);
            this.numericUpDown_vls.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown_vls.Name = "numericUpDown_vls";
            this.numericUpDown_vls.Size = new System.Drawing.Size(57, 20);
            this.numericUpDown_vls.TabIndex = 9;
            this.numericUpDown_vls.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // numericUpDown_atm
            // 
            this.numericUpDown_atm.Location = new System.Drawing.Point(185, 256);
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
            this.label4.Location = new System.Drawing.Point(149, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "ATM";
            // 
            // numericUpDown_play_count
            // 
            this.numericUpDown_play_count.Location = new System.Drawing.Point(185, 282);
            this.numericUpDown_play_count.Maximum = new decimal(new int[] {
            30,
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
            this.label5.Location = new System.Drawing.Point(138, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Сообщ.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "раза";
            // 
            // numericUpDown_wait_b_message
            // 
            this.numericUpDown_wait_b_message.Location = new System.Drawing.Point(81, 281);
            this.numericUpDown_wait_b_message.Maximum = new decimal(new int[] {
            40000,
            0,
            0,
            0});
            this.numericUpDown_wait_b_message.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDown_wait_b_message.Name = "numericUpDown_wait_b_message";
            this.numericUpDown_wait_b_message.Size = new System.Drawing.Size(57, 20);
            this.numericUpDown_wait_b_message.TabIndex = 16;
            this.numericUpDown_wait_b_message.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ждем (мс)";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 494);
            this.Controls.Add(this.numericUpDown_wait_b_message);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown_play_count);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown_atm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown_vls);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown_iteration);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_timer);
            this.Controls.Add(this.textBox_log);
            this.Controls.Add(this.textBox_num);
            this.Controls.Add(this.button_run);
            this.Name = "FormMain";
            this.Text = "Прозвонка";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_timer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_iteration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_vls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_atm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_play_count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_wait_b_message)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_run;
        private System.Windows.Forms.TextBox textBox_num;
        private System.Windows.Forms.TextBox textBox_log;
        private System.Windows.Forms.NumericUpDown numericUpDown_timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_iteration;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_vls;
        private System.Windows.Forms.NumericUpDown numericUpDown_atm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_play_count;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown_wait_b_message;
        private System.Windows.Forms.Label label7;
    }
}

