<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PI_Calculator
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PI_Calculator))
        Me.Item1 = New System.Windows.Forms.ComboBox()
        Me.PIPricesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.YHIDataSet = New EVE_Ore_Calculator.YHIDataSet()
        Me.IPU1 = New System.Windows.Forms.TextBox()
        Me.Units1 = New System.Windows.Forms.TextBox()
        Me.IskMade1 = New System.Windows.Forms.TextBox()
        Me.Item_Label = New System.Windows.Forms.Label()
        Me.ISK_Per_Unit_Label = New System.Windows.Forms.Label()
        Me.Units_Label = New System.Windows.Forms.Label()
        Me.Isk_Made_Label = New System.Windows.Forms.Label()
        Me.Total_Isk_Made_Label = New System.Windows.Forms.Label()
        Me.Total_Isk_Made = New System.Windows.Forms.TextBox()
        Me.IskMade2 = New System.Windows.Forms.TextBox()
        Me.Units2 = New System.Windows.Forms.TextBox()
        Me.IPU2 = New System.Windows.Forms.TextBox()
        Me.IskMade3 = New System.Windows.Forms.TextBox()
        Me.Units3 = New System.Windows.Forms.TextBox()
        Me.IPU3 = New System.Windows.Forms.TextBox()
        Me.IskMade4 = New System.Windows.Forms.TextBox()
        Me.Units4 = New System.Windows.Forms.TextBox()
        Me.IPU4 = New System.Windows.Forms.TextBox()
        Me.IskMade5 = New System.Windows.Forms.TextBox()
        Me.Units5 = New System.Windows.Forms.TextBox()
        Me.IPU5 = New System.Windows.Forms.TextBox()
        Me.IskMade6 = New System.Windows.Forms.TextBox()
        Me.Units6 = New System.Windows.Forms.TextBox()
        Me.IPU6 = New System.Windows.Forms.TextBox()
        Me.IskMade7 = New System.Windows.Forms.TextBox()
        Me.Units7 = New System.Windows.Forms.TextBox()
        Me.IPU7 = New System.Windows.Forms.TextBox()
        Me.IskMade8 = New System.Windows.Forms.TextBox()
        Me.Units8 = New System.Windows.Forms.TextBox()
        Me.IPU8 = New System.Windows.Forms.TextBox()
        Me.IskMade9 = New System.Windows.Forms.TextBox()
        Me.Units9 = New System.Windows.Forms.TextBox()
        Me.IPU9 = New System.Windows.Forms.TextBox()
        Me.IskMade10 = New System.Windows.Forms.TextBox()
        Me.Units10 = New System.Windows.Forms.TextBox()
        Me.IPU10 = New System.Windows.Forms.TextBox()
        Me.Clear_All_Button = New System.Windows.Forms.Button()
        Me.Item2 = New System.Windows.Forms.ComboBox()
        Me.PIPricesBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Item3 = New System.Windows.Forms.ComboBox()
        Me.PIPricesBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.YHIDataSet1 = New EVE_Ore_Calculator.YHIDataSet()
        Me.Item4 = New System.Windows.Forms.ComboBox()
        Me.PIPricesBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Item5 = New System.Windows.Forms.ComboBox()
        Me.PIPricesBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Item6 = New System.Windows.Forms.ComboBox()
        Me.PIPricesBindingSource6 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Item7 = New System.Windows.Forms.ComboBox()
        Me.PIPricesBindingSource7 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Item8 = New System.Windows.Forms.ComboBox()
        Me.PIPricesBindingSource8 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Item9 = New System.Windows.Forms.ComboBox()
        Me.PIPricesBindingSource9 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Item10 = New System.Windows.Forms.ComboBox()
        Me.PIPricesBindingSource10 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PI_PricesTableAdapter = New EVE_Ore_Calculator.YHIDataSetTableAdapters.PI_PricesTableAdapter()
        CType(Me.PIPricesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YHIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIPricesBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIPricesBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YHIDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIPricesBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIPricesBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIPricesBindingSource6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIPricesBindingSource7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIPricesBindingSource8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIPricesBindingSource9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIPricesBindingSource10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Item1
        '
        Me.Item1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Item1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Item1.DataSource = Me.PIPricesBindingSource1
        Me.Item1.DisplayMember = "Item"
        Me.Item1.FormattingEnabled = True
        Me.Item1.Location = New System.Drawing.Point(68, 100)
        Me.Item1.Name = "Item1"
        Me.Item1.Size = New System.Drawing.Size(233, 28)
        Me.Item1.TabIndex = 6
        '
        'PIPricesBindingSource1
        '
        Me.PIPricesBindingSource1.DataMember = "PI_Prices"
        Me.PIPricesBindingSource1.DataSource = Me.YHIDataSet
        '
        'YHIDataSet
        '
        Me.YHIDataSet.DataSetName = "YHIDataSet"
        Me.YHIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IPU1
        '
        Me.IPU1.BackColor = System.Drawing.SystemColors.Window
        Me.IPU1.Enabled = False
        Me.IPU1.Location = New System.Drawing.Point(350, 98)
        Me.IPU1.Name = "IPU1"
        Me.IPU1.ReadOnly = True
        Me.IPU1.Size = New System.Drawing.Size(137, 26)
        Me.IPU1.TabIndex = 7
        '
        'Units1
        '
        Me.Units1.Location = New System.Drawing.Point(542, 100)
        Me.Units1.Name = "Units1"
        Me.Units1.Size = New System.Drawing.Size(137, 26)
        Me.Units1.TabIndex = 8
        '
        'IskMade1
        '
        Me.IskMade1.BackColor = System.Drawing.SystemColors.Window
        Me.IskMade1.Enabled = False
        Me.IskMade1.Location = New System.Drawing.Point(725, 98)
        Me.IskMade1.Name = "IskMade1"
        Me.IskMade1.ReadOnly = True
        Me.IskMade1.Size = New System.Drawing.Size(137, 26)
        Me.IskMade1.TabIndex = 9
        Me.IskMade1.Text = "0"
        '
        'Item_Label
        '
        Me.Item_Label.AutoSize = True
        Me.Item_Label.Location = New System.Drawing.Point(164, 74)
        Me.Item_Label.Name = "Item_Label"
        Me.Item_Label.Size = New System.Drawing.Size(41, 20)
        Me.Item_Label.TabIndex = 2
        Me.Item_Label.Text = "Item"
        '
        'ISK_Per_Unit_Label
        '
        Me.ISK_Per_Unit_Label.AutoSize = True
        Me.ISK_Per_Unit_Label.Location = New System.Drawing.Point(373, 74)
        Me.ISK_Per_Unit_Label.Name = "ISK_Per_Unit_Label"
        Me.ISK_Per_Unit_Label.Size = New System.Drawing.Size(91, 20)
        Me.ISK_Per_Unit_Label.TabIndex = 3
        Me.ISK_Per_Unit_Label.Text = "Isk Per Unit"
        '
        'Units_Label
        '
        Me.Units_Label.AutoSize = True
        Me.Units_Label.Location = New System.Drawing.Point(589, 74)
        Me.Units_Label.Name = "Units_Label"
        Me.Units_Label.Size = New System.Drawing.Size(46, 20)
        Me.Units_Label.TabIndex = 4
        Me.Units_Label.Text = "Units"
        '
        'Isk_Made_Label
        '
        Me.Isk_Made_Label.AutoSize = True
        Me.Isk_Made_Label.Location = New System.Drawing.Point(754, 74)
        Me.Isk_Made_Label.Name = "Isk_Made_Label"
        Me.Isk_Made_Label.Size = New System.Drawing.Size(74, 20)
        Me.Isk_Made_Label.TabIndex = 5
        Me.Isk_Made_Label.Text = "Isk Made"
        '
        'Total_Isk_Made_Label
        '
        Me.Total_Isk_Made_Label.AutoSize = True
        Me.Total_Isk_Made_Label.Location = New System.Drawing.Point(231, 25)
        Me.Total_Isk_Made_Label.Name = "Total_Isk_Made_Label"
        Me.Total_Isk_Made_Label.Size = New System.Drawing.Size(113, 20)
        Me.Total_Isk_Made_Label.TabIndex = 0
        Me.Total_Isk_Made_Label.Text = "Total Isk Made"
        '
        'Total_Isk_Made
        '
        Me.Total_Isk_Made.BackColor = System.Drawing.SystemColors.Window
        Me.Total_Isk_Made.Location = New System.Drawing.Point(350, 25)
        Me.Total_Isk_Made.Name = "Total_Isk_Made"
        Me.Total_Isk_Made.ReadOnly = True
        Me.Total_Isk_Made.Size = New System.Drawing.Size(177, 26)
        Me.Total_Isk_Made.TabIndex = 1
        Me.Total_Isk_Made.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'IskMade2
        '
        Me.IskMade2.BackColor = System.Drawing.SystemColors.Window
        Me.IskMade2.Enabled = False
        Me.IskMade2.Location = New System.Drawing.Point(725, 154)
        Me.IskMade2.Name = "IskMade2"
        Me.IskMade2.ReadOnly = True
        Me.IskMade2.Size = New System.Drawing.Size(137, 26)
        Me.IskMade2.TabIndex = 13
        Me.IskMade2.Text = "0"
        '
        'Units2
        '
        Me.Units2.Location = New System.Drawing.Point(542, 156)
        Me.Units2.Name = "Units2"
        Me.Units2.Size = New System.Drawing.Size(137, 26)
        Me.Units2.TabIndex = 12
        '
        'IPU2
        '
        Me.IPU2.BackColor = System.Drawing.SystemColors.Window
        Me.IPU2.Enabled = False
        Me.IPU2.Location = New System.Drawing.Point(350, 154)
        Me.IPU2.Name = "IPU2"
        Me.IPU2.ReadOnly = True
        Me.IPU2.Size = New System.Drawing.Size(137, 26)
        Me.IPU2.TabIndex = 11
        '
        'IskMade3
        '
        Me.IskMade3.BackColor = System.Drawing.SystemColors.Window
        Me.IskMade3.Enabled = False
        Me.IskMade3.Location = New System.Drawing.Point(725, 204)
        Me.IskMade3.Name = "IskMade3"
        Me.IskMade3.ReadOnly = True
        Me.IskMade3.Size = New System.Drawing.Size(137, 26)
        Me.IskMade3.TabIndex = 17
        Me.IskMade3.Text = "0"
        '
        'Units3
        '
        Me.Units3.Location = New System.Drawing.Point(542, 206)
        Me.Units3.Name = "Units3"
        Me.Units3.Size = New System.Drawing.Size(137, 26)
        Me.Units3.TabIndex = 16
        '
        'IPU3
        '
        Me.IPU3.BackColor = System.Drawing.SystemColors.Window
        Me.IPU3.Enabled = False
        Me.IPU3.Location = New System.Drawing.Point(350, 204)
        Me.IPU3.Name = "IPU3"
        Me.IPU3.ReadOnly = True
        Me.IPU3.Size = New System.Drawing.Size(137, 26)
        Me.IPU3.TabIndex = 15
        Me.IPU3.Text = " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'IskMade4
        '
        Me.IskMade4.BackColor = System.Drawing.SystemColors.Window
        Me.IskMade4.Enabled = False
        Me.IskMade4.Location = New System.Drawing.Point(725, 257)
        Me.IskMade4.Name = "IskMade4"
        Me.IskMade4.ReadOnly = True
        Me.IskMade4.Size = New System.Drawing.Size(137, 26)
        Me.IskMade4.TabIndex = 21
        Me.IskMade4.Text = "0"
        '
        'Units4
        '
        Me.Units4.Location = New System.Drawing.Point(542, 259)
        Me.Units4.Name = "Units4"
        Me.Units4.Size = New System.Drawing.Size(137, 26)
        Me.Units4.TabIndex = 20
        '
        'IPU4
        '
        Me.IPU4.BackColor = System.Drawing.SystemColors.Window
        Me.IPU4.Enabled = False
        Me.IPU4.Location = New System.Drawing.Point(350, 257)
        Me.IPU4.Name = "IPU4"
        Me.IPU4.ReadOnly = True
        Me.IPU4.Size = New System.Drawing.Size(137, 26)
        Me.IPU4.TabIndex = 19
        '
        'IskMade5
        '
        Me.IskMade5.BackColor = System.Drawing.SystemColors.Window
        Me.IskMade5.Enabled = False
        Me.IskMade5.Location = New System.Drawing.Point(725, 311)
        Me.IskMade5.Name = "IskMade5"
        Me.IskMade5.ReadOnly = True
        Me.IskMade5.Size = New System.Drawing.Size(137, 26)
        Me.IskMade5.TabIndex = 25
        Me.IskMade5.Text = "0"
        '
        'Units5
        '
        Me.Units5.Location = New System.Drawing.Point(542, 313)
        Me.Units5.Name = "Units5"
        Me.Units5.Size = New System.Drawing.Size(137, 26)
        Me.Units5.TabIndex = 24
        '
        'IPU5
        '
        Me.IPU5.BackColor = System.Drawing.SystemColors.Window
        Me.IPU5.Enabled = False
        Me.IPU5.Location = New System.Drawing.Point(350, 311)
        Me.IPU5.Name = "IPU5"
        Me.IPU5.ReadOnly = True
        Me.IPU5.Size = New System.Drawing.Size(137, 26)
        Me.IPU5.TabIndex = 23
        '
        'IskMade6
        '
        Me.IskMade6.BackColor = System.Drawing.SystemColors.Window
        Me.IskMade6.Enabled = False
        Me.IskMade6.Location = New System.Drawing.Point(725, 365)
        Me.IskMade6.Name = "IskMade6"
        Me.IskMade6.ReadOnly = True
        Me.IskMade6.Size = New System.Drawing.Size(137, 26)
        Me.IskMade6.TabIndex = 29
        Me.IskMade6.Text = "0"
        '
        'Units6
        '
        Me.Units6.Location = New System.Drawing.Point(542, 367)
        Me.Units6.Name = "Units6"
        Me.Units6.Size = New System.Drawing.Size(137, 26)
        Me.Units6.TabIndex = 28
        '
        'IPU6
        '
        Me.IPU6.BackColor = System.Drawing.SystemColors.Window
        Me.IPU6.Enabled = False
        Me.IPU6.Location = New System.Drawing.Point(350, 365)
        Me.IPU6.Name = "IPU6"
        Me.IPU6.ReadOnly = True
        Me.IPU6.Size = New System.Drawing.Size(137, 26)
        Me.IPU6.TabIndex = 27
        '
        'IskMade7
        '
        Me.IskMade7.BackColor = System.Drawing.SystemColors.Window
        Me.IskMade7.Enabled = False
        Me.IskMade7.Location = New System.Drawing.Point(725, 416)
        Me.IskMade7.Name = "IskMade7"
        Me.IskMade7.ReadOnly = True
        Me.IskMade7.Size = New System.Drawing.Size(137, 26)
        Me.IskMade7.TabIndex = 33
        Me.IskMade7.Text = "0"
        '
        'Units7
        '
        Me.Units7.Location = New System.Drawing.Point(542, 418)
        Me.Units7.Name = "Units7"
        Me.Units7.Size = New System.Drawing.Size(137, 26)
        Me.Units7.TabIndex = 32
        '
        'IPU7
        '
        Me.IPU7.BackColor = System.Drawing.SystemColors.Window
        Me.IPU7.Enabled = False
        Me.IPU7.Location = New System.Drawing.Point(350, 416)
        Me.IPU7.Name = "IPU7"
        Me.IPU7.ReadOnly = True
        Me.IPU7.Size = New System.Drawing.Size(137, 26)
        Me.IPU7.TabIndex = 31
        '
        'IskMade8
        '
        Me.IskMade8.BackColor = System.Drawing.SystemColors.Window
        Me.IskMade8.Enabled = False
        Me.IskMade8.Location = New System.Drawing.Point(725, 468)
        Me.IskMade8.Name = "IskMade8"
        Me.IskMade8.ReadOnly = True
        Me.IskMade8.Size = New System.Drawing.Size(137, 26)
        Me.IskMade8.TabIndex = 37
        Me.IskMade8.Text = "0"
        '
        'Units8
        '
        Me.Units8.Location = New System.Drawing.Point(542, 470)
        Me.Units8.Name = "Units8"
        Me.Units8.Size = New System.Drawing.Size(137, 26)
        Me.Units8.TabIndex = 36
        '
        'IPU8
        '
        Me.IPU8.BackColor = System.Drawing.SystemColors.Window
        Me.IPU8.Enabled = False
        Me.IPU8.Location = New System.Drawing.Point(350, 468)
        Me.IPU8.Name = "IPU8"
        Me.IPU8.ReadOnly = True
        Me.IPU8.Size = New System.Drawing.Size(137, 26)
        Me.IPU8.TabIndex = 35
        '
        'IskMade9
        '
        Me.IskMade9.BackColor = System.Drawing.SystemColors.Window
        Me.IskMade9.Enabled = False
        Me.IskMade9.Location = New System.Drawing.Point(725, 524)
        Me.IskMade9.Name = "IskMade9"
        Me.IskMade9.ReadOnly = True
        Me.IskMade9.Size = New System.Drawing.Size(137, 26)
        Me.IskMade9.TabIndex = 41
        Me.IskMade9.Text = "0"
        '
        'Units9
        '
        Me.Units9.Location = New System.Drawing.Point(542, 526)
        Me.Units9.Name = "Units9"
        Me.Units9.Size = New System.Drawing.Size(137, 26)
        Me.Units9.TabIndex = 40
        '
        'IPU9
        '
        Me.IPU9.BackColor = System.Drawing.SystemColors.Window
        Me.IPU9.Enabled = False
        Me.IPU9.Location = New System.Drawing.Point(350, 524)
        Me.IPU9.Name = "IPU9"
        Me.IPU9.ReadOnly = True
        Me.IPU9.Size = New System.Drawing.Size(137, 26)
        Me.IPU9.TabIndex = 39
        '
        'IskMade10
        '
        Me.IskMade10.BackColor = System.Drawing.SystemColors.Window
        Me.IskMade10.Enabled = False
        Me.IskMade10.Location = New System.Drawing.Point(725, 585)
        Me.IskMade10.Name = "IskMade10"
        Me.IskMade10.ReadOnly = True
        Me.IskMade10.Size = New System.Drawing.Size(137, 26)
        Me.IskMade10.TabIndex = 45
        Me.IskMade10.Text = "0"
        '
        'Units10
        '
        Me.Units10.Location = New System.Drawing.Point(542, 587)
        Me.Units10.Name = "Units10"
        Me.Units10.Size = New System.Drawing.Size(137, 26)
        Me.Units10.TabIndex = 44
        '
        'IPU10
        '
        Me.IPU10.BackColor = System.Drawing.SystemColors.Window
        Me.IPU10.Enabled = False
        Me.IPU10.Location = New System.Drawing.Point(350, 585)
        Me.IPU10.Name = "IPU10"
        Me.IPU10.ReadOnly = True
        Me.IPU10.Size = New System.Drawing.Size(137, 26)
        Me.IPU10.TabIndex = 43
        '
        'Clear_All_Button
        '
        Me.Clear_All_Button.Location = New System.Drawing.Point(412, 639)
        Me.Clear_All_Button.Name = "Clear_All_Button"
        Me.Clear_All_Button.Size = New System.Drawing.Size(115, 41)
        Me.Clear_All_Button.TabIndex = 46
        Me.Clear_All_Button.Text = "Clear All"
        Me.Clear_All_Button.UseVisualStyleBackColor = True
        '
        'Item2
        '
        Me.Item2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Item2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Item2.DataSource = Me.PIPricesBindingSource2
        Me.Item2.DisplayMember = "Item"
        Me.Item2.FormattingEnabled = True
        Me.Item2.Location = New System.Drawing.Point(68, 152)
        Me.Item2.Name = "Item2"
        Me.Item2.Size = New System.Drawing.Size(233, 28)
        Me.Item2.TabIndex = 10
        '
        'PIPricesBindingSource2
        '
        Me.PIPricesBindingSource2.DataMember = "PI_Prices"
        Me.PIPricesBindingSource2.DataSource = Me.YHIDataSet
        '
        'Item3
        '
        Me.Item3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Item3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Item3.DataSource = Me.PIPricesBindingSource3
        Me.Item3.DisplayMember = "Item"
        Me.Item3.FormattingEnabled = True
        Me.Item3.Location = New System.Drawing.Point(68, 202)
        Me.Item3.Name = "Item3"
        Me.Item3.Size = New System.Drawing.Size(233, 28)
        Me.Item3.TabIndex = 14
        '
        'PIPricesBindingSource3
        '
        Me.PIPricesBindingSource3.DataMember = "PI_Prices"
        Me.PIPricesBindingSource3.DataSource = Me.YHIDataSet1
        '
        'YHIDataSet1
        '
        Me.YHIDataSet1.DataSetName = "YHIDataSet"
        Me.YHIDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Item4
        '
        Me.Item4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Item4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Item4.DataSource = Me.PIPricesBindingSource4
        Me.Item4.DisplayMember = "Item"
        Me.Item4.FormattingEnabled = True
        Me.Item4.Location = New System.Drawing.Point(68, 255)
        Me.Item4.Name = "Item4"
        Me.Item4.Size = New System.Drawing.Size(233, 28)
        Me.Item4.TabIndex = 18
        '
        'PIPricesBindingSource4
        '
        Me.PIPricesBindingSource4.DataMember = "PI_Prices"
        Me.PIPricesBindingSource4.DataSource = Me.YHIDataSet1
        '
        'Item5
        '
        Me.Item5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Item5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Item5.DataSource = Me.PIPricesBindingSource5
        Me.Item5.DisplayMember = "Item"
        Me.Item5.FormattingEnabled = True
        Me.Item5.Location = New System.Drawing.Point(68, 309)
        Me.Item5.Name = "Item5"
        Me.Item5.Size = New System.Drawing.Size(233, 28)
        Me.Item5.TabIndex = 22
        '
        'PIPricesBindingSource5
        '
        Me.PIPricesBindingSource5.DataMember = "PI_Prices"
        Me.PIPricesBindingSource5.DataSource = Me.YHIDataSet1
        '
        'Item6
        '
        Me.Item6.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Item6.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Item6.DataSource = Me.PIPricesBindingSource6
        Me.Item6.DisplayMember = "Item"
        Me.Item6.FormattingEnabled = True
        Me.Item6.Location = New System.Drawing.Point(68, 363)
        Me.Item6.Name = "Item6"
        Me.Item6.Size = New System.Drawing.Size(233, 28)
        Me.Item6.TabIndex = 26
        '
        'PIPricesBindingSource6
        '
        Me.PIPricesBindingSource6.DataMember = "PI_Prices"
        Me.PIPricesBindingSource6.DataSource = Me.YHIDataSet1
        '
        'Item7
        '
        Me.Item7.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Item7.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Item7.DataSource = Me.PIPricesBindingSource7
        Me.Item7.DisplayMember = "Item"
        Me.Item7.FormattingEnabled = True
        Me.Item7.Location = New System.Drawing.Point(68, 414)
        Me.Item7.Name = "Item7"
        Me.Item7.Size = New System.Drawing.Size(233, 28)
        Me.Item7.TabIndex = 30
        '
        'PIPricesBindingSource7
        '
        Me.PIPricesBindingSource7.DataMember = "PI_Prices"
        Me.PIPricesBindingSource7.DataSource = Me.YHIDataSet1
        '
        'Item8
        '
        Me.Item8.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Item8.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Item8.DataSource = Me.PIPricesBindingSource8
        Me.Item8.DisplayMember = "Item"
        Me.Item8.FormattingEnabled = True
        Me.Item8.Location = New System.Drawing.Point(68, 466)
        Me.Item8.Name = "Item8"
        Me.Item8.Size = New System.Drawing.Size(233, 28)
        Me.Item8.TabIndex = 34
        '
        'PIPricesBindingSource8
        '
        Me.PIPricesBindingSource8.DataMember = "PI_Prices"
        Me.PIPricesBindingSource8.DataSource = Me.YHIDataSet1
        '
        'Item9
        '
        Me.Item9.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Item9.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Item9.DataSource = Me.PIPricesBindingSource9
        Me.Item9.DisplayMember = "Item"
        Me.Item9.FormattingEnabled = True
        Me.Item9.Location = New System.Drawing.Point(68, 522)
        Me.Item9.Name = "Item9"
        Me.Item9.Size = New System.Drawing.Size(233, 28)
        Me.Item9.TabIndex = 38
        '
        'PIPricesBindingSource9
        '
        Me.PIPricesBindingSource9.DataMember = "PI_Prices"
        Me.PIPricesBindingSource9.DataSource = Me.YHIDataSet1
        '
        'Item10
        '
        Me.Item10.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Item10.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Item10.DataSource = Me.PIPricesBindingSource10
        Me.Item10.DisplayMember = "Item"
        Me.Item10.FormattingEnabled = True
        Me.Item10.Location = New System.Drawing.Point(68, 583)
        Me.Item10.Name = "Item10"
        Me.Item10.Size = New System.Drawing.Size(233, 28)
        Me.Item10.TabIndex = 42
        '
        'PIPricesBindingSource10
        '
        Me.PIPricesBindingSource10.DataMember = "PI_Prices"
        Me.PIPricesBindingSource10.DataSource = Me.YHIDataSet1
        '
        'PI_PricesTableAdapter
        '
        Me.PI_PricesTableAdapter.ClearBeforeFill = True
        '
        'PI_Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(944, 692)
        Me.Controls.Add(Me.Item10)
        Me.Controls.Add(Me.Item9)
        Me.Controls.Add(Me.Item8)
        Me.Controls.Add(Me.Item7)
        Me.Controls.Add(Me.Item6)
        Me.Controls.Add(Me.Item5)
        Me.Controls.Add(Me.Item4)
        Me.Controls.Add(Me.Item3)
        Me.Controls.Add(Me.Item2)
        Me.Controls.Add(Me.Clear_All_Button)
        Me.Controls.Add(Me.IskMade10)
        Me.Controls.Add(Me.Units10)
        Me.Controls.Add(Me.IPU10)
        Me.Controls.Add(Me.IskMade9)
        Me.Controls.Add(Me.Units9)
        Me.Controls.Add(Me.IPU9)
        Me.Controls.Add(Me.IskMade8)
        Me.Controls.Add(Me.Units8)
        Me.Controls.Add(Me.IPU8)
        Me.Controls.Add(Me.IskMade7)
        Me.Controls.Add(Me.Units7)
        Me.Controls.Add(Me.IPU7)
        Me.Controls.Add(Me.IskMade6)
        Me.Controls.Add(Me.Units6)
        Me.Controls.Add(Me.IPU6)
        Me.Controls.Add(Me.IskMade5)
        Me.Controls.Add(Me.Units5)
        Me.Controls.Add(Me.IPU5)
        Me.Controls.Add(Me.IskMade4)
        Me.Controls.Add(Me.Units4)
        Me.Controls.Add(Me.IPU4)
        Me.Controls.Add(Me.IskMade3)
        Me.Controls.Add(Me.Units3)
        Me.Controls.Add(Me.IPU3)
        Me.Controls.Add(Me.IskMade2)
        Me.Controls.Add(Me.Units2)
        Me.Controls.Add(Me.IPU2)
        Me.Controls.Add(Me.Total_Isk_Made)
        Me.Controls.Add(Me.Total_Isk_Made_Label)
        Me.Controls.Add(Me.Isk_Made_Label)
        Me.Controls.Add(Me.Units_Label)
        Me.Controls.Add(Me.ISK_Per_Unit_Label)
        Me.Controls.Add(Me.Item_Label)
        Me.Controls.Add(Me.IskMade1)
        Me.Controls.Add(Me.Units1)
        Me.Controls.Add(Me.IPU1)
        Me.Controls.Add(Me.Item1)
        Me.Name = "PI_Calculator"
        Me.Text = "PI_Calculator"
        CType(Me.PIPricesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YHIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIPricesBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIPricesBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YHIDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIPricesBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIPricesBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIPricesBindingSource6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIPricesBindingSource7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIPricesBindingSource8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIPricesBindingSource9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIPricesBindingSource10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Item1 As System.Windows.Forms.ComboBox
    Friend WithEvents IPU1 As System.Windows.Forms.TextBox
    Friend WithEvents Units1 As System.Windows.Forms.TextBox
    Friend WithEvents IskMade1 As System.Windows.Forms.TextBox
    Friend WithEvents Item_Label As System.Windows.Forms.Label
    Friend WithEvents ISK_Per_Unit_Label As System.Windows.Forms.Label
    Friend WithEvents Units_Label As System.Windows.Forms.Label
    Friend WithEvents Isk_Made_Label As System.Windows.Forms.Label
    Friend WithEvents Total_Isk_Made_Label As System.Windows.Forms.Label
    Friend WithEvents Total_Isk_Made As System.Windows.Forms.TextBox
    Friend WithEvents IskMade2 As System.Windows.Forms.TextBox
    Friend WithEvents Units2 As System.Windows.Forms.TextBox
    Friend WithEvents IPU2 As System.Windows.Forms.TextBox
    Friend WithEvents IskMade3 As System.Windows.Forms.TextBox
    Friend WithEvents Units3 As System.Windows.Forms.TextBox
    Friend WithEvents IPU3 As System.Windows.Forms.TextBox
    Friend WithEvents IskMade4 As System.Windows.Forms.TextBox
    Friend WithEvents Units4 As System.Windows.Forms.TextBox
    Friend WithEvents IPU4 As System.Windows.Forms.TextBox
    Friend WithEvents IskMade5 As System.Windows.Forms.TextBox
    Friend WithEvents Units5 As System.Windows.Forms.TextBox
    Friend WithEvents IPU5 As System.Windows.Forms.TextBox
    Friend WithEvents IskMade6 As System.Windows.Forms.TextBox
    Friend WithEvents Units6 As System.Windows.Forms.TextBox
    Friend WithEvents IPU6 As System.Windows.Forms.TextBox
    Friend WithEvents IskMade7 As System.Windows.Forms.TextBox
    Friend WithEvents Units7 As System.Windows.Forms.TextBox
    Friend WithEvents IPU7 As System.Windows.Forms.TextBox
    Friend WithEvents IskMade8 As System.Windows.Forms.TextBox
    Friend WithEvents Units8 As System.Windows.Forms.TextBox
    Friend WithEvents IPU8 As System.Windows.Forms.TextBox
    Friend WithEvents IskMade9 As System.Windows.Forms.TextBox
    Friend WithEvents Units9 As System.Windows.Forms.TextBox
    Friend WithEvents IPU9 As System.Windows.Forms.TextBox
    Friend WithEvents IskMade10 As System.Windows.Forms.TextBox
    Friend WithEvents Units10 As System.Windows.Forms.TextBox
    Friend WithEvents IPU10 As System.Windows.Forms.TextBox
    Friend WithEvents Clear_All_Button As System.Windows.Forms.Button
    Friend WithEvents Item2 As System.Windows.Forms.ComboBox
    Friend WithEvents Item3 As System.Windows.Forms.ComboBox
    Friend WithEvents Item4 As System.Windows.Forms.ComboBox
    Friend WithEvents Item5 As System.Windows.Forms.ComboBox
    Friend WithEvents Item6 As System.Windows.Forms.ComboBox
    Friend WithEvents Item7 As System.Windows.Forms.ComboBox
    Friend WithEvents Item8 As System.Windows.Forms.ComboBox
    Friend WithEvents Item9 As System.Windows.Forms.ComboBox
    Friend WithEvents Item10 As System.Windows.Forms.ComboBox
    Friend WithEvents YHIDataSet As EVE_Ore_Calculator.YHIDataSet
    Friend WithEvents PI_PricesTableAdapter As EVE_Ore_Calculator.YHIDataSetTableAdapters.PI_PricesTableAdapter
    Friend WithEvents PIPricesBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PIPricesBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents YHIDataSet1 As EVE_Ore_Calculator.YHIDataSet
    Friend WithEvents PIPricesBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents PIPricesBindingSource4 As System.Windows.Forms.BindingSource
    Friend WithEvents PIPricesBindingSource5 As System.Windows.Forms.BindingSource
    Friend WithEvents PIPricesBindingSource6 As System.Windows.Forms.BindingSource
    Friend WithEvents PIPricesBindingSource7 As System.Windows.Forms.BindingSource
    Friend WithEvents PIPricesBindingSource8 As System.Windows.Forms.BindingSource
    Friend WithEvents PIPricesBindingSource9 As System.Windows.Forms.BindingSource
    Friend WithEvents PIPricesBindingSource10 As System.Windows.Forms.BindingSource
End Class
