Public Class formAccountRecovery
    Private Sub UsersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UsersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MusicLibDataSet)

    End Sub

    Private Sub formAccountRecovery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MusicLibDataSet.users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.MusicLibDataSet.users)

    End Sub

    Private Sub recover()
        If txtUsername.TextLength > 0 Then
            If txtUsername.Text <> formHome.lblUser.Text Then
                Dim password As String = Convert.ToString((UsersTableAdapter.userRecoverPassword(txtUsername.Text)))

                If password.Length > 0 Then
                    Dim change = UsersTableAdapter.userChangePassword(formUserAdd.generateRandomChar(8), txtUsername.Text)

                    If change > 0 Then
                        Dim passwordNew As String = Convert.ToString((UsersTableAdapter.userRecoverPassword(txtUsername.Text)))

                        If passwordNew.Length Then
                            MsgBox("The account has been recovered.", MsgBoxStyle.Information, "Account Recovery")
                            MsgBox("Please give this new password to the user: " & passwordNew, MsgBoxStyle.Information, "Password Reset")
                            Me.Close()
                        End If
                    End If
                Else
                    MsgBox("The account was not found.", MsgBoxStyle.Exclamation, "Account Recovery")
                End If
            Else
                MsgBox("This account is in use.", MsgBoxStyle.Exclamation, "Account Recovery")
            End If
        Else
            MsgBox("Please enter a username.", MsgBoxStyle.Exclamation, "Account Recovery")
        End If
    End Sub

    Private Sub btbRecover_Click(sender As Object, e As EventArgs) Handles btbRecover.Click
        recover()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            recover()
        End If
    End Sub
End Class