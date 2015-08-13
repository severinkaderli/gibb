<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAscii
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
        Me.lstFunktion = New System.Windows.Forms.ListBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtTabelle = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lstFunktion
        '
        Me.lstFunktion.FormattingEnabled = True
        Me.lstFunktion.Items.AddRange(New Object() {"For.. Next", "While... End While", "Do... Loop Until"})
        Me.lstFunktion.Location = New System.Drawing.Point(141, 31)
        Me.lstFunktion.Name = "lstFunktion"
        Me.lstFunktion.Size = New System.Drawing.Size(138, 69)
        Me.lstFunktion.TabIndex = 0
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(303, 31)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(115, 33)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(303, 70)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(115, 32)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Beenden"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtTabelle
        '
        Me.txtTabelle.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTabelle.Location = New System.Drawing.Point(13, 140)
        Me.txtTabelle.Multiline = True
        Me.txtTabelle.Name = "txtTabelle"
        Me.txtTabelle.Size = New System.Drawing.Size(645, 416)
        Me.txtTabelle.TabIndex = 3
        '
        'frmAscii
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 568)
        Me.Controls.Add(Me.txtTabelle)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lstFunktion)
        Me.Name = "frmAscii"
        Me.Text = "ASCII Zeichencodes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstFunktion As System.Windows.Forms.ListBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtTabelle As System.Windows.Forms.TextBox

End Class
