namespace EX12_DataLogger
{
    partial class DataLogger
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
            this.components = new System.ComponentModel.Container();
            this.StopLoggingButton = new System.Windows.Forms.Button();
            this.StartLoggingButton = new System.Windows.Forms.Button();
            this.IDReadOnlyTextField1 = new System.Windows.Forms.TextBox();
            this.IDReadOnlyTextField2 = new System.Windows.Forms.TextBox();
            this.IDReadOnlyTextField3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UpdateRateTrackBar = new System.Windows.Forms.TrackBar();
            this.UpdateRateLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.UseTimerCheckbox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TimerMinutesInput = new System.Windows.Forms.TextBox();
            this.ElapsedTimeTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Elapsed_Time_Timer = new System.Windows.Forms.Timer(this.components);
            this.DataProgressBar = new System.Windows.Forms.ProgressBar();
            this.StatusTimer = new System.Windows.Forms.Timer(this.components);
            this.ObjectID_1_TextBox = new System.Windows.Forms.TextBox();
            this.ObjectID_2_TextBox = new System.Windows.Forms.TextBox();
            this.ObjectID_3_TextBox = new System.Windows.Forms.TextBox();
            this.InitializeButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ObjectID_4_TextBox = new System.Windows.Forms.TextBox();
            this.IDReadOnlyTextField4 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateRateTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // StopLoggingButton
            // 
            this.StopLoggingButton.BackColor = System.Drawing.Color.Red;
            this.StopLoggingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopLoggingButton.ForeColor = System.Drawing.Color.White;
            this.StopLoggingButton.Location = new System.Drawing.Point(12, 383);
            this.StopLoggingButton.Margin = new System.Windows.Forms.Padding(4);
            this.StopLoggingButton.Name = "StopLoggingButton";
            this.StopLoggingButton.Size = new System.Drawing.Size(223, 103);
            this.StopLoggingButton.TabIndex = 0;
            this.StopLoggingButton.Text = "Stop Logging, Create Log";
            this.StopLoggingButton.UseVisualStyleBackColor = false;
            this.StopLoggingButton.Click += new System.EventHandler(this.StopLoggingButton_Click);
            // 
            // StartLoggingButton
            // 
            this.StartLoggingButton.BackColor = System.Drawing.Color.LawnGreen;
            this.StartLoggingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartLoggingButton.ForeColor = System.Drawing.Color.Black;
            this.StartLoggingButton.Location = new System.Drawing.Point(253, 383);
            this.StartLoggingButton.Margin = new System.Windows.Forms.Padding(4);
            this.StartLoggingButton.Name = "StartLoggingButton";
            this.StartLoggingButton.Size = new System.Drawing.Size(223, 103);
            this.StartLoggingButton.TabIndex = 1;
            this.StartLoggingButton.Text = "Start Logging";
            this.StartLoggingButton.UseVisualStyleBackColor = false;
            this.StartLoggingButton.Click += new System.EventHandler(this.StartLoggingButton_Click);
            // 
            // IDReadOnlyTextField1
            // 
            this.IDReadOnlyTextField1.Location = new System.Drawing.Point(293, 162);
            this.IDReadOnlyTextField1.Margin = new System.Windows.Forms.Padding(4);
            this.IDReadOnlyTextField1.Name = "IDReadOnlyTextField1";
            this.IDReadOnlyTextField1.ReadOnly = true;
            this.IDReadOnlyTextField1.Size = new System.Drawing.Size(183, 22);
            this.IDReadOnlyTextField1.TabIndex = 5;
            // 
            // IDReadOnlyTextField2
            // 
            this.IDReadOnlyTextField2.Location = new System.Drawing.Point(293, 194);
            this.IDReadOnlyTextField2.Margin = new System.Windows.Forms.Padding(4);
            this.IDReadOnlyTextField2.Name = "IDReadOnlyTextField2";
            this.IDReadOnlyTextField2.ReadOnly = true;
            this.IDReadOnlyTextField2.Size = new System.Drawing.Size(183, 22);
            this.IDReadOnlyTextField2.TabIndex = 6;
            // 
            // IDReadOnlyTextField3
            // 
            this.IDReadOnlyTextField3.Location = new System.Drawing.Point(293, 226);
            this.IDReadOnlyTextField3.Margin = new System.Windows.Forms.Padding(4);
            this.IDReadOnlyTextField3.Name = "IDReadOnlyTextField3";
            this.IDReadOnlyTextField3.ReadOnly = true;
            this.IDReadOnlyTextField3.Size = new System.Drawing.Size(183, 22);
            this.IDReadOnlyTextField3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "CANopen Object ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(319, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Data Received";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(166, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Update Rate";
            // 
            // UpdateRateTrackBar
            // 
            this.UpdateRateTrackBar.Location = new System.Drawing.Point(48, 39);
            this.UpdateRateTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateRateTrackBar.Maximum = 100;
            this.UpdateRateTrackBar.Minimum = 1;
            this.UpdateRateTrackBar.Name = "UpdateRateTrackBar";
            this.UpdateRateTrackBar.Size = new System.Drawing.Size(376, 56);
            this.UpdateRateTrackBar.TabIndex = 11;
            this.UpdateRateTrackBar.Value = 50;
            this.UpdateRateTrackBar.Scroll += new System.EventHandler(this.UpdateRateTrackBar_Scroll);
            // 
            // UpdateRateLabel
            // 
            this.UpdateRateLabel.AutoSize = true;
            this.UpdateRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateRateLabel.Location = new System.Drawing.Point(196, 87);
            this.UpdateRateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpdateRateLabel.Name = "UpdateRateLabel";
            this.UpdateRateLabel.Size = new System.Drawing.Size(32, 24);
            this.UpdateRateLabel.TabIndex = 12;
            this.UpdateRateLabel.Text = "50";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(236, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "ms";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(340, 87);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "100 ms";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 87);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "1 ms";
            // 
            // UseTimerCheckbox
            // 
            this.UseTimerCheckbox.AutoSize = true;
            this.UseTimerCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseTimerCheckbox.Location = new System.Drawing.Point(59, 512);
            this.UseTimerCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.UseTimerCheckbox.Name = "UseTimerCheckbox";
            this.UseTimerCheckbox.Size = new System.Drawing.Size(119, 28);
            this.UseTimerCheckbox.TabIndex = 16;
            this.UseTimerCheckbox.Text = "Use Timer";
            this.UseTimerCheckbox.UseVisualStyleBackColor = true;
            this.UseTimerCheckbox.CheckedChanged += new System.EventHandler(this.UseTimerCheckbox_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(53, 552);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = "Elapsed Time:";
            // 
            // TimerMinutesInput
            // 
            this.TimerMinutesInput.Location = new System.Drawing.Point(197, 515);
            this.TimerMinutesInput.Margin = new System.Windows.Forms.Padding(4);
            this.TimerMinutesInput.Name = "TimerMinutesInput";
            this.TimerMinutesInput.Size = new System.Drawing.Size(183, 22);
            this.TimerMinutesInput.TabIndex = 18;
            // 
            // ElapsedTimeTextBox
            // 
            this.ElapsedTimeTextBox.Location = new System.Drawing.Point(197, 551);
            this.ElapsedTimeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ElapsedTimeTextBox.Name = "ElapsedTimeTextBox";
            this.ElapsedTimeTextBox.ReadOnly = true;
            this.ElapsedTimeTextBox.Size = new System.Drawing.Size(183, 22);
            this.ElapsedTimeTextBox.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(385, 515);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 24);
            this.label9.TabIndex = 20;
            this.label9.Text = "min";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(385, 551);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 24);
            this.label10.TabIndex = 21;
            this.label10.Text = "min";
            // 
            // Elapsed_Time_Timer
            // 
            this.Elapsed_Time_Timer.Interval = 60000;
            this.Elapsed_Time_Timer.Tick += new System.EventHandler(this.GUI_Compare_Timer_Tick);
            // 
            // DataProgressBar
            // 
            this.DataProgressBar.Location = new System.Drawing.Point(488, 131);
            this.DataProgressBar.Name = "DataProgressBar";
            this.DataProgressBar.Size = new System.Drawing.Size(25, 23);
            this.DataProgressBar.TabIndex = 22;
            this.DataProgressBar.Value = 100;
            // 
            // StatusTimer
            // 
            this.StatusTimer.Tick += new System.EventHandler(this.StatusTimer_Tick);
            // 
            // ObjectID_1_TextBox
            // 
            this.ObjectID_1_TextBox.Location = new System.Drawing.Point(98, 162);
            this.ObjectID_1_TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ObjectID_1_TextBox.Name = "ObjectID_1_TextBox";
            this.ObjectID_1_TextBox.Size = new System.Drawing.Size(183, 22);
            this.ObjectID_1_TextBox.TabIndex = 23;
            // 
            // ObjectID_2_TextBox
            // 
            this.ObjectID_2_TextBox.Location = new System.Drawing.Point(98, 194);
            this.ObjectID_2_TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ObjectID_2_TextBox.Name = "ObjectID_2_TextBox";
            this.ObjectID_2_TextBox.Size = new System.Drawing.Size(183, 22);
            this.ObjectID_2_TextBox.TabIndex = 24;
            // 
            // ObjectID_3_TextBox
            // 
            this.ObjectID_3_TextBox.Location = new System.Drawing.Point(98, 226);
            this.ObjectID_3_TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ObjectID_3_TextBox.Name = "ObjectID_3_TextBox";
            this.ObjectID_3_TextBox.Size = new System.Drawing.Size(183, 22);
            this.ObjectID_3_TextBox.TabIndex = 25;
            // 
            // InitializeButton
            // 
            this.InitializeButton.BackColor = System.Drawing.Color.Orange;
            this.InitializeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InitializeButton.Location = new System.Drawing.Point(12, 290);
            this.InitializeButton.Name = "InitializeButton";
            this.InitializeButton.Size = new System.Drawing.Size(464, 86);
            this.InitializeButton.TabIndex = 26;
            this.InitializeButton.Text = "Initialize Drive";
            this.InitializeButton.UseVisualStyleBackColor = false;
            this.InitializeButton.Click += new System.EventHandler(this.InitializeButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "(32 Bits)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 194);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 20);
            this.label11.TabIndex = 28;
            this.label11.Text = "(32 Bits)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 226);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 20);
            this.label12.TabIndex = 29;
            this.label12.Text = "(32 Bits)";
            // 
            // ObjectID_4_TextBox
            // 
            this.ObjectID_4_TextBox.Location = new System.Drawing.Point(98, 257);
            this.ObjectID_4_TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ObjectID_4_TextBox.Name = "ObjectID_4_TextBox";
            this.ObjectID_4_TextBox.Size = new System.Drawing.Size(183, 22);
            this.ObjectID_4_TextBox.TabIndex = 30;
            // 
            // IDReadOnlyTextField4
            // 
            this.IDReadOnlyTextField4.Location = new System.Drawing.Point(293, 257);
            this.IDReadOnlyTextField4.Margin = new System.Windows.Forms.Padding(4);
            this.IDReadOnlyTextField4.Name = "IDReadOnlyTextField4";
            this.IDReadOnlyTextField4.ReadOnly = true;
            this.IDReadOnlyTextField4.Size = new System.Drawing.Size(183, 22);
            this.IDReadOnlyTextField4.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(17, 256);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 20);
            this.label13.TabIndex = 32;
            this.label13.Text = "(16 Bits)";
            // 
            // DataLogger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 607);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.IDReadOnlyTextField4);
            this.Controls.Add(this.ObjectID_4_TextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.InitializeButton);
            this.Controls.Add(this.ObjectID_3_TextBox);
            this.Controls.Add(this.ObjectID_2_TextBox);
            this.Controls.Add(this.ObjectID_1_TextBox);
            this.Controls.Add(this.DataProgressBar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ElapsedTimeTextBox);
            this.Controls.Add(this.TimerMinutesInput);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.UseTimerCheckbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UpdateRateLabel);
            this.Controls.Add(this.UpdateRateTrackBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDReadOnlyTextField3);
            this.Controls.Add(this.IDReadOnlyTextField2);
            this.Controls.Add(this.IDReadOnlyTextField1);
            this.Controls.Add(this.StartLoggingButton);
            this.Controls.Add(this.StopLoggingButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DataLogger";
            this.Text = "Data Logger";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LogData_FormClosed);
            this.Load += new System.EventHandler(this.DataLogger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UpdateRateTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StopLoggingButton;
        private System.Windows.Forms.Button StartLoggingButton;
        private System.Windows.Forms.TextBox IDReadOnlyTextField1;
        private System.Windows.Forms.TextBox IDReadOnlyTextField2;
        private System.Windows.Forms.TextBox IDReadOnlyTextField3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar UpdateRateTrackBar;
        private System.Windows.Forms.Label UpdateRateLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox UseTimerCheckbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TimerMinutesInput;
        private System.Windows.Forms.TextBox ElapsedTimeTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer Elapsed_Time_Timer;
        private System.Windows.Forms.ProgressBar DataProgressBar;
        private System.Windows.Forms.Timer StatusTimer;
        private System.Windows.Forms.TextBox ObjectID_1_TextBox;
        private System.Windows.Forms.TextBox ObjectID_2_TextBox;
        private System.Windows.Forms.TextBox ObjectID_3_TextBox;
        private System.Windows.Forms.Button InitializeButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ObjectID_4_TextBox;
        private System.Windows.Forms.TextBox IDReadOnlyTextField4;
        private System.Windows.Forms.Label label13;
    }
}

