Public Class frmDir
    Dim queryResult()
    Dim currentIndex As Integer = 0
    Private Sub frmDir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“PhoneDirectoryGroupings1DataSet.PhoneDirectoryGroups”中。您可以根据需要移动或删除它。
        Me.PhoneDirectoryGroupsTableAdapter.Fill(Me.PhoneDirectoryGroupings1DataSet.PhoneDirectoryGroups)
        'Me.PhoneDirectoryGroupsTableAdapter.Fill(Me.PhoneDirectoryGroupings1DataSet1.PhoneDirectoryGroups)
        Dim query = From line In PhoneDirectoryGroupings1DataSet.PhoneDirectoryGroups
                    Select line.DirectoryGroup, line.Descripton
        queryResult = query.ToArray()
        'tslIndex.Text = "of {" & CStr(queryResult.Length) & "}"
        'displayRecord(0)
    End Sub

    Private Sub btExit_Click(sender As Object, e As EventArgs) Handles btExit.Click
        Me.Close()
        frmMain.Show()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchItem As String = txtDirName.Text.Trim.ToUpper
        Dim found As Boolean = False
        PhoneDirectoryGroupsBindingSource.Position = CStr(PhoneDirectoryGroupsBindingSource.Find("DirectoryGroup", searchItem))

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'PhoneDirectoryGroupings1DataSet.PhoneDirectoryGroups.
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click

    End Sub
End Class