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
            this.enableButton = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.posTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.readButton = new System.Windows.Forms.Button();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // enableButton
            // 
            this.enableButton.Location = new System.Drawing.Point(149, 29);
            this.enableButton.Name = "enableButton";
            this.enableButton.Size = new System.Drawing.Size(98, 36);
            this.enableButton.TabIndex = 0;
            this.enableButton.Text = "Amp Disable";
            this.enableButton.UseVisualStyleBackColor = true;
            this.enableButton.Click += new System.EventHandler(this.enableButton_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.ListBox1);
            this.GroupBox1.Controls.Add(this.readButton);
            this.GroupBox1.Controls.Add(this.statusTextBox);
            this.GroupBox1.Controls.Add(this.posTextBox);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(12, 71);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(389, 244);
            this.GroupBox1.TabIndex = 1;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Amp Status";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(34, 53);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(129, 13);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Actual Position (in counts)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Amp event status";
            // 
            // posTextBox
            // 
            this.posTextBox.Location = new System.Drawing.Point(260, 50);
            this.posTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.posTextBox.Name = "posTextBox";
            this.posTextBox.ReadOnly = true;
            this.posTextBox.Size = new System.Drawing.Size(76, 20);
            this.posTextBox.TabIndex = 6;
            this.posTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(260, 86);
            this.statusTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.Size = new System.Drawing.Size(76, 20);
            this.statusTextBox.TabIndex = 7;
            this.statusTextBox.Text = "0";
            this.statusTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(137, 137);
            this.readButton.Margin = new System.Windows.Forms.Padding(2);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(98, 23);
            this.readButton.TabIndex = 8;
            this.readButton.Text = "ReadEventSticky";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // ListBox1
            // 
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.Location = new System.Drawing.Point(64, 164);
            this.ListBox1.Margin = new System.Windows.Forms.Padding(2);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(246, 69);
            this.ListBox1.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 327);
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

        private System.Windows.Forms.Button enableButton;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.ListBox ListBox1;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox posTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Timer timer1;
    }
}

