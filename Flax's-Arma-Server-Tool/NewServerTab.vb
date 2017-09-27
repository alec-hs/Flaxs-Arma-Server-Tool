Imports System.IO
Imports System.Xml

Public Class NewServerTab
    Private Sub NewServerTab_Load(sender As Object, e As EventArgs) Handles Me.Load
        If filePatchCombo.SelectedIndex = -1 Then
            filePatchCombo.SelectedItem = "2"
        End If

        If verifySigCombo.SelectedIndex = -1 Then
            verifySigCombo.SelectedItem = "0"
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
        UpdateMissionsList()

        Dim profile As String = Application.StartupPath & "\servers\" & MainWindow.SafeName(Me.Parent.Text) & ".FASTprofile"
        If File.Exists(profile) Then
            Dim xml = XDocument.Load(profile)
            Dim allCheckList As New List(Of Control)
            For Each checkList As CheckedListBox In MainWindow.FindControlRecursive(allCheckList, Me, GetType(CheckedListBox))
                Dim items As New List(Of String)
                For Each element In xml.<profile>.<settings>.Elements(checkList.Name).Elements
                    items.Add(element)
                Next

                For Each item In items
                    If Not checkList.FindString(item) = -1 Then
                        checkList.SetItemChecked(checkList.FindString(item), True)
                    End If
                Next
            Next
        End If

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

        Try
            If File.Exists(path & oldProfileName & ".FASTprofile") Then
                File.Delete(path & oldProfileName & ".FASTprofile")
            End If

            If Directory.Exists(path & oldProfileName) Then
                FileIO.FileSystem.CopyDirectory(path & oldProfileName, My.Computer.FileSystem.SpecialDirectories.Temp & "\" & oldProfileName, True)
                Directory.Delete(path & oldProfileName, True)
            End If

            If Not Directory.Exists(profilePath) Then
                Directory.CreateDirectory(profilePath)
                If Directory.Exists(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & oldProfileName) Then
                    FileIO.FileSystem.CopyDirectory(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & oldProfileName, profilePath, True)
                End If
            End If

                If Not File.Exists(profilePath & newProfileName & "_config.cfg") Then
                Dim cfg = File.Create(profilePath & newProfileName & "_config.cfg")
                cfg.Close()
            End If

            If Not File.Exists(profilePath & newProfileName & "_basic.cfg") Then
                Dim cfg = File.Create(profilePath & newProfileName & "_basic.cfg")
                cfg.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Files in use please close and try again.")
        End Try



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

            Dim allCheckList As New List(Of Control)
            For Each checkList As CheckedListBox In MainWindow.FindControlRecursive(allCheckList, Me, GetType(CheckedListBox))
                writer.WriteStartElement(checkList.Name)
                For Each item In checkList.CheckedItems
                    writer.WriteStartElement("item")
                    writer.WriteString(item)
                    writer.WriteEndElement()
                Next
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

    Private Sub LaunchServer_Click(sender As Object, e As EventArgs) Handles launchServerButton.Click

        If ReadyToLaunch(profileNameBox.Text) Then
            LaunchServer()
        Else
            MsgBox("Please make sure all fields are filled in and the profile is saved.")
        End If

    End Sub

    Public Sub LaunchServer()
        Dim profileName As String = MainWindow.SafeName(Me.Parent.Text)
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
            MsgBox(ex.Message)
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
            commandLine = commandLine & " ""-serverMod=" & serverMods & """"


            If htCheck.Checked Then
                commandLine = commandLine & " -enableHT"
            End If

            If filePatchingCheck.Checked Then
                commandLine = commandLine & " -filePatching"
            End If

            If netlogCheck.Checked Then
                commandLine = commandLine & " -netlog"
            End If

            If rankingCheck.Checked Then
                commandLine = commandLine & " -ranking=" & rankingBox.Text
            End If

            If pidCheck.Checked Then
                commandLine = commandLine & " -pid=" & pidBox.Text
            End If

            If autoInitCheck.Checked Then
                commandLine = commandLine & " -autoInit"
            End If

            If extraParamsBox.Text IsNot Nothing Then
                commandLine = commandLine & extraParamsBox.Text
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

                    hcCommandLine = hcCommandLine & " ""-mod=" & serverMods & """"

                    Clipboard.SetText(hcCommandLine)

                    Dim hcStartInfo As New ProcessStartInfo(serverFileBox.Text, hcCommandLine)
                    Dim hcProcess As New Process With {
                            .StartInfo = hcStartInfo
                        }
                    hcProcess.Start()
                Next
            End If
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
        Dim serverProfile As String = Application.StartupPath & "\servers\" & profile & "\users\" & profile & "\" & profile & ".Arma3Profile"

        Directory.CreateDirectory(Application.StartupPath & "\servers\" & profile & "\users\" & profile)

        Dim configLines As New List(Of String) From {
            "passwordAdmin = """ & adminPassBox.Text & """;",
            "password = """ & passwordBox.Text & """;",
            "serverCommandPassword = """ & serverCommandBox.Text & """;",
            "hostname = """ & serverNameBox.Text & """;",
            "maxPlayers = " & maxPlayersBox.Text & ";",
            "kickduplicate = " & kickDupeCheck.CheckState & ";",
            "upnp = " & upnpCheck.CheckState & ";",
            "allowedFilePatching = " & filePatchCombo.Text & ";",
            "verifySignatures = " & verifySigCombo.Text & ";",
            "disableVoN = " & vonCheck.CheckState & ";",
            "vonCodecQuality = " & codecNumeric.Value & ";",
            "vonCodec = 1;",
            "BattlEye = " & battleyeCheck.CheckState & ";",
            "persistent = " & persistCheck.CheckState & ";"
        }

        configLines.Add("motd[]= {")
        For Each line In modBox.Lines
            If line Is modBox.Lines.Last Then
                configLines.Add("""" & line & """")
            Else
                configLines.Add("""" & line & """,")
            End If
        Next
        configLines.Add("};")

        configLines.Add("motdInterval = " & modTimeNumeric.Value & ";")

        If enableHCCheck.Checked Then
            configLines.Add("headlessClients[] = {""" & headlessIPBox.Text & """};")
            configLines.Add("localClient[] = {""" & localClientBox.Text & """};")
        End If

        If voteCheck.Checked Then
            configLines.Add("allowedVoteCmds[] = {};")
            configLines.Add("allowedVotedAdminCmds[] = {};")
            configLines.Add("voteMissionPlayers = " & voteMinPlayersNumeric.Value & ";")
            configLines.Add("voteThreshold = " & voteThresholdNumeric.Value / 100 & ";")
        Else
            configLines.Add("voteMissionPlayers = " & voteMinPlayersNumeric.Value & ";")
            configLines.Add("voteThreshold = " & voteThresholdNumeric.Value & ";")
        End If

        If loopbackCheck.Checked Then
            configLines.Add("loopback = True;")
        End If

        If disconTimeCheck.Checked Then
            configLines.Add("disconnectTimeout = " & disconTimeNumeric.Value & ";")
        End If

        If maxDesyncCheck.Checked Then
            configLines.Add("maxdesync = " & maxDesyncNumeric.Value & ";")
        End If

        If maxPingCheck.Checked Then
            configLines.Add("maxping = " & maxPingNumeric.Value & ";")
        End If

        If packetLossCheck.Checked Then
            configLines.Add("maxpacketloss = " & packetLossNumeric.Value & ";")
        End If

        If kickSlowCheck.Checked Then
            If kickSlowCombo.Text = "Log" Then
                configLines.Add("kickClientsOnSlowNetwork[] = { 0, 0, 0, 0 };")
            ElseIf kickSlowCombo.Text = "Log & Kick" Then
                configLines.Add("kickClientsOnSlowNetwork[] = { 1, 1, 1, 1 };")
            End If
        End If

        If consoleLogCheck.Checked Then
            configLines.Add("logFile = """ & consoleLogBox.Text & """;")
        End If

        If requiredBuildCheck.Checked Then
            configLines.Add("requiredBuild = " & requiredBuildBox.Text & ";")
        End If

        configLines.Add("doubleIdDetected = """ & doubleIdDetectedBox.Text & """;")
        configLines.Add("onUserConnected = """ & onUserConnectedBox.Text & """;")
        configLines.Add("onUserDisconnected = """ & onUserDisconnectedBox.Text & """;")
        configLines.Add("onHackedData = """ & onHackedDataBox.Text & """;")
        configLines.Add("onDifferentData = """ & onDifferentDataBox.Text & """;")
        configLines.Add("onUnsignedData = """ & onUnsignedDataBox.Text & """;")
        configLines.Add("regularCheck = """ & regularCheckBox.Text & """;")

        configLines.Add("timeStampFormat = """ & rptTimeCombo.Text & """;")

        configLines.Add("class Missions {")
        For Each mission In missionsList.CheckedItems
            configLines.Add(vbTab & "class Mission_" & missionsList.CheckedItems.IndexOf(mission) + 1 & " {")
            configLines.Add(vbTab & vbTab & "template = """ & mission & """;")
            configLines.Add(vbTab & vbTab & "difficulty = """ & difficultyCombo.Text & """;")
            configLines.Add(vbTab & "};")
        Next
        configLines.Add("};")


        '"admins[] = {""<UID>""};"
        '"drawingInMap = 0;"
        '"forceRotorLibSimulation = 0;"
        '"forcedDifficulty = ""regular"";"
        '"missionWhitelist[] = {""intro.altis""};"

        File.WriteAllLines(config, configLines)

        Dim basicLines As New List(Of String) From {
            "adapter = -1;",
            "3D_Performance=1;",
            "Resolution_W = 0;",
            "Resolution_H = 0;",
            "Resolution_Bpp = 32;",
            "terrainGrid = " & terrainNumeric.Value & ";",
            "viewDistance = " & distanceNumeric.Value & ";",
            "Windowed = 0;",
            "MaxMsgSend =" & maxSendBox.Text & ";",
            "MaxSizeGuaranteed =" & maxGuaranteedBox.Text & ";",
            "MaxSizeNonguaranteed =" & maxNonGuaranteedBox.Text & ";",
            "MinBandwidth =" & minBandwidthBox.Text & ";",
            "MaxBandwidth =" & maxBandwidthBox.Text & ";",
            "MinErrorToSend =" & minErrorBox.Text & ";",
            "MinErrorToSendNear =" & minErrorNearBox.Text & ";",
            "MaxCustomFileSize =" & maxCustFileBox.Text & ";",
            "class sockets{maxPacketSize = " & maxPacketBox.Text & ";};"
        }

        File.WriteAllLines(basic, basicLines)

        Dim profileLines As New List(Of String) From {
            "difficulty = """ & difficultyCombo.Text & """",
            "class DifficultyPresets {",
            vbTab & "class CustomDifficulty {",
            vbTab & vbTab & "class Options {",
            vbTab & vbTab & vbTab & "reduceDamage = " & reducedDamageCheck.CheckState & ";",
            vbTab & vbTab & vbTab & "groupIndicators = " & groupIndicatorCheck.CheckState & ";",
            vbTab & vbTab & vbTab & "friendlyTags = " & friendlyNameCheck.CheckState & ";",
            vbTab & vbTab & vbTab & "enemyTags = " & enemyNameCheck.CheckState & ";",
            vbTab & vbTab & vbTab & "detectedMines = " & detectedMinesCheck.CheckState & ";",
            vbTab & vbTab & vbTab & "commands = " & commandsCheck.CheckState & ";",
            vbTab & vbTab & vbTab & "waypoints = " & waypointsCheck.CheckState & ";",
            vbTab & vbTab & vbTab & "tacticalPing = " & tacticalPingCheck.CheckState & ";",
            vbTab & vbTab & vbTab & "weaponInfo = " & weaponInfoCheck.CheckState & ";",
            vbTab & vbTab & vbTab & "stanceIndicator = " & stanceIndicatorCheck.CheckState & ";",
            vbTab & vbTab & vbTab & "staminaBar = " & staminaBarCheck.CheckState & ";",
            vbTab & vbTab & vbTab & "weaponCrosshair = " & crosshairCheck.CheckState & ";",
            vbTab & vbTab & vbTab & "visionAid = " & visualAidCheck.CheckState & ";",
            vbTab & vbTab & vbTab & "thirdPersonView = " & thirdPersonCheck.CheckState & ";",
            vbTab & vbTab & vbTab & "cameraShake = " & cameraShakeCheck.CheckState & ";",
            vbTab & vbTab & vbTab & "scoreTable = " & scoreTableCheck.CheckState & ";",
            vbTab & vbTab & vbTab & "deathMessages = " & killedByCheck.CheckState & ";",
            vbTab & vbTab & vbTab & "vonID = " & vonIDCheck.CheckState & ";",
            vbTab & vbTab & vbTab & "mapContent = " & mapContentCheck.CheckState & ";",
            vbTab & vbTab & vbTab & "autoReport = " & autoReportingCheck.CheckState & ";",
            vbTab & vbTab & vbTab & "multipleSaves = " & multipleSavesCheck.CheckState & ";",
            vbTab & vbTab & "};",
            "",
            vbTab & vbTab & "aiLevelPreset = " & aiPresetNumeric.Value & ";",
            "",
            vbTab & vbTab & "class CustomAILevel {",
            vbTab & vbTab & vbTab & "skillAI = " & aiSkillNumeric.Value & ";",
            vbTab & vbTab & vbTab & "precisionAI = " & aiAccuracyNumeric.Value & ";",
            vbTab & vbTab & "};",
            vbTab & "};",
            "};"
        }

        File.WriteAllLines(serverProfile, profileLines)

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
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = "," Or e.KeyChar = """")
        End If
    End Sub

    Private Sub HeadlessIPBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles headlessIPBox.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = "," Or e.KeyChar = """")
        End If
    End Sub

    Private Sub RequiredBuildBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles requiredBuildBox.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = ",")
        End If
    End Sub

    Public Sub UpdateModsList()
        Dim currentMods = serverModsList.Items
        Dim newMods As New List(Of String)
        Dim checkedServerMods As New List(Of String)
        Dim checkedHCMods As New List(Of String)

        For Each addon In serverModsList.CheckedItems
            checkedServerMods.Add(addon.ToString)
        Next

        For Each addon In hcModsList.CheckedItems
            checkedHCMods.Add(addon.ToString)
        Next

        serverModsList.Items.Clear()
        hcModsList.Items.Clear()

        If Directory.Exists(My.Settings.serverDir) Then
            For Each addon In Directory.GetDirectories(My.Settings.serverDir, "@*")
                newMods.Add(Replace(addon, My.Settings.serverDir & "\", ""))
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

            For Each addon In checkedServerMods
                If Not serverModsList.FindString(addon) = -1 Then
                    serverModsList.SetItemChecked(serverModsList.FindString(addon), True)
                End If
            Next

            For Each addon In checkedHCMods
                If Not hcModsList.FindString(addon) = -1 Then
                    hcModsList.SetItemChecked(hcModsList.FindString(addon), True)
                End If
            Next
        Else
            MsgBox("Please install game before continuing.")
        End If

    End Sub

    Public Sub UpdateMissionsList()


        Dim missionsFolder As String = My.Settings.serverDir & "\MPMissions"
        Dim currentMissions As CheckedListBox.ObjectCollection = missionsList.Items
        Dim newMissions As New List(Of String)
        Dim checkedMissions As New List(Of String)

        For Each mission In missionsList.CheckedItems
            checkedMissions.Add(mission.ToString)
        Next

        missionsList.Items.Clear()

        If Directory.Exists(missionsFolder) Then
            For Each mission In Directory.GetFiles(missionsFolder, "*.pbo")
                mission = Replace(mission, missionsFolder & "\", "")
                mission = Replace(mission, ".pbo", "")
                newMissions.Add(mission)
            Next

            For Each mission In newMissions.ToList
                For Each nMission In currentMissions
                    If nMission = mission Then
                        newMissions.Remove(nMission)
                    End If
                Next
            Next

            For Each mission In newMissions.ToList
                missionsList.Items.Add(mission)
            Next

            For Each mission In checkedMissions
                If Not missionsList.FindString(mission) = -1 Then
                    missionsList.SetItemChecked(missionsList.FindString(mission), True)
                End If
            Next
        Else
            MsgBox("MPMissions folder is missing.")
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

    Private Sub MissionRefreshButton_Click(sender As Object, e As EventArgs) Handles missionRefreshButton.Click
        UpdateMissionsList()
    End Sub

    Private Sub MissionsAllButton_Click(sender As Object, e As EventArgs) Handles missionsAllButton.Click
        For i = 0 To missionsList.Items.Count - 1
            missionsList.SetItemChecked(i, 1)
        Next i
    End Sub

    Private Sub MissionsNoneButton_Click(sender As Object, e As EventArgs) Handles missionsNoneButton.Click
        For i = 0 To missionsList.Items.Count - 1
            missionsList.SetItemChecked(i, 0)
        Next i
    End Sub
End Class
