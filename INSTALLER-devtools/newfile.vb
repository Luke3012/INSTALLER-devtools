Public Class newfile
    Dim pathfile As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            pathfile = OpenFileDialog1.FileName
            TextBox2.Text = System.IO.Path.GetFileName(OpenFileDialog1.FileName)
            TextBox2.ReadOnly = False
            Button3.Show()
        End If
    End Sub

    Private Sub newfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button3.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MessageBox.Show("Vuoi caricare il File " & pathfile & " con il nome di " & TextBox2.Text & " in " & TextBox3.Text & " ?", "Carico?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                System.IO.File.Copy(pathfile, TextBox1.Text & TextBox2.Text, True)
                If onedrive.Visible = True Then
                    Dim bho As String
                    bho = onedrive.ListBox1.SelectedItem
                    onedrive.after()
                    onedrive.ListBox1.SelectedItem = bho
                End If
                Close()
            Catch
                MsgBox("Errore caricamento del file!", MsgBoxStyle.Critical, "Errore")
            End Try
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text = "" Then
            Button3.Enabled = False
        Else
            Button3.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class