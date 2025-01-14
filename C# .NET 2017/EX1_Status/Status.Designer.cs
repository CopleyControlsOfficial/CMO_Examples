namespace EX1_Status
{
    partial class Status
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
            this.enableButton = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.readButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.posTextBox = new System.Windows.Forms.TextBox();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // enableButton
            // 
            this.enableButton.Location = new System.Drawing.Point(146, 12);
            this.enableButton.Name = "enableButton";
            this.enableButton.Size = new System.Drawing.Size(107, 31);
            this.enableButton.TabIndex = 0;
            this.enableButton.Text = "Amp Disable";
            this.enableButton.UseVisualStyleBackColor = true;
            this.enableButton.Click += new System.EventHandler(this.enableButton_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.ListBox1);
            this.GroupBox1.Controls.Add(this.readButton);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Controls.Add(this.label1);
            this.GroupBox1.Controls.Add(this.statusTextBox);
            this.GroupBox1.Controls.Add(this.posTextBox);
            this.GroupBox1.Location = new System.Drawing.Point(3, 61);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(385, 261);
            this.GroupBox1.TabIndex = 1;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Amp Status";
            // 
            // ListBox1
            // 
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.ItemHeight = 16;
            this.ListBox1.Location = new System.Drawing.Point(29, 168);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(322, 84);
            this.ListBox1.TabIndex = 5;
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(130, 123);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(130, 31);
            this.readButton.TabIndex = 4;
            this.readButton.Text = "ReadEventSticky";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Amp event status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Actual Position (in counts)";
            // 
            // statusTextBox
            // 
            this.statusTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.statusTextBox.Location = new System.Drawing.Point(256, 76);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.Size = new System.Drawing.Size(95, 22);
            this.statusTextBox.TabIndex = 1;
            this.statusTextBox.Text = "0";
            this.statusTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // posTextBox
            // 
            this.posTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.posTextBox.Location = new System.Drawing.Point(256, 30);
            this.posTextBox.Name = "posTextBox";
            this.posTextBox.ReadOnly = true;
            this.posTextBox.Size = new System.Drawing.Size(95, 22);
            this.posTextBox.TabIndex = 0;
            this.posTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 325);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.enableButton);
            this.Name = "Status";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Status_FormClosed);
            this.Load += new System.EventHandler(this.Status_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Button enableButton;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.ListBox ListBox1;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox statusTextBox;
        internal System.Windows.Forms.TextBox posTextBox;
    }
}

