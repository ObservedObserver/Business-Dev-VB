Public Class Depreciation
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblItem.Click

    End Sub

    Private Sub btnStraightLine_Click(sender As Object, e As EventArgs) Handles btnStraightLine.Click
        If trueData() = "OK" Then
            showDepreciationResult(CInt(txtYearOfPurchase.Text), CDbl(txtEstimatedLifeOfItem.Text), CDbl(txtCost.Text), txtItem.Text, "straight-line")
        Else
            MessageBox.Show(trueData(), "Warning")
        End If
    End Sub

    Function trueData() As String
        If txtItem.Text = "" Then
            Return "Please enter right item value!"
        ElseIf CDbl(txtEstimatedLifeOfItem.Text) = 0 Then
            Return "Please enter a EstimatedLifeOfItem value > 0 !"
        End If
        Return "OK"
    End Function

    Private Sub showDepreciationResult(ByVal startYear As Integer, usageLife As Double, ByVal itemValue As Double, itemName As String, depreciationMethod As String)
        Dim depreciationRate, depreciationValue, totalDepreciationValue, depreciationLife As Double
        Dim currentValue As Double = itemValue
        lstResult.Items.Clear()
        lstResult.Items.Add("Description: " & itemName)
        lstResult.Items.Add("Year of purchase: " & CStr(startYear))
        lstResult.Items.Add("Esimated life: " & CStr(usageLife))
        lstResult.Items.Add("Methods: " & depreciationMethod)
        lstResult.Items.Add("")
        If depreciationMethod = "straight-line" Then
            depreciationRate = 1.0 / usageLife
            depreciationLife = usageLife
        Else
            depreciationRate = 2.0 / usageLife
            If CInt(usageLife) Mod 2 = 1 Then
                depreciationLife = CDbl(CInt(usageLife / 2.0) + 1)
            Else
                depreciationLife = usageLife / 2.0
            End If
        End If
        depreciationValue = depreciationRate * itemValue
        totalDepreciationValue = 0
        For index = 1 To depreciationLife
            If currentValue = 0 Then
                Exit For
            End If
            lstResult.Items.Add("Value at beginning of " & CStr(startYear) & " : " & currentValue.ToString("C"))
            If currentValue < depreciationValue Then
                depreciationValue = currentValue
                totalDepreciationValue += currentValue
                currentValue = 0
            Else
                currentValue -= depreciationValue
                totalDepreciationValue += depreciationValue
            End If
            lstResult.Items.Add("Amount of depreciation during" & CStr(startYear) & " : " & depreciationValue.ToString("C"))
            lstResult.Items.Add("total depreciation at end of " & CStr(startYear) & " : " & totalDepreciationValue.ToString("C"))
            lstResult.Items.Add("")
            startYear += 1
        Next
    End Sub

    Private Sub btnDoubleDecling_Click(sender As Object, e As EventArgs) Handles btnDoubleDecling.Click
        If trueData() = "OK" Then
            showDepreciationResult(CInt(txtYearOfPurchase.Text), CDbl(txtEstimatedLifeOfItem.Text), CDbl(txtCost.Text), txtItem.Text, "double-declining-balance")
        Else
            MessageBox.Show(trueData(), "Warning")
        End If
    End Sub
End Class
