namespace EX4_Linkage
{
    partial class Linkage
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.yAxisTextBox = new System.Windows.Forms.TextBox();
            this.xAxisTextBox = new System.Windows.Forms.TextBox();
            this.linkageMoveButton = new System.Windows.Forms.Button();
            this.HomeAxisButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "counts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "counts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Y Axis Move to Position";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "X Axis Move to Position";
            // 
            // yAxisTextBox
            // 
            this.yAxisTextBox.Location = new System.Drawing.Point(177, 168);
            this.yAxisTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.yAxisTextBox.Name = "yAxisTextBox";
            this.yAxisTextBox.Size = new System.Drawing.Size(86, 20);
            this.yAxisTextBox.TabIndex = 11;
            this.yAxisTextBox.Text = "10000";
            // 
            // xAxisTextBox
            // 
            this.xAxisTextBox.Location = new System.Drawing.Point(177, 138);
            this.xAxisTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.xAxisTextBox.Name = "xAxisTextBox";
            this.xAxisTextBox.Size = new System.Drawing.Size(86, 20);
            this.xAxisTextBox.TabIndex = 10;
            this.xAxisTextBox.Text = "20000";
            // 
            // linkageMoveButton
            // 
            this.linkageMoveButton.Location = new System.Drawing.Point(76, 81);
            this.linkageMoveButton.Margin = new System.Windows.Forms.Padding(2);
            this.linkageMoveButton.Name = "linkageMoveButton";
            this.linkageMoveButton.Size = new System.Drawing.Size(158, 32);
            this.linkageMoveButton.TabIndex = 9;
            this.linkageMoveButton.Text = "Perform Linkage Move";
            this.linkageMoveButton.UseVisualStyleBackColor = true;
            this.linkageMoveButton.Click += new System.EventHandler(this.linkageMoveButton_Click);
            // 
            // HomeAxisButton
            // 
            this.HomeAxisButton.Location = new System.Drawing.Point(76, 31);
            this.HomeAxisButton.Margin = new System.Windows.Forms.Padding(2);
            this.HomeAxisButton.Name = "HomeAxisButton";
            this.HomeAxisButton.Size = new System.Drawing.Size(158, 32);
            this.HomeAxisButton.TabIndex = 8;
            this.HomeAxisButton.Text = "Home Axis";
            this.HomeAxisButton.UseVisualStyleBackColor = true;
            this.HomeAxisButton.Click += new System.EventHandler(this.HomeAxisButton_Click);
            // 
            // Linkage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 247);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yAxisTextBox);
            this.Controls.Add(this.xAxisTextBox);
            this.Controls.Add(this.linkageMoveButton);
            this.Controls.Add(this.HomeAxisButton);
            this.Name = "Linkage";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Linkage_FormClosed);
            this.Load += new System.EventHandler(this.Linkage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox yAxisTextBox;
        private System.Windows.Forms.TextBox xAxisTextBox;
        private System.Windows.Forms.Button linkageMoveButton;
        private System.Windows.Forms.Button HomeAxisButton;
    }
}

