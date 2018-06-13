<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ErrReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ErrReport))
        Me.rtfError = New System.Windows.Forms.RichTextBox()
        Me.createGitIssueButton = New System.Windows.Forms.Button()
        Me.errorInfoLabel = New System.Windows.Forms.Label()
        Me.goToBIButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rtfError
        '
        Me.rtfError.Location = New System.Drawing.Point(12, 94)
        Me.rtfError.Name = "rtfError"
        Me.rtfError.ReadOnly = True
        Me.rtfError.Size = New System.Drawing.Size(776, 344)
        Me.rtfError.TabIndex = 0
        Me.rtfError.Text = ""
        '
        'createGitIssueButton
        '
        Me.createGitIssueButton.Location = New System.Drawing.Point(618, 12)
        Me.createGitIssueButton.Name = "createGitIssueButton"
        Me.createGitIssueButton.Size = New System.Drawing.Size(170, 35)
        Me.createGitIssueButton.TabIndex = 2
        Me.createGitIssueButton.Text = "Create GitHub Issue"
        Me.createGitIssueButton.UseVisualStyleBackColor = True
        '
        'errorInfoLabel
        '
        Me.errorInfoLabel.ForeColor = System.Drawing.Color.Red
        Me.errorInfoLabel.Location = New System.Drawing.Point(12, 16)
        Me.errorInfoLabel.Name = "errorInfoLabel"
        Me.errorInfoLabel.Size = New System.Drawing.Size(460, 63)
        Me.errorInfoLabel.TabIndex = 3
        Me.errorInfoLabel.Text = "An error occured. Please report this on the GitHub Repo or in the BI Forums post." &
    " Please try and describe the setps that led to the error and include the error i" &
    "nfo below in a code block. "
        '
        'goToBIButton
        '
        Me.goToBIButton.Location = New System.Drawing.Point(618, 53)
        Me.goToBIButton.Name = "goToBIButton"
        Me.goToBIButton.Size = New System.Drawing.Size(170, 35)
        Me.goToBIButton.TabIndex = 4
        Me.goToBIButton.Text = "Go To BI Forums"
        Me.goToBIButton.UseVisualStyleBackColor = True
        '
        'ErrReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.goToBIButton)
        Me.Controls.Add(Me.errorInfoLabel)
        Me.Controls.Add(Me.createGitIssueButton)
        Me.Controls.Add(Me.rtfError)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ErrReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Error Report"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rtfError As RichTextBox
    Friend WithEvents createGitIssueButton As Button
    Friend WithEvents errorInfoLabel As Label
    Friend WithEvents goToBIButton As Button
End Class
