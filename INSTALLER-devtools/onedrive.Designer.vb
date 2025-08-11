<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class onedrive
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(onedrive))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.path = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.stato = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.fondvers = New System.Windows.Forms.TextBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 411)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 42)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Indietro"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(244, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Path di OneDrive (File Fondamental.zip)"
        '
        'Button4
        '
        Me.Button4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button4.Location = New System.Drawing.Point(433, 19)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(95, 39)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Modifica"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'path
        '
        Me.path.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.path.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.path.Location = New System.Drawing.Point(9, 27)
        Me.path.Name = "path"
        Me.path.Size = New System.Drawing.Size(418, 24)
        Me.path.TabIndex = 8
        Me.path.Text = "Nessuna File selezionato ..."
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "Fondamental.zip"
        Me.OpenFileDialog1.Filter = "File Fondamental.zip|*.zip;"
        '
        'stato
        '
        Me.stato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.stato.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stato.Location = New System.Drawing.Point(212, 401)
        Me.stato.Name = "stato"
        Me.stato.Size = New System.Drawing.Size(504, 26)
        Me.stato.TabIndex = 11
        Me.stato.Text = "--- Visualizzerai le info qui ---"
        Me.stato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(212, 430)
        Me.ProgressBar1.MarqueeAnimationSpeed = 20
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(504, 23)
        Me.ProgressBar1.TabIndex = 12
        '
        'ListBox1
        '
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(12, 85)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(188, 315)
        Me.ListBox1.Sorted = True
        Me.ListBox1.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Directory Principale"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(209, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Visualizzatore"
        '
        'ListBox2
        '
        Me.ListBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 15
        Me.ListBox2.Location = New System.Drawing.Point(212, 85)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(232, 180)
        Me.ListBox2.TabIndex = 16
        '
        'ListBox3
        '
        Me.ListBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 15
        Me.ListBox3.Location = New System.Drawing.Point(450, 85)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.ListBox3.Size = New System.Drawing.Size(104, 180)
        Me.ListBox3.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(447, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Tipo"
        '
        'Timer1
        '
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(212, 268)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(342, 23)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Indietro"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(212, 297)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(342, 23)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Modifica"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Enabled = False
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(581, 287)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(125, 79)
        Me.Button5.TabIndex = 21
        Me.Button5.Text = "Salva tutto e chiudi"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Enabled = False
        Me.Button6.Location = New System.Drawing.Point(383, 362)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(171, 35)
        Me.Button6.TabIndex = 22
        Me.Button6.Text = "Nuova Cartella"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Enabled = False
        Me.Button7.Location = New System.Drawing.Point(212, 362)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(165, 35)
        Me.Button7.TabIndex = 23
        Me.Button7.Text = "Nuovo File"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Enabled = False
        Me.Button8.Location = New System.Drawing.Point(212, 326)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(110, 30)
        Me.Button8.TabIndex = 24
        Me.Button8.Text = "Elimina"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(115, 411)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(85, 42)
        Me.Button9.TabIndex = 25
        Me.Button9.Text = "Apri OneDrive"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.path)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(542, 64)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.fondvers)
        Me.GroupBox2.Location = New System.Drawing.Point(560, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(162, 64)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(0, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 18)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Versione Fondamental"
        '
        'fondvers
        '
        Me.fondvers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fondvers.Location = New System.Drawing.Point(9, 28)
        Me.fondvers.Name = "fondvers"
        Me.fondvers.ReadOnly = True
        Me.fondvers.Size = New System.Drawing.Size(147, 26)
        Me.fondvers.TabIndex = 0
        Me.fondvers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button10
        '
        Me.Button10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button10.Enabled = False
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(581, 78)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(125, 69)
        Me.Button10.TabIndex = 28
        Me.Button10.Text = "Nuova App"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button11.Enabled = False
        Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Location = New System.Drawing.Point(581, 153)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(125, 53)
        Me.Button11.TabIndex = 29
        Me.Button11.Text = "Modifica App Selezionata"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button12.Enabled = False
        Me.Button12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Location = New System.Drawing.Point(581, 212)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(125, 69)
        Me.Button12.TabIndex = 30
        Me.Button12.Text = "Nuova Configurazione (.ini)"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Enabled = False
        Me.Button13.Location = New System.Drawing.Point(328, 326)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(119, 30)
        Me.Button13.TabIndex = 31
        Me.Button13.Text = "Copia"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Enabled = False
        Me.Button14.Location = New System.Drawing.Point(453, 326)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(101, 30)
        Me.Button14.TabIndex = 32
        Me.Button14.Text = "Incolla"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'onedrive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 465)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.stato)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "onedrive"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editor di Fondamental"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents path As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents stato As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents fondvers As TextBox
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button14 As Button
End Class
