Imports System.IO

Public Class whatfolder
    Private Sub whatfolder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
    End Sub

    Dim dir As String
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox1.Text = ""
        TextBox2.Text = "Fondamental\" & ComboBox1.SelectedItem
        If ComboBox1.SelectedItem = "\" Then
            TextBox2.Text = "Fondamental\"
        End If
        dir = TextBox2.Text
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox2.Text = dir & TextBox1.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Text = "Chiudi"
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ultimalettera As String = TextBox2.Text.Substring(TextBox2.Text.Length - 1)
        If ultimalettera = "\" Then
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                File.Copy(OpenFileDialog1.FileName, explorer.mega.Text & "\" & explorer.ListBox1.SelectedItem & "\" & explorer.ListBox2.SelectedItem & "\" & System.IO.Path.GetFileName(OpenFileDialog1.FileName), True)
                Dim path As String = explorer.mega.Text & "\" & explorer.ListBox1.SelectedItem & "\other.bat"
                Dim wow As Boolean
                If File.Exists(path) Then
                    If MessageBox.Show("Vuoi sostituire il file other.bat? Se hai combinato qualcosa fallo altrimenti (parere stesso di te stesso, Luca) NON FARLO CHE PERDI TUTTOOOOOO!!!", "Sovrascrivo?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                        wow = False
                    Else
                        wow = True
                        ' trova il coso done e lo elimina
                        Dim line As String
                        Dim Input As StreamReader
                        Dim PolicyIdCode As String
                        Dim strFile As New ArrayList
                        PolicyIdCode = "echo done>done.txt"
                        Input = File.OpenText(path)
                        While Input.Peek <> -1
                            line = Input.ReadLine
                            If Not line.Contains(PolicyIdCode) Then
                                strFile.Add(line)
                            End If
                        End While
                        Input.Close()
                        If File.Exists(path) Then
                            File.Delete(path)
                        End If
                        Dim objWriter As New System.IO.StreamWriter(path, True)
                        For Each item As String In strFile
                            objWriter.WriteLine(item)
                        Next
                        objWriter.Flush()
                        objWriter.Close()
                    End If
                Else
                    wow = False
                End If
                Dim write As New StreamWriter(path, wow)
                write.WriteLine("megatools get /Root/INSTALLER/UPDATER/" & explorer.ListBox1.SelectedItem & "/" & explorer.ListBox2.SelectedItem & "/" & System.IO.Path.GetFileName(OpenFileDialog1.FileName) & " --reload")
                write.WriteLine("cd .. & cd ..")
                    write.WriteLine("mkdir " & TextBox2.Text.Substring(0, TextBox2.Text.Length - 1))
                    write.WriteLine("move /Y Fondamental\Updater\" & System.IO.Path.GetFileName(OpenFileDialog1.FileName) & " " & TextBox2.Text)
                    write.WriteLine("cd Fondamental\Updater\")
                    write.WriteLine("echo done>done.txt")
                write.Close()
                If wow = True Then
                    Button2.Text = "no"
                End If
                Close()
                Else
                    MsgBox("Operazione Annullata", MsgBoxStyle.Exclamation, "Annullato")
                Button1.Text = "Chiudi"
                Close()
            End If
        Else
            MsgBox("L'ultimo carattere del percorso deve essere '\' !", MsgBoxStyle.Exclamation, "Attenzione!")
        End If
    End Sub
End Class