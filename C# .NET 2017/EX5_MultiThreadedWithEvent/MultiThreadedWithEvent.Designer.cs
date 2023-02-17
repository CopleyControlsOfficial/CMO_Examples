namespace EX5_MutliThreadedWithEvent
{
    partial class MultiThreadedWithEvent
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
            this.HomeAxisButton = new System.Windows.Forms.Button();
            this.xAxisGroupBox = new System.Windows.Forms.GroupBox();
            this.MoveLabel = new System.Windows.Forms.Label();
            this.xMoveDistanceTextBox = new System.Windows.Forms.TextBox();
            this.xAxisStopButton = new System.Windows.Forms.Button();
            this.xAxisStartButton = new System.Windows.Forms.Button();
            this.YaxisGroupButton = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yAxisMoveDistanceTextBox = new System.Windows.Forms.TextBox();
            this.yAxisStopButton = new System.Windows.Forms.Button();
            this.yAxisStartButton = new System.Windows.Forms.Button();
            this.xAxisGroupBox.SuspendLayout();
            this.YaxisGroupButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomeAxisButton
            // 
            this.HomeAxisButton.Location = new System.Drawing.Point(157, 25);
            this.HomeAxisButton.Name = "HomeAxisButton";
            this.HomeAxisButton.Size = new System.Drawing.Size(270, 44);
            this.HomeAxisButton.TabIndex = 0;
            this.HomeAxisButton.Text = "Home Axis";
            this.HomeAxisButton.UseVisualStyleBackColor = true;
            this.HomeAxisButton.Click += new System.EventHandler(this.HomeAxisButton_Click);
            // 
            // xAxisGroupBox
            // 
            this.xAxisGroupBox.Controls.Add(this.MoveLabel);
            this.xAxisGroupBox.Controls.Add(this.xMoveDistanceTextBox);
            this.xAxisGroupBox.Controls.Add(this.xAxisStopButton);
            this.xAxisGroupBox.Controls.Add(this.xAxisStartButton);
            this.xAxisGroupBox.Location = new System.Drawing.Point(12, 90);
            this.xAxisGroupBox.Name = "xAxisGroupBox";
            this.xAxisGroupBox.Size = new System.Drawing.Size(266, 139);
            this.xAxisGroupBox.TabIndex = 1;
            this.xAxisGroupBox.TabStop = false;
            this.xAxisGroupBox.Text = "X Axis";
            // 
            // MoveLabel
            // 
            this.MoveLabel.AutoSize = true;
            this.MoveLabel.Location = new System.Drawing.Point(16, 36);
            this.MoveLabel.Name = "MoveLabel";
            this.MoveLabel.Size = new System.Drawing.Size(101, 17);
            this.MoveLabel.TabIndex = 6;
            this.MoveLabel.Text = "Move Distance";
            // 
            // xMoveDistanceTextBox
            // 
            this.xMoveDistanceTextBox.Location = new System.Drawing.Point(135, 31);
            this.xMoveDistanceTextBox.Name = "xMoveDistanceTextBox";
            this.xMoveDistanceTextBox.Size = new System.Drawing.Size(87, 22);
            this.xMoveDistanceTextBox.TabIndex = 4;
            this.xMoveDistanceTextBox.Text = "1000";
            // 
            // xAxisStopButton
            // 
            this.xAxisStopButton.Location = new System.Drawing.Point(145, 92);
            this.xAxisStopButton.Name = "xAxisStopButton";
            this.xAxisStopButton.Size = new System.Drawing.Size(86, 28);
            this.xAxisStopButton.TabIndex = 1;
            this.xAxisStopButton.Text = "Stop";
            this.xAxisStopButton.UseVisualStyleBackColor = true;
            this.xAxisStopButton.Click += new System.EventHandler(this.xAxisStopButton_Click);
            // 
            // xAxisStartButton
            // 
            this.xAxisStartButton.Enabled = false;
            this.xAxisStartButton.Location = new System.Drawing.Point(19, 92);
            this.xAxisStartButton.Name = "xAxisStartButton";
            this.xAxisStartButton.Size = new System.Drawing.Size(86, 28);
            this.xAxisStartButton.TabIndex = 0;
            this.xAxisStartButton.Text = "Start";
            this.xAxisStartButton.UseVisualStyleBackColor = true;
            this.xAxisStartButton.Click += new System.EventHandler(this.xAxisStartButton_Click);
            // 
            // YaxisGroupButton
            // 
            this.YaxisGroupButton.Controls.Add(this.label1);
            this.YaxisGroupButton.Controls.Add(this.yAxisMoveDistanceTextBox);
            this.YaxisGroupButton.Controls.Add(this.yAxisStopButton);
            this.YaxisGroupButton.Controls.Add(this.yAxisStartButton);
            this.YaxisGroupButton.Location = new System.Drawing.Point(300, 90);
            this.YaxisGroupButton.Name = "YaxisGroupButton";
            this.YaxisGroupButton.Size = new System.Drawing.Size(254, 139);
            this.YaxisGroupButton.TabIndex = 2;
            this.YaxisGroupButton.TabStop = false;
            this.YaxisGroupButton.Text = "Y Axis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Move Distance";
            // 
            // yAxisMoveDistanceTextBox
            // 
            this.yAxisMoveDistanceTextBox.Location = new System.Drawing.Point(131, 31);
            this.yAxisMoveDistanceTextBox.Name = "yAxisMoveDistanceTextBox";
            this.yAxisMoveDistanceTextBox.Size = new System.Drawing.Size(87, 22);
            this.yAxisMoveDistanceTextBox.TabIndex = 5;
            this.yAxisMoveDistanceTextBox.Text = "1000";
            // 
            // yAxisStopButton
            // 
            this.yAxisStopButton.Location = new System.Drawing.Point(146, 92);
            this.yAxisStopButton.Name = "yAxisStopButton";
            this.yAxisStopButton.Size = new System.Drawing.Size(86, 28);
            this.yAxisStopButton.TabIndex = 3;
            this.yAxisStopButton.Text = "Stop";
            this.yAxisStopButton.UseVisualStyleBackColor = true;
            this.yAxisStopButton.Click += new System.EventHandler(this.yAxisStopButton_Click);
            // 
            // yAxisStartButton
            // 
            this.yAxisStartButton.Enabled = false;
            this.yAxisStartButton.Location = new System.Drawing.Point(18, 92);
            this.yAxisStartButton.Name = "yAxisStartButton";
            this.yAxisStartButton.Size = new System.Drawing.Size(86, 28);
            this.yAxisStartButton.TabIndex = 2;
            this.yAxisStartButton.Text = "Start";
            this.yAxisStartButton.UseVisualStyleBackColor = true;
            this.yAxisStartButton.Click += new System.EventHandler(this.yAxisStartButton_Click);
            // 
            // MultiThreadedWithEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 255);
            this.Controls.Add(this.YaxisGroupButton);
            this.Controls.Add(this.xAxisGroupBox);
            this.Controls.Add(this.HomeAxisButton);
            this.Name = "MultiThreadedWithEvent";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.xAxisGroupBox.ResumeLayout(false);
            this.xAxisGroupBox.PerformLayout();
            this.YaxisGroupButton.ResumeLayout(false);
            this.YaxisGroupButton.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HomeAxisButton;
        private System.Windows.Forms.GroupBox xAxisGroupBox;
        private System.Windows.Forms.GroupBox YaxisGroupButton;
        private System.Windows.Forms.Button xAxisStopButton;
        private System.Windows.Forms.Button xAxisStartButton;
        private System.Windows.Forms.Button yAxisStopButton;
        private System.Windows.Forms.Button yAxisStartButton;
        private System.Windows.Forms.TextBox xMoveDistanceTextBox;
        private System.Windows.Forms.TextBox yAxisMoveDistanceTextBox;
        private System.Windows.Forms.Label MoveLabel;
        private System.Windows.Forms.Label label1;
    }
}

