<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InstallSteamCMD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InstallSteamCMD))
        Me.installDirLabel = New System.Windows.Forms.Label()
        Me.installDirBox = New System.Windows.Forms.TextBox()
        Me.installButton = New System.Windows.Forms.Button()
        Me.steamDirDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.steamDirButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'installDirLabel
        '
        Me.installDirLabel.AutoSize = True
        Me.installDirLabel.Location = New System.Drawing.Point(12, 19)
        Me.installDirLabel.Name = "installDirLabel"
        Me.installDirLabel.Size = New System.Drawing.Size(79, 13)
        Me.installDirLabel.TabIndex = 0
        Me.installDirLabel.Text = "Install Directory"
        '
        'installDirBox
        '
        Me.installDirBox.Location = New System.Drawing.Point(97, 16)
        Me.installDirBox.Name = "installDirBox"
        Me.installDirBox.Size = New System.Drawing.Size(181, 20)
        Me.installDirBox.TabIndex = 5
        Me.installDirBox.Text = "C:\Steam"
        '
        'installButton
        '
        Me.installButton.Location = New System.Drawing.Point(228, 42)
        Me.installButton.Name = "installButton"
        Me.installButton.Size = New System.Drawing.Size(80, 20)
        Me.installButton.TabIndex = 9
        Me.installButton.Text = "Install"
        Me.installButton.UseVisualStyleBackColor = True
        '
        'steamDirButton
        '
        Me.steamDirButton.BackgroundImage = CType(resources.GetObject("steamDirButton.BackgroundImage"), System.Drawing.Image)
        Me.steamDirButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.steamDirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.steamDirButton.Location = New System.Drawing.Point(284, 16)
        Me.steamDirButton.Name = "steamDirButton"
        Me.steamDirButton.Size = New System.Drawing.Size(24, 20)
        Me.steamDirButton.TabIndex = 8
        Me.steamDirButton.UseVisualStyleBackColor = True
        '
        'InstallSteamCMD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 73)
        Me.Controls.Add(Me.installButton)
        Me.Controls.Add(Me.steamDirButton)
        Me.Controls.Add(Me.installDirBox)
        Me.Controls.Add(Me.installDirLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "InstallSteamCMD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "F.A.S.T. - Install SteamCMD"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents installDirLabel As Label
    Friend WithEvents installDirBox As TextBox
    Friend WithEvents steamDirButton As Button
    Friend WithEvents installButton As Button
    Friend WithEvents steamDirDialog As FolderBrowserDialog
End Class
