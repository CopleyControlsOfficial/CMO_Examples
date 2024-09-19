namespace EX13_PathPlanning
{
    partial class PathPlanningPvtIntegration
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title8 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.trajectoryCommandsLabel = new System.Windows.Forms.Label();
            this.HaltButton = new System.Windows.Forms.Button();
            this.allShapesButton = new System.Windows.Forms.Button();
            this.infinityButton = new System.Windows.Forms.Button();
            this.ampersandButton = new System.Windows.Forms.Button();
            this.circleButton = new System.Windows.Forms.Button();
            this.drawHeartButton = new System.Windows.Forms.Button();
            this.stitchingButton = new System.Windows.Forms.Button();
            this.timeBetweenPointsTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeBetweenPointsTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // Chart
            // 
            chartArea3.AxisX.LabelStyle.Format = "0";
            chartArea3.AxisX2.LabelStyle.Format = "0";
            chartArea3.AxisY.LabelStyle.Format = "0";
            chartArea3.AxisY2.LabelStyle.Format = "0";
            chartArea3.BackColor = System.Drawing.Color.White;
            chartArea3.BackSecondaryColor = System.Drawing.Color.White;
            chartArea3.InnerPlotPosition.Auto = false;
            chartArea3.InnerPlotPosition.Height = 89.39832F;
            chartArea3.InnerPlotPosition.Width = 93.148F;
            chartArea3.InnerPlotPosition.X = 5.70307F;
            chartArea3.InnerPlotPosition.Y = 2.41776F;
            chartArea3.Name = "positionArea";
            chartArea3.Position.Auto = false;
            chartArea3.Position.Height = 65.14299F;
            chartArea3.Position.Width = 91.39F;
            chartArea3.Position.X = 5.60747F;
            chartArea3.Position.Y = 6.357013F;
            chartArea4.AlignWithChartArea = "positionArea";
            chartArea4.AxisX.LabelStyle.Format = "0";
            chartArea4.AxisX2.LabelStyle.Format = "0";
            chartArea4.AxisY.LabelStyle.Format = "0";
            chartArea4.AxisY2.LabelStyle.Format = "0";
            chartArea4.BackSecondaryColor = System.Drawing.Color.White;
            chartArea4.Name = "velocityArea";
            chartArea4.Position.Auto = false;
            chartArea4.Position.Height = 25F;
            chartArea4.Position.Width = 91.39F;
            chartArea4.Position.X = 5.60747F;
            chartArea4.Position.Y = 71.5F;
            this.Chart.ChartAreas.Add(chartArea3);
            this.Chart.ChartAreas.Add(chartArea4);
            this.Chart.Location = new System.Drawing.Point(337, 12);
            this.Chart.Name = "Chart";
            this.Chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.Chart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0))))),
        System.Drawing.Color.Blue};
            series4.ChartArea = "positionArea";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.IsVisibleInLegend = false;
            series4.Name = "Position Data";
            series4.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series5.ChartArea = "velocityArea";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.IsVisibleInLegend = false;
            series5.Name = "XAxisVelocity";
            series5.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series6.ChartArea = "velocityArea";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.IsVisibleInLegend = false;
            series6.Name = "YAxisVelocity";
            series6.ShadowColor = System.Drawing.Color.Red;
            this.Chart.Series.Add(series4);
            this.Chart.Series.Add(series5);
            this.Chart.Series.Add(series6);
            this.Chart.Size = new System.Drawing.Size(807, 637);
            this.Chart.TabIndex = 22;
            this.Chart.Text = "chart";
            title5.DockedToChartArea = "positionArea";
            title5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title5.IsDockedInsideChartArea = false;
            title5.Name = "yAxisPositionsTitle";
            title5.Text = "Y-Axis Position (counts)";
            title6.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Bottom;
            title6.DockedToChartArea = "positionArea";
            title6.IsDockedInsideChartArea = false;
            title6.Name = "xAxisPositionsTitle";
            title6.Text = "X-Axis Position (counts)";
            title7.DockedToChartArea = "velocityArea";
            title7.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title7.IsDockedInsideChartArea = false;
            title7.Name = "VelocitiesTitle";
            title7.Text = "Velocity (0.1 counts/sec)";
            title8.DockedToChartArea = "velocityArea";
            title8.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title8.IsDockedInsideChartArea = false;
            title8.Name = "PointTitle";
            title8.Text = "Point Number";
            this.Chart.Titles.Add(title5);
            this.Chart.Titles.Add(title6);
            this.Chart.Titles.Add(title7);
            this.Chart.Titles.Add(title8);
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
            this.HaltButton.Location = new System.Drawing.Point(30, 434);
            this.HaltButton.Margin = new System.Windows.Forms.Padding(2);
            this.HaltButton.Name = "HaltButton";
            this.HaltButton.Size = new System.Drawing.Size(267, 123);
            this.HaltButton.TabIndex = 23;
            this.HaltButton.Text = "HALT";
            this.HaltButton.UseVisualStyleBackColor = false;
            this.HaltButton.Click += new System.EventHandler(this.HaltButton_Click);
            // 
            // allShapesButton
            // 
            this.allShapesButton.BackColor = System.Drawing.Color.White;
            this.allShapesButton.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allShapesButton.ForeColor = System.Drawing.Color.Red;
            this.allShapesButton.Location = new System.Drawing.Point(29, 53);
            this.allShapesButton.Name = "allShapesButton";
            this.allShapesButton.Size = new System.Drawing.Size(131, 121);
            this.allShapesButton.TabIndex = 42;
            this.allShapesButton.Text = "INFINITE LOOP";
            this.allShapesButton.UseVisualStyleBackColor = false;
            this.allShapesButton.Click += new System.EventHandler(this.allShapesButton_Click);
            // 
            // infinityButton
            // 
            this.infinityButton.BackColor = System.Drawing.Color.White;
            this.infinityButton.Image = global::EX13_PathPlanning.Properties.Resources.infinity_logo2;
            this.infinityButton.Location = new System.Drawing.Point(29, 308);
            this.infinityButton.Name = "infinityButton";
            this.infinityButton.Size = new System.Drawing.Size(131, 121);
            this.infinityButton.TabIndex = 43;
            this.infinityButton.UseVisualStyleBackColor = false;
            this.infinityButton.Click += new System.EventHandler(this.infinityButton_Click);
            // 
            // ampersandButton
            // 
            this.ampersandButton.BackColor = System.Drawing.Color.White;
            this.ampersandButton.Image = global::EX13_PathPlanning.Properties.Resources._161_1618970_png_transparent_ampersand_red_ampersand_symbol;
            this.ampersandButton.Location = new System.Drawing.Point(165, 181);
            this.ampersandButton.Name = "ampersandButton";
            this.ampersandButton.Size = new System.Drawing.Size(131, 121);
            this.ampersandButton.TabIndex = 41;
            this.ampersandButton.UseVisualStyleBackColor = false;
            this.ampersandButton.Click += new System.EventHandler(this.ampersandButton_Click);
            // 
            // circleButton
            // 
            this.circleButton.BackColor = System.Drawing.Color.White;
            this.circleButton.Image = global::EX13_PathPlanning.Properties.Resources.circle1;
            this.circleButton.Location = new System.Drawing.Point(29, 181);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(131, 121);
            this.circleButton.TabIndex = 40;
            this.circleButton.UseVisualStyleBackColor = false;
            this.circleButton.Click += new System.EventHandler(this.circleButton_Click);
            // 
            // drawHeartButton
            // 
            this.drawHeartButton.BackColor = System.Drawing.Color.White;
            this.drawHeartButton.Image = global::EX13_PathPlanning.Properties.Resources.Heart_icon_red_hollow_svg;
            this.drawHeartButton.Location = new System.Drawing.Point(165, 53);
            this.drawHeartButton.Name = "drawHeartButton";
            this.drawHeartButton.Size = new System.Drawing.Size(131, 121);
            this.drawHeartButton.TabIndex = 39;
            this.drawHeartButton.UseVisualStyleBackColor = false;
            this.drawHeartButton.Click += new System.EventHandler(this.drawHeartButton_Click);
            // 
            // stitchingButton
            // 
            this.stitchingButton.BackColor = System.Drawing.Color.White;
            this.stitchingButton.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stitchingButton.ForeColor = System.Drawing.Color.Red;
            this.stitchingButton.Location = new System.Drawing.Point(166, 308);
            this.stitchingButton.Name = "stitchingButton";
            this.stitchingButton.Size = new System.Drawing.Size(131, 121);
            this.stitchingButton.TabIndex = 44;
            this.stitchingButton.Text = "Stitching Pattern";
            this.stitchingButton.UseVisualStyleBackColor = false;
            this.stitchingButton.Click += new System.EventHandler(this.stitchingButton_Click);
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
            this.Controls.Add(this.stitchingButton);
            this.Controls.Add(this.infinityButton);
            this.Controls.Add(this.allShapesButton);
            this.Controls.Add(this.ampersandButton);
            this.Controls.Add(this.circleButton);
            this.Controls.Add(this.drawHeartButton);
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
        private System.Windows.Forms.Button drawHeartButton;
        private System.Windows.Forms.Button circleButton;
        private System.Windows.Forms.Button ampersandButton;
        private System.Windows.Forms.Button allShapesButton;
        private System.Windows.Forms.Button infinityButton;
        private System.Windows.Forms.Button stitchingButton;
        private System.Windows.Forms.TrackBar timeBetweenPointsTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

