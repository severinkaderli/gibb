<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSchmetterling
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSchmetterling))
        Me.picFluegelOffen = New System.Windows.Forms.PictureBox()
        Me.picFluegelZu = New System.Windows.Forms.PictureBox()
        Me.picFlug = New System.Windows.Forms.PictureBox()
        Me.tmrSchmetterling = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picFluegelOffen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFluegelZu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFlug, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picFluegelOffen
        '
        Me.picFluegelOffen.Image = CType(resources.GetObject("picFluegelOffen.Image"), System.Drawing.Image)
        Me.picFluegelOffen.Location = New System.Drawing.Point(12, 23)
        Me.picFluegelOffen.Name = "picFluegelOffen"
        Me.picFluegelOffen.Size = New System.Drawing.Size(77, 77)
        Me.picFluegelOffen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picFluegelOffen.TabIndex = 0
        Me.picFluegelOffen.TabStop = False
        Me.picFluegelOffen.Visible = False
        '
        'picFluegelZu
        '
        Me.picFluegelZu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picFluegelZu.Image = CType(resources.GetObject("picFluegelZu.Image"), System.Drawing.Image)
        Me.picFluegelZu.Location = New System.Drawing.Point(12, 106)
        Me.picFluegelZu.Name = "picFluegelZu"
        Me.picFluegelZu.Size = New System.Drawing.Size(77, 77)
        Me.picFluegelZu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picFluegelZu.TabIndex = 1
        Me.picFluegelZu.TabStop = False
        Me.picFluegelZu.Visible = False
        '
        'picFlug
        '
        Me.picFlug.BackColor = System.Drawing.Color.Transparent
        Me.picFlug.Location = New System.Drawing.Point(12, 269)
        Me.picFlug.Name = "picFlug"
        Me.picFlug.Size = New System.Drawing.Size(100, 50)
        Me.picFlug.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picFlug.TabIndex = 2
        Me.picFlug.TabStop = False
        '
        'tmrSchmetterling
        '
        Me.tmrSchmetterling.Enabled = True
        Me.tmrSchmetterling.Interval = 500
        '
        'frmSchmetterling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(360, 331)
        Me.Controls.Add(Me.picFlug)
        Me.Controls.Add(Me.picFluegelZu)
        Me.Controls.Add(Me.picFluegelOffen)
        Me.Name = "frmSchmetterling"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Schmetterling"
        CType(Me.picFluegelOffen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFluegelZu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFlug, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picFluegelOffen As System.Windows.Forms.PictureBox
    Friend WithEvents picFluegelZu As System.Windows.Forms.PictureBox
    Friend WithEvents picFlug As System.Windows.Forms.PictureBox
    Friend WithEvents tmrSchmetterling As System.Windows.Forms.Timer

End Class
