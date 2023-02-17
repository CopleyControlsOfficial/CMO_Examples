<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PVT
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.numberOfEventsTextBox = New System.Windows.Forms.TextBox()
        Me.StopPVTButton = New System.Windows.Forms.Button()
        Me.startButton = New System.Windows.Forms.Button()
        Me.HomeAxisButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 173)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Number of Events"
        '
        'numberOfEventsTextBox
        '
        Me.numberOfEventsTextBox.Location = New System.Drawing.Point(137, 171)
        Me.numberOfEventsTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.numberOfEventsTextBox.Name = "numberOfEventsTextBox"
        Me.numberOfEventsTextBox.Size = New System.Drawing.Size(68, 20)
        Me.numberOfEventsTextBox.TabIndex = 8
        Me.numberOfEventsTextBox.Text = "0"
        Me.numberOfEventsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'StopPVTButton
        '
        Me.StopPVTButton.Location = New System.Drawing.Point(70, 118)
        Me.StopPVTButton.Margin = New System.Windows.Forms.Padding(2)
        Me.StopPVTButton.Name = "StopPVTButton"
        Me.StopPVTButton.Size = New System.Drawing.Size(106, 30)
        Me.StopPVTButton.TabIndex = 7
        Me.StopPVTButton.Text = "Stop PVT"
        Me.StopPVTButton.UseVisualStyleBackColor = True
        '
        'startButton
        '
        Me.startButton.Location = New System.Drawing.Point(70, 71)
        Me.startButton.Margin = New System.Windows.Forms.Padding(2)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(106, 30)
        Me.startButton.TabIndex = 6
        Me.startButton.Text = "Start PVT Motion"
        Me.startButton.UseVisualStyleBackColor = True
        '
        'HomeAxisButton
        '
        Me.HomeAxisButton.Location = New System.Drawing.Point(70, 23)
        Me.HomeAxisButton.Margin = New System.Windows.Forms.Padding(2)
        Me.HomeAxisButton.Name = "HomeAxisButton"
        Me.HomeAxisButton.Size = New System.Drawing.Size(106, 30)
        Me.HomeAxisButton.TabIndex = 5
        Me.HomeAxisButton.Text = "Home Axis"
        Me.HomeAxisButton.UseVisualStyleBackColor = True
        '
        'PVT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(241, 223)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.numberOfEventsTextBox)
        Me.Controls.Add(Me.StopPVTButton)
        Me.Controls.Add(Me.startButton)
        Me.Controls.Add(Me.HomeAxisButton)
        Me.Name = "PVT"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents numberOfEventsTextBox As TextBox
    Friend WithEvents StopPVTButton As Button
    Friend WithEvents startButton As Button
    Friend WithEvents HomeAxisButton As Button
End Class
