Imports System.IO
Imports System.IO.Compression

Public Class onedrive
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not path.Text = "Nessuna File selezionato ..." Then

            If MessageBox.Show("Vuoi chiudere senza salvare?", "Chiudo?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                choose.Show()
                Close()
            End If
        Else
            choose.Show()
            Close()
        End If
    End Sub

    Private Sub onedrive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim read2 As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\installeronedrivepath.txt")
            path.Text = read2
            If Not File.Exists(path.Text) Then
                path.Text = "Nessun File selezionato ..."
            Else
                estrai()
            End If
        Catch
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            path.Text = OpenFileDialog1.FileName
            Dim write As New StreamWriter(Application.StartupPath & "\installeronedrivepath.txt")
            write.Write(path.Text)
            write.Close()
            estrai()
        End If
    End Sub

    Private Async Sub estrai()
        ProgressBar1.Style = ProgressBarStyle.Marquee
        stato.Text = "--- Estrazione in Corso ---"
        Dim estrazione As New Task(Sub()
                                       Dim extract As String = path.Text
                                       Try
                                           Directory.Delete(Application.StartupPath & "\extract", True)
                                       Catch
                                       End Try
                                       Try
                                           Directory.CreateDirectory(Application.StartupPath & "\extract")
                                       Catch
                                       End Try
                                       Try
                                           ZipFile.ExtractToDirectory(extract, Application.StartupPath & "\extract")
                                       Catch
                                           MsgBox("Errore estrazione", MsgBoxStyle.Critical, "Errore")
                                       End Try
                                   End Sub)
        estrazione.Start()
        Await estrazione
        stato.Text = "--- Tutto estratto perfettamente ---"
        ProgressBar1.Style = ProgressBarStyle.Blocks
        after()
    End Sub

    Public fondamental As String = Application.StartupPath & "\extract\Fondamental\"
    Public Sub after()
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        For Each folder As String In System.IO.Directory.GetDirectories(fondamental)
            ListBox1.Items.Add(IO.Path.GetFileName(folder))
        Next

        'Versione Fondamental
        Try
            fondvers.Text = File.ReadAllText(fondamental & "Settings\version.txt")
            fondvers.ReadOnly = False
        Catch
        End Try

        Button10.Enabled = True
        Button12.Enabled = False
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If Not ListBox1.SelectedIndex = -1 Then
            Button11.Enabled = False
            Button5.Enabled = True
            Button6.Enabled = True
            Button7.Enabled = True
            Button3.Enabled = False
            Button2.Enabled = False
            Button8.Enabled = True
            Button12.Enabled = True
            Button13.Enabled = True
            Button8.Text = "Elimina Cartella"
            ListBox2.Items.Clear()
            ListBox3.Items.Clear()
            Timer1.Start()

            For Each folder As String In System.IO.Directory.GetDirectories(fondamental & ListBox1.SelectedItem & "\")
                ListBox2.Items.Add(IO.Path.GetFileName(folder))
                ListBox3.Items.Add("Cartella")
            Next
            Dim files() As String = Directory.GetFiles(fondamental & ListBox1.SelectedItem & "\")
            For Each file As String In files
                ListBox2.Items.Add(IO.Path.GetFileName(file))
                ListBox3.Items.Add("File")
            Next
            current = fondamental & ListBox1.SelectedItem & "\"
            currenttext = "Fondamental\" & ListBox1.SelectedItem & "\"

            'Controlla se la cartella selezionata è quella di un app
            If File.Exists(fondamental & ListBox1.SelectedItem & "\" & "downloader32.ini") Or File.Exists(fondamental & ListBox1.SelectedItem & "\" & "downloader64.ini") Or File.Exists(fondamental & ListBox1.SelectedItem & "\" & "downloadercustom.ini") Then
                Button11.Enabled = True
            End If
        End If
    End Sub

    Dim currenttext As String
    Dim backtext As String
    Dim current As String
    Dim back As String
    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        If Not ListBox2.SelectedIndex = -1 Then

            Button8.Text = "Elimina Cartella"
            Button3.Enabled = False
            ListBox3.SelectionMode = SelectionMode.One
            ListBox3.SelectedIndex = ListBox2.SelectedIndex
            If ListBox3.SelectedItem = "Cartella" Then
                back = current
                backtext = currenttext
                Dim sel As String = ListBox2.SelectedItem
                ListBox2.Items.Clear()
                ListBox3.Items.Clear()
                For Each folder As String In System.IO.Directory.GetDirectories(current & sel & "\")
                    ListBox2.Items.Add(IO.Path.GetFileName(folder))
                    ListBox3.Items.Add("Cartella")
                Next
                Dim files() As String = Directory.GetFiles(current & sel & "\")
                For Each file As String In files
                    ListBox2.Items.Add(IO.Path.GetFileName(file))
                    ListBox3.Items.Add("File")
                Next
                current = current & sel & "\"
                currenttext = currenttext & sel & "\"
            End If
            If ListBox3.SelectedItem = "File" Then
                Button8.Text = "Elimina File"
                Button3.Enabled = True
            End If
            ListBox3.SelectionMode = SelectionMode.None
            Button2.Enabled = True
            Button8.Enabled = True

        End If
    End Sub

    Private Sub ListBox2_Click() Handles ListBox2.MouseMove
        ListBox3.TopIndex = ListBox2.TopIndex
    End Sub
    Private Sub ListBox2_Click2() Handles ListBox2.MouseWheel
        ListBox3.TopIndex = ListBox2.TopIndex
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ListBox3.TopIndex = ListBox2.TopIndex
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        For Each folder As String In System.IO.Directory.GetDirectories(back)
            ListBox2.Items.Add(IO.Path.GetFileName(folder))
            ListBox3.Items.Add("Cartella")
        Next
        Dim files() As String = Directory.GetFiles(back)
        For Each file As String In files
            ListBox2.Items.Add(IO.Path.GetFileName(file))
            ListBox3.Items.Add("File")
        Next
        current = back
        currenttext = backtext
        Button2.Enabled = False
        Button3.Enabled = False
        Button8.Text = "Elimina Cartella"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ListBox2.SelectedItem.ToString.Contains(".ini") Then
            newapp.Close()
            newapp.alternative = True
            newapp.percorsoalternativo = ListBox1.SelectedItem & "\"
            newapp.nomealternativo = ListBox2.SelectedItem.ToString.Replace(".ini", "")
            newapp.ShowDialog()
            reload()
            Exit Sub
        End If
        editortext.Close()
        editortext.TextBox1.Text = current & ListBox2.SelectedItem
        editortext.RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(editortext.TextBox1.Text, System.Text.Encoding.Default)
        editortext.ShowDialog()
    End Sub

    Private Async Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Fai un Backup!
        Try
            Dim fi As New FileInfo(path.Text)
            Try
                File.Delete(fi.DirectoryName & "\FondamentalBackup.zip")
            Catch
            End Try
            File.Copy(path.Text, fi.DirectoryName & "\FondamentalBackup.zip")
        Catch
            MsgBox("Errore durante la creazione del backup!", MsgBoxStyle.Exclamation, "Errore Backup Fondamental")
        End Try

        'Aggiorna Fondamental
        Try
            Dim write As New StreamWriter(fondamental & "Settings\version.txt")
            write.Write(fondvers.Text)
            write.Close()
        Catch
            MsgBox("Errore nell'Aggiornamento della Versione Fondamental!", MsgBoxStyle.Exclamation, "Errore")
        End Try

        'Aggiorna la Lista App
        Try
            File.Delete(fondamental & "contents")
            Dim write As New StreamWriter(fondamental & "contents", False, System.Text.Encoding.Default)
            For Each Item In ListBox1.Items
                write.WriteLine(Item)
            Next
            write.Close()
        Catch
            MsgBox("Errore nell'Aggiornamento delle App In Fondamental!", MsgBoxStyle.Exclamation, "Errorissimo!")
        End Try

        ProgressBar1.Style = ProgressBarStyle.Marquee
        stato.Text = "--- Compressione in Corso ---"
        Dim estrazione As New Task(Sub()
                                       Dim extract As String = path.Text
                                       Try
                                           File.Delete(extract)
                                       Catch
                                       End Try
                                       Try
                                           ZipFile.CreateFromDirectory(Application.StartupPath & "\extract", extract)
                                       Catch
                                           MsgBox("Errore compressione!", MsgBoxStyle.Critical, "Errore")
                                       End Try
                                       Try
                                           Directory.Delete(Application.StartupPath & "\extract", True)
                                       Catch
                                       End Try
                                   End Sub)
        estrazione.Start()
        Await estrazione
        stato.Text = "--- Tutto compresso perfettamente ---"
        ProgressBar1.Style = ProgressBarStyle.Blocks
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        Button5.Enabled = False
        Button3.Enabled = False
        Button2.Enabled = False
        Button8.Enabled = False
        Button12.Enabled = False

        'Controlla Versione Fondamental
        Try
            Dim fi As New FileInfo(path.Text)
            If Not File.ReadAllText(fi.DirectoryName & "\FondamentalVersion.txt") = fondvers.Text Then
                Dim write2 As New StreamWriter(fi.DirectoryName & "\FondamentalVersion.txt")
                write2.Write(fondvers.Text)
                write2.Close()
            End If
        Catch
            MsgBox("Errore nell'Aggiornamento della Versione Fondamental! (2)", MsgBoxStyle.Exclamation, "Errore (2)")
        End Try



        MsgBox("Tutto fatto, chiudo", MsgBoxStyle.Information, "OK")
        choose.Show()
        Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        newfolder.Close()
        newfolder.ShowDialog()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If Button8.Text = "Elimina File" Then
            If MessageBox.Show("Vuoi eliminare il file " & currenttext & ListBox2.SelectedItem & " ?", "Elimino File?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Try
                    File.Delete(current & ListBox2.SelectedItem)
                    Dim bho As String
                    bho = ListBox1.SelectedItem
                    after()
                    ListBox1.SelectedItem = bho
                Catch
                    MsgBox("Errore eliminazione!", MsgBoxStyle.Critical, "Errore")
                End Try
            End If
        Else
            If MessageBox.Show("Vuoi eliminare la cartella " & currenttext.Substring(0, currenttext.Length - 1) & " ?", "Elimino Cartella?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Try
                    Directory.Delete(current.Substring(0, current.Length - 1), True)
                    Dim bho As String
                    bho = ListBox1.SelectedItem
                    after()
                    ListBox1.SelectedItem = bho
                Catch
                    MsgBox("Errore eliminazione!", MsgBoxStyle.Critical, "Errore")
                End Try
            End If
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        newfile.Close()
        newfile.TextBox1.Text = current
        newfile.TextBox3.Text = currenttext
        newfile.ShowDialog()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Try
            Dim one As New Process
            With one.StartInfo
                .FileName = ("OneDrive.exe")
                .WorkingDirectory = "C:\Users\" & Environment.UserName & "\AppData\Local\Microsoft\OneDrive\"
            End With
            one.Start()
        Catch
        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim before As String = ListBox1.SelectedItem

        newapp.Close()
        newapp.ShowDialog()

        ListBox1.Items.Clear()
        For Each folder As String In System.IO.Directory.GetDirectories(fondamental)
            ListBox1.Items.Add(IO.Path.GetFileName(folder))
        Next

        ListBox1.SelectedItem = newapp.appname.Text
        If ListBox1.SelectedIndex < 0 And Not before = "" Then
            ListBox1.SelectedItem = before
        End If
    End Sub

    Private Sub fondvers_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fondvers.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim before As String = ListBox1.SelectedItem

        newapp.Close()
        newapp.editmode = True
        newapp.appname.Text = ListBox1.SelectedItem
        newapp.ShowDialog()

        ListBox1.SelectedIndex = -1
        ListBox1.SelectedItem = before
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim before As String = ListBox1.SelectedItem

        newapp.Close()
        newapp.alternative = True
        newapp.percorsoalternativo = ListBox1.SelectedItem & "\"
        newapp.ShowDialog()

        ListBox1.SelectedIndex = -1
        ListBox1.SelectedItem = before
    End Sub

    Dim filetocopy As String
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        filetocopy = current & ListBox2.SelectedItem
        Button14.Enabled = True
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        File.Copy(filetocopy, current & IO.Path.GetFileName(filetocopy), True)
        reload()
    End Sub

    Private Sub reload()
        Dim before As String = ListBox1.SelectedItem
        ListBox1.SelectedIndex = -1
        ListBox1.SelectedItem = before
    End Sub
End Class