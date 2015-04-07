Imports System.Configuration
Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Mining_Calculator
    Dim Mysqlconn As MySqlConnection
    Dim cmd As MySqlCommand

    Private Sub Calc_Units1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Units1.Leave
        If (IPU1.Text.Trim().Length = 0 Or Units1.Text.Trim().Length = 0) Then
            IskMade1.Text = 0
        Else
            IskMade1.Text = Convert.ToDecimal(IPU1.Text) * Convert.ToDecimal(Units1.Text)
            M3Made1.Text = Convert.ToDecimal(Units1.Text) * Convert.ToDecimal(Item1.SelectedValue)
            Calc_Total_Isk_Made()
        End If
    End Sub
    Private Sub Calc_Units2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Units2.Leave
        If (IPU2.Text.Trim().Length = 0 Or Units2.Text.Trim().Length = 0) Then
            IskMade2.Text = 0
        Else
            IskMade2.Text = Convert.ToDecimal(IPU2.Text) * Convert.ToDecimal(Units2.Text)
            M3Made2.Text = Convert.ToDecimal(Units2.Text) * Convert.ToDecimal(Item2.SelectedValue)
            Calc_Total_Isk_Made()
        End If
    End Sub
    Private Sub Calc_Units3_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Units3.Leave
        If (IPU3.Text.Trim().Length = 0 Or Units3.Text.Trim().Length = 0) Then
            IskMade3.Text = 0
        Else
            IskMade3.Text = Convert.ToDecimal(IPU3.Text) * Convert.ToDecimal(Units3.Text)
            M3Made3.Text = Convert.ToDecimal(Units3.Text) * Convert.ToDecimal(Item3.SelectedValue)
            Calc_Total_Isk_Made()
        End If
    End Sub
    Private Sub Calc_Units4_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Units4.Leave
        If (IPU4.Text.Trim().Length = 0 Or Units4.Text.Trim().Length = 0) Then
            IskMade4.Text = 0
        Else
            IskMade4.Text = Convert.ToDecimal(IPU4.Text) * Convert.ToDecimal(Units4.Text)
            M3Made4.Text = Convert.ToDecimal(Units4.Text) * Convert.ToDecimal(Item4.SelectedValue)
            Calc_Total_Isk_Made()
        End If
    End Sub
    Private Sub Calc_Units5_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Units5.Leave
        If (IPU5.Text.Trim().Length = 0 Or Units5.Text.Trim().Length = 0) Then
            IskMade5.Text = 0
        Else
            IskMade5.Text = Convert.ToDecimal(IPU5.Text) * Convert.ToDecimal(Units5.Text)
            M3Made5.Text = Convert.ToDecimal(Units5.Text) * Convert.ToDecimal(Item5.SelectedValue)
            Calc_Total_Isk_Made()
        End If
    End Sub
    Private Sub Calc_Units6_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Units6.Leave
        If (IPU6.Text.Trim().Length = 0 Or Units6.Text.Trim().Length = 0) Then
            IskMade6.Text = 0
        Else
            IskMade6.Text = Convert.ToDecimal(IPU6.Text) * Convert.ToDecimal(Units6.Text)
            M3Made6.Text = Convert.ToDecimal(Units6.Text) * Convert.ToDecimal(Item6.SelectedValue)
            Calc_Total_Isk_Made()
        End If
    End Sub
    Private Sub Calc_Units7_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Units7.Leave
        If (IPU7.Text.Trim().Length = 0 Or Units7.Text.Trim().Length = 0) Then
            IskMade7.Text = 0
        Else
            IskMade7.Text = Convert.ToDecimal(IPU7.Text) * Convert.ToDecimal(Units7.Text)
            M3Made7.Text = Convert.ToDecimal(Units7.Text) * Convert.ToDecimal(Item7.SelectedValue)
            Calc_Total_Isk_Made()
        End If
    End Sub
    Private Sub Calc_Units8_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Units8.Leave
        If (IPU8.Text.Trim().Length = 0 Or Units8.Text.Trim().Length = 0) Then
            IskMade8.Text = 0
        Else
            IskMade8.Text = Convert.ToDecimal(IPU8.Text) * Convert.ToDecimal(Units8.Text)
            M3Made8.Text = Convert.ToDecimal(Units8.Text) * Convert.ToDecimal(Item8.SelectedValue)
            Calc_Total_Isk_Made()
        End If
    End Sub
    Private Sub Calc_Units9_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Units9.Leave
        If (IPU9.Text.Trim().Length = 0 Or Units9.Text.Trim().Length = 0) Then
            IskMade9.Text = 0
        Else
            IskMade9.Text = Convert.ToDecimal(IPU9.Text) * Convert.ToDecimal(Units9.Text)
            M3Made9.Text = Convert.ToDecimal(Units9.Text) * Convert.ToDecimal(Item9.SelectedValue)
            Calc_Total_Isk_Made()
        End If
    End Sub
    Private Sub Calc_Units10_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Units10.Leave
        If (IPU10.Text.Trim().Length = 0 Or Units10.Text.Trim().Length = 0) Then
            IskMade10.Text = 0
        Else
            IskMade10.Text = Convert.ToDecimal(IPU10.Text) * Convert.ToDecimal(Units10.Text)
            M3Made10.Text = Convert.ToDecimal(Units10.Text) * Convert.ToDecimal(Item10.SelectedValue)
            Calc_Total_Isk_Made()
        End If
    End Sub
    Private Sub Calc_Units11_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Units10.Leave
        If (IPU11.Text.Trim().Length = 0 Or Units11.Text.Trim().Length = 0) Then
            IskMade11.Text = 0
        Else
            IskMade11.Text = Convert.ToDecimal(IPU11.Text) * Convert.ToDecimal(Units11.Text)
            M3Made11.Text = Convert.ToDecimal(Units11.Text) * Convert.ToDecimal(Item11.SelectedValue)
            Calc_Total_Isk_Made()
        End If
    End Sub
    Private Sub Calc_Units12_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Units12.Leave
        If (IPU12.Text.Trim().Length = 0 Or Units12.Text.Trim().Length = 0) Then
            IskMade12.Text = 0
        Else
            IskMade12.Text = Convert.ToDecimal(IPU12.Text) * Convert.ToDecimal(Units12.Text)
            M3Made12.Text = Convert.ToDecimal(Units12.Text) * Convert.ToDecimal(Item12.SelectedValue)
            Calc_Total_Isk_Made()
        End If
    End Sub
    Private Sub Calc_Units13_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Units13.Leave
        If (IPU13.Text.Trim().Length = 0 Or Units13.Text.Trim().Length = 0) Then
            IskMade13.Text = 0
        Else
            IskMade13.Text = Convert.ToDecimal(IPU13.Text) * Convert.ToDecimal(Units13.Text)
            M3Made13.Text = Convert.ToDecimal(Units13.Text) * Convert.ToDecimal(Item13.SelectedValue)
            Calc_Total_Isk_Made()
        End If
    End Sub
    Private Sub Calc_Units14_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Units14.Leave
        If (IPU14.Text.Trim().Length = 0 Or Units14.Text.Trim().Length = 0) Then
            IskMade14.Text = 0
        Else
            IskMade14.Text = Convert.ToDecimal(IPU14.Text) * Convert.ToDecimal(Units14.Text)
            M3Made14.Text = Convert.ToDecimal(Units14.Text) * Convert.ToDecimal(Item14.SelectedValue)
            Calc_Total_Isk_Made()
        End If
    End Sub
    Private Sub Calc_Units15_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Units15.Leave
        If (IPU15.Text.Trim().Length = 0 Or Units15.Text.Trim().Length = 0) Then
            IskMade15.Text = 0
        Else
            IskMade15.Text = Convert.ToDecimal(IPU15.Text) * Convert.ToDecimal(Units15.Text)
            M3Made15.Text = Convert.ToDecimal(Units15.Text) * Convert.ToDecimal(Item15.SelectedValue)
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
            Convert.ToDecimal(IskMade10.Text) +
            Convert.ToDecimal(IskMade11.Text) +
            Convert.ToDecimal(IskMade12.Text) +
            Convert.ToDecimal(IskMade13.Text) +
            Convert.ToDecimal(IskMade14.Text) +
            Convert.ToDecimal(IskMade15.Text)
        Total_M3_Made.Text = Convert.ToDecimal(M3Made1.Text) +
            Convert.ToDecimal(M3Made2.Text) +
            Convert.ToDecimal(M3Made3.Text) +
            Convert.ToDecimal(M3Made4.Text) +
            Convert.ToDecimal(M3Made5.Text) +
            Convert.ToDecimal(M3Made6.Text) +
            Convert.ToDecimal(M3Made7.Text) +
            Convert.ToDecimal(M3Made8.Text) +
            Convert.ToDecimal(M3Made9.Text) +
            Convert.ToDecimal(M3Made10.Text) +
            Convert.ToDecimal(M3Made11.Text) +
            Convert.ToDecimal(M3Made12.Text) +
            Convert.ToDecimal(M3Made13.Text) +
            Convert.ToDecimal(M3Made14.Text) +
            Convert.ToDecimal(M3Made15.Text)
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
        Item11.Text = ""
        Item12.Text = ""
        Item13.Text = ""
        Item14.Text = ""
        Item15.Text = ""
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
        IPU11.Text = ""
        IPU12.Text = ""
        IPU13.Text = ""
        IPU14.Text = ""
        IPU15.Text = ""
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
        Units11.Text = ""
        Units12.Text = ""
        Units13.Text = ""
        Units14.Text = ""
        Units15.Text = ""
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
        IskMade11.Text = "0"
        IskMade12.Text = "0"
        IskMade13.Text = "0"
        IskMade14.Text = "0"
        IskMade15.Text = "0"
        M3Made1.Text = "0"
        M3Made2.Text = "0"
        M3Made3.Text = "0"
        M3Made4.Text = "0"
        M3Made5.Text = "0"
        M3Made6.Text = "0"
        M3Made7.Text = "0"
        M3Made8.Text = "0"
        M3Made9.Text = "0"
        M3Made10.Text = "0"
        M3Made11.Text = "0"
        M3Made12.Text = "0"
        M3Made13.Text = "0"
        M3Made14.Text = "0"
        M3Made15.Text = "0"
        Total_Isk_Made.Text = ""
        Total_M3_Made.Text = ""
    End Sub

    Private Sub Mining_Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'YHIDataSet1.Mining_Prices' table. You can move, or remove it, as needed.
        Me.Mining_PricesTableAdapter.Fill(Me.YHIDataSet1.Mining_Prices)

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
        IPU11.Text = ""
        IPU12.Text = ""
        IPU13.Text = ""
        IPU14.Text = ""
        IPU15.Text = ""

    End Sub

    Private Sub Item1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Item1.SelectedIndexChanged
        If Item1.SelectedIndex > 0 Then
            Dim Source_Data As EVE_Ore_Calculator.YHIDataSet1.Mining_PricesRow = Item1.SelectedItem.Row
            IPU1.Text = Source_Data.Price
        End If

    End Sub

    Private Sub Item2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Item2.SelectedIndexChanged
        If Item2.SelectedIndex > 0 Then
            Dim Source_Data As EVE_Ore_Calculator.YHIDataSet1.Mining_PricesRow = Item2.SelectedItem.Row
            IPU2.Text = Source_Data.Price
        End If
    End Sub

    Private Sub Item3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Item3.SelectedIndexChanged
        If Item3.SelectedIndex > 0 Then
            Dim Source_Data As EVE_Ore_Calculator.YHIDataSet1.Mining_PricesRow = Item3.SelectedItem.Row
            IPU3.Text = Source_Data.Price
        End If
    End Sub

    Private Sub Item4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Item4.SelectedIndexChanged
        If Item4.SelectedIndex > 0 Then
            Dim Source_Data As EVE_Ore_Calculator.YHIDataSet1.Mining_PricesRow = Item4.SelectedItem.Row
            IPU4.Text = Source_Data.Price
        End If
    End Sub

    Private Sub Item5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Item5.SelectedIndexChanged
        If Item5.SelectedIndex > 0 Then
            Dim Source_Data As EVE_Ore_Calculator.YHIDataSet1.Mining_PricesRow = Item5.SelectedItem.Row
            IPU5.Text = Source_Data.Price
        End If
    End Sub

    Private Sub Item6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Item6.SelectedIndexChanged
        If Item6.SelectedIndex > 0 Then
            Dim Source_Data As EVE_Ore_Calculator.YHIDataSet1.Mining_PricesRow = Item6.SelectedItem.Row
            IPU6.Text = Source_Data.Price
        End If
    End Sub

    Private Sub Item7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Item7.SelectedIndexChanged
        If Item7.SelectedIndex > 0 Then
            Dim Source_Data As EVE_Ore_Calculator.YHIDataSet1.Mining_PricesRow = Item7.SelectedItem.Row
            IPU7.Text = Source_Data.Price
        End If
    End Sub

    Private Sub Item8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Item8.SelectedIndexChanged
        If Item8.SelectedIndex > 0 Then
            Dim Source_Data As EVE_Ore_Calculator.YHIDataSet1.Mining_PricesRow = Item8.SelectedItem.Row
            IPU8.Text = Source_Data.Price
        End If
    End Sub

    Private Sub Item9_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Item9.SelectedIndexChanged
        If Item9.SelectedIndex > 0 Then
            Dim Source_Data As EVE_Ore_Calculator.YHIDataSet1.Mining_PricesRow = Item9.SelectedItem.Row
            IPU9.Text = Source_Data.Price
        End If
    End Sub

    Private Sub Item10_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Item10.SelectedIndexChanged
        If Item10.SelectedIndex > 0 Then
            Dim Source_Data As EVE_Ore_Calculator.YHIDataSet1.Mining_PricesRow = Item10.SelectedItem.Row
            IPU10.Text = Source_Data.Price
        End If
    End Sub
    Private Sub Item11_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Item11.SelectedIndexChanged
        If Item11.SelectedIndex > 0 Then
            Dim Source_Data As EVE_Ore_Calculator.YHIDataSet1.Mining_PricesRow = Item11.SelectedItem.Row
            IPU11.Text = Source_Data.Price
        End If
    End Sub
    Private Sub Item12_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Item12.SelectedIndexChanged
        If Item12.SelectedIndex > 0 Then
            Dim Source_Data As EVE_Ore_Calculator.YHIDataSet1.Mining_PricesRow = Item12.SelectedItem.Row
            IPU12.Text = Source_Data.Price
        End If
    End Sub
    Private Sub Item13_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Item13.SelectedIndexChanged
        If Item13.SelectedIndex > 0 Then
            Dim Source_Data As EVE_Ore_Calculator.YHIDataSet1.Mining_PricesRow = Item13.SelectedItem.Row
            IPU13.Text = Source_Data.Price
        End If
    End Sub
    Private Sub Item14_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Item14.SelectedIndexChanged
        If Item14.SelectedIndex > 0 Then
            Dim Source_Data As EVE_Ore_Calculator.YHIDataSet1.Mining_PricesRow = Item14.SelectedItem.Row
            IPU14.Text = Source_Data.Price
        End If
    End Sub
    Private Sub Item15_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Item15.SelectedIndexChanged
        If Item15.SelectedIndex > 0 Then
            Dim Source_Data As EVE_Ore_Calculator.YHIDataSet1.Mining_PricesRow = Item15.SelectedItem.Row
            IPU15.Text = Source_Data.Price
        End If
    End Sub

    Private Sub Export_Button_Click(sender As Object, e As EventArgs) Handles Export_Button.Click
        If Not (Directory.Exists("C:\YHI_Contract_Info")) Then
            Directory.CreateDirectory("C:\YHI_Contract_Info")
        End If
        Using writer As StreamWriter = New StreamWriter("C:\YHI_Contract_Info\Mining_Contract_Info_" + DateTime.Today.ToString("MMddyyy") + ".csv")
            writer.WriteLine("Total Isk Made, Total M3 Made")
            writer.WriteLine(Total_Isk_Made.Text + "," + Total_M3_Made.Text)
            writer.WriteLine(" ")
            writer.WriteLine("Item,Isk Per Unit,Units,IskMade,M3Made")
            writer.WriteLine(Item1.Text + "," + IPU1.Text + "," + Units1.Text + "," + IskMade1.Text + "," + M3Made1.Text)
            writer.WriteLine(Item2.Text + "," + IPU2.Text + "," + Units2.Text + "," + IskMade2.Text + "," + M3Made2.Text)
            writer.WriteLine(Item3.Text + "," + IPU3.Text + "," + Units3.Text + "," + IskMade3.Text + "," + M3Made3.Text)
            writer.WriteLine(Item4.Text + "," + IPU4.Text + "," + Units4.Text + "," + IskMade4.Text + "," + M3Made4.Text)
            writer.WriteLine(Item5.Text + "," + IPU5.Text + "," + Units5.Text + "," + IskMade5.Text + "," + M3Made5.Text)
            writer.WriteLine(Item6.Text + "," + IPU6.Text + "," + Units6.Text + "," + IskMade6.Text + "," + M3Made6.Text)
            writer.WriteLine(Item7.Text + "," + IPU7.Text + "," + Units7.Text + "," + IskMade7.Text + "," + M3Made7.Text)
            writer.WriteLine(Item8.Text + "," + IPU8.Text + "," + Units8.Text + "," + IskMade8.Text + "," + M3Made8.Text)
            writer.WriteLine(Item9.Text + "," + IPU9.Text + "," + Units9.Text + "," + IskMade9.Text + "," + M3Made9.Text)
            writer.WriteLine(Item10.Text + "," + IPU10.Text + "," + Units10.Text + "," + IskMade10.Text + "," + M3Made10.Text)
            writer.WriteLine(Item11.Text + "," + IPU11.Text + "," + Units11.Text + "," + IskMade11.Text + "," + M3Made11.Text)
            writer.WriteLine(Item12.Text + "," + IPU12.Text + "," + Units12.Text + "," + IskMade12.Text + "," + M3Made12.Text)
            writer.WriteLine(Item13.Text + "," + IPU13.Text + "," + Units13.Text + "," + IskMade13.Text + "," + M3Made13.Text)
            writer.WriteLine(Item14.Text + "," + IPU14.Text + "," + Units14.Text + "," + IskMade14.Text + "," + M3Made14.Text)
            writer.WriteLine(Item15.Text + "," + IPU15.Text + "," + Units15.Text + "," + IskMade15.Text + "," + M3Made15.Text)
        End Using
        MessageBox.Show("File Exported to C:\YHI_Contract_Info")
    End Sub
End Class