Public Class QuitDialog
    Dim mousex As Integer
    Dim mousey As Integer
    Dim drag As Boolean = False

    Private Sub DragArea_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DragArea.MouseDown, IconHolder.MouseDown, title_quit.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub DragArea_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DragArea.MouseMove, IconHolder.MouseMove, title_quit.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub DragArea_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DragArea.MouseUp, IconHolder.MouseUp, title_quit.MouseUp
        drag = False
    End Sub

    Private Sub btn_quitgame_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_quitgame.Click
        'Close main form, exiting application
        MainMenu.Close()
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        'Cancel and close current dialog
        Me.Close()
    End Sub

    Private Sub QuitDialog_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Show all hidden forms and controls
        For Each ctrl In MainMenu.Controls
            ctrl.Show()
        Next
        For Each frm In My.Application.OpenForms
            If frm IsNot MainMenu Then
                frm.Show()
            End If
        Next
    End Sub

    Private Sub QuitDialog_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Hide all visible forms and controls
        For Each ctrl In MainMenu.Controls
            ctrl.Hide()
        Next
        For Each frm In My.Application.OpenForms
            If frm IsNot MainMenu Then
                frm.Hide()
            End If
        Next
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
End Class