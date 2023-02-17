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
        Me.HomeAxisButton = New System.Windows.Forms.Button()
        Me.startButton = New System.Windows.Forms.Button()
        Me.StopPVTButton = New System.Windows.Forms.Button()
        Me.numberOfEventsTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'HomeAxisButton
        '
        Me.HomeAxisButton.Location = New System.Drawing.Point(54, 34)
        Me.HomeAxisButton.Name = "HomeAxisButton"
        Me.HomeAxisButton.Size = New System.Drawing.Size(243, 34)
        Me.HomeAxisButton.TabIndex = 0
        Me.HomeAxisButton.Text = "Home Axis"
        Me.HomeAxisButton.UseVisualStyleBackColor = True
        '
        'startButton
        '
        Me.startButton.Location = New System.Drawing.Point(54, 96)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(243, 34)
        Me.startButton.TabIndex = 1
        Me.startButton.Text = "Start PVT Motion"
        Me.startButton.UseVisualStyleBackColor = True
        '
        'StopPVTButton
        '
        Me.StopPVTButton.Location = New System.Drawing.Point(54, 158)
        Me.StopPVTButton.Name = "StopPVTButton"
        Me.StopPVTButton.Size = New System.Drawing.Size(243, 34)
        Me.StopPVTButton.TabIndex = 2
        Me.StopPVTButton.Text = "Stop PVT"
        Me.StopPVTButton.UseVisualStyleBackColor = True
        '
        'numberOfEventsTextBox
        '
        Me.numberOfEventsTextBox.Location = New System.Drawing.Point(224, 211)
        Me.numberOfEventsTextBox.Name = "numberOfEventsTextBox"
        Me.numberOfEventsTextBox.Size = New System.Drawing.Size(60, 22)
        Me.numberOfEventsTextBox.TabIndex = 3
        Me.numberOfEventsTextBox.Text = "0"
        Me.numberOfEventsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(70, 214)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Number of Events"
        '
        'PVT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 255)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.numberOfEventsTextBox)
        Me.Controls.Add(Me.StopPVTButton)
        Me.Controls.Add(Me.startButton)
        Me.Controls.Add(Me.HomeAxisButton)
        Me.Name = "PVT"
        Me.Text = "PVT"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HomeAxisButton As Button
    Friend WithEvents startButton As Button
    Friend WithEvents StopPVTButton As Button
    Friend WithEvents numberOfEventsTextBox As TextBox
    Friend WithEvents Label1 As Label
End Class
