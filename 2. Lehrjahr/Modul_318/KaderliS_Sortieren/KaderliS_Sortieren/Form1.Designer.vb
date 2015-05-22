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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSortierprogramm))
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
        Me.tlbDateiNew = New System.Windows.Forms.ToolStripButton()
        Me.tlbDateiOpen = New System.Windows.Forms.ToolStripButton()
        Me.tlbDateiSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlbEditCut = New System.Windows.Forms.ToolStripButton()
        Me.tlbEditCopy = New System.Windows.Forms.ToolStripButton()
        Me.tlbEditPaste = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlbSort = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlbInfoAbout = New System.Windows.Forms.ToolStripButton()
        Me.tlbToolbar = New System.Windows.Forms.ToolStrip()
        Me.tmrTimer = New System.Windows.Forms.Timer(Me.components)
        Me.optChar = New System.Windows.Forms.RadioButton()
        Me.optWord = New System.Windows.Forms.RadioButton()
        Me.grpAlgorithm = New System.Windows.Forms.GroupBox()
        Me.grpSort = New System.Windows.Forms.GroupBox()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.grpSorttime = New System.Windows.Forms.GroupBox()
        Me.mnuMenu.SuspendLayout()
        Me.tlbToolbar.SuspendLayout()
        Me.grpAlgorithm.SuspendLayout()
        Me.grpSort.SuspendLayout()
        Me.grpOptions.SuspendLayout()
        Me.grpSorttime.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(12, 52)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInput.Size = New System.Drawing.Size(524, 190)
        Me.txtInput.TabIndex = 0
        '
        'txtSorted
        '
        Me.txtSorted.Location = New System.Drawing.Point(12, 251)
        Me.txtSorted.Multiline = True
        Me.txtSorted.Name = "txtSorted"
        Me.txtSorted.ReadOnly = True
        Me.txtSorted.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSorted.Size = New System.Drawing.Size(524, 182)
        Me.txtSorted.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(547, 410)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Beenden"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSort
        '
        Me.btnSort.Location = New System.Drawing.Point(547, 381)
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
        Me.optRipple.Location = New System.Drawing.Point(6, 42)
        Me.optRipple.Name = "optRipple"
        Me.optRipple.Size = New System.Drawing.Size(55, 17)
        Me.optRipple.TabIndex = 5
        Me.optRipple.Text = "Ripple"
        Me.optRipple.UseVisualStyleBackColor = True
        '
        'optQuick
        '
        Me.optQuick.AutoSize = True
        Me.optQuick.Location = New System.Drawing.Point(6, 88)
        Me.optQuick.Name = "optQuick"
        Me.optQuick.Size = New System.Drawing.Size(53, 17)
        Me.optQuick.TabIndex = 8
        Me.optQuick.Text = "Quick"
        Me.optQuick.UseVisualStyleBackColor = True
        '
        'chkUmlaut
        '
        Me.chkUmlaut.AutoSize = True
        Me.chkUmlaut.Location = New System.Drawing.Point(6, 19)
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
        Me.optBubble.Location = New System.Drawing.Point(6, 19)
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
        Me.optInsertion.Location = New System.Drawing.Point(6, 65)
        Me.optInsertion.Name = "optInsertion"
        Me.optInsertion.Size = New System.Drawing.Size(65, 17)
        Me.optInsertion.TabIndex = 11
        Me.optInsertion.Text = "Insertion"
        Me.optInsertion.UseVisualStyleBackColor = True
        '
        'txtSorttime
        '
        Me.txtSorttime.Enabled = False
        Me.txtSorttime.Location = New System.Drawing.Point(6, 19)
        Me.txtSorttime.Name = "txtSorttime"
        Me.txtSorttime.ReadOnly = True
        Me.txtSorttime.Size = New System.Drawing.Size(65, 20)
        Me.txtSorttime.TabIndex = 13
        Me.txtSorttime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSec
        '
        Me.lblSec.AutoSize = True
        Me.lblSec.Location = New System.Drawing.Point(77, 22)
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
        'tlbDateiNew
        '
        Me.tlbDateiNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlbDateiNew.Image = CType(resources.GetObject("tlbDateiNew.Image"), System.Drawing.Image)
        Me.tlbDateiNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbDateiNew.Name = "tlbDateiNew"
        Me.tlbDateiNew.Size = New System.Drawing.Size(23, 22)
        Me.tlbDateiNew.Text = "ToolStripButton1"
        Me.tlbDateiNew.ToolTipText = "Neu"
        '
        'tlbDateiOpen
        '
        Me.tlbDateiOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlbDateiOpen.Image = CType(resources.GetObject("tlbDateiOpen.Image"), System.Drawing.Image)
        Me.tlbDateiOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbDateiOpen.Name = "tlbDateiOpen"
        Me.tlbDateiOpen.Size = New System.Drawing.Size(23, 22)
        Me.tlbDateiOpen.Text = "ToolStripButton1"
        Me.tlbDateiOpen.ToolTipText = "Öffnen"
        '
        'tlbDateiSave
        '
        Me.tlbDateiSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlbDateiSave.Image = CType(resources.GetObject("tlbDateiSave.Image"), System.Drawing.Image)
        Me.tlbDateiSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbDateiSave.Name = "tlbDateiSave"
        Me.tlbDateiSave.Size = New System.Drawing.Size(23, 22)
        Me.tlbDateiSave.Text = "ToolStripButton1"
        Me.tlbDateiSave.ToolTipText = "Speichern"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tlbEditCut
        '
        Me.tlbEditCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlbEditCut.Image = CType(resources.GetObject("tlbEditCut.Image"), System.Drawing.Image)
        Me.tlbEditCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbEditCut.Name = "tlbEditCut"
        Me.tlbEditCut.Size = New System.Drawing.Size(23, 22)
        Me.tlbEditCut.Text = "ToolStripButton1"
        Me.tlbEditCut.ToolTipText = "Ausschneiden"
        '
        'tlbEditCopy
        '
        Me.tlbEditCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlbEditCopy.Image = CType(resources.GetObject("tlbEditCopy.Image"), System.Drawing.Image)
        Me.tlbEditCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbEditCopy.Name = "tlbEditCopy"
        Me.tlbEditCopy.Size = New System.Drawing.Size(23, 22)
        Me.tlbEditCopy.Text = "ToolStripButton1"
        Me.tlbEditCopy.ToolTipText = "Kopieren"
        '
        'tlbEditPaste
        '
        Me.tlbEditPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlbEditPaste.Image = CType(resources.GetObject("tlbEditPaste.Image"), System.Drawing.Image)
        Me.tlbEditPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbEditPaste.Name = "tlbEditPaste"
        Me.tlbEditPaste.Size = New System.Drawing.Size(23, 22)
        Me.tlbEditPaste.Text = "ToolStripButton1"
        Me.tlbEditPaste.ToolTipText = "Einfügen"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tlbSort
        '
        Me.tlbSort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlbSort.Image = CType(resources.GetObject("tlbSort.Image"), System.Drawing.Image)
        Me.tlbSort.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbSort.Name = "tlbSort"
        Me.tlbSort.Size = New System.Drawing.Size(23, 22)
        Me.tlbSort.Text = "ToolStripButton1"
        Me.tlbSort.ToolTipText = "Sortieren"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tlbInfoAbout
        '
        Me.tlbInfoAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlbInfoAbout.Image = CType(resources.GetObject("tlbInfoAbout.Image"), System.Drawing.Image)
        Me.tlbInfoAbout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbInfoAbout.Name = "tlbInfoAbout"
        Me.tlbInfoAbout.Size = New System.Drawing.Size(23, 22)
        Me.tlbInfoAbout.Text = "ToolStripButton1"
        Me.tlbInfoAbout.ToolTipText = "Info"
        '
        'tlbToolbar
        '
        Me.tlbToolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlbDateiNew, Me.tlbDateiOpen, Me.tlbDateiSave, Me.ToolStripSeparator1, Me.tlbEditCut, Me.tlbEditCopy, Me.tlbEditPaste, Me.ToolStripSeparator2, Me.tlbSort, Me.ToolStripSeparator3, Me.tlbInfoAbout})
        Me.tlbToolbar.Location = New System.Drawing.Point(0, 24)
        Me.tlbToolbar.Name = "tlbToolbar"
        Me.tlbToolbar.Size = New System.Drawing.Size(674, 25)
        Me.tlbToolbar.TabIndex = 16
        Me.tlbToolbar.Text = "ToolStrip1"
        '
        'tmrTimer
        '
        Me.tmrTimer.Enabled = True
        '
        'optChar
        '
        Me.optChar.AutoSize = True
        Me.optChar.Checked = True
        Me.optChar.Location = New System.Drawing.Point(6, 19)
        Me.optChar.Name = "optChar"
        Me.optChar.Size = New System.Drawing.Size(91, 17)
        Me.optChar.TabIndex = 17
        Me.optChar.TabStop = True
        Me.optChar.Text = "nach Zeichen"
        Me.optChar.UseVisualStyleBackColor = True
        '
        'optWord
        '
        Me.optWord.AutoSize = True
        Me.optWord.Location = New System.Drawing.Point(6, 42)
        Me.optWord.Name = "optWord"
        Me.optWord.Size = New System.Drawing.Size(84, 17)
        Me.optWord.TabIndex = 18
        Me.optWord.Text = "nach Wörter"
        Me.optWord.UseVisualStyleBackColor = True
        '
        'grpAlgorithm
        '
        Me.grpAlgorithm.Controls.Add(Me.optQuick)
        Me.grpAlgorithm.Controls.Add(Me.optInsertion)
        Me.grpAlgorithm.Controls.Add(Me.optRipple)
        Me.grpAlgorithm.Controls.Add(Me.optBubble)
        Me.grpAlgorithm.Location = New System.Drawing.Point(551, 52)
        Me.grpAlgorithm.Name = "grpAlgorithm"
        Me.grpAlgorithm.Size = New System.Drawing.Size(113, 115)
        Me.grpAlgorithm.TabIndex = 19
        Me.grpAlgorithm.TabStop = False
        Me.grpAlgorithm.Text = "Algorithmus"
        '
        'grpSort
        '
        Me.grpSort.Controls.Add(Me.optWord)
        Me.grpSort.Controls.Add(Me.optChar)
        Me.grpSort.Location = New System.Drawing.Point(551, 173)
        Me.grpSort.Name = "grpSort"
        Me.grpSort.Size = New System.Drawing.Size(113, 69)
        Me.grpSort.TabIndex = 20
        Me.grpSort.TabStop = False
        Me.grpSort.Text = "Sortierart"
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.chkUmlaut)
        Me.grpOptions.Location = New System.Drawing.Point(551, 251)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(113, 48)
        Me.grpOptions.TabIndex = 21
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Optionen"
        '
        'grpSorttime
        '
        Me.grpSorttime.Controls.Add(Me.txtSorttime)
        Me.grpSorttime.Controls.Add(Me.lblSec)
        Me.grpSorttime.Location = New System.Drawing.Point(551, 306)
        Me.grpSorttime.Name = "grpSorttime"
        Me.grpSorttime.Size = New System.Drawing.Size(113, 55)
        Me.grpSorttime.TabIndex = 22
        Me.grpSorttime.TabStop = False
        Me.grpSorttime.Text = "Sortierzeit"
        '
        'frmSortierprogramm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 445)
        Me.Controls.Add(Me.grpSorttime)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.grpSort)
        Me.Controls.Add(Me.grpAlgorithm)
        Me.Controls.Add(Me.tlbToolbar)
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
        Me.tlbToolbar.ResumeLayout(False)
        Me.tlbToolbar.PerformLayout()
        Me.grpAlgorithm.ResumeLayout(False)
        Me.grpAlgorithm.PerformLayout()
        Me.grpSort.ResumeLayout(False)
        Me.grpSort.PerformLayout()
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.grpSorttime.ResumeLayout(False)
        Me.grpSorttime.PerformLayout()
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
    Friend WithEvents tlbDateiNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbDateiOpen As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbDateiSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlbEditCut As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbEditCopy As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbEditPaste As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlbSort As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlbInfoAbout As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbToolbar As System.Windows.Forms.ToolStrip
    Friend WithEvents tmrTimer As System.Windows.Forms.Timer
    Friend WithEvents optChar As System.Windows.Forms.RadioButton
    Friend WithEvents optWord As System.Windows.Forms.RadioButton
    Friend WithEvents grpAlgorithm As System.Windows.Forms.GroupBox
    Friend WithEvents grpSort As System.Windows.Forms.GroupBox
    Friend WithEvents grpOptions As System.Windows.Forms.GroupBox
    Friend WithEvents grpSorttime As System.Windows.Forms.GroupBox

End Class
