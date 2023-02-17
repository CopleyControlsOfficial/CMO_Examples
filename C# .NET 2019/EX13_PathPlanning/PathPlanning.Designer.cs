namespace EX13_PathPlanning
{
    partial class PathPlanning
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SetStartPosTab = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.StartPosYAxisTextBox = new System.Windows.Forms.TextBox();
            this.StartPosXAxisTextBox = new System.Windows.Forms.TextBox();
            this.SetStartPosButton = new System.Windows.Forms.Button();
            this.AddLineTab = new System.Windows.Forms.TabPage();
            this.Label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AddLineYAxisTextBox = new System.Windows.Forms.TextBox();
            this.AddLineXAxisTextBox = new System.Windows.Forms.TextBox();
            this.AddLineButton = new System.Windows.Forms.Button();
            this.AddArcTab = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.RadiusTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.AddArcAngleTextBox = new System.Windows.Forms.TextBox();
            this.AddArcButton = new System.Windows.Forms.Button();
            this.AddPauseTab = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.AddPauseTextBox = new System.Windows.Forms.TextBox();
            this.AddPauseButton = new System.Windows.Forms.Button();
            this.PlayPathTab = new System.Windows.Forms.TabPage();
            this.PlayPathButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MaxJerkTextBox = new System.Windows.Forms.TextBox();
            this.MaxAccelTextBox = new System.Windows.Forms.TextBox();
            this.MaxDecelTextBox = new System.Windows.Forms.TextBox();
            this.MaxVelTextBox = new System.Windows.Forms.TextBox();
            this.pathCommandsLabel = new System.Windows.Forms.Label();
            this.trajectoryCommandsLabel = new System.Windows.Forms.Label();
            this.HaltButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SetStartPosTab.SuspendLayout();
            this.AddLineTab.SuspendLayout();
            this.AddArcTab.SuspendLayout();
            this.AddPauseTab.SuspendLayout();
            this.PlayPathTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // Chart
            // 
            chartArea1.AxisX.LabelStyle.Format = "0";
            chartArea1.AxisX2.LabelStyle.Format = "0";
            chartArea1.AxisY.LabelStyle.Format = "0";
            chartArea1.AxisY2.LabelStyle.Format = "0";
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 89.39832F;
            chartArea1.InnerPlotPosition.Width = 93.148F;
            chartArea1.InnerPlotPosition.X = 5.70307F;
            chartArea1.InnerPlotPosition.Y = 2.41776F;
            chartArea1.Name = "positionArea";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 65.14299F;
            chartArea1.Position.Width = 91.39F;
            chartArea1.Position.X = 5.60747F;
            chartArea1.Position.Y = 6.357013F;
            chartArea2.AlignWithChartArea = "positionArea";
            chartArea2.AxisX.LabelStyle.Format = "0";
            chartArea2.AxisX2.LabelStyle.Format = "0";
            chartArea2.AxisY.LabelStyle.Format = "0";
            chartArea2.AxisY2.LabelStyle.Format = "0";
            chartArea2.BackSecondaryColor = System.Drawing.Color.White;
            chartArea2.Name = "velocityArea";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 25F;
            chartArea2.Position.Width = 91.39F;
            chartArea2.Position.X = 5.60747F;
            chartArea2.Position.Y = 71.5F;
            this.Chart.ChartAreas.Add(chartArea1);
            this.Chart.ChartAreas.Add(chartArea2);
            this.Chart.Location = new System.Drawing.Point(337, 12);
            this.Chart.Name = "Chart";
            this.Chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.Chart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0))))),
        System.Drawing.Color.Blue};
            series1.ChartArea = "positionArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsVisibleInLegend = false;
            series1.Name = "Position Data";
            series1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.ChartArea = "velocityArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsVisibleInLegend = false;
            series2.Name = "XAxisVelocity";
            series2.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series3.ChartArea = "velocityArea";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.IsVisibleInLegend = false;
            series3.Name = "YAxisVelocity";
            series3.ShadowColor = System.Drawing.Color.Red;
            this.Chart.Series.Add(series1);
            this.Chart.Series.Add(series2);
            this.Chart.Series.Add(series3);
            this.Chart.Size = new System.Drawing.Size(807, 690);
            this.Chart.TabIndex = 22;
            this.Chart.Text = "chart";
            title1.DockedToChartArea = "positionArea";
            title1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title1.IsDockedInsideChartArea = false;
            title1.Name = "yAxisPositionsTitle";
            title1.Text = "Y-Axis Position (counts)";
            title2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Bottom;
            title2.DockedToChartArea = "positionArea";
            title2.IsDockedInsideChartArea = false;
            title2.Name = "xAxisPositionsTitle";
            title2.Text = "X-Axis Position (counts)";
            title3.DockedToChartArea = "velocityArea";
            title3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title3.IsDockedInsideChartArea = false;
            title3.Name = "VelocitiesTitle";
            title3.Text = "Velocity (0.1 counts/sec)";
            title4.DockedToChartArea = "velocityArea";
            title4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title4.IsDockedInsideChartArea = false;
            title4.Name = "PointTitle";
            title4.Text = "Point Number";
            this.Chart.Titles.Add(title1);
            this.Chart.Titles.Add(title2);
            this.Chart.Titles.Add(title3);
            this.Chart.Titles.Add(title4);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.SetStartPosTab);
            this.tabControl1.Controls.Add(this.AddLineTab);
            this.tabControl1.Controls.Add(this.AddArcTab);
            this.tabControl1.Controls.Add(this.AddPauseTab);
            this.tabControl1.Controls.Add(this.PlayPathTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 352);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(308, 233);
            this.tabControl1.TabIndex = 38;
            // 
            // SetStartPosTab
            // 
            this.SetStartPosTab.Controls.Add(this.label21);
            this.SetStartPosTab.Controls.Add(this.label22);
            this.SetStartPosTab.Controls.Add(this.label23);
            this.SetStartPosTab.Controls.Add(this.label24);
            this.SetStartPosTab.Controls.Add(this.StartPosYAxisTextBox);
            this.SetStartPosTab.Controls.Add(this.StartPosXAxisTextBox);
            this.SetStartPosTab.Controls.Add(this.SetStartPosButton);
            this.SetStartPosTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetStartPosTab.Location = new System.Drawing.Point(4, 22);
            this.SetStartPosTab.Name = "SetStartPosTab";
            this.SetStartPosTab.Padding = new System.Windows.Forms.Padding(3);
            this.SetStartPosTab.Size = new System.Drawing.Size(300, 207);
            this.SetStartPosTab.TabIndex = 4;
            this.SetStartPosTab.Text = "Set Start Pos";
            this.SetStartPosTab.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(65, 78);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(45, 16);
            this.label21.TabIndex = 32;
            this.label21.Text = "y axis:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(65, 39);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(44, 16);
            this.label22.TabIndex = 31;
            this.label22.Text = "x axis:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(196, 78);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(47, 16);
            this.label23.TabIndex = 30;
            this.label23.Text = "counts";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(196, 39);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(47, 16);
            this.label24.TabIndex = 27;
            this.label24.Text = "counts";
            // 
            // StartPosYAxisTextBox
            // 
            this.StartPosYAxisTextBox.BackColor = System.Drawing.Color.LightGreen;
            this.StartPosYAxisTextBox.Location = new System.Drawing.Point(117, 75);
            this.StartPosYAxisTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.StartPosYAxisTextBox.Name = "StartPosYAxisTextBox";
            this.StartPosYAxisTextBox.Size = new System.Drawing.Size(75, 22);
            this.StartPosYAxisTextBox.TabIndex = 29;
            // 
            // StartPosXAxisTextBox
            // 
            this.StartPosXAxisTextBox.BackColor = System.Drawing.Color.LightGreen;
            this.StartPosXAxisTextBox.Location = new System.Drawing.Point(117, 36);
            this.StartPosXAxisTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.StartPosXAxisTextBox.Name = "StartPosXAxisTextBox";
            this.StartPosXAxisTextBox.Size = new System.Drawing.Size(75, 22);
            this.StartPosXAxisTextBox.TabIndex = 28;
            // 
            // SetStartPosButton
            // 
            this.SetStartPosButton.BackColor = System.Drawing.Color.LightBlue;
            this.SetStartPosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetStartPosButton.Location = new System.Drawing.Point(5, 131);
            this.SetStartPosButton.Margin = new System.Windows.Forms.Padding(2);
            this.SetStartPosButton.Name = "SetStartPosButton";
            this.SetStartPosButton.Size = new System.Drawing.Size(290, 71);
            this.SetStartPosButton.TabIndex = 3;
            this.SetStartPosButton.Text = "Set Starting Position";
            this.SetStartPosButton.UseVisualStyleBackColor = false;
            this.SetStartPosButton.Click += new System.EventHandler(this.SetStartPosButton_Click);
            // 
            // AddLineTab
            // 
            this.AddLineTab.Controls.Add(this.Label15);
            this.AddLineTab.Controls.Add(this.label12);
            this.AddLineTab.Controls.Add(this.label11);
            this.AddLineTab.Controls.Add(this.label10);
            this.AddLineTab.Controls.Add(this.label9);
            this.AddLineTab.Controls.Add(this.AddLineYAxisTextBox);
            this.AddLineTab.Controls.Add(this.AddLineXAxisTextBox);
            this.AddLineTab.Controls.Add(this.AddLineButton);
            this.AddLineTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLineTab.Location = new System.Drawing.Point(4, 22);
            this.AddLineTab.Name = "AddLineTab";
            this.AddLineTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddLineTab.Size = new System.Drawing.Size(300, 207);
            this.AddLineTab.TabIndex = 0;
            this.AddLineTab.Text = "Add Line";
            this.AddLineTab.UseVisualStyleBackColor = true;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(32, 10);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(199, 16);
            this.Label15.TabIndex = 28;
            this.Label15.Text = "Absolute Position of Destination:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(65, 78);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "y axis:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(65, 39);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "x axis:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(196, 78);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "counts";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(196, 39);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "counts";
            // 
            // AddLineYAxisTextBox
            // 
            this.AddLineYAxisTextBox.BackColor = System.Drawing.Color.LightGreen;
            this.AddLineYAxisTextBox.Location = new System.Drawing.Point(117, 75);
            this.AddLineYAxisTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.AddLineYAxisTextBox.Name = "AddLineYAxisTextBox";
            this.AddLineYAxisTextBox.Size = new System.Drawing.Size(75, 22);
            this.AddLineYAxisTextBox.TabIndex = 23;
            // 
            // AddLineXAxisTextBox
            // 
            this.AddLineXAxisTextBox.BackColor = System.Drawing.Color.LightGreen;
            this.AddLineXAxisTextBox.Location = new System.Drawing.Point(117, 36);
            this.AddLineXAxisTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.AddLineXAxisTextBox.Name = "AddLineXAxisTextBox";
            this.AddLineXAxisTextBox.Size = new System.Drawing.Size(75, 22);
            this.AddLineXAxisTextBox.TabIndex = 22;
            // 
            // AddLineButton
            // 
            this.AddLineButton.BackColor = System.Drawing.Color.LightBlue;
            this.AddLineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLineButton.Location = new System.Drawing.Point(5, 131);
            this.AddLineButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddLineButton.Name = "AddLineButton";
            this.AddLineButton.Size = new System.Drawing.Size(290, 71);
            this.AddLineButton.TabIndex = 2;
            this.AddLineButton.Text = "Add Line";
            this.AddLineButton.UseVisualStyleBackColor = false;
            this.AddLineButton.Click += new System.EventHandler(this.AddLineButton_Click);
            // 
            // AddArcTab
            // 
            this.AddArcTab.Controls.Add(this.label14);
            this.AddArcTab.Controls.Add(this.RadiusTextBox);
            this.AddArcTab.Controls.Add(this.label13);
            this.AddArcTab.Controls.Add(this.label17);
            this.AddArcTab.Controls.Add(this.label18);
            this.AddArcTab.Controls.Add(this.AddArcAngleTextBox);
            this.AddArcTab.Controls.Add(this.AddArcButton);
            this.AddArcTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddArcTab.Location = new System.Drawing.Point(4, 22);
            this.AddArcTab.Name = "AddArcTab";
            this.AddArcTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddArcTab.Size = new System.Drawing.Size(300, 207);
            this.AddArcTab.TabIndex = 1;
            this.AddArcTab.Text = "Add Arc";
            this.AddArcTab.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(187, 36);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 16);
            this.label14.TabIndex = 38;
            this.label14.Text = "counts";
            // 
            // RadiusTextBox
            // 
            this.RadiusTextBox.BackColor = System.Drawing.Color.LightGreen;
            this.RadiusTextBox.Location = new System.Drawing.Point(108, 33);
            this.RadiusTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.RadiusTextBox.Name = "RadiusTextBox";
            this.RadiusTextBox.Size = new System.Drawing.Size(75, 22);
            this.RadiusTextBox.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(51, 36);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 16);
            this.label13.TabIndex = 36;
            this.label13.Text = "Radius:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(56, 82);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 16);
            this.label17.TabIndex = 35;
            this.label17.Text = "Angle:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(187, 82);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 16);
            this.label18.TabIndex = 34;
            this.label18.Text = "degrees";
            // 
            // AddArcAngleTextBox
            // 
            this.AddArcAngleTextBox.BackColor = System.Drawing.Color.LightGreen;
            this.AddArcAngleTextBox.Location = new System.Drawing.Point(108, 79);
            this.AddArcAngleTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.AddArcAngleTextBox.Name = "AddArcAngleTextBox";
            this.AddArcAngleTextBox.Size = new System.Drawing.Size(75, 22);
            this.AddArcAngleTextBox.TabIndex = 33;
            // 
            // AddArcButton
            // 
            this.AddArcButton.BackColor = System.Drawing.Color.LightBlue;
            this.AddArcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddArcButton.Location = new System.Drawing.Point(5, 131);
            this.AddArcButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddArcButton.Name = "AddArcButton";
            this.AddArcButton.Size = new System.Drawing.Size(290, 71);
            this.AddArcButton.TabIndex = 5;
            this.AddArcButton.Text = "Add Arc";
            this.AddArcButton.UseVisualStyleBackColor = false;
            this.AddArcButton.Click += new System.EventHandler(this.AddArcButton_Click);
            // 
            // AddPauseTab
            // 
            this.AddPauseTab.Controls.Add(this.label19);
            this.AddPauseTab.Controls.Add(this.label20);
            this.AddPauseTab.Controls.Add(this.AddPauseTextBox);
            this.AddPauseTab.Controls.Add(this.AddPauseButton);
            this.AddPauseTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPauseTab.Location = new System.Drawing.Point(4, 22);
            this.AddPauseTab.Name = "AddPauseTab";
            this.AddPauseTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddPauseTab.Size = new System.Drawing.Size(300, 207);
            this.AddPauseTab.TabIndex = 2;
            this.AddPauseTab.Text = "Add Pause";
            this.AddPauseTab.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(25, 58);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(81, 16);
            this.label19.TabIndex = 34;
            this.label19.Text = "Time Delay:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(186, 58);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(60, 16);
            this.label20.TabIndex = 32;
            this.label20.Text = "seconds";
            // 
            // AddPauseTextBox
            // 
            this.AddPauseTextBox.BackColor = System.Drawing.Color.LightGreen;
            this.AddPauseTextBox.Location = new System.Drawing.Point(107, 55);
            this.AddPauseTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.AddPauseTextBox.Name = "AddPauseTextBox";
            this.AddPauseTextBox.Size = new System.Drawing.Size(75, 22);
            this.AddPauseTextBox.TabIndex = 33;
            // 
            // AddPauseButton
            // 
            this.AddPauseButton.BackColor = System.Drawing.Color.LightBlue;
            this.AddPauseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPauseButton.Location = new System.Drawing.Point(5, 131);
            this.AddPauseButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddPauseButton.Name = "AddPauseButton";
            this.AddPauseButton.Size = new System.Drawing.Size(290, 71);
            this.AddPauseButton.TabIndex = 20;
            this.AddPauseButton.Text = "Add Pause";
            this.AddPauseButton.UseVisualStyleBackColor = false;
            this.AddPauseButton.Click += new System.EventHandler(this.AddPauseButton_Click);
            // 
            // PlayPathTab
            // 
            this.PlayPathTab.Controls.Add(this.PlayPathButton);
            this.PlayPathTab.Location = new System.Drawing.Point(4, 22);
            this.PlayPathTab.Name = "PlayPathTab";
            this.PlayPathTab.Padding = new System.Windows.Forms.Padding(3);
            this.PlayPathTab.Size = new System.Drawing.Size(300, 207);
            this.PlayPathTab.TabIndex = 3;
            this.PlayPathTab.Text = "Play Path";
            this.PlayPathTab.UseVisualStyleBackColor = true;
            // 
            // PlayPathButton
            // 
            this.PlayPathButton.BackColor = System.Drawing.Color.LightBlue;
            this.PlayPathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayPathButton.ForeColor = System.Drawing.Color.Black;
            this.PlayPathButton.Location = new System.Drawing.Point(5, 131);
            this.PlayPathButton.Margin = new System.Windows.Forms.Padding(2);
            this.PlayPathButton.Name = "PlayPathButton";
            this.PlayPathButton.Size = new System.Drawing.Size(290, 71);
            this.PlayPathButton.TabIndex = 19;
            this.PlayPathButton.Text = "Play Path";
            this.PlayPathButton.UseVisualStyleBackColor = false;
            this.PlayPathButton.Click += new System.EventHandler(this.PlayPathButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 275);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Max Jerk:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 241);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Max Decel:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 207);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Max Accel:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Max Vel:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 241);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "counts/s^2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 275);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "counts/s^3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 207);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "counts/s^2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "counts/s";
            // 
            // MaxJerkTextBox
            // 
            this.MaxJerkTextBox.Location = new System.Drawing.Point(124, 272);
            this.MaxJerkTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MaxJerkTextBox.Name = "MaxJerkTextBox";
            this.MaxJerkTextBox.Size = new System.Drawing.Size(75, 20);
            this.MaxJerkTextBox.TabIndex = 29;
            // 
            // MaxAccelTextBox
            // 
            this.MaxAccelTextBox.Location = new System.Drawing.Point(124, 204);
            this.MaxAccelTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MaxAccelTextBox.Name = "MaxAccelTextBox";
            this.MaxAccelTextBox.Size = new System.Drawing.Size(75, 20);
            this.MaxAccelTextBox.TabIndex = 28;
            // 
            // MaxDecelTextBox
            // 
            this.MaxDecelTextBox.Location = new System.Drawing.Point(124, 239);
            this.MaxDecelTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MaxDecelTextBox.Name = "MaxDecelTextBox";
            this.MaxDecelTextBox.Size = new System.Drawing.Size(75, 20);
            this.MaxDecelTextBox.TabIndex = 27;
            // 
            // MaxVelTextBox
            // 
            this.MaxVelTextBox.Location = new System.Drawing.Point(124, 170);
            this.MaxVelTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MaxVelTextBox.Name = "MaxVelTextBox";
            this.MaxVelTextBox.Size = new System.Drawing.Size(75, 20);
            this.MaxVelTextBox.TabIndex = 26;
            // 
            // pathCommandsLabel
            // 
            this.pathCommandsLabel.AutoSize = true;
            this.pathCommandsLabel.Location = new System.Drawing.Point(122, 326);
            this.pathCommandsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pathCommandsLabel.Name = "pathCommandsLabel";
            this.pathCommandsLabel.Size = new System.Drawing.Size(84, 13);
            this.pathCommandsLabel.TabIndex = 25;
            this.pathCommandsLabel.Text = "Path Commands";
            // 
            // trajectoryCommandsLabel
            // 
            this.trajectoryCommandsLabel.AutoSize = true;
            this.trajectoryCommandsLabel.Location = new System.Drawing.Point(109, 24);
            this.trajectoryCommandsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.trajectoryCommandsLabel.Name = "trajectoryCommandsLabel";
            this.trajectoryCommandsLabel.Size = new System.Drawing.Size(109, 13);
            this.trajectoryCommandsLabel.TabIndex = 24;
            this.trajectoryCommandsLabel.Text = "Trajectory Commands";
            // 
            // HaltButton
            // 
            this.HaltButton.BackColor = System.Drawing.Color.Red;
            this.HaltButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HaltButton.Location = new System.Drawing.Point(29, 53);
            this.HaltButton.Margin = new System.Windows.Forms.Padding(2);
            this.HaltButton.Name = "HaltButton";
            this.HaltButton.Size = new System.Drawing.Size(131, 99);
            this.HaltButton.TabIndex = 23;
            this.HaltButton.Text = "Halt Linkage Move";
            this.HaltButton.UseVisualStyleBackColor = false;
            this.HaltButton.Click += new System.EventHandler(this.HaltButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Lime;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(165, 53);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(126, 99);
            this.StartButton.TabIndex = 22;
            this.StartButton.Text = "Start Linkage Move";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // PathPlanning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 714);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MaxJerkTextBox);
            this.Controls.Add(this.MaxAccelTextBox);
            this.Controls.Add(this.MaxDecelTextBox);
            this.Controls.Add(this.MaxVelTextBox);
            this.Controls.Add(this.pathCommandsLabel);
            this.Controls.Add(this.trajectoryCommandsLabel);
            this.Controls.Add(this.HaltButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.Chart);
            this.Name = "PathPlanning";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PathPlanning_FormClosing);
            this.Load += new System.EventHandler(this.PathPlanning_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.SetStartPosTab.ResumeLayout(false);
            this.SetStartPosTab.PerformLayout();
            this.AddLineTab.ResumeLayout(false);
            this.AddLineTab.PerformLayout();
            this.AddArcTab.ResumeLayout(false);
            this.AddArcTab.PerformLayout();
            this.AddPauseTab.ResumeLayout(false);
            this.AddPauseTab.PerformLayout();
            this.PlayPathTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SetStartPosTab;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox StartPosYAxisTextBox;
        private System.Windows.Forms.TextBox StartPosXAxisTextBox;
        private System.Windows.Forms.Button SetStartPosButton;
        private System.Windows.Forms.TabPage AddLineTab;
        internal System.Windows.Forms.Label Label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox AddLineYAxisTextBox;
        private System.Windows.Forms.TextBox AddLineXAxisTextBox;
        private System.Windows.Forms.Button AddLineButton;
        private System.Windows.Forms.TabPage AddArcTab;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox RadiusTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox AddArcAngleTextBox;
        private System.Windows.Forms.Button AddArcButton;
        private System.Windows.Forms.TabPage AddPauseTab;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox AddPauseTextBox;
        private System.Windows.Forms.Button AddPauseButton;
        private System.Windows.Forms.TabPage PlayPathTab;
        private System.Windows.Forms.Button PlayPathButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MaxJerkTextBox;
        private System.Windows.Forms.TextBox MaxAccelTextBox;
        private System.Windows.Forms.TextBox MaxDecelTextBox;
        private System.Windows.Forms.TextBox MaxVelTextBox;
        private System.Windows.Forms.Label pathCommandsLabel;
        private System.Windows.Forms.Label trajectoryCommandsLabel;
        private System.Windows.Forms.Button HaltButton;
        private System.Windows.Forms.Button StartButton;
    }
}

