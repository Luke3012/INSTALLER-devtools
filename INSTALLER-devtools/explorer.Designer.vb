<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class explorer
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(explorer))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.mega = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.lavoro = New System.Windows.Forms.GroupBox()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.controllo = New System.Windows.Forms.GroupBox()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.lavoro.SuspendLayout()
        Me.controllo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 379)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 41)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Indietro"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.Enabled = False
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(12, 101)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(197, 272)
        Me.ListBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(141, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(532, 22)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Modifica i File di Updater di MEGA con tutta facilità senza che ti scervelli ..."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(141, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Path di MEGA (Cartelle)"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(622, 63)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(98, 29)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Modifica"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'mega
        '
        Me.mega.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mega.Location = New System.Drawing.Point(141, 68)
        Me.mega.Name = "mega"
        Me.mega.Size = New System.Drawing.Size(475, 24)
        Me.mega.TabIndex = 5
        Me.mega.Text = "Nessuna Cartella selezionata ..."
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.Description = "Scegli la cartella di MEGA, quella UPDATER dove sono contenuti tutti i file d'agg" &
    "iornamento..."
        '
        'lavoro
        '
        Me.lavoro.Controls.Add(Me.Button13)
        Me.lavoro.Controls.Add(Me.Button10)
        Me.lavoro.Controls.Add(Me.Button5)
        Me.lavoro.Controls.Add(Me.Button9)
        Me.lavoro.Controls.Add(Me.Button8)
        Me.lavoro.Controls.Add(Me.Button6)
        Me.lavoro.Controls.Add(Me.Label4)
        Me.lavoro.Controls.Add(Me.ListBox3)
        Me.lavoro.Enabled = False
        Me.lavoro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lavoro.Location = New System.Drawing.Point(478, 101)
        Me.lavoro.Name = "lavoro"
        Me.lavoro.Size = New System.Drawing.Size(242, 319)
        Me.lavoro.TabIndex = 8
        Me.lavoro.TabStop = False
        Me.lavoro.Text = "Area di lavoro OTA"
        '
        'Button13
        '
        Me.Button13.Enabled = False
        Me.Button13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.Location = New System.Drawing.Point(157, 41)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(70, 26)
        Me.Button13.TabIndex = 7
        Me.Button13.Text = "Elimina"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(6, 263)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(221, 41)
        Me.Button10.TabIndex = 6
        Me.Button10.Text = "Elimina Aggiornamento OTA"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(6, 217)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(221, 40)
        Me.Button9.TabIndex = 5
        Me.Button9.Text = "Carica File per OTA"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(6, 169)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(221, 42)
        Me.Button8.TabIndex = 4
        Me.Button8.Text = "Ricostruisci Aggiornamento OTA Specifico"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(6, 122)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(221, 41)
        Me.Button6.TabIndex = 3
        Me.Button6.Text = "Clona Aggiornamento OTA selezionato"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(6, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "File dell'OTA"
        '
        'ListBox3
        '
        Me.ListBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 15
        Me.ListBox3.Location = New System.Drawing.Point(6, 41)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(145, 75)
        Me.ListBox3.Sorted = True
        Me.ListBox3.TabIndex = 0
        '
        'controllo
        '
        Me.controllo.Controls.Add(Me.GroupBox1)
        Me.controllo.Controls.Add(Me.Button14)
        Me.controllo.Controls.Add(Me.TextBox1)
        Me.controllo.Controls.Add(Me.Label3)
        Me.controllo.Controls.Add(Me.ListBox2)
        Me.controllo.Enabled = False
        Me.controllo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.controllo.Location = New System.Drawing.Point(215, 101)
        Me.controllo.Name = "controllo"
        Me.controllo.Size = New System.Drawing.Size(257, 319)
        Me.controllo.TabIndex = 9
        Me.controllo.TabStop = False
        Me.controllo.Text = "Area di controllo/selezione OTA"
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(3, 98)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(239, 30)
        Me.Button12.TabIndex = 6
        Me.Button12.Text = "File 'other.bat'"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(122, 65)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(120, 30)
        Me.Button7.TabIndex = 5
        Me.Button7.Text = "File 'updateold.bat'"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(3, 256)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(136, 57)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Text = "Nulla da dire al momento... seleziona qualcosa"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(3, 65)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(116, 30)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "File 'update.bat'"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(3, 20)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 39)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Changelog generico"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(3, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(204, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Agg. OTA trovati per questa versione"
        '
        'ListBox2
        '
        Me.ListBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 15
        Me.ListBox2.Location = New System.Drawing.Point(3, 41)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(248, 75)
        Me.ListBox2.TabIndex = 0
        '
        'Button5
        '
        Me.Button5.Enabled = False
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(157, 73)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(70, 43)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "Modifica"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "File INSTALLER.exe|INSTALLER.exe;"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.INSTALLER_devtools.My.Resources.Resources.Igh0zt_Ios7_Style_Metro_Ui_MetroUI_Apps_Mac_App_Store
        Me.PictureBox1.Location = New System.Drawing.Point(49, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(86, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(141, 379)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(65, 41)
        Me.Button11.TabIndex = 10
        Me.Button11.Text = "Apri MEGA"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(145, 256)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(106, 57)
        Me.Button14.TabIndex = 9
        Me.Button14.Text = "Ricostruisci Ultimo OTA"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button15)
        Me.GroupBox1.Controls.Add(Me.Button12)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 116)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(251, 134)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Modifica"
        '
        'Button15
        '
        Me.Button15.Location = New System.Drawing.Point(122, 20)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(120, 39)
        Me.Button15.TabIndex = 7
        Me.Button15.Text = "Changelog generico OLD"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'explorer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 432)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.controllo)
        Me.Controls.Add(Me.lavoro)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.mega)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "explorer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Esplora File"
        Me.lavoro.ResumeLayout(False)
        Me.lavoro.PerformLayout()
        Me.controllo.ResumeLayout(False)
        Me.controllo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents mega As TextBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents lavoro As GroupBox
    Friend WithEvents controllo As GroupBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button15 As Button
    Friend WithEvents Button14 As Button
End Class
