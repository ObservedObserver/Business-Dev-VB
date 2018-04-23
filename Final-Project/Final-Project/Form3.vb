Public Class frmList
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“FinalDataSet.TelephoneListings”中。您可以根据需要移动或删除它。
        Me.TelephoneListingsTableAdapter1.Fill(Me.FinalDataSet.TelephoneListings)
        TelephoneListingsBindingSource.Filter = "GROUPNAME='" & frmMain.currentDir & "'"
        'TODO: 这行代码将数据加载到表“PhoneDirectoryGroupings1DataSet.TelephoneListings”中。您可以根据需要移动或删除它。
        'Me.TelephoneListingsTableAdapter.Fill(Me.PhoneDirectoryGroupings1DataSet.TelephoneListings)
        'TelephoneListingsBindingSource.Filter = "GROUPNAME='" & frmMain.currentDir & "'"
        ' TelephoneListingsBindingSource.Filter = "GROUPNAME='FAMILY'"
        ' BindingNavigator1.DataSource = TelephoneListingsBindingSource
        'BindingNavigator1.BindingSource = TelephoneListingsBindingSource
        'Me.BindingNavigator1.BindingSource.Filter = "GROUPNAME='FAMILY'"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        frmMain.displayDir()
        frmMain.displayList()
        frmMain.Show()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TelephoneListingsBindingSource.EndEdit()
        'TableAdapterName.Update(DataSetName.TableName)
        Me.TelephoneListingsTableAdapter1.Update(Me.FinalDataSet.TelephoneListings)
        Try
            Me.Validate()
            Me.TelephoneListingsBindingSource.EndEdit()
            'TableAdapterName.Update(DataSetName.TableName)
            'Me.TelephoneListingsTableAdapter.GetData()
            Me.TelephoneListingsTableAdapter1.Update(Me.FinalDataSet.TelephoneListings)
            MessageBox.Show("success", "tip")
        Catch ex As Exception
            MessageBox.Show("fail", "tip")
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            Me.Validate()
            Me.TelephoneListingsBindingSource.EndEdit()
            Me.TelephoneListingsTableAdapter1.Update(Me.FinalDataSet.TelephoneListings)
            MessageBox.Show("Saved Successfully! :)", "Hint")
        Catch ex As Exception
            MessageBox.Show("Saved Failed. :{", "Warning")
        End Try
    End Sub
End Class