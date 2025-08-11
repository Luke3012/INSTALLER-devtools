Imports System.IO
Imports System.IO.Compression
Imports System.Threading

Public Class installermake
    Dim versione As String = installer.versione.Text
    Dim versioneold As String = installer.versioneold.Text
    Private Sub installermake_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        installer.Hide()
        installerpubblica.Hide()
        already = False
        Timer1.Start()
    End Sub

    Private Sub prima()
        Timer1.Stop()
        Label2.Text = "Inizializzo ..."
        ''Creiamo le cartelle MEGA
        'Directory.CreateDirectory(installer.mega.Text & "\" & versioneold & "\" & versione & "\Changelog")
        'Directory.CreateDirectory(installer.mega.Text & "\" & versione)

        ''Copiamo i File
        'Dim write As New StreamWriter(installer.mega.Text & "\" & versioneold & "\" & versione & "\Changelog\" & versione & ".txt", False, System.Text.Encoding.Default)
        'write.WriteLine(installer.changelog.Text)
        'write.Close()
        'Dim write2 As New StreamWriter(installer.mega.Text & "\" & versioneold & "\" & versione & "\changelogdownload.bat", False, System.Text.Encoding.Default)
        'write2.WriteLine(installerpubblica.RichTextBox2.Text)
        'write2.Close()
        'Dim write3 As New StreamWriter(installer.mega.Text & "\" & versioneold & "\" & versione & "\updatedownload.bat", False, System.Text.Encoding.Default)
        'write3.WriteLine(installerpubblica.RichTextBox3.Text)
        'write3.Close()
        'Dim write4 As New StreamWriter(installer.mega.Text & "\" & versioneold & "\" & versione & "\updater.bat", False, System.Text.Encoding.Default)
        'write4.WriteLine(installerpubblica.RichTextBox4.Text)
        'write4.Close()
        'Dim write5 As New StreamWriter(installer.mega.Text & "\" & versioneold & "\update.bat", False, System.Text.Encoding.Default)
        'write5.WriteLine(installerpubblica.RichTextBox1.Text)
        'write5.Close()
        'Dim write6 As New StreamWriter(installer.mega.Text & "\" & versioneold & "\changelogdownload.txt", False, System.Text.Encoding.Default)
        'write6.WriteLine(installer.changelog.Text)
        'write6.Close()
        'Dim write7 As New StreamWriter(installer.mega.Text & "\" & versioneold & "\updateinfo.txt", False, System.Text.Encoding.Default)
        'write7.Write("1")
        'write7.Close()
        'Dim write8 As New StreamWriter(installer.mega.Text & "\" & versione & "\updateinfo.txt", False, System.Text.Encoding.Default)
        'write8.Write("0")
        'write8.Close()
        'File.Copy(installer.InstallerPath.Text, installer.mega.Text & "\" & versioneold & "\" & versione & "\INSTALLER.exe", True)
        '' Imposta quale è l'ultima versione
        'Dim write9 As New StreamWriter(installer.mega.Text & "\latest.txt", False, System.Text.Encoding.Default)
        'write9.Write(versione)
        'write9.Close()
        If Not scelta = "fine" Then
            Timer2.Start()
        Else
            seconda()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        prima()
        Timer1.Stop()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        scelta = "estrai"
        seconda()
        Timer2.Stop()
    End Sub

    Dim scelta As String
    Dim already As Boolean = False
    Private Async Sub seconda()
        Timer2.Stop()
        If scelta = "estrai" Then
            'Fase di estrazione del vecchio Fondamental
            Label2.Text = "Estraggo Fondamental.zip (OneDrive) ..."
            threadcomprimieestrai = New System.Threading.Thread(AddressOf MyBackgroundThread)
            threadcomprimieestrai.Start()
        End If
        If scelta = "copiaggio" Then
            'Fase di copiaggio dei dati nella cartella estratta
            Dim write As New StreamWriter(Application.StartupPath & "\extract\Fondamental\Settings\Changelog\" & versione & ".txt", False, System.Text.Encoding.Default)
            write.Write(installer.changelog.Text)
            write.Close()
            'If Not installer.Updater.Text = "Nessun percorso ..." Then
            '    File.Copy(installer.Updater.Text, Application.StartupPath & "\extract\Fondamental\Settings\Backup\updater.exe", True)
            '    File.Copy(installer.Updater.Text, Application.StartupPath & "\extract\Fondamental\Updater\updater.exe", True)
            'End If
            scelta = "comprimi"
            Label2.Text = "Modifico i File del database ..."
            Timer3.Start()
        End If
        If scelta = "comprimi" Then
            'Fase di compressione e sostituzione del vecchio
            Label2.Text = "Comprimo Fondamental.zip (OneDrive) ..."
            scelta = "comprimi"
            threadcomprimieestrai = New System.Threading.Thread(AddressOf MyBackgroundThread)
            threadcomprimieestrai.Start()
        End If
        If scelta = "fine" Then
            If already = False Then
                Label2.Text = "Concludo ..."
                already = True
                Dim task As New Task(Sub()
                                         Try
                                             Directory.Delete(Application.StartupPath & "\extract", True)
                                         Catch
                                         End Try
                                     End Sub)
                task.Start()
                Await task
                ' Qui chiede se vuoi pubblicare l'update anche a altre versioni
                ' If MessageBox.Show("Vuoi pubblicare quest'Aggiornamento OTA anche ad altre versioni?", "Altra Versione?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                '  versionedit.ComboBox1.Enabled = False
                ' versionedit.ComboBox2.Enabled = False
                ' versionedit.ComboBox3.Enabled = False
                '   versionedit.ShowDialog()
                '     If MessageBox.Show("Vuoi modificare il Changelog di questa versione?", "Modifichi?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                '   changelogset.ShowDialog()
                '  End If
                '      installerpubblica.updatedecide()
                '   already = False
                '  scelta = "fine"
                '  versione = installer.versione.Text
                '  versioneold = installer.versioneold.Text
                ' Label2.Text = "Creo i File MEGA per altra versione ..."
                '  Timer1.Start()
                '  Exit Sub
                ' End If
                'Alla fine avvia MEGA e OneDrive per fare l'Upload...ovviamente lo fa manuale
                If MessageBox.Show("Tutto fatto! Vuoi avviare OneDrive per pubblicare?", "Pubblico?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    'Try
                    '    Dim mega As New Process
                    '    With mega.StartInfo
                    '        .FileName = ("MEGAsync.exe")
                    '        .WorkingDirectory = "C:\Users\" & Environment.UserName & "\AppData\Local\MEGAsync\"
                    '    End With
                    '    mega.Start()
                    'Catch
                    'End Try
                    Try
                        Dim one As New Process
                        With one.StartInfo
                            .FileName = ("OneDrive.exe")
                            .WorkingDirectory = "C:\Users\" & Environment.UserName & "\AppData\Local\Microsoft\OneDrive\"
                        End With
                        one.Start()
                    Catch
                    End Try
                End If
                'Abbiamo finitooo
                main.Show()
            End If
        End If
    End Sub

    Dim onedrive As String = installer.onedrive.Text
    Dim threadcomprimieestrai As New Thread(AddressOf MyBackgroundThread)
    Private Sub MyBackgroundThread()
        Dim ex As String = onedrive
        If scelta = "estrai" Then
            Try
                Directory.Delete(Application.StartupPath & "\extract", True)
            Catch
            End Try
            Try
                Directory.CreateDirectory(Application.StartupPath & "\extract")
            Catch
            End Try
            Try
                ZipFile.ExtractToDirectory(ex, Application.StartupPath & "\extract")
            Catch
                MsgBox("Errore estrazione", MsgBoxStyle.Critical, "Errore")
            End Try
            dopoestrai()
        End If
        If scelta = "comprimi" Then
            Try
                File.Delete(ex)
            Catch
            End Try
            Try
                ZipFile.CreateFromDirectory(Application.StartupPath & "\extract", ex)
            Catch
                MsgBox("Errore compressione", MsgBoxStyle.Critical, "Errore")
            End Try
            dopoestrai()
        End If
    End Sub
    Private Delegate Sub lolok()
    Public Sub dopoestrai()
        If Me.InvokeRequired() Then
            Me.BeginInvoke(New lolok(AddressOf dopoestrai))
        End If
        threadcomprimieestrai.Abort()
        threadcomprimieestrai.Join()

        If scelta = "estrai" Then
            scelta = "copiaggio"
            seconda()
        Else
            scelta = "fine"
            seconda()
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        terza()
        Timer3.Stop()
    End Sub

    Private Sub terza()
        Timer3.Stop()
        Try
            File.Copy(installer.InstallerPath.Text, My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\updaterpath.txt") & "\INSTALLER.exe", True)
        Catch
            MsgBox("Errore copia INSTALLER")
        End Try
        Try
            File.WriteAllText(My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\updaterpath.txt") & "\INSTALLER\versione.txt", installer.codificaversione(versione))
        Catch
            MsgBox("Errore scrittura versione")
        End Try
        Try
            File.WriteAllText(My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\updaterpath.txt") & "\INSTALLER\ultimochangelog.txt", installer.changelog.Text, System.Text.Encoding.Default)
        Catch
            MsgBox("Errore scrittura ultimo changelog")
        End Try
        seconda()
    End Sub
End Class