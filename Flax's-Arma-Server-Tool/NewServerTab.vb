Imports System.IO
Imports System.Xml

Public Class NewServerTab
    Private Sub NewServerTab_Load(sender As Object, e As EventArgs) Handles Me.Load
        If filePatchCombo.SelectedIndex = -1 Then
            filePatchCombo.SelectedItem = "2"
        End If

        If verifySigCombo.SelectedIndex = -1 Then
            verifySigCombo.SelectedItem = "none"
        End If

        If rptTimeCombo.SelectedIndex = -1 Then
            rptTimeCombo.SelectedItem = "none"
        End If

        If kickSlowCombo.SelectedIndex = -1 Then
            kickSlowCombo.SelectedItem = "Log"
        End If

        If difficultyCombo.SelectedIndex = -1 Then
            difficultyCombo.SelectedItem = "Regular"
        End If

        UpdateModsList()

    End Sub

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

        If Not Directory.Exists(profilePath) Then
            Directory.CreateDirectory(profilePath)
        End If

        If Not File.Exists(profilePath & newProfileName & "_config.cfg") Then
            Dim cfg = File.Create(profilePath & newProfileName & "_config.cfg")
            cfg.Close()
        End If

        If Not File.Exists(profilePath & newProfileName & "_basic.cfg") Then
            Dim cfg = File.Create(profilePath & newProfileName & "_basic.cfg")
            cfg.Close()
        End If


        Dim settings = New XmlWriterSettings With {
            .Indent = True,
            .IndentChars = " ",
            .NewLineOnAttributes = True,
            .CloseOutput = True
        }

        Using writer As XmlWriter = XmlWriter.Create(System.IO.File.Create(path & newProfileName & ".FASTprofile"), settings)
            writer.WriteStartDocument(True)
            writer.WriteStartElement("profile")
            writer.WriteStartElement("settings")

            Dim allTxt As New List(Of Control)
            For Each txt As TextBox In MainWindow.FindControlRecursive(allTxt, Me, GetType(TextBox))
                writer.WriteStartElement(txt.Name)
                writer.WriteString(txt.Text)
                writer.WriteEndElement()
            Next

            Dim allRichTxt As New List(Of Control)
            For Each richTxt As RichTextBox In MainWindow.FindControlRecursive(allRichTxt, Me, GetType(RichTextBox))

                writer.WriteStartElement(richTxt.Name)
                For Each line In richTxt.Lines
                    writer.WriteStartElement("line")
                    writer.WriteString(line)
                    writer.WriteEndElement()
                Next
                writer.WriteEndElement()
            Next

            Dim allCheck As New List(Of Control)
            For Each check As CheckBox In MainWindow.FindControlRecursive(allCheck, Me, GetType(CheckBox))
                writer.WriteStartElement(check.Name)
                writer.WriteString(check.CheckState)
                writer.WriteEndElement()
            Next

            Dim allCombo As New List(Of Control)
            For Each combo As ComboBox In MainWindow.FindControlRecursive(allCombo, Me, GetType(ComboBox))
                writer.WriteStartElement(combo.Name)
                writer.WriteString(combo.SelectedItem)
                writer.WriteEndElement()
            Next

            Dim allNumeric As New List(Of Control)
            For Each numeric As NumericUpDown In MainWindow.FindControlRecursive(allNumeric, Me, GetType(NumericUpDown))
                writer.WriteStartElement(numeric.Name)
                writer.WriteString(numeric.Value)
                writer.WriteEndElement()
            Next

            writer.WriteEndElement()
            writer.WriteEndElement()
            writer.WriteEndDocument()
            writer.Close()
        End Using

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
        MainWindow.DeleteProfile(MainWindow.categoryTabs.SelectedTab.Text, True)
    End Sub

    Private Sub LaunchServer_Click(sender As Object, e As EventArgs) Handles launchServer.Click

        If ReadyToLaunch(profileNameBox.Text) Then
            Dim profileName As String = MainWindow.SafeName(MainWindow.categoryTabs.SelectedTab.Text)
            Dim profilePath As String = Application.StartupPath & "\servers\" & profileName & "\"
            Dim configs As String = profilePath & profileName
            Dim start As Boolean = True
            Dim serverMods As String = Nothing

            For Each addon In serverModsList.CheckedItems
                serverMods = serverMods & addon & ";"
            Next

            Try
                WriteConfigFiles(profileName)
            Catch ex As Exception
                MsgBox("Config files in use elsewhere - make sure server is not running.")
                start = False
            End Try

            If start Then
                Dim commandLine As String
                commandLine = "-port=" & portBox.Text
                commandLine = commandLine & " ""-config=" & configs & "_config.cfg"""
                commandLine = commandLine & " ""-cfg=" & configs & "_basic.cfg"""
                commandLine = commandLine & " ""-profiles=" & profilePath & """"
                commandLine = commandLine & " -name=" & profileName
                commandLine = commandLine & " ""-mods=" & serverMods & """"


                If htCheck.Checked Then
                    commandLine = commandLine & " -enableHT"
                End If

                If filePatchingCheck.Checked Then
                    commandLine = commandLine & " -filePatching"
                End If

                Clipboard.SetText(commandLine)

                Dim sStartInfo As New ProcessStartInfo(serverFileBox.Text, commandLine)
                Dim sProcess As New Process With {
                    .StartInfo = sStartInfo
                }
                sProcess.Start()

                If enableHCCheck.Checked Then
                    For hc As Integer = 1 To noOfHCNumeric.Value
                        Dim hcCommandLine As String = "-client -connect=127.0.0.1 -password=" & passwordBox.Text & " -profiles=" & profilePath & " -nosound"
                        Dim hcMods As String = Nothing

                        For Each addon In hcModsList.CheckedItems
                            hcMods = hcMods & addon & ";"
                        Next

                        hcCommandLine = hcCommandLine & " ""-mods=" & serverMods & """"

                        Clipboard.SetText(hcCommandLine)

                        Dim hcStartInfo As New ProcessStartInfo(serverFileBox.Text, hcCommandLine)
                        Dim hcProcess As New Process With {
                            .StartInfo = hcStartInfo
                        }
                        hcProcess.Start()
                    Next
                End If
            End If

        Else
            MsgBox("Please make sure all fields are filled in and the profile is saved.")
        End If

    End Sub

    Public Function ReadyToLaunch(profile As String)

        profile = MainWindow.SafeName(profile)

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

    Public Sub WriteConfigFiles(profile As String)

        profile = MainWindow.SafeName(profile)

        Dim config As String = Application.StartupPath & "\servers\" & profile & "\" & profile & "_config.cfg"
        Dim basic As String = Application.StartupPath & "\servers\" & profile & "\" & profile & "_basic.cfg"
        Dim configLines As New List(Of String) From {
            "hostname=""" & serverNameBox.Text & """;",
            "password=""" & passwordBox.Text & """;",
            "passwordAdmin=""" & adminPassBox.Text & """;",
            "maxPlayers=" & maxPlayersBox.Text & ";",
            "kickDuplicate=" & kickDupeCheck.CheckState & ";",
            "allowedFilePatching=" & filePatchingCheck.CheckState & ";",
            "disableVoN=" & vonCheck.CheckState & ";",
            "persistent=" & persistCheck.CheckState & ";",
            "BattlEye=" & maxPingCheck.CheckState & ";"
        }

        If enableHCCheck.Checked Then
            configLines.Add("headlessClients[] ={" & headlessIPBox.Text & "};")
            configLines.Add("localClient[] ={" & localClientBox.Text & "};")
        End If

        File.WriteAllLines(config, configLines)

    End Sub

    Private Sub EnableHCCheck_CheckedChanged(sender As Object, e As EventArgs) Handles enableHCCheck.CheckedChanged
        If enableHCCheck.Checked Then
            noOfHCNumeric.Enabled = True
            headlessIPBox.Enabled = True
            localClientBox.Enabled = True
        Else
            noOfHCNumeric.Enabled = False
            headlessIPBox.Enabled = False
            localClientBox.Enabled = False
        End If
    End Sub

    Private Sub MaxPlayersBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles maxPlayersBox.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        End If
    End Sub

    Private Sub PortBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles portBox.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        End If
    End Sub

    Private Sub LocalClientBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles localClientBox.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = ",")
        End If
    End Sub

    Private Sub HeadlessIPBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles headlessIPBox.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = ",")
        End If
    End Sub

    Public Sub UpdateModsList()
        serverModsList.Items.Clear()
        hcModsList.Items.Clear()

        Dim currentMods = serverModsList.Items
        Dim newMods As New List(Of String)

        If Directory.Exists(My.Settings.serverDir) Then
            For Each addon In Directory.GetDirectories(My.Settings.serverDir)
                If addon.Contains("@") Then
                    newMods.Add(Replace(addon, My.Settings.serverDir & "\", ""))
                End If
            Next

            For Each addon In newMods.ToList
                For Each nAddon In currentMods
                    If nAddon = addon Then
                        newMods.Remove(nAddon)
                    End If
                Next
            Next

            For Each addon In newMods.ToList
                serverModsList.Items.Add(addon)
                hcModsList.Items.Add(addon)
            Next
        Else
            MsgBox("Please install game before continuing.")
        End If

    End Sub

    Private Sub ServerToHCButton_Click(sender As Object, e As EventArgs) Handles serverToHCButton.Click
        For Each item In serverModsList.Items
            Dim index As Integer = serverModsList.FindString(item)
            Dim check As Integer = serverModsList.GetItemCheckState(index)
            Dim newIndex As Integer = hcModsList.FindString(item)

            hcModsList.SetItemCheckState(newIndex, check)
        Next
    End Sub

    Private Sub HcToServerButton_Click(sender As Object, e As EventArgs) Handles hcToServerButton.Click
        For Each item In hcModsList.Items
            Dim index As Integer = hcModsList.FindString(item)
            Dim check As Integer = hcModsList.GetItemCheckState(index)
            Dim newIndex As Integer = serverModsList.FindString(item)

            serverModsList.SetItemCheckState(newIndex, check)
        Next
    End Sub

    Private Sub ServerModsAllButton_Click(sender As Object, e As EventArgs) Handles serverModsAllButton.Click
        For i = 0 To serverModsList.Items.Count - 1
            serverModsList.SetItemChecked(i, 1)
        Next i
    End Sub

    Private Sub ServerModsNoneButton_Click(sender As Object, e As EventArgs) Handles serverModsNoneButton.Click
        For i = 0 To serverModsList.Items.Count - 1
            serverModsList.SetItemChecked(i, 0)
        Next i
    End Sub

    Private Sub HcModsAllButton_Click(sender As Object, e As EventArgs) Handles hcModsAllButton.Click
        For i = 0 To serverModsList.Items.Count - 1
            hcModsList.SetItemChecked(i, 1)
        Next i
    End Sub

    Private Sub HcModsNoneButton_Click(sender As Object, e As EventArgs) Handles hcModsNoneButton.Click
        For i = 0 To serverModsList.Items.Count - 1
            hcModsList.SetItemChecked(i, 0)
        Next i
    End Sub

    Private Sub ServerModsUpButton_Click(sender As Object, e As EventArgs) Handles serverModsUpButton.Click
        Dim index As Integer = serverModsList.SelectedIndex
        Dim addon As String = serverModsList.SelectedItem
        Dim check As Integer = serverModsList.GetItemCheckState(index)

        If index > 0 Then
            serverModsList.Items.RemoveAt(index)
            serverModsList.Items.Insert(index - 1, addon)
            serverModsList.SelectedIndex = index - 1
            serverModsList.SetItemCheckState(index - 1, check)
        End If
    End Sub

    Private Sub ServerModsDownButton_Click(sender As Object, e As EventArgs) Handles serverModsDownButton.Click
        Dim index As Integer = serverModsList.SelectedIndex
        Dim addon As String = serverModsList.SelectedItem
        Dim check As Integer = serverModsList.GetItemCheckState(index)

        If index < serverModsList.Items.Count - 1 Then
            serverModsList.Items.RemoveAt(index)
            serverModsList.Items.Insert(index + 1, addon)
            serverModsList.SelectedIndex = index + 1
            serverModsList.SetItemCheckState(index + 1, check)
        End If
    End Sub

    Private Sub HcModsUpButton_Click(sender As Object, e As EventArgs) Handles hcModsUpButton.Click
        Dim index As Integer = hcModsList.SelectedIndex
        Dim addon As String = hcModsList.SelectedItem
        Dim check As Integer = hcModsList.GetItemCheckState(index)

        If index > 0 Then
            hcModsList.Items.RemoveAt(index)
            hcModsList.Items.Insert(index - 1, addon)
            hcModsList.SelectedIndex = index - 1
            hcModsList.SetItemCheckState(index - 1, check)
        End If
    End Sub

    Private Sub HcModsDownButton_Click(sender As Object, e As EventArgs) Handles hcModsDownButton.Click
        Dim index As Integer = hcModsList.SelectedIndex
        Dim addon As String = hcModsList.SelectedItem
        Dim check As Integer = hcModsList.GetItemCheckState(index)

        If index < hcModsList.Items.Count - 1 Then
            hcModsList.Items.RemoveAt(index)
            hcModsList.Items.Insert(index + 1, addon)
            hcModsList.SelectedIndex = index + 1
            hcModsList.SetItemCheckState(index + 1, check)
        End If
    End Sub

    Private Sub ServerModsSortButton_Click(sender As Object, e As EventArgs) Handles serverModsSortButton.Click
        serverModsList.Sorted = True
        serverModsList.Sorted = False
    End Sub

    Private Sub HcModsSortButton_Click(sender As Object, e As EventArgs) Handles hcModsSortButton.Click
        serverModsList.Sorted = True
        serverModsList.Sorted = False
    End Sub

    Private Sub RefreshModsButton_Click(sender As Object, e As EventArgs) Handles refreshModsButton.Click
        UpdateModsList()
    End Sub

    Private Sub RequiredBuildCheck_CheckedChanged(sender As Object, e As EventArgs) Handles requiredBuildCheck.CheckedChanged
        If requiredBuildCheck.Checked Then
            requiredBuildBox.Enabled = True
        Else
            requiredBuildBox.Enabled = False
        End If
    End Sub

    Private Sub NetlogCheck_CheckedChanged(sender As Object, e As EventArgs) Handles netlogCheck.CheckedChanged
        If netlogCheck.Checked Then
            netlogGroup.Enabled = True
        Else
            netlogGroup.Enabled = False
        End If
    End Sub

    Private Sub ConsoleLogCheck_CheckedChanged(sender As Object, e As EventArgs) Handles consoleLogCheck.CheckedChanged
        If consoleLogCheck.Checked Then
            consoleLogButton.Enabled = True
            consoleLogBox.Enabled = True
        Else
            consoleLogButton.Enabled = False
            consoleLogBox.Enabled = False
        End If
    End Sub

    Private Sub RankingCheck_CheckedChanged(sender As Object, e As EventArgs) Handles rankingCheck.CheckedChanged
        If rankingCheck.Checked Then
            rankingButton.Enabled = True
            rankingBox.Enabled = True
        Else
            rankingButton.Enabled = False
            rankingBox.Enabled = False
        End If
    End Sub

    Private Sub PidCheck_CheckedChanged(sender As Object, e As EventArgs) Handles pidCheck.CheckedChanged
        If pidCheck.Checked Then
            pidButton.Enabled = True
            pidBox.Enabled = True
        Else
            pidButton.Enabled = False
            pidBox.Enabled = False
        End If
    End Sub

    Private Sub MaxPingCheck_CheckedChanged(sender As Object, e As EventArgs) Handles maxPingCheck.CheckedChanged
        If maxPingCheck.Checked Then
            maxPingNumeric.Enabled = True
            maxPingNumeric.Enabled = True
        Else
            maxPingNumeric.Enabled = False
            maxPingNumeric.Enabled = False
        End If
    End Sub

    Private Sub MaxDesyncCheck_CheckedChanged(sender As Object, e As EventArgs) Handles maxDesyncCheck.CheckedChanged
        If maxDesyncCheck.Checked Then
            maxDesyncNumeric.Enabled = True
            maxDesyncNumeric.Enabled = True
        Else
            maxDesyncNumeric.Enabled = False
            maxDesyncNumeric.Enabled = False
        End If
    End Sub

    Private Sub PacketLossCheck_CheckedChanged(sender As Object, e As EventArgs) Handles packetLossCheck.CheckedChanged
        If packetLossCheck.Checked Then
            packetLossNumeric.Enabled = True
            packetLossNumeric.Enabled = True
        Else
            packetLossNumeric.Enabled = False
            packetLossNumeric.Enabled = False
        End If
    End Sub

    Private Sub DisconTimeCheck_CheckedChanged(sender As Object, e As EventArgs) Handles disconTimeCheck.CheckedChanged
        If disconTimeCheck.Checked Then
            disconTimeNumeric.Enabled = True
            disconTimeNumeric.Enabled = True
        Else
            disconTimeNumeric.Enabled = False
            disconTimeNumeric.Enabled = False
        End If
    End Sub

    Private Sub KickSlowCheck_CheckedChanged(sender As Object, e As EventArgs) Handles kickSlowCheck.CheckedChanged
        If kickSlowCheck.Checked Then
            kickSlowCombo.Enabled = True
            kickSlowCombo.Enabled = True
        Else
            kickSlowCombo.Enabled = False
            kickSlowCombo.Enabled = False
        End If
    End Sub

    Private Sub PerfResetButton_Click(sender As Object, e As EventArgs) Handles perfResetButton.Click
        maxSendBox.Text = "128"
        maxGuaranteedBox.Text = "512"
        maxNonGuaranteedBox.Text = "256"
        minBandwidthBox.Text = "128"
        maxBandwidthBox.Text = "2000"
        minErrorBox.Text = "0.001"
        minErrorNearBox.Text = "0.01"
        maxCustFileBox.Text = "160"
        maxPacketBox.Text = "1400"
    End Sub

End Class
