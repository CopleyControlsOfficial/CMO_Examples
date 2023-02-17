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
            this.TraceTimeGroupBox = new System.Windows.Forms.GroupBox();
            this.TracePeriodTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalTraceTimeLabel = new System.Windows.Forms.Label();
            this.MaxSamplesLabel = new System.Windows.Forms.Label();
            this.TracePeriodLabel = new System.Windows.Forms.Label();
            this.TraceRefPeriodLabel = new System.Windows.Forms.Label();
            this.SendPeriodButton = new System.Windows.Forms.Button();
            this.TriggerGroupBox = new System.Windows.Forms.GroupBox();
            this.TrigDelayTextBox = new System.Windows.Forms.TextBox();
            this.TrigLevelTextBox = new System.Windows.Forms.TextBox();
            this.TrigChannelTextBox = new System.Windows.Forms.TextBox();
            this.TrigTypeTextBox = new System.Windows.Forms.TextBox();
            this.TrigDelayLabel = new System.Windows.Forms.Label();
            this.TrigLevelLabel = new System.Windows.Forms.Label();
            this.TrigChannelLabel = new System.Windows.Forms.Label();
            this.TrigTypeLabel = new System.Windows.Forms.Label();
            this.SendTrigSettingsButton = new System.Windows.Forms.Button();
            this.StartTraceButton = new System.Windows.Forms.Button();
            this.StopTraceButton = new System.Windows.Forms.Button();
            this.TraceStatusLabel = new System.Windows.Forms.Label();
            this.TraceRefPeriodValue = new System.Windows.Forms.Label();
            this.MaxSamplesValue = new System.Windows.Forms.Label();
            this.TotalTraceTimeValue = new System.Windows.Forms.Label();
            this.TraceStatusValue = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.EnableDisableButton = new System.Windows.Forms.Button();
            this.TraceTimeGroupBox.SuspendLayout();
            this.TriggerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TraceTimeGroupBox
            // 
            this.TraceTimeGroupBox.Controls.Add(this.TotalTraceTimeValue);
            this.TraceTimeGroupBox.Controls.Add(this.MaxSamplesValue);
            this.TraceTimeGroupBox.Controls.Add(this.TraceRefPeriodValue);
            this.TraceTimeGroupBox.Controls.Add(this.TracePeriodTextBox);
            this.TraceTimeGroupBox.Controls.Add(this.label2);
            this.TraceTimeGroupBox.Controls.Add(this.label1);
            this.TraceTimeGroupBox.Controls.Add(this.TotalTraceTimeLabel);
            this.TraceTimeGroupBox.Controls.Add(this.MaxSamplesLabel);
            this.TraceTimeGroupBox.Controls.Add(this.TracePeriodLabel);
            this.TraceTimeGroupBox.Controls.Add(this.TraceRefPeriodLabel);
            this.TraceTimeGroupBox.Controls.Add(this.SendPeriodButton);
            this.TraceTimeGroupBox.Location = new System.Drawing.Point(33, 43);
            this.TraceTimeGroupBox.Name = "TraceTimeGroupBox";
            this.TraceTimeGroupBox.Size = new System.Drawing.Size(313, 217);
            this.TraceTimeGroupBox.TabIndex = 0;
            this.TraceTimeGroupBox.TabStop = false;
            this.TraceTimeGroupBox.Text = "Trace Time";
            // 
            // TracePeriodTextBox
            // 
            this.TracePeriodTextBox.Location = new System.Drawing.Point(155, 86);
            this.TracePeriodTextBox.Name = "TracePeriodTextBox";
            this.TracePeriodTextBox.Size = new System.Drawing.Size(54, 22);
            this.TracePeriodTextBox.TabIndex = 16;
            this.TracePeriodTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "ms";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "ns";
            // 
            // TotalTraceTimeLabel
            // 
            this.TotalTraceTimeLabel.AutoSize = true;
            this.TotalTraceTimeLabel.Location = new System.Drawing.Point(24, 175);
            this.TotalTraceTimeLabel.Name = "TotalTraceTimeLabel";
            this.TotalTraceTimeLabel.Size = new System.Drawing.Size(120, 17);
            this.TotalTraceTimeLabel.TabIndex = 6;
            this.TotalTraceTimeLabel.Text = "Total Trace Time:";
            // 
            // MaxSamplesLabel
            // 
            this.MaxSamplesLabel.AutoSize = true;
            this.MaxSamplesLabel.Location = new System.Drawing.Point(29, 133);
            this.MaxSamplesLabel.Name = "MaxSamplesLabel";
            this.MaxSamplesLabel.Size = new System.Drawing.Size(95, 17);
            this.MaxSamplesLabel.TabIndex = 5;
            this.MaxSamplesLabel.Text = "Max Samples:";
            // 
            // TracePeriodLabel
            // 
            this.TracePeriodLabel.AutoSize = true;
            this.TracePeriodLabel.Location = new System.Drawing.Point(30, 89);
            this.TracePeriodLabel.Name = "TracePeriodLabel";
            this.TracePeriodLabel.Size = new System.Drawing.Size(94, 17);
            this.TracePeriodLabel.TabIndex = 4;
            this.TracePeriodLabel.Text = "Trace Period:";
            // 
            // TraceRefPeriodLabel
            // 
            this.TraceRefPeriodLabel.AutoSize = true;
            this.TraceRefPeriodLabel.Location = new System.Drawing.Point(29, 38);
            this.TraceRefPeriodLabel.Name = "TraceRefPeriodLabel";
            this.TraceRefPeriodLabel.Size = new System.Drawing.Size(120, 17);
            this.TraceRefPeriodLabel.TabIndex = 3;
            this.TraceRefPeriodLabel.Text = "Trace Ref Period:";
            // 
            // SendPeriodButton
            // 
            this.SendPeriodButton.Location = new System.Drawing.Point(232, 81);
            this.SendPeriodButton.Name = "SendPeriodButton";
            this.SendPeriodButton.Size = new System.Drawing.Size(61, 32);
            this.SendPeriodButton.TabIndex = 0;
            this.SendPeriodButton.Text = "Send";
            this.SendPeriodButton.UseVisualStyleBackColor = true;
            this.SendPeriodButton.Click += new System.EventHandler(this.SendPeriodButton_Click);
            // 
            // TriggerGroupBox
            // 
            this.TriggerGroupBox.Controls.Add(this.TrigDelayTextBox);
            this.TriggerGroupBox.Controls.Add(this.TrigLevelTextBox);
            this.TriggerGroupBox.Controls.Add(this.TrigChannelTextBox);
            this.TriggerGroupBox.Controls.Add(this.TrigTypeTextBox);
            this.TriggerGroupBox.Controls.Add(this.TrigDelayLabel);
            this.TriggerGroupBox.Controls.Add(this.TrigLevelLabel);
            this.TriggerGroupBox.Controls.Add(this.TrigChannelLabel);
            this.TriggerGroupBox.Controls.Add(this.TrigTypeLabel);
            this.TriggerGroupBox.Controls.Add(this.SendTrigSettingsButton);
            this.TriggerGroupBox.Location = new System.Drawing.Point(365, 43);
            this.TriggerGroupBox.Name = "TriggerGroupBox";
            this.TriggerGroupBox.Size = new System.Drawing.Size(229, 269);
            this.TriggerGroupBox.TabIndex = 0;
            this.TriggerGroupBox.TabStop = false;
            this.TriggerGroupBox.Text = "Trigger";
            // 
            // TrigDelayTextBox
            // 
            this.TrigDelayTextBox.Location = new System.Drawing.Point(118, 175);
            this.TrigDelayTextBox.Name = "TrigDelayTextBox";
            this.TrigDelayTextBox.Size = new System.Drawing.Size(87, 22);
            this.TrigDelayTextBox.TabIndex = 15;
            // 
            // TrigLevelTextBox
            // 
            this.TrigLevelTextBox.Location = new System.Drawing.Point(118, 130);
            this.TrigLevelTextBox.Name = "TrigLevelTextBox";
            this.TrigLevelTextBox.Size = new System.Drawing.Size(87, 22);
            this.TrigLevelTextBox.TabIndex = 14;
            // 
            // TrigChannelTextBox
            // 
            this.TrigChannelTextBox.Location = new System.Drawing.Point(118, 86);
            this.TrigChannelTextBox.Name = "TrigChannelTextBox";
            this.TrigChannelTextBox.Size = new System.Drawing.Size(87, 22);
            this.TrigChannelTextBox.TabIndex = 13;
            // 
            // TrigTypeTextBox
            // 
            this.TrigTypeTextBox.Location = new System.Drawing.Point(118, 38);
            this.TrigTypeTextBox.Name = "TrigTypeTextBox";
            this.TrigTypeTextBox.Size = new System.Drawing.Size(87, 22);
            this.TrigTypeTextBox.TabIndex = 12;
            // 
            // TrigDelayLabel
            // 
            this.TrigDelayLabel.AutoSize = true;
            this.TrigDelayLabel.Location = new System.Drawing.Point(30, 180);
            this.TrigDelayLabel.Name = "TrigDelayLabel";
            this.TrigDelayLabel.Size = new System.Drawing.Size(48, 17);
            this.TrigDelayLabel.TabIndex = 11;
            this.TrigDelayLabel.Text = "Delay:";
            // 
            // TrigLevelLabel
            // 
            this.TrigLevelLabel.AutoSize = true;
            this.TrigLevelLabel.Location = new System.Drawing.Point(30, 133);
            this.TrigLevelLabel.Name = "TrigLevelLabel";
            this.TrigLevelLabel.Size = new System.Drawing.Size(46, 17);
            this.TrigLevelLabel.TabIndex = 10;
            this.TrigLevelLabel.Text = "Level:";
            // 
            // TrigChannelLabel
            // 
            this.TrigChannelLabel.AutoSize = true;
            this.TrigChannelLabel.Location = new System.Drawing.Point(30, 89);
            this.TrigChannelLabel.Name = "TrigChannelLabel";
            this.TrigChannelLabel.Size = new System.Drawing.Size(64, 17);
            this.TrigChannelLabel.TabIndex = 9;
            this.TrigChannelLabel.Text = "Channel:";
            // 
            // TrigTypeLabel
            // 
            this.TrigTypeLabel.AutoSize = true;
            this.TrigTypeLabel.Location = new System.Drawing.Point(30, 38);
            this.TrigTypeLabel.Name = "TrigTypeLabel";
            this.TrigTypeLabel.Size = new System.Drawing.Size(44, 17);
            this.TrigTypeLabel.TabIndex = 8;
            this.TrigTypeLabel.Text = "Type:";
            // 
            // SendTrigSettingsButton
            // 
            this.SendTrigSettingsButton.Location = new System.Drawing.Point(62, 222);
            this.SendTrigSettingsButton.Name = "SendTrigSettingsButton";
            this.SendTrigSettingsButton.Size = new System.Drawing.Size(61, 32);
            this.SendTrigSettingsButton.TabIndex = 1;
            this.SendTrigSettingsButton.Text = "Send";
            this.SendTrigSettingsButton.UseVisualStyleBackColor = true;
            this.SendTrigSettingsButton.Click += new System.EventHandler(this.SendTrigSettingsButton_Click);
            // 
            // StartTraceButton
            // 
            this.StartTraceButton.Location = new System.Drawing.Point(48, 305);
            this.StartTraceButton.Name = "StartTraceButton";
            this.StartTraceButton.Size = new System.Drawing.Size(102, 30);
            this.StartTraceButton.TabIndex = 1;
            this.StartTraceButton.Text = "Start Trace";
            this.StartTraceButton.UseVisualStyleBackColor = true;
            this.StartTraceButton.Click += new System.EventHandler(this.StartTraceButton_Click);
            // 
            // StopTraceButton
            // 
            this.StopTraceButton.Location = new System.Drawing.Point(181, 305);
            this.StopTraceButton.Name = "StopTraceButton";
            this.StopTraceButton.Size = new System.Drawing.Size(102, 30);
            this.StopTraceButton.TabIndex = 2;
            this.StopTraceButton.Text = "Stop Trace";
            this.StopTraceButton.UseVisualStyleBackColor = true;
            this.StopTraceButton.Click += new System.EventHandler(this.StopTraceButton_Click);
            // 
            // TraceStatusLabel
            // 
            this.TraceStatusLabel.AutoSize = true;
            this.TraceStatusLabel.Location = new System.Drawing.Point(57, 375);
            this.TraceStatusLabel.Name = "TraceStatusLabel";
            this.TraceStatusLabel.Size = new System.Drawing.Size(93, 17);
            this.TraceStatusLabel.TabIndex = 7;
            this.TraceStatusLabel.Text = "Trace Status:";
            // 
            // TraceRefPeriodValue
            // 
            this.TraceRefPeriodValue.BackColor = System.Drawing.Color.Black;
            this.TraceRefPeriodValue.ForeColor = System.Drawing.Color.Lime;
            this.TraceRefPeriodValue.Location = new System.Drawing.Point(156, 38);
            this.TraceRefPeriodValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TraceRefPeriodValue.Name = "TraceRefPeriodValue";
            this.TraceRefPeriodValue.Size = new System.Drawing.Size(53, 20);
            this.TraceRefPeriodValue.TabIndex = 17;
            this.TraceRefPeriodValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MaxSamplesValue
            // 
            this.MaxSamplesValue.BackColor = System.Drawing.Color.Black;
            this.MaxSamplesValue.ForeColor = System.Drawing.Color.Lime;
            this.MaxSamplesValue.Location = new System.Drawing.Point(156, 133);
            this.MaxSamplesValue.Name = "MaxSamplesValue";
            this.MaxSamplesValue.Size = new System.Drawing.Size(53, 20);
            this.MaxSamplesValue.TabIndex = 18;
            this.MaxSamplesValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TotalTraceTimeValue
            // 
            this.TotalTraceTimeValue.BackColor = System.Drawing.Color.Black;
            this.TotalTraceTimeValue.ForeColor = System.Drawing.Color.Lime;
            this.TotalTraceTimeValue.Location = new System.Drawing.Point(156, 175);
            this.TotalTraceTimeValue.Name = "TotalTraceTimeValue";
            this.TotalTraceTimeValue.Size = new System.Drawing.Size(85, 20);
            this.TotalTraceTimeValue.TabIndex = 19;
            this.TotalTraceTimeValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TraceStatusValue
            // 
            this.TraceStatusValue.BackColor = System.Drawing.Color.Black;
            this.TraceStatusValue.ForeColor = System.Drawing.Color.Lime;
            this.TraceStatusValue.Location = new System.Drawing.Point(156, 375);
            this.TraceStatusValue.Name = "TraceStatusValue";
            this.TraceStatusValue.Size = new System.Drawing.Size(235, 20);
            this.TraceStatusValue.TabIndex = 20;
            this.TraceStatusValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // EnableDisableButton
            // 
            this.EnableDisableButton.Location = new System.Drawing.Point(159, 431);
            this.EnableDisableButton.Name = "EnableDisableButton";
            this.EnableDisableButton.Size = new System.Drawing.Size(124, 30);
            this.EnableDisableButton.TabIndex = 16;
            this.EnableDisableButton.Text = "Enable/Disable";
            this.EnableDisableButton.UseVisualStyleBackColor = true;
            this.EnableDisableButton.Click += new System.EventHandler(this.EnableDisableButton_Click);
            // 
            // Trace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 484);
            this.Controls.Add(this.EnableDisableButton);
            this.Controls.Add(this.TraceStatusValue);
            this.Controls.Add(this.TraceStatusLabel);
            this.Controls.Add(this.StopTraceButton);
            this.Controls.Add(this.StartTraceButton);
            this.Controls.Add(this.TriggerGroupBox);
            this.Controls.Add(this.TraceTimeGroupBox);
            this.Name = "Trace";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Trace_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TraceTimeGroupBox.ResumeLayout(false);
            this.TraceTimeGroupBox.PerformLayout();
            this.TriggerGroupBox.ResumeLayout(false);
            this.TriggerGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox TraceTimeGroupBox;
        private System.Windows.Forms.Button SendPeriodButton;
        private System.Windows.Forms.GroupBox TriggerGroupBox;
        private System.Windows.Forms.Button SendTrigSettingsButton;
        private System.Windows.Forms.Button StartTraceButton;
        private System.Windows.Forms.Button StopTraceButton;
        private System.Windows.Forms.Label TracePeriodLabel;
        private System.Windows.Forms.Label TraceRefPeriodLabel;
        private System.Windows.Forms.Label TotalTraceTimeLabel;
        private System.Windows.Forms.Label MaxSamplesLabel;
        private System.Windows.Forms.Label TraceStatusLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TrigDelayLabel;
        private System.Windows.Forms.Label TrigLevelLabel;
        private System.Windows.Forms.Label TrigChannelLabel;
        private System.Windows.Forms.Label TrigTypeLabel;
        internal System.Windows.Forms.TextBox TrigTypeTextBox;
        private System.Windows.Forms.TextBox TrigChannelTextBox;
        private System.Windows.Forms.TextBox TrigDelayTextBox;
        private System.Windows.Forms.TextBox TrigLevelTextBox;
        private System.Windows.Forms.TextBox TracePeriodTextBox;
        private System.Windows.Forms.Label TotalTraceTimeValue;
        private System.Windows.Forms.Label MaxSamplesValue;
        internal System.Windows.Forms.Label TraceRefPeriodValue;
        private System.Windows.Forms.Label TraceStatusValue;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Button EnableDisableButton;
    }
}

