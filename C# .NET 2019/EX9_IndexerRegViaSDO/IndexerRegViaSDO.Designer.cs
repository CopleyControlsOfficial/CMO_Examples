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
            this.label1 = new System.Windows.Forms.Label();
            this.txtRegisterNumber = new System.Windows.Forms.TextBox();
            this.txtReadData = new System.Windows.Forms.TextBox();
            this.txtWriteData = new System.Windows.Forms.TextBox();
            this.cmdRead = new System.Windows.Forms.Button();
            this.cmdWrite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Register Number";
            // 
            // txtRegisterNumber
            // 
            this.txtRegisterNumber.Location = new System.Drawing.Point(125, 15);
            this.txtRegisterNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegisterNumber.Name = "txtRegisterNumber";
            this.txtRegisterNumber.Size = new System.Drawing.Size(36, 20);
            this.txtRegisterNumber.TabIndex = 10;
            this.txtRegisterNumber.Text = "0";
            this.txtRegisterNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtReadData
            // 
            this.txtReadData.Location = new System.Drawing.Point(125, 88);
            this.txtReadData.Margin = new System.Windows.Forms.Padding(2);
            this.txtReadData.Name = "txtReadData";
            this.txtReadData.Size = new System.Drawing.Size(76, 20);
            this.txtReadData.TabIndex = 9;
            this.txtReadData.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtWriteData
            // 
            this.txtWriteData.Location = new System.Drawing.Point(125, 57);
            this.txtWriteData.Margin = new System.Windows.Forms.Padding(2);
            this.txtWriteData.Name = "txtWriteData";
            this.txtWriteData.Size = new System.Drawing.Size(76, 20);
            this.txtWriteData.TabIndex = 8;
            this.txtWriteData.Text = "0";
            this.txtWriteData.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmdRead
            // 
            this.cmdRead.Location = new System.Drawing.Point(25, 84);
            this.cmdRead.Margin = new System.Windows.Forms.Padding(2);
            this.cmdRead.Name = "cmdRead";
            this.cmdRead.Size = new System.Drawing.Size(94, 26);
            this.cmdRead.TabIndex = 7;
            this.cmdRead.Text = "Read Register";
            this.cmdRead.UseVisualStyleBackColor = true;
            this.cmdRead.Click += new System.EventHandler(this.cmdRead_Click);
            // 
            // cmdWrite
            // 
            this.cmdWrite.Location = new System.Drawing.Point(25, 53);
            this.cmdWrite.Margin = new System.Windows.Forms.Padding(2);
            this.cmdWrite.Name = "cmdWrite";
            this.cmdWrite.Size = new System.Drawing.Size(94, 26);
            this.cmdWrite.TabIndex = 6;
            this.cmdWrite.Text = "Write Register";
            this.cmdWrite.UseVisualStyleBackColor = true;
            this.cmdWrite.Click += new System.EventHandler(this.cmdWrite_Click);
            // 
            // IndexerRegViaSDO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 143);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRegisterNumber);
            this.Controls.Add(this.txtReadData);
            this.Controls.Add(this.txtWriteData);
            this.Controls.Add(this.cmdRead);
            this.Controls.Add(this.cmdWrite);
            this.Name = "IndexerRegViaSDO";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.IndexerRegViaSDO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRegisterNumber;
        private System.Windows.Forms.TextBox txtReadData;
        private System.Windows.Forms.TextBox txtWriteData;
        private System.Windows.Forms.Button cmdRead;
        private System.Windows.Forms.Button cmdWrite;
    }
}

