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
        Me.picBild = New System.Windows.Forms.PictureBox()
        Me.btnBeenden = New System.Windows.Forms.Button()
        Me.lblPfad = New System.Windows.Forms.Label()
        Me.dirVerzeichnis = New Microsoft.VisualBasic.Compatibility.VB6.DirListBox()
        Me.drvLaufwerk = New Microsoft.VisualBasic.Compatibility.VB6.DriveListBox()
        Me.filDatei = New Microsoft.VisualBasic.Compatibility.VB6.FileListBox()
        CType(Me.picBild, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBild
        '
        Me.picBild.Location = New System.Drawing.Point(234, 13)
        Me.picBild.Name = "picBild"
        Me.picBild.Size = New System.Drawing.Size(413, 436)
        Me.picBild.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBild.TabIndex = 0
        Me.picBild.TabStop = False
        '
        'btnBeenden
        '
        Me.btnBeenden.Location = New System.Drawing.Point(368, 475)
        Me.btnBeenden.Name = "btnBeenden"
        Me.btnBeenden.Size = New System.Drawing.Size(279, 23)
        Me.btnBeenden.TabIndex = 1
        Me.btnBeenden.Text = "Beenden"
        Me.btnBeenden.UseVisualStyleBackColor = True
        '
        'lblPfad
        '
        Me.lblPfad.AutoSize = True
        Me.lblPfad.Location = New System.Drawing.Point(22, 485)
        Me.lblPfad.Name = "lblPfad"
        Me.lblPfad.Size = New System.Drawing.Size(39, 13)
        Me.lblPfad.TabIndex = 2
        Me.lblPfad.Text = "Label1"
        '
        'dirVerzeichnis
        '
        Me.dirVerzeichnis.FormattingEnabled = True
        Me.dirVerzeichnis.IntegralHeight = False
        Me.dirVerzeichnis.Location = New System.Drawing.Point(16, 49)
        Me.dirVerzeichnis.Name = "dirVerzeichnis"
        Me.dirVerzeichnis.Size = New System.Drawing.Size(212, 194)
        Me.dirVerzeichnis.TabIndex = 3
        '
        'drvLaufwerk
        '
        Me.drvLaufwerk.FormattingEnabled = True
        Me.drvLaufwerk.Location = New System.Drawing.Point(16, 13)
        Me.drvLaufwerk.Name = "drvLaufwerk"
        Me.drvLaufwerk.Size = New System.Drawing.Size(212, 21)
        Me.drvLaufwerk.TabIndex = 4
        '
        'filDatei
        '
        Me.filDatei.FormattingEnabled = True
        Me.filDatei.Location = New System.Drawing.Point(13, 250)
        Me.filDatei.Name = "filDatei"
        Me.filDatei.Pattern = "*.jpg;*.png;*.gif;*.jpeg;*.tiff"
        Me.filDatei.Size = New System.Drawing.Size(215, 199)
        Me.filDatei.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 510)
        Me.Controls.Add(Me.filDatei)
        Me.Controls.Add(Me.drvLaufwerk)
        Me.Controls.Add(Me.dirVerzeichnis)
        Me.Controls.Add(Me.lblPfad)
        Me.Controls.Add(Me.btnBeenden)
        Me.Controls.Add(Me.picBild)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picBild, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picBild As System.Windows.Forms.PictureBox
    Friend WithEvents btnBeenden As System.Windows.Forms.Button
    Friend WithEvents lblPfad As System.Windows.Forms.Label
    Friend WithEvents dirVerzeichnis As Microsoft.VisualBasic.Compatibility.VB6.DirListBox
    Friend WithEvents drvLaufwerk As Microsoft.VisualBasic.Compatibility.VB6.DriveListBox
    Friend WithEvents filDatei As Microsoft.VisualBasic.Compatibility.VB6.FileListBox

End Class
