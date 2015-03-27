Public Class Selection_Window

    Private Sub MiningButton_Click(sender As Object, e As EventArgs) Handles MiningButton.Click
        Dim myform As New Mining_Calculator
        myform.Show()
    End Sub

    Private Sub PIButton_Click(sender As Object, e As EventArgs) Handles PIButton.Click
        Dim myform As New PI_Calculator
        myform.Show()
    End Sub
End Class