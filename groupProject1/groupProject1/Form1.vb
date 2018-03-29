Public Class Form1
    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        If txtUserName.Text = "ChenHao" And txtPassword.Text = "123456" Then
            grpLogin.Hide()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtUserName.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Exit button on the login group, used to close the form
        End
    End Sub
End Class
