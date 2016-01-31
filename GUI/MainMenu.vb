Public Class MainMenu
    'FMOD declarations
    Dim Fsystem As New FMOD.System(Nothing)
    Dim Fversion As UInteger
    Dim Fresult As New FMOD.RESULT
    Dim sfxMouseDown, sfxMouseUp, sfxMouseHover, sfxBGM As New FMOD.Sound(Nothing)

    Private Sub MainMenu_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        FMOD_DeInitialize()
    End Sub

    Private Sub MainMenu_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Fresult = Fsystem.playSound(sfxBGM, Nothing, False, Nothing)
        ERRCHECK(Fresult)

        'Me.TopLevel = True
    End Sub

    Private Sub ERRCHECK(ByVal Fresult As FMOD.RESULT)
        If Fresult <> FMOD.RESULT.OK Then
            MessageBox.Show("FMOD Error: " & FMOD.Error.String(Fresult), "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If
    End Sub

    'Free resources used by FMOD
    Private Sub FMOD_DeInitialize()
        Fresult = sfxMouseDown.release()
        ERRCHECK(Fresult)
        Fresult = sfxMouseUp.release()
        ERRCHECK(Fresult)
        Fresult = sfxMouseHover.release()
        ERRCHECK(Fresult)
        Fresult = sfxBGM.release()
        ERRCHECK(Fresult)
        Fresult = Fsystem.close()
        ERRCHECK(Fresult)
        Fresult = Fsystem.release()
        ERRCHECK(Fresult)
    End Sub

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        FMOD_Initialize()
    End Sub

    'Initialize FMOD sound system and sfx
    Private Sub FMOD_Initialize()
        Fresult = FMOD.Factory.System_Create(Fsystem)
        ERRCHECK(Fresult)

        Fresult = Fsystem.getVersion(Fversion)
        ERRCHECK(Fresult)

        If Fversion < FMOD.VERSION.number Then
            MessageBox.Show("FMOD Error: The lib version (" & Fversion & ") doesn't match the header version (" & FMOD.VERSION.number & ")", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If

        Fresult = Fsystem.init(32, FMOD.INITFLAGS.NORMAL, Nothing)
        ERRCHECK(Fresult)

        Fresult = Fsystem.createStream(Application.StartupPath & "\cstrike\sound\ui\buttonclick.wav", FMOD.MODE.DEFAULT, sfxMouseDown)
        ERRCHECK(Fresult)

        Fresult = Fsystem.createStream(Application.StartupPath & "\cstrike\sound\ui\buttonclickrelease.wav", FMOD.MODE.DEFAULT, sfxMouseUp)
        ERRCHECK(Fresult)

        Fresult = Fsystem.createStream(Application.StartupPath & "\cstrike\sound\ui\buttonrollover.wav", FMOD.MODE.DEFAULT, sfxMouseHover)
        ERRCHECK(Fresult)

        Fresult = Fsystem.createStream(Application.StartupPath & "\cstrike\media\gamestartup.mp3", FMOD.MODE.LOOP_NORMAL, sfxBGM)
        ERRCHECK(Fresult)
    End Sub

    Private Sub btn_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_newgame.MouseEnter, btn_options.MouseEnter, btn_quit.MouseEnter
        'Play MouseHover sfx
        Fresult = Fsystem.playSound(sfxMouseHover, Nothing, False, Nothing)
        ERRCHECK(Fresult)
        'Set menu item highlight on
        sender.ForeColor = Color.White
    End Sub

    Private Sub btn_newgame_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_newgame.MouseLeave, btn_options.MouseLeave, btn_quit.MouseLeave
        'Set menu item highlight off
        sender.ForeColor = Color.DarkGray
    End Sub

    Private Sub btn_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn_newgame.MouseDown, btn_options.MouseDown, btn_quit.MouseDown
        'Play MouseUp & Mousedown sfx
        Fresult = Fsystem.playSound(sfxMouseDown, Nothing, False, Nothing)
        ERRCHECK(Fresult)
        Fresult = Fsystem.playSound(sfxMouseUp, Nothing, False, Nothing)
        ERRCHECK(Fresult)

        'Check which control fired the event
        If sender Is btn_quit Then
            QuitDialog.Show(Me)
        ElseIf sender Is btn_options Then
            OptionsDialog.Show(Me)
        ElseIf sender Is btn_newgame Then

        End If
    End Sub

    'Prevent flickering
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property
    Private Sub PreVentFlicker()
        With Me
            .SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            .SetStyle(ControlStyles.UserPaint, True)
            .SetStyle(ControlStyles.AllPaintingInWmPaint, True)
            .UpdateStyles()
        End With
    End Sub
End Class