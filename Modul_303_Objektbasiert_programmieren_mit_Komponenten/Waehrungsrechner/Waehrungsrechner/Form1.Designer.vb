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
        Me.lblKurs = New System.Windows.Forms.Label()
        Me.txtKurs = New System.Windows.Forms.TextBox()
        Me.lblCHF = New System.Windows.Forms.Label()
        Me.txtCHF = New System.Windows.Forms.TextBox()
        Me.lblErgebnis = New System.Windows.Forms.Label()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblKurs
        '
        Me.lblKurs.AutoSize = True
        Me.lblKurs.Location = New System.Drawing.Point(13, 34)
        Me.lblKurs.Name = "lblKurs"
        Me.lblKurs.Size = New System.Drawing.Size(28, 13)
        Me.lblKurs.TabIndex = 0
        Me.lblKurs.Text = "Kurs"
        '
        'txtKurs
        '
        Me.txtKurs.Location = New System.Drawing.Point(59, 26)
        Me.txtKurs.Name = "txtKurs"
        Me.txtKurs.Size = New System.Drawing.Size(100, 20)
        Me.txtKurs.TabIndex = 1
        '
        'lblCHF
        '
        Me.lblCHF.AutoSize = True
        Me.lblCHF.Location = New System.Drawing.Point(226, 32)
        Me.lblCHF.Name = "lblCHF"
        Me.lblCHF.Size = New System.Drawing.Size(28, 13)
        Me.lblCHF.TabIndex = 2
        Me.lblCHF.Text = "CHF"
        '
        'txtCHF
        '
        Me.txtCHF.Location = New System.Drawing.Point(272, 26)
        Me.txtCHF.Name = "txtCHF"
        Me.txtCHF.Size = New System.Drawing.Size(100, 20)
        Me.txtCHF.TabIndex = 3
        '
        'lblErgebnis
        '
        Me.lblErgebnis.Location = New System.Drawing.Point(158, 87)
        Me.lblErgebnis.Name = "lblErgebnis"
        Me.lblErgebnis.Size = New System.Drawing.Size(214, 62)
        Me.lblErgebnis.TabIndex = 4
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(158, 181)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(107, 40)
        Me.btnEnd.TabIndex = 5
        Me.btnEnd.Text = "Beenden"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 262)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.lblErgebnis)
        Me.Controls.Add(Me.txtCHF)
        Me.Controls.Add(Me.lblCHF)
        Me.Controls.Add(Me.txtKurs)
        Me.Controls.Add(Me.lblKurs)
        Me.Name = "Form1"
        Me.Text = "Währungsrechner"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblKurs As System.Windows.Forms.Label
    Friend WithEvents txtKurs As System.Windows.Forms.TextBox
    Friend WithEvents lblCHF As System.Windows.Forms.Label
    Friend WithEvents txtCHF As System.Windows.Forms.TextBox
    Friend WithEvents lblErgebnis As System.Windows.Forms.Label
    Friend WithEvents btnEnd As System.Windows.Forms.Button

End Class
