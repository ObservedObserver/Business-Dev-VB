Public Class frmPhone

    Dim fileName As String = ""      'Current phone directory
    Dim loginStatus As Boolean = False
    Function getFileName(ByVal fileName As String) As String
        Return fileName & ".txt"
    End Function
    Private Sub frmPhone_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DisplayDirectories()
        DisplayCombo()
    End Sub
    Private Sub DisplayCombo()
        If (fileName <> "") And IO.File.Exists(getFileName(fileName)) Then
            Dim query = From line In IO.File.ReadAllLines(getFileName(fileName))
                        Let name = line.Split(","c)(0)
                        Order By name
                        Select name
            'cboName.DataSource = query.ToList
            cboName.BeginUpdate()
            cboName.Items.Clear()
            For Each line In query
                cboName.Items.Add(line.ToString)
            Next
            cboName.EndUpdate()
        End If
    End Sub
    Private Sub btnCreate_Click(sender As System.Object, e As System.EventArgs) Handles btnCreate.Click
        Dim dirNames() As String = IO.File.ReadAllLines("Directories.txt")
        Dim sw As IO.StreamWriter = IO.File.AppendText("Directories.txt")
        Dim newDir As String = InputBox("Enter a file name.").ToUpper
        Dim fileNameOK = True
        If Array.IndexOf(dirNames, newDir) = -1 Then
            If Len(newDir) = 0 Then
                MessageBox.Show("File name is ilag", "warning")
            Else
                Dim sw2 As IO.StreamWriter = IO.File.CreateText(newDir & ".txt")
                sw.WriteLine(newDir & ".txt")
                sw2.Close()
            End If
        End If
        sw.Close()
        DisplayDirectories()
    End Sub

    Private Sub btnOpen_Click(sender As System.Object, e As System.EventArgs)
        MessageBox.Show("Click on an existing phone directory.")
    End Sub

    Sub DisplayDirectories()
        lstDirs.Items.Clear()
        If IO.File.Exists("Directories.txt") Then
            Dim query = From phoneDir In IO.File.ReadAllLines("Directories.txt")
                        Let tranPhoneDir = Split(phoneDir, ".")(0)
                        Order By phoneDir
                        Select tranPhoneDir
            For Each phoneDir In query
                lstDirs.Items.Add(phoneDir)
            Next
        End If
    End Sub

    Private Sub lstDirs_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstDirs.SelectedIndexChanged
        fileName = lstDirs.Text
        txtCurrent.Text = lstDirs.Text
        displayList()
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        'Add name to directory (do not keep the file open).
        If (txtName.Text.Trim.Length = 0) Or
       (txtPhoneNumber.Text.Trim.Length = 0) Then
            MessageBox.Show("You must enter a name and number.")
        Else
            Dim sw As IO.StreamWriter = IO.File.AppendText(getFileName(fileName))
            sw.WriteLine(txtName.Text & "," & txtPhoneNumber.Text)
            sw.Close()
            txtName.Clear()
            txtPhoneNumber.Clear()
            txtName.Focus()
            displayList()

        End If
    End Sub

    Private Sub btnRemove_Click(sender As System.Object, e As System.EventArgs) Handles btnRemove.Click
        Dim query = From line In IO.File.ReadAllLines(getFileName(fileName))
                    Let name = line.Split(","c)(0)
                    Let phoneNum = line.Split(","c)(1)
                    Where name <> cboName.Text
                    Select name & "," & phoneNum
        IO.File.WriteAllLines(getFileName(fileName), query.ToArray)
        cboName.Text = ""
        displayList()
        'txtPhoneNumber.Clear()
        'txtName.Focus()
    End Sub
    Private Sub displayList()
        'MessageBox.Show(fileName, "name")
        DisplayCombo()
        If (fileName <> "") And IO.File.Exists(getFileName(fileName)) Then
            If loginStatus = False Then
                Dim query = From line In IO.File.ReadAllLines(getFileName(fileName))
                            Let name = line.Split(","c)(0)
                            Let phoneNum = "***-****"
                            Order By name
                            Select name, phoneNum
                dgvOutput.DataSource = query.ToList
            Else
                Dim query = From line In IO.File.ReadAllLines(getFileName(fileName))
                            Let name = line.Split(","c)(0)
                            Let phoneNum = line.Split(","c)(1)
                            Order By name
                            Select name, phoneNum
                dgvOutput.DataSource = query.ToList
            End If

            dgvOutput.CurrentCell = Nothing
            dgvOutput.Columns("name").HeaderText = "Name"
            dgvOutput.Columns("phoneNum").HeaderText = "Phone Number"
        End If
    End Sub
    Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click
        displayList()
    End Sub

    Private Sub cboName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboName.SelectedIndexChanged
        cboName.SelectedIndex = cboName.FindString(cboName.Text)
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Dim passwd As String
        passwd = InputBox("Input admin password to access full info.", "Login")
        If passwd = "123456" Then
            loginStatus = True
            displayList()
        Else
            MessageBox.Show("Your password is wrong!", "waring")
        End If
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        OpenFileDialog1.ShowDialog()
        MessageBox.Show(OpenFileDialog1.FileName, "warning")
        'If OpenFileDialog1.FileName.
        Dim dirNames() As String = IO.File.ReadAllLines("Directories.txt")
        Dim sw As IO.StreamWriter = IO.File.AppendText("Directories.txt")
        Dim newDir As String = OpenFileDialog1.FileName
        Dim newDirArr() As String = Split(newDir, "\")
        newDir = newDirArr(newDirArr.Length - 1)
        newDir = Split(newDir, ".")(0)
        newDir = newDir.Substring(0, 1).ToUpper() & newDir.Substring(1, Len(newDir) - 1).ToLower()
        'MessageBox.Show(newDir, "name")
        If Array.IndexOf(dirNames, newDir) = -1 Then
            If Len(newDir) = 0 Then
                MessageBox.Show("File name is ilag", "warning")
            Else
                sw.WriteLine(newDir & ".txt")
                sw.Close()
                FileCopy(OpenFileDialog1.FileName, newDir & ".txt")
                DisplayDirectories()
            End If
        End If
        sw.Close()
    End Sub

    Private Sub cboName_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cboName.SelectedIndexChanged

    End Sub
End Class
