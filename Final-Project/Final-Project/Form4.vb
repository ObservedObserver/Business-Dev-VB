Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“TmpDataSet.TelephoneListings”中。您可以根据需要移动或删除它。
        Me.TelephoneListingsTableAdapter2.Fill(Me.TmpDataSet.TelephoneListings)
        'TODO: 这行代码将数据加载到表“TestDataSet.TelephoneListings”中。您可以根据需要移动或删除它。
        Me.TelephoneListingsTableAdapter1.Fill(Me.TestDataSet.TelephoneListings)
        'TODO: 这行代码将数据加载到表“PhoneDirectoryGroupings1DataSet.PhoneDirectoryGroups”中。您可以根据需要移动或删除它。
        Me.PhoneDirectoryGroupsTableAdapter.Fill(Me.PhoneDirectoryGroupings1DataSet.PhoneDirectoryGroups)
        'TODO: 这行代码将数据加载到表“PhoneDirectoryGroupings1DataSet.TelephoneListings”中。您可以根据需要移动或删除它。
        Me.TelephoneListingsTableAdapter.Fill(Me.PhoneDirectoryGroupings1DataSet.TelephoneListings)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        'Me.Validate()
        'Me.BindingSource1.EndEdit()
        Me.Validate()
        Me.BindingSource2.EndEdit()
        Me.TelephoneListingsTableAdapter2.Update(Me.TmpDataSet.TelephoneListings)
        Try
            Me.Validate()
            Me.BindingSource2.EndEdit()
            Me.TelephoneListingsTableAdapter2.Update(Me.TmpDataSet.TelephoneListings)
            'TableAdapterManager.UpdateAll(Me.PhoneDirectoryGroupings1DataSet)
            ' UpdateDB()
            'Me.TelephoneListingsTableAdapter.Update(Me.PhoneDirectoryGroupings1DataSet.TelephoneListings)
            MsgBox("Update successful")

        Catch ex As Exception
            MsgBox("Update failed")
        End Try
    End Sub
    Private Sub UpdateDB()
        Dim deletedChildRecords As PhoneDirectoryGroupings1DataSet.TelephoneListingsDataTable =
            CType(PhoneDirectoryGroupings1DataSet.TelephoneListings.GetChanges(Data.DataRowState.Deleted), PhoneDirectoryGroupings1DataSet.TelephoneListingsDataTable)

        Dim newChildRecords As PhoneDirectoryGroupings1DataSet.TelephoneListingsDataTable =
            CType(PhoneDirectoryGroupings1DataSet.TelephoneListings.GetChanges(Data.DataRowState.Added), PhoneDirectoryGroupings1DataSet.TelephoneListingsDataTable)

        Dim modifiedChildRecords As PhoneDirectoryGroupings1DataSet.TelephoneListingsDataTable =
            CType(PhoneDirectoryGroupings1DataSet.TelephoneListings.GetChanges(Data.DataRowState.Modified), PhoneDirectoryGroupings1DataSet.TelephoneListingsDataTable)

        Try
            If deletedChildRecords IsNot Nothing Then
                TelephoneListingsTableAdapter.Update(deletedChildRecords)
            End If

            PhoneDirectoryGroupsTableAdapter.Update(PhoneDirectoryGroupings1DataSet.PhoneDirectoryGroups)

            If newChildRecords IsNot Nothing Then
                TelephoneListingsTableAdapter.Update(newChildRecords)
            End If

            If modifiedChildRecords IsNot Nothing Then
                TelephoneListingsTableAdapter.Update(modifiedChildRecords)
                MessageBox.Show("sdsd", "sd")
            End If

            PhoneDirectoryGroupings1DataSet.AcceptChanges()

        Catch ex As Exception
            MessageBox.Show("An error occurred during the update process")
            ' Add code to handle error here.

        Finally
            If deletedChildRecords IsNot Nothing Then
                deletedChildRecords.Dispose()
            End If

            If newChildRecords IsNot Nothing Then
                newChildRecords.Dispose()
            End If

            If modifiedChildRecords IsNot Nothing Then
                modifiedChildRecords.Dispose()
            End If

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        frmMain.Show()
    End Sub
End Class