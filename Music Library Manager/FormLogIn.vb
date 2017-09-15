Public Class formLogIn

    Dim userType As String = Nothing

    Private Sub formLogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.UsersTableAdapter.Fill(Me.MusicLibDataSet.users)
        Catch ex As Exception
            MsgBox("Database is missing.", MsgBoxStyle.Critical, "MLM")
            Me.Close()
        End Try
    End Sub

    Private Sub login()
        If userType = "guest" Then
            Me.Hide()

            formHome.lblUserType.Text = userType
            formHome.lblUser.Text = txtUsername.Text

            formHome.tabAddTrack.Enabled = False
            formHome.tabEditTrack.Enabled = False

            formHome.btnBrowseUsers.Enabled = False
            formHome.btnAddUser.Enabled = False
            formHome.btnEditAccount.Enabled = False
            formHome.btnManageUsers.Enabled = False
            formHome.btnAccountRecovery.Enabled = False

            formHome.btnDelete.Enabled = False

            formHome.Show()
        Else
            Dim login = UsersTableAdapter.userLogIn(txtUsername.Text, txtPassword.Text, userType)

            If txtUsername.Text = "" Or txtPassword.Text = "" Then
                MsgBox("Please fill all the fields.", MsgBoxStyle.Exclamation, "Log In")
            Else
                If login > 0 Then
                    Dim userIn = UsersTableAdapter.userSetIn(txtUsername.Text)

                    If userIn > 0 Then
                        Me.Hide()

                        formHome.lblUserType.Text = userType
                        formHome.lblUser.Text = txtUsername.Text
                        formHome.Show()
                    End If
                Else
                    MsgBox("Log in details are not correct.", MsgBoxStyle.Exclamation, "Log In")
                End If
            End If
        End If
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        login()
    End Sub

    Private Sub radStandard_CheckedChanged(sender As Object) Handles radStandard.CheckedChanged
        If radStandard.Checked = True Then
            radMaster.Checked = False
            radGuest.Checked = False
            userType = "standard"
            txtPassword.Enabled = True
            Label1.Text = "Username:"
        End If
    End Sub

    Private Sub radMaster_CheckedChanged(sender As Object) Handles radMaster.CheckedChanged
        If radMaster.Checked = True Then
            radStandard.Checked = False
            radGuest.Checked = False
            userType = "master"
            txtPassword.Enabled = True
            Label1.Text = "Username:"
        End If
    End Sub

    Private Sub radGuest_CheckedChanged(sender As Object) Handles radGuest.CheckedChanged
        If radGuest.Checked = True Then
            radStandard.Checked = False
            radMaster.Checked = False
            userType = "guest"
            txtPassword.Enabled = False
            Label1.Text = "Name:"
        End If
    End Sub

    Private Sub UsersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UsersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MusicLibDataSet)

    End Sub

    Private Sub FlatClose1_Click(sender As Object, e As EventArgs) Handles FlatClose1.Click
        Application.Exit()
    End Sub

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim tmp As System.Windows.Forms.KeyPressEventArgs = e
        If tmp.KeyChar = ChrW(Keys.Enter) Then
            MessageBox.Show("Enter key")
        Else
            MessageBox.Show(tmp.KeyChar)
        End If
    End Sub

    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown, txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            login()
        End If
    End Sub

    Private Sub btnForgotPassword_Click(sender As Object, e As EventArgs) Handles btnForgotPassword.Click
        MsgBox("Please request an account recovery to a master user.", MsgBoxStyle.Information, "Account Recovery")
    End Sub
End Class
