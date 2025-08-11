Public Class choose
    ' Cose per il pannello
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub panel_MouseDown() Handles Me.MouseDown, PictureBox1.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub
    Private Sub panel_MouseMove() Handles Me.MouseMove, PictureBox1.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub panel_MouseUp() Handles Me.MouseUp, PictureBox1.MouseUp
        drag = False
    End Sub
    ' Fine cose per il pannello

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        main.Show()
        Close()
    End Sub
    Public Sub Button3_MouseLeave() Handles Button3.MouseLeave
        Button3.Font = New Font(Button3.Font, FontStyle.Regular)
    End Sub
    Public Sub Button3_MouseEnter() Handles Button3.MouseEnter
        Button3.Font = New Font(Button3.Font, FontStyle.Bold)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        explorer.Show()
        Close()
    End Sub
    Public Sub Button1_MouseLeave() Handles Button1.MouseLeave
        Button1.Font = New Font(Button1.Font, FontStyle.Regular)
    End Sub
    Public Sub Button1_MouseEnter() Handles Button1.MouseEnter
        Button1.Font = New Font(Button1.Font, FontStyle.Bold)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        onedrive.Show()
        Close()
    End Sub
    Public Sub Button2_MouseLeave() Handles Button2.MouseLeave
        Button2.Font = New Font(Button2.Font, FontStyle.Regular)
    End Sub
    Public Sub Button2_MouseEnter() Handles Button2.MouseEnter
        Button2.Font = New Font(Button2.Font, FontStyle.Bold)
    End Sub


End Class