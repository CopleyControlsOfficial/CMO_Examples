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
            this.HomeAxisButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.StopPVTButton = new System.Windows.Forms.Button();
            this.numberOfEventsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HomeAxisButton
            // 
            this.HomeAxisButton.Location = new System.Drawing.Point(86, 34);
            this.HomeAxisButton.Name = "HomeAxisButton";
            this.HomeAxisButton.Size = new System.Drawing.Size(276, 54);
            this.HomeAxisButton.TabIndex = 0;
            this.HomeAxisButton.Text = "Home Axis";
            this.HomeAxisButton.UseVisualStyleBackColor = true;
            this.HomeAxisButton.Click += new System.EventHandler(this.HomeAxisButton_Click);
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(86, 117);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(276, 54);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start PVT Motion";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // StopPVTButton
            // 
            this.StopPVTButton.Location = new System.Drawing.Point(86, 199);
            this.StopPVTButton.Name = "StopPVTButton";
            this.StopPVTButton.Size = new System.Drawing.Size(276, 54);
            this.StopPVTButton.TabIndex = 2;
            this.StopPVTButton.Text = "Stop PVT";
            this.StopPVTButton.UseVisualStyleBackColor = true;
            this.StopPVTButton.Click += new System.EventHandler(this.StopPVTButton_Click);
            // 
            // numberOfEventsTextBox
            // 
            this.numberOfEventsTextBox.Location = new System.Drawing.Point(263, 298);
            this.numberOfEventsTextBox.Name = "numberOfEventsTextBox";
            this.numberOfEventsTextBox.Size = new System.Drawing.Size(86, 22);
            this.numberOfEventsTextBox.TabIndex = 3;
            this.numberOfEventsTextBox.Text = "0";
            this.numberOfEventsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number of Events";
            // 
            // PVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 353);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberOfEventsTextBox);
            this.Controls.Add(this.StopPVTButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.HomeAxisButton);
            this.Name = "PVT";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HomeAxisButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button StopPVTButton;
        private System.Windows.Forms.TextBox numberOfEventsTextBox;
        private System.Windows.Forms.Label label1;
    }
}

