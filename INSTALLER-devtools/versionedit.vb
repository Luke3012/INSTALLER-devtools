Public Class versionedit
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox2.Enabled = True
        Label2.Text = ComboBox1.Text & "." & ComboBox2.Text
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If Label6.Text = "nessuna" Then
            ComboBox6.Enabled = True
        Else
            Button1.Enabled = True
        End If
        ComboBox3.Enabled = True
        Label2.Text = ComboBox1.Text & "." & ComboBox2.Text
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Label2.Text = ComboBox1.Text & "." & ComboBox2.Text & "." & ComboBox3.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        installer.versione.Text = Label2.Text
        installer.versioneold.Text = Label6.Text
        Close()
    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox6.SelectedIndexChanged
        ComboBox5.Enabled = True
        Label6.Text = ComboBox6.Text & "." & ComboBox5.Text
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        ComboBox4.Enabled = True
        Label6.Text = ComboBox6.Text & "." & ComboBox5.Text
        Button1.Enabled = True
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        Label6.Text = ComboBox6.Text & "." & ComboBox5.Text & "." & ComboBox4.Text
        Button1.Enabled = True
    End Sub

    Private Sub versionedit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not installer.versioneold.Text = "..." Then
            Label6.Text = installer.versioneold.Text
        End If
    End Sub
End Class