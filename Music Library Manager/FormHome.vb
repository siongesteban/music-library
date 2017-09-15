Imports System.ComponentModel
Imports System.IO

Public Class formHome
    Private Sub formHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MusicLibDataSet.users' table. You can move, or remove it, as needed
        Me.UsersTableAdapter.Fill(Me.MusicLibDataSet.users)
        Me.TracksTableAdapter.Fill(Me.MusicLibDataSet.tracks)

        lblDateTime.Text = DateTime.Now.ToLongDateString()

        If lblUserType.Text = "standard" Then
            btnAddUser.Enabled = False
            btnManageUsers.Enabled = False
            btnAccountRecovery.Enabled = False
        End If
    End Sub

    Private Sub TracksBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TracksBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TracksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MusicLibDataSet)

    End Sub

    Private Sub clearField()
        txtTitle.ResetText()
        txtComment.ResetText()
        txtArtist.ResetText()
        txtAlbumArtist.ResetText()
        txtAlbum.ResetText()
        txtYear.ResetText()
        txtTrackNumA.ResetText()
        txtTrackNumB.ResetText()
        txtGenre.ResetText()
        txtPublisher.ResetText()
        txtCopyright.ResetText()
        txtComposer.ResetText()
        txtDiscNumA.ResetText()
        txtDiscNumB.ResetText()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearField()
    End Sub

    Private Sub submit()
        If txtTitle.Text = "" Or txtComment.Text = "" Or txtArtist.Text = "" Or txtAlbumArtist.Text = "" Or txtAlbum.Text = "" Or txtYear.Text = "" Or txtTrackNumA.Text = "" Or txtTrackNumB.Text = "" Or txtGenre.Text = "" Or txtPublisher.Text = "" Or txtCopyright.Text = "" Or txtComposer.Text = "" Or txtDiscNumA.Text = "" Or txtDiscNumB.Text = "" Then
            MsgBox("Any of the fields can't be empty. Please try again", MsgBoxStyle.Exclamation, "Submit")
        Else
            If IsNumeric(txtYear.Text) = True And IsNumeric(txtTrackNumA.Text) = True And IsNumeric(txtTrackNumB.Text) = True And IsNumeric(txtDiscNumA.Text) = True And IsNumeric(txtDiscNumB.Text) = True Then
                Dim coverLoc As String = ""

                Try
                    coverLoc = imageLocation()
                Catch ex As Exception
                    MsgBox("The track will have no cover.", MsgBoxStyle.Information, "Add User")
                End Try

                Dim submit = TracksTableAdapter.trackSubmit(txtTitle.Text, txtArtist.Text, txtAlbum.Text, txtGenre.Text, CType(txtYear.Text, Int32), CType(txtTrackNumA.Text, Int32), CType(txtDiscNumA.Text, Int32), txtComment.Text, txtAlbumArtist.Text, txtComposer.Text, Today, txtPublisher.Text, txtCopyright.Text, CType(txtTrackNumB.Text, Int32), CType(txtDiscNumB.Text, Int32), coverLoc)

                If submit > 0 Then
                    Me.TracksTableAdapter.Fill(Me.MusicLibDataSet.tracks)
                    clearField()
                    MsgBox("The track has been added to the library.", MsgBoxStyle.Information, "Submit")
                Else
                    MsgBox("Please review the fields.", MsgBoxStyle.Exclamation, "Submit")
                End If
            Else
                MsgBox("Some of the fields are invalid.", MsgBoxStyle.Exclamation, "Submit")
            End If
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        submit()
    End Sub

    Private Sub FlatClose1_Click(sender As Object, e As EventArgs)
        Dim isYes = MsgBox("Did you intend to log out?", MsgBoxStyle.YesNo, "")
        If isYes = MsgBoxResult.Yes Then
            Me.Hide()
            formLogIn.txtUsername.ResetText()
            formLogIn.txtPassword.ResetText()
            formLogIn.radMaster.Checked = False
            formLogIn.radStandard.Checked = True
            formLogIn.Show()
        End If
    End Sub

    Private Sub save()
        If txtEditTitle.Text = "" Or txtEditComment.Text = "" Or txtEditArtist.Text = "" Or txtEditAlbumArtist.Text = "" Or txtEditAlbum.Text = "" Or txtEditYear.Text = "" Or txtEditTrackNumA.Text = "" Or txtEditTrackNumB.Text = "" Or txtEditGenre.Text = "" Or txtEditPublisher.Text = "" Or txtEditCopyright.Text = "" Or txtEditComposer.Text = "" Or txtEditDiscNumA.Text = "" Or txtEditDiscNumB.Text = "" Then
            MsgBox("Any of the fields can't be empty. Please try again", MsgBoxStyle.Exclamation, "Save")
        Else
            If IsNumeric(txtEditYear.Text) = True And IsNumeric(txtEditTrackNumA.Text) = True And IsNumeric(txtEditTrackNumB.Text) = True And IsNumeric(txtEditDiscNumA.Text) = True And IsNumeric(txtEditDiscNumB.Text) = True Then
                Dim isYes = MsgBox("Save changes?", MsgBoxStyle.YesNo, "Edit Track")

                If isYes = MsgBoxResult.Yes Then
                    Dim coverLoc As String = ""

                    Try
                        coverLoc = imageLocation()
                    Catch ex As Exception
                        MsgBox("The track will have no cover.", MsgBoxStyle.Information, "Edit Track")
                    End Try

                    Dim save = TracksTableAdapter.trackEdit(txtEditTitle.Text, txtEditArtist.Text, txtEditAlbum.Text, txtEditGenre.Text, Convert.ToInt32(txtEditYear.Text), Convert.ToInt32(txtEditTrackNumA.Text), Convert.ToInt32(txtEditDiscNumA.Text), txtEditComment.Text, txtEditAlbumArtist.Text, txtEditComposer.Text, txtEditPublisher.Text, txtEditCopyright.Text, Convert.ToInt32(txtEditTrackNumB.Text), Convert.ToInt32(txtEditDiscNumB.Text), coverLoc, lblTitle.Text)

                    If save > 0 Then
                        Me.TracksTableAdapter.Fill(Me.MusicLibDataSet.tracks)
                        MsgBox("Change(s) has been made.", MsgBoxStyle.Information, "Save")
                    Else
                        MsgBox("Something went wrong, please try again.", MsgBoxStyle.Exclamation, "Save")
                    End If
                End If
            Else
                MsgBox("Some of the inputs are invalid.", MsgBoxStyle.Exclamation, "Save")
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        save()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim isYes = MsgBox("This track will be deleted from the library.", MsgBoxStyle.OkCancel, "Delete")

        If isYes = MsgBoxResult.Ok Then
            Dim delete = TracksTableAdapter.trackDelete(lblTitle.Text)

            If delete > 0 Then
                Me.TracksTableAdapter.Fill(Me.MusicLibDataSet.tracks)
                MsgBox("The track has been deleted.", MsgBoxStyle.Information, "Delete")
                txtSearch.ResetText()
            Else
                MsgBox("Something went wrong, please try again.", MsgBoxStyle.Exclamation, "Save")
            End If
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub clearLogin()
        Me.Close()
        formLogIn.txtUsername.Text = ""
        formLogIn.txtPassword.Text = ""
        formLogIn.radMaster.Checked = False
        formLogIn.radGuest.Checked = False
        formLogIn.radStandard.Checked = True
        formLogIn.Show()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        If lblUserType.Text = "guest" Then
            Dim isYes = MsgBox("Do you wish to log out?", MsgBoxStyle.YesNo, "Log out")

            If isYes = MsgBoxResult.Yes Then
                clearLogin()
            End If
        Else
            Dim isYes = MsgBox("Do you wish to log out?", MsgBoxStyle.YesNo, "Log out")

            If isYes = MsgBoxResult.Yes Then
                Dim out = UsersTableAdapter.userSetOut(lblUser.Text)

                If out > 0 Then
                    clearLogin()
                End If
            End If
        End If
    End Sub

    Private Sub btnBrowseUsers_Click(sender As Object, e As EventArgs) Handles btnBrowseUsers.Click
        formUserBrowse.ShowDialog()
    End Sub

    Public Sub checkNumeric(input As String, msgTitle As String)
        If IsNumeric(input) = False Then
            If input <> "" Then
                MsgBox("Input must be numeric.", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub txtEditYear_TextChanged(sender As Object, e As EventArgs) Handles txtEditYear.TextChanged
        checkNumeric(txtEditYear.Text, "Year")
    End Sub

    Private Sub txtEditTrackNumA_TextChanged(sender As Object, e As EventArgs) Handles txtEditTrackNumA.TextChanged
        checkNumeric(txtEditTrackNumA.Text, "Track Number")
    End Sub

    Private Sub txtEditTrackNumB_TextChanged(sender As Object, e As EventArgs) Handles txtEditTrackNumB.TextChanged
        checkNumeric(txtEditTrackNumB.Text, "Track Number")
    End Sub

    Private Sub txtEditDiscNumA_TextChanged(sender As Object, e As EventArgs) Handles txtEditDiscNumA.TextChanged
        checkNumeric(txtEditDiscNumA.Text, "Disc Number")
    End Sub

    Private Sub txtEditDiscNumB_TextChanged(sender As Object, e As EventArgs) Handles txtEditDiscNumB.TextChanged
        checkNumeric(txtEditDiscNumB.Text, "Disc Number")
    End Sub

    Private Sub btnEditAccount_Click(sender As Object, e As EventArgs) Handles btnEditAccount.Click
        formUserEdit.ShowDialog()
    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        If lblUserType.Text <> "master" Then
            MsgBox("Standard users do not have the priviledge to add a user.", MsgBoxStyle.Exclamation, "Add User")
        Else
            formUserAdd.ShowDialog()
        End If
    End Sub

    Private Sub tabMain_Click(sender As Object, e As EventArgs) Handles tabMain.Click
        Me.TracksTableAdapter.Fill(Me.MusicLibDataSet.tracks)
        txtSearch.ResetText()
        pictureCover.ImageLocation = ""
        pictureEditCover.ImageLocation = ""
        btnClearCover.Hide()
        btnEditClearCover.Hide()
        If tabMain.SelectedTab.Text = "ADD TRACK" Or tabMain.SelectedTab.Text = "USER" Then
            listTrack.Hide()
            btnDelete.Hide()
            txtSearch.Hide()
            btnClearSearch.Hide()
        Else
            listTrack.Show()
            btnDelete.Show()
            txtSearch.Show()
            btnClearSearch.Show()
        End If
    End Sub

    Dim imagePath As String
    Dim imageName As String
    Private Sub selectCover(obj As Object)
        openFileCover.Filter = "image file (*.jpg, *.bmp, *.png | *.jpg; *.bmp; *.png"
        If openFileCover.ShowDialog <> DialogResult.Cancel Then
            imagePath = openFileCover.FileName
            imageName = Path.GetFileName(openFileCover.FileName)
            obj.ImageLocation = imagePath
        Else
            obj.ImageLocation = obj.ImageLocation
        End If
    End Sub

    Private Function imageLocation() As String
        My.Computer.FileSystem.CopyFile(imagePath, "assets\cover\" & imageName, FileIO.UIOption.AllDialogs, FileIO.UICancelOption.DoNothing)

        Return "assets\cover\" & imageName
    End Function

    Private Sub pictureEditCover_Click(sender As Object, e As EventArgs) Handles pictureEditCover.Click
        selectCover(pictureEditCover)
        btnEditClearCover.Show()
    End Sub

    Private Sub pictureCover_Click(sender As Object, e As EventArgs) Handles pictureCover.Click
        selectCover(pictureCover)
        btnClearCover.Show()
    End Sub

    Private Sub btnManageUsers_Click(sender As Object, e As EventArgs) Handles btnManageUsers.Click
        If lblUserType.Text <> "master" Then
            MsgBox("Standard users do not have the priviledge to manage other users.", MsgBoxStyle.Exclamation, "Manage Users")
        Else
            formUserManage.ShowDialog()
        End If
    End Sub

    Private Sub btnClearCover_Click(sender As Object, e As EventArgs) Handles btnClearCover.Click
        pictureCover.ImageLocation = ""
        btnClearCover.Hide()
    End Sub

    Private Sub btnEditClearCover_Click(sender As Object, e As EventArgs) Handles btnEditClearCover.Click
        pictureEditCover.ImageLocation = ""
        btnEditClearCover.Hide()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        TracksBindingSource.Filter = If((txtSearch.Text.Length > 0), "[title] LIKE '%" & txtSearch.Text & "%' or [artist] LIKE '%" & txtSearch.Text & "%' or [album] LIKE '%" & txtSearch.Text & "%' or [genre] LIKE '%" & txtSearch.Text & "%'", "")
    End Sub

    Private Sub btnClearSearch_Click(sender As Object, e As EventArgs) Handles btnClearSearch.Click
        txtSearch.ResetText()
    End Sub

    Private Sub txtYear_TextChanged(sender As Object, e As EventArgs) Handles txtYear.TextChanged
        checkNumeric(txtYear.Text, "Year")
    End Sub

    Private Sub txtTrackNumA_TextChanged(sender As Object, e As EventArgs) Handles txtTrackNumA.TextChanged
        checkNumeric(txtTrackNumA.Text, "Track Number")
    End Sub

    Private Sub txtTrackNumB_TextChanged(sender As Object, e As EventArgs) Handles txtTrackNumB.TextChanged
        checkNumeric(txtTrackNumB.Text, "Track Number")
    End Sub

    Private Sub txtDiscNumA_TextChanged(sender As Object, e As EventArgs) Handles txtDiscNumA.TextChanged
        checkNumeric(txtDiscNumA.Text, "Disc Number")
    End Sub

    Private Sub txtDiscNumB_TextChanged(sender As Object, e As EventArgs) Handles txtDiscNumB.TextChanged
        checkNumeric(txtDiscNumB.Text, "Disc Number")
    End Sub

    Private Sub txtTitle_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTitle.KeyDown, txtComment.KeyDown, txtArtist.KeyDown, txtAlbumArtist.KeyDown, txtAlbum.KeyDown, txtYear.KeyDown, txtTrackNumA.KeyDown, txtTrackNumB.KeyDown, txtGenre.KeyDown, txtPublisher.KeyDown, txtCopyright.KeyDown, txtComposer.KeyDown, txtDiscNumA.KeyDown, txtDiscNumB.KeyDown
        If e.KeyCode = Keys.Enter Then
            submit()
        End If
    End Sub

    Private Sub txtEditTitle_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEditTitle.KeyDown, txtEditComment.KeyDown, txtEditArtist.KeyDown, txtEditAlbumArtist.KeyDown, txtEditAlbum.KeyDown, txtEditYear.KeyDown, txtEditTrackNumA.KeyDown, txtEditTrackNumB.KeyDown, txtEditGenre.KeyDown, txtEditPublisher.KeyDown, txtEditCopyright.KeyDown, txtEditComposer.KeyDown, txtEditDiscNumA.KeyDown, txtEditDiscNumB.KeyDown
        If e.KeyCode = Keys.Enter Then
            save()
        End If
    End Sub

    Private Sub btnAccountRecovery_Click(sender As Object, e As EventArgs) Handles btnAccountRecovery.Click
        If lblUserType.Text = "master" Then
            formAccountRecovery.ShowDialog()
        Else
            MsgBox("Standard users do not have the priviledge to recover accounts.", MsgBoxStyle.Exclamation, "Account Recovery")
        End If
    End Sub
End Class