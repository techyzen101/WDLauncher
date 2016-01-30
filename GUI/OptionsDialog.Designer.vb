<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionsDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OptionsDialog))
        Dim ColorPack1 As WDLauncher.ColorPack = New WDLauncher.ColorPack()
        Dim ColorPack2 As WDLauncher.ColorPack = New WDLauncher.ColorPack()
        Dim ColorPack3 As WDLauncher.ColorPack = New WDLauncher.ColorPack()
        Dim ColorPack4 As WDLauncher.ColorPack = New WDLauncher.ColorPack()
        Dim ColorLinearGradient1 As WDLauncher.ColorLinearGradient = New WDLauncher.ColorLinearGradient()
        Dim ColorPack5 As WDLauncher.ColorPack = New WDLauncher.ColorPack()
        Dim ColorPack6 As WDLauncher.ColorPack = New WDLauncher.ColorPack()
        Dim ColorPack7 As WDLauncher.ColorPack = New WDLauncher.ColorPack()
        Dim ColorPack8 As WDLauncher.ColorPack = New WDLauncher.ColorPack()
        Dim ColorLinearGradient2 As WDLauncher.ColorLinearGradient = New WDLauncher.ColorLinearGradient()
        Dim ColorPack9 As WDLauncher.ColorPack = New WDLauncher.ColorPack()
        Dim ColorPack10 As WDLauncher.ColorPack = New WDLauncher.ColorPack()
        Dim ColorPack11 As WDLauncher.ColorPack = New WDLauncher.ColorPack()
        Dim ColorPack12 As WDLauncher.ColorPack = New WDLauncher.ColorPack()
        Dim ColorLinearGradient3 As WDLauncher.ColorLinearGradient = New WDLauncher.ColorLinearGradient()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.btn_apply = New System.Windows.Forms.Button()
        Me.DragArea = New System.Windows.Forms.Panel()
        Me.title_options = New System.Windows.Forms.Label()
        Me.IconHolder = New System.Windows.Forms.PictureBox()
        Me.TabControlContainer = New System.Windows.Forms.Panel()
        Me.Options_TabControl = New System.Windows.Forms.TabControl()
        Me.tabpage_multiplayer = New System.Windows.Forms.TabPage()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.label_spraypaint = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_advanced = New System.Windows.Forms.Button()
        Me.picturebox_crosshair = New System.Windows.Forms.PictureBox()
        Me.picturebox_spray = New System.Windows.Forms.PictureBox()
        Me.label_playername = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.tabpage_keyboard = New System.Windows.Forms.TabPage()
        Me.tabpage_mouse = New System.Windows.Forms.TabPage()
        Me.tabpage_audio = New System.Windows.Forms.TabPage()
        Me.tabpage_video = New System.Windows.Forms.TabPage()
        Me.tabpage_voice = New System.Windows.Forms.TabPage()
        Me.tab_multiplayer = New System.Windows.Forms.Button()
        Me.tab_keyboard = New System.Windows.Forms.Button()
        Me.tab_mouse = New System.Windows.Forms.Button()
        Me.tab_audio = New System.Windows.Forms.Button()
        Me.tab_video = New System.Windows.Forms.Button()
        Me.tab_voice = New System.Windows.Forms.Button()
        Me.slider_blue = New WDLauncher.gTrackBar()
        Me.slider_green = New WDLauncher.gTrackBar()
        Me.slider_red = New WDLauncher.gTrackBar()
        Me.combobox_crosshair = New WDLauncher.FlatCombo()
        Me.combobox_spray = New WDLauncher.FlatCombo()
        Me.DragArea.SuspendLayout()
        CType(Me.IconHolder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlContainer.SuspendLayout()
        Me.Options_TabControl.SuspendLayout()
        Me.tabpage_multiplayer.SuspendLayout()
        CType(Me.picturebox_crosshair, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picturebox_spray, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancel.BackColor = System.Drawing.Color.DimGray
        Me.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_cancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btn_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_cancel.Location = New System.Drawing.Point(490, 295)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 2
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'btn_ok
        '
        Me.btn_ok.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_ok.BackColor = System.Drawing.Color.DimGray
        Me.btn_ok.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_ok.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btn_ok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_ok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ok.ForeColor = System.Drawing.Color.White
        Me.btn_ok.Location = New System.Drawing.Point(409, 295)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(75, 23)
        Me.btn_ok.TabIndex = 3
        Me.btn_ok.Text = "OK"
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'btn_apply
        '
        Me.btn_apply.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_apply.BackColor = System.Drawing.Color.DimGray
        Me.btn_apply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_apply.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btn_apply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_apply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_apply.ForeColor = System.Drawing.Color.White
        Me.btn_apply.Location = New System.Drawing.Point(328, 295)
        Me.btn_apply.Name = "btn_apply"
        Me.btn_apply.Size = New System.Drawing.Size(75, 23)
        Me.btn_apply.TabIndex = 4
        Me.btn_apply.Text = "Apply"
        Me.btn_apply.UseVisualStyleBackColor = False
        '
        'DragArea
        '
        Me.DragArea.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DragArea.BackColor = System.Drawing.Color.DimGray
        Me.DragArea.Controls.Add(Me.title_options)
        Me.DragArea.Controls.Add(Me.IconHolder)
        Me.DragArea.Location = New System.Drawing.Point(12, 12)
        Me.DragArea.Name = "DragArea"
        Me.DragArea.Size = New System.Drawing.Size(553, 32)
        Me.DragArea.TabIndex = 8
        '
        'title_options
        '
        Me.title_options.AutoSize = True
        Me.title_options.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title_options.ForeColor = System.Drawing.Color.White
        Me.title_options.Location = New System.Drawing.Point(28, 8)
        Me.title_options.Margin = New System.Windows.Forms.Padding(40, 5, 50, 5)
        Me.title_options.Name = "title_options"
        Me.title_options.Size = New System.Drawing.Size(54, 16)
        Me.title_options.TabIndex = 12
        Me.title_options.Text = "Options"
        '
        'IconHolder
        '
        Me.IconHolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.IconHolder.ErrorImage = Nothing
        Me.IconHolder.Image = CType(resources.GetObject("IconHolder.Image"), System.Drawing.Image)
        Me.IconHolder.InitialImage = Nothing
        Me.IconHolder.Location = New System.Drawing.Point(8, 8)
        Me.IconHolder.Margin = New System.Windows.Forms.Padding(8)
        Me.IconHolder.Name = "IconHolder"
        Me.IconHolder.Size = New System.Drawing.Size(16, 16)
        Me.IconHolder.TabIndex = 11
        Me.IconHolder.TabStop = False
        '
        'TabControlContainer
        '
        Me.TabControlContainer.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControlContainer.Controls.Add(Me.Options_TabControl)
        Me.TabControlContainer.Location = New System.Drawing.Point(12, 85)
        Me.TabControlContainer.Name = "TabControlContainer"
        Me.TabControlContainer.Size = New System.Drawing.Size(553, 204)
        Me.TabControlContainer.TabIndex = 9
        '
        'Options_TabControl
        '
        Me.Options_TabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Options_TabControl.Controls.Add(Me.tabpage_multiplayer)
        Me.Options_TabControl.Controls.Add(Me.tabpage_keyboard)
        Me.Options_TabControl.Controls.Add(Me.tabpage_mouse)
        Me.Options_TabControl.Controls.Add(Me.tabpage_audio)
        Me.Options_TabControl.Controls.Add(Me.tabpage_video)
        Me.Options_TabControl.Controls.Add(Me.tabpage_voice)
        Me.Options_TabControl.Location = New System.Drawing.Point(-5, -23)
        Me.Options_TabControl.Name = "Options_TabControl"
        Me.Options_TabControl.SelectedIndex = 0
        Me.Options_TabControl.Size = New System.Drawing.Size(563, 232)
        Me.Options_TabControl.TabIndex = 0
        '
        'tabpage_multiplayer
        '
        Me.tabpage_multiplayer.BackColor = System.Drawing.Color.Gray
        Me.tabpage_multiplayer.Controls.Add(Me.slider_blue)
        Me.tabpage_multiplayer.Controls.Add(Me.slider_green)
        Me.tabpage_multiplayer.Controls.Add(Me.slider_red)
        Me.tabpage_multiplayer.Controls.Add(Me.CheckBox1)
        Me.tabpage_multiplayer.Controls.Add(Me.Label3)
        Me.tabpage_multiplayer.Controls.Add(Me.label_spraypaint)
        Me.tabpage_multiplayer.Controls.Add(Me.Label1)
        Me.tabpage_multiplayer.Controls.Add(Me.btn_advanced)
        Me.tabpage_multiplayer.Controls.Add(Me.combobox_crosshair)
        Me.tabpage_multiplayer.Controls.Add(Me.picturebox_crosshair)
        Me.tabpage_multiplayer.Controls.Add(Me.combobox_spray)
        Me.tabpage_multiplayer.Controls.Add(Me.picturebox_spray)
        Me.tabpage_multiplayer.Controls.Add(Me.label_playername)
        Me.tabpage_multiplayer.Controls.Add(Me.TextBox1)
        Me.tabpage_multiplayer.Location = New System.Drawing.Point(4, 22)
        Me.tabpage_multiplayer.Name = "tabpage_multiplayer"
        Me.tabpage_multiplayer.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpage_multiplayer.Size = New System.Drawing.Size(555, 206)
        Me.tabpage_multiplayer.TabIndex = 0
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(432, 157)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(85, 17)
        Me.CheckBox1.TabIndex = 21
        Me.CheckBox1.Text = "Transclucent"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(293, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Crosshair Appearance"
        '
        'label_spraypaint
        '
        Me.label_spraypaint.AutoSize = True
        Me.label_spraypaint.ForeColor = System.Drawing.Color.White
        Me.label_spraypaint.Location = New System.Drawing.Point(29, 67)
        Me.label_spraypaint.Name = "label_spraypaint"
        Me.label_spraypaint.Size = New System.Drawing.Size(61, 13)
        Me.label_spraypaint.TabIndex = 19
        Me.label_spraypaint.Text = "Spray Paint"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(102, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 39)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Changes to your spraypaint" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "image takes effect when you " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "join a server."
        '
        'btn_advanced
        '
        Me.btn_advanced.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_advanced.BackColor = System.Drawing.Color.Gray
        Me.btn_advanced.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_advanced.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btn_advanced.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_advanced.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_advanced.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_advanced.ForeColor = System.Drawing.Color.White
        Me.btn_advanced.Location = New System.Drawing.Point(296, 31)
        Me.btn_advanced.Name = "btn_advanced"
        Me.btn_advanced.Size = New System.Drawing.Size(130, 23)
        Me.btn_advanced.TabIndex = 16
        Me.btn_advanced.Text = "Advanced"
        Me.btn_advanced.UseVisualStyleBackColor = False
        '
        'picturebox_crosshair
        '
        Me.picturebox_crosshair.BackColor = System.Drawing.Color.DimGray
        Me.picturebox_crosshair.Location = New System.Drawing.Point(296, 83)
        Me.picturebox_crosshair.Name = "picturebox_crosshair"
        Me.picturebox_crosshair.Size = New System.Drawing.Size(64, 64)
        Me.picturebox_crosshair.TabIndex = 5
        Me.picturebox_crosshair.TabStop = False
        '
        'picturebox_spray
        '
        Me.picturebox_spray.BackColor = System.Drawing.Color.DimGray
        Me.picturebox_spray.Location = New System.Drawing.Point(32, 83)
        Me.picturebox_spray.Name = "picturebox_spray"
        Me.picturebox_spray.Size = New System.Drawing.Size(64, 64)
        Me.picturebox_spray.TabIndex = 2
        Me.picturebox_spray.TabStop = False
        '
        'label_playername
        '
        Me.label_playername.AutoSize = True
        Me.label_playername.ForeColor = System.Drawing.Color.White
        Me.label_playername.Location = New System.Drawing.Point(29, 18)
        Me.label_playername.Name = "label_playername"
        Me.label_playername.Size = New System.Drawing.Size(67, 13)
        Me.label_playername.TabIndex = 1
        Me.label_playername.Text = "Player Name"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.DimGray
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(32, 34)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 20)
        Me.TextBox1.TabIndex = 0
        '
        'tabpage_keyboard
        '
        Me.tabpage_keyboard.BackColor = System.Drawing.Color.Gray
        Me.tabpage_keyboard.Location = New System.Drawing.Point(4, 22)
        Me.tabpage_keyboard.Name = "tabpage_keyboard"
        Me.tabpage_keyboard.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpage_keyboard.Size = New System.Drawing.Size(555, 206)
        Me.tabpage_keyboard.TabIndex = 1
        '
        'tabpage_mouse
        '
        Me.tabpage_mouse.BackColor = System.Drawing.Color.Gray
        Me.tabpage_mouse.Location = New System.Drawing.Point(4, 22)
        Me.tabpage_mouse.Name = "tabpage_mouse"
        Me.tabpage_mouse.Size = New System.Drawing.Size(555, 206)
        Me.tabpage_mouse.TabIndex = 2
        '
        'tabpage_audio
        '
        Me.tabpage_audio.BackColor = System.Drawing.Color.Gray
        Me.tabpage_audio.Location = New System.Drawing.Point(4, 22)
        Me.tabpage_audio.Name = "tabpage_audio"
        Me.tabpage_audio.Size = New System.Drawing.Size(555, 206)
        Me.tabpage_audio.TabIndex = 3
        '
        'tabpage_video
        '
        Me.tabpage_video.BackColor = System.Drawing.Color.Gray
        Me.tabpage_video.Location = New System.Drawing.Point(4, 22)
        Me.tabpage_video.Name = "tabpage_video"
        Me.tabpage_video.Size = New System.Drawing.Size(555, 206)
        Me.tabpage_video.TabIndex = 4
        '
        'tabpage_voice
        '
        Me.tabpage_voice.BackColor = System.Drawing.Color.Gray
        Me.tabpage_voice.Location = New System.Drawing.Point(4, 22)
        Me.tabpage_voice.Name = "tabpage_voice"
        Me.tabpage_voice.Size = New System.Drawing.Size(555, 206)
        Me.tabpage_voice.TabIndex = 5
        '
        'tab_multiplayer
        '
        Me.tab_multiplayer.BackColor = System.Drawing.Color.Gray
        Me.tab_multiplayer.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.tab_multiplayer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.tab_multiplayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.tab_multiplayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tab_multiplayer.ForeColor = System.Drawing.Color.White
        Me.tab_multiplayer.Location = New System.Drawing.Point(12, 60)
        Me.tab_multiplayer.Margin = New System.Windows.Forms.Padding(0)
        Me.tab_multiplayer.Name = "tab_multiplayer"
        Me.tab_multiplayer.Size = New System.Drawing.Size(75, 25)
        Me.tab_multiplayer.TabIndex = 10
        Me.tab_multiplayer.Text = "Multiplayer"
        Me.tab_multiplayer.UseVisualStyleBackColor = False
        '
        'tab_keyboard
        '
        Me.tab_keyboard.BackColor = System.Drawing.Color.Gray
        Me.tab_keyboard.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.tab_keyboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.tab_keyboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.tab_keyboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tab_keyboard.ForeColor = System.Drawing.Color.White
        Me.tab_keyboard.Location = New System.Drawing.Point(87, 62)
        Me.tab_keyboard.Margin = New System.Windows.Forms.Padding(0)
        Me.tab_keyboard.Name = "tab_keyboard"
        Me.tab_keyboard.Size = New System.Drawing.Size(75, 23)
        Me.tab_keyboard.TabIndex = 11
        Me.tab_keyboard.Text = "Keyboard"
        Me.tab_keyboard.UseVisualStyleBackColor = False
        '
        'tab_mouse
        '
        Me.tab_mouse.BackColor = System.Drawing.Color.Gray
        Me.tab_mouse.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.tab_mouse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.tab_mouse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.tab_mouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tab_mouse.ForeColor = System.Drawing.Color.White
        Me.tab_mouse.Location = New System.Drawing.Point(162, 62)
        Me.tab_mouse.Margin = New System.Windows.Forms.Padding(0)
        Me.tab_mouse.Name = "tab_mouse"
        Me.tab_mouse.Size = New System.Drawing.Size(75, 23)
        Me.tab_mouse.TabIndex = 12
        Me.tab_mouse.Text = "Mouse"
        Me.tab_mouse.UseVisualStyleBackColor = False
        '
        'tab_audio
        '
        Me.tab_audio.BackColor = System.Drawing.Color.Gray
        Me.tab_audio.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.tab_audio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.tab_audio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.tab_audio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tab_audio.ForeColor = System.Drawing.Color.White
        Me.tab_audio.Location = New System.Drawing.Point(237, 62)
        Me.tab_audio.Margin = New System.Windows.Forms.Padding(0)
        Me.tab_audio.Name = "tab_audio"
        Me.tab_audio.Size = New System.Drawing.Size(75, 23)
        Me.tab_audio.TabIndex = 13
        Me.tab_audio.Text = "Audio"
        Me.tab_audio.UseVisualStyleBackColor = False
        '
        'tab_video
        '
        Me.tab_video.BackColor = System.Drawing.Color.Gray
        Me.tab_video.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.tab_video.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.tab_video.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.tab_video.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tab_video.ForeColor = System.Drawing.Color.White
        Me.tab_video.Location = New System.Drawing.Point(312, 62)
        Me.tab_video.Margin = New System.Windows.Forms.Padding(0)
        Me.tab_video.Name = "tab_video"
        Me.tab_video.Size = New System.Drawing.Size(75, 23)
        Me.tab_video.TabIndex = 14
        Me.tab_video.Text = "Video"
        Me.tab_video.UseVisualStyleBackColor = False
        '
        'tab_voice
        '
        Me.tab_voice.BackColor = System.Drawing.Color.Gray
        Me.tab_voice.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.tab_voice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.tab_voice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.tab_voice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tab_voice.ForeColor = System.Drawing.Color.White
        Me.tab_voice.Location = New System.Drawing.Point(387, 62)
        Me.tab_voice.Margin = New System.Windows.Forms.Padding(0)
        Me.tab_voice.Name = "tab_voice"
        Me.tab_voice.Size = New System.Drawing.Size(75, 23)
        Me.tab_voice.TabIndex = 15
        Me.tab_voice.Text = "Voice"
        Me.tab_voice.UseVisualStyleBackColor = False
        '
        'slider_blue
        '
        ColorPack1.Border = System.Drawing.Color.DarkGray
        ColorPack1.Face = System.Drawing.Color.DarkGray
        ColorPack1.Highlight = System.Drawing.Color.DarkGray
        Me.slider_blue.AButColor = ColorPack1
        Me.slider_blue.ArrowColorDown = System.Drawing.Color.DarkGray
        Me.slider_blue.ArrowColorHover = System.Drawing.Color.DarkGray
        Me.slider_blue.ArrowColorUp = System.Drawing.Color.DarkGray
        Me.slider_blue.BackColor = System.Drawing.Color.Transparent
        Me.slider_blue.BrushStyle = WDLauncher.gTrackBar.eBrushStyle.Linear
        Me.slider_blue.ChangeLarge = 17
        Me.slider_blue.ChangeSmall = 15
        ColorPack2.Border = System.Drawing.Color.DarkGray
        ColorPack2.Face = System.Drawing.Color.DarkGray
        ColorPack2.Highlight = System.Drawing.Color.DarkGray
        Me.slider_blue.ColorDown = ColorPack2
        ColorPack3.Border = System.Drawing.Color.DarkGray
        ColorPack3.Face = System.Drawing.Color.DarkGray
        ColorPack3.Highlight = System.Drawing.Color.DarkGray
        Me.slider_blue.ColorHover = ColorPack3
        ColorPack4.Border = System.Drawing.Color.DarkGray
        ColorPack4.Face = System.Drawing.Color.DarkGray
        ColorPack4.Highlight = System.Drawing.Color.DarkGray
        Me.slider_blue.ColorUp = ColorPack4
        Me.slider_blue.FloatValue = False
        Me.slider_blue.Label = ""
        Me.slider_blue.Location = New System.Drawing.Point(363, 125)
        Me.slider_blue.Margin = New System.Windows.Forms.Padding(0)
        Me.slider_blue.MaxValue = 255
        Me.slider_blue.Name = "slider_blue"
        Me.slider_blue.Size = New System.Drawing.Size(130, 21)
        Me.slider_blue.SliderCapEnd = System.Drawing.Drawing2D.LineCap.Square
        Me.slider_blue.SliderCapStart = System.Drawing.Drawing2D.LineCap.Square
        ColorLinearGradient1.ColorA = System.Drawing.Color.DarkGray
        ColorLinearGradient1.ColorB = System.Drawing.Color.DarkGray
        Me.slider_blue.SliderColorLow = ColorLinearGradient1
        Me.slider_blue.SliderShape = WDLauncher.gTrackBar.eShape.Rectangle
        Me.slider_blue.SliderSize = New System.Drawing.Size(8, 15)
        Me.slider_blue.SliderWidthHigh = 1.0!
        Me.slider_blue.SliderWidthLow = 1.0!
        Me.slider_blue.TabIndex = 24
        Me.slider_blue.TickInterval = 17
        Me.slider_blue.TickOffset = 0
        Me.slider_blue.TickThickness = 1.0!
        Me.slider_blue.TickType = WDLauncher.gTrackBar.eTickType.Down_Left
        Me.slider_blue.TickWidth = 2
        Me.slider_blue.UpDownAutoWidth = False
        Me.slider_blue.UpDownShow = False
        Me.slider_blue.Value = 0
        Me.slider_blue.ValueAdjusted = 0.0!
        Me.slider_blue.ValueDivisor = WDLauncher.gTrackBar.eValueDivisor.e1
        Me.slider_blue.ValueStrFormat = Nothing
        '
        'slider_green
        '
        ColorPack5.Border = System.Drawing.Color.DarkGray
        ColorPack5.Face = System.Drawing.Color.DarkGray
        ColorPack5.Highlight = System.Drawing.Color.DarkGray
        Me.slider_green.AButColor = ColorPack5
        Me.slider_green.ArrowColorDown = System.Drawing.Color.DarkGray
        Me.slider_green.ArrowColorHover = System.Drawing.Color.DarkGray
        Me.slider_green.ArrowColorUp = System.Drawing.Color.DarkGray
        Me.slider_green.BackColor = System.Drawing.Color.Transparent
        Me.slider_green.BrushStyle = WDLauncher.gTrackBar.eBrushStyle.Linear
        Me.slider_green.ChangeLarge = 17
        Me.slider_green.ChangeSmall = 15
        ColorPack6.Border = System.Drawing.Color.DarkGray
        ColorPack6.Face = System.Drawing.Color.DarkGray
        ColorPack6.Highlight = System.Drawing.Color.DarkGray
        Me.slider_green.ColorDown = ColorPack6
        ColorPack7.Border = System.Drawing.Color.DarkGray
        ColorPack7.Face = System.Drawing.Color.DarkGray
        ColorPack7.Highlight = System.Drawing.Color.DarkGray
        Me.slider_green.ColorHover = ColorPack7
        ColorPack8.Border = System.Drawing.Color.DarkGray
        ColorPack8.Face = System.Drawing.Color.DarkGray
        ColorPack8.Highlight = System.Drawing.Color.DarkGray
        Me.slider_green.ColorUp = ColorPack8
        Me.slider_green.FloatValue = False
        Me.slider_green.Label = ""
        Me.slider_green.Location = New System.Drawing.Point(363, 104)
        Me.slider_green.Margin = New System.Windows.Forms.Padding(0)
        Me.slider_green.MaxValue = 255
        Me.slider_green.Name = "slider_green"
        Me.slider_green.Size = New System.Drawing.Size(130, 21)
        Me.slider_green.SliderCapEnd = System.Drawing.Drawing2D.LineCap.Square
        Me.slider_green.SliderCapStart = System.Drawing.Drawing2D.LineCap.Square
        ColorLinearGradient2.ColorA = System.Drawing.Color.DarkGray
        ColorLinearGradient2.ColorB = System.Drawing.Color.DarkGray
        Me.slider_green.SliderColorLow = ColorLinearGradient2
        Me.slider_green.SliderShape = WDLauncher.gTrackBar.eShape.Rectangle
        Me.slider_green.SliderSize = New System.Drawing.Size(8, 15)
        Me.slider_green.SliderWidthHigh = 1.0!
        Me.slider_green.SliderWidthLow = 1.0!
        Me.slider_green.TabIndex = 23
        Me.slider_green.TickInterval = 17
        Me.slider_green.TickOffset = 0
        Me.slider_green.TickThickness = 1.0!
        Me.slider_green.TickType = WDLauncher.gTrackBar.eTickType.Down_Left
        Me.slider_green.TickWidth = 2
        Me.slider_green.UpDownAutoWidth = False
        Me.slider_green.UpDownShow = False
        Me.slider_green.Value = 0
        Me.slider_green.ValueAdjusted = 0.0!
        Me.slider_green.ValueDivisor = WDLauncher.gTrackBar.eValueDivisor.e1
        Me.slider_green.ValueStrFormat = Nothing
        '
        'slider_red
        '
        ColorPack9.Border = System.Drawing.Color.DarkGray
        ColorPack9.Face = System.Drawing.Color.DarkGray
        ColorPack9.Highlight = System.Drawing.Color.DarkGray
        Me.slider_red.AButColor = ColorPack9
        Me.slider_red.ArrowColorDown = System.Drawing.Color.DarkGray
        Me.slider_red.ArrowColorHover = System.Drawing.Color.DarkGray
        Me.slider_red.ArrowColorUp = System.Drawing.Color.DarkGray
        Me.slider_red.BackColor = System.Drawing.Color.Transparent
        Me.slider_red.BrushStyle = WDLauncher.gTrackBar.eBrushStyle.Linear
        Me.slider_red.ChangeLarge = 17
        Me.slider_red.ChangeSmall = 15
        ColorPack10.Border = System.Drawing.Color.DarkGray
        ColorPack10.Face = System.Drawing.Color.DarkGray
        ColorPack10.Highlight = System.Drawing.Color.DarkGray
        Me.slider_red.ColorDown = ColorPack10
        ColorPack11.Border = System.Drawing.Color.DarkGray
        ColorPack11.Face = System.Drawing.Color.DarkGray
        ColorPack11.Highlight = System.Drawing.Color.DarkGray
        Me.slider_red.ColorHover = ColorPack11
        ColorPack12.Border = System.Drawing.Color.DarkGray
        ColorPack12.Face = System.Drawing.Color.DarkGray
        ColorPack12.Highlight = System.Drawing.Color.DarkGray
        Me.slider_red.ColorUp = ColorPack12
        Me.slider_red.FloatValue = False
        Me.slider_red.Label = ""
        Me.slider_red.Location = New System.Drawing.Point(363, 83)
        Me.slider_red.Margin = New System.Windows.Forms.Padding(0)
        Me.slider_red.MaxValue = 255
        Me.slider_red.Name = "slider_red"
        Me.slider_red.Size = New System.Drawing.Size(130, 21)
        Me.slider_red.SliderCapEnd = System.Drawing.Drawing2D.LineCap.Square
        Me.slider_red.SliderCapStart = System.Drawing.Drawing2D.LineCap.Square
        ColorLinearGradient3.ColorA = System.Drawing.Color.DarkGray
        ColorLinearGradient3.ColorB = System.Drawing.Color.DarkGray
        Me.slider_red.SliderColorLow = ColorLinearGradient3
        Me.slider_red.SliderShape = WDLauncher.gTrackBar.eShape.Rectangle
        Me.slider_red.SliderSize = New System.Drawing.Size(8, 15)
        Me.slider_red.SliderWidthHigh = 1.0!
        Me.slider_red.SliderWidthLow = 1.0!
        Me.slider_red.TabIndex = 22
        Me.slider_red.TickInterval = 17
        Me.slider_red.TickOffset = 0
        Me.slider_red.TickThickness = 1.0!
        Me.slider_red.TickType = WDLauncher.gTrackBar.eTickType.Down_Left
        Me.slider_red.TickWidth = 2
        Me.slider_red.UpDownAutoWidth = False
        Me.slider_red.UpDownShow = False
        Me.slider_red.Value = 0
        Me.slider_red.ValueAdjusted = 0.0!
        Me.slider_red.ValueDivisor = WDLauncher.gTrackBar.eValueDivisor.e1
        Me.slider_red.ValueStrFormat = Nothing
        '
        'combobox_crosshair
        '
        Me.combobox_crosshair.BackColor = System.Drawing.Color.DimGray
        Me.combobox_crosshair.ButtonColor = System.Drawing.Color.DimGray
        Me.combobox_crosshair.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_crosshair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.combobox_crosshair.ForeColor = System.Drawing.Color.White
        Me.combobox_crosshair.Location = New System.Drawing.Point(296, 153)
        Me.combobox_crosshair.Name = "combobox_crosshair"
        Me.combobox_crosshair.Size = New System.Drawing.Size(130, 21)
        Me.combobox_crosshair.Sorted = True
        Me.combobox_crosshair.TabIndex = 6
        '
        'combobox_spray
        '
        Me.combobox_spray.BackColor = System.Drawing.Color.DimGray
        Me.combobox_spray.ButtonColor = System.Drawing.Color.DimGray
        Me.combobox_spray.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_spray.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.combobox_spray.ForeColor = System.Drawing.Color.White
        Me.combobox_spray.Items.AddRange(New Object() {"Default", "TrollFace"})
        Me.combobox_spray.Location = New System.Drawing.Point(102, 83)
        Me.combobox_spray.Name = "combobox_spray"
        Me.combobox_spray.Size = New System.Drawing.Size(130, 21)
        Me.combobox_spray.Sorted = True
        Me.combobox_spray.TabIndex = 3
        '
        'OptionsDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SpringGreen
        Me.ClientSize = New System.Drawing.Size(577, 330)
        Me.ControlBox = False
        Me.Controls.Add(Me.tab_voice)
        Me.Controls.Add(Me.tab_video)
        Me.Controls.Add(Me.tab_audio)
        Me.Controls.Add(Me.tab_mouse)
        Me.Controls.Add(Me.TabControlContainer)
        Me.Controls.Add(Me.DragArea)
        Me.Controls.Add(Me.btn_apply)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.tab_keyboard)
        Me.Controls.Add(Me.tab_multiplayer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OptionsDialog"
        Me.Opacity = 0.99R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.SpringGreen
        Me.DragArea.ResumeLayout(False)
        Me.DragArea.PerformLayout()
        CType(Me.IconHolder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlContainer.ResumeLayout(False)
        Me.Options_TabControl.ResumeLayout(False)
        Me.tabpage_multiplayer.ResumeLayout(False)
        Me.tabpage_multiplayer.PerformLayout()
        CType(Me.picturebox_crosshair, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picturebox_spray, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_ok As System.Windows.Forms.Button
    Friend WithEvents btn_apply As System.Windows.Forms.Button
    Friend WithEvents DragArea As System.Windows.Forms.Panel
    Friend WithEvents title_options As System.Windows.Forms.Label
    Friend WithEvents IconHolder As System.Windows.Forms.PictureBox
    Friend WithEvents TabControlContainer As System.Windows.Forms.Panel
    Friend WithEvents Options_TabControl As System.Windows.Forms.TabControl
    Friend WithEvents tabpage_multiplayer As System.Windows.Forms.TabPage
    Friend WithEvents tabpage_keyboard As System.Windows.Forms.TabPage
    Friend WithEvents tab_multiplayer As System.Windows.Forms.Button
    Friend WithEvents tab_keyboard As System.Windows.Forms.Button
    Friend WithEvents tab_mouse As System.Windows.Forms.Button
    Friend WithEvents tab_audio As System.Windows.Forms.Button
    Friend WithEvents tab_video As System.Windows.Forms.Button
    Friend WithEvents tab_voice As System.Windows.Forms.Button
    Friend WithEvents tabpage_mouse As System.Windows.Forms.TabPage
    Friend WithEvents tabpage_audio As System.Windows.Forms.TabPage
    Friend WithEvents tabpage_video As System.Windows.Forms.TabPage
    Friend WithEvents tabpage_voice As System.Windows.Forms.TabPage
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents picturebox_spray As System.Windows.Forms.PictureBox
    Friend WithEvents label_playername As System.Windows.Forms.Label
    Friend WithEvents combobox_spray As WDLauncher.FlatCombo
    Friend WithEvents combobox_crosshair As WDLauncher.FlatCombo
    Friend WithEvents picturebox_crosshair As System.Windows.Forms.PictureBox
    Friend WithEvents btn_advanced As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents label_spraypaint As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents slider_blue As WDLauncher.gTrackBar
    Friend WithEvents slider_green As WDLauncher.gTrackBar
    Friend WithEvents slider_red As WDLauncher.gTrackBar
End Class
