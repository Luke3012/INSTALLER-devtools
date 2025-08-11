Imports System.IO

Public Class main
    ' Cose per il pannello
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub panel_MouseDown() Handles Me.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub
    Private Sub panel_MouseMove() Handles Me.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub panel_MouseUp() Handles Me.MouseUp
        drag = False
    End Sub
    ' Fine cose per il pannello

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        installer.Close()
        installer.Show()
        Close()
    End Sub
    Public Sub Button1_MouseLeave() Handles Button1.MouseLeave
        Button1.Font = New Font(Button1.Font, FontStyle.Regular)
    End Sub
    Public Sub Button1_MouseEnter() Handles Button1.MouseEnter
        Button1.Font = New Font(Button1.Font, FontStyle.Bold)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        updater.Show()
        Close()
    End Sub
    Public Sub Button2_MouseLeave() Handles Button2.MouseLeave
        Button2.Font = New Font(Button2.Font, FontStyle.Regular)
    End Sub
    Public Sub Button2_MouseEnter() Handles Button2.MouseEnter
        Button2.Font = New Font(Button2.Font, FontStyle.Bold)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub
    Public Sub Button3_MouseLeave() Handles Button3.MouseLeave
        Label1.Font = New Font(Label1.Font, FontStyle.Regular)
    End Sub
    Public Sub Button3_MouseEnter() Handles Button3.MouseEnter
        Label1.Font = New Font(Label1.Font, FontStyle.Bold)
    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        installer.Close()
        updater.Close()
        explorer.Close()
        onedrive.Close()
        'Controlla alcune cose
        If Not File.Exists("C:\Users\" & Environment.UserName & "\AppData\Local\Microsoft\OneDrive\OneDrive.exe") Then
            'MsgBox("OneDrive NON sembra essere INSTALLATO!", MsgBoxStyle.Exclamation, "OneDrive!")
        End If
        If Not File.Exists("C:\Users\" & Environment.UserName & "\AppData\Local\MEGAsync\MEGAsync.exe") Then
            'MsgBox("MEGA NON sembra essere INSTALLATO!", MsgBoxStyle.Exclamation, "MEGA!")
        End If
        Button4.Select()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        choose.Show()
        Close()
    End Sub
    Public Sub Button4_MouseLeave() Handles Button4.MouseLeave
        Button4.Font = New Font(Button4.Font, FontStyle.Regular)
    End Sub
    Public Sub Button4_MouseEnter() Handles Button4.MouseEnter
        Button4.Font = New Font(Button4.Font, FontStyle.Bold)
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        informazioni.ShowDialog()
    End Sub
    Public Sub Button5_MouseLeave() Handles Button5.MouseLeave
        Label2.Font = New Font(Label2.Font, FontStyle.Regular)
    End Sub
    Public Sub Button5_MouseEnter() Handles Button5.MouseEnter
        Label2.Font = New Font(Label2.Font, FontStyle.Bold)
    End Sub
End Class
