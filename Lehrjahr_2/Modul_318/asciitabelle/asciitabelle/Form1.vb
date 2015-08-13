Public Class frmAscii

    Dim strFunktion As String = ""

    Private Sub lstFunktion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles lstFunktion.SelectedIndexChanged

        strFunktion = lstFunktion.Text
    End Sub

    Sub whileloop()
        Dim intCode As Integer = 32
        While intCode <= 255
            writeCode(intCode)
            intCode += 1
        End While
    End Sub

    Sub forloop()
        For i = 32 To 255
            writeCode(i)
        Next

    End Sub

    Sub untilloop()
        Dim intCode As Integer = 32
        Do
            writeCode(intCode)
            intCode += 1
        Loop Until intCode > 255

    End Sub

    Sub writeCode(ByVal code)
        If code = 32 Then
            txtTabelle.Text = "Die Folgende Tabelle wurde mit " & strFunktion & " erstellt" & vbCrLf
        End If
        txtTabelle.Text += Format(code, "000") & " " & Chr(code) & " "
        If (code - 31) Mod 11 = 0 Then
            txtTabelle.Text += vbCrLf
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If lstFunktion.SelectedIndex = 0 Then
            forloop()
        ElseIf lstFunktion.SelectedIndex = 1 Then
            whileloop()
        Else
            untilloop()
        End If
    End Sub
End Class