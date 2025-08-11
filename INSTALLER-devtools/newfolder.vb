Imports System.IO

Public Class newfolder
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub newfolder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            TextBox1.Text = "Fondamental\"
        End If
        If ComboBox1.SelectedIndex = 1 Then
            TextBox1.Text = "Fondamental\Settings\"
        End If
        If ComboBox1.SelectedIndex = 2 Then
            TextBox1.Text = "Fondamental\Updater\"
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox2.Enabled = True
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text = "" Then
            Button2.Enabled = False
        Else
            Button2.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MessageBox.Show("Vuoi creare una cartella nel percorso " & TextBox1.Text & TextBox2.Text & " ?", "Creo?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                Directory.CreateDirectory(Application.StartupPath & "\extract\" & TextBox1.Text & TextBox2.Text)
                If onedrive.Visible = True Then
                    Dim bho As String
                    bho = onedrive.ListBox1.SelectedItem
                    onedrive.after()
                    onedrive.ListBox1.SelectedItem = bho
                End If
                Close()
            Catch
                MsgBox("Errore", MsgBoxStyle.Critical, "!")
            End Try
        End If
    End Sub
End Class