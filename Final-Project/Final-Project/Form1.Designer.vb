<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lstDirectories = New System.Windows.Forms.ListBox()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PhoneDirectoryGroupings1DataSet = New Final_Project.PhoneDirectoryGroupings1DataSet()
        Me.PhoneDirectoryGroupsTableAdapter = New Final_Project.PhoneDirectoryGroupings1DataSetTableAdapters.PhoneDirectoryGroupsTableAdapter()
        Me.TelephoneListingsTableAdapter = New Final_Project.PhoneDirectoryGroupings1DataSetTableAdapters.TelephoneListingsTableAdapter()
        Me.btnMatainDir = New System.Windows.Forms.Button()
        Me.btnMatainPhone = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhoneDirectoryGroupings1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(48, 46)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(133, 29)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "Phone Directory"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(329, 46)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(194, 29)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = "Phone Directory Listings"
        '
        'lstDirectories
        '
        Me.lstDirectories.FormattingEnabled = True
        Me.lstDirectories.ItemHeight = 21
        Me.lstDirectories.Location = New System.Drawing.Point(48, 99)
        Me.lstDirectories.Name = "lstDirectories"
        Me.lstDirectories.Size = New System.Drawing.Size(201, 277)
        Me.lstDirectories.TabIndex = 2
        '
        'dgvData
        '
        Me.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(329, 99)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.RowTemplate.Height = 23
        Me.dgvData.Size = New System.Drawing.Size(485, 277)
        Me.dgvData.TabIndex = 4
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "TelephoneListings"
        Me.BindingSource1.DataSource = Me.PhoneDirectoryGroupings1DataSet
        '
        'PhoneDirectoryGroupings1DataSet
        '
        Me.PhoneDirectoryGroupings1DataSet.DataSetName = "PhoneDirectoryGroupings1DataSet"
        Me.PhoneDirectoryGroupings1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PhoneDirectoryGroupsTableAdapter
        '
        Me.PhoneDirectoryGroupsTableAdapter.ClearBeforeFill = True
        '
        'TelephoneListingsTableAdapter
        '
        Me.TelephoneListingsTableAdapter.ClearBeforeFill = True
        '
        'btnMatainDir
        '
        Me.btnMatainDir.Location = New System.Drawing.Point(48, 404)
        Me.btnMatainDir.Name = "btnMatainDir"
        Me.btnMatainDir.Size = New System.Drawing.Size(164, 50)
        Me.btnMatainDir.TabIndex = 5
        Me.btnMatainDir.Text = "Matain Directory"
        Me.btnMatainDir.UseVisualStyleBackColor = True
        '
        'btnMatainPhone
        '
        Me.btnMatainPhone.Location = New System.Drawing.Point(329, 404)
        Me.btnMatainPhone.Name = "btnMatainPhone"
        Me.btnMatainPhone.Size = New System.Drawing.Size(203, 50)
        Me.btnMatainPhone.TabIndex = 6
        Me.btnMatainPhone.Text = "Matain Phone Listings"
        Me.btnMatainPhone.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(614, 404)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(88, 50)
        Me.btnRefresh.TabIndex = 7
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(726, 404)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(88, 50)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 496)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnMatainPhone)
        Me.Controls.Add(Me.btnMatainDir)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.lstDirectories)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhoneDirectoryGroupings1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lstDirectories As ListBox
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents PhoneDirectoryGroupings1DataSet As PhoneDirectoryGroupings1DataSet
    Friend WithEvents PhoneDirectoryGroupsTableAdapter As PhoneDirectoryGroupings1DataSetTableAdapters.PhoneDirectoryGroupsTableAdapter
    Friend WithEvents TelephoneListingsTableAdapter As PhoneDirectoryGroupings1DataSetTableAdapters.TelephoneListingsTableAdapter
    Friend WithEvents btnMatainDir As Button
    Friend WithEvents btnMatainPhone As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnExit As Button
End Class
