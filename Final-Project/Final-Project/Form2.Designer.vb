<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDir))
        Dim DirectoryGroupLabel As System.Windows.Forms.Label
        Dim DescriptonLabel As System.Windows.Forms.Label
        Me.lblDirName = New System.Windows.Forms.Label()
        Me.txtDirName = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btExit = New System.Windows.Forms.Button()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnUpdate = New System.Windows.Forms.ToolStripButton()
        Me.PhoneDirectoryGroupings1DataSet = New Final_Project.PhoneDirectoryGroupings1DataSet()
        Me.PhoneDirectoryGroupsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PhoneDirectoryGroupsTableAdapter = New Final_Project.PhoneDirectoryGroupings1DataSetTableAdapters.PhoneDirectoryGroupsTableAdapter()
        Me.TableAdapterManager = New Final_Project.PhoneDirectoryGroupings1DataSetTableAdapters.TableAdapterManager()
        Me.DirectoryGroupTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptonTextBox = New System.Windows.Forms.TextBox()
        DirectoryGroupLabel = New System.Windows.Forms.Label()
        DescriptonLabel = New System.Windows.Forms.Label()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.PhoneDirectoryGroupings1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhoneDirectoryGroupsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDirName
        '
        Me.lblDirName.AutoSize = True
        Me.lblDirName.Location = New System.Drawing.Point(219, 215)
        Me.lblDirName.Name = "lblDirName"
        Me.lblDirName.Size = New System.Drawing.Size(130, 21)
        Me.lblDirName.TabIndex = 2
        Me.lblDirName.Text = "Directory Name"
        '
        'txtDirName
        '
        Me.txtDirName.Location = New System.Drawing.Point(387, 215)
        Me.txtDirName.Name = "txtDirName"
        Me.txtDirName.Size = New System.Drawing.Size(309, 29)
        Me.txtDirName.TabIndex = 5
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(223, 327)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(166, 56)
        Me.btnSearch.TabIndex = 7
        Me.btnSearch.Text = "Search for Item"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btExit
        '
        Me.btExit.Location = New System.Drawing.Point(556, 327)
        Me.btExit.Name = "btExit"
        Me.btExit.Size = New System.Drawing.Size(140, 56)
        Me.btExit.TabIndex = 8
        Me.btExit.Text = "Exit"
        Me.btExit.UseVisualStyleBackColor = True
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.PhoneDirectoryGroupsBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.btnUpdate})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(869, 25)
        Me.BindingNavigator1.TabIndex = 9
        Me.BindingNavigator1.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(32, 22)
        Me.BindingNavigatorCountItem.Text = "/ {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "总项数"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnUpdate
        '
        Me.btnUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Image)
        Me.btnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(23, 22)
        Me.btnUpdate.Text = "Update"
        '
        'PhoneDirectoryGroupings1DataSet
        '
        Me.PhoneDirectoryGroupings1DataSet.DataSetName = "PhoneDirectoryGroupings1DataSet"
        Me.PhoneDirectoryGroupings1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PhoneDirectoryGroupsBindingSource
        '
        Me.PhoneDirectoryGroupsBindingSource.DataMember = "PhoneDirectoryGroups"
        Me.PhoneDirectoryGroupsBindingSource.DataSource = Me.PhoneDirectoryGroupings1DataSet
        '
        'PhoneDirectoryGroupsTableAdapter
        '
        Me.PhoneDirectoryGroupsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PhoneDirectoryGroupsTableAdapter = Me.PhoneDirectoryGroupsTableAdapter
        Me.TableAdapterManager.TelephoneListingsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Final_Project.PhoneDirectoryGroupings1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DirectoryGroupLabel
        '
        DirectoryGroupLabel.AutoSize = True
        DirectoryGroupLabel.Location = New System.Drawing.Point(213, 80)
        DirectoryGroupLabel.Name = "DirectoryGroupLabel"
        DirectoryGroupLabel.Size = New System.Drawing.Size(136, 21)
        DirectoryGroupLabel.TabIndex = 9
        DirectoryGroupLabel.Text = "Directory Group:"
        '
        'DirectoryGroupTextBox
        '
        Me.DirectoryGroupTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PhoneDirectoryGroupsBindingSource, "DirectoryGroup", True))
        Me.DirectoryGroupTextBox.Location = New System.Drawing.Point(387, 80)
        Me.DirectoryGroupTextBox.Name = "DirectoryGroupTextBox"
        Me.DirectoryGroupTextBox.Size = New System.Drawing.Size(309, 29)
        Me.DirectoryGroupTextBox.TabIndex = 10
        '
        'DescriptonLabel
        '
        DescriptonLabel.AutoSize = True
        DescriptonLabel.Location = New System.Drawing.Point(253, 148)
        DescriptonLabel.Name = "DescriptonLabel"
        DescriptonLabel.Size = New System.Drawing.Size(96, 21)
        DescriptonLabel.TabIndex = 10
        DescriptonLabel.Text = "Descripton:"
        '
        'DescriptonTextBox
        '
        Me.DescriptonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PhoneDirectoryGroupsBindingSource, "Descripton", True))
        Me.DescriptonTextBox.Location = New System.Drawing.Point(387, 148)
        Me.DescriptonTextBox.Name = "DescriptonTextBox"
        Me.DescriptonTextBox.Size = New System.Drawing.Size(309, 29)
        Me.DescriptonTextBox.TabIndex = 11
        '
        'frmDir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 496)
        Me.Controls.Add(DescriptonLabel)
        Me.Controls.Add(Me.DescriptonTextBox)
        Me.Controls.Add(DirectoryGroupLabel)
        Me.Controls.Add(Me.DirectoryGroupTextBox)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.btExit)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtDirName)
        Me.Controls.Add(Me.lblDirName)
        Me.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frmDir"
        Me.Text = "Maintain Directories"
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.PhoneDirectoryGroupings1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhoneDirectoryGroupsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDirName As Label
    Friend WithEvents txtDirName As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btExit As Button
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
    Friend WithEvents btnUpdate As ToolStripButton
    Friend WithEvents PhoneDirectoryGroupings1DataSet As PhoneDirectoryGroupings1DataSet
    Friend WithEvents PhoneDirectoryGroupsBindingSource As BindingSource
    Friend WithEvents PhoneDirectoryGroupsTableAdapter As PhoneDirectoryGroupings1DataSetTableAdapters.PhoneDirectoryGroupsTableAdapter
    Friend WithEvents TableAdapterManager As PhoneDirectoryGroupings1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents DirectoryGroupTextBox As TextBox
    Friend WithEvents DescriptonTextBox As TextBox
End Class
