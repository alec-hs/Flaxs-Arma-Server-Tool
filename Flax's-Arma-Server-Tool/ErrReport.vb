Public Class ErrReport
    Private Sub CreateGitIssueButton_Click(sender As Object, e As EventArgs) Handles createGitIssueButton.Click
        Process.Start("https://github.com/alec-hs/Flaxs-Arma-Server-Tool/issues/new")
    End Sub

    Private Sub goToBIButton_Click(sender As Object, e As EventArgs) Handles goToBIButton.Click
        Process.Start("https://forums.bohemia.net/forums/topic/206609-flaxs-arma-server-tool-fast/")
    End Sub
End Class