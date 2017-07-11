<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ImportMod
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImportMod))
        Me.urlLabel = New System.Windows.Forms.Label()
        Me.urlBox = New System.Windows.Forms.TextBox()
        Me.importButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'urlLabel
        '
        Me.urlLabel.AutoSize = True
        Me.urlLabel.Location = New System.Drawing.Point(12, 17)
        Me.urlLabel.Name = "urlLabel"
        Me.urlLabel.Size = New System.Drawing.Size(62, 13)
        Me.urlLabel.TabIndex = 0
        Me.urlLabel.Text = "Steam URL"
        '
        'urlBox
        '
        Me.urlBox.Location = New System.Drawing.Point(80, 14)
        Me.urlBox.Name = "urlBox"
        Me.urlBox.Size = New System.Drawing.Size(267, 20)
        Me.urlBox.TabIndex = 1
        '
        'importButton
        '
        Me.importButton.Location = New System.Drawing.Point(353, 12)
        Me.importButton.Name = "importButton"
        Me.importButton.Size = New System.Drawing.Size(75, 23)
        Me.importButton.TabIndex = 2
        Me.importButton.Text = "Import"
        Me.importButton.UseVisualStyleBackColor = True
        '
        'ImportMod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 47)
        Me.Controls.Add(Me.importButton)
        Me.Controls.Add(Me.urlBox)
        Me.Controls.Add(Me.urlLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ImportMod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "F.A.S.T. - Import Mod"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents urlLabel As Label
    Friend WithEvents urlBox As TextBox
    Friend WithEvents importButton As Button
End Class
