Public Class Form1

    ' Index des aktuellen Panels
    Dim PX As Integer

    ' Gesamtes Spielfeld inkl. Randfelder
    Dim F(14, 9) As Integer

    ' Zeile und Spalte des aktuellen Panels
    Dim PZ As Integer
    Dim PS As Integer

    ' Schwierigkeitsstufe
    Dim Stufe As Integer

    ' Eine zunächst leere Liste von Spiel-Panels
    Dim PL As New ArrayList

    ' Ein Feld von Farben für die Panels
    Dim FarbenFeld() As Color = {Color.Red,
        Color.Yellow, Color.Green, Color.Blue,
        Color.Cyan, Color.Magenta, Color.Black,
        Color.White}

    ' Konstanten für Status eines Feldpunktes
    Const Leer = -1
    Const Rand = -2

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Z, S As Integer

        ' Zufallsgenerator initialisieren
        Randomize()

        ' Feld besetzen
        For Z = 1 To 13
            F(Z, 0) = Rand
            For S = 1 To 8
                F(Z, S) = Leer
            Next S
            F(Z, 9) = Rand
        Next Z

        For S = 0 To 9
            F(14, S) = Rand
        Next S

        ' Initialisierung
        Stufe = 1
        NächstesPanel()
    End Sub

    Private Sub NächstesPanel()
        Dim Farbe As Integer
        Dim p As New Panel

        ' Neues Panel zur ArrayList hinzufügen
        PL.Add(p)

        ' Neues Panel platzieren
        p.Location = New Point(100, 80)
        p.Size = New Point(20, 20)

        ' Farbauswahl für neues Panel
        Farbe = Math.Floor(Rnd() * 8)
        p.BackColor = FarbenFeld(Farbe)

        ' Neues Panel zum Formular hinzufügen
        Controls.Add(p)

        ' Index für späteren Zugriff ermitteln
        PX = PL.Count - 1

        ' Aktuelle Zeile, Spalte
        PZ = 1
        PS = 5
    End Sub


    Private Sub AllePrüfen()
        Dim Z, S As Integer
        Dim Neben, Über As Boolean
        Neben = False
        Über = False

        ' Drei gleiche Panels nebeneinander ?
        For Z = 13 To 1 Step -1
            For S = 1 To 6
                Neben = NebenPrüfen(Z, S)
                If Neben Then Exit For
            Next S
            If Neben Then Exit For
        Next Z

        ' Drei gleiche Panels übereinander ?
        For Z = 13 To 3 Step -1
            For S = 1 To 8
                Über = ÜberPrüfen(Z, S)
                If Über Then Exit For
            Next S
            If Über Then Exit For
        Next Z

        If Neben Or Über Then
            ' Schneller
            Stufe = Stufe + 1
            timT.Interval = 5000 / (Stufe + 9)

            ' Eventuell kann jetzt noch eine Reihe
            ' entfernt werden
            AllePrüfen()
        End If
    End Sub

    ' Falls 3 Felder nebeneinander besetzt
    Private Function NebenPrüfen(ByVal Z As Integer,
            ByVal S As Integer) As Boolean
        Dim ZX, SX As Integer
        NebenPrüfen = False

        If F(Z, S) <> Leer And
                F(Z, S + 1) <> Leer And
                F(Z, S + 2) <> Leer Then

            ' Falls drei Farben gleich
            If PL(F(Z, S)).BackColor =
                    PL(F(Z, S + 1)).BackColor And
                    PL(F(Z, S)).BackColor =
                    PL(F(Z, S + 2)).BackColor Then

                For SX = S To S + 2
                    ' PL aus dem Formular löschen
                    Controls.Remove(PL(F(Z, SX)))
                    ' Feld leeren
                    F(Z, SX) = Leer

                    ' Panels oberhalb des entladenen
                    ' Panels absenken
                    ZX = Z - 1
                    Do While F(ZX, SX) <> Leer
                        PL(F(ZX, SX)).Top =
                            PL(F(ZX, SX)).Top + 20

                        ' Feld neu besetzen
                        F(ZX + 1, SX) = F(ZX, SX)
                        F(ZX, SX) = Leer
                        ZX = ZX - 1
                    Loop

                Next SX
                NebenPrüfen = True
            End If
        End If
    End Function

    ' Falls drei Felder übereinander besetzt
    Private Function ÜberPrüfen(ByVal Z As Integer,
            ByVal S As Integer) As Boolean
        Dim ZX As Integer
        ÜberPrüfen = False

        If F(Z, S) <> Leer And F(Z - 1, S) <> Leer And
                F(Z - 2, S) <> Leer Then

            ' Falls drei Farben gleich
            If PL(F(Z, S)).BackColor =
                    PL(F(Z - 1, S)).BackColor And
                    PL(F(Z, S)).BackColor =
                    PL(F(Z - 2, S)).BackColor Then

                ' 3 Panels entladen
                For ZX = Z To Z - 2 Step -1
                    ' PL aus dem Formular löschen
                    Controls.Remove(PL(F(ZX, S)))
                    ' Feld leeren
                    F(ZX, S) = Leer
                Next ZX
                ÜberPrüfen = True
            End If
        End If
    End Function

    Private Sub timT_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timT.Tick
        ' Falls es nicht mehr weiter geht
        If F(PZ + 1, PS) <> Leer Then
            ' Oberste Zeile erreicht
            If PZ = 1 Then
                timT.Enabled = False
                MessageBox.Show("Das war's")
                Exit Sub
            End If

            F(PZ, PS) = PX       ' Belegen
            AllePrüfen()
            NächstesPanel()

        Else
            ' Falls es noch weiter geht
            PL(PX).Top = PL(PX).Top + 20
            PZ = PZ + 1
        End If
    End Sub

    Private Sub cmdLinks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLinks.Click
        If F(PZ, PS - 1) = Leer Then
            PL(PX).Left = PL(PX).Left - 20
            PS = PS - 1
        End If
    End Sub

    Private Sub cmdRechts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRechts.Click
        If F(PZ, PS + 1) = Leer Then
            PL(PX).Left = PL(PX).Left + 20
            PS = PS + 1
        End If
    End Sub

    Private Sub cmdUnten_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUnten.Click
        Do While F(PZ + 1, PS) = Leer
            PL(PX).Top = PL(PX).Top + 20
            PZ = PZ + 1
        Loop
        F(PZ, PS) = PX       'Belegen
        AllePrüfen()
        NächstesPanel()
    End Sub

    Private Sub cmdPause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPause.Click
        timT.Enabled = Not timT.Enabled
    End Sub
End Class
