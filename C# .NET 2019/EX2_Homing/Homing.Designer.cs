namespace EX2_Homing
{
    partial class Homing
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
            this.enableButton = new System.Windows.Forms.Button();
            this.HomeAxisButton = new System.Windows.Forms.Button();
            this.referencedLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.posTextBox = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // enableButton
            // 
            this.enableButton.Location = new System.Drawing.Point(113, 23);
            this.enableButton.Margin = new System.Windows.Forms.Padding(2);
            this.enableButton.Name = "enableButton";
            this.enableButton.Size = new System.Drawing.Size(128, 32);
            this.enableButton.TabIndex = 1;
            this.enableButton.Text = "Amp Disable";
            this.enableButton.UseVisualStyleBackColor = true;
            this.enableButton.Click += new System.EventHandler(this.enableButton_Click);
            // 
            // HomeAxisButton
            // 
            this.HomeAxisButton.Location = new System.Drawing.Point(113, 76);
            this.HomeAxisButton.Margin = new System.Windows.Forms.Padding(2);
            this.HomeAxisButton.Name = "HomeAxisButton";
            this.HomeAxisButton.Size = new System.Drawing.Size(128, 32);
            this.HomeAxisButton.TabIndex = 2;
            this.HomeAxisButton.Text = "Home Axis";
            this.HomeAxisButton.UseVisualStyleBackColor = true;
            this.HomeAxisButton.Click += new System.EventHandler(this.HomeAxisButton_Click);
            // 
            // referencedLabel
            // 
            this.referencedLabel.AutoSize = true;
            this.referencedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.referencedLabel.Location = new System.Drawing.Point(86, 172);
            this.referencedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.referencedLabel.Name = "referencedLabel";
            this.referencedLabel.Size = new System.Drawing.Size(117, 16);
            this.referencedLabel.TabIndex = 11;
            this.referencedLabel.Text = "Not Referenced";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "counts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Actual Position";
            // 
            // posTextBox
            // 
            this.posTextBox.Location = new System.Drawing.Point(170, 139);
            this.posTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.posTextBox.Name = "posTextBox";
            this.posTextBox.ReadOnly = true;
            this.posTextBox.Size = new System.Drawing.Size(76, 20);
            this.posTextBox.TabIndex = 8;
            this.posTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(100, 199);
            this.resetButton.Margin = new System.Windows.Forms.Padding(2);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(70, 24);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset Amp";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Homing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 292);
            this.Controls.Add(this.referencedLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.posTextBox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.HomeAxisButton);
            this.Controls.Add(this.enableButton);
            this.Name = "Homing";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Homing_FormClosed);
            this.Load += new System.EventHandler(this.Homing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enableButton;
        private System.Windows.Forms.Button HomeAxisButton;
        private System.Windows.Forms.Label referencedLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox posTextBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Timer Timer1;
    }
}

