namespace EX11_LSS
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BitRateTextBox = new System.Windows.Forms.TextBox();
            this.AssignIDsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Bit Rate: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "bits/sec";
            // 
            // BitRateTextBox
            // 
            this.BitRateTextBox.Location = new System.Drawing.Point(85, 27);
            this.BitRateTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.BitRateTextBox.Name = "BitRateTextBox";
            this.BitRateTextBox.Size = new System.Drawing.Size(76, 20);
            this.BitRateTextBox.TabIndex = 9;
            this.BitRateTextBox.Text = "1000000";
            this.BitRateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AssignIDsButton
            // 
            this.AssignIDsButton.Location = new System.Drawing.Point(73, 78);
            this.AssignIDsButton.Margin = new System.Windows.Forms.Padding(2);
            this.AssignIDsButton.Name = "AssignIDsButton";
            this.AssignIDsButton.Size = new System.Drawing.Size(104, 36);
            this.AssignIDsButton.TabIndex = 8;
            this.AssignIDsButton.Text = "Assign Node IDs";
            this.AssignIDsButton.UseVisualStyleBackColor = true;
            this.AssignIDsButton.Click += new System.EventHandler(this.AssignIDsButton_Click);
            // 
            // LSS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 148);
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

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BitRateTextBox;
        private System.Windows.Forms.Button AssignIDsButton;
    }
}

