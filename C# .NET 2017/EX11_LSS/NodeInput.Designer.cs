namespace EX12_LSS
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SendIDButton = new System.Windows.Forms.Button();
            this.NodeIDTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter the desired node ID for the";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "amp with the blinking CAN LEDs";
            // 
            // SendIDButton
            // 
            this.SendIDButton.Location = new System.Drawing.Point(205, 114);
            this.SendIDButton.Name = "SendIDButton";
            this.SendIDButton.Size = new System.Drawing.Size(75, 30);
            this.SendIDButton.TabIndex = 2;
            this.SendIDButton.Text = "Send";
            this.SendIDButton.UseVisualStyleBackColor = true;
            this.SendIDButton.Click += new System.EventHandler(this.SendIDButton_Click);
            // 
            // NodeIDTextBox
            // 
            this.NodeIDTextBox.Location = new System.Drawing.Point(89, 118);
            this.NodeIDTextBox.Name = "NodeIDTextBox";
            this.NodeIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.NodeIDTextBox.TabIndex = 3;
            // 
            // NodeInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 255);
            this.Controls.Add(this.NodeIDTextBox);
            this.Controls.Add(this.SendIDButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NodeInput";
            this.Text = "NodeInput";
            this.Load += new System.EventHandler(this.NodeInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SendIDButton;
        private System.Windows.Forms.TextBox NodeIDTextBox;
    }
}