Public Class frmList
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“PhoneDirectoryGroupings1DataSet.TelephoneListings”中。您可以根据需要移动或删除它。
        Me.TelephoneListingsTableAdapter1.Fill(Me.PhoneDirectoryGroupings1DataSet.TelephoneListings)
        'TODO: 这行代码将数据加载到表“PhoneDirectoryGroupings1DataSet2.TelephoneListings”中。您可以根据需要移动或删除它。
        Me.TelephoneListingsTableAdapter.Fill(Me.PhoneDirectoryGroupings1DataSet2.TelephoneListings)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        frmMain.Show()
    End Sub
End Class