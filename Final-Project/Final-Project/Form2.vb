Public Class frmDir
    Dim queryResult()
    Dim currentIndex As Integer = 0
    Private Sub displayRecord(ByVal num)
        currentIndex = num
        txtDirGroup.Text = queryResult(currentIndex).DirectoryGroup
        txtDescription.Text = queryResult(currentIndex).Descripton
        tstIndex.Text = CStr(currentIndex + 1)
    End Sub
    Private Sub frmDir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“PhoneDirectoryGroupings1DataSet1.PhoneDirectoryGroups”中。您可以根据需要移动或删除它。
        Me.PhoneDirectoryGroupsTableAdapter.Fill(Me.PhoneDirectoryGroupings1DataSet1.PhoneDirectoryGroups)
        Dim query = From line In PhoneDirectoryGroupings1DataSet1.PhoneDirectoryGroups
                    Select line.DirectoryGroup, line.Descripton
        queryResult = query.ToArray()
        tslIndex.Text = "of {" & CStr(queryResult.Length) & "}"
        displayRecord(0)
    End Sub

    Private Sub btExit_Click(sender As Object, e As EventArgs) Handles btExit.Click
        Me.Hide()
        frmMain.Show()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        'currentIndex = (currentIndex + 1) Mod queryResult.Length
        displayRecord((currentIndex + 1) Mod queryResult.Length)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        'currentIndex = (currentIndex - 1 + queryResult.Length) Mod queryResult.Length
        displayRecord((currentIndex - 1 + queryResult.Length) Mod queryResult.Length)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        displayRecord(0)
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        displayRecord(queryResult.Length - 1)
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        Dim index As Integer
        Try
            index = CInt(tstIndex.Text.Trim) - 1
        Catch
            MessageBox.Show("check your input(may not be a number)", "warning")
        End Try
        If index >= 0 And index < queryResult.Length Then
            displayRecord(index)
        Else
            MessageBox.Show("Out of range", "warning")
        End If
    End Sub
End Class