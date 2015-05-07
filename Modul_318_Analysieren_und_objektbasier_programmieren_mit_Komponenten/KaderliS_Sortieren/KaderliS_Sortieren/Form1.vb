Public Class frmSortierprogramm

    Dim time As New Stopwatch

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnSort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSort.Click, mnuEditSort.Click
        Dim strSort As String = txtInput.Text

        'Change cursor to loading icon
        Me.Cursor = Windows.Forms.Cursors.WaitCursor

        'Start timer
        time.Start()

        'Ripplesort
        If optRipple.Checked And Not chkUmlaut.Checked Then
            rippleSort(strSort)
        ElseIf optRipple.Checked And chkUmlaut.Checked Then
            rippleSortUmlaut(strSort)
        End If

        'Quicksort
        If optQuick.Checked And Not chkUmlaut.Checked Then
            quickSort(strSort, 1, strSort.Length)
        ElseIf optQuick.Checked And chkUmlaut.Checked Then
            quickSortUmlaut(strSort, 1, strSort.Length)
        End If

        'Bubblesort
        If optBubble.Checked And Not chkUmlaut.Checked Then
            bubbleSort(strSort)
        ElseIf optBubble.Checked And chkUmlaut.Checked Then
            bubbleSortUmlaut(strSort)
        End If

        'Insertionsort
        If optInsertion.Checked And Not chkUmlaut.Checked Then
            insertionSort(strSort)
        ElseIf optInsertion.Checked And chkUmlaut.Checked Then
            insertionSortUmlaut(strSort)
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

    Private Sub mnuDateiNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDateiNew.Click
        txtInput.Text = ""
        txtSorted.Text = ""
    End Sub

    Private Sub mnuInfos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInfos.Click
        'Info feld öffnen
        AboutBox1.Show()
    End Sub

    Private Sub mnuEditCut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditCut.Click
        If TypeOf Me.ActiveControl Is TextBox Then
            Clipboard.SetDataObject(CType(Me.ActiveControl, TextBox).SelectedText)
            'Delete Text
            CType(Me.ActiveControl, TextBox).SelectedText = ""
        End If
    End Sub

    Private Sub mnuEditCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditCopy.Click
        If TypeOf Me.ActiveControl Is TextBox Then
            Clipboard.SetDataObject(CType(Me.ActiveControl, TextBox).SelectedText)
        End If
    End Sub

    Private Sub mnuEditPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditPaste.Click
        CType(Me.ActiveControl, TextBox).SelectedText = Clipboard.GetDataObject.GetData(DataFormats.Text)
    End Sub

    Private Sub mnuOptionenFarbeFormular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOptionenFarbeFormular.Click
        Dim dlgFarbe As New ColorDialog()
        dlgFarbe.Color = Me.BackColor
        dlgFarbe.ShowDialog()
        Me.BackColor = dlgFarbe.Color
    End Sub

    Private Sub mnuDateiSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDateiSave.Click
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

    Private Sub mnuDateiOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDateiOpen.Click
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

    Private Sub mnuEdit_DropDownOpening(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.DropDownOpening
        'Überprüfen ob Text in der Zwischenablage ist
        If Clipboard.GetDataObject.GetData(DataFormats.Text) = "" Then
            mnuEditPaste.Enabled = False
        Else
            mnuEditPaste.Enabled = True
        End If
        'Überprüfen ob Text ausgewählt wurde
        If TypeOf Me.ActiveControl Is TextBox Then
            If CType(Me.ActiveControl, TextBox).SelectedText = "" Then
                mnuEditCut.Enabled = False
                mnuEditCopy.Enabled = False
            Else
                mnuEditCut.Enabled = True
                mnuEditCopy.Enabled = True
            End If
        End If
    End Sub
End Class
