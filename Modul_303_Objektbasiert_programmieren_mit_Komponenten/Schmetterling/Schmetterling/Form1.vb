Public Class frmSchmetterling

    'Startrichtung
    Public direction As String = "Up"

    Private Sub tmrSchmetterling_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrSchmetterling.Tick

        Static offen As Boolean


        If offen Then
            picFlug.Image = picFluegelZu.Image
        Else
            picFlug.Image = picFluegelOffen.Image
        End If

        'Richtung ändern
        If direction = "Up" Then
            picFlug.Location = New Point(picFlug.Location.X, picFlug.Location.Y - 50)
        ElseIf direction = "Down" Then
            picFlug.Location = New Point(picFlug.Location.X, picFlug.Location.Y + 50)
        ElseIf direction = "Right" Then
            picFlug.Location = New Point(picFlug.Location.X + 50, picFlug.Location.Y)
        Else
            picFlug.Location = New Point(picFlug.Location.X - 50, picFlug.Location.Y)
        End If

        'Aus dem Fenster fliegen
        If picFlug.Location.X > Me.ClientSize.Width Then
            picFlug.Location = New Point(0, picFlug.Location.Y)
        ElseIf picFlug.Location.X < 0 - picFlug.Width Then
            picFlug.Location = New Point(Me.ClientSize.Width, picFlug.Location.Y)
        ElseIf picFlug.Location.Y < 0 - picFlug.Height Then
            picFlug.Location = New Point(picFlug.Location.X, Me.ClientSize.Height)
        ElseIf picFlug.Location.Y > Me.ClientSize.Height Then
            picFlug.Location = New Point(picFlug.Location.X, 0)
        End If
        offen = Not offen
    End Sub

    Private Sub picFlug_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picFlug.Click
        picFlug.Hide()
    End Sub

    Private Sub frmSchmetterling_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click
        picFlug.Show()
    End Sub

    Private Sub frmSchmetterling_Load(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown, MyBase.Load

        'Geschwindigkeit anpassen
        If e.Button = MouseButtons.Left Then
            tmrSchmetterling.Interval = 25
        ElseIf e.Button = MouseButtons.Right Then
            tmrSchmetterling.Interval = 750
        End If
    End Sub

    Private Sub frmSchmetterling_Load_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        tmrSchmetterling.Interval = 200
    End Sub

    Private Sub frmSchmetterling_Load_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Up Then
            direction = "Up"
        ElseIf e.KeyCode = Keys.Down Then
            direction = "Down"
        ElseIf e.KeyCode = Keys.Left Then
            direction = "Left"
        ElseIf e.KeyCode = Keys.Right Then
            direction = "Right"
        End If
    End Sub

End Class
