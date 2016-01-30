<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.btn_newgame = New System.Windows.Forms.Label()
        Me.btn_options = New System.Windows.Forms.Label()
        Me.btn_quit = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_newgame
        '
        Me.btn_newgame.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_newgame.AutoSize = True
        Me.btn_newgame.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_newgame.ForeColor = System.Drawing.Color.DarkGray
        Me.btn_newgame.Location = New System.Drawing.Point(59, 594)
        Me.btn_newgame.Margin = New System.Windows.Forms.Padding(50, 5, 50, 5)
        Me.btn_newgame.Name = "btn_newgame"
        Me.btn_newgame.Size = New System.Drawing.Size(85, 17)
        Me.btn_newgame.TabIndex = 0
        Me.btn_newgame.Text = "New Game"
        '
        'btn_options
        '
        Me.btn_options.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_options.AutoSize = True
        Me.btn_options.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_options.ForeColor = System.Drawing.Color.DarkGray
        Me.btn_options.Location = New System.Drawing.Point(59, 621)
        Me.btn_options.Margin = New System.Windows.Forms.Padding(50, 5, 50, 5)
        Me.btn_options.Name = "btn_options"
        Me.btn_options.Size = New System.Drawing.Size(64, 17)
        Me.btn_options.TabIndex = 1
        Me.btn_options.Text = "Options"
        '
        'btn_quit
        '
        Me.btn_quit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_quit.AutoSize = True
        Me.btn_quit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_quit.ForeColor = System.Drawing.Color.DarkGray
        Me.btn_quit.Location = New System.Drawing.Point(59, 648)
        Me.btn_quit.Margin = New System.Windows.Forms.Padding(50, 5, 50, 5)
        Me.btn_quit.Name = "btn_quit"
        Me.btn_quit.Size = New System.Drawing.Size(38, 17)
        Me.btn_quit.TabIndex = 2
        Me.btn_quit.Text = "Quit"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.WDLauncher.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_quit)
        Me.Controls.Add(Me.btn_options)
        Me.Controls.Add(Me.btn_newgame)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_newgame As System.Windows.Forms.Label
    Friend WithEvents btn_options As System.Windows.Forms.Label
    Friend WithEvents btn_quit As System.Windows.Forms.Label

End Class
