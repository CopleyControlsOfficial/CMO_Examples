<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Trace
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
        Me.TraceTimeGroupBox = New System.Windows.Forms.GroupBox()
        Me.TriggerGroupBox = New System.Windows.Forms.GroupBox()
        Me.SendPeriodButton = New System.Windows.Forms.Button()
        Me.SendTrigSettingsButton = New System.Windows.Forms.Button()
        Me.StartTraceButton = New System.Windows.Forms.Button()
        Me.StopTraceButton = New System.Windows.Forms.Button()
        Me.EnableDisableButton = New System.Windows.Forms.Button()
        Me.TrigTypeTextBox = New System.Windows.Forms.TextBox()
        Me.TrigChannelTextBox = New System.Windows.Forms.TextBox()
        Me.TrigLevelTextBox = New System.Windows.Forms.TextBox()
        Me.TrigDelayTextBox = New System.Windows.Forms.TextBox()
        Me.TracePeriodTextBox = New System.Windows.Forms.TextBox()
        Me.TrigTypeLabel = New System.Windows.Forms.Label()
        Me.TrigChannelLabel = New System.Windows.Forms.Label()
        Me.TrigLevelLabel = New System.Windows.Forms.Label()
        Me.TrigDelayLevel = New System.Windows.Forms.Label()
        Me.TraceRefPeriodLabel = New System.Windows.Forms.Label()
        Me.TracePeriodLabel = New System.Windows.Forms.Label()
        Me.MaxSamplesLabel = New System.Windows.Forms.Label()
        Me.TotalTraceTimeLabel = New System.Windows.Forms.Label()
        Me.TraceRefPeriodValue = New System.Windows.Forms.Label()
        Me.MaxSamplesValue = New System.Windows.Forms.Label()
        Me.TotalTraceTimeValue = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TraceStatusLabel = New System.Windows.Forms.Label()
        Me.TraceStatusValue = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TraceTimeGroupBox.SuspendLayout()
        Me.TriggerGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'TraceTimeGroupBox
        '
        Me.TraceTimeGroupBox.Controls.Add(Me.Label2)
        Me.TraceTimeGroupBox.Controls.Add(Me.Label1)
        Me.TraceTimeGroupBox.Controls.Add(Me.TotalTraceTimeValue)
        Me.TraceTimeGroupBox.Controls.Add(Me.MaxSamplesValue)
        Me.TraceTimeGroupBox.Controls.Add(Me.TraceRefPeriodValue)
        Me.TraceTimeGroupBox.Controls.Add(Me.TotalTraceTimeLabel)
        Me.TraceTimeGroupBox.Controls.Add(Me.MaxSamplesLabel)
        Me.TraceTimeGroupBox.Controls.Add(Me.TracePeriodLabel)
        Me.TraceTimeGroupBox.Controls.Add(Me.TraceRefPeriodLabel)
        Me.TraceTimeGroupBox.Controls.Add(Me.TracePeriodTextBox)
        Me.TraceTimeGroupBox.Controls.Add(Me.SendPeriodButton)
        Me.TraceTimeGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.TraceTimeGroupBox.Name = "TraceTimeGroupBox"
        Me.TraceTimeGroupBox.Size = New System.Drawing.Size(296, 222)
        Me.TraceTimeGroupBox.TabIndex = 0
        Me.TraceTimeGroupBox.TabStop = False
        Me.TraceTimeGroupBox.Text = "Trace Time"
        '
        'TriggerGroupBox
        '
        Me.TriggerGroupBox.Controls.Add(Me.TrigDelayLevel)
        Me.TriggerGroupBox.Controls.Add(Me.TrigLevelLabel)
        Me.TriggerGroupBox.Controls.Add(Me.TrigChannelLabel)
        Me.TriggerGroupBox.Controls.Add(Me.TrigTypeLabel)
        Me.TriggerGroupBox.Controls.Add(Me.TrigDelayTextBox)
        Me.TriggerGroupBox.Controls.Add(Me.TrigLevelTextBox)
        Me.TriggerGroupBox.Controls.Add(Me.TrigChannelTextBox)
        Me.TriggerGroupBox.Controls.Add(Me.TrigTypeTextBox)
        Me.TriggerGroupBox.Controls.Add(Me.SendTrigSettingsButton)
        Me.TriggerGroupBox.Location = New System.Drawing.Point(328, 12)
        Me.TriggerGroupBox.Name = "TriggerGroupBox"
        Me.TriggerGroupBox.Size = New System.Drawing.Size(175, 276)
        Me.TriggerGroupBox.TabIndex = 1
        Me.TriggerGroupBox.TabStop = False
        Me.TriggerGroupBox.Text = "Trigger"
        '
        'SendPeriodButton
        '
        Me.SendPeriodButton.Location = New System.Drawing.Point(215, 86)
        Me.SendPeriodButton.Name = "SendPeriodButton"
        Me.SendPeriodButton.Size = New System.Drawing.Size(75, 26)
        Me.SendPeriodButton.TabIndex = 2
        Me.SendPeriodButton.Text = "Send"
        Me.SendPeriodButton.UseVisualStyleBackColor = True
        '
        'SendTrigSettingsButton
        '
        Me.SendTrigSettingsButton.Location = New System.Drawing.Point(66, 234)
        Me.SendTrigSettingsButton.Name = "SendTrigSettingsButton"
        Me.SendTrigSettingsButton.Size = New System.Drawing.Size(75, 26)
        Me.SendTrigSettingsButton.TabIndex = 3
        Me.SendTrigSettingsButton.Text = "Send"
        Me.SendTrigSettingsButton.UseVisualStyleBackColor = True
        '
        'StartTraceButton
        '
        Me.StartTraceButton.Location = New System.Drawing.Point(36, 262)
        Me.StartTraceButton.Name = "StartTraceButton"
        Me.StartTraceButton.Size = New System.Drawing.Size(89, 26)
        Me.StartTraceButton.TabIndex = 4
        Me.StartTraceButton.Text = "Start Trace"
        Me.StartTraceButton.UseVisualStyleBackColor = True
        '
        'StopTraceButton
        '
        Me.StopTraceButton.Location = New System.Drawing.Point(192, 262)
        Me.StopTraceButton.Name = "StopTraceButton"
        Me.StopTraceButton.Size = New System.Drawing.Size(89, 26)
        Me.StopTraceButton.TabIndex = 5
        Me.StopTraceButton.Text = "Stop Trace"
        Me.StopTraceButton.UseVisualStyleBackColor = True
        '
        'EnableDisableButton
        '
        Me.EnableDisableButton.Location = New System.Drawing.Point(162, 375)
        Me.EnableDisableButton.Name = "EnableDisableButton"
        Me.EnableDisableButton.Size = New System.Drawing.Size(100, 26)
        Me.EnableDisableButton.TabIndex = 6
        Me.EnableDisableButton.UseVisualStyleBackColor = True
        '
        'TrigTypeTextBox
        '
        Me.TrigTypeTextBox.Location = New System.Drawing.Point(79, 43)
        Me.TrigTypeTextBox.Name = "TrigTypeTextBox"
        Me.TrigTypeTextBox.Size = New System.Drawing.Size(72, 22)
        Me.TrigTypeTextBox.TabIndex = 7
        '
        'TrigChannelTextBox
        '
        Me.TrigChannelTextBox.Location = New System.Drawing.Point(79, 88)
        Me.TrigChannelTextBox.Name = "TrigChannelTextBox"
        Me.TrigChannelTextBox.Size = New System.Drawing.Size(72, 22)
        Me.TrigChannelTextBox.TabIndex = 7
        '
        'TrigLevelTextBox
        '
        Me.TrigLevelTextBox.Location = New System.Drawing.Point(79, 138)
        Me.TrigLevelTextBox.Name = "TrigLevelTextBox"
        Me.TrigLevelTextBox.Size = New System.Drawing.Size(72, 22)
        Me.TrigLevelTextBox.TabIndex = 8
        '
        'TrigDelayTextBox
        '
        Me.TrigDelayTextBox.Location = New System.Drawing.Point(79, 188)
        Me.TrigDelayTextBox.Name = "TrigDelayTextBox"
        Me.TrigDelayTextBox.Size = New System.Drawing.Size(72, 22)
        Me.TrigDelayTextBox.TabIndex = 9
        '
        'TracePeriodTextBox
        '
        Me.TracePeriodTextBox.Location = New System.Drawing.Point(152, 88)
        Me.TracePeriodTextBox.Name = "TracePeriodTextBox"
        Me.TracePeriodTextBox.Size = New System.Drawing.Size(45, 22)
        Me.TracePeriodTextBox.TabIndex = 7
        '
        'TrigTypeLabel
        '
        Me.TrigTypeLabel.AutoSize = True
        Me.TrigTypeLabel.Location = New System.Drawing.Point(6, 43)
        Me.TrigTypeLabel.Name = "TrigTypeLabel"
        Me.TrigTypeLabel.Size = New System.Drawing.Size(44, 17)
        Me.TrigTypeLabel.TabIndex = 8
        Me.TrigTypeLabel.Text = "Type:"
        '
        'TrigChannelLabel
        '
        Me.TrigChannelLabel.AutoSize = True
        Me.TrigChannelLabel.Location = New System.Drawing.Point(6, 91)
        Me.TrigChannelLabel.Name = "TrigChannelLabel"
        Me.TrigChannelLabel.Size = New System.Drawing.Size(64, 17)
        Me.TrigChannelLabel.TabIndex = 10
        Me.TrigChannelLabel.Text = "Channel:"
        '
        'TrigLevelLabel
        '
        Me.TrigLevelLabel.AutoSize = True
        Me.TrigLevelLabel.Location = New System.Drawing.Point(6, 143)
        Me.TrigLevelLabel.Name = "TrigLevelLabel"
        Me.TrigLevelLabel.Size = New System.Drawing.Size(46, 17)
        Me.TrigLevelLabel.TabIndex = 11
        Me.TrigLevelLabel.Text = "Level:"
        '
        'TrigDelayLevel
        '
        Me.TrigDelayLevel.AutoSize = True
        Me.TrigDelayLevel.Location = New System.Drawing.Point(6, 191)
        Me.TrigDelayLevel.Name = "TrigDelayLevel"
        Me.TrigDelayLevel.Size = New System.Drawing.Size(48, 17)
        Me.TrigDelayLevel.TabIndex = 12
        Me.TrigDelayLevel.Text = "Delay:"
        '
        'TraceRefPeriodLabel
        '
        Me.TraceRefPeriodLabel.AutoSize = True
        Me.TraceRefPeriodLabel.Location = New System.Drawing.Point(21, 46)
        Me.TraceRefPeriodLabel.Name = "TraceRefPeriodLabel"
        Me.TraceRefPeriodLabel.Size = New System.Drawing.Size(120, 17)
        Me.TraceRefPeriodLabel.TabIndex = 13
        Me.TraceRefPeriodLabel.Text = "Trace Ref Period:"
        '
        'TracePeriodLabel
        '
        Me.TracePeriodLabel.AutoSize = True
        Me.TracePeriodLabel.Location = New System.Drawing.Point(21, 91)
        Me.TracePeriodLabel.Name = "TracePeriodLabel"
        Me.TracePeriodLabel.Size = New System.Drawing.Size(94, 17)
        Me.TracePeriodLabel.TabIndex = 14
        Me.TracePeriodLabel.Text = "Trace Period:"
        '
        'MaxSamplesLabel
        '
        Me.MaxSamplesLabel.AutoSize = True
        Me.MaxSamplesLabel.Location = New System.Drawing.Point(21, 141)
        Me.MaxSamplesLabel.Name = "MaxSamplesLabel"
        Me.MaxSamplesLabel.Size = New System.Drawing.Size(95, 17)
        Me.MaxSamplesLabel.TabIndex = 15
        Me.MaxSamplesLabel.Text = "Max Samples:"
        '
        'TotalTraceTimeLabel
        '
        Me.TotalTraceTimeLabel.AutoSize = True
        Me.TotalTraceTimeLabel.Location = New System.Drawing.Point(21, 191)
        Me.TotalTraceTimeLabel.Name = "TotalTraceTimeLabel"
        Me.TotalTraceTimeLabel.Size = New System.Drawing.Size(120, 17)
        Me.TotalTraceTimeLabel.TabIndex = 16
        Me.TotalTraceTimeLabel.Text = "Total Trace Time:"
        '
        'TraceRefPeriodValue
        '
        Me.TraceRefPeriodValue.BackColor = System.Drawing.Color.Black
        Me.TraceRefPeriodValue.ForeColor = System.Drawing.Color.Lime
        Me.TraceRefPeriodValue.Location = New System.Drawing.Point(149, 46)
        Me.TraceRefPeriodValue.Name = "TraceRefPeriodValue"
        Me.TraceRefPeriodValue.Size = New System.Drawing.Size(48, 18)
        Me.TraceRefPeriodValue.TabIndex = 17
        Me.TraceRefPeriodValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MaxSamplesValue
        '
        Me.MaxSamplesValue.BackColor = System.Drawing.Color.Black
        Me.MaxSamplesValue.ForeColor = System.Drawing.Color.Lime
        Me.MaxSamplesValue.Location = New System.Drawing.Point(149, 143)
        Me.MaxSamplesValue.Name = "MaxSamplesValue"
        Me.MaxSamplesValue.Size = New System.Drawing.Size(48, 18)
        Me.MaxSamplesValue.TabIndex = 18
        Me.MaxSamplesValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TotalTraceTimeValue
        '
        Me.TotalTraceTimeValue.BackColor = System.Drawing.Color.Black
        Me.TotalTraceTimeValue.ForeColor = System.Drawing.Color.Lime
        Me.TotalTraceTimeValue.Location = New System.Drawing.Point(147, 191)
        Me.TotalTraceTimeValue.Name = "TotalTraceTimeValue"
        Me.TotalTraceTimeValue.Size = New System.Drawing.Size(77, 19)
        Me.TotalTraceTimeValue.TabIndex = 7
        Me.TotalTraceTimeValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(203, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 17)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "ns"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(230, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 17)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "ms"
        '
        'TraceStatusLabel
        '
        Me.TraceStatusLabel.AutoSize = True
        Me.TraceStatusLabel.Location = New System.Drawing.Point(33, 327)
        Me.TraceStatusLabel.Name = "TraceStatusLabel"
        Me.TraceStatusLabel.Size = New System.Drawing.Size(93, 17)
        Me.TraceStatusLabel.TabIndex = 21
        Me.TraceStatusLabel.Text = "Trace Status:"
        '
        'TraceStatusValue
        '
        Me.TraceStatusValue.BackColor = System.Drawing.Color.Black
        Me.TraceStatusValue.ForeColor = System.Drawing.Color.Lime
        Me.TraceStatusValue.Location = New System.Drawing.Point(141, 327)
        Me.TraceStatusValue.Name = "TraceStatusValue"
        Me.TraceStatusValue.Size = New System.Drawing.Size(211, 18)
        Me.TraceStatusValue.TabIndex = 22
        '
        'Timer1
        '
        '
        'Trace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 424)
        Me.Controls.Add(Me.TraceStatusValue)
        Me.Controls.Add(Me.TraceStatusLabel)
        Me.Controls.Add(Me.EnableDisableButton)
        Me.Controls.Add(Me.StopTraceButton)
        Me.Controls.Add(Me.StartTraceButton)
        Me.Controls.Add(Me.TriggerGroupBox)
        Me.Controls.Add(Me.TraceTimeGroupBox)
        Me.Name = "Trace"
        Me.Text = "Form1"
        Me.TraceTimeGroupBox.ResumeLayout(False)
        Me.TraceTimeGroupBox.PerformLayout()
        Me.TriggerGroupBox.ResumeLayout(False)
        Me.TriggerGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TraceTimeGroupBox As GroupBox
    Friend WithEvents SendPeriodButton As Button
    Friend WithEvents TriggerGroupBox As GroupBox
    Friend WithEvents SendTrigSettingsButton As Button
    Friend WithEvents StartTraceButton As Button
    Friend WithEvents StopTraceButton As Button
    Friend WithEvents EnableDisableButton As Button
    Friend WithEvents TrigLevelTextBox As TextBox
    Friend WithEvents TrigChannelTextBox As TextBox
    Friend WithEvents TrigTypeTextBox As TextBox
    Friend WithEvents TracePeriodTextBox As TextBox
    Friend WithEvents TrigDelayTextBox As TextBox
    Friend WithEvents TrigDelayLevel As Label
    Friend WithEvents TrigLevelLabel As Label
    Friend WithEvents TrigChannelLabel As Label
    Friend WithEvents TrigTypeLabel As Label
    Friend WithEvents TraceRefPeriodLabel As Label
    Friend WithEvents TraceRefPeriodValue As Label
    Friend WithEvents TotalTraceTimeLabel As Label
    Friend WithEvents MaxSamplesLabel As Label
    Friend WithEvents TracePeriodLabel As Label
    Friend WithEvents TotalTraceTimeValue As Label
    Friend WithEvents MaxSamplesValue As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TraceStatusLabel As Label
    Friend WithEvents TraceStatusValue As Label
    Friend WithEvents Timer1 As Timer
End Class
