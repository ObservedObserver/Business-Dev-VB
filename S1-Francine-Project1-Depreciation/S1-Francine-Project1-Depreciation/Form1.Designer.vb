﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Depreciation
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
        Me.lblItem = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblYearOfPurchase = New System.Windows.Forms.Label()
        Me.lblEstimatedLifeOfItem = New System.Windows.Forms.Label()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.txtEstimatedLifeOfItem = New System.Windows.Forms.TextBox()
        Me.txtYearOfPurchase = New System.Windows.Forms.TextBox()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.btnStraightLine = New System.Windows.Forms.Button()
        Me.lstResult = New System.Windows.Forms.ListBox()
        Me.btnDoubleDecling = New System.Windows.Forms.Button()
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
        'btnStraightLine
        '
        Me.btnStraightLine.Location = New System.Drawing.Point(64, 214)
        Me.btnStraightLine.Name = "btnStraightLine"
        Me.btnStraightLine.Size = New System.Drawing.Size(140, 50)
        Me.btnStraightLine.TabIndex = 8
        Me.btnStraightLine.Text = "Straight Line Method"
        Me.btnStraightLine.UseVisualStyleBackColor = True
        '
        'lstResult
        '
        Me.lstResult.FormattingEnabled = True
        Me.lstResult.ItemHeight = 20
        Me.lstResult.Location = New System.Drawing.Point(64, 292)
        Me.lstResult.Name = "lstResult"
        Me.lstResult.Size = New System.Drawing.Size(311, 184)
        Me.lstResult.TabIndex = 10
        '
        'btnDoubleDecling
        '
        Me.btnDoubleDecling.Location = New System.Drawing.Point(235, 214)
        Me.btnDoubleDecling.Name = "btnDoubleDecling"
        Me.btnDoubleDecling.Size = New System.Drawing.Size(140, 50)
        Me.btnDoubleDecling.TabIndex = 11
        Me.btnDoubleDecling.Text = "Double Decling Method"
        Me.btnDoubleDecling.UseVisualStyleBackColor = True
        '
        'Depreciation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 525)
        Me.Controls.Add(Me.btnDoubleDecling)
        Me.Controls.Add(Me.lstResult)
        Me.Controls.Add(Me.btnStraightLine)
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
    Friend WithEvents btnStraightLine As Button
    Friend WithEvents lstResult As ListBox
    Friend WithEvents btnDoubleDecling As Button
End Class