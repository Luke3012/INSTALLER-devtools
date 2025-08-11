Public Class changelogmerge
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        installer.changelog.Text = RichTextBox1.Text
        Close()
    End Sub

    Private Sub changelogmerge_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Per Velocizzare
        Button1.PerformClick()
    End Sub
End Class