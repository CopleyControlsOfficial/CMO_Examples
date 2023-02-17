<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DualJog
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
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
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.PercentDisplay1 = New System.Windows.Forms.Label()
        Me.PercentDisplay2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'ActVelVar_1
        '
        Me.ActVelVar_1.AutoSize = True
        Me.ActVelVar_1.Location = New System.Drawing.Point(95, 164)
        Me.ActVelVar_1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ActVelVar_1.Name = "ActVelVar_1"
        Me.ActVelVar_1.Size = New System.Drawing.Size(55, 13)
        Me.ActVelVar_1.TabIndex = 114
        Me.ActVelVar_1.Text = "                "
        '
        'ActVelVar_2
        '
        Me.ActVelVar_2.AutoSize = True
        Me.ActVelVar_2.Location = New System.Drawing.Point(389, 164)
        Me.ActVelVar_2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ActVelVar_2.Name = "ActVelVar_2"
        Me.ActVelVar_2.Size = New System.Drawing.Size(55, 13)
        Me.ActVelVar_2.TabIndex = 113
        Me.ActVelVar_2.Text = "                "
        '
        'label28
        '
        Me.label28.AutoSize = True
        Me.label28.Location = New System.Drawing.Point(475, 164)
        Me.label28.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label28.Name = "label28"
        Me.label28.Size = New System.Drawing.Size(49, 13)
        Me.label28.TabIndex = 112
        Me.label28.Text = "counts/s"
        '
        'label27
        '
        Me.label27.AutoSize = True
        Me.label27.Location = New System.Drawing.Point(187, 164)
        Me.label27.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label27.Name = "label27"
        Me.label27.Size = New System.Drawing.Size(49, 13)
        Me.label27.TabIndex = 111
        Me.label27.Text = "counts/s"
        '
        'label25
        '
        Me.label25.AutoSize = True
        Me.label25.Location = New System.Drawing.Point(308, 164)
        Me.label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label25.Name = "label25"
        Me.label25.Size = New System.Drawing.Size(77, 13)
        Me.label25.TabIndex = 110
        Me.label25.Text = "Actual Velocity"
        '
        'label24
        '
        Me.label24.AutoSize = True
        Me.label24.Location = New System.Drawing.Point(14, 164)
        Me.label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label24.Name = "label24"
        Me.label24.Size = New System.Drawing.Size(77, 13)
        Me.label24.TabIndex = 109
        Me.label24.Text = "Actual Velocity"
        '
        'DeltaPos
        '
        Me.DeltaPos.AutoSize = True
        Me.DeltaPos.Location = New System.Drawing.Point(646, 196)
        Me.DeltaPos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DeltaPos.Name = "DeltaPos"
        Me.DeltaPos.Size = New System.Drawing.Size(55, 13)
        Me.DeltaPos.TabIndex = 108
        Me.DeltaPos.Text = "                "
        '
        'label17
        '
        Me.label17.AutoSize = True
        Me.label17.Location = New System.Drawing.Point(728, 196)
        Me.label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(39, 13)
        Me.label17.TabIndex = 107
        Me.label17.Text = "counts"
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Location = New System.Drawing.Point(570, 196)
        Me.label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(72, 13)
        Me.label13.TabIndex = 106
        Me.label13.Text = "Delta Position"
        '
        'label23
        '
        Me.label23.AutoSize = True
        Me.label23.Location = New System.Drawing.Point(728, 122)
        Me.label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label23.Name = "label23"
        Me.label23.Size = New System.Drawing.Size(61, 13)
        Me.label23.TabIndex = 105
        Me.label23.Text = "counts/s^2"
        '
        'label22
        '
        Me.label22.AutoSize = True
        Me.label22.Location = New System.Drawing.Point(728, 78)
        Me.label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label22.Name = "label22"
        Me.label22.Size = New System.Drawing.Size(61, 13)
        Me.label22.TabIndex = 104
        Me.label22.Text = "counts/s^2"
        '
        'label21
        '
        Me.label21.AutoSize = True
        Me.label21.Location = New System.Drawing.Point(728, 37)
        Me.label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label21.Name = "label21"
        Me.label21.Size = New System.Drawing.Size(49, 13)
        Me.label21.TabIndex = 103
        Me.label21.Text = "counts/s"
        '
        'DecelTextBox12
        '
        Me.DecelTextBox12.Location = New System.Drawing.Point(644, 119)
        Me.DecelTextBox12.Name = "DecelTextBox12"
        Me.DecelTextBox12.Size = New System.Drawing.Size(77, 20)
        Me.DecelTextBox12.TabIndex = 102
        '
        'AccelTextBox12
        '
        Me.AccelTextBox12.Location = New System.Drawing.Point(644, 75)
        Me.AccelTextBox12.Name = "AccelTextBox12"
        Me.AccelTextBox12.Size = New System.Drawing.Size(77, 20)
        Me.AccelTextBox12.TabIndex = 101
        '
        'VelocityTextBox12
        '
        Me.VelocityTextBox12.Location = New System.Drawing.Point(644, 34)
        Me.VelocityTextBox12.Name = "VelocityTextBox12"
        Me.VelocityTextBox12.Size = New System.Drawing.Size(77, 20)
        Me.VelocityTextBox12.TabIndex = 100
        '
        'label20
        '
        Me.label20.AutoSize = True
        Me.label20.Location = New System.Drawing.Point(570, 122)
        Me.label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label20.Name = "label20"
        Me.label20.Size = New System.Drawing.Size(70, 13)
        Me.label20.TabIndex = 99
        Me.label20.Text = "Deceleration:"
        '
        'label19
        '
        Me.label19.AutoSize = True
        Me.label19.Location = New System.Drawing.Point(570, 78)
        Me.label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label19.Name = "label19"
        Me.label19.Size = New System.Drawing.Size(69, 13)
        Me.label19.TabIndex = 98
        Me.label19.Text = "Acceleration:"
        '
        'label18
        '
        Me.label18.AutoSize = True
        Me.label18.Location = New System.Drawing.Point(570, 37)
        Me.label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label18.Name = "label18"
        Me.label18.Size = New System.Drawing.Size(47, 13)
        Me.label18.TabIndex = 97
        Me.label18.Text = "Velocity:"
        '
        'label16
        '
        Me.label16.AutoSize = True
        Me.label16.Location = New System.Drawing.Point(660, 18)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(51, 13)
        Me.label16.TabIndex = 96
        Me.label16.Text = "Duel Axis"
        '
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.Location = New System.Drawing.Point(475, 196)
        Me.label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(39, 13)
        Me.label15.TabIndex = 95
        Me.label15.Text = "counts"
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.Location = New System.Drawing.Point(308, 196)
        Me.label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(77, 13)
        Me.label14.TabIndex = 94
        Me.label14.Text = "Actual Position"
        '
        'ActPosVar_2
        '
        Me.ActPosVar_2.AutoSize = True
        Me.ActPosVar_2.Location = New System.Drawing.Point(389, 196)
        Me.ActPosVar_2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ActPosVar_2.Name = "ActPosVar_2"
        Me.ActPosVar_2.Size = New System.Drawing.Size(55, 13)
        Me.ActPosVar_2.TabIndex = 93
        Me.ActPosVar_2.Text = "                "
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Location = New System.Drawing.Point(308, 122)
        Me.label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(70, 13)
        Me.label12.TabIndex = 92
        Me.label12.Text = "Deceleration:"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(308, 78)
        Me.label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(69, 13)
        Me.label11.TabIndex = 91
        Me.label11.Text = "Acceleration:"
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(308, 37)
        Me.label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(47, 13)
        Me.label10.TabIndex = 90
        Me.label10.Text = "Velocity:"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(475, 122)
        Me.label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(61, 13)
        Me.label9.TabIndex = 89
        Me.label9.Text = "counts/s^2"
        '
        'DecelTextBox2
        '
        Me.DecelTextBox2.Location = New System.Drawing.Point(382, 119)
        Me.DecelTextBox2.Name = "DecelTextBox2"
        Me.DecelTextBox2.Size = New System.Drawing.Size(77, 20)
        Me.DecelTextBox2.TabIndex = 88
        '
        'AccelTextBox2
        '
        Me.AccelTextBox2.Location = New System.Drawing.Point(382, 75)
        Me.AccelTextBox2.Name = "AccelTextBox2"
        Me.AccelTextBox2.Size = New System.Drawing.Size(77, 20)
        Me.AccelTextBox2.TabIndex = 87
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(475, 79)
        Me.label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(61, 13)
        Me.label8.TabIndex = 86
        Me.label8.Text = "counts/s^2"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(475, 37)
        Me.label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(49, 13)
        Me.label7.TabIndex = 85
        Me.label7.Text = "counts/s"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(401, 18)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(35, 13)
        Me.label6.TabIndex = 84
        Me.label6.Text = "Axis 2"
        '
        'VelocityTextBox2
        '
        Me.VelocityTextBox2.Location = New System.Drawing.Point(382, 34)
        Me.VelocityTextBox2.Name = "VelocityTextBox2"
        Me.VelocityTextBox2.Size = New System.Drawing.Size(77, 20)
        Me.VelocityTextBox2.TabIndex = 83
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(114, 18)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(35, 13)
        Me.label5.TabIndex = 82
        Me.label5.Text = "Axis 1"
        '
        'HomeButton1
        '
        Me.HomeButton1.Location = New System.Drawing.Point(84, 257)
        Me.HomeButton1.Name = "HomeButton1"
        Me.HomeButton1.Size = New System.Drawing.Size(85, 26)
        Me.HomeButton1.TabIndex = 81
        Me.HomeButton1.Text = "Home Axis 1"
        Me.HomeButton1.UseVisualStyleBackColor = True
        '
        'HomeButton12
        '
        Me.HomeButton12.Location = New System.Drawing.Point(619, 256)
        Me.HomeButton12.Name = "HomeButton12"
        Me.HomeButton12.Size = New System.Drawing.Size(102, 27)
        Me.HomeButton12.TabIndex = 80
        Me.HomeButton12.Text = "Duel Axis Home"
        Me.HomeButton12.UseVisualStyleBackColor = True
        '
        'JogPosButton12
        '
        Me.JogPosButton12.Location = New System.Drawing.Point(687, 226)
        Me.JogPosButton12.Name = "JogPosButton12"
        Me.JogPosButton12.Size = New System.Drawing.Size(102, 27)
        Me.JogPosButton12.TabIndex = 79
        Me.JogPosButton12.Text = "Duel Axis Jog Pos"
        Me.JogPosButton12.UseVisualStyleBackColor = True
        '
        'JogNegButton12
        '
        Me.JogNegButton12.Location = New System.Drawing.Point(579, 226)
        Me.JogNegButton12.Name = "JogNegButton12"
        Me.JogNegButton12.Size = New System.Drawing.Size(102, 27)
        Me.JogNegButton12.TabIndex = 78
        Me.JogNegButton12.Text = "Duel Axis Jog Neg"
        Me.JogNegButton12.UseVisualStyleBackColor = True
        '
        'JogPosButton2
        '
        Me.JogPosButton2.Location = New System.Drawing.Point(428, 226)
        Me.JogPosButton2.Name = "JogPosButton2"
        Me.JogPosButton2.Size = New System.Drawing.Size(86, 26)
        Me.JogPosButton2.TabIndex = 77
        Me.JogPosButton2.Text = "Axis 2 Jog Pos"
        Me.JogPosButton2.UseVisualStyleBackColor = True
        '
        'JogNegButton2
        '
        Me.JogNegButton2.Location = New System.Drawing.Point(335, 226)
        Me.JogNegButton2.Name = "JogNegButton2"
        Me.JogNegButton2.Size = New System.Drawing.Size(87, 26)
        Me.JogNegButton2.TabIndex = 76
        Me.JogNegButton2.Text = "Axis 2 Jog Neg"
        Me.JogNegButton2.UseVisualStyleBackColor = True
        '
        'HomeButton2
        '
        Me.HomeButton2.Location = New System.Drawing.Point(374, 257)
        Me.HomeButton2.Name = "HomeButton2"
        Me.HomeButton2.Size = New System.Drawing.Size(85, 26)
        Me.HomeButton2.TabIndex = 75
        Me.HomeButton2.Text = "Home Axis 2"
        Me.HomeButton2.UseVisualStyleBackColor = True
        '
        'ActPosVar_1
        '
        Me.ActPosVar_1.AutoSize = True
        Me.ActPosVar_1.Location = New System.Drawing.Point(95, 196)
        Me.ActPosVar_1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ActPosVar_1.Name = "ActPosVar_1"
        Me.ActPosVar_1.Size = New System.Drawing.Size(55, 13)
        Me.ActPosVar_1.TabIndex = 74
        Me.ActPosVar_1.Text = "                "
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(187, 196)
        Me.label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(39, 13)
        Me.label4.TabIndex = 73
        Me.label4.Text = "counts"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(187, 119)
        Me.label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(61, 13)
        Me.label3.TabIndex = 72
        Me.label3.Text = "counts/s^2"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(187, 78)
        Me.label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(61, 13)
        Me.label2.TabIndex = 71
        Me.label2.Text = "counts/s^2"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(187, 37)
        Me.label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(49, 13)
        Me.label1.TabIndex = 70
        Me.label1.Text = "counts/s"
        '
        'ActPosLabel
        '
        Me.ActPosLabel.AutoSize = True
        Me.ActPosLabel.Location = New System.Drawing.Point(14, 196)
        Me.ActPosLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ActPosLabel.Name = "ActPosLabel"
        Me.ActPosLabel.Size = New System.Drawing.Size(77, 13)
        Me.ActPosLabel.TabIndex = 69
        Me.ActPosLabel.Text = "Actual Position"
        '
        'DecelLabel
        '
        Me.DecelLabel.AutoSize = True
        Me.DecelLabel.Location = New System.Drawing.Point(14, 119)
        Me.DecelLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DecelLabel.Name = "DecelLabel"
        Me.DecelLabel.Size = New System.Drawing.Size(70, 13)
        Me.DecelLabel.TabIndex = 68
        Me.DecelLabel.Text = "Deceleration:"
        '
        'AccelLabel
        '
        Me.AccelLabel.AutoSize = True
        Me.AccelLabel.Location = New System.Drawing.Point(14, 78)
        Me.AccelLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.AccelLabel.Name = "AccelLabel"
        Me.AccelLabel.Size = New System.Drawing.Size(69, 13)
        Me.AccelLabel.TabIndex = 67
        Me.AccelLabel.Text = "Acceleration:"
        '
        'VelocityLabel
        '
        Me.VelocityLabel.AutoSize = True
        Me.VelocityLabel.Location = New System.Drawing.Point(14, 37)
        Me.VelocityLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.VelocityLabel.Name = "VelocityLabel"
        Me.VelocityLabel.Size = New System.Drawing.Size(47, 13)
        Me.VelocityLabel.TabIndex = 66
        Me.VelocityLabel.Text = "Velocity:"
        '
        'DecelTextBox1
        '
        Me.DecelTextBox1.Location = New System.Drawing.Point(93, 119)
        Me.DecelTextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.DecelTextBox1.Name = "DecelTextBox1"
        Me.DecelTextBox1.Size = New System.Drawing.Size(76, 20)
        Me.DecelTextBox1.TabIndex = 65
        '
        'AccelTextBox1
        '
        Me.AccelTextBox1.Location = New System.Drawing.Point(93, 76)
        Me.AccelTextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.AccelTextBox1.Name = "AccelTextBox1"
        Me.AccelTextBox1.Size = New System.Drawing.Size(76, 20)
        Me.AccelTextBox1.TabIndex = 64
        '
        'VelocityTextBox1
        '
        Me.VelocityTextBox1.Location = New System.Drawing.Point(93, 37)
        Me.VelocityTextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.VelocityTextBox1.Name = "VelocityTextBox1"
        Me.VelocityTextBox1.Size = New System.Drawing.Size(76, 20)
        Me.VelocityTextBox1.TabIndex = 63
        '
        'JogPosButton1
        '
        Me.JogPosButton1.Location = New System.Drawing.Point(140, 226)
        Me.JogPosButton1.Margin = New System.Windows.Forms.Padding(2)
        Me.JogPosButton1.Name = "JogPosButton1"
        Me.JogPosButton1.Size = New System.Drawing.Size(86, 26)
        Me.JogPosButton1.TabIndex = 62
        Me.JogPosButton1.Text = "Axis 1 Jog Pos "
        Me.JogPosButton1.UseVisualStyleBackColor = True
        '
        'JogNegButton1
        '
        Me.JogNegButton1.Location = New System.Drawing.Point(49, 226)
        Me.JogNegButton1.Margin = New System.Windows.Forms.Padding(2)
        Me.JogNegButton1.Name = "JogNegButton1"
        Me.JogNegButton1.Size = New System.Drawing.Size(87, 26)
        Me.JogNegButton1.TabIndex = 61
        Me.JogNegButton1.Text = "Axis 1 Jog Neg"
        Me.JogNegButton1.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(17, 328)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(219, 23)
        Me.ProgressBar1.TabIndex = 115
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(305, 328)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(219, 23)
        Me.ProgressBar2.TabIndex = 116
        '
        'PercentDisplay1
        '
        Me.PercentDisplay1.AutoSize = True
        Me.PercentDisplay1.Location = New System.Drawing.Point(95, 354)
        Me.PercentDisplay1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.PercentDisplay1.Name = "PercentDisplay1"
        Me.PercentDisplay1.Size = New System.Drawing.Size(55, 13)
        Me.PercentDisplay1.TabIndex = 117
        Me.PercentDisplay1.Text = "                "
        '
        'PercentDisplay2
        '
        Me.PercentDisplay2.AutoSize = True
        Me.PercentDisplay2.Location = New System.Drawing.Point(389, 354)
        Me.PercentDisplay2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.PercentDisplay2.Name = "PercentDisplay2"
        Me.PercentDisplay2.Size = New System.Drawing.Size(55, 13)
        Me.PercentDisplay2.TabIndex = 118
        Me.PercentDisplay2.Text = "                "
        '
        'DualJog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 400)
        Me.Controls.Add(Me.PercentDisplay2)
        Me.Controls.Add(Me.PercentDisplay1)
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
        Me.Name = "DualJog"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
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
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ProgressBar2 As ProgressBar
    Private WithEvents PercentDisplay1 As Label
    Private WithEvents PercentDisplay2 As Label
End Class
