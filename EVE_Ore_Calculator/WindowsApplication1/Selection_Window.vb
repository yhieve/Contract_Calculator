Public Class Selection_Window

    Private Sub Ore_Calculator_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MiningButton.Click
        Dim myform As New MiningAppraisel
        myform.Show()
    End Sub

    Private Sub PI_Button_Click(sender As Object, e As EventArgs) Handles PIButton.Click
        Dim myform As New PIAppraisel
        myform.Show()
    End Sub

End Class