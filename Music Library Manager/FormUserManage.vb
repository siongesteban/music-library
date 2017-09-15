Public Class formUserManage
    Dim userType As String

    Private Sub UsersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UsersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MusicLibDataSet)
    End Sub

    Private Sub formUserManage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MusicLibDataSet.users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.MusicLibDataSet.users)

        getUserType()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        txtSearch.ResetText()
        Me.Close()
    End Sub

    Private Sub radStandard_CheckedChanged(sender As Object) Handles radStandard.CheckedChanged
        If radStandard.Checked = True Then
            If txtEditUsername.Text = formHome.lblUser.Text Then
                MsgBox("You must assign another user on the library to have a master account before you can change this user's account type. This ensures that there is always at least one user with a master account on the library.", MsgBoxStyle.Exclamation, "Save")

                radStandard.Checked = False
                userType = "master"
            Else
                radMaster.Checked = False
                userType = "standard"
            End If
        End If
    End Sub

    Private Sub radMaster_CheckedChanged(sender As Object) Handles radMaster.CheckedChanged
        If radMaster.Checked = True Then
            radStandard.Checked = False
            userType = "master"
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        txtSearch.ResetText()
        Dim save = UsersTableAdapter.userEditManage(userType, txtEditUsername.Text)

        If save > 0 Then
            Me.UsersTableAdapter.Fill(Me.MusicLibDataSet.users)
            formHome.lblUserType.Text = txtEditUserType.Text
            getUserType()
            MsgBox("Changes have been made.", MsgBoxStyle.Information, "Save")
        End If
    End Sub

    Private Sub getUserType()
        If txtEditUserType.Text = "master" Then
            radMaster.Checked = True
            radStandard.Checked = False
        Else
            radStandard.Checked = True
            radMaster.Checked = False
        End If
    End Sub

    Private Sub listUser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listUser.SelectedIndexChanged
        getUserType()

        If txtEditUsername.Text = formHome.lblUser.Text Then
            btnSave.Enabled = False
        Else
            btnSave.Enabled = True
        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        txtSearch.ResetText()

        If txtEditUsername.Text = formHome.lblUser.Text Then
            MsgBox("This account is currently in use.", MsgBoxStyle.Exclamation, "Delete")
        Else
            If userType <> "master" Then
                Dim isYes = MsgBox("Are you sure to delete this user?", MsgBoxStyle.YesNo, "Delete")

                If isYes = MsgBoxResult.Yes Then
                    Dim delete = UsersTableAdapter.userDelete(txtEditUsername.Text)

                    If delete > 0 Then
                        MsgBox("The account has been deleted.", MsgBoxStyle.Information, "Delete")
                        Me.UsersTableAdapter.Fill(Me.MusicLibDataSet.users)
                    End If
                End If
            Else
                MsgBox("Master users can not be deleted.", MsgBoxStyle.Exclamation, "Delete User")
            End If
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        UsersBindingSource.Filter = If((txtSearch.Text.Length > 0), "[username] LIKE '%" & txtSearch.Text & "%' or [first_name] LIKE '%" & txtSearch.Text & "%' or [last_name] LIKE '%" & txtSearch.Text & "%' or [user_type] LIKE '%" & txtSearch.Text & "%' or [contact_no] LIKE '%" & txtSearch.Text & "%' or [email] LIKE '%" & txtSearch.Text & "%'", "")
    End Sub

    Private Sub btnClearSearch_Click(sender As Object, e As EventArgs) Handles btnClearSearch.Click
        txtSearch.ResetText()
    End Sub
End Class