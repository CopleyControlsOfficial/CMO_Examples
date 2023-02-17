namespace EX12_PositionTriggeredOutput
{
    partial class PositionTriggeredOutput
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
            this.HardwarePositionTriggeredOutputButton = new System.Windows.Forms.Button();
            this.SoftwarePositionTriggeredOutputButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HardwarePositionTriggeredOutputButton
            // 
            this.HardwarePositionTriggeredOutputButton.BackColor = System.Drawing.Color.LawnGreen;
            this.HardwarePositionTriggeredOutputButton.Location = new System.Drawing.Point(51, 38);
            this.HardwarePositionTriggeredOutputButton.Name = "HardwarePositionTriggeredOutputButton";
            this.HardwarePositionTriggeredOutputButton.Size = new System.Drawing.Size(75, 81);
            this.HardwarePositionTriggeredOutputButton.TabIndex = 0;
            this.HardwarePositionTriggeredOutputButton.Text = "Configure Hardware Position Triggered Output";
            this.HardwarePositionTriggeredOutputButton.UseVisualStyleBackColor = false;
            this.HardwarePositionTriggeredOutputButton.Click += new System.EventHandler(this.HardwarePositionTriggeredOutputButton_Click);
            // 
            // SoftwarePositionTriggeredOutputButton
            // 
            this.SoftwarePositionTriggeredOutputButton.BackColor = System.Drawing.Color.LawnGreen;
            this.SoftwarePositionTriggeredOutputButton.Location = new System.Drawing.Point(132, 38);
            this.SoftwarePositionTriggeredOutputButton.Name = "SoftwarePositionTriggeredOutputButton";
            this.SoftwarePositionTriggeredOutputButton.Size = new System.Drawing.Size(75, 81);
            this.SoftwarePositionTriggeredOutputButton.TabIndex = 1;
            this.SoftwarePositionTriggeredOutputButton.Text = "Configure Software Position Triggered Output";
            this.SoftwarePositionTriggeredOutputButton.UseVisualStyleBackColor = false;
            this.SoftwarePositionTriggeredOutputButton.Click += new System.EventHandler(this.SoftwarePositionTriggeredOutputButton_Click);
            // 
            // PositionTriggeredOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 165);
            this.Controls.Add(this.SoftwarePositionTriggeredOutputButton);
            this.Controls.Add(this.HardwarePositionTriggeredOutputButton);
            this.Name = "PositionTriggeredOutput";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PositionTriggeredOutput_FormClosed);
            this.Load += new System.EventHandler(this.PositionTriggeredOutput_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HardwarePositionTriggeredOutputButton;
        private System.Windows.Forms.Button SoftwarePositionTriggeredOutputButton;
    }
}

