Public Class FlatCombo
    Inherits ComboBox

    Private BorderBrush As Brush = New SolidBrush(Color.DimGray)
    Private ArrowBrush As Brush = New SolidBrush(Color.White)
    Private DropButtonBrush As Brush = New SolidBrush(SystemColors.Control)
    Private _ButtonColor As Color = SystemColors.Control

    Public Property ButtonColor() As Color
        Get
            Return _ButtonColor
        End Get
        Set(ByVal Value As Color)
            _ButtonColor = Value
            DropButtonBrush = New SolidBrush(Me.ButtonColor)
            Me.Invalidate()
        End Set
    End Property

    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)

        Select Case m.Msg
            Case &HF
                'Paint the background. Only the borders
                'will show up because the edit
                'box will be overlayed
                Dim g As Graphics = Me.CreateGraphics
                Dim p As Pen = New Pen(Color.White, 2)
                Dim p2 As Pen = New Pen(Color.DimGray, 5)
                '
                g.FillRectangle(BorderBrush, Me.Width - 20, 0, 20, Me.Height)
                g.DrawRectangle(p2, Me.ClientRectangle)

                'Draw the background of the dropdown button
                Dim rect As Rectangle = New Rectangle(Me.Width - 15, 3, 12, Me.Height - 6)
                g.FillRectangle(DropButtonBrush, rect)

                'Create the path for the arrow
                Dim pth As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
                Dim TopLeft As PointF = New PointF(Me.Width - 13, (Me.Height - 5) / 2)
                Dim TopRight As PointF = New PointF(Me.Width - 6, (Me.Height - 5) / 2)
                Dim Bottom As PointF = New PointF(Me.Width - 9, (Me.Height + 2) / 2)
                pth.AddLine(TopLeft, TopRight)
                pth.AddLine(TopRight, Bottom)

                g.SmoothingMode = Drawing2D.SmoothingMode.HighQuality

                'Determine the arrow's color.
                If Me.DroppedDown Then
                    ArrowBrush = New SolidBrush(Color.White)
                Else
                    ArrowBrush = New SolidBrush(Color.Gray)
                End If

                'Draw the arrow
                g.FillPath(ArrowBrush, pth)

            Case Else
                Exit Select
        End Select
    End Sub
End Class
