namespace EX5_MultiThreadedWithEvent
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
            this.YaxisGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.yAxisMoveDistanceTextBox = new System.Windows.Forms.TextBox();
            this.yAxisStopButton = new System.Windows.Forms.Button();
            this.yAxisStartButton = new System.Windows.Forms.Button();
            this.xAxisGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.xMoveDistanceTextBox = new System.Windows.Forms.TextBox();
            this.xAxisStopButton = new System.Windows.Forms.Button();
            this.xAxisStartButton = new System.Windows.Forms.Button();
            this.HomeAxisButton = new System.Windows.Forms.Button();
            this.YaxisGroupBox.SuspendLayout();
            this.xAxisGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // YaxisGroupBox
            // 
            this.YaxisGroupBox.Controls.Add(this.label2);
            this.YaxisGroupBox.Controls.Add(this.yAxisMoveDistanceTextBox);
            this.YaxisGroupBox.Controls.Add(this.yAxisStopButton);
            this.YaxisGroupBox.Controls.Add(this.yAxisStartButton);
            this.YaxisGroupBox.Location = new System.Drawing.Point(286, 54);
            this.YaxisGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.YaxisGroupBox.Name = "YaxisGroupBox";
            this.YaxisGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.YaxisGroupBox.Size = new System.Drawing.Size(268, 150);
            this.YaxisGroupBox.TabIndex = 2;
            this.YaxisGroupBox.TabStop = false;
            this.YaxisGroupBox.Text = "Y Axis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Move Distance";
            // 
            // yAxisMoveDistanceTextBox
            // 
            this.yAxisMoveDistanceTextBox.Location = new System.Drawing.Point(143, 40);
            this.yAxisMoveDistanceTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.yAxisMoveDistanceTextBox.Name = "yAxisMoveDistanceTextBox";
            this.yAxisMoveDistanceTextBox.Size = new System.Drawing.Size(76, 20);
            this.yAxisMoveDistanceTextBox.TabIndex = 7;
            this.yAxisMoveDistanceTextBox.Text = "1000";
            this.yAxisMoveDistanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // yAxisStopButton
            // 
            this.yAxisStopButton.Location = new System.Drawing.Point(150, 105);
            this.yAxisStopButton.Margin = new System.Windows.Forms.Padding(2);
            this.yAxisStopButton.Name = "yAxisStopButton";
            this.yAxisStopButton.Size = new System.Drawing.Size(56, 25);
            this.yAxisStopButton.TabIndex = 5;
            this.yAxisStopButton.Text = "Stop";
            this.yAxisStopButton.UseVisualStyleBackColor = true;
            this.yAxisStopButton.Click += new System.EventHandler(this.yAxisStopButton_Click);
            // 
            // yAxisStartButton
            // 
            this.yAxisStartButton.Enabled = false;
            this.yAxisStartButton.Location = new System.Drawing.Point(35, 105);
            this.yAxisStartButton.Margin = new System.Windows.Forms.Padding(2);
            this.yAxisStartButton.Name = "yAxisStartButton";
            this.yAxisStartButton.Size = new System.Drawing.Size(56, 25);
            this.yAxisStartButton.TabIndex = 4;
            this.yAxisStartButton.Text = "Start";
            this.yAxisStartButton.UseVisualStyleBackColor = true;
            this.yAxisStartButton.Click += new System.EventHandler(this.yAxisStartButton_Click);
            // 
            // xAxisGroupBox
            // 
            this.xAxisGroupBox.Controls.Add(this.label1);
            this.xAxisGroupBox.Controls.Add(this.xMoveDistanceTextBox);
            this.xAxisGroupBox.Controls.Add(this.xAxisStopButton);
            this.xAxisGroupBox.Controls.Add(this.xAxisStartButton);
            this.xAxisGroupBox.Location = new System.Drawing.Point(30, 52);
            this.xAxisGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.xAxisGroupBox.Name = "xAxisGroupBox";
            this.xAxisGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.xAxisGroupBox.Size = new System.Drawing.Size(252, 141);
            this.xAxisGroupBox.TabIndex = 4;
            this.xAxisGroupBox.TabStop = false;
            this.xAxisGroupBox.Text = "X Axis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Move Distance";
            // 
            // xMoveDistanceTextBox
            // 
            this.xMoveDistanceTextBox.Location = new System.Drawing.Point(131, 41);
            this.xMoveDistanceTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.xMoveDistanceTextBox.Name = "xMoveDistanceTextBox";
            this.xMoveDistanceTextBox.Size = new System.Drawing.Size(76, 20);
            this.xMoveDistanceTextBox.TabIndex = 6;
            this.xMoveDistanceTextBox.Text = "1000";
            this.xMoveDistanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // xAxisStopButton
            // 
            this.xAxisStopButton.Location = new System.Drawing.Point(140, 106);
            this.xAxisStopButton.Margin = new System.Windows.Forms.Padding(2);
            this.xAxisStopButton.Name = "xAxisStopButton";
            this.xAxisStopButton.Size = new System.Drawing.Size(56, 25);
            this.xAxisStopButton.TabIndex = 3;
            this.xAxisStopButton.Text = "Stop";
            this.xAxisStopButton.UseVisualStyleBackColor = true;
            this.xAxisStopButton.Click += new System.EventHandler(this.xAxisStopButton_Click);
            // 
            // xAxisStartButton
            // 
            this.xAxisStartButton.Enabled = false;
            this.xAxisStartButton.Location = new System.Drawing.Point(26, 106);
            this.xAxisStartButton.Margin = new System.Windows.Forms.Padding(2);
            this.xAxisStartButton.Name = "xAxisStartButton";
            this.xAxisStartButton.Size = new System.Drawing.Size(56, 25);
            this.xAxisStartButton.TabIndex = 2;
            this.xAxisStartButton.Text = "Start";
            this.xAxisStartButton.UseVisualStyleBackColor = true;
            this.xAxisStartButton.Click += new System.EventHandler(this.xAxisStartButton_Click);
            // 
            // HomeAxisButton
            // 
            this.HomeAxisButton.Location = new System.Drawing.Point(199, 23);
            this.HomeAxisButton.Margin = new System.Windows.Forms.Padding(2);
            this.HomeAxisButton.Name = "HomeAxisButton";
            this.HomeAxisButton.Size = new System.Drawing.Size(178, 26);
            this.HomeAxisButton.TabIndex = 3;
            this.HomeAxisButton.Text = "Home Axis";
            this.HomeAxisButton.UseVisualStyleBackColor = true;
            this.HomeAxisButton.Click += new System.EventHandler(this.HomeAxisButton_Click);
            // 
            // MultiThreadedWithEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 238);
            this.Controls.Add(this.YaxisGroupBox);
            this.Controls.Add(this.xAxisGroupBox);
            this.Controls.Add(this.HomeAxisButton);
            this.Name = "MultiThreadedWithEvent";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MultiThreadedWithEvent_FormClosing);
            this.Load += new System.EventHandler(this.MultiThreadedWithEvent_Load);
            this.YaxisGroupBox.ResumeLayout(false);
            this.YaxisGroupBox.PerformLayout();
            this.xAxisGroupBox.ResumeLayout(false);
            this.xAxisGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox YaxisGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox yAxisMoveDistanceTextBox;
        private System.Windows.Forms.Button yAxisStopButton;
        private System.Windows.Forms.Button yAxisStartButton;
        private System.Windows.Forms.GroupBox xAxisGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox xMoveDistanceTextBox;
        private System.Windows.Forms.Button xAxisStopButton;
        private System.Windows.Forms.Button xAxisStartButton;
        private System.Windows.Forms.Button HomeAxisButton;
    }
}

