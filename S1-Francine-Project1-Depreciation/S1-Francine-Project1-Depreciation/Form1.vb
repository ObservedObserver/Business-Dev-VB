Public Class Depreciation
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblItem.Click

    End Sub

    ' straight-line 按钮的点击事件
    Private Sub btnStraightLine_Click(sender As Object, e As EventArgs) Handles btnStraightLine.Click
        If TrueData() = "OK" Then
            ShowDepreciationResult(CInt(txtYearOfPurchase.Text), CDbl(txtEstimatedLifeOfItem.Text), CDbl(txtCost.Text), txtItem.Text, "straight-line")
        Else
            MessageBox.Show(TrueData(), "Warning")
        End If
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
    ' double-declining-balance 按钮的点击事件
    Private Sub btnDoubleDecling_Click(sender As Object, e As EventArgs) Handles btnDoubleDecling.Click
        If TrueData() = "OK" Then
            ShowDepreciationResult(CInt(txtYearOfPurchase.Text), CDbl(txtEstimatedLifeOfItem.Text), CDbl(txtCost.Text), txtItem.Text, "double-declining-balance")
        Else
            MessageBox.Show(trueData(), "Warning")
        End If
    End Sub
End Class
