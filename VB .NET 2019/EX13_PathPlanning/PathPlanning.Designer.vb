<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PathPlanning
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim Title3 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim Title4 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.SetStartPosTab = New System.Windows.Forms.TabPage()
        Me.label21 = New System.Windows.Forms.Label()
        Me.label22 = New System.Windows.Forms.Label()
        Me.label23 = New System.Windows.Forms.Label()
        Me.label24 = New System.Windows.Forms.Label()
        Me.StartPosYAxisTextBox = New System.Windows.Forms.TextBox()
        Me.StartPosXAxisTextBox = New System.Windows.Forms.TextBox()
        Me.SetStartPosButton = New System.Windows.Forms.Button()
        Me.AddLineTab = New System.Windows.Forms.TabPage()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.AddLineYAxisTextBox = New System.Windows.Forms.TextBox()
        Me.AddLineXAxisTextBox = New System.Windows.Forms.TextBox()
        Me.AddLineButton = New System.Windows.Forms.Button()
        Me.AddArcTab = New System.Windows.Forms.TabPage()
        Me.label14 = New System.Windows.Forms.Label()
        Me.RadiusTextBox = New System.Windows.Forms.TextBox()
        Me.label13 = New System.Windows.Forms.Label()
        Me.label17 = New System.Windows.Forms.Label()
        Me.label18 = New System.Windows.Forms.Label()
        Me.AddArcAngleTextBox = New System.Windows.Forms.TextBox()
        Me.AddArcButton = New System.Windows.Forms.Button()
        Me.AddPauseTab = New System.Windows.Forms.TabPage()
        Me.label19 = New System.Windows.Forms.Label()
        Me.label20 = New System.Windows.Forms.Label()
        Me.AddPauseTextBox = New System.Windows.Forms.TextBox()
        Me.AddPauseButton = New System.Windows.Forms.Button()
        Me.PlayPathTab = New System.Windows.Forms.TabPage()
        Me.PlayPathButton = New System.Windows.Forms.Button()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.MaxJerkTextBox = New System.Windows.Forms.TextBox()
        Me.MaxAccelTextBox = New System.Windows.Forms.TextBox()
        Me.MaxDecelTextBox = New System.Windows.Forms.TextBox()
        Me.MaxVelTextBox = New System.Windows.Forms.TextBox()
        Me.pathCommandsLabel = New System.Windows.Forms.Label()
        Me.trajectoryCommandsLabel = New System.Windows.Forms.Label()
        Me.HaltButton = New System.Windows.Forms.Button()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.Chart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.tabControl1.SuspendLayout()
        Me.SetStartPosTab.SuspendLayout()
        Me.AddLineTab.SuspendLayout()
        Me.AddArcTab.SuspendLayout()
        Me.AddPauseTab.SuspendLayout()
        Me.PlayPathTab.SuspendLayout()
        CType(Me.Chart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.SetStartPosTab)
        Me.tabControl1.Controls.Add(Me.AddLineTab)
        Me.tabControl1.Controls.Add(Me.AddArcTab)
        Me.tabControl1.Controls.Add(Me.AddPauseTab)
        Me.tabControl1.Controls.Add(Me.PlayPathTab)
        Me.tabControl1.Location = New System.Drawing.Point(12, 349)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(308, 233)
        Me.tabControl1.TabIndex = 38
        '
        'SetStartPosTab
        '
        Me.SetStartPosTab.Controls.Add(Me.label21)
        Me.SetStartPosTab.Controls.Add(Me.label22)
        Me.SetStartPosTab.Controls.Add(Me.label23)
        Me.SetStartPosTab.Controls.Add(Me.label24)
        Me.SetStartPosTab.Controls.Add(Me.StartPosYAxisTextBox)
        Me.SetStartPosTab.Controls.Add(Me.StartPosXAxisTextBox)
        Me.SetStartPosTab.Controls.Add(Me.SetStartPosButton)
        Me.SetStartPosTab.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetStartPosTab.Location = New System.Drawing.Point(4, 22)
        Me.SetStartPosTab.Name = "SetStartPosTab"
        Me.SetStartPosTab.Padding = New System.Windows.Forms.Padding(3)
        Me.SetStartPosTab.Size = New System.Drawing.Size(300, 207)
        Me.SetStartPosTab.TabIndex = 4
        Me.SetStartPosTab.Text = "Set Start Pos"
        Me.SetStartPosTab.UseVisualStyleBackColor = True
        '
        'label21
        '
        Me.label21.AutoSize = True
        Me.label21.Location = New System.Drawing.Point(65, 78)
        Me.label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label21.Name = "label21"
        Me.label21.Size = New System.Drawing.Size(45, 16)
        Me.label21.TabIndex = 32
        Me.label21.Text = "y axis:"
        '
        'label22
        '
        Me.label22.AutoSize = True
        Me.label22.Location = New System.Drawing.Point(65, 39)
        Me.label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label22.Name = "label22"
        Me.label22.Size = New System.Drawing.Size(44, 16)
        Me.label22.TabIndex = 31
        Me.label22.Text = "x axis:"
        '
        'label23
        '
        Me.label23.AutoSize = True
        Me.label23.Location = New System.Drawing.Point(196, 78)
        Me.label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label23.Name = "label23"
        Me.label23.Size = New System.Drawing.Size(47, 16)
        Me.label23.TabIndex = 30
        Me.label23.Text = "counts"
        '
        'label24
        '
        Me.label24.AutoSize = True
        Me.label24.Location = New System.Drawing.Point(196, 39)
        Me.label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label24.Name = "label24"
        Me.label24.Size = New System.Drawing.Size(47, 16)
        Me.label24.TabIndex = 27
        Me.label24.Text = "counts"
        '
        'StartPosYAxisTextBox
        '
        Me.StartPosYAxisTextBox.BackColor = System.Drawing.Color.LightGreen
        Me.StartPosYAxisTextBox.Location = New System.Drawing.Point(117, 75)
        Me.StartPosYAxisTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.StartPosYAxisTextBox.Name = "StartPosYAxisTextBox"
        Me.StartPosYAxisTextBox.Size = New System.Drawing.Size(75, 22)
        Me.StartPosYAxisTextBox.TabIndex = 29
        '
        'StartPosXAxisTextBox
        '
        Me.StartPosXAxisTextBox.BackColor = System.Drawing.Color.LightGreen
        Me.StartPosXAxisTextBox.Location = New System.Drawing.Point(117, 36)
        Me.StartPosXAxisTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.StartPosXAxisTextBox.Name = "StartPosXAxisTextBox"
        Me.StartPosXAxisTextBox.Size = New System.Drawing.Size(75, 22)
        Me.StartPosXAxisTextBox.TabIndex = 28
        '
        'SetStartPosButton
        '
        Me.SetStartPosButton.BackColor = System.Drawing.Color.LightBlue
        Me.SetStartPosButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetStartPosButton.Location = New System.Drawing.Point(5, 131)
        Me.SetStartPosButton.Margin = New System.Windows.Forms.Padding(2)
        Me.SetStartPosButton.Name = "SetStartPosButton"
        Me.SetStartPosButton.Size = New System.Drawing.Size(290, 71)
        Me.SetStartPosButton.TabIndex = 3
        Me.SetStartPosButton.Text = "Set Starting Position"
        Me.SetStartPosButton.UseVisualStyleBackColor = False
        '
        'AddLineTab
        '
        Me.AddLineTab.Controls.Add(Me.Label15)
        Me.AddLineTab.Controls.Add(Me.label12)
        Me.AddLineTab.Controls.Add(Me.label11)
        Me.AddLineTab.Controls.Add(Me.label10)
        Me.AddLineTab.Controls.Add(Me.label9)
        Me.AddLineTab.Controls.Add(Me.AddLineYAxisTextBox)
        Me.AddLineTab.Controls.Add(Me.AddLineXAxisTextBox)
        Me.AddLineTab.Controls.Add(Me.AddLineButton)
        Me.AddLineTab.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddLineTab.Location = New System.Drawing.Point(4, 22)
        Me.AddLineTab.Name = "AddLineTab"
        Me.AddLineTab.Padding = New System.Windows.Forms.Padding(3)
        Me.AddLineTab.Size = New System.Drawing.Size(300, 207)
        Me.AddLineTab.TabIndex = 0
        Me.AddLineTab.Text = "Add Line"
        Me.AddLineTab.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(40, 10)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(199, 16)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Absolute Position of Destination:"
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Location = New System.Drawing.Point(65, 78)
        Me.label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(45, 16)
        Me.label12.TabIndex = 26
        Me.label12.Text = "y axis:"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(65, 39)
        Me.label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(44, 16)
        Me.label11.TabIndex = 25
        Me.label11.Text = "x axis:"
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(196, 78)
        Me.label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(47, 16)
        Me.label10.TabIndex = 24
        Me.label10.Text = "counts"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(196, 39)
        Me.label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(47, 16)
        Me.label9.TabIndex = 22
        Me.label9.Text = "counts"
        '
        'AddLineYAxisTextBox
        '
        Me.AddLineYAxisTextBox.BackColor = System.Drawing.Color.LightGreen
        Me.AddLineYAxisTextBox.Location = New System.Drawing.Point(117, 75)
        Me.AddLineYAxisTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.AddLineYAxisTextBox.Name = "AddLineYAxisTextBox"
        Me.AddLineYAxisTextBox.Size = New System.Drawing.Size(75, 22)
        Me.AddLineYAxisTextBox.TabIndex = 23
        '
        'AddLineXAxisTextBox
        '
        Me.AddLineXAxisTextBox.BackColor = System.Drawing.Color.LightGreen
        Me.AddLineXAxisTextBox.Location = New System.Drawing.Point(117, 36)
        Me.AddLineXAxisTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.AddLineXAxisTextBox.Name = "AddLineXAxisTextBox"
        Me.AddLineXAxisTextBox.Size = New System.Drawing.Size(75, 22)
        Me.AddLineXAxisTextBox.TabIndex = 22
        '
        'AddLineButton
        '
        Me.AddLineButton.BackColor = System.Drawing.Color.LightBlue
        Me.AddLineButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddLineButton.Location = New System.Drawing.Point(5, 131)
        Me.AddLineButton.Margin = New System.Windows.Forms.Padding(2)
        Me.AddLineButton.Name = "AddLineButton"
        Me.AddLineButton.Size = New System.Drawing.Size(290, 71)
        Me.AddLineButton.TabIndex = 2
        Me.AddLineButton.Text = "Add Line"
        Me.AddLineButton.UseVisualStyleBackColor = False
        '
        'AddArcTab
        '
        Me.AddArcTab.Controls.Add(Me.label14)
        Me.AddArcTab.Controls.Add(Me.RadiusTextBox)
        Me.AddArcTab.Controls.Add(Me.label13)
        Me.AddArcTab.Controls.Add(Me.label17)
        Me.AddArcTab.Controls.Add(Me.label18)
        Me.AddArcTab.Controls.Add(Me.AddArcAngleTextBox)
        Me.AddArcTab.Controls.Add(Me.AddArcButton)
        Me.AddArcTab.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddArcTab.Location = New System.Drawing.Point(4, 22)
        Me.AddArcTab.Name = "AddArcTab"
        Me.AddArcTab.Padding = New System.Windows.Forms.Padding(3)
        Me.AddArcTab.Size = New System.Drawing.Size(300, 207)
        Me.AddArcTab.TabIndex = 1
        Me.AddArcTab.Text = "Add Arc"
        Me.AddArcTab.UseVisualStyleBackColor = True
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.Location = New System.Drawing.Point(187, 50)
        Me.label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(47, 16)
        Me.label14.TabIndex = 38
        Me.label14.Text = "counts"
        '
        'RadiusTextBox
        '
        Me.RadiusTextBox.BackColor = System.Drawing.Color.LightGreen
        Me.RadiusTextBox.Location = New System.Drawing.Point(108, 47)
        Me.RadiusTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.RadiusTextBox.Name = "RadiusTextBox"
        Me.RadiusTextBox.Size = New System.Drawing.Size(75, 22)
        Me.RadiusTextBox.TabIndex = 37
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Location = New System.Drawing.Point(51, 50)
        Me.label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(54, 16)
        Me.label13.TabIndex = 36
        Me.label13.Text = "Radius:"
        '
        'label17
        '
        Me.label17.AutoSize = True
        Me.label17.Location = New System.Drawing.Point(56, 96)
        Me.label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(46, 16)
        Me.label17.TabIndex = 35
        Me.label17.Text = "Angle:"
        '
        'label18
        '
        Me.label18.AutoSize = True
        Me.label18.Location = New System.Drawing.Point(187, 96)
        Me.label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label18.Name = "label18"
        Me.label18.Size = New System.Drawing.Size(59, 16)
        Me.label18.TabIndex = 34
        Me.label18.Text = "degrees"
        '
        'AddArcAngleTextBox
        '
        Me.AddArcAngleTextBox.BackColor = System.Drawing.Color.LightGreen
        Me.AddArcAngleTextBox.Location = New System.Drawing.Point(108, 93)
        Me.AddArcAngleTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.AddArcAngleTextBox.Name = "AddArcAngleTextBox"
        Me.AddArcAngleTextBox.Size = New System.Drawing.Size(75, 22)
        Me.AddArcAngleTextBox.TabIndex = 33
        '
        'AddArcButton
        '
        Me.AddArcButton.BackColor = System.Drawing.Color.LightBlue
        Me.AddArcButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddArcButton.Location = New System.Drawing.Point(5, 131)
        Me.AddArcButton.Margin = New System.Windows.Forms.Padding(2)
        Me.AddArcButton.Name = "AddArcButton"
        Me.AddArcButton.Size = New System.Drawing.Size(290, 71)
        Me.AddArcButton.TabIndex = 5
        Me.AddArcButton.Text = "Add Arc"
        Me.AddArcButton.UseVisualStyleBackColor = False
        '
        'AddPauseTab
        '
        Me.AddPauseTab.Controls.Add(Me.label19)
        Me.AddPauseTab.Controls.Add(Me.label20)
        Me.AddPauseTab.Controls.Add(Me.AddPauseTextBox)
        Me.AddPauseTab.Controls.Add(Me.AddPauseButton)
        Me.AddPauseTab.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddPauseTab.Location = New System.Drawing.Point(4, 22)
        Me.AddPauseTab.Name = "AddPauseTab"
        Me.AddPauseTab.Padding = New System.Windows.Forms.Padding(3)
        Me.AddPauseTab.Size = New System.Drawing.Size(300, 207)
        Me.AddPauseTab.TabIndex = 2
        Me.AddPauseTab.Text = "Add Pause"
        Me.AddPauseTab.UseVisualStyleBackColor = True
        '
        'label19
        '
        Me.label19.AutoSize = True
        Me.label19.Location = New System.Drawing.Point(23, 58)
        Me.label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label19.Name = "label19"
        Me.label19.Size = New System.Drawing.Size(81, 16)
        Me.label19.TabIndex = 34
        Me.label19.Text = "Time Delay:"
        '
        'label20
        '
        Me.label20.AutoSize = True
        Me.label20.Location = New System.Drawing.Point(186, 58)
        Me.label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label20.Name = "label20"
        Me.label20.Size = New System.Drawing.Size(60, 16)
        Me.label20.TabIndex = 32
        Me.label20.Text = "seconds"
        '
        'AddPauseTextBox
        '
        Me.AddPauseTextBox.BackColor = System.Drawing.Color.LightGreen
        Me.AddPauseTextBox.Location = New System.Drawing.Point(107, 55)
        Me.AddPauseTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.AddPauseTextBox.Name = "AddPauseTextBox"
        Me.AddPauseTextBox.Size = New System.Drawing.Size(75, 22)
        Me.AddPauseTextBox.TabIndex = 33
        '
        'AddPauseButton
        '
        Me.AddPauseButton.BackColor = System.Drawing.Color.LightBlue
        Me.AddPauseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddPauseButton.Location = New System.Drawing.Point(5, 131)
        Me.AddPauseButton.Margin = New System.Windows.Forms.Padding(2)
        Me.AddPauseButton.Name = "AddPauseButton"
        Me.AddPauseButton.Size = New System.Drawing.Size(290, 71)
        Me.AddPauseButton.TabIndex = 20
        Me.AddPauseButton.Text = "Add Pause"
        Me.AddPauseButton.UseVisualStyleBackColor = False
        '
        'PlayPathTab
        '
        Me.PlayPathTab.Controls.Add(Me.PlayPathButton)
        Me.PlayPathTab.Location = New System.Drawing.Point(4, 22)
        Me.PlayPathTab.Name = "PlayPathTab"
        Me.PlayPathTab.Padding = New System.Windows.Forms.Padding(3)
        Me.PlayPathTab.Size = New System.Drawing.Size(300, 207)
        Me.PlayPathTab.TabIndex = 3
        Me.PlayPathTab.Text = "Play Path"
        Me.PlayPathTab.UseVisualStyleBackColor = True
        '
        'PlayPathButton
        '
        Me.PlayPathButton.BackColor = System.Drawing.Color.LightBlue
        Me.PlayPathButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayPathButton.ForeColor = System.Drawing.Color.Black
        Me.PlayPathButton.Location = New System.Drawing.Point(5, 131)
        Me.PlayPathButton.Margin = New System.Windows.Forms.Padding(2)
        Me.PlayPathButton.Name = "PlayPathButton"
        Me.PlayPathButton.Size = New System.Drawing.Size(290, 71)
        Me.PlayPathButton.TabIndex = 19
        Me.PlayPathButton.Text = "Play Path"
        Me.PlayPathButton.UseVisualStyleBackColor = False
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(67, 272)
        Me.label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(53, 13)
        Me.label8.TabIndex = 37
        Me.label8.Text = "Max Jerk:"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(60, 238)
        Me.label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(61, 13)
        Me.label7.TabIndex = 36
        Me.label7.Text = "Max Decel:"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(61, 204)
        Me.label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(60, 13)
        Me.label6.TabIndex = 35
        Me.label6.Text = "Max Accel:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(72, 169)
        Me.label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(48, 13)
        Me.label3.TabIndex = 34
        Me.label3.Text = "Max Vel:"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(203, 238)
        Me.label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(61, 13)
        Me.label5.TabIndex = 33
        Me.label5.Text = "counts/s^2"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(203, 272)
        Me.label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(61, 13)
        Me.label4.TabIndex = 32
        Me.label4.Text = "counts/s^3"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(203, 204)
        Me.label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(61, 13)
        Me.label2.TabIndex = 31
        Me.label2.Text = "counts/s^2"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(203, 169)
        Me.label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(49, 13)
        Me.label1.TabIndex = 30
        Me.label1.Text = "counts/s"
        '
        'MaxJerkTextBox
        '
        Me.MaxJerkTextBox.Location = New System.Drawing.Point(124, 269)
        Me.MaxJerkTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.MaxJerkTextBox.Name = "MaxJerkTextBox"
        Me.MaxJerkTextBox.Size = New System.Drawing.Size(75, 20)
        Me.MaxJerkTextBox.TabIndex = 29
        '
        'MaxAccelTextBox
        '
        Me.MaxAccelTextBox.Location = New System.Drawing.Point(124, 201)
        Me.MaxAccelTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.MaxAccelTextBox.Name = "MaxAccelTextBox"
        Me.MaxAccelTextBox.Size = New System.Drawing.Size(75, 20)
        Me.MaxAccelTextBox.TabIndex = 28
        '
        'MaxDecelTextBox
        '
        Me.MaxDecelTextBox.Location = New System.Drawing.Point(124, 236)
        Me.MaxDecelTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.MaxDecelTextBox.Name = "MaxDecelTextBox"
        Me.MaxDecelTextBox.Size = New System.Drawing.Size(75, 20)
        Me.MaxDecelTextBox.TabIndex = 27
        '
        'MaxVelTextBox
        '
        Me.MaxVelTextBox.Location = New System.Drawing.Point(124, 167)
        Me.MaxVelTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.MaxVelTextBox.Name = "MaxVelTextBox"
        Me.MaxVelTextBox.Size = New System.Drawing.Size(75, 20)
        Me.MaxVelTextBox.TabIndex = 26
        '
        'pathCommandsLabel
        '
        Me.pathCommandsLabel.AutoSize = True
        Me.pathCommandsLabel.Location = New System.Drawing.Point(122, 323)
        Me.pathCommandsLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.pathCommandsLabel.Name = "pathCommandsLabel"
        Me.pathCommandsLabel.Size = New System.Drawing.Size(84, 13)
        Me.pathCommandsLabel.TabIndex = 25
        Me.pathCommandsLabel.Text = "Path Commands"
        '
        'trajectoryCommandsLabel
        '
        Me.trajectoryCommandsLabel.AutoSize = True
        Me.trajectoryCommandsLabel.Location = New System.Drawing.Point(109, 21)
        Me.trajectoryCommandsLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.trajectoryCommandsLabel.Name = "trajectoryCommandsLabel"
        Me.trajectoryCommandsLabel.Size = New System.Drawing.Size(109, 13)
        Me.trajectoryCommandsLabel.TabIndex = 24
        Me.trajectoryCommandsLabel.Text = "Trajectory Commands"
        '
        'HaltButton
        '
        Me.HaltButton.BackColor = System.Drawing.Color.Red
        Me.HaltButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HaltButton.Location = New System.Drawing.Point(29, 50)
        Me.HaltButton.Margin = New System.Windows.Forms.Padding(2)
        Me.HaltButton.Name = "HaltButton"
        Me.HaltButton.Size = New System.Drawing.Size(131, 99)
        Me.HaltButton.TabIndex = 23
        Me.HaltButton.Text = "Halt Linkage Move"
        Me.HaltButton.UseVisualStyleBackColor = False
        '
        'StartButton
        '
        Me.StartButton.BackColor = System.Drawing.Color.Lime
        Me.StartButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartButton.Location = New System.Drawing.Point(165, 50)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(126, 99)
        Me.StartButton.TabIndex = 22
        Me.StartButton.Text = "Start Linkage Move"
        Me.StartButton.UseVisualStyleBackColor = False
        '
        'Chart
        '
        ChartArea1.AxisX.LabelStyle.Format = "0"
        ChartArea1.AxisX2.LabelStyle.Format = "0"
        ChartArea1.AxisY.LabelStyle.Format = "0"
        ChartArea1.AxisY2.LabelStyle.Format = "0"
        ChartArea1.BackColor = System.Drawing.Color.White
        ChartArea1.BackSecondaryColor = System.Drawing.Color.White
        ChartArea1.InnerPlotPosition.Auto = False
        ChartArea1.InnerPlotPosition.Height = 89.39832!
        ChartArea1.InnerPlotPosition.Width = 93.148!
        ChartArea1.InnerPlotPosition.X = 5.70307!
        ChartArea1.InnerPlotPosition.Y = 2.41776!
        ChartArea1.Name = "positionArea"
        ChartArea1.Position.Auto = False
        ChartArea1.Position.Height = 65.14299!
        ChartArea1.Position.Width = 91.39!
        ChartArea1.Position.X = 5.60747!
        ChartArea1.Position.Y = 6.357013!
        ChartArea2.AlignWithChartArea = "positionArea"
        ChartArea2.AxisX.LabelStyle.Format = "0"
        ChartArea2.AxisX2.LabelStyle.Format = "0"
        ChartArea2.AxisY.LabelStyle.Format = "0"
        ChartArea2.AxisY2.LabelStyle.Format = "0"
        ChartArea2.BackSecondaryColor = System.Drawing.Color.White
        ChartArea2.Name = "velocityArea"
        ChartArea2.Position.Auto = False
        ChartArea2.Position.Height = 25.0!
        ChartArea2.Position.Width = 91.39!
        ChartArea2.Position.X = 5.60747!
        ChartArea2.Position.Y = 71.5!
        Me.Chart.ChartAreas.Add(ChartArea1)
        Me.Chart.ChartAreas.Add(ChartArea2)
        Me.Chart.Location = New System.Drawing.Point(337, 12)
        Me.Chart.Name = "Chart"
        Me.Chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.Chart.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.Red, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.Blue}
        Series1.ChartArea = "positionArea"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.IsVisibleInLegend = False
        Series1.Name = "Position Data"
        Series1.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Double]
        Series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Double]
        Series2.ChartArea = "velocityArea"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series2.IsVisibleInLegend = False
        Series2.Name = "XAxisVelocity"
        Series2.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Series3.ChartArea = "velocityArea"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series3.IsVisibleInLegend = False
        Series3.Name = "YAxisVelocity"
        Series3.ShadowColor = System.Drawing.Color.Red
        Me.Chart.Series.Add(Series1)
        Me.Chart.Series.Add(Series2)
        Me.Chart.Series.Add(Series3)
        Me.Chart.Size = New System.Drawing.Size(807, 690)
        Me.Chart.TabIndex = 22
        Me.Chart.Text = "chart"
        Title1.DockedToChartArea = "positionArea"
        Title1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left
        Title1.IsDockedInsideChartArea = False
        Title1.Name = "yAxisPositionsTitle"
        Title1.Text = "Y-Axis Position (counts)"
        Title2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Bottom
        Title2.DockedToChartArea = "positionArea"
        Title2.IsDockedInsideChartArea = False
        Title2.Name = "xAxisPositionsTitle"
        Title2.Text = "X-Axis Position (counts)"
        Title3.DockedToChartArea = "velocityArea"
        Title3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left
        Title3.IsDockedInsideChartArea = False
        Title3.Name = "VelocitiesTitle"
        Title3.Text = "Velocity (0.1 counts/sec)"
        Title4.DockedToChartArea = "velocityArea"
        Title4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
        Title4.IsDockedInsideChartArea = False
        Title4.Name = "PointTitle"
        Title4.Text = "Point Number"
        Me.Chart.Titles.Add(Title1)
        Me.Chart.Titles.Add(Title2)
        Me.Chart.Titles.Add(Title3)
        Me.Chart.Titles.Add(Title4)
        '
        'PathPlanning
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1217, 714)
        Me.Controls.Add(Me.Chart)
        Me.Controls.Add(Me.tabControl1)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.MaxJerkTextBox)
        Me.Controls.Add(Me.MaxAccelTextBox)
        Me.Controls.Add(Me.MaxDecelTextBox)
        Me.Controls.Add(Me.MaxVelTextBox)
        Me.Controls.Add(Me.pathCommandsLabel)
        Me.Controls.Add(Me.trajectoryCommandsLabel)
        Me.Controls.Add(Me.HaltButton)
        Me.Controls.Add(Me.StartButton)
        Me.Name = "PathPlanning"
        Me.Text = "Form1"
        Me.tabControl1.ResumeLayout(False)
        Me.SetStartPosTab.ResumeLayout(False)
        Me.SetStartPosTab.PerformLayout()
        Me.AddLineTab.ResumeLayout(False)
        Me.AddLineTab.PerformLayout()
        Me.AddArcTab.ResumeLayout(False)
        Me.AddArcTab.PerformLayout()
        Me.AddPauseTab.ResumeLayout(False)
        Me.AddPauseTab.PerformLayout()
        Me.PlayPathTab.ResumeLayout(False)
        CType(Me.Chart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents tabControl1 As TabControl
    Private WithEvents SetStartPosTab As TabPage
    Private WithEvents label21 As Label
    Private WithEvents label22 As Label
    Private WithEvents label23 As Label
    Private WithEvents label24 As Label
    Private WithEvents StartPosYAxisTextBox As TextBox
    Private WithEvents StartPosXAxisTextBox As TextBox
    Private WithEvents SetStartPosButton As Button
    Private WithEvents AddLineTab As TabPage
    Private WithEvents label12 As Label
    Private WithEvents label11 As Label
    Private WithEvents label10 As Label
    Private WithEvents label9 As Label
    Private WithEvents AddLineYAxisTextBox As TextBox
    Private WithEvents AddLineXAxisTextBox As TextBox
    Private WithEvents AddLineButton As Button
    Private WithEvents AddArcTab As TabPage
    Private WithEvents label14 As Label
    Private WithEvents RadiusTextBox As TextBox
    Private WithEvents label13 As Label
    Private WithEvents label17 As Label
    Private WithEvents label18 As Label
    Private WithEvents AddArcAngleTextBox As TextBox
    Private WithEvents AddArcButton As Button
    Private WithEvents AddPauseTab As TabPage
    Private WithEvents label19 As Label
    Private WithEvents label20 As Label
    Private WithEvents AddPauseTextBox As TextBox
    Private WithEvents AddPauseButton As Button
    Private WithEvents PlayPathTab As TabPage
    Private WithEvents PlayPathButton As Button
    Private WithEvents label8 As Label
    Private WithEvents label7 As Label
    Private WithEvents label6 As Label
    Private WithEvents label3 As Label
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents MaxJerkTextBox As TextBox
    Private WithEvents MaxAccelTextBox As TextBox
    Private WithEvents MaxDecelTextBox As TextBox
    Private WithEvents MaxVelTextBox As TextBox
    Private WithEvents pathCommandsLabel As Label
    Private WithEvents trajectoryCommandsLabel As Label
    Private WithEvents HaltButton As Button
    Private WithEvents StartButton As Button
    Friend WithEvents Chart As DataVisualization.Charting.Chart
    Friend WithEvents Label15 As Label
End Class
