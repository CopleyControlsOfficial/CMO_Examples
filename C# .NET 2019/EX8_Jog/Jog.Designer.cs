namespace EX8_Jog
{
    partial class Jog
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
            this.components = new System.ComponentModel.Container();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.ActPosVar = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DecelTextBox = new System.Windows.Forms.TextBox();
            this.AccelTextBox = new System.Windows.Forms.TextBox();
            this.VelocityTextBox = new System.Windows.Forms.TextBox();
            this.JogPosButton = new System.Windows.Forms.Button();
            this.JogNegButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(220, 149);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "counts";
            // 
            // ActPosVar
            // 
            this.ActPosVar.AutoSize = true;
            this.ActPosVar.Location = new System.Drawing.Point(150, 149);
            this.ActPosVar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ActPosVar.Name = "ActPosVar";
            this.ActPosVar.Size = new System.Drawing.Size(52, 13);
            this.ActPosVar.TabIndex = 26;
            this.ActPosVar.Text = "               ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 149);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Actual Position:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 104);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Deceleration:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 67);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Acceleration:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Velocity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "counts/s^2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "counts/s^2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "counts/s";
            // 
            // DecelTextBox
            // 
            this.DecelTextBox.Location = new System.Drawing.Point(152, 102);
            this.DecelTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.DecelTextBox.Name = "DecelTextBox";
            this.DecelTextBox.Size = new System.Drawing.Size(92, 20);
            this.DecelTextBox.TabIndex = 18;
            // 
            // AccelTextBox
            // 
            this.AccelTextBox.Location = new System.Drawing.Point(152, 64);
            this.AccelTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.AccelTextBox.Name = "AccelTextBox";
            this.AccelTextBox.Size = new System.Drawing.Size(92, 20);
            this.AccelTextBox.TabIndex = 17;
            // 
            // VelocityTextBox
            // 
            this.VelocityTextBox.Location = new System.Drawing.Point(152, 25);
            this.VelocityTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.VelocityTextBox.Name = "VelocityTextBox";
            this.VelocityTextBox.Size = new System.Drawing.Size(92, 20);
            this.VelocityTextBox.TabIndex = 16;
            // 
            // JogPosButton
            // 
            this.JogPosButton.Location = new System.Drawing.Point(195, 190);
            this.JogPosButton.Margin = new System.Windows.Forms.Padding(2);
            this.JogPosButton.Name = "JogPosButton";
            this.JogPosButton.Size = new System.Drawing.Size(62, 27);
            this.JogPosButton.TabIndex = 15;
            this.JogPosButton.Text = "Jog Pos";
            this.JogPosButton.UseVisualStyleBackColor = true;
            this.JogPosButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.JogPosButton_MouseDown);
            this.JogPosButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.JogPosButton_MouseUp);            
            // 
            // JogNegButton
            // 
            this.JogNegButton.Location = new System.Drawing.Point(69, 190);
            this.JogNegButton.Margin = new System.Windows.Forms.Padding(2);
            this.JogNegButton.Name = "JogNegButton";
            this.JogNegButton.Size = new System.Drawing.Size(62, 27);
            this.JogNegButton.TabIndex = 14;
            this.JogNegButton.Text = "Jog Neg";
            this.JogNegButton.UseVisualStyleBackColor = true;
            this.JogNegButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.JogNegButton_MouseDown);
            this.JogNegButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.JogNegButton_MouseUp);            
            // 
            // Jog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 257);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ActPosVar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DecelTextBox);
            this.Controls.Add(this.AccelTextBox);
            this.Controls.Add(this.VelocityTextBox);
            this.Controls.Add(this.JogPosButton);
            this.Controls.Add(this.JogNegButton);
            this.Name = "Jog";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Jog_FormClosing);
            this.Load += new System.EventHandler(this.Jog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label ActPosVar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DecelTextBox;
        private System.Windows.Forms.TextBox AccelTextBox;
        private System.Windows.Forms.TextBox VelocityTextBox;
        private System.Windows.Forms.Button JogPosButton;
        private System.Windows.Forms.Button JogNegButton;
    }
}

