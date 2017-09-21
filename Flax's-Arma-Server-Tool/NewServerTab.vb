Imports System.IO
Imports System.Xml


Public Class NewServerTab

    Dim oProcess As New Process()

    Private Sub SaveProfileButton_Click(sender As Object, e As EventArgs) Handles saveProfileButton.Click
        SaveProfile()
    End Sub

    Public Sub SaveProfile()
        Dim newProfileName As String = MainWindow.SafeName(profileNameBox.Text)
        Dim oldProfileName As String = MainWindow.SafeName(MainWindow.categoryTabs.SelectedTab.Text)
        Dim path As String = Application.StartupPath & "\servers\"
        Dim profilePath As String = path & newProfileName & "\"

        MainWindow.categoryTabs.SelectedTab.Text = profileNameBox.Text

        If File.Exists(path & oldProfileName & ".FASTprofile") Then
            File.Delete(path & oldProfileName & ".FASTprofile")
        End If

        If Directory.Exists(path & oldProfileName) Then
            Directory.Delete(path & oldProfileName, True)
        End If

        If Not Directory.Exists(path & newProfileName) Then
            Directory.CreateDirectory(path & newProfileName)
        End If

        If Not File.Exists(profilePath & newProfileName & "_config.cfg") Then
            File.Create(profilePath & newProfileName & "_config.cfg")
        End If

        If Not File.Exists(profilePath & newProfileName & "_basic.cfg") Then
            File.Create(profilePath & newProfileName & "_basic.cfg")
        End If

        Dim writer As New XmlTextWriter(path & newProfileName & ".FASTprofile", System.Text.Encoding.UTF8)
        writer.WriteStartDocument(True)
        writer.Formatting = Formatting.Indented
        writer.Indentation = 2
        writer.WriteStartElement("profile")
        writer.WriteStartElement("settings")

        Dim allTxt As New List(Of Control)
        For Each txt As TextBox In MainWindow.FindControlRecursive(allTxt, Me, GetType(TextBox))
            WriteAttribute(txt.Name, txt.Text, writer)
        Next

        Dim allCheck As New List(Of Control)
        For Each check As CheckBox In MainWindow.FindControlRecursive(allCheck, Me, GetType(CheckBox))
            WriteAttribute(check.Name, check.CheckState, writer)
        Next

        writer.WriteEndElement()
        writer.WriteEndElement()
        writer.WriteEndDocument()
        writer.Close()
    End Sub

    Private Sub WriteAttribute(attribute As String, value As String, writer As XmlTextWriter)
        writer.WriteStartElement(attribute)
        writer.WriteString(value)
        writer.WriteEndElement()
    End Sub

    Private Sub ServerDirButton_Click(sender As Object, e As EventArgs) Handles serverDirButton.Click
        ChooseServerFile()
    End Sub

    Public Sub ChooseServerFile()
        If serverFileDialog.ShowDialog() = DialogResult.OK Then
            serverFileBox.Text = serverFileDialog.FileName
        End If
    End Sub

    Private Sub PersistCheck_CheckedChanged(sender As Object, e As EventArgs) Handles persistCheck.CheckedChanged
        If persistCheck.Checked Then
            autoInitCheck.Enabled = True
        Else
            autoInitCheck.Checked = False
            autoInitCheck.Enabled = False
        End If
    End Sub

    Private Sub DeleteProfileButton_Click(sender As Object, e As EventArgs) Handles deleteProfileButton.Click
        Try
            If File.Exists(Application.StartupPath & "\servers\" & MainWindow.categoryTabs.SelectedTab.Text & ".FASTprofile") Then
                File.Delete(Application.StartupPath & "\servers\" & MainWindow.categoryTabs.SelectedTab.Text & ".FASTprofile")
            End If

            If Directory.Exists(Application.StartupPath & "\servers\" & MainWindow.categoryTabs.SelectedTab.Text) Then
                Directory.Delete(Application.StartupPath & "\servers\" & MainWindow.categoryTabs.SelectedTab.Text, True)
            End If

            MainWindow.categoryTabs.TabPages.Remove(MainWindow.categoryTabs.SelectedTab)
        Catch ex As Exception
            MsgBox("Not all files were deleted - a file was open elsewhere.")
        End Try
    End Sub

    Private Sub LaunchServer_Click(sender As Object, e As EventArgs) Handles launchServer.Click

        If ReadyToLaunch(MainWindow.SafeName(profileNameBox.Text)) Then
            Dim profileName As String = MainWindow.SafeName(MainWindow.categoryTabs.SelectedTab.Text)
            Dim profilePath As String = Application.StartupPath & "\servers\" & profileName & "\"
            Dim configs As String = profilePath & profileName

            Dim commandLine As String
            commandLine = "-port=" & portBox.Text
            commandLine = commandLine & " ""-config=" & configs & "_config.cfg"""
            commandLine = commandLine & " ""-cfg=" & configs & "_basic.cfg"""
            commandLine = commandLine & " ""-profiles=" & profilePath & """"
            commandLine = commandLine & " -name=" & profileName

            If htCheck.Checked Then
                commandLine = commandLine & " -enableHT"
            End If

            If filePatchingCheck.Checked Then
                commandLine = commandLine & " -filePatching"
            End If

            Clipboard.SetText(commandLine)

            Dim oStartInfo As New ProcessStartInfo(serverFileBox.Text, commandLine)
            oProcess.StartInfo = oStartInfo
            oProcess.Start()
        Else
            MsgBox("Please make sure all fields are filled in and the profile is saved.")
        End If

    End Sub

    Public Function ReadyToLaunch(profile As String)
        If ProfileFilesExist(profile) Then
            Return True
            Exit Function
        End If
        Return False
    End Function

    Public Function ProfileFilesExist(profile As String)
        If Not Directory.Exists(Application.StartupPath & "\servers\" & profile) Then
            Return False
        End If

        If Not File.Exists(Application.StartupPath & "\servers\" & profile & "\" & profile & "_config.cfg") Then
            Return False
        End If

        If Not File.Exists(Application.StartupPath & "\servers\" & profile & "\" & profile & "_basic.cfg") Then
            Return False
        End If

        Return True
    End Function
End Class
