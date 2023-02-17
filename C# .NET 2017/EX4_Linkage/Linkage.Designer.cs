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
            this.HomeAxisButton = new System.Windows.Forms.Button();
            this.linkageMoveButton = new System.Windows.Forms.Button();
            this.xAxisTextBox = new System.Windows.Forms.TextBox();
            this.yAxisTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HomeAxisButton
            // 
            this.HomeAxisButton.Location = new System.Drawing.Point(85, 21);
            this.HomeAxisButton.Name = "HomeAxisButton";
            this.HomeAxisButton.Size = new System.Drawing.Size(267, 42);
            this.HomeAxisButton.TabIndex = 0;
            this.HomeAxisButton.Text = "Home Axis";
            this.HomeAxisButton.UseVisualStyleBackColor = true;
            this.HomeAxisButton.Click += new System.EventHandler(this.HomeAxisButton_Click);
            // 
            // linkageMoveButton
            // 
            this.linkageMoveButton.Location = new System.Drawing.Point(85, 80);
            this.linkageMoveButton.Name = "linkageMoveButton";
            this.linkageMoveButton.Size = new System.Drawing.Size(267, 42);
            this.linkageMoveButton.TabIndex = 1;
            this.linkageMoveButton.Text = "Perform Linkage Move";
            this.linkageMoveButton.UseVisualStyleBackColor = true;
            this.linkageMoveButton.Click += new System.EventHandler(this.linkageMoveButton_Click);
            // 
            // xAxisTextBox
            // 
            this.xAxisTextBox.Location = new System.Drawing.Point(236, 156);
            this.xAxisTextBox.Name = "xAxisTextBox";
            this.xAxisTextBox.Size = new System.Drawing.Size(116, 22);
            this.xAxisTextBox.TabIndex = 2;
            this.xAxisTextBox.Text = "20000";
            // 
            // yAxisTextBox
            // 
            this.yAxisTextBox.Location = new System.Drawing.Point(236, 193);
            this.yAxisTextBox.Name = "yAxisTextBox";
            this.yAxisTextBox.Size = new System.Drawing.Size(116, 22);
            this.yAxisTextBox.TabIndex = 3;
            this.yAxisTextBox.Text = "10000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "X Axis Move to Position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Y Axis Move to Position";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "counts";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(358, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "counts";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 254);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yAxisTextBox);
            this.Controls.Add(this.xAxisTextBox);
            this.Controls.Add(this.linkageMoveButton);
            this.Controls.Add(this.HomeAxisButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HomeAxisButton;
        private System.Windows.Forms.Button linkageMoveButton;
        private System.Windows.Forms.TextBox xAxisTextBox;
        private System.Windows.Forms.TextBox yAxisTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

