Imports System.IO
Imports System.Text
Imports System.Net
Imports System.Security.Cryptography

Public Class MainWindow

    'SHARED VARIABLES
    Dim modsfile As String = Application.StartupPath & "/mods.cfg"
    Dim oProcess As New Process()
    Dim cancelled As Boolean
    Dim updating As Boolean = False
    Dim updateAll As Boolean

    Public Function SystemSerialNumber() As String
        ' Get the Windows Management Instrumentation object.
        Dim wmi As Object = GetObject("WinMgmts:")

        ' Get the base boards.
        Dim serial_numbers As String = ""
        Dim mother_boards As Object =
        wmi.InstancesOf("Win32_BaseBoard")
        For Each board As Object In mother_boards
            serial_numbers &= ", " & board.SerialNumber
        Next board
        If serial_numbers.Length > 0 Then serial_numbers =
        serial_numbers.Substring(2)

        Return serial_numbers
    End Function

    Public Sub CheckModFile()
        If Not My.Computer.FileSystem.FileExists(modsfile) Then
            Dim fs As FileStream = File.Create(modsfile)
            fs.Close()
        End If
    End Sub

    Public Class TabPageEx
        Inherits TabPage

        Public Sub New()
            Me.Controls.Add(New NewServerTab)
        End Sub

    End Class

    Public Shared Function FindControlRecursive(ByVal list As List(Of Control), ByVal parent As Control, ByVal ctrlType As System.Type) As List(Of Control)
        If parent Is Nothing Then Return list
        If parent.GetType Is ctrlType Then
            list.Add(parent)
        End If
        For Each child As Control In parent.Controls
            FindControlRecursive(list, child, ctrlType)
        Next
        Return list
    End Function

    'MAIN WINDOW
    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Not Directory.Exists(Application.StartupPath & "\servers") Then
            Directory.CreateDirectory(Application.StartupPath & "\servers")
        End If

        Dim profiles() = Directory.GetFiles(Application.StartupPath & "\servers", "*.FASTprofile", SearchOption.TopDirectoryOnly)

        For Each profile In profiles
            Dim newTab As New TabPage
            categoryTabs.TabPages.Add(newTab)
            newTab.Controls.Add(New NewServerTab)

            Try
                Dim xml = XDocument.Load(profile)
                newTab.Text = xml.<profile>.<settings>.<profileNameBox>.Value

                Dim profileNameBox = CType(newTab.Controls.Find("profileNameBox", True)(0), TextBox)
                profileNameBox.Text = xml.<profile>.<settings>.<profileNameBox>.Value

                Dim allTxt As New List(Of Control)
                For Each txt As TextBox In FindControlRecursive(allTxt, newTab, GetType(TextBox))
                    txt.Text = xml.<profile>.<settings>.Elements(txt.Name).Value
                Next

                Dim allRichTxt As New List(Of Control)
                For Each richTxt As RichTextBox In FindControlRecursive(allRichTxt, newTab, GetType(RichTextBox))
                    Dim lines As New List(Of String)
                    For Each element In xml.<profile>.<settings>.Elements(richTxt.Name).Elements
                        lines.Add(element)
                    Next

                    For Each line In lines
                        richTxt.AppendText(line.ToString & Environment.NewLine)
                    Next
                Next

                Dim allCheck As New List(Of Control)
                For Each check As CheckBox In FindControlRecursive(allCheck, newTab, GetType(CheckBox))
                    If xml.<profile>.<settings>.Elements(check.Name).Value = 1 Then
                        check.Checked = True
                    Else
                        check.Checked = False
                    End If
                Next

                Dim allCombo As New List(Of Control)
                For Each combo As ComboBox In FindControlRecursive(allCombo, newTab, GetType(ComboBox))
                    combo.SelectedItem = xml.<profile>.<settings>.Elements(combo.Name).Value
                Next

                Dim allNumeric As New List(Of Control)
                For Each numeric As NumericUpDown In FindControlRecursive(allNumeric, newTab, GetType(NumericUpDown))
                    numeric.Value = xml.<profile>.<settings>.Elements(numeric.Name).Value
                Next

            Catch ex As Exception
                'profile = Replace(profile, Application.StartupPath & "\servers\", "")
                'profile = Replace(profile, ".FASTprofile", "")
                'MsgBox(profile & Environment.NewLine & Environment.NewLine & "Profile corrupted and was deleted.")
                'categoryTabs.TabPages.Remove(newTab)
                'DeleteProfile(profile, False)
                MsgBox(vbCrLf & ex.Message)
            End Try
        Next

        If My.Settings.firstRun Then
            Dim firstRunDialog As New FirstRun
            firstRunDialog.ShowDialog()
        Else
            steamDirBox.Text = My.Settings.steamDir
            serverDirBox.Text = My.Settings.serverDir
            userNameBox.Text = My.Settings.userName
            branchCombo.Text = My.Settings.selectedBranch

            Dim encryptionString As String = Environment.UserName & SystemSerialNumber()
            Dim wrapper As New Simple3Des(encryptionString)
            Dim cypher As String = wrapper.DecryptData(My.Settings.userPass)
            userPassBox.Text = cypher


            If My.Settings.installedBranch = "" Then
                infoBranchBox.Text = "N/A"
            Else
                infoBranchBox.Text = My.Settings.installedBranch
            End If

            If My.Settings.lastUpdated = "00:00:00" Then
                infoUpdatedBox.Text = "N/A"
            Else
                infoUpdatedBox.Text = My.Settings.lastUpdated
            End If

        End If

        CheckForUpdates()

    End Sub

    Public Sub DeleteProfile(profile As String, manual As Boolean)
        Try
            profile = Application.StartupPath & "\servers\" & SafeName(profile)
            If File.Exists(profile & ".FASTprofile") Then
                File.Delete(profile & ".FASTprofile")
            End If

            If Directory.Exists(profile) Then
                Directory.Delete(profile, True)
            End If
            If manual Then
                categoryTabs.TabPages.Remove(categoryTabs.SelectedTab)
            End If

        Catch ex As Exception
            MsgBox("Not all files were deleted - a file was open elsewhere.")
        End Try
    End Sub

    Private Sub MainWindow_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        Try
            oProcess.Kill()
        Catch ex As Exception
            'MsgBox("MainWindow_Close Sub - An exception occurred:" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub InstallCMDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstallCMDToolStripMenuItem.Click
        Dim installSteam As New InstallSteamCMD
        installSteam.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Process.Start("https://github.com/alec-hs/Flaxs-Arma-Server-Tool")
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        Process.Start("https://forums.bistudio.com/forums/topic/206609-flaxs-arma-server-tool-fast")
    End Sub

    Private Sub OpenSteamCMDDirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenSteamCMDDirToolStripMenuItem.Click
        If System.IO.Directory.Exists(My.Settings.steamDir) Then
            Process.Start(My.Settings.steamDir)
        Else
            MessageBox.Show("Folder Does not Exist", "Information")
        End If
    End Sub

    Private Sub OpenA3DirectoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenA3DirectoryToolStripMenuItem.Click
        If System.IO.Directory.Exists(My.Settings.serverDir) Then
            Process.Start(My.Settings.serverDir)
        Else
            MessageBox.Show("Folder Does not Exist", "Information")
        End If

    End Sub

    Private Sub OpenModsLocationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenModsLocationToolStripMenuItem.Click
        Try
            If System.IO.Directory.Exists(My.Settings.steamDir & "\steamapps\workshop\content\107410") Then
                Process.Start(My.Settings.steamDir & "\steamapps\workshop\content\107410")
            Else
                MessageBox.Show("No MODS currently installed in the for the selected steam install.", "Information")
            End If
        Catch ex As Exception
            MsgBox("OpenModsLocationToolStripMenuItem_Click - An exception occurred:" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub CopyKeysFromModsStipMenuItem_Click(sender As Object, e As EventArgs) Handles CopyKeysFromModsToolStripMenuItem.Click
        CheckModFile()
        Dim lines As List(Of String) = System.IO.File.ReadAllLines(modsfile).ToList
        For Each line In lines
            Dim values() As String = line.Split(",")
            Dim modID As String = values(0)
            CopyKeys(modID)
        Next

        MsgBox("Keys Copied!")
    End Sub

    Private Sub CopyKeys(modID As String)
        Dim modPath As String = My.Settings.steamDir & "\steamapps\workshop\content\107410\" & modID
        Dim a3Keys As String = My.Settings.serverDir & "\keys"

        For Each fileObject As String In Directory.GetFiles(modPath, "*.bikey")
            File.Copy(fileObject, a3Keys & fileObject.Substring(Len(modPath)), True)
        Next

        For Each dir As String In Directory.GetDirectories(modPath)
            For Each fileObject As String In Directory.GetFiles(dir, "*.bikey")
                File.Copy(fileObject, a3Keys & fileObject.Substring(Len(dir)), True)
            Next
        Next
    End Sub

    'MAIN TAB
    Private Sub SteamDirSelect_Click(sender As Object, e As EventArgs) Handles steamDirButton.Click
        ChooseSteamDir()
    End Sub

    Private Sub CancelUpdateButton_Click(sender As Object, e As EventArgs) Handles cancelUpdateButton.Click
        Try
            oProcess.Kill()
            cancelled = True
        Catch ex As Exception
            MsgBox("CancelUpdateButton - An exception occurred:" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub ShowUserPassButton_Click(sender As Object, e As EventArgs) Handles showUserPassButton.Click
        If userPassBox.PasswordChar = "*" Then
            userPassBox.PasswordChar = ""
            showUserPassButton.BackgroundImage = My.Resources.Invisible_32px
        Else
            userPassBox.PasswordChar = "*"
            showUserPassButton.BackgroundImage = My.Resources.Visible_32px
        End If
    End Sub

    Private Sub UpdateServer(sender As Object, e As EventArgs) Handles updateServerButton.Click
        Dim branchId As String
        Dim steamCommand As String
        Dim steamCMD As String = steamDirBox.Text + "\steamcmd.exe"

        If branchCombo.SelectedItem = "Stable" Then
            branchId = "233780"
        Else
            branchId = "107410 -beta development"
        End If

        steamCommand = "+login " & userNameBox.Text & " " & userPassBox.Text & " +force_install_dir " & serverDirBox.Text & " +app_update " & branchId & " validate +quit"

        My.Settings.installedBranch = branchCombo.SelectedItem
        infoBranchBox.Text = branchCombo.SelectedItem
        My.Settings.lastUpdated = DateTime.Now
        infoUpdatedBox.Text = My.Settings.lastUpdated.ToString

        RunSteamCommand(steamCMD, steamCommand, "server")
    End Sub

    Private Sub ServerDirButton_Click(sender As Object, e As EventArgs) Handles serverDirButton.Click
        ChooseServerDir()
    End Sub

    Private Sub SteamDirBox_TextChanged(sender As Object, e As EventArgs) Handles steamDirBox.TextChanged
        steamDirBox.BackColor = Color.Empty
        My.Settings.steamDir = steamDirBox.Text
    End Sub

    Private Sub UserNameBox_TextChanged(sender As Object, e As EventArgs) Handles userNameBox.TextChanged
        userNameBox.BackColor = Color.Empty
        My.Settings.userName = userNameBox.Text
    End Sub

    Private Sub UserPassBox_TextChanged(sender As Object, e As EventArgs) Handles userPassBox.TextChanged
        userPassBox.BackColor = Color.Empty
        Dim encryptionString As String = Environment.UserName & SystemSerialNumber()
        Dim wrapper As New Simple3Des(encryptionString)
        Dim cypher As String = wrapper.EncryptData(userPassBox.Text)
        My.Settings.userPass = cypher
    End Sub

    Private Sub BranchCombo_SelectedValueChanged(sender As Object, e As EventArgs) Handles branchCombo.SelectedValueChanged
        My.Settings.selectedBranch = branchCombo.Text
        If My.Settings.selectedBranch = "Development" Then
            MessageBox.Show("WARNING - Due to the A3 Dev branch server using the main game you will also download all Workshop Items for A3 that you are subscribed to on the Steam account you are currently logged into.", "WARNING - Dev Branch")
        End If
    End Sub

    Private Sub ServerDirBox_TextChanged(sender As Object, e As EventArgs) Handles serverDirBox.TextChanged
        serverDirBox.BackColor = Color.Empty
        My.Settings.serverDir = serverDirBox.Text
    End Sub

    Public Sub ChooseSteamDir()
        If steamDirDialog.ShowDialog() = DialogResult.OK Then
            steamDirBox.Text = steamDirDialog.SelectedPath
        End If
    End Sub

    Public Sub ChooseServerDir()
        If serverDirDialog.ShowDialog() = DialogResult.OK Then
            serverDirBox.Text = serverDirDialog.SelectedPath
        End If
    End Sub


    'MODS TAB
    Private Sub ImportMod_Click(sender As Object, e As EventArgs) Handles modUrlButton.Click
        Dim importDiaglog As New ImportMod
        importDiaglog.ShowDialog()
    End Sub

    Private Sub PrivateMod_Click(sender As Object, e As EventArgs) Handles privateModButton.Click
        Dim importPrivateDiaglog As New ImportPrivateMod
        importPrivateDiaglog.ShowDialog()
    End Sub

    Private Sub ModLauncherButton_Click(sender As Object, e As EventArgs) Handles modLauncherButton.Click
        ImportModSetFile()
    End Sub

    Private Sub ModsDataGrid_CellContentClick(sender As System.Object, e As DataGridViewCellEventArgs) Handles modsDataGrid.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        'UPDATE MOD
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.ColumnIndex = 3 Then
            If updating Then
                MsgBox("Already updating please wait.")
            Else
                If e.RowIndex >= 0 Then
                    Dim modID As String = modsDataGrid.Rows(e.RowIndex).Cells(0).Value
                    Dim modName As String = modsDataGrid.Rows(e.RowIndex).Cells(1).Value

                    UpdateMod(modID, modName, "single")
                End If
            End If
        End If

        'VIEW DETAILS
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.ColumnIndex = 4 Then
            If e.RowIndex >= 0 Then
                Dim url As String = "http://steamcommunity.com/sharedfiles/filedetails/?id=" & modsDataGrid.Rows(e.RowIndex).Cells(0).Value
                Process.Start(url)
            End If
        End If

        'DELETE BUTTON
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.ColumnIndex = 5 Then
            If e.RowIndex >= 0 Then
                Dim modID As Integer = modsDataGrid.Rows(e.RowIndex).Cells(0).Value
                Dim modName As String = modsDataGrid.Rows(e.RowIndex).Cells(1).Value

                DeleteMod(modID, modName)
            End If
        End If
    End Sub

    Public Sub ImportModSetFile()

        If importModSet.ShowDialog() = DialogResult.OK Then
            Dim modSetFile As String = importModSet.FileName

            Dim dataReader As New StreamReader(modSetFile, Encoding.Default)
            Dim modLine As String

            Do
                modLine = dataReader.ReadLine
                If modLine Is Nothing Then Exit Do
                Dim values() As String = modLine.Split(Environment.NewLine)
                If modLine.Contains("data-type=""Link"">") Then
                    Dim link As String
                    link = modLine.Substring(modLine.IndexOf("http://steam"))
                    link = StrReverse(link)
                    link = link.Substring(link.IndexOf("epyt-atad") + 11)
                    link = StrReverse(link)
                    ImportMod.ImportModToList(link)
                End If
            Loop
            dataReader.Close()

        End If
    End Sub

    Public Function GetModInfo(modID As String)
        Try
            ' Create a request using a URL that can receive a post.   
            Dim request As WebRequest = WebRequest.Create("https://api.steampowered.com/ISteamRemoteStorage/GetPublishedFileDetails/v1/")
            ' Set the Method property of the request to POST.  
            request.Method = "POST"
            ' Create POST data and convert it to a byte array.  
            Dim postData As String = "itemcount=1&publishedfileids[0]=" & modID
            Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
            ' Set the ContentType property of the WebRequest.  
            request.ContentType = "application/x-www-form-urlencoded"
            ' Set the ContentLength property of the WebRequest.  
            request.ContentLength = byteArray.Length
            ' Get the request stream.  
            Dim dataStream As Stream = request.GetRequestStream()
            ' Write the data to the request stream.  
            dataStream.Write(byteArray, 0, byteArray.Length)
            ' Close the Stream object.  
            dataStream.Close()
            ' Get the response.
            Dim response As WebResponse = Nothing
            Try
                response = request.GetResponse()
            Catch ex As Exception
                MsgBox("There may be an issue with Steam please try again shortly.")
            End Try
            ' Display the status. 
            Dim staus As String = CType(response, HttpWebResponse).StatusDescription
            ' Get the stream containing content returned by the server.  
            dataStream = response.GetResponseStream()
            ' Open the stream using a StreamReader for easy access.  
            Dim reader As New StreamReader(dataStream)
            ' Read the content.  
            Dim responseFromServer As String = reader.ReadToEnd()
            ' Return the content.  
            Return responseFromServer
            ' Clean up the streams.  
            reader.Close()
            dataStream.Close()
            response.Close()
        Catch ex As Exception
            MsgBox("GetModInfo - An exception occurred:" & vbCrLf & ex.Message)
            Return Nothing
        End Try

    End Function

    Public Async Sub CheckForUpdates()
        Try
            If My.Computer.FileSystem.FileExists(modsfile) Then
                checkUpdatesButton.Enabled = False
                checkUpdatesButton.Text = "Checking..."
                checkingUpdatesBar.Style = ProgressBarStyle.Marquee
                checkingUpdatesBar.MarqueeAnimationSpeed = 30
                modsTab.Enabled = False
                Dim lines As List(Of String) = System.IO.File.ReadAllLines(modsfile).ToList
                For Each line In File.ReadAllLines(modsfile).ToList
                    Dim values() As String = line.Split(",")
                    Dim modID As String = values(0)
                    If values(4) = "public" Then
                        Dim updateTimeUNIX As Double

                        Dim modInfo As String = Nothing
                        Dim tasks As New List(Of Task) From {
                            Task.Run(
                            Sub()
                                modInfo = GetModInfo(modID)
                            End Sub
                        )
                        }

                        Await Task.WhenAll(tasks)

                        updateTimeUNIX = modInfo.Substring(modInfo.IndexOf("""time_updated"":") + 15, 10)

                        Dim steamUpdate As New DateTime(1970, 1, 1, 0, 0, 0)
                        steamUpdate = steamUpdate.AddSeconds(updateTimeUNIX)

                        Dim lineNo As Integer = GetLineNo(modID, modsfile) - 1
                        values(3) = steamUpdate
                        Dim newLine As String = String.Join(",", values)
                        lines.Insert(lineNo, newLine)
                        lines.RemoveAt(lineNo + 1)
                        System.IO.File.WriteAllLines(modsfile, lines)
                    End If

                    UpdateModGrid()
                Next


                checkUpdatesButton.Enabled = True
                checkUpdatesButton.Text = "Check for Updates"
                checkingUpdatesBar.Style = ProgressBarStyle.Continuous
                checkingUpdatesBar.Value = 0
                modsTab.Enabled = True
            End If

        Catch ex As Exception
            MsgBox("CheckForUpdates - An exception occurred:" & vbCrLf & ex.ToString)
        End Try
    End Sub

    Public Sub UpdateModGrid()
        modsDataGrid.Rows.Clear()
        Try
            Dim updatesNeeded As Boolean
            If My.Computer.FileSystem.FileExists(modsfile) Then

                Dim lines As List(Of String) = System.IO.File.ReadAllLines(modsfile).ToList

                For Each line In lines
                    Dim values() As String = line.Split(",")
                    Dim modID As String = values(0)
                    Dim lastUpdated As String = values(2)
                    Dim steamUpdate As DateTime = values(3)

                    modsDataGrid.Rows.Add("")
                    For ix As Integer = 0 To 2
                        modsDataGrid.Rows(modsDataGrid.Rows.Count - 1).Cells(ix).Value = values(ix)
                    Next

                    If values(2) = "Not Installed" Then
                        modsDataGrid.Rows(modsDataGrid.Rows.Count - 1).DefaultCellStyle.BackColor = Color.Red
                    Else
                        If CDate(lastUpdated) < CDate(steamUpdate) Then
                            modsDataGrid.Rows(modsDataGrid.Rows.Count - 1).DefaultCellStyle.BackColor = Color.Orange
                            updatesNeeded = True
                        ElseIf CDate(lastUpdated) > CDate(steamUpdate) Then
                            modsDataGrid.Rows(modsDataGrid.Rows.Count - 1).DefaultCellStyle.BackColor = Color.Green
                        End If
                        If values(4) = "private" Then
                            modsDataGrid.Rows(modsDataGrid.Rows.Count - 1).DefaultCellStyle.BackColor = Color.LightBlue
                        End If
                    End If
                Next
                modsDataGrid.PerformLayout()
            End If
        Catch ex As Exception
            MsgBox("UpdateModGrid - An exception occurred:" & vbCrLf & ex.Message)
        End Try

    End Sub

    Private Sub UpdateAllMods_Click(sender As Object, e As EventArgs) Handles updateAllMods.Click
        If ReadyToUpdate() Then
            If updating Then
                MsgBox("Already updating please wait.")
            Else
                If My.Computer.FileSystem.FileExists(modsfile) Then
                    Dim lines As List(Of String) = System.IO.File.ReadAllLines(modsfile).ToList
                    Dim noUpdates As Boolean = True

                    For Each line In File.ReadAllLines(modsfile).ToList
                        Dim values() As String = line.Split(",")
                        Dim lastUpdated As String = values(2)
                        Dim steamUpdate As DateTime = values(3)

                        If lastUpdated = "Not Installed" Then
                            noUpdates = False
                        ElseIf CDate(lastUpdated) < CDate(steamUpdate) Then
                            noUpdates = False
                        ElseIf CDate(lastUpdated) >= CDate(steamUpdate) Then
                            lines.RemoveAt(lines.IndexOf(line))
                        End If

                    Next


                    If noUpdates Then
                        MsgBox("No Mods Need Updating.")
                    Else
                        Dim steamCommand As String = "+login " & userNameBox.Text & " " & userPassBox.Text
                        Dim modIDs As New List(Of String)
                        For Each line In lines
                            Dim values() As String = line.Split(",")
                            Dim modID As String = values(0)
                            Dim modName As String = values(1)

                            Do While updating
                                Application.DoEvents()
                            Loop
                            UpdateMod(modID, modName, "all")

                            modIDs.Add(modID)

                            steamCommand = steamCommand & " +workshop_download_item 107410 " & modID

                            updateAll = True
                        Next
                        Dim steamCMD As String = steamDirBox.Text + "\steamcmd.exe"
                        steamCommand = steamCommand & " validate +quit"
                        RunSteamCommand(steamCMD, steamCommand, "addon", modIDs)
                    End If
                    updateAll = False
                    UpdateModGrid()
                Else
                    MsgBox("Please add some mods.")
                End If

            End If
        Else
            MessageBox.Show("Please check that SteamCMD is installed and that all fields are correct:" & Environment.NewLine & Environment.NewLine & "   -  Steam Dir" & Environment.NewLine & "   -  User Name & Pass" & Environment.NewLine & "   -  Server Dir", "Error")
        End If

    End Sub

    Public Sub UpdateMod(modID As String, modName As String, type As String)

        If ReadyToUpdate() Then
            Dim modPath As String = My.Settings.steamDir & "\steamapps\workshop\content\107410\" & modID
            Dim workshopFile As String = My.Settings.steamDir & "\steamapps\workshop\appworkshop_107410.acf"

            Try
                Dim linkCommand As String
                Dim linkPath As String

                System.IO.Directory.CreateDirectory(modPath)

                modName = SafeName(modName)

                linkPath = My.Settings.serverDir & "\@" & modName
                linkCommand = "/c mklink /D " & linkPath & " " & modPath

                Process.Start("cmd", linkCommand)

            Catch ex As Exception
                MsgBox("An exception occurred:" & vbCrLf & ex.Message)
            End Try

            Dim lines As List(Of String) = System.IO.File.ReadAllLines(modsfile).ToList
            Dim lineNo As Integer = GetLineNo(modID, modsfile) - 1
            Dim line() As String = lines(lineNo).Split(",")
            line(2) = Date.Now.ToString
            Dim newLine As String = String.Join(",", line)
            lines.Insert(lineNo, newLine)
            lines.RemoveAt(lineNo + 1)
            System.IO.File.WriteAllLines(modsfile, lines)


            If type = "single" Then
                Dim steamCMD As String = steamDirBox.Text + "\steamcmd.exe"
                Dim steamCommand As String = "+login " & userNameBox.Text & " " & userPassBox.Text & " +workshop_download_item 107410 " & modID & " validate +quit"

                Dim modIDs As New List(Of String) From {
                    modID
                }

                RunSteamCommand(steamCMD, steamCommand, "addon", modIDs)
            End If
        Else
            MessageBox.Show("Please check that SteamCMD is installed and that all fields are correct:" & Environment.NewLine & Environment.NewLine & "   -  Steam Dir" & Environment.NewLine & "   -  User Name & Pass" & Environment.NewLine & "   -  Server Dir", "Error")
        End If

    End Sub

    Public Sub DeleteMod(modID As String, modName As String)
        Dim modPath As String = My.Settings.steamDir & "\steamapps\workshop\content\107410\" & modID
        Dim workshopFile As String = My.Settings.steamDir & "\steamapps\workshop\appworkshop_107410.acf"
        Dim shortcutPath As String
        modName = SafeName(modName)

        shortcutPath = My.Settings.serverDir & "\@" & modName
        If File.Exists(modsfile) Then
            Dim lines As List(Of String) = System.IO.File.ReadAllLines(modsfile).ToList
            lines.RemoveAt(GetLineNo(modID, modsfile) - 1)
            System.IO.File.WriteAllLines(modsfile, lines)

            Try
                If (System.IO.Directory.Exists(modPath)) Then
                    System.IO.Directory.Delete(modPath, True)
                End If
                If (System.IO.Directory.Exists(shortcutPath)) Then
                    System.IO.Directory.Delete(shortcutPath, True)
                End If
                If (System.IO.File.Exists(workshopFile)) Then
                    lines = System.IO.File.ReadAllLines(workshopFile).ToList
                    Dim fileText As String = File.ReadAllText(workshopFile)
                    If fileText.Contains(modID) Then
                        Dim lineNo As Integer = GetLineNo(modID, workshopFile) - 1
                        lines.RemoveRange(lineNo, 6)
                        System.IO.File.WriteAllLines(workshopFile, lines)
                        lineNo = GetLineNo(modID, workshopFile) - 1
                        lines.RemoveRange(lineNo, 6)
                        System.IO.File.WriteAllLines(workshopFile, lines)
                    End If
                End If
            Catch ex As Exception
                MsgBox("DeleteMod - An exception occurred:" & vbCrLf & ex.Message)
            End Try
        End If

        UpdateModGrid()

    End Sub


    'SHARED 
    Public Function GetLineNo(target As String, targetFile As String)
        Dim count As Integer
        For Each line As String In System.IO.File.ReadLines(targetFile)
            count = count + 1
            If line.Contains(target) Then Return count
        Next
        Return ""
    End Function

    Public Function ReadyToUpdate() As Boolean

        If steamDirBox.Text = "" Then
            Return False
        ElseIf userNameBox.Text = "" Then
            Return False
        ElseIf userPassBox.Text = "" Then
            Return False
        ElseIf serverDirBox.Text = "" Then
            Return False
        ElseIf (Not System.IO.File.Exists(My.Settings.steamDir & "\steamcmd.exe")) Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Async Sub RunSteamCommand(steamCMD As String, steamCommand As String, type As String, Optional ByVal modIDs As List(Of String) = Nothing)

        If ReadyToUpdate() Then
            updating = True
            steamProgressBar.Value = 0
            cancelUpdateButton.Enabled = True
            categoryTabs.SelectedTab = serverTab
            Dim tasks As New List(Of Task)

            updateServerButton.Enabled = False
            modsTab.Enabled = False

            steamProgressBar.MarqueeAnimationSpeed = 30
            steamProgressBar.Style = ProgressBarStyle.Marquee

            If type Is "addon" Then
                steamOutputBox.Text = "Starting SteamCMD to update Addon" & Environment.NewLine & Environment.NewLine
            ElseIf type Is "server" Then
                steamOutputBox.Text = "Starting SteamCMD to update Server" & Environment.NewLine
            ElseIf type Is "install" Then
                steamOutputBox.Text = "Downloading and Installing SteamCMD" & Environment.NewLine
            End If

            tasks.Add(Task.Run(
                    Sub()
                        Dim oStartInfo As New ProcessStartInfo(steamCMD, steamCommand) With {
                            .CreateNoWindow = True,
                            .WindowStyle = ProcessWindowStyle.Hidden,
                            .UseShellExecute = False,
                            .RedirectStandardOutput = True,
                            .RedirectStandardInput = True
                        }
                        oProcess.StartInfo = oStartInfo
                        oProcess.Start()

                        Dim sOutput As String

                        Using oStreamReader As System.IO.StreamReader = oProcess.StandardOutput
                            Dim oStreamWriter As System.IO.StreamWriter = oProcess.StandardInput
                            Do Until oProcess.HasExited
                                Try
                                    sOutput = oStreamReader.ReadLine

                                    If sOutput Like "*at the console." Then
                                        Dim steamCode As String

                                        steamCode = InputBox("Enter Steam Guard code from email or mobile app.", "Steam Guard Code", "")
                                        oStreamWriter.Write(steamCode & Environment.NewLine)
                                    End If

                                    If sOutput Like "*Update state*" Then
                                        Dim counter As Integer = sOutput.IndexOf(":")
                                        Dim progress As String = sOutput.Substring(counter + 2, 2)
                                        Dim progressValue As Integer

                                        If progress.Contains(".") Then
                                            progressValue = progress.Substring(0, 1)
                                        Else
                                            progressValue = progress
                                        End If
                                        steamProgressBar.Invoke(
                                                Sub()
                                                    steamProgressBar.Style = ProgressBarStyle.Continuous
                                                    steamProgressBar.Value = progressValue
                                                End Sub
                                        )
                                    End If

                                    If sOutput Like "*Success*" Then
                                        steamProgressBar.Invoke(
                                                Sub()
                                                    steamProgressBar.Value = 100
                                                End Sub
                                        )
                                    End If

                                    If sOutput Like "*Timeout*" Then
                                        MsgBox("Steam download timed out, please update mod again.")
                                    End If

                                    steamOutputBox.Invoke(
                                    Sub()
                                        If sOutput = Nothing Then

                                        Else
                                            steamOutputBox.AppendText(sOutput & Environment.NewLine)
                                        End If

                                        steamOutputBox.SelectionStart = steamOutputBox.Text.Length
                                        steamOutputBox.ScrollToCaret()
                                    End Sub
                                    )
                                Catch ex As Exception
                                    MsgBox("RunSteamCommand - An exception occurred:" & vbCrLf & ex.Message & Environment.NewLine & Environment.NewLine & ex.ToString)
                                End Try

                            Loop

                        End Using

                    End Sub
                ))

            Await Task.WhenAll(tasks)

            If (cancelled = True) Then
                cancelled = Nothing

                steamProgressBar.Style = ProgressBarStyle.Continuous
                steamProgressBar.Value = 0

                steamOutputBox.Text = "Process Cancelled" & Environment.NewLine
            Else
                steamOutputBox.AppendText(Environment.NewLine & "Task Completed" & Environment.NewLine)
                steamOutputBox.Text = steamOutputBox.Text.TrimEnd

                steamProgressBar.Style = ProgressBarStyle.Continuous
                steamProgressBar.Value = 100

                If type Is "addon" Then
                    UpdateModGrid()

                    For Each item In modIDs
                        CopyKeys(item)
                    Next

                ElseIf type Is "server" Then
                    MsgBox("Server Installed/ Updated.")
                ElseIf type Is "install" Then
                    MsgBox("SteamCMD Installed.")
                End If
            End If

            cancelUpdateButton.Enabled = False
            modsTab.Enabled = True
            updateServerButton.Enabled = True
            updating = False
            modsDataGrid.PerformLayout()

        Else
            MessageBox.Show("Please check that SteamCMD is installed and that all fields are correct:" & Environment.NewLine & Environment.NewLine & "   -  Steam Dir" & Environment.NewLine & "   -  User Name & Pass" & Environment.NewLine & "   -  Server Dir", "Error")
        End If

    End Sub

    Private Sub CheckUpdatesButton_Click(sender As Object, e As EventArgs) Handles checkUpdatesButton.Click
        CheckForUpdates()
    End Sub

    Public Function SafeName(name As String)
        name = name.Replace("  ", "")
        name = name.Replace(" ", "_")
        name = name.Replace(">", "")
        name = name.Replace("<", "")
        name = name.Replace(":", "-")
        name = name.Replace("/", "")
        name = name.Replace("\", "")
        name = name.Replace("|", "")
        name = name.Replace("?", "")
        name = name.Replace("*", "")
        name = name.Replace(",", "_")

        Return name
    End Function

    Private Sub SelectedModsToClipboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectedModsToClipboardToolStripMenuItem.Click
        Dim modsLine As String = Nothing

        For Each row As DataGridViewRow In modsDataGrid.SelectedRows

            Dim modName As String = row.Cells(1).Value

            modsLine = modsLine & "@" & SafeName(modName) & ";"
        Next

        If modsLine = Nothing Then
            MsgBox("Select some mods.")
        Else
            Clipboard.SetText(modsLine)
            MsgBox("Mods line has been copied to clipboard: " & Environment.NewLine & modsLine)
        End If

    End Sub

    Private Sub AddNewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewToolStripMenuItem.Click

        If Directory.Exists(My.Settings.serverDir) Then
            Dim newServer As New TabPageEx
            categoryTabs.TabPages.Add(newServer)

            newServer.Text = "New Server"
            categoryTabs.SelectedTab = newServer
        Else
            MsgBox("Please install game before adding a server.")
        End If

    End Sub

    Private Sub OpenProfileDirectoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenProfileDirectoryToolStripMenuItem.Click
        If System.IO.Directory.Exists(Application.StartupPath & "\servers\") Then
            Process.Start(Application.StartupPath & "\servers\")
        Else
            MessageBox.Show("No Profiles", "Information")
        End If
    End Sub

    Private Sub ImportSteamModsStripMenuItem_Click(sender As Object, e As EventArgs) Handles importSteamModsStripMenuItem.Click

    End Sub
End Class


Public NotInheritable Class Simple3Des
    Private TripleDes As New TripleDESCryptoServiceProvider

    Private Function TruncateHash(
    ByVal key As String,
    ByVal length As Integer) As Byte()

        Dim sha1 As New SHA1CryptoServiceProvider

        ' Hash the key.
        Dim keyBytes() As Byte =
            System.Text.Encoding.Unicode.GetBytes(key)
        Dim hash() As Byte = sha1.ComputeHash(keyBytes)

        ' Truncate or pad the hash.
        ReDim Preserve hash(length - 1)
        Return hash
    End Function

    Sub New(ByVal key As String)
        ' Initialize the crypto provider.
        TripleDes.Key = TruncateHash(key, TripleDes.KeySize \ 8)
        TripleDes.IV = TruncateHash("", TripleDes.BlockSize \ 8)
    End Sub

    Public Function EncryptData(ByVal plaintext As String) As String
        Try
            ' Convert the plaintext string to a byte array.
            Dim plaintextBytes() As Byte =
                System.Text.Encoding.Unicode.GetBytes(plaintext)

            ' Create the stream.
            Dim ms As New System.IO.MemoryStream
            ' Create the encoder to write to the stream.
            Dim encStream As New CryptoStream(ms,
                TripleDes.CreateEncryptor(),
                System.Security.Cryptography.CryptoStreamMode.Write)

            ' Use the crypto stream to write the byte array to the stream.
            encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
            encStream.FlushFinalBlock()

            ' Convert the encrypted stream to a printable string.
            Return Convert.ToBase64String(ms.ToArray)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Function DecryptData(ByVal encryptedtext As String) As String
        Try
            ' Convert the encrypted text string to a byte array.
            Dim encryptedBytes() As Byte = Convert.FromBase64String(encryptedtext)

            ' Create the stream.
            Dim ms As New System.IO.MemoryStream
            ' Create the decoder to write to the stream.
            Dim decStream As New CryptoStream(ms,
                TripleDes.CreateDecryptor(),
                System.Security.Cryptography.CryptoStreamMode.Write)

            ' Use the crypto stream to write the byte array to the stream.
            decStream.Write(encryptedBytes, 0, encryptedBytes.Length)
            decStream.FlushFinalBlock()

            ' Convert the plaintext stream to a string.
            Return System.Text.Encoding.Unicode.GetString(ms.ToArray)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

End Class
