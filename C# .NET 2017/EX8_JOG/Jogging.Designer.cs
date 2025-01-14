namespace EX8_JOG
{
    partial class Jogging
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
            this.JogNegButton = new System.Windows.Forms.Button();
            this.JogPosButton = new System.Windows.Forms.Button();
            this.VelocityTextBox = new System.Windows.Forms.TextBox();
            this.AccelTextBox = new System.Windows.Forms.TextBox();
            this.DecelTextBox = new System.Windows.Forms.TextBox();
            this.VelocityLabel = new System.Windows.Forms.Label();
            this.AccelLabel = new System.Windows.Forms.Label();
            this.DecelLabel = new System.Windows.Forms.Label();
            this.ActPosLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ActPosVar = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // JogNegButton
            // 
            this.JogNegButton.Location = new System.Drawing.Point(37, 261);
            this.JogNegButton.Name = "JogNegButton";
            this.JogNegButton.Size = new System.Drawing.Size(90, 32);
            this.JogNegButton.TabIndex = 0;
            this.JogNegButton.Text = "Jog Neg";
            this.JogNegButton.UseVisualStyleBackColor = true;
            this.JogNegButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.JogNegButton_MouseDown);
            this.JogNegButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.JogNegButton_MouseUp);
            // 
            // JogPosButton
            // 
            this.JogPosButton.Location = new System.Drawing.Point(184, 261);
            this.JogPosButton.Name = "JogPosButton";
            this.JogPosButton.Size = new System.Drawing.Size(90, 32);
            this.JogPosButton.TabIndex = 1;
            this.JogPosButton.Text = "Jog Pos";
            this.JogPosButton.UseVisualStyleBackColor = true;
            this.JogPosButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.JogPosButton_MouseDown);
            this.JogPosButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.JogPosButton_MouseUp);
            // 
            // VelocityTextBox
            // 
            this.VelocityTextBox.Location = new System.Drawing.Point(127, 34);
            this.VelocityTextBox.Name = "VelocityTextBox";
            this.VelocityTextBox.Size = new System.Drawing.Size(100, 22);
            this.VelocityTextBox.TabIndex = 2;
            // 
            // AccelTextBox
            // 
            this.AccelTextBox.Location = new System.Drawing.Point(127, 82);
            this.AccelTextBox.Name = "AccelTextBox";
            this.AccelTextBox.Size = new System.Drawing.Size(100, 22);
            this.AccelTextBox.TabIndex = 3;
            // 
            // DecelTextBox
            // 
            this.DecelTextBox.Location = new System.Drawing.Point(127, 136);
            this.DecelTextBox.Name = "DecelTextBox";
            this.DecelTextBox.Size = new System.Drawing.Size(100, 22);
            this.DecelTextBox.TabIndex = 4;
            // 
            // VelocityLabel
            // 
            this.VelocityLabel.AutoSize = true;
            this.VelocityLabel.Location = new System.Drawing.Point(21, 34);
            this.VelocityLabel.Name = "VelocityLabel";
            this.VelocityLabel.Size = new System.Drawing.Size(61, 17);
            this.VelocityLabel.TabIndex = 5;
            this.VelocityLabel.Text = "Velocity:";
            // 
            // AccelLabel
            // 
            this.AccelLabel.AutoSize = true;
            this.AccelLabel.Location = new System.Drawing.Point(21, 85);
            this.AccelLabel.Name = "AccelLabel";
            this.AccelLabel.Size = new System.Drawing.Size(90, 17);
            this.AccelLabel.TabIndex = 6;
            this.AccelLabel.Text = "Acceleration:";
            // 
            // DecelLabel
            // 
            this.DecelLabel.AutoSize = true;
            this.DecelLabel.Location = new System.Drawing.Point(21, 136);
            this.DecelLabel.Name = "DecelLabel";
            this.DecelLabel.Size = new System.Drawing.Size(92, 17);
            this.DecelLabel.TabIndex = 7;
            this.DecelLabel.Text = "Deceleration:";
            // 
            // ActPosLabel
            // 
            this.ActPosLabel.AutoSize = true;
            this.ActPosLabel.Location = new System.Drawing.Point(21, 204);
            this.ActPosLabel.Name = "ActPosLabel";
            this.ActPosLabel.Size = new System.Drawing.Size(101, 17);
            this.ActPosLabel.TabIndex = 8;
            this.ActPosLabel.Text = "Actual Position";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "counts/s";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "counts/s^2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "counts/s^2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "counts";
            // 
            // ActPosVar
            // 
            this.ActPosVar.AutoSize = true;
            this.ActPosVar.Location = new System.Drawing.Point(128, 204);
            this.ActPosVar.Name = "ActPosVar";
            this.ActPosVar.Size = new System.Drawing.Size(72, 17);
            this.ActPosVar.TabIndex = 13;
            this.ActPosVar.Text = "                ";
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Jogging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 326);
            this.Controls.Add(this.ActPosVar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ActPosLabel);
            this.Controls.Add(this.DecelLabel);
            this.Controls.Add(this.AccelLabel);
            this.Controls.Add(this.VelocityLabel);
            this.Controls.Add(this.DecelTextBox);
            this.Controls.Add(this.AccelTextBox);
            this.Controls.Add(this.VelocityTextBox);
            this.Controls.Add(this.JogPosButton);
            this.Controls.Add(this.JogNegButton);
            this.Name = "Jogging";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Jogging_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button JogNegButton;
        private System.Windows.Forms.Button JogPosButton;
        private System.Windows.Forms.TextBox VelocityTextBox;
        private System.Windows.Forms.TextBox AccelTextBox;
        private System.Windows.Forms.TextBox DecelTextBox;
        private System.Windows.Forms.Label VelocityLabel;
        private System.Windows.Forms.Label AccelLabel;
        private System.Windows.Forms.Label DecelLabel;
        private System.Windows.Forms.Label ActPosLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ActPosVar;
        private System.Windows.Forms.Timer Timer1;
    }
}

