namespace PvtConstAccelTrj
{
    partial class PvtConstAccelTrj
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
            this.StartPvtMoveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartPvtMoveButton
            // 
            this.StartPvtMoveButton.Location = new System.Drawing.Point(21, 23);
            this.StartPvtMoveButton.Name = "StartPvtMoveButton";
            this.StartPvtMoveButton.Size = new System.Drawing.Size(105, 36);
            this.StartPvtMoveButton.TabIndex = 0;
            this.StartPvtMoveButton.Text = "Start PVT Move";
            this.StartPvtMoveButton.UseVisualStyleBackColor = true;
            this.StartPvtMoveButton.Click += new System.EventHandler(this.StartPvtMoveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StartPvtMoveButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PvtConstAccelTrj_FormClosing);
            this.Load += new System.EventHandler(this.PvtConstAccelTrj_Load);
        }

        #endregion

        private System.Windows.Forms.Button StartPvtMoveButton;
    }
}

