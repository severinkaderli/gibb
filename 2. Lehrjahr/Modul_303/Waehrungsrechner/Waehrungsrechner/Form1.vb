Public Class Form1

    Private Sub Berechnen()
        Dim Kurs As Double
        Dim CHF As Double
        Kurs = Val(txtKurs.Text)
        CHF = Val(txtCHF.Text)
        If Kurs > 0 Then
            lblErgebnis.Text = "Sie erhalten " & Format(CHF / Kurs, "0.00") & " Dollar!"
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKurs.TextChanged
        Berechnen()
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCHF.TextChanged
        Berechnen()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        End
    End Sub

End Class
