Public Class newappdscr
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        newapp.description = RichTextBox1.Text
        Close()
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        check()
    End Sub

    Private Sub newappdscr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        check()
    End Sub

    Private Sub check()
        If RichTextBox1.Text.Replace(" ", "") = "" Then
            Button2.Enabled = False
        Else
            Button2.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MessageBox.Show("Elimino?", "?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            newapp.description = ""
            Close()
        End If
    End Sub
End Class