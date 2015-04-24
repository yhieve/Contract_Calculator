Imports System.Configuration
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System
Imports System.ComponentModel
Imports System.Windows

Public Class PIAppraisel

    Private Sub Clear_All_Button_Click(sender As Object, e As EventArgs) Handles Clear_All_Button.Click
        AppraisleBox.Text = ""
    End Sub

    Private Sub Skip_Click(sender As Object, e As EventArgs) Handles Skip.Click
        Dim ItemNames As List(Of String) = New List(Of String)
        Dim ItemAmounts As List(Of String) = New List(Of String)
        Dim M3Amounts As List(Of String) = New List(Of String)
        Dim myform As New Mining_Calculator(ItemNames, ItemAmounts, M3Amounts)
        myform.Show()
    End Sub

End Class