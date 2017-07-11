Imports System
Imports System.IO
Imports System.Text

Public Class ImportPrivateMod

    Dim modsfile As String = Application.StartupPath & "/mods.cfg"

    Private Sub ImportButton_Click(sender As Object, e As EventArgs) Handles importButton.Click

        If Not IsNumeric(workshopIDBox.Text) Then
            MsgBox("Please enter a valid Steam Workshop Item ID.")
        ElseIf modNameBox.Text = Nothing Then
            MsgBox("Please enter a name for the Workshop Item.")
        Else
            Dim modID As Integer = workshopIDBox.Text
            Dim modName As String = modNameBox.Text

            Try
                Dim steamUpdate As New DateTime(1970, 1, 1, 0, 0, 0)
                Dim modLine As String = modID & "," & modName & ",Not Installed," & steamUpdate & ",private" & Environment.NewLine

                If My.Computer.FileSystem.FileExists(modsfile) Then
                    Dim fs As StreamWriter = File.AppendText(modsfile)

                    fs.Write(modLine)
                    fs.Close()

                    Me.Close()
                    MainWindow.UpdateModGrid()
                Else
                    Dim fs As FileStream = File.Create(modsfile)

                    Dim modInfo As Byte() = New UTF8Encoding(True).GetBytes(modLine)
                    fs.Write(modInfo, 0, modInfo.Length)
                    fs.Close()

                    Me.Close()
                    MainWindow.UpdateModGrid()
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class