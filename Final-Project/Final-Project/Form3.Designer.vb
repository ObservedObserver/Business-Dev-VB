<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmList
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmList))
        Dim GROUPNAMELabel As System.Windows.Forms.Label
        Dim FullNameLabel As System.Windows.Forms.Label
        Dim PhoneNumbe_1Label As System.Windows.Forms.Label
        Dim PhoneType1Label As System.Windows.Forms.Label
        Dim PhoneNumber2Label As System.Windows.Forms.Label
        Dim PhoneType2Label As System.Windows.Forms.Label
        Dim PhoneNumber3Label As System.Windows.Forms.Label
        Dim PhoneType3Label As System.Windows.Forms.Label
        Dim StreetAddress1Label As System.Windows.Forms.Label
        Dim StreetAddress2Label As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim ProvinceStateLabel As System.Windows.Forms.Label
        Dim ZipCodeLabel As System.Windows.Forms.Label
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PhoneDirectoryGroupings1DataSet2 = New Final_Project.PhoneDirectoryGroupings1DataSet2()
        Me.TelephoneListingsTableAdapter = New Final_Project.PhoneDirectoryGroupings1DataSet2TableAdapters.TelephoneListingsTableAdapter()
        Me.PhoneDirectoryGroupings1DataSet = New Final_Project.PhoneDirectoryGroupings1DataSet()
        Me.TelephoneListingsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TelephoneListingsTableAdapter1 = New Final_Project.PhoneDirectoryGroupings1DataSetTableAdapters.TelephoneListingsTableAdapter()
        Me.TableAdapterManager = New Final_Project.PhoneDirectoryGroupings1DataSetTableAdapters.TableAdapterManager()
        Me.GROUPNAMETextBox = New System.Windows.Forms.TextBox()
        Me.FullNameTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumbe_1TextBox = New System.Windows.Forms.TextBox()
        Me.PhoneType1TextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumber2TextBox = New System.Windows.Forms.TextBox()
        Me.PhoneType2TextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumber3TextBox = New System.Windows.Forms.TextBox()
        Me.PhoneType3TextBox = New System.Windows.Forms.TextBox()
        Me.StreetAddress1TextBox = New System.Windows.Forms.TextBox()
        Me.StreetAddress2TextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.ProvinceStateTextBox = New System.Windows.Forms.TextBox()
        Me.ZipCodeTextBox = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        GROUPNAMELabel = New System.Windows.Forms.Label()
        FullNameLabel = New System.Windows.Forms.Label()
        PhoneNumbe_1Label = New System.Windows.Forms.Label()
        PhoneType1Label = New System.Windows.Forms.Label()
        PhoneNumber2Label = New System.Windows.Forms.Label()
        PhoneType2Label = New System.Windows.Forms.Label()
        PhoneNumber3Label = New System.Windows.Forms.Label()
        PhoneType3Label = New System.Windows.Forms.Label()
        StreetAddress1Label = New System.Windows.Forms.Label()
        StreetAddress2Label = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        ProvinceStateLabel = New System.Windows.Forms.Label()
        ZipCodeLabel = New System.Windows.Forms.Label()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhoneDirectoryGroupings1DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhoneDirectoryGroupings1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TelephoneListingsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.TelephoneListingsBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(869, 25)
        Me.BindingNavigator1.TabIndex = 0
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "移到第一条记录"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "移到上一条记录"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "位置"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "当前位置"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(32, 22)
        Me.BindingNavigatorCountItem.Text = "/ {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "总项数"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "移到下一条记录"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "移到最后一条记录"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "新添"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "删除"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "TelephoneListings"
        Me.BindingSource1.DataSource = Me.PhoneDirectoryGroupings1DataSet2
        '
        'PhoneDirectoryGroupings1DataSet2
        '
        Me.PhoneDirectoryGroupings1DataSet2.DataSetName = "PhoneDirectoryGroupings1DataSet2"
        Me.PhoneDirectoryGroupings1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TelephoneListingsTableAdapter
        '
        Me.TelephoneListingsTableAdapter.ClearBeforeFill = True
        '
        'PhoneDirectoryGroupings1DataSet
        '
        Me.PhoneDirectoryGroupings1DataSet.DataSetName = "PhoneDirectoryGroupings1DataSet"
        Me.PhoneDirectoryGroupings1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TelephoneListingsBindingSource
        '
        Me.TelephoneListingsBindingSource.DataMember = "TelephoneListings"
        Me.TelephoneListingsBindingSource.DataSource = Me.PhoneDirectoryGroupings1DataSet
        '
        'TelephoneListingsTableAdapter1
        '
        Me.TelephoneListingsTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PhoneDirectoryGroupsTableAdapter = Nothing
        Me.TableAdapterManager.TelephoneListingsTableAdapter = Me.TelephoneListingsTableAdapter1
        Me.TableAdapterManager.UpdateOrder = Final_Project.PhoneDirectoryGroupings1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GROUPNAMELabel
        '
        GROUPNAMELabel.AutoSize = True
        GROUPNAMELabel.Location = New System.Drawing.Point(42, 51)
        GROUPNAMELabel.Name = "GROUPNAMELabel"
        GROUPNAMELabel.Size = New System.Drawing.Size(120, 21)
        GROUPNAMELabel.TabIndex = 1
        GROUPNAMELabel.Text = "GROUPNAME:"
        '
        'GROUPNAMETextBox
        '
        Me.GROUPNAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TelephoneListingsBindingSource, "GROUPNAME", True))
        Me.GROUPNAMETextBox.Location = New System.Drawing.Point(168, 48)
        Me.GROUPNAMETextBox.Name = "GROUPNAMETextBox"
        Me.GROUPNAMETextBox.Size = New System.Drawing.Size(233, 29)
        Me.GROUPNAMETextBox.TabIndex = 2
        '
        'FullNameLabel
        '
        FullNameLabel.AutoSize = True
        FullNameLabel.Location = New System.Drawing.Point(70, 91)
        FullNameLabel.Name = "FullNameLabel"
        FullNameLabel.Size = New System.Drawing.Size(92, 21)
        FullNameLabel.TabIndex = 3
        FullNameLabel.Text = "Full Name:"
        '
        'FullNameTextBox
        '
        Me.FullNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TelephoneListingsBindingSource, "FullName", True))
        Me.FullNameTextBox.Location = New System.Drawing.Point(168, 83)
        Me.FullNameTextBox.Name = "FullNameTextBox"
        Me.FullNameTextBox.Size = New System.Drawing.Size(233, 29)
        Me.FullNameTextBox.TabIndex = 4
        '
        'PhoneNumbe_1Label
        '
        PhoneNumbe_1Label.AutoSize = True
        PhoneNumbe_1Label.Location = New System.Drawing.Point(23, 130)
        PhoneNumbe_1Label.Name = "PhoneNumbe_1Label"
        PhoneNumbe_1Label.Size = New System.Drawing.Size(139, 21)
        PhoneNumbe_1Label.TabIndex = 5
        PhoneNumbe_1Label.Text = "Phone Numbe 1:"
        '
        'PhoneNumbe_1TextBox
        '
        Me.PhoneNumbe_1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TelephoneListingsBindingSource, "PhoneNumbe 1", True))
        Me.PhoneNumbe_1TextBox.Location = New System.Drawing.Point(168, 122)
        Me.PhoneNumbe_1TextBox.Name = "PhoneNumbe_1TextBox"
        Me.PhoneNumbe_1TextBox.Size = New System.Drawing.Size(233, 29)
        Me.PhoneNumbe_1TextBox.TabIndex = 6
        '
        'PhoneType1Label
        '
        PhoneType1Label.AutoSize = True
        PhoneType1Label.Location = New System.Drawing.Point(49, 161)
        PhoneType1Label.Name = "PhoneType1Label"
        PhoneType1Label.Size = New System.Drawing.Size(113, 21)
        PhoneType1Label.TabIndex = 7
        PhoneType1Label.Text = "Phone Type1:"
        '
        'PhoneType1TextBox
        '
        Me.PhoneType1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TelephoneListingsBindingSource, "PhoneType1", True))
        Me.PhoneType1TextBox.Location = New System.Drawing.Point(168, 161)
        Me.PhoneType1TextBox.Name = "PhoneType1TextBox"
        Me.PhoneType1TextBox.Size = New System.Drawing.Size(233, 29)
        Me.PhoneType1TextBox.TabIndex = 8
        '
        'PhoneNumber2Label
        '
        PhoneNumber2Label.AutoSize = True
        PhoneNumber2Label.Location = New System.Drawing.Point(22, 203)
        PhoneNumber2Label.Name = "PhoneNumber2Label"
        PhoneNumber2Label.Size = New System.Drawing.Size(140, 21)
        PhoneNumber2Label.TabIndex = 9
        PhoneNumber2Label.Text = "Phone Number2:"
        '
        'PhoneNumber2TextBox
        '
        Me.PhoneNumber2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TelephoneListingsBindingSource, "PhoneNumber2", True))
        Me.PhoneNumber2TextBox.Location = New System.Drawing.Point(168, 200)
        Me.PhoneNumber2TextBox.Name = "PhoneNumber2TextBox"
        Me.PhoneNumber2TextBox.Size = New System.Drawing.Size(233, 29)
        Me.PhoneNumber2TextBox.TabIndex = 10
        '
        'PhoneType2Label
        '
        PhoneType2Label.AutoSize = True
        PhoneType2Label.Location = New System.Drawing.Point(49, 240)
        PhoneType2Label.Name = "PhoneType2Label"
        PhoneType2Label.Size = New System.Drawing.Size(113, 21)
        PhoneType2Label.TabIndex = 11
        PhoneType2Label.Text = "Phone Type2:"
        '
        'PhoneType2TextBox
        '
        Me.PhoneType2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TelephoneListingsBindingSource, "PhoneType2", True))
        Me.PhoneType2TextBox.Location = New System.Drawing.Point(168, 237)
        Me.PhoneType2TextBox.Name = "PhoneType2TextBox"
        Me.PhoneType2TextBox.Size = New System.Drawing.Size(233, 29)
        Me.PhoneType2TextBox.TabIndex = 12
        '
        'PhoneNumber3Label
        '
        PhoneNumber3Label.AutoSize = True
        PhoneNumber3Label.Location = New System.Drawing.Point(23, 277)
        PhoneNumber3Label.Name = "PhoneNumber3Label"
        PhoneNumber3Label.Size = New System.Drawing.Size(140, 21)
        PhoneNumber3Label.TabIndex = 13
        PhoneNumber3Label.Text = "Phone Number3:"
        '
        'PhoneNumber3TextBox
        '
        Me.PhoneNumber3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TelephoneListingsBindingSource, "PhoneNumber3", True))
        Me.PhoneNumber3TextBox.Location = New System.Drawing.Point(169, 274)
        Me.PhoneNumber3TextBox.Name = "PhoneNumber3TextBox"
        Me.PhoneNumber3TextBox.Size = New System.Drawing.Size(232, 29)
        Me.PhoneNumber3TextBox.TabIndex = 14
        '
        'PhoneType3Label
        '
        PhoneType3Label.AutoSize = True
        PhoneType3Label.Location = New System.Drawing.Point(50, 314)
        PhoneType3Label.Name = "PhoneType3Label"
        PhoneType3Label.Size = New System.Drawing.Size(113, 21)
        PhoneType3Label.TabIndex = 15
        PhoneType3Label.Text = "Phone Type3:"
        '
        'PhoneType3TextBox
        '
        Me.PhoneType3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TelephoneListingsBindingSource, "PhoneType3", True))
        Me.PhoneType3TextBox.Location = New System.Drawing.Point(169, 311)
        Me.PhoneType3TextBox.Name = "PhoneType3TextBox"
        Me.PhoneType3TextBox.Size = New System.Drawing.Size(232, 29)
        Me.PhoneType3TextBox.TabIndex = 16
        '
        'StreetAddress1Label
        '
        StreetAddress1Label.AutoSize = True
        StreetAddress1Label.Location = New System.Drawing.Point(30, 352)
        StreetAddress1Label.Name = "StreetAddress1Label"
        StreetAddress1Label.Size = New System.Drawing.Size(133, 21)
        StreetAddress1Label.TabIndex = 17
        StreetAddress1Label.Text = "Street Address1:"
        '
        'StreetAddress1TextBox
        '
        Me.StreetAddress1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TelephoneListingsBindingSource, "StreetAddress1", True))
        Me.StreetAddress1TextBox.Location = New System.Drawing.Point(169, 349)
        Me.StreetAddress1TextBox.Name = "StreetAddress1TextBox"
        Me.StreetAddress1TextBox.Size = New System.Drawing.Size(232, 29)
        Me.StreetAddress1TextBox.TabIndex = 18
        '
        'StreetAddress2Label
        '
        StreetAddress2Label.AutoSize = True
        StreetAddress2Label.Location = New System.Drawing.Point(30, 391)
        StreetAddress2Label.Name = "StreetAddress2Label"
        StreetAddress2Label.Size = New System.Drawing.Size(133, 21)
        StreetAddress2Label.TabIndex = 19
        StreetAddress2Label.Text = "Street Address2:"
        '
        'StreetAddress2TextBox
        '
        Me.StreetAddress2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TelephoneListingsBindingSource, "StreetAddress2", True))
        Me.StreetAddress2TextBox.Location = New System.Drawing.Point(169, 388)
        Me.StreetAddress2TextBox.Name = "StreetAddress2TextBox"
        Me.StreetAddress2TextBox.Size = New System.Drawing.Size(232, 29)
        Me.StreetAddress2TextBox.TabIndex = 20
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(120, 426)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(43, 21)
        CityLabel.TabIndex = 21
        CityLabel.Text = "City:"
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TelephoneListingsBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(169, 423)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(232, 29)
        Me.CityTextBox.TabIndex = 22
        '
        'ProvinceStateLabel
        '
        ProvinceStateLabel.AutoSize = True
        ProvinceStateLabel.Location = New System.Drawing.Point(445, 48)
        ProvinceStateLabel.Name = "ProvinceStateLabel"
        ProvinceStateLabel.Size = New System.Drawing.Size(123, 21)
        ProvinceStateLabel.TabIndex = 23
        ProvinceStateLabel.Text = "Province State:"
        '
        'ProvinceStateTextBox
        '
        Me.ProvinceStateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TelephoneListingsBindingSource, "ProvinceState", True))
        Me.ProvinceStateTextBox.Location = New System.Drawing.Point(574, 45)
        Me.ProvinceStateTextBox.Name = "ProvinceStateTextBox"
        Me.ProvinceStateTextBox.Size = New System.Drawing.Size(243, 29)
        Me.ProvinceStateTextBox.TabIndex = 24
        '
        'ZipCodeLabel
        '
        ZipCodeLabel.AutoSize = True
        ZipCodeLabel.Location = New System.Drawing.Point(485, 86)
        ZipCodeLabel.Name = "ZipCodeLabel"
        ZipCodeLabel.Size = New System.Drawing.Size(83, 21)
        ZipCodeLabel.TabIndex = 25
        ZipCodeLabel.Text = "Zip Code:"
        '
        'ZipCodeTextBox
        '
        Me.ZipCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TelephoneListingsBindingSource, "ZipCode", True))
        Me.ZipCodeTextBox.Location = New System.Drawing.Point(574, 83)
        Me.ZipCodeTextBox.Name = "ZipCodeTextBox"
        Me.ZipCodeTextBox.Size = New System.Drawing.Size(243, 29)
        Me.ZipCodeTextBox.TabIndex = 26
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(728, 405)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(89, 47)
        Me.btnExit.TabIndex = 27
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 496)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(ZipCodeLabel)
        Me.Controls.Add(Me.ZipCodeTextBox)
        Me.Controls.Add(ProvinceStateLabel)
        Me.Controls.Add(Me.ProvinceStateTextBox)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(StreetAddress2Label)
        Me.Controls.Add(Me.StreetAddress2TextBox)
        Me.Controls.Add(StreetAddress1Label)
        Me.Controls.Add(Me.StreetAddress1TextBox)
        Me.Controls.Add(PhoneType3Label)
        Me.Controls.Add(Me.PhoneType3TextBox)
        Me.Controls.Add(PhoneNumber3Label)
        Me.Controls.Add(Me.PhoneNumber3TextBox)
        Me.Controls.Add(PhoneType2Label)
        Me.Controls.Add(Me.PhoneType2TextBox)
        Me.Controls.Add(PhoneNumber2Label)
        Me.Controls.Add(Me.PhoneNumber2TextBox)
        Me.Controls.Add(PhoneType1Label)
        Me.Controls.Add(Me.PhoneType1TextBox)
        Me.Controls.Add(PhoneNumbe_1Label)
        Me.Controls.Add(Me.PhoneNumbe_1TextBox)
        Me.Controls.Add(FullNameLabel)
        Me.Controls.Add(Me.FullNameTextBox)
        Me.Controls.Add(GROUPNAMELabel)
        Me.Controls.Add(Me.GROUPNAMETextBox)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "frmList"
        Me.Text = "Listings"
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhoneDirectoryGroupings1DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhoneDirectoryGroupings1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TelephoneListingsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents PhoneDirectoryGroupings1DataSet2 As PhoneDirectoryGroupings1DataSet2
    Friend WithEvents TelephoneListingsTableAdapter As PhoneDirectoryGroupings1DataSet2TableAdapters.TelephoneListingsTableAdapter
    Friend WithEvents PhoneDirectoryGroupings1DataSet As PhoneDirectoryGroupings1DataSet
    Friend WithEvents TelephoneListingsBindingSource As BindingSource
    Friend WithEvents TelephoneListingsTableAdapter1 As PhoneDirectoryGroupings1DataSetTableAdapters.TelephoneListingsTableAdapter
    Friend WithEvents TableAdapterManager As PhoneDirectoryGroupings1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents GROUPNAMETextBox As TextBox
    Friend WithEvents FullNameTextBox As TextBox
    Friend WithEvents PhoneNumbe_1TextBox As TextBox
    Friend WithEvents PhoneType1TextBox As TextBox
    Friend WithEvents PhoneNumber2TextBox As TextBox
    Friend WithEvents PhoneType2TextBox As TextBox
    Friend WithEvents PhoneNumber3TextBox As TextBox
    Friend WithEvents PhoneType3TextBox As TextBox
    Friend WithEvents StreetAddress1TextBox As TextBox
    Friend WithEvents StreetAddress2TextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents ProvinceStateTextBox As TextBox
    Friend WithEvents ZipCodeTextBox As TextBox
    Friend WithEvents btnExit As Button
End Class
