namespace EX10_IoModule
{
    partial class IoModule
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput2State = new System.Windows.Forms.TextBox();
            this.txtInput1State = new System.Windows.Forms.TextBox();
            this.cbOut2 = new System.Windows.Forms.CheckBox();
            this.cbOut1 = new System.Windows.Forms.CheckBox();
            this.TimerStat = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Input 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Input 1";
            // 
            // txtInput2State
            // 
            this.txtInput2State.Location = new System.Drawing.Point(122, 53);
            this.txtInput2State.Margin = new System.Windows.Forms.Padding(2);
            this.txtInput2State.Name = "txtInput2State";
            this.txtInput2State.Size = new System.Drawing.Size(32, 20);
            this.txtInput2State.TabIndex = 9;
            this.txtInput2State.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInput1State
            // 
            this.txtInput1State.Location = new System.Drawing.Point(122, 21);
            this.txtInput1State.Margin = new System.Windows.Forms.Padding(2);
            this.txtInput1State.Name = "txtInput1State";
            this.txtInput1State.Size = new System.Drawing.Size(32, 20);
            this.txtInput1State.TabIndex = 8;
            this.txtInput1State.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbOut2
            // 
            this.cbOut2.AutoSize = true;
            this.cbOut2.Location = new System.Drawing.Point(33, 54);
            this.cbOut2.Margin = new System.Windows.Forms.Padding(2);
            this.cbOut2.Name = "cbOut2";
            this.cbOut2.Size = new System.Drawing.Size(67, 17);
            this.cbOut2.TabIndex = 7;
            this.cbOut2.Text = "Output 2";
            this.cbOut2.UseVisualStyleBackColor = true;
            this.cbOut2.CheckedChanged += new System.EventHandler(this.cbOut2_CheckedChanged);
            // 
            // cbOut1
            // 
            this.cbOut1.AutoSize = true;
            this.cbOut1.Location = new System.Drawing.Point(33, 23);
            this.cbOut1.Margin = new System.Windows.Forms.Padding(2);
            this.cbOut1.Name = "cbOut1";
            this.cbOut1.Size = new System.Drawing.Size(67, 17);
            this.cbOut1.TabIndex = 6;
            this.cbOut1.Text = "Output 1";
            this.cbOut1.UseVisualStyleBackColor = true;
            this.cbOut1.CheckedChanged += new System.EventHandler(this.cbOut1_CheckedChanged);
            // 
            // TimerStat
            // 
            this.TimerStat.Tick += new System.EventHandler(this.TimerStat_Tick);
            // 
            // IoModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 103);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInput2State);
            this.Controls.Add(this.txtInput1State);
            this.Controls.Add(this.cbOut2);
            this.Controls.Add(this.cbOut1);
            this.Name = "IoModule";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.IoModule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput2State;
        private System.Windows.Forms.TextBox txtInput1State;
        private System.Windows.Forms.CheckBox cbOut2;
        private System.Windows.Forms.CheckBox cbOut1;
        private System.Windows.Forms.Timer TimerStat;
    }
}

