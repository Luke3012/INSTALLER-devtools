Imports System.IO
Public Class cloneota
    Private Sub cloneota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.AddRange(explorer.ListBox1.Items)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Public versioneold As String
    Public versione As String = explorer.ListBox2.SelectedItem
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not ListBox1.SelectedIndex >= explorer.ListBox1.SelectedIndex And Not ListBox1.SelectedIndex <= 12 Then
            If MessageBox.Show("Sei sicuro/a di voler clonare l'OTA per la versione " & versione & " alla versione " & ListBox1.SelectedItem & " ?", "Clonare?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                versioneold = ListBox1.SelectedItem
                copychangelogs()
                If othercopy = True Then
                    File.Copy(explorer.mega.Text & "\" & explorer.ListBox1.SelectedItem & "\other.bat", explorer.mega.Text & "\" & ListBox1.SelectedItem & "\other.bat", True)
                End If
                ifquestion = True
                clone()
            End If
        Else
            MsgBox("Non puoi clonare a questa versione!", MsgBoxStyle.Exclamation, "Attenzione!")
        End If
    End Sub

    Public Sub copychangelogs()
        'Creiamo le cartelle MEGA
        Directory.CreateDirectory(explorer.mega.Text & "\" & versioneold & "\" & versione & "\Changelog")

        'Adesso dobbiamo copiare i Changelog nella cartella
        Dim limite1 As String = ListBox1.SelectedIndex
        Dim limite2 As String = explorer.ListBox1.Items.IndexOf(versione) - 1
        Dim versions As String = " [NUOVA: " & versione & "]"
        changelogmerge.Close()
        changelogmerge.RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(explorer.mega.Text & "\" & explorer.ListBox1.SelectedItem & "\" & explorer.ListBox2.SelectedItem & "\Changelog\" & explorer.ListBox2.SelectedItem & ".txt", System.Text.Encoding.Default)
        Do
            Try
                File.Copy(explorer.mega.Text & "\" & ListBox1.Items.Item(limite2 - 1) & "\" & ListBox1.Items.Item(limite2) & "\Changelog\" & ListBox1.Items.Item(limite2) & ".txt", explorer.mega.Text & "\" & versioneold & "\" & versione & "\Changelog\" & ListBox1.Items.Item(limite2) & ".txt", True)
                versions = versions & ", " & ListBox1.Items.Item(limite2)
                changelogmerge.RichTextBox1.Text = changelogmerge.RichTextBox1.Text & vbNewLine & vbNewLine
                changelogmerge.RichTextBox1.AppendText(My.Computer.FileSystem.ReadAllText(explorer.mega.Text & "\" & ListBox1.Items.Item(limite2 - 1) & "\" & ListBox1.Items.Item(limite2) & "\Changelog\" & ListBox1.Items.Item(limite2) & ".txt", System.Text.Encoding.Default))
            Catch
            End Try
            limite2 = limite2 - 1
        Loop Until limite2 = limite1
        'For Each file As String In Directory.GetFiles(explorer.mega.Text & "\" & ListBox1.SelectedItem & "\" & explorer.ListBox2.SelectedItem & "\Changelog\")
        '
        'Next

        'Aggiornato per Velocizzare
        'If MessageBox.Show("Vuoi unire il Changelog delle versioni" & versions & " ?", "Clonare Changelog?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
        changelogmerge.ShowDialog()
        'Else
        'installer.changelog.Text = My.Computer.FileSystem.ReadAllText(explorer.mega.Text & "\" & explorer.ListBox1.SelectedItem & "\" & explorer.ListBox2.SelectedItem & "\Changelog\" & explorer.ListBox2.SelectedItem & ".txt", System.Text.Encoding.Default)
        'End If
    End Sub

    Dim ifquestion As Boolean
    Private Sub clone()

        ' Ok iniziamo
        installer.versione.Text = versione
        installer.versioneold.Text = versioneold
        installer.mega.Text = explorer.mega.Text
        installerpubblica.updatedecide()

        'Ok bene..quindi abbiamo i file


        'Copiamo i File
        Try
            File.Delete(installer.mega.Text & "\" & versioneold & "\updateold.bat")
            File.Delete(installer.mega.Text & "\" & versioneold & "\changelogdownloadold.txt")
        Catch
        End Try
        My.Computer.FileSystem.RenameFile(installer.mega.Text & "\" & versioneold & "\update.bat", "updateold.bat")
        My.Computer.FileSystem.RenameFile(installer.mega.Text & "\" & versioneold & "\changelogdownload.txt", "changelogdownloadold.txt")
        File.Copy(explorer.mega.Text & "\" & explorer.ListBox1.SelectedItem & "\" & explorer.ListBox2.SelectedItem & "\Changelog\" & explorer.ListBox2.SelectedItem & ".txt", installer.mega.Text & "\" & versioneold & "\" & versione & "\Changelog\" & versione & ".txt", True)
        Dim write2 As New StreamWriter(installer.mega.Text & "\" & versioneold & "\" & versione & "\changelogdownload.bat", False, System.Text.Encoding.Default)
        write2.WriteLine(installerpubblica.RichTextBox2.Text)
        write2.Close()
        Dim write3 As New StreamWriter(installer.mega.Text & "\" & versioneold & "\" & versione & "\updatedownload.bat", False, System.Text.Encoding.Default)
        write3.WriteLine(installerpubblica.RichTextBox3.Text)
        write3.Close()
        Dim write4 As New StreamWriter(installer.mega.Text & "\" & versioneold & "\" & versione & "\updater.bat", False, System.Text.Encoding.Default)
        write4.WriteLine(installerpubblica.RichTextBox4.Text)
        write4.Close()
        Dim write5 As New StreamWriter(installer.mega.Text & "\" & versioneold & "\update.bat", False, System.Text.Encoding.Default)
        write5.WriteLine(installerpubblica.RichTextBox1.Text)
        write5.Close()
        Dim write6 As New StreamWriter(installer.mega.Text & "\" & versioneold & "\changelogdownload.txt", False, System.Text.Encoding.Default)
        write6.WriteLine(installer.changelog.Text)
        write6.Close()
        Dim write7 As New StreamWriter(installer.mega.Text & "\" & versioneold & "\updateinfo.txt", False, System.Text.Encoding.Default)
        write7.Write("1")
        write7.Close()
        File.Copy(installer.mega.Text & "\" & explorer.ListBox1.SelectedItem & "\" & explorer.ListBox2.SelectedItem & "\INSTALLER.exe", installer.mega.Text & "\" & versioneold & "\" & versione & "\INSTALLER.exe", True)

        checkother()
        If ifquestion = True Then
            If MessageBox.Show("Vuoi visualizzare l'OTA clonato?", "Visualizzare?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                explorer.ListBox1.SelectedItem = versioneold
                explorer.ListBox2.SelectedItem = versione
            End If
        End If
    End Sub

    Public Sub rebuild()
        versioneold = ListBox1.SelectedItem
        'Adesso dobbiamo copiare i Changelog nella cartella
        Dim limite1 As String = ListBox1.SelectedIndex
        Dim limite2 As String = explorer.ListBox1.Items.IndexOf(versione)
        Dim versions As String = " [NUOVA: " & versione & "]"
        changelogmerge.Close()
        installer.changelog.Text = My.Computer.FileSystem.ReadAllText(explorer.mega.Text & "\" & explorer.ListBox1.SelectedItem & "\" & explorer.ListBox2.SelectedItem & "\Changelog\" & explorer.ListBox2.SelectedItem & ".txt", System.Text.Encoding.Default)
        Do
            Try
                File.Copy(explorer.mega.Text & "\" & ListBox1.Items.Item(limite2 - 1) & "\" & ListBox1.Items.Item(limite2) & "\Changelog\" & ListBox1.Items.Item(limite2) & ".txt", explorer.mega.Text & "\" & versioneold & "\" & versione & "\Changelog\" & ListBox1.Items.Item(limite2) & ".txt", True)
                versions = versions & ", " & ListBox1.Items.Item(limite2)
                installer.changelog.Text = installer.changelog.Text & vbNewLine & vbNewLine
                installer.changelog.AppendText(My.Computer.FileSystem.ReadAllText(explorer.mega.Text & "\" & ListBox1.Items.Item(limite2 - 1) & "\" & ListBox1.Items.Item(limite2) & "\Changelog\" & ListBox1.Items.Item(limite2) & ".txt", System.Text.Encoding.Default))
            Catch
            End Try
            limite2 = limite2 - 1
        Loop Until limite2 <= limite1
        'Try
        'installer.changelog.Text = My.Computer.FileSystem.ReadAllText(explorer.mega.Text & "\" & explorer.ListBox1.SelectedItem & "\" & explorer.ListBox2.SelectedItem & "\Changelog\" & explorer.ListBox2.SelectedItem & ".txt", System.Text.Encoding.Default)
        'Catch
        'installer.changelog.Text = "VERSIONE " & explorer.ListBox2.SelectedItem & vbNewLine & "- Miglioramenti generali"
        'End Try

        ' Ok iniziamo
        installer.versione.Text = versione
        installer.versioneold.Text = versioneold
        installer.mega.Text = explorer.mega.Text
        installerpubblica.updatedecide()
        Dim write5 As New StreamWriter(installer.mega.Text & "\" & versioneold & "\update.bat", False, System.Text.Encoding.Default)
        write5.WriteLine(installerpubblica.RichTextBox1.Text)
        write5.Close()
        Dim write6 As New StreamWriter(installer.mega.Text & "\" & versioneold & "\changelogdownload.txt", False, System.Text.Encoding.Default)
        write6.WriteLine(installer.changelog.Text)
        write6.Close()
        Dim write7 As New StreamWriter(installer.mega.Text & "\" & versioneold & "\updateinfo.txt", False, System.Text.Encoding.Default)
        write7.Write("1")
        write7.Close()

        checkother()


    End Sub

    Public Sub rebuildlatest()
        versioneold = ListBox1.SelectedItem
        copychangelogs()
        If othercopy = True Then
            File.Copy(explorer.mega.Text & "\" & explorer.ListBox1.SelectedItem & "\other.bat", explorer.mega.Text & "\" & ListBox1.SelectedItem & "\other.bat", True)
        End If
        clone()
    End Sub

    Public Sub checkother()
        versioneold = ListBox1.SelectedItem
        'Se esiste other.bat ... fai e tarantell
        If File.Exists(explorer.mega.Text & "\" & versioneold & "\other.bat") Then
            'Qui trova la stringa e la elimina
            deldone()

            'E qua scrive il codice in più dentro a update.bat
            Dim path As String = explorer.mega.Text & "\" & versioneold & "\update.bat"
            Dim write As New StreamWriter(path, True)
            write.WriteLine("del other.bat")
            write.WriteLine("megatools get /Root/INSTALLER/UPDATER/" & versioneold & "/other.bat --reload")
            write.WriteLine("other.bat")
            write.Close()
        End If

        MsgBox("Tutto Fatto!", MsgBoxStyle.Exclamation, "OK")
        Close()
    End Sub

    Private Sub deldone()
        Dim line As String
        Dim Input As StreamReader
        Dim PolicyIdCode As String
        Dim strFile As New ArrayList
        PolicyIdCode = "echo done>done.txt"
        Input = File.OpenText(explorer.mega.Text & "\" & versioneold & "\update.bat")
        While Input.Peek <> -1
            line = Input.ReadLine
            If Not line.Contains(PolicyIdCode) Then
                strFile.Add(line)
            End If
        End While
        Input.Close()
        If File.Exists(explorer.mega.Text & "\" & versioneold & "\update.bat") Then
            File.Delete(explorer.mega.Text & "\" & versioneold & "\update.bat")
        End If
        Dim objWriter As New System.IO.StreamWriter(explorer.mega.Text & "\" & versioneold & "\update.bat", True)
        For Each item As String In strFile
            objWriter.WriteLine(item)
        Next
        objWriter.Flush()
        objWriter.Close()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Button2.Enabled = True
    End Sub

    Dim othercopy As Boolean
    Public Sub copyother()
        othercopy = True
    End Sub
End Class