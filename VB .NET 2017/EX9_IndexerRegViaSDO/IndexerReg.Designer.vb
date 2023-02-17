<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IndexerReg
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
        Me.cmdWrite = New System.Windows.Forms.Button()
        Me.cmdRead = New System.Windows.Forms.Button()
        Me.txtWriteData = New System.Windows.Forms.TextBox()
        Me.txtReadData = New System.Windows.Forms.TextBox()
        Me.txtRegisterNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdWrite
        '
        Me.cmdWrite.Location = New System.Drawing.Point(61, 87)
        Me.cmdWrite.Name = "cmdWrite"
        Me.cmdWrite.Size = New System.Drawing.Size(121, 32)
        Me.cmdWrite.TabIndex = 0
        Me.cmdWrite.Text = "Write Register"
        Me.cmdWrite.UseVisualStyleBackColor = True
        '
        'cmdRead
        '
        Me.cmdRead.Location = New System.Drawing.Point(61, 144)
        Me.cmdRead.Name = "cmdRead"
        Me.cmdRead.Size = New System.Drawing.Size(121, 32)
        Me.cmdRead.TabIndex = 1
        Me.cmdRead.Text = "Read Register"
        Me.cmdRead.UseVisualStyleBackColor = True
        '
        'txtWriteData
        '
        Me.txtWriteData.Location = New System.Drawing.Point(188, 92)
        Me.txtWriteData.Name = "txtWriteData"
        Me.txtWriteData.Size = New System.Drawing.Size(100, 22)
        Me.txtWriteData.TabIndex = 2
        Me.txtWriteData.Text = "0"
        Me.txtWriteData.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtReadData
        '
        Me.txtReadData.Location = New System.Drawing.Point(188, 149)
        Me.txtReadData.Name = "txtReadData"
        Me.txtReadData.Size = New System.Drawing.Size(100, 22)
        Me.txtReadData.TabIndex = 3
        Me.txtReadData.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRegisterNumber
        '
        Me.txtRegisterNumber.Location = New System.Drawing.Point(188, 32)
        Me.txtRegisterNumber.Name = "txtRegisterNumber"
        Me.txtRegisterNumber.Size = New System.Drawing.Size(42, 22)
        Me.txtRegisterNumber.TabIndex = 4
        Me.txtRegisterNumber.Text = "0"
        Me.txtRegisterNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Register Number"
        '
        'IndexerReg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 193)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRegisterNumber)
        Me.Controls.Add(Me.txtReadData)
        Me.Controls.Add(Me.txtWriteData)
        Me.Controls.Add(Me.cmdRead)
        Me.Controls.Add(Me.cmdWrite)
        Me.Name = "IndexerReg"
        Me.Text = "R/W Indexer Register via SDO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdWrite As Button
    Friend WithEvents cmdRead As Button
    Friend WithEvents txtWriteData As TextBox
    Friend WithEvents txtReadData As TextBox
    Friend WithEvents txtRegisterNumber As TextBox
    Friend WithEvents Label1 As Label
End Class
