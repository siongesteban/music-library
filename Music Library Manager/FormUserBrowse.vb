Public Class formUserBrowse
    Private Sub formUserBrowse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MusicLibDataSet.users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.MusicLibDataSet.users)

    End Sub

    Private Sub UsersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UsersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MusicLibDataSet)

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        txtSearch.ResetText()
        Me.Close()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        UsersBindingSource.Filter = If((txtSearch.Text.Length > 0), "[username] LIKE '%" & txtSearch.Text & "%' or [first_name] LIKE '%" & txtSearch.Text & "%' or [last_name] LIKE '%" & txtSearch.Text & "%' or [user_type] LIKE '%" & txtSearch.Text & "%' or [contact_no] LIKE '%" & txtSearch.Text & "%' or [email] LIKE '%" & txtSearch.Text & "%'", "")
    End Sub

    Private Sub btnClearSearch_Click(sender As Object, e As EventArgs) Handles btnClearSearch.Click
        txtSearch.ResetText()
    End Sub
End Class