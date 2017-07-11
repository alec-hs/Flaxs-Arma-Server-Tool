<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FirstRun
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FirstRun))
        Me.infoLabel = New System.Windows.Forms.Label()
        Me.userNameLabel = New System.Windows.Forms.Label()
        Me.userNameBox = New System.Windows.Forms.TextBox()
        Me.userPassBox = New System.Windows.Forms.TextBox()
        Me.userPassLabel = New System.Windows.Forms.Label()
        Me.steamDirBox = New System.Windows.Forms.TextBox()
        Me.steamDirLabel = New System.Windows.Forms.Label()
        Me.serverDirBox = New System.Windows.Forms.TextBox()
        Me.serverDirLabel = New System.Windows.Forms.Label()
        Me.showUserPassButton = New System.Windows.Forms.Button()
        Me.serverDirButton = New System.Windows.Forms.Button()
        Me.steamDirButton = New System.Windows.Forms.Button()
        Me.installSteamCheck = New System.Windows.Forms.CheckBox()
        Me.installSteamLabel = New System.Windows.Forms.Label()
        Me.continueButton = New System.Windows.Forms.Button()
        Me.steamDirDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.serverDirDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.userInfoLabel = New System.Windows.Forms.Label()
        Me.passwordInfoLabel = New System.Windows.Forms.Label()
        Me.steamDirInfoLabel = New System.Windows.Forms.Label()
        Me.a3DirInfoLabel = New System.Windows.Forms.Label()
        Me.installSteamInfoLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'infoLabel
        '
        Me.infoLabel.AutoSize = True
        Me.infoLabel.Location = New System.Drawing.Point(17, 9)
        Me.infoLabel.Name = "infoLabel"
        Me.infoLabel.Size = New System.Drawing.Size(246, 26)
        Me.infoLabel.TabIndex = 0
        Me.infoLabel.Text = "Welcome to the Unofficial Arma 3 Server Updater. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Before you start use the form " &
    "below to get setup."
        '
        'userNameLabel
        '
        Me.userNameLabel.AutoSize = True
        Me.userNameLabel.Location = New System.Drawing.Point(12, 50)
        Me.userNameLabel.Name = "userNameLabel"
        Me.userNameLabel.Size = New System.Drawing.Size(62, 13)
        Me.userNameLabel.TabIndex = 1
        Me.userNameLabel.Text = "Steam User"
        '
        'userNameBox
        '
        Me.userNameBox.Location = New System.Drawing.Point(109, 47)
        Me.userNameBox.Name = "userNameBox"
        Me.userNameBox.Size = New System.Drawing.Size(181, 20)
        Me.userNameBox.TabIndex = 0
        '
        'userPassBox
        '
        Me.userPassBox.Location = New System.Drawing.Point(109, 96)
        Me.userPassBox.Name = "userPassBox"
        Me.userPassBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.userPassBox.Size = New System.Drawing.Size(151, 20)
        Me.userPassBox.TabIndex = 1
        '
        'userPassLabel
        '
        Me.userPassLabel.AutoSize = True
        Me.userPassLabel.Location = New System.Drawing.Point(12, 99)
        Me.userPassLabel.Name = "userPassLabel"
        Me.userPassLabel.Size = New System.Drawing.Size(86, 13)
        Me.userPassLabel.TabIndex = 7
        Me.userPassLabel.Text = "Steam Password"
        '
        'steamDirBox
        '
        Me.steamDirBox.Location = New System.Drawing.Point(109, 145)
        Me.steamDirBox.Name = "steamDirBox"
        Me.steamDirBox.Size = New System.Drawing.Size(151, 20)
        Me.steamDirBox.TabIndex = 3
        '
        'steamDirLabel
        '
        Me.steamDirLabel.AutoSize = True
        Me.steamDirLabel.Location = New System.Drawing.Point(12, 148)
        Me.steamDirLabel.Name = "steamDirLabel"
        Me.steamDirLabel.Size = New System.Drawing.Size(83, 13)
        Me.steamDirLabel.TabIndex = 9
        Me.steamDirLabel.Text = "Steam Install Dir"
        '
        'serverDirBox
        '
        Me.serverDirBox.Location = New System.Drawing.Point(109, 194)
        Me.serverDirBox.Name = "serverDirBox"
        Me.serverDirBox.Size = New System.Drawing.Size(151, 20)
        Me.serverDirBox.TabIndex = 5
        '
        'serverDirLabel
        '
        Me.serverDirLabel.AutoSize = True
        Me.serverDirLabel.Location = New System.Drawing.Point(12, 197)
        Me.serverDirLabel.Name = "serverDirLabel"
        Me.serverDirLabel.Size = New System.Drawing.Size(66, 13)
        Me.serverDirLabel.TabIndex = 11
        Me.serverDirLabel.Text = "A3 Install Dir"
        '
        'showUserPassButton
        '
        Me.showUserPassButton.BackgroundImage = CType(resources.GetObject("showUserPassButton.BackgroundImage"), System.Drawing.Image)
        Me.showUserPassButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.showUserPassButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.showUserPassButton.Location = New System.Drawing.Point(266, 96)
        Me.showUserPassButton.Name = "showUserPassButton"
        Me.showUserPassButton.Size = New System.Drawing.Size(24, 20)
        Me.showUserPassButton.TabIndex = 2
        Me.showUserPassButton.UseVisualStyleBackColor = True
        '
        'serverDirButton
        '
        Me.serverDirButton.BackgroundImage = CType(resources.GetObject("serverDirButton.BackgroundImage"), System.Drawing.Image)
        Me.serverDirButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.serverDirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.serverDirButton.Location = New System.Drawing.Point(266, 194)
        Me.serverDirButton.Name = "serverDirButton"
        Me.serverDirButton.Size = New System.Drawing.Size(24, 20)
        Me.serverDirButton.TabIndex = 6
        Me.serverDirButton.UseVisualStyleBackColor = True
        '
        'steamDirButton
        '
        Me.steamDirButton.BackgroundImage = CType(resources.GetObject("steamDirButton.BackgroundImage"), System.Drawing.Image)
        Me.steamDirButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.steamDirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.steamDirButton.Location = New System.Drawing.Point(266, 145)
        Me.steamDirButton.Name = "steamDirButton"
        Me.steamDirButton.Size = New System.Drawing.Size(24, 20)
        Me.steamDirButton.TabIndex = 4
        Me.steamDirButton.UseVisualStyleBackColor = True
        '
        'installSteamCheck
        '
        Me.installSteamCheck.AutoSize = True
        Me.installSteamCheck.Location = New System.Drawing.Point(109, 246)
        Me.installSteamCheck.Name = "installSteamCheck"
        Me.installSteamCheck.Size = New System.Drawing.Size(15, 14)
        Me.installSteamCheck.TabIndex = 8
        Me.installSteamCheck.UseVisualStyleBackColor = True
        '
        'installSteamLabel
        '
        Me.installSteamLabel.AutoSize = True
        Me.installSteamLabel.Location = New System.Drawing.Point(12, 246)
        Me.installSteamLabel.Name = "installSteamLabel"
        Me.installSteamLabel.Size = New System.Drawing.Size(91, 13)
        Me.installSteamLabel.TabIndex = 17
        Me.installSteamLabel.Text = "Install SteamCMD"
        '
        'continueButton
        '
        Me.continueButton.Location = New System.Drawing.Point(220, 291)
        Me.continueButton.Name = "continueButton"
        Me.continueButton.Size = New System.Drawing.Size(75, 23)
        Me.continueButton.TabIndex = 7
        Me.continueButton.Text = "Continue"
        Me.continueButton.UseVisualStyleBackColor = True
        '
        'userInfoLabel
        '
        Me.userInfoLabel.AutoSize = True
        Me.userInfoLabel.Location = New System.Drawing.Point(12, 70)
        Me.userInfoLabel.Name = "userInfoLabel"
        Me.userInfoLabel.Size = New System.Drawing.Size(148, 13)
        Me.userInfoLabel.TabIndex = 19
        Me.userInfoLabel.Text = "Your normal Steam username."
        '
        'passwordInfoLabel
        '
        Me.passwordInfoLabel.AutoSize = True
        Me.passwordInfoLabel.Location = New System.Drawing.Point(12, 119)
        Me.passwordInfoLabel.Name = "passwordInfoLabel"
        Me.passwordInfoLabel.Size = New System.Drawing.Size(150, 13)
        Me.passwordInfoLabel.TabIndex = 20
        Me.passwordInfoLabel.Text = "Your normal Steam password. "
        '
        'steamDirInfoLabel
        '
        Me.steamDirInfoLabel.AutoSize = True
        Me.steamDirInfoLabel.Location = New System.Drawing.Point(12, 168)
        Me.steamDirInfoLabel.Name = "steamDirInfoLabel"
        Me.steamDirInfoLabel.Size = New System.Drawing.Size(278, 13)
        Me.steamDirInfoLabel.TabIndex = 21
        Me.steamDirInfoLabel.Text = "The directrory where you want SteamCMD to be installed."
        '
        'a3DirInfoLabel
        '
        Me.a3DirInfoLabel.AutoSize = True
        Me.a3DirInfoLabel.Location = New System.Drawing.Point(12, 217)
        Me.a3DirInfoLabel.Name = "a3DirInfoLabel"
        Me.a3DirInfoLabel.Size = New System.Drawing.Size(247, 13)
        Me.a3DirInfoLabel.TabIndex = 22
        Me.a3DirInfoLabel.Text = "The directory where Arma 3 Server will be installed."
        '
        'installSteamInfoLabel
        '
        Me.installSteamInfoLabel.AutoSize = True
        Me.installSteamInfoLabel.Location = New System.Drawing.Point(12, 263)
        Me.installSteamInfoLabel.Name = "installSteamInfoLabel"
        Me.installSteamInfoLabel.Size = New System.Drawing.Size(234, 13)
        Me.installSteamInfoLabel.TabIndex = 23
        Me.installSteamInfoLabel.Text = "Tick if you want to install SteamCMD right away."
        '
        'FirstRun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 326)
        Me.Controls.Add(Me.installSteamInfoLabel)
        Me.Controls.Add(Me.a3DirInfoLabel)
        Me.Controls.Add(Me.steamDirInfoLabel)
        Me.Controls.Add(Me.passwordInfoLabel)
        Me.Controls.Add(Me.userInfoLabel)
        Me.Controls.Add(Me.continueButton)
        Me.Controls.Add(Me.installSteamLabel)
        Me.Controls.Add(Me.installSteamCheck)
        Me.Controls.Add(Me.steamDirButton)
        Me.Controls.Add(Me.serverDirButton)
        Me.Controls.Add(Me.showUserPassButton)
        Me.Controls.Add(Me.serverDirBox)
        Me.Controls.Add(Me.serverDirLabel)
        Me.Controls.Add(Me.steamDirBox)
        Me.Controls.Add(Me.steamDirLabel)
        Me.Controls.Add(Me.userPassBox)
        Me.Controls.Add(Me.userPassLabel)
        Me.Controls.Add(Me.userNameBox)
        Me.Controls.Add(Me.userNameLabel)
        Me.Controls.Add(Me.infoLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FirstRun"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "F.A.S.T - First Run"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents infoLabel As Label
    Friend WithEvents userNameLabel As Label
    Friend WithEvents userNameBox As TextBox
    Friend WithEvents userPassBox As TextBox
    Friend WithEvents userPassLabel As Label
    Friend WithEvents steamDirBox As TextBox
    Friend WithEvents steamDirLabel As Label
    Friend WithEvents serverDirBox As TextBox
    Friend WithEvents serverDirLabel As Label
    Friend WithEvents showUserPassButton As Button
    Friend WithEvents serverDirButton As Button
    Friend WithEvents steamDirButton As Button
    Friend WithEvents installSteamCheck As CheckBox
    Friend WithEvents installSteamLabel As Label
    Friend WithEvents continueButton As Button
    Friend WithEvents steamDirDialog As FolderBrowserDialog
    Friend WithEvents serverDirDialog As FolderBrowserDialog
    Friend WithEvents userInfoLabel As Label
    Friend WithEvents passwordInfoLabel As Label
    Friend WithEvents steamDirInfoLabel As Label
    Friend WithEvents a3DirInfoLabel As Label
    Friend WithEvents installSteamInfoLabel As Label
End Class
