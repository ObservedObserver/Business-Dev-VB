Public Class Depreciation
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblItem.Click

    End Sub

    '判断数据格式是否正确 
    Function TrueData() As String
        If txtItem.Text = "" Then
            Return "Please enter right item value!"
        ElseIf txtCost.Text = "" Or isNumeric(txtCost.Text) = False Then
            Return "Please enter right cost value!"
        ElseIf txtYearOfPurchase.Text = "" Or IsNumeric(txtYearOfPurchase.Text) = False Then
            Return "Please enter right Tear of Purchase value!"
        ElseIf txtEstimatedLifeOfItem.Text = "" Or IsNumeric(txtEstimatedLifeOfItem.Text) = False Then
            Return "Please enter right Estimated Life of Item!"
        ElseIf CDbl(txtEstimatedLifeOfItem.Text) = 0 Then
            Return "Please enter a EstimatedLifeOfItem value > 0 !!"
        End If
        '如果数据格式正确，返回"ok"
        Return "OK"
    End Function
    ' 展示list上的基本信息部分
    Private Sub DisplayBasicInfo(startYear As String, usageLife As String, itemName As String, depreciationMethod As String)
        lstResult.Items.Clear()
        lstResult.Items.Add("Description: " & itemName)
        lstResult.Items.Add("Year of purchase: " & startYear)
        lstResult.Items.Add("Esimated life: " & usageLife)
        lstResult.Items.Add("Methods: " & depreciationMethod)
        lstResult.Items.Add("")
    End Sub
    ' 根据折旧方法，计算折旧率
    Function GetDepreciationRate(usageLife As Double, depreciationMethod As String) As Double
        Dim depreciationRate As Double
        If depreciationMethod = "straight-line" Then
            depreciationRate = 1.0 / usageLife
        Else
            depreciationRate = 2.0 / usageLife
        End If
        Return depreciationRate
    End Function
    ' 展示每年的这就信息
    Private Sub ShowDepreciationResult(ByVal startYear As Integer, usageLife As Double, ByVal itemValue As Double, itemName As String, depreciationMethod As String)
        Dim depreciationRate, depreciationValue, totalDepreciationValue As Double
        Dim currentValue As Double = itemValue
        ' 展示基本信息
        DisplayBasicInfo(startYear, CStr(usageLife), CStr(itemName), depreciationMethod)
        ' 计算折旧率
        depreciationRate = GetDepreciationRate(usageLife, depreciationMethod)
        ' 设置默认的折旧量，即straight-line情况下的折旧量
        depreciationValue = depreciationRate * itemValue
        ' 初始化总折旧量为0
        totalDepreciationValue = 0
        For index = 1 To usageLife
            If currentValue <= 0 Then
                Exit For
            End If
            lstResult.Items.Add("Value at beginning of " & CStr(startYear) & " : " & currentValue.ToString("C"))
            ' 根据折旧方法计算每年折旧量，累计折旧量，与剩余价值。
            If depreciationMethod = "straight-line" Then
                currentValue -= depreciationValue
                totalDepreciationValue += depreciationValue
            Else
                depreciationValue = currentValue * depreciationRate
                totalDepreciationValue += depreciationValue
                currentValue -= depreciationValue

            End If
            lstResult.Items.Add("Amount of depreciation during" & CStr(startYear) & " : " & depreciationValue.ToString("C"))
            lstResult.Items.Add("total depreciation at end of " & CStr(startYear) & " : " & totalDepreciationValue.ToString("C"))
            lstResult.Items.Add("")
            startYear += 1
        Next
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim method As String
        If TrueData() = "OK" Then
            ' 检查折旧方法
            If radStraight.Checked = True Then
                method = "straight-line"
            Else
                method = "double-deciling"
            End If
            ShowDepreciationResult(CInt(txtYearOfPurchase.Text), CDbl(txtEstimatedLifeOfItem.Text), CDbl(txtCost.Text), txtItem.Text, method)
        Else
            MessageBox.Show(TrueData(), "Warning")
        End If
    End Sub
    ' 点击Clear, 清空所有值并将单选框还原为默认值(straight-line)
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCost.Clear()
        txtItem.Clear()
        txtYearOfPurchase.Clear()
        txtEstimatedLifeOfItem.Clear()
        radDouble.Checked = False
        radStraight.Checked = True
    End Sub
    ' 点击Exit, 推出应用
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
