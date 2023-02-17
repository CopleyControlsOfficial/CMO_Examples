<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PDOmapping
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
        Me.SendOffsetButton = New System.Windows.Forms.Button()
        Me.SaveMappingToFlashButton = New System.Windows.Forms.Button()
        Me.PositionTextBox = New System.Windows.Forms.TextBox()
        Me.AlogRefTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'SendOffsetButton
        '
        Me.SendOffsetButton.Location = New System.Drawing.Point(89, 33)
        Me.SendOffsetButton.Name = "SendOffsetButton"
        Me.SendOffsetButton.Size = New System.Drawing.Size(118, 32)
        Me.SendOffsetButton.TabIndex = 0
        Me.SendOffsetButton.Text = "Send Data"
        Me.SendOffsetButton.UseVisualStyleBackColor = True
        '
        'SaveMappingToFlashButton
        '
        Me.SaveMappingToFlashButton.Location = New System.Drawing.Point(89, 175)
        Me.SaveMappingToFlashButton.Name = "SaveMappingToFlashButton"
        Me.SaveMappingToFlashButton.Size = New System.Drawing.Size(118, 32)
        Me.SaveMappingToFlashButton.TabIndex = 1
        Me.SaveMappingToFlashButton.Text = "Send Mapping"
        Me.SaveMappingToFlashButton.UseVisualStyleBackColor = True
        '
        'PositionTextBox
        '
        Me.PositionTextBox.Location = New System.Drawing.Point(89, 89)
        Me.PositionTextBox.Name = "PositionTextBox"
        Me.PositionTextBox.Size = New System.Drawing.Size(118, 22)
        Me.PositionTextBox.TabIndex = 2
        '
        'AlogRefTextBox
        '
        Me.AlogRefTextBox.Location = New System.Drawing.Point(89, 132)
        Me.AlogRefTextBox.Name = "AlogRefTextBox"
        Me.AlogRefTextBox.Size = New System.Drawing.Size(118, 22)
        Me.AlogRefTextBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Position: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Offset: "
        '
        'PDOmapping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 255)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AlogRefTextBox)
        Me.Controls.Add(Me.PositionTextBox)
        Me.Controls.Add(Me.SaveMappingToFlashButton)
        Me.Controls.Add(Me.SendOffsetButton)
        Me.Name = "PDOmapping"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SendOffsetButton As Button
    Friend WithEvents SaveMappingToFlashButton As Button
    Friend WithEvents PositionTextBox As TextBox
    Friend WithEvents AlogRefTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
