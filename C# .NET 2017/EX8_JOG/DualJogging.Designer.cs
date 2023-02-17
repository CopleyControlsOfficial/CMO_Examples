namespace DualJogging
{
    partial class DualJogging
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
            this.JogNegButton1 = new System.Windows.Forms.Button();
            this.JogPosButton1 = new System.Windows.Forms.Button();
            this.VelocityTextBox1 = new System.Windows.Forms.TextBox();
            this.AccelTextBox1 = new System.Windows.Forms.TextBox();
            this.DecelTextBox1 = new System.Windows.Forms.TextBox();
            this.VelocityLabel = new System.Windows.Forms.Label();
            this.AccelLabel = new System.Windows.Forms.Label();
            this.DecelLabel = new System.Windows.Forms.Label();
            this.ActPosLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ActPosVar_1 = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.HomeButton2 = new System.Windows.Forms.Button();
            this.JogNegButton2 = new System.Windows.Forms.Button();
            this.JogPosButton2 = new System.Windows.Forms.Button();
            this.JogNegButton12 = new System.Windows.Forms.Button();
            this.JogPosButton12 = new System.Windows.Forms.Button();
            this.HomeButton12 = new System.Windows.Forms.Button();
            this.HomeButton1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.VelocityTextBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AccelTextBox2 = new System.Windows.Forms.TextBox();
            this.DecelTextBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ActPosVar_2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.VelocityTextBox12 = new System.Windows.Forms.TextBox();
            this.AccelTextBox12 = new System.Windows.Forms.TextBox();
            this.DecelTextBox12 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.DeltaPos = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.ActVelVar_2 = new System.Windows.Forms.Label();
            this.ActVelVar_1 = new System.Windows.Forms.Label();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.ProgressBar2 = new System.Windows.Forms.ProgressBar();
            this.label26 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.PercentDisplay1 = new System.Windows.Forms.Label();
            this.PercentDisplay2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // JogNegButton1
            // 
            this.JogNegButton1.Location = new System.Drawing.Point(51, 217);
            this.JogNegButton1.Margin = new System.Windows.Forms.Padding(2);
            this.JogNegButton1.Name = "JogNegButton1";
            this.JogNegButton1.Size = new System.Drawing.Size(87, 26);
            this.JogNegButton1.TabIndex = 0;
            this.JogNegButton1.Text = "Axis 1 Jog Neg";
            this.JogNegButton1.UseVisualStyleBackColor = true;
            this.JogNegButton1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.JogNegButton_MouseDown1);
            this.JogNegButton1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.JogNegButton_MouseUp1);
            // 
            // JogPosButton1
            // 
            this.JogPosButton1.Location = new System.Drawing.Point(142, 217);
            this.JogPosButton1.Margin = new System.Windows.Forms.Padding(2);
            this.JogPosButton1.Name = "JogPosButton1";
            this.JogPosButton1.Size = new System.Drawing.Size(86, 26);
            this.JogPosButton1.TabIndex = 1;
            this.JogPosButton1.Text = "Axis 1 Jog Pos ";
            this.JogPosButton1.UseVisualStyleBackColor = true;
            this.JogPosButton1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.JogPosButton_MouseDown1);
            this.JogPosButton1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.JogPosButton_MouseUp1);
            // 
            // VelocityTextBox1
            // 
            this.VelocityTextBox1.Location = new System.Drawing.Point(95, 28);
            this.VelocityTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.VelocityTextBox1.Name = "VelocityTextBox1";
            this.VelocityTextBox1.Size = new System.Drawing.Size(76, 20);
            this.VelocityTextBox1.TabIndex = 2;
            // 
            // AccelTextBox1
            // 
            this.AccelTextBox1.Location = new System.Drawing.Point(95, 67);
            this.AccelTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.AccelTextBox1.Name = "AccelTextBox1";
            this.AccelTextBox1.Size = new System.Drawing.Size(76, 20);
            this.AccelTextBox1.TabIndex = 3;
            // 
            // DecelTextBox1
            // 
            this.DecelTextBox1.Location = new System.Drawing.Point(95, 110);
            this.DecelTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.DecelTextBox1.Name = "DecelTextBox1";
            this.DecelTextBox1.Size = new System.Drawing.Size(76, 20);
            this.DecelTextBox1.TabIndex = 4;
            // 
            // VelocityLabel
            // 
            this.VelocityLabel.AutoSize = true;
            this.VelocityLabel.Location = new System.Drawing.Point(16, 28);
            this.VelocityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VelocityLabel.Name = "VelocityLabel";
            this.VelocityLabel.Size = new System.Drawing.Size(47, 13);
            this.VelocityLabel.TabIndex = 5;
            this.VelocityLabel.Text = "Velocity:";
            // 
            // AccelLabel
            // 
            this.AccelLabel.AutoSize = true;
            this.AccelLabel.Location = new System.Drawing.Point(16, 69);
            this.AccelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AccelLabel.Name = "AccelLabel";
            this.AccelLabel.Size = new System.Drawing.Size(69, 13);
            this.AccelLabel.TabIndex = 6;
            this.AccelLabel.Text = "Acceleration:";
            // 
            // DecelLabel
            // 
            this.DecelLabel.AutoSize = true;
            this.DecelLabel.Location = new System.Drawing.Point(16, 110);
            this.DecelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DecelLabel.Name = "DecelLabel";
            this.DecelLabel.Size = new System.Drawing.Size(70, 13);
            this.DecelLabel.TabIndex = 7;
            this.DecelLabel.Text = "Deceleration:";
            // 
            // ActPosLabel
            // 
            this.ActPosLabel.AutoSize = true;
            this.ActPosLabel.Location = new System.Drawing.Point(16, 187);
            this.ActPosLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ActPosLabel.Name = "ActPosLabel";
            this.ActPosLabel.Size = new System.Drawing.Size(77, 13);
            this.ActPosLabel.TabIndex = 8;
            this.ActPosLabel.Text = "Actual Position";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "counts/s";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "counts/s^2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "counts/s^2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 187);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "counts";
            // 
            // ActPosVar_1
            // 
            this.ActPosVar_1.AutoSize = true;
            this.ActPosVar_1.Location = new System.Drawing.Point(97, 187);
            this.ActPosVar_1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ActPosVar_1.Name = "ActPosVar_1";
            this.ActPosVar_1.Size = new System.Drawing.Size(55, 13);
            this.ActPosVar_1.TabIndex = 13;
            this.ActPosVar_1.Text = "                ";
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // HomeButton2
            // 
            this.HomeButton2.Location = new System.Drawing.Point(376, 248);
            this.HomeButton2.Name = "HomeButton2";
            this.HomeButton2.Size = new System.Drawing.Size(85, 26);
            this.HomeButton2.TabIndex = 14;
            this.HomeButton2.Text = "Home Axis 2";
            this.HomeButton2.UseVisualStyleBackColor = true;
            this.HomeButton2.Click += new System.EventHandler(this.HomeButton2_Click);
            // 
            // JogNegButton2
            // 
            this.JogNegButton2.Location = new System.Drawing.Point(337, 217);
            this.JogNegButton2.Name = "JogNegButton2";
            this.JogNegButton2.Size = new System.Drawing.Size(87, 26);
            this.JogNegButton2.TabIndex = 15;
            this.JogNegButton2.Text = "Axis 2 Jog Neg";
            this.JogNegButton2.UseVisualStyleBackColor = true;
            this.JogNegButton2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.JogNegButton_MouseDown2);
            this.JogNegButton2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.JogNegButton_MouseUp2);
            // 
            // JogPosButton2
            // 
            this.JogPosButton2.Location = new System.Drawing.Point(430, 217);
            this.JogPosButton2.Name = "JogPosButton2";
            this.JogPosButton2.Size = new System.Drawing.Size(86, 26);
            this.JogPosButton2.TabIndex = 16;
            this.JogPosButton2.Text = "Axis 2 Jog Pos";
            this.JogPosButton2.UseVisualStyleBackColor = true;
            this.JogPosButton2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.JogPosButton_MouseDown2);
            this.JogPosButton2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.JogPosButton_MouseUp2);
            // 
            // JogNegButton12
            // 
            this.JogNegButton12.Location = new System.Drawing.Point(581, 217);
            this.JogNegButton12.Name = "JogNegButton12";
            this.JogNegButton12.Size = new System.Drawing.Size(102, 27);
            this.JogNegButton12.TabIndex = 17;
            this.JogNegButton12.Text = "Dual Axis Jog Neg";
            this.JogNegButton12.UseVisualStyleBackColor = true;
            this.JogNegButton12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.JogNegButton_MouseDown12);
            this.JogNegButton12.MouseUp += new System.Windows.Forms.MouseEventHandler(this.JogNegButton_MouseUp12);
            // 
            // JogPosButton12
            // 
            this.JogPosButton12.Location = new System.Drawing.Point(689, 217);
            this.JogPosButton12.Name = "JogPosButton12";
            this.JogPosButton12.Size = new System.Drawing.Size(102, 27);
            this.JogPosButton12.TabIndex = 18;
            this.JogPosButton12.Text = "Dual Axis Jog Pos";
            this.JogPosButton12.UseVisualStyleBackColor = true;
            this.JogPosButton12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.JogPosButton_MouseDown12);
            this.JogPosButton12.MouseUp += new System.Windows.Forms.MouseEventHandler(this.JogPosButton_MouseUp12);
            // 
            // HomeButton12
            // 
            this.HomeButton12.Location = new System.Drawing.Point(621, 247);
            this.HomeButton12.Name = "HomeButton12";
            this.HomeButton12.Size = new System.Drawing.Size(102, 27);
            this.HomeButton12.TabIndex = 19;
            this.HomeButton12.Text = "Dual Axis Home";
            this.HomeButton12.UseVisualStyleBackColor = true;
            this.HomeButton12.Click += new System.EventHandler(this.HomeButton12_Click);
            // 
            // HomeButton1
            // 
            this.HomeButton1.Location = new System.Drawing.Point(86, 248);
            this.HomeButton1.Name = "HomeButton1";
            this.HomeButton1.Size = new System.Drawing.Size(85, 26);
            this.HomeButton1.TabIndex = 20;
            this.HomeButton1.Text = "Home Axis 1";
            this.HomeButton1.UseVisualStyleBackColor = true;
            this.HomeButton1.Click += new System.EventHandler(this.HomeButton1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Axis 1";
            // 
            // VelocityTextBox2
            // 
            this.VelocityTextBox2.Location = new System.Drawing.Point(384, 25);
            this.VelocityTextBox2.Name = "VelocityTextBox2";
            this.VelocityTextBox2.Size = new System.Drawing.Size(77, 20);
            this.VelocityTextBox2.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(403, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Axis 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(477, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "counts/s";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(477, 70);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "counts/s^2";
            // 
            // AccelTextBox2
            // 
            this.AccelTextBox2.Location = new System.Drawing.Point(384, 66);
            this.AccelTextBox2.Name = "AccelTextBox2";
            this.AccelTextBox2.Size = new System.Drawing.Size(77, 20);
            this.AccelTextBox2.TabIndex = 26;
            // 
            // DecelTextBox2
            // 
            this.DecelTextBox2.Location = new System.Drawing.Point(384, 110);
            this.DecelTextBox2.Name = "DecelTextBox2";
            this.DecelTextBox2.Size = new System.Drawing.Size(77, 20);
            this.DecelTextBox2.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(477, 113);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "counts/s^2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(310, 28);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Velocity:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(310, 69);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Acceleration:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(310, 113);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Deceleration:";
            // 
            // ActPosVar_2
            // 
            this.ActPosVar_2.AutoSize = true;
            this.ActPosVar_2.Location = new System.Drawing.Point(391, 187);
            this.ActPosVar_2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ActPosVar_2.Name = "ActPosVar_2";
            this.ActPosVar_2.Size = new System.Drawing.Size(55, 13);
            this.ActPosVar_2.TabIndex = 32;
            this.ActPosVar_2.Text = "                ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(310, 187);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "Actual Position";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(477, 187);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "counts";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(662, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "Dual Axis";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(572, 28);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 13);
            this.label18.TabIndex = 40;
            this.label18.Text = "Velocity:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(572, 69);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 13);
            this.label19.TabIndex = 41;
            this.label19.Text = "Acceleration:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(572, 113);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(70, 13);
            this.label20.TabIndex = 42;
            this.label20.Text = "Deceleration:";
            // 
            // VelocityTextBox12
            // 
            this.VelocityTextBox12.Location = new System.Drawing.Point(646, 25);
            this.VelocityTextBox12.Name = "VelocityTextBox12";
            this.VelocityTextBox12.Size = new System.Drawing.Size(77, 20);
            this.VelocityTextBox12.TabIndex = 43;
            // 
            // AccelTextBox12
            // 
            this.AccelTextBox12.Location = new System.Drawing.Point(646, 66);
            this.AccelTextBox12.Name = "AccelTextBox12";
            this.AccelTextBox12.Size = new System.Drawing.Size(77, 20);
            this.AccelTextBox12.TabIndex = 44;
            // 
            // DecelTextBox12
            // 
            this.DecelTextBox12.Location = new System.Drawing.Point(646, 110);
            this.DecelTextBox12.Name = "DecelTextBox12";
            this.DecelTextBox12.Size = new System.Drawing.Size(77, 20);
            this.DecelTextBox12.TabIndex = 45;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(730, 28);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(49, 13);
            this.label21.TabIndex = 46;
            this.label21.Text = "counts/s";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(730, 69);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(61, 13);
            this.label22.TabIndex = 47;
            this.label22.Text = "counts/s^2";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(730, 113);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(61, 13);
            this.label23.TabIndex = 48;
            this.label23.Text = "counts/s^2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(572, 187);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 49;
            this.label13.Text = "Delta Position";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(730, 187);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 13);
            this.label17.TabIndex = 50;
            this.label17.Text = "counts";
            // 
            // DeltaPos
            // 
            this.DeltaPos.AutoSize = true;
            this.DeltaPos.Location = new System.Drawing.Point(648, 187);
            this.DeltaPos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DeltaPos.Name = "DeltaPos";
            this.DeltaPos.Size = new System.Drawing.Size(55, 13);
            this.DeltaPos.TabIndex = 51;
            this.DeltaPos.Text = "                ";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(16, 155);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(77, 13);
            this.label24.TabIndex = 52;
            this.label24.Text = "Actual Velocity";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(310, 155);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(77, 13);
            this.label25.TabIndex = 53;
            this.label25.Text = "Actual Velocity";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(189, 155);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(49, 13);
            this.label27.TabIndex = 55;
            this.label27.Text = "counts/s";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(477, 155);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(49, 13);
            this.label28.TabIndex = 56;
            this.label28.Text = "counts/s";
            // 
            // ActVelVar_2
            // 
            this.ActVelVar_2.AutoSize = true;
            this.ActVelVar_2.Location = new System.Drawing.Point(391, 155);
            this.ActVelVar_2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ActVelVar_2.Name = "ActVelVar_2";
            this.ActVelVar_2.Size = new System.Drawing.Size(55, 13);
            this.ActVelVar_2.TabIndex = 59;
            this.ActVelVar_2.Text = "                ";
            // 
            // ActVelVar_1
            // 
            this.ActVelVar_1.AutoSize = true;
            this.ActVelVar_1.Location = new System.Drawing.Point(97, 155);
            this.ActVelVar_1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ActVelVar_1.Name = "ActVelVar_1";
            this.ActVelVar_1.Size = new System.Drawing.Size(55, 13);
            this.ActVelVar_1.TabIndex = 60;
            this.ActVelVar_1.Text = "                ";
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(51, 290);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(177, 23);
            this.ProgressBar1.Step = 1;
            this.ProgressBar1.TabIndex = 61;
            // 
            // ProgressBar2
            // 
            this.ProgressBar2.Location = new System.Drawing.Point(337, 290);
            this.ProgressBar2.Name = "ProgressBar2";
            this.ProgressBar2.Size = new System.Drawing.Size(179, 23);
            this.ProgressBar2.Step = 1;
            this.ProgressBar2.TabIndex = 62;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(16, 316);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(47, 13);
            this.label26.TabIndex = 63;
            this.label26.Text = "Min (0%)";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(189, 316);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(62, 13);
            this.label29.TabIndex = 64;
            this.label29.Text = "Max (100%)";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(310, 316);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(47, 13);
            this.label30.TabIndex = 65;
            this.label30.Text = "Min (0%)";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(477, 316);
            this.label31.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(62, 13);
            this.label31.TabIndex = 66;
            this.label31.Text = "Max (100%)";
            // 
            // PercentDisplay1
            // 
            this.PercentDisplay1.AutoSize = true;
            this.PercentDisplay1.Location = new System.Drawing.Point(97, 316);
            this.PercentDisplay1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PercentDisplay1.Name = "PercentDisplay1";
            this.PercentDisplay1.Size = new System.Drawing.Size(55, 13);
            this.PercentDisplay1.TabIndex = 67;
            this.PercentDisplay1.Text = "                ";
            // 
            // PercentDisplay2
            // 
            this.PercentDisplay2.AutoSize = true;
            this.PercentDisplay2.Location = new System.Drawing.Point(391, 316);
            this.PercentDisplay2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PercentDisplay2.Name = "PercentDisplay2";
            this.PercentDisplay2.Size = new System.Drawing.Size(55, 13);
            this.PercentDisplay2.TabIndex = 68;
            this.PercentDisplay2.Text = "                ";
            // 
            // Jogging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 355);
            this.Controls.Add(this.PercentDisplay2);
            this.Controls.Add(this.PercentDisplay1);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.ProgressBar2);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.ActVelVar_1);
            this.Controls.Add(this.ActVelVar_2);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.DeltaPos);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.DecelTextBox12);
            this.Controls.Add(this.AccelTextBox12);
            this.Controls.Add(this.VelocityTextBox12);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ActPosVar_2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DecelTextBox2);
            this.Controls.Add(this.AccelTextBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.VelocityTextBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.HomeButton1);
            this.Controls.Add(this.HomeButton12);
            this.Controls.Add(this.JogPosButton12);
            this.Controls.Add(this.JogNegButton12);
            this.Controls.Add(this.JogPosButton2);
            this.Controls.Add(this.JogNegButton2);
            this.Controls.Add(this.HomeButton2);
            this.Controls.Add(this.ActPosVar_1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ActPosLabel);
            this.Controls.Add(this.DecelLabel);
            this.Controls.Add(this.AccelLabel);
            this.Controls.Add(this.VelocityLabel);
            this.Controls.Add(this.DecelTextBox1);
            this.Controls.Add(this.AccelTextBox1);
            this.Controls.Add(this.VelocityTextBox1);
            this.Controls.Add(this.JogPosButton1);
            this.Controls.Add(this.JogNegButton1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Jogging";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Jogging_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button JogNegButton1;
        private System.Windows.Forms.Button JogPosButton1;
        private System.Windows.Forms.TextBox VelocityTextBox1;
        private System.Windows.Forms.TextBox AccelTextBox1;
        private System.Windows.Forms.TextBox DecelTextBox1;
        private System.Windows.Forms.Label VelocityLabel;
        private System.Windows.Forms.Label AccelLabel;
        private System.Windows.Forms.Label DecelLabel;
        private System.Windows.Forms.Label ActPosLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ActPosVar_1;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Button HomeButton2;
        private System.Windows.Forms.Button JogNegButton2;
        private System.Windows.Forms.Button JogPosButton2;
        private System.Windows.Forms.Button JogNegButton12;
        private System.Windows.Forms.Button JogPosButton12;
        private System.Windows.Forms.Button HomeButton12;
        private System.Windows.Forms.Button HomeButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox VelocityTextBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AccelTextBox2;
        private System.Windows.Forms.TextBox DecelTextBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label ActPosVar_2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox VelocityTextBox12;
        private System.Windows.Forms.TextBox AccelTextBox12;
        private System.Windows.Forms.TextBox DecelTextBox12;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label DeltaPos;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label ActVelVar_2;
        private System.Windows.Forms.Label ActVelVar_1;
        private System.Windows.Forms.ProgressBar ProgressBar1;
        private System.Windows.Forms.ProgressBar ProgressBar2;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label PercentDisplay1;
        private System.Windows.Forms.Label PercentDisplay2;
    }
}

