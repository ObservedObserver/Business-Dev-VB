Public Class frmMain
    Dim currentDir As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“PhoneDirectoryGroupings1DataSet.TelephoneListings”中。您可以根据需要移动或删除它。
        Me.TelephoneListingsTableAdapter.Fill(Me.PhoneDirectoryGroupings1DataSet.TelephoneListings)
        'TODO: 这行代码将数据加载到表“PhoneDirectoryGroupings1DataSet.PhoneDirectoryGroups”中。您可以根据需要移动或删除它。
        Me.PhoneDirectoryGroupsTableAdapter.Fill(Me.PhoneDirectoryGroupings1DataSet.PhoneDirectoryGroups)
        Dim query = From line In PhoneDirectoryGroupings1DataSet.PhoneDirectoryGroups
                    Select line.DirectoryGroup
        For Each name As String In query
            lstDirectories.Items.Add(name)
        Next
    End Sub

    Private Sub lstDirectories_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDirectories.SelectedIndexChanged
        currentDir = lstDirectories.SelectedItem
        Dim query = From line In PhoneDirectoryGroupings1DataSet.TelephoneListings
                    Where line.GROUPNAME = currentDir
                    Select line.FullName, line.PhoneNumbe_1, line.PhoneType1
        dgvData.DataSource = query.ToList
        dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub btnMatainPhone_Click(sender As Object, e As EventArgs) Handles btnMatainPhone.Click
        Me.Hide()
        'frmDir.Show()
    End Sub

    Private Sub btnMatainDir_Click(sender As Object, e As EventArgs) Handles btnMatainDir.Click
        Me.Hide()
        frmDir.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
