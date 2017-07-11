Public Class FirstRun

    Private Sub ShowUserPassButton_Click(sender As Object, e As EventArgs) Handles showUserPassButton.Click
        If userPassBox.PasswordChar = "*" Then
            userPassBox.PasswordChar = ""
            showUserPassButton.BackgroundImage = My.Resources.Invisible_32px
        Else
            userPassBox.PasswordChar = "*"
            showUserPassButton.BackgroundImage = My.Resources.Visible_32px
        End If
    End Sub

    Private Sub SteamDirButton_Click(sender As Object, e As EventArgs) Handles steamDirButton.Click
        ChooseSteamDir()
    End Sub

    Public Sub ChooseSteamDir()
        If steamDirDialog.ShowDialog() = DialogResult.OK Then
            steamDirBox.Text = steamDirDialog.SelectedPath
        End If
    End Sub

    Private Sub ServerDirButton_Click(sender As Object, e As EventArgs) Handles serverDirButton.Click
        ChooseserverDir()
    End Sub

    Public Sub ChooseserverDir()
        If serverDirDialog.ShowDialog() = DialogResult.OK Then
            serverDirBox.Text = serverDirDialog.SelectedPath
        End If
    End Sub

    Private Sub ContinueButton_Click(sender As Object, e As EventArgs) Handles continueButton.Click
        My.Settings.userName = userNameBox.Text
        My.Settings.steamDir = steamDirBox.Text
        My.Settings.serverDir = serverDirBox.Text

        Dim encryptionString As String = Environment.UserName & MainWindow.SystemSerialNumber()
        Dim wrapper As New Simple3Des(encryptionString)
        Dim cypher As String = wrapper.EncryptData(userPassBox.Text)
        My.Settings.userPass = cypher

        MainWindow.steamDirBox.Text = My.Settings.steamDir
        MainWindow.serverDirBox.Text = My.Settings.serverDir
        MainWindow.userNameBox.Text = My.Settings.userName
        MainWindow.userPassBox.Text = userPassBox.Text
        MainWindow.infoBranchBox.Text = "N/A"
        MainWindow.infoUpdatedBox.Text = "N/A"

        My.Settings.firstRun = False
        Me.Close()

        If installSteamCheck.Checked Then
            Dim installSteam As New InstallSteamCMD
            installSteam.ShowDialog()
        End If

    End Sub
End Class