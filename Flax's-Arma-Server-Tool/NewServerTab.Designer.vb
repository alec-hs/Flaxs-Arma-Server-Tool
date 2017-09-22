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
        Me.serverFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.modsTab = New System.Windows.Forms.TabPage()
        Me.settingsTab = New System.Windows.Forms.TabPage()
        Me.networkGroup = New System.Windows.Forms.GroupBox()
        Me.netlogCheck = New System.Windows.Forms.CheckBox()
        Me.loopbackCheck = New System.Windows.Forms.CheckBox()
        Me.upnpCheck = New System.Windows.Forms.CheckBox()
        Me.headlessGroup = New System.Windows.Forms.GroupBox()
        Me.noOfHCBox = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.enableHCCheck = New System.Windows.Forms.CheckBox()
        Me.localClientBox = New System.Windows.Forms.TextBox()
        Me.headlessIPBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.HCIPLabel = New System.Windows.Forms.Label()
        Me.rulesGroup = New System.Windows.Forms.GroupBox()
        Me.mainGroup = New System.Windows.Forms.GroupBox()
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
        Me.rulesTab = New System.Windows.Forms.TabPage()
        Me.kickDupeCheck = New System.Windows.Forms.CheckBox()
        Me.battleyeCheck = New System.Windows.Forms.CheckBox()
        Me.vonCheck = New System.Windows.Forms.CheckBox()
        Me.perfTab = New System.Windows.Forms.TabPage()
        Me.filePatchingCheck = New System.Windows.Forms.CheckBox()
        Me.htCheck = New System.Windows.Forms.CheckBox()
        Me.missionTab = New System.Windows.Forms.TabPage()
        Me.persistCheck = New System.Windows.Forms.CheckBox()
        Me.autoInitCheck = New System.Windows.Forms.CheckBox()
        Me.difficultyTab = New System.Windows.Forms.TabPage()
        Me.scriptingTab = New System.Windows.Forms.TabPage()
        Me.profileGroup.SuspendLayout()
        Me.settingsTab.SuspendLayout()
        Me.networkGroup.SuspendLayout()
        Me.headlessGroup.SuspendLayout()
        CType(Me.noOfHCBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mainGroup.SuspendLayout()
        Me.serverTabs.SuspendLayout()
        Me.rulesTab.SuspendLayout()
        Me.perfTab.SuspendLayout()
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
        'serverFileDialog
        '
        Me.serverFileDialog.DefaultExt = "exe"
        Me.serverFileDialog.Filter = "Arma 3 Server Files|arma*.exe"
        '
        'modsTab
        '
        Me.modsTab.Location = New System.Drawing.Point(4, 22)
        Me.modsTab.Name = "modsTab"
        Me.modsTab.Padding = New System.Windows.Forms.Padding(3)
        Me.modsTab.Size = New System.Drawing.Size(691, 241)
        Me.modsTab.TabIndex = 1
        Me.modsTab.Text = "Mods"
        Me.modsTab.UseVisualStyleBackColor = True
        '
        'settingsTab
        '
        Me.settingsTab.Controls.Add(Me.networkGroup)
        Me.settingsTab.Controls.Add(Me.headlessGroup)
        Me.settingsTab.Controls.Add(Me.rulesGroup)
        Me.settingsTab.Controls.Add(Me.mainGroup)
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
        Me.headlessGroup.Controls.Add(Me.noOfHCBox)
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
        'noOfHCBox
        '
        Me.noOfHCBox.Enabled = False
        Me.noOfHCBox.Location = New System.Drawing.Point(134, 17)
        Me.noOfHCBox.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.noOfHCBox.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.noOfHCBox.Name = "noOfHCBox"
        Me.noOfHCBox.Size = New System.Drawing.Size(42, 20)
        Me.noOfHCBox.TabIndex = 14
        Me.noOfHCBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
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
        'mainGroup
        '
        Me.mainGroup.Controls.Add(Me.serverDirButton)
        Me.mainGroup.Controls.Add(Me.serverFileBox)
        Me.mainGroup.Controls.Add(Me.Label1)
        Me.mainGroup.Controls.Add(Me.nameLabel)
        Me.mainGroup.Controls.Add(Me.serverNameBox)
        Me.mainGroup.Controls.Add(Me.portBox)
        Me.mainGroup.Controls.Add(Me.passwordLabel)
        Me.mainGroup.Controls.Add(Me.maxPlayersLabel)
        Me.mainGroup.Controls.Add(Me.passwordBox)
        Me.mainGroup.Controls.Add(Me.maxPlayersBox)
        Me.mainGroup.Controls.Add(Me.adminPassLabel)
        Me.mainGroup.Controls.Add(Me.portLabel)
        Me.mainGroup.Controls.Add(Me.adminPassBox)
        Me.mainGroup.Location = New System.Drawing.Point(6, 6)
        Me.mainGroup.Name = "mainGroup"
        Me.mainGroup.Size = New System.Drawing.Size(350, 120)
        Me.mainGroup.TabIndex = 11
        Me.mainGroup.TabStop = False
        Me.mainGroup.Text = "Main"
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
        Me.serverTabs.Controls.Add(Me.rulesTab)
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
        'rulesTab
        '
        Me.rulesTab.Controls.Add(Me.kickDupeCheck)
        Me.rulesTab.Controls.Add(Me.battleyeCheck)
        Me.rulesTab.Controls.Add(Me.vonCheck)
        Me.rulesTab.Location = New System.Drawing.Point(4, 22)
        Me.rulesTab.Name = "rulesTab"
        Me.rulesTab.Padding = New System.Windows.Forms.Padding(3)
        Me.rulesTab.Size = New System.Drawing.Size(691, 241)
        Me.rulesTab.TabIndex = 3
        Me.rulesTab.Text = "Rules"
        Me.rulesTab.UseVisualStyleBackColor = True
        '
        'kickDupeCheck
        '
        Me.kickDupeCheck.AutoSize = True
        Me.kickDupeCheck.Location = New System.Drawing.Point(359, 83)
        Me.kickDupeCheck.Name = "kickDupeCheck"
        Me.kickDupeCheck.Size = New System.Drawing.Size(100, 17)
        Me.kickDupeCheck.TabIndex = 15
        Me.kickDupeCheck.Text = "Kick Duplicates"
        Me.kickDupeCheck.UseVisualStyleBackColor = True
        '
        'battleyeCheck
        '
        Me.battleyeCheck.AutoSize = True
        Me.battleyeCheck.Location = New System.Drawing.Point(332, 163)
        Me.battleyeCheck.Name = "battleyeCheck"
        Me.battleyeCheck.Size = New System.Drawing.Size(65, 17)
        Me.battleyeCheck.TabIndex = 16
        Me.battleyeCheck.Text = "BattlEye"
        Me.battleyeCheck.UseVisualStyleBackColor = True
        '
        'vonCheck
        '
        Me.vonCheck.AutoSize = True
        Me.vonCheck.Location = New System.Drawing.Point(232, 60)
        Me.vonCheck.Name = "vonCheck"
        Me.vonCheck.Size = New System.Drawing.Size(87, 17)
        Me.vonCheck.TabIndex = 14
        Me.vonCheck.Text = "Disable VON"
        Me.vonCheck.UseVisualStyleBackColor = True
        '
        'perfTab
        '
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
        Me.settingsTab.ResumeLayout(False)
        Me.networkGroup.ResumeLayout(False)
        Me.networkGroup.PerformLayout()
        Me.headlessGroup.ResumeLayout(False)
        Me.headlessGroup.PerformLayout()
        CType(Me.noOfHCBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mainGroup.ResumeLayout(False)
        Me.mainGroup.PerformLayout()
        Me.serverTabs.ResumeLayout(False)
        Me.rulesTab.ResumeLayout(False)
        Me.rulesTab.PerformLayout()
        Me.perfTab.ResumeLayout(False)
        Me.perfTab.PerformLayout()
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
    Friend WithEvents mainGroup As GroupBox
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
    Friend WithEvents noOfHCBox As NumericUpDown
    Friend WithEvents netlogCheck As CheckBox
    Friend WithEvents rulesTab As TabPage
    Friend WithEvents missionTab As TabPage
    Friend WithEvents difficultyTab As TabPage
    Friend WithEvents scriptingTab As TabPage
    Friend WithEvents kickDupeCheck As CheckBox
    Friend WithEvents battleyeCheck As CheckBox
    Friend WithEvents vonCheck As CheckBox
    Friend WithEvents filePatchingCheck As CheckBox
    Friend WithEvents htCheck As CheckBox
    Friend WithEvents persistCheck As CheckBox
    Friend WithEvents autoInitCheck As CheckBox
End Class
