<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSoftIce
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSoftIce))
        Me.lstSorte = New System.Windows.Forms.ListBox()
        Me.lblAuswahl = New System.Windows.Forms.Label()
        Me.lblSorte = New System.Windows.Forms.Label()
        Me.picEis = New System.Windows.Forms.PictureBox()
        Me.optSize1 = New System.Windows.Forms.RadioButton()
        Me.optSize2 = New System.Windows.Forms.RadioButton()
        Me.optSize3 = New System.Windows.Forms.RadioButton()
        Me.grpGroesse = New System.Windows.Forms.GroupBox()
        Me.lblPreis = New System.Windows.Forms.Label()
        Me.txtPreis = New System.Windows.Forms.TextBox()
        Me.txtPaid = New System.Windows.Forms.TextBox()
        Me.lblPaid = New System.Windows.Forms.Label()
        Me.txtRetour = New System.Windows.Forms.TextBox()
        Me.lblRetour = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnGeld1 = New System.Windows.Forms.Button()
        Me.btnGeld2 = New System.Windows.Forms.Button()
        Me.btnGeld3 = New System.Windows.Forms.Button()
        Me.btnGeld4 = New System.Windows.Forms.Button()
        Me.btnGeld5 = New System.Windows.Forms.Button()
        Me.btnGeld6 = New System.Windows.Forms.Button()
        Me.picVanille = New System.Windows.Forms.PictureBox()
        Me.picHaselnuss = New System.Windows.Forms.PictureBox()
        Me.picSchoko = New System.Windows.Forms.PictureBox()
        Me.picErdbeer = New System.Windows.Forms.PictureBox()
        CType(Me.picEis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGroesse.SuspendLayout()
        CType(Me.picVanille, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHaselnuss, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSchoko, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picErdbeer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstSorte
        '
        Me.lstSorte.FormattingEnabled = True
        Me.lstSorte.Items.AddRange(New Object() {"Schokolade", "Erdbeer", "Haselnuss", "Vanille"})
        Me.lstSorte.Location = New System.Drawing.Point(12, 61)
        Me.lstSorte.Name = "lstSorte"
        Me.lstSorte.Size = New System.Drawing.Size(195, 173)
        Me.lstSorte.TabIndex = 0
        '
        'lblAuswahl
        '
        Me.lblAuswahl.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblAuswahl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAuswahl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuswahl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblAuswahl.Location = New System.Drawing.Point(12, 9)
        Me.lblAuswahl.Name = "lblAuswahl"
        Me.lblAuswahl.Size = New System.Drawing.Size(476, 27)
        Me.lblAuswahl.TabIndex = 1
        Me.lblAuswahl.Text = "Bitte wählen Sie eine Sorte!"
        Me.lblAuswahl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSorte
        '
        Me.lblSorte.AutoSize = True
        Me.lblSorte.Location = New System.Drawing.Point(15, 45)
        Me.lblSorte.Name = "lblSorte"
        Me.lblSorte.Size = New System.Drawing.Size(32, 13)
        Me.lblSorte.TabIndex = 2
        Me.lblSorte.Text = "Sorte"
        '
        'picEis
        '
        Me.picEis.Location = New System.Drawing.Point(12, 241)
        Me.picEis.Name = "picEis"
        Me.picEis.Size = New System.Drawing.Size(317, 199)
        Me.picEis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picEis.TabIndex = 3
        Me.picEis.TabStop = False
        Me.picEis.Visible = False
        '
        'optSize1
        '
        Me.optSize1.AutoSize = True
        Me.optSize1.Location = New System.Drawing.Point(6, 19)
        Me.optSize1.Name = "optSize1"
        Me.optSize1.Size = New System.Drawing.Size(52, 17)
        Me.optSize1.TabIndex = 4
        Me.optSize1.TabStop = True
        Me.optSize1.Text = "Gross"
        Me.optSize1.UseVisualStyleBackColor = True
        '
        'optSize2
        '
        Me.optSize2.AutoSize = True
        Me.optSize2.Checked = True
        Me.optSize2.Location = New System.Drawing.Point(6, 42)
        Me.optSize2.Name = "optSize2"
        Me.optSize2.Size = New System.Drawing.Size(50, 17)
        Me.optSize2.TabIndex = 5
        Me.optSize2.TabStop = True
        Me.optSize2.Text = "Mittel"
        Me.optSize2.UseVisualStyleBackColor = True
        '
        'optSize3
        '
        Me.optSize3.AutoSize = True
        Me.optSize3.Location = New System.Drawing.Point(6, 65)
        Me.optSize3.Name = "optSize3"
        Me.optSize3.Size = New System.Drawing.Size(48, 17)
        Me.optSize3.TabIndex = 6
        Me.optSize3.TabStop = True
        Me.optSize3.Text = "Klein"
        Me.optSize3.UseVisualStyleBackColor = True
        '
        'grpGroesse
        '
        Me.grpGroesse.Controls.Add(Me.optSize1)
        Me.grpGroesse.Controls.Add(Me.optSize3)
        Me.grpGroesse.Controls.Add(Me.optSize2)
        Me.grpGroesse.Location = New System.Drawing.Point(214, 61)
        Me.grpGroesse.Name = "grpGroesse"
        Me.grpGroesse.Size = New System.Drawing.Size(115, 173)
        Me.grpGroesse.TabIndex = 7
        Me.grpGroesse.TabStop = False
        Me.grpGroesse.Text = "Grösse"
        '
        'lblPreis
        '
        Me.lblPreis.AutoSize = True
        Me.lblPreis.Location = New System.Drawing.Point(359, 61)
        Me.lblPreis.Name = "lblPreis"
        Me.lblPreis.Size = New System.Drawing.Size(30, 13)
        Me.lblPreis.TabIndex = 8
        Me.lblPreis.Text = "Preis"
        '
        'txtPreis
        '
        Me.txtPreis.Enabled = False
        Me.txtPreis.Location = New System.Drawing.Point(362, 80)
        Me.txtPreis.Name = "txtPreis"
        Me.txtPreis.Size = New System.Drawing.Size(100, 20)
        Me.txtPreis.TabIndex = 9
        '
        'txtPaid
        '
        Me.txtPaid.Enabled = False
        Me.txtPaid.Location = New System.Drawing.Point(362, 126)
        Me.txtPaid.Name = "txtPaid"
        Me.txtPaid.Size = New System.Drawing.Size(100, 20)
        Me.txtPaid.TabIndex = 11
        '
        'lblPaid
        '
        Me.lblPaid.AutoSize = True
        Me.lblPaid.Location = New System.Drawing.Point(359, 105)
        Me.lblPaid.Name = "lblPaid"
        Me.lblPaid.Size = New System.Drawing.Size(42, 13)
        Me.lblPaid.TabIndex = 10
        Me.lblPaid.Text = "Bezahlt"
        '
        'txtRetour
        '
        Me.txtRetour.Enabled = False
        Me.txtRetour.HideSelection = False
        Me.txtRetour.Location = New System.Drawing.Point(362, 165)
        Me.txtRetour.Name = "txtRetour"
        Me.txtRetour.Size = New System.Drawing.Size(100, 20)
        Me.txtRetour.TabIndex = 13
        '
        'lblRetour
        '
        Me.lblRetour.AutoSize = True
        Me.lblRetour.Location = New System.Drawing.Point(359, 149)
        Me.lblRetour.Name = "lblRetour"
        Me.lblRetour.Size = New System.Drawing.Size(39, 13)
        Me.lblRetour.TabIndex = 12
        Me.lblRetour.Text = "Retour"
        '
        'btnOk
        '
        Me.btnOk.Enabled = False
        Me.btnOk.Location = New System.Drawing.Point(362, 359)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(100, 31)
        Me.btnOk.TabIndex = 14
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(362, 407)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(100, 30)
        Me.btnReset.TabIndex = 15
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnGeld1
        '
        Me.btnGeld1.Location = New System.Drawing.Point(362, 210)
        Me.btnGeld1.Name = "btnGeld1"
        Me.btnGeld1.Size = New System.Drawing.Size(10, 118)
        Me.btnGeld1.TabIndex = 16
        Me.btnGeld1.Tag = "5"
        Me.btnGeld1.Text = "Button1"
        Me.btnGeld1.UseVisualStyleBackColor = True
        '
        'btnGeld2
        '
        Me.btnGeld2.Location = New System.Drawing.Point(378, 237)
        Me.btnGeld2.Name = "btnGeld2"
        Me.btnGeld2.Size = New System.Drawing.Size(10, 90)
        Me.btnGeld2.TabIndex = 17
        Me.btnGeld2.Tag = "2"
        Me.btnGeld2.Text = "Button2"
        Me.btnGeld2.UseVisualStyleBackColor = True
        '
        'btnGeld3
        '
        Me.btnGeld3.Location = New System.Drawing.Point(394, 253)
        Me.btnGeld3.Name = "btnGeld3"
        Me.btnGeld3.Size = New System.Drawing.Size(10, 75)
        Me.btnGeld3.TabIndex = 18
        Me.btnGeld3.Tag = "1"
        Me.btnGeld3.Text = "Button3"
        Me.btnGeld3.UseVisualStyleBackColor = True
        '
        'btnGeld4
        '
        Me.btnGeld4.Location = New System.Drawing.Point(410, 284)
        Me.btnGeld4.Name = "btnGeld4"
        Me.btnGeld4.Size = New System.Drawing.Size(10, 44)
        Me.btnGeld4.TabIndex = 19
        Me.btnGeld4.Tag = "0.5"
        Me.btnGeld4.Text = "Button4"
        Me.btnGeld4.UseVisualStyleBackColor = True
        '
        'btnGeld5
        '
        Me.btnGeld5.Location = New System.Drawing.Point(426, 265)
        Me.btnGeld5.Name = "btnGeld5"
        Me.btnGeld5.Size = New System.Drawing.Size(10, 63)
        Me.btnGeld5.TabIndex = 20
        Me.btnGeld5.Tag = "0.2"
        Me.btnGeld5.Text = "Button5"
        Me.btnGeld5.UseVisualStyleBackColor = True
        '
        'btnGeld6
        '
        Me.btnGeld6.Location = New System.Drawing.Point(442, 274)
        Me.btnGeld6.Name = "btnGeld6"
        Me.btnGeld6.Size = New System.Drawing.Size(10, 54)
        Me.btnGeld6.TabIndex = 21
        Me.btnGeld6.Tag = "0.1"
        Me.btnGeld6.Text = "Button6"
        Me.btnGeld6.UseVisualStyleBackColor = True
        '
        'picVanille
        '
        Me.picVanille.Image = CType(resources.GetObject("picVanille.Image"), System.Drawing.Image)
        Me.picVanille.Location = New System.Drawing.Point(124, 309)
        Me.picVanille.Name = "picVanille"
        Me.picVanille.Size = New System.Drawing.Size(100, 50)
        Me.picVanille.TabIndex = 22
        Me.picVanille.TabStop = False
        Me.picVanille.Visible = False
        '
        'picHaselnuss
        '
        Me.picHaselnuss.Image = CType(resources.GetObject("picHaselnuss.Image"), System.Drawing.Image)
        Me.picHaselnuss.Location = New System.Drawing.Point(124, 253)
        Me.picHaselnuss.Name = "picHaselnuss"
        Me.picHaselnuss.Size = New System.Drawing.Size(100, 50)
        Me.picHaselnuss.TabIndex = 23
        Me.picHaselnuss.TabStop = False
        Me.picHaselnuss.Visible = False
        '
        'picSchoko
        '
        Me.picSchoko.Image = CType(resources.GetObject("picSchoko.Image"), System.Drawing.Image)
        Me.picSchoko.Location = New System.Drawing.Point(18, 309)
        Me.picSchoko.Name = "picSchoko"
        Me.picSchoko.Size = New System.Drawing.Size(100, 50)
        Me.picSchoko.TabIndex = 24
        Me.picSchoko.TabStop = False
        Me.picSchoko.Visible = False
        '
        'picErdbeer
        '
        Me.picErdbeer.Image = CType(resources.GetObject("picErdbeer.Image"), System.Drawing.Image)
        Me.picErdbeer.Location = New System.Drawing.Point(18, 253)
        Me.picErdbeer.Name = "picErdbeer"
        Me.picErdbeer.Size = New System.Drawing.Size(100, 50)
        Me.picErdbeer.TabIndex = 25
        Me.picErdbeer.TabStop = False
        Me.picErdbeer.Visible = False
        '
        'frmSoftIce
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(500, 452)
        Me.Controls.Add(Me.picErdbeer)
        Me.Controls.Add(Me.picSchoko)
        Me.Controls.Add(Me.picHaselnuss)
        Me.Controls.Add(Me.picVanille)
        Me.Controls.Add(Me.btnGeld6)
        Me.Controls.Add(Me.btnGeld5)
        Me.Controls.Add(Me.btnGeld4)
        Me.Controls.Add(Me.btnGeld3)
        Me.Controls.Add(Me.btnGeld2)
        Me.Controls.Add(Me.btnGeld1)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.txtRetour)
        Me.Controls.Add(Me.lblRetour)
        Me.Controls.Add(Me.txtPaid)
        Me.Controls.Add(Me.lblPaid)
        Me.Controls.Add(Me.txtPreis)
        Me.Controls.Add(Me.lblPreis)
        Me.Controls.Add(Me.grpGroesse)
        Me.Controls.Add(Me.picEis)
        Me.Controls.Add(Me.lblSorte)
        Me.Controls.Add(Me.lblAuswahl)
        Me.Controls.Add(Me.lstSorte)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSoftIce"
        Me.Text = "  SoftIce-Automat (C) 2014 by Severin Kaderli"
        CType(Me.picEis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGroesse.ResumeLayout(False)
        Me.grpGroesse.PerformLayout()
        CType(Me.picVanille, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHaselnuss, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSchoko, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picErdbeer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstSorte As System.Windows.Forms.ListBox
    Friend WithEvents lblAuswahl As System.Windows.Forms.Label
    Friend WithEvents lblSorte As System.Windows.Forms.Label
    Friend WithEvents picEis As System.Windows.Forms.PictureBox
    Friend WithEvents optSize1 As System.Windows.Forms.RadioButton
    Friend WithEvents optSize2 As System.Windows.Forms.RadioButton
    Friend WithEvents optSize3 As System.Windows.Forms.RadioButton
    Friend WithEvents grpGroesse As System.Windows.Forms.GroupBox
    Friend WithEvents lblPreis As System.Windows.Forms.Label
    Friend WithEvents txtPreis As System.Windows.Forms.TextBox
    Friend WithEvents txtPaid As System.Windows.Forms.TextBox
    Friend WithEvents lblPaid As System.Windows.Forms.Label
    Friend WithEvents txtRetour As System.Windows.Forms.TextBox
    Friend WithEvents lblRetour As System.Windows.Forms.Label
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnGeld1 As System.Windows.Forms.Button
    Friend WithEvents btnGeld2 As System.Windows.Forms.Button
    Friend WithEvents btnGeld3 As System.Windows.Forms.Button
    Friend WithEvents btnGeld4 As System.Windows.Forms.Button
    Friend WithEvents btnGeld5 As System.Windows.Forms.Button
    Friend WithEvents btnGeld6 As System.Windows.Forms.Button
    Friend WithEvents picVanille As System.Windows.Forms.PictureBox
    Friend WithEvents picHaselnuss As System.Windows.Forms.PictureBox
    Friend WithEvents picSchoko As System.Windows.Forms.PictureBox
    Friend WithEvents picErdbeer As System.Windows.Forms.PictureBox

End Class
