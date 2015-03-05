<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLernkontrolle
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
        Me.txtInfo = New System.Windows.Forms.TextBox()
        Me.btnDouble = New System.Windows.Forms.Button()
        Me.btnEnable = New System.Windows.Forms.Button()
        Me.btnGross = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEnde = New System.Windows.Forms.Button()
        Me.btnDisable = New System.Windows.Forms.Button()
        Me.btnKlein = New System.Windows.Forms.Button()
        Me.lblLabel = New System.Windows.Forms.Label()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.btnBorder = New System.Windows.Forms.Button()
        Me.btnNoBorder = New System.Windows.Forms.Button()
        Me.btnInvisible = New System.Windows.Forms.Button()
        Me.btnVisible = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.prgBar = New System.Windows.Forms.ProgressBar()
        Me.grpSize = New System.Windows.Forms.GroupBox()
        Me.optSizeBig = New System.Windows.Forms.RadioButton()
        Me.optSizeNormal = New System.Windows.Forms.RadioButton()
        Me.grpControls = New System.Windows.Forms.GroupBox()
        Me.lblProzent = New System.Windows.Forms.Label()
        Me.lblSchrittweite = New System.Windows.Forms.Label()
        Me.lblMs = New System.Windows.Forms.Label()
        Me.lblIntervall = New System.Windows.Forms.Label()
        Me.txtSchrittweite = New System.Windows.Forms.TextBox()
        Me.txtIntervall = New System.Windows.Forms.TextBox()
        Me.optTimerFunction = New System.Windows.Forms.RadioButton()
        Me.optTimer = New System.Windows.Forms.RadioButton()
        Me.optBarPosition = New System.Windows.Forms.RadioButton()
        Me.trkSlider = New System.Windows.Forms.TrackBar()
        Me.grpSize.SuspendLayout()
        Me.grpControls.SuspendLayout()
        CType(Me.trkSlider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtInfo
        '
        Me.txtInfo.Location = New System.Drawing.Point(13, 13)
        Me.txtInfo.Multiline = True
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.Size = New System.Drawing.Size(686, 61)
        Me.txtInfo.TabIndex = 0
        Me.txtInfo.Text = "Benutzungsfreundliche Programme nutzen die Tabulatortaste (Eigenschaft TabIndex n" & _
            "utzen)"
        '
        'btnDouble
        '
        Me.btnDouble.Location = New System.Drawing.Point(13, 81)
        Me.btnDouble.Name = "btnDouble"
        Me.btnDouble.Size = New System.Drawing.Size(230, 23)
        Me.btnDouble.TabIndex = 1
        Me.btnDouble.Text = "Text in txtText verdoppeln"
        Me.btnDouble.UseVisualStyleBackColor = True
        '
        'btnEnable
        '
        Me.btnEnable.Location = New System.Drawing.Point(480, 81)
        Me.btnEnable.Name = "btnEnable"
        Me.btnEnable.Size = New System.Drawing.Size(219, 23)
        Me.btnEnable.TabIndex = 2
        Me.btnEnable.Text = "txtText aktivieren"
        Me.btnEnable.UseVisualStyleBackColor = True
        '
        'btnGross
        '
        Me.btnGross.Location = New System.Drawing.Point(249, 80)
        Me.btnGross.Name = "btnGross"
        Me.btnGross.Size = New System.Drawing.Size(225, 23)
        Me.btnGross.TabIndex = 3
        Me.btnGross.Text = "Grosse Schriftgrösse in txtText"
        Me.btnGross.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(13, 119)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(230, 23)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Text in txtText löschen"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEnde
        '
        Me.btnEnde.Location = New System.Drawing.Point(480, 158)
        Me.btnEnde.Name = "btnEnde"
        Me.btnEnde.Size = New System.Drawing.Size(225, 23)
        Me.btnEnde.TabIndex = 5
        Me.btnEnde.Text = "Ende"
        Me.btnEnde.UseVisualStyleBackColor = True
        '
        'btnDisable
        '
        Me.btnDisable.Location = New System.Drawing.Point(480, 119)
        Me.btnDisable.Name = "btnDisable"
        Me.btnDisable.Size = New System.Drawing.Size(225, 23)
        Me.btnDisable.TabIndex = 6
        Me.btnDisable.Text = "txtText deaktivieren"
        Me.btnDisable.UseVisualStyleBackColor = True
        '
        'btnKlein
        '
        Me.btnKlein.Location = New System.Drawing.Point(249, 119)
        Me.btnKlein.Name = "btnKlein"
        Me.btnKlein.Size = New System.Drawing.Size(225, 23)
        Me.btnKlein.TabIndex = 7
        Me.btnKlein.Text = "Normale Schriftgrösse in txtText"
        Me.btnKlein.UseVisualStyleBackColor = True
        '
        'lblLabel
        '
        Me.lblLabel.AutoSize = True
        Me.lblLabel.Location = New System.Drawing.Point(246, 168)
        Me.lblLabel.Name = "lblLabel"
        Me.lblLabel.Size = New System.Drawing.Size(43, 13)
        Me.lblLabel.TabIndex = 8
        Me.lblLabel.Text = "lblLabel"
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(13, 158)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(103, 68)
        Me.txtMessage.TabIndex = 9
        Me.txtMessage.Text = "Hier angeklickte ListBox-Zeile in MessageBox anzeigen"
        '
        'btnBorder
        '
        Me.btnBorder.Location = New System.Drawing.Point(243, 250)
        Me.btnBorder.Name = "btnBorder"
        Me.btnBorder.Size = New System.Drawing.Size(225, 23)
        Me.btnBorder.TabIndex = 10
        Me.btnBorder.Text = "lblLabel mit Rand anzeigen"
        Me.btnBorder.UseVisualStyleBackColor = True
        '
        'btnNoBorder
        '
        Me.btnNoBorder.Location = New System.Drawing.Point(243, 279)
        Me.btnNoBorder.Name = "btnNoBorder"
        Me.btnNoBorder.Size = New System.Drawing.Size(225, 23)
        Me.btnNoBorder.TabIndex = 11
        Me.btnNoBorder.Text = "lblLabel ohne Rand anzeigen"
        Me.btnNoBorder.UseVisualStyleBackColor = True
        '
        'btnInvisible
        '
        Me.btnInvisible.Location = New System.Drawing.Point(243, 337)
        Me.btnInvisible.Name = "btnInvisible"
        Me.btnInvisible.Size = New System.Drawing.Size(225, 23)
        Me.btnInvisible.TabIndex = 12
        Me.btnInvisible.Text = "lblLabel unsichtbar machen"
        Me.btnInvisible.UseVisualStyleBackColor = True
        '
        'btnVisible
        '
        Me.btnVisible.Location = New System.Drawing.Point(243, 308)
        Me.btnVisible.Name = "btnVisible"
        Me.btnVisible.Size = New System.Drawing.Size(225, 23)
        Me.btnVisible.TabIndex = 13
        Me.btnVisible.Text = "lblLabel sichtbar machen"
        Me.btnVisible.UseVisualStyleBackColor = True
        '
        'btnUp
        '
        Me.btnUp.Location = New System.Drawing.Point(7, 250)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(230, 23)
        Me.btnUp.TabIndex = 14
        Me.btnUp.Text = "lstListe aufwärts schieben"
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'btnDown
        '
        Me.btnDown.Location = New System.Drawing.Point(7, 279)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(230, 23)
        Me.btnDown.TabIndex = 15
        Me.btnDown.Text = "lstListe abwärts schieben"
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'btnRight
        '
        Me.btnRight.Location = New System.Drawing.Point(7, 308)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(230, 23)
        Me.btnRight.TabIndex = 16
        Me.btnRight.Text = "lstListe nach rechts schieben"
        Me.btnRight.UseVisualStyleBackColor = True
        '
        'btnLeft
        '
        Me.btnLeft.Location = New System.Drawing.Point(7, 337)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(230, 23)
        Me.btnLeft.TabIndex = 17
        Me.btnLeft.Text = "lstListe nach links"
        Me.btnLeft.UseVisualStyleBackColor = True
        '
        'prgBar
        '
        Me.prgBar.Location = New System.Drawing.Point(7, 377)
        Me.prgBar.Name = "prgBar"
        Me.prgBar.Size = New System.Drawing.Size(692, 23)
        Me.prgBar.TabIndex = 18
        '
        'grpSize
        '
        Me.grpSize.Controls.Add(Me.optSizeBig)
        Me.grpSize.Controls.Add(Me.optSizeNormal)
        Me.grpSize.Location = New System.Drawing.Point(480, 250)
        Me.grpSize.Name = "grpSize"
        Me.grpSize.Size = New System.Drawing.Size(219, 110)
        Me.grpSize.TabIndex = 19
        Me.grpSize.TabStop = False
        Me.grpSize.Text = "Grösse des Ende-Buttons"
        '
        'optSizeBig
        '
        Me.optSizeBig.AutoSize = True
        Me.optSizeBig.Location = New System.Drawing.Point(6, 64)
        Me.optSizeBig.Name = "optSizeBig"
        Me.optSizeBig.Size = New System.Drawing.Size(52, 17)
        Me.optSizeBig.TabIndex = 1
        Me.optSizeBig.TabStop = True
        Me.optSizeBig.Text = "Gross"
        Me.optSizeBig.UseVisualStyleBackColor = True
        '
        'optSizeNormal
        '
        Me.optSizeNormal.AutoSize = True
        Me.optSizeNormal.Location = New System.Drawing.Point(7, 34)
        Me.optSizeNormal.Name = "optSizeNormal"
        Me.optSizeNormal.Size = New System.Drawing.Size(58, 17)
        Me.optSizeNormal.TabIndex = 0
        Me.optSizeNormal.TabStop = True
        Me.optSizeNormal.Text = "Normal"
        Me.optSizeNormal.UseVisualStyleBackColor = True
        '
        'grpControls
        '
        Me.grpControls.Controls.Add(Me.lblProzent)
        Me.grpControls.Controls.Add(Me.lblSchrittweite)
        Me.grpControls.Controls.Add(Me.lblMs)
        Me.grpControls.Controls.Add(Me.lblIntervall)
        Me.grpControls.Controls.Add(Me.txtSchrittweite)
        Me.grpControls.Controls.Add(Me.txtIntervall)
        Me.grpControls.Controls.Add(Me.optTimerFunction)
        Me.grpControls.Controls.Add(Me.optTimer)
        Me.grpControls.Controls.Add(Me.optBarPosition)
        Me.grpControls.Location = New System.Drawing.Point(7, 459)
        Me.grpControls.Name = "grpControls"
        Me.grpControls.Size = New System.Drawing.Size(692, 89)
        Me.grpControls.TabIndex = 20
        Me.grpControls.TabStop = False
        Me.grpControls.Text = "GroupBox2"
        '
        'lblProzent
        '
        Me.lblProzent.AutoSize = True
        Me.lblProzent.Location = New System.Drawing.Point(638, 45)
        Me.lblProzent.Name = "lblProzent"
        Me.lblProzent.Size = New System.Drawing.Size(15, 13)
        Me.lblProzent.TabIndex = 8
        Me.lblProzent.Text = "%"
        '
        'lblSchrittweite
        '
        Me.lblSchrittweite.AutoSize = True
        Me.lblSchrittweite.Location = New System.Drawing.Point(473, 46)
        Me.lblSchrittweite.Name = "lblSchrittweite"
        Me.lblSchrittweite.Size = New System.Drawing.Size(62, 13)
        Me.lblSchrittweite.TabIndex = 7
        Me.lblSchrittweite.Text = "Schrittweite"
        '
        'lblMs
        '
        Me.lblMs.AutoSize = True
        Me.lblMs.Location = New System.Drawing.Point(428, 47)
        Me.lblMs.Name = "lblMs"
        Me.lblMs.Size = New System.Drawing.Size(20, 13)
        Me.lblMs.TabIndex = 6
        Me.lblMs.Text = "ms"
        '
        'lblIntervall
        '
        Me.lblIntervall.AutoSize = True
        Me.lblIntervall.Location = New System.Drawing.Point(287, 46)
        Me.lblIntervall.Name = "lblIntervall"
        Me.lblIntervall.Size = New System.Drawing.Size(44, 13)
        Me.lblIntervall.TabIndex = 5
        Me.lblIntervall.Text = "Intervall"
        '
        'txtSchrittweite
        '
        Me.txtSchrittweite.Location = New System.Drawing.Point(534, 42)
        Me.txtSchrittweite.Name = "txtSchrittweite"
        Me.txtSchrittweite.Size = New System.Drawing.Size(100, 20)
        Me.txtSchrittweite.TabIndex = 4
        '
        'txtIntervall
        '
        Me.txtIntervall.Location = New System.Drawing.Point(330, 43)
        Me.txtIntervall.Name = "txtIntervall"
        Me.txtIntervall.Size = New System.Drawing.Size(100, 20)
        Me.txtIntervall.TabIndex = 3
        '
        'optTimerFunction
        '
        Me.optTimerFunction.AutoSize = True
        Me.optTimerFunction.Location = New System.Drawing.Point(5, 66)
        Me.optTimerFunction.Name = "optTimerFunction"
        Me.optTimerFunction.Size = New System.Drawing.Size(139, 17)
        Me.optTimerFunction.TabIndex = 2
        Me.optTimerFunction.TabStop = True
        Me.optTimerFunction.Text = "Timer-Funktion bestimmt"
        Me.optTimerFunction.UseVisualStyleBackColor = True
        '
        'optTimer
        '
        Me.optTimer.AutoSize = True
        Me.optTimer.Location = New System.Drawing.Point(6, 43)
        Me.optTimer.Name = "optTimer"
        Me.optTimer.Size = New System.Drawing.Size(158, 17)
        Me.optTimer.TabIndex = 1
        Me.optTimer.TabStop = True
        Me.optTimer.Text = "Timer-Komponente bestimmt"
        Me.optTimer.UseVisualStyleBackColor = True
        '
        'optBarPosition
        '
        Me.optBarPosition.AutoSize = True
        Me.optBarPosition.Location = New System.Drawing.Point(7, 20)
        Me.optBarPosition.Name = "optBarPosition"
        Me.optBarPosition.Size = New System.Drawing.Size(192, 17)
        Me.optBarPosition.TabIndex = 0
        Me.optBarPosition.TabStop = True
        Me.optBarPosition.Text = "Trackbarschieber bestimmt Position"
        Me.optBarPosition.UseVisualStyleBackColor = True
        '
        'trkSlider
        '
        Me.trkSlider.Location = New System.Drawing.Point(7, 407)
        Me.trkSlider.Name = "trkSlider"
        Me.trkSlider.Size = New System.Drawing.Size(692, 45)
        Me.trkSlider.TabIndex = 21
        '
        'frmLernkontrolle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 554)
        Me.Controls.Add(Me.trkSlider)
        Me.Controls.Add(Me.grpControls)
        Me.Controls.Add(Me.grpSize)
        Me.Controls.Add(Me.prgBar)
        Me.Controls.Add(Me.btnLeft)
        Me.Controls.Add(Me.btnRight)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.btnVisible)
        Me.Controls.Add(Me.btnInvisible)
        Me.Controls.Add(Me.btnNoBorder)
        Me.Controls.Add(Me.btnBorder)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.lblLabel)
        Me.Controls.Add(Me.btnKlein)
        Me.Controls.Add(Me.btnDisable)
        Me.Controls.Add(Me.btnEnde)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnGross)
        Me.Controls.Add(Me.btnEnable)
        Me.Controls.Add(Me.btnDouble)
        Me.Controls.Add(Me.txtInfo)
        Me.Name = "frmLernkontrolle"
        Me.Text = "Lernkontrolle"
        Me.grpSize.ResumeLayout(False)
        Me.grpSize.PerformLayout()
        Me.grpControls.ResumeLayout(False)
        Me.grpControls.PerformLayout()
        CType(Me.trkSlider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtInfo As System.Windows.Forms.TextBox
    Friend WithEvents btnDouble As System.Windows.Forms.Button
    Friend WithEvents btnEnable As System.Windows.Forms.Button
    Friend WithEvents btnGross As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEnde As System.Windows.Forms.Button
    Friend WithEvents btnDisable As System.Windows.Forms.Button
    Friend WithEvents btnKlein As System.Windows.Forms.Button
    Friend WithEvents lblLabel As System.Windows.Forms.Label
    Friend WithEvents txtMessage As System.Windows.Forms.TextBox
    Friend WithEvents btnBorder As System.Windows.Forms.Button
    Friend WithEvents btnNoBorder As System.Windows.Forms.Button
    Friend WithEvents btnInvisible As System.Windows.Forms.Button
    Friend WithEvents btnVisible As System.Windows.Forms.Button
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents btnRight As System.Windows.Forms.Button
    Friend WithEvents btnLeft As System.Windows.Forms.Button
    Friend WithEvents prgBar As System.Windows.Forms.ProgressBar
    Friend WithEvents grpSize As System.Windows.Forms.GroupBox
    Friend WithEvents optSizeBig As System.Windows.Forms.RadioButton
    Friend WithEvents optSizeNormal As System.Windows.Forms.RadioButton
    Friend WithEvents grpControls As System.Windows.Forms.GroupBox
    Friend WithEvents lblProzent As System.Windows.Forms.Label
    Friend WithEvents lblSchrittweite As System.Windows.Forms.Label
    Friend WithEvents lblMs As System.Windows.Forms.Label
    Friend WithEvents lblIntervall As System.Windows.Forms.Label
    Friend WithEvents txtSchrittweite As System.Windows.Forms.TextBox
    Friend WithEvents txtIntervall As System.Windows.Forms.TextBox
    Friend WithEvents optTimerFunction As System.Windows.Forms.RadioButton
    Friend WithEvents optTimer As System.Windows.Forms.RadioButton
    Friend WithEvents optBarPosition As System.Windows.Forms.RadioButton
    Friend WithEvents trkSlider As System.Windows.Forms.TrackBar

End Class
