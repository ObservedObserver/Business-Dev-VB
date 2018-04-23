Public Class frmMain
    Public currentDir As String
    Public Sub displayDir()
        ' finalDataSet.AcceptChanges()
        Me.PhoneDirectoryGroupsTableAdapter.Update(Me.FinalDataSet.PhoneDirectoryGroups)
        Me.TelephoneListingsTableAdapter.Update(Me.FinalDataSet.TelephoneListings)
        Me.PhoneDirectoryGroupsTableAdapter.Fill(Me.FinalDataSet.PhoneDirectoryGroups)
        Me.TelephoneListingsTableAdapter.Fill(Me.FinalDataSet.TelephoneListings)
        lstDirectories.Items.Clear()
        Dim query = From line In FinalDataSet.PhoneDirectoryGroups
                    Select line.DirectoryGroup
        For Each name As String In query
            lstDirectories.Items.Add(name)
        Next
    End Sub
    Public Sub displayList()
        Dim query = From line In FinalDataSet.TelephoneListings
                    Where line.GROUPNAME = currentDir
                    Select line.FullName, line.PhoneNumbe_1, line.PhoneType1
        dgvData.DataSource = query.ToList
        dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“FinalDataSet.PhoneDirectoryGroups”中。您可以根据需要移动或删除它。
        Me.PhoneDirectoryGroupsTableAdapter.Fill(Me.FinalDataSet.PhoneDirectoryGroups)
        'TODO: 这行代码将数据加载到表“FinalDataSet.TelephoneListings”中。您可以根据需要移动或删除它。
        Me.TelephoneListingsTableAdapter.Fill(Me.FinalDataSet.TelephoneListings)
        'TODO: 这行代码将数据加载到表“finalDataSet.TelephoneListings”中。您可以根据需要移动或删除它。
        displayDir()
    End Sub

    Private Sub lstDirectories_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDirectories.SelectedIndexChanged
        currentDir = lstDirectories.SelectedItem
        displayList()
    End Sub

    Private Sub btnMatainPhone_Click(sender As Object, e As EventArgs) Handles btnMatainPhone.Click
        Me.Hide()
        frmList.Show()
        'Form4.Show()
    End Sub

    Private Sub btnMatainDir_Click(sender As Object, e As EventArgs) Handles btnMatainDir.Click
        Me.Hide()
        frmDir.Show()
        'Form5.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        displayDir()
    End Sub
End Class
