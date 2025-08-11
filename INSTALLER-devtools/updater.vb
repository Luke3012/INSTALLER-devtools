Imports System.IO
Imports MaterialSkin
Public Class updater

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            path.Text = OpenFileDialog1.FileName
        End If
        check()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        main.Show()
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            File.Copy(path.Text, folder.Text & "\Updaters\latest.exe", True)
            File.Copy(path.Text, folder.Text & "\Updaters\updater" & v1.Text & "." & v2.Text & ".exe", True)
            Dim write As New StreamWriter(folder.Text & "\updatercheck.txt")
            write.Write(v1.Text & v2.Text)
            write.Close()
            If MessageBox.Show("Tutto fatto! Vuoi avviare OneDrive per pubblicare?", "Pubblico?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Try
                    Dim one As New Process
                    With one.StartInfo
                        .FileName = ("OneDrive.exe")
                        .WorkingDirectory = "C:\Users\" & Environment.UserName & "\AppData\Local\Microsoft\OneDrive\"
                    End With
                    one.Start()
                Catch
                End Try
            End If
            main.Show()
        Catch
            MsgBox("Qualcosa è andato storto...riprova!", MsgBoxStyle.Critical, "OOPS")
        End Try
    End Sub

    Private Sub check()
        If Not path.Text = "Nessun File selezionato ..." And Not v1.Text = "" And Not v2.Text = "" And Not folder.Text = "Nessun Percorso selezionato ..." Then
            Button2.Enabled = True
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        updaterversion.ShowDialog()
        check()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            folder.Text = FolderBrowserDialog1.SelectedPath
            Dim write As New StreamWriter(Application.StartupPath & "\updaterpath.txt")
            write.Write(folder.Text)
            write.Close()
        End If
        check()
    End Sub

    Private Sub updater_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim read As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\updaterpath.txt")
            folder.Text = read
        Catch
        End Try
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
    End Sub
End Class