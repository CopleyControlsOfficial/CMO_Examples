namespace EX10_IoModule
{
    partial class IOModule
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
            this.cbOut1 = new System.Windows.Forms.CheckBox();
            this.cbOut2 = new System.Windows.Forms.CheckBox();
            this.txtInput1State = new System.Windows.Forms.TextBox();
            this.txtInput2State = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TimerStat = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // cbOut1
            // 
            this.cbOut1.AutoSize = true;
            this.cbOut1.Location = new System.Drawing.Point(30, 33);
            this.cbOut1.Name = "cbOut1";
            this.cbOut1.Size = new System.Drawing.Size(85, 21);
            this.cbOut1.TabIndex = 0;
            this.cbOut1.Text = "Output 1";
            this.cbOut1.UseVisualStyleBackColor = true;
            this.cbOut1.CheckedChanged += new System.EventHandler(this.cbOut1_CheckedChanged);
            // 
            // cbOut2
            // 
            this.cbOut2.AutoSize = true;
            this.cbOut2.Location = new System.Drawing.Point(30, 72);
            this.cbOut2.Name = "cbOut2";
            this.cbOut2.Size = new System.Drawing.Size(85, 21);
            this.cbOut2.TabIndex = 1;
            this.cbOut2.Text = "Output 2";
            this.cbOut2.UseVisualStyleBackColor = true;
            this.cbOut2.CheckedChanged += new System.EventHandler(this.cbOut2_CheckedChanged);
            // 
            // txtInput1State
            // 
            this.txtInput1State.Location = new System.Drawing.Point(140, 31);
            this.txtInput1State.Name = "txtInput1State";
            this.txtInput1State.Size = new System.Drawing.Size(52, 22);
            this.txtInput1State.TabIndex = 2;
            // 
            // txtInput2State
            // 
            this.txtInput2State.Location = new System.Drawing.Point(140, 70);
            this.txtInput2State.Name = "txtInput2State";
            this.txtInput2State.Size = new System.Drawing.Size(52, 22);
            this.txtInput2State.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Input 2";
            // 
            // TimerStat
            // 
            this.TimerStat.Tick += new System.EventHandler(this.TimerStat_Tick);
            // 
            // IOModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 155);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInput2State);
            this.Controls.Add(this.txtInput1State);
            this.Controls.Add(this.cbOut2);
            this.Controls.Add(this.cbOut1);
            this.Name = "IOModule";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.IOModule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbOut1;
        private System.Windows.Forms.CheckBox cbOut2;
        private System.Windows.Forms.TextBox txtInput1State;
        private System.Windows.Forms.TextBox txtInput2State;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer TimerStat;
    }
}

