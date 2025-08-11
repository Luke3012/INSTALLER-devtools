<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class installer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(installer))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.mega = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.onedrive = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.versione = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.changelog = New System.Windows.Forms.RichTextBox()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.Updater = New System.Windows.Forms.TextBox()
        Me.InstallerPath = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.versioneold = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 561)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 58)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Indietro"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(654, 561)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(147, 58)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Pubblica"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'mega
        '
        Me.mega.Enabled = False
        Me.mega.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mega.Location = New System.Drawing.Point(18, 42)
        Me.mega.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mega.Name = "mega"
        Me.mega.Size = New System.Drawing.Size(620, 33)
        Me.mega.TabIndex = 2
        Me.mega.Text = "Nessuna Cartella selezionata ..."
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(654, 42)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(147, 45)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Modifica"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Path di MEGA (Cartelle)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 111)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(359, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Path di OneDrive (File Fondamental.zip)"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(654, 132)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(147, 45)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Modifica"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'onedrive
        '
        Me.onedrive.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.onedrive.Location = New System.Drawing.Point(18, 140)
        Me.onedrive.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.onedrive.Name = "onedrive"
        Me.onedrive.Size = New System.Drawing.Size(620, 33)
        Me.onedrive.TabIndex = 5
        Me.onedrive.Text = "Nessuna File selezionato ..."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(140, 265)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(224, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Carica updater.exe (opzionale)"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(138, 451)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Carica il Changelog"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "Fondamental.zip"
        Me.OpenFileDialog1.Filter = "File Fondamental.zip|*.zip;"
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.Description = "Scegli il percorso della Cartella di OneDrive (non quella di UPDATER, quella di I" &
    "nstaller...quella dove sta tutto diciamo)"
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 25
        Me.ListBox1.Items.AddRange(New Object() {"File OneDrive (non impostata)", "Scrivi Changelog (non impostata)", "Carica INSTALLER.exe (non impostata)", "Carica Versione (non impostata)", "", "RIMANENTI = 4"})
        Me.ListBox1.Location = New System.Drawing.Point(810, 42)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.ListBox1.Size = New System.Drawing.Size(376, 179)
        Me.ListBox1.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(806, 12)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 25)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Riepilogo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(140, 366)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(175, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Carica INSTALLER.exe"
        '
        'versione
        '
        Me.versione.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.versione.Location = New System.Drawing.Point(510, 432)
        Me.versione.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.versione.Name = "versione"
        Me.versione.ReadOnly = True
        Me.versione.Size = New System.Drawing.Size(122, 35)
        Me.versione.TabIndex = 16
        Me.versione.Text = "..."
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(354, 431)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(147, 48)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "Modifica versione"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(805, 293)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(198, 25)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Changelog Impostato"
        '
        'changelog
        '
        Me.changelog.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.changelog.Location = New System.Drawing.Point(809, 323)
        Me.changelog.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.changelog.Name = "changelog"
        Me.changelog.ReadOnly = True
        Me.changelog.Size = New System.Drawing.Size(376, 296)
        Me.changelog.TabIndex = 19
        Me.changelog.Text = "Nessun Cangelog impostato ..."
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.Filter = "File INSTALLER.exe (o UPDATER.exe)|*.exe;"
        '
        'Updater
        '
        Me.Updater.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Updater.Location = New System.Drawing.Point(144, 226)
        Me.Updater.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Updater.Name = "Updater"
        Me.Updater.ReadOnly = True
        Me.Updater.Size = New System.Drawing.Size(554, 30)
        Me.Updater.TabIndex = 20
        Me.Updater.Text = "Nessun percorso ..."
        Me.Updater.Visible = False
        '
        'InstallerPath
        '
        Me.InstallerPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InstallerPath.Location = New System.Drawing.Point(144, 328)
        Me.InstallerPath.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.InstallerPath.Name = "InstallerPath"
        Me.InstallerPath.ReadOnly = True
        Me.InstallerPath.Size = New System.Drawing.Size(554, 30)
        Me.InstallerPath.TabIndex = 21
        Me.InstallerPath.Text = "Nessun percorso ..."
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.INSTALLER_devtools.My.Resources.Resources.Igh0zt_Ios7_Style_Metro_Ui_MetroUI_Apps_Mac_App_Store
        Me.PictureBox3.Location = New System.Drawing.Point(18, 306)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(111, 97)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 14
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.INSTALLER_devtools.My.Resources.Resources.Changelog
        Me.PictureBox2.Location = New System.Drawing.Point(18, 412)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(111, 97)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.INSTALLER_devtools.My.Resources.Resources.unnamed__1_
        Me.PictureBox1.Location = New System.Drawing.Point(18, 200)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(111, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'versioneold
        '
        Me.versioneold.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.versioneold.Location = New System.Drawing.Point(644, 431)
        Me.versioneold.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.versioneold.Name = "versioneold"
        Me.versioneold.ReadOnly = True
        Me.versioneold.Size = New System.Drawing.Size(122, 35)
        Me.versioneold.TabIndex = 22
        Me.versioneold.Text = "..."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(510, 403)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 25)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Nuova ver."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(639, 402)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 25)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Vecchia ver."
        '
        'installer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1206, 633)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.versioneold)
        Me.Controls.Add(Me.InstallerPath)
        Me.Controls.Add(Me.Updater)
        Me.Controls.Add(Me.changelog)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.versione)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.onedrive)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.mega)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "installer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aggiorna INSTALLER"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents mega As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents onedrive As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents versione As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents changelog As RichTextBox
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents Updater As TextBox
    Friend WithEvents InstallerPath As TextBox
    Friend WithEvents versioneold As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
