<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formUserEdit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formUserEdit))
        Me.panelMain = New musicLibraryManager.FormSkin()
        Me.btnSave = New musicLibraryManager.FlatButton()
        Me.btnClose = New musicLibraryManager.FlatButton()
        Me.FlatGroupBox2 = New musicLibraryManager.FlatGroupBox()
        Me.txtEditPassword = New musicLibraryManager.FlatTextBox()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MusicLibDataSet = New musicLibraryManager.musicLibDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEditEmail = New musicLibraryManager.FlatTextBox()
        Me.txtEditContactNo = New musicLibraryManager.FlatTextBox()
        Me.txtEditLastName = New musicLibraryManager.FlatTextBox()
        Me.txtEditFirstName = New musicLibraryManager.FlatTextBox()
        Me.txtEditUsername = New musicLibraryManager.FlatTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.UsersTableAdapter = New musicLibraryManager.musicLibDataSetTableAdapters.usersTableAdapter()
        Me.TableAdapterManager = New musicLibraryManager.musicLibDataSetTableAdapters.TableAdapterManager()
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
        Me.panelMain.SuspendLayout()
        Me.FlatGroupBox2.SuspendLayout()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MusicLibDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UsersBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelMain
        '
        Me.panelMain.BackColor = System.Drawing.Color.White
        Me.panelMain.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.panelMain.BorderColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.panelMain.Controls.Add(Me.btnSave)
        Me.panelMain.Controls.Add(Me.btnClose)
        Me.panelMain.Controls.Add(Me.FlatGroupBox2)
        Me.panelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMain.FlatColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.panelMain.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.panelMain.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.panelMain.HeaderMaximize = False
        Me.panelMain.Location = New System.Drawing.Point(0, 0)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Padding = New System.Windows.Forms.Padding(0, 50, 1, 1)
        Me.panelMain.Size = New System.Drawing.Size(470, 397)
        Me.panelMain.TabIndex = 0
        Me.panelMain.Text = "Edit Account"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BaseColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnSave.Location = New System.Drawing.Point(343, 325)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Rounded = False
        Me.btnSave.Size = New System.Drawing.Size(75, 32)
        Me.btnSave.TabIndex = 27
        Me.btnSave.Text = "Save"
        Me.btnSave.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnClose.Location = New System.Drawing.Point(262, 325)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Rounded = False
        Me.btnClose.Size = New System.Drawing.Size(75, 32)
        Me.btnClose.TabIndex = 26
        Me.btnClose.Text = "Close"
        Me.btnClose.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatGroupBox2
        '
        Me.FlatGroupBox2.AutoScroll = True
        Me.FlatGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatGroupBox2.Controls.Add(Me.txtEditPassword)
        Me.FlatGroupBox2.Controls.Add(Me.Label1)
        Me.FlatGroupBox2.Controls.Add(Me.txtEditEmail)
        Me.FlatGroupBox2.Controls.Add(Me.txtEditContactNo)
        Me.FlatGroupBox2.Controls.Add(Me.txtEditLastName)
        Me.FlatGroupBox2.Controls.Add(Me.txtEditFirstName)
        Me.FlatGroupBox2.Controls.Add(Me.txtEditUsername)
        Me.FlatGroupBox2.Controls.Add(Me.Label10)
        Me.FlatGroupBox2.Controls.Add(Me.Label8)
        Me.FlatGroupBox2.Controls.Add(Me.Label5)
        Me.FlatGroupBox2.Controls.Add(Me.Label7)
        Me.FlatGroupBox2.Controls.Add(Me.Label6)
        Me.FlatGroupBox2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox2.Location = New System.Drawing.Point(12, 62)
        Me.FlatGroupBox2.Name = "FlatGroupBox2"
        Me.FlatGroupBox2.ShowText = True
        Me.FlatGroupBox2.Size = New System.Drawing.Size(424, 245)
        Me.FlatGroupBox2.TabIndex = 24
        Me.FlatGroupBox2.Text = "___________________"
        '
        'txtEditPassword
        '
        Me.txtEditPassword.BackColor = System.Drawing.Color.Transparent
        Me.txtEditPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "password", True))
        Me.txtEditPassword.Location = New System.Drawing.Point(196, 70)
        Me.txtEditPassword.MaxLength = 32767
        Me.txtEditPassword.Multiline = False
        Me.txtEditPassword.Name = "txtEditPassword"
        Me.txtEditPassword.ReadOnly = False
        Me.txtEditPassword.Size = New System.Drawing.Size(210, 29)
        Me.txtEditPassword.TabIndex = 2
        Me.txtEditPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtEditPassword.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEditPassword.UseSystemPasswordChar = True
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(35, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Password"
        '
        'txtEditEmail
        '
        Me.txtEditEmail.BackColor = System.Drawing.Color.Transparent
        Me.txtEditEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "email", True))
        Me.txtEditEmail.Location = New System.Drawing.Point(196, 211)
        Me.txtEditEmail.MaxLength = 32767
        Me.txtEditEmail.Multiline = False
        Me.txtEditEmail.Name = "txtEditEmail"
        Me.txtEditEmail.ReadOnly = False
        Me.txtEditEmail.Size = New System.Drawing.Size(210, 29)
        Me.txtEditEmail.TabIndex = 6
        Me.txtEditEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtEditEmail.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEditEmail.UseSystemPasswordChar = False
        '
        'txtEditContactNo
        '
        Me.txtEditContactNo.BackColor = System.Drawing.Color.Transparent
        Me.txtEditContactNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "contact_no", True))
        Me.txtEditContactNo.Location = New System.Drawing.Point(196, 176)
        Me.txtEditContactNo.MaxLength = 32767
        Me.txtEditContactNo.Multiline = False
        Me.txtEditContactNo.Name = "txtEditContactNo"
        Me.txtEditContactNo.ReadOnly = False
        Me.txtEditContactNo.Size = New System.Drawing.Size(210, 29)
        Me.txtEditContactNo.TabIndex = 5
        Me.txtEditContactNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtEditContactNo.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEditContactNo.UseSystemPasswordChar = False
        '
        'txtEditLastName
        '
        Me.txtEditLastName.BackColor = System.Drawing.Color.Transparent
        Me.txtEditLastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "last_name", True))
        Me.txtEditLastName.Location = New System.Drawing.Point(196, 140)
        Me.txtEditLastName.MaxLength = 32767
        Me.txtEditLastName.Multiline = False
        Me.txtEditLastName.Name = "txtEditLastName"
        Me.txtEditLastName.ReadOnly = False
        Me.txtEditLastName.Size = New System.Drawing.Size(210, 29)
        Me.txtEditLastName.TabIndex = 4
        Me.txtEditLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtEditLastName.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEditLastName.UseSystemPasswordChar = False
        '
        'txtEditFirstName
        '
        Me.txtEditFirstName.BackColor = System.Drawing.Color.Transparent
        Me.txtEditFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "first_name", True))
        Me.txtEditFirstName.Location = New System.Drawing.Point(196, 105)
        Me.txtEditFirstName.MaxLength = 32767
        Me.txtEditFirstName.Multiline = False
        Me.txtEditFirstName.Name = "txtEditFirstName"
        Me.txtEditFirstName.ReadOnly = False
        Me.txtEditFirstName.Size = New System.Drawing.Size(210, 29)
        Me.txtEditFirstName.TabIndex = 3
        Me.txtEditFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtEditFirstName.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEditFirstName.UseSystemPasswordChar = False
        '
        'txtEditUsername
        '
        Me.txtEditUsername.BackColor = System.Drawing.Color.Transparent
        Me.txtEditUsername.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "username", True))
        Me.txtEditUsername.Location = New System.Drawing.Point(196, 35)
        Me.txtEditUsername.MaxLength = 32767
        Me.txtEditUsername.Multiline = False
        Me.txtEditUsername.Name = "txtEditUsername"
        Me.txtEditUsername.ReadOnly = False
        Me.txtEditUsername.Size = New System.Drawing.Size(210, 29)
        Me.txtEditUsername.TabIndex = 1
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
        'UsersBindingNavigator
        '
        Me.UsersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.UsersBindingNavigator.BindingSource = Me.UsersBindingSource
        Me.UsersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.UsersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.UsersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.UsersBindingNavigatorSaveItem})
        Me.UsersBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.UsersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.UsersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.UsersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.UsersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.UsersBindingNavigator.Name = "UsersBindingNavigator"
        Me.UsersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.UsersBindingNavigator.Size = New System.Drawing.Size(668, 25)
        Me.UsersBindingNavigator.TabIndex = 1
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
        'UsersBindingNavigatorSaveItem
        '
        Me.UsersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UsersBindingNavigatorSaveItem.Image = CType(resources.GetObject("UsersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.UsersBindingNavigatorSaveItem.Name = "UsersBindingNavigatorSaveItem"
        Me.UsersBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.UsersBindingNavigatorSaveItem.Text = "Save Data"
        '
        'formUserEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 397)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelMain)
        Me.Controls.Add(Me.UsersBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formUserEdit"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Account"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.panelMain.ResumeLayout(False)
        Me.FlatGroupBox2.ResumeLayout(False)
        Me.FlatGroupBox2.PerformLayout()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MusicLibDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UsersBindingNavigator.ResumeLayout(False)
        Me.UsersBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panelMain As FormSkin
    Friend WithEvents btnClose As FlatButton
    Friend WithEvents FlatGroupBox2 As FlatGroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents MusicLibDataSet As musicLibDataSet
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents UsersTableAdapter As musicLibDataSetTableAdapters.usersTableAdapter
    Friend WithEvents TableAdapterManager As musicLibDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UsersBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
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
    Friend WithEvents txtEditUsername As FlatTextBox
    Friend WithEvents btnSave As FlatButton
    Friend WithEvents txtEditEmail As FlatTextBox
    Friend WithEvents txtEditContactNo As FlatTextBox
    Friend WithEvents txtEditLastName As FlatTextBox
    Friend WithEvents txtEditFirstName As FlatTextBox
    Friend WithEvents txtEditPassword As FlatTextBox
    Friend WithEvents Label1 As Label
End Class
