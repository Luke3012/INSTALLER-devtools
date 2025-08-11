<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newappimg
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.picperc = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(12, 346)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(319, 41)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(12, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(319, 169)
        Me.ListBox1.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Location = New System.Drawing.Point(13, 187)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(171, 41)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Aggiungi Immagine"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(190, 187)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(142, 41)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Rimuovi Immagine"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Title = "Scegli un'immagine"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(13, 257)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(319, 29)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Cambia Immagine di Copertina"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'picperc
        '
        Me.picperc.Location = New System.Drawing.Point(13, 234)
        Me.picperc.Name = "picperc"
        Me.picperc.ReadOnly = True
        Me.picperc.Size = New System.Drawing.Size(319, 21)
        Me.picperc.TabIndex = 5
        Me.picperc.Text = "Nessuna Immagine di Copertina Selezionata ..."
        Me.picperc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'newappimg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 399)
        Me.ControlBox = False
        Me.Controls.Add(Me.picperc)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "newappimg"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Immagine App"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button4 As Button
    Friend WithEvents picperc As TextBox
End Class
