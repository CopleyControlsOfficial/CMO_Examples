namespace EX12_LSS
{
    partial class LSS
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
            this.AssignIDsButton = new System.Windows.Forms.Button();
            this.BitRateTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AssignIDsButton
            // 
            this.AssignIDsButton.Location = new System.Drawing.Point(56, 164);
            this.AssignIDsButton.Name = "AssignIDsButton";
            this.AssignIDsButton.Size = new System.Drawing.Size(149, 40);
            this.AssignIDsButton.TabIndex = 0;
            this.AssignIDsButton.Text = "Assign Node IDs";
            this.AssignIDsButton.UseVisualStyleBackColor = true;
            this.AssignIDsButton.Click += new System.EventHandler(this.AssignIDsButton_Click);
            // 
            // BitRateTextBox
            // 
            this.BitRateTextBox.Location = new System.Drawing.Point(87, 84);
            this.BitRateTextBox.Name = "BitRateTextBox";
            this.BitRateTextBox.Size = new System.Drawing.Size(100, 22);
            this.BitRateTextBox.TabIndex = 1;
            this.BitRateTextBox.Text = "1000000";
            this.BitRateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "bits/sec";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bit Rate: ";
            // 
            // LSS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BitRateTextBox);
            this.Controls.Add(this.AssignIDsButton);
            this.Name = "LSS";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LSS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AssignIDsButton;
        private System.Windows.Forms.TextBox BitRateTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

