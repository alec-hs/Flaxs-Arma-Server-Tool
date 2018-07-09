<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewSymlink
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewSymlink))
        Me.dropBox = New System.Windows.Forms.TextBox()
        Me.dropLabel = New System.Windows.Forms.Label()
        Me.sourceBox = New System.Windows.Forms.TextBox()
        Me.sourceLabel = New System.Windows.Forms.Label()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.sourcePathButton = New System.Windows.Forms.Button()
        Me.dropPathButton = New System.Windows.Forms.Button()
        Me.folderSelectDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'dropBox
        '
        Me.dropBox.Location = New System.Drawing.Point(144, 55)
        Me.dropBox.Margin = New System.Windows.Forms.Padding(4)
        Me.dropBox.Name = "dropBox"
        Me.dropBox.Size = New System.Drawing.Size(422, 22)
        Me.dropBox.TabIndex = 9
        '
        'dropLabel
        '
        Me.dropLabel.AutoSize = True
        Me.dropLabel.Location = New System.Drawing.Point(13, 58)
        Me.dropLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.dropLabel.Name = "dropLabel"
        Me.dropLabel.Size = New System.Drawing.Size(123, 17)
        Me.dropLabel.TabIndex = 8
        Me.dropLabel.Text = "Destination Folder"
        '
        'sourceBox
        '
        Me.sourceBox.Location = New System.Drawing.Point(144, 23)
        Me.sourceBox.Margin = New System.Windows.Forms.Padding(4)
        Me.sourceBox.Name = "sourceBox"
        Me.sourceBox.Size = New System.Drawing.Size(422, 22)
        Me.sourceBox.TabIndex = 7
        '
        'sourceLabel
        '
        Me.sourceLabel.AutoSize = True
        Me.sourceLabel.Location = New System.Drawing.Point(13, 26)
        Me.sourceLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.sourceLabel.Name = "sourceLabel"
        Me.sourceLabel.Size = New System.Drawing.Size(97, 17)
        Me.sourceLabel.TabIndex = 6
        Me.sourceLabel.Text = "Source Folder"
        '
        'OKButton
        '
        Me.OKButton.Location = New System.Drawing.Point(506, 96)
        Me.OKButton.Margin = New System.Windows.Forms.Padding(4)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(100, 28)
        Me.OKButton.TabIndex = 19
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'sourcePathButton
        '
        Me.sourcePathButton.BackgroundImage = CType(resources.GetObject("sourcePathButton.BackgroundImage"), System.Drawing.Image)
        Me.sourcePathButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.sourcePathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sourcePathButton.Location = New System.Drawing.Point(574, 22)
        Me.sourcePathButton.Margin = New System.Windows.Forms.Padding(4)
        Me.sourcePathButton.Name = "sourcePathButton"
        Me.sourcePathButton.Size = New System.Drawing.Size(32, 25)
        Me.sourcePathButton.TabIndex = 20
        Me.sourcePathButton.UseVisualStyleBackColor = True
        '
        'dropPathButton
        '
        Me.dropPathButton.BackgroundImage = CType(resources.GetObject("dropPathButton.BackgroundImage"), System.Drawing.Image)
        Me.dropPathButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.dropPathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dropPathButton.Location = New System.Drawing.Point(574, 54)
        Me.dropPathButton.Margin = New System.Windows.Forms.Padding(4)
        Me.dropPathButton.Name = "dropPathButton"
        Me.dropPathButton.Size = New System.Drawing.Size(32, 25)
        Me.dropPathButton.TabIndex = 21
        Me.dropPathButton.UseVisualStyleBackColor = True
        '
        'folderSelectDialog
        '
        Me.folderSelectDialog.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'NewSymlink
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 137)
        Me.Controls.Add(Me.dropPathButton)
        Me.Controls.Add(Me.sourcePathButton)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.dropBox)
        Me.Controls.Add(Me.dropLabel)
        Me.Controls.Add(Me.sourceBox)
        Me.Controls.Add(Me.sourceLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NewSymlink"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "New Symbolic Link"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dropBox As TextBox
    Friend WithEvents dropLabel As Label
    Friend WithEvents sourceBox As TextBox
    Friend WithEvents sourceLabel As Label
    Friend WithEvents OKButton As Button
    Friend WithEvents sourcePathButton As Button
    Friend WithEvents dropPathButton As Button
    Friend WithEvents folderSelectDialog As FolderBrowserDialog
End Class
