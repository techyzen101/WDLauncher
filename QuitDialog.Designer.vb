<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuitDialog
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
        Me.btn_quitgame = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.DragArea = New System.Windows.Forms.Panel()
        Me.title_quit = New System.Windows.Forms.Label()
        Me.IconHolder = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DragArea.SuspendLayout()
        CType(Me.IconHolder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_quitgame
        '
        Me.btn_quitgame.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_quitgame.BackColor = System.Drawing.Color.DimGray
        Me.btn_quitgame.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_quitgame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_quitgame.ForeColor = System.Drawing.Color.White
        Me.btn_quitgame.Location = New System.Drawing.Point(132, 115)
        Me.btn_quitgame.Name = "btn_quitgame"
        Me.btn_quitgame.Size = New System.Drawing.Size(75, 23)
        Me.btn_quitgame.TabIndex = 0
        Me.btn_quitgame.Text = "Quit Game"
        Me.btn_quitgame.UseVisualStyleBackColor = False
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancel.BackColor = System.Drawing.Color.DimGray
        Me.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_cancel.Location = New System.Drawing.Point(213, 115)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 1
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'DragArea
        '
        Me.DragArea.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DragArea.BackColor = System.Drawing.Color.DimGray
        Me.DragArea.Controls.Add(Me.title_quit)
        Me.DragArea.Controls.Add(Me.IconHolder)
        Me.DragArea.Location = New System.Drawing.Point(12, 12)
        Me.DragArea.Name = "DragArea"
        Me.DragArea.Size = New System.Drawing.Size(276, 32)
        Me.DragArea.TabIndex = 9
        '
        'title_quit
        '
        Me.title_quit.AutoSize = True
        Me.title_quit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title_quit.ForeColor = System.Drawing.Color.White
        Me.title_quit.Location = New System.Drawing.Point(28, 8)
        Me.title_quit.Margin = New System.Windows.Forms.Padding(40, 5, 50, 5)
        Me.title_quit.Name = "title_quit"
        Me.title_quit.Size = New System.Drawing.Size(31, 16)
        Me.title_quit.TabIndex = 10
        Me.title_quit.Text = "Quit"
        '
        'IconHolder
        '
        Me.IconHolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.IconHolder.ErrorImage = Nothing
        Me.IconHolder.Image = Global.WDLauncher.My.Resources.Resources.MenuIcon
        Me.IconHolder.InitialImage = Nothing
        Me.IconHolder.Location = New System.Drawing.Point(8, 8)
        Me.IconHolder.Margin = New System.Windows.Forms.Padding(8)
        Me.IconHolder.Name = "IconHolder"
        Me.IconHolder.Size = New System.Drawing.Size(16, 16)
        Me.IconHolder.TabIndex = 0
        Me.IconHolder.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(29, 67)
        Me.Label1.Margin = New System.Windows.Forms.Padding(40, 5, 50, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Are you sure?"
        '
        'QuitDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SpringGreen
        Me.ClientSize = New System.Drawing.Size(300, 150)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DragArea)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_quitgame)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "QuitDialog"
        Me.Opacity = 0.99R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.SpringGreen
        Me.DragArea.ResumeLayout(False)
        Me.DragArea.PerformLayout()
        CType(Me.IconHolder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_quitgame As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents DragArea As System.Windows.Forms.Panel
    Friend WithEvents IconHolder As System.Windows.Forms.PictureBox
    Friend WithEvents title_quit As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
