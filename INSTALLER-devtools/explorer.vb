Imports System.IO

Public Class explorer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        choose.Show()
        Close()
    End Sub

    Private Sub explorer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ListBox1.Items.Clear()
            Dim read As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\installermegapath.txt")
            mega.Text = read
            caricacartelle()
        Catch
        End Try
    End Sub

    Private Sub caricacartelle()
        'Carica le cartelle...
        ListBox1.Items.Clear()
        ListBox1.Enabled = True
        Dim checkcartelle() As String
        For Each folder As String In System.IO.Directory.GetDirectories(mega.Text & "\")
            ListBox1.Items.Add(Path.GetFileName(folder))
        Next
        checkcartelle = Directory.GetDirectories(mega.Text & "\")
        Convert.ToInt32(checkcartelle.Length)
        If checkcartelle.Length = 0 Then
            MsgBox("Nessuna cartella presente! Hai sbagliato selezione!", MsgBoxStyle.Critical, "Errore!")
            ListBox1.Items.Clear()
            ListBox1.Enabled = False
            Exit Sub
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            mega.Text = FolderBrowserDialog1.SelectedPath
            Dim write As New StreamWriter(Application.StartupPath & "\installermegapath.txt")
            write.Write(mega.Text)
            write.Close()
            caricacartelle()
        End If
    End Sub

    Dim selezionato As String
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Try
            'Mostra le cose
            controllo.Enabled = True
            selezionato = mega.Text & "\" & ListBox1.SelectedItem
            ListBox2.Items.Clear()
            For Each folder As String In System.IO.Directory.GetDirectories(selezionato & "\")
                ListBox2.Items.Add(Path.GetFileName(folder))
            Next

            'Calcola il resto delle cose
            Dim updatereader As New System.IO.StreamReader(selezionato & "\updateinfo.txt", System.Text.Encoding.Default)
            If updatereader.ReadLine = "0" Then
                TextBox1.Text = "Nessun OTA è stato pubblicato per questo Update!"
                Button2.Enabled = False
                Button4.Enabled = False
            Else
                If ListBox2.Items.Count = 1 Then
                    TextBox1.Text = "E' stato pubblicato 1 agg. OTA per questo Update!"
                Else
                    TextBox1.Text = "Sono stati pubblicati " & ListBox2.Items.Count & " agg. OTA per questo Update!"
                End If
                Button2.Enabled = True
                Button4.Enabled = True
            End If
            updatereader.Close()
            If Not File.Exists(selezionato & "\updateold.bat") Then
                Button7.Enabled = False
            Else
                Button7.Enabled = True
            End If
            If Not File.Exists(selezionato & "\other.bat") Then
                Button12.Enabled = False
            Else
                Button12.Enabled = True
            End If
            If Not File.Exists(selezionato & "\changelogdownloadold.txt") Then
                Button15.Enabled = False
            Else
                Button15.Enabled = True
            End If
            If ListBox1.SelectedItem = ListBox1.Items.Item(ListBox1.Items.Count - 2) Or ListBox1.SelectedItem = ListBox1.Items.Item(ListBox1.Items.Count - 1) Then
                Button14.Enabled = False
            Else
                Button14.Enabled = True
            End If

            'Alla fine
            lavoro.Enabled = False
            Button5.Enabled = False
            Button13.Enabled = False
        Catch
            controllo.Enabled = False
            lavoro.Enabled = False
        End Try
    End Sub

    Dim selezionato2 As String
    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        If Not ListBox2.SelectedIndex = -1 Then
            ListBox3.Items.Clear()
            selezionato2 = selezionato & "\" & ListBox2.SelectedItem & "\"
            Dim files() As String = Directory.GetFiles(selezionato & "\" & ListBox2.SelectedItem & "\")
            For Each file As String In files
                ListBox3.Items.Add(Path.GetFileName(file))
            Next
            If File.Exists(selezionato2 & "Changelog\" & ListBox2.SelectedItem & ".txt") Then
                For Each file As String In Directory.GetFiles(selezionato & "\" & ListBox2.SelectedItem & "\Changelog\")
                    ListBox3.Items.Add("Changelog\" & Path.GetFileName(file))
                Next
            End If
            lavoro.Enabled = True
        End If
    End Sub

    Private Sub ListBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox3.SelectedIndexChanged
        If Not ListBox3.SelectedIndex = -1 Then

            Button5.Enabled = True

            If Not ListBox3.SelectedItem = "INSTALLER.exe" And Not ListBox3.SelectedItem = "changelogdownload.bat" And Not ListBox3.SelectedItem = "updatedownload.bat" And Not ListBox3.SelectedItem = "updater.bat" And Not ListBox3.SelectedItem = "Changelog\" & ListBox2.SelectedItem & ".txt" Then
                Button13.Enabled = True
            Else
                Button13.Enabled = False
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        editortext.Close()
        editortext.changelog()
        editortext.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        editortext.Close()
        editortext.updatebat()
        editortext.ShowDialog()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        editortext.Close()
        editortext.updateoldbat()
        editortext.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Se si ha cliccato INSTALLER.exe
        If ListBox3.SelectedItem = "INSTALLER.exe" Then
            OpenFileDialog1.InitialDirectory = mega.Text & "\" & ListBox1.SelectedItem & "\" & ListBox2.SelectedItem
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                File.Copy(OpenFileDialog1.FileName, selezionato2 & "INSTALLER.exe", True)
            End If
            Exit Sub
        End If

        Try
            editortext.Close()
            editortext.TextBox1.Text = selezionato2 & ListBox3.SelectedItem
            editortext.RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(editortext.TextBox1.Text, System.Text.Encoding.Default)
            editortext.ShowDialog()
        Catch
            MsgBox("Ci ho provato... ma qualcosa è andato storto!", MsgBoxStyle.Critical, "Errore")
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        cloneota.Close()
        If File.Exists(mega.Text & "\" & ListBox1.SelectedItem & "\other.bat") Then
            If MessageBox.Show("Vuoi clonare anche il file other.bat? [Se eliminerai i file a cui esso è legato non funzionerà più!]", "Clono other.bat?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                cloneota.copyother()
            End If
        End If
        cloneota.ShowDialog()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If MessageBox.Show("Sei sicuro/a di voler ricostruire l'OTA selezionato per questa versione?", "Ricostruisco?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            If File.Exists(mega.Text & "\" & ListBox1.SelectedItem & "\other.bat") Then
                If Not MessageBox.Show("Sei sicuro/a di voler continuare? Il file other.bat sarà invalidato!", "Sicuro?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    Exit Sub
                End If
            End If
            File.Delete(mega.Text & "\" & ListBox1.SelectedItem & "\other.bat")
            cloneota.Close()
            cloneota.ListBox1.Items.AddRange(ListBox1.Items)
            cloneota.ListBox1.SelectedItem = ListBox1.SelectedItem
            cloneota.rebuild()
            Dim bho As String = ListBox1.SelectedItem
            Dim bho2 As String = ListBox2.SelectedItem
            ListBox1.SelectedIndex = -1
            ListBox1.SelectedItem = bho
            ListBox2.SelectedItem = bho2
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        newfile.Close()
        newfile.TextBox1.Text = mega.Text & "\" & ListBox1.SelectedItem & "\" & ListBox2.SelectedItem & "\"
        whatfolder.Close()
        whatfolder.ShowDialog()
        'Se annulla
        If whatfolder.Button1.Text = "Chiudi" Then
            Exit Sub
        End If
        'Se non si sovrascrive
        If whatfolder.Button2.Text = "no" Then
            MsgBox("Tutto Fatto!", MsgBoxStyle.Exclamation, "OK")
            Dim bhog As String = ListBox1.SelectedItem
            Dim bho2g As String = ListBox2.SelectedItem
            ListBox1.SelectedIndex = -1
            ListBox1.SelectedItem = bhog
            ListBox2.SelectedItem = bho2g
            Exit Sub
        End If
        'Se continua, se si sovrascrive o si crea un other.bat nuovo
        cloneota.Close()
        cloneota.ListBox1.Items.AddRange(ListBox1.Items)
        cloneota.ListBox1.SelectedItem = ListBox1.SelectedItem
        cloneota.checkother()
        Dim bho As String = ListBox1.SelectedItem
        Dim bho2 As String = ListBox2.SelectedItem
        ListBox1.SelectedIndex = -1
        ListBox1.SelectedItem = bho
        ListBox2.SelectedItem = bho2
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If ListBox2.SelectedItem = ListBox1.Items(ListBox1.SelectedIndex + 1) Then
            MsgBox("Non puoi Cancellare questo OTA in quanto è Richiesto per coordinare gli altri!", MsgBoxStyle.Exclamation, "Non puoi Eliminare!")
            Exit Sub
        End If

        Dim myline As String
        myline = File.ReadAllLines(mega.Text & "\" & ListBox1.SelectedItem & "\update.bat").ElementAt(2).ToString
        If myline.Contains("get /Root/INSTALLER/UPDATER/" & ListBox1.SelectedItem & "/" & ListBox2.SelectedItem & "/INSTALLER.exe --reload") Then
            If MessageBox.Show("Sei sicuro di voler eliminare quest'Update? L'OTA che vuoi cancellare coincide con quello che l'utente deve scaricare...procedo?", "Elimino?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Directory.Delete(mega.Text & "\" & ListBox1.SelectedItem & "\" & ListBox2.SelectedItem, True)
                Dim bho As String = ListBox1.SelectedItem
                ListBox1.SelectedIndex = -1
                ListBox1.SelectedItem = bho
            End If
        Else
            If MessageBox.Show("Sei sicuro di voler eliminare quest'OTA?", "Elimino?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Directory.Delete(mega.Text & "\" & ListBox1.SelectedItem & "\" & ListBox2.SelectedItem, True)
                Dim bho As String = ListBox1.SelectedItem
                ListBox1.SelectedIndex = -1
                ListBox1.SelectedItem = bho
            End If
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Try
            Dim mega As New Process
            With mega.StartInfo
                .FileName = ("MEGAsync.exe")
                .WorkingDirectory = "C:\Users\" & Environment.UserName & "\AppData\Local\MEGAsync\"
            End With
            mega.Start()
        Catch
        End Try
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        editortext.Close()
        editortext.TextBox1.Text = mega.Text & "\" & ListBox1.SelectedItem & "\other.bat"
        editortext.RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(editortext.TextBox1.Text, System.Text.Encoding.Default)
        editortext.ShowDialog()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If MessageBox.Show("Vuoi eliminare il File selezionato?", "Elimino?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                File.Delete(mega.Text & "\" & ListBox1.SelectedItem & "\" & ListBox2.SelectedItem & "\" & ListBox3.SelectedItem)
                Dim bho As String = ListBox1.SelectedItem
                Dim bho2 As String = ListBox2.SelectedItem
                ListBox1.SelectedIndex = -1
                ListBox1.SelectedItem = bho
                ListBox2.SelectedItem = bho2
            Catch
                MsgBox("Errore eliminzione File!", MsgBoxStyle.Critical, "Errore")
            End Try
        End If
    End Sub

    Public toselect As String
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If MessageBox.Show("Vuoi clonare l'Ultimo OTA disponibile? (" & ListBox1.Items.Item(ListBox1.Items.Count - 1) & " , se disponibile il file other.bat sarà clonato anche esso)", "Clono ultima versione?", MessageBoxButtons.YesNo) = DialogResult.Yes Then

            Dim save1 As Integer = ListBox1.SelectedIndex
            toselect = ListBox1.SelectedItem
            cloneota.Close()
            ListBox1.SelectedIndex = ListBox1.Items.Count - 2
            ListBox2.SelectedItem = ListBox1.Items.Item(ListBox1.Items.Count - 1)
            cloneota.Show()
            cloneota.Hide()
            cloneota.ListBox1.SelectedItem = toselect
            If File.Exists(mega.Text & "\" & ListBox1.SelectedItem & "\other.bat") Then
                cloneota.copyother()
            End If
            cloneota.rebuildlatest()
            cloneota.Close()
            ListBox1.SelectedIndex = save1
            ListBox2.SelectedItem = ListBox1.Items.Item(ListBox1.Items.Count - 1)

        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        editortext.Close()
        editortext.changelogold()
        editortext.ShowDialog()
    End Sub
End Class