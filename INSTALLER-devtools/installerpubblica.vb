Public Class installerpubblica
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub installerpubblica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updatedecide()

    End Sub

    Public Sub updatedecide()
        RichTextBox1.Text = "del done.txt" & vbNewLine &
            "echo download>download.txt" & vbNewLine &
            "megatools get /Root/INSTALLER/UPDATER/" & installer.versioneold.Text & "/" & installer.versione.Text & "/INSTALLER.exe --reload" & vbNewLine &
            "echo install>install.txt" & vbNewLine &
            "megatools copy --local Changelog --remote /Root/INSTALLER/UPDATER/" & installer.versioneold.Text & "/" & installer.versione.Text & "/Changelog --download --reload" & vbNewLine &
            "cd .." & vbNewLine & "cd .." & vbNewLine & "del INSTALLER.exe" & vbNewLine & "move /Y Fondamental\Updater\INSTALLER.exe" & vbNewLine & "xcopy /y Fondamental\Updater\Changelog Fondamental\Settings\Changelog" & vbNewLine & "rmdir /s /q Fondamental\Updater\Changelog" & vbNewLine &
            "cd Fondamental\Updater\" & vbNewLine & "echo finish>finish.txt" & vbNewLine & "del changelogdownload.bat" & vbNewLine & "del updatedownload.bat" & vbNewLine & "del updater.bat" & vbNewLine &
            "megatools get /Root/INSTALLER/UPDATER/" & installer.versioneold.Text & "/" & installer.versione.Text & "/updater.bat --reload" & vbNewLine &
            "megatools get /Root/INSTALLER/UPDATER/" & installer.versioneold.Text & "/" & installer.versione.Text & "/changelogdownload.bat --reload" & vbNewLine &
            "megatools get /Root/INSTALLER/UPDATER/" & installer.versioneold.Text & "/" & installer.versione.Text & "/updatedownload.bat --reload" & vbNewLine &
            "echo done>done.txt"

        RichTextBox2.Text = "del done.txt & del changelogdownload.txt & megatools get /Root/INSTALLER/UPDATER/" & installer.versione.Text & "/changelogdownload.txt --reload"
        RichTextBox3.Text = "del done.txt & del update.bat & megatools get /Root/INSTALLER/UPDATER/" & installer.versione.Text & "/update.bat --reload & update.bat"
        RichTextBox4.Text = "del done.txt & del updateinfo.txt & megatools get /Root/INSTALLER/UPDATER/" & installer.versione.Text & "/updateinfo.txt --reload"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        installermake.ShowDialog()
    End Sub
End Class