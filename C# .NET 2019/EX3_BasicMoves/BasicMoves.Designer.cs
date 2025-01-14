namespace EX3_BasicMoves
{
    partial class BasicMoves
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AccelerationLabel = new System.Windows.Forms.Label();
            this.velocityLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.posTextBox = new System.Windows.Forms.TextBox();
            this.DistanceTextBox = new System.Windows.Forms.TextBox();
            this.DecelTextBox = new System.Windows.Forms.TextBox();
            this.AccelTextBox = new System.Windows.Forms.TextBox();
            this.VelocityTextBox = new System.Windows.Forms.TextBox();
            this.haltMoveButton = new System.Windows.Forms.Button();
            this.doMoveButton = new System.Windows.Forms.Button();
            this.enableButton = new System.Windows.Forms.Button();
            this.HomeAxisButton = new System.Windows.Forms.Button();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(71, 216);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Actual Position";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 183);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Move Distance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 148);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Deceleration";
            // 
            // AccelerationLabel
            // 
            this.AccelerationLabel.AutoSize = true;
            this.AccelerationLabel.Location = new System.Drawing.Point(71, 114);
            this.AccelerationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AccelerationLabel.Name = "AccelerationLabel";
            this.AccelerationLabel.Size = new System.Drawing.Size(66, 13);
            this.AccelerationLabel.TabIndex = 34;
            this.AccelerationLabel.Text = "Acceleration";
            // 
            // velocityLabel
            // 
            this.velocityLabel.AutoSize = true;
            this.velocityLabel.Location = new System.Drawing.Point(71, 79);
            this.velocityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.velocityLabel.Name = "velocityLabel";
            this.velocityLabel.Size = new System.Drawing.Size(44, 13);
            this.velocityLabel.TabIndex = 33;
            this.velocityLabel.Text = "Velocity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 216);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "counts";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "counts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "counts/s^2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "counts/s^2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "counts/s";
            // 
            // posTextBox
            // 
            this.posTextBox.Location = new System.Drawing.Point(229, 214);
            this.posTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.posTextBox.Name = "posTextBox";
            this.posTextBox.ReadOnly = true;
            this.posTextBox.Size = new System.Drawing.Size(76, 20);
            this.posTextBox.TabIndex = 27;
            this.posTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DistanceTextBox
            // 
            this.DistanceTextBox.Location = new System.Drawing.Point(229, 181);
            this.DistanceTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.DistanceTextBox.Name = "DistanceTextBox";
            this.DistanceTextBox.Size = new System.Drawing.Size(76, 20);
            this.DistanceTextBox.TabIndex = 26;
            this.DistanceTextBox.Text = "1000";
            this.DistanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DecelTextBox
            // 
            this.DecelTextBox.Location = new System.Drawing.Point(229, 145);
            this.DecelTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.DecelTextBox.Name = "DecelTextBox";
            this.DecelTextBox.Size = new System.Drawing.Size(76, 20);
            this.DecelTextBox.TabIndex = 25;
            this.DecelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AccelTextBox
            // 
            this.AccelTextBox.Location = new System.Drawing.Point(229, 111);
            this.AccelTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.AccelTextBox.Name = "AccelTextBox";
            this.AccelTextBox.Size = new System.Drawing.Size(76, 20);
            this.AccelTextBox.TabIndex = 24;
            this.AccelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // VelocityTextBox
            // 
            this.VelocityTextBox.Location = new System.Drawing.Point(229, 76);
            this.VelocityTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.VelocityTextBox.Name = "VelocityTextBox";
            this.VelocityTextBox.Size = new System.Drawing.Size(76, 20);
            this.VelocityTextBox.TabIndex = 23;
            this.VelocityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // haltMoveButton
            // 
            this.haltMoveButton.Location = new System.Drawing.Point(257, 248);
            this.haltMoveButton.Margin = new System.Windows.Forms.Padding(2);
            this.haltMoveButton.Name = "haltMoveButton";
            this.haltMoveButton.Size = new System.Drawing.Size(85, 26);
            this.haltMoveButton.TabIndex = 22;
            this.haltMoveButton.Text = "Halt Move";
            this.haltMoveButton.UseVisualStyleBackColor = true;
            this.haltMoveButton.Click += new System.EventHandler(this.haltMoveButton_Click);
            // 
            // doMoveButton
            // 
            this.doMoveButton.Location = new System.Drawing.Point(151, 248);
            this.doMoveButton.Margin = new System.Windows.Forms.Padding(2);
            this.doMoveButton.Name = "doMoveButton";
            this.doMoveButton.Size = new System.Drawing.Size(85, 26);
            this.doMoveButton.TabIndex = 21;
            this.doMoveButton.Text = "Do Move";
            this.doMoveButton.UseVisualStyleBackColor = true;
            this.doMoveButton.Click += new System.EventHandler(this.doMoveButton_Click);
            // 
            // enableButton
            // 
            this.enableButton.Location = new System.Drawing.Point(51, 248);
            this.enableButton.Margin = new System.Windows.Forms.Padding(2);
            this.enableButton.Name = "enableButton";
            this.enableButton.Size = new System.Drawing.Size(85, 26);
            this.enableButton.TabIndex = 20;
            this.enableButton.Text = "Amp Disable";
            this.enableButton.UseVisualStyleBackColor = true;
            this.enableButton.Click += new System.EventHandler(this.enableButton_Click);
            // 
            // HomeAxisButton
            // 
            this.HomeAxisButton.Location = new System.Drawing.Point(95, 32);
            this.HomeAxisButton.Margin = new System.Windows.Forms.Padding(2);
            this.HomeAxisButton.Name = "HomeAxisButton";
            this.HomeAxisButton.Size = new System.Drawing.Size(226, 28);
            this.HomeAxisButton.TabIndex = 19;
            this.HomeAxisButton.Text = "Home Axis";
            this.HomeAxisButton.UseVisualStyleBackColor = true;
            this.HomeAxisButton.Click += new System.EventHandler(this.HomeAxisButton_Click);
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // BasicMoves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 354);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AccelerationLabel);
            this.Controls.Add(this.velocityLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.posTextBox);
            this.Controls.Add(this.DistanceTextBox);
            this.Controls.Add(this.DecelTextBox);
            this.Controls.Add(this.AccelTextBox);
            this.Controls.Add(this.VelocityTextBox);
            this.Controls.Add(this.haltMoveButton);
            this.Controls.Add(this.doMoveButton);
            this.Controls.Add(this.enableButton);
            this.Controls.Add(this.HomeAxisButton);
            this.Name = "BasicMoves";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BasicMoves_FormClosing);
            this.Load += new System.EventHandler(this.BasicMoves_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label AccelerationLabel;
        private System.Windows.Forms.Label velocityLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox posTextBox;
        private System.Windows.Forms.TextBox DistanceTextBox;
        private System.Windows.Forms.TextBox DecelTextBox;
        private System.Windows.Forms.TextBox AccelTextBox;
        private System.Windows.Forms.TextBox VelocityTextBox;
        private System.Windows.Forms.Button haltMoveButton;
        private System.Windows.Forms.Button doMoveButton;
        private System.Windows.Forms.Button enableButton;
        private System.Windows.Forms.Button HomeAxisButton;
        private System.Windows.Forms.Timer Timer1;
    }
}

