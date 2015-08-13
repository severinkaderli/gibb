' SoftIce-Automat
' (C)2014 Severin Kaderli

Public Class frmSoftIce

    Dim mstrSorte As String = "Schokolade"
    Dim msngPreis As Single = 5
    Dim mstrSize As String = "'Mittel'"
    Dim msngBezahlt As Single
    Dim msngRetour As Single

    'Das erste Eis beim Laden des Programmes vorauswählen
    Private Sub frmSoftIce_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstSorte.SelectedIndex = 0
        txtPaid.Text = "0.00"
        txtRetour.Text = "0.00"
    End Sub

    'Wenn Sorte ausgewählt wurde, die Nachrichtenzeile aktualisieren
    Private Sub lstSorte_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstSorte.SelectedIndexChanged
        mstrSorte = lstSorte.Text
        Nachricht(mstrSorte, mstrSize)
    End Sub

    'Grösse auswählen und die Nachrichtenzeile anpassen
    Private Sub optSize_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optSize1.CheckedChanged, optSize2.CheckedChanged, optSize3.CheckedChanged

        Select Case sender.Name
            Case "optSize1"
                msngPreis = 7.5
                mstrSize = "'Gross'"
            Case "optSize2"
                msngPreis = 5
                mstrSize = "'Mittel'"
            Case "optSize3"
                msngPreis = 3
                mstrSize = "'Klein'"
        End Select

        Nachricht(mstrSorte, mstrSize)
    End Sub

    'Sorte und Grösse in der Nachrichtenzeile anzeigen
    Private Sub Nachricht(ByVal Sorte As String, ByVal Size As String)

        lblAuswahl.Text = "Sie haben " & Sorte & " in der Grösse " & Size & " gewählt."
        txtPreis.Text = Format(msngPreis, "0.00")
    End Sub

    Private Sub Geldeinwurf(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGeld1.Click, btnGeld2.Click, btnGeld3.Click, btnGeld4.Click, btnGeld5.Click, btnGeld6.Click

        'Wenn Geld eingeworfen wurde, txtPaid um den neuen Wert erhöhen
        msngBezahlt += Val(sender.Tag)
        txtPaid.Text = Format(msngBezahlt, "0.00")

        'OK-Button für weitere Aktionen aktivieren, wenn genug gezahlt wurde
        If msngBezahlt >= msngPreis Then
            btnOk.Enabled = True
        End If
    End Sub

    'Eis bestellen und Retourwert berechnen
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

        If msngBezahlt - msngPreis > 0 Then
            txtRetour.Enabled = True
            msngRetour += msngBezahlt - msngPreis
            txtRetour.Text = Format(msngRetour, "0.00")
        Else
            msngRetour += 0
            txtRetour.Text = Format(msngRetour, "0.00")
        End If

        'Komponenten deaktivieren um Preisänderungen zu vermeiden
        btnOk.Enabled = False
        picEis.Visible = True
        lstSorte.Enabled = False
        optSize1.Enabled = False
        optSize2.Enabled = False
        optSize3.Enabled = False
        btnGeld1.Enabled = False
        btnGeld2.Enabled = False
        btnGeld3.Enabled = False
        btnGeld4.Enabled = False
        btnGeld5.Enabled = False
        btnGeld6.Enabled = False

        'Aufgrund der Wahl, korrektes Bild des Eis' darstellen
        Select Case mstrSorte
            Case "Schokolade"
                picEis.Image = picSchoko.Image
            Case "Vanille"
                picEis.Image = picVanille.Image
            Case "Erdbeer"
                picEis.Image = picErdbeer.Image
            Case "Haselnuss"
                picEis.Image = picHaselnuss.Image
        End Select
    End Sub

    Private Sub txtRetour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRetour.Click
        msngRetour = 0
        txtRetour.Text = Format(0, "0.00")
        txtRetour.Enabled = False
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        reset()

    End Sub

    Private Sub picEis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picEis.Click
        reset()
    End Sub

    Private Sub reset()
        lstSorte.SelectedIndex = 0
        optSize2.Checked = True
        txtPaid.Text = Format(0, "0.00")
        picEis.Image = Nothing
        btnOk.Enabled = False
        lstSorte.Enabled = True
        optSize1.Enabled = True
        optSize2.Enabled = True
        optSize3.Enabled = True
        btnGeld1.Enabled = True
        btnGeld2.Enabled = True
        btnGeld3.Enabled = True
        btnGeld4.Enabled = True
        btnGeld5.Enabled = True
        btnGeld6.Enabled = True
        msngBezahlt = 0
        picEis.Visible = False
    End Sub
End Class
