<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Depreciation
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblYearOfPurchase = New System.Windows.Forms.Label()
        Me.lblEstimatedLifeOfItem = New System.Windows.Forms.Label()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.txtEstimatedLifeOfItem = New System.Windows.Forms.TextBox()
        Me.txtYearOfPurchase = New System.Windows.Forms.TextBox()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lstResult = New System.Windows.Forms.ListBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.radStraight = New System.Windows.Forms.RadioButton()
        Me.radDouble = New System.Windows.Forms.RadioButton()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.grpMethods = New System.Windows.Forms.GroupBox()
        Me.grpMethods.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Location = New System.Drawing.Point(221, 45)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(39, 20)
        Me.lblItem.TabIndex = 0
        Me.lblItem.Text = "Item"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Location = New System.Drawing.Point(222, 83)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(38, 20)
        Me.lblCost.TabIndex = 1
        Me.lblCost.Text = "Cost"
        '
        'lblYearOfPurchase
        '
        Me.lblYearOfPurchase.AutoSize = True
        Me.lblYearOfPurchase.Location = New System.Drawing.Point(139, 121)
        Me.lblYearOfPurchase.Name = "lblYearOfPurchase"
        Me.lblYearOfPurchase.Size = New System.Drawing.Size(121, 20)
        Me.lblYearOfPurchase.TabIndex = 2
        Me.lblYearOfPurchase.Text = "Year of purchase"
        '
        'lblEstimatedLifeOfItem
        '
        Me.lblEstimatedLifeOfItem.AutoSize = True
        Me.lblEstimatedLifeOfItem.Location = New System.Drawing.Point(60, 159)
        Me.lblEstimatedLifeOfItem.Name = "lblEstimatedLifeOfItem"
        Me.lblEstimatedLifeOfItem.Size = New System.Drawing.Size(200, 20)
        Me.lblEstimatedLifeOfItem.TabIndex = 3
        Me.lblEstimatedLifeOfItem.Text = "Estimated life of item (years)"
        '
        'txtItem
        '
        Me.txtItem.Location = New System.Drawing.Point(275, 42)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(100, 25)
        Me.txtItem.TabIndex = 1
        '
        'txtEstimatedLifeOfItem
        '
        Me.txtEstimatedLifeOfItem.Location = New System.Drawing.Point(275, 156)
        Me.txtEstimatedLifeOfItem.Name = "txtEstimatedLifeOfItem"
        Me.txtEstimatedLifeOfItem.Size = New System.Drawing.Size(100, 25)
        Me.txtEstimatedLifeOfItem.TabIndex = 4
        '
        'txtYearOfPurchase
        '
        Me.txtYearOfPurchase.Location = New System.Drawing.Point(275, 118)
        Me.txtYearOfPurchase.Name = "txtYearOfPurchase"
        Me.txtYearOfPurchase.Size = New System.Drawing.Size(100, 25)
        Me.txtYearOfPurchase.TabIndex = 3
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(275, 80)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(100, 25)
        Me.txtCost.TabIndex = 2
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(315, 283)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(140, 50)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lstResult
        '
        Me.lstResult.FormattingEnabled = True
        Me.lstResult.ItemHeight = 20
        Me.lstResult.Location = New System.Drawing.Point(411, 31)
        Me.lstResult.Name = "lstResult"
        Me.lstResult.Size = New System.Drawing.Size(311, 204)
        Me.lstResult.TabIndex = 10
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(532, 283)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(140, 50)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'radStraight
        '
        Me.radStraight.AutoSize = True
        Me.radStraight.Checked = True
        Me.radStraight.Location = New System.Drawing.Point(17, 24)
        Me.radStraight.Name = "radStraight"
        Me.radStraight.Size = New System.Drawing.Size(170, 24)
        Me.radStraight.TabIndex = 12
        Me.radStraight.TabStop = True
        Me.radStraight.Text = "Staright-line-method"
        Me.radStraight.UseVisualStyleBackColor = True
        '
        'radDouble
        '
        Me.radDouble.AutoSize = True
        Me.radDouble.Location = New System.Drawing.Point(17, 51)
        Me.radDouble.Name = "radDouble"
        Me.radDouble.Size = New System.Drawing.Size(251, 24)
        Me.radDouble.TabIndex = 13
        Me.radDouble.TabStop = True
        Me.radDouble.Text = "Double-decling-balance-method"
        Me.radDouble.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(105, 283)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(140, 50)
        Me.btnCalculate.TabIndex = 14
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'grpMethods
        '
        Me.grpMethods.Controls.Add(Me.radStraight)
        Me.grpMethods.Controls.Add(Me.radDouble)
        Me.grpMethods.Location = New System.Drawing.Point(53, 187)
        Me.grpMethods.Name = "grpMethods"
        Me.grpMethods.Size = New System.Drawing.Size(306, 81)
        Me.grpMethods.TabIndex = 15
        Me.grpMethods.TabStop = False
        Me.grpMethods.Text = "Depreciation Method"
        '
        'Depreciation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 370)
        Me.Controls.Add(Me.grpMethods)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lstResult)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.txtYearOfPurchase)
        Me.Controls.Add(Me.txtEstimatedLifeOfItem)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.lblEstimatedLifeOfItem)
        Me.Controls.Add(Me.lblYearOfPurchase)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblItem)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Depreciation"
        Me.Text = "Depreciation"
        Me.grpMethods.ResumeLayout(False)
        Me.grpMethods.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblItem As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents lblYearOfPurchase As Label
    Friend WithEvents lblEstimatedLifeOfItem As Label
    Friend WithEvents txtItem As TextBox
    Friend WithEvents txtEstimatedLifeOfItem As TextBox
    Friend WithEvents txtYearOfPurchase As TextBox
    Friend WithEvents txtCost As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents lstResult As ListBox
    Friend WithEvents btnExit As Button
    Friend WithEvents radStraight As RadioButton
    Friend WithEvents radDouble As RadioButton
    Friend WithEvents btnCalculate As Button
    Friend WithEvents grpMethods As GroupBox
End Class
