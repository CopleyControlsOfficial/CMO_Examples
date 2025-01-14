Public Class NodeInput
    Dim nodeIdentification As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nodeIdentification = Convert.ToInt32(NodeIDTextBox.Text)
        Dispose()
    End Sub
    Public Function NodeID() As Integer
        Return nodeIdentification
    End Function
End Class