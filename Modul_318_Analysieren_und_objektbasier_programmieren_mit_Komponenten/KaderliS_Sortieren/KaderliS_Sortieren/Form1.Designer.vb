<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSortierprogramm
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.txtSorted = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.optRipple = New System.Windows.Forms.RadioButton()
        Me.optQuick = New System.Windows.Forms.RadioButton()
        Me.chkUmlaut = New System.Windows.Forms.CheckBox()
        Me.optBubble = New System.Windows.Forms.RadioButton()
        Me.optInsertion = New System.Windows.Forms.RadioButton()
        Me.lblSorttime = New System.Windows.Forms.Label()
        Me.txtSorttime = New System.Windows.Forms.TextBox()
        Me.lblSec = New System.Windows.Forms.Label()
        Me.mnuMenu = New System.Windows.Forms.MenuStrip()
        Me.mnuDatei = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDateiNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDateiOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuDateiSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuDateiExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuEditSort = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionenUmlaute = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuOptionenFarbe = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionenFarbeFormular = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionenFarbeTextbox = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInfos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(12, 27)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInput.Size = New System.Drawing.Size(524, 198)
        Me.txtInput.TabIndex = 0
        '
        'txtSorted
        '
        Me.txtSorted.Location = New System.Drawing.Point(12, 229)
        Me.txtSorted.Multiline = True
        Me.txtSorted.Name = "txtSorted"
        Me.txtSorted.ReadOnly = True
        Me.txtSorted.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSorted.Size = New System.Drawing.Size(524, 184)
        Me.txtSorted.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(545, 390)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Beenden"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSort
        '
        Me.btnSort.Location = New System.Drawing.Point(545, 361)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(75, 23)
        Me.btnSort.TabIndex = 3
        Me.btnSort.Text = "Sortieren"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(12, 423)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(0, 13)
        Me.lblTime.TabIndex = 4
        '
        'optRipple
        '
        Me.optRipple.AutoSize = True
        Me.optRipple.Location = New System.Drawing.Point(545, 52)
        Me.optRipple.Name = "optRipple"
        Me.optRipple.Size = New System.Drawing.Size(55, 17)
        Me.optRipple.TabIndex = 5
        Me.optRipple.Text = "Ripple"
        Me.optRipple.UseVisualStyleBackColor = True
        '
        'optQuick
        '
        Me.optQuick.AutoSize = True
        Me.optQuick.Location = New System.Drawing.Point(545, 98)
        Me.optQuick.Name = "optQuick"
        Me.optQuick.Size = New System.Drawing.Size(53, 17)
        Me.optQuick.TabIndex = 8
        Me.optQuick.Text = "Quick"
        Me.optQuick.UseVisualStyleBackColor = True
        '
        'chkUmlaut
        '
        Me.chkUmlaut.AutoSize = True
        Me.chkUmlaut.Location = New System.Drawing.Point(549, 188)
        Me.chkUmlaut.Name = "chkUmlaut"
        Me.chkUmlaut.Size = New System.Drawing.Size(65, 17)
        Me.chkUmlaut.TabIndex = 9
        Me.chkUmlaut.Text = "Umlaute"
        Me.chkUmlaut.UseVisualStyleBackColor = True
        '
        'optBubble
        '
        Me.optBubble.AutoSize = True
        Me.optBubble.Checked = True
        Me.optBubble.Location = New System.Drawing.Point(545, 30)
        Me.optBubble.Name = "optBubble"
        Me.optBubble.Size = New System.Drawing.Size(58, 17)
        Me.optBubble.TabIndex = 10
        Me.optBubble.TabStop = True
        Me.optBubble.Text = "Bubble"
        Me.optBubble.UseVisualStyleBackColor = True
        '
        'optInsertion
        '
        Me.optInsertion.AutoSize = True
        Me.optInsertion.Location = New System.Drawing.Point(545, 75)
        Me.optInsertion.Name = "optInsertion"
        Me.optInsertion.Size = New System.Drawing.Size(65, 17)
        Me.optInsertion.TabIndex = 11
        Me.optInsertion.Text = "Insertion"
        Me.optInsertion.UseVisualStyleBackColor = True
        '
        'lblSorttime
        '
        Me.lblSorttime.AutoSize = True
        Me.lblSorttime.Location = New System.Drawing.Point(542, 212)
        Me.lblSorttime.Name = "lblSorttime"
        Me.lblSorttime.Size = New System.Drawing.Size(53, 13)
        Me.lblSorttime.TabIndex = 12
        Me.lblSorttime.Text = "Sortierzeit"
        '
        'txtSorttime
        '
        Me.txtSorttime.Enabled = False
        Me.txtSorttime.Location = New System.Drawing.Point(543, 229)
        Me.txtSorttime.Name = "txtSorttime"
        Me.txtSorttime.ReadOnly = True
        Me.txtSorttime.Size = New System.Drawing.Size(77, 20)
        Me.txtSorttime.TabIndex = 13
        Me.txtSorttime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSec
        '
        Me.lblSec.AutoSize = True
        Me.lblSec.Location = New System.Drawing.Point(621, 233)
        Me.lblSec.Name = "lblSec"
        Me.lblSec.Size = New System.Drawing.Size(29, 13)
        Me.lblSec.TabIndex = 14
        Me.lblSec.Text = "Sek."
        '
        'mnuMenu
        '
        Me.mnuMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDatei, Me.mnuEdit, Me.mnuOptionen, Me.mnuInfos})
        Me.mnuMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenu.Name = "mnuMenu"
        Me.mnuMenu.Size = New System.Drawing.Size(674, 24)
        Me.mnuMenu.TabIndex = 15
        Me.mnuMenu.Text = "MenuStrip1"
        '
        'mnuDatei
        '
        Me.mnuDatei.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDateiNew, Me.mnuDateiOpen, Me.ToolStripMenuItem1, Me.mnuDateiSave, Me.ToolStripMenuItem2, Me.mnuDateiExit})
        Me.mnuDatei.Name = "mnuDatei"
        Me.mnuDatei.Size = New System.Drawing.Size(46, 20)
        Me.mnuDatei.Text = "Datei"
        '
        'mnuDateiNew
        '
        Me.mnuDateiNew.Name = "mnuDateiNew"
        Me.mnuDateiNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuDateiNew.Size = New System.Drawing.Size(168, 22)
        Me.mnuDateiNew.Text = "Neu"
        '
        'mnuDateiOpen
        '
        Me.mnuDateiOpen.Name = "mnuDateiOpen"
        Me.mnuDateiOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuDateiOpen.Size = New System.Drawing.Size(168, 22)
        Me.mnuDateiOpen.Text = "Öffnen"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(165, 6)
        '
        'mnuDateiSave
        '
        Me.mnuDateiSave.Name = "mnuDateiSave"
        Me.mnuDateiSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuDateiSave.Size = New System.Drawing.Size(168, 22)
        Me.mnuDateiSave.Text = "Speichern"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(165, 6)
        '
        'mnuDateiExit
        '
        Me.mnuDateiExit.Name = "mnuDateiExit"
        Me.mnuDateiExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.mnuDateiExit.Size = New System.Drawing.Size(168, 22)
        Me.mnuDateiExit.Text = "Beenden"
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEditCut, Me.mnuEditCopy, Me.mnuEditPaste, Me.ToolStripMenuItem3, Me.mnuEditSort})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(75, 20)
        Me.mnuEdit.Text = "Bearbeiten"
        '
        'mnuEditCut
        '
        Me.mnuEditCut.Name = "mnuEditCut"
        Me.mnuEditCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuEditCut.Size = New System.Drawing.Size(191, 22)
        Me.mnuEditCut.Text = "Ausschneiden"
        '
        'mnuEditCopy
        '
        Me.mnuEditCopy.Name = "mnuEditCopy"
        Me.mnuEditCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuEditCopy.Size = New System.Drawing.Size(191, 22)
        Me.mnuEditCopy.Text = "Kopieren"
        '
        'mnuEditPaste
        '
        Me.mnuEditPaste.Name = "mnuEditPaste"
        Me.mnuEditPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.mnuEditPaste.Size = New System.Drawing.Size(191, 22)
        Me.mnuEditPaste.Text = "Einfügen"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(188, 6)
        '
        'mnuEditSort
        '
        Me.mnuEditSort.Name = "mnuEditSort"
        Me.mnuEditSort.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.mnuEditSort.Size = New System.Drawing.Size(191, 22)
        Me.mnuEditSort.Text = "Sortieren"
        '
        'mnuOptionen
        '
        Me.mnuOptionen.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOptionenUmlaute, Me.ToolStripMenuItem4, Me.mnuOptionenFarbe})
        Me.mnuOptionen.Name = "mnuOptionen"
        Me.mnuOptionen.Size = New System.Drawing.Size(69, 20)
        Me.mnuOptionen.Text = "Optionen"
        '
        'mnuOptionenUmlaute
        '
        Me.mnuOptionenUmlaute.CheckOnClick = True
        Me.mnuOptionenUmlaute.Name = "mnuOptionenUmlaute"
        Me.mnuOptionenUmlaute.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.mnuOptionenUmlaute.Size = New System.Drawing.Size(163, 22)
        Me.mnuOptionenUmlaute.Text = "Umlaute"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(160, 6)
        '
        'mnuOptionenFarbe
        '
        Me.mnuOptionenFarbe.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOptionenFarbeFormular, Me.mnuOptionenFarbeTextbox})
        Me.mnuOptionenFarbe.Name = "mnuOptionenFarbe"
        Me.mnuOptionenFarbe.Size = New System.Drawing.Size(163, 22)
        Me.mnuOptionenFarbe.Text = "Farbe"
        '
        'mnuOptionenFarbeFormular
        '
        Me.mnuOptionenFarbeFormular.Name = "mnuOptionenFarbeFormular"
        Me.mnuOptionenFarbeFormular.Size = New System.Drawing.Size(122, 22)
        Me.mnuOptionenFarbeFormular.Text = "Formular"
        '
        'mnuOptionenFarbeTextbox
        '
        Me.mnuOptionenFarbeTextbox.Name = "mnuOptionenFarbeTextbox"
        Me.mnuOptionenFarbeTextbox.Size = New System.Drawing.Size(122, 22)
        Me.mnuOptionenFarbeTextbox.Text = "Textbox"
        '
        'mnuInfos
        '
        Me.mnuInfos.Name = "mnuInfos"
        Me.mnuInfos.Size = New System.Drawing.Size(45, 20)
        Me.mnuInfos.Text = "Infos"
        '
        'frmSortierprogramm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 445)
        Me.Controls.Add(Me.lblSec)
        Me.Controls.Add(Me.txtSorttime)
        Me.Controls.Add(Me.lblSorttime)
        Me.Controls.Add(Me.optInsertion)
        Me.Controls.Add(Me.optBubble)
        Me.Controls.Add(Me.chkUmlaut)
        Me.Controls.Add(Me.optQuick)
        Me.Controls.Add(Me.optRipple)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtSorted)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.mnuMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.mnuMenu
        Me.MaximizeBox = False
        Me.Name = "frmSortierprogramm"
        Me.Text = "Sortierprogramm Version 3 - (c) 2015  Severin Kaderli"
        Me.mnuMenu.ResumeLayout(False)
        Me.mnuMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents txtSorted As System.Windows.Forms.TextBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSort As System.Windows.Forms.Button
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents optRipple As System.Windows.Forms.RadioButton
    Friend WithEvents optQuick As System.Windows.Forms.RadioButton
    Friend WithEvents chkUmlaut As System.Windows.Forms.CheckBox
    Friend WithEvents optBubble As System.Windows.Forms.RadioButton
    Friend WithEvents optInsertion As System.Windows.Forms.RadioButton
    Friend WithEvents lblSorttime As System.Windows.Forms.Label
    Friend WithEvents txtSorttime As System.Windows.Forms.TextBox
    Friend WithEvents lblSec As System.Windows.Forms.Label
    Friend WithEvents mnuMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuDatei As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOptionen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuInfos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDateiNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDateiOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuDateiSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuDateiExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEditCut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEditCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEditPaste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuEditSort As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOptionenUmlaute As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuOptionenFarbe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOptionenFarbeFormular As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOptionenFarbeTextbox As System.Windows.Forms.ToolStripMenuItem

End Class
