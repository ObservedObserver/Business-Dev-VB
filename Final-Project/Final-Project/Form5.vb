Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“PhoneDirectoryGroupings1DataSet.PhoneDirectoryGroups”中。您可以根据需要移动或删除它。
        Me.PhoneDirectoryGroupsTableAdapter.Fill(Me.PhoneDirectoryGroupings1DataSet.PhoneDirectoryGroups)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            Me.Validate()
            Me.BindingSource1.EndEdit()
            'TableAdapterName.Update(DataSetName.TableName)
            Me.PhoneDirectoryGroupsTableAdapter.Update(Me.PhoneDirectoryGroupings1DataSet.PhoneDirectoryGroups)
            MessageBox.Show("success", "tip")
        Catch ex As Exception
            MessageBox.Show("fail", "tip")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        frmMain.Show()
    End Sub
End Class