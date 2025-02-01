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
            this.trajectoryCommandsLabel = new System.Windows.Forms.Label();
            this.HaltButton = new System.Windows.Forms.Button();
            this.circleButton = new System.Windows.Forms.Button();
            this.timeBetweenPointsTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeBetweenPointsTrackBar)).BeginInit();
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
            this.Chart.Size = new System.Drawing.Size(807, 637);
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
            this.HaltButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HaltButton.Location = new System.Drawing.Point(30, 307);
            this.HaltButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HaltButton.Name = "HaltButton";
            this.HaltButton.Size = new System.Drawing.Size(267, 123);
            this.HaltButton.TabIndex = 23;
            this.HaltButton.Text = "HALT";
            this.HaltButton.UseVisualStyleBackColor = false;
            this.HaltButton.Click += new System.EventHandler(this.HaltButton_Click);
            // 
            // circleButton
            // 
            this.circleButton.BackColor = System.Drawing.Color.White;
            this.circleButton.Image = global::EX13_PathPlanning.Properties.Resources.circle1;
            this.circleButton.Location = new System.Drawing.Point(30, 56);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(266, 246);
            this.circleButton.TabIndex = 40;
            this.circleButton.UseVisualStyleBackColor = false;
            this.circleButton.Click += new System.EventHandler(this.circleButton_Click);
            // 
            // timeBetweenPointsTrackBar
            // 
            this.timeBetweenPointsTrackBar.Location = new System.Drawing.Point(29, 562);
            this.timeBetweenPointsTrackBar.Minimum = 1;
            this.timeBetweenPointsTrackBar.Name = "timeBetweenPointsTrackBar";
            this.timeBetweenPointsTrackBar.Size = new System.Drawing.Size(267, 45);
            this.timeBetweenPointsTrackBar.TabIndex = 45;
            this.timeBetweenPointsTrackBar.Value = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 594);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "1 ms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 594);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "10 ms";
            // 
            // PathPlanning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 659);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeBetweenPointsTrackBar);
            this.Controls.Add(this.circleButton);
            this.Controls.Add(this.trajectoryCommandsLabel);
            this.Controls.Add(this.HaltButton);
            this.Controls.Add(this.Chart);
            this.Name = "PathPlanning";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PathPlanning_FormClosing);
            this.Load += new System.EventHandler(this.PathPlanning_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeBetweenPointsTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.Label trajectoryCommandsLabel;
        private System.Windows.Forms.Button HaltButton;
        private System.Windows.Forms.Button circleButton;
        private System.Windows.Forms.TrackBar timeBetweenPointsTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

