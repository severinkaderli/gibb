Public Class Form1

    Private Sub btnBeenden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBeenden.Click
        Me.Close()
    End Sub

    Private Sub drvLaufwerk_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles drvLaufwerk.SelectedIndexChanged
        dirVerzeichnis.Path = drvLaufwerk.Drive
    End Sub

    Private Sub dirVerzeichnis_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dirVerzeichnis.SelectedIndexChanged
        filDatei.Path = dirVerzeichnis.DirList(dirVerzeichnis.DirListIndex)
    End Sub

    Private Sub filDatei_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filDatei.SelectedIndexChanged
        picBild.Image = Image.FromFile(filDatei.Path & "\" & filDatei.FileName)
        lblPfad.Text = filDatei.Path & "\" & filDatei.FileName
    End Sub
End Class
