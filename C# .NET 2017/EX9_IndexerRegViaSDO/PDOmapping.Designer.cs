namespace EX11_PDOMapping
{
    partial class PDOmapping
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
            this.SendOffsetButton = new System.Windows.Forms.Button();
            this.SaveMappingToFlashButton = new System.Windows.Forms.Button();
            this.PositionTextBox = new System.Windows.Forms.TextBox();
            this.AlogRefTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SendOffsetButton
            // 
            this.SendOffsetButton.Location = new System.Drawing.Point(83, 40);
            this.SendOffsetButton.Name = "SendOffsetButton";
            this.SendOffsetButton.Size = new System.Drawing.Size(115, 33);
            this.SendOffsetButton.TabIndex = 0;
            this.SendOffsetButton.Text = "Send Data";
            this.SendOffsetButton.UseVisualStyleBackColor = true;
            this.SendOffsetButton.Click += new System.EventHandler(this.SendOffsetButton_Click);
            // 
            // SaveMappingToFlashButton
            // 
            this.SaveMappingToFlashButton.Location = new System.Drawing.Point(83, 181);
            this.SaveMappingToFlashButton.Name = "SaveMappingToFlashButton";
            this.SaveMappingToFlashButton.Size = new System.Drawing.Size(115, 33);
            this.SaveMappingToFlashButton.TabIndex = 1;
            this.SaveMappingToFlashButton.Text = "Save Mapping";
            this.SaveMappingToFlashButton.UseVisualStyleBackColor = true;
            this.SaveMappingToFlashButton.Click += new System.EventHandler(this.SaveMappingToFlashButton_Click);
            // 
            // PositionTextBox
            // 
            this.PositionTextBox.Location = new System.Drawing.Point(83, 100);
            this.PositionTextBox.Name = "PositionTextBox";
            this.PositionTextBox.Size = new System.Drawing.Size(115, 22);
            this.PositionTextBox.TabIndex = 2;
            // 
            // AlogRefTextBox
            // 
            this.AlogRefTextBox.Location = new System.Drawing.Point(83, 140);
            this.AlogRefTextBox.Name = "AlogRefTextBox";
            this.AlogRefTextBox.Size = new System.Drawing.Size(115, 22);
            this.AlogRefTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Position: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Offset: ";
            // 
            // PDOmapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AlogRefTextBox);
            this.Controls.Add(this.PositionTextBox);
            this.Controls.Add(this.SaveMappingToFlashButton);
            this.Controls.Add(this.SendOffsetButton);
            this.Name = "PDOmapping";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PDOmapping_FormClosing);
            this.Load += new System.EventHandler(this.PDOmapping_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendOffsetButton;
        private System.Windows.Forms.Button SaveMappingToFlashButton;
        private System.Windows.Forms.TextBox PositionTextBox;
        private System.Windows.Forms.TextBox AlogRefTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

