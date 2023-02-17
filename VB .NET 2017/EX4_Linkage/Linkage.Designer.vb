<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Linkage
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
        Me.linkageMoveButton = New System.Windows.Forms.Button()
        Me.xAxisTextBox = New System.Windows.Forms.TextBox()
        Me.yAxisTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'HomeAxisButton
        '
        Me.HomeAxisButton.Location = New System.Drawing.Point(90, 29)
        Me.HomeAxisButton.Name = "HomeAxisButton"
        Me.HomeAxisButton.Size = New System.Drawing.Size(205, 40)
        Me.HomeAxisButton.TabIndex = 0
        Me.HomeAxisButton.Text = "Home Axis"
        Me.HomeAxisButton.UseVisualStyleBackColor = True
        '
        'linkageMoveButton
        '
        Me.linkageMoveButton.Location = New System.Drawing.Point(90, 85)
        Me.linkageMoveButton.Name = "linkageMoveButton"
        Me.linkageMoveButton.Size = New System.Drawing.Size(205, 40)
        Me.linkageMoveButton.TabIndex = 1
        Me.linkageMoveButton.Text = "Perform Linkage Move"
        Me.linkageMoveButton.UseVisualStyleBackColor = True
        '
        'xAxisTextBox
        '
        Me.xAxisTextBox.Location = New System.Drawing.Point(214, 140)
        Me.xAxisTextBox.Name = "xAxisTextBox"
        Me.xAxisTextBox.Size = New System.Drawing.Size(100, 22)
        Me.xAxisTextBox.TabIndex = 2
        Me.xAxisTextBox.Text = "20000"
        '
        'yAxisTextBox
        '
        Me.yAxisTextBox.Location = New System.Drawing.Point(214, 187)
        Me.yAxisTextBox.Name = "yAxisTextBox"
        Me.yAxisTextBox.Size = New System.Drawing.Size(100, 22)
        Me.yAxisTextBox.TabIndex = 3
        Me.yAxisTextBox.Text = "10000"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "X Axis Move to Position"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Y Axis Move to Position"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(320, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "counts"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(320, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "counts"
        '
        'Linkage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 255)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.yAxisTextBox)
        Me.Controls.Add(Me.xAxisTextBox)
        Me.Controls.Add(Me.linkageMoveButton)
        Me.Controls.Add(Me.HomeAxisButton)
        Me.Name = "Linkage"
        Me.Text = "Linkage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HomeAxisButton As Button
    Friend WithEvents linkageMoveButton As Button
    Friend WithEvents xAxisTextBox As TextBox
    Friend WithEvents yAxisTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
