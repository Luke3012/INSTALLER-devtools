Public Class changelogset
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        Button2.Enabled = True
    End Sub

    Private Sub changelogset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "VERSIONE " & installer.versione.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        installer.changelog.Text = Label1.Text & vbNewLine & RichTextBox1.Text
        installer.setchangelog()
        Close()
    End Sub
End Class