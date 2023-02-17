namespace EX11_LSS
{
    partial class NodeInput
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
            this.NodeIDTextBox = new System.Windows.Forms.TextBox();
            this.SendIDButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NodeIDTextBox
            // 
            this.NodeIDTextBox.Location = new System.Drawing.Point(81, 103);
            this.NodeIDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.NodeIDTextBox.Name = "NodeIDTextBox";
            this.NodeIDTextBox.Size = new System.Drawing.Size(76, 20);
            this.NodeIDTextBox.TabIndex = 11;
            // 
            // SendIDButton
            // 
            this.SendIDButton.Location = new System.Drawing.Point(160, 99);
            this.SendIDButton.Margin = new System.Windows.Forms.Padding(2);
            this.SendIDButton.Name = "SendIDButton";
            this.SendIDButton.Size = new System.Drawing.Size(56, 24);
            this.SendIDButton.TabIndex = 10;
            this.SendIDButton.Text = "Send";
            this.SendIDButton.UseVisualStyleBackColor = true;
            this.SendIDButton.Click += new System.EventHandler(this.SendIDButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "amp with the blinking CAN LEDs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Please enter the desired node ID for the";
            // 
            // NodeInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 168);
            this.Controls.Add(this.NodeIDTextBox);
            this.Controls.Add(this.SendIDButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NodeInput";
            this.Text = "NodeInput";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NodeIDTextBox;
        private System.Windows.Forms.Button SendIDButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}