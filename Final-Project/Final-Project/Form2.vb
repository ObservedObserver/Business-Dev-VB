Public Class frmDir
    Dim queryResult()
    Dim currentIndex As Integer = 0
    Private Sub frmDir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“FinalDataSet.PhoneDirectoryGroups”中。您可以根据需要移动或删除它。
        Me.PhoneDirectoryGroupsTableAdapter.Fill(Me.FinalDataSet.PhoneDirectoryGroups)
        'TODO: 这行代码将数据加载到表“finalDataSet.PhoneDirectoryGroups”中。您可以根据需要移动或删除它。
        'Me.PhoneDirectoryGroupsTableAdapter.Fill(frmMain.finalDataSet.PhoneDirectoryGroups)
        'Me.finalDataSet.PhoneDirectoryGroups
        Me.PhoneDirectoryGroupsTableAdapter.Fill(Me.FinalDataSet.PhoneDirectoryGroups)
        Dim query = From line In FinalDataSet.PhoneDirectoryGroups
                    Select line.DirectoryGroup, line.Descripton
        queryResult = query.ToArray()
        'tslIndex.Text = "of {" & CStr(queryResult.Length) & "}"
        'displayRecord(0)
    End Sub

    Private Sub btExit_Click(sender As Object, e As EventArgs) Handles btExit.Click
        Me.Close()
        frmMain.displayDir()
        frmMain.displayList()
        frmMain.Show()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchItem As String = txtDirName.Text.Trim.ToUpper
        Dim found As Boolean = False
        BindingSource1.Position = CStr(BindingSource1.Find("DirectoryGroup", searchItem))

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'finalDataSet.PhoneDirectoryGroups.
        Try
            Me.Validate()
            Me.BindingSource1.EndEdit()
            Me.PhoneDirectoryGroupsTableAdapter.Update(Me.FinalDataSet.PhoneDirectoryGroups)
            MessageBox.Show("Saved Successfully! :)", "Hint")
        Catch ex As Exception
            MessageBox.Show("Saved Failed. :{", "Warning")
        End Try
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click

    End Sub
End Class