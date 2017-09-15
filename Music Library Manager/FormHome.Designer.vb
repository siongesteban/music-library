<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formHome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formHome))
        Me.TracksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MusicLibDataSet = New musicLibraryManager.musicLibDataSet()
        Me.TracksTableAdapter = New musicLibraryManager.musicLibDataSetTableAdapters.tracksTableAdapter()
        Me.TableAdapterManager = New musicLibraryManager.musicLibDataSetTableAdapters.TableAdapterManager()
        Me.panelMain = New musicLibraryManager.FormSkin()
        Me.btnClearSearch = New musicLibraryManager.FlatButton()
        Me.txtSearch = New musicLibraryManager.FlatTextBox()
        Me.btnDelete = New musicLibraryManager.FlatButton()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblUserType = New System.Windows.Forms.Label()
        Me.listTrack = New System.Windows.Forms.ListBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.FlatMini1 = New musicLibraryManager.FlatMini()
        Me.TracksBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TracksBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.tabMain = New musicLibraryManager.FlatTabControl()
        Me.tabBrowse = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.FlatGroupBox4 = New musicLibraryManager.FlatGroupBox()
        Me.lblDiscNumB = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblComposer = New System.Windows.Forms.Label()
        Me.lblDiscNumAA = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.FlatGroupBox3 = New musicLibraryManager.FlatGroupBox()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblPublisher = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.FlatGroupBox2 = New musicLibraryManager.FlatGroupBox()
        Me.lblGenre = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblTrackNumB = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblTrackNumA = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblAlbum = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblAlbumArtist = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblArtist = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FlatGroupBox1 = New musicLibraryManager.FlatGroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblComment = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabAddTrack = New System.Windows.Forms.TabPage()
        Me.btnClearCover = New musicLibraryManager.FlatButton()
        Me.pictureCover = New System.Windows.Forms.PictureBox()
        Me.btnClear = New musicLibraryManager.FlatButton()
        Me.btnSubmit = New musicLibraryManager.FlatButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.FlatGroupBox5 = New musicLibraryManager.FlatGroupBox()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.txtDiscNumB = New System.Windows.Forms.TextBox()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.txtDiscNumA = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.txtComposer = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.FlatGroupBox6 = New musicLibraryManager.FlatGroupBox()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.txtCopyright = New System.Windows.Forms.TextBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.txtPublisher = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.FlatGroupBox7 = New musicLibraryManager.FlatGroupBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.txtGenre = New System.Windows.Forms.TextBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.txtTrackNumB = New System.Windows.Forms.TextBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.txtTrackNumA = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtAlbum = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtAlbumArtist = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtArtist = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.FlatGroupBox8 = New musicLibraryManager.FlatGroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.tabEditTrack = New System.Windows.Forms.TabPage()
        Me.FlatGroupBox9 = New musicLibraryManager.FlatGroupBox()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.txtEditDiscNumB = New System.Windows.Forms.TextBox()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.txtEditDiscNumA = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.txtEditComposer = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.FlatGroupBox10 = New musicLibraryManager.FlatGroupBox()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.txtEditCopyright = New System.Windows.Forms.TextBox()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.txtEditPublisher = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.FlatGroupBox11 = New musicLibraryManager.FlatGroupBox()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.txtEditGenre = New System.Windows.Forms.TextBox()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.txtEditTrackNumB = New System.Windows.Forms.TextBox()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.txtEditTrackNumA = New System.Windows.Forms.TextBox()
        Me.Panel23 = New System.Windows.Forms.Panel()
        Me.txtEditYear = New System.Windows.Forms.TextBox()
        Me.Panel24 = New System.Windows.Forms.Panel()
        Me.txtEditAlbum = New System.Windows.Forms.TextBox()
        Me.Panel25 = New System.Windows.Forms.Panel()
        Me.txtEditAlbumArtist = New System.Windows.Forms.TextBox()
        Me.Panel26 = New System.Windows.Forms.Panel()
        Me.txtEditArtist = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.FlatGroupBox12 = New musicLibraryManager.FlatGroupBox()
        Me.Panel27 = New System.Windows.Forms.Panel()
        Me.txtEditComment = New System.Windows.Forms.TextBox()
        Me.Panel28 = New System.Windows.Forms.Panel()
        Me.txtEditTitle = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.btnEditClearCover = New musicLibraryManager.FlatButton()
        Me.pictureEditCover = New System.Windows.Forms.PictureBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.btnSave = New musicLibraryManager.FlatButton()
        Me.tabUser = New System.Windows.Forms.TabPage()
        Me.btnAccountRecovery = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnManageUsers = New System.Windows.Forms.Button()
        Me.btnEditAccount = New System.Windows.Forms.Button()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.btnBrowseUsers = New System.Windows.Forms.Button()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersTableAdapter = New musicLibraryManager.musicLibDataSetTableAdapters.usersTableAdapter()
        Me.timerClock = New System.Windows.Forms.Timer(Me.components)
        Me.openFileCover = New System.Windows.Forms.OpenFileDialog()
        CType(Me.TracksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MusicLibDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelMain.SuspendLayout()
        CType(Me.TracksBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TracksBindingNavigator.SuspendLayout()
        Me.tabMain.SuspendLayout()
        Me.tabBrowse.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlatGroupBox4.SuspendLayout()
        Me.FlatGroupBox3.SuspendLayout()
        Me.FlatGroupBox2.SuspendLayout()
        Me.FlatGroupBox1.SuspendLayout()
        Me.tabAddTrack.SuspendLayout()
        CType(Me.pictureCover, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlatGroupBox5.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.FlatGroupBox6.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.FlatGroupBox7.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.FlatGroupBox8.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.tabEditTrack.SuspendLayout()
        Me.FlatGroupBox9.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.FlatGroupBox10.SuspendLayout()
        Me.Panel18.SuspendLayout()
        Me.Panel19.SuspendLayout()
        Me.FlatGroupBox11.SuspendLayout()
        Me.Panel20.SuspendLayout()
        Me.Panel21.SuspendLayout()
        Me.Panel22.SuspendLayout()
        Me.Panel23.SuspendLayout()
        Me.Panel24.SuspendLayout()
        Me.Panel25.SuspendLayout()
        Me.Panel26.SuspendLayout()
        Me.FlatGroupBox12.SuspendLayout()
        Me.Panel27.SuspendLayout()
        Me.Panel28.SuspendLayout()
        CType(Me.pictureEditCover, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabUser.SuspendLayout()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TracksBindingSource
        '
        Me.TracksBindingSource.DataMember = "tracks"
        Me.TracksBindingSource.DataSource = Me.MusicLibDataSet
        '
        'MusicLibDataSet
        '
        Me.MusicLibDataSet.DataSetName = "musicLibDataSet"
        Me.MusicLibDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TracksTableAdapter
        '
        Me.TracksTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tracksTableAdapter = Me.TracksTableAdapter
        Me.TableAdapterManager.UpdateOrder = musicLibraryManager.musicLibDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        '
        'panelMain
        '
        Me.panelMain.BackColor = System.Drawing.Color.White
        Me.panelMain.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.panelMain.BorderColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.panelMain.Controls.Add(Me.btnClearSearch)
        Me.panelMain.Controls.Add(Me.txtSearch)
        Me.panelMain.Controls.Add(Me.btnDelete)
        Me.panelMain.Controls.Add(Me.btnClose)
        Me.panelMain.Controls.Add(Me.lblUserType)
        Me.panelMain.Controls.Add(Me.listTrack)
        Me.panelMain.Controls.Add(Me.lblUser)
        Me.panelMain.Controls.Add(Me.lblDateTime)
        Me.panelMain.Controls.Add(Me.FlatMini1)
        Me.panelMain.Controls.Add(Me.TracksBindingNavigator)
        Me.panelMain.Controls.Add(Me.tabMain)
        Me.panelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMain.FlatColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.panelMain.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.panelMain.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.panelMain.HeaderMaximize = False
        Me.panelMain.Location = New System.Drawing.Point(0, 0)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Padding = New System.Windows.Forms.Padding(0, 50, 1, 1)
        Me.panelMain.Size = New System.Drawing.Size(1018, 509)
        Me.panelMain.TabIndex = 0
        Me.panelMain.Text = "Music Library Manager"
        '
        'btnClearSearch
        '
        Me.btnClearSearch.BackColor = System.Drawing.Color.Transparent
        Me.btnClearSearch.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnClearSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClearSearch.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearSearch.Location = New System.Drawing.Point(989, 480)
        Me.btnClearSearch.Name = "btnClearSearch"
        Me.btnClearSearch.Rounded = False
        Me.btnClearSearch.Size = New System.Drawing.Size(29, 29)
        Me.btnClearSearch.TabIndex = 25
        Me.btnClearSearch.Text = "x"
        Me.btnClearSearch.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.Transparent
        Me.txtSearch.Location = New System.Drawing.Point(722, 480)
        Me.txtSearch.MaxLength = 32767
        Me.txtSearch.Multiline = False
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Padding = New System.Windows.Forms.Padding(3)
        Me.txtSearch.ReadOnly = False
        Me.txtSearch.Size = New System.Drawing.Size(268, 29)
        Me.txtSearch.TabIndex = 24
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtSearch.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSearch.UseSystemPasswordChar = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnDelete.BaseColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.btnDelete.Location = New System.Drawing.Point(957, 440)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(0)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Rounded = True
        Me.btnDelete.Size = New System.Drawing.Size(47, 22)
        Me.btnDelete.TabIndex = 19
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(987, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(18, 18)
        Me.btnClose.TabIndex = 23
        Me.btnClose.Text = "x"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lblUserType
        '
        Me.lblUserType.AutoSize = True
        Me.lblUserType.BackColor = System.Drawing.Color.Transparent
        Me.lblUserType.Font = New System.Drawing.Font("Segoe UI Light", 9.0!)
        Me.lblUserType.ForeColor = System.Drawing.Color.White
        Me.lblUserType.Location = New System.Drawing.Point(561, 25)
        Me.lblUserType.Name = "lblUserType"
        Me.lblUserType.Size = New System.Drawing.Size(42, 15)
        Me.lblUserType.TabIndex = 22
        Me.lblUserType.Text = "master"
        Me.lblUserType.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'listTrack
        '
        Me.listTrack.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.listTrack.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listTrack.DataSource = Me.TracksBindingSource
        Me.listTrack.DisplayMember = "title"
        Me.listTrack.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listTrack.ForeColor = System.Drawing.Color.White
        Me.listTrack.FormattingEnabled = True
        Me.listTrack.ItemHeight = 30
        Me.listTrack.Location = New System.Drawing.Point(722, 50)
        Me.listTrack.Name = "listTrack"
        Me.listTrack.Size = New System.Drawing.Size(295, 420)
        Me.listTrack.TabIndex = 18
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.BackColor = System.Drawing.Color.Transparent
        Me.lblUser.Font = New System.Drawing.Font("Segoe UI Light", 9.0!)
        Me.lblUser.ForeColor = System.Drawing.Color.White
        Me.lblUser.Location = New System.Drawing.Point(690, 25)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(34, 15)
        Me.lblUser.TabIndex = 21
        Me.lblUser.Text = "siong"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDateTime
        '
        Me.lblDateTime.AutoSize = True
        Me.lblDateTime.BackColor = System.Drawing.Color.Transparent
        Me.lblDateTime.Font = New System.Drawing.Font("Segoe UI Light", 9.0!)
        Me.lblDateTime.ForeColor = System.Drawing.Color.White
        Me.lblDateTime.Location = New System.Drawing.Point(363, 25)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(116, 15)
        Me.lblDateTime.TabIndex = 20
        Me.lblDateTime.Text = "12/8/2016 7:56:47 PM"
        Me.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FlatMini1
        '
        Me.FlatMini1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMini1.BackColor = System.Drawing.Color.White
        Me.FlatMini1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatMini1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMini1.Location = New System.Drawing.Point(963, 12)
        Me.FlatMini1.Name = "FlatMini1"
        Me.FlatMini1.Size = New System.Drawing.Size(18, 18)
        Me.FlatMini1.TabIndex = 2
        Me.FlatMini1.Text = "FlatMini1"
        Me.FlatMini1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'TracksBindingNavigator
        '
        Me.TracksBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TracksBindingNavigator.BindingSource = Me.TracksBindingSource
        Me.TracksBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TracksBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TracksBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.TracksBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TracksBindingNavigatorSaveItem})
        Me.TracksBindingNavigator.Location = New System.Drawing.Point(254, 0)
        Me.TracksBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TracksBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TracksBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TracksBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TracksBindingNavigator.Name = "TracksBindingNavigator"
        Me.TracksBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TracksBindingNavigator.Size = New System.Drawing.Size(278, 25)
        Me.TracksBindingNavigator.TabIndex = 0
        Me.TracksBindingNavigator.Text = "BindingNavigator1"
        Me.TracksBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TracksBindingNavigatorSaveItem
        '
        Me.TracksBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TracksBindingNavigatorSaveItem.Image = CType(resources.GetObject("TracksBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TracksBindingNavigatorSaveItem.Name = "TracksBindingNavigatorSaveItem"
        Me.TracksBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TracksBindingNavigatorSaveItem.Text = "Save Data"
        '
        'tabMain
        '
        Me.tabMain.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.tabMain.Controls.Add(Me.tabBrowse)
        Me.tabMain.Controls.Add(Me.tabAddTrack)
        Me.tabMain.Controls.Add(Me.tabEditTrack)
        Me.tabMain.Controls.Add(Me.tabUser)
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Left
        Me.tabMain.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabMain.ItemSize = New System.Drawing.Size(120, 40)
        Me.tabMain.Location = New System.Drawing.Point(0, 50)
        Me.tabMain.Margin = New System.Windows.Forms.Padding(0)
        Me.tabMain.Multiline = True
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(722, 458)
        Me.tabMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tabMain.TabIndex = 0
        '
        'tabBrowse
        '
        Me.tabBrowse.AutoScroll = True
        Me.tabBrowse.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.tabBrowse.Controls.Add(Me.PictureBox1)
        Me.tabBrowse.Controls.Add(Me.Label14)
        Me.tabBrowse.Controls.Add(Me.FlatGroupBox4)
        Me.tabBrowse.Controls.Add(Me.FlatGroupBox3)
        Me.tabBrowse.Controls.Add(Me.FlatGroupBox2)
        Me.tabBrowse.Controls.Add(Me.FlatGroupBox1)
        Me.tabBrowse.Location = New System.Drawing.Point(4, 44)
        Me.tabBrowse.Name = "tabBrowse"
        Me.tabBrowse.Size = New System.Drawing.Size(714, 410)
        Me.tabBrowse.TabIndex = 0
        Me.tabBrowse.Text = "BROWSE"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("ImageLocation", Me.TracksBindingSource, "imagePath", True))
        Me.PictureBox1.ImageLocation = ""
        Me.PictureBox1.Location = New System.Drawing.Point(457, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(222, 222)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(393, 622)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 19)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Label14"
        '
        'FlatGroupBox4
        '
        Me.FlatGroupBox4.AutoScroll = True
        Me.FlatGroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatGroupBox4.Controls.Add(Me.lblDiscNumB)
        Me.FlatGroupBox4.Controls.Add(Me.Label11)
        Me.FlatGroupBox4.Controls.Add(Me.lblComposer)
        Me.FlatGroupBox4.Controls.Add(Me.lblDiscNumAA)
        Me.FlatGroupBox4.Controls.Add(Me.Label13)
        Me.FlatGroupBox4.Controls.Add(Me.Label15)
        Me.FlatGroupBox4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox4.Location = New System.Drawing.Point(8, 519)
        Me.FlatGroupBox4.Name = "FlatGroupBox4"
        Me.FlatGroupBox4.ShowText = True
        Me.FlatGroupBox4.Size = New System.Drawing.Size(671, 105)
        Me.FlatGroupBox4.TabIndex = 17
        Me.FlatGroupBox4.Text = "Content"
        '
        'lblDiscNumB
        '
        Me.lblDiscNumB.AutoSize = True
        Me.lblDiscNumB.BackColor = System.Drawing.Color.Transparent
        Me.lblDiscNumB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TracksBindingSource, "diskNumB", True))
        Me.lblDiscNumB.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblDiscNumB.ForeColor = System.Drawing.Color.White
        Me.lblDiscNumB.Location = New System.Drawing.Point(234, 72)
        Me.lblDiscNumB.Name = "lblDiscNumB"
        Me.lblDiscNumB.Size = New System.Drawing.Size(22, 17)
        Me.lblDiscNumB.TabIndex = 19
        Me.lblDiscNumB.Text = "10"
        Me.lblDiscNumB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(217, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(13, 17)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "/"
        '
        'lblComposer
        '
        Me.lblComposer.AutoSize = True
        Me.lblComposer.BackColor = System.Drawing.Color.Transparent
        Me.lblComposer.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TracksBindingSource, "composer", True))
        Me.lblComposer.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblComposer.ForeColor = System.Drawing.Color.White
        Me.lblComposer.Location = New System.Drawing.Point(191, 41)
        Me.lblComposer.Name = "lblComposer"
        Me.lblComposer.Size = New System.Drawing.Size(86, 17)
        Me.lblComposer.TabIndex = 3
        Me.lblComposer.Text = "<composer>"
        '
        'lblDiscNumAA
        '
        Me.lblDiscNumAA.AutoSize = True
        Me.lblDiscNumAA.BackColor = System.Drawing.Color.Transparent
        Me.lblDiscNumAA.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TracksBindingSource, "discNumA", True))
        Me.lblDiscNumAA.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblDiscNumAA.ForeColor = System.Drawing.Color.White
        Me.lblDiscNumAA.Location = New System.Drawing.Point(191, 72)
        Me.lblDiscNumAA.Name = "lblDiscNumAA"
        Me.lblDiscNumAA.Size = New System.Drawing.Size(22, 17)
        Me.lblDiscNumAA.TabIndex = 17
        Me.lblDiscNumAA.Text = "10"
        Me.lblDiscNumAA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(35, 47)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 17)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Composer"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(35, 78)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 17)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Part of Set"
        '
        'FlatGroupBox3
        '
        Me.FlatGroupBox3.AutoScroll = True
        Me.FlatGroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatGroupBox3.Controls.Add(Me.lblCopyright)
        Me.FlatGroupBox3.Controls.Add(Me.Label22)
        Me.FlatGroupBox3.Controls.Add(Me.lblPublisher)
        Me.FlatGroupBox3.Controls.Add(Me.Label24)
        Me.FlatGroupBox3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox3.Location = New System.Drawing.Point(8, 408)
        Me.FlatGroupBox3.Name = "FlatGroupBox3"
        Me.FlatGroupBox3.ShowText = True
        Me.FlatGroupBox3.Size = New System.Drawing.Size(671, 105)
        Me.FlatGroupBox3.TabIndex = 16
        Me.FlatGroupBox3.Text = "Origin"
        '
        'lblCopyright
        '
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.BackColor = System.Drawing.Color.Transparent
        Me.lblCopyright.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TracksBindingSource, "copyright", True))
        Me.lblCopyright.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblCopyright.ForeColor = System.Drawing.Color.White
        Me.lblCopyright.Location = New System.Drawing.Point(191, 82)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(84, 17)
        Me.lblCopyright.TabIndex = 5
        Me.lblCopyright.Text = "<copyright>"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(35, 82)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(65, 17)
        Me.Label22.TabIndex = 4
        Me.Label22.Text = "Copyright"
        '
        'lblPublisher
        '
        Me.lblPublisher.AutoSize = True
        Me.lblPublisher.BackColor = System.Drawing.Color.Transparent
        Me.lblPublisher.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TracksBindingSource, "publisher", True))
        Me.lblPublisher.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblPublisher.ForeColor = System.Drawing.Color.White
        Me.lblPublisher.Location = New System.Drawing.Point(191, 47)
        Me.lblPublisher.Name = "lblPublisher"
        Me.lblPublisher.Size = New System.Drawing.Size(82, 17)
        Me.lblPublisher.TabIndex = 3
        Me.lblPublisher.Text = "<publisher>"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(35, 47)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(61, 17)
        Me.Label24.TabIndex = 2
        Me.Label24.Text = "Publisher"
        '
        'FlatGroupBox2
        '
        Me.FlatGroupBox2.AutoScroll = True
        Me.FlatGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatGroupBox2.Controls.Add(Me.lblGenre)
        Me.FlatGroupBox2.Controls.Add(Me.Label10)
        Me.FlatGroupBox2.Controls.Add(Me.lblTrackNumB)
        Me.FlatGroupBox2.Controls.Add(Me.Label9)
        Me.FlatGroupBox2.Controls.Add(Me.lblTrackNumA)
        Me.FlatGroupBox2.Controls.Add(Me.Label8)
        Me.FlatGroupBox2.Controls.Add(Me.lblYear)
        Me.FlatGroupBox2.Controls.Add(Me.Label5)
        Me.FlatGroupBox2.Controls.Add(Me.lblAlbum)
        Me.FlatGroupBox2.Controls.Add(Me.Label7)
        Me.FlatGroupBox2.Controls.Add(Me.lblAlbumArtist)
        Me.FlatGroupBox2.Controls.Add(Me.Label4)
        Me.FlatGroupBox2.Controls.Add(Me.lblArtist)
        Me.FlatGroupBox2.Controls.Add(Me.Label6)
        Me.FlatGroupBox2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox2.Location = New System.Drawing.Point(8, 160)
        Me.FlatGroupBox2.Name = "FlatGroupBox2"
        Me.FlatGroupBox2.ShowText = True
        Me.FlatGroupBox2.Size = New System.Drawing.Size(443, 248)
        Me.FlatGroupBox2.TabIndex = 6
        Me.FlatGroupBox2.Text = "Media"
        '
        'lblGenre
        '
        Me.lblGenre.AutoSize = True
        Me.lblGenre.BackColor = System.Drawing.Color.Transparent
        Me.lblGenre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TracksBindingSource, "genre", True))
        Me.lblGenre.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblGenre.ForeColor = System.Drawing.Color.White
        Me.lblGenre.Location = New System.Drawing.Point(191, 223)
        Me.lblGenre.Name = "lblGenre"
        Me.lblGenre.Size = New System.Drawing.Size(61, 17)
        Me.lblGenre.TabIndex = 15
        Me.lblGenre.Text = "<genre>"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(35, 223)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 17)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Genre"
        '
        'lblTrackNumB
        '
        Me.lblTrackNumB.AutoSize = True
        Me.lblTrackNumB.BackColor = System.Drawing.Color.Transparent
        Me.lblTrackNumB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TracksBindingSource, "trackNumB", True))
        Me.lblTrackNumB.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblTrackNumB.ForeColor = System.Drawing.Color.White
        Me.lblTrackNumB.Location = New System.Drawing.Point(234, 188)
        Me.lblTrackNumB.Name = "lblTrackNumB"
        Me.lblTrackNumB.Size = New System.Drawing.Size(22, 17)
        Me.lblTrackNumB.TabIndex = 13
        Me.lblTrackNumB.Text = "10"
        Me.lblTrackNumB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(215, 187)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 17)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "/"
        '
        'lblTrackNumA
        '
        Me.lblTrackNumA.AutoSize = True
        Me.lblTrackNumA.BackColor = System.Drawing.Color.Transparent
        Me.lblTrackNumA.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TracksBindingSource, "trackNumA", True))
        Me.lblTrackNumA.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblTrackNumA.ForeColor = System.Drawing.Color.White
        Me.lblTrackNumA.Location = New System.Drawing.Point(191, 188)
        Me.lblTrackNumA.Name = "lblTrackNumA"
        Me.lblTrackNumA.Size = New System.Drawing.Size(22, 17)
        Me.lblTrackNumA.TabIndex = 11
        Me.lblTrackNumA.Text = "10"
        Me.lblTrackNumA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(35, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 17)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Track"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.BackColor = System.Drawing.Color.Transparent
        Me.lblYear.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TracksBindingSource, "yearRelease", True))
        Me.lblYear.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblYear.ForeColor = System.Drawing.Color.White
        Me.lblYear.Location = New System.Drawing.Point(191, 152)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(111, 17)
        Me.lblYear.TabIndex = 9
        Me.lblYear.Text = "<yearOfRelease>"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(35, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Year"
        '
        'lblAlbum
        '
        Me.lblAlbum.AutoSize = True
        Me.lblAlbum.BackColor = System.Drawing.Color.Transparent
        Me.lblAlbum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TracksBindingSource, "album", True))
        Me.lblAlbum.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblAlbum.ForeColor = System.Drawing.Color.White
        Me.lblAlbum.Location = New System.Drawing.Point(191, 117)
        Me.lblAlbum.Name = "lblAlbum"
        Me.lblAlbum.Size = New System.Drawing.Size(64, 17)
        Me.lblAlbum.TabIndex = 7
        Me.lblAlbum.Text = "<album>"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(35, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Album"
        '
        'lblAlbumArtist
        '
        Me.lblAlbumArtist.AutoSize = True
        Me.lblAlbumArtist.BackColor = System.Drawing.Color.Transparent
        Me.lblAlbumArtist.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TracksBindingSource, "artist", True))
        Me.lblAlbumArtist.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblAlbumArtist.ForeColor = System.Drawing.Color.White
        Me.lblAlbumArtist.Location = New System.Drawing.Point(191, 82)
        Me.lblAlbumArtist.Name = "lblAlbumArtist"
        Me.lblAlbumArtist.Size = New System.Drawing.Size(97, 17)
        Me.lblAlbumArtist.TabIndex = 5
        Me.lblAlbumArtist.Text = "<albumArtist>"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(35, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Album Artist"
        '
        'lblArtist
        '
        Me.lblArtist.AutoSize = True
        Me.lblArtist.BackColor = System.Drawing.Color.Transparent
        Me.lblArtist.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TracksBindingSource, "artist", True))
        Me.lblArtist.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblArtist.ForeColor = System.Drawing.Color.White
        Me.lblArtist.Location = New System.Drawing.Point(191, 47)
        Me.lblArtist.Name = "lblArtist"
        Me.lblArtist.Size = New System.Drawing.Size(140, 17)
        Me.lblArtist.TabIndex = 3
        Me.lblArtist.Text = "<contributingArtists>"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(35, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Contributing Artist(s)"
        '
        'FlatGroupBox1
        '
        Me.FlatGroupBox1.AutoScroll = True
        Me.FlatGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatGroupBox1.Controls.Add(Me.Label16)
        Me.FlatGroupBox1.Controls.Add(Me.Label17)
        Me.FlatGroupBox1.Controls.Add(Me.lblComment)
        Me.FlatGroupBox1.Controls.Add(Me.Label3)
        Me.FlatGroupBox1.Controls.Add(Me.lblTitle)
        Me.FlatGroupBox1.Controls.Add(Me.Label1)
        Me.FlatGroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.FlatGroupBox1.Name = "FlatGroupBox1"
        Me.FlatGroupBox1.ShowText = True
        Me.FlatGroupBox1.Size = New System.Drawing.Size(443, 148)
        Me.FlatGroupBox1.TabIndex = 0
        Me.FlatGroupBox1.Text = "Description"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TracksBindingSource, "dateAdded", True))
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(191, 116)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(93, 17)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "<dateAdded>"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(35, 116)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(78, 17)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "Date Added"
        '
        'lblComment
        '
        Me.lblComment.AutoSize = True
        Me.lblComment.BackColor = System.Drawing.Color.Transparent
        Me.lblComment.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TracksBindingSource, "comment", True))
        Me.lblComment.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblComment.ForeColor = System.Drawing.Color.White
        Me.lblComment.Location = New System.Drawing.Point(191, 82)
        Me.lblComment.Name = "lblComment"
        Me.lblComment.Size = New System.Drawing.Size(84, 17)
        Me.lblComment.TabIndex = 5
        Me.lblComment.Text = "<comment>"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(35, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Comment"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TracksBindingSource, "title", True))
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(191, 47)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(49, 17)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "<title>"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(35, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Title"
        '
        'tabAddTrack
        '
        Me.tabAddTrack.AutoScroll = True
        Me.tabAddTrack.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.tabAddTrack.Controls.Add(Me.btnClearCover)
        Me.tabAddTrack.Controls.Add(Me.pictureCover)
        Me.tabAddTrack.Controls.Add(Me.btnClear)
        Me.tabAddTrack.Controls.Add(Me.btnSubmit)
        Me.tabAddTrack.Controls.Add(Me.Label12)
        Me.tabAddTrack.Controls.Add(Me.FlatGroupBox5)
        Me.tabAddTrack.Controls.Add(Me.FlatGroupBox6)
        Me.tabAddTrack.Controls.Add(Me.FlatGroupBox7)
        Me.tabAddTrack.Controls.Add(Me.FlatGroupBox8)
        Me.tabAddTrack.Location = New System.Drawing.Point(4, 44)
        Me.tabAddTrack.Name = "tabAddTrack"
        Me.tabAddTrack.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAddTrack.Size = New System.Drawing.Size(714, 410)
        Me.tabAddTrack.TabIndex = 1
        Me.tabAddTrack.Text = "ADD TRACK"
        '
        'btnClearCover
        '
        Me.btnClearCover.BackColor = System.Drawing.Color.Transparent
        Me.btnClearCover.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnClearCover.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClearCover.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnClearCover.Location = New System.Drawing.Point(604, 247)
        Me.btnClearCover.Name = "btnClearCover"
        Me.btnClearCover.Rounded = False
        Me.btnClearCover.Size = New System.Drawing.Size(75, 32)
        Me.btnClearCover.TabIndex = 36
        Me.btnClearCover.Text = "Clear"
        Me.btnClearCover.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnClearCover.Visible = False
        '
        'pictureCover
        '
        Me.pictureCover.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.pictureCover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureCover.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureCover.ImageLocation = ""
        Me.pictureCover.Location = New System.Drawing.Point(457, 19)
        Me.pictureCover.Name = "pictureCover"
        Me.pictureCover.Size = New System.Drawing.Size(222, 222)
        Me.pictureCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureCover.TabIndex = 35
        Me.pictureCover.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Transparent
        Me.btnClear.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnClear.Location = New System.Drawing.Point(204, 596)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Rounded = False
        Me.btnClear.Size = New System.Drawing.Size(75, 32)
        Me.btnClear.TabIndex = 22
        Me.btnClear.Text = "Clear"
        Me.btnClear.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Transparent
        Me.btnSubmit.BaseColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnSubmit.Location = New System.Drawing.Point(285, 596)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Rounded = False
        Me.btnSubmit.Size = New System.Drawing.Size(129, 32)
        Me.btnSubmit.TabIndex = 23
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(494, 629)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 19)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Label12"
        '
        'FlatGroupBox5
        '
        Me.FlatGroupBox5.AutoScroll = True
        Me.FlatGroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox5.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatGroupBox5.Controls.Add(Me.Panel13)
        Me.FlatGroupBox5.Controls.Add(Me.Panel14)
        Me.FlatGroupBox5.Controls.Add(Me.Label2)
        Me.FlatGroupBox5.Controls.Add(Me.Panel12)
        Me.FlatGroupBox5.Controls.Add(Me.Label19)
        Me.FlatGroupBox5.Controls.Add(Me.Label20)
        Me.FlatGroupBox5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox5.Location = New System.Drawing.Point(8, 477)
        Me.FlatGroupBox5.Name = "FlatGroupBox5"
        Me.FlatGroupBox5.ShowText = True
        Me.FlatGroupBox5.Size = New System.Drawing.Size(431, 105)
        Me.FlatGroupBox5.TabIndex = 21
        Me.FlatGroupBox5.Text = "Content"
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel13.Controls.Add(Me.txtDiscNumB)
        Me.Panel13.Location = New System.Drawing.Point(250, 70)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(33, 29)
        Me.Panel13.TabIndex = 14
        '
        'txtDiscNumB
        '
        Me.txtDiscNumB.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtDiscNumB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDiscNumB.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtDiscNumB.ForeColor = System.Drawing.Color.Silver
        Me.txtDiscNumB.Location = New System.Drawing.Point(9, 6)
        Me.txtDiscNumB.MaxLength = 2
        Me.txtDiscNumB.Name = "txtDiscNumB"
        Me.txtDiscNumB.Size = New System.Drawing.Size(16, 18)
        Me.txtDiscNumB.TabIndex = 14
        Me.txtDiscNumB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel14.Controls.Add(Me.txtDiscNumA)
        Me.Panel14.Location = New System.Drawing.Point(196, 70)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(33, 29)
        Me.Panel14.TabIndex = 13
        '
        'txtDiscNumA
        '
        Me.txtDiscNumA.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtDiscNumA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDiscNumA.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtDiscNumA.ForeColor = System.Drawing.Color.Silver
        Me.txtDiscNumA.Location = New System.Drawing.Point(9, 6)
        Me.txtDiscNumA.MaxLength = 2
        Me.txtDiscNumA.Name = "txtDiscNumA"
        Me.txtDiscNumA.Size = New System.Drawing.Size(16, 18)
        Me.txtDiscNumA.TabIndex = 13
        Me.txtDiscNumA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(233, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 17)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "/"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel12.Controls.Add(Me.txtComposer)
        Me.Panel12.Location = New System.Drawing.Point(196, 35)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(210, 29)
        Me.Panel12.TabIndex = 12
        '
        'txtComposer
        '
        Me.txtComposer.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtComposer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtComposer.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtComposer.ForeColor = System.Drawing.Color.Silver
        Me.txtComposer.Location = New System.Drawing.Point(13, 6)
        Me.txtComposer.Name = "txtComposer"
        Me.txtComposer.Size = New System.Drawing.Size(185, 18)
        Me.txtComposer.TabIndex = 12
        Me.txtComposer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(35, 47)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(69, 17)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Composer"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(35, 82)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(69, 17)
        Me.Label20.TabIndex = 16
        Me.Label20.Text = "Part of Set"
        '
        'FlatGroupBox6
        '
        Me.FlatGroupBox6.AutoScroll = True
        Me.FlatGroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox6.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatGroupBox6.Controls.Add(Me.Panel11)
        Me.FlatGroupBox6.Controls.Add(Me.Panel10)
        Me.FlatGroupBox6.Controls.Add(Me.Label23)
        Me.FlatGroupBox6.Controls.Add(Me.Label26)
        Me.FlatGroupBox6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox6.Location = New System.Drawing.Point(8, 366)
        Me.FlatGroupBox6.Name = "FlatGroupBox6"
        Me.FlatGroupBox6.ShowText = True
        Me.FlatGroupBox6.Size = New System.Drawing.Size(431, 105)
        Me.FlatGroupBox6.TabIndex = 20
        Me.FlatGroupBox6.Text = "Origin"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel11.Controls.Add(Me.txtCopyright)
        Me.Panel11.Location = New System.Drawing.Point(196, 70)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(210, 29)
        Me.Panel11.TabIndex = 11
        '
        'txtCopyright
        '
        Me.txtCopyright.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtCopyright.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCopyright.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtCopyright.ForeColor = System.Drawing.Color.Silver
        Me.txtCopyright.Location = New System.Drawing.Point(13, 6)
        Me.txtCopyright.Name = "txtCopyright"
        Me.txtCopyright.Size = New System.Drawing.Size(185, 18)
        Me.txtCopyright.TabIndex = 11
        Me.txtCopyright.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel10.Controls.Add(Me.txtPublisher)
        Me.Panel10.Location = New System.Drawing.Point(196, 35)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(210, 29)
        Me.Panel10.TabIndex = 10
        '
        'txtPublisher
        '
        Me.txtPublisher.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtPublisher.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPublisher.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPublisher.ForeColor = System.Drawing.Color.Silver
        Me.txtPublisher.Location = New System.Drawing.Point(13, 6)
        Me.txtPublisher.Name = "txtPublisher"
        Me.txtPublisher.Size = New System.Drawing.Size(185, 18)
        Me.txtPublisher.TabIndex = 10
        Me.txtPublisher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(35, 82)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(65, 17)
        Me.Label23.TabIndex = 4
        Me.Label23.Text = "Copyright"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(35, 47)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(61, 17)
        Me.Label26.TabIndex = 2
        Me.Label26.Text = "Publisher"
        '
        'FlatGroupBox7
        '
        Me.FlatGroupBox7.AutoScroll = True
        Me.FlatGroupBox7.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox7.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatGroupBox7.Controls.Add(Me.Panel9)
        Me.FlatGroupBox7.Controls.Add(Me.Panel8)
        Me.FlatGroupBox7.Controls.Add(Me.Panel7)
        Me.FlatGroupBox7.Controls.Add(Me.Panel6)
        Me.FlatGroupBox7.Controls.Add(Me.Panel5)
        Me.FlatGroupBox7.Controls.Add(Me.Panel4)
        Me.FlatGroupBox7.Controls.Add(Me.Panel3)
        Me.FlatGroupBox7.Controls.Add(Me.Label28)
        Me.FlatGroupBox7.Controls.Add(Me.Label30)
        Me.FlatGroupBox7.Controls.Add(Me.Label32)
        Me.FlatGroupBox7.Controls.Add(Me.Label34)
        Me.FlatGroupBox7.Controls.Add(Me.Label36)
        Me.FlatGroupBox7.Controls.Add(Me.Label38)
        Me.FlatGroupBox7.Controls.Add(Me.Label40)
        Me.FlatGroupBox7.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox7.Location = New System.Drawing.Point(8, 118)
        Me.FlatGroupBox7.Name = "FlatGroupBox7"
        Me.FlatGroupBox7.ShowText = True
        Me.FlatGroupBox7.Size = New System.Drawing.Size(431, 248)
        Me.FlatGroupBox7.TabIndex = 19
        Me.FlatGroupBox7.Text = "Media"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel9.Controls.Add(Me.txtGenre)
        Me.Panel9.Location = New System.Drawing.Point(196, 211)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(210, 29)
        Me.Panel9.TabIndex = 9
        '
        'txtGenre
        '
        Me.txtGenre.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtGenre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGenre.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtGenre.ForeColor = System.Drawing.Color.Silver
        Me.txtGenre.Location = New System.Drawing.Point(13, 6)
        Me.txtGenre.Name = "txtGenre"
        Me.txtGenre.Size = New System.Drawing.Size(185, 18)
        Me.txtGenre.TabIndex = 9
        Me.txtGenre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel8.Controls.Add(Me.txtTrackNumB)
        Me.Panel8.Location = New System.Drawing.Point(250, 176)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(33, 29)
        Me.Panel8.TabIndex = 8
        '
        'txtTrackNumB
        '
        Me.txtTrackNumB.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtTrackNumB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTrackNumB.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtTrackNumB.ForeColor = System.Drawing.Color.Silver
        Me.txtTrackNumB.Location = New System.Drawing.Point(9, 6)
        Me.txtTrackNumB.MaxLength = 2
        Me.txtTrackNumB.Name = "txtTrackNumB"
        Me.txtTrackNumB.Size = New System.Drawing.Size(16, 18)
        Me.txtTrackNumB.TabIndex = 8
        Me.txtTrackNumB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel7.Controls.Add(Me.txtTrackNumA)
        Me.Panel7.Location = New System.Drawing.Point(196, 176)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(33, 29)
        Me.Panel7.TabIndex = 7
        '
        'txtTrackNumA
        '
        Me.txtTrackNumA.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtTrackNumA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTrackNumA.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtTrackNumA.ForeColor = System.Drawing.Color.Silver
        Me.txtTrackNumA.Location = New System.Drawing.Point(9, 6)
        Me.txtTrackNumA.MaxLength = 2
        Me.txtTrackNumA.Name = "txtTrackNumA"
        Me.txtTrackNumA.Size = New System.Drawing.Size(16, 18)
        Me.txtTrackNumA.TabIndex = 7
        Me.txtTrackNumA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel6.Controls.Add(Me.txtYear)
        Me.Panel6.Location = New System.Drawing.Point(196, 140)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(89, 29)
        Me.Panel6.TabIndex = 6
        '
        'txtYear
        '
        Me.txtYear.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtYear.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtYear.ForeColor = System.Drawing.Color.Silver
        Me.txtYear.Location = New System.Drawing.Point(13, 6)
        Me.txtYear.MaxLength = 4
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(63, 18)
        Me.txtYear.TabIndex = 6
        Me.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel5.Controls.Add(Me.txtAlbum)
        Me.Panel5.Location = New System.Drawing.Point(196, 105)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(210, 29)
        Me.Panel5.TabIndex = 5
        '
        'txtAlbum
        '
        Me.txtAlbum.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtAlbum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAlbum.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtAlbum.ForeColor = System.Drawing.Color.Silver
        Me.txtAlbum.Location = New System.Drawing.Point(13, 6)
        Me.txtAlbum.Name = "txtAlbum"
        Me.txtAlbum.Size = New System.Drawing.Size(185, 18)
        Me.txtAlbum.TabIndex = 5
        Me.txtAlbum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel4.Controls.Add(Me.txtAlbumArtist)
        Me.Panel4.Location = New System.Drawing.Point(196, 70)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(210, 29)
        Me.Panel4.TabIndex = 4
        '
        'txtAlbumArtist
        '
        Me.txtAlbumArtist.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtAlbumArtist.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAlbumArtist.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtAlbumArtist.ForeColor = System.Drawing.Color.Silver
        Me.txtAlbumArtist.Location = New System.Drawing.Point(13, 6)
        Me.txtAlbumArtist.Name = "txtAlbumArtist"
        Me.txtAlbumArtist.Size = New System.Drawing.Size(185, 18)
        Me.txtAlbumArtist.TabIndex = 4
        Me.txtAlbumArtist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel3.Controls.Add(Me.txtArtist)
        Me.Panel3.Location = New System.Drawing.Point(196, 35)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(210, 29)
        Me.Panel3.TabIndex = 3
        '
        'txtArtist
        '
        Me.txtArtist.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtArtist.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtArtist.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtArtist.ForeColor = System.Drawing.Color.Silver
        Me.txtArtist.Location = New System.Drawing.Point(13, 6)
        Me.txtArtist.Name = "txtArtist"
        Me.txtArtist.Size = New System.Drawing.Size(185, 18)
        Me.txtArtist.TabIndex = 3
        Me.txtArtist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(35, 223)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(43, 17)
        Me.Label28.TabIndex = 14
        Me.Label28.Text = "Genre"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.White
        Me.Label30.Location = New System.Drawing.Point(233, 182)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(13, 17)
        Me.Label30.TabIndex = 12
        Me.Label30.Text = "/"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.White
        Me.Label32.Location = New System.Drawing.Point(35, 188)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(39, 17)
        Me.Label32.TabIndex = 10
        Me.Label32.Text = "Track"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.White
        Me.Label34.Location = New System.Drawing.Point(35, 152)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(34, 17)
        Me.Label34.TabIndex = 8
        Me.Label34.Text = "Year"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.Location = New System.Drawing.Point(35, 117)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(45, 17)
        Me.Label36.TabIndex = 6
        Me.Label36.Text = "Album"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.BackColor = System.Drawing.Color.Transparent
        Me.Label38.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.White
        Me.Label38.Location = New System.Drawing.Point(35, 82)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(79, 17)
        Me.Label38.TabIndex = 4
        Me.Label38.Text = "Album Artist"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.BackColor = System.Drawing.Color.Transparent
        Me.Label40.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.White
        Me.Label40.Location = New System.Drawing.Point(35, 47)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(128, 17)
        Me.Label40.TabIndex = 2
        Me.Label40.Text = "Contributing Artist(s)"
        '
        'FlatGroupBox8
        '
        Me.FlatGroupBox8.AutoScroll = True
        Me.FlatGroupBox8.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox8.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatGroupBox8.Controls.Add(Me.Panel2)
        Me.FlatGroupBox8.Controls.Add(Me.Panel1)
        Me.FlatGroupBox8.Controls.Add(Me.Label44)
        Me.FlatGroupBox8.Controls.Add(Me.Label46)
        Me.FlatGroupBox8.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox8.Location = New System.Drawing.Point(8, 6)
        Me.FlatGroupBox8.Name = "FlatGroupBox8"
        Me.FlatGroupBox8.ShowText = True
        Me.FlatGroupBox8.Size = New System.Drawing.Size(431, 106)
        Me.FlatGroupBox8.TabIndex = 18
        Me.FlatGroupBox8.Text = "Description"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtComment)
        Me.Panel2.Location = New System.Drawing.Point(196, 70)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(210, 29)
        Me.Panel2.TabIndex = 2
        '
        'txtComment
        '
        Me.txtComment.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtComment.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtComment.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtComment.ForeColor = System.Drawing.Color.Silver
        Me.txtComment.Location = New System.Drawing.Point(13, 6)
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(185, 18)
        Me.txtComment.TabIndex = 2
        Me.txtComment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtTitle)
        Me.Panel1.Location = New System.Drawing.Point(196, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(210, 29)
        Me.Panel1.TabIndex = 1
        '
        'txtTitle
        '
        Me.txtTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtTitle.ForeColor = System.Drawing.Color.Silver
        Me.txtTitle.Location = New System.Drawing.Point(13, 6)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(185, 18)
        Me.txtTitle.TabIndex = 1
        Me.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.BackColor = System.Drawing.Color.Transparent
        Me.Label44.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.White
        Me.Label44.Location = New System.Drawing.Point(35, 82)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(64, 17)
        Me.Label44.TabIndex = 4
        Me.Label44.Text = "Comment"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.BackColor = System.Drawing.Color.Transparent
        Me.Label46.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.White
        Me.Label46.Location = New System.Drawing.Point(35, 47)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(32, 17)
        Me.Label46.TabIndex = 2
        Me.Label46.Text = "Title"
        '
        'tabEditTrack
        '
        Me.tabEditTrack.AutoScroll = True
        Me.tabEditTrack.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.tabEditTrack.Controls.Add(Me.FlatGroupBox9)
        Me.tabEditTrack.Controls.Add(Me.FlatGroupBox10)
        Me.tabEditTrack.Controls.Add(Me.FlatGroupBox11)
        Me.tabEditTrack.Controls.Add(Me.FlatGroupBox12)
        Me.tabEditTrack.Controls.Add(Me.btnEditClearCover)
        Me.tabEditTrack.Controls.Add(Me.pictureEditCover)
        Me.tabEditTrack.Controls.Add(Me.Label47)
        Me.tabEditTrack.Controls.Add(Me.btnSave)
        Me.tabEditTrack.Location = New System.Drawing.Point(4, 44)
        Me.tabEditTrack.Name = "tabEditTrack"
        Me.tabEditTrack.Size = New System.Drawing.Size(714, 410)
        Me.tabEditTrack.TabIndex = 2
        Me.tabEditTrack.Text = "EDIT TRACK"
        '
        'FlatGroupBox9
        '
        Me.FlatGroupBox9.AutoScroll = True
        Me.FlatGroupBox9.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox9.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatGroupBox9.Controls.Add(Me.Panel15)
        Me.FlatGroupBox9.Controls.Add(Me.Panel16)
        Me.FlatGroupBox9.Controls.Add(Me.Label18)
        Me.FlatGroupBox9.Controls.Add(Me.Panel17)
        Me.FlatGroupBox9.Controls.Add(Me.Label21)
        Me.FlatGroupBox9.Controls.Add(Me.Label25)
        Me.FlatGroupBox9.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox9.Location = New System.Drawing.Point(8, 477)
        Me.FlatGroupBox9.Name = "FlatGroupBox9"
        Me.FlatGroupBox9.ShowText = True
        Me.FlatGroupBox9.Size = New System.Drawing.Size(431, 105)
        Me.FlatGroupBox9.TabIndex = 41
        Me.FlatGroupBox9.Text = "Content"
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel15.Controls.Add(Me.txtEditDiscNumB)
        Me.Panel15.Location = New System.Drawing.Point(250, 70)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(33, 29)
        Me.Panel15.TabIndex = 14
        '
        'txtEditDiscNumB
        '
        Me.txtEditDiscNumB.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtEditDiscNumB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEditDiscNumB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TracksBindingSource, "diskNumB", True))
        Me.txtEditDiscNumB.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtEditDiscNumB.ForeColor = System.Drawing.Color.Silver
        Me.txtEditDiscNumB.Location = New System.Drawing.Point(9, 6)
        Me.txtEditDiscNumB.MaxLength = 2
        Me.txtEditDiscNumB.Name = "txtEditDiscNumB"
        Me.txtEditDiscNumB.Size = New System.Drawing.Size(16, 18)
        Me.txtEditDiscNumB.TabIndex = 14
        Me.txtEditDiscNumB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel16.Controls.Add(Me.txtEditDiscNumA)
        Me.Panel16.Location = New System.Drawing.Point(196, 70)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(33, 29)
        Me.Panel16.TabIndex = 13
        '
        'txtEditDiscNumA
        '
        Me.txtEditDiscNumA.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtEditDiscNumA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEditDiscNumA.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TracksBindingSource, "discNumA", True))
        Me.txtEditDiscNumA.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtEditDiscNumA.ForeColor = System.Drawing.Color.Silver
        Me.txtEditDiscNumA.Location = New System.Drawing.Point(9, 6)
        Me.txtEditDiscNumA.MaxLength = 2
        Me.txtEditDiscNumA.Name = "txtEditDiscNumA"
        Me.txtEditDiscNumA.Size = New System.Drawing.Size(16, 18)
        Me.txtEditDiscNumA.TabIndex = 13
        Me.txtEditDiscNumA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(233, 76)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(13, 17)
        Me.Label18.TabIndex = 43
        Me.Label18.Text = "/"
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel17.Controls.Add(Me.txtEditComposer)
        Me.Panel17.Location = New System.Drawing.Point(196, 35)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(210, 29)
        Me.Panel17.TabIndex = 12
        '
        'txtEditComposer
        '
        Me.txtEditComposer.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtEditComposer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEditComposer.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TracksBindingSource, "composer", True))
        Me.txtEditComposer.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtEditComposer.ForeColor = System.Drawing.Color.Silver
        Me.txtEditComposer.Location = New System.Drawing.Point(13, 6)
        Me.txtEditComposer.Name = "txtEditComposer"
        Me.txtEditComposer.Size = New System.Drawing.Size(185, 18)
        Me.txtEditComposer.TabIndex = 12
        Me.txtEditComposer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(35, 47)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(69, 17)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "Composer"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(35, 82)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(69, 17)
        Me.Label25.TabIndex = 16
        Me.Label25.Text = "Part of Set"
        '
        'FlatGroupBox10
        '
        Me.FlatGroupBox10.AutoScroll = True
        Me.FlatGroupBox10.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox10.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatGroupBox10.Controls.Add(Me.Panel18)
        Me.FlatGroupBox10.Controls.Add(Me.Panel19)
        Me.FlatGroupBox10.Controls.Add(Me.Label27)
        Me.FlatGroupBox10.Controls.Add(Me.Label29)
        Me.FlatGroupBox10.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox10.Location = New System.Drawing.Point(8, 366)
        Me.FlatGroupBox10.Name = "FlatGroupBox10"
        Me.FlatGroupBox10.ShowText = True
        Me.FlatGroupBox10.Size = New System.Drawing.Size(431, 105)
        Me.FlatGroupBox10.TabIndex = 40
        Me.FlatGroupBox10.Text = "Origin"
        '
        'Panel18
        '
        Me.Panel18.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel18.Controls.Add(Me.txtEditCopyright)
        Me.Panel18.Location = New System.Drawing.Point(196, 70)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(210, 29)
        Me.Panel18.TabIndex = 11
        '
        'txtEditCopyright
        '
        Me.txtEditCopyright.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtEditCopyright.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEditCopyright.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TracksBindingSource, "copyright", True))
        Me.txtEditCopyright.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtEditCopyright.ForeColor = System.Drawing.Color.Silver
        Me.txtEditCopyright.Location = New System.Drawing.Point(13, 6)
        Me.txtEditCopyright.Name = "txtEditCopyright"
        Me.txtEditCopyright.Size = New System.Drawing.Size(185, 18)
        Me.txtEditCopyright.TabIndex = 11
        Me.txtEditCopyright.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel19
        '
        Me.Panel19.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel19.Controls.Add(Me.txtEditPublisher)
        Me.Panel19.Location = New System.Drawing.Point(196, 35)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(210, 29)
        Me.Panel19.TabIndex = 10
        '
        'txtEditPublisher
        '
        Me.txtEditPublisher.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtEditPublisher.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEditPublisher.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TracksBindingSource, "publisher", True))
        Me.txtEditPublisher.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtEditPublisher.ForeColor = System.Drawing.Color.Silver
        Me.txtEditPublisher.Location = New System.Drawing.Point(13, 6)
        Me.txtEditPublisher.Name = "txtEditPublisher"
        Me.txtEditPublisher.Size = New System.Drawing.Size(185, 18)
        Me.txtEditPublisher.TabIndex = 10
        Me.txtEditPublisher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(35, 82)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(65, 17)
        Me.Label27.TabIndex = 4
        Me.Label27.Text = "Copyright"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(35, 47)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(61, 17)
        Me.Label29.TabIndex = 2
        Me.Label29.Text = "Publisher"
        '
        'FlatGroupBox11
        '
        Me.FlatGroupBox11.AutoScroll = True
        Me.FlatGroupBox11.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox11.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatGroupBox11.Controls.Add(Me.Panel20)
        Me.FlatGroupBox11.Controls.Add(Me.Panel21)
        Me.FlatGroupBox11.Controls.Add(Me.Panel22)
        Me.FlatGroupBox11.Controls.Add(Me.Panel23)
        Me.FlatGroupBox11.Controls.Add(Me.Panel24)
        Me.FlatGroupBox11.Controls.Add(Me.Panel25)
        Me.FlatGroupBox11.Controls.Add(Me.Panel26)
        Me.FlatGroupBox11.Controls.Add(Me.Label31)
        Me.FlatGroupBox11.Controls.Add(Me.Label33)
        Me.FlatGroupBox11.Controls.Add(Me.Label35)
        Me.FlatGroupBox11.Controls.Add(Me.Label37)
        Me.FlatGroupBox11.Controls.Add(Me.Label39)
        Me.FlatGroupBox11.Controls.Add(Me.Label41)
        Me.FlatGroupBox11.Controls.Add(Me.Label42)
        Me.FlatGroupBox11.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox11.Location = New System.Drawing.Point(8, 118)
        Me.FlatGroupBox11.Name = "FlatGroupBox11"
        Me.FlatGroupBox11.ShowText = True
        Me.FlatGroupBox11.Size = New System.Drawing.Size(431, 248)
        Me.FlatGroupBox11.TabIndex = 39
        Me.FlatGroupBox11.Text = "Media"
        '
        'Panel20
        '
        Me.Panel20.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel20.Controls.Add(Me.txtEditGenre)
        Me.Panel20.Location = New System.Drawing.Point(196, 211)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(210, 29)
        Me.Panel20.TabIndex = 9
        '
        'txtEditGenre
        '
        Me.txtEditGenre.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtEditGenre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEditGenre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TracksBindingSource, "genre", True))
        Me.txtEditGenre.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtEditGenre.ForeColor = System.Drawing.Color.Silver
        Me.txtEditGenre.Location = New System.Drawing.Point(13, 6)
        Me.txtEditGenre.Name = "txtEditGenre"
        Me.txtEditGenre.Size = New System.Drawing.Size(185, 18)
        Me.txtEditGenre.TabIndex = 9
        Me.txtEditGenre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel21
        '
        Me.Panel21.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel21.Controls.Add(Me.txtEditTrackNumB)
        Me.Panel21.Location = New System.Drawing.Point(250, 176)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(33, 29)
        Me.Panel21.TabIndex = 8
        '
        'txtEditTrackNumB
        '
        Me.txtEditTrackNumB.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtEditTrackNumB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEditTrackNumB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TracksBindingSource, "trackNumB", True))
        Me.txtEditTrackNumB.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtEditTrackNumB.ForeColor = System.Drawing.Color.Silver
        Me.txtEditTrackNumB.Location = New System.Drawing.Point(9, 6)
        Me.txtEditTrackNumB.MaxLength = 2
        Me.txtEditTrackNumB.Name = "txtEditTrackNumB"
        Me.txtEditTrackNumB.Size = New System.Drawing.Size(16, 18)
        Me.txtEditTrackNumB.TabIndex = 8
        Me.txtEditTrackNumB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel22
        '
        Me.Panel22.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel22.Controls.Add(Me.txtEditTrackNumA)
        Me.Panel22.Location = New System.Drawing.Point(196, 176)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(33, 29)
        Me.Panel22.TabIndex = 7
        '
        'txtEditTrackNumA
        '
        Me.txtEditTrackNumA.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtEditTrackNumA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEditTrackNumA.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TracksBindingSource, "trackNumA", True))
        Me.txtEditTrackNumA.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtEditTrackNumA.ForeColor = System.Drawing.Color.Silver
        Me.txtEditTrackNumA.Location = New System.Drawing.Point(9, 6)
        Me.txtEditTrackNumA.MaxLength = 2
        Me.txtEditTrackNumA.Name = "txtEditTrackNumA"
        Me.txtEditTrackNumA.Size = New System.Drawing.Size(16, 18)
        Me.txtEditTrackNumA.TabIndex = 7
        Me.txtEditTrackNumA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel23
        '
        Me.Panel23.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel23.Controls.Add(Me.txtEditYear)
        Me.Panel23.Location = New System.Drawing.Point(196, 140)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(89, 29)
        Me.Panel23.TabIndex = 6
        '
        'txtEditYear
        '
        Me.txtEditYear.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtEditYear.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEditYear.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TracksBindingSource, "yearRelease", True))
        Me.txtEditYear.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtEditYear.ForeColor = System.Drawing.Color.Silver
        Me.txtEditYear.Location = New System.Drawing.Point(13, 6)
        Me.txtEditYear.MaxLength = 4
        Me.txtEditYear.Name = "txtEditYear"
        Me.txtEditYear.Size = New System.Drawing.Size(63, 18)
        Me.txtEditYear.TabIndex = 6
        Me.txtEditYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel24
        '
        Me.Panel24.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel24.Controls.Add(Me.txtEditAlbum)
        Me.Panel24.Location = New System.Drawing.Point(196, 105)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(210, 29)
        Me.Panel24.TabIndex = 5
        '
        'txtEditAlbum
        '
        Me.txtEditAlbum.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtEditAlbum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEditAlbum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TracksBindingSource, "album", True))
        Me.txtEditAlbum.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtEditAlbum.ForeColor = System.Drawing.Color.Silver
        Me.txtEditAlbum.Location = New System.Drawing.Point(13, 6)
        Me.txtEditAlbum.Name = "txtEditAlbum"
        Me.txtEditAlbum.Size = New System.Drawing.Size(185, 18)
        Me.txtEditAlbum.TabIndex = 5
        Me.txtEditAlbum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel25
        '
        Me.Panel25.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel25.Controls.Add(Me.txtEditAlbumArtist)
        Me.Panel25.Location = New System.Drawing.Point(196, 70)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(210, 29)
        Me.Panel25.TabIndex = 4
        '
        'txtEditAlbumArtist
        '
        Me.txtEditAlbumArtist.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtEditAlbumArtist.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEditAlbumArtist.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TracksBindingSource, "albumArtist", True))
        Me.txtEditAlbumArtist.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtEditAlbumArtist.ForeColor = System.Drawing.Color.Silver
        Me.txtEditAlbumArtist.Location = New System.Drawing.Point(13, 6)
        Me.txtEditAlbumArtist.Name = "txtEditAlbumArtist"
        Me.txtEditAlbumArtist.Size = New System.Drawing.Size(185, 18)
        Me.txtEditAlbumArtist.TabIndex = 4
        Me.txtEditAlbumArtist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel26
        '
        Me.Panel26.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel26.Controls.Add(Me.txtEditArtist)
        Me.Panel26.Location = New System.Drawing.Point(196, 35)
        Me.Panel26.Name = "Panel26"
        Me.Panel26.Size = New System.Drawing.Size(210, 29)
        Me.Panel26.TabIndex = 3
        '
        'txtEditArtist
        '
        Me.txtEditArtist.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtEditArtist.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEditArtist.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TracksBindingSource, "artist", True))
        Me.txtEditArtist.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtEditArtist.ForeColor = System.Drawing.Color.Silver
        Me.txtEditArtist.Location = New System.Drawing.Point(13, 6)
        Me.txtEditArtist.Name = "txtEditArtist"
        Me.txtEditArtist.Size = New System.Drawing.Size(185, 18)
        Me.txtEditArtist.TabIndex = 3
        Me.txtEditArtist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.White
        Me.Label31.Location = New System.Drawing.Point(35, 223)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(43, 17)
        Me.Label31.TabIndex = 14
        Me.Label31.Text = "Genre"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.White
        Me.Label33.Location = New System.Drawing.Point(233, 182)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(13, 17)
        Me.Label33.TabIndex = 12
        Me.Label33.Text = "/"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.White
        Me.Label35.Location = New System.Drawing.Point(35, 188)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(39, 17)
        Me.Label35.TabIndex = 10
        Me.Label35.Text = "Track"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.White
        Me.Label37.Location = New System.Drawing.Point(35, 152)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(34, 17)
        Me.Label37.TabIndex = 8
        Me.Label37.Text = "Year"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.BackColor = System.Drawing.Color.Transparent
        Me.Label39.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.White
        Me.Label39.Location = New System.Drawing.Point(35, 117)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(45, 17)
        Me.Label39.TabIndex = 6
        Me.Label39.Text = "Album"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.BackColor = System.Drawing.Color.Transparent
        Me.Label41.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.White
        Me.Label41.Location = New System.Drawing.Point(35, 82)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(79, 17)
        Me.Label41.TabIndex = 4
        Me.Label41.Text = "Album Artist"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.White
        Me.Label42.Location = New System.Drawing.Point(35, 47)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(128, 17)
        Me.Label42.TabIndex = 2
        Me.Label42.Text = "Contributing Artist(s)"
        '
        'FlatGroupBox12
        '
        Me.FlatGroupBox12.AutoScroll = True
        Me.FlatGroupBox12.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox12.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatGroupBox12.Controls.Add(Me.Panel27)
        Me.FlatGroupBox12.Controls.Add(Me.Panel28)
        Me.FlatGroupBox12.Controls.Add(Me.Label43)
        Me.FlatGroupBox12.Controls.Add(Me.Label45)
        Me.FlatGroupBox12.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox12.Location = New System.Drawing.Point(8, 6)
        Me.FlatGroupBox12.Name = "FlatGroupBox12"
        Me.FlatGroupBox12.ShowText = True
        Me.FlatGroupBox12.Size = New System.Drawing.Size(431, 106)
        Me.FlatGroupBox12.TabIndex = 38
        Me.FlatGroupBox12.Text = "Description"
        '
        'Panel27
        '
        Me.Panel27.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel27.Controls.Add(Me.txtEditComment)
        Me.Panel27.Location = New System.Drawing.Point(196, 70)
        Me.Panel27.Name = "Panel27"
        Me.Panel27.Size = New System.Drawing.Size(210, 29)
        Me.Panel27.TabIndex = 2
        '
        'txtEditComment
        '
        Me.txtEditComment.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtEditComment.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEditComment.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TracksBindingSource, "comment", True))
        Me.txtEditComment.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtEditComment.ForeColor = System.Drawing.Color.Silver
        Me.txtEditComment.Location = New System.Drawing.Point(13, 6)
        Me.txtEditComment.Name = "txtEditComment"
        Me.txtEditComment.Size = New System.Drawing.Size(185, 18)
        Me.txtEditComment.TabIndex = 2
        Me.txtEditComment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel28
        '
        Me.Panel28.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel28.Controls.Add(Me.txtEditTitle)
        Me.Panel28.Location = New System.Drawing.Point(196, 35)
        Me.Panel28.Name = "Panel28"
        Me.Panel28.Size = New System.Drawing.Size(210, 29)
        Me.Panel28.TabIndex = 1
        '
        'txtEditTitle
        '
        Me.txtEditTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtEditTitle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEditTitle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TracksBindingSource, "title", True))
        Me.txtEditTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtEditTitle.ForeColor = System.Drawing.Color.Silver
        Me.txtEditTitle.Location = New System.Drawing.Point(13, 6)
        Me.txtEditTitle.Name = "txtEditTitle"
        Me.txtEditTitle.Size = New System.Drawing.Size(185, 18)
        Me.txtEditTitle.TabIndex = 1
        Me.txtEditTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.BackColor = System.Drawing.Color.Transparent
        Me.Label43.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.White
        Me.Label43.Location = New System.Drawing.Point(35, 82)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(64, 17)
        Me.Label43.TabIndex = 4
        Me.Label43.Text = "Comment"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.BackColor = System.Drawing.Color.Transparent
        Me.Label45.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.White
        Me.Label45.Location = New System.Drawing.Point(35, 47)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(32, 17)
        Me.Label45.TabIndex = 2
        Me.Label45.Text = "Title"
        '
        'btnEditClearCover
        '
        Me.btnEditClearCover.BackColor = System.Drawing.Color.Transparent
        Me.btnEditClearCover.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnEditClearCover.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditClearCover.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnEditClearCover.Location = New System.Drawing.Point(604, 247)
        Me.btnEditClearCover.Name = "btnEditClearCover"
        Me.btnEditClearCover.Rounded = False
        Me.btnEditClearCover.Size = New System.Drawing.Size(75, 32)
        Me.btnEditClearCover.TabIndex = 37
        Me.btnEditClearCover.Text = "Clear"
        Me.btnEditClearCover.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnEditClearCover.Visible = False
        '
        'pictureEditCover
        '
        Me.pictureEditCover.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.pictureEditCover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureEditCover.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureEditCover.DataBindings.Add(New System.Windows.Forms.Binding("ImageLocation", Me.TracksBindingSource, "imagePath", True))
        Me.pictureEditCover.ImageLocation = ""
        Me.pictureEditCover.Location = New System.Drawing.Point(457, 19)
        Me.pictureEditCover.Name = "pictureEditCover"
        Me.pictureEditCover.Size = New System.Drawing.Size(222, 222)
        Me.pictureEditCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureEditCover.TabIndex = 34
        Me.pictureEditCover.TabStop = False
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Label47.Location = New System.Drawing.Point(470, 626)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(57, 19)
        Me.Label47.TabIndex = 33
        Me.Label47.Text = "Label47"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BaseColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnSave.Location = New System.Drawing.Point(285, 592)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Rounded = False
        Me.btnSave.Size = New System.Drawing.Size(129, 32)
        Me.btnSave.TabIndex = 31
        Me.btnSave.Text = "Save"
        Me.btnSave.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'tabUser
        '
        Me.tabUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.tabUser.Controls.Add(Me.btnAccountRecovery)
        Me.tabUser.Controls.Add(Me.btnLogOut)
        Me.tabUser.Controls.Add(Me.btnManageUsers)
        Me.tabUser.Controls.Add(Me.btnEditAccount)
        Me.tabUser.Controls.Add(Me.btnAddUser)
        Me.tabUser.Controls.Add(Me.btnBrowseUsers)
        Me.tabUser.Location = New System.Drawing.Point(4, 44)
        Me.tabUser.Name = "tabUser"
        Me.tabUser.Size = New System.Drawing.Size(714, 410)
        Me.tabUser.TabIndex = 3
        Me.tabUser.Text = "USER"
        '
        'btnAccountRecovery
        '
        Me.btnAccountRecovery.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnAccountRecovery.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnAccountRecovery.FlatAppearance.BorderSize = 0
        Me.btnAccountRecovery.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnAccountRecovery.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral
        Me.btnAccountRecovery.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccountRecovery.Font = New System.Drawing.Font("Segoe UI Light", 11.0!)
        Me.btnAccountRecovery.ForeColor = System.Drawing.Color.White
        Me.btnAccountRecovery.Image = Global.musicLibraryManager.My.Resources.Resources.icn_settings
        Me.btnAccountRecovery.Location = New System.Drawing.Point(252, 216)
        Me.btnAccountRecovery.Name = "btnAccountRecovery"
        Me.btnAccountRecovery.Size = New System.Drawing.Size(210, 185)
        Me.btnAccountRecovery.TabIndex = 6
        Me.btnAccountRecovery.Text = "ACCOUNT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "RECOVERY"
        Me.btnAccountRecovery.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnAccountRecovery.UseVisualStyleBackColor = False
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnLogOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Segoe UI Light", 11.0!)
        Me.btnLogOut.ForeColor = System.Drawing.Color.White
        Me.btnLogOut.Image = Global.musicLibraryManager.My.Resources.Resources.icn_logout
        Me.btnLogOut.Location = New System.Drawing.Point(482, 216)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(210, 185)
        Me.btnLogOut.TabIndex = 5
        Me.btnLogOut.Text = "LOG OUT"
        Me.btnLogOut.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'btnManageUsers
        '
        Me.btnManageUsers.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnManageUsers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnManageUsers.FlatAppearance.BorderSize = 0
        Me.btnManageUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnManageUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral
        Me.btnManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManageUsers.Font = New System.Drawing.Font("Segoe UI Light", 11.0!)
        Me.btnManageUsers.ForeColor = System.Drawing.Color.White
        Me.btnManageUsers.Image = Global.musicLibraryManager.My.Resources.Resources.icn_manage
        Me.btnManageUsers.Location = New System.Drawing.Point(21, 216)
        Me.btnManageUsers.Name = "btnManageUsers"
        Me.btnManageUsers.Size = New System.Drawing.Size(210, 185)
        Me.btnManageUsers.TabIndex = 3
        Me.btnManageUsers.Text = "MANAGE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "OTHER ACCOUNTS"
        Me.btnManageUsers.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnManageUsers.UseVisualStyleBackColor = False
        '
        'btnEditAccount
        '
        Me.btnEditAccount.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnEditAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnEditAccount.FlatAppearance.BorderSize = 0
        Me.btnEditAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnEditAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral
        Me.btnEditAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditAccount.Font = New System.Drawing.Font("Segoe UI Light", 11.0!)
        Me.btnEditAccount.ForeColor = System.Drawing.Color.White
        Me.btnEditAccount.Image = Global.musicLibraryManager.My.Resources.Resources.icn_edit
        Me.btnEditAccount.Location = New System.Drawing.Point(482, 12)
        Me.btnEditAccount.Name = "btnEditAccount"
        Me.btnEditAccount.Size = New System.Drawing.Size(210, 185)
        Me.btnEditAccount.TabIndex = 2
        Me.btnEditAccount.Text = "EDIT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ACCOUNT"
        Me.btnEditAccount.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnEditAccount.UseVisualStyleBackColor = False
        '
        'btnAddUser
        '
        Me.btnAddUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnAddUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnAddUser.FlatAppearance.BorderSize = 0
        Me.btnAddUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnAddUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral
        Me.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddUser.Font = New System.Drawing.Font("Segoe UI Light", 11.0!)
        Me.btnAddUser.ForeColor = System.Drawing.Color.White
        Me.btnAddUser.Image = Global.musicLibraryManager.My.Resources.Resources.icn_add
        Me.btnAddUser.Location = New System.Drawing.Point(252, 12)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(210, 185)
        Me.btnAddUser.TabIndex = 1
        Me.btnAddUser.Text = "ADD" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "USER"
        Me.btnAddUser.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnAddUser.UseVisualStyleBackColor = False
        '
        'btnBrowseUsers
        '
        Me.btnBrowseUsers.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnBrowseUsers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnBrowseUsers.FlatAppearance.BorderSize = 0
        Me.btnBrowseUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnBrowseUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral
        Me.btnBrowseUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowseUsers.Font = New System.Drawing.Font("Segoe UI Light", 11.0!)
        Me.btnBrowseUsers.ForeColor = System.Drawing.Color.White
        Me.btnBrowseUsers.Image = Global.musicLibraryManager.My.Resources.Resources.icn_browse
        Me.btnBrowseUsers.Location = New System.Drawing.Point(21, 12)
        Me.btnBrowseUsers.Name = "btnBrowseUsers"
        Me.btnBrowseUsers.Size = New System.Drawing.Size(210, 185)
        Me.btnBrowseUsers.TabIndex = 0
        Me.btnBrowseUsers.Text = "BROWSE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "USERS"
        Me.btnBrowseUsers.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnBrowseUsers.UseVisualStyleBackColor = False
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "users"
        Me.UsersBindingSource.DataSource = Me.MusicLibDataSet
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'timerClock
        '
        Me.timerClock.Enabled = True
        Me.timerClock.Interval = 1000
        '
        'formHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 509)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Music Library Manager"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        CType(Me.TracksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MusicLibDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelMain.ResumeLayout(False)
        Me.panelMain.PerformLayout()
        CType(Me.TracksBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TracksBindingNavigator.ResumeLayout(False)
        Me.TracksBindingNavigator.PerformLayout()
        Me.tabMain.ResumeLayout(False)
        Me.tabBrowse.ResumeLayout(False)
        Me.tabBrowse.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlatGroupBox4.ResumeLayout(False)
        Me.FlatGroupBox4.PerformLayout()
        Me.FlatGroupBox3.ResumeLayout(False)
        Me.FlatGroupBox3.PerformLayout()
        Me.FlatGroupBox2.ResumeLayout(False)
        Me.FlatGroupBox2.PerformLayout()
        Me.FlatGroupBox1.ResumeLayout(False)
        Me.FlatGroupBox1.PerformLayout()
        Me.tabAddTrack.ResumeLayout(False)
        Me.tabAddTrack.PerformLayout()
        CType(Me.pictureCover, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlatGroupBox5.ResumeLayout(False)
        Me.FlatGroupBox5.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.FlatGroupBox6.ResumeLayout(False)
        Me.FlatGroupBox6.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.FlatGroupBox7.ResumeLayout(False)
        Me.FlatGroupBox7.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.FlatGroupBox8.ResumeLayout(False)
        Me.FlatGroupBox8.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tabEditTrack.ResumeLayout(False)
        Me.tabEditTrack.PerformLayout()
        Me.FlatGroupBox9.ResumeLayout(False)
        Me.FlatGroupBox9.PerformLayout()
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        Me.Panel17.ResumeLayout(False)
        Me.Panel17.PerformLayout()
        Me.FlatGroupBox10.ResumeLayout(False)
        Me.FlatGroupBox10.PerformLayout()
        Me.Panel18.ResumeLayout(False)
        Me.Panel18.PerformLayout()
        Me.Panel19.ResumeLayout(False)
        Me.Panel19.PerformLayout()
        Me.FlatGroupBox11.ResumeLayout(False)
        Me.FlatGroupBox11.PerformLayout()
        Me.Panel20.ResumeLayout(False)
        Me.Panel20.PerformLayout()
        Me.Panel21.ResumeLayout(False)
        Me.Panel21.PerformLayout()
        Me.Panel22.ResumeLayout(False)
        Me.Panel22.PerformLayout()
        Me.Panel23.ResumeLayout(False)
        Me.Panel23.PerformLayout()
        Me.Panel24.ResumeLayout(False)
        Me.Panel24.PerformLayout()
        Me.Panel25.ResumeLayout(False)
        Me.Panel25.PerformLayout()
        Me.Panel26.ResumeLayout(False)
        Me.Panel26.PerformLayout()
        Me.FlatGroupBox12.ResumeLayout(False)
        Me.FlatGroupBox12.PerformLayout()
        Me.Panel27.ResumeLayout(False)
        Me.Panel27.PerformLayout()
        Me.Panel28.ResumeLayout(False)
        Me.Panel28.PerformLayout()
        CType(Me.pictureEditCover, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabUser.ResumeLayout(False)
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelMain As FormSkin
    Friend WithEvents tabMain As FlatTabControl
    Friend WithEvents tabBrowse As TabPage
    Friend WithEvents tabAddTrack As TabPage
    Friend WithEvents FlatGroupBox1 As FlatGroupBox
    Friend WithEvents tabEditTrack As TabPage
    Friend WithEvents tabUser As TabPage
    Friend WithEvents FlatGroupBox2 As FlatGroupBox
    Friend WithEvents lblAlbumArtist As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblArtist As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblComment As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblAlbum As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents FlatGroupBox4 As FlatGroupBox
    Friend WithEvents lblDiscNumB As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblComposer As Label
    Friend WithEvents lblDiscNumAA As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents FlatGroupBox3 As FlatGroupBox
    Friend WithEvents lblCopyright As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents lblPublisher As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents lblGenre As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblTrackNumB As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblTrackNumA As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents listTrack As ListBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TracksBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents TracksBindingSource As BindingSource
    Friend WithEvents MusicLibDataSet As musicLibDataSet
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TracksBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TracksTableAdapter As musicLibDataSetTableAdapters.tracksTableAdapter
    Friend WithEvents TableAdapterManager As musicLibDataSetTableAdapters.TableAdapterManager
    Friend WithEvents btnDelete As FlatButton
    Friend WithEvents FlatMini1 As FlatMini
    Friend WithEvents lblUserType As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents lblDateTime As Label
    Friend WithEvents FlatGroupBox5 As FlatGroupBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents FlatGroupBox6 As FlatGroupBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents FlatGroupBox7 As FlatGroupBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents FlatGroupBox8 As FlatGroupBox
    Friend WithEvents Label44 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents btnClear As FlatButton
    Friend WithEvents btnSubmit As FlatButton
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents btnSave As FlatButton
    Friend WithEvents Label47 As Label
    Friend WithEvents btnBrowseUsers As Button
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnManageUsers As Button
    Friend WithEvents btnEditAccount As Button
    Friend WithEvents btnAddUser As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents UsersTableAdapter As musicLibDataSetTableAdapters.usersTableAdapter
    Friend WithEvents timerClock As Timer
    Friend WithEvents pictureEditCover As PictureBox
    Friend WithEvents openFileCover As OpenFileDialog
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pictureCover As PictureBox
    Friend WithEvents btnClearCover As FlatButton
    Friend WithEvents btnEditClearCover As FlatButton
    Friend WithEvents txtSearch As FlatTextBox
    Friend WithEvents btnClearSearch As FlatButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents Panel13 As Panel
    Friend WithEvents txtDiscNumB As TextBox
    Friend WithEvents Panel14 As Panel
    Friend WithEvents txtDiscNumA As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents txtComposer As TextBox
    Friend WithEvents Panel11 As Panel
    Friend WithEvents txtCopyright As TextBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents txtPublisher As TextBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents txtTrackNumB As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txtTrackNumA As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txtYear As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtAlbum As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtAlbumArtist As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtArtist As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtComment As TextBox
    Friend WithEvents FlatGroupBox9 As FlatGroupBox
    Friend WithEvents Panel15 As Panel
    Friend WithEvents txtEditDiscNumB As TextBox
    Friend WithEvents Panel16 As Panel
    Friend WithEvents txtEditDiscNumA As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Panel17 As Panel
    Friend WithEvents txtEditComposer As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents FlatGroupBox10 As FlatGroupBox
    Friend WithEvents Panel18 As Panel
    Friend WithEvents txtEditCopyright As TextBox
    Friend WithEvents Panel19 As Panel
    Friend WithEvents txtEditPublisher As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents FlatGroupBox11 As FlatGroupBox
    Friend WithEvents Panel20 As Panel
    Friend WithEvents txtEditGenre As TextBox
    Friend WithEvents Panel21 As Panel
    Friend WithEvents txtEditTrackNumB As TextBox
    Friend WithEvents Panel22 As Panel
    Friend WithEvents txtEditTrackNumA As TextBox
    Friend WithEvents Panel23 As Panel
    Friend WithEvents txtEditYear As TextBox
    Friend WithEvents Panel24 As Panel
    Friend WithEvents txtEditAlbum As TextBox
    Friend WithEvents Panel25 As Panel
    Friend WithEvents txtEditAlbumArtist As TextBox
    Friend WithEvents Panel26 As Panel
    Friend WithEvents txtEditArtist As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents FlatGroupBox12 As FlatGroupBox
    Friend WithEvents Panel27 As Panel
    Friend WithEvents txtEditComment As TextBox
    Friend WithEvents Panel28 As Panel
    Friend WithEvents txtEditTitle As TextBox
    Friend WithEvents Label43 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents btnAccountRecovery As Button
End Class
