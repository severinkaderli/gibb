Public Class Form1

    Private Sub btnPlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlus.Click
        setText(sender)
        txtResult.Text = Val(txtVal1.Text) + Val(txtVal2.Text)
    End Sub

    Private Sub btnMinus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinus.Click
        setText(sender)
        txtResult.Text = txtVal1.Text - txtVal2.Text
    End Sub

    Private Sub btnDurch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDurch.Click
        setText(sender)
        txtResult.Text = txtVal1.Text / txtVal2.Text
    End Sub

    Private Sub btnBackslash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackslash.Click
        setText(sender)
        txtResult.Text = txtVal1.Text \ txtVal2.Text
    End Sub

    Private Sub btnMal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMal.Click
        setText(sender)
        txtResult.Text = txtVal1.Text * txtVal2.Text
    End Sub

    Private Sub btnHoch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHoch.Click
        setText(sender)
        txtResult.Text = txtVal1.Text ^ txtVal2.Text
    End Sub

    Private Sub btnMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMod.Click
        setText(sender)
        txtResult.Text = txtVal1.Text Mod txtVal2.Text
    End Sub

    Private Sub btnVerbindung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerbindung.Click
        setText(sender)
        txtResult.Text = txtVal1.Text & txtVal2.Text
    End Sub

    Private Sub btnGleich_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGleich.Click
        setText(sender)
        txtResult.Text = txtVal1.Text + txtVal2.Text
    End Sub

    Private Sub btnKleiner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKleiner.Click
        setText(sender)
        txtResult.Text = txtVal1.Text < txtVal2.Text
    End Sub

    Private Sub btnGroesser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGroesser.Click
        setText(sender)
        txtResult.Text = txtVal1.Text > txtVal2.Text
    End Sub

    Private Sub btnLike_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLike.Click
        setText(sender)
        txtResult.Text = txtVal1.Text Like txtVal2.Text
    End Sub

    Private Sub btnAnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnd.Click
        setText(sender)
        txtResult.Text = txtVal1.Text And txtVal2.Text
    End Sub

    Private Sub btnOr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOr.Click
        setText(sender)
        txtResult.Text = txtVal1.Text Or txtVal2.Text
    End Sub

    Private Sub setText(ByVal sender As System.Object)
        Dim y As Integer = Val(sender.Text)
        lblOperator.Text = sender.Text
        txtBinary.Text = Format(CLng(Convert.ToString(y, 2)), "0000 0000 0000 0000")
    End Sub

    ' Private Sub btnXor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
    '    btnAnd.Click, btnBackslash.Click, btnBackslash.Click, btnGleich.Click, btnGroesser.Click, btnHoch.Click, btnKleiner.Click, btnLike.Click, _
    '   btnLike.Click, btnMal.Click, btnMinus.Click, btnMinus.Click, btnMod.Click, btnNot.Click, btnOr.Click, btnPlus.Click, btnVerbindung.Click, btnXor.Click
    '  setText(sender)
    ' Dim operator = sender.Text
    'txtResult.Text = txtVal1.Text & operator txtVal2.Text
    'End Operator
End Class
