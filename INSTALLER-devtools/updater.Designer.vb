<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class updater
    Inherits MaterialSkin.Controls.MaterialForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(updater))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.path = New System.Windows.Forms.TextBox()
        Me.v1 = New System.Windows.Forms.TextBox()
        Me.v2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.folder = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Button1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Button3 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Button5 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Button4 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "updater"
        Me.OpenFileDialog1.Filter = "File updater.exe|updater.exe;"
        '
        'path
        '
        Me.path.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.path.Location = New System.Drawing.Point(92, 119)
        Me.path.Name = "path"
        Me.path.ReadOnly = True
        Me.path.Size = New System.Drawing.Size(330, 21)
        Me.path.TabIndex = 4
        Me.path.Text = "Nessun File selezionato ..."
        '
        'v1
        '
        Me.v1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v1.Location = New System.Drawing.Point(158, 257)
        Me.v1.Name = "v1"
        Me.v1.ReadOnly = True
        Me.v1.Size = New System.Drawing.Size(26, 22)
        Me.v1.TabIndex = 5
        '
        'v2
        '
        Me.v2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v2.Location = New System.Drawing.Point(207, 257)
        Me.v2.Name = "v2"
        Me.v2.ReadOnly = True
        Me.v2.Size = New System.Drawing.Size(26, 22)
        Me.v2.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(189, 263)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "."
        '
        'folder
        '
        Me.folder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.folder.Location = New System.Drawing.Point(11, 188)
        Me.folder.Name = "folder"
        Me.folder.ReadOnly = True
        Me.folder.Size = New System.Drawing.Size(411, 21)
        Me.folder.TabIndex = 11
        Me.folder.Text = "Nessun Percorso selezionato ..."
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.Description = "Scegli il percorso della Cartella di OneDrive (non quella di UPDATER, quella di I" &
    "nstaller...quella dove sta tutto diciamo)"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PictureBox1.Image = Global.INSTALLER_devtools.My.Resources.Resources.unnamed__1_
        Me.PictureBox1.Location = New System.Drawing.Point(12, 82)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(74, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Depth = 0
        Me.Button2.Location = New System.Drawing.Point(388, 319)
        Me.Button2.MouseState = MaterialSkin.MouseState.HOVER
        Me.Button2.Name = "Button2"
        Me.Button2.Primary = True
        Me.Button2.Size = New System.Drawing.Size(127, 41)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Aggiorna"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Depth = 0
        Me.Button1.Location = New System.Drawing.Point(11, 319)
        Me.Button1.MouseState = MaterialSkin.MouseState.HOVER
        Me.Button1.Name = "Button1"
        Me.Button1.Primary = True
        Me.Button1.Size = New System.Drawing.Size(127, 41)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Indietro"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Depth = 0
        Me.Button3.Location = New System.Drawing.Point(428, 119)
        Me.Button3.MouseState = MaterialSkin.MouseState.HOVER
        Me.Button3.Name = "Button3"
        Me.Button3.Primary = True
        Me.Button3.Size = New System.Drawing.Size(92, 41)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Seleziona"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Depth = 0
        Me.Button5.Location = New System.Drawing.Point(428, 168)
        Me.Button5.MouseState = MaterialSkin.MouseState.HOVER
        Me.Button5.Name = "Button5"
        Me.Button5.Primary = True
        Me.Button5.Size = New System.Drawing.Size(92, 41)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "Seleziona"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Depth = 0
        Me.Button4.Location = New System.Drawing.Point(239, 248)
        Me.Button4.MouseState = MaterialSkin.MouseState.HOVER
        Me.Button4.Name = "Button4"
        Me.Button4.Primary = True
        Me.Button4.Size = New System.Drawing.Size(139, 41)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "Modifica Versione"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(154, 235)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(69, 19)
        Me.MaterialLabel1.TabIndex = 19
        Me.MaterialLabel1.Text = "Versione"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(92, 78)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(363, 38)
        Me.MaterialLabel2.TabIndex = 20
        Me.MaterialLabel2.Text = "Seleziona il File updater.exe, scegli la nuova versione" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "e me la vedrò io"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(92, 166)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(276, 19)
        Me.MaterialLabel3.TabIndex = 21
        Me.MaterialLabel3.Text = "Scegli il percorso di updater di OneDrive"
        '
        'updater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 372)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.folder)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.v2)
        Me.Controls.Add(Me.v1)
        Me.Controls.Add(Me.path)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "updater"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aggiorna Updater"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents path As TextBox
    Friend WithEvents v1 As TextBox
    Friend WithEvents v2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents folder As TextBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Button1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Button3 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Button5 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Button4 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
End Class
