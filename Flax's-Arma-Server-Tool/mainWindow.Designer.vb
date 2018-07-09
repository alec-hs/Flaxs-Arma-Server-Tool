<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.steamDirDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.serverDirDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.toolsMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstallCMDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenSteamCMDDirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenA3DirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenModsLocationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CopyKeysFromModsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectedModsToClipboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.importSteamModsStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenProfileDirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.importModSet = New System.Windows.Forms.OpenFileDialog()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.modsTab = New System.Windows.Forms.TabPage()
        Me.checkingUpdatesBar = New System.Windows.Forms.ProgressBar()
        Me.checkUpdatesButton = New System.Windows.Forms.Button()
        Me.updateAllMods = New System.Windows.Forms.Button()
        Me.importModsGroup = New System.Windows.Forms.GroupBox()
        Me.privateModLabel = New System.Windows.Forms.Label()
        Me.privateModButton = New System.Windows.Forms.Button()
        Me.modLauncherLabel = New System.Windows.Forms.Label()
        Me.modLauncherButton = New System.Windows.Forms.Button()
        Me.modUrlLabel = New System.Windows.Forms.Label()
        Me.modUrlButton = New System.Windows.Forms.Button()
        Me.modsDataGrid = New System.Windows.Forms.DataGridView()
        Me.modID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.updateDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.installMod = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.urlButton = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.deleteButton = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.serverTab = New System.Windows.Forms.TabPage()
        Me.cancelUpdateButton = New System.Windows.Forms.Button()
        Me.steamProgressBar = New System.Windows.Forms.ProgressBar()
        Me.steamOutputBox = New System.Windows.Forms.RichTextBox()
        Me.lastUpdateGroup = New System.Windows.Forms.GroupBox()
        Me.infoUpdatedBox = New System.Windows.Forms.TextBox()
        Me.infoUpdatedLabel = New System.Windows.Forms.Label()
        Me.infoBranchBox = New System.Windows.Forms.TextBox()
        Me.infoBranchLabel = New System.Windows.Forms.Label()
        Me.serverInfoGroup = New System.Windows.Forms.GroupBox()
        Me.serverDirButton = New System.Windows.Forms.Button()
        Me.serverDirBox = New System.Windows.Forms.TextBox()
        Me.serverDirLabel = New System.Windows.Forms.Label()
        Me.branchCombo = New System.Windows.Forms.ComboBox()
        Me.branchLabel = New System.Windows.Forms.Label()
        Me.steamInfoGroup = New System.Windows.Forms.GroupBox()
        Me.showUserPassButton = New System.Windows.Forms.Button()
        Me.steamDirButton = New System.Windows.Forms.Button()
        Me.userPassBox = New System.Windows.Forms.TextBox()
        Me.userPassLabel = New System.Windows.Forms.Label()
        Me.userNameBox = New System.Windows.Forms.TextBox()
        Me.userNameLabel = New System.Windows.Forms.Label()
        Me.steamDirBox = New System.Windows.Forms.TextBox()
        Me.steamDirLabel = New System.Windows.Forms.Label()
        Me.updateServerButton = New System.Windows.Forms.Button()
        Me.categoryTabs = New System.Windows.Forms.TabControl()
        Me.NewSymlinkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolsMenuStrip.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.modsTab.SuspendLayout()
        Me.importModsGroup.SuspendLayout()
        CType(Me.modsDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.serverTab.SuspendLayout()
        Me.lastUpdateGroup.SuspendLayout()
        Me.serverInfoGroup.SuspendLayout()
        Me.steamInfoGroup.SuspendLayout()
        Me.categoryTabs.SuspendLayout()
        Me.SuspendLayout()
        '
        'toolsMenuStrip
        '
        Me.toolsMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolsMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.ServersToolStripMenuItem})
        Me.toolsMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.toolsMenuStrip.Name = "toolsMenuStrip"
        Me.toolsMenuStrip.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.toolsMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.toolsMenuStrip.Size = New System.Drawing.Size(943, 28)
        Me.toolsMenuStrip.TabIndex = 9
        Me.toolsMenuStrip.Text = "Menu"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.HelpToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(184, 26)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(184, 26)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(181, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(184, 26)
        Me.ExitToolStripMenuItem.Text = "Exit        Alt+F4"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InstallCMDToolStripMenuItem, Me.OpenSteamCMDDirToolStripMenuItem, Me.ToolStripSeparator2, Me.OpenA3DirectoryToolStripMenuItem, Me.OpenModsLocationToolStripMenuItem, Me.ToolStripSeparator3, Me.CopyKeysFromModsToolStripMenuItem, Me.SelectedModsToClipboardToolStripMenuItem, Me.importSteamModsStripMenuItem, Me.NewSymlinkToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(56, 24)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'InstallCMDToolStripMenuItem
        '
        Me.InstallCMDToolStripMenuItem.Name = "InstallCMDToolStripMenuItem"
        Me.InstallCMDToolStripMenuItem.Size = New System.Drawing.Size(271, 26)
        Me.InstallCMDToolStripMenuItem.Text = "Install SteamCMD"
        '
        'OpenSteamCMDDirToolStripMenuItem
        '
        Me.OpenSteamCMDDirToolStripMenuItem.Name = "OpenSteamCMDDirToolStripMenuItem"
        Me.OpenSteamCMDDirToolStripMenuItem.Size = New System.Drawing.Size(271, 26)
        Me.OpenSteamCMDDirToolStripMenuItem.Text = "Open SteamCMD Location"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(268, 6)
        '
        'OpenA3DirectoryToolStripMenuItem
        '
        Me.OpenA3DirectoryToolStripMenuItem.Name = "OpenA3DirectoryToolStripMenuItem"
        Me.OpenA3DirectoryToolStripMenuItem.Size = New System.Drawing.Size(271, 26)
        Me.OpenA3DirectoryToolStripMenuItem.Text = "Open Arma 3 Location"
        '
        'OpenModsLocationToolStripMenuItem
        '
        Me.OpenModsLocationToolStripMenuItem.Name = "OpenModsLocationToolStripMenuItem"
        Me.OpenModsLocationToolStripMenuItem.Size = New System.Drawing.Size(271, 26)
        Me.OpenModsLocationToolStripMenuItem.Text = "Open Mods Location"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(268, 6)
        '
        'CopyKeysFromModsToolStripMenuItem
        '
        Me.CopyKeysFromModsToolStripMenuItem.Name = "CopyKeysFromModsToolStripMenuItem"
        Me.CopyKeysFromModsToolStripMenuItem.Size = New System.Drawing.Size(271, 26)
        Me.CopyKeysFromModsToolStripMenuItem.Text = "Copy Keys from Mods"
        '
        'SelectedModsToClipboardToolStripMenuItem
        '
        Me.SelectedModsToClipboardToolStripMenuItem.Name = "SelectedModsToClipboardToolStripMenuItem"
        Me.SelectedModsToClipboardToolStripMenuItem.Size = New System.Drawing.Size(271, 26)
        Me.SelectedModsToClipboardToolStripMenuItem.Text = "Selected Mods to Clipboard"
        '
        'importSteamModsStripMenuItem
        '
        Me.importSteamModsStripMenuItem.Name = "importSteamModsStripMenuItem"
        Me.importSteamModsStripMenuItem.Size = New System.Drawing.Size(271, 26)
        Me.importSteamModsStripMenuItem.Text = "Import Existing Steam Mods"
        '
        'ServersToolStripMenuItem
        '
        Me.ServersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewToolStripMenuItem, Me.OpenProfileDirectoryToolStripMenuItem})
        Me.ServersToolStripMenuItem.Name = "ServersToolStripMenuItem"
        Me.ServersToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
        Me.ServersToolStripMenuItem.Text = "Servers"
        '
        'AddNewToolStripMenuItem
        '
        Me.AddNewToolStripMenuItem.Name = "AddNewToolStripMenuItem"
        Me.AddNewToolStripMenuItem.Size = New System.Drawing.Size(232, 26)
        Me.AddNewToolStripMenuItem.Text = "Add New"
        '
        'OpenProfileDirectoryToolStripMenuItem
        '
        Me.OpenProfileDirectoryToolStripMenuItem.Name = "OpenProfileDirectoryToolStripMenuItem"
        Me.OpenProfileDirectoryToolStripMenuItem.Size = New System.Drawing.Size(232, 26)
        Me.OpenProfileDirectoryToolStripMenuItem.Text = "Open Profile Directory"
        '
        'importModSet
        '
        Me.importModSet.Filter = "*.html|"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Delete"
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.MinimumWidth = 45
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn1.Width = 45
        '
        'modsTab
        '
        Me.modsTab.Controls.Add(Me.checkingUpdatesBar)
        Me.modsTab.Controls.Add(Me.checkUpdatesButton)
        Me.modsTab.Controls.Add(Me.updateAllMods)
        Me.modsTab.Controls.Add(Me.importModsGroup)
        Me.modsTab.Controls.Add(Me.modsDataGrid)
        Me.modsTab.Location = New System.Drawing.Point(4, 28)
        Me.modsTab.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.modsTab.Name = "modsTab"
        Me.modsTab.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.modsTab.Size = New System.Drawing.Size(935, 411)
        Me.modsTab.TabIndex = 1
        Me.modsTab.Text = "Mods"
        Me.modsTab.UseVisualStyleBackColor = True
        '
        'checkingUpdatesBar
        '
        Me.checkingUpdatesBar.Location = New System.Drawing.Point(667, 47)
        Me.checkingUpdatesBar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkingUpdatesBar.Name = "checkingUpdatesBar"
        Me.checkingUpdatesBar.Size = New System.Drawing.Size(147, 14)
        Me.checkingUpdatesBar.Step = 1
        Me.checkingUpdatesBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.checkingUpdatesBar.TabIndex = 17
        '
        'checkUpdatesButton
        '
        Me.checkUpdatesButton.Location = New System.Drawing.Point(667, 11)
        Me.checkUpdatesButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkUpdatesButton.Name = "checkUpdatesButton"
        Me.checkUpdatesButton.Size = New System.Drawing.Size(147, 33)
        Me.checkUpdatesButton.TabIndex = 3
        Me.checkUpdatesButton.Text = "Check For Updates"
        Me.checkUpdatesButton.UseVisualStyleBackColor = True
        '
        'updateAllMods
        '
        Me.updateAllMods.Location = New System.Drawing.Point(821, 11)
        Me.updateAllMods.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.updateAllMods.Name = "updateAllMods"
        Me.updateAllMods.Size = New System.Drawing.Size(100, 49)
        Me.updateAllMods.TabIndex = 2
        Me.updateAllMods.Text = "Update All"
        Me.updateAllMods.UseVisualStyleBackColor = True
        '
        'importModsGroup
        '
        Me.importModsGroup.Controls.Add(Me.privateModLabel)
        Me.importModsGroup.Controls.Add(Me.privateModButton)
        Me.importModsGroup.Controls.Add(Me.modLauncherLabel)
        Me.importModsGroup.Controls.Add(Me.modLauncherButton)
        Me.importModsGroup.Controls.Add(Me.modUrlLabel)
        Me.importModsGroup.Controls.Add(Me.modUrlButton)
        Me.importModsGroup.Location = New System.Drawing.Point(8, 4)
        Me.importModsGroup.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.importModsGroup.Name = "importModsGroup"
        Me.importModsGroup.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.importModsGroup.Size = New System.Drawing.Size(613, 55)
        Me.importModsGroup.TabIndex = 1
        Me.importModsGroup.TabStop = False
        Me.importModsGroup.Text = "Import Mods"
        '
        'privateModLabel
        '
        Me.privateModLabel.AutoSize = True
        Me.privateModLabel.Location = New System.Drawing.Point(451, 25)
        Me.privateModLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.privateModLabel.Name = "privateModLabel"
        Me.privateModLabel.Size = New System.Drawing.Size(112, 17)
        Me.privateModLabel.TabIndex = 5
        Me.privateModLabel.Text = "Add Private Mod"
        '
        'privateModButton
        '
        Me.privateModButton.BackgroundImage = Global.FAST.My.Resources.Resources.Plus_Math_32px
        Me.privateModButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.privateModButton.Location = New System.Drawing.Point(573, 17)
        Me.privateModButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.privateModButton.Name = "privateModButton"
        Me.privateModButton.Size = New System.Drawing.Size(32, 30)
        Me.privateModButton.TabIndex = 4
        Me.privateModButton.UseVisualStyleBackColor = True
        '
        'modLauncherLabel
        '
        Me.modLauncherLabel.AutoSize = True
        Me.modLauncherLabel.Location = New System.Drawing.Point(208, 25)
        Me.modLauncherLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.modLauncherLabel.Name = "modLauncherLabel"
        Me.modLauncherLabel.Size = New System.Drawing.Size(168, 17)
        Me.modLauncherLabel.TabIndex = 3
        Me.modLauncherLabel.Text = "Import from BIS Launcher"
        '
        'modLauncherButton
        '
        Me.modLauncherButton.BackgroundImage = CType(resources.GetObject("modLauncherButton.BackgroundImage"), System.Drawing.Image)
        Me.modLauncherButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.modLauncherButton.Location = New System.Drawing.Point(385, 17)
        Me.modLauncherButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.modLauncherButton.Name = "modLauncherButton"
        Me.modLauncherButton.Size = New System.Drawing.Size(32, 30)
        Me.modLauncherButton.TabIndex = 2
        Me.modLauncherButton.UseVisualStyleBackColor = True
        '
        'modUrlLabel
        '
        Me.modUrlLabel.AutoSize = True
        Me.modUrlLabel.Location = New System.Drawing.Point(8, 25)
        Me.modUrlLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.modUrlLabel.Name = "modUrlLabel"
        Me.modUrlLabel.Size = New System.Drawing.Size(128, 17)
        Me.modUrlLabel.TabIndex = 1
        Me.modUrlLabel.Text = "Add Mod from URL"
        '
        'modUrlButton
        '
        Me.modUrlButton.BackgroundImage = Global.FAST.My.Resources.Resources.Plus_Math_32px
        Me.modUrlButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.modUrlButton.Location = New System.Drawing.Point(147, 17)
        Me.modUrlButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.modUrlButton.Name = "modUrlButton"
        Me.modUrlButton.Size = New System.Drawing.Size(32, 30)
        Me.modUrlButton.TabIndex = 0
        Me.modUrlButton.UseVisualStyleBackColor = True
        '
        'modsDataGrid
        '
        Me.modsDataGrid.AllowUserToAddRows = False
        Me.modsDataGrid.AllowUserToDeleteRows = False
        Me.modsDataGrid.AllowUserToResizeColumns = False
        Me.modsDataGrid.AllowUserToResizeRows = False
        Me.modsDataGrid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.modsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.modsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.modsDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.modID, Me.modName, Me.updateDate, Me.installMod, Me.urlButton, Me.deleteButton})
        Me.modsDataGrid.Location = New System.Drawing.Point(8, 66)
        Me.modsDataGrid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.modsDataGrid.Name = "modsDataGrid"
        Me.modsDataGrid.ReadOnly = True
        Me.modsDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.modsDataGrid.Size = New System.Drawing.Size(913, 334)
        Me.modsDataGrid.TabIndex = 0
        '
        'modID
        '
        Me.modID.HeaderText = "Mod ID"
        Me.modID.MaxInputLength = 12
        Me.modID.MinimumWidth = 110
        Me.modID.Name = "modID"
        Me.modID.ReadOnly = True
        Me.modID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.modID.Width = 110
        '
        'modName
        '
        Me.modName.HeaderText = "Name"
        Me.modName.MinimumWidth = 260
        Me.modName.Name = "modName"
        Me.modName.ReadOnly = True
        Me.modName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.modName.Width = 260
        '
        'updateDate
        '
        Me.updateDate.HeaderText = "Last Updated"
        Me.updateDate.MinimumWidth = 117
        Me.updateDate.Name = "updateDate"
        Me.updateDate.ReadOnly = True
        Me.updateDate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.updateDate.Width = 117
        '
        'installMod
        '
        Me.installMod.HeaderText = "Update"
        Me.installMod.MinimumWidth = 45
        Me.installMod.Name = "installMod"
        Me.installMod.ReadOnly = True
        Me.installMod.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.installMod.Text = ""
        Me.installMod.Width = 45
        '
        'urlButton
        '
        Me.urlButton.HeaderText = "Details"
        Me.urlButton.MinimumWidth = 45
        Me.urlButton.Name = "urlButton"
        Me.urlButton.ReadOnly = True
        Me.urlButton.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.urlButton.Text = ""
        Me.urlButton.Width = 45
        '
        'deleteButton
        '
        Me.deleteButton.HeaderText = "Delete"
        Me.deleteButton.MinimumWidth = 45
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.ReadOnly = True
        Me.deleteButton.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.deleteButton.Text = ""
        Me.deleteButton.Width = 45
        '
        'serverTab
        '
        Me.serverTab.Controls.Add(Me.cancelUpdateButton)
        Me.serverTab.Controls.Add(Me.steamProgressBar)
        Me.serverTab.Controls.Add(Me.steamOutputBox)
        Me.serverTab.Controls.Add(Me.lastUpdateGroup)
        Me.serverTab.Controls.Add(Me.serverInfoGroup)
        Me.serverTab.Controls.Add(Me.steamInfoGroup)
        Me.serverTab.Controls.Add(Me.updateServerButton)
        Me.serverTab.Location = New System.Drawing.Point(4, 28)
        Me.serverTab.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.serverTab.Name = "serverTab"
        Me.serverTab.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.serverTab.Size = New System.Drawing.Size(935, 411)
        Me.serverTab.TabIndex = 0
        Me.serverTab.Text = "Steam Updater"
        Me.serverTab.UseVisualStyleBackColor = True
        '
        'cancelUpdateButton
        '
        Me.cancelUpdateButton.Enabled = False
        Me.cancelUpdateButton.Location = New System.Drawing.Point(816, 362)
        Me.cancelUpdateButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cancelUpdateButton.Name = "cancelUpdateButton"
        Me.cancelUpdateButton.Size = New System.Drawing.Size(100, 28)
        Me.cancelUpdateButton.TabIndex = 17
        Me.cancelUpdateButton.Text = "Cancel"
        Me.cancelUpdateButton.UseVisualStyleBackColor = True
        '
        'steamProgressBar
        '
        Me.steamProgressBar.Location = New System.Drawing.Point(349, 362)
        Me.steamProgressBar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.steamProgressBar.Name = "steamProgressBar"
        Me.steamProgressBar.Size = New System.Drawing.Size(459, 28)
        Me.steamProgressBar.Step = 1
        Me.steamProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.steamProgressBar.TabIndex = 16
        '
        'steamOutputBox
        '
        Me.steamOutputBox.BackColor = System.Drawing.SystemColors.Window
        Me.steamOutputBox.ForeColor = System.Drawing.SystemColors.InfoText
        Me.steamOutputBox.Location = New System.Drawing.Point(349, 15)
        Me.steamOutputBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.steamOutputBox.Name = "steamOutputBox"
        Me.steamOutputBox.ReadOnly = True
        Me.steamOutputBox.Size = New System.Drawing.Size(565, 339)
        Me.steamOutputBox.TabIndex = 15
        Me.steamOutputBox.Text = ""
        '
        'lastUpdateGroup
        '
        Me.lastUpdateGroup.Controls.Add(Me.infoUpdatedBox)
        Me.lastUpdateGroup.Controls.Add(Me.infoUpdatedLabel)
        Me.lastUpdateGroup.Controls.Add(Me.infoBranchBox)
        Me.lastUpdateGroup.Controls.Add(Me.infoBranchLabel)
        Me.lastUpdateGroup.Location = New System.Drawing.Point(8, 256)
        Me.lastUpdateGroup.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lastUpdateGroup.Name = "lastUpdateGroup"
        Me.lastUpdateGroup.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lastUpdateGroup.Size = New System.Drawing.Size(333, 98)
        Me.lastUpdateGroup.TabIndex = 12
        Me.lastUpdateGroup.TabStop = False
        Me.lastUpdateGroup.Text = "Last Update Info"
        '
        'infoUpdatedBox
        '
        Me.infoUpdatedBox.Enabled = False
        Me.infoUpdatedBox.Location = New System.Drawing.Point(103, 55)
        Me.infoUpdatedBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.infoUpdatedBox.Name = "infoUpdatedBox"
        Me.infoUpdatedBox.Size = New System.Drawing.Size(200, 22)
        Me.infoUpdatedBox.TabIndex = 5
        Me.infoUpdatedBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'infoUpdatedLabel
        '
        Me.infoUpdatedLabel.AutoSize = True
        Me.infoUpdatedLabel.Location = New System.Drawing.Point(24, 59)
        Me.infoUpdatedLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.infoUpdatedLabel.Name = "infoUpdatedLabel"
        Me.infoUpdatedLabel.Size = New System.Drawing.Size(38, 17)
        Me.infoUpdatedLabel.TabIndex = 4
        Me.infoUpdatedLabel.Text = "Date"
        '
        'infoBranchBox
        '
        Me.infoBranchBox.Enabled = False
        Me.infoBranchBox.Location = New System.Drawing.Point(103, 23)
        Me.infoBranchBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.infoBranchBox.Name = "infoBranchBox"
        Me.infoBranchBox.Size = New System.Drawing.Size(200, 22)
        Me.infoBranchBox.TabIndex = 2
        Me.infoBranchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'infoBranchLabel
        '
        Me.infoBranchLabel.AutoSize = True
        Me.infoBranchLabel.Location = New System.Drawing.Point(24, 27)
        Me.infoBranchLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.infoBranchLabel.Name = "infoBranchLabel"
        Me.infoBranchLabel.Size = New System.Drawing.Size(53, 17)
        Me.infoBranchLabel.TabIndex = 0
        Me.infoBranchLabel.Text = "Branch"
        '
        'serverInfoGroup
        '
        Me.serverInfoGroup.Controls.Add(Me.serverDirButton)
        Me.serverInfoGroup.Controls.Add(Me.serverDirBox)
        Me.serverInfoGroup.Controls.Add(Me.serverDirLabel)
        Me.serverInfoGroup.Controls.Add(Me.branchCombo)
        Me.serverInfoGroup.Controls.Add(Me.branchLabel)
        Me.serverInfoGroup.Location = New System.Drawing.Point(8, 150)
        Me.serverInfoGroup.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.serverInfoGroup.Name = "serverInfoGroup"
        Me.serverInfoGroup.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.serverInfoGroup.Size = New System.Drawing.Size(333, 98)
        Me.serverInfoGroup.TabIndex = 11
        Me.serverInfoGroup.TabStop = False
        Me.serverInfoGroup.Text = "Arma Server Settings"
        '
        'serverDirButton
        '
        Me.serverDirButton.BackgroundImage = CType(resources.GetObject("serverDirButton.BackgroundImage"), System.Drawing.Image)
        Me.serverDirButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.serverDirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.serverDirButton.Location = New System.Drawing.Point(272, 63)
        Me.serverDirButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.serverDirButton.Name = "serverDirButton"
        Me.serverDirButton.Size = New System.Drawing.Size(32, 25)
        Me.serverDirButton.TabIndex = 9
        Me.serverDirButton.UseVisualStyleBackColor = True
        '
        'serverDirBox
        '
        Me.serverDirBox.Location = New System.Drawing.Point(103, 63)
        Me.serverDirBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.serverDirBox.Name = "serverDirBox"
        Me.serverDirBox.Size = New System.Drawing.Size(160, 22)
        Me.serverDirBox.TabIndex = 8
        '
        'serverDirLabel
        '
        Me.serverDirLabel.AutoSize = True
        Me.serverDirLabel.Location = New System.Drawing.Point(24, 66)
        Me.serverDirLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.serverDirLabel.Name = "serverDirLabel"
        Me.serverDirLabel.Size = New System.Drawing.Size(65, 17)
        Me.serverDirLabel.TabIndex = 7
        Me.serverDirLabel.Text = "Directory"
        '
        'branchCombo
        '
        Me.branchCombo.DisplayMember = "(none)"
        Me.branchCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.branchCombo.FormattingEnabled = True
        Me.branchCombo.Items.AddRange(New Object() {"Stable", "Development"})
        Me.branchCombo.Location = New System.Drawing.Point(103, 30)
        Me.branchCombo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.branchCombo.Name = "branchCombo"
        Me.branchCombo.Size = New System.Drawing.Size(200, 24)
        Me.branchCombo.TabIndex = 1
        '
        'branchLabel
        '
        Me.branchLabel.AutoSize = True
        Me.branchLabel.Location = New System.Drawing.Point(24, 33)
        Me.branchLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.branchLabel.Name = "branchLabel"
        Me.branchLabel.Size = New System.Drawing.Size(53, 17)
        Me.branchLabel.TabIndex = 0
        Me.branchLabel.Text = "Branch"
        '
        'steamInfoGroup
        '
        Me.steamInfoGroup.Controls.Add(Me.showUserPassButton)
        Me.steamInfoGroup.Controls.Add(Me.steamDirButton)
        Me.steamInfoGroup.Controls.Add(Me.userPassBox)
        Me.steamInfoGroup.Controls.Add(Me.userPassLabel)
        Me.steamInfoGroup.Controls.Add(Me.userNameBox)
        Me.steamInfoGroup.Controls.Add(Me.userNameLabel)
        Me.steamInfoGroup.Controls.Add(Me.steamDirBox)
        Me.steamInfoGroup.Controls.Add(Me.steamDirLabel)
        Me.steamInfoGroup.Location = New System.Drawing.Point(8, 7)
        Me.steamInfoGroup.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.steamInfoGroup.Name = "steamInfoGroup"
        Me.steamInfoGroup.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.steamInfoGroup.Size = New System.Drawing.Size(333, 135)
        Me.steamInfoGroup.TabIndex = 10
        Me.steamInfoGroup.TabStop = False
        Me.steamInfoGroup.Text = "SteamCMD Settings"
        '
        'showUserPassButton
        '
        Me.showUserPassButton.BackgroundImage = CType(resources.GetObject("showUserPassButton.BackgroundImage"), System.Drawing.Image)
        Me.showUserPassButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.showUserPassButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.showUserPassButton.Location = New System.Drawing.Point(272, 92)
        Me.showUserPassButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.showUserPassButton.Name = "showUserPassButton"
        Me.showUserPassButton.Size = New System.Drawing.Size(32, 25)
        Me.showUserPassButton.TabIndex = 7
        Me.showUserPassButton.UseVisualStyleBackColor = True
        '
        'steamDirButton
        '
        Me.steamDirButton.BackgroundImage = CType(resources.GetObject("steamDirButton.BackgroundImage"), System.Drawing.Image)
        Me.steamDirButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.steamDirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.steamDirButton.Location = New System.Drawing.Point(272, 27)
        Me.steamDirButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.steamDirButton.Name = "steamDirButton"
        Me.steamDirButton.Size = New System.Drawing.Size(32, 25)
        Me.steamDirButton.TabIndex = 6
        Me.steamDirButton.UseVisualStyleBackColor = True
        '
        'userPassBox
        '
        Me.userPassBox.Location = New System.Drawing.Point(103, 92)
        Me.userPassBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.userPassBox.Name = "userPassBox"
        Me.userPassBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.userPassBox.Size = New System.Drawing.Size(160, 22)
        Me.userPassBox.TabIndex = 5
        '
        'userPassLabel
        '
        Me.userPassLabel.AutoSize = True
        Me.userPassLabel.Location = New System.Drawing.Point(24, 96)
        Me.userPassLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.userPassLabel.Name = "userPassLabel"
        Me.userPassLabel.Size = New System.Drawing.Size(69, 17)
        Me.userPassLabel.TabIndex = 4
        Me.userPassLabel.Text = "Password"
        '
        'userNameBox
        '
        Me.userNameBox.Location = New System.Drawing.Point(103, 60)
        Me.userNameBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.userNameBox.Name = "userNameBox"
        Me.userNameBox.Size = New System.Drawing.Size(200, 22)
        Me.userNameBox.TabIndex = 3
        '
        'userNameLabel
        '
        Me.userNameLabel.AutoSize = True
        Me.userNameLabel.Location = New System.Drawing.Point(24, 64)
        Me.userNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.userNameLabel.Name = "userNameLabel"
        Me.userNameLabel.Size = New System.Drawing.Size(73, 17)
        Me.userNameLabel.TabIndex = 2
        Me.userNameLabel.Text = "Username"
        '
        'steamDirBox
        '
        Me.steamDirBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.steamDirBox.Location = New System.Drawing.Point(103, 27)
        Me.steamDirBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.steamDirBox.Name = "steamDirBox"
        Me.steamDirBox.Size = New System.Drawing.Size(160, 22)
        Me.steamDirBox.TabIndex = 1
        '
        'steamDirLabel
        '
        Me.steamDirLabel.AutoSize = True
        Me.steamDirLabel.Location = New System.Drawing.Point(24, 31)
        Me.steamDirLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.steamDirLabel.Name = "steamDirLabel"
        Me.steamDirLabel.Size = New System.Drawing.Size(65, 17)
        Me.steamDirLabel.TabIndex = 0
        Me.steamDirLabel.Text = "Directory"
        '
        'updateServerButton
        '
        Me.updateServerButton.Location = New System.Drawing.Point(8, 362)
        Me.updateServerButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.updateServerButton.Name = "updateServerButton"
        Me.updateServerButton.Size = New System.Drawing.Size(333, 28)
        Me.updateServerButton.TabIndex = 9
        Me.updateServerButton.Text = "Update"
        Me.updateServerButton.UseVisualStyleBackColor = True
        '
        'categoryTabs
        '
        Me.categoryTabs.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.categoryTabs.Controls.Add(Me.serverTab)
        Me.categoryTabs.Controls.Add(Me.modsTab)
        Me.categoryTabs.Dock = System.Windows.Forms.DockStyle.Top
        Me.categoryTabs.Location = New System.Drawing.Point(0, 28)
        Me.categoryTabs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.categoryTabs.Name = "categoryTabs"
        Me.categoryTabs.SelectedIndex = 0
        Me.categoryTabs.Size = New System.Drawing.Size(943, 443)
        Me.categoryTabs.TabIndex = 10
        '
        'NewSymlinkToolStripMenuItem
        '
        Me.NewSymlinkToolStripMenuItem.Name = "NewSymlinkToolStripMenuItem"
        Me.NewSymlinkToolStripMenuItem.Size = New System.Drawing.Size(271, 26)
        Me.NewSymlinkToolStripMenuItem.Text = "New Symlink"
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 476)
        Me.Controls.Add(Me.categoryTabs)
        Me.Controls.Add(Me.toolsMenuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Flax's Arma Server Tool"
        Me.toolsMenuStrip.ResumeLayout(False)
        Me.toolsMenuStrip.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.modsTab.ResumeLayout(False)
        Me.importModsGroup.ResumeLayout(False)
        Me.importModsGroup.PerformLayout()
        CType(Me.modsDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.serverTab.ResumeLayout(False)
        Me.lastUpdateGroup.ResumeLayout(False)
        Me.lastUpdateGroup.PerformLayout()
        Me.serverInfoGroup.ResumeLayout(False)
        Me.serverInfoGroup.PerformLayout()
        Me.steamInfoGroup.ResumeLayout(False)
        Me.steamInfoGroup.PerformLayout()
        Me.categoryTabs.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents steamDirDialog As FolderBrowserDialog
    Friend WithEvents serverDirDialog As FolderBrowserDialog
    Friend WithEvents toolsMenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InstallCMDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenA3DirectoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenSteamCMDDirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenModsLocationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents CopyKeysFromModsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents importModSet As OpenFileDialog
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents SelectedModsToClipboardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents modsTab As TabPage
    Friend WithEvents checkingUpdatesBar As ProgressBar
    Friend WithEvents checkUpdatesButton As Button
    Friend WithEvents updateAllMods As Button
    Friend WithEvents importModsGroup As GroupBox
    Friend WithEvents privateModLabel As Label
    Friend WithEvents privateModButton As Button
    Friend WithEvents modLauncherLabel As Label
    Friend WithEvents modLauncherButton As Button
    Friend WithEvents modUrlLabel As Label
    Friend WithEvents modUrlButton As Button
    Friend WithEvents modsDataGrid As DataGridView
    Friend WithEvents modID As DataGridViewTextBoxColumn
    Friend WithEvents modName As DataGridViewTextBoxColumn
    Friend WithEvents updateDate As DataGridViewTextBoxColumn
    Friend WithEvents installMod As DataGridViewButtonColumn
    Friend WithEvents urlButton As DataGridViewButtonColumn
    Friend WithEvents deleteButton As DataGridViewButtonColumn
    Friend WithEvents serverTab As TabPage
    Friend WithEvents cancelUpdateButton As Button
    Friend WithEvents steamProgressBar As ProgressBar
    Friend WithEvents steamOutputBox As RichTextBox
    Friend WithEvents lastUpdateGroup As GroupBox
    Friend WithEvents infoUpdatedBox As TextBox
    Friend WithEvents infoUpdatedLabel As Label
    Friend WithEvents infoBranchBox As TextBox
    Friend WithEvents infoBranchLabel As Label
    Friend WithEvents serverInfoGroup As GroupBox
    Friend WithEvents serverDirButton As Button
    Friend WithEvents serverDirBox As TextBox
    Friend WithEvents serverDirLabel As Label
    Friend WithEvents branchCombo As ComboBox
    Friend WithEvents branchLabel As Label
    Friend WithEvents steamInfoGroup As GroupBox
    Friend WithEvents showUserPassButton As Button
    Friend WithEvents steamDirButton As Button
    Friend WithEvents userPassBox As TextBox
    Friend WithEvents userPassLabel As Label
    Friend WithEvents userNameBox As TextBox
    Friend WithEvents userNameLabel As Label
    Friend WithEvents steamDirBox As TextBox
    Friend WithEvents steamDirLabel As Label
    Friend WithEvents updateServerButton As Button
    Friend WithEvents categoryTabs As TabControl
    Friend WithEvents OpenProfileDirectoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents importSteamModsStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewSymlinkToolStripMenuItem As ToolStripMenuItem
End Class
