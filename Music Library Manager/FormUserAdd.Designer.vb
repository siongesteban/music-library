<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formUserAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formUserAdd))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MusicLibDataSet = New musicLibraryManager.musicLibDataSet()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.panelMain = New musicLibraryManager.FormSkin()
        Me.btnAdd = New musicLibraryManager.FlatButton()
        Me.btnClose = New musicLibraryManager.FlatButton()
        Me.FlatGroupBox2 = New musicLibraryManager.FlatGroupBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtContactNo = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Panel28 = New System.Windows.Forms.Panel()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.radStandard = New musicLibraryManager.FlatRadioButton()
        Me.radMaster = New musicLibraryManager.FlatRadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.MusicLibDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UsersBindingNavigator.SuspendLayout()
        Me.panelMain.SuspendLayout()
        Me.FlatGroupBox2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel28.SuspendLayout()
        Me.SuspendLayout()
        '
        'MusicLibDataSet
        '
        Me.MusicLibDataSet.DataSetName = "musicLibDataSet"
        Me.MusicLibDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.UsersBindingNavigator.Size = New System.Drawing.Size(470, 25)
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
        'panelMain
        '
        Me.panelMain.BackColor = System.Drawing.Color.White
        Me.panelMain.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.panelMain.BorderColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.panelMain.Controls.Add(Me.btnAdd)
        Me.panelMain.Controls.Add(Me.btnClose)
        Me.panelMain.Controls.Add(Me.FlatGroupBox2)
        Me.panelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMain.FlatColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.panelMain.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.panelMain.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.panelMain.HeaderMaximize = False
        Me.panelMain.Location = New System.Drawing.Point(0, 0)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(470, 427)
        Me.panelMain.TabIndex = 0
        Me.panelMain.Text = "Add User"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.BaseColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnAdd.Location = New System.Drawing.Point(345, 360)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Rounded = False
        Me.btnAdd.Size = New System.Drawing.Size(75, 32)
        Me.btnAdd.TabIndex = 30
        Me.btnAdd.Text = "Submit"
        Me.btnAdd.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnClose.Location = New System.Drawing.Point(264, 360)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Rounded = False
        Me.btnClose.Size = New System.Drawing.Size(75, 32)
        Me.btnClose.TabIndex = 29
        Me.btnClose.Text = "Close"
        Me.btnClose.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatGroupBox2
        '
        Me.FlatGroupBox2.AutoScroll = True
        Me.FlatGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatGroupBox2.Controls.Add(Me.Panel5)
        Me.FlatGroupBox2.Controls.Add(Me.Panel4)
        Me.FlatGroupBox2.Controls.Add(Me.Panel3)
        Me.FlatGroupBox2.Controls.Add(Me.Panel2)
        Me.FlatGroupBox2.Controls.Add(Me.Panel1)
        Me.FlatGroupBox2.Controls.Add(Me.Panel28)
        Me.FlatGroupBox2.Controls.Add(Me.radStandard)
        Me.FlatGroupBox2.Controls.Add(Me.radMaster)
        Me.FlatGroupBox2.Controls.Add(Me.Label2)
        Me.FlatGroupBox2.Controls.Add(Me.Label1)
        Me.FlatGroupBox2.Controls.Add(Me.Label10)
        Me.FlatGroupBox2.Controls.Add(Me.Label8)
        Me.FlatGroupBox2.Controls.Add(Me.Label5)
        Me.FlatGroupBox2.Controls.Add(Me.Label7)
        Me.FlatGroupBox2.Controls.Add(Me.Label6)
        Me.FlatGroupBox2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox2.Location = New System.Drawing.Point(12, 62)
        Me.FlatGroupBox2.Name = "FlatGroupBox2"
        Me.FlatGroupBox2.ShowText = True
        Me.FlatGroupBox2.Size = New System.Drawing.Size(445, 346)
        Me.FlatGroupBox2.TabIndex = 28
        Me.FlatGroupBox2.Text = "___________________"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel5.Controls.Add(Me.txtEmail)
        Me.Panel5.Location = New System.Drawing.Point(198, 246)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(210, 29)
        Me.Panel5.TabIndex = 6
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtEmail.ForeColor = System.Drawing.Color.Silver
        Me.txtEmail.Location = New System.Drawing.Point(13, 6)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(185, 18)
        Me.txtEmail.TabIndex = 6
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel4.Controls.Add(Me.txtContactNo)
        Me.Panel4.Location = New System.Drawing.Point(198, 211)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(210, 29)
        Me.Panel4.TabIndex = 5
        '
        'txtContactNo
        '
        Me.txtContactNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtContactNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContactNo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtContactNo.ForeColor = System.Drawing.Color.Silver
        Me.txtContactNo.Location = New System.Drawing.Point(13, 6)
        Me.txtContactNo.MaxLength = 11
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.Size = New System.Drawing.Size(185, 18)
        Me.txtContactNo.TabIndex = 5
        Me.txtContactNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel3.Controls.Add(Me.txtLastName)
        Me.Panel3.Location = New System.Drawing.Point(198, 175)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(210, 29)
        Me.Panel3.TabIndex = 4
        '
        'txtLastName
        '
        Me.txtLastName.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLastName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtLastName.ForeColor = System.Drawing.Color.Silver
        Me.txtLastName.Location = New System.Drawing.Point(13, 6)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(185, 18)
        Me.txtLastName.TabIndex = 4
        Me.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtFirstName)
        Me.Panel2.Location = New System.Drawing.Point(198, 140)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(210, 29)
        Me.Panel2.TabIndex = 3
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFirstName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtFirstName.ForeColor = System.Drawing.Color.Silver
        Me.txtFirstName.Location = New System.Drawing.Point(13, 6)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(185, 18)
        Me.txtFirstName.TabIndex = 3
        Me.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Location = New System.Drawing.Point(198, 70)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(210, 29)
        Me.Panel1.TabIndex = 2
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPassword.ForeColor = System.Drawing.Color.Silver
        Me.txtPassword.Location = New System.Drawing.Point(13, 6)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.ReadOnly = True
        Me.txtPassword.Size = New System.Drawing.Size(185, 18)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.Text = "Click to generate"
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel28
        '
        Me.Panel28.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel28.Controls.Add(Me.txtUsername)
        Me.Panel28.Location = New System.Drawing.Point(198, 35)
        Me.Panel28.Name = "Panel28"
        Me.Panel28.Size = New System.Drawing.Size(210, 29)
        Me.Panel28.TabIndex = 1
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtUsername.ForeColor = System.Drawing.Color.Silver
        Me.txtUsername.Location = New System.Drawing.Point(13, 6)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.ReadOnly = True
        Me.txtUsername.Size = New System.Drawing.Size(185, 18)
        Me.txtUsername.TabIndex = 1
        Me.txtUsername.Text = "Click to generate"
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'radStandard
        '
        Me.radStandard.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.radStandard.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.radStandard.BorderColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.radStandard.Checked = True
        Me.radStandard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radStandard.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.radStandard.Location = New System.Drawing.Point(271, 112)
        Me.radStandard.Name = "radStandard"
        Me.radStandard.Options = musicLibraryManager.FlatRadioButton._Options.Style1
        Me.radStandard.Size = New System.Drawing.Size(80, 22)
        Me.radStandard.TabIndex = 35
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
        Me.radMaster.Location = New System.Drawing.Point(198, 112)
        Me.radMaster.Name = "radMaster"
        Me.radMaster.Options = musicLibraryManager.FlatRadioButton._Options.Style1
        Me.radMaster.Size = New System.Drawing.Size(67, 22)
        Me.radMaster.TabIndex = 34
        Me.radMaster.Text = "Master"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(35, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 17)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Type"
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
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(37, 258)
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
        Me.Label8.Location = New System.Drawing.Point(37, 223)
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
        Me.Label5.Location = New System.Drawing.Point(37, 187)
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
        Me.Label7.Location = New System.Drawing.Point(37, 152)
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
        'formUserAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 427)
        Me.ControlBox = False
        Me.Controls.Add(Me.UsersBindingNavigator)
        Me.Controls.Add(Me.panelMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formUserAdd"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add User"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        CType(Me.MusicLibDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UsersBindingNavigator.ResumeLayout(False)
        Me.UsersBindingNavigator.PerformLayout()
        Me.panelMain.ResumeLayout(False)
        Me.FlatGroupBox2.ResumeLayout(False)
        Me.FlatGroupBox2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel28.ResumeLayout(False)
        Me.Panel28.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panelMain As FormSkin
    Friend WithEvents btnAdd As FlatButton
    Friend WithEvents btnClose As FlatButton
    Friend WithEvents FlatGroupBox2 As FlatGroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents radStandard As FlatRadioButton
    Friend WithEvents radMaster As FlatRadioButton
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
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtContactNo As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Panel28 As Panel
    Friend WithEvents txtUsername As TextBox
End Class
