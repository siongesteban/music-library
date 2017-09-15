<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formUserManage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formUserManage))
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MusicLibDataSet = New musicLibraryManager.musicLibDataSet()
        Me.UsersTableAdapter = New musicLibraryManager.musicLibDataSetTableAdapters.usersTableAdapter()
        Me.TableAdapterManager = New musicLibraryManager.musicLibDataSetTableAdapters.TableAdapterManager()
        Me.panelMain = New musicLibraryManager.FormSkin()
        Me.btnClearSearch = New musicLibraryManager.FlatButton()
        Me.txtSearch = New musicLibraryManager.FlatTextBox()
        Me.txtEditUserType = New System.Windows.Forms.Label()
        Me.btnDelete = New musicLibraryManager.FlatButton()
        Me.btnSave = New musicLibraryManager.FlatButton()
        Me.btnClose = New musicLibraryManager.FlatButton()
        Me.listUser = New System.Windows.Forms.ListBox()
        Me.FlatGroupBox2 = New musicLibraryManager.FlatGroupBox()
        Me.radStandard = New musicLibraryManager.FlatRadioButton()
        Me.radMaster = New musicLibraryManager.FlatRadioButton()
        Me.txtEmail = New musicLibraryManager.FlatTextBox()
        Me.txtContactNo = New musicLibraryManager.FlatTextBox()
        Me.txtLastName = New musicLibraryManager.FlatTextBox()
        Me.txtFirstName = New musicLibraryManager.FlatTextBox()
        Me.txtEditUsername = New musicLibraryManager.FlatTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.UsersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.UsersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MusicLibDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelMain.SuspendLayout()
        Me.FlatGroupBox2.SuspendLayout()
        CType(Me.UsersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UsersBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "users"
        Me.UsersBindingSource.DataSource = Me.MusicLibDataSet
        '
        'MusicLibDataSet
        '
        Me.MusicLibDataSet.DataSetName = "musicLibDataSet"
        Me.MusicLibDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tracksTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = musicLibraryManager.musicLibDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Me.UsersTableAdapter
        '
        'panelMain
        '
        Me.panelMain.BackColor = System.Drawing.Color.White
        Me.panelMain.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.panelMain.BorderColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.panelMain.Controls.Add(Me.btnClearSearch)
        Me.panelMain.Controls.Add(Me.txtSearch)
        Me.panelMain.Controls.Add(Me.txtEditUserType)
        Me.panelMain.Controls.Add(Me.btnDelete)
        Me.panelMain.Controls.Add(Me.btnSave)
        Me.panelMain.Controls.Add(Me.btnClose)
        Me.panelMain.Controls.Add(Me.listUser)
        Me.panelMain.Controls.Add(Me.FlatGroupBox2)
        Me.panelMain.Controls.Add(Me.UsersBindingNavigator)
        Me.panelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMain.FlatColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.panelMain.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.panelMain.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.panelMain.HeaderMaximize = False
        Me.panelMain.Location = New System.Drawing.Point(0, 0)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Padding = New System.Windows.Forms.Padding(0, 50, 1, 1)
        Me.panelMain.Size = New System.Drawing.Size(668, 389)
        Me.panelMain.TabIndex = 1
        Me.panelMain.Text = "Manage Users"
        '
        'btnClearSearch
        '
        Me.btnClearSearch.BackColor = System.Drawing.Color.Transparent
        Me.btnClearSearch.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnClearSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClearSearch.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearSearch.Location = New System.Drawing.Point(638, 360)
        Me.btnClearSearch.Name = "btnClearSearch"
        Me.btnClearSearch.Rounded = False
        Me.btnClearSearch.Size = New System.Drawing.Size(29, 29)
        Me.btnClearSearch.TabIndex = 44
        Me.btnClearSearch.Text = "x"
        Me.btnClearSearch.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.Transparent
        Me.txtSearch.Location = New System.Drawing.Point(456, 360)
        Me.txtSearch.MaxLength = 32767
        Me.txtSearch.Multiline = False
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.ReadOnly = False
        Me.txtSearch.Size = New System.Drawing.Size(183, 29)
        Me.txtSearch.TabIndex = 43
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtSearch.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSearch.UseSystemPasswordChar = False
        '
        'txtEditUserType
        '
        Me.txtEditUserType.AutoSize = True
        Me.txtEditUserType.BackColor = System.Drawing.Color.Transparent
        Me.txtEditUserType.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "user_type", True))
        Me.txtEditUserType.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditUserType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.txtEditUserType.Location = New System.Drawing.Point(47, 326)
        Me.txtEditUserType.Name = "txtEditUserType"
        Me.txtEditUserType.Size = New System.Drawing.Size(39, 17)
        Me.txtEditUserType.TabIndex = 42
        Me.txtEditUserType.Text = "Email"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.BaseColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnDelete.Location = New System.Drawing.Point(262, 326)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Rounded = False
        Me.btnDelete.Size = New System.Drawing.Size(75, 32)
        Me.btnDelete.TabIndex = 29
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BaseColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnSave.Location = New System.Drawing.Point(343, 326)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Rounded = False
        Me.btnSave.Size = New System.Drawing.Size(75, 32)
        Me.btnSave.TabIndex = 28
        Me.btnSave.Text = "Save"
        Me.btnSave.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnClose.Location = New System.Drawing.Point(208, 326)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Rounded = False
        Me.btnClose.Size = New System.Drawing.Size(48, 32)
        Me.btnClose.TabIndex = 23
        Me.btnClose.Text = "Close"
        Me.btnClose.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'listUser
        '
        Me.listUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.listUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listUser.DataSource = Me.UsersBindingSource
        Me.listUser.DisplayMember = "last_name"
        Me.listUser.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listUser.ForeColor = System.Drawing.Color.White
        Me.listUser.FormattingEnabled = True
        Me.listUser.ItemHeight = 30
        Me.listUser.Location = New System.Drawing.Point(456, 50)
        Me.listUser.Name = "listUser"
        Me.listUser.Size = New System.Drawing.Size(211, 300)
        Me.listUser.TabIndex = 19
        Me.listUser.ValueMember = "last_name"
        '
        'FlatGroupBox2
        '
        Me.FlatGroupBox2.AutoScroll = True
        Me.FlatGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatGroupBox2.Controls.Add(Me.radStandard)
        Me.FlatGroupBox2.Controls.Add(Me.radMaster)
        Me.FlatGroupBox2.Controls.Add(Me.txtEmail)
        Me.FlatGroupBox2.Controls.Add(Me.txtContactNo)
        Me.FlatGroupBox2.Controls.Add(Me.txtLastName)
        Me.FlatGroupBox2.Controls.Add(Me.txtFirstName)
        Me.FlatGroupBox2.Controls.Add(Me.txtEditUsername)
        Me.FlatGroupBox2.Controls.Add(Me.Label10)
        Me.FlatGroupBox2.Controls.Add(Me.Label8)
        Me.FlatGroupBox2.Controls.Add(Me.Label5)
        Me.FlatGroupBox2.Controls.Add(Me.Label7)
        Me.FlatGroupBox2.Controls.Add(Me.Label4)
        Me.FlatGroupBox2.Controls.Add(Me.Label6)
        Me.FlatGroupBox2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox2.Location = New System.Drawing.Point(12, 62)
        Me.FlatGroupBox2.Name = "FlatGroupBox2"
        Me.FlatGroupBox2.ShowText = True
        Me.FlatGroupBox2.Size = New System.Drawing.Size(424, 248)
        Me.FlatGroupBox2.TabIndex = 7
        Me.FlatGroupBox2.Text = "___________________"
        '
        'radStandard
        '
        Me.radStandard.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.radStandard.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.radStandard.BorderColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.radStandard.Checked = True
        Me.radStandard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radStandard.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.radStandard.Location = New System.Drawing.Point(269, 77)
        Me.radStandard.Name = "radStandard"
        Me.radStandard.Options = musicLibraryManager.FlatRadioButton._Options.Style1
        Me.radStandard.Size = New System.Drawing.Size(80, 22)
        Me.radStandard.TabIndex = 41
        Me.radStandard.Text = "Standard"
        '
        'radMaster
        '
        Me.radMaster.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.radMaster.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.radMaster.BorderColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.radMaster.Checked = False
        Me.radMaster.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radMaster.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.radMaster.Location = New System.Drawing.Point(196, 77)
        Me.radMaster.Name = "radMaster"
        Me.radMaster.Options = musicLibraryManager.FlatRadioButton._Options.Style1
        Me.radMaster.Size = New System.Drawing.Size(67, 22)
        Me.radMaster.TabIndex = 40
        Me.radMaster.Text = "Master"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.Transparent
        Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "email", True))
        Me.txtEmail.Location = New System.Drawing.Point(196, 211)
        Me.txtEmail.MaxLength = 32767
        Me.txtEmail.Multiline = False
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(210, 29)
        Me.txtEmail.TabIndex = 39
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtEmail.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEmail.UseSystemPasswordChar = False
        '
        'txtContactNo
        '
        Me.txtContactNo.BackColor = System.Drawing.Color.Transparent
        Me.txtContactNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "contact_no", True))
        Me.txtContactNo.Location = New System.Drawing.Point(196, 176)
        Me.txtContactNo.MaxLength = 32767
        Me.txtContactNo.Multiline = False
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.ReadOnly = True
        Me.txtContactNo.Size = New System.Drawing.Size(210, 29)
        Me.txtContactNo.TabIndex = 38
        Me.txtContactNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtContactNo.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtContactNo.UseSystemPasswordChar = False
        '
        'txtLastName
        '
        Me.txtLastName.BackColor = System.Drawing.Color.Transparent
        Me.txtLastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "last_name", True))
        Me.txtLastName.Location = New System.Drawing.Point(196, 140)
        Me.txtLastName.MaxLength = 32767
        Me.txtLastName.Multiline = False
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.ReadOnly = True
        Me.txtLastName.Size = New System.Drawing.Size(210, 29)
        Me.txtLastName.TabIndex = 37
        Me.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtLastName.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtLastName.UseSystemPasswordChar = False
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.Color.Transparent
        Me.txtFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "first_name", True))
        Me.txtFirstName.Location = New System.Drawing.Point(196, 105)
        Me.txtFirstName.MaxLength = 32767
        Me.txtFirstName.Multiline = False
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.ReadOnly = True
        Me.txtFirstName.Size = New System.Drawing.Size(210, 29)
        Me.txtFirstName.TabIndex = 36
        Me.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtFirstName.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFirstName.UseSystemPasswordChar = False
        '
        'txtEditUsername
        '
        Me.txtEditUsername.BackColor = System.Drawing.Color.Transparent
        Me.txtEditUsername.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "username", True))
        Me.txtEditUsername.Location = New System.Drawing.Point(196, 35)
        Me.txtEditUsername.MaxLength = 32767
        Me.txtEditUsername.Multiline = False
        Me.txtEditUsername.Name = "txtEditUsername"
        Me.txtEditUsername.ReadOnly = True
        Me.txtEditUsername.Size = New System.Drawing.Size(210, 29)
        Me.txtEditUsername.TabIndex = 17
        Me.txtEditUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtEditUsername.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEditUsername.UseSystemPasswordChar = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(35, 223)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 17)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Email"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(35, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 17)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Contact No."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(35, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Last Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(35, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "First Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(35, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Type"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(35, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Username"
        '
        'UsersBindingNavigator
        '
        Me.UsersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.UsersBindingNavigator.BindingSource = Me.UsersBindingSource
        Me.UsersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.UsersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.UsersBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.UsersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.UsersBindingNavigatorSaveItem})
        Me.UsersBindingNavigator.Location = New System.Drawing.Point(222, 0)
        Me.UsersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.UsersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.UsersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.UsersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.UsersBindingNavigator.Name = "UsersBindingNavigator"
        Me.UsersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.UsersBindingNavigator.Size = New System.Drawing.Size(203, 25)
        Me.UsersBindingNavigator.TabIndex = 24
        Me.UsersBindingNavigator.Text = "BindingNavigator1"
        Me.UsersBindingNavigator.Visible = False
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
        Me.BindingNavigatorDeleteItem.Visible = False
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
        Me.BindingNavigatorPositionItem.Visible = False
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
        'UsersBindingNavigatorSaveItem
        '
        Me.UsersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UsersBindingNavigatorSaveItem.Image = CType(resources.GetObject("UsersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.UsersBindingNavigatorSaveItem.Name = "UsersBindingNavigatorSaveItem"
        Me.UsersBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.UsersBindingNavigatorSaveItem.Text = "Save Data"
        '
        'formUserManage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 389)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formUserManage"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Users"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MusicLibDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelMain.ResumeLayout(False)
        Me.panelMain.PerformLayout()
        Me.FlatGroupBox2.ResumeLayout(False)
        Me.FlatGroupBox2.PerformLayout()
        CType(Me.UsersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UsersBindingNavigator.ResumeLayout(False)
        Me.UsersBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelMain As FormSkin
    Friend WithEvents UsersBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents UsersBindingSource As BindingSource
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
    Friend WithEvents UsersBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents btnClose As FlatButton
    Friend WithEvents listUser As ListBox
    Friend WithEvents FlatGroupBox2 As FlatGroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents UsersTableAdapter As musicLibDataSetTableAdapters.usersTableAdapter
    Friend WithEvents TableAdapterManager As musicLibDataSetTableAdapters.TableAdapterManager
    Friend WithEvents btnSave As FlatButton
    Friend WithEvents btnDelete As FlatButton
    Friend WithEvents txtEditUsername As FlatTextBox
    Friend WithEvents radStandard As FlatRadioButton
    Friend WithEvents radMaster As FlatRadioButton
    Friend WithEvents txtEmail As FlatTextBox
    Friend WithEvents txtContactNo As FlatTextBox
    Friend WithEvents txtLastName As FlatTextBox
    Friend WithEvents txtFirstName As FlatTextBox
    Friend WithEvents txtEditUserType As Label
    Friend WithEvents btnClearSearch As FlatButton
    Friend WithEvents txtSearch As FlatTextBox
End Class
