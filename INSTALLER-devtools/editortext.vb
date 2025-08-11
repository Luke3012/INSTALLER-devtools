Imports System.IO

Public Class editortext
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RichTextBox1.ReadOnly = False
        Button2.Enabled = True
        Button3.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Public Sub updatebat()
        TextBox1.Text = explorer.mega.Text & "\" & explorer.ListBox1.Text & "\update.bat"
        RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(TextBox1.Text, System.Text.Encoding.Default)
    End Sub
    Public Sub updateoldbat()
        TextBox1.Text = explorer.mega.Text & "\" & explorer.ListBox1.Text & "\updateold.bat"
        RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(TextBox1.Text, System.Text.Encoding.Default)
    End Sub
    Public Sub changelog()
        TextBox1.Text = explorer.mega.Text & "\" & explorer.ListBox1.Text & "\changelogdownload.txt"
        RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(TextBox1.Text, System.Text.Encoding.Default)
    End Sub
    Public Sub changelogold()
        TextBox1.Text = explorer.mega.Text & "\" & explorer.ListBox1.Text & "\changelogdownloadold.txt"
        RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(TextBox1.Text, System.Text.Encoding.Default)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim write As New StreamWriter(TextBox1.Text, False, System.Text.Encoding.Default)
            write.Write(RichTextBox1.Text)
            write.Close()
            Close()
        Catch
            MsgBox("Errore salvataggio!", MsgBoxStyle.Critical, "Errore")
        End Try
    End Sub
End Class