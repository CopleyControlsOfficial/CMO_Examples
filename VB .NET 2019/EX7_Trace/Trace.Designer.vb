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
        Me.EnableDisableButton = New System.Windows.Forms.Button()
        Me.TraceStatusLabel = New System.Windows.Forms.Label()
        Me.TraceStatusValue = New System.Windows.Forms.Label()
        Me.StopTraceButton = New System.Windows.Forms.Button()
        Me.StartTraceButton = New System.Windows.Forms.Button()
        Me.TriggerGroupBox = New System.Windows.Forms.GroupBox()
        Me.TrigDelayLabel = New System.Windows.Forms.Label()
        Me.TrigLevelLabel = New System.Windows.Forms.Label()
        Me.TrigChannelLabel = New System.Windows.Forms.Label()
        Me.TrigTypeLabel = New System.Windows.Forms.Label()
        Me.SendTrigSettingsButton = New System.Windows.Forms.Button()
        Me.TrigDelayTextBox = New System.Windows.Forms.TextBox()
        Me.TrigLevelTextBox = New System.Windows.Forms.TextBox()
        Me.TrigChannelTextBox = New System.Windows.Forms.TextBox()
        Me.TrigTypeTextBox = New System.Windows.Forms.TextBox()
        Me.TraceTimeGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TotalTraceTimeLabel = New System.Windows.Forms.Label()
        Me.MaxSamplesLabel = New System.Windows.Forms.Label()
        Me.TracePeriodLabel = New System.Windows.Forms.Label()
        Me.TraceRefPeriodLabel = New System.Windows.Forms.Label()
        Me.TotalTraceTimeValue = New System.Windows.Forms.Label()
        Me.MaxSamplesValue = New System.Windows.Forms.Label()
        Me.TraceRefPeriodValue = New System.Windows.Forms.Label()
        Me.TracePeriodTextBox = New System.Windows.Forms.TextBox()
        Me.SendPeriodButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TriggerGroupBox.SuspendLayout()
        Me.TraceTimeGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'EnableDisableButton
        '
        Me.EnableDisableButton.Location = New System.Drawing.Point(74, 306)
        Me.EnableDisableButton.Margin = New System.Windows.Forms.Padding(2)
        Me.EnableDisableButton.Name = "EnableDisableButton"
        Me.EnableDisableButton.Size = New System.Drawing.Size(76, 22)
        Me.EnableDisableButton.TabIndex = 30
        Me.EnableDisableButton.UseVisualStyleBackColor = True
        '
        'TraceStatusLabel
        '
        Me.TraceStatusLabel.AutoSize = True
        Me.TraceStatusLabel.Location = New System.Drawing.Point(34, 276)
        Me.TraceStatusLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TraceStatusLabel.Name = "TraceStatusLabel"
        Me.TraceStatusLabel.Size = New System.Drawing.Size(71, 13)
        Me.TraceStatusLabel.TabIndex = 29
        Me.TraceStatusLabel.Text = "Trace Status:"
        '
        'TraceStatusValue
        '
        Me.TraceStatusValue.BackColor = System.Drawing.Color.Black
        Me.TraceStatusValue.ForeColor = System.Drawing.Color.Lime
        Me.TraceStatusValue.Location = New System.Drawing.Point(108, 276)
        Me.TraceStatusValue.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TraceStatusValue.Name = "TraceStatusValue"
        Me.TraceStatusValue.Size = New System.Drawing.Size(158, 15)
        Me.TraceStatusValue.TabIndex = 28
        '
        'StopTraceButton
        '
        Me.StopTraceButton.Location = New System.Drawing.Point(144, 194)
        Me.StopTraceButton.Margin = New System.Windows.Forms.Padding(2)
        Me.StopTraceButton.Name = "StopTraceButton"
        Me.StopTraceButton.Size = New System.Drawing.Size(74, 25)
        Me.StopTraceButton.TabIndex = 27
        Me.StopTraceButton.Text = "Stop Trace"
        Me.StopTraceButton.UseVisualStyleBackColor = True
        '
        'StartTraceButton
        '
        Me.StartTraceButton.Location = New System.Drawing.Point(36, 194)
        Me.StartTraceButton.Margin = New System.Windows.Forms.Padding(2)
        Me.StartTraceButton.Name = "StartTraceButton"
        Me.StartTraceButton.Size = New System.Drawing.Size(74, 25)
        Me.StartTraceButton.TabIndex = 26
        Me.StartTraceButton.Text = "Start Trace"
        Me.StartTraceButton.UseVisualStyleBackColor = True
        '
        'TriggerGroupBox
        '
        Me.TriggerGroupBox.Controls.Add(Me.TrigDelayLabel)
        Me.TriggerGroupBox.Controls.Add(Me.TrigLevelLabel)
        Me.TriggerGroupBox.Controls.Add(Me.TrigChannelLabel)
        Me.TriggerGroupBox.Controls.Add(Me.TrigTypeLabel)
        Me.TriggerGroupBox.Controls.Add(Me.SendTrigSettingsButton)
        Me.TriggerGroupBox.Controls.Add(Me.TrigDelayTextBox)
        Me.TriggerGroupBox.Controls.Add(Me.TrigLevelTextBox)
        Me.TriggerGroupBox.Controls.Add(Me.TrigChannelTextBox)
        Me.TriggerGroupBox.Controls.Add(Me.TrigTypeTextBox)
        Me.TriggerGroupBox.Location = New System.Drawing.Point(262, 11)
        Me.TriggerGroupBox.Margin = New System.Windows.Forms.Padding(2)
        Me.TriggerGroupBox.Name = "TriggerGroupBox"
        Me.TriggerGroupBox.Padding = New System.Windows.Forms.Padding(2)
        Me.TriggerGroupBox.Size = New System.Drawing.Size(150, 240)
        Me.TriggerGroupBox.TabIndex = 24
        Me.TriggerGroupBox.TabStop = False
        Me.TriggerGroupBox.Text = "Trigger"
        '
        'TrigDelayLabel
        '
        Me.TrigDelayLabel.AutoSize = True
        Me.TrigDelayLabel.Location = New System.Drawing.Point(15, 137)
        Me.TrigDelayLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TrigDelayLabel.Name = "TrigDelayLabel"
        Me.TrigDelayLabel.Size = New System.Drawing.Size(37, 13)
        Me.TrigDelayLabel.TabIndex = 22
        Me.TrigDelayLabel.Text = "Delay:"
        '
        'TrigLevelLabel
        '
        Me.TrigLevelLabel.AutoSize = True
        Me.TrigLevelLabel.Location = New System.Drawing.Point(15, 102)
        Me.TrigLevelLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TrigLevelLabel.Name = "TrigLevelLabel"
        Me.TrigLevelLabel.Size = New System.Drawing.Size(36, 13)
        Me.TrigLevelLabel.TabIndex = 21
        Me.TrigLevelLabel.Text = "Level:"
        '
        'TrigChannelLabel
        '
        Me.TrigChannelLabel.AutoSize = True
        Me.TrigChannelLabel.Location = New System.Drawing.Point(15, 66)
        Me.TrigChannelLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TrigChannelLabel.Name = "TrigChannelLabel"
        Me.TrigChannelLabel.Size = New System.Drawing.Size(49, 13)
        Me.TrigChannelLabel.TabIndex = 20
        Me.TrigChannelLabel.Text = "Channel:"
        '
        'TrigTypeLabel
        '
        Me.TrigTypeLabel.AutoSize = True
        Me.TrigTypeLabel.Location = New System.Drawing.Point(15, 28)
        Me.TrigTypeLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TrigTypeLabel.Name = "TrigTypeLabel"
        Me.TrigTypeLabel.Size = New System.Drawing.Size(34, 13)
        Me.TrigTypeLabel.TabIndex = 19
        Me.TrigTypeLabel.Text = "Type:"
        '
        'SendTrigSettingsButton
        '
        Me.SendTrigSettingsButton.Location = New System.Drawing.Point(52, 184)
        Me.SendTrigSettingsButton.Margin = New System.Windows.Forms.Padding(2)
        Me.SendTrigSettingsButton.Name = "SendTrigSettingsButton"
        Me.SendTrigSettingsButton.Size = New System.Drawing.Size(56, 25)
        Me.SendTrigSettingsButton.TabIndex = 3
        Me.SendTrigSettingsButton.Text = "Send"
        Me.SendTrigSettingsButton.UseVisualStyleBackColor = True
        '
        'TrigDelayTextBox
        '
        Me.TrigDelayTextBox.Location = New System.Drawing.Point(88, 135)
        Me.TrigDelayTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.TrigDelayTextBox.Name = "TrigDelayTextBox"
        Me.TrigDelayTextBox.Size = New System.Drawing.Size(51, 20)
        Me.TrigDelayTextBox.TabIndex = 1
        '
        'TrigLevelTextBox
        '
        Me.TrigLevelTextBox.Location = New System.Drawing.Point(88, 99)
        Me.TrigLevelTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.TrigLevelTextBox.Name = "TrigLevelTextBox"
        Me.TrigLevelTextBox.Size = New System.Drawing.Size(51, 20)
        Me.TrigLevelTextBox.TabIndex = 2
        '
        'TrigChannelTextBox
        '
        Me.TrigChannelTextBox.Location = New System.Drawing.Point(88, 63)
        Me.TrigChannelTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.TrigChannelTextBox.Name = "TrigChannelTextBox"
        Me.TrigChannelTextBox.Size = New System.Drawing.Size(51, 20)
        Me.TrigChannelTextBox.TabIndex = 1
        '
        'TrigTypeTextBox
        '
        Me.TrigTypeTextBox.Location = New System.Drawing.Point(88, 25)
        Me.TrigTypeTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.TrigTypeTextBox.Name = "TrigTypeTextBox"
        Me.TrigTypeTextBox.Size = New System.Drawing.Size(51, 20)
        Me.TrigTypeTextBox.TabIndex = 0
        '
        'TraceTimeGroupBox
        '
        Me.TraceTimeGroupBox.Controls.Add(Me.Label2)
        Me.TraceTimeGroupBox.Controls.Add(Me.Label1)
        Me.TraceTimeGroupBox.Controls.Add(Me.TotalTraceTimeLabel)
        Me.TraceTimeGroupBox.Controls.Add(Me.MaxSamplesLabel)
        Me.TraceTimeGroupBox.Controls.Add(Me.TracePeriodLabel)
        Me.TraceTimeGroupBox.Controls.Add(Me.TraceRefPeriodLabel)
        Me.TraceTimeGroupBox.Controls.Add(Me.TotalTraceTimeValue)
        Me.TraceTimeGroupBox.Controls.Add(Me.MaxSamplesValue)
        Me.TraceTimeGroupBox.Controls.Add(Me.TraceRefPeriodValue)
        Me.TraceTimeGroupBox.Controls.Add(Me.TracePeriodTextBox)
        Me.TraceTimeGroupBox.Controls.Add(Me.SendPeriodButton)
        Me.TraceTimeGroupBox.Location = New System.Drawing.Point(13, 11)
        Me.TraceTimeGroupBox.Margin = New System.Windows.Forms.Padding(2)
        Me.TraceTimeGroupBox.Name = "TraceTimeGroupBox"
        Me.TraceTimeGroupBox.Padding = New System.Windows.Forms.Padding(2)
        Me.TraceTimeGroupBox.Size = New System.Drawing.Size(228, 175)
        Me.TraceTimeGroupBox.TabIndex = 25
        Me.TraceTimeGroupBox.TabStop = False
        Me.TraceTimeGroupBox.Text = "Trace Time"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(168, 138)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "ms"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(148, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "ns"
        '
        'TotalTraceTimeLabel
        '
        Me.TotalTraceTimeLabel.AutoSize = True
        Me.TotalTraceTimeLabel.Location = New System.Drawing.Point(4, 137)
        Me.TotalTraceTimeLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TotalTraceTimeLabel.Name = "TotalTraceTimeLabel"
        Me.TotalTraceTimeLabel.Size = New System.Drawing.Size(91, 13)
        Me.TotalTraceTimeLabel.TabIndex = 15
        Me.TotalTraceTimeLabel.Text = "Total Trace Time:"
        '
        'MaxSamplesLabel
        '
        Me.MaxSamplesLabel.AutoSize = True
        Me.MaxSamplesLabel.Location = New System.Drawing.Point(4, 102)
        Me.MaxSamplesLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MaxSamplesLabel.Name = "MaxSamplesLabel"
        Me.MaxSamplesLabel.Size = New System.Drawing.Size(73, 13)
        Me.MaxSamplesLabel.TabIndex = 14
        Me.MaxSamplesLabel.Text = "Max Samples:"
        '
        'TracePeriodLabel
        '
        Me.TracePeriodLabel.AutoSize = True
        Me.TracePeriodLabel.Location = New System.Drawing.Point(4, 66)
        Me.TracePeriodLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TracePeriodLabel.Name = "TracePeriodLabel"
        Me.TracePeriodLabel.Size = New System.Drawing.Size(71, 13)
        Me.TracePeriodLabel.TabIndex = 13
        Me.TracePeriodLabel.Text = "Trace Period:"
        '
        'TraceRefPeriodLabel
        '
        Me.TraceRefPeriodLabel.AutoSize = True
        Me.TraceRefPeriodLabel.Location = New System.Drawing.Point(4, 29)
        Me.TraceRefPeriodLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TraceRefPeriodLabel.Name = "TraceRefPeriodLabel"
        Me.TraceRefPeriodLabel.Size = New System.Drawing.Size(91, 13)
        Me.TraceRefPeriodLabel.TabIndex = 12
        Me.TraceRefPeriodLabel.Text = "Trace Ref Period:"
        '
        'TotalTraceTimeValue
        '
        Me.TotalTraceTimeValue.BackColor = System.Drawing.Color.Black
        Me.TotalTraceTimeValue.ForeColor = System.Drawing.Color.Lime
        Me.TotalTraceTimeValue.Location = New System.Drawing.Point(106, 137)
        Me.TotalTraceTimeValue.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TotalTraceTimeValue.Name = "TotalTraceTimeValue"
        Me.TotalTraceTimeValue.Size = New System.Drawing.Size(58, 15)
        Me.TotalTraceTimeValue.TabIndex = 10
        Me.TotalTraceTimeValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MaxSamplesValue
        '
        Me.MaxSamplesValue.BackColor = System.Drawing.Color.Black
        Me.MaxSamplesValue.ForeColor = System.Drawing.Color.Lime
        Me.MaxSamplesValue.Location = New System.Drawing.Point(106, 102)
        Me.MaxSamplesValue.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MaxSamplesValue.Name = "MaxSamplesValue"
        Me.MaxSamplesValue.Size = New System.Drawing.Size(36, 15)
        Me.MaxSamplesValue.TabIndex = 9
        '
        'TraceRefPeriodValue
        '
        Me.TraceRefPeriodValue.BackColor = System.Drawing.Color.Black
        Me.TraceRefPeriodValue.ForeColor = System.Drawing.Color.Lime
        Me.TraceRefPeriodValue.Location = New System.Drawing.Point(108, 28)
        Me.TraceRefPeriodValue.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TraceRefPeriodValue.Name = "TraceRefPeriodValue"
        Me.TraceRefPeriodValue.Size = New System.Drawing.Size(36, 15)
        Me.TraceRefPeriodValue.TabIndex = 8
        Me.TraceRefPeriodValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TracePeriodTextBox
        '
        Me.TracePeriodTextBox.Location = New System.Drawing.Point(108, 63)
        Me.TracePeriodTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.TracePeriodTextBox.Name = "TracePeriodTextBox"
        Me.TracePeriodTextBox.Size = New System.Drawing.Size(37, 20)
        Me.TracePeriodTextBox.TabIndex = 7
        '
        'SendPeriodButton
        '
        Me.SendPeriodButton.Location = New System.Drawing.Point(158, 60)
        Me.SendPeriodButton.Margin = New System.Windows.Forms.Padding(2)
        Me.SendPeriodButton.Name = "SendPeriodButton"
        Me.SendPeriodButton.Size = New System.Drawing.Size(56, 25)
        Me.SendPeriodButton.TabIndex = 6
        Me.SendPeriodButton.Text = "Send"
        Me.SendPeriodButton.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Trace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 350)
        Me.Controls.Add(Me.EnableDisableButton)
        Me.Controls.Add(Me.TraceStatusLabel)
        Me.Controls.Add(Me.TraceStatusValue)
        Me.Controls.Add(Me.StopTraceButton)
        Me.Controls.Add(Me.StartTraceButton)
        Me.Controls.Add(Me.TriggerGroupBox)
        Me.Controls.Add(Me.TraceTimeGroupBox)
        Me.Name = "Trace"
        Me.Text = "Form1"
        Me.TriggerGroupBox.ResumeLayout(False)
        Me.TriggerGroupBox.PerformLayout()
        Me.TraceTimeGroupBox.ResumeLayout(False)
        Me.TraceTimeGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EnableDisableButton As Button
    Friend WithEvents TraceStatusLabel As Label
    Friend WithEvents TraceStatusValue As Label
    Friend WithEvents StopTraceButton As Button
    Friend WithEvents StartTraceButton As Button
    Friend WithEvents TriggerGroupBox As GroupBox
    Friend WithEvents TrigDelayLabel As Label
    Friend WithEvents TrigLevelLabel As Label
    Friend WithEvents TrigChannelLabel As Label
    Friend WithEvents TrigTypeLabel As Label
    Friend WithEvents SendTrigSettingsButton As Button
    Friend WithEvents TrigDelayTextBox As TextBox
    Friend WithEvents TrigLevelTextBox As TextBox
    Friend WithEvents TrigChannelTextBox As TextBox
    Friend WithEvents TrigTypeTextBox As TextBox
    Friend WithEvents TraceTimeGroupBox As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TotalTraceTimeLabel As Label
    Friend WithEvents MaxSamplesLabel As Label
    Friend WithEvents TracePeriodLabel As Label
    Friend WithEvents TraceRefPeriodLabel As Label
    Friend WithEvents TotalTraceTimeValue As Label
    Friend WithEvents MaxSamplesValue As Label
    Friend WithEvents TraceRefPeriodValue As Label
    Friend WithEvents TracePeriodTextBox As TextBox
    Friend WithEvents SendPeriodButton As Button
    Friend WithEvents Timer1 As Timer
End Class
