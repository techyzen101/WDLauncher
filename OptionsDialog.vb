Public Class OptionsDialog
    Dim mousex As Integer
    Dim mousey As Integer
    Dim drag As Boolean = False

    Private Sub DragArea_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DragArea.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub DragArea_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DragArea.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub DragArea_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DragArea.MouseUp
        drag = False
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        'Close current dialog
        Me.Close()
    End Sub

    Dim lasttab As System.Windows.Forms.Button
    Private Sub tab_MouseDown(ByVal sender As System.Windows.Forms.Button, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tab_multiplayer.MouseDown, tab_keyboard.MouseDown, _
        tab_mouse.MouseDown, tab_audio.MouseDown, tab_video.MouseDown, tab_voice.MouseDown
        TabEffect(sender)
        If sender Is tab_multiplayer Then
            Options_TabControl.SelectTab(0)
        ElseIf sender Is tab_keyboard Then
            Options_TabControl.SelectTab(1)
        ElseIf sender Is tab_mouse Then
            Options_TabControl.SelectTab(2)
        ElseIf sender Is tab_audio Then
            Options_TabControl.SelectTab(3)
        ElseIf sender Is tab_video Then
            Options_TabControl.SelectTab(4)
        ElseIf sender Is tab_voice Then
            Options_TabControl.SelectTab(5)
        End If
    End Sub

    Private Sub OptionsDialog_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Set last tab for tabeffect to work properly
        lasttab = tab_multiplayer
        combobox_crosshair.Items.Add("crosss")
        combobox_crosshair.Items.Add("r")
        combobox_crosshair.Items.Add("test")
        combobox_crosshair.SelectedIndex = 0
    End Sub

    'TabEffect
    Private Sub TabEffect(ByVal sender As System.Windows.Forms.Button)
        If lasttab IsNot sender Then
            sender.FlatAppearance.BorderColor = sender.BackColor
            sender.SetBounds(sender.Left, sender.Top - 2, sender.Width, sender.Height + 2)
            lasttab = sender
        End If
        For Each paneltab In Me.Controls.OfType(Of System.Windows.Forms.Button)()
            If paneltab IsNot sender And paneltab.Height = sender.Height Then
                ''MessageBox.Show(paneltab.ToString)
                paneltab.FlatAppearance.BorderColor = Color.DimGray
                paneltab.SetBounds(paneltab.Left, paneltab.Top + 2, paneltab.Width, paneltab.Height - 2)
            End If
        Next
    End Sub

    'Rounded Form Edges
    Private Sub frmmain_Paint(ByVal sender As Object, _
    ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim gp As New System.Drawing.Drawing2D.GraphicsPath
        Dim chgcorn As Integer = 20  'Change the value and get the 
        'desired Rounded corner, 
        'keep in mind that the value should be divisible by 10.

        ' check whether the entered number is divisible by 10 or not, 
        ' if not then make it.
        If chgcorn Mod 10 <> 0 Then
            chgcorn = chgcorn - (chgcorn Mod 10)
        End If

        Dim r1 As New Rectangle(0, Me.Height - chgcorn, chgcorn, chgcorn)
        Dim r2 As New Rectangle(Me.Width - chgcorn - 1, _
        Me.Height - chgcorn, chgcorn, chgcorn)

        'creating the upper Arc
        gp.AddArc(0, 0, chgcorn, chgcorn, 180, 90)
        gp.AddArc(Me.Width - chgcorn - 1, 0, chgcorn, chgcorn, 270, 90)

        'Creating the Body
        gp.AddRectangle(New Rectangle(0, chgcorn / 2, Me.Width, Me.Height - chgcorn))

        'Creating the lower Arc
        gp.AddArc(r1, -270, 90)
        gp.AddArc(r2, 360, 90)

        Me.BackColor = Color.DimGray
        Region = New Region(gp)
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

    Private Sub UpdateCrosshairImage(ByVal sender As Object, ByVal e As System.EventArgs) Handles _
        slider_blue.ValueChanged, slider_green.ValueChanged, slider_red.ValueChanged, _
        CheckBox1.CheckedChanged, combobox_crosshair.SelectedValueChanged
        Dim x As Integer
        Dim y As Integer
        Dim alpha As Byte
        Dim trans As Byte
        Dim imgfile As String

        If CheckBox1.Checked Then
            trans = 100
        Else
            trans = 255
        End If

        imgfile = "C:\Users\techy\Documents\" & combobox_crosshair.SelectedItem & ".png"

        Dim img As Bitmap = New Bitmap(imgfile)
        Dim clr As New Color
        clr = Color.FromArgb(trans, slider_red.Value, slider_green.Value, slider_blue.Value)
        For x = 0 To img.Width - 1
            For y = 0 To img.Height - 1
                alpha = img.GetPixel(x, y).A
                If alpha = 255 Then
                    img.SetPixel(x, y, clr)
                End If
            Next
        Next

        picturebox_crosshair.Image = img
    End Sub
End Class