<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formLogIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formLogIn))
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
        Me.radGuest = New musicLibraryManager.FlatRadioButton()
        Me.btnForgotPassword = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.FlatMini1 = New musicLibraryManager.FlatMini()
        Me.FlatClose1 = New musicLibraryManager.FlatClose()
        Me.radStandard = New musicLibraryManager.FlatRadioButton()
        Me.radMaster = New musicLibraryManager.FlatRadioButton()
        Me.btnLogIn = New musicLibraryManager.FlatButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.MusicLibDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UsersBindingNavigator.SuspendLayout()
        Me.panelMain.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        Me.UsersBindingNavigator.Size = New System.Drawing.Size(315, 25)
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
        Me.panelMain.Controls.Add(Me.radGuest)
        Me.panelMain.Controls.Add(Me.btnForgotPassword)
        Me.panelMain.Controls.Add(Me.Panel2)
        Me.panelMain.Controls.Add(Me.Panel1)
        Me.panelMain.Controls.Add(Me.FlatMini1)
        Me.panelMain.Controls.Add(Me.FlatClose1)
        Me.panelMain.Controls.Add(Me.radStandard)
        Me.panelMain.Controls.Add(Me.radMaster)
        Me.panelMain.Controls.Add(Me.btnLogIn)
        Me.panelMain.Controls.Add(Me.Label2)
        Me.panelMain.Controls.Add(Me.Label1)
        Me.panelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMain.FlatColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.panelMain.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.panelMain.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.panelMain.HeaderMaximize = False
        Me.panelMain.Location = New System.Drawing.Point(0, 0)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(306, 282)
        Me.panelMain.TabIndex = 0
        Me.panelMain.Text = "Log In"
        '
        'radGuest
        '
        Me.radGuest.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.radGuest.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.radGuest.BorderColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.radGuest.Checked = False
        Me.radGuest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radGuest.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.radGuest.Location = New System.Drawing.Point(101, 173)
        Me.radGuest.Name = "radGuest"
        Me.radGuest.Options = musicLibraryManager.FlatRadioButton._Options.Style1
        Me.radGuest.Size = New System.Drawing.Size(67, 22)
        Me.radGuest.TabIndex = 11
        Me.radGuest.Text = "Guest"
        '
        'btnForgotPassword
        '
        Me.btnForgotPassword.AutoSize = True
        Me.btnForgotPassword.BackColor = System.Drawing.Color.Transparent
        Me.btnForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnForgotPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnForgotPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnForgotPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnForgotPassword.Location = New System.Drawing.Point(97, 198)
        Me.btnForgotPassword.Name = "btnForgotPassword"
        Me.btnForgotPassword.Size = New System.Drawing.Size(118, 19)
        Me.btnForgotPassword.TabIndex = 10
        Me.btnForgotPassword.Text = "Forgot password?"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtPassword)
        Me.Panel2.Location = New System.Drawing.Point(101, 106)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(180, 29)
        Me.Panel2.TabIndex = 2
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPassword.ForeColor = System.Drawing.Color.Silver
        Me.txtPassword.Location = New System.Drawing.Point(13, 5)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(155, 18)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtUsername)
        Me.Panel1.Location = New System.Drawing.Point(101, 71)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(180, 29)
        Me.Panel1.TabIndex = 1
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtUsername.ForeColor = System.Drawing.Color.Silver
        Me.txtUsername.Location = New System.Drawing.Point(13, 6)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(155, 18)
        Me.txtUsername.TabIndex = 1
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FlatMini1
        '
        Me.FlatMini1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMini1.BackColor = System.Drawing.Color.White
        Me.FlatMini1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatMini1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMini1.Location = New System.Drawing.Point(252, 12)
        Me.FlatMini1.Name = "FlatMini1"
        Me.FlatMini1.Size = New System.Drawing.Size(18, 18)
        Me.FlatMini1.TabIndex = 9
        Me.FlatMini1.Text = "FlatMini1"
        Me.FlatMini1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(276, 12)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 8
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'radStandard
        '
        Me.radStandard.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.radStandard.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.radStandard.BorderColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.radStandard.Checked = True
        Me.radStandard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radStandard.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.radStandard.Location = New System.Drawing.Point(174, 145)
        Me.radStandard.Name = "radStandard"
        Me.radStandard.Options = musicLibraryManager.FlatRadioButton._Options.Style1
        Me.radStandard.Size = New System.Drawing.Size(80, 22)
        Me.radStandard.TabIndex = 4
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
        Me.radMaster.Location = New System.Drawing.Point(101, 145)
        Me.radMaster.Name = "radMaster"
        Me.radMaster.Options = musicLibraryManager.FlatRadioButton._Options.Style1
        Me.radMaster.Size = New System.Drawing.Size(67, 22)
        Me.radMaster.TabIndex = 3
        Me.radMaster.Text = "Master"
        '
        'btnLogIn
        '
        Me.btnLogIn.BackColor = System.Drawing.Color.Transparent
        Me.btnLogIn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogIn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnLogIn.Location = New System.Drawing.Point(101, 224)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Rounded = False
        Me.btnLogIn.Size = New System.Drawing.Size(180, 32)
        Me.btnLogIn.TabIndex = 5
        Me.btnLogIn.Text = "Log In"
        Me.btnLogIn.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(25, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(21, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username:"
        '
        'formLogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 282)
        Me.ControlBox = False
        Me.Controls.Add(Me.UsersBindingNavigator)
        Me.Controls.Add(Me.panelMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formLogIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log In"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        CType(Me.MusicLibDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UsersBindingNavigator.ResumeLayout(False)
        Me.UsersBindingNavigator.PerformLayout()
        Me.panelMain.ResumeLayout(False)
        Me.panelMain.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panelMain As FormSkin
    Friend WithEvents radStandard As FlatRadioButton
    Friend WithEvents radMaster As FlatRadioButton
    Friend WithEvents btnLogIn As FlatButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents FlatMini1 As FlatMini
    Friend WithEvents FlatClose1 As FlatClose
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
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnForgotPassword As Label
    Friend WithEvents radGuest As FlatRadioButton
End Class
