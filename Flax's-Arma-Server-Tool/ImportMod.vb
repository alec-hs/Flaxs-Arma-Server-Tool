Imports System
Imports System.IO
Imports System.Text

Public Class ImportMod

    Dim modsfile As String = Application.StartupPath & "/mods.cfg"

    Private Sub ImportButton_Click(sender As Object, e As EventArgs) Handles importButton.Click
        Dim modURL As String = urlBox.Text

        ImportModToList(modURL)
    End Sub

    Public Sub ImportModToList(modUrl As String)
        Dim modID As Integer = modUrl.Substring(modUrl.IndexOf("?id=") + 4)
        Dim modName As String
        Dim appName As String
        Dim sourceString As String
        Dim duplicate As Boolean = False

        MainWindow.CheckModFile()
        Dim lines As List(Of String) = System.IO.File.ReadAllLines(modsfile).ToList

        For Each line In lines
            Dim values() As String = line.Split(",")
            If modID = values(0) Then
                duplicate = True
            End If
        Next

        If Not duplicate Then
            Try
                sourceString = New System.Net.WebClient().DownloadString(modUrl)

                appName = sourceString.Substring(sourceString.IndexOf("content=" & ControlChars.Quote & "Steam Workshop:") + 25, 6)


                If appName Like "Arma 3" Then
                    modName = sourceString.Substring(sourceString.IndexOf("<title>Steam Workshop :: ") + 25)
                    modName = StrReverse(modName)
                    modName = modName.Substring(modName.IndexOf(">eltit/<") + 8)
                    modName = StrReverse(modName)


                    If modUrl Like "http*://steamcommunity.com/*/filedetails/?id=*" Then
                        Try
                            Dim steamUpdate As New DateTime(1970, 1, 1, 0, 0, 0)
                            Dim modLine As String = modID & "," & modName & ",Not Installed," & steamUpdate & ",public" & Environment.NewLine

                            MainWindow.CheckModFile()
                            Dim fs As StreamWriter = File.AppendText(modsfile)

                            fs.Write(modLine)
                            fs.Close()

                            Me.Close()
                            MainWindow.UpdateModGrid()

                        Catch ex As Exception
                            modID = Nothing
                            MessageBox.Show("Please remove any charcters after the mod ID in the url.")
                            MsgBox("An exception occurred:" & vbCrLf & ex.Message)
                        End Try
                    Else
                        MessageBox.Show("Please use format: https://steamcommunity.com/sharedfiles/filedetails/?id=*********")
                    End If
                Else
                    MessageBox.Show("This is a workshop Item for a different game.")
                    Me.Close()
                End If
            Catch ex As Exception
                MsgBox("An exception occurred:" & vbCrLf & ex.Message)
            End Try
        Else
            Me.Close()
            MsgBox("Mod already imported.")
        End If

    End Sub

End Class