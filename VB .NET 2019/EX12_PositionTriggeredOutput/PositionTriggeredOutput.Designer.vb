<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PositionTriggeredOutput
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
        Me.HardwarePositionTriggeredOutputButton = New System.Windows.Forms.Button()
        Me.SoftwarePositionTriggeredOutputButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'HardwarePositionTriggeredOutputButton
        '
        Me.HardwarePositionTriggeredOutputButton.BackColor = System.Drawing.Color.LawnGreen
        Me.HardwarePositionTriggeredOutputButton.Location = New System.Drawing.Point(43, 37)
        Me.HardwarePositionTriggeredOutputButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.HardwarePositionTriggeredOutputButton.Name = "HardwarePositionTriggeredOutputButton"
        Me.HardwarePositionTriggeredOutputButton.Size = New System.Drawing.Size(80, 84)
        Me.HardwarePositionTriggeredOutputButton.TabIndex = 0
        Me.HardwarePositionTriggeredOutputButton.Text = "Configure Hardware Position Triggered Output"
        Me.HardwarePositionTriggeredOutputButton.UseVisualStyleBackColor = False
        '
        'SoftwarePositionTriggeredOutputButton
        '
        Me.SoftwarePositionTriggeredOutputButton.BackColor = System.Drawing.Color.LawnGreen
        Me.SoftwarePositionTriggeredOutputButton.Location = New System.Drawing.Point(127, 37)
        Me.SoftwarePositionTriggeredOutputButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SoftwarePositionTriggeredOutputButton.Name = "SoftwarePositionTriggeredOutputButton"
        Me.SoftwarePositionTriggeredOutputButton.Size = New System.Drawing.Size(80, 84)
        Me.SoftwarePositionTriggeredOutputButton.TabIndex = 1
        Me.SoftwarePositionTriggeredOutputButton.Text = "Configure Software Position Triggered Output"
        Me.SoftwarePositionTriggeredOutputButton.UseVisualStyleBackColor = False
        '
        'PositionTriggeredOutput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(258, 175)
        Me.Controls.Add(Me.SoftwarePositionTriggeredOutputButton)
        Me.Controls.Add(Me.HardwarePositionTriggeredOutputButton)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "PositionTriggeredOutput"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HardwarePositionTriggeredOutputButton As Button
    Friend WithEvents SoftwarePositionTriggeredOutputButton As Button
End Class
