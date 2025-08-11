Imports System.IO
Public Class installer
    'Dichiarazioni se può pubblicare o meno (Tutte Boolean)
    'Dim MegaReady As Boolean = False
    Dim OneDriveReady As Boolean = False
    Dim ChangelogReady As Boolean = False
    Dim VersioneReady As Boolean = False
    Dim InstallerReady As Boolean = False
    'Dim UpdaterReady As Boolean = False


    Private Sub installer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try
        '    Dim read As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\installermegapath.txt")
        '    mega.Text = read
        '    If Not mega.Text = "" Then
        '        MegaReady = True
        '        Try
        '            Dim read2 As String = My.Computer.FileSystem.ReadAllText(mega.Text & "\latest.txt")
        '            versioneold.Text = read2
        '        Catch
        '        End Try
        '    End If
        'Catch
        'End Try
        Try
            Dim read2 As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\installeronedrivepath.txt")
            onedrive.Text = read2
            If File.Exists(onedrive.Text) Then
                If Not onedrive.Text = "" Then
                    Try
                        versioneold.Text = determinaversione(File.ReadAllText(My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\updaterpath.txt") & "\INSTALLER\versione.txt"))
                        OneDriveReady = True
                    Catch
                        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
                            Dim gg As New StreamWriter(Application.StartupPath & "\updaterpath.txt")
                            gg.Write(FolderBrowserDialog1.SelectedPath)
                            gg.Close()
                        End If
                        Try
                            versioneold.Text = determinaversione(File.ReadAllText(My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\updaterpath.txt") & "\INSTALLER\versione.txt"))
                            OneDriveReady = True
                        Catch
                        End Try
                    End Try
                End If
            Else
                onedrive.Text = "Nessun File selezionato ..."
            End If
        Catch
        End Try
        checkdone()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        main.Show()
        Close()
    End Sub

    Public Sub setchangelog()
        ChangelogReady = True
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If Not versione.Text = "..." Then
            changelogset.ShowDialog()
        Else
            MsgBox("Versione NON IMPOSTATA!", MsgBoxStyle.Exclamation, "Imposta prima la versione")
        End If
        checkdone()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            onedrive.Text = OpenFileDialog1.FileName
            Dim write As New StreamWriter(Application.StartupPath & "\installeronedrivepath.txt")
            write.Write(onedrive.Text)
            write.Close()
            Try
                versioneold.Text = determinaversione(File.ReadAllText(My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\updaterpath.txt") & "\INSTALLER\versione.txt"))
                OneDriveReady = True
            Catch
                If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
                    Dim gg As New StreamWriter(Application.StartupPath & "\updaterpath.txt")
                    gg.Write(FolderBrowserDialog1.SelectedPath)
                    gg.Close()
                End If
                Try
                    versioneold.Text = determinaversione(File.ReadAllText(My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\updaterpath.txt") & "\INSTALLER\versione.txt"))
                    OneDriveReady = True
                Catch
                End Try
            End Try
        End If
        checkdone()
    End Sub

    'Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    '    If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
    '        mega.Text = FolderBrowserDialog1.SelectedPath
    '        Dim write As New StreamWriter(Application.StartupPath & "\installermegapath.txt")
    '        write.Write(mega.Text)
    '        write.Close()
    '        MegaReady = True
    '        Try
    '            Dim read As String = My.Computer.FileSystem.ReadAllText(mega.Text & "\latest.txt")
    '            versioneold.Text = read
    '        Catch
    '        End Try
    '    End If
    '    checkdone()
    'End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'installerpubblica.ShowDialog()
        installermake.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        versionedit.ShowDialog()
        If Not versione.Text = "..." And Not versioneold.Text = "..." Then
            VersioneReady = True
        Else
            versione.Text = "..."
            versioneold.Text = "..."
        End If
        checkdone()
    End Sub

    Private Sub checkdone()
        Dim totale As Integer = 4
        'If MegaReady = True Then
        '    ListBox1.Items(0) = "Cartella MEGA (impostata)"
        '    totale = totale - 1
        'End If
        If OneDriveReady = True Then
            ListBox1.Items(0) = "File OneDrive (impostata)"
            totale = totale - 1
        End If
        If ChangelogReady = True Then
            ListBox1.Items(1) = "Scrivi Changelog (impostata)"
            totale = totale - 1
        End If
        If InstallerReady = True Then
            ListBox1.Items(2) = "Carica INSTALLER.exe (impostata)"
            totale = totale - 1
        End If
        If VersioneReady = True Then
            ListBox1.Items(3) = "Carica Versione (impostata)"
            totale = totale - 1
        End If
        'If UpdaterReady = True Then
        '    ListBox1.Items(5) = "Carica Updater.exe (imp. ,opzionale)"
        'End If
        ListBox1.Items(5) = "RIMANENTI = " & totale
        If ListBox1.Items(5) = "RIMANENTI = 0" Then
            Button2.Enabled = True
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If OpenFileDialog2.ShowDialog() = DialogResult.OK Then
            InstallerPath.Text = OpenFileDialog2.FileName
            InstallerReady = True
        End If
        checkdone()
    End Sub

    'Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
    '    If OpenFileDialog2.ShowDialog() = DialogResult.OK Then
    '        Updater.Text = OpenFileDialog2.FileName
    '        UpdaterReady = True
    '    End If
    '    checkdone()
    'End Sub

    Public Function determinaversione(numero As String)
        numero = numero.Insert(1, ".")

        If numero(numero.Length - 1) = "0" Then
            numero = numero.Substring(0, numero.Length - 1)
        Else
            numero = numero.Insert(3, ".")
        End If

        Return numero
    End Function

    Public Function codificaversione(numero As String)
        numero = numero.ToLower.Replace("versione", "").Replace(" ", "").Replace(".", "")
        If numero.Length < 3 Then numero = numero & "0"

        Return numero
    End Function
End Class