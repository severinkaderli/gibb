Public Class form1
    Private Sub Form_Doubleclick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.DoubleClick
        txtAusgabe.Text += "Doppelklick" & vbCrLf
    End Sub

    Private Sub Form_Mouseclick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseClick

        txtAusgabe.Text += "Klick" & vbCrLf

        If e.Button = MouseButtons.Left Then
            txtAusgabe.Text += "linke Maustaste runter" & vbCrLf
        ElseIf e.Button = MouseButtons.Right Then
            txtAusgabe.Text += "rechte Maustaste runter" & vbCrLf
        ElseIf e.Button = MouseButtons.Middle Then
            txtAusgabe.Text += "mittlere Maustaste runter" & vbCrLf
        End If
    End Sub

    Private Sub Form_Mouserelease(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = MouseButtons.Left Then
            txtAusgabe.Text += "linke Maustaste hoch" & vbCrLf
        ElseIf e.Button = MouseButtons.Right Then
            txtAusgabe.Text += "rechte Maustaste hoch" & vbCrLf
        ElseIf e.Button = MouseButtons.Middle Then
            txtAusgabe.Text += "mittlere Maustaste hoch" & vbCrLf
        End If
    End Sub

    Private Sub Form_Keydown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        txtAusgabe.Text += "Taste runter" & vbCrLf
    End Sub

    Private Sub Form_Keyup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        txtAusgabe.Text += "Taste hoch" & vbCrLf
    End Sub

    Private Sub Form_Keyup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress

        txtAusgabe.Text += e.KeyChar & " gedrückt" & vbCrLf
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        Form2.Show()
    End Sub
End Class
