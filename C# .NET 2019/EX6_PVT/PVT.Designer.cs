namespace EX6_PVT
{
    partial class PVT
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
            this.label1 = new System.Windows.Forms.Label();
            this.numberOfEventsTextBox = new System.Windows.Forms.TextBox();
            this.StopPVTButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.HomeAxisButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 210);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Number of Events";
            // 
            // numberOfEventsTextBox
            // 
            this.numberOfEventsTextBox.Location = new System.Drawing.Point(134, 207);
            this.numberOfEventsTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.numberOfEventsTextBox.Name = "numberOfEventsTextBox";
            this.numberOfEventsTextBox.Size = new System.Drawing.Size(76, 20);
            this.numberOfEventsTextBox.TabIndex = 8;
            this.numberOfEventsTextBox.Text = "0";
            this.numberOfEventsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // StopPVTButton
            // 
            this.StopPVTButton.Location = new System.Drawing.Point(40, 141);
            this.StopPVTButton.Margin = new System.Windows.Forms.Padding(2);
            this.StopPVTButton.Name = "StopPVTButton";
            this.StopPVTButton.Size = new System.Drawing.Size(180, 28);
            this.StopPVTButton.TabIndex = 7;
            this.StopPVTButton.Text = "Stop PVT";
            this.StopPVTButton.UseVisualStyleBackColor = true;
            this.StopPVTButton.Click += new System.EventHandler(this.StopPVTButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(40, 83);
            this.startButton.Margin = new System.Windows.Forms.Padding(2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(180, 28);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Start PVT Motion";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // HomeAxisButton
            // 
            this.HomeAxisButton.Location = new System.Drawing.Point(40, 26);
            this.HomeAxisButton.Margin = new System.Windows.Forms.Padding(2);
            this.HomeAxisButton.Name = "HomeAxisButton";
            this.HomeAxisButton.Size = new System.Drawing.Size(180, 28);
            this.HomeAxisButton.TabIndex = 5;
            this.HomeAxisButton.Text = "Home Axis";
            this.HomeAxisButton.UseVisualStyleBackColor = true;
            this.HomeAxisButton.Click += new System.EventHandler(this.HomeAxisButton_Click);
            // 
            // PVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 286);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberOfEventsTextBox);
            this.Controls.Add(this.StopPVTButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.HomeAxisButton);
            this.Name = "PVT";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PVT_FormClosed);
            this.Load += new System.EventHandler(this.PVT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberOfEventsTextBox;
        private System.Windows.Forms.Button StopPVTButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button HomeAxisButton;
    }
}

