Imports System.IO
Imports System.IO.Compression

Public Class InstallSteamCMD

    Private Sub InstallSteamCMD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        installDirBox.Text = My.Settings.steamDir
    End Sub

    Private Sub InstallButton_Click(sender As Object, e As EventArgs) Handles installButton.Click
        DownloadSteam()
    End Sub

    Private Sub SteamDirSelect_Click(sender As Object, e As EventArgs) Handles steamDirButton.Click
        ChooseSteamDir()
    End Sub
    Public Sub ChooseSteamDir()
        If steamDirDialog.ShowDialog() = DialogResult.OK Then
            installDirBox.Text = steamDirDialog.SelectedPath
        End If
    End Sub

    Public Async Sub DownloadSteam()
        Me.Close()
        Dim installPath As String = installDirBox.Text
        Dim filePath As String = installPath + "\steamcmd.zip"
        Dim steamURL As String = "https://steamcdn-a.akamaihd.net/client/installer/steamcmd.zip"
        Dim tasks As New List(Of Task)()
        Dim steamCommand As String
        Dim extracted As Boolean = False
        Dim installed As Boolean = False

        tasks.Add(Task.Run(
                    Sub()
                        My.Computer.Network.DownloadFile(New Uri(steamURL), filePath, Nothing, Nothing, 10000, True)
                    End Sub
                ))

        Await Task.WhenAll(tasks)

        tasks.Clear()
        tasks.Add(Task.Run(
                  Sub()
                      Try
                          ZipFile.ExtractToDirectory(filePath, installPath)
                          extracted = True
                      Catch ex As Exception
                          'MessageBox.Show("Error - Please delete existing SteamCMD in this directory", "Error")
                          MsgBox("Unzip - An exception occurred:" & vbCrLf & ex.Message)
                          installed = True
                      End Try

                  End Sub
        ))

        Await Task.WhenAll(tasks)

        If extracted Then
            File.Delete(filePath)
            My.Settings.steamDir = installPath
            MainWindow.steamDirBox.Text = installPath

            MainWindow.Update()

            steamCommand = "+login anonymous +quit"

            MessageBox.Show("Steam CMD will now download and start the install process. If prompted please enter your Steam Guard Code." & Environment.NewLine & "You will recieve this by email from steam. When this is all complete type 'quit' to finish.", "Information")

            MainWindow.RunSteamCommand(installPath & "\steamcmd.exe", steamCommand, "install")

        Else
            If Not installed Then
                MessageBox.Show("Error - please check all fields and try again.", "Error")
            End If
        End If

    End Sub

End Class