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
        Me.launchServerButton = New System.Windows.Forms.Button()
        Me.profileGroup = New System.Windows.Forms.GroupBox()
        Me.deleteProfileButton = New System.Windows.Forms.Button()
        Me.exportButton = New System.Windows.Forms.Button()
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
        Me.upnpCheck = New System.Windows.Forms.CheckBox()
        Me.loopbackCheck = New System.Windows.Forms.CheckBox()
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
        Me.voteMinPlayersNumeric = New System.Windows.Forms.NumericUpDown()
        Me.voteCheck = New System.Windows.Forms.CheckBox()
        Me.vonGroup = New System.Windows.Forms.GroupBox()
        Me.codecLabel = New System.Windows.Forms.Label()
        Me.codecNumeric = New System.Windows.Forms.NumericUpDown()
        Me.vonCheck = New System.Windows.Forms.CheckBox()
        Me.missionTab = New System.Windows.Forms.TabPage()
        Me.missionsGroup = New System.Windows.Forms.GroupBox()
        Me.difficultyLabel = New System.Windows.Forms.Label()
        Me.autoInitCheck = New System.Windows.Forms.CheckBox()
        Me.persistCheck = New System.Windows.Forms.CheckBox()
        Me.difficultyCombo = New System.Windows.Forms.ComboBox()
        Me.missionRefreshButton = New System.Windows.Forms.Button()
        Me.missionsNoneButton = New System.Windows.Forms.Button()
        Me.missionsAllButton = New System.Windows.Forms.Button()
        Me.missionsList = New System.Windows.Forms.CheckedListBox()
        Me.customDifficutlyGroup = New System.Windows.Forms.GroupBox()
        Me.tacticalPingCheck = New System.Windows.Forms.CheckBox()
        Me.aiSettingsGroup = New System.Windows.Forms.GroupBox()
        Me.aiAccuracyLabel = New System.Windows.Forms.Label()
        Me.aiSkillLabel = New System.Windows.Forms.Label()
        Me.aiPresetLabel = New System.Windows.Forms.Label()
        Me.aiAccuracyNumeric = New System.Windows.Forms.NumericUpDown()
        Me.aiSkillNumeric = New System.Windows.Forms.NumericUpDown()
        Me.aiPresetNumeric = New System.Windows.Forms.NumericUpDown()
        Me.multipleSavesCheck = New System.Windows.Forms.CheckBox()
        Me.autoReportingCheck = New System.Windows.Forms.CheckBox()
        Me.mapContentCheck = New System.Windows.Forms.CheckBox()
        Me.vonIDCheck = New System.Windows.Forms.CheckBox()
        Me.killedByCheck = New System.Windows.Forms.CheckBox()
        Me.scoreTableCheck = New System.Windows.Forms.CheckBox()
        Me.cameraShakeCheck = New System.Windows.Forms.CheckBox()
        Me.thirdPersonCheck = New System.Windows.Forms.CheckBox()
        Me.visualAidCheck = New System.Windows.Forms.CheckBox()
        Me.crosshairCheck = New System.Windows.Forms.CheckBox()
        Me.staminaBarCheck = New System.Windows.Forms.CheckBox()
        Me.stanceIndicatorCheck = New System.Windows.Forms.CheckBox()
        Me.weaponInfoCheck = New System.Windows.Forms.CheckBox()
        Me.waypointsCheck = New System.Windows.Forms.CheckBox()
        Me.commandsCheck = New System.Windows.Forms.CheckBox()
        Me.detectedMinesCheck = New System.Windows.Forms.CheckBox()
        Me.enemyNameCheck = New System.Windows.Forms.CheckBox()
        Me.friendlyNameCheck = New System.Windows.Forms.CheckBox()
        Me.groupIndicatorCheck = New System.Windows.Forms.CheckBox()
        Me.reducedDamageCheck = New System.Windows.Forms.CheckBox()
        Me.perfTab = New System.Windows.Forms.TabPage()
        Me.serverPerfGroup = New System.Windows.Forms.GroupBox()
        Me.moreInfoLabel = New System.Windows.Forms.LinkLabel()
        Me.perfResetLabel = New System.Windows.Forms.Label()
        Me.perfResetButton = New System.Windows.Forms.Button()
        Me.extraParamsBox = New System.Windows.Forms.TextBox()
        Me.extraParamsLabel = New System.Windows.Forms.Label()
        Me.maxSendLabel = New System.Windows.Forms.Label()
        Me.maxSendBox = New System.Windows.Forms.TextBox()
        Me.minErrorLabel = New System.Windows.Forms.Label()
        Me.minErrorBox = New System.Windows.Forms.TextBox()
        Me.minErrorNearLabel = New System.Windows.Forms.Label()
        Me.minErrorNearBox = New System.Windows.Forms.TextBox()
        Me.maxBandwidthLabel = New System.Windows.Forms.Label()
        Me.maxBandwidthBox = New System.Windows.Forms.TextBox()
        Me.minBandwidthLabel = New System.Windows.Forms.Label()
        Me.minBandwidthBox = New System.Windows.Forms.TextBox()
        Me.maxNonGuaranteedLabel = New System.Windows.Forms.Label()
        Me.maxNonGuaranteedBox = New System.Windows.Forms.TextBox()
        Me.maxGuaranteedLabel = New System.Windows.Forms.Label()
        Me.maxGuaranteedBox = New System.Windows.Forms.TextBox()
        Me.maxPacketLabel = New System.Windows.Forms.Label()
        Me.maxPacketBox = New System.Windows.Forms.TextBox()
        Me.maxCustFileLabel = New System.Windows.Forms.Label()
        Me.maxCustFileBox = New System.Windows.Forms.TextBox()
        Me.filePatchingCheck = New System.Windows.Forms.CheckBox()
        Me.htCheck = New System.Windows.Forms.CheckBox()
        Me.clientPerfGroup = New System.Windows.Forms.GroupBox()
        Me.plPercentLabel = New System.Windows.Forms.Label()
        Me.msLabel = New System.Windows.Forms.Label()
        Me.sLabel = New System.Windows.Forms.Label()
        Me.viewGroup = New System.Windows.Forms.GroupBox()
        Me.metresLabel = New System.Windows.Forms.Label()
        Me.distanceLabel = New System.Windows.Forms.Label()
        Me.terrainLabel = New System.Windows.Forms.Label()
        Me.distanceNumeric = New System.Windows.Forms.NumericUpDown()
        Me.terrainNumeric = New System.Windows.Forms.NumericUpDown()
        Me.maxPingCheck = New System.Windows.Forms.CheckBox()
        Me.disconTimeNumeric = New System.Windows.Forms.NumericUpDown()
        Me.maxDesyncCheck = New System.Windows.Forms.CheckBox()
        Me.packetLossNumeric = New System.Windows.Forms.NumericUpDown()
        Me.kickSlowCombo = New System.Windows.Forms.ComboBox()
        Me.maxDesyncNumeric = New System.Windows.Forms.NumericUpDown()
        Me.packetLossCheck = New System.Windows.Forms.CheckBox()
        Me.maxPingNumeric = New System.Windows.Forms.NumericUpDown()
        Me.disconTimeCheck = New System.Windows.Forms.CheckBox()
        Me.kickSlowCheck = New System.Windows.Forms.CheckBox()
        Me.scriptingTab = New System.Windows.Forms.TabPage()
        Me.serverScriptsGroup = New System.Windows.Forms.GroupBox()
        Me.regularCheckLabel = New System.Windows.Forms.Label()
        Me.onUnsignedDataLabel = New System.Windows.Forms.Label()
        Me.onDifferentDataLabel = New System.Windows.Forms.Label()
        Me.onUnsignedDataBox = New System.Windows.Forms.RichTextBox()
        Me.regularCheckBox = New System.Windows.Forms.RichTextBox()
        Me.onDifferentDataBox = New System.Windows.Forms.RichTextBox()
        Me.onHackedDataBox = New System.Windows.Forms.RichTextBox()
        Me.onHackedDataLabel = New System.Windows.Forms.Label()
        Me.onUserDisconnectedLabel = New System.Windows.Forms.Label()
        Me.onUserConnectedLabel = New System.Windows.Forms.Label()
        Me.doubleIdDetectedLabel = New System.Windows.Forms.Label()
        Me.onUserConnectedBox = New System.Windows.Forms.RichTextBox()
        Me.onUserDisconnectedBox = New System.Windows.Forms.RichTextBox()
        Me.doubleIdDetectedBox = New System.Windows.Forms.RichTextBox()
        Me.serverCommandBox = New System.Windows.Forms.RichTextBox()
        Me.serverCommandLabel = New System.Windows.Forms.Label()
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
        CType(Me.voteMinPlayersNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.vonGroup.SuspendLayout()
        CType(Me.codecNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.missionTab.SuspendLayout()
        Me.missionsGroup.SuspendLayout()
        Me.customDifficutlyGroup.SuspendLayout()
        Me.aiSettingsGroup.SuspendLayout()
        CType(Me.aiAccuracyNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.aiSkillNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.aiPresetNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.perfTab.SuspendLayout()
        Me.serverPerfGroup.SuspendLayout()
        Me.clientPerfGroup.SuspendLayout()
        Me.viewGroup.SuspendLayout()
        CType(Me.distanceNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.terrainNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.disconTimeNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.packetLossNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maxDesyncNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maxPingNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scriptingTab.SuspendLayout()
        Me.serverScriptsGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'profileNameBox
        '
        Me.profileNameBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.profileNameBox.Location = New System.Drawing.Point(12, 42)
        Me.profileNameBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.profileNameBox.Name = "profileNameBox"
        Me.profileNameBox.Size = New System.Drawing.Size(288, 32)
        Me.profileNameBox.TabIndex = 16
        Me.profileNameBox.Text = "New Server"
        '
        'launchServerButton
        '
        Me.launchServerButton.Location = New System.Drawing.Point(1224, 40)
        Me.launchServerButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.launchServerButton.Name = "launchServerButton"
        Me.launchServerButton.Size = New System.Drawing.Size(150, 42)
        Me.launchServerButton.TabIndex = 20
        Me.launchServerButton.Text = "Launch"
        Me.launchServerButton.UseVisualStyleBackColor = True
        '
        'profileGroup
        '
        Me.profileGroup.Controls.Add(Me.deleteProfileButton)
        Me.profileGroup.Controls.Add(Me.exportButton)
        Me.profileGroup.Controls.Add(Me.saveProfileButton)
        Me.profileGroup.Controls.Add(Me.profileNameBox)
        Me.profileGroup.Controls.Add(Me.launchServerButton)
        Me.profileGroup.Controls.Add(Me.battleyeCheck)
        Me.profileGroup.Location = New System.Drawing.Point(6, 525)
        Me.profileGroup.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.profileGroup.Name = "profileGroup"
        Me.profileGroup.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.profileGroup.Size = New System.Drawing.Size(1386, 106)
        Me.profileGroup.TabIndex = 3
        Me.profileGroup.TabStop = False
        Me.profileGroup.Text = "Server Profile"
        '
        'deleteProfileButton
        '
        Me.deleteProfileButton.Location = New System.Drawing.Point(428, 40)
        Me.deleteProfileButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.deleteProfileButton.Name = "deleteProfileButton"
        Me.deleteProfileButton.Size = New System.Drawing.Size(100, 42)
        Me.deleteProfileButton.TabIndex = 18
        Me.deleteProfileButton.Text = "Delete"
        Me.deleteProfileButton.UseVisualStyleBackColor = True
        '
        'exportButton
        '
        Me.exportButton.Location = New System.Drawing.Point(1062, 40)
        Me.exportButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.exportButton.Name = "exportButton"
        Me.exportButton.Size = New System.Drawing.Size(150, 42)
        Me.exportButton.TabIndex = 19
        Me.exportButton.Text = "Export"
        Me.exportButton.UseVisualStyleBackColor = True
        '
        'saveProfileButton
        '
        Me.saveProfileButton.Location = New System.Drawing.Point(316, 40)
        Me.saveProfileButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.saveProfileButton.Name = "saveProfileButton"
        Me.saveProfileButton.Size = New System.Drawing.Size(100, 42)
        Me.saveProfileButton.TabIndex = 17
        Me.saveProfileButton.Text = "Save"
        Me.saveProfileButton.UseVisualStyleBackColor = True
        '
        'battleyeCheck
        '
        Me.battleyeCheck.AutoSize = True
        Me.battleyeCheck.Location = New System.Drawing.Point(920, 48)
        Me.battleyeCheck.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.battleyeCheck.Name = "battleyeCheck"
        Me.battleyeCheck.Size = New System.Drawing.Size(124, 29)
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
        Me.modsTab.Location = New System.Drawing.Point(8, 39)
        Me.modsTab.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.modsTab.Name = "modsTab"
        Me.modsTab.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.modsTab.Size = New System.Drawing.Size(1382, 466)
        Me.modsTab.TabIndex = 1
        Me.modsTab.Text = "Mods"
        '
        'refreshModsButton
        '
        Me.refreshModsButton.Location = New System.Drawing.Point(668, 158)
        Me.refreshModsButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.refreshModsButton.Name = "refreshModsButton"
        Me.refreshModsButton.Size = New System.Drawing.Size(48, 44)
        Me.refreshModsButton.TabIndex = 4
        Me.refreshModsButton.Text = "" & Global.Microsoft.VisualBasic.ChrW(9) & "↻"
        Me.refreshModsButton.UseVisualStyleBackColor = True
        '
        'hcToServerButton
        '
        Me.hcToServerButton.Location = New System.Drawing.Point(668, 102)
        Me.hcToServerButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.hcToServerButton.Name = "hcToServerButton"
        Me.hcToServerButton.Size = New System.Drawing.Size(48, 44)
        Me.hcToServerButton.TabIndex = 3
        Me.hcToServerButton.Text = "<"
        Me.hcToServerButton.UseVisualStyleBackColor = True
        '
        'serverToHCButton
        '
        Me.serverToHCButton.Location = New System.Drawing.Point(668, 46)
        Me.serverToHCButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.serverToHCButton.Name = "serverToHCButton"
        Me.serverToHCButton.Size = New System.Drawing.Size(48, 44)
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
        Me.hcModsGroup.Location = New System.Drawing.Point(730, 12)
        Me.hcModsGroup.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.hcModsGroup.Name = "hcModsGroup"
        Me.hcModsGroup.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.hcModsGroup.Size = New System.Drawing.Size(640, 440)
        Me.hcModsGroup.TabIndex = 1
        Me.hcModsGroup.TabStop = False
        Me.hcModsGroup.Text = "Headless Client Mods"
        '
        'hcModsSortButton
        '
        Me.hcModsSortButton.Location = New System.Drawing.Point(356, 385)
        Me.hcModsSortButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.hcModsSortButton.Name = "hcModsSortButton"
        Me.hcModsSortButton.Size = New System.Drawing.Size(100, 44)
        Me.hcModsSortButton.TabIndex = 11
        Me.hcModsSortButton.Text = "Sort"
        Me.hcModsSortButton.UseVisualStyleBackColor = True
        '
        'hcModsDownButton
        '
        Me.hcModsDownButton.Location = New System.Drawing.Point(296, 385)
        Me.hcModsDownButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.hcModsDownButton.Name = "hcModsDownButton"
        Me.hcModsDownButton.Size = New System.Drawing.Size(48, 44)
        Me.hcModsDownButton.TabIndex = 10
        Me.hcModsDownButton.Text = "˅"
        Me.hcModsDownButton.UseVisualStyleBackColor = True
        '
        'hcModsUpButton
        '
        Me.hcModsUpButton.Location = New System.Drawing.Point(236, 385)
        Me.hcModsUpButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.hcModsUpButton.Name = "hcModsUpButton"
        Me.hcModsUpButton.Size = New System.Drawing.Size(48, 44)
        Me.hcModsUpButton.TabIndex = 9
        Me.hcModsUpButton.Text = "˄"
        Me.hcModsUpButton.UseVisualStyleBackColor = True
        '
        'hcModsNoneButton
        '
        Me.hcModsNoneButton.Location = New System.Drawing.Point(124, 385)
        Me.hcModsNoneButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.hcModsNoneButton.Name = "hcModsNoneButton"
        Me.hcModsNoneButton.Size = New System.Drawing.Size(100, 44)
        Me.hcModsNoneButton.TabIndex = 8
        Me.hcModsNoneButton.Text = "None"
        Me.hcModsNoneButton.UseVisualStyleBackColor = True
        '
        'hcModsAllButton
        '
        Me.hcModsAllButton.Location = New System.Drawing.Point(12, 385)
        Me.hcModsAllButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.hcModsAllButton.Name = "hcModsAllButton"
        Me.hcModsAllButton.Size = New System.Drawing.Size(100, 44)
        Me.hcModsAllButton.TabIndex = 7
        Me.hcModsAllButton.Text = "All"
        Me.hcModsAllButton.UseVisualStyleBackColor = True
        '
        'hcModsList
        '
        Me.hcModsList.FormattingEnabled = True
        Me.hcModsList.Location = New System.Drawing.Point(12, 37)
        Me.hcModsList.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.hcModsList.Name = "hcModsList"
        Me.hcModsList.ScrollAlwaysVisible = True
        Me.hcModsList.Size = New System.Drawing.Size(602, 316)
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
        Me.serverModsGroup.Location = New System.Drawing.Point(12, 12)
        Me.serverModsGroup.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.serverModsGroup.Name = "serverModsGroup"
        Me.serverModsGroup.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.serverModsGroup.Size = New System.Drawing.Size(640, 440)
        Me.serverModsGroup.TabIndex = 0
        Me.serverModsGroup.TabStop = False
        Me.serverModsGroup.Text = "Server Mods"
        '
        'serverModsSortButton
        '
        Me.serverModsSortButton.Location = New System.Drawing.Point(356, 385)
        Me.serverModsSortButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.serverModsSortButton.Name = "serverModsSortButton"
        Me.serverModsSortButton.Size = New System.Drawing.Size(100, 44)
        Me.serverModsSortButton.TabIndex = 6
        Me.serverModsSortButton.Text = "Sort"
        Me.serverModsSortButton.UseVisualStyleBackColor = True
        '
        'serverModsDownButton
        '
        Me.serverModsDownButton.Location = New System.Drawing.Point(296, 385)
        Me.serverModsDownButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.serverModsDownButton.Name = "serverModsDownButton"
        Me.serverModsDownButton.Size = New System.Drawing.Size(48, 44)
        Me.serverModsDownButton.TabIndex = 5
        Me.serverModsDownButton.Text = "˅"
        Me.serverModsDownButton.UseVisualStyleBackColor = True
        '
        'serverModsUpButton
        '
        Me.serverModsUpButton.Location = New System.Drawing.Point(236, 385)
        Me.serverModsUpButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.serverModsUpButton.Name = "serverModsUpButton"
        Me.serverModsUpButton.Size = New System.Drawing.Size(48, 44)
        Me.serverModsUpButton.TabIndex = 4
        Me.serverModsUpButton.Text = "˄"
        Me.serverModsUpButton.UseVisualStyleBackColor = True
        '
        'serverModsNoneButton
        '
        Me.serverModsNoneButton.Location = New System.Drawing.Point(124, 385)
        Me.serverModsNoneButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.serverModsNoneButton.Name = "serverModsNoneButton"
        Me.serverModsNoneButton.Size = New System.Drawing.Size(100, 44)
        Me.serverModsNoneButton.TabIndex = 2
        Me.serverModsNoneButton.Text = "None"
        Me.serverModsNoneButton.UseVisualStyleBackColor = True
        '
        'serverModsAllButton
        '
        Me.serverModsAllButton.Location = New System.Drawing.Point(12, 385)
        Me.serverModsAllButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.serverModsAllButton.Name = "serverModsAllButton"
        Me.serverModsAllButton.Size = New System.Drawing.Size(100, 44)
        Me.serverModsAllButton.TabIndex = 1
        Me.serverModsAllButton.Text = "All"
        Me.serverModsAllButton.UseVisualStyleBackColor = True
        '
        'serverModsList
        '
        Me.serverModsList.FormattingEnabled = True
        Me.serverModsList.Location = New System.Drawing.Point(12, 37)
        Me.serverModsList.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.serverModsList.Name = "serverModsList"
        Me.serverModsList.ScrollAlwaysVisible = True
        Me.serverModsList.Size = New System.Drawing.Size(602, 316)
        Me.serverModsList.TabIndex = 0
        '
        'settingsTab
        '
        Me.settingsTab.BackColor = System.Drawing.Color.LightSkyBlue
        Me.settingsTab.Controls.Add(Me.networkGroup)
        Me.settingsTab.Controls.Add(Me.headlessGroup)
        Me.settingsTab.Controls.Add(Me.loggingGroup)
        Me.settingsTab.Controls.Add(Me.settingsGroup)
        Me.settingsTab.Location = New System.Drawing.Point(8, 39)
        Me.settingsTab.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.settingsTab.Name = "settingsTab"
        Me.settingsTab.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.settingsTab.Size = New System.Drawing.Size(1382, 466)
        Me.settingsTab.TabIndex = 0
        Me.settingsTab.Text = "Settings"
        '
        'networkGroup
        '
        Me.networkGroup.Controls.Add(Me.netlogCheck)
        Me.networkGroup.Controls.Add(Me.upnpCheck)
        Me.networkGroup.Controls.Add(Me.loopbackCheck)
        Me.networkGroup.Location = New System.Drawing.Point(552, 254)
        Me.networkGroup.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.networkGroup.Name = "networkGroup"
        Me.networkGroup.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.networkGroup.Size = New System.Drawing.Size(166, 198)
        Me.networkGroup.TabIndex = 13
        Me.networkGroup.TabStop = False
        Me.networkGroup.Text = "Network"
        '
        'netlogCheck
        '
        Me.netlogCheck.AutoSize = True
        Me.netlogCheck.BackColor = System.Drawing.Color.LightSkyBlue
        Me.netlogCheck.Location = New System.Drawing.Point(12, 137)
        Me.netlogCheck.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.netlogCheck.Name = "netlogCheck"
        Me.netlogCheck.Size = New System.Drawing.Size(106, 29)
        Me.netlogCheck.TabIndex = 14
        Me.netlogCheck.Text = "Netlog"
        Me.netlogCheck.UseVisualStyleBackColor = False
        '
        'upnpCheck
        '
        Me.upnpCheck.AutoSize = True
        Me.upnpCheck.Location = New System.Drawing.Point(12, 92)
        Me.upnpCheck.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.upnpCheck.Name = "upnpCheck"
        Me.upnpCheck.Size = New System.Drawing.Size(102, 29)
        Me.upnpCheck.TabIndex = 14
        Me.upnpCheck.Text = "UPNP"
        Me.upnpCheck.UseVisualStyleBackColor = True
        '
        'loopbackCheck
        '
        Me.loopbackCheck.AutoSize = True
        Me.loopbackCheck.Location = New System.Drawing.Point(12, 48)
        Me.loopbackCheck.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.loopbackCheck.Name = "loopbackCheck"
        Me.loopbackCheck.Size = New System.Drawing.Size(138, 29)
        Me.loopbackCheck.TabIndex = 15
        Me.loopbackCheck.Text = "Loopback"
        Me.loopbackCheck.UseVisualStyleBackColor = True
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
        Me.headlessGroup.Location = New System.Drawing.Point(12, 254)
        Me.headlessGroup.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.headlessGroup.Name = "headlessGroup"
        Me.headlessGroup.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.headlessGroup.Size = New System.Drawing.Size(528, 198)
        Me.headlessGroup.TabIndex = 12
        Me.headlessGroup.TabStop = False
        Me.headlessGroup.Text = "Headless Client"
        '
        'noOfHCNumeric
        '
        Me.noOfHCNumeric.Enabled = False
        Me.noOfHCNumeric.Location = New System.Drawing.Point(268, 33)
        Me.noOfHCNumeric.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.noOfHCNumeric.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.noOfHCNumeric.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.noOfHCNumeric.Name = "noOfHCNumeric"
        Me.noOfHCNumeric.Size = New System.Drawing.Size(84, 31)
        Me.noOfHCNumeric.TabIndex = 14
        Me.noOfHCNumeric.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'noOfHCLabel
        '
        Me.noOfHCLabel.AutoSize = True
        Me.noOfHCLabel.Location = New System.Drawing.Point(148, 38)
        Me.noOfHCLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.noOfHCLabel.Name = "noOfHCLabel"
        Me.noOfHCLabel.Size = New System.Drawing.Size(116, 25)
        Me.noOfHCLabel.TabIndex = 16
        Me.noOfHCLabel.Text = "No. of HCs"
        '
        'enableHCCheck
        '
        Me.enableHCCheck.AutoSize = True
        Me.enableHCCheck.Location = New System.Drawing.Point(362, 37)
        Me.enableHCCheck.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.enableHCCheck.Name = "enableHCCheck"
        Me.enableHCCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.enableHCCheck.Size = New System.Drawing.Size(147, 29)
        Me.enableHCCheck.TabIndex = 14
        Me.enableHCCheck.Text = "Enable HC"
        Me.enableHCCheck.UseVisualStyleBackColor = True
        '
        'localClientBox
        '
        Me.localClientBox.Enabled = False
        Me.localClientBox.Location = New System.Drawing.Point(162, 131)
        Me.localClientBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.localClientBox.Name = "localClientBox"
        Me.localClientBox.Size = New System.Drawing.Size(350, 31)
        Me.localClientBox.TabIndex = 3
        Me.localClientBox.Text = "127.0.0.1"
        '
        'headlessIPBox
        '
        Me.headlessIPBox.Enabled = False
        Me.headlessIPBox.Location = New System.Drawing.Point(162, 81)
        Me.headlessIPBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.headlessIPBox.Name = "headlessIPBox"
        Me.headlessIPBox.Size = New System.Drawing.Size(350, 31)
        Me.headlessIPBox.TabIndex = 2
        Me.headlessIPBox.Text = "127.0.0.1"
        '
        'localClientsLabel
        '
        Me.localClientsLabel.AutoSize = True
        Me.localClientsLabel.Location = New System.Drawing.Point(12, 137)
        Me.localClientsLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.localClientsLabel.Name = "localClientsLabel"
        Me.localClientsLabel.Size = New System.Drawing.Size(136, 25)
        Me.localClientsLabel.TabIndex = 1
        Me.localClientsLabel.Text = "Local Clients"
        '
        'hcIPLabel
        '
        Me.hcIPLabel.AutoSize = True
        Me.hcIPLabel.Location = New System.Drawing.Point(12, 87)
        Me.hcIPLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.hcIPLabel.Name = "hcIPLabel"
        Me.hcIPLabel.Size = New System.Drawing.Size(138, 25)
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
        Me.loggingGroup.Location = New System.Drawing.Point(730, 12)
        Me.loggingGroup.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.loggingGroup.Name = "loggingGroup"
        Me.loggingGroup.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.loggingGroup.Size = New System.Drawing.Size(640, 440)
        Me.loggingGroup.TabIndex = 12
        Me.loggingGroup.TabStop = False
        Me.loggingGroup.Text = "Logging"
        '
        'rankingCheck
        '
        Me.rankingCheck.AutoSize = True
        Me.rankingCheck.BackColor = System.Drawing.Color.LightSkyBlue
        Me.rankingCheck.Location = New System.Drawing.Point(234, 40)
        Me.rankingCheck.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.rankingCheck.Name = "rankingCheck"
        Me.rankingCheck.Size = New System.Drawing.Size(164, 29)
        Me.rankingCheck.TabIndex = 26
        Me.rankingCheck.Text = "Ranking File"
        Me.rankingCheck.UseVisualStyleBackColor = False
        '
        'pidCheck
        '
        Me.pidCheck.AutoSize = True
        Me.pidCheck.Location = New System.Drawing.Point(502, 40)
        Me.pidCheck.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.pidCheck.Name = "pidCheck"
        Me.pidCheck.Size = New System.Drawing.Size(119, 29)
        Me.pidCheck.TabIndex = 25
        Me.pidCheck.Text = "PID File"
        Me.pidCheck.UseVisualStyleBackColor = True
        '
        'consoleLogCheck
        '
        Me.consoleLogCheck.AutoSize = True
        Me.consoleLogCheck.Location = New System.Drawing.Point(12, 40)
        Me.consoleLogCheck.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.consoleLogCheck.Name = "consoleLogCheck"
        Me.consoleLogCheck.Size = New System.Drawing.Size(165, 29)
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
        Me.netlogGroup.Location = New System.Drawing.Point(328, 281)
        Me.netlogGroup.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.netlogGroup.Name = "netlogGroup"
        Me.netlogGroup.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.netlogGroup.Size = New System.Drawing.Size(300, 148)
        Me.netlogGroup.TabIndex = 24
        Me.netlogGroup.TabStop = False
        Me.netlogGroup.Text = "Netlog"
        '
        'netRotButton
        '
        Me.netRotButton.Location = New System.Drawing.Point(168, 25)
        Me.netRotButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.netRotButton.Name = "netRotButton"
        Me.netRotButton.Size = New System.Drawing.Size(120, 42)
        Me.netRotButton.TabIndex = 32
        Me.netRotButton.Text = "Rotate"
        Me.netRotButton.UseVisualStyleBackColor = True
        '
        'netDelButton
        '
        Me.netDelButton.Location = New System.Drawing.Point(168, 92)
        Me.netDelButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.netDelButton.Name = "netDelButton"
        Me.netDelButton.Size = New System.Drawing.Size(120, 42)
        Me.netDelButton.TabIndex = 31
        Me.netDelButton.Text = "Delete"
        Me.netDelButton.UseVisualStyleBackColor = True
        '
        'netOpenButton
        '
        Me.netOpenButton.Location = New System.Drawing.Point(12, 92)
        Me.netOpenButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.netOpenButton.Name = "netOpenButton"
        Me.netOpenButton.Size = New System.Drawing.Size(120, 42)
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
        Me.rptGroup.Location = New System.Drawing.Point(12, 281)
        Me.rptGroup.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.rptGroup.Name = "rptGroup"
        Me.rptGroup.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.rptGroup.Size = New System.Drawing.Size(300, 148)
        Me.rptGroup.TabIndex = 23
        Me.rptGroup.TabStop = False
        Me.rptGroup.Text = "RPT"
        '
        'rptDeleteButton
        '
        Me.rptDeleteButton.Location = New System.Drawing.Point(168, 92)
        Me.rptDeleteButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.rptDeleteButton.Name = "rptDeleteButton"
        Me.rptDeleteButton.Size = New System.Drawing.Size(120, 42)
        Me.rptDeleteButton.TabIndex = 29
        Me.rptDeleteButton.Text = "Delete"
        Me.rptDeleteButton.UseVisualStyleBackColor = True
        '
        'rptOpenButton
        '
        Me.rptOpenButton.Location = New System.Drawing.Point(12, 92)
        Me.rptOpenButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.rptOpenButton.Name = "rptOpenButton"
        Me.rptOpenButton.Size = New System.Drawing.Size(120, 42)
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
        Me.rptTimeCombo.Location = New System.Drawing.Point(170, 25)
        Me.rptTimeCombo.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.rptTimeCombo.MaxDropDownItems = 3
        Me.rptTimeCombo.Name = "rptTimeCombo"
        Me.rptTimeCombo.Size = New System.Drawing.Size(112, 33)
        Me.rptTimeCombo.TabIndex = 28
        '
        'rptTimeLabel
        '
        Me.rptTimeLabel.AutoSize = True
        Me.rptTimeLabel.Location = New System.Drawing.Point(12, 31)
        Me.rptTimeLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.rptTimeLabel.Name = "rptTimeLabel"
        Me.rptTimeLabel.Size = New System.Drawing.Size(126, 25)
        Me.rptTimeLabel.TabIndex = 25
        Me.rptTimeLabel.Text = "Time Stamp"
        '
        'pidButton
        '
        Me.pidButton.Enabled = False
        Me.pidButton.Location = New System.Drawing.Point(516, 210)
        Me.pidButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.pidButton.Name = "pidButton"
        Me.pidButton.Size = New System.Drawing.Size(100, 42)
        Me.pidButton.TabIndex = 22
        Me.pidButton.Text = "Open"
        Me.pidButton.UseVisualStyleBackColor = True
        '
        'pidLabel
        '
        Me.pidLabel.AutoSize = True
        Me.pidLabel.Location = New System.Drawing.Point(12, 215)
        Me.pidLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.pidLabel.Name = "pidLabel"
        Me.pidLabel.Size = New System.Drawing.Size(87, 25)
        Me.pidLabel.TabIndex = 20
        Me.pidLabel.Text = "PID File"
        '
        'pidBox
        '
        Me.pidBox.Enabled = False
        Me.pidBox.Location = New System.Drawing.Point(194, 212)
        Me.pidBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.pidBox.Name = "pidBox"
        Me.pidBox.Size = New System.Drawing.Size(306, 31)
        Me.pidBox.TabIndex = 21
        Me.pidBox.Text = "pid.log"
        '
        'rankingButton
        '
        Me.rankingButton.Enabled = False
        Me.rankingButton.Location = New System.Drawing.Point(516, 158)
        Me.rankingButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.rankingButton.Name = "rankingButton"
        Me.rankingButton.Size = New System.Drawing.Size(100, 42)
        Me.rankingButton.TabIndex = 19
        Me.rankingButton.Text = "Open"
        Me.rankingButton.UseVisualStyleBackColor = True
        '
        'rankingLabel
        '
        Me.rankingLabel.AutoSize = True
        Me.rankingLabel.Location = New System.Drawing.Point(12, 163)
        Me.rankingLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.rankingLabel.Name = "rankingLabel"
        Me.rankingLabel.Size = New System.Drawing.Size(132, 25)
        Me.rankingLabel.TabIndex = 17
        Me.rankingLabel.Text = "Ranking File"
        '
        'rankingBox
        '
        Me.rankingBox.Enabled = False
        Me.rankingBox.Location = New System.Drawing.Point(194, 160)
        Me.rankingBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.rankingBox.Name = "rankingBox"
        Me.rankingBox.Size = New System.Drawing.Size(306, 31)
        Me.rankingBox.TabIndex = 18
        Me.rankingBox.Text = "ranking.log"
        '
        'consoleLogButton
        '
        Me.consoleLogButton.Enabled = False
        Me.consoleLogButton.Location = New System.Drawing.Point(516, 102)
        Me.consoleLogButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.consoleLogButton.Name = "consoleLogButton"
        Me.consoleLogButton.Size = New System.Drawing.Size(100, 42)
        Me.consoleLogButton.TabIndex = 16
        Me.consoleLogButton.Text = "Open"
        Me.consoleLogButton.UseVisualStyleBackColor = True
        '
        'consoleLogLabel
        '
        Me.consoleLogLabel.AutoSize = True
        Me.consoleLogLabel.Location = New System.Drawing.Point(12, 110)
        Me.consoleLogLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.consoleLogLabel.Name = "consoleLogLabel"
        Me.consoleLogLabel.Size = New System.Drawing.Size(174, 25)
        Me.consoleLogLabel.TabIndex = 14
        Me.consoleLogLabel.Text = "Console Log File"
        '
        'consoleLogBox
        '
        Me.consoleLogBox.Enabled = False
        Me.consoleLogBox.Location = New System.Drawing.Point(194, 104)
        Me.consoleLogBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.consoleLogBox.Name = "consoleLogBox"
        Me.consoleLogBox.Size = New System.Drawing.Size(306, 31)
        Me.consoleLogBox.TabIndex = 15
        Me.consoleLogBox.Text = "server_console.log"
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
        Me.settingsGroup.Location = New System.Drawing.Point(12, 12)
        Me.settingsGroup.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.settingsGroup.Name = "settingsGroup"
        Me.settingsGroup.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.settingsGroup.Size = New System.Drawing.Size(706, 231)
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
        Me.serverDirButton.Location = New System.Drawing.Point(640, 75)
        Me.serverDirButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.serverDirButton.Name = "serverDirButton"
        Me.serverDirButton.Size = New System.Drawing.Size(48, 38)
        Me.serverDirButton.TabIndex = 2
        Me.serverDirButton.UseVisualStyleBackColor = False
        '
        'serverFileBox
        '
        Me.serverFileBox.Location = New System.Drawing.Point(188, 75)
        Me.serverFileBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.serverFileBox.Name = "serverFileBox"
        Me.serverFileBox.Size = New System.Drawing.Size(436, 31)
        Me.serverFileBox.TabIndex = 1
        '
        'serverFileLabel
        '
        Me.serverFileLabel.AutoSize = True
        Me.serverFileLabel.Location = New System.Drawing.Point(12, 81)
        Me.serverFileLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.serverFileLabel.Name = "serverFileLabel"
        Me.serverFileLabel.Size = New System.Drawing.Size(116, 25)
        Me.serverFileLabel.TabIndex = 13
        Me.serverFileLabel.Text = "Server File"
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Location = New System.Drawing.Point(12, 31)
        Me.nameLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(137, 25)
        Me.nameLabel.TabIndex = 0
        Me.nameLabel.Text = "Server Name"
        '
        'serverNameBox
        '
        Me.serverNameBox.Location = New System.Drawing.Point(188, 25)
        Me.serverNameBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.serverNameBox.Name = "serverNameBox"
        Me.serverNameBox.Size = New System.Drawing.Size(496, 31)
        Me.serverNameBox.TabIndex = 0
        '
        'portBox
        '
        Me.portBox.Location = New System.Drawing.Point(564, 175)
        Me.portBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.portBox.Name = "portBox"
        Me.portBox.Size = New System.Drawing.Size(120, 31)
        Me.portBox.TabIndex = 6
        Me.portBox.Text = "2302"
        '
        'passwordLabel
        '
        Me.passwordLabel.AutoSize = True
        Me.passwordLabel.Location = New System.Drawing.Point(12, 131)
        Me.passwordLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.passwordLabel.Name = "passwordLabel"
        Me.passwordLabel.Size = New System.Drawing.Size(106, 25)
        Me.passwordLabel.TabIndex = 2
        Me.passwordLabel.Text = "Password"
        '
        'maxPlayersLabel
        '
        Me.maxPlayersLabel.AutoSize = True
        Me.maxPlayersLabel.Location = New System.Drawing.Point(424, 131)
        Me.maxPlayersLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.maxPlayersLabel.Name = "maxPlayersLabel"
        Me.maxPlayersLabel.Size = New System.Drawing.Size(131, 25)
        Me.maxPlayersLabel.TabIndex = 8
        Me.maxPlayersLabel.Text = "Max Players"
        '
        'passwordBox
        '
        Me.passwordBox.Location = New System.Drawing.Point(188, 125)
        Me.passwordBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.passwordBox.Name = "passwordBox"
        Me.passwordBox.Size = New System.Drawing.Size(210, 31)
        Me.passwordBox.TabIndex = 3
        '
        'maxPlayersBox
        '
        Me.maxPlayersBox.Location = New System.Drawing.Point(564, 125)
        Me.maxPlayersBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.maxPlayersBox.Name = "maxPlayersBox"
        Me.maxPlayersBox.Size = New System.Drawing.Size(120, 31)
        Me.maxPlayersBox.TabIndex = 5
        Me.maxPlayersBox.Text = "32"
        '
        'adminPassLabel
        '
        Me.adminPassLabel.AutoSize = True
        Me.adminPassLabel.Location = New System.Drawing.Point(12, 181)
        Me.adminPassLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.adminPassLabel.Name = "adminPassLabel"
        Me.adminPassLabel.Size = New System.Drawing.Size(166, 25)
        Me.adminPassLabel.TabIndex = 4
        Me.adminPassLabel.Text = "AdminPassword"
        '
        'portLabel
        '
        Me.portLabel.AutoSize = True
        Me.portLabel.Location = New System.Drawing.Point(500, 181)
        Me.portLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.portLabel.Name = "portLabel"
        Me.portLabel.Size = New System.Drawing.Size(51, 25)
        Me.portLabel.TabIndex = 6
        Me.portLabel.Text = "Port"
        '
        'adminPassBox
        '
        Me.adminPassBox.Location = New System.Drawing.Point(188, 175)
        Me.adminPassBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.adminPassBox.Name = "adminPassBox"
        Me.adminPassBox.Size = New System.Drawing.Size(210, 31)
        Me.adminPassBox.TabIndex = 4
        '
        'serverTabs
        '
        Me.serverTabs.Controls.Add(Me.settingsTab)
        Me.serverTabs.Controls.Add(Me.miscTab)
        Me.serverTabs.Controls.Add(Me.modsTab)
        Me.serverTabs.Controls.Add(Me.missionTab)
        Me.serverTabs.Controls.Add(Me.perfTab)
        Me.serverTabs.Controls.Add(Me.scriptingTab)
        Me.serverTabs.Dock = System.Windows.Forms.DockStyle.Top
        Me.serverTabs.Location = New System.Drawing.Point(0, 0)
        Me.serverTabs.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.serverTabs.Name = "serverTabs"
        Me.serverTabs.SelectedIndex = 0
        Me.serverTabs.Size = New System.Drawing.Size(1398, 513)
        Me.serverTabs.TabIndex = 4
        '
        'miscTab
        '
        Me.miscTab.BackColor = System.Drawing.Color.LightSkyBlue
        Me.miscTab.Controls.Add(Me.miscGroup)
        Me.miscTab.Controls.Add(Me.modGroup)
        Me.miscTab.Controls.Add(Me.votingGroup)
        Me.miscTab.Controls.Add(Me.vonGroup)
        Me.miscTab.Location = New System.Drawing.Point(8, 39)
        Me.miscTab.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.miscTab.Name = "miscTab"
        Me.miscTab.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.miscTab.Size = New System.Drawing.Size(1382, 466)
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
        Me.miscGroup.Location = New System.Drawing.Point(12, 12)
        Me.miscGroup.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.miscGroup.Name = "miscGroup"
        Me.miscGroup.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.miscGroup.Size = New System.Drawing.Size(602, 237)
        Me.miscGroup.TabIndex = 20
        Me.miscGroup.TabStop = False
        Me.miscGroup.Text = "Main"
        '
        'filePatchLabel
        '
        Me.filePatchLabel.AutoSize = True
        Me.filePatchLabel.Location = New System.Drawing.Point(46, 133)
        Me.filePatchLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.filePatchLabel.Name = "filePatchLabel"
        Me.filePatchLabel.Size = New System.Drawing.Size(194, 25)
        Me.filePatchLabel.TabIndex = 26
        Me.filePatchLabel.Text = "Allow File Patching"
        '
        'filePatchCombo
        '
        Me.filePatchCombo.BackColor = System.Drawing.SystemColors.Window
        Me.filePatchCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.filePatchCombo.FormattingEnabled = True
        Me.filePatchCombo.Items.AddRange(New Object() {"0", "1", "2"})
        Me.filePatchCombo.Location = New System.Drawing.Point(266, 127)
        Me.filePatchCombo.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.filePatchCombo.MaxDropDownItems = 3
        Me.filePatchCombo.Name = "filePatchCombo"
        Me.filePatchCombo.Size = New System.Drawing.Size(218, 33)
        Me.filePatchCombo.TabIndex = 27
        '
        'verifySigLabel
        '
        Me.verifySigLabel.AutoSize = True
        Me.verifySigLabel.Location = New System.Drawing.Point(46, 185)
        Me.verifySigLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.verifySigLabel.Name = "verifySigLabel"
        Me.verifySigLabel.Size = New System.Drawing.Size(176, 25)
        Me.verifySigLabel.TabIndex = 17
        Me.verifySigLabel.Text = "Verify Signatures"
        '
        'requiredBuildBox
        '
        Me.requiredBuildBox.Enabled = False
        Me.requiredBuildBox.Location = New System.Drawing.Point(266, 77)
        Me.requiredBuildBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.requiredBuildBox.Name = "requiredBuildBox"
        Me.requiredBuildBox.Size = New System.Drawing.Size(218, 31)
        Me.requiredBuildBox.TabIndex = 25
        Me.requiredBuildBox.Text = "0"
        '
        'verifySigCombo
        '
        Me.verifySigCombo.BackColor = System.Drawing.SystemColors.Window
        Me.verifySigCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.verifySigCombo.FormattingEnabled = True
        Me.verifySigCombo.Items.AddRange(New Object() {"0", "1", "2"})
        Me.verifySigCombo.Location = New System.Drawing.Point(266, 179)
        Me.verifySigCombo.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.verifySigCombo.MaxDropDownItems = 3
        Me.verifySigCombo.Name = "verifySigCombo"
        Me.verifySigCombo.Size = New System.Drawing.Size(218, 33)
        Me.verifySigCombo.TabIndex = 23
        '
        'requiredBuildCheck
        '
        Me.requiredBuildCheck.AutoSize = True
        Me.requiredBuildCheck.Location = New System.Drawing.Point(12, 81)
        Me.requiredBuildCheck.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.requiredBuildCheck.Name = "requiredBuildCheck"
        Me.requiredBuildCheck.Size = New System.Drawing.Size(185, 29)
        Me.requiredBuildCheck.TabIndex = 21
        Me.requiredBuildCheck.Text = "Required Build"
        Me.requiredBuildCheck.UseVisualStyleBackColor = True
        '
        'kickDupeCheck
        '
        Me.kickDupeCheck.AutoSize = True
        Me.kickDupeCheck.Location = New System.Drawing.Point(12, 37)
        Me.kickDupeCheck.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.kickDupeCheck.Name = "kickDupeCheck"
        Me.kickDupeCheck.Size = New System.Drawing.Size(192, 29)
        Me.kickDupeCheck.TabIndex = 15
        Me.kickDupeCheck.Text = "Kick Duplicates"
        Me.kickDupeCheck.UseVisualStyleBackColor = True
        '
        'modGroup
        '
        Me.modGroup.Controls.Add(Me.modTimeLabel)
        Me.modGroup.Controls.Add(Me.modTimeNumeric)
        Me.modGroup.Controls.Add(Me.modBox)
        Me.modGroup.Location = New System.Drawing.Point(626, 12)
        Me.modGroup.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.modGroup.Name = "modGroup"
        Me.modGroup.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.modGroup.Size = New System.Drawing.Size(744, 440)
        Me.modGroup.TabIndex = 19
        Me.modGroup.TabStop = False
        Me.modGroup.Text = "Message Of The Day"
        '
        'modTimeLabel
        '
        Me.modTimeLabel.AutoSize = True
        Me.modTimeLabel.Location = New System.Drawing.Point(320, 394)
        Me.modTimeLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.modTimeLabel.Name = "modTimeLabel"
        Me.modTimeLabel.Size = New System.Drawing.Size(290, 25)
        Me.modTimeLabel.TabIndex = 17
        Me.modTimeLabel.Text = "Seconds Between Messages"
        '
        'modTimeNumeric
        '
        Me.modTimeNumeric.Location = New System.Drawing.Point(622, 390)
        Me.modTimeNumeric.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.modTimeNumeric.Maximum = New Decimal(New Integer() {600, 0, 0, 0})
        Me.modTimeNumeric.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.modTimeNumeric.Name = "modTimeNumeric"
        Me.modTimeNumeric.Size = New System.Drawing.Size(110, 31)
        Me.modTimeNumeric.TabIndex = 17
        Me.modTimeNumeric.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'modBox
        '
        Me.modBox.Location = New System.Drawing.Point(12, 37)
        Me.modBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.modBox.Name = "modBox"
        Me.modBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.modBox.Size = New System.Drawing.Size(716, 339)
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
        Me.votingGroup.Controls.Add(Me.voteMinPlayersNumeric)
        Me.votingGroup.Controls.Add(Me.voteCheck)
        Me.votingGroup.Location = New System.Drawing.Point(12, 260)
        Me.votingGroup.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.votingGroup.Name = "votingGroup"
        Me.votingGroup.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.votingGroup.Size = New System.Drawing.Size(318, 192)
        Me.votingGroup.TabIndex = 18
        Me.votingGroup.TabStop = False
        Me.votingGroup.Text = "Voting"
        '
        'percentLabel
        '
        Me.percentLabel.AutoSize = True
        Me.percentLabel.Location = New System.Drawing.Point(268, 138)
        Me.percentLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.percentLabel.Name = "percentLabel"
        Me.percentLabel.Size = New System.Drawing.Size(31, 25)
        Me.percentLabel.TabIndex = 22
        Me.percentLabel.Text = "%"
        '
        'voteThresholdLabel
        '
        Me.voteThresholdLabel.AutoSize = True
        Me.voteThresholdLabel.Location = New System.Drawing.Point(14, 135)
        Me.voteThresholdLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.voteThresholdLabel.Name = "voteThresholdLabel"
        Me.voteThresholdLabel.Size = New System.Drawing.Size(158, 25)
        Me.voteThresholdLabel.TabIndex = 21
        Me.voteThresholdLabel.Text = "Vote Threshold"
        '
        'minPlayersLabel
        '
        Me.minPlayersLabel.AutoSize = True
        Me.minPlayersLabel.Location = New System.Drawing.Point(50, 85)
        Me.minPlayersLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.minPlayersLabel.Name = "minPlayersLabel"
        Me.minPlayersLabel.Size = New System.Drawing.Size(125, 25)
        Me.minPlayersLabel.TabIndex = 17
        Me.minPlayersLabel.Text = "Min Players"
        '
        'voteThresholdNumeric
        '
        Me.voteThresholdNumeric.Location = New System.Drawing.Point(180, 131)
        Me.voteThresholdNumeric.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.voteThresholdNumeric.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.voteThresholdNumeric.Name = "voteThresholdNumeric"
        Me.voteThresholdNumeric.Size = New System.Drawing.Size(86, 31)
        Me.voteThresholdNumeric.TabIndex = 20
        Me.voteThresholdNumeric.Value = New Decimal(New Integer() {33, 0, 0, 0})
        '
        'voteMinPlayersNumeric
        '
        Me.voteMinPlayersNumeric.Location = New System.Drawing.Point(180, 81)
        Me.voteMinPlayersNumeric.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.voteMinPlayersNumeric.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.voteMinPlayersNumeric.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.voteMinPlayersNumeric.Name = "voteMinPlayersNumeric"
        Me.voteMinPlayersNumeric.Size = New System.Drawing.Size(86, 31)
        Me.voteMinPlayersNumeric.TabIndex = 17
        Me.voteMinPlayersNumeric.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'voteCheck
        '
        Me.voteCheck.AutoSize = True
        Me.voteCheck.Checked = True
        Me.voteCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.voteCheck.Location = New System.Drawing.Point(22, 37)
        Me.voteCheck.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.voteCheck.Name = "voteCheck"
        Me.voteCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.voteCheck.Size = New System.Drawing.Size(183, 29)
        Me.voteCheck.TabIndex = 19
        Me.voteCheck.Text = "Disable Voting"
        Me.voteCheck.UseVisualStyleBackColor = True
        '
        'vonGroup
        '
        Me.vonGroup.Controls.Add(Me.codecLabel)
        Me.vonGroup.Controls.Add(Me.codecNumeric)
        Me.vonGroup.Controls.Add(Me.vonCheck)
        Me.vonGroup.Location = New System.Drawing.Point(342, 260)
        Me.vonGroup.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.vonGroup.Name = "vonGroup"
        Me.vonGroup.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.vonGroup.Size = New System.Drawing.Size(272, 192)
        Me.vonGroup.TabIndex = 17
        Me.vonGroup.TabStop = False
        Me.vonGroup.Text = "VON Settings"
        '
        'codecLabel
        '
        Me.codecLabel.AutoSize = True
        Me.codecLabel.Location = New System.Drawing.Point(12, 63)
        Me.codecLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.codecLabel.Name = "codecLabel"
        Me.codecLabel.Size = New System.Drawing.Size(147, 25)
        Me.codecLabel.TabIndex = 16
        Me.codecLabel.Text = "Codec Quality"
        '
        'codecNumeric
        '
        Me.codecNumeric.Location = New System.Drawing.Point(170, 60)
        Me.codecNumeric.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.codecNumeric.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.codecNumeric.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.codecNumeric.Name = "codecNumeric"
        Me.codecNumeric.Size = New System.Drawing.Size(86, 31)
        Me.codecNumeric.TabIndex = 15
        Me.codecNumeric.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'vonCheck
        '
        Me.vonCheck.AutoSize = True
        Me.vonCheck.Location = New System.Drawing.Point(18, 110)
        Me.vonCheck.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.vonCheck.Name = "vonCheck"
        Me.vonCheck.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.vonCheck.Size = New System.Drawing.Size(167, 29)
        Me.vonCheck.TabIndex = 14
        Me.vonCheck.Text = "Disable VON"
        Me.vonCheck.UseVisualStyleBackColor = True
        '
        'missionTab
        '
        Me.missionTab.BackColor = System.Drawing.Color.LightSkyBlue
        Me.missionTab.Controls.Add(Me.missionsGroup)
        Me.missionTab.Controls.Add(Me.customDifficutlyGroup)
        Me.missionTab.Location = New System.Drawing.Point(8, 39)
        Me.missionTab.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.missionTab.Name = "missionTab"
        Me.missionTab.Size = New System.Drawing.Size(1382, 466)
        Me.missionTab.TabIndex = 4
        Me.missionTab.Text = "Missions"
        '
        'missionsGroup
        '
        Me.missionsGroup.Controls.Add(Me.difficultyLabel)
        Me.missionsGroup.Controls.Add(Me.autoInitCheck)
        Me.missionsGroup.Controls.Add(Me.persistCheck)
        Me.missionsGroup.Controls.Add(Me.difficultyCombo)
        Me.missionsGroup.Controls.Add(Me.missionRefreshButton)
        Me.missionsGroup.Controls.Add(Me.missionsNoneButton)
        Me.missionsGroup.Controls.Add(Me.missionsAllButton)
        Me.missionsGroup.Controls.Add(Me.missionsList)
        Me.missionsGroup.Location = New System.Drawing.Point(10, 12)
        Me.missionsGroup.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.missionsGroup.Name = "missionsGroup"
        Me.missionsGroup.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.missionsGroup.Size = New System.Drawing.Size(630, 440)
        Me.missionsGroup.TabIndex = 12
        Me.missionsGroup.TabStop = False
        Me.missionsGroup.Text = "Missions"
        '
        'difficultyLabel
        '
        Me.difficultyLabel.AutoSize = True
        Me.difficultyLabel.Location = New System.Drawing.Point(302, 394)
        Me.difficultyLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.difficultyLabel.Name = "difficultyLabel"
        Me.difficultyLabel.Size = New System.Drawing.Size(162, 25)
        Me.difficultyLabel.TabIndex = 30
        Me.difficultyLabel.Text = "Difficulty Preset"
        '
        'autoInitCheck
        '
        Me.autoInitCheck.AutoSize = True
        Me.autoInitCheck.Enabled = False
        Me.autoInitCheck.Location = New System.Drawing.Point(266, 315)
        Me.autoInitCheck.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.autoInitCheck.Name = "autoInitCheck"
        Me.autoInitCheck.Size = New System.Drawing.Size(122, 29)
        Me.autoInitCheck.TabIndex = 11
        Me.autoInitCheck.Text = "Auto Init"
        Me.autoInitCheck.UseVisualStyleBackColor = True
        '
        'persistCheck
        '
        Me.persistCheck.AutoSize = True
        Me.persistCheck.Location = New System.Drawing.Point(12, 315)
        Me.persistCheck.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.persistCheck.Name = "persistCheck"
        Me.persistCheck.Size = New System.Drawing.Size(241, 29)
        Me.persistCheck.TabIndex = 10
        Me.persistCheck.Text = "Persistant Battlefield"
        Me.persistCheck.UseVisualStyleBackColor = True
        '
        'difficultyCombo
        '
        Me.difficultyCombo.BackColor = System.Drawing.SystemColors.Window
        Me.difficultyCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.difficultyCombo.FormattingEnabled = True
        Me.difficultyCombo.Items.AddRange(New Object() {"Recruit", "Regular", "Veteran", "Custom"})
        Me.difficultyCombo.Location = New System.Drawing.Point(474, 388)
        Me.difficultyCombo.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.difficultyCombo.MaxDropDownItems = 3
        Me.difficultyCombo.Name = "difficultyCombo"
        Me.difficultyCombo.Size = New System.Drawing.Size(140, 33)
        Me.difficultyCombo.TabIndex = 29
        '
        'missionRefreshButton
        '
        Me.missionRefreshButton.Location = New System.Drawing.Point(236, 385)
        Me.missionRefreshButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.missionRefreshButton.Name = "missionRefreshButton"
        Me.missionRefreshButton.Size = New System.Drawing.Size(48, 44)
        Me.missionRefreshButton.TabIndex = 15
        Me.missionRefreshButton.Text = "" & Global.Microsoft.VisualBasic.ChrW(9) & "↻"
        Me.missionRefreshButton.UseVisualStyleBackColor = True
        '
        'missionsNoneButton
        '
        Me.missionsNoneButton.Location = New System.Drawing.Point(124, 385)
        Me.missionsNoneButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.missionsNoneButton.Name = "missionsNoneButton"
        Me.missionsNoneButton.Size = New System.Drawing.Size(100, 44)
        Me.missionsNoneButton.TabIndex = 14
        Me.missionsNoneButton.Text = "None"
        Me.missionsNoneButton.UseVisualStyleBackColor = True
        '
        'missionsAllButton
        '
        Me.missionsAllButton.Location = New System.Drawing.Point(12, 385)
        Me.missionsAllButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.missionsAllButton.Name = "missionsAllButton"
        Me.missionsAllButton.Size = New System.Drawing.Size(100, 44)
        Me.missionsAllButton.TabIndex = 13
        Me.missionsAllButton.Text = "All"
        Me.missionsAllButton.UseVisualStyleBackColor = True
        '
        'missionsList
        '
        Me.missionsList.FormattingEnabled = True
        Me.missionsList.Location = New System.Drawing.Point(12, 37)
        Me.missionsList.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.missionsList.Name = "missionsList"
        Me.missionsList.Size = New System.Drawing.Size(602, 264)
        Me.missionsList.TabIndex = 12
        '
        'customDifficutlyGroup
        '
        Me.customDifficutlyGroup.Controls.Add(Me.tacticalPingCheck)
        Me.customDifficutlyGroup.Controls.Add(Me.aiSettingsGroup)
        Me.customDifficutlyGroup.Controls.Add(Me.multipleSavesCheck)
        Me.customDifficutlyGroup.Controls.Add(Me.autoReportingCheck)
        Me.customDifficutlyGroup.Controls.Add(Me.mapContentCheck)
        Me.customDifficutlyGroup.Controls.Add(Me.vonIDCheck)
        Me.customDifficutlyGroup.Controls.Add(Me.killedByCheck)
        Me.customDifficutlyGroup.Controls.Add(Me.scoreTableCheck)
        Me.customDifficutlyGroup.Controls.Add(Me.cameraShakeCheck)
        Me.customDifficutlyGroup.Controls.Add(Me.thirdPersonCheck)
        Me.customDifficutlyGroup.Controls.Add(Me.visualAidCheck)
        Me.customDifficutlyGroup.Controls.Add(Me.crosshairCheck)
        Me.customDifficutlyGroup.Controls.Add(Me.staminaBarCheck)
        Me.customDifficutlyGroup.Controls.Add(Me.stanceIndicatorCheck)
        Me.customDifficutlyGroup.Controls.Add(Me.weaponInfoCheck)
        Me.customDifficutlyGroup.Controls.Add(Me.waypointsCheck)
        Me.customDifficutlyGroup.Controls.Add(Me.commandsCheck)
        Me.customDifficutlyGroup.Controls.Add(Me.detectedMinesCheck)
        Me.customDifficutlyGroup.Controls.Add(Me.enemyNameCheck)
        Me.customDifficutlyGroup.Controls.Add(Me.friendlyNameCheck)
        Me.customDifficutlyGroup.Controls.Add(Me.groupIndicatorCheck)
        Me.customDifficutlyGroup.Controls.Add(Me.reducedDamageCheck)
        Me.customDifficutlyGroup.Location = New System.Drawing.Point(652, 12)
        Me.customDifficutlyGroup.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.customDifficutlyGroup.Name = "customDifficutlyGroup"
        Me.customDifficutlyGroup.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.customDifficutlyGroup.Size = New System.Drawing.Size(720, 440)
        Me.customDifficutlyGroup.TabIndex = 13
        Me.customDifficutlyGroup.TabStop = False
        Me.customDifficutlyGroup.Text = "Custom Difficulty"
        '
        'tacticalPingCheck
        '
        Me.tacticalPingCheck.AutoSize = True
        Me.tacticalPingCheck.Checked = True
        Me.tacticalPingCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tacticalPingCheck.Location = New System.Drawing.Point(468, 125)
        Me.tacticalPingCheck.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tacticalPingCheck.Name = "tacticalPingCheck"
        Me.tacticalPingCheck.Size = New System.Drawing.Size(168, 29)
        Me.tacticalPingCheck.TabIndex = 21
        Me.tacticalPingCheck.Text = "Tactical Ping"
        Me.tacticalPingCheck.UseVisualStyleBackColor = True
        '
        'aiSettingsGroup
        '
        Me.aiSettingsGroup.Controls.Add(Me.aiAccuracyLabel)
        Me.aiSettingsGroup.Controls.Add(Me.aiSkillLabel)
        Me.aiSettingsGroup.Controls.Add(Me.aiPresetLabel)
        Me.aiSettingsGroup.Controls.Add(Me.aiAccuracyNumeric)
        Me.aiSettingsGroup.Controls.Add(Me.aiSkillNumeric)
        Me.aiSettingsGroup.Controls.Add(Me.aiPresetNumeric)
        Me.aiSettingsGroup.Location = New System.Drawing.Point(468, 237)
        Me.aiSettingsGroup.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.aiSettingsGroup.Name = "aiSettingsGroup"
        Me.aiSettingsGroup.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.aiSettingsGroup.Size = New System.Drawing.Size(240, 192)
        Me.aiSettingsGroup.TabIndex = 20
        Me.aiSettingsGroup.TabStop = False
        Me.aiSettingsGroup.Text = "AI Settings"
        '
        'aiAccuracyLabel
        '
        Me.aiAccuracyLabel.AutoSize = True
        Me.aiAccuracyLabel.Location = New System.Drawing.Point(26, 90)
        Me.aiAccuracyLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.aiAccuracyLabel.Name = "aiAccuracyLabel"
        Me.aiAccuracyLabel.Size = New System.Drawing.Size(101, 25)
        Me.aiAccuracyLabel.TabIndex = 21
        Me.aiAccuracyLabel.Text = "Accuracy"
        '
        'aiSkillLabel
        '
        Me.aiSkillLabel.AutoSize = True
        Me.aiSkillLabel.Location = New System.Drawing.Point(26, 40)
        Me.aiSkillLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.aiSkillLabel.Name = "aiSkillLabel"
        Me.aiSkillLabel.Size = New System.Drawing.Size(52, 25)
        Me.aiSkillLabel.TabIndex = 20
        Me.aiSkillLabel.Text = "Skill"
        '
        'aiPresetLabel
        '
        Me.aiPresetLabel.AutoSize = True
        Me.aiPresetLabel.Location = New System.Drawing.Point(26, 140)
        Me.aiPresetLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.aiPresetLabel.Name = "aiPresetLabel"
        Me.aiPresetLabel.Size = New System.Drawing.Size(74, 25)
        Me.aiPresetLabel.TabIndex = 19
        Me.aiPresetLabel.Text = "Preset"
        '
        'aiAccuracyNumeric
        '
        Me.aiAccuracyNumeric.DecimalPlaces = 2
        Me.aiAccuracyNumeric.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.aiAccuracyNumeric.Location = New System.Drawing.Point(142, 87)
        Me.aiAccuracyNumeric.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.aiAccuracyNumeric.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.aiAccuracyNumeric.Name = "aiAccuracyNumeric"
        Me.aiAccuracyNumeric.Size = New System.Drawing.Size(86, 31)
        Me.aiAccuracyNumeric.TabIndex = 18
        Me.aiAccuracyNumeric.Value = New Decimal(New Integer() {55, 0, 0, 131072})
        '
        'aiSkillNumeric
        '
        Me.aiSkillNumeric.DecimalPlaces = 2
        Me.aiSkillNumeric.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.aiSkillNumeric.Location = New System.Drawing.Point(142, 37)
        Me.aiSkillNumeric.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.aiSkillNumeric.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.aiSkillNumeric.Name = "aiSkillNumeric"
        Me.aiSkillNumeric.Size = New System.Drawing.Size(86, 31)
        Me.aiSkillNumeric.TabIndex = 17
        Me.aiSkillNumeric.Value = New Decimal(New Integer() {75, 0, 0, 131072})
        '
        'aiPresetNumeric
        '
        Me.aiPresetNumeric.Location = New System.Drawing.Point(142, 137)
        Me.aiPresetNumeric.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.aiPresetNumeric.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.aiPresetNumeric.Name = "aiPresetNumeric"
        Me.aiPresetNumeric.Size = New System.Drawing.Size(86, 31)
        Me.aiPresetNumeric.TabIndex = 16
        Me.aiPresetNumeric.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'multipleSavesCheck
        '
        Me.multipleSavesCheck.AutoSize = True
        Me.multipleSavesCheck.Checked = True
        Me.multipleSavesCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.multipleSavesCheck.Location = New System.Drawing.Point(12, 258)
        Me.multipleSavesCheck.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.multipleSavesCheck.Name = "multipleSavesCheck"
        Me.multipleSavesCheck.Size = New System.Drawing.Size(185, 29)
        Me.multipleSavesCheck.TabIndex = 19
        Me.multipleSavesCheck.Text = "Multiple Saves"
        Me.multipleSavesCheck.UseVisualStyleBackColor = True
        '
        'autoReportingCheck
        '
        Me.autoReportingCheck.AutoSize = True
        Me.autoReportingCheck.Checked = True
        Me.autoReportingCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.autoReportingCheck.Location = New System.Drawing.Point(468, 37)
        Me.autoReportingCheck.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.autoReportingCheck.Name = "autoReportingCheck"
        Me.autoReportingCheck.Size = New System.Drawing.Size(187, 29)
        Me.autoReportingCheck.TabIndex = 18
        Me.autoReportingCheck.Text = "Auto Reporting"
        Me.autoReportingCheck.UseVisualStyleBackColor = True
        '
        'mapContentCheck
        '
        Me.mapContentCheck.AutoSize = True
        Me.mapContentCheck.Checked = True
        Me.mapContentCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mapContentCheck.Location = New System.Drawing.Point(264, 169)
        Me.mapContentCheck.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.mapContentCheck.Name = "mapContentCheck"
        Me.mapContentCheck.Size = New System.Drawing.Size(264, 29)
        Me.mapContentCheck.TabIndex = 17
        Me.mapContentCheck.Text = "Extended Map Content"
        Me.mapContentCheck.UseVisualStyleBackColor = True
        '
        'vonIDCheck
        '
        Me.vonIDCheck.AutoSize = True
        Me.vonIDCheck.Checked = True
        Me.vonIDCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.vonIDCheck.Location = New System.Drawing.Point(264, 258)
        Me.vonIDCheck.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.vonIDCheck.Name = "vonIDCheck"
        Me.vonIDCheck.Size = New System.Drawing.Size(115, 29)
        Me.vonIDCheck.TabIndex = 16
        Me.vonIDCheck.Text = "VON ID"
        Me.vonIDCheck.UseVisualStyleBackColor = True
        '
        'killedByCheck
        '
        Me.killedByCheck.AutoSize = True
        Me.killedByCheck.Checked = True
        Me.killedByCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.killedByCheck.Location = New System.Drawing.Point(264, 302)
        Me.killedByCheck.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.killedByCheck.Name = "killedByCheck"
        Me.killedByCheck.Size = New System.Drawing.Size(128, 29)
        Me.killedByCheck.TabIndex = 15
        Me.killedByCheck.Text = "Killed By"
        Me.killedByCheck.UseVisualStyleBackColor = True
        '
        'scoreTableCheck
        '
        Me.scoreTableCheck.AutoSize = True
        Me.scoreTableCheck.Checked = True
        Me.scoreTableCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.scoreTableCheck.Location = New System.Drawing.Point(468, 81)
        Me.scoreTableCheck.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.scoreTableCheck.Name = "scoreTableCheck"
        Me.scoreTableCheck.Size = New System.Drawing.Size(160, 29)
        Me.scoreTableCheck.TabIndex = 14
        Me.scoreTableCheck.Text = "Score Table"
        Me.scoreTableCheck.UseVisualStyleBackColor = True
        '
        'cameraShakeCheck
        '
        Me.cameraShakeCheck.AutoSize = True
        Me.cameraShakeCheck.Checked = True
        Me.cameraShakeCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cameraShakeCheck.Location = New System.Drawing.Point(264, 81)
        Me.cameraShakeCheck.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cameraShakeCheck.Name = "cameraShakeCheck"
        Me.cameraShakeCheck.Size = New System.Drawing.Size(186, 29)
        Me.cameraShakeCheck.TabIndex = 13
        Me.cameraShakeCheck.Text = "Camera Shake"
        Me.cameraShakeCheck.UseVisualStyleBackColor = True
        '
        'thirdPersonCheck
        '
        Me.thirdPersonCheck.AutoSize = True
        Me.thirdPersonCheck.Checked = True
        Me.thirdPersonCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.thirdPersonCheck.Location = New System.Drawing.Point(12, 302)
        Me.thirdPersonCheck.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.thirdPersonCheck.Name = "thirdPersonCheck"
        Me.thirdPersonCheck.Size = New System.Drawing.Size(230, 29)
        Me.thirdPersonCheck.TabIndex = 12
        Me.thirdPersonCheck.Text = "3rd Person Camera"
        Me.thirdPersonCheck.UseVisualStyleBackColor = True
        '
        'visualAidCheck
        '
        Me.visualAidCheck.AutoSize = True
        Me.visualAidCheck.Checked = True
        Me.visualAidCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.visualAidCheck.Location = New System.Drawing.Point(264, 125)
        Me.visualAidCheck.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.visualAidCheck.Name = "visualAidCheck"
        Me.visualAidCheck.Size = New System.Drawing.Size(151, 29)
        Me.visualAidCheck.TabIndex = 11
        Me.visualAidCheck.Text = "Visual Aids"
        Me.visualAidCheck.UseVisualStyleBackColor = True
        '
        'crosshairCheck
        '
        Me.crosshairCheck.AutoSize = True
        Me.crosshairCheck.Checked = True
        Me.crosshairCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.crosshairCheck.Location = New System.Drawing.Point(264, 390)
        Me.crosshairCheck.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.crosshairCheck.Name = "crosshairCheck"
        Me.crosshairCheck.Size = New System.Drawing.Size(136, 29)
        Me.crosshairCheck.TabIndex = 10
        Me.crosshairCheck.Text = "Crosshair"
        Me.crosshairCheck.UseVisualStyleBackColor = True
        '
        'staminaBarCheck
        '
        Me.staminaBarCheck.AutoSize = True
        Me.staminaBarCheck.Checked = True
        Me.staminaBarCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.staminaBarCheck.Location = New System.Drawing.Point(264, 37)
        Me.staminaBarCheck.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.staminaBarCheck.Name = "staminaBarCheck"
        Me.staminaBarCheck.Size = New System.Drawing.Size(161, 29)
        Me.staminaBarCheck.TabIndex = 9
        Me.staminaBarCheck.Text = "Stamina Bar"
        Me.staminaBarCheck.UseVisualStyleBackColor = True
        '
        'stanceIndicatorCheck
        '
        Me.stanceIndicatorCheck.AutoSize = True
        Me.stanceIndicatorCheck.Checked = True
        Me.stanceIndicatorCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.stanceIndicatorCheck.Location = New System.Drawing.Point(12, 390)
        Me.stanceIndicatorCheck.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.stanceIndicatorCheck.Name = "stanceIndicatorCheck"
        Me.stanceIndicatorCheck.Size = New System.Drawing.Size(199, 29)
        Me.stanceIndicatorCheck.TabIndex = 8
        Me.stanceIndicatorCheck.Text = "Stance Indicator"
        Me.stanceIndicatorCheck.UseVisualStyleBackColor = True
        '
        'weaponInfoCheck
        '
        Me.weaponInfoCheck.AutoSize = True
        Me.weaponInfoCheck.Checked = True
        Me.weaponInfoCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.weaponInfoCheck.Location = New System.Drawing.Point(12, 346)
        Me.weaponInfoCheck.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.weaponInfoCheck.Name = "weaponInfoCheck"
        Me.weaponInfoCheck.Size = New System.Drawing.Size(165, 29)
        Me.weaponInfoCheck.TabIndex = 7
        Me.weaponInfoCheck.Text = "Weapon Info"
        Me.weaponInfoCheck.UseVisualStyleBackColor = True
        '
        'waypointsCheck
        '
        Me.waypointsCheck.AutoSize = True
        Me.waypointsCheck.Checked = True
        Me.waypointsCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.waypointsCheck.Location = New System.Drawing.Point(264, 346)
        Me.waypointsCheck.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.waypointsCheck.Name = "waypointsCheck"
        Me.waypointsCheck.Size = New System.Drawing.Size(145, 29)
        Me.waypointsCheck.TabIndex = 6
        Me.waypointsCheck.Text = "Waypoints"
        Me.waypointsCheck.UseVisualStyleBackColor = True
        '
        'commandsCheck
        '
        Me.commandsCheck.AutoSize = True
        Me.commandsCheck.Checked = True
        Me.commandsCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.commandsCheck.Location = New System.Drawing.Point(264, 213)
        Me.commandsCheck.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.commandsCheck.Name = "commandsCheck"
        Me.commandsCheck.Size = New System.Drawing.Size(152, 29)
        Me.commandsCheck.TabIndex = 5
        Me.commandsCheck.Text = "Commands"
        Me.commandsCheck.UseVisualStyleBackColor = True
        '
        'detectedMinesCheck
        '
        Me.detectedMinesCheck.AutoSize = True
        Me.detectedMinesCheck.Checked = True
        Me.detectedMinesCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.detectedMinesCheck.Location = New System.Drawing.Point(12, 213)
        Me.detectedMinesCheck.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.detectedMinesCheck.Name = "detectedMinesCheck"
        Me.detectedMinesCheck.Size = New System.Drawing.Size(194, 29)
        Me.detectedMinesCheck.TabIndex = 4
        Me.detectedMinesCheck.Text = "Detected Mines"
        Me.detectedMinesCheck.UseVisualStyleBackColor = True
        '
        'enemyNameCheck
        '
        Me.enemyNameCheck.AutoSize = True
        Me.enemyNameCheck.Checked = True
        Me.enemyNameCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.enemyNameCheck.Location = New System.Drawing.Point(12, 169)
        Me.enemyNameCheck.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.enemyNameCheck.Name = "enemyNameCheck"
        Me.enemyNameCheck.Size = New System.Drawing.Size(226, 29)
        Me.enemyNameCheck.TabIndex = 3
        Me.enemyNameCheck.Text = "Enemy Name Tags"
        Me.enemyNameCheck.UseVisualStyleBackColor = True
        '
        'friendlyNameCheck
        '
        Me.friendlyNameCheck.AutoSize = True
        Me.friendlyNameCheck.Checked = True
        Me.friendlyNameCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.friendlyNameCheck.Location = New System.Drawing.Point(12, 125)
        Me.friendlyNameCheck.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.friendlyNameCheck.Name = "friendlyNameCheck"
        Me.friendlyNameCheck.Size = New System.Drawing.Size(237, 29)
        Me.friendlyNameCheck.TabIndex = 2
        Me.friendlyNameCheck.Text = "Friendly Name Tags"
        Me.friendlyNameCheck.UseVisualStyleBackColor = True
        '
        'groupIndicatorCheck
        '
        Me.groupIndicatorCheck.AutoSize = True
        Me.groupIndicatorCheck.Checked = True
        Me.groupIndicatorCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.groupIndicatorCheck.Location = New System.Drawing.Point(12, 81)
        Me.groupIndicatorCheck.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.groupIndicatorCheck.Name = "groupIndicatorCheck"
        Me.groupIndicatorCheck.Size = New System.Drawing.Size(202, 29)
        Me.groupIndicatorCheck.TabIndex = 1
        Me.groupIndicatorCheck.Text = "Group Indicators"
        Me.groupIndicatorCheck.UseVisualStyleBackColor = True
        '
        'reducedDamageCheck
        '
        Me.reducedDamageCheck.AutoSize = True
        Me.reducedDamageCheck.Location = New System.Drawing.Point(12, 37)
        Me.reducedDamageCheck.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.reducedDamageCheck.Name = "reducedDamageCheck"
        Me.reducedDamageCheck.Size = New System.Drawing.Size(216, 29)
        Me.reducedDamageCheck.TabIndex = 0
        Me.reducedDamageCheck.Text = "Reduced Damage"
        Me.reducedDamageCheck.UseVisualStyleBackColor = True
        '
        'perfTab
        '
        Me.perfTab.BackColor = System.Drawing.Color.LightSkyBlue
        Me.perfTab.Controls.Add(Me.serverPerfGroup)
        Me.perfTab.Controls.Add(Me.clientPerfGroup)
        Me.perfTab.Location = New System.Drawing.Point(8, 39)
        Me.perfTab.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.perfTab.Name = "perfTab"
        Me.perfTab.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.perfTab.Size = New System.Drawing.Size(1382, 466)
        Me.perfTab.TabIndex = 2
        Me.perfTab.Text = "Perfomance"
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
        Me.serverPerfGroup.Location = New System.Drawing.Point(12, 12)
        Me.serverPerfGroup.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.serverPerfGroup.Name = "serverPerfGroup"
        Me.serverPerfGroup.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.serverPerfGroup.Size = New System.Drawing.Size(920, 440)
        Me.serverPerfGroup.TabIndex = 46
        Me.serverPerfGroup.TabStop = False
        Me.serverPerfGroup.Text = "Server"
        '
        'moreInfoLabel
        '
        Me.moreInfoLabel.AutoSize = True
        Me.moreInfoLabel.Location = New System.Drawing.Point(804, 31)
        Me.moreInfoLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.moreInfoLabel.Name = "moreInfoLabel"
        Me.moreInfoLabel.Size = New System.Drawing.Size(102, 25)
        Me.moreInfoLabel.TabIndex = 37
        Me.moreInfoLabel.TabStop = True
        Me.moreInfoLabel.Text = "More Info"
        '
        'perfResetLabel
        '
        Me.perfResetLabel.AutoSize = True
        Me.perfResetLabel.Location = New System.Drawing.Point(12, 142)
        Me.perfResetLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.perfResetLabel.Name = "perfResetLabel"
        Me.perfResetLabel.Size = New System.Drawing.Size(170, 25)
        Me.perfResetLabel.TabIndex = 36
        Me.perfResetLabel.Text = "Reset All Values"
        '
        'perfResetButton
        '
        Me.perfResetButton.Location = New System.Drawing.Point(272, 129)
        Me.perfResetButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.perfResetButton.Name = "perfResetButton"
        Me.perfResetButton.Size = New System.Drawing.Size(142, 44)
        Me.perfResetButton.TabIndex = 35
        Me.perfResetButton.Text = "Reset"
        Me.perfResetButton.UseVisualStyleBackColor = True
        '
        'extraParamsBox
        '
        Me.extraParamsBox.Location = New System.Drawing.Point(272, 387)
        Me.extraParamsBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.extraParamsBox.Name = "extraParamsBox"
        Me.extraParamsBox.Size = New System.Drawing.Size(632, 31)
        Me.extraParamsBox.TabIndex = 34
        '
        'extraParamsLabel
        '
        Me.extraParamsLabel.AutoSize = True
        Me.extraParamsLabel.Location = New System.Drawing.Point(12, 392)
        Me.extraParamsLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.extraParamsLabel.Name = "extraParamsLabel"
        Me.extraParamsLabel.Size = New System.Drawing.Size(178, 25)
        Me.extraParamsLabel.TabIndex = 33
        Me.extraParamsLabel.Text = "Extra Parameters"
        '
        'maxSendLabel
        '
        Me.maxSendLabel.AutoSize = True
        Me.maxSendLabel.Location = New System.Drawing.Point(440, 142)
        Me.maxSendLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.maxSendLabel.Name = "maxSendLabel"
        Me.maxSendLabel.Size = New System.Drawing.Size(214, 25)
        Me.maxSendLabel.TabIndex = 31
        Me.maxSendLabel.Text = "Max Messages Send"
        '
        'maxSendBox
        '
        Me.maxSendBox.Location = New System.Drawing.Point(768, 137)
        Me.maxSendBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.maxSendBox.Name = "maxSendBox"
        Me.maxSendBox.Size = New System.Drawing.Size(136, 31)
        Me.maxSendBox.TabIndex = 32
        Me.maxSendBox.Text = "128"
        '
        'minErrorLabel
        '
        Me.minErrorLabel.AutoSize = True
        Me.minErrorLabel.Location = New System.Drawing.Point(440, 296)
        Me.minErrorLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.minErrorLabel.Name = "minErrorLabel"
        Me.minErrorLabel.Size = New System.Drawing.Size(187, 25)
        Me.minErrorLabel.TabIndex = 29
        Me.minErrorLabel.Text = "Min Error To Send"
        '
        'minErrorBox
        '
        Me.minErrorBox.Location = New System.Drawing.Point(768, 287)
        Me.minErrorBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.minErrorBox.Name = "minErrorBox"
        Me.minErrorBox.Size = New System.Drawing.Size(136, 31)
        Me.minErrorBox.TabIndex = 30
        Me.minErrorBox.Text = "0.001"
        '
        'minErrorNearLabel
        '
        Me.minErrorNearLabel.AutoSize = True
        Me.minErrorNearLabel.Location = New System.Drawing.Point(440, 342)
        Me.minErrorNearLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.minErrorNearLabel.Name = "minErrorNearLabel"
        Me.minErrorNearLabel.Size = New System.Drawing.Size(239, 25)
        Me.minErrorNearLabel.TabIndex = 27
        Me.minErrorNearLabel.Text = "Min Error To Send Near"
        '
        'minErrorNearBox
        '
        Me.minErrorNearBox.Location = New System.Drawing.Point(768, 337)
        Me.minErrorNearBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.minErrorNearBox.Name = "minErrorNearBox"
        Me.minErrorNearBox.Size = New System.Drawing.Size(136, 31)
        Me.minErrorNearBox.TabIndex = 28
        Me.minErrorNearBox.Text = "0.01"
        '
        'maxBandwidthLabel
        '
        Me.maxBandwidthLabel.AutoSize = True
        Me.maxBandwidthLabel.Location = New System.Drawing.Point(12, 342)
        Me.maxBandwidthLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.maxBandwidthLabel.Name = "maxBandwidthLabel"
        Me.maxBandwidthLabel.Size = New System.Drawing.Size(236, 25)
        Me.maxBandwidthLabel.TabIndex = 25
        Me.maxBandwidthLabel.Text = "Max Bandwidth (mbit/s)"
        '
        'maxBandwidthBox
        '
        Me.maxBandwidthBox.Location = New System.Drawing.Point(274, 337)
        Me.maxBandwidthBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.maxBandwidthBox.Name = "maxBandwidthBox"
        Me.maxBandwidthBox.Size = New System.Drawing.Size(136, 31)
        Me.maxBandwidthBox.TabIndex = 26
        Me.maxBandwidthBox.Text = "2000"
        '
        'minBandwidthLabel
        '
        Me.minBandwidthLabel.AutoSize = True
        Me.minBandwidthLabel.Location = New System.Drawing.Point(12, 292)
        Me.minBandwidthLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.minBandwidthLabel.Name = "minBandwidthLabel"
        Me.minBandwidthLabel.Size = New System.Drawing.Size(224, 25)
        Me.minBandwidthLabel.TabIndex = 23
        Me.minBandwidthLabel.Text = "Min Bandwidth (kbit/s)"
        '
        'minBandwidthBox
        '
        Me.minBandwidthBox.Location = New System.Drawing.Point(274, 287)
        Me.minBandwidthBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.minBandwidthBox.Name = "minBandwidthBox"
        Me.minBandwidthBox.Size = New System.Drawing.Size(136, 31)
        Me.minBandwidthBox.TabIndex = 24
        Me.minBandwidthBox.Text = "128"
        '
        'maxNonGuaranteedLabel
        '
        Me.maxNonGuaranteedLabel.AutoSize = True
        Me.maxNonGuaranteedLabel.Location = New System.Drawing.Point(440, 192)
        Me.maxNonGuaranteedLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.maxNonGuaranteedLabel.Name = "maxNonGuaranteedLabel"
        Me.maxNonGuaranteedLabel.Size = New System.Drawing.Size(329, 25)
        Me.maxNonGuaranteedLabel.TabIndex = 21
        Me.maxNonGuaranteedLabel.Text = "Max Size Nonguaranteed (Bytes)"
        '
        'maxNonGuaranteedBox
        '
        Me.maxNonGuaranteedBox.Location = New System.Drawing.Point(768, 187)
        Me.maxNonGuaranteedBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.maxNonGuaranteedBox.Name = "maxNonGuaranteedBox"
        Me.maxNonGuaranteedBox.Size = New System.Drawing.Size(136, 31)
        Me.maxNonGuaranteedBox.TabIndex = 22
        Me.maxNonGuaranteedBox.Text = "256"
        '
        'maxGuaranteedLabel
        '
        Me.maxGuaranteedLabel.AutoSize = True
        Me.maxGuaranteedLabel.Location = New System.Drawing.Point(440, 242)
        Me.maxGuaranteedLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.maxGuaranteedLabel.Name = "maxGuaranteedLabel"
        Me.maxGuaranteedLabel.Size = New System.Drawing.Size(294, 25)
        Me.maxGuaranteedLabel.TabIndex = 19
        Me.maxGuaranteedLabel.Text = "Max Size Guaranteed (Bytes)"
        '
        'maxGuaranteedBox
        '
        Me.maxGuaranteedBox.Location = New System.Drawing.Point(768, 237)
        Me.maxGuaranteedBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.maxGuaranteedBox.Name = "maxGuaranteedBox"
        Me.maxGuaranteedBox.Size = New System.Drawing.Size(136, 31)
        Me.maxGuaranteedBox.TabIndex = 20
        Me.maxGuaranteedBox.Text = "512"
        '
        'maxPacketLabel
        '
        Me.maxPacketLabel.AutoSize = True
        Me.maxPacketLabel.Location = New System.Drawing.Point(12, 242)
        Me.maxPacketLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.maxPacketLabel.Name = "maxPacketLabel"
        Me.maxPacketLabel.Size = New System.Drawing.Size(173, 25)
        Me.maxPacketLabel.TabIndex = 17
        Me.maxPacketLabel.Text = "Max Packet Size"
        '
        'maxPacketBox
        '
        Me.maxPacketBox.Location = New System.Drawing.Point(274, 237)
        Me.maxPacketBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.maxPacketBox.Name = "maxPacketBox"
        Me.maxPacketBox.Size = New System.Drawing.Size(136, 31)
        Me.maxPacketBox.TabIndex = 18
        Me.maxPacketBox.Text = "1400"
        '
        'maxCustFileLabel
        '
        Me.maxCustFileLabel.AutoSize = True
        Me.maxCustFileLabel.Location = New System.Drawing.Point(12, 192)
        Me.maxCustFileLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.maxCustFileLabel.Name = "maxCustFileLabel"
        Me.maxCustFileLabel.Size = New System.Drawing.Size(266, 25)
        Me.maxCustFileLabel.TabIndex = 15
        Me.maxCustFileLabel.Text = "Max Custom File Size (kB)"
        '
        'maxCustFileBox
        '
        Me.maxCustFileBox.Location = New System.Drawing.Point(274, 187)
        Me.maxCustFileBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.maxCustFileBox.Name = "maxCustFileBox"
        Me.maxCustFileBox.Size = New System.Drawing.Size(136, 31)
        Me.maxCustFileBox.TabIndex = 16
        Me.maxCustFileBox.Text = "160"
        '
        'filePatchingCheck
        '
        Me.filePatchingCheck.AutoSize = True
        Me.filePatchingCheck.Location = New System.Drawing.Point(18, 37)
        Me.filePatchingCheck.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.filePatchingCheck.Name = "filePatchingCheck"
        Me.filePatchingCheck.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.filePatchingCheck.Size = New System.Drawing.Size(169, 29)
        Me.filePatchingCheck.TabIndex = 13
        Me.filePatchingCheck.Text = "File Patching"
        Me.filePatchingCheck.UseVisualStyleBackColor = True
        '
        'htCheck
        '
        Me.htCheck.AutoSize = True
        Me.htCheck.Location = New System.Drawing.Point(18, 81)
        Me.htCheck.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.htCheck.Name = "htCheck"
        Me.htCheck.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.htCheck.Size = New System.Drawing.Size(264, 29)
        Me.htCheck.TabIndex = 14
        Me.htCheck.Text = "Enable Hyperthreading"
        Me.htCheck.UseVisualStyleBackColor = True
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
        Me.clientPerfGroup.Location = New System.Drawing.Point(944, 12)
        Me.clientPerfGroup.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.clientPerfGroup.Name = "clientPerfGroup"
        Me.clientPerfGroup.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.clientPerfGroup.Size = New System.Drawing.Size(426, 440)
        Me.clientPerfGroup.TabIndex = 45
        Me.clientPerfGroup.TabStop = False
        Me.clientPerfGroup.Text = "Client"
        '
        'plPercentLabel
        '
        Me.plPercentLabel.AutoSize = True
        Me.plPercentLabel.Location = New System.Drawing.Point(378, 138)
        Me.plPercentLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.plPercentLabel.Name = "plPercentLabel"
        Me.plPercentLabel.Size = New System.Drawing.Size(31, 25)
        Me.plPercentLabel.TabIndex = 47
        Me.plPercentLabel.Text = "%"
        '
        'msLabel
        '
        Me.msLabel.AutoSize = True
        Me.msLabel.Location = New System.Drawing.Point(378, 38)
        Me.msLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.msLabel.Name = "msLabel"
        Me.msLabel.Size = New System.Drawing.Size(40, 25)
        Me.msLabel.TabIndex = 46
        Me.msLabel.Text = "ms"
        '
        'sLabel
        '
        Me.sLabel.AutoSize = True
        Me.sLabel.Location = New System.Drawing.Point(378, 188)
        Me.sLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.sLabel.Name = "sLabel"
        Me.sLabel.Size = New System.Drawing.Size(23, 25)
        Me.sLabel.TabIndex = 45
        Me.sLabel.Text = "s"
        '
        'viewGroup
        '
        Me.viewGroup.Controls.Add(Me.metresLabel)
        Me.viewGroup.Controls.Add(Me.distanceLabel)
        Me.viewGroup.Controls.Add(Me.terrainLabel)
        Me.viewGroup.Controls.Add(Me.distanceNumeric)
        Me.viewGroup.Controls.Add(Me.terrainNumeric)
        Me.viewGroup.Location = New System.Drawing.Point(12, 287)
        Me.viewGroup.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.viewGroup.Name = "viewGroup"
        Me.viewGroup.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.viewGroup.Size = New System.Drawing.Size(400, 142)
        Me.viewGroup.TabIndex = 44
        Me.viewGroup.TabStop = False
        Me.viewGroup.Text = "View Settings"
        '
        'metresLabel
        '
        Me.metresLabel.AutoSize = True
        Me.metresLabel.Location = New System.Drawing.Point(308, 92)
        Me.metresLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.metresLabel.Name = "metresLabel"
        Me.metresLabel.Size = New System.Drawing.Size(77, 25)
        Me.metresLabel.TabIndex = 27
        Me.metresLabel.Text = "metres"
        '
        'distanceLabel
        '
        Me.distanceLabel.AutoSize = True
        Me.distanceLabel.Location = New System.Drawing.Point(12, 92)
        Me.distanceLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.distanceLabel.Name = "distanceLabel"
        Me.distanceLabel.Size = New System.Drawing.Size(148, 25)
        Me.distanceLabel.TabIndex = 26
        Me.distanceLabel.Text = "View Distance"
        '
        'terrainLabel
        '
        Me.terrainLabel.AutoSize = True
        Me.terrainLabel.Location = New System.Drawing.Point(12, 42)
        Me.terrainLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.terrainLabel.Name = "terrainLabel"
        Me.terrainLabel.Size = New System.Drawing.Size(126, 25)
        Me.terrainLabel.TabIndex = 23
        Me.terrainLabel.Text = "Terrain Grid"
        '
        'distanceNumeric
        '
        Me.distanceNumeric.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.distanceNumeric.Location = New System.Drawing.Point(174, 88)
        Me.distanceNumeric.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.distanceNumeric.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.distanceNumeric.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.distanceNumeric.Name = "distanceNumeric"
        Me.distanceNumeric.Size = New System.Drawing.Size(122, 31)
        Me.distanceNumeric.TabIndex = 25
        Me.distanceNumeric.Value = New Decimal(New Integer() {2500, 0, 0, 0})
        '
        'terrainNumeric
        '
        Me.terrainNumeric.DecimalPlaces = 3
        Me.terrainNumeric.Location = New System.Drawing.Point(174, 38)
        Me.terrainNumeric.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.terrainNumeric.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.terrainNumeric.Minimum = New Decimal(New Integer() {3125, 0, 0, 196608})
        Me.terrainNumeric.Name = "terrainNumeric"
        Me.terrainNumeric.Size = New System.Drawing.Size(122, 31)
        Me.terrainNumeric.TabIndex = 24
        Me.terrainNumeric.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'maxPingCheck
        '
        Me.maxPingCheck.AutoSize = True
        Me.maxPingCheck.Location = New System.Drawing.Point(12, 37)
        Me.maxPingCheck.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.maxPingCheck.Name = "maxPingCheck"
        Me.maxPingCheck.Size = New System.Drawing.Size(134, 29)
        Me.maxPingCheck.TabIndex = 34
        Me.maxPingCheck.Text = "Max Ping"
        Me.maxPingCheck.UseVisualStyleBackColor = True
        '
        'disconTimeNumeric
        '
        Me.disconTimeNumeric.Enabled = False
        Me.disconTimeNumeric.Location = New System.Drawing.Point(290, 185)
        Me.disconTimeNumeric.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.disconTimeNumeric.Maximum = New Decimal(New Integer() {600, 0, 0, 0})
        Me.disconTimeNumeric.Name = "disconTimeNumeric"
        Me.disconTimeNumeric.Size = New System.Drawing.Size(86, 31)
        Me.disconTimeNumeric.TabIndex = 43
        Me.disconTimeNumeric.Value = New Decimal(New Integer() {90, 0, 0, 0})
        '
        'maxDesyncCheck
        '
        Me.maxDesyncCheck.AutoSize = True
        Me.maxDesyncCheck.Location = New System.Drawing.Point(12, 87)
        Me.maxDesyncCheck.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.maxDesyncCheck.Name = "maxDesyncCheck"
        Me.maxDesyncCheck.Size = New System.Drawing.Size(163, 29)
        Me.maxDesyncCheck.TabIndex = 35
        Me.maxDesyncCheck.Text = "Max Desync"
        Me.maxDesyncCheck.UseVisualStyleBackColor = True
        '
        'packetLossNumeric
        '
        Me.packetLossNumeric.Enabled = False
        Me.packetLossNumeric.Location = New System.Drawing.Point(290, 135)
        Me.packetLossNumeric.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.packetLossNumeric.Name = "packetLossNumeric"
        Me.packetLossNumeric.Size = New System.Drawing.Size(86, 31)
        Me.packetLossNumeric.TabIndex = 42
        '
        'kickSlowCombo
        '
        Me.kickSlowCombo.BackColor = System.Drawing.SystemColors.Window
        Me.kickSlowCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.kickSlowCombo.Enabled = False
        Me.kickSlowCombo.FormattingEnabled = True
        Me.kickSlowCombo.Items.AddRange(New Object() {"Log", "Log & Kick"})
        Me.kickSlowCombo.Location = New System.Drawing.Point(290, 235)
        Me.kickSlowCombo.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.kickSlowCombo.Name = "kickSlowCombo"
        Me.kickSlowCombo.Size = New System.Drawing.Size(118, 33)
        Me.kickSlowCombo.TabIndex = 36
        '
        'maxDesyncNumeric
        '
        Me.maxDesyncNumeric.Enabled = False
        Me.maxDesyncNumeric.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.maxDesyncNumeric.Location = New System.Drawing.Point(290, 85)
        Me.maxDesyncNumeric.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.maxDesyncNumeric.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.maxDesyncNumeric.Name = "maxDesyncNumeric"
        Me.maxDesyncNumeric.Size = New System.Drawing.Size(122, 31)
        Me.maxDesyncNumeric.TabIndex = 41
        '
        'packetLossCheck
        '
        Me.packetLossCheck.AutoSize = True
        Me.packetLossCheck.Location = New System.Drawing.Point(12, 137)
        Me.packetLossCheck.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.packetLossCheck.Name = "packetLossCheck"
        Me.packetLossCheck.Size = New System.Drawing.Size(209, 29)
        Me.packetLossCheck.TabIndex = 37
        Me.packetLossCheck.Text = "Max Packet Loss"
        Me.packetLossCheck.UseVisualStyleBackColor = True
        '
        'maxPingNumeric
        '
        Me.maxPingNumeric.Enabled = False
        Me.maxPingNumeric.Location = New System.Drawing.Point(290, 35)
        Me.maxPingNumeric.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.maxPingNumeric.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.maxPingNumeric.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.maxPingNumeric.Name = "maxPingNumeric"
        Me.maxPingNumeric.Size = New System.Drawing.Size(86, 31)
        Me.maxPingNumeric.TabIndex = 40
        Me.maxPingNumeric.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'disconTimeCheck
        '
        Me.disconTimeCheck.AutoSize = True
        Me.disconTimeCheck.Location = New System.Drawing.Point(12, 187)
        Me.disconTimeCheck.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.disconTimeCheck.Name = "disconTimeCheck"
        Me.disconTimeCheck.Size = New System.Drawing.Size(234, 29)
        Me.disconTimeCheck.TabIndex = 38
        Me.disconTimeCheck.Text = "Disconnect Timeout"
        Me.disconTimeCheck.UseVisualStyleBackColor = True
        '
        'kickSlowCheck
        '
        Me.kickSlowCheck.AutoSize = True
        Me.kickSlowCheck.Location = New System.Drawing.Point(12, 238)
        Me.kickSlowCheck.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.kickSlowCheck.Name = "kickSlowCheck"
        Me.kickSlowCheck.Size = New System.Drawing.Size(255, 29)
        Me.kickSlowCheck.TabIndex = 39
        Me.kickSlowCheck.Text = "Kick On Slow Network"
        Me.kickSlowCheck.UseVisualStyleBackColor = True
        '
        'scriptingTab
        '
        Me.scriptingTab.BackColor = System.Drawing.Color.LightSkyBlue
        Me.scriptingTab.Controls.Add(Me.serverScriptsGroup)
        Me.scriptingTab.Location = New System.Drawing.Point(8, 39)
        Me.scriptingTab.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.scriptingTab.Name = "scriptingTab"
        Me.scriptingTab.Size = New System.Drawing.Size(1382, 466)
        Me.scriptingTab.TabIndex = 6
        Me.scriptingTab.Text = "Server Scripting"
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
        Me.serverScriptsGroup.Location = New System.Drawing.Point(12, 12)
        Me.serverScriptsGroup.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.serverScriptsGroup.Name = "serverScriptsGroup"
        Me.serverScriptsGroup.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.serverScriptsGroup.Size = New System.Drawing.Size(1360, 440)
        Me.serverScriptsGroup.TabIndex = 0
        Me.serverScriptsGroup.TabStop = False
        Me.serverScriptsGroup.Text = "Server Side Scripting"
        '
        'regularCheckLabel
        '
        Me.regularCheckLabel.AutoSize = True
        Me.regularCheckLabel.Location = New System.Drawing.Point(762, 342)
        Me.regularCheckLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.regularCheckLabel.Name = "regularCheckLabel"
        Me.regularCheckLabel.Size = New System.Drawing.Size(140, 25)
        Me.regularCheckLabel.TabIndex = 19
        Me.regularCheckLabel.Text = "regularCheck"
        '
        'onUnsignedDataLabel
        '
        Me.onUnsignedDataLabel.AutoSize = True
        Me.onUnsignedDataLabel.Location = New System.Drawing.Point(762, 244)
        Me.onUnsignedDataLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.onUnsignedDataLabel.Name = "onUnsignedDataLabel"
        Me.onUnsignedDataLabel.Size = New System.Drawing.Size(172, 25)
        Me.onUnsignedDataLabel.TabIndex = 18
        Me.onUnsignedDataLabel.Text = "onUnsignedData"
        '
        'onDifferentDataLabel
        '
        Me.onDifferentDataLabel.AutoSize = True
        Me.onDifferentDataLabel.Location = New System.Drawing.Point(762, 146)
        Me.onDifferentDataLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.onDifferentDataLabel.Name = "onDifferentDataLabel"
        Me.onDifferentDataLabel.Size = New System.Drawing.Size(162, 25)
        Me.onDifferentDataLabel.TabIndex = 17
        Me.onDifferentDataLabel.Text = "onDifferentData"
        '
        'onUnsignedDataBox
        '
        Me.onUnsignedDataBox.Location = New System.Drawing.Point(948, 238)
        Me.onUnsignedDataBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.onUnsignedDataBox.Multiline = False
        Me.onUnsignedDataBox.Name = "onUnsignedDataBox"
        Me.onUnsignedDataBox.Size = New System.Drawing.Size(396, 83)
        Me.onUnsignedDataBox.TabIndex = 16
        Me.onUnsignedDataBox.Text = ""
        '
        'regularCheckBox
        '
        Me.regularCheckBox.Location = New System.Drawing.Point(948, 337)
        Me.regularCheckBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.regularCheckBox.Multiline = False
        Me.regularCheckBox.Name = "regularCheckBox"
        Me.regularCheckBox.Size = New System.Drawing.Size(396, 83)
        Me.regularCheckBox.TabIndex = 15
        Me.regularCheckBox.Text = ""
        '
        'onDifferentDataBox
        '
        Me.onDifferentDataBox.Location = New System.Drawing.Point(948, 140)
        Me.onDifferentDataBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.onDifferentDataBox.Multiline = False
        Me.onDifferentDataBox.Name = "onDifferentDataBox"
        Me.onDifferentDataBox.Size = New System.Drawing.Size(396, 83)
        Me.onDifferentDataBox.TabIndex = 14
        Me.onDifferentDataBox.Text = ""
        '
        'onHackedDataBox
        '
        Me.onHackedDataBox.Location = New System.Drawing.Point(948, 42)
        Me.onHackedDataBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.onHackedDataBox.Multiline = False
        Me.onHackedDataBox.Name = "onHackedDataBox"
        Me.onHackedDataBox.Size = New System.Drawing.Size(396, 83)
        Me.onHackedDataBox.TabIndex = 13
        Me.onHackedDataBox.Text = ""
        '
        'onHackedDataLabel
        '
        Me.onHackedDataLabel.AutoSize = True
        Me.onHackedDataLabel.Location = New System.Drawing.Point(762, 48)
        Me.onHackedDataLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.onHackedDataLabel.Name = "onHackedDataLabel"
        Me.onHackedDataLabel.Size = New System.Drawing.Size(154, 25)
        Me.onHackedDataLabel.TabIndex = 12
        Me.onHackedDataLabel.Text = "onHackedData"
        '
        'onUserDisconnectedLabel
        '
        Me.onUserDisconnectedLabel.AutoSize = True
        Me.onUserDisconnectedLabel.Location = New System.Drawing.Point(16, 342)
        Me.onUserDisconnectedLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.onUserDisconnectedLabel.Name = "onUserDisconnectedLabel"
        Me.onUserDisconnectedLabel.Size = New System.Drawing.Size(212, 25)
        Me.onUserDisconnectedLabel.TabIndex = 11
        Me.onUserDisconnectedLabel.Text = "onUserDisconnected"
        '
        'onUserConnectedLabel
        '
        Me.onUserConnectedLabel.AutoSize = True
        Me.onUserConnectedLabel.Location = New System.Drawing.Point(16, 244)
        Me.onUserConnectedLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.onUserConnectedLabel.Name = "onUserConnectedLabel"
        Me.onUserConnectedLabel.Size = New System.Drawing.Size(185, 25)
        Me.onUserConnectedLabel.TabIndex = 10
        Me.onUserConnectedLabel.Text = "onUserConnected"
        '
        'doubleIdDetectedLabel
        '
        Me.doubleIdDetectedLabel.AutoSize = True
        Me.doubleIdDetectedLabel.Location = New System.Drawing.Point(16, 146)
        Me.doubleIdDetectedLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.doubleIdDetectedLabel.Name = "doubleIdDetectedLabel"
        Me.doubleIdDetectedLabel.Size = New System.Drawing.Size(180, 25)
        Me.doubleIdDetectedLabel.TabIndex = 9
        Me.doubleIdDetectedLabel.Text = "doubleIdDetected"
        '
        'onUserConnectedBox
        '
        Me.onUserConnectedBox.Location = New System.Drawing.Point(302, 238)
        Me.onUserConnectedBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.onUserConnectedBox.Multiline = False
        Me.onUserConnectedBox.Name = "onUserConnectedBox"
        Me.onUserConnectedBox.Size = New System.Drawing.Size(396, 83)
        Me.onUserConnectedBox.TabIndex = 8
        Me.onUserConnectedBox.Text = ""
        '
        'onUserDisconnectedBox
        '
        Me.onUserDisconnectedBox.Location = New System.Drawing.Point(302, 337)
        Me.onUserDisconnectedBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.onUserDisconnectedBox.Multiline = False
        Me.onUserDisconnectedBox.Name = "onUserDisconnectedBox"
        Me.onUserDisconnectedBox.Size = New System.Drawing.Size(396, 83)
        Me.onUserDisconnectedBox.TabIndex = 7
        Me.onUserDisconnectedBox.Text = ""
        '
        'doubleIdDetectedBox
        '
        Me.doubleIdDetectedBox.Location = New System.Drawing.Point(302, 140)
        Me.doubleIdDetectedBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.doubleIdDetectedBox.Multiline = False
        Me.doubleIdDetectedBox.Name = "doubleIdDetectedBox"
        Me.doubleIdDetectedBox.Size = New System.Drawing.Size(396, 83)
        Me.doubleIdDetectedBox.TabIndex = 6
        Me.doubleIdDetectedBox.Text = ""
        '
        'serverCommandBox
        '
        Me.serverCommandBox.Location = New System.Drawing.Point(302, 42)
        Me.serverCommandBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.serverCommandBox.Multiline = False
        Me.serverCommandBox.Name = "serverCommandBox"
        Me.serverCommandBox.Size = New System.Drawing.Size(396, 83)
        Me.serverCommandBox.TabIndex = 5
        Me.serverCommandBox.Text = ""
        '
        'serverCommandLabel
        '
        Me.serverCommandLabel.AutoSize = True
        Me.serverCommandLabel.Location = New System.Drawing.Point(16, 48)
        Me.serverCommandLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.serverCommandLabel.Name = "serverCommandLabel"
        Me.serverCommandLabel.Size = New System.Drawing.Size(278, 25)
        Me.serverCommandLabel.TabIndex = 0
        Me.serverCommandLabel.Text = "Server Command Password"
        '
        'NewServerTab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.serverTabs)
        Me.Controls.Add(Me.profileGroup)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "NewServerTab"
        Me.Size = New System.Drawing.Size(1398, 637)
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
        CType(Me.voteMinPlayersNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.vonGroup.ResumeLayout(False)
        Me.vonGroup.PerformLayout()
        CType(Me.codecNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.missionTab.ResumeLayout(False)
        Me.missionsGroup.ResumeLayout(False)
        Me.missionsGroup.PerformLayout()
        Me.customDifficutlyGroup.ResumeLayout(False)
        Me.customDifficutlyGroup.PerformLayout()
        Me.aiSettingsGroup.ResumeLayout(False)
        Me.aiSettingsGroup.PerformLayout()
        CType(Me.aiAccuracyNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.aiSkillNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.aiPresetNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.perfTab.ResumeLayout(False)
        Me.serverPerfGroup.ResumeLayout(False)
        Me.serverPerfGroup.PerformLayout()
        Me.clientPerfGroup.ResumeLayout(False)
        Me.clientPerfGroup.PerformLayout()
        Me.viewGroup.ResumeLayout(False)
        Me.viewGroup.PerformLayout()
        CType(Me.distanceNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.terrainNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.disconTimeNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.packetLossNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maxDesyncNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maxPingNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scriptingTab.ResumeLayout(False)
        Me.serverScriptsGroup.ResumeLayout(False)
        Me.serverScriptsGroup.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents profileNameBox As TextBox
    Friend WithEvents launchServerButton As Button
    Friend WithEvents profileGroup As GroupBox
    Friend WithEvents saveProfileButton As Button
    Friend WithEvents exportButton As Button
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
    Friend WithEvents voteMinPlayersNumeric As NumericUpDown
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
    Friend WithEvents missionsGroup As GroupBox
    Friend WithEvents missionRefreshButton As Button
    Friend WithEvents missionsNoneButton As Button
    Friend WithEvents missionsAllButton As Button
    Friend WithEvents missionsList As CheckedListBox
    Friend WithEvents customDifficutlyGroup As GroupBox
    Friend WithEvents difficultyCombo As ComboBox
    Friend WithEvents multipleSavesCheck As CheckBox
    Friend WithEvents autoReportingCheck As CheckBox
    Friend WithEvents mapContentCheck As CheckBox
    Friend WithEvents vonIDCheck As CheckBox
    Friend WithEvents killedByCheck As CheckBox
    Friend WithEvents scoreTableCheck As CheckBox
    Friend WithEvents cameraShakeCheck As CheckBox
    Friend WithEvents thirdPersonCheck As CheckBox
    Friend WithEvents visualAidCheck As CheckBox
    Friend WithEvents crosshairCheck As CheckBox
    Friend WithEvents staminaBarCheck As CheckBox
    Friend WithEvents stanceIndicatorCheck As CheckBox
    Friend WithEvents weaponInfoCheck As CheckBox
    Friend WithEvents waypointsCheck As CheckBox
    Friend WithEvents commandsCheck As CheckBox
    Friend WithEvents detectedMinesCheck As CheckBox
    Friend WithEvents enemyNameCheck As CheckBox
    Friend WithEvents friendlyNameCheck As CheckBox
    Friend WithEvents groupIndicatorCheck As CheckBox
    Friend WithEvents reducedDamageCheck As CheckBox
    Friend WithEvents aiSettingsGroup As GroupBox
    Friend WithEvents aiAccuracyLabel As Label
    Friend WithEvents aiSkillLabel As Label
    Friend WithEvents aiPresetLabel As Label
    Friend WithEvents aiAccuracyNumeric As NumericUpDown
    Friend WithEvents aiSkillNumeric As NumericUpDown
    Friend WithEvents aiPresetNumeric As NumericUpDown
    Friend WithEvents difficultyLabel As Label
    Friend WithEvents tacticalPingCheck As CheckBox
End Class
