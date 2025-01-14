<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IndexerRegViaSDO
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
        Me.txtRegisterNumber = New System.Windows.Forms.TextBox()
        Me.txtWriteData = New System.Windows.Forms.TextBox()
        Me.txtReadData = New System.Windows.Forms.TextBox()
        Me.cmdRead = New System.Windows.Forms.Button()
        Me.cmdWrite = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Register Number"
        '
        'txtRegisterNumber
        '
        Me.txtRegisterNumber.Location = New System.Drawing.Point(143, 21)
        Me.txtRegisterNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRegisterNumber.Name = "txtRegisterNumber"
        Me.txtRegisterNumber.Size = New System.Drawing.Size(30, 20)
        Me.txtRegisterNumber.TabIndex = 10
        Me.txtRegisterNumber.Text = "0"
        Me.txtRegisterNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtWriteData
        '
        Me.txtWriteData.Location = New System.Drawing.Point(143, 73)
        Me.txtWriteData.Margin = New System.Windows.Forms.Padding(2)
        Me.txtWriteData.Name = "txtWriteData"
        Me.txtWriteData.Size = New System.Drawing.Size(76, 20)
        Me.txtWriteData.TabIndex = 9
        Me.txtWriteData.Text = "0"
        Me.txtWriteData.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtReadData
        '
        Me.txtReadData.Location = New System.Drawing.Point(143, 115)
        Me.txtReadData.Margin = New System.Windows.Forms.Padding(2)
        Me.txtReadData.Name = "txtReadData"
        Me.txtReadData.Size = New System.Drawing.Size(76, 20)
        Me.txtReadData.TabIndex = 8
        Me.txtReadData.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdRead
        '
        Me.cmdRead.Location = New System.Drawing.Point(33, 111)
        Me.cmdRead.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdRead.Name = "cmdRead"
        Me.cmdRead.Size = New System.Drawing.Size(80, 26)
        Me.cmdRead.TabIndex = 7
        Me.cmdRead.Text = "Read Register"
        Me.cmdRead.UseVisualStyleBackColor = True
        '
        'cmdWrite
        '
        Me.cmdWrite.Location = New System.Drawing.Point(33, 69)
        Me.cmdWrite.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdWrite.Name = "cmdWrite"
        Me.cmdWrite.Size = New System.Drawing.Size(80, 26)
        Me.cmdWrite.TabIndex = 6
        Me.cmdWrite.Text = "Write Register"
        Me.cmdWrite.UseVisualStyleBackColor = True
        '
        'IndexerRegViaSDO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(255, 176)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRegisterNumber)
        Me.Controls.Add(Me.txtWriteData)
        Me.Controls.Add(Me.txtReadData)
        Me.Controls.Add(Me.cmdRead)
        Me.Controls.Add(Me.cmdWrite)
        Me.Name = "IndexerRegViaSDO"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtRegisterNumber As TextBox
    Friend WithEvents txtWriteData As TextBox
    Friend WithEvents txtReadData As TextBox
    Friend WithEvents cmdRead As Button
    Friend WithEvents cmdWrite As Button
End Class
