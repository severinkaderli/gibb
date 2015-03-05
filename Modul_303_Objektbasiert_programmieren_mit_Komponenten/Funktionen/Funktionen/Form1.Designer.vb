<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUhr
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
        Me.tmrTimer = New System.Windows.Forms.Timer(Me.components)
        Me.picUhr = New System.Windows.Forms.PictureBox()
        CType(Me.picUhr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrTimer
        '
        '
        'picUhr
        '
        Me.picUhr.Location = New System.Drawing.Point(13, 13)
        Me.picUhr.Name = "picUhr"
        Me.picUhr.Size = New System.Drawing.Size(283, 260)
        Me.picUhr.TabIndex = 0
        Me.picUhr.TabStop = False
        '
        'frmUhr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 285)
        Me.Controls.Add(Me.picUhr)
        Me.Name = "frmUhr"
        Me.Text = "Form1"
        CType(Me.picUhr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrTimer As System.Windows.Forms.Timer
    Friend WithEvents picUhr As System.Windows.Forms.PictureBox

End Class
