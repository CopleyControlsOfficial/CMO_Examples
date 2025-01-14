namespace EX7_Trace
{
    partial class Trace
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
            this.TraceStatusValue = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.EnableDisableButton = new System.Windows.Forms.Button();
            this.StopTraceButton = new System.Windows.Forms.Button();
            this.StartTraceButton = new System.Windows.Forms.Button();
            this.TriggerGroupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TrigDelayTextBox = new System.Windows.Forms.TextBox();
            this.TrigLevelTextBox = new System.Windows.Forms.TextBox();
            this.TrigChannelTextBox = new System.Windows.Forms.TextBox();
            this.TrigTypeTextBox = new System.Windows.Forms.TextBox();
            this.SendTrigSettingsButton = new System.Windows.Forms.Button();
            this.TraceTimeGroupBox = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TotalTraceTimeValue = new System.Windows.Forms.Label();
            this.MaxSamplesValue = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TraceRefPeriodValue = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TracePeriodTextBox = new System.Windows.Forms.TextBox();
            this.SendPeriodButton = new System.Windows.Forms.Button();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.TriggerGroupBox.SuspendLayout();
            this.TraceTimeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TraceStatusValue
            // 
            this.TraceStatusValue.BackColor = System.Drawing.Color.Black;
            this.TraceStatusValue.ForeColor = System.Drawing.Color.Lime;
            this.TraceStatusValue.Location = new System.Drawing.Point(107, 253);
            this.TraceStatusValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TraceStatusValue.Name = "TraceStatusValue";
            this.TraceStatusValue.Size = new System.Drawing.Size(176, 16);
            this.TraceStatusValue.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 253);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Trace Status:";
            // 
            // EnableDisableButton
            // 
            this.EnableDisableButton.Location = new System.Drawing.Point(69, 295);
            this.EnableDisableButton.Margin = new System.Windows.Forms.Padding(2);
            this.EnableDisableButton.Name = "EnableDisableButton";
            this.EnableDisableButton.Size = new System.Drawing.Size(74, 24);
            this.EnableDisableButton.TabIndex = 11;
            this.EnableDisableButton.UseVisualStyleBackColor = true;
            this.EnableDisableButton.Click += new System.EventHandler(this.EnableDisableButton_Click);
            // 
            // StopTraceButton
            // 
            this.StopTraceButton.Location = new System.Drawing.Point(138, 205);
            this.StopTraceButton.Margin = new System.Windows.Forms.Padding(2);
            this.StopTraceButton.Name = "StopTraceButton";
            this.StopTraceButton.Size = new System.Drawing.Size(74, 24);
            this.StopTraceButton.TabIndex = 10;
            this.StopTraceButton.Text = "Stop Trace";
            this.StopTraceButton.UseVisualStyleBackColor = true;
            this.StopTraceButton.Click += new System.EventHandler(this.StopTraceButton_Click);
            // 
            // StartTraceButton
            // 
            this.StartTraceButton.Location = new System.Drawing.Point(35, 205);
            this.StartTraceButton.Margin = new System.Windows.Forms.Padding(2);
            this.StartTraceButton.Name = "StartTraceButton";
            this.StartTraceButton.Size = new System.Drawing.Size(74, 24);
            this.StartTraceButton.TabIndex = 9;
            this.StartTraceButton.Text = "Start Trace";
            this.StartTraceButton.UseVisualStyleBackColor = true;
            this.StartTraceButton.Click += new System.EventHandler(this.StartTraceButton_Click);
            // 
            // TriggerGroupBox
            // 
            this.TriggerGroupBox.Controls.Add(this.label4);
            this.TriggerGroupBox.Controls.Add(this.label3);
            this.TriggerGroupBox.Controls.Add(this.label2);
            this.TriggerGroupBox.Controls.Add(this.label1);
            this.TriggerGroupBox.Controls.Add(this.TrigDelayTextBox);
            this.TriggerGroupBox.Controls.Add(this.TrigLevelTextBox);
            this.TriggerGroupBox.Controls.Add(this.TrigChannelTextBox);
            this.TriggerGroupBox.Controls.Add(this.TrigTypeTextBox);
            this.TriggerGroupBox.Controls.Add(this.SendTrigSettingsButton);
            this.TriggerGroupBox.Location = new System.Drawing.Point(248, 11);
            this.TriggerGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.TriggerGroupBox.Name = "TriggerGroupBox";
            this.TriggerGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.TriggerGroupBox.Size = new System.Drawing.Size(150, 217);
            this.TriggerGroupBox.TabIndex = 7;
            this.TriggerGroupBox.TabStop = false;
            this.TriggerGroupBox.Text = "Trigger";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Delay:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Level:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Channel:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Type:";
            // 
            // TrigDelayTextBox
            // 
            this.TrigDelayTextBox.Location = new System.Drawing.Point(78, 138);
            this.TrigDelayTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TrigDelayTextBox.Name = "TrigDelayTextBox";
            this.TrigDelayTextBox.Size = new System.Drawing.Size(60, 20);
            this.TrigDelayTextBox.TabIndex = 8;
            // 
            // TrigLevelTextBox
            // 
            this.TrigLevelTextBox.Location = new System.Drawing.Point(78, 102);
            this.TrigLevelTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TrigLevelTextBox.Name = "TrigLevelTextBox";
            this.TrigLevelTextBox.Size = new System.Drawing.Size(60, 20);
            this.TrigLevelTextBox.TabIndex = 7;
            // 
            // TrigChannelTextBox
            // 
            this.TrigChannelTextBox.Location = new System.Drawing.Point(78, 67);
            this.TrigChannelTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TrigChannelTextBox.Name = "TrigChannelTextBox";
            this.TrigChannelTextBox.Size = new System.Drawing.Size(60, 20);
            this.TrigChannelTextBox.TabIndex = 6;
            // 
            // TrigTypeTextBox
            // 
            this.TrigTypeTextBox.Location = new System.Drawing.Point(78, 30);
            this.TrigTypeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TrigTypeTextBox.Name = "TrigTypeTextBox";
            this.TrigTypeTextBox.Size = new System.Drawing.Size(60, 20);
            this.TrigTypeTextBox.TabIndex = 5;
            // 
            // SendTrigSettingsButton
            // 
            this.SendTrigSettingsButton.Location = new System.Drawing.Point(50, 175);
            this.SendTrigSettingsButton.Margin = new System.Windows.Forms.Padding(2);
            this.SendTrigSettingsButton.Name = "SendTrigSettingsButton";
            this.SendTrigSettingsButton.Size = new System.Drawing.Size(56, 24);
            this.SendTrigSettingsButton.TabIndex = 1;
            this.SendTrigSettingsButton.Text = "Send";
            this.SendTrigSettingsButton.UseVisualStyleBackColor = true;
            this.SendTrigSettingsButton.Click += new System.EventHandler(this.SendTrigSettingsButton_Click);
            // 
            // TraceTimeGroupBox
            // 
            this.TraceTimeGroupBox.Controls.Add(this.label13);
            this.TraceTimeGroupBox.Controls.Add(this.TotalTraceTimeValue);
            this.TraceTimeGroupBox.Controls.Add(this.MaxSamplesValue);
            this.TraceTimeGroupBox.Controls.Add(this.label10);
            this.TraceTimeGroupBox.Controls.Add(this.TraceRefPeriodValue);
            this.TraceTimeGroupBox.Controls.Add(this.label8);
            this.TraceTimeGroupBox.Controls.Add(this.label7);
            this.TraceTimeGroupBox.Controls.Add(this.label6);
            this.TraceTimeGroupBox.Controls.Add(this.label5);
            this.TraceTimeGroupBox.Controls.Add(this.TracePeriodTextBox);
            this.TraceTimeGroupBox.Controls.Add(this.SendPeriodButton);
            this.TraceTimeGroupBox.Location = new System.Drawing.Point(11, 11);
            this.TraceTimeGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.TraceTimeGroupBox.Name = "TraceTimeGroupBox";
            this.TraceTimeGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.TraceTimeGroupBox.Size = new System.Drawing.Size(232, 175);
            this.TraceTimeGroupBox.TabIndex = 8;
            this.TraceTimeGroupBox.TabStop = false;
            this.TraceTimeGroupBox.Text = "Trace Time";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(181, 141);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "ms";
            // 
            // TotalTraceTimeValue
            // 
            this.TotalTraceTimeValue.BackColor = System.Drawing.Color.Black;
            this.TotalTraceTimeValue.ForeColor = System.Drawing.Color.Lime;
            this.TotalTraceTimeValue.Location = new System.Drawing.Point(112, 141);
            this.TotalTraceTimeValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalTraceTimeValue.Name = "TotalTraceTimeValue";
            this.TotalTraceTimeValue.Size = new System.Drawing.Size(64, 16);
            this.TotalTraceTimeValue.TabIndex = 19;
            // 
            // MaxSamplesValue
            // 
            this.MaxSamplesValue.BackColor = System.Drawing.Color.Black;
            this.MaxSamplesValue.ForeColor = System.Drawing.Color.Lime;
            this.MaxSamplesValue.Location = new System.Drawing.Point(112, 105);
            this.MaxSamplesValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MaxSamplesValue.Name = "MaxSamplesValue";
            this.MaxSamplesValue.Size = new System.Drawing.Size(40, 16);
            this.MaxSamplesValue.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(157, 34);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "ns";
            // 
            // TraceRefPeriodValue
            // 
            this.TraceRefPeriodValue.BackColor = System.Drawing.Color.Black;
            this.TraceRefPeriodValue.ForeColor = System.Drawing.Color.Lime;
            this.TraceRefPeriodValue.Location = new System.Drawing.Point(112, 34);
            this.TraceRefPeriodValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TraceRefPeriodValue.Name = "TraceRefPeriodValue";
            this.TraceRefPeriodValue.Size = new System.Drawing.Size(40, 16);
            this.TraceRefPeriodValue.TabIndex = 16;
            this.TraceRefPeriodValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 141);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Total Trace Time:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 105);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Max Samples:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 69);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Trace Period:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Trace Ref Period:";
            // 
            // TracePeriodTextBox
            // 
            this.TracePeriodTextBox.Location = new System.Drawing.Point(115, 67);
            this.TracePeriodTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TracePeriodTextBox.Name = "TracePeriodTextBox";
            this.TracePeriodTextBox.Size = new System.Drawing.Size(36, 20);
            this.TracePeriodTextBox.TabIndex = 9;
            // 
            // SendPeriodButton
            // 
            this.SendPeriodButton.Location = new System.Drawing.Point(163, 64);
            this.SendPeriodButton.Margin = new System.Windows.Forms.Padding(2);
            this.SendPeriodButton.Name = "SendPeriodButton";
            this.SendPeriodButton.Size = new System.Drawing.Size(56, 24);
            this.SendPeriodButton.TabIndex = 0;
            this.SendPeriodButton.Text = "Send";
            this.SendPeriodButton.UseVisualStyleBackColor = true;
            this.SendPeriodButton.Click += new System.EventHandler(this.SendPeriodButton_Click);
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Trace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 342);
            this.Controls.Add(this.TraceStatusValue);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.EnableDisableButton);
            this.Controls.Add(this.StopTraceButton);
            this.Controls.Add(this.StartTraceButton);
            this.Controls.Add(this.TriggerGroupBox);
            this.Controls.Add(this.TraceTimeGroupBox);
            this.Name = "Trace";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Trace_FormClosing);
            this.Load += new System.EventHandler(this.Trace_Load);
            this.TriggerGroupBox.ResumeLayout(false);
            this.TriggerGroupBox.PerformLayout();
            this.TraceTimeGroupBox.ResumeLayout(false);
            this.TraceTimeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TraceStatusValue;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button EnableDisableButton;
        private System.Windows.Forms.Button StopTraceButton;
        private System.Windows.Forms.Button StartTraceButton;
        private System.Windows.Forms.GroupBox TriggerGroupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TrigDelayTextBox;
        private System.Windows.Forms.TextBox TrigLevelTextBox;
        private System.Windows.Forms.TextBox TrigChannelTextBox;
        private System.Windows.Forms.TextBox TrigTypeTextBox;
        private System.Windows.Forms.Button SendTrigSettingsButton;
        private System.Windows.Forms.GroupBox TraceTimeGroupBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label TotalTraceTimeValue;
        private System.Windows.Forms.Label MaxSamplesValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label TraceRefPeriodValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TracePeriodTextBox;
        private System.Windows.Forms.Button SendPeriodButton;
        private System.Windows.Forms.Timer Timer1;
    }
}

