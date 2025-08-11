Public Class newappimg
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            newapp.images.Add(OpenFileDialog1.FileName)
            loadimgs()
        End If
    End Sub

    Private Sub newappimg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadimgs()
    End Sub

    Private Sub loadimgs()
        ListBox1.Items.Clear()

        Try
            For count = 0 To newapp.images.Count - 1
                ListBox1.Items.Add(newapp.images.Item(count))
            Next
        Catch
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex = -1 Then
            Exit Sub
        End If

        Button3.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        newapp.images.RemoveAt(ListBox1.SelectedIndex)
        loadimgs()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            newapp.pic = OpenFileDialog1.FileName
            picperc.Text = OpenFileDialog1.FileName
        End If
    End Sub
End Class