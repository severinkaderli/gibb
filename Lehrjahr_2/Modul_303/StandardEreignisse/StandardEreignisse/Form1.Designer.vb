<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form1
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
        Me.txtAusgabe = New System.Windows.Forms.TextBox()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtAusgabe
        '
        Me.txtAusgabe.Location = New System.Drawing.Point(13, 13)
        Me.txtAusgabe.Multiline = True
        Me.txtAusgabe.Name = "txtAusgabe"
        Me.txtAusgabe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAusgabe.Size = New System.Drawing.Size(259, 237)
        Me.txtAusgabe.TabIndex = 0
        '
        'btnHelp
        '
        Me.btnHelp.Location = New System.Drawing.Point(279, 13)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(33, 23)
        Me.btnHelp.TabIndex = 1
        Me.btnHelp.Text = "?"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 266)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.txtAusgabe)
        Me.Name = "form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAusgabe As System.Windows.Forms.TextBox
    Friend WithEvents btnHelp As System.Windows.Forms.Button

End Class
