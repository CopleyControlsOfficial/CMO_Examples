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
            this.HomeAxisButton = new System.Windows.Forms.Button();
            this.enableButton = new System.Windows.Forms.Button();
            this.doMoveButton = new System.Windows.Forms.Button();
            this.haltMoveButton = new System.Windows.Forms.Button();
            this.VelocityTextBox = new System.Windows.Forms.TextBox();
            this.AccelTextBox = new System.Windows.Forms.TextBox();
            this.DecelTextBox = new System.Windows.Forms.TextBox();
            this.DistanceTextBox = new System.Windows.Forms.TextBox();
            this.posTextBox = new System.Windows.Forms.TextBox();
            this.velocityLabel = new System.Windows.Forms.Label();
            this.AccelerationLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // HomeAxisButton
            // 
            this.HomeAxisButton.Location = new System.Drawing.Point(64, 12);
            this.HomeAxisButton.Name = "HomeAxisButton";
            this.HomeAxisButton.Size = new System.Drawing.Size(255, 42);
            this.HomeAxisButton.TabIndex = 0;
            this.HomeAxisButton.Text = "Home Axis";
            this.HomeAxisButton.UseVisualStyleBackColor = true;
            this.HomeAxisButton.Click += new System.EventHandler(this.HomeAxisButton_Click);
            // 
            // enableButton
            // 
            this.enableButton.Location = new System.Drawing.Point(21, 283);
            this.enableButton.Name = "enableButton";
            this.enableButton.Size = new System.Drawing.Size(109, 32);
            this.enableButton.TabIndex = 1;
            this.enableButton.Text = "Amp Disable";
            this.enableButton.UseVisualStyleBackColor = true;
            this.enableButton.Click += new System.EventHandler(this.enableButton_Click);
            // 
            // doMoveButton
            // 
            this.doMoveButton.Location = new System.Drawing.Point(145, 283);
            this.doMoveButton.Name = "doMoveButton";
            this.doMoveButton.Size = new System.Drawing.Size(110, 32);
            this.doMoveButton.TabIndex = 2;
            this.doMoveButton.Text = "Do Move";
            this.doMoveButton.UseVisualStyleBackColor = true;
            this.doMoveButton.Click += new System.EventHandler(this.doMoveButton_Click);
            // 
            // haltMoveButton
            // 
            this.haltMoveButton.Location = new System.Drawing.Point(280, 283);
            this.haltMoveButton.Name = "haltMoveButton";
            this.haltMoveButton.Size = new System.Drawing.Size(97, 32);
            this.haltMoveButton.TabIndex = 3;
            this.haltMoveButton.Text = "Halt Move";
            this.haltMoveButton.UseVisualStyleBackColor = true;
            this.haltMoveButton.Click += new System.EventHandler(this.haltMoveButton_Click);
            // 
            // VelocityTextBox
            // 
            this.VelocityTextBox.Location = new System.Drawing.Point(190, 71);
            this.VelocityTextBox.Name = "VelocityTextBox";
            this.VelocityTextBox.Size = new System.Drawing.Size(100, 22);
            this.VelocityTextBox.TabIndex = 4;
            // 
            // AccelTextBox
            // 
            this.AccelTextBox.Location = new System.Drawing.Point(190, 109);
            this.AccelTextBox.Name = "AccelTextBox";
            this.AccelTextBox.Size = new System.Drawing.Size(100, 22);
            this.AccelTextBox.TabIndex = 5;
            // 
            // DecelTextBox
            // 
            this.DecelTextBox.Location = new System.Drawing.Point(190, 151);
            this.DecelTextBox.Name = "DecelTextBox";
            this.DecelTextBox.Size = new System.Drawing.Size(100, 22);
            this.DecelTextBox.TabIndex = 6;
            // 
            // DistanceTextBox
            // 
            this.DistanceTextBox.Location = new System.Drawing.Point(190, 195);
            this.DistanceTextBox.Name = "DistanceTextBox";
            this.DistanceTextBox.Size = new System.Drawing.Size(100, 22);
            this.DistanceTextBox.TabIndex = 7;
            // 
            // posTextBox
            // 
            this.posTextBox.Location = new System.Drawing.Point(190, 240);
            this.posTextBox.Name = "posTextBox";
            this.posTextBox.ReadOnly = true;
            this.posTextBox.Size = new System.Drawing.Size(100, 22);
            this.posTextBox.TabIndex = 8;
            // 
            // velocityLabel
            // 
            this.velocityLabel.AutoSize = true;
            this.velocityLabel.Location = new System.Drawing.Point(44, 71);
            this.velocityLabel.Name = "velocityLabel";
            this.velocityLabel.Size = new System.Drawing.Size(57, 17);
            this.velocityLabel.TabIndex = 9;
            this.velocityLabel.Text = "Velocity";
            // 
            // AccelerationLabel
            // 
            this.AccelerationLabel.AutoSize = true;
            this.AccelerationLabel.Location = new System.Drawing.Point(44, 114);
            this.AccelerationLabel.Name = "AccelerationLabel";
            this.AccelerationLabel.Size = new System.Drawing.Size(86, 17);
            this.AccelerationLabel.TabIndex = 10;
            this.AccelerationLabel.Text = "Acceleration";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Deceleration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Move Distance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Actual Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "counts/s";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "counts/s^2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "counts/s^2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(296, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "counts";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(296, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "counts";
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // BasicMoves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 340);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AccelerationLabel);
            this.Controls.Add(this.velocityLabel);
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

        private System.Windows.Forms.Button HomeAxisButton;
        private System.Windows.Forms.Button enableButton;
        private System.Windows.Forms.Button doMoveButton;
        private System.Windows.Forms.Button haltMoveButton;
        private System.Windows.Forms.TextBox VelocityTextBox;
        private System.Windows.Forms.TextBox AccelTextBox;
        private System.Windows.Forms.TextBox DecelTextBox;
        private System.Windows.Forms.TextBox DistanceTextBox;
        private System.Windows.Forms.TextBox posTextBox;
        private System.Windows.Forms.Label velocityLabel;
        private System.Windows.Forms.Label AccelerationLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer Timer1;
    }
}

