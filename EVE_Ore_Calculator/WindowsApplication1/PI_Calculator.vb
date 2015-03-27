Imports System.Configuration
Imports MySql.Data.MySqlClient
Public Class PI_Calculator
    Dim Mysqlconn As MySqlConnection
    Dim cmd As MySqlCommand



    Private Sub Calc_Units1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Units1.Leave
        If (IPU1.Text.Trim().Length = 0 Or Units1.Text.Trim().Length = 0) Then
            IskMade1.Text = 0
        Else
            IskMade1.Text = Convert.ToDecimal(IPU1.Text) * Convert.ToDecimal(Units1.Text)
            Calc_Total_Isk_Made()
        End If
    End Sub
    Private Sub Calc_Units2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Units2.Leave
        If (IPU2.Text.Trim().Length = 0 Or Units2.Text.Trim().Length = 0) Then
            IskMade2.Text = 0
        Else
            IskMade2.Text = Convert.ToDecimal(IPU2.Text) * Convert.ToDecimal(Units2.Text)
            Calc_Total_Isk_Made()
        End If
    End Sub
    Private Sub Calc_Units3_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Units3.Leave
        If (IPU3.Text.Trim().Length = 0 Or Units3.Text.Trim().Length = 0) Then
            IskMade3.Text = 0
        Else
            IskMade3.Text = Convert.ToDecimal(IPU3.Text) * Convert.ToDecimal(Units3.Text)
            Calc_Total_Isk_Made()
        End If
    End Sub
    Private Sub Calc_Units4_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Units4.Leave
        If (IPU4.Text.Trim().Length = 0 Or Units4.Text.Trim().Length = 0) Then
            IskMade4.Text = 0
        Else
            IskMade4.Text = Convert.ToDecimal(IPU4.Text) * Convert.ToDecimal(Units4.Text)
            Calc_Total_Isk_Made()
        End If
    End Sub
    Private Sub Calc_Units5_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Units5.Leave
        If (IPU5.Text.Trim().Length = 0 Or Units5.Text.Trim().Length = 0) Then
            IskMade5.Text = 0
        Else
            IskMade5.Text = Convert.ToDecimal(IPU5.Text) * Convert.ToDecimal(Units5.Text)
            Calc_Total_Isk_Made()
        End If
    End Sub
    Private Sub Calc_Units6_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Units6.Leave
        If (IPU6.Text.Trim().Length = 0 Or Units6.Text.Trim().Length = 0) Then
            IskMade6.Text = 0
        Else
            IskMade6.Text = Convert.ToDecimal(IPU6.Text) * Convert.ToDecimal(Units6.Text)
            Calc_Total_Isk_Made()
        End If
    End Sub
    Private Sub Calc_Units7_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Units7.Leave
        If (IPU7.Text.Trim().Length = 0 Or Units7.Text.Trim().Length = 0) Then
            IskMade7.Text = 0
        Else
            IskMade7.Text = Convert.ToDecimal(IPU7.Text) * Convert.ToDecimal(Units7.Text)
            Calc_Total_Isk_Made()
        End If
    End Sub
    Private Sub Calc_Units8_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Units8.Leave
        If (IPU8.Text.Trim().Length = 0 Or Units8.Text.Trim().Length = 0) Then
            IskMade8.Text = 0
        Else
            IskMade8.Text = Convert.ToDecimal(IPU8.Text) * Convert.ToDecimal(Units8.Text)
            Calc_Total_Isk_Made()
        End If
    End Sub
    Private Sub Calc_Units9_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Units9.Leave
        If (IPU9.Text.Trim().Length = 0 Or Units9.Text.Trim().Length = 0) Then
            IskMade9.Text = 0
        Else
            IskMade9.Text = Convert.ToDecimal(IPU9.Text) * Convert.ToDecimal(Units9.Text)
            Calc_Total_Isk_Made()
        End If
    End Sub
    Private Sub Calc_Units10_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Units10.Leave
        If (IPU10.Text.Trim().Length = 0 Or Units10.Text.Trim().Length = 0) Then
            IskMade10.Text = 0
        Else
            IskMade10.Text = Convert.ToDecimal(IPU10.Text) * Convert.ToDecimal(Units10.Text)
            Calc_Total_Isk_Made()
        End If
    End Sub
    Private Sub Calc_Total_Isk_Made()
        Total_Isk_Made.Text = Convert.ToDecimal(IskMade1.Text) +
            Convert.ToDecimal(IskMade2.Text) +
            Convert.ToDecimal(IskMade3.Text) +
            Convert.ToDecimal(IskMade4.Text) +
            Convert.ToDecimal(IskMade5.Text) +
            Convert.ToDecimal(IskMade6.Text) +
            Convert.ToDecimal(IskMade7.Text) +
            Convert.ToDecimal(IskMade8.Text) +
            Convert.ToDecimal(IskMade9.Text) +
            Convert.ToDecimal(IskMade10.Text)
    End Sub

    Private Sub Clear_All_Button_Click(sender As Object, e As EventArgs) Handles Clear_All_Button.Click
        Item1.Text = ""
        Item2.Text = ""
        Item3.Text = ""
        Item4.Text = ""
        Item5.Text = ""
        Item6.Text = ""
        Item7.Text = ""
        Item8.Text = ""
        Item9.Text = ""
        Item10.Text = ""
        IPU1.Text = ""
        IPU2.Text = ""
        IPU3.Text = ""
        IPU4.Text = ""
        IPU5.Text = ""
        IPU6.Text = ""
        IPU7.Text = ""
        IPU8.Text = ""
        IPU9.Text = ""
        IPU10.Text = ""
        Units1.Text = ""
        Units2.Text = ""
        Units3.Text = ""
        Units4.Text = ""
        Units5.Text = ""
        Units6.Text = ""
        Units7.Text = ""
        Units8.Text = ""
        Units9.Text = ""
        Units10.Text = ""
        IskMade1.Text = "0"
        IskMade2.Text = "0"
        IskMade3.Text = "0"
        IskMade4.Text = "0"
        IskMade5.Text = "0"
        IskMade6.Text = "0"
        IskMade7.Text = "0"
        IskMade8.Text = "0"
        IskMade9.Text = "0"
        IskMade10.Text = "0"
    End Sub

    Private Sub PI_Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'YHIDataSet1.PI_Prices' table. You can move, or remove it, as needed.
        Me.PI_PricesTableAdapter.Fill(Me.YHIDataSet1.PI_Prices)
        'TODO: This line of code loads data into the 'YHIDataSet1.PI_Prices' table. You can move, or remove it, as needed.
        Me.PI_PricesTableAdapter.Fill(Me.YHIDataSet1.PI_Prices)
        'TODO: This line of code loads data into the 'YHIDataSet1.PI_Prices' table. You can move, or remove it, as needed.
        Me.PI_PricesTableAdapter.Fill(Me.YHIDataSet1.PI_Prices)
        'TODO: This line of code loads data into the 'YHIDataSet1.PI_Prices' table. You can move, or remove it, as needed.
        Me.PI_PricesTableAdapter.Fill(Me.YHIDataSet1.PI_Prices)
        'TODO: This line of code loads data into the 'YHIDataSet1.PI_Prices' table. You can move, or remove it, as needed.
        Me.PI_PricesTableAdapter.Fill(Me.YHIDataSet1.PI_Prices)
        'TODO: This line of code loads data into the 'YHIDataSet1.PI_Prices' table. You can move, or remove it, as needed.
        Me.PI_PricesTableAdapter.Fill(Me.YHIDataSet1.PI_Prices)
        'TODO: This line of code loads data into the 'YHIDataSet1.PI_Prices' table. You can move, or remove it, as needed.
        Me.PI_PricesTableAdapter.Fill(Me.YHIDataSet1.PI_Prices)
        'TODO: This line of code loads data into the 'YHIDataSet1.PI_Prices' table. You can move, or remove it, as needed.
        Me.PI_PricesTableAdapter.Fill(Me.YHIDataSet1.PI_Prices)
        'TODO: This line of code loads data into the 'YHIDataSet.PI_Prices' table. You can move, or remove it, as needed.
        Me.PI_PricesTableAdapter.Fill(Me.YHIDataSet.PI_Prices)

        IPU1.Text = ""
        IPU2.Text = ""
        IPU3.Text = ""
        IPU4.Text = ""
        IPU5.Text = ""
        IPU6.Text = ""
        IPU7.Text = ""
        IPU8.Text = ""
        IPU9.Text = ""
        IPU10.Text = ""

    End Sub

    Private Sub Item1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Item1.SelectedIndexChanged
        'MessageBox.Show(Item1.Text + " " + Item1.SelectedIndex.ToString())
        IPU1.Text = Item1.SelectedIndex.ToString()

    End Sub

    Private Sub Item2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Item2.SelectedIndexChanged
        'MessageBox.Show(Item1.Text + " " + Item1.SelectedIndex.ToString())
        IPU2.Text = Item2.SelectedIndex.ToString()
    End Sub

    Private Sub Item3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Item3.SelectedIndexChanged
        'MessageBox.Show(Item1.Text + " " + Item1.SelectedIndex.ToString())
        IPU3.Text = Item3.SelectedIndex.ToString()
    End Sub

    Private Sub Item4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Item4.SelectedIndexChanged
        'MessageBox.Show(Item1.Text + " " + Item1.SelectedIndex.ToString())
        IPU4.Text = Item4.SelectedIndex.ToString()
    End Sub

    Private Sub Item5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Item5.SelectedIndexChanged
        'MessageBox.Show(Item1.Text + " " + Item1.SelectedIndex.ToString())
        IPU5.Text = Item5.SelectedIndex.ToString()
    End Sub

    Private Sub Item6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Item6.SelectedIndexChanged
        'MessageBox.Show(Item1.Text + " " + Item1.SelectedIndex.ToString())
        IPU6.Text = Item6.SelectedIndex.ToString()
    End Sub

    Private Sub Item7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Item7.SelectedIndexChanged
        'MessageBox.Show(Item1.Text + " " + Item1.SelectedIndex.ToString())
        IPU7.Text = Item7.SelectedIndex.ToString()
    End Sub

    Private Sub Item8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Item8.SelectedIndexChanged
        'MessageBox.Show(Item1.Text + " " + Item1.SelectedIndex.ToString())
        IPU8.Text = Item8.SelectedIndex.ToString()
    End Sub

    Private Sub Item9_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Item9.SelectedIndexChanged
        'MessageBox.Show(Item1.Text + " " + Item1.SelectedIndex.ToString())
        IPU9.Text = Item9.SelectedIndex.ToString()
    End Sub

    Private Sub Item10_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Item10.SelectedIndexChanged
        'MessageBox.Show(Item1.Text + " " + Item1.SelectedIndex.ToString())
        IPU10.Text = Item10.SelectedIndex.ToString()
    End Sub
End Class