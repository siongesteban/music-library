Public Class formUserEdit
    Private Sub UsersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UsersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MusicLibDataSet)

    End Sub

    Private Sub formUserEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MusicLibDataSet.users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.MusicLibDataSet.users)

        Try
            Me.UsersTableAdapter.getUser(Me.MusicLibDataSet.users)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub GetUserToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.UsersTableAdapter.getUser(Me.MusicLibDataSet.users)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim isEmailValid As Boolean = formUserAdd.IsValidEmail(txtEditEmail.Text)

        If txtEditUsername.Text = "" Or txtEditPassword.Text = "" Or txtEditLastName.Text = "" Or txtEditFirstName.Text = "" Or txtEditContactNo.Text = "" Or txtEditEmail.Text = "" Then
            MsgBox("Any of the fields can't be empty.", MsgBoxStyle.Exclamation, "Submit")
        Else
            If isEmailValid = True Then
                If IsNumeric(txtEditContactNo.Text) = True Then
                    Dim edit = UsersTableAdapter.userEdit(txtEditUsername.Text, txtEditPassword.Text, txtEditLastName.Text, txtEditFirstName.Text, txtEditContactNo.Text, txtEditEmail.Text, formHome.lblUser.Text)

                    If edit > 0 Then
                        formHome.lblUser.Text = txtEditUsername.Text
                        MsgBox("Change(s) has been made.", MsgBoxStyle.Information, "Edit")
                    Else
                        MsgBox("Something went wrong, please try again", MsgBoxStyle.Exclamation, "Edit")
                    End If
                Else
                    MsgBox("Contact no. is invalid.", MsgBoxStyle.Exclamation, "Submit")
                End If
            Else
                MsgBox("Email is invalid.", MsgBoxStyle.Exclamation, "Submit")
            End If
        End If


    End Sub

    Private Sub txtEditContactNo_TextChanged(sender As Object, e As EventArgs) Handles txtEditContactNo.TextChanged
        formHome.checkNumeric(txtEditContactNo.Text, "Contact No.")
    End Sub
End Class