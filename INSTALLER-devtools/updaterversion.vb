Public Class updaterversion
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox2.Enabled = True
        Label4.Text = ComboBox1.Text
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Button2.Enabled = True
        Label5.Text = ComboBox2.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        updater.v1.Text = Label4.Text
        updater.v2.Text = Label5.Text
        Close()
    End Sub
End Class