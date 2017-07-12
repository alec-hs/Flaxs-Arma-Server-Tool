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
            Dim duplicate As Boolean = False

            Dim lines As List(Of String) = System.IO.File.ReadAllLines(modsfile).ToList

            For Each line In lines
                Dim values() As String = line.Split(",")
                If modID = values(0) Then
                    duplicate = True
                End If
            Next
            If Not duplicate Then
                Try
                    Dim steamUpdate As New DateTime(1970, 1, 1, 0, 0, 0)
                    Dim modLine As String = modID & "," & modName & ",Not Installed," & steamUpdate & ",private" & Environment.NewLine

                    Dim fs As StreamWriter = File.AppendText(modsfile)

                    fs.Write(modLine)
                    fs.Close()

                    Me.Close()
                    MainWindow.UpdateModGrid()

                Catch ex As Exception

                End Try
            Else
                Me.Close()
                MsgBox("Mod already imported.")
            End If

        End If
    End Sub
End Class