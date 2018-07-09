Imports System.IO

Public Class NewSymlink
    Private Sub ChooseDir(caller As String)
        If folderSelectDialog.ShowDialog() = DialogResult.OK Then
            If caller = "source" Then
                sourceBox.Text = folderSelectDialog.SelectedPath
            ElseIf caller = "destination" Then
                dropBox.Text = folderSelectDialog.SelectedPath
            End If
        End If
    End Sub

    Private Sub sourcePathButton_Click(sender As Object, e As EventArgs) Handles sourcePathButton.Click
        ChooseDir("source")
    End Sub


    Private Sub dropPathButton_Click(sender As Object, e As EventArgs) Handles dropPathButton.Click
        ChooseDir("destination")
    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        Try
            Dim linkCommand As String
            Dim sourcePath As String = Path.GetFullPath(sourceBox.Text).TrimEnd(Path.DirectorySeparatorChar)
            Dim linkName As String = Path.GetFileName(sourcePath)
            Dim destinaitionPath As String = Path.GetFullPath(dropBox.Text).TrimEnd(Path.DirectorySeparatorChar)

            linkCommand = "/c mklink /D " & destinaitionPath & "\" & linkName & " " & sourcePath

            Process.Start("cmd", linkCommand)

            Close()

            MsgBox("Symlink Created")

        Catch ex As Exception
            MsgBox("An exception occurred:" & vbCrLf & ex.Message)
        End Try
    End Sub
End Class