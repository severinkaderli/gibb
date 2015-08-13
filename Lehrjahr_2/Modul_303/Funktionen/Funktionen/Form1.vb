Public Class frmUhr
    Dim g As Graphics
    Dim p As Pen
    Dim intX, intY As Integer
    Dim intX0, intY0, intH As Integer
    Dim intFactor As Integer

    Private Sub tmrTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTimer.Tick
        g = picUhr.CreateGraphics
        g.Clear(Color.LightGray)

        'Sekundenzeiger
        Zeiger(6, 2, Me.Height / 3, Second(Microsoft.VisualBasic.TimeOfDay))

        'Minutenzeiger
        Zeiger(6, 3, Me.Height / 3, Minute(Microsoft.VisualBasic.TimeOfDay))

        'Stundenzeiger
        Zeiger(30, 3, Me.Height / 4, Hour(Microsoft.VisualBasic.TimeOfDay))

    End Sub

    Sub Zeiger(ByVal sngDegrees As Single, ByVal intZeigerbreite As Integer, ByVal sngZeigerLaenge As Single, ByVal intZeitwert As Integer)
        p = New Pen(Color.Black, intZeigerbreite)
        intX = Math.Cos((intZeitwert - 15) * Math.PI * sngDegrees / 180) * sngZeigerLaenge
        intY = Math.Sin((intZeitwert - 15) * Math.PI * sngDegrees / 180) * sngZeigerLaenge
        g.DrawLine(p, intX0, intY0, intX + intX0, intY + intY0)
        Me.Text = "Uhr [" & Microsoft.VisualBasic.TimeOfDay & "]"
    End Sub


    Private Sub frmUhr_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tmrTimer.Interval = 1000
        tmrTimer.Enabled = True
        picUhr.Width = Me.Width
        picUhr.Height = Me.Height
        picUhr.BackColor = Color.DarkGray
        picUhr.Location = New Point(0, -20)
        intFactor = Me.Height / 2.5
        intX0 = Me.Width / 2
        intY0 = Me.Height / 2
    End Sub
End Class
