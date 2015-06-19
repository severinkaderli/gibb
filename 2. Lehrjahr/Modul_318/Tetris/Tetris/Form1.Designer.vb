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
        Me.components = New System.ComponentModel.Container()
        Me.timT = New System.Windows.Forms.Timer(Me.components)
        Me.cmdLinks = New System.Windows.Forms.Button()
        Me.cmdRechts = New System.Windows.Forms.Button()
        Me.cmdUnten = New System.Windows.Forms.Button()
        Me.cmdPause = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'timT
        '
        Me.timT.Enabled = True
        Me.timT.Interval = 1000
        '
        'cmdLinks
        '
        Me.cmdLinks.Location = New System.Drawing.Point(12, 13)
        Me.cmdLinks.Name = "cmdLinks"
        Me.cmdLinks.Size = New System.Drawing.Size(75, 23)
        Me.cmdLinks.TabIndex = 0
        Me.cmdLinks.Text = "Links"
        Me.cmdLinks.UseVisualStyleBackColor = True
        '
        'cmdRechts
        '
        Me.cmdRechts.Location = New System.Drawing.Point(197, 13)
        Me.cmdRechts.Name = "cmdRechts"
        Me.cmdRechts.Size = New System.Drawing.Size(75, 23)
        Me.cmdRechts.TabIndex = 1
        Me.cmdRechts.Text = "Rechts"
        Me.cmdRechts.UseVisualStyleBackColor = True
        '
        'cmdUnten
        '
        Me.cmdUnten.Location = New System.Drawing.Point(103, 47)
        Me.cmdUnten.Name = "cmdUnten"
        Me.cmdUnten.Size = New System.Drawing.Size(75, 23)
        Me.cmdUnten.TabIndex = 2
        Me.cmdUnten.Text = "Drop"
        Me.cmdUnten.UseVisualStyleBackColor = True
        '
        'cmdPause
        '
        Me.cmdPause.Location = New System.Drawing.Point(103, 12)
        Me.cmdPause.Name = "cmdPause"
        Me.cmdPause.Size = New System.Drawing.Size(75, 23)
        Me.cmdPause.TabIndex = 3
        Me.cmdPause.Text = "Pause"
        Me.cmdPause.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 386)
        Me.Controls.Add(Me.cmdPause)
        Me.Controls.Add(Me.cmdUnten)
        Me.Controls.Add(Me.cmdRechts)
        Me.Controls.Add(Me.cmdLinks)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents timT As System.Windows.Forms.Timer
    Friend WithEvents cmdLinks As System.Windows.Forms.Button
    Friend WithEvents cmdRechts As System.Windows.Forms.Button
    Public WithEvents cmdUnten As System.Windows.Forms.Button
    Friend WithEvents cmdPause As System.Windows.Forms.Button

End Class
