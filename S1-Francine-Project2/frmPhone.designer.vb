<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmPhone
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
    If disposing AndAlso components IsNot Nothing Then
      components.Dispose()
    End If
    MyBase.Dispose(disposing)
  End Sub

  Friend WithEvents lblName As System.Windows.Forms.Label
  Friend WithEvents txtName As System.Windows.Forms.TextBox
  Friend WithEvents lblPhoneNumber As System.Windows.Forms.Label
  Friend WithEvents btnAdd As System.Windows.Forms.Button
  Friend WithEvents btnRemove As System.Windows.Forms.Button
  Friend WithEvents btnDisplay As System.Windows.Forms.Button
  Friend WithEvents txtPhoneNumber As System.Windows.Forms.TextBox

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  Friend WithEvents lblCurrent As System.Windows.Forms.Label
  Friend WithEvents txtCurrent As System.Windows.Forms.TextBox
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.lblCurrent = New System.Windows.Forms.Label()
        Me.txtCurrent = New System.Windows.Forms.TextBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.lblDirectories = New System.Windows.Forms.Label()
        Me.lstDirs = New System.Windows.Forms.ListBox()
        Me.dgvOutput = New System.Windows.Forms.DataGridView()
        Me.lblHint = New System.Windows.Forms.Label()
        Me.tabOperation = New System.Windows.Forms.TabControl()
        Me.tabPageAdd = New System.Windows.Forms.TabPage()
        Me.tabPageDelete = New System.Windows.Forms.TabPage()
        Me.lblDelName = New System.Windows.Forms.Label()
        Me.cboName = New System.Windows.Forms.ComboBox()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.dgvOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabOperation.SuspendLayout()
        Me.tabPageAdd.SuspendLayout()
        Me.tabPageDelete.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(66, 15)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 12)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name:"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(109, 12)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(113, 21)
        Me.txtName.TabIndex = 2
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(109, 51)
        Me.txtPhoneNumber.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(113, 21)
        Me.txtPhoneNumber.TabIndex = 4
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Location = New System.Drawing.Point(18, 54)
        Me.lblPhoneNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(83, 12)
        Me.lblPhoneNumber.TabIndex = 3
        Me.lblPhoneNumber.Text = "Phone number:"
        Me.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(44, 86)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(157, 37)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add a Listing to the Current Directory"
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(31, 83)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(157, 37)
        Me.btnRemove.TabIndex = 6
        Me.btnRemove.Text = "Remove a Listing from the Current Directory"
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(18, 221)
        Me.btnDisplay.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(151, 41)
        Me.btnDisplay.TabIndex = 8
        Me.btnDisplay.Text = "Display the Listings in the Current Directory"
        '
        'lblCurrent
        '
        Me.lblCurrent.AutoSize = True
        Me.lblCurrent.Location = New System.Drawing.Point(16, 25)
        Me.lblCurrent.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCurrent.Name = "lblCurrent"
        Me.lblCurrent.Size = New System.Drawing.Size(149, 12)
        Me.lblCurrent.TabIndex = 11
        Me.lblCurrent.Text = "Current phone directory:"
        '
        'txtCurrent
        '
        Me.txtCurrent.Location = New System.Drawing.Point(18, 40)
        Me.txtCurrent.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtCurrent.Name = "txtCurrent"
        Me.txtCurrent.ReadOnly = True
        Me.txtCurrent.Size = New System.Drawing.Size(151, 21)
        Me.txtCurrent.TabIndex = 12
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(18, 311)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(77, 41)
        Me.btnCreate.TabIndex = 13
        Me.btnCreate.Text = "Create New Directory"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'lblDirectories
        '
        Me.lblDirectories.AutoSize = True
        Me.lblDirectories.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDirectories.Location = New System.Drawing.Point(15, 8)
        Me.lblDirectories.Name = "lblDirectories"
        Me.lblDirectories.Size = New System.Drawing.Size(108, 13)
        Me.lblDirectories.TabIndex = 14
        Me.lblDirectories.Text = "Phone Directories"
        Me.lblDirectories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstDirs
        '
        Me.lstDirs.FormattingEnabled = True
        Me.lstDirs.ItemHeight = 12
        Me.lstDirs.Location = New System.Drawing.Point(18, 67)
        Me.lstDirs.Name = "lstDirs"
        Me.lstDirs.Size = New System.Drawing.Size(151, 148)
        Me.lstDirs.TabIndex = 15
        '
        'dgvOutput
        '
        Me.dgvOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOutput.Location = New System.Drawing.Point(188, 221)
        Me.dgvOutput.Name = "dgvOutput"
        Me.dgvOutput.RowHeadersVisible = False
        Me.dgvOutput.Size = New System.Drawing.Size(262, 132)
        Me.dgvOutput.TabIndex = 16
        '
        'lblHint
        '
        Me.lblHint.Location = New System.Drawing.Point(186, 9)
        Me.lblHint.Name = "lblHint"
        Me.lblHint.Size = New System.Drawing.Size(283, 28)
        Me.lblHint.TabIndex = 17
        Me.lblHint.Text = "Click on one of the existing phone directories below to make it the current phone" &
    " directory."
        '
        'tabOperation
        '
        Me.tabOperation.Controls.Add(Me.tabPageAdd)
        Me.tabOperation.Controls.Add(Me.tabPageDelete)
        Me.tabOperation.Location = New System.Drawing.Point(189, 55)
        Me.tabOperation.Name = "tabOperation"
        Me.tabOperation.SelectedIndex = 0
        Me.tabOperation.Size = New System.Drawing.Size(266, 160)
        Me.tabOperation.TabIndex = 18
        '
        'tabPageAdd
        '
        Me.tabPageAdd.Controls.Add(Me.lblName)
        Me.tabPageAdd.Controls.Add(Me.txtName)
        Me.tabPageAdd.Controls.Add(Me.lblPhoneNumber)
        Me.tabPageAdd.Controls.Add(Me.txtPhoneNumber)
        Me.tabPageAdd.Controls.Add(Me.btnAdd)
        Me.tabPageAdd.Location = New System.Drawing.Point(4, 22)
        Me.tabPageAdd.Name = "tabPageAdd"
        Me.tabPageAdd.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageAdd.Size = New System.Drawing.Size(258, 134)
        Me.tabPageAdd.TabIndex = 0
        Me.tabPageAdd.Text = "Add"
        Me.tabPageAdd.UseVisualStyleBackColor = True
        '
        'tabPageDelete
        '
        Me.tabPageDelete.Controls.Add(Me.lblDelName)
        Me.tabPageDelete.Controls.Add(Me.cboName)
        Me.tabPageDelete.Controls.Add(Me.btnRemove)
        Me.tabPageDelete.Location = New System.Drawing.Point(4, 22)
        Me.tabPageDelete.Name = "tabPageDelete"
        Me.tabPageDelete.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageDelete.Size = New System.Drawing.Size(258, 134)
        Me.tabPageDelete.TabIndex = 1
        Me.tabPageDelete.Text = "Delete"
        Me.tabPageDelete.UseVisualStyleBackColor = True
        '
        'lblDelName
        '
        Me.lblDelName.AutoSize = True
        Me.lblDelName.Location = New System.Drawing.Point(29, 16)
        Me.lblDelName.Name = "lblDelName"
        Me.lblDelName.Size = New System.Drawing.Size(89, 12)
        Me.lblDelName.TabIndex = 1
        Me.lblDelName.Text = "Delete by name"
        '
        'cboName
        '
        Me.cboName.FormattingEnabled = True
        Me.cboName.Location = New System.Drawing.Point(31, 46)
        Me.cboName.Name = "cboName"
        Me.cboName.Size = New System.Drawing.Size(126, 20)
        Me.cboName.TabIndex = 0
        '
        'btnAdmin
        '
        Me.btnAdmin.Location = New System.Drawing.Point(18, 266)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(151, 41)
        Me.btnAdmin.TabIndex = 19
        Me.btnAdmin.Text = "Check full infomation as administrator"
        Me.btnAdmin.UseVisualStyleBackColor = True
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(101, 311)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(68, 41)
        Me.btnImport.TabIndex = 20
        Me.btnImport.Text = "Import Directory"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmPhone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 365)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.btnAdmin)
        Me.Controls.Add(Me.txtCurrent)
        Me.Controls.Add(Me.lblCurrent)
        Me.Controls.Add(Me.tabOperation)
        Me.Controls.Add(Me.lblHint)
        Me.Controls.Add(Me.dgvOutput)
        Me.Controls.Add(Me.lstDirs)
        Me.Controls.Add(Me.lblDirectories)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.btnDisplay)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmPhone"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create and Maintain Telephone Directories"
        CType(Me.dgvOutput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabOperation.ResumeLayout(False)
        Me.tabPageAdd.ResumeLayout(False)
        Me.tabPageAdd.PerformLayout()
        Me.tabPageDelete.ResumeLayout(False)
        Me.tabPageDelete.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCreate As System.Windows.Forms.Button
  Friend WithEvents lblDirectories As System.Windows.Forms.Label
  Friend WithEvents lstDirs As System.Windows.Forms.ListBox
  Friend WithEvents dgvOutput As System.Windows.Forms.DataGridView
  Friend WithEvents lblHint As System.Windows.Forms.Label
    Friend WithEvents tabOperation As TabControl
    Friend WithEvents tabPageAdd As TabPage
    Friend WithEvents tabPageDelete As TabPage
    Friend WithEvents lblDelName As Label
    Friend WithEvents cboName As ComboBox
    Friend WithEvents btnAdmin As Button
    Friend WithEvents btnImport As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
