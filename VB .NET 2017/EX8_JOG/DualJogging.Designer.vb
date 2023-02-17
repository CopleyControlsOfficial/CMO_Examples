<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DualJogging
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
        Me.components = New System.ComponentModel.Container()
        Me.label31 = New System.Windows.Forms.Label()
        Me.label30 = New System.Windows.Forms.Label()
        Me.label29 = New System.Windows.Forms.Label()
        Me.label26 = New System.Windows.Forms.Label()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ActVelVar_1 = New System.Windows.Forms.Label()
        Me.ActVelVar_2 = New System.Windows.Forms.Label()
        Me.label28 = New System.Windows.Forms.Label()
        Me.label27 = New System.Windows.Forms.Label()
        Me.label25 = New System.Windows.Forms.Label()
        Me.label24 = New System.Windows.Forms.Label()
        Me.DeltaPos = New System.Windows.Forms.Label()
        Me.label17 = New System.Windows.Forms.Label()
        Me.label13 = New System.Windows.Forms.Label()
        Me.label23 = New System.Windows.Forms.Label()
        Me.label22 = New System.Windows.Forms.Label()
        Me.label21 = New System.Windows.Forms.Label()
        Me.DecelTextBox12 = New System.Windows.Forms.TextBox()
        Me.AccelTextBox12 = New System.Windows.Forms.TextBox()
        Me.VelocityTextBox12 = New System.Windows.Forms.TextBox()
        Me.label20 = New System.Windows.Forms.Label()
        Me.label19 = New System.Windows.Forms.Label()
        Me.label18 = New System.Windows.Forms.Label()
        Me.label16 = New System.Windows.Forms.Label()
        Me.label15 = New System.Windows.Forms.Label()
        Me.label14 = New System.Windows.Forms.Label()
        Me.ActPosVar_2 = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.DecelTextBox2 = New System.Windows.Forms.TextBox()
        Me.AccelTextBox2 = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.VelocityTextBox2 = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.HomeButton1 = New System.Windows.Forms.Button()
        Me.HomeButton12 = New System.Windows.Forms.Button()
        Me.JogPosButton12 = New System.Windows.Forms.Button()
        Me.JogNegButton12 = New System.Windows.Forms.Button()
        Me.JogPosButton2 = New System.Windows.Forms.Button()
        Me.JogNegButton2 = New System.Windows.Forms.Button()
        Me.HomeButton2 = New System.Windows.Forms.Button()
        Me.ActPosVar_1 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.ActPosLabel = New System.Windows.Forms.Label()
        Me.DecelLabel = New System.Windows.Forms.Label()
        Me.AccelLabel = New System.Windows.Forms.Label()
        Me.VelocityLabel = New System.Windows.Forms.Label()
        Me.DecelTextBox1 = New System.Windows.Forms.TextBox()
        Me.AccelTextBox1 = New System.Windows.Forms.TextBox()
        Me.VelocityTextBox1 = New System.Windows.Forms.TextBox()
        Me.JogPosButton1 = New System.Windows.Forms.Button()
        Me.JogNegButton1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PercentDisplay2 = New System.Windows.Forms.Label()
        Me.PercentDisplay1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'label31
        '
        Me.label31.AutoSize = True
        Me.label31.Location = New System.Drawing.Point(662, 399)
        Me.label31.Name = "label31"
        Me.label31.Size = New System.Drawing.Size(83, 17)
        Me.label31.TabIndex = 126
        Me.label31.Text = "Max (100%)"
        '
        'label30
        '
        Me.label30.AutoSize = True
        Me.label30.Location = New System.Drawing.Point(439, 399)
        Me.label30.Name = "label30"
        Me.label30.Size = New System.Drawing.Size(64, 17)
        Me.label30.TabIndex = 125
        Me.label30.Text = "Min (0%)"
        '
        'label29
        '
        Me.label29.AutoSize = True
        Me.label29.Location = New System.Drawing.Point(278, 399)
        Me.label29.Name = "label29"
        Me.label29.Size = New System.Drawing.Size(83, 17)
        Me.label29.TabIndex = 124
        Me.label29.Text = "Max (100%)"
        '
        'label26
        '
        Me.label26.AutoSize = True
        Me.label26.Location = New System.Drawing.Point(47, 399)
        Me.label26.Name = "label26"
        Me.label26.Size = New System.Drawing.Size(64, 17)
        Me.label26.TabIndex = 123
        Me.label26.Text = "Min (0%)"
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(475, 367)
        Me.ProgressBar2.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(239, 28)
        Me.ProgressBar2.Step = 1
        Me.ProgressBar2.TabIndex = 122
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(94, 367)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(236, 28)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.TabIndex = 121
        '
        'ActVelVar_1
        '
        Me.ActVelVar_1.AutoSize = True
        Me.ActVelVar_1.Location = New System.Drawing.Point(155, 201)
        Me.ActVelVar_1.Name = "ActVelVar_1"
        Me.ActVelVar_1.Size = New System.Drawing.Size(72, 17)
        Me.ActVelVar_1.TabIndex = 120
        Me.ActVelVar_1.Text = "                "
        '
        'ActVelVar_2
        '
        Me.ActVelVar_2.AutoSize = True
        Me.ActVelVar_2.Location = New System.Drawing.Point(547, 201)
        Me.ActVelVar_2.Name = "ActVelVar_2"
        Me.ActVelVar_2.Size = New System.Drawing.Size(72, 17)
        Me.ActVelVar_2.TabIndex = 119
        Me.ActVelVar_2.Text = "                "
        '
        'label28
        '
        Me.label28.AutoSize = True
        Me.label28.Location = New System.Drawing.Point(662, 201)
        Me.label28.Name = "label28"
        Me.label28.Size = New System.Drawing.Size(61, 17)
        Me.label28.TabIndex = 118
        Me.label28.Text = "counts/s"
        '
        'label27
        '
        Me.label27.AutoSize = True
        Me.label27.Location = New System.Drawing.Point(278, 201)
        Me.label27.Name = "label27"
        Me.label27.Size = New System.Drawing.Size(61, 17)
        Me.label27.TabIndex = 117
        Me.label27.Text = "counts/s"
        '
        'label25
        '
        Me.label25.AutoSize = True
        Me.label25.Location = New System.Drawing.Point(439, 201)
        Me.label25.Name = "label25"
        Me.label25.Size = New System.Drawing.Size(100, 17)
        Me.label25.TabIndex = 116
        Me.label25.Text = "Actual Velocity"
        '
        'label24
        '
        Me.label24.AutoSize = True
        Me.label24.Location = New System.Drawing.Point(47, 201)
        Me.label24.Name = "label24"
        Me.label24.Size = New System.Drawing.Size(100, 17)
        Me.label24.TabIndex = 115
        Me.label24.Text = "Actual Velocity"
        '
        'DeltaPos
        '
        Me.DeltaPos.AutoSize = True
        Me.DeltaPos.Location = New System.Drawing.Point(890, 240)
        Me.DeltaPos.Name = "DeltaPos"
        Me.DeltaPos.Size = New System.Drawing.Size(72, 17)
        Me.DeltaPos.TabIndex = 114
        Me.DeltaPos.Text = "                "
        '
        'label17
        '
        Me.label17.AutoSize = True
        Me.label17.Location = New System.Drawing.Point(999, 240)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(50, 17)
        Me.label17.TabIndex = 113
        Me.label17.Text = "counts"
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Location = New System.Drawing.Point(789, 240)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(95, 17)
        Me.label13.TabIndex = 112
        Me.label13.Text = "Delta Position"
        '
        'label23
        '
        Me.label23.AutoSize = True
        Me.label23.Location = New System.Drawing.Point(999, 149)
        Me.label23.Name = "label23"
        Me.label23.Size = New System.Drawing.Size(76, 17)
        Me.label23.TabIndex = 111
        Me.label23.Text = "counts/s^2"
        '
        'label22
        '
        Me.label22.AutoSize = True
        Me.label22.Location = New System.Drawing.Point(999, 95)
        Me.label22.Name = "label22"
        Me.label22.Size = New System.Drawing.Size(76, 17)
        Me.label22.TabIndex = 110
        Me.label22.Text = "counts/s^2"
        '
        'label21
        '
        Me.label21.AutoSize = True
        Me.label21.Location = New System.Drawing.Point(999, 44)
        Me.label21.Name = "label21"
        Me.label21.Size = New System.Drawing.Size(61, 17)
        Me.label21.TabIndex = 109
        Me.label21.Text = "counts/s"
        '
        'DecelTextBox12
        '
        Me.DecelTextBox12.Location = New System.Drawing.Point(887, 145)
        Me.DecelTextBox12.Margin = New System.Windows.Forms.Padding(4)
        Me.DecelTextBox12.Name = "DecelTextBox12"
        Me.DecelTextBox12.Size = New System.Drawing.Size(101, 22)
        Me.DecelTextBox12.TabIndex = 108
        '
        'AccelTextBox12
        '
        Me.AccelTextBox12.Location = New System.Drawing.Point(887, 91)
        Me.AccelTextBox12.Margin = New System.Windows.Forms.Padding(4)
        Me.AccelTextBox12.Name = "AccelTextBox12"
        Me.AccelTextBox12.Size = New System.Drawing.Size(101, 22)
        Me.AccelTextBox12.TabIndex = 107
        '
        'VelocityTextBox12
        '
        Me.VelocityTextBox12.Location = New System.Drawing.Point(887, 41)
        Me.VelocityTextBox12.Margin = New System.Windows.Forms.Padding(4)
        Me.VelocityTextBox12.Name = "VelocityTextBox12"
        Me.VelocityTextBox12.Size = New System.Drawing.Size(101, 22)
        Me.VelocityTextBox12.TabIndex = 106
        '
        'label20
        '
        Me.label20.AutoSize = True
        Me.label20.Location = New System.Drawing.Point(789, 149)
        Me.label20.Name = "label20"
        Me.label20.Size = New System.Drawing.Size(92, 17)
        Me.label20.TabIndex = 105
        Me.label20.Text = "Deceleration:"
        '
        'label19
        '
        Me.label19.AutoSize = True
        Me.label19.Location = New System.Drawing.Point(789, 95)
        Me.label19.Name = "label19"
        Me.label19.Size = New System.Drawing.Size(90, 17)
        Me.label19.TabIndex = 104
        Me.label19.Text = "Acceleration:"
        '
        'label18
        '
        Me.label18.AutoSize = True
        Me.label18.Location = New System.Drawing.Point(789, 44)
        Me.label18.Name = "label18"
        Me.label18.Size = New System.Drawing.Size(61, 17)
        Me.label18.TabIndex = 103
        Me.label18.Text = "Velocity:"
        '
        'label16
        '
        Me.label16.AutoSize = True
        Me.label16.Location = New System.Drawing.Point(909, 21)
        Me.label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(66, 17)
        Me.label16.TabIndex = 102
        Me.label16.Text = "Dual Axis"
        '
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.Location = New System.Drawing.Point(662, 240)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(50, 17)
        Me.label15.TabIndex = 101
        Me.label15.Text = "counts"
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.Location = New System.Drawing.Point(439, 240)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(101, 17)
        Me.label14.TabIndex = 100
        Me.label14.Text = "Actual Position"
        '
        'ActPosVar_2
        '
        Me.ActPosVar_2.AutoSize = True
        Me.ActPosVar_2.Location = New System.Drawing.Point(547, 240)
        Me.ActPosVar_2.Name = "ActPosVar_2"
        Me.ActPosVar_2.Size = New System.Drawing.Size(72, 17)
        Me.ActPosVar_2.TabIndex = 99
        Me.ActPosVar_2.Text = "                "
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Location = New System.Drawing.Point(439, 149)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(92, 17)
        Me.label12.TabIndex = 98
        Me.label12.Text = "Deceleration:"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(439, 95)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(90, 17)
        Me.label11.TabIndex = 97
        Me.label11.Text = "Acceleration:"
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(439, 44)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(61, 17)
        Me.label10.TabIndex = 96
        Me.label10.Text = "Velocity:"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(662, 149)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(76, 17)
        Me.label9.TabIndex = 95
        Me.label9.Text = "counts/s^2"
        '
        'DecelTextBox2
        '
        Me.DecelTextBox2.Location = New System.Drawing.Point(538, 145)
        Me.DecelTextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.DecelTextBox2.Name = "DecelTextBox2"
        Me.DecelTextBox2.Size = New System.Drawing.Size(101, 22)
        Me.DecelTextBox2.TabIndex = 94
        '
        'AccelTextBox2
        '
        Me.AccelTextBox2.Location = New System.Drawing.Point(538, 91)
        Me.AccelTextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.AccelTextBox2.Name = "AccelTextBox2"
        Me.AccelTextBox2.Size = New System.Drawing.Size(101, 22)
        Me.AccelTextBox2.TabIndex = 93
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(662, 96)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(76, 17)
        Me.label8.TabIndex = 92
        Me.label8.Text = "counts/s^2"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(662, 44)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(61, 17)
        Me.label7.TabIndex = 91
        Me.label7.Text = "counts/s"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(563, 21)
        Me.label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(45, 17)
        Me.label6.TabIndex = 90
        Me.label6.Text = "Axis 2"
        '
        'VelocityTextBox2
        '
        Me.VelocityTextBox2.Location = New System.Drawing.Point(538, 41)
        Me.VelocityTextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.VelocityTextBox2.Name = "VelocityTextBox2"
        Me.VelocityTextBox2.Size = New System.Drawing.Size(101, 22)
        Me.VelocityTextBox2.TabIndex = 89
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(181, 21)
        Me.label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(45, 17)
        Me.label5.TabIndex = 88
        Me.label5.Text = "Axis 1"
        '
        'HomeButton1
        '
        Me.HomeButton1.Location = New System.Drawing.Point(141, 315)
        Me.HomeButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.HomeButton1.Name = "HomeButton1"
        Me.HomeButton1.Size = New System.Drawing.Size(113, 32)
        Me.HomeButton1.TabIndex = 87
        Me.HomeButton1.Text = "Home Axis 1"
        Me.HomeButton1.UseVisualStyleBackColor = True
        '
        'HomeButton12
        '
        Me.HomeButton12.Location = New System.Drawing.Point(854, 314)
        Me.HomeButton12.Margin = New System.Windows.Forms.Padding(4)
        Me.HomeButton12.Name = "HomeButton12"
        Me.HomeButton12.Size = New System.Drawing.Size(136, 33)
        Me.HomeButton12.TabIndex = 86
        Me.HomeButton12.Text = "Dual Axis Home"
        Me.HomeButton12.UseVisualStyleBackColor = True
        '
        'JogPosButton12
        '
        Me.JogPosButton12.Location = New System.Drawing.Point(945, 277)
        Me.JogPosButton12.Margin = New System.Windows.Forms.Padding(4)
        Me.JogPosButton12.Name = "JogPosButton12"
        Me.JogPosButton12.Size = New System.Drawing.Size(136, 33)
        Me.JogPosButton12.TabIndex = 85
        Me.JogPosButton12.Text = "Dual Axis Jog Pos"
        Me.JogPosButton12.UseVisualStyleBackColor = True
        '
        'JogNegButton12
        '
        Me.JogNegButton12.Location = New System.Drawing.Point(801, 277)
        Me.JogNegButton12.Margin = New System.Windows.Forms.Padding(4)
        Me.JogNegButton12.Name = "JogNegButton12"
        Me.JogNegButton12.Size = New System.Drawing.Size(136, 33)
        Me.JogNegButton12.TabIndex = 84
        Me.JogNegButton12.Text = "Dual Axis Jog Neg"
        Me.JogNegButton12.UseVisualStyleBackColor = True
        '
        'JogPosButton2
        '
        Me.JogPosButton2.Location = New System.Drawing.Point(599, 277)
        Me.JogPosButton2.Margin = New System.Windows.Forms.Padding(4)
        Me.JogPosButton2.Name = "JogPosButton2"
        Me.JogPosButton2.Size = New System.Drawing.Size(115, 32)
        Me.JogPosButton2.TabIndex = 83
        Me.JogPosButton2.Text = "Axis 2 Jog Pos"
        Me.JogPosButton2.UseVisualStyleBackColor = True
        '
        'JogNegButton2
        '
        Me.JogNegButton2.Location = New System.Drawing.Point(475, 277)
        Me.JogNegButton2.Margin = New System.Windows.Forms.Padding(4)
        Me.JogNegButton2.Name = "JogNegButton2"
        Me.JogNegButton2.Size = New System.Drawing.Size(116, 32)
        Me.JogNegButton2.TabIndex = 82
        Me.JogNegButton2.Text = "Axis 2 Jog Neg"
        Me.JogNegButton2.UseVisualStyleBackColor = True
        '
        'HomeButton2
        '
        Me.HomeButton2.Location = New System.Drawing.Point(527, 315)
        Me.HomeButton2.Margin = New System.Windows.Forms.Padding(4)
        Me.HomeButton2.Name = "HomeButton2"
        Me.HomeButton2.Size = New System.Drawing.Size(113, 32)
        Me.HomeButton2.TabIndex = 81
        Me.HomeButton2.Text = "Home Axis 2"
        Me.HomeButton2.UseVisualStyleBackColor = True
        '
        'ActPosVar_1
        '
        Me.ActPosVar_1.AutoSize = True
        Me.ActPosVar_1.Location = New System.Drawing.Point(155, 240)
        Me.ActPosVar_1.Name = "ActPosVar_1"
        Me.ActPosVar_1.Size = New System.Drawing.Size(72, 17)
        Me.ActPosVar_1.TabIndex = 80
        Me.ActPosVar_1.Text = "                "
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(278, 240)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(50, 17)
        Me.label4.TabIndex = 79
        Me.label4.Text = "counts"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(278, 145)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(76, 17)
        Me.label3.TabIndex = 78
        Me.label3.Text = "counts/s^2"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(278, 95)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(76, 17)
        Me.label2.TabIndex = 77
        Me.label2.Text = "counts/s^2"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(278, 44)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(61, 17)
        Me.label1.TabIndex = 76
        Me.label1.Text = "counts/s"
        '
        'ActPosLabel
        '
        Me.ActPosLabel.AutoSize = True
        Me.ActPosLabel.Location = New System.Drawing.Point(47, 240)
        Me.ActPosLabel.Name = "ActPosLabel"
        Me.ActPosLabel.Size = New System.Drawing.Size(101, 17)
        Me.ActPosLabel.TabIndex = 75
        Me.ActPosLabel.Text = "Actual Position"
        '
        'DecelLabel
        '
        Me.DecelLabel.AutoSize = True
        Me.DecelLabel.Location = New System.Drawing.Point(47, 145)
        Me.DecelLabel.Name = "DecelLabel"
        Me.DecelLabel.Size = New System.Drawing.Size(92, 17)
        Me.DecelLabel.TabIndex = 74
        Me.DecelLabel.Text = "Deceleration:"
        '
        'AccelLabel
        '
        Me.AccelLabel.AutoSize = True
        Me.AccelLabel.Location = New System.Drawing.Point(47, 95)
        Me.AccelLabel.Name = "AccelLabel"
        Me.AccelLabel.Size = New System.Drawing.Size(90, 17)
        Me.AccelLabel.TabIndex = 73
        Me.AccelLabel.Text = "Acceleration:"
        '
        'VelocityLabel
        '
        Me.VelocityLabel.AutoSize = True
        Me.VelocityLabel.Location = New System.Drawing.Point(47, 44)
        Me.VelocityLabel.Name = "VelocityLabel"
        Me.VelocityLabel.Size = New System.Drawing.Size(61, 17)
        Me.VelocityLabel.TabIndex = 72
        Me.VelocityLabel.Text = "Velocity:"
        '
        'DecelTextBox1
        '
        Me.DecelTextBox1.Location = New System.Drawing.Point(153, 145)
        Me.DecelTextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DecelTextBox1.Name = "DecelTextBox1"
        Me.DecelTextBox1.Size = New System.Drawing.Size(100, 22)
        Me.DecelTextBox1.TabIndex = 71
        '
        'AccelTextBox1
        '
        Me.AccelTextBox1.Location = New System.Drawing.Point(153, 92)
        Me.AccelTextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AccelTextBox1.Name = "AccelTextBox1"
        Me.AccelTextBox1.Size = New System.Drawing.Size(100, 22)
        Me.AccelTextBox1.TabIndex = 70
        '
        'VelocityTextBox1
        '
        Me.VelocityTextBox1.Location = New System.Drawing.Point(153, 44)
        Me.VelocityTextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.VelocityTextBox1.Name = "VelocityTextBox1"
        Me.VelocityTextBox1.Size = New System.Drawing.Size(100, 22)
        Me.VelocityTextBox1.TabIndex = 69
        '
        'JogPosButton1
        '
        Me.JogPosButton1.Location = New System.Drawing.Point(215, 277)
        Me.JogPosButton1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.JogPosButton1.Name = "JogPosButton1"
        Me.JogPosButton1.Size = New System.Drawing.Size(115, 32)
        Me.JogPosButton1.TabIndex = 68
        Me.JogPosButton1.Text = "Axis 1 Jog Pos "
        Me.JogPosButton1.UseVisualStyleBackColor = True
        '
        'JogNegButton1
        '
        Me.JogNegButton1.Location = New System.Drawing.Point(94, 277)
        Me.JogNegButton1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.JogNegButton1.Name = "JogNegButton1"
        Me.JogNegButton1.Size = New System.Drawing.Size(116, 32)
        Me.JogNegButton1.TabIndex = 67
        Me.JogNegButton1.Text = "Axis 1 Jog Neg"
        Me.JogNegButton1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'PercentDisplay2
        '
        Me.PercentDisplay2.AutoSize = True
        Me.PercentDisplay2.Location = New System.Drawing.Point(547, 399)
        Me.PercentDisplay2.Name = "PercentDisplay2"
        Me.PercentDisplay2.Size = New System.Drawing.Size(72, 17)
        Me.PercentDisplay2.TabIndex = 128
        Me.PercentDisplay2.Text = "                "
        '
        'PercentDisplay1
        '
        Me.PercentDisplay1.AutoSize = True
        Me.PercentDisplay1.Location = New System.Drawing.Point(155, 399)
        Me.PercentDisplay1.Name = "PercentDisplay1"
        Me.PercentDisplay1.Size = New System.Drawing.Size(72, 17)
        Me.PercentDisplay1.TabIndex = 127
        Me.PercentDisplay1.Text = "                "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1128, 437)
        Me.Controls.Add(Me.PercentDisplay2)
        Me.Controls.Add(Me.PercentDisplay1)
        Me.Controls.Add(Me.label31)
        Me.Controls.Add(Me.label30)
        Me.Controls.Add(Me.label29)
        Me.Controls.Add(Me.label26)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.ActVelVar_1)
        Me.Controls.Add(Me.ActVelVar_2)
        Me.Controls.Add(Me.label28)
        Me.Controls.Add(Me.label27)
        Me.Controls.Add(Me.label25)
        Me.Controls.Add(Me.label24)
        Me.Controls.Add(Me.DeltaPos)
        Me.Controls.Add(Me.label17)
        Me.Controls.Add(Me.label13)
        Me.Controls.Add(Me.label23)
        Me.Controls.Add(Me.label22)
        Me.Controls.Add(Me.label21)
        Me.Controls.Add(Me.DecelTextBox12)
        Me.Controls.Add(Me.AccelTextBox12)
        Me.Controls.Add(Me.VelocityTextBox12)
        Me.Controls.Add(Me.label20)
        Me.Controls.Add(Me.label19)
        Me.Controls.Add(Me.label18)
        Me.Controls.Add(Me.label16)
        Me.Controls.Add(Me.label15)
        Me.Controls.Add(Me.label14)
        Me.Controls.Add(Me.ActPosVar_2)
        Me.Controls.Add(Me.label12)
        Me.Controls.Add(Me.label11)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.DecelTextBox2)
        Me.Controls.Add(Me.AccelTextBox2)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.VelocityTextBox2)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.HomeButton1)
        Me.Controls.Add(Me.HomeButton12)
        Me.Controls.Add(Me.JogPosButton12)
        Me.Controls.Add(Me.JogNegButton12)
        Me.Controls.Add(Me.JogPosButton2)
        Me.Controls.Add(Me.JogNegButton2)
        Me.Controls.Add(Me.HomeButton2)
        Me.Controls.Add(Me.ActPosVar_1)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.ActPosLabel)
        Me.Controls.Add(Me.DecelLabel)
        Me.Controls.Add(Me.AccelLabel)
        Me.Controls.Add(Me.VelocityLabel)
        Me.Controls.Add(Me.DecelTextBox1)
        Me.Controls.Add(Me.AccelTextBox1)
        Me.Controls.Add(Me.VelocityTextBox1)
        Me.Controls.Add(Me.JogPosButton1)
        Me.Controls.Add(Me.JogNegButton1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label31 As Label
    Private WithEvents label30 As Label
    Private WithEvents label29 As Label
    Private WithEvents label26 As Label
    Private WithEvents ProgressBar2 As ProgressBar
    Private WithEvents ProgressBar1 As ProgressBar
    Private WithEvents ActVelVar_1 As Label
    Private WithEvents ActVelVar_2 As Label
    Private WithEvents label28 As Label
    Private WithEvents label27 As Label
    Private WithEvents label25 As Label
    Private WithEvents label24 As Label
    Private WithEvents DeltaPos As Label
    Private WithEvents label17 As Label
    Private WithEvents label13 As Label
    Private WithEvents label23 As Label
    Private WithEvents label22 As Label
    Private WithEvents label21 As Label
    Private WithEvents DecelTextBox12 As TextBox
    Private WithEvents AccelTextBox12 As TextBox
    Private WithEvents VelocityTextBox12 As TextBox
    Private WithEvents label20 As Label
    Private WithEvents label19 As Label
    Private WithEvents label18 As Label
    Private WithEvents label16 As Label
    Private WithEvents label15 As Label
    Private WithEvents label14 As Label
    Private WithEvents ActPosVar_2 As Label
    Private WithEvents label12 As Label
    Private WithEvents label11 As Label
    Private WithEvents label10 As Label
    Private WithEvents label9 As Label
    Private WithEvents DecelTextBox2 As TextBox
    Private WithEvents AccelTextBox2 As TextBox
    Private WithEvents label8 As Label
    Private WithEvents label7 As Label
    Private WithEvents label6 As Label
    Private WithEvents VelocityTextBox2 As TextBox
    Private WithEvents label5 As Label
    Private WithEvents HomeButton1 As Button
    Private WithEvents HomeButton12 As Button
    Private WithEvents JogPosButton12 As Button
    Private WithEvents JogNegButton12 As Button
    Private WithEvents JogPosButton2 As Button
    Private WithEvents JogNegButton2 As Button
    Private WithEvents HomeButton2 As Button
    Private WithEvents ActPosVar_1 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents ActPosLabel As Label
    Private WithEvents DecelLabel As Label
    Private WithEvents AccelLabel As Label
    Private WithEvents VelocityLabel As Label
    Private WithEvents DecelTextBox1 As TextBox
    Private WithEvents AccelTextBox1 As TextBox
    Private WithEvents VelocityTextBox1 As TextBox
    Private WithEvents JogPosButton1 As Button
    Private WithEvents JogNegButton1 As Button
    Private WithEvents Timer1 As Timer
    Private WithEvents PercentDisplay2 As Label
    Private WithEvents PercentDisplay1 As Label
End Class
