<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewServerTab
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewServerTab))
        Me.profileNameBox = New System.Windows.Forms.TextBox()
        Me.launchServer = New System.Windows.Forms.Button()
        Me.profileGroup = New System.Windows.Forms.GroupBox()
        Me.deleteProfileButton = New System.Windows.Forms.Button()
        Me.createBatButton = New System.Windows.Forms.Button()
        Me.saveProfileButton = New System.Windows.Forms.Button()
        Me.battleyeCheck = New System.Windows.Forms.CheckBox()
        Me.serverFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.modsTab = New System.Windows.Forms.TabPage()
        Me.refreshModsButton = New System.Windows.Forms.Button()
        Me.hcToServerButton = New System.Windows.Forms.Button()
        Me.serverToHCButton = New System.Windows.Forms.Button()
        Me.hcModsGroup = New System.Windows.Forms.GroupBox()
        Me.hcModsSortButton = New System.Windows.Forms.Button()
        Me.hcModsDownButton = New System.Windows.Forms.Button()
        Me.hcModsUpButton = New System.Windows.Forms.Button()
        Me.hcModsNoneButton = New System.Windows.Forms.Button()
        Me.hcModsAllButton = New System.Windows.Forms.Button()
        Me.hcModsList = New System.Windows.Forms.CheckedListBox()
        Me.serverModsGroup = New System.Windows.Forms.GroupBox()
        Me.serverModsSortButton = New System.Windows.Forms.Button()
        Me.serverModsDownButton = New System.Windows.Forms.Button()
        Me.serverModsUpButton = New System.Windows.Forms.Button()
        Me.serverModsNoneButton = New System.Windows.Forms.Button()
        Me.serverModsAllButton = New System.Windows.Forms.Button()
        Me.serverModsList = New System.Windows.Forms.CheckedListBox()
        Me.settingsTab = New System.Windows.Forms.TabPage()
        Me.networkGroup = New System.Windows.Forms.GroupBox()
        Me.netlogCheck = New System.Windows.Forms.CheckBox()
        Me.loopbackCheck = New System.Windows.Forms.CheckBox()
        Me.upnpCheck = New System.Windows.Forms.CheckBox()
        Me.headlessGroup = New System.Windows.Forms.GroupBox()
        Me.noOfHCNumeric = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.enableHCCheck = New System.Windows.Forms.CheckBox()
        Me.localClientBox = New System.Windows.Forms.TextBox()
        Me.headlessIPBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.HCIPLabel = New System.Windows.Forms.Label()
        Me.rulesGroup = New System.Windows.Forms.GroupBox()
        Me.settingsGroup = New System.Windows.Forms.GroupBox()
        Me.serverDirButton = New System.Windows.Forms.Button()
        Me.serverFileBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.serverNameBox = New System.Windows.Forms.TextBox()
        Me.portBox = New System.Windows.Forms.TextBox()
        Me.passwordLabel = New System.Windows.Forms.Label()
        Me.maxPlayersLabel = New System.Windows.Forms.Label()
        Me.passwordBox = New System.Windows.Forms.TextBox()
        Me.maxPlayersBox = New System.Windows.Forms.TextBox()
        Me.adminPassLabel = New System.Windows.Forms.Label()
        Me.portLabel = New System.Windows.Forms.Label()
        Me.adminPassBox = New System.Windows.Forms.TextBox()
        Me.serverTabs = New System.Windows.Forms.TabControl()
        Me.miscTab = New System.Windows.Forms.TabPage()
        Me.miscGroup = New System.Windows.Forms.GroupBox()
        Me.filePatchLabel = New System.Windows.Forms.Label()
        Me.filePatchCombo = New System.Windows.Forms.ComboBox()
        Me.verifySigLabel = New System.Windows.Forms.Label()
        Me.requiredBuildBox = New System.Windows.Forms.TextBox()
        Me.verifySigCombo = New System.Windows.Forms.ComboBox()
        Me.requiredBuildCheck = New System.Windows.Forms.CheckBox()
        Me.kickDupeCheck = New System.Windows.Forms.CheckBox()
        Me.modGroup = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.modTimeNumeric = New System.Windows.Forms.NumericUpDown()
        Me.modBox = New System.Windows.Forms.RichTextBox()
        Me.votingGroup = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.voteThresholdNumeric = New System.Windows.Forms.NumericUpDown()
        Me.minPlayersNumeric = New System.Windows.Forms.NumericUpDown()
        Me.voteCheck = New System.Windows.Forms.CheckBox()
        Me.vonGroup = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.codecNumeric = New System.Windows.Forms.NumericUpDown()
        Me.vonCheck = New System.Windows.Forms.CheckBox()
        Me.perfTab = New System.Windows.Forms.TabPage()
        Me.NumericUpDown9 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown8 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown7 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown6 = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox10 = New System.Windows.Forms.CheckBox()
        Me.CheckBox9 = New System.Windows.Forms.CheckBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.maxPingCheck = New System.Windows.Forms.CheckBox()
        Me.filePatchingCheck = New System.Windows.Forms.CheckBox()
        Me.htCheck = New System.Windows.Forms.CheckBox()
        Me.missionTab = New System.Windows.Forms.TabPage()
        Me.persistCheck = New System.Windows.Forms.CheckBox()
        Me.autoInitCheck = New System.Windows.Forms.CheckBox()
        Me.difficultyTab = New System.Windows.Forms.TabPage()
        Me.scriptingTab = New System.Windows.Forms.TabPage()
        Me.profileGroup.SuspendLayout()
        Me.modsTab.SuspendLayout()
        Me.hcModsGroup.SuspendLayout()
        Me.serverModsGroup.SuspendLayout()
        Me.settingsTab.SuspendLayout()
        Me.networkGroup.SuspendLayout()
        Me.headlessGroup.SuspendLayout()
        CType(Me.noOfHCNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.settingsGroup.SuspendLayout()
        Me.serverTabs.SuspendLayout()
        Me.miscTab.SuspendLayout()
        Me.miscGroup.SuspendLayout()
        Me.modGroup.SuspendLayout()
        CType(Me.modTimeNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.votingGroup.SuspendLayout()
        CType(Me.voteThresholdNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minPlayersNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.vonGroup.SuspendLayout()
        CType(Me.codecNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.perfTab.SuspendLayout()
        CType(Me.NumericUpDown9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.missionTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'profileNameBox
        '
        Me.profileNameBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.profileNameBox.Location = New System.Drawing.Point(6, 22)
        Me.profileNameBox.Name = "profileNameBox"
        Me.profileNameBox.Size = New System.Drawing.Size(146, 20)
        Me.profileNameBox.TabIndex = 16
        Me.profileNameBox.Text = "New Server"
        '
        'launchServer
        '
        Me.launchServer.Location = New System.Drawing.Point(612, 20)
        Me.launchServer.Name = "launchServer"
        Me.launchServer.Size = New System.Drawing.Size(75, 23)
        Me.launchServer.TabIndex = 20
        Me.launchServer.Text = "Launch"
        Me.launchServer.UseVisualStyleBackColor = True
        '
        'profileGroup
        '
        Me.profileGroup.Controls.Add(Me.deleteProfileButton)
        Me.profileGroup.Controls.Add(Me.createBatButton)
        Me.profileGroup.Controls.Add(Me.saveProfileButton)
        Me.profileGroup.Controls.Add(Me.profileNameBox)
        Me.profileGroup.Controls.Add(Me.launchServer)
        Me.profileGroup.Controls.Add(Me.battleyeCheck)
        Me.profileGroup.Location = New System.Drawing.Point(3, 273)
        Me.profileGroup.Name = "profileGroup"
        Me.profileGroup.Size = New System.Drawing.Size(693, 55)
        Me.profileGroup.TabIndex = 3
        Me.profileGroup.TabStop = False
        Me.profileGroup.Text = "Server Profile"
        '
        'deleteProfileButton
        '
        Me.deleteProfileButton.Location = New System.Drawing.Point(214, 20)
        Me.deleteProfileButton.Name = "deleteProfileButton"
        Me.deleteProfileButton.Size = New System.Drawing.Size(50, 23)
        Me.deleteProfileButton.TabIndex = 18
        Me.deleteProfileButton.Text = "Delete"
        Me.deleteProfileButton.UseVisualStyleBackColor = True
        '
        'createBatButton
        '
        Me.createBatButton.Location = New System.Drawing.Point(531, 20)
        Me.createBatButton.Name = "createBatButton"
        Me.createBatButton.Size = New System.Drawing.Size(75, 23)
        Me.createBatButton.TabIndex = 19
        Me.createBatButton.Text = "Export"
        Me.createBatButton.UseVisualStyleBackColor = True
        '
        'saveProfileButton
        '
        Me.saveProfileButton.Location = New System.Drawing.Point(158, 20)
        Me.saveProfileButton.Name = "saveProfileButton"
        Me.saveProfileButton.Size = New System.Drawing.Size(50, 23)
        Me.saveProfileButton.TabIndex = 17
        Me.saveProfileButton.Text = "Save"
        Me.saveProfileButton.UseVisualStyleBackColor = True
        '
        'battleyeCheck
        '
        Me.battleyeCheck.AutoSize = True
        Me.battleyeCheck.Location = New System.Drawing.Point(460, 24)
        Me.battleyeCheck.Name = "battleyeCheck"
        Me.battleyeCheck.Size = New System.Drawing.Size(65, 17)
        Me.battleyeCheck.TabIndex = 17
        Me.battleyeCheck.Text = "BattlEye"
        Me.battleyeCheck.UseVisualStyleBackColor = True
        '
        'serverFileDialog
        '
        Me.serverFileDialog.DefaultExt = "exe"
        Me.serverFileDialog.Filter = "Arma 3 Server Files|arma*.exe"
        '
        'modsTab
        '
        Me.modsTab.Controls.Add(Me.refreshModsButton)
        Me.modsTab.Controls.Add(Me.hcToServerButton)
        Me.modsTab.Controls.Add(Me.serverToHCButton)
        Me.modsTab.Controls.Add(Me.hcModsGroup)
        Me.modsTab.Controls.Add(Me.serverModsGroup)
        Me.modsTab.Location = New System.Drawing.Point(4, 22)
        Me.modsTab.Name = "modsTab"
        Me.modsTab.Padding = New System.Windows.Forms.Padding(3)
        Me.modsTab.Size = New System.Drawing.Size(691, 241)
        Me.modsTab.TabIndex = 1
        Me.modsTab.Text = "Mods"
        Me.modsTab.UseVisualStyleBackColor = True
        '
        'refreshModsButton
        '
        Me.refreshModsButton.Location = New System.Drawing.Point(334, 82)
        Me.refreshModsButton.Name = "refreshModsButton"
        Me.refreshModsButton.Size = New System.Drawing.Size(24, 23)
        Me.refreshModsButton.TabIndex = 4
        Me.refreshModsButton.Text = "" & Global.Microsoft.VisualBasic.ChrW(9) & "↻"
        Me.refreshModsButton.UseVisualStyleBackColor = True
        '
        'hcToServerButton
        '
        Me.hcToServerButton.Location = New System.Drawing.Point(334, 53)
        Me.hcToServerButton.Name = "hcToServerButton"
        Me.hcToServerButton.Size = New System.Drawing.Size(24, 23)
        Me.hcToServerButton.TabIndex = 3
        Me.hcToServerButton.Text = "<"
        Me.hcToServerButton.UseVisualStyleBackColor = True
        '
        'serverToHCButton
        '
        Me.serverToHCButton.Location = New System.Drawing.Point(334, 24)
        Me.serverToHCButton.Name = "serverToHCButton"
        Me.serverToHCButton.Size = New System.Drawing.Size(24, 23)
        Me.serverToHCButton.TabIndex = 2
        Me.serverToHCButton.Text = ">"
        Me.serverToHCButton.UseVisualStyleBackColor = True
        '
        'hcModsGroup
        '
        Me.hcModsGroup.Controls.Add(Me.hcModsSortButton)
        Me.hcModsGroup.Controls.Add(Me.hcModsDownButton)
        Me.hcModsGroup.Controls.Add(Me.hcModsUpButton)
        Me.hcModsGroup.Controls.Add(Me.hcModsNoneButton)
        Me.hcModsGroup.Controls.Add(Me.hcModsAllButton)
        Me.hcModsGroup.Controls.Add(Me.hcModsList)
        Me.hcModsGroup.Location = New System.Drawing.Point(365, 6)
        Me.hcModsGroup.Name = "hcModsGroup"
        Me.hcModsGroup.Size = New System.Drawing.Size(320, 229)
        Me.hcModsGroup.TabIndex = 1
        Me.hcModsGroup.TabStop = False
        Me.hcModsGroup.Text = "Headless Client Mods"
        '
        'hcModsSortButton
        '
        Me.hcModsSortButton.Location = New System.Drawing.Point(178, 200)
        Me.hcModsSortButton.Name = "hcModsSortButton"
        Me.hcModsSortButton.Size = New System.Drawing.Size(50, 23)
        Me.hcModsSortButton.TabIndex = 11
        Me.hcModsSortButton.Text = "Sort"
        Me.hcModsSortButton.UseVisualStyleBackColor = True
        '
        'hcModsDownButton
        '
        Me.hcModsDownButton.Location = New System.Drawing.Point(148, 200)
        Me.hcModsDownButton.Name = "hcModsDownButton"
        Me.hcModsDownButton.Size = New System.Drawing.Size(24, 23)
        Me.hcModsDownButton.TabIndex = 10
        Me.hcModsDownButton.Text = "˅"
        Me.hcModsDownButton.UseVisualStyleBackColor = True
        '
        'hcModsUpButton
        '
        Me.hcModsUpButton.Location = New System.Drawing.Point(118, 200)
        Me.hcModsUpButton.Name = "hcModsUpButton"
        Me.hcModsUpButton.Size = New System.Drawing.Size(24, 23)
        Me.hcModsUpButton.TabIndex = 9
        Me.hcModsUpButton.Text = "˄"
        Me.hcModsUpButton.UseVisualStyleBackColor = True
        '
        'hcModsNoneButton
        '
        Me.hcModsNoneButton.Location = New System.Drawing.Point(62, 200)
        Me.hcModsNoneButton.Name = "hcModsNoneButton"
        Me.hcModsNoneButton.Size = New System.Drawing.Size(50, 23)
        Me.hcModsNoneButton.TabIndex = 8
        Me.hcModsNoneButton.Text = "None"
        Me.hcModsNoneButton.UseVisualStyleBackColor = True
        '
        'hcModsAllButton
        '
        Me.hcModsAllButton.Location = New System.Drawing.Point(6, 200)
        Me.hcModsAllButton.Name = "hcModsAllButton"
        Me.hcModsAllButton.Size = New System.Drawing.Size(50, 23)
        Me.hcModsAllButton.TabIndex = 7
        Me.hcModsAllButton.Text = "All"
        Me.hcModsAllButton.UseVisualStyleBackColor = True
        '
        'hcModsList
        '
        Me.hcModsList.FormattingEnabled = True
        Me.hcModsList.Location = New System.Drawing.Point(6, 19)
        Me.hcModsList.Name = "hcModsList"
        Me.hcModsList.ScrollAlwaysVisible = True
        Me.hcModsList.Size = New System.Drawing.Size(303, 169)
        Me.hcModsList.TabIndex = 1
        '
        'serverModsGroup
        '
        Me.serverModsGroup.Controls.Add(Me.serverModsSortButton)
        Me.serverModsGroup.Controls.Add(Me.serverModsDownButton)
        Me.serverModsGroup.Controls.Add(Me.serverModsUpButton)
        Me.serverModsGroup.Controls.Add(Me.serverModsNoneButton)
        Me.serverModsGroup.Controls.Add(Me.serverModsAllButton)
        Me.serverModsGroup.Controls.Add(Me.serverModsList)
        Me.serverModsGroup.Location = New System.Drawing.Point(7, 6)
        Me.serverModsGroup.Name = "serverModsGroup"
        Me.serverModsGroup.Size = New System.Drawing.Size(320, 229)
        Me.serverModsGroup.TabIndex = 0
        Me.serverModsGroup.TabStop = False
        Me.serverModsGroup.Text = "Server Mods"
        '
        'serverModsSortButton
        '
        Me.serverModsSortButton.Location = New System.Drawing.Point(178, 200)
        Me.serverModsSortButton.Name = "serverModsSortButton"
        Me.serverModsSortButton.Size = New System.Drawing.Size(50, 23)
        Me.serverModsSortButton.TabIndex = 6
        Me.serverModsSortButton.Text = "Sort"
        Me.serverModsSortButton.UseVisualStyleBackColor = True
        '
        'serverModsDownButton
        '
        Me.serverModsDownButton.Location = New System.Drawing.Point(148, 200)
        Me.serverModsDownButton.Name = "serverModsDownButton"
        Me.serverModsDownButton.Size = New System.Drawing.Size(24, 23)
        Me.serverModsDownButton.TabIndex = 5
        Me.serverModsDownButton.Text = "˅"
        Me.serverModsDownButton.UseVisualStyleBackColor = True
        '
        'serverModsUpButton
        '
        Me.serverModsUpButton.Location = New System.Drawing.Point(118, 200)
        Me.serverModsUpButton.Name = "serverModsUpButton"
        Me.serverModsUpButton.Size = New System.Drawing.Size(24, 23)
        Me.serverModsUpButton.TabIndex = 4
        Me.serverModsUpButton.Text = "˄"
        Me.serverModsUpButton.UseVisualStyleBackColor = True
        '
        'serverModsNoneButton
        '
        Me.serverModsNoneButton.Location = New System.Drawing.Point(62, 200)
        Me.serverModsNoneButton.Name = "serverModsNoneButton"
        Me.serverModsNoneButton.Size = New System.Drawing.Size(50, 23)
        Me.serverModsNoneButton.TabIndex = 2
        Me.serverModsNoneButton.Text = "None"
        Me.serverModsNoneButton.UseVisualStyleBackColor = True
        '
        'serverModsAllButton
        '
        Me.serverModsAllButton.Location = New System.Drawing.Point(6, 200)
        Me.serverModsAllButton.Name = "serverModsAllButton"
        Me.serverModsAllButton.Size = New System.Drawing.Size(50, 23)
        Me.serverModsAllButton.TabIndex = 1
        Me.serverModsAllButton.Text = "All"
        Me.serverModsAllButton.UseVisualStyleBackColor = True
        '
        'serverModsList
        '
        Me.serverModsList.FormattingEnabled = True
        Me.serverModsList.Location = New System.Drawing.Point(6, 19)
        Me.serverModsList.Name = "serverModsList"
        Me.serverModsList.ScrollAlwaysVisible = True
        Me.serverModsList.Size = New System.Drawing.Size(303, 169)
        Me.serverModsList.TabIndex = 0
        '
        'settingsTab
        '
        Me.settingsTab.Controls.Add(Me.networkGroup)
        Me.settingsTab.Controls.Add(Me.headlessGroup)
        Me.settingsTab.Controls.Add(Me.rulesGroup)
        Me.settingsTab.Controls.Add(Me.settingsGroup)
        Me.settingsTab.Location = New System.Drawing.Point(4, 22)
        Me.settingsTab.Name = "settingsTab"
        Me.settingsTab.Padding = New System.Windows.Forms.Padding(3)
        Me.settingsTab.Size = New System.Drawing.Size(691, 241)
        Me.settingsTab.TabIndex = 0
        Me.settingsTab.Text = "Settings"
        Me.settingsTab.UseVisualStyleBackColor = True
        '
        'networkGroup
        '
        Me.networkGroup.Controls.Add(Me.netlogCheck)
        Me.networkGroup.Controls.Add(Me.loopbackCheck)
        Me.networkGroup.Controls.Add(Me.upnpCheck)
        Me.networkGroup.Location = New System.Drawing.Point(276, 132)
        Me.networkGroup.Name = "networkGroup"
        Me.networkGroup.Size = New System.Drawing.Size(80, 103)
        Me.networkGroup.TabIndex = 13
        Me.networkGroup.TabStop = False
        Me.networkGroup.Text = "Network"
        '
        'netlogCheck
        '
        Me.netlogCheck.AutoSize = True
        Me.netlogCheck.Location = New System.Drawing.Point(6, 71)
        Me.netlogCheck.Name = "netlogCheck"
        Me.netlogCheck.Size = New System.Drawing.Size(57, 17)
        Me.netlogCheck.TabIndex = 14
        Me.netlogCheck.Text = "Netlog"
        Me.netlogCheck.UseVisualStyleBackColor = True
        '
        'loopbackCheck
        '
        Me.loopbackCheck.AutoSize = True
        Me.loopbackCheck.Location = New System.Drawing.Point(6, 25)
        Me.loopbackCheck.Name = "loopbackCheck"
        Me.loopbackCheck.Size = New System.Drawing.Size(74, 17)
        Me.loopbackCheck.TabIndex = 15
        Me.loopbackCheck.Text = "Loopback"
        Me.loopbackCheck.UseVisualStyleBackColor = True
        '
        'upnpCheck
        '
        Me.upnpCheck.AutoSize = True
        Me.upnpCheck.Location = New System.Drawing.Point(6, 48)
        Me.upnpCheck.Name = "upnpCheck"
        Me.upnpCheck.Size = New System.Drawing.Size(56, 17)
        Me.upnpCheck.TabIndex = 14
        Me.upnpCheck.Text = "UPNP"
        Me.upnpCheck.UseVisualStyleBackColor = True
        '
        'headlessGroup
        '
        Me.headlessGroup.Controls.Add(Me.noOfHCNumeric)
        Me.headlessGroup.Controls.Add(Me.Label2)
        Me.headlessGroup.Controls.Add(Me.enableHCCheck)
        Me.headlessGroup.Controls.Add(Me.localClientBox)
        Me.headlessGroup.Controls.Add(Me.headlessIPBox)
        Me.headlessGroup.Controls.Add(Me.Label3)
        Me.headlessGroup.Controls.Add(Me.HCIPLabel)
        Me.headlessGroup.Location = New System.Drawing.Point(6, 132)
        Me.headlessGroup.Name = "headlessGroup"
        Me.headlessGroup.Size = New System.Drawing.Size(264, 103)
        Me.headlessGroup.TabIndex = 12
        Me.headlessGroup.TabStop = False
        Me.headlessGroup.Text = "Headless Client"
        '
        'noOfHCNumeric
        '
        Me.noOfHCNumeric.Enabled = False
        Me.noOfHCNumeric.Location = New System.Drawing.Point(134, 17)
        Me.noOfHCNumeric.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.noOfHCNumeric.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.noOfHCNumeric.Name = "noOfHCNumeric"
        Me.noOfHCNumeric.Size = New System.Drawing.Size(42, 20)
        Me.noOfHCNumeric.TabIndex = 14
        Me.noOfHCNumeric.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "No. of HCs"
        '
        'enableHCCheck
        '
        Me.enableHCCheck.AutoSize = True
        Me.enableHCCheck.Location = New System.Drawing.Point(181, 19)
        Me.enableHCCheck.Name = "enableHCCheck"
        Me.enableHCCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.enableHCCheck.Size = New System.Drawing.Size(77, 17)
        Me.enableHCCheck.TabIndex = 14
        Me.enableHCCheck.Text = "Enable HC"
        Me.enableHCCheck.UseVisualStyleBackColor = True
        '
        'localClientBox
        '
        Me.localClientBox.Location = New System.Drawing.Point(77, 68)
        Me.localClientBox.Name = "localClientBox"
        Me.localClientBox.Size = New System.Drawing.Size(181, 20)
        Me.localClientBox.TabIndex = 3
        Me.localClientBox.Text = "127.0.0.1"
        '
        'headlessIPBox
        '
        Me.headlessIPBox.Location = New System.Drawing.Point(77, 42)
        Me.headlessIPBox.Name = "headlessIPBox"
        Me.headlessIPBox.Size = New System.Drawing.Size(181, 20)
        Me.headlessIPBox.TabIndex = 2
        Me.headlessIPBox.Text = "127.0.0.1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Local Clients"
        '
        'HCIPLabel
        '
        Me.HCIPLabel.AutoSize = True
        Me.HCIPLabel.Location = New System.Drawing.Point(2, 45)
        Me.HCIPLabel.Name = "HCIPLabel"
        Me.HCIPLabel.Size = New System.Drawing.Size(69, 13)
        Me.HCIPLabel.TabIndex = 0
        Me.HCIPLabel.Text = "Headless IPs"
        '
        'rulesGroup
        '
        Me.rulesGroup.Location = New System.Drawing.Point(365, 6)
        Me.rulesGroup.Name = "rulesGroup"
        Me.rulesGroup.Size = New System.Drawing.Size(320, 229)
        Me.rulesGroup.TabIndex = 12
        Me.rulesGroup.TabStop = False
        Me.rulesGroup.Text = "Logging"
        '
        'settingsGroup
        '
        Me.settingsGroup.Controls.Add(Me.serverDirButton)
        Me.settingsGroup.Controls.Add(Me.serverFileBox)
        Me.settingsGroup.Controls.Add(Me.Label1)
        Me.settingsGroup.Controls.Add(Me.nameLabel)
        Me.settingsGroup.Controls.Add(Me.serverNameBox)
        Me.settingsGroup.Controls.Add(Me.portBox)
        Me.settingsGroup.Controls.Add(Me.passwordLabel)
        Me.settingsGroup.Controls.Add(Me.maxPlayersLabel)
        Me.settingsGroup.Controls.Add(Me.passwordBox)
        Me.settingsGroup.Controls.Add(Me.maxPlayersBox)
        Me.settingsGroup.Controls.Add(Me.adminPassLabel)
        Me.settingsGroup.Controls.Add(Me.portLabel)
        Me.settingsGroup.Controls.Add(Me.adminPassBox)
        Me.settingsGroup.Location = New System.Drawing.Point(6, 6)
        Me.settingsGroup.Name = "settingsGroup"
        Me.settingsGroup.Size = New System.Drawing.Size(350, 120)
        Me.settingsGroup.TabIndex = 11
        Me.settingsGroup.TabStop = False
        Me.settingsGroup.Text = "Main"
        '
        'serverDirButton
        '
        Me.serverDirButton.BackgroundImage = CType(resources.GetObject("serverDirButton.BackgroundImage"), System.Drawing.Image)
        Me.serverDirButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.serverDirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.serverDirButton.Location = New System.Drawing.Point(320, 39)
        Me.serverDirButton.Name = "serverDirButton"
        Me.serverDirButton.Size = New System.Drawing.Size(24, 20)
        Me.serverDirButton.TabIndex = 2
        Me.serverDirButton.UseVisualStyleBackColor = True
        '
        'serverFileBox
        '
        Me.serverFileBox.Location = New System.Drawing.Point(94, 39)
        Me.serverFileBox.Name = "serverFileBox"
        Me.serverFileBox.Size = New System.Drawing.Size(220, 20)
        Me.serverFileBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Server File"
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Location = New System.Drawing.Point(6, 16)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(69, 13)
        Me.nameLabel.TabIndex = 0
        Me.nameLabel.Text = "Server Name"
        '
        'serverNameBox
        '
        Me.serverNameBox.Location = New System.Drawing.Point(94, 13)
        Me.serverNameBox.Name = "serverNameBox"
        Me.serverNameBox.Size = New System.Drawing.Size(250, 20)
        Me.serverNameBox.TabIndex = 0
        '
        'portBox
        '
        Me.portBox.Location = New System.Drawing.Point(282, 91)
        Me.portBox.Name = "portBox"
        Me.portBox.Size = New System.Drawing.Size(62, 20)
        Me.portBox.TabIndex = 6
        '
        'passwordLabel
        '
        Me.passwordLabel.AutoSize = True
        Me.passwordLabel.Location = New System.Drawing.Point(6, 68)
        Me.passwordLabel.Name = "passwordLabel"
        Me.passwordLabel.Size = New System.Drawing.Size(53, 13)
        Me.passwordLabel.TabIndex = 2
        Me.passwordLabel.Text = "Password"
        '
        'maxPlayersLabel
        '
        Me.maxPlayersLabel.AutoSize = True
        Me.maxPlayersLabel.Location = New System.Drawing.Point(212, 68)
        Me.maxPlayersLabel.Name = "maxPlayersLabel"
        Me.maxPlayersLabel.Size = New System.Drawing.Size(64, 13)
        Me.maxPlayersLabel.TabIndex = 8
        Me.maxPlayersLabel.Text = "Max Players"
        '
        'passwordBox
        '
        Me.passwordBox.Location = New System.Drawing.Point(94, 65)
        Me.passwordBox.Name = "passwordBox"
        Me.passwordBox.Size = New System.Drawing.Size(107, 20)
        Me.passwordBox.TabIndex = 3
        '
        'maxPlayersBox
        '
        Me.maxPlayersBox.Location = New System.Drawing.Point(282, 65)
        Me.maxPlayersBox.Name = "maxPlayersBox"
        Me.maxPlayersBox.Size = New System.Drawing.Size(62, 20)
        Me.maxPlayersBox.TabIndex = 5
        '
        'adminPassLabel
        '
        Me.adminPassLabel.AutoSize = True
        Me.adminPassLabel.Location = New System.Drawing.Point(6, 94)
        Me.adminPassLabel.Name = "adminPassLabel"
        Me.adminPassLabel.Size = New System.Drawing.Size(82, 13)
        Me.adminPassLabel.TabIndex = 4
        Me.adminPassLabel.Text = "AdminPassword"
        '
        'portLabel
        '
        Me.portLabel.AutoSize = True
        Me.portLabel.Location = New System.Drawing.Point(250, 94)
        Me.portLabel.Name = "portLabel"
        Me.portLabel.Size = New System.Drawing.Size(26, 13)
        Me.portLabel.TabIndex = 6
        Me.portLabel.Text = "Port"
        '
        'adminPassBox
        '
        Me.adminPassBox.Location = New System.Drawing.Point(94, 91)
        Me.adminPassBox.Name = "adminPassBox"
        Me.adminPassBox.Size = New System.Drawing.Size(107, 20)
        Me.adminPassBox.TabIndex = 4
        '
        'serverTabs
        '
        Me.serverTabs.Controls.Add(Me.settingsTab)
        Me.serverTabs.Controls.Add(Me.miscTab)
        Me.serverTabs.Controls.Add(Me.modsTab)
        Me.serverTabs.Controls.Add(Me.perfTab)
        Me.serverTabs.Controls.Add(Me.missionTab)
        Me.serverTabs.Controls.Add(Me.difficultyTab)
        Me.serverTabs.Controls.Add(Me.scriptingTab)
        Me.serverTabs.Dock = System.Windows.Forms.DockStyle.Top
        Me.serverTabs.Location = New System.Drawing.Point(0, 0)
        Me.serverTabs.Name = "serverTabs"
        Me.serverTabs.SelectedIndex = 0
        Me.serverTabs.Size = New System.Drawing.Size(699, 267)
        Me.serverTabs.TabIndex = 4
        '
        'miscTab
        '
        Me.miscTab.Controls.Add(Me.miscGroup)
        Me.miscTab.Controls.Add(Me.modGroup)
        Me.miscTab.Controls.Add(Me.votingGroup)
        Me.miscTab.Controls.Add(Me.vonGroup)
        Me.miscTab.Location = New System.Drawing.Point(4, 22)
        Me.miscTab.Name = "miscTab"
        Me.miscTab.Padding = New System.Windows.Forms.Padding(3)
        Me.miscTab.Size = New System.Drawing.Size(691, 241)
        Me.miscTab.TabIndex = 3
        Me.miscTab.Text = "MISC"
        Me.miscTab.UseVisualStyleBackColor = True
        '
        'miscGroup
        '
        Me.miscGroup.Controls.Add(Me.filePatchLabel)
        Me.miscGroup.Controls.Add(Me.filePatchCombo)
        Me.miscGroup.Controls.Add(Me.verifySigLabel)
        Me.miscGroup.Controls.Add(Me.requiredBuildBox)
        Me.miscGroup.Controls.Add(Me.verifySigCombo)
        Me.miscGroup.Controls.Add(Me.requiredBuildCheck)
        Me.miscGroup.Controls.Add(Me.kickDupeCheck)
        Me.miscGroup.Location = New System.Drawing.Point(6, 6)
        Me.miscGroup.Name = "miscGroup"
        Me.miscGroup.Size = New System.Drawing.Size(301, 123)
        Me.miscGroup.TabIndex = 20
        Me.miscGroup.TabStop = False
        Me.miscGroup.Text = "Main"
        '
        'filePatchLabel
        '
        Me.filePatchLabel.AutoSize = True
        Me.filePatchLabel.Location = New System.Drawing.Point(23, 46)
        Me.filePatchLabel.Name = "filePatchLabel"
        Me.filePatchLabel.Size = New System.Drawing.Size(96, 13)
        Me.filePatchLabel.TabIndex = 26
        Me.filePatchLabel.Text = "Allow File Patching"
        '
        'filePatchCombo
        '
        Me.filePatchCombo.BackColor = System.Drawing.SystemColors.Window
        Me.filePatchCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.filePatchCombo.FormattingEnabled = True
        Me.filePatchCombo.Items.AddRange(New Object() {"0", "1", "2"})
        Me.filePatchCombo.Location = New System.Drawing.Point(133, 43)
        Me.filePatchCombo.MaxDropDownItems = 3
        Me.filePatchCombo.Name = "filePatchCombo"
        Me.filePatchCombo.Size = New System.Drawing.Size(79, 21)
        Me.filePatchCombo.TabIndex = 27
        '
        'verifySigLabel
        '
        Me.verifySigLabel.AutoSize = True
        Me.verifySigLabel.Location = New System.Drawing.Point(23, 73)
        Me.verifySigLabel.Name = "verifySigLabel"
        Me.verifySigLabel.Size = New System.Drawing.Size(86, 13)
        Me.verifySigLabel.TabIndex = 17
        Me.verifySigLabel.Text = "Verify Signatures"
        '
        'requiredBuildBox
        '
        Me.requiredBuildBox.Enabled = False
        Me.requiredBuildBox.Location = New System.Drawing.Point(133, 17)
        Me.requiredBuildBox.Name = "requiredBuildBox"
        Me.requiredBuildBox.Size = New System.Drawing.Size(79, 20)
        Me.requiredBuildBox.TabIndex = 25
        Me.requiredBuildBox.Text = "0"
        '
        'verifySigCombo
        '
        Me.verifySigCombo.BackColor = System.Drawing.SystemColors.Window
        Me.verifySigCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.verifySigCombo.FormattingEnabled = True
        Me.verifySigCombo.Items.AddRange(New Object() {"none", "v1", "v2"})
        Me.verifySigCombo.Location = New System.Drawing.Point(133, 70)
        Me.verifySigCombo.MaxDropDownItems = 3
        Me.verifySigCombo.Name = "verifySigCombo"
        Me.verifySigCombo.Size = New System.Drawing.Size(79, 21)
        Me.verifySigCombo.TabIndex = 23
        '
        'requiredBuildCheck
        '
        Me.requiredBuildCheck.AutoSize = True
        Me.requiredBuildCheck.Location = New System.Drawing.Point(6, 19)
        Me.requiredBuildCheck.Name = "requiredBuildCheck"
        Me.requiredBuildCheck.Size = New System.Drawing.Size(95, 17)
        Me.requiredBuildCheck.TabIndex = 21
        Me.requiredBuildCheck.Text = "Required Build"
        Me.requiredBuildCheck.UseVisualStyleBackColor = True
        '
        'kickDupeCheck
        '
        Me.kickDupeCheck.AutoSize = True
        Me.kickDupeCheck.Location = New System.Drawing.Point(6, 99)
        Me.kickDupeCheck.Name = "kickDupeCheck"
        Me.kickDupeCheck.Size = New System.Drawing.Size(100, 17)
        Me.kickDupeCheck.TabIndex = 15
        Me.kickDupeCheck.Text = "Kick Duplicates"
        Me.kickDupeCheck.UseVisualStyleBackColor = True
        '
        'modGroup
        '
        Me.modGroup.Controls.Add(Me.Label8)
        Me.modGroup.Controls.Add(Me.modTimeNumeric)
        Me.modGroup.Controls.Add(Me.modBox)
        Me.modGroup.Location = New System.Drawing.Point(313, 6)
        Me.modGroup.Name = "modGroup"
        Me.modGroup.Size = New System.Drawing.Size(372, 229)
        Me.modGroup.TabIndex = 19
        Me.modGroup.TabStop = False
        Me.modGroup.Text = "Message Of The Day"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(160, 205)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(145, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Seconds Between Messages"
        '
        'modTimeNumeric
        '
        Me.modTimeNumeric.Location = New System.Drawing.Point(311, 203)
        Me.modTimeNumeric.Maximum = New Decimal(New Integer() {600, 0, 0, 0})
        Me.modTimeNumeric.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.modTimeNumeric.Name = "modTimeNumeric"
        Me.modTimeNumeric.Size = New System.Drawing.Size(55, 20)
        Me.modTimeNumeric.TabIndex = 17
        Me.modTimeNumeric.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'modBox
        '
        Me.modBox.Location = New System.Drawing.Point(6, 19)
        Me.modBox.Name = "modBox"
        Me.modBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.modBox.Size = New System.Drawing.Size(360, 178)
        Me.modBox.TabIndex = 0
        Me.modBox.Text = ""
        Me.modBox.WordWrap = False
        '
        'votingGroup
        '
        Me.votingGroup.Controls.Add(Me.Label7)
        Me.votingGroup.Controls.Add(Me.Label6)
        Me.votingGroup.Controls.Add(Me.Label5)
        Me.votingGroup.Controls.Add(Me.voteThresholdNumeric)
        Me.votingGroup.Controls.Add(Me.minPlayersNumeric)
        Me.votingGroup.Controls.Add(Me.voteCheck)
        Me.votingGroup.Location = New System.Drawing.Point(6, 135)
        Me.votingGroup.Name = "votingGroup"
        Me.votingGroup.Size = New System.Drawing.Size(159, 100)
        Me.votingGroup.TabIndex = 18
        Me.votingGroup.TabStop = False
        Me.votingGroup.Text = "Voting"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(134, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "%"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Vote Threshold"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Min Players"
        '
        'voteThresholdNumeric
        '
        Me.voteThresholdNumeric.Location = New System.Drawing.Point(90, 68)
        Me.voteThresholdNumeric.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.voteThresholdNumeric.Name = "voteThresholdNumeric"
        Me.voteThresholdNumeric.Size = New System.Drawing.Size(43, 20)
        Me.voteThresholdNumeric.TabIndex = 20
        Me.voteThresholdNumeric.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'minPlayersNumeric
        '
        Me.minPlayersNumeric.Location = New System.Drawing.Point(90, 42)
        Me.minPlayersNumeric.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.minPlayersNumeric.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.minPlayersNumeric.Name = "minPlayersNumeric"
        Me.minPlayersNumeric.Size = New System.Drawing.Size(43, 20)
        Me.minPlayersNumeric.TabIndex = 17
        Me.minPlayersNumeric.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'voteCheck
        '
        Me.voteCheck.AutoSize = True
        Me.voteCheck.Location = New System.Drawing.Point(6, 19)
        Me.voteCheck.Name = "voteCheck"
        Me.voteCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.voteCheck.Size = New System.Drawing.Size(98, 17)
        Me.voteCheck.TabIndex = 19
        Me.voteCheck.Text = "Voting Enabled"
        Me.voteCheck.UseVisualStyleBackColor = True
        '
        'vonGroup
        '
        Me.vonGroup.Controls.Add(Me.Label4)
        Me.vonGroup.Controls.Add(Me.codecNumeric)
        Me.vonGroup.Controls.Add(Me.vonCheck)
        Me.vonGroup.Location = New System.Drawing.Point(171, 135)
        Me.vonGroup.Name = "vonGroup"
        Me.vonGroup.Size = New System.Drawing.Size(136, 100)
        Me.vonGroup.TabIndex = 17
        Me.vonGroup.TabStop = False
        Me.vonGroup.Text = "VON Settings"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Codec Quality"
        '
        'codecNumeric
        '
        Me.codecNumeric.Location = New System.Drawing.Point(85, 31)
        Me.codecNumeric.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.codecNumeric.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.codecNumeric.Name = "codecNumeric"
        Me.codecNumeric.Size = New System.Drawing.Size(43, 20)
        Me.codecNumeric.TabIndex = 15
        Me.codecNumeric.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'vonCheck
        '
        Me.vonCheck.AutoSize = True
        Me.vonCheck.Location = New System.Drawing.Point(9, 57)
        Me.vonCheck.Name = "vonCheck"
        Me.vonCheck.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.vonCheck.Size = New System.Drawing.Size(87, 17)
        Me.vonCheck.TabIndex = 14
        Me.vonCheck.Text = "Disable VON"
        Me.vonCheck.UseVisualStyleBackColor = True
        '
        'perfTab
        '
        Me.perfTab.Controls.Add(Me.NumericUpDown9)
        Me.perfTab.Controls.Add(Me.NumericUpDown8)
        Me.perfTab.Controls.Add(Me.NumericUpDown7)
        Me.perfTab.Controls.Add(Me.NumericUpDown6)
        Me.perfTab.Controls.Add(Me.CheckBox10)
        Me.perfTab.Controls.Add(Me.CheckBox9)
        Me.perfTab.Controls.Add(Me.CheckBox8)
        Me.perfTab.Controls.Add(Me.ComboBox2)
        Me.perfTab.Controls.Add(Me.CheckBox4)
        Me.perfTab.Controls.Add(Me.maxPingCheck)
        Me.perfTab.Controls.Add(Me.filePatchingCheck)
        Me.perfTab.Controls.Add(Me.htCheck)
        Me.perfTab.Location = New System.Drawing.Point(4, 22)
        Me.perfTab.Name = "perfTab"
        Me.perfTab.Padding = New System.Windows.Forms.Padding(3)
        Me.perfTab.Size = New System.Drawing.Size(691, 241)
        Me.perfTab.TabIndex = 2
        Me.perfTab.Text = "Perfomance"
        Me.perfTab.UseVisualStyleBackColor = True
        '
        'NumericUpDown9
        '
        Me.NumericUpDown9.Location = New System.Drawing.Point(198, 144)
        Me.NumericUpDown9.Name = "NumericUpDown9"
        Me.NumericUpDown9.Size = New System.Drawing.Size(38, 20)
        Me.NumericUpDown9.TabIndex = 43
        '
        'NumericUpDown8
        '
        Me.NumericUpDown8.Location = New System.Drawing.Point(198, 118)
        Me.NumericUpDown8.Name = "NumericUpDown8"
        Me.NumericUpDown8.Size = New System.Drawing.Size(38, 20)
        Me.NumericUpDown8.TabIndex = 42
        '
        'NumericUpDown7
        '
        Me.NumericUpDown7.Location = New System.Drawing.Point(198, 92)
        Me.NumericUpDown7.Name = "NumericUpDown7"
        Me.NumericUpDown7.Size = New System.Drawing.Size(38, 20)
        Me.NumericUpDown7.TabIndex = 41
        '
        'NumericUpDown6
        '
        Me.NumericUpDown6.Location = New System.Drawing.Point(198, 66)
        Me.NumericUpDown6.Name = "NumericUpDown6"
        Me.NumericUpDown6.Size = New System.Drawing.Size(38, 20)
        Me.NumericUpDown6.TabIndex = 40
        '
        'CheckBox10
        '
        Me.CheckBox10.AutoSize = True
        Me.CheckBox10.Location = New System.Drawing.Point(54, 172)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(133, 17)
        Me.CheckBox10.TabIndex = 39
        Me.CheckBox10.Text = "Kick On Slow Network"
        Me.CheckBox10.UseVisualStyleBackColor = True
        '
        'CheckBox9
        '
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.Location = New System.Drawing.Point(54, 145)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(121, 17)
        Me.CheckBox9.TabIndex = 38
        Me.CheckBox9.Text = "Disconnect Timeout"
        Me.CheckBox9.UseVisualStyleBackColor = True
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Location = New System.Drawing.Point(54, 119)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(108, 17)
        Me.CheckBox8.TabIndex = 37
        Me.CheckBox8.Text = "Max Packet Loss"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.SystemColors.Window
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"0", "1", "2"})
        Me.ComboBox2.Location = New System.Drawing.Point(198, 170)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(79, 21)
        Me.ComboBox2.TabIndex = 36
        Me.ComboBox2.Text = "0"
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(54, 93)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(85, 17)
        Me.CheckBox4.TabIndex = 35
        Me.CheckBox4.Text = "Max Desync"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'maxPingCheck
        '
        Me.maxPingCheck.AutoSize = True
        Me.maxPingCheck.Location = New System.Drawing.Point(54, 67)
        Me.maxPingCheck.Name = "maxPingCheck"
        Me.maxPingCheck.Size = New System.Drawing.Size(70, 17)
        Me.maxPingCheck.TabIndex = 34
        Me.maxPingCheck.Text = "Max Ping"
        Me.maxPingCheck.UseVisualStyleBackColor = True
        '
        'filePatchingCheck
        '
        Me.filePatchingCheck.AutoSize = True
        Me.filePatchingCheck.Location = New System.Drawing.Point(278, 89)
        Me.filePatchingCheck.Name = "filePatchingCheck"
        Me.filePatchingCheck.Size = New System.Drawing.Size(87, 17)
        Me.filePatchingCheck.TabIndex = 13
        Me.filePatchingCheck.Text = "File Patching"
        Me.filePatchingCheck.UseVisualStyleBackColor = True
        '
        'htCheck
        '
        Me.htCheck.AutoSize = True
        Me.htCheck.Location = New System.Drawing.Point(278, 135)
        Me.htCheck.Name = "htCheck"
        Me.htCheck.Size = New System.Drawing.Size(134, 17)
        Me.htCheck.TabIndex = 14
        Me.htCheck.Text = "Enable Hyperthreading"
        Me.htCheck.UseVisualStyleBackColor = True
        '
        'missionTab
        '
        Me.missionTab.Controls.Add(Me.persistCheck)
        Me.missionTab.Controls.Add(Me.autoInitCheck)
        Me.missionTab.Location = New System.Drawing.Point(4, 22)
        Me.missionTab.Name = "missionTab"
        Me.missionTab.Size = New System.Drawing.Size(691, 241)
        Me.missionTab.TabIndex = 4
        Me.missionTab.Text = "Missions"
        Me.missionTab.UseVisualStyleBackColor = True
        '
        'persistCheck
        '
        Me.persistCheck.AutoSize = True
        Me.persistCheck.Location = New System.Drawing.Point(285, 100)
        Me.persistCheck.Name = "persistCheck"
        Me.persistCheck.Size = New System.Drawing.Size(121, 17)
        Me.persistCheck.TabIndex = 10
        Me.persistCheck.Text = "Persistant Battlefield"
        Me.persistCheck.UseVisualStyleBackColor = True
        '
        'autoInitCheck
        '
        Me.autoInitCheck.AutoSize = True
        Me.autoInitCheck.Enabled = False
        Me.autoInitCheck.Location = New System.Drawing.Point(285, 123)
        Me.autoInitCheck.Name = "autoInitCheck"
        Me.autoInitCheck.Size = New System.Drawing.Size(65, 17)
        Me.autoInitCheck.TabIndex = 11
        Me.autoInitCheck.Text = "Auto Init"
        Me.autoInitCheck.UseVisualStyleBackColor = True
        '
        'difficultyTab
        '
        Me.difficultyTab.Location = New System.Drawing.Point(4, 22)
        Me.difficultyTab.Name = "difficultyTab"
        Me.difficultyTab.Size = New System.Drawing.Size(691, 241)
        Me.difficultyTab.TabIndex = 5
        Me.difficultyTab.Text = "Difficulty"
        Me.difficultyTab.UseVisualStyleBackColor = True
        '
        'scriptingTab
        '
        Me.scriptingTab.Location = New System.Drawing.Point(4, 22)
        Me.scriptingTab.Name = "scriptingTab"
        Me.scriptingTab.Size = New System.Drawing.Size(691, 241)
        Me.scriptingTab.TabIndex = 6
        Me.scriptingTab.Text = "Server Scripting"
        Me.scriptingTab.UseVisualStyleBackColor = True
        '
        'NewServerTab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.serverTabs)
        Me.Controls.Add(Me.profileGroup)
        Me.Name = "NewServerTab"
        Me.Size = New System.Drawing.Size(699, 331)
        Me.profileGroup.ResumeLayout(False)
        Me.profileGroup.PerformLayout()
        Me.modsTab.ResumeLayout(False)
        Me.hcModsGroup.ResumeLayout(False)
        Me.serverModsGroup.ResumeLayout(False)
        Me.settingsTab.ResumeLayout(False)
        Me.networkGroup.ResumeLayout(False)
        Me.networkGroup.PerformLayout()
        Me.headlessGroup.ResumeLayout(False)
        Me.headlessGroup.PerformLayout()
        CType(Me.noOfHCNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.settingsGroup.ResumeLayout(False)
        Me.settingsGroup.PerformLayout()
        Me.serverTabs.ResumeLayout(False)
        Me.miscTab.ResumeLayout(False)
        Me.miscGroup.ResumeLayout(False)
        Me.miscGroup.PerformLayout()
        Me.modGroup.ResumeLayout(False)
        Me.modGroup.PerformLayout()
        CType(Me.modTimeNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.votingGroup.ResumeLayout(False)
        Me.votingGroup.PerformLayout()
        CType(Me.voteThresholdNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minPlayersNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.vonGroup.ResumeLayout(False)
        Me.vonGroup.PerformLayout()
        CType(Me.codecNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.perfTab.ResumeLayout(False)
        Me.perfTab.PerformLayout()
        CType(Me.NumericUpDown9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.missionTab.ResumeLayout(False)
        Me.missionTab.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents profileNameBox As TextBox
    Friend WithEvents launchServer As Button
    Friend WithEvents profileGroup As GroupBox
    Friend WithEvents saveProfileButton As Button
    Friend WithEvents createBatButton As Button
    Friend WithEvents serverFileDialog As OpenFileDialog
    Friend WithEvents modsTab As TabPage
    Friend WithEvents settingsTab As TabPage
    Friend WithEvents headlessGroup As GroupBox
    Friend WithEvents loopbackCheck As CheckBox
    Friend WithEvents upnpCheck As CheckBox
    Friend WithEvents rulesGroup As GroupBox
    Friend WithEvents settingsGroup As GroupBox
    Friend WithEvents serverDirButton As Button
    Friend WithEvents serverFileBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents nameLabel As Label
    Friend WithEvents serverNameBox As TextBox
    Friend WithEvents portBox As TextBox
    Friend WithEvents passwordLabel As Label
    Friend WithEvents maxPlayersLabel As Label
    Friend WithEvents passwordBox As TextBox
    Friend WithEvents maxPlayersBox As TextBox
    Friend WithEvents adminPassLabel As Label
    Friend WithEvents portLabel As Label
    Friend WithEvents adminPassBox As TextBox
    Friend WithEvents serverTabs As TabControl
    Friend WithEvents deleteProfileButton As Button
    Friend WithEvents perfTab As TabPage
    Friend WithEvents networkGroup As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents enableHCCheck As CheckBox
    Friend WithEvents localClientBox As TextBox
    Friend WithEvents headlessIPBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents HCIPLabel As Label
    Friend WithEvents noOfHCNumeric As NumericUpDown
    Friend WithEvents netlogCheck As CheckBox
    Friend WithEvents miscTab As TabPage
    Friend WithEvents missionTab As TabPage
    Friend WithEvents difficultyTab As TabPage
    Friend WithEvents scriptingTab As TabPage
    Friend WithEvents kickDupeCheck As CheckBox
    Friend WithEvents vonCheck As CheckBox
    Friend WithEvents filePatchingCheck As CheckBox
    Friend WithEvents htCheck As CheckBox
    Friend WithEvents persistCheck As CheckBox
    Friend WithEvents autoInitCheck As CheckBox
    Friend WithEvents modGroup As GroupBox
    Friend WithEvents modBox As RichTextBox
    Friend WithEvents votingGroup As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents voteThresholdNumeric As NumericUpDown
    Friend WithEvents minPlayersNumeric As NumericUpDown
    Friend WithEvents voteCheck As CheckBox
    Friend WithEvents vonGroup As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents codecNumeric As NumericUpDown
    Friend WithEvents miscGroup As GroupBox
    Friend WithEvents verifySigCombo As ComboBox
    Friend WithEvents requiredBuildCheck As CheckBox
    Friend WithEvents battleyeCheck As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents modTimeNumeric As NumericUpDown
    Friend WithEvents filePatchLabel As Label
    Friend WithEvents filePatchCombo As ComboBox
    Friend WithEvents verifySigLabel As Label
    Friend WithEvents requiredBuildBox As TextBox
    Friend WithEvents NumericUpDown9 As NumericUpDown
    Friend WithEvents NumericUpDown8 As NumericUpDown
    Friend WithEvents NumericUpDown7 As NumericUpDown
    Friend WithEvents NumericUpDown6 As NumericUpDown
    Friend WithEvents CheckBox10 As CheckBox
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents maxPingCheck As CheckBox
    Friend WithEvents hcModsGroup As GroupBox
    Friend WithEvents serverModsGroup As GroupBox
    Friend WithEvents serverModsList As CheckedListBox
    Friend WithEvents hcModsList As CheckedListBox
    Friend WithEvents refreshModsButton As Button
    Friend WithEvents hcToServerButton As Button
    Friend WithEvents serverToHCButton As Button
    Friend WithEvents hcModsSortButton As Button
    Friend WithEvents hcModsDownButton As Button
    Friend WithEvents hcModsUpButton As Button
    Friend WithEvents hcModsNoneButton As Button
    Friend WithEvents hcModsAllButton As Button
    Friend WithEvents serverModsSortButton As Button
    Friend WithEvents serverModsDownButton As Button
    Friend WithEvents serverModsUpButton As Button
    Friend WithEvents serverModsNoneButton As Button
    Friend WithEvents serverModsAllButton As Button
End Class
