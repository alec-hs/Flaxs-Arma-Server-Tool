<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportPrivateMod
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImportPrivateMod))
        Me.modIDLabel = New System.Windows.Forms.Label()
        Me.modNameLabel = New System.Windows.Forms.Label()
        Me.modNameBox = New System.Windows.Forms.TextBox()
        Me.importButton = New System.Windows.Forms.Button()
        Me.workshopIDBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'modIDLabel
        '
        Me.modIDLabel.AutoSize = True
        Me.modIDLabel.Location = New System.Drawing.Point(12, 9)
        Me.modIDLabel.Name = "modIDLabel"
        Me.modIDLabel.Size = New System.Drawing.Size(70, 13)
        Me.modIDLabel.TabIndex = 3
        Me.modIDLabel.Text = "Workshop ID"
        '
        'modNameLabel
        '
        Me.modNameLabel.AutoSize = True
        Me.modNameLabel.Location = New System.Drawing.Point(12, 35)
        Me.modNameLabel.Name = "modNameLabel"
        Me.modNameLabel.Size = New System.Drawing.Size(59, 13)
        Me.modNameLabel.TabIndex = 4
        Me.modNameLabel.Text = "Mod Name"
        '
        'modNameBox
        '
        Me.modNameBox.Location = New System.Drawing.Point(88, 32)
        Me.modNameBox.Name = "modNameBox"
        Me.modNameBox.Size = New System.Drawing.Size(173, 20)
        Me.modNameBox.TabIndex = 3
        '
        'importButton
        '
        Me.importButton.Location = New System.Drawing.Point(186, 58)
        Me.importButton.Name = "importButton"
        Me.importButton.Size = New System.Drawing.Size(75, 23)
        Me.importButton.TabIndex = 4
        Me.importButton.Text = "Import"
        Me.importButton.UseVisualStyleBackColor = True
        '
        'workshopIDBox
        '
        Me.workshopIDBox.Location = New System.Drawing.Point(88, 6)
        Me.workshopIDBox.Name = "workshopIDBox"
        Me.workshopIDBox.Size = New System.Drawing.Size(173, 20)
        Me.workshopIDBox.TabIndex = 2
        '
        'ImportPrivateMod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(273, 94)
        Me.Controls.Add(Me.importButton)
        Me.Controls.Add(Me.modNameBox)
        Me.Controls.Add(Me.workshopIDBox)
        Me.Controls.Add(Me.modNameLabel)
        Me.Controls.Add(Me.modIDLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ImportPrivateMod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "F.A.S.T. - Import Private Mod"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents modIDLabel As Label
    Friend WithEvents modNameLabel As Label
    Friend WithEvents modNameBox As TextBox
    Friend WithEvents importButton As Button
    Friend WithEvents workshopIDBox As TextBox
End Class
