Public Class frmSortierprogramm

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnSort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSort.Click, mnuEditSort.Click, tlbSort.Click
        Dim time As New Stopwatch
        Dim strSort As String = txtInput.Text
        Dim Wort() As String

        'Start timer
        time.Start()

        'Change cursor to loading icon
        Me.Cursor = Windows.Forms.Cursors.WaitCursor

        If optWord.Checked Then
            'Wörter aus dem String auslesen
            WorteLesen(strSort, Wort)
        End If

        'Ripplesort
        If optRipple.Checked And Not chkUmlaut.Checked Then
            If optWord.Checked Then
                rippleWort(Wort)
            Else
                rippleSort(strSort)
            End If
        ElseIf optRipple.Checked And chkUmlaut.Checked Then
            If optWord.Checked Then
                rippleWortUmlaut(Wort)
            Else
                rippleSortUmlaut(strSort)
            End If
        End If

        'Quicksort
        If optQuick.Checked And Not chkUmlaut.Checked Then
            If optWord.Checked Then
                quickWort(Wort, 0, Wort.Length - 1)
            Else
                quickSort(strSort, 1, strSort.Length)
            End If
        ElseIf optQuick.Checked And chkUmlaut.Checked Then
            If optWord.Checked Then
                quickWortUmlaut(Wort, 0, Wort.Length - 1)
            Else
                quickSortUmlaut(strSort, 1, strSort.Length)
            End If
        End If

        'Bubblesort
        If optBubble.Checked And Not chkUmlaut.Checked Then
            If optWord.Checked Then
                bubbleWort(Wort)
            Else
                bubbleSort(strSort)
            End If
        ElseIf optBubble.Checked And chkUmlaut.Checked Then
            If optWord.Checked Then
                bubbleWortUmlaut(Wort)
            Else
                bubbleSortUmlaut(strSort)
            End If
        End If

        'Insertionsort
        If optInsertion.Checked And Not chkUmlaut.Checked Then
            If optWord.Checked Then
                insertionWort(Wort)
            Else
                insertionSort(strSort)
            End If

        ElseIf optInsertion.Checked And chkUmlaut.Checked Then
            If optWord.Checked Then
                insertionWortUmlaut(Wort)
            Else
                insertionSortUmlaut(strSort)
            End If
        End If

        'Worte zurück in String schreiben
        If optWord.Checked Then
            WorteSchreiben(strSort, Wort)
        End If
        txtSorted.Text = strSort

        Me.Cursor = Windows.Forms.Cursors.Default

        'Display time and reset timer
        txtSorttime.Text = CStr(time.ElapsedMilliseconds / 1000)
        time.Reset()
    End Sub

    Private Sub mnuDateiExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDateiExit.Click
        Me.Close()
        End
    End Sub

    Private Sub mnuDateiNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDateiNew.Click, tlbDateiNew.Click
        txtInput.Text = ""
        txtSorted.Text = ""
    End Sub

    Private Sub mnuInfos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInfos.Click, tlbInfoAbout.Click
        'Info feld öffnen
        AboutBox1.Show()
    End Sub

    Private Sub mnuEditCut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditCut.Click, tlbEditCut.Click
        If TypeOf Me.ActiveControl Is TextBox Then
            Clipboard.SetDataObject(CType(Me.ActiveControl, TextBox).SelectedText)
            'Delete Text
            CType(Me.ActiveControl, TextBox).SelectedText = ""
        End If
    End Sub

    Private Sub mnuEditCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditCopy.Click, tlbEditCopy.Click
        If TypeOf Me.ActiveControl Is TextBox Then
            Clipboard.SetDataObject(CType(Me.ActiveControl, TextBox).SelectedText)
        End If
    End Sub

    Private Sub mnuEditPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditPaste.Click, tlbEditPaste.Click
        If TypeOf Me.ActiveControl Is TextBox Then
            CType(Me.ActiveControl, TextBox).SelectedText = Clipboard.GetDataObject.GetData(DataFormats.Text)
        End If
    End Sub

    Private Sub mnuOptionenFarbeFormular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOptionenFarbeFormular.Click
        Dim dlgFarbe As New ColorDialog()
        dlgFarbe.Color = Me.BackColor
        dlgFarbe.ShowDialog()
        Me.BackColor = dlgFarbe.Color
    End Sub

    Private Sub mnuDateiSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDateiSave.Click, tlbDateiSave.Click
        Dim intDateiHandle As Integer
        Dim strDateiInhalt As String
        Dim dlgSaveFile As New SaveFileDialog()
        'Message anzeigen, wenn kein Text zum speichern vorhanden ist
        If txtSorted.Text = "" Then
            MsgBox("Kein Sortierter Text zum Speichern vorhanden", MsgBoxStyle.Information)
            Exit Sub
        End If

        dlgSaveFile.Filter = "Text Dateien(*.txt) | *.txt | Alle Dateien (*.*) | *.*"
        dlgSaveFile.FilterIndex = 1
        dlgSaveFile.RestoreDirectory = True
        If dlgSaveFile.ShowDialog = DialogResult.OK Then
            intDateiHandle = FreeFile()
            FileOpen(intDateiHandle, dlgSaveFile.FileName, OpenMode.Binary)
            strDateiInhalt = txtSorted.Text
            FilePut(intDateiHandle, strDateiInhalt, 1)
            FileClose(intDateiHandle)
        End If
    End Sub

    Private Sub mnuDateiOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDateiOpen.Click, tlbDateiOpen.Click
        Dim intDateiHandle As Integer
        Dim strDateiInhalt As String
        Dim dlgSaveFile As New OpenFileDialog()


        dlgSaveFile.Filter = "Text Dateien(*.txt)|*.txt|Alle Dateien (*.*)|*.*"
        dlgSaveFile.FilterIndex = 1
        dlgSaveFile.RestoreDirectory = True
        If dlgSaveFile.ShowDialog = DialogResult.OK Then
            intDateiHandle = FreeFile()
            FileOpen(intDateiHandle, dlgSaveFile.FileName, OpenMode.Binary)
            strDateiInhalt = Space(LOF(intDateiHandle))
            FileGet(intDateiHandle, strDateiInhalt, 1)
            txtInput.Text = strDateiInhalt
            txtSorted.Text = ""
            FileClose(intDateiHandle)
        End If
    End Sub

    Private Sub chkUmlaut_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkUmlaut.CheckedChanged
        If chkUmlaut.Checked Then
            mnuOptionenUmlaute.Checked = True
        Else
            mnuOptionenUmlaute.Checked = False
        End If
    End Sub

    Private Sub mnuOptionenUmlaute_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOptionenUmlaute.CheckedChanged
        If mnuOptionenUmlaute.Checked Then
            chkUmlaut.Checked = True
        Else
            chkUmlaut.Checked = False
        End If
    End Sub

    Private Sub mnuOptionenFarbeTextbox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOptionenFarbeTextbox.Click
        Dim dlgFarbe As New ColorDialog()
        dlgFarbe.Color = txtInput.BackColor
        dlgFarbe.ShowDialog()
        txtInput.BackColor = dlgFarbe.Color
        txtSorted.BackColor = dlgFarbe.Color
    End Sub

    'Überprüfen, ob die Toolbar Buttons aktiviert sein sollen
    Private Sub mnuEdit_DropDownOpening(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.DropDownOpening, tmrTimer.Tick
        'Überprüfen ob Text in der Zwischenablage ist
        If Clipboard.GetDataObject.GetData(DataFormats.Text) = "" Then
            mnuEditPaste.Enabled = False
            tlbEditPaste.Enabled = False
        Else
            mnuEditPaste.Enabled = True
            tlbEditPaste.Enabled = True
        End If
        'Überprüfen ob Text ausgewählt wurde
        If TypeOf Me.ActiveControl Is TextBox Then
            If CType(Me.ActiveControl, TextBox).SelectedText = "" Then
                mnuEditCut.Enabled = False
                mnuEditCopy.Enabled = False
                tlbEditCopy.Enabled = False
                tlbEditCut.Enabled = False
            Else
                mnuEditCut.Enabled = True
                mnuEditCopy.Enabled = True
                tlbEditCopy.Enabled = True
                tlbEditCut.Enabled = True
            End If
        End If
    End Sub
End Class
