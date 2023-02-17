Public Class NodeInput
    Dim nodeIdentification As Integer

    Private Sub NodeInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SendIDButton_Click(sender As Object, e As EventArgs) Handles SendIDButton.Click
        nodeIdentification = Convert.ToInt32(NodeIDTextBox.Text)
        Dispose()
    End Sub

    Public Function NodeID() As Integer
        Return nodeIdentification
    End Function
End Class