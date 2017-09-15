Imports System.Globalization
Imports System.Text.RegularExpressions

Public Class formUserAdd
    Dim userType As String
    Public Function generateRandomChar(ByRef iLength As Integer) As String
        Dim rdm As New Random()
        Dim allowChrs() As Char = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLOMNOPQRSTUVWXYZ0123456789".ToCharArray()
        Dim sResult As String = ""

        For i As Integer = 0 To iLength - 1
            sResult += allowChrs(rdm.Next(0, allowChrs.Length))
        Next

        Return sResult
    End Function

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        clearFields()
        Me.Close()
    End Sub

    Dim invalid As Boolean
    Public Function IsValidEmail(strIn As String) As Boolean
        invalid = False
        If String.IsNullOrEmpty(strIn) Then Return False

        ' Use IdnMapping class to convert Unicode domain names.
        Try
            strIn = Regex.Replace(strIn, "(@)(.+)$", AddressOf Me.DomainMapper,
                                RegexOptions.None, TimeSpan.FromMilliseconds(200))
        Catch e As RegexMatchTimeoutException
            Return False
        End Try

        If invalid Then Return False

        ' Return true if strIn is in valid e-mail format.
        Try
            Return Regex.IsMatch(strIn,
                 "^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                 "(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                 RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250))
        Catch e As RegexMatchTimeoutException
            Return False
        End Try
    End Function

    Private Function DomainMapper(match As Match) As String
        ' IdnMapping class with default property values.
        Dim idn As New IdnMapping()

        Dim domainName As String = match.Groups(2).Value
        Try
            domainName = idn.GetAscii(domainName)
        Catch e As ArgumentException
            invalid = True
        End Try
        Return match.Groups(1).Value + domainName
    End Function

    Private Sub clearFields()
        txtUsername.ResetText()
        txtPassword.ResetText()
        txtLastName.ResetText()
        txtFirstName.ResetText()
        txtContactNo.ResetText()
        txtEmail.ResetText()
    End Sub

    Private Sub submit()
        Dim isEmailValid As Boolean = IsValidEmail(txtEmail.Text)

        If txtUsername.Text = "" Or txtPassword.Text = "" Or txtLastName.Text = "" Or txtFirstName.Text = "" Or txtContactNo.Text = "" Or txtEmail.Text = "" Then
            MsgBox("Any of the fields can not be empty.", MsgBoxStyle.Exclamation, "Submit")
        Else
            If isEmailValid = True Then
                If IsNumeric(txtContactNo.Text) = True Then
                    Dim submit = UsersTableAdapter.userSubmit(txtUsername.Text, txtPassword.Text, userType, txtLastName.Text, txtFirstName.Text, txtContactNo.Text, txtEmail.Text)

                    If submit > 0 Then
                        MsgBox("New user has been added.", MsgBoxStyle.Information, "Save")

                        clearFields()
                        radStandard.Checked = True
                        radMaster.Checked = False

                        Me.Close()
                    End If
                Else
                    MsgBox("Contact no. is invalid.", MsgBoxStyle.Exclamation, "Submit")
                End If
            Else
                MsgBox("Email is invalid.", MsgBoxStyle.Exclamation, "Submit")
            End If
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        submit()
    End Sub

    Private Sub radStandard_CheckedChanged(sender As Object) Handles radStandard.CheckedChanged
        If radStandard.Checked = True Then
            radMaster.Checked = False
            userType = "standard"
        End If
    End Sub

    Private Sub radMaster_CheckedChanged(sender As Object) Handles radMaster.CheckedChanged
        If radMaster.Checked = True Then
            radStandard.Checked = False
            userType = "master"
        End If
    End Sub

    Private Sub txtContactNo_TextChanged(sender As Object, e As EventArgs) Handles txtContactNo.TextChanged
        formHome.checkNumeric(txtContactNo.Text, "Contact No.")
    End Sub

    Private Sub UsersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UsersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MusicLibDataSet)

    End Sub

    Private Sub formUserAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MusicLibDataSet.users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.MusicLibDataSet.users)
    End Sub

    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown, txtFirstName.KeyDown, txtLastName.KeyDown, txtPassword.KeyDown, txtContactNo.KeyDown, txtEmail.KeyDown
        If e.KeyCode = Keys.Enter Then
            submit()
        End If
    End Sub
    Private Sub txtUsername_MouseClick(sender As Object, e As MouseEventArgs) Handles txtUsername.MouseClick
        txtUsername.Text = generateRandomChar(8)
    End Sub

    Private Sub txtPassword_MouseClick(sender As Object, e As MouseEventArgs) Handles txtPassword.MouseClick
        txtPassword.Text = generateRandomChar(8)
    End Sub
End Class