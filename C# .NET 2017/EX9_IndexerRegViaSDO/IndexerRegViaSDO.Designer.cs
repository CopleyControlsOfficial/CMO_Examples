namespace EX9_IndexerRegViaSDO
{
    partial class IndexerRegViaSDO
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
            this.cmdWrite = new System.Windows.Forms.Button();
            this.cmdRead = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRegisterNumber = new System.Windows.Forms.TextBox();
            this.txtWriteData = new System.Windows.Forms.TextBox();
            this.txtReadData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdWrite
            // 
            this.cmdWrite.Location = new System.Drawing.Point(38, 72);
            this.cmdWrite.Name = "cmdWrite";
            this.cmdWrite.Size = new System.Drawing.Size(141, 29);
            this.cmdWrite.TabIndex = 0;
            this.cmdWrite.Text = "Write Register";
            this.cmdWrite.UseVisualStyleBackColor = true;
            this.cmdWrite.Click += new System.EventHandler(this.cmdWrite_Click);
            // 
            // cmdRead
            // 
            this.cmdRead.Location = new System.Drawing.Point(38, 119);
            this.cmdRead.Name = "cmdRead";
            this.cmdRead.Size = new System.Drawing.Size(141, 29);
            this.cmdRead.TabIndex = 1;
            this.cmdRead.Text = "Read Register";
            this.cmdRead.UseVisualStyleBackColor = true;
            this.cmdRead.Click += new System.EventHandler(this.cmdRead_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Register Number";
            // 
            // txtRegisterNumber
            // 
            this.txtRegisterNumber.Location = new System.Drawing.Point(213, 28);
            this.txtRegisterNumber.Name = "txtRegisterNumber";
            this.txtRegisterNumber.Size = new System.Drawing.Size(40, 22);
            this.txtRegisterNumber.TabIndex = 3;
            this.txtRegisterNumber.Text = "0";
            this.txtRegisterNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtWriteData
            // 
            this.txtWriteData.Location = new System.Drawing.Point(213, 75);
            this.txtWriteData.Name = "txtWriteData";
            this.txtWriteData.Size = new System.Drawing.Size(100, 22);
            this.txtWriteData.TabIndex = 4;
            this.txtWriteData.Text = "0";
            this.txtWriteData.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtReadData
            // 
            this.txtReadData.Location = new System.Drawing.Point(213, 122);
            this.txtReadData.Name = "txtReadData";
            this.txtReadData.Size = new System.Drawing.Size(100, 22);
            this.txtReadData.TabIndex = 5;
            this.txtReadData.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // IndexerRegViaSDO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 175);
            this.Controls.Add(this.txtReadData);
            this.Controls.Add(this.txtWriteData);
            this.Controls.Add(this.txtRegisterNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdRead);
            this.Controls.Add(this.cmdWrite);
            this.Name = "IndexerRegViaSDO";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.IndexerRegViaSDO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdWrite;
        private System.Windows.Forms.Button cmdRead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRegisterNumber;
        private System.Windows.Forms.TextBox txtWriteData;
        private System.Windows.Forms.TextBox txtReadData;
    }
}

