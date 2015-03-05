<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtVal1 = New System.Windows.Forms.TextBox()
        Me.txtVal2 = New System.Windows.Forms.TextBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.lblOperator = New System.Windows.Forms.Label()
        Me.lblGleich = New System.Windows.Forms.Label()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnBackslash = New System.Windows.Forms.Button()
        Me.btnMal = New System.Windows.Forms.Button()
        Me.btnVerbindung = New System.Windows.Forms.Button()
        Me.btnHoch = New System.Windows.Forms.Button()
        Me.btnMod = New System.Windows.Forms.Button()
        Me.btnDurch = New System.Windows.Forms.Button()
        Me.btnAnd = New System.Windows.Forms.Button()
        Me.btnOr = New System.Windows.Forms.Button()
        Me.btnLike = New System.Windows.Forms.Button()
        Me.btnGroesser = New System.Windows.Forms.Button()
        Me.btnKleiner = New System.Windows.Forms.Button()
        Me.btnGleich = New System.Windows.Forms.Button()
        Me.btnNot = New System.Windows.Forms.Button()
        Me.btnXor = New System.Windows.Forms.Button()
        Me.txtBinary = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtVal1
        '
        Me.txtVal1.Location = New System.Drawing.Point(-2, 13)
        Me.txtVal1.Name = "txtVal1"
        Me.txtVal1.Size = New System.Drawing.Size(175, 20)
        Me.txtVal1.TabIndex = 0
        '
        'txtVal2
        '
        Me.txtVal2.Location = New System.Drawing.Point(240, 12)
        Me.txtVal2.Name = "txtVal2"
        Me.txtVal2.Size = New System.Drawing.Size(158, 20)
        Me.txtVal2.TabIndex = 1
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(456, 12)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(100, 20)
        Me.txtResult.TabIndex = 2
        '
        'lblOperator
        '
        Me.lblOperator.AutoSize = True
        Me.lblOperator.Location = New System.Drawing.Point(191, 15)
        Me.lblOperator.Name = "lblOperator"
        Me.lblOperator.Size = New System.Drawing.Size(0, 13)
        Me.lblOperator.TabIndex = 3
        '
        'lblGleich
        '
        Me.lblGleich.AutoSize = True
        Me.lblGleich.Location = New System.Drawing.Point(405, 12)
        Me.lblGleich.Name = "lblGleich"
        Me.lblGleich.Size = New System.Drawing.Size(13, 13)
        Me.lblGleich.TabIndex = 4
        Me.lblGleich.Text = "="
        '
        'btnPlus
        '
        Me.btnPlus.Location = New System.Drawing.Point(13, 58)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(45, 32)
        Me.btnPlus.TabIndex = 5
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'btnMinus
        '
        Me.btnMinus.Location = New System.Drawing.Point(64, 58)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(45, 32)
        Me.btnMinus.TabIndex = 6
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = True
        '
        'btnBackslash
        '
        Me.btnBackslash.Location = New System.Drawing.Point(194, 58)
        Me.btnBackslash.Name = "btnBackslash"
        Me.btnBackslash.Size = New System.Drawing.Size(45, 32)
        Me.btnBackslash.TabIndex = 7
        Me.btnBackslash.Text = "\"
        Me.btnBackslash.UseVisualStyleBackColor = True
        '
        'btnMal
        '
        Me.btnMal.Location = New System.Drawing.Point(279, 58)
        Me.btnMal.Name = "btnMal"
        Me.btnMal.Size = New System.Drawing.Size(45, 32)
        Me.btnMal.TabIndex = 8
        Me.btnMal.Text = "*"
        Me.btnMal.UseVisualStyleBackColor = True
        '
        'btnVerbindung
        '
        Me.btnVerbindung.Location = New System.Drawing.Point(459, 58)
        Me.btnVerbindung.Name = "btnVerbindung"
        Me.btnVerbindung.Size = New System.Drawing.Size(45, 32)
        Me.btnVerbindung.TabIndex = 11
        Me.btnVerbindung.Text = "&&"
        Me.btnVerbindung.UseVisualStyleBackColor = True
        '
        'btnHoch
        '
        Me.btnHoch.Location = New System.Drawing.Point(330, 58)
        Me.btnHoch.Name = "btnHoch"
        Me.btnHoch.Size = New System.Drawing.Size(45, 32)
        Me.btnHoch.TabIndex = 12
        Me.btnHoch.Text = "^"
        Me.btnHoch.UseVisualStyleBackColor = True
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(408, 58)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(45, 32)
        Me.btnMod.TabIndex = 13
        Me.btnMod.Text = "Mod"
        Me.btnMod.UseVisualStyleBackColor = True
        '
        'btnDurch
        '
        Me.btnDurch.Location = New System.Drawing.Point(143, 58)
        Me.btnDurch.Name = "btnDurch"
        Me.btnDurch.Size = New System.Drawing.Size(45, 32)
        Me.btnDurch.TabIndex = 14
        Me.btnDurch.Text = "/"
        Me.btnDurch.UseVisualStyleBackColor = True
        '
        'btnAnd
        '
        Me.btnAnd.Location = New System.Drawing.Point(279, 123)
        Me.btnAnd.Name = "btnAnd"
        Me.btnAnd.Size = New System.Drawing.Size(45, 32)
        Me.btnAnd.TabIndex = 15
        Me.btnAnd.Text = "AND"
        Me.btnAnd.UseVisualStyleBackColor = True
        '
        'btnOr
        '
        Me.btnOr.Location = New System.Drawing.Point(330, 123)
        Me.btnOr.Name = "btnOr"
        Me.btnOr.Size = New System.Drawing.Size(45, 32)
        Me.btnOr.TabIndex = 16
        Me.btnOr.Text = "OR"
        Me.btnOr.UseVisualStyleBackColor = True
        '
        'btnLike
        '
        Me.btnLike.Location = New System.Drawing.Point(194, 123)
        Me.btnLike.Name = "btnLike"
        Me.btnLike.Size = New System.Drawing.Size(45, 32)
        Me.btnLike.TabIndex = 17
        Me.btnLike.Text = "Like"
        Me.btnLike.UseVisualStyleBackColor = True
        '
        'btnGroesser
        '
        Me.btnGroesser.Location = New System.Drawing.Point(143, 123)
        Me.btnGroesser.Name = "btnGroesser"
        Me.btnGroesser.Size = New System.Drawing.Size(45, 32)
        Me.btnGroesser.TabIndex = 18
        Me.btnGroesser.Text = ">"
        Me.btnGroesser.UseVisualStyleBackColor = True
        '
        'btnKleiner
        '
        Me.btnKleiner.Location = New System.Drawing.Point(64, 123)
        Me.btnKleiner.Name = "btnKleiner"
        Me.btnKleiner.Size = New System.Drawing.Size(45, 32)
        Me.btnKleiner.TabIndex = 19
        Me.btnKleiner.Text = "<"
        Me.btnKleiner.UseVisualStyleBackColor = True
        '
        'btnGleich
        '
        Me.btnGleich.Location = New System.Drawing.Point(13, 123)
        Me.btnGleich.Name = "btnGleich"
        Me.btnGleich.Size = New System.Drawing.Size(45, 32)
        Me.btnGleich.TabIndex = 20
        Me.btnGleich.Text = "="
        Me.btnGleich.UseVisualStyleBackColor = True
        '
        'btnNot
        '
        Me.btnNot.Location = New System.Drawing.Point(459, 123)
        Me.btnNot.Name = "btnNot"
        Me.btnNot.Size = New System.Drawing.Size(45, 32)
        Me.btnNot.TabIndex = 21
        Me.btnNot.Text = "NOT"
        Me.btnNot.UseVisualStyleBackColor = True
        '
        'btnXor
        '
        Me.btnXor.Location = New System.Drawing.Point(408, 123)
        Me.btnXor.Name = "btnXor"
        Me.btnXor.Size = New System.Drawing.Size(45, 32)
        Me.btnXor.TabIndex = 22
        Me.btnXor.Text = "XOR"
        Me.btnXor.UseVisualStyleBackColor = True
        '
        'txtBinary
        '
        Me.txtBinary.Location = New System.Drawing.Point(456, 32)
        Me.txtBinary.Name = "txtBinary"
        Me.txtBinary.Size = New System.Drawing.Size(100, 20)
        Me.txtBinary.TabIndex = 23
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 204)
        Me.Controls.Add(Me.txtBinary)
        Me.Controls.Add(Me.btnXor)
        Me.Controls.Add(Me.btnNot)
        Me.Controls.Add(Me.btnGleich)
        Me.Controls.Add(Me.btnKleiner)
        Me.Controls.Add(Me.btnGroesser)
        Me.Controls.Add(Me.btnLike)
        Me.Controls.Add(Me.btnOr)
        Me.Controls.Add(Me.btnAnd)
        Me.Controls.Add(Me.btnDurch)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnHoch)
        Me.Controls.Add(Me.btnVerbindung)
        Me.Controls.Add(Me.btnMal)
        Me.Controls.Add(Me.btnBackslash)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.lblGleich)
        Me.Controls.Add(Me.lblOperator)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.txtVal2)
        Me.Controls.Add(Me.txtVal1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtVal1 As System.Windows.Forms.TextBox
    Friend WithEvents txtVal2 As System.Windows.Forms.TextBox
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents lblOperator As System.Windows.Forms.Label
    Friend WithEvents lblGleich As System.Windows.Forms.Label
    Friend WithEvents btnPlus As System.Windows.Forms.Button
    Friend WithEvents btnMinus As System.Windows.Forms.Button
    Friend WithEvents btnBackslash As System.Windows.Forms.Button
    Friend WithEvents btnMal As System.Windows.Forms.Button
    Friend WithEvents btnVerbindung As System.Windows.Forms.Button
    Friend WithEvents btnHoch As System.Windows.Forms.Button
    Friend WithEvents btnMod As System.Windows.Forms.Button
    Friend WithEvents btnDurch As System.Windows.Forms.Button
    Friend WithEvents btnAnd As System.Windows.Forms.Button
    Friend WithEvents btnOr As System.Windows.Forms.Button
    Friend WithEvents btnLike As System.Windows.Forms.Button
    Friend WithEvents btnGroesser As System.Windows.Forms.Button
    Friend WithEvents btnKleiner As System.Windows.Forms.Button
    Friend WithEvents btnGleich As System.Windows.Forms.Button
    Friend WithEvents btnNot As System.Windows.Forms.Button
    Friend WithEvents btnXor As System.Windows.Forms.Button
    Friend WithEvents txtBinary As System.Windows.Forms.TextBox

End Class
