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
        Me.noOfHCLabel = New System.Windows.Forms.Label()
        Me.enableHCCheck = New System.Windows.Forms.CheckBox()
        Me.localClientBox = New System.Windows.Forms.TextBox()
        Me.headlessIPBox = New System.Windows.Forms.TextBox()
        Me.localClientsLabel = New System.Windows.Forms.Label()
        Me.hcIPLabel = New System.Windows.Forms.Label()
        Me.loggingGroup = New System.Windows.Forms.GroupBox()
        Me.rankingCheck = New System.Windows.Forms.CheckBox()
        Me.pidCheck = New System.Windows.Forms.CheckBox()
        Me.consoleLogCheck = New System.Windows.Forms.CheckBox()
        Me.netlogGroup = New System.Windows.Forms.GroupBox()
        Me.netRotButton = New System.Windows.Forms.Button()
        Me.netDelButton = New System.Windows.Forms.Button()
        Me.netOpenButton = New System.Windows.Forms.Button()
        Me.rptGroup = New System.Windows.Forms.GroupBox()
        Me.rptDeleteButton = New System.Windows.Forms.Button()
        Me.rptOpenButton = New System.Windows.Forms.Button()
        Me.rptTimeCombo = New System.Windows.Forms.ComboBox()
        Me.rptTimeLabel = New System.Windows.Forms.Label()
        Me.pidButton = New System.Windows.Forms.Button()
        Me.pidLabel = New System.Windows.Forms.Label()
        Me.pidBox = New System.Windows.Forms.TextBox()
        Me.rankingButton = New System.Windows.Forms.Button()
        Me.rankingLabel = New System.Windows.Forms.Label()
        Me.rankingBox = New System.Windows.Forms.TextBox()
        Me.consoleLogButton = New System.Windows.Forms.Button()
        Me.consoleLogLabel = New System.Windows.Forms.Label()
        Me.consoleLogBox = New System.Windows.Forms.TextBox()
        Me.settingsGroup = New System.Windows.Forms.GroupBox()
        Me.serverDirButton = New System.Windows.Forms.Button()
        Me.serverFileBox = New System.Windows.Forms.TextBox()
        Me.serverFileLabel = New System.Windows.Forms.Label()
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
        Me.modTimeLabel = New System.Windows.Forms.Label()
        Me.modTimeNumeric = New System.Windows.Forms.NumericUpDown()
        Me.modBox = New System.Windows.Forms.RichTextBox()
        Me.votingGroup = New System.Windows.Forms.GroupBox()
        Me.percentLabel = New System.Windows.Forms.Label()
        Me.voteThresholdLabel = New System.Windows.Forms.Label()
        Me.minPlayersLabel = New System.Windows.Forms.Label()
        Me.voteThresholdNumeric = New System.Windows.Forms.NumericUpDown()
        Me.minPlayersNumeric = New System.Windows.Forms.NumericUpDown()
        Me.voteCheck = New System.Windows.Forms.CheckBox()
        Me.vonGroup = New System.Windows.Forms.GroupBox()
        Me.codecLabel = New System.Windows.Forms.Label()
        Me.codecNumeric = New System.Windows.Forms.NumericUpDown()
        Me.vonCheck = New System.Windows.Forms.CheckBox()
        Me.perfTab = New System.Windows.Forms.TabPage()
        Me.disconTimeNumeric = New System.Windows.Forms.NumericUpDown()
        Me.packetLossNumeric = New System.Windows.Forms.NumericUpDown()
        Me.maxDesyncNumeric = New System.Windows.Forms.NumericUpDown()
        Me.maxPingNumeric = New System.Windows.Forms.NumericUpDown()
        Me.kickSlowCheck = New System.Windows.Forms.CheckBox()
        Me.disconTimeCheck = New System.Windows.Forms.CheckBox()
        Me.packetLossCheck = New System.Windows.Forms.CheckBox()
        Me.kickSlowCombo = New System.Windows.Forms.ComboBox()
        Me.maxDesyncCheck = New System.Windows.Forms.CheckBox()
        Me.maxPingCheck = New System.Windows.Forms.CheckBox()
        Me.filePatchingCheck = New System.Windows.Forms.CheckBox()
        Me.htCheck = New System.Windows.Forms.CheckBox()
        Me.missionTab = New System.Windows.Forms.TabPage()
        Me.persistCheck = New System.Windows.Forms.CheckBox()
        Me.autoInitCheck = New System.Windows.Forms.CheckBox()
        Me.difficultyTab = New System.Windows.Forms.TabPage()
        Me.scriptingTab = New System.Windows.Forms.TabPage()
        Me.viewGroup = New System.Windows.Forms.GroupBox()
        Me.clientPerfGroup = New System.Windows.Forms.GroupBox()
        Me.serverPerfGroup = New System.Windows.Forms.GroupBox()
        Me.maxCustFileLabel = New System.Windows.Forms.Label()
        Me.maxCustFileBox = New System.Windows.Forms.TextBox()
        Me.maxPacketLabel = New System.Windows.Forms.Label()
        Me.maxPacketBox = New System.Windows.Forms.TextBox()
        Me.maxGuaranteedLabel = New System.Windows.Forms.Label()
        Me.maxGuaranteedBox = New System.Windows.Forms.TextBox()
        Me.maxNonGuaranteedLabel = New System.Windows.Forms.Label()
        Me.maxNonGuaranteedBox = New System.Windows.Forms.TextBox()
        Me.minBandwidthLabel = New System.Windows.Forms.Label()
        Me.minBandwidthBox = New System.Windows.Forms.TextBox()
        Me.maxBandwidthLabel = New System.Windows.Forms.Label()
        Me.maxBandwidthBox = New System.Windows.Forms.TextBox()
        Me.minErrorNearLabel = New System.Windows.Forms.Label()
        Me.minErrorNearBox = New System.Windows.Forms.TextBox()
        Me.minErrorLabel = New System.Windows.Forms.Label()
        Me.minErrorBox = New System.Windows.Forms.TextBox()
        Me.maxSendLabel = New System.Windows.Forms.Label()
        Me.maxSendBox = New System.Windows.Forms.TextBox()
        Me.extraParamsLabel = New System.Windows.Forms.Label()
        Me.extraParamsBox = New System.Windows.Forms.TextBox()
        Me.perfResetButton = New System.Windows.Forms.Button()
        Me.perfResetLabel = New System.Windows.Forms.Label()
        Me.moreInfoLabel = New System.Windows.Forms.LinkLabel()
        Me.metresLabel = New System.Windows.Forms.Label()
        Me.distanceLabel = New System.Windows.Forms.Label()
        Me.terrainLabel = New System.Windows.Forms.Label()
        Me.distanceNumeric = New System.Windows.Forms.NumericUpDown()
        Me.terrainNumeric = New System.Windows.Forms.NumericUpDown()
        Me.sLabel = New System.Windows.Forms.Label()
        Me.msLabel = New System.Windows.Forms.Label()
        Me.plPercentLabel = New System.Windows.Forms.Label()
        Me.serverScriptsGroup = New System.Windows.Forms.GroupBox()
        Me.serverCommandLabel = New System.Windows.Forms.Label()
        Me.serverCommandBox = New System.Windows.Forms.RichTextBox()
        Me.doubleIdDetectedBox = New System.Windows.Forms.RichTextBox()
        Me.onUserDisconnectedBox = New System.Windows.Forms.RichTextBox()
        Me.onUserConnectedBox = New System.Windows.Forms.RichTextBox()
        Me.doubleIdDetectedLabel = New System.Windows.Forms.Label()
        Me.onUserConnectedLabel = New System.Windows.Forms.Label()
        Me.onUserDisconnectedLabel = New System.Windows.Forms.Label()
        Me.regularCheckLabel = New System.Windows.Forms.Label()
        Me.onUnsignedDataLabel = New System.Windows.Forms.Label()
        Me.onDifferentDataLabel = New System.Windows.Forms.Label()
        Me.onUnsignedDataBox = New System.Windows.Forms.RichTextBox()
        Me.regularCheckBox = New System.Windows.Forms.RichTextBox()
        Me.onDifferentDataBox = New System.Windows.Forms.RichTextBox()
        Me.onHackedDataBox = New System.Windows.Forms.RichTextBox()
        Me.onHackedDataLabel = New System.Windows.Forms.Label()
        Me.profileGroup.SuspendLayout()
        Me.modsTab.SuspendLayout()
        Me.hcModsGroup.SuspendLayout()
        Me.serverModsGroup.SuspendLayout()
        Me.settingsTab.SuspendLayout()
        Me.networkGroup.SuspendLayout()
        Me.headlessGroup.SuspendLayout()
        CType(Me.noOfHCNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.loggingGroup.SuspendLayout()
        Me.netlogGroup.SuspendLayout()
        Me.rptGroup.SuspendLayout()
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
        CType(Me.disconTimeNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.packetLossNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maxDesyncNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maxPingNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.missionTab.SuspendLayout()
        Me.scriptingTab.SuspendLayout()
        Me.viewGroup.SuspendLayout()
        Me.clientPerfGroup.SuspendLayout()
        Me.serverPerfGroup.SuspendLayout()
        CType(Me.distanceNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.terrainNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.serverScriptsGroup.SuspendLayout()
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
        Me.launchServer.Location = New System.Drawing.Point(612, 21)
        Me.launchServer.Name = "launchServer"
        Me.launchServer.Size = New System.Drawing.Size(75, 22)
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
        Me.deleteProfileButton.Location = New System.Drawing.Point(214, 21)
        Me.deleteProfileButton.Name = "deleteProfileButton"
        Me.deleteProfileButton.Size = New System.Drawing.Size(50, 22)
        Me.deleteProfileButton.TabIndex = 18
        Me.deleteProfileButton.Text = "Delete"
        Me.deleteProfileButton.UseVisualStyleBackColor = True
        '
        'createBatButton
        '
        Me.createBatButton.Location = New System.Drawing.Point(531, 21)
        Me.createBatButton.Name = "createBatButton"
        Me.createBatButton.Size = New System.Drawing.Size(75, 22)
        Me.createBatButton.TabIndex = 19
        Me.createBatButton.Text = "Export"
        Me.createBatButton.UseVisualStyleBackColor = True
        '
        'saveProfileButton
        '
        Me.saveProfileButton.Location = New System.Drawing.Point(158, 21)
        Me.saveProfileButton.Name = "saveProfileButton"
        Me.saveProfileButton.Size = New System.Drawing.Size(50, 22)
        Me.saveProfileButton.TabIndex = 17
        Me.saveProfileButton.Text = "Save"
        Me.saveProfileButton.UseVisualStyleBackColor = True
        '
        'battleyeCheck
        '
        Me.battleyeCheck.AutoSize = True
        Me.battleyeCheck.Location = New System.Drawing.Point(460, 25)
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
        Me.modsTab.BackColor = System.Drawing.Color.LightSkyBlue
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
        Me.serverModsGroup.Location = New System.Drawing.Point(6, 6)
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
        Me.settingsTab.BackColor = System.Drawing.Color.LightSkyBlue
        Me.settingsTab.Controls.Add(Me.networkGroup)
        Me.settingsTab.Controls.Add(Me.headlessGroup)
        Me.settingsTab.Controls.Add(Me.loggingGroup)
        Me.settingsTab.Controls.Add(Me.settingsGroup)
        Me.settingsTab.Location = New System.Drawing.Point(4, 22)
        Me.settingsTab.Name = "settingsTab"
        Me.settingsTab.Padding = New System.Windows.Forms.Padding(3)
        Me.settingsTab.Size = New System.Drawing.Size(691, 241)
        Me.settingsTab.TabIndex = 0
        Me.settingsTab.Text = "Settings"
        '
        'networkGroup
        '
        Me.networkGroup.Controls.Add(Me.netlogCheck)
        Me.networkGroup.Controls.Add(Me.upnpCheck)
        Me.networkGroup.Controls.Add(Me.loopbackCheck)
        Me.networkGroup.Location = New System.Drawing.Point(276, 132)
        Me.networkGroup.Name = "networkGroup"
        Me.networkGroup.Size = New System.Drawing.Size(83, 103)
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
        Me.headlessGroup.Controls.Add(Me.noOfHCLabel)
        Me.headlessGroup.Controls.Add(Me.enableHCCheck)
        Me.headlessGroup.Controls.Add(Me.localClientBox)
        Me.headlessGroup.Controls.Add(Me.headlessIPBox)
        Me.headlessGroup.Controls.Add(Me.localClientsLabel)
        Me.headlessGroup.Controls.Add(Me.hcIPLabel)
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
        'noOfHCLabel
        '
        Me.noOfHCLabel.AutoSize = True
        Me.noOfHCLabel.Location = New System.Drawing.Point(74, 20)
        Me.noOfHCLabel.Name = "noOfHCLabel"
        Me.noOfHCLabel.Size = New System.Drawing.Size(59, 13)
        Me.noOfHCLabel.TabIndex = 16
        Me.noOfHCLabel.Text = "No. of HCs"
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
        Me.localClientBox.Enabled = False
        Me.localClientBox.Location = New System.Drawing.Point(81, 68)
        Me.localClientBox.Name = "localClientBox"
        Me.localClientBox.Size = New System.Drawing.Size(177, 20)
        Me.localClientBox.TabIndex = 3
        Me.localClientBox.Text = "127.0.0.1"
        '
        'headlessIPBox
        '
        Me.headlessIPBox.Enabled = False
        Me.headlessIPBox.Location = New System.Drawing.Point(81, 42)
        Me.headlessIPBox.Name = "headlessIPBox"
        Me.headlessIPBox.Size = New System.Drawing.Size(177, 20)
        Me.headlessIPBox.TabIndex = 2
        Me.headlessIPBox.Text = "127.0.0.1"
        '
        'localClientsLabel
        '
        Me.localClientsLabel.AutoSize = True
        Me.localClientsLabel.Location = New System.Drawing.Point(6, 71)
        Me.localClientsLabel.Name = "localClientsLabel"
        Me.localClientsLabel.Size = New System.Drawing.Size(67, 13)
        Me.localClientsLabel.TabIndex = 1
        Me.localClientsLabel.Text = "Local Clients"
        '
        'hcIPLabel
        '
        Me.hcIPLabel.AutoSize = True
        Me.hcIPLabel.Location = New System.Drawing.Point(6, 45)
        Me.hcIPLabel.Name = "hcIPLabel"
        Me.hcIPLabel.Size = New System.Drawing.Size(69, 13)
        Me.hcIPLabel.TabIndex = 0
        Me.hcIPLabel.Text = "Headless IPs"
        '
        'loggingGroup
        '
        Me.loggingGroup.Controls.Add(Me.rankingCheck)
        Me.loggingGroup.Controls.Add(Me.pidCheck)
        Me.loggingGroup.Controls.Add(Me.consoleLogCheck)
        Me.loggingGroup.Controls.Add(Me.netlogGroup)
        Me.loggingGroup.Controls.Add(Me.rptGroup)
        Me.loggingGroup.Controls.Add(Me.pidButton)
        Me.loggingGroup.Controls.Add(Me.pidLabel)
        Me.loggingGroup.Controls.Add(Me.pidBox)
        Me.loggingGroup.Controls.Add(Me.rankingButton)
        Me.loggingGroup.Controls.Add(Me.rankingLabel)
        Me.loggingGroup.Controls.Add(Me.rankingBox)
        Me.loggingGroup.Controls.Add(Me.consoleLogButton)
        Me.loggingGroup.Controls.Add(Me.consoleLogLabel)
        Me.loggingGroup.Controls.Add(Me.consoleLogBox)
        Me.loggingGroup.Location = New System.Drawing.Point(365, 6)
        Me.loggingGroup.Name = "loggingGroup"
        Me.loggingGroup.Size = New System.Drawing.Size(320, 229)
        Me.loggingGroup.TabIndex = 12
        Me.loggingGroup.TabStop = False
        Me.loggingGroup.Text = "Logging"
        '
        'rankingCheck
        '
        Me.rankingCheck.AutoSize = True
        Me.rankingCheck.Location = New System.Drawing.Point(117, 21)
        Me.rankingCheck.Name = "rankingCheck"
        Me.rankingCheck.Size = New System.Drawing.Size(85, 17)
        Me.rankingCheck.TabIndex = 26
        Me.rankingCheck.Text = "Ranking File"
        Me.rankingCheck.UseVisualStyleBackColor = True
        '
        'pidCheck
        '
        Me.pidCheck.AutoSize = True
        Me.pidCheck.Location = New System.Drawing.Point(251, 21)
        Me.pidCheck.Name = "pidCheck"
        Me.pidCheck.Size = New System.Drawing.Size(63, 17)
        Me.pidCheck.TabIndex = 25
        Me.pidCheck.Text = "PID File"
        Me.pidCheck.UseVisualStyleBackColor = True
        '
        'consoleLogCheck
        '
        Me.consoleLogCheck.AutoSize = True
        Me.consoleLogCheck.Location = New System.Drawing.Point(6, 21)
        Me.consoleLogCheck.Name = "consoleLogCheck"
        Me.consoleLogCheck.Size = New System.Drawing.Size(85, 17)
        Me.consoleLogCheck.TabIndex = 16
        Me.consoleLogCheck.Text = "Console Log"
        Me.consoleLogCheck.UseVisualStyleBackColor = True
        '
        'netlogGroup
        '
        Me.netlogGroup.Controls.Add(Me.netRotButton)
        Me.netlogGroup.Controls.Add(Me.netDelButton)
        Me.netlogGroup.Controls.Add(Me.netOpenButton)
        Me.netlogGroup.Enabled = False
        Me.netlogGroup.Location = New System.Drawing.Point(164, 146)
        Me.netlogGroup.Name = "netlogGroup"
        Me.netlogGroup.Size = New System.Drawing.Size(150, 77)
        Me.netlogGroup.TabIndex = 24
        Me.netlogGroup.TabStop = False
        Me.netlogGroup.Text = "Netlog"
        '
        'netRotButton
        '
        Me.netRotButton.Location = New System.Drawing.Point(84, 13)
        Me.netRotButton.Name = "netRotButton"
        Me.netRotButton.Size = New System.Drawing.Size(60, 22)
        Me.netRotButton.TabIndex = 32
        Me.netRotButton.Text = "Rotate"
        Me.netRotButton.UseVisualStyleBackColor = True
        '
        'netDelButton
        '
        Me.netDelButton.Location = New System.Drawing.Point(84, 48)
        Me.netDelButton.Name = "netDelButton"
        Me.netDelButton.Size = New System.Drawing.Size(60, 22)
        Me.netDelButton.TabIndex = 31
        Me.netDelButton.Text = "Delete"
        Me.netDelButton.UseVisualStyleBackColor = True
        '
        'netOpenButton
        '
        Me.netOpenButton.Location = New System.Drawing.Point(6, 48)
        Me.netOpenButton.Name = "netOpenButton"
        Me.netOpenButton.Size = New System.Drawing.Size(60, 22)
        Me.netOpenButton.TabIndex = 30
        Me.netOpenButton.Text = "Open"
        Me.netOpenButton.UseVisualStyleBackColor = True
        '
        'rptGroup
        '
        Me.rptGroup.Controls.Add(Me.rptDeleteButton)
        Me.rptGroup.Controls.Add(Me.rptOpenButton)
        Me.rptGroup.Controls.Add(Me.rptTimeCombo)
        Me.rptGroup.Controls.Add(Me.rptTimeLabel)
        Me.rptGroup.Location = New System.Drawing.Point(6, 146)
        Me.rptGroup.Name = "rptGroup"
        Me.rptGroup.Size = New System.Drawing.Size(150, 77)
        Me.rptGroup.TabIndex = 23
        Me.rptGroup.TabStop = False
        Me.rptGroup.Text = "RPT"
        '
        'rptDeleteButton
        '
        Me.rptDeleteButton.Location = New System.Drawing.Point(84, 48)
        Me.rptDeleteButton.Name = "rptDeleteButton"
        Me.rptDeleteButton.Size = New System.Drawing.Size(60, 22)
        Me.rptDeleteButton.TabIndex = 29
        Me.rptDeleteButton.Text = "Delete"
        Me.rptDeleteButton.UseVisualStyleBackColor = True
        '
        'rptOpenButton
        '
        Me.rptOpenButton.Location = New System.Drawing.Point(6, 48)
        Me.rptOpenButton.Name = "rptOpenButton"
        Me.rptOpenButton.Size = New System.Drawing.Size(60, 22)
        Me.rptOpenButton.TabIndex = 25
        Me.rptOpenButton.Text = "Open"
        Me.rptOpenButton.UseVisualStyleBackColor = True
        '
        'rptTimeCombo
        '
        Me.rptTimeCombo.BackColor = System.Drawing.SystemColors.Window
        Me.rptTimeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.rptTimeCombo.FormattingEnabled = True
        Me.rptTimeCombo.Items.AddRange(New Object() {"none", "short", "full"})
        Me.rptTimeCombo.Location = New System.Drawing.Point(85, 13)
        Me.rptTimeCombo.MaxDropDownItems = 3
        Me.rptTimeCombo.Name = "rptTimeCombo"
        Me.rptTimeCombo.Size = New System.Drawing.Size(58, 21)
        Me.rptTimeCombo.TabIndex = 28
        '
        'rptTimeLabel
        '
        Me.rptTimeLabel.AutoSize = True
        Me.rptTimeLabel.Location = New System.Drawing.Point(6, 16)
        Me.rptTimeLabel.Name = "rptTimeLabel"
        Me.rptTimeLabel.Size = New System.Drawing.Size(63, 13)
        Me.rptTimeLabel.TabIndex = 25
        Me.rptTimeLabel.Text = "Time Stamp"
        '
        'pidButton
        '
        Me.pidButton.Enabled = False
        Me.pidButton.Location = New System.Drawing.Point(258, 109)
        Me.pidButton.Name = "pidButton"
        Me.pidButton.Size = New System.Drawing.Size(50, 22)
        Me.pidButton.TabIndex = 22
        Me.pidButton.Text = "Open"
        Me.pidButton.UseVisualStyleBackColor = True
        '
        'pidLabel
        '
        Me.pidLabel.AutoSize = True
        Me.pidLabel.Location = New System.Drawing.Point(6, 112)
        Me.pidLabel.Name = "pidLabel"
        Me.pidLabel.Size = New System.Drawing.Size(44, 13)
        Me.pidLabel.TabIndex = 20
        Me.pidLabel.Text = "PID File"
        '
        'pidBox
        '
        Me.pidBox.Enabled = False
        Me.pidBox.Location = New System.Drawing.Point(97, 110)
        Me.pidBox.Name = "pidBox"
        Me.pidBox.Size = New System.Drawing.Size(155, 20)
        Me.pidBox.TabIndex = 21
        Me.pidBox.Text = "pid.log"
        '
        'rankingButton
        '
        Me.rankingButton.Enabled = False
        Me.rankingButton.Location = New System.Drawing.Point(258, 82)
        Me.rankingButton.Name = "rankingButton"
        Me.rankingButton.Size = New System.Drawing.Size(50, 22)
        Me.rankingButton.TabIndex = 19
        Me.rankingButton.Text = "Open"
        Me.rankingButton.UseVisualStyleBackColor = True
        '
        'rankingLabel
        '
        Me.rankingLabel.AutoSize = True
        Me.rankingLabel.Location = New System.Drawing.Point(6, 85)
        Me.rankingLabel.Name = "rankingLabel"
        Me.rankingLabel.Size = New System.Drawing.Size(66, 13)
        Me.rankingLabel.TabIndex = 17
        Me.rankingLabel.Text = "Ranking File"
        '
        'rankingBox
        '
        Me.rankingBox.Enabled = False
        Me.rankingBox.Location = New System.Drawing.Point(97, 83)
        Me.rankingBox.Name = "rankingBox"
        Me.rankingBox.Size = New System.Drawing.Size(155, 20)
        Me.rankingBox.TabIndex = 18
        Me.rankingBox.Text = "ranking.log"
        '
        'consoleLogButton
        '
        Me.consoleLogButton.Enabled = False
        Me.consoleLogButton.Location = New System.Drawing.Point(258, 53)
        Me.consoleLogButton.Name = "consoleLogButton"
        Me.consoleLogButton.Size = New System.Drawing.Size(50, 22)
        Me.consoleLogButton.TabIndex = 16
        Me.consoleLogButton.Text = "Open"
        Me.consoleLogButton.UseVisualStyleBackColor = True
        '
        'consoleLogLabel
        '
        Me.consoleLogLabel.AutoSize = True
        Me.consoleLogLabel.Location = New System.Drawing.Point(6, 57)
        Me.consoleLogLabel.Name = "consoleLogLabel"
        Me.consoleLogLabel.Size = New System.Drawing.Size(85, 13)
        Me.consoleLogLabel.TabIndex = 14
        Me.consoleLogLabel.Text = "Console Log File"
        '
        'consoleLogBox
        '
        Me.consoleLogBox.Enabled = False
        Me.consoleLogBox.Location = New System.Drawing.Point(97, 54)
        Me.consoleLogBox.Name = "consoleLogBox"
        Me.consoleLogBox.Size = New System.Drawing.Size(155, 20)
        Me.consoleLogBox.TabIndex = 15
        Me.consoleLogBox.Text = "logfile_console.log"
        '
        'settingsGroup
        '
        Me.settingsGroup.Controls.Add(Me.serverDirButton)
        Me.settingsGroup.Controls.Add(Me.serverFileBox)
        Me.settingsGroup.Controls.Add(Me.serverFileLabel)
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
        Me.settingsGroup.Size = New System.Drawing.Size(353, 120)
        Me.settingsGroup.TabIndex = 11
        Me.settingsGroup.TabStop = False
        Me.settingsGroup.Text = "Main"
        '
        'serverDirButton
        '
        Me.serverDirButton.BackColor = System.Drawing.SystemColors.Control
        Me.serverDirButton.BackgroundImage = CType(resources.GetObject("serverDirButton.BackgroundImage"), System.Drawing.Image)
        Me.serverDirButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.serverDirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.serverDirButton.Location = New System.Drawing.Point(320, 39)
        Me.serverDirButton.Name = "serverDirButton"
        Me.serverDirButton.Size = New System.Drawing.Size(24, 20)
        Me.serverDirButton.TabIndex = 2
        Me.serverDirButton.UseVisualStyleBackColor = False
        '
        'serverFileBox
        '
        Me.serverFileBox.Location = New System.Drawing.Point(94, 39)
        Me.serverFileBox.Name = "serverFileBox"
        Me.serverFileBox.Size = New System.Drawing.Size(220, 20)
        Me.serverFileBox.TabIndex = 1
        '
        'serverFileLabel
        '
        Me.serverFileLabel.AutoSize = True
        Me.serverFileLabel.Location = New System.Drawing.Point(6, 42)
        Me.serverFileLabel.Name = "serverFileLabel"
        Me.serverFileLabel.Size = New System.Drawing.Size(57, 13)
        Me.serverFileLabel.TabIndex = 13
        Me.serverFileLabel.Text = "Server File"
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
        Me.portBox.Text = "2302"
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
        Me.maxPlayersBox.Text = "32"
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
        Me.miscTab.BackColor = System.Drawing.Color.LightSkyBlue
        Me.miscTab.Controls.Add(Me.miscGroup)
        Me.miscTab.Controls.Add(Me.modGroup)
        Me.miscTab.Controls.Add(Me.votingGroup)
        Me.miscTab.Controls.Add(Me.vonGroup)
        Me.miscTab.Location = New System.Drawing.Point(4, 22)
        Me.miscTab.Name = "miscTab"
        Me.miscTab.Padding = New System.Windows.Forms.Padding(3)
        Me.miscTab.Size = New System.Drawing.Size(691, 241)
        Me.miscTab.TabIndex = 3
        Me.miscTab.Text = "Misc"
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
        Me.filePatchLabel.Location = New System.Drawing.Point(23, 69)
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
        Me.filePatchCombo.Location = New System.Drawing.Point(133, 66)
        Me.filePatchCombo.MaxDropDownItems = 3
        Me.filePatchCombo.Name = "filePatchCombo"
        Me.filePatchCombo.Size = New System.Drawing.Size(111, 21)
        Me.filePatchCombo.TabIndex = 27
        '
        'verifySigLabel
        '
        Me.verifySigLabel.AutoSize = True
        Me.verifySigLabel.Location = New System.Drawing.Point(23, 96)
        Me.verifySigLabel.Name = "verifySigLabel"
        Me.verifySigLabel.Size = New System.Drawing.Size(86, 13)
        Me.verifySigLabel.TabIndex = 17
        Me.verifySigLabel.Text = "Verify Signatures"
        '
        'requiredBuildBox
        '
        Me.requiredBuildBox.Enabled = False
        Me.requiredBuildBox.Location = New System.Drawing.Point(133, 40)
        Me.requiredBuildBox.Name = "requiredBuildBox"
        Me.requiredBuildBox.Size = New System.Drawing.Size(111, 20)
        Me.requiredBuildBox.TabIndex = 25
        Me.requiredBuildBox.Text = "0"
        '
        'verifySigCombo
        '
        Me.verifySigCombo.BackColor = System.Drawing.SystemColors.Window
        Me.verifySigCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.verifySigCombo.FormattingEnabled = True
        Me.verifySigCombo.Items.AddRange(New Object() {"none", "v1", "v2"})
        Me.verifySigCombo.Location = New System.Drawing.Point(133, 93)
        Me.verifySigCombo.MaxDropDownItems = 3
        Me.verifySigCombo.Name = "verifySigCombo"
        Me.verifySigCombo.Size = New System.Drawing.Size(111, 21)
        Me.verifySigCombo.TabIndex = 23
        '
        'requiredBuildCheck
        '
        Me.requiredBuildCheck.AutoSize = True
        Me.requiredBuildCheck.Location = New System.Drawing.Point(6, 42)
        Me.requiredBuildCheck.Name = "requiredBuildCheck"
        Me.requiredBuildCheck.Size = New System.Drawing.Size(95, 17)
        Me.requiredBuildCheck.TabIndex = 21
        Me.requiredBuildCheck.Text = "Required Build"
        Me.requiredBuildCheck.UseVisualStyleBackColor = True
        '
        'kickDupeCheck
        '
        Me.kickDupeCheck.AutoSize = True
        Me.kickDupeCheck.Location = New System.Drawing.Point(6, 19)
        Me.kickDupeCheck.Name = "kickDupeCheck"
        Me.kickDupeCheck.Size = New System.Drawing.Size(100, 17)
        Me.kickDupeCheck.TabIndex = 15
        Me.kickDupeCheck.Text = "Kick Duplicates"
        Me.kickDupeCheck.UseVisualStyleBackColor = True
        '
        'modGroup
        '
        Me.modGroup.Controls.Add(Me.modTimeLabel)
        Me.modGroup.Controls.Add(Me.modTimeNumeric)
        Me.modGroup.Controls.Add(Me.modBox)
        Me.modGroup.Location = New System.Drawing.Point(313, 6)
        Me.modGroup.Name = "modGroup"
        Me.modGroup.Size = New System.Drawing.Size(372, 229)
        Me.modGroup.TabIndex = 19
        Me.modGroup.TabStop = False
        Me.modGroup.Text = "Message Of The Day"
        '
        'modTimeLabel
        '
        Me.modTimeLabel.AutoSize = True
        Me.modTimeLabel.Location = New System.Drawing.Point(160, 205)
        Me.modTimeLabel.Name = "modTimeLabel"
        Me.modTimeLabel.Size = New System.Drawing.Size(145, 13)
        Me.modTimeLabel.TabIndex = 17
        Me.modTimeLabel.Text = "Seconds Between Messages"
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
        Me.votingGroup.Controls.Add(Me.percentLabel)
        Me.votingGroup.Controls.Add(Me.voteThresholdLabel)
        Me.votingGroup.Controls.Add(Me.minPlayersLabel)
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
        'percentLabel
        '
        Me.percentLabel.AutoSize = True
        Me.percentLabel.Location = New System.Drawing.Point(134, 72)
        Me.percentLabel.Name = "percentLabel"
        Me.percentLabel.Size = New System.Drawing.Size(15, 13)
        Me.percentLabel.TabIndex = 22
        Me.percentLabel.Text = "%"
        '
        'voteThresholdLabel
        '
        Me.voteThresholdLabel.AutoSize = True
        Me.voteThresholdLabel.Location = New System.Drawing.Point(7, 70)
        Me.voteThresholdLabel.Name = "voteThresholdLabel"
        Me.voteThresholdLabel.Size = New System.Drawing.Size(79, 13)
        Me.voteThresholdLabel.TabIndex = 21
        Me.voteThresholdLabel.Text = "Vote Threshold"
        '
        'minPlayersLabel
        '
        Me.minPlayersLabel.AutoSize = True
        Me.minPlayersLabel.Location = New System.Drawing.Point(25, 44)
        Me.minPlayersLabel.Name = "minPlayersLabel"
        Me.minPlayersLabel.Size = New System.Drawing.Size(61, 13)
        Me.minPlayersLabel.TabIndex = 17
        Me.minPlayersLabel.Text = "Min Players"
        '
        'voteThresholdNumeric
        '
        Me.voteThresholdNumeric.Location = New System.Drawing.Point(90, 68)
        Me.voteThresholdNumeric.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.voteThresholdNumeric.Name = "voteThresholdNumeric"
        Me.voteThresholdNumeric.Size = New System.Drawing.Size(43, 20)
        Me.voteThresholdNumeric.TabIndex = 20
        Me.voteThresholdNumeric.Value = New Decimal(New Integer() {33, 0, 0, 0})
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
        Me.vonGroup.Controls.Add(Me.codecLabel)
        Me.vonGroup.Controls.Add(Me.codecNumeric)
        Me.vonGroup.Controls.Add(Me.vonCheck)
        Me.vonGroup.Location = New System.Drawing.Point(171, 135)
        Me.vonGroup.Name = "vonGroup"
        Me.vonGroup.Size = New System.Drawing.Size(136, 100)
        Me.vonGroup.TabIndex = 17
        Me.vonGroup.TabStop = False
        Me.vonGroup.Text = "VON Settings"
        '
        'codecLabel
        '
        Me.codecLabel.AutoSize = True
        Me.codecLabel.Location = New System.Drawing.Point(6, 33)
        Me.codecLabel.Name = "codecLabel"
        Me.codecLabel.Size = New System.Drawing.Size(73, 13)
        Me.codecLabel.TabIndex = 16
        Me.codecLabel.Text = "Codec Quality"
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
        Me.perfTab.BackColor = System.Drawing.Color.LightSkyBlue
        Me.perfTab.Controls.Add(Me.serverPerfGroup)
        Me.perfTab.Controls.Add(Me.clientPerfGroup)
        Me.perfTab.Location = New System.Drawing.Point(4, 22)
        Me.perfTab.Name = "perfTab"
        Me.perfTab.Padding = New System.Windows.Forms.Padding(3)
        Me.perfTab.Size = New System.Drawing.Size(691, 241)
        Me.perfTab.TabIndex = 2
        Me.perfTab.Text = "Perfomance"
        '
        'disconTimeNumeric
        '
        Me.disconTimeNumeric.Enabled = False
        Me.disconTimeNumeric.Location = New System.Drawing.Point(145, 96)
        Me.disconTimeNumeric.Maximum = New Decimal(New Integer() {600, 0, 0, 0})
        Me.disconTimeNumeric.Name = "disconTimeNumeric"
        Me.disconTimeNumeric.Size = New System.Drawing.Size(43, 20)
        Me.disconTimeNumeric.TabIndex = 43
        Me.disconTimeNumeric.Value = New Decimal(New Integer() {90, 0, 0, 0})
        '
        'packetLossNumeric
        '
        Me.packetLossNumeric.Enabled = False
        Me.packetLossNumeric.Location = New System.Drawing.Point(145, 70)
        Me.packetLossNumeric.Name = "packetLossNumeric"
        Me.packetLossNumeric.Size = New System.Drawing.Size(43, 20)
        Me.packetLossNumeric.TabIndex = 42
        '
        'maxDesyncNumeric
        '
        Me.maxDesyncNumeric.Enabled = False
        Me.maxDesyncNumeric.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.maxDesyncNumeric.Location = New System.Drawing.Point(145, 44)
        Me.maxDesyncNumeric.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.maxDesyncNumeric.Name = "maxDesyncNumeric"
        Me.maxDesyncNumeric.Size = New System.Drawing.Size(61, 20)
        Me.maxDesyncNumeric.TabIndex = 41
        '
        'maxPingNumeric
        '
        Me.maxPingNumeric.Enabled = False
        Me.maxPingNumeric.Location = New System.Drawing.Point(145, 18)
        Me.maxPingNumeric.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.maxPingNumeric.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.maxPingNumeric.Name = "maxPingNumeric"
        Me.maxPingNumeric.Size = New System.Drawing.Size(43, 20)
        Me.maxPingNumeric.TabIndex = 40
        Me.maxPingNumeric.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'kickSlowCheck
        '
        Me.kickSlowCheck.AutoSize = True
        Me.kickSlowCheck.Location = New System.Drawing.Point(6, 124)
        Me.kickSlowCheck.Name = "kickSlowCheck"
        Me.kickSlowCheck.Size = New System.Drawing.Size(133, 17)
        Me.kickSlowCheck.TabIndex = 39
        Me.kickSlowCheck.Text = "Kick On Slow Network"
        Me.kickSlowCheck.UseVisualStyleBackColor = True
        '
        'disconTimeCheck
        '
        Me.disconTimeCheck.AutoSize = True
        Me.disconTimeCheck.Location = New System.Drawing.Point(6, 97)
        Me.disconTimeCheck.Name = "disconTimeCheck"
        Me.disconTimeCheck.Size = New System.Drawing.Size(121, 17)
        Me.disconTimeCheck.TabIndex = 38
        Me.disconTimeCheck.Text = "Disconnect Timeout"
        Me.disconTimeCheck.UseVisualStyleBackColor = True
        '
        'packetLossCheck
        '
        Me.packetLossCheck.AutoSize = True
        Me.packetLossCheck.Location = New System.Drawing.Point(6, 71)
        Me.packetLossCheck.Name = "packetLossCheck"
        Me.packetLossCheck.Size = New System.Drawing.Size(108, 17)
        Me.packetLossCheck.TabIndex = 37
        Me.packetLossCheck.Text = "Max Packet Loss"
        Me.packetLossCheck.UseVisualStyleBackColor = True
        '
        'kickSlowCombo
        '
        Me.kickSlowCombo.BackColor = System.Drawing.SystemColors.Window
        Me.kickSlowCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.kickSlowCombo.Enabled = False
        Me.kickSlowCombo.FormattingEnabled = True
        Me.kickSlowCombo.Items.AddRange(New Object() {"Log", "Log & Kick"})
        Me.kickSlowCombo.Location = New System.Drawing.Point(145, 122)
        Me.kickSlowCombo.Name = "kickSlowCombo"
        Me.kickSlowCombo.Size = New System.Drawing.Size(61, 21)
        Me.kickSlowCombo.TabIndex = 36
        '
        'maxDesyncCheck
        '
        Me.maxDesyncCheck.AutoSize = True
        Me.maxDesyncCheck.Location = New System.Drawing.Point(6, 45)
        Me.maxDesyncCheck.Name = "maxDesyncCheck"
        Me.maxDesyncCheck.Size = New System.Drawing.Size(85, 17)
        Me.maxDesyncCheck.TabIndex = 35
        Me.maxDesyncCheck.Text = "Max Desync"
        Me.maxDesyncCheck.UseVisualStyleBackColor = True
        '
        'maxPingCheck
        '
        Me.maxPingCheck.AutoSize = True
        Me.maxPingCheck.Location = New System.Drawing.Point(6, 19)
        Me.maxPingCheck.Name = "maxPingCheck"
        Me.maxPingCheck.Size = New System.Drawing.Size(70, 17)
        Me.maxPingCheck.TabIndex = 34
        Me.maxPingCheck.Text = "Max Ping"
        Me.maxPingCheck.UseVisualStyleBackColor = True
        '
        'filePatchingCheck
        '
        Me.filePatchingCheck.AutoSize = True
        Me.filePatchingCheck.Location = New System.Drawing.Point(9, 19)
        Me.filePatchingCheck.Name = "filePatchingCheck"
        Me.filePatchingCheck.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.filePatchingCheck.Size = New System.Drawing.Size(87, 17)
        Me.filePatchingCheck.TabIndex = 13
        Me.filePatchingCheck.Text = "File Patching"
        Me.filePatchingCheck.UseVisualStyleBackColor = True
        '
        'htCheck
        '
        Me.htCheck.AutoSize = True
        Me.htCheck.Location = New System.Drawing.Point(9, 42)
        Me.htCheck.Name = "htCheck"
        Me.htCheck.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.htCheck.Size = New System.Drawing.Size(134, 17)
        Me.htCheck.TabIndex = 14
        Me.htCheck.Text = "Enable Hyperthreading"
        Me.htCheck.UseVisualStyleBackColor = True
        '
        'missionTab
        '
        Me.missionTab.BackColor = System.Drawing.Color.LightSkyBlue
        Me.missionTab.Controls.Add(Me.persistCheck)
        Me.missionTab.Controls.Add(Me.autoInitCheck)
        Me.missionTab.Location = New System.Drawing.Point(4, 22)
        Me.missionTab.Name = "missionTab"
        Me.missionTab.Size = New System.Drawing.Size(691, 241)
        Me.missionTab.TabIndex = 4
        Me.missionTab.Text = "Missions"
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
        Me.difficultyTab.BackColor = System.Drawing.Color.LightSkyBlue
        Me.difficultyTab.Location = New System.Drawing.Point(4, 22)
        Me.difficultyTab.Name = "difficultyTab"
        Me.difficultyTab.Size = New System.Drawing.Size(691, 241)
        Me.difficultyTab.TabIndex = 5
        Me.difficultyTab.Text = "Difficulty"
        '
        'scriptingTab
        '
        Me.scriptingTab.BackColor = System.Drawing.Color.LightSkyBlue
        Me.scriptingTab.Controls.Add(Me.serverScriptsGroup)
        Me.scriptingTab.Location = New System.Drawing.Point(4, 22)
        Me.scriptingTab.Name = "scriptingTab"
        Me.scriptingTab.Size = New System.Drawing.Size(691, 241)
        Me.scriptingTab.TabIndex = 6
        Me.scriptingTab.Text = "Server Scripting"
        '
        'viewGroup
        '
        Me.viewGroup.Controls.Add(Me.metresLabel)
        Me.viewGroup.Controls.Add(Me.distanceLabel)
        Me.viewGroup.Controls.Add(Me.terrainLabel)
        Me.viewGroup.Controls.Add(Me.distanceNumeric)
        Me.viewGroup.Controls.Add(Me.terrainNumeric)
        Me.viewGroup.Location = New System.Drawing.Point(6, 149)
        Me.viewGroup.Name = "viewGroup"
        Me.viewGroup.Size = New System.Drawing.Size(200, 74)
        Me.viewGroup.TabIndex = 44
        Me.viewGroup.TabStop = False
        Me.viewGroup.Text = "View Settings"
        '
        'clientPerfGroup
        '
        Me.clientPerfGroup.Controls.Add(Me.plPercentLabel)
        Me.clientPerfGroup.Controls.Add(Me.msLabel)
        Me.clientPerfGroup.Controls.Add(Me.sLabel)
        Me.clientPerfGroup.Controls.Add(Me.viewGroup)
        Me.clientPerfGroup.Controls.Add(Me.maxPingCheck)
        Me.clientPerfGroup.Controls.Add(Me.disconTimeNumeric)
        Me.clientPerfGroup.Controls.Add(Me.maxDesyncCheck)
        Me.clientPerfGroup.Controls.Add(Me.packetLossNumeric)
        Me.clientPerfGroup.Controls.Add(Me.kickSlowCombo)
        Me.clientPerfGroup.Controls.Add(Me.maxDesyncNumeric)
        Me.clientPerfGroup.Controls.Add(Me.packetLossCheck)
        Me.clientPerfGroup.Controls.Add(Me.maxPingNumeric)
        Me.clientPerfGroup.Controls.Add(Me.disconTimeCheck)
        Me.clientPerfGroup.Controls.Add(Me.kickSlowCheck)
        Me.clientPerfGroup.Location = New System.Drawing.Point(472, 6)
        Me.clientPerfGroup.Name = "clientPerfGroup"
        Me.clientPerfGroup.Size = New System.Drawing.Size(213, 229)
        Me.clientPerfGroup.TabIndex = 45
        Me.clientPerfGroup.TabStop = False
        Me.clientPerfGroup.Text = "Client"
        '
        'serverPerfGroup
        '
        Me.serverPerfGroup.Controls.Add(Me.moreInfoLabel)
        Me.serverPerfGroup.Controls.Add(Me.perfResetLabel)
        Me.serverPerfGroup.Controls.Add(Me.perfResetButton)
        Me.serverPerfGroup.Controls.Add(Me.extraParamsBox)
        Me.serverPerfGroup.Controls.Add(Me.extraParamsLabel)
        Me.serverPerfGroup.Controls.Add(Me.maxSendLabel)
        Me.serverPerfGroup.Controls.Add(Me.maxSendBox)
        Me.serverPerfGroup.Controls.Add(Me.minErrorLabel)
        Me.serverPerfGroup.Controls.Add(Me.minErrorBox)
        Me.serverPerfGroup.Controls.Add(Me.minErrorNearLabel)
        Me.serverPerfGroup.Controls.Add(Me.minErrorNearBox)
        Me.serverPerfGroup.Controls.Add(Me.maxBandwidthLabel)
        Me.serverPerfGroup.Controls.Add(Me.maxBandwidthBox)
        Me.serverPerfGroup.Controls.Add(Me.minBandwidthLabel)
        Me.serverPerfGroup.Controls.Add(Me.minBandwidthBox)
        Me.serverPerfGroup.Controls.Add(Me.maxNonGuaranteedLabel)
        Me.serverPerfGroup.Controls.Add(Me.maxNonGuaranteedBox)
        Me.serverPerfGroup.Controls.Add(Me.maxGuaranteedLabel)
        Me.serverPerfGroup.Controls.Add(Me.maxGuaranteedBox)
        Me.serverPerfGroup.Controls.Add(Me.maxPacketLabel)
        Me.serverPerfGroup.Controls.Add(Me.maxPacketBox)
        Me.serverPerfGroup.Controls.Add(Me.maxCustFileLabel)
        Me.serverPerfGroup.Controls.Add(Me.maxCustFileBox)
        Me.serverPerfGroup.Controls.Add(Me.filePatchingCheck)
        Me.serverPerfGroup.Controls.Add(Me.htCheck)
        Me.serverPerfGroup.Location = New System.Drawing.Point(6, 6)
        Me.serverPerfGroup.Name = "serverPerfGroup"
        Me.serverPerfGroup.Size = New System.Drawing.Size(460, 229)
        Me.serverPerfGroup.TabIndex = 46
        Me.serverPerfGroup.TabStop = False
        Me.serverPerfGroup.Text = "Server"
        '
        'maxCustFileLabel
        '
        Me.maxCustFileLabel.AutoSize = True
        Me.maxCustFileLabel.Location = New System.Drawing.Point(6, 100)
        Me.maxCustFileLabel.Name = "maxCustFileLabel"
        Me.maxCustFileLabel.Size = New System.Drawing.Size(129, 13)
        Me.maxCustFileLabel.TabIndex = 15
        Me.maxCustFileLabel.Text = "Max Custom File Size (kB)"
        '
        'maxCustFileBox
        '
        Me.maxCustFileBox.Location = New System.Drawing.Point(137, 97)
        Me.maxCustFileBox.Name = "maxCustFileBox"
        Me.maxCustFileBox.Size = New System.Drawing.Size(70, 20)
        Me.maxCustFileBox.TabIndex = 16
        Me.maxCustFileBox.Text = "160"
        '
        'maxPacketLabel
        '
        Me.maxPacketLabel.AutoSize = True
        Me.maxPacketLabel.Location = New System.Drawing.Point(6, 126)
        Me.maxPacketLabel.Name = "maxPacketLabel"
        Me.maxPacketLabel.Size = New System.Drawing.Size(87, 13)
        Me.maxPacketLabel.TabIndex = 17
        Me.maxPacketLabel.Text = "Max Packet Size"
        '
        'maxPacketBox
        '
        Me.maxPacketBox.Location = New System.Drawing.Point(137, 123)
        Me.maxPacketBox.Name = "maxPacketBox"
        Me.maxPacketBox.Size = New System.Drawing.Size(70, 20)
        Me.maxPacketBox.TabIndex = 18
        Me.maxPacketBox.Text = "1400"
        '
        'maxGuaranteedLabel
        '
        Me.maxGuaranteedLabel.AutoSize = True
        Me.maxGuaranteedLabel.Location = New System.Drawing.Point(220, 126)
        Me.maxGuaranteedLabel.Name = "maxGuaranteedLabel"
        Me.maxGuaranteedLabel.Size = New System.Drawing.Size(144, 13)
        Me.maxGuaranteedLabel.TabIndex = 19
        Me.maxGuaranteedLabel.Text = "Max Size Guaranteed (Bytes)"
        '
        'maxGuaranteedBox
        '
        Me.maxGuaranteedBox.Location = New System.Drawing.Point(384, 123)
        Me.maxGuaranteedBox.Name = "maxGuaranteedBox"
        Me.maxGuaranteedBox.Size = New System.Drawing.Size(70, 20)
        Me.maxGuaranteedBox.TabIndex = 20
        Me.maxGuaranteedBox.Text = "512"
        '
        'maxNonGuaranteedLabel
        '
        Me.maxNonGuaranteedLabel.AutoSize = True
        Me.maxNonGuaranteedLabel.Location = New System.Drawing.Point(220, 100)
        Me.maxNonGuaranteedLabel.Name = "maxNonGuaranteedLabel"
        Me.maxNonGuaranteedLabel.Size = New System.Drawing.Size(162, 13)
        Me.maxNonGuaranteedLabel.TabIndex = 21
        Me.maxNonGuaranteedLabel.Text = "Max Size Nonguaranteed (Bytes)"
        '
        'maxNonGuaranteedBox
        '
        Me.maxNonGuaranteedBox.Location = New System.Drawing.Point(384, 97)
        Me.maxNonGuaranteedBox.Name = "maxNonGuaranteedBox"
        Me.maxNonGuaranteedBox.Size = New System.Drawing.Size(70, 20)
        Me.maxNonGuaranteedBox.TabIndex = 22
        Me.maxNonGuaranteedBox.Text = "256"
        '
        'minBandwidthLabel
        '
        Me.minBandwidthLabel.AutoSize = True
        Me.minBandwidthLabel.Location = New System.Drawing.Point(6, 152)
        Me.minBandwidthLabel.Name = "minBandwidthLabel"
        Me.minBandwidthLabel.Size = New System.Drawing.Size(113, 13)
        Me.minBandwidthLabel.TabIndex = 23
        Me.minBandwidthLabel.Text = "Min Bandwidth (kbit/s)"
        '
        'minBandwidthBox
        '
        Me.minBandwidthBox.Location = New System.Drawing.Point(137, 149)
        Me.minBandwidthBox.Name = "minBandwidthBox"
        Me.minBandwidthBox.Size = New System.Drawing.Size(70, 20)
        Me.minBandwidthBox.TabIndex = 24
        Me.minBandwidthBox.Text = "128"
        '
        'maxBandwidthLabel
        '
        Me.maxBandwidthLabel.AutoSize = True
        Me.maxBandwidthLabel.Location = New System.Drawing.Point(6, 178)
        Me.maxBandwidthLabel.Name = "maxBandwidthLabel"
        Me.maxBandwidthLabel.Size = New System.Drawing.Size(118, 13)
        Me.maxBandwidthLabel.TabIndex = 25
        Me.maxBandwidthLabel.Text = "Max Bandwidth (mbit/s)"
        '
        'maxBandwidthBox
        '
        Me.maxBandwidthBox.Location = New System.Drawing.Point(137, 175)
        Me.maxBandwidthBox.Name = "maxBandwidthBox"
        Me.maxBandwidthBox.Size = New System.Drawing.Size(70, 20)
        Me.maxBandwidthBox.TabIndex = 26
        Me.maxBandwidthBox.Text = "2000"
        '
        'minErrorNearLabel
        '
        Me.minErrorNearLabel.AutoSize = True
        Me.minErrorNearLabel.Location = New System.Drawing.Point(220, 178)
        Me.minErrorNearLabel.Name = "minErrorNearLabel"
        Me.minErrorNearLabel.Size = New System.Drawing.Size(119, 13)
        Me.minErrorNearLabel.TabIndex = 27
        Me.minErrorNearLabel.Text = "Min Error To Send Near"
        '
        'minErrorNearBox
        '
        Me.minErrorNearBox.Location = New System.Drawing.Point(384, 175)
        Me.minErrorNearBox.Name = "minErrorNearBox"
        Me.minErrorNearBox.Size = New System.Drawing.Size(70, 20)
        Me.minErrorNearBox.TabIndex = 28
        Me.minErrorNearBox.Text = "0.01"
        '
        'minErrorLabel
        '
        Me.minErrorLabel.AutoSize = True
        Me.minErrorLabel.Location = New System.Drawing.Point(220, 154)
        Me.minErrorLabel.Name = "minErrorLabel"
        Me.minErrorLabel.Size = New System.Drawing.Size(93, 13)
        Me.minErrorLabel.TabIndex = 29
        Me.minErrorLabel.Text = "Min Error To Send"
        '
        'minErrorBox
        '
        Me.minErrorBox.Location = New System.Drawing.Point(384, 149)
        Me.minErrorBox.Name = "minErrorBox"
        Me.minErrorBox.Size = New System.Drawing.Size(70, 20)
        Me.minErrorBox.TabIndex = 30
        Me.minErrorBox.Text = "0.001"
        '
        'maxSendLabel
        '
        Me.maxSendLabel.AutoSize = True
        Me.maxSendLabel.Location = New System.Drawing.Point(220, 74)
        Me.maxSendLabel.Name = "maxSendLabel"
        Me.maxSendLabel.Size = New System.Drawing.Size(106, 13)
        Me.maxSendLabel.TabIndex = 31
        Me.maxSendLabel.Text = "Max Messages Send"
        '
        'maxSendBox
        '
        Me.maxSendBox.Location = New System.Drawing.Point(384, 71)
        Me.maxSendBox.Name = "maxSendBox"
        Me.maxSendBox.Size = New System.Drawing.Size(70, 20)
        Me.maxSendBox.TabIndex = 32
        Me.maxSendBox.Text = "128"
        '
        'extraParamsLabel
        '
        Me.extraParamsLabel.AutoSize = True
        Me.extraParamsLabel.Location = New System.Drawing.Point(6, 204)
        Me.extraParamsLabel.Name = "extraParamsLabel"
        Me.extraParamsLabel.Size = New System.Drawing.Size(87, 13)
        Me.extraParamsLabel.TabIndex = 33
        Me.extraParamsLabel.Text = "Extra Parameters"
        '
        'extraParamsBox
        '
        Me.extraParamsBox.Location = New System.Drawing.Point(136, 201)
        Me.extraParamsBox.Name = "extraParamsBox"
        Me.extraParamsBox.Size = New System.Drawing.Size(318, 20)
        Me.extraParamsBox.TabIndex = 34
        '
        'perfResetButton
        '
        Me.perfResetButton.Location = New System.Drawing.Point(136, 67)
        Me.perfResetButton.Name = "perfResetButton"
        Me.perfResetButton.Size = New System.Drawing.Size(71, 23)
        Me.perfResetButton.TabIndex = 35
        Me.perfResetButton.Text = "Reset"
        Me.perfResetButton.UseVisualStyleBackColor = True
        '
        'perfResetLabel
        '
        Me.perfResetLabel.AutoSize = True
        Me.perfResetLabel.Location = New System.Drawing.Point(6, 74)
        Me.perfResetLabel.Name = "perfResetLabel"
        Me.perfResetLabel.Size = New System.Drawing.Size(84, 13)
        Me.perfResetLabel.TabIndex = 36
        Me.perfResetLabel.Text = "Reset All Values"
        '
        'moreInfoLabel
        '
        Me.moreInfoLabel.AutoSize = True
        Me.moreInfoLabel.Location = New System.Drawing.Point(402, 16)
        Me.moreInfoLabel.Name = "moreInfoLabel"
        Me.moreInfoLabel.Size = New System.Drawing.Size(52, 13)
        Me.moreInfoLabel.TabIndex = 37
        Me.moreInfoLabel.TabStop = True
        Me.moreInfoLabel.Text = "More Info"
        '
        'metresLabel
        '
        Me.metresLabel.AutoSize = True
        Me.metresLabel.Location = New System.Drawing.Point(154, 48)
        Me.metresLabel.Name = "metresLabel"
        Me.metresLabel.Size = New System.Drawing.Size(38, 13)
        Me.metresLabel.TabIndex = 27
        Me.metresLabel.Text = "metres"
        '
        'distanceLabel
        '
        Me.distanceLabel.AutoSize = True
        Me.distanceLabel.Location = New System.Drawing.Point(6, 48)
        Me.distanceLabel.Name = "distanceLabel"
        Me.distanceLabel.Size = New System.Drawing.Size(75, 13)
        Me.distanceLabel.TabIndex = 26
        Me.distanceLabel.Text = "View Distance"
        '
        'terrainLabel
        '
        Me.terrainLabel.AutoSize = True
        Me.terrainLabel.Location = New System.Drawing.Point(6, 22)
        Me.terrainLabel.Name = "terrainLabel"
        Me.terrainLabel.Size = New System.Drawing.Size(62, 13)
        Me.terrainLabel.TabIndex = 23
        Me.terrainLabel.Text = "Terrain Grid"
        '
        'distanceNumeric
        '
        Me.distanceNumeric.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.distanceNumeric.Location = New System.Drawing.Point(87, 46)
        Me.distanceNumeric.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.distanceNumeric.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.distanceNumeric.Name = "distanceNumeric"
        Me.distanceNumeric.Size = New System.Drawing.Size(61, 20)
        Me.distanceNumeric.TabIndex = 25
        Me.distanceNumeric.Value = New Decimal(New Integer() {2500, 0, 0, 0})
        '
        'terrainNumeric
        '
        Me.terrainNumeric.DecimalPlaces = 3
        Me.terrainNumeric.Location = New System.Drawing.Point(87, 20)
        Me.terrainNumeric.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.terrainNumeric.Minimum = New Decimal(New Integer() {3125, 0, 0, 196608})
        Me.terrainNumeric.Name = "terrainNumeric"
        Me.terrainNumeric.Size = New System.Drawing.Size(61, 20)
        Me.terrainNumeric.TabIndex = 24
        Me.terrainNumeric.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'sLabel
        '
        Me.sLabel.AutoSize = True
        Me.sLabel.Location = New System.Drawing.Point(189, 98)
        Me.sLabel.Name = "sLabel"
        Me.sLabel.Size = New System.Drawing.Size(12, 13)
        Me.sLabel.TabIndex = 45
        Me.sLabel.Text = "s"
        '
        'msLabel
        '
        Me.msLabel.AutoSize = True
        Me.msLabel.Location = New System.Drawing.Point(189, 20)
        Me.msLabel.Name = "msLabel"
        Me.msLabel.Size = New System.Drawing.Size(20, 13)
        Me.msLabel.TabIndex = 46
        Me.msLabel.Text = "ms"
        '
        'plPercentLabel
        '
        Me.plPercentLabel.AutoSize = True
        Me.plPercentLabel.Location = New System.Drawing.Point(189, 72)
        Me.plPercentLabel.Name = "plPercentLabel"
        Me.plPercentLabel.Size = New System.Drawing.Size(15, 13)
        Me.plPercentLabel.TabIndex = 47
        Me.plPercentLabel.Text = "%"
        '
        'serverScriptsGroup
        '
        Me.serverScriptsGroup.Controls.Add(Me.regularCheckLabel)
        Me.serverScriptsGroup.Controls.Add(Me.onUnsignedDataLabel)
        Me.serverScriptsGroup.Controls.Add(Me.onDifferentDataLabel)
        Me.serverScriptsGroup.Controls.Add(Me.onUnsignedDataBox)
        Me.serverScriptsGroup.Controls.Add(Me.regularCheckBox)
        Me.serverScriptsGroup.Controls.Add(Me.onDifferentDataBox)
        Me.serverScriptsGroup.Controls.Add(Me.onHackedDataBox)
        Me.serverScriptsGroup.Controls.Add(Me.onHackedDataLabel)
        Me.serverScriptsGroup.Controls.Add(Me.onUserDisconnectedLabel)
        Me.serverScriptsGroup.Controls.Add(Me.onUserConnectedLabel)
        Me.serverScriptsGroup.Controls.Add(Me.doubleIdDetectedLabel)
        Me.serverScriptsGroup.Controls.Add(Me.onUserConnectedBox)
        Me.serverScriptsGroup.Controls.Add(Me.onUserDisconnectedBox)
        Me.serverScriptsGroup.Controls.Add(Me.doubleIdDetectedBox)
        Me.serverScriptsGroup.Controls.Add(Me.serverCommandBox)
        Me.serverScriptsGroup.Controls.Add(Me.serverCommandLabel)
        Me.serverScriptsGroup.Location = New System.Drawing.Point(6, 6)
        Me.serverScriptsGroup.Name = "serverScriptsGroup"
        Me.serverScriptsGroup.Size = New System.Drawing.Size(680, 229)
        Me.serverScriptsGroup.TabIndex = 0
        Me.serverScriptsGroup.TabStop = False
        Me.serverScriptsGroup.Text = "Server Side Scripting"
        '
        'serverCommandLabel
        '
        Me.serverCommandLabel.AutoSize = True
        Me.serverCommandLabel.Location = New System.Drawing.Point(8, 25)
        Me.serverCommandLabel.Name = "serverCommandLabel"
        Me.serverCommandLabel.Size = New System.Drawing.Size(137, 13)
        Me.serverCommandLabel.TabIndex = 0
        Me.serverCommandLabel.Text = "Server Command Password"
        '
        'serverCommandBox
        '
        Me.serverCommandBox.Location = New System.Drawing.Point(151, 22)
        Me.serverCommandBox.Name = "serverCommandBox"
        Me.serverCommandBox.Size = New System.Drawing.Size(200, 45)
        Me.serverCommandBox.TabIndex = 5
        Me.serverCommandBox.Text = ""
        '
        'doubleIdDetectedBox
        '
        Me.doubleIdDetectedBox.Location = New System.Drawing.Point(151, 73)
        Me.doubleIdDetectedBox.Name = "doubleIdDetectedBox"
        Me.doubleIdDetectedBox.Size = New System.Drawing.Size(200, 45)
        Me.doubleIdDetectedBox.TabIndex = 6
        Me.doubleIdDetectedBox.Text = ""
        '
        'onUserDisconnectedBox
        '
        Me.onUserDisconnectedBox.Location = New System.Drawing.Point(151, 175)
        Me.onUserDisconnectedBox.Name = "onUserDisconnectedBox"
        Me.onUserDisconnectedBox.Size = New System.Drawing.Size(200, 45)
        Me.onUserDisconnectedBox.TabIndex = 7
        Me.onUserDisconnectedBox.Text = ""
        '
        'onUserConnectedBox
        '
        Me.onUserConnectedBox.Location = New System.Drawing.Point(151, 124)
        Me.onUserConnectedBox.Name = "onUserConnectedBox"
        Me.onUserConnectedBox.Size = New System.Drawing.Size(200, 45)
        Me.onUserConnectedBox.TabIndex = 8
        Me.onUserConnectedBox.Text = ""
        '
        'doubleIdDetectedLabel
        '
        Me.doubleIdDetectedLabel.AutoSize = True
        Me.doubleIdDetectedLabel.Location = New System.Drawing.Point(8, 76)
        Me.doubleIdDetectedLabel.Name = "doubleIdDetectedLabel"
        Me.doubleIdDetectedLabel.Size = New System.Drawing.Size(92, 13)
        Me.doubleIdDetectedLabel.TabIndex = 9
        Me.doubleIdDetectedLabel.Text = "doubleIdDetected"
        '
        'onUserConnectedLabel
        '
        Me.onUserConnectedLabel.AutoSize = True
        Me.onUserConnectedLabel.Location = New System.Drawing.Point(8, 127)
        Me.onUserConnectedLabel.Name = "onUserConnectedLabel"
        Me.onUserConnectedLabel.Size = New System.Drawing.Size(93, 13)
        Me.onUserConnectedLabel.TabIndex = 10
        Me.onUserConnectedLabel.Text = "onUserConnected"
        '
        'onUserDisconnectedLabel
        '
        Me.onUserDisconnectedLabel.AutoSize = True
        Me.onUserDisconnectedLabel.Location = New System.Drawing.Point(8, 178)
        Me.onUserDisconnectedLabel.Name = "onUserDisconnectedLabel"
        Me.onUserDisconnectedLabel.Size = New System.Drawing.Size(107, 13)
        Me.onUserDisconnectedLabel.TabIndex = 11
        Me.onUserDisconnectedLabel.Text = "onUserDisconnected"
        '
        'regularCheckLabel
        '
        Me.regularCheckLabel.AutoSize = True
        Me.regularCheckLabel.Location = New System.Drawing.Point(381, 178)
        Me.regularCheckLabel.Name = "regularCheckLabel"
        Me.regularCheckLabel.Size = New System.Drawing.Size(70, 13)
        Me.regularCheckLabel.TabIndex = 19
        Me.regularCheckLabel.Text = "regularCheck"
        '
        'onUnsignedDataLabel
        '
        Me.onUnsignedDataLabel.AutoSize = True
        Me.onUnsignedDataLabel.Location = New System.Drawing.Point(381, 127)
        Me.onUnsignedDataLabel.Name = "onUnsignedDataLabel"
        Me.onUnsignedDataLabel.Size = New System.Drawing.Size(87, 13)
        Me.onUnsignedDataLabel.TabIndex = 18
        Me.onUnsignedDataLabel.Text = "onUnsignedData"
        '
        'onDifferentDataLabel
        '
        Me.onDifferentDataLabel.AutoSize = True
        Me.onDifferentDataLabel.Location = New System.Drawing.Point(381, 76)
        Me.onDifferentDataLabel.Name = "onDifferentDataLabel"
        Me.onDifferentDataLabel.Size = New System.Drawing.Size(82, 13)
        Me.onDifferentDataLabel.TabIndex = 17
        Me.onDifferentDataLabel.Text = "onDifferentData"
        '
        'onUnsignedDataBox
        '
        Me.onUnsignedDataBox.Location = New System.Drawing.Point(474, 124)
        Me.onUnsignedDataBox.Name = "onUnsignedDataBox"
        Me.onUnsignedDataBox.Size = New System.Drawing.Size(200, 45)
        Me.onUnsignedDataBox.TabIndex = 16
        Me.onUnsignedDataBox.Text = ""
        '
        'regularCheckBox
        '
        Me.regularCheckBox.Location = New System.Drawing.Point(474, 175)
        Me.regularCheckBox.Name = "regularCheckBox"
        Me.regularCheckBox.Size = New System.Drawing.Size(200, 45)
        Me.regularCheckBox.TabIndex = 15
        Me.regularCheckBox.Text = ""
        '
        'onDifferentDataBox
        '
        Me.onDifferentDataBox.Location = New System.Drawing.Point(474, 73)
        Me.onDifferentDataBox.Name = "onDifferentDataBox"
        Me.onDifferentDataBox.Size = New System.Drawing.Size(200, 45)
        Me.onDifferentDataBox.TabIndex = 14
        Me.onDifferentDataBox.Text = ""
        '
        'onHackedDataBox
        '
        Me.onHackedDataBox.Location = New System.Drawing.Point(474, 22)
        Me.onHackedDataBox.Name = "onHackedDataBox"
        Me.onHackedDataBox.Size = New System.Drawing.Size(200, 45)
        Me.onHackedDataBox.TabIndex = 13
        Me.onHackedDataBox.Text = ""
        '
        'onHackedDataLabel
        '
        Me.onHackedDataLabel.AutoSize = True
        Me.onHackedDataLabel.Location = New System.Drawing.Point(381, 25)
        Me.onHackedDataLabel.Name = "onHackedDataLabel"
        Me.onHackedDataLabel.Size = New System.Drawing.Size(80, 13)
        Me.onHackedDataLabel.TabIndex = 12
        Me.onHackedDataLabel.Text = "onHackedData"
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
        Me.loggingGroup.ResumeLayout(False)
        Me.loggingGroup.PerformLayout()
        Me.netlogGroup.ResumeLayout(False)
        Me.rptGroup.ResumeLayout(False)
        Me.rptGroup.PerformLayout()
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
        CType(Me.disconTimeNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.packetLossNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maxDesyncNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maxPingNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.missionTab.ResumeLayout(False)
        Me.missionTab.PerformLayout()
        Me.scriptingTab.ResumeLayout(False)
        Me.viewGroup.ResumeLayout(False)
        Me.viewGroup.PerformLayout()
        Me.clientPerfGroup.ResumeLayout(False)
        Me.clientPerfGroup.PerformLayout()
        Me.serverPerfGroup.ResumeLayout(False)
        Me.serverPerfGroup.PerformLayout()
        CType(Me.distanceNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.terrainNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.serverScriptsGroup.ResumeLayout(False)
        Me.serverScriptsGroup.PerformLayout()
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
    Friend WithEvents loggingGroup As GroupBox
    Friend WithEvents settingsGroup As GroupBox
    Friend WithEvents serverDirButton As Button
    Friend WithEvents serverFileBox As TextBox
    Friend WithEvents serverFileLabel As Label
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
    Friend WithEvents noOfHCLabel As Label
    Friend WithEvents enableHCCheck As CheckBox
    Friend WithEvents localClientBox As TextBox
    Friend WithEvents headlessIPBox As TextBox
    Friend WithEvents localClientsLabel As Label
    Friend WithEvents hcIPLabel As Label
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
    Friend WithEvents percentLabel As Label
    Friend WithEvents voteThresholdLabel As Label
    Friend WithEvents minPlayersLabel As Label
    Friend WithEvents voteThresholdNumeric As NumericUpDown
    Friend WithEvents minPlayersNumeric As NumericUpDown
    Friend WithEvents voteCheck As CheckBox
    Friend WithEvents vonGroup As GroupBox
    Friend WithEvents codecLabel As Label
    Friend WithEvents codecNumeric As NumericUpDown
    Friend WithEvents miscGroup As GroupBox
    Friend WithEvents verifySigCombo As ComboBox
    Friend WithEvents requiredBuildCheck As CheckBox
    Friend WithEvents battleyeCheck As CheckBox
    Friend WithEvents modTimeLabel As Label
    Friend WithEvents modTimeNumeric As NumericUpDown
    Friend WithEvents filePatchLabel As Label
    Friend WithEvents filePatchCombo As ComboBox
    Friend WithEvents verifySigLabel As Label
    Friend WithEvents requiredBuildBox As TextBox
    Friend WithEvents disconTimeNumeric As NumericUpDown
    Friend WithEvents packetLossNumeric As NumericUpDown
    Friend WithEvents maxDesyncNumeric As NumericUpDown
    Friend WithEvents maxPingNumeric As NumericUpDown
    Friend WithEvents kickSlowCheck As CheckBox
    Friend WithEvents disconTimeCheck As CheckBox
    Friend WithEvents packetLossCheck As CheckBox
    Friend WithEvents kickSlowCombo As ComboBox
    Friend WithEvents maxDesyncCheck As CheckBox
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
    Friend WithEvents consoleLogButton As Button
    Friend WithEvents consoleLogLabel As Label
    Friend WithEvents consoleLogBox As TextBox
    Friend WithEvents netlogGroup As GroupBox
    Friend WithEvents netRotButton As Button
    Friend WithEvents netDelButton As Button
    Friend WithEvents netOpenButton As Button
    Friend WithEvents rptGroup As GroupBox
    Friend WithEvents rptDeleteButton As Button
    Friend WithEvents rptOpenButton As Button
    Friend WithEvents rptTimeCombo As ComboBox
    Friend WithEvents rptTimeLabel As Label
    Friend WithEvents pidButton As Button
    Friend WithEvents pidLabel As Label
    Friend WithEvents pidBox As TextBox
    Friend WithEvents rankingButton As Button
    Friend WithEvents rankingLabel As Label
    Friend WithEvents rankingBox As TextBox
    Friend WithEvents rankingCheck As CheckBox
    Friend WithEvents pidCheck As CheckBox
    Friend WithEvents consoleLogCheck As CheckBox
    Friend WithEvents serverPerfGroup As GroupBox
    Friend WithEvents clientPerfGroup As GroupBox
    Friend WithEvents viewGroup As GroupBox
    Friend WithEvents extraParamsBox As TextBox
    Friend WithEvents extraParamsLabel As Label
    Friend WithEvents maxSendLabel As Label
    Friend WithEvents maxSendBox As TextBox
    Friend WithEvents minErrorLabel As Label
    Friend WithEvents minErrorBox As TextBox
    Friend WithEvents minErrorNearLabel As Label
    Friend WithEvents minErrorNearBox As TextBox
    Friend WithEvents maxBandwidthLabel As Label
    Friend WithEvents maxBandwidthBox As TextBox
    Friend WithEvents minBandwidthLabel As Label
    Friend WithEvents minBandwidthBox As TextBox
    Friend WithEvents maxNonGuaranteedLabel As Label
    Friend WithEvents maxNonGuaranteedBox As TextBox
    Friend WithEvents maxGuaranteedLabel As Label
    Friend WithEvents maxGuaranteedBox As TextBox
    Friend WithEvents maxPacketLabel As Label
    Friend WithEvents maxPacketBox As TextBox
    Friend WithEvents maxCustFileLabel As Label
    Friend WithEvents maxCustFileBox As TextBox
    Friend WithEvents moreInfoLabel As LinkLabel
    Friend WithEvents perfResetLabel As Label
    Friend WithEvents perfResetButton As Button
    Friend WithEvents metresLabel As Label
    Friend WithEvents distanceLabel As Label
    Friend WithEvents terrainLabel As Label
    Friend WithEvents distanceNumeric As NumericUpDown
    Friend WithEvents terrainNumeric As NumericUpDown
    Friend WithEvents msLabel As Label
    Friend WithEvents sLabel As Label
    Friend WithEvents plPercentLabel As Label
    Friend WithEvents serverScriptsGroup As GroupBox
    Friend WithEvents regularCheckLabel As Label
    Friend WithEvents onUnsignedDataLabel As Label
    Friend WithEvents onDifferentDataLabel As Label
    Friend WithEvents onUnsignedDataBox As RichTextBox
    Friend WithEvents regularCheckBox As RichTextBox
    Friend WithEvents onDifferentDataBox As RichTextBox
    Friend WithEvents onHackedDataBox As RichTextBox
    Friend WithEvents onHackedDataLabel As Label
    Friend WithEvents onUserDisconnectedLabel As Label
    Friend WithEvents onUserConnectedLabel As Label
    Friend WithEvents doubleIdDetectedLabel As Label
    Friend WithEvents onUserConnectedBox As RichTextBox
    Friend WithEvents onUserDisconnectedBox As RichTextBox
    Friend WithEvents doubleIdDetectedBox As RichTextBox
    Friend WithEvents serverCommandBox As RichTextBox
    Friend WithEvents serverCommandLabel As Label
End Class
