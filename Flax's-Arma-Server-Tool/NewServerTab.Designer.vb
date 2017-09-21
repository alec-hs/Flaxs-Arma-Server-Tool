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
        Me.miscGroup = New System.Windows.Forms.GroupBox()
        Me.htCheck = New System.Windows.Forms.CheckBox()
        Me.kickDupeCheck = New System.Windows.Forms.CheckBox()
        Me.loopbackCheck = New System.Windows.Forms.CheckBox()
        Me.upnpCheck = New System.Windows.Forms.CheckBox()
        Me.autoInitCheck = New System.Windows.Forms.CheckBox()
        Me.persistCheck = New System.Windows.Forms.CheckBox()
        Me.vonCheck = New System.Windows.Forms.CheckBox()
        Me.battleyeCheck = New System.Windows.Forms.CheckBox()
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
        Me.perfTab = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.filePatchingCheck = New System.Windows.Forms.CheckBox()
        Me.profileGroup.SuspendLayout()
        Me.modsTab.SuspendLayout()
        Me.settingsTab.SuspendLayout()
        Me.miscGroup.SuspendLayout()
        Me.mainGroup.SuspendLayout()
        Me.serverTabs.SuspendLayout()
        Me.perfTab.SuspendLayout()
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
        Me.serverFileDialog.DefaultExt = "arma3*.exe"
        '
        'modsTab
        '
        Me.modsTab.Controls.Add(Me.TextBox1)
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
        Me.settingsTab.Controls.Add(Me.miscGroup)
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
        'miscGroup
        '
        Me.miscGroup.Controls.Add(Me.loopbackCheck)
        Me.miscGroup.Controls.Add(Me.filePatchingCheck)
        Me.miscGroup.Controls.Add(Me.htCheck)
        Me.miscGroup.Controls.Add(Me.kickDupeCheck)
        Me.miscGroup.Controls.Add(Me.upnpCheck)
        Me.miscGroup.Controls.Add(Me.autoInitCheck)
        Me.miscGroup.Controls.Add(Me.persistCheck)
        Me.miscGroup.Controls.Add(Me.vonCheck)
        Me.miscGroup.Controls.Add(Me.battleyeCheck)
        Me.miscGroup.Location = New System.Drawing.Point(6, 136)
        Me.miscGroup.Name = "miscGroup"
        Me.miscGroup.Size = New System.Drawing.Size(350, 100)
        Me.miscGroup.TabIndex = 12
        Me.miscGroup.TabStop = False
        Me.miscGroup.Text = "Misc"
        '
        'htCheck
        '
        Me.htCheck.AutoSize = True
        Me.htCheck.Location = New System.Drawing.Point(136, 74)
        Me.htCheck.Name = "htCheck"
        Me.htCheck.Size = New System.Drawing.Size(134, 17)
        Me.htCheck.TabIndex = 12
        Me.htCheck.Text = "Enable Hyperthreading"
        Me.htCheck.UseVisualStyleBackColor = True
        '
        'kickDupeCheck
        '
        Me.kickDupeCheck.AutoSize = True
        Me.kickDupeCheck.Location = New System.Drawing.Point(136, 51)
        Me.kickDupeCheck.Name = "kickDupeCheck"
        Me.kickDupeCheck.Size = New System.Drawing.Size(100, 17)
        Me.kickDupeCheck.TabIndex = 11
        Me.kickDupeCheck.Text = "Kick Duplicates"
        Me.kickDupeCheck.UseVisualStyleBackColor = True
        '
        'loopbackCheck
        '
        Me.loopbackCheck.AutoSize = True
        Me.loopbackCheck.Location = New System.Drawing.Point(276, 74)
        Me.loopbackCheck.Name = "loopbackCheck"
        Me.loopbackCheck.Size = New System.Drawing.Size(74, 17)
        Me.loopbackCheck.TabIndex = 15
        Me.loopbackCheck.Text = "Loopback"
        Me.loopbackCheck.UseVisualStyleBackColor = True
        '
        'upnpCheck
        '
        Me.upnpCheck.AutoSize = True
        Me.upnpCheck.Location = New System.Drawing.Point(276, 51)
        Me.upnpCheck.Name = "upnpCheck"
        Me.upnpCheck.Size = New System.Drawing.Size(56, 17)
        Me.upnpCheck.TabIndex = 14
        Me.upnpCheck.Text = "UPNP"
        Me.upnpCheck.UseVisualStyleBackColor = True
        '
        'autoInitCheck
        '
        Me.autoInitCheck.AutoSize = True
        Me.autoInitCheck.Enabled = False
        Me.autoInitCheck.Location = New System.Drawing.Point(9, 74)
        Me.autoInitCheck.Name = "autoInitCheck"
        Me.autoInitCheck.Size = New System.Drawing.Size(65, 17)
        Me.autoInitCheck.TabIndex = 9
        Me.autoInitCheck.Text = "Auto Init"
        Me.autoInitCheck.UseVisualStyleBackColor = True
        '
        'persistCheck
        '
        Me.persistCheck.AutoSize = True
        Me.persistCheck.Location = New System.Drawing.Point(9, 51)
        Me.persistCheck.Name = "persistCheck"
        Me.persistCheck.Size = New System.Drawing.Size(121, 17)
        Me.persistCheck.TabIndex = 8
        Me.persistCheck.Text = "Persistant Battlefield"
        Me.persistCheck.UseVisualStyleBackColor = True
        '
        'vonCheck
        '
        Me.vonCheck.AutoSize = True
        Me.vonCheck.Location = New System.Drawing.Point(9, 28)
        Me.vonCheck.Name = "vonCheck"
        Me.vonCheck.Size = New System.Drawing.Size(87, 17)
        Me.vonCheck.TabIndex = 7
        Me.vonCheck.Text = "Disable VON"
        Me.vonCheck.UseVisualStyleBackColor = True
        '
        'battleyeCheck
        '
        Me.battleyeCheck.AutoSize = True
        Me.battleyeCheck.Location = New System.Drawing.Point(276, 28)
        Me.battleyeCheck.Name = "battleyeCheck"
        Me.battleyeCheck.Size = New System.Drawing.Size(65, 17)
        Me.battleyeCheck.TabIndex = 13
        Me.battleyeCheck.Text = "BattlEye"
        Me.battleyeCheck.UseVisualStyleBackColor = True
        '
        'rulesGroup
        '
        Me.rulesGroup.Location = New System.Drawing.Point(365, 6)
        Me.rulesGroup.Name = "rulesGroup"
        Me.rulesGroup.Size = New System.Drawing.Size(320, 230)
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
        Me.serverDirButton.Location = New System.Drawing.Point(308, 39)
        Me.serverDirButton.Name = "serverDirButton"
        Me.serverDirButton.Size = New System.Drawing.Size(24, 20)
        Me.serverDirButton.TabIndex = 2
        Me.serverDirButton.UseVisualStyleBackColor = True
        '
        'serverFileBox
        '
        Me.serverFileBox.Location = New System.Drawing.Point(94, 39)
        Me.serverFileBox.Name = "serverFileBox"
        Me.serverFileBox.Size = New System.Drawing.Size(208, 20)
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
        Me.serverNameBox.Size = New System.Drawing.Size(238, 20)
        Me.serverNameBox.TabIndex = 0
        '
        'portBox
        '
        Me.portBox.Location = New System.Drawing.Point(270, 91)
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
        Me.maxPlayersLabel.Location = New System.Drawing.Point(200, 68)
        Me.maxPlayersLabel.Name = "maxPlayersLabel"
        Me.maxPlayersLabel.Size = New System.Drawing.Size(64, 13)
        Me.maxPlayersLabel.TabIndex = 8
        Me.maxPlayersLabel.Text = "Max Players"
        '
        'passwordBox
        '
        Me.passwordBox.Location = New System.Drawing.Point(94, 65)
        Me.passwordBox.Name = "passwordBox"
        Me.passwordBox.Size = New System.Drawing.Size(93, 20)
        Me.passwordBox.TabIndex = 3
        '
        'maxPlayersBox
        '
        Me.maxPlayersBox.Location = New System.Drawing.Point(270, 65)
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
        Me.portLabel.Location = New System.Drawing.Point(238, 94)
        Me.portLabel.Name = "portLabel"
        Me.portLabel.Size = New System.Drawing.Size(26, 13)
        Me.portLabel.TabIndex = 6
        Me.portLabel.Text = "Port"
        '
        'adminPassBox
        '
        Me.adminPassBox.Location = New System.Drawing.Point(94, 91)
        Me.adminPassBox.Name = "adminPassBox"
        Me.adminPassBox.Size = New System.Drawing.Size(93, 20)
        Me.adminPassBox.TabIndex = 4
        '
        'serverTabs
        '
        Me.serverTabs.Controls.Add(Me.settingsTab)
        Me.serverTabs.Controls.Add(Me.modsTab)
        Me.serverTabs.Controls.Add(Me.perfTab)
        Me.serverTabs.Dock = System.Windows.Forms.DockStyle.Top
        Me.serverTabs.Location = New System.Drawing.Point(0, 0)
        Me.serverTabs.Name = "serverTabs"
        Me.serverTabs.SelectedIndex = 0
        Me.serverTabs.Size = New System.Drawing.Size(699, 267)
        Me.serverTabs.TabIndex = 4
        '
        'perfTab
        '
        Me.perfTab.Controls.Add(Me.TextBox2)
        Me.perfTab.Location = New System.Drawing.Point(4, 22)
        Me.perfTab.Name = "perfTab"
        Me.perfTab.Padding = New System.Windows.Forms.Padding(3)
        Me.perfTab.Size = New System.Drawing.Size(691, 241)
        Me.perfTab.TabIndex = 2
        Me.perfTab.Text = "Perfomance"
        Me.perfTab.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(226, 110)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(238, 20)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(226, 110)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(238, 20)
        Me.TextBox2.TabIndex = 1
        '
        'filePatchingCheck
        '
        Me.filePatchingCheck.AutoSize = True
        Me.filePatchingCheck.Location = New System.Drawing.Point(136, 28)
        Me.filePatchingCheck.Name = "filePatchingCheck"
        Me.filePatchingCheck.Size = New System.Drawing.Size(87, 17)
        Me.filePatchingCheck.TabIndex = 10
        Me.filePatchingCheck.Text = "File Patching"
        Me.filePatchingCheck.UseVisualStyleBackColor = True
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
        Me.modsTab.PerformLayout()
        Me.settingsTab.ResumeLayout(False)
        Me.miscGroup.ResumeLayout(False)
        Me.miscGroup.PerformLayout()
        Me.mainGroup.ResumeLayout(False)
        Me.mainGroup.PerformLayout()
        Me.serverTabs.ResumeLayout(False)
        Me.perfTab.ResumeLayout(False)
        Me.perfTab.PerformLayout()
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
    Friend WithEvents miscGroup As GroupBox
    Friend WithEvents htCheck As CheckBox
    Friend WithEvents kickDupeCheck As CheckBox
    Friend WithEvents loopbackCheck As CheckBox
    Friend WithEvents upnpCheck As CheckBox
    Friend WithEvents autoInitCheck As CheckBox
    Friend WithEvents persistCheck As CheckBox
    Friend WithEvents vonCheck As CheckBox
    Friend WithEvents battleyeCheck As CheckBox
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents perfTab As TabPage
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents filePatchingCheck As CheckBox
End Class
