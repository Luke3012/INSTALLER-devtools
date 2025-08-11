Imports System.IO
Imports System.Net

Public Class newapp
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        Close()
    End Sub

    Public images As List(Of String)
    Public pic As String = ""
    Public description As String = ""
    Dim fondamental As String
    Public editmode As Boolean = False
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles imagesbtn.Click
        newappimg.Close()
        If Not pic = "" Then newappimg.picperc.Text = pic
        If editmode = True Then newappimg.Button4.Enabled = False
        newappimg.ShowDialog()
    End Sub

    'Dichiara Variabili qui per risparmiare tempo...
    Dim name As String
    Dim d As String
    Dim p As String
    Dim n As String
    Dim sil As String
    Dim sp As String
    Dim con As String
    Dim adv As Boolean
    Dim noboot As Boolean
    Dim z As String
    Dim pz As String
    Dim v As String
    Private Async Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
        If appname.Text.Replace(" ", "") = "" Then
            MsgBox("Nome Vuoto!", MsgBoxStyle.Exclamation, "Impossibile Aggiungere!")
            Exit Sub
        End If
        If pic = "" And alternative = False Then
            MsgBox("Nessuna Immagine di Copertina Selezionata!", MsgBoxStyle.Exclamation, "Impossibile Aggiungere!")
            Exit Sub
        End If

        If Not Directory.Exists(fondamental & appname.Text) And alternative = False Then
            Directory.CreateDirectory(fondamental & appname.Text)
        End If
        delete()

        'Qui il Complesso...
        If enable32.Checked = True Or alternative = True Then
            name = name32.Text
            d = d32.Text
            Await ControllaGrandezza(sp32, adv32)
            p = p32.Text
            n = n32.Text
            sil = sil32.Text
            con = con32.Text
            sp = sp32.Text
            adv = False
            noboot = noboot32.Checked

            If adv32.Checked = True Then
                adv = True
                z = z32.Text
                pz = pz32.Text
                v = v32.Text
            End If
            If alternative = True Then
                Save(fondamental & percorsoalternativo & appname.Text & ".ini")
                Close()
                Exit Sub
            End If
            Save(fondamental & appname.Text & "\downloader32.ini")
        End If
        If enable64.Checked = True Then
            name = name64.Text
            d = d64.Text
            Await ControllaGrandezza(sp64, adv64)
            p = p64.Text
            n = n64.Text
            sil = sil64.Text
            con = con64.Text
            sp = sp64.Text
            adv = False
            noboot = noboot64.Checked

            If adv64.Checked = True Then
                adv = True
                z = z64.Text
                pz = pz64.Text
                v = v64.Text
            End If
            Save(fondamental & appname.Text & "\downloader64.ini")
        End If
        If enablecust.Checked = True Then
            name = namecust.Text
            d = dcust.Text
            Await ControllaGrandezza(spcust, advcust)
            p = pcust.Text
            n = ncust.Text
            sil = silcust.Text
            con = concust.Text
            sp = spcust.Text
            adv = False
            noboot = nobootcust.Checked

            If advcust.Checked = True Then
                adv = True
                z = zcust.Text
                pz = pzcust.Text
                v = vcust.Text
            End If
            Save(fondamental & appname.Text & "\downloadercustom.ini")
        End If

        'Qui Salva l'Immagine
        If Not editmode = True Then
            Try
                File.Delete(fondamental & appname.Text & "\image")
            Catch
            End Try
            Try
                File.Copy(pic, fondamental & appname.Text & "\image")
            Catch
                MsgBox("Errore durante l'Aggiunta dell'Immagine di Copertina!", MsgBoxStyle.Critical, "Errore!")
            End Try
        End If

        'Qui Salva le Immagini
        If Not editmode = True Then
            For Count = 0 To images.Count - 1
                Try
                    File.Copy(images.Item(Count), fondamental & appname.Text & "\pic" & Count + 1)
                Catch
                End Try
            Next
        End If

        'Qui Salva la Descrizione
        If Not description.Replace(" ", "") = "" Then
            File.WriteAllText(fondamental & appname.Text & "\description", description, System.Text.Encoding.Default)
        Else
            Try
                File.Delete(fondamental & appname.Text & "\description")
            Catch
            End Try
        End If

        'Qui Chiude
        Close()
    End Sub

    Private Sub Save(File As String)
        Dim write As New StreamWriter(File, False, System.Text.Encoding.Default)

        write.WriteLine("name=" & name)
        write.WriteLine("downloader.genericd=" & d)
        write.WriteLine("downloader.genericp=" & p)
        write.WriteLine("downloader.genericn=" & n)
        If Not sil.Replace(" ", "") = "" Then
            write.WriteLine("downloader.genericsil=" & sil)
        End If
        If Not sp.Replace(" ", "") = "" Then
            write.WriteLine("downloader.genericsp=" & sp)
        End If
        If Not con.Replace(" ", "") = "" Then
            write.WriteLine("downloader.genericcon=" & con)
        End If
        If adv = True Then
            write.WriteLine("downloader.genericz=\" & z)
            write.WriteLine("downloader.genericpz=" & z & "\" & pz)
            write.WriteLine("downloader.genericdel=" & z)
            write.WriteLine("downloader.genericv=" & v)
        End If
        If noboot Then write.WriteLine("downloader.noboot=true")

        write.Close()
    End Sub

    Private Sub delete()
        'Per Eliminare i File prima di Salvare...
        'Elimina i File Configurazione

        If alternative = True Then
            If File.Exists(fondamental & percorsoalternativo & appname.Text & ".ini") Then File.Delete(fondamental & percorsoalternativo & appname.Text & ".ini")
            Exit Sub
        End If
        Try
            File.Delete(fondamental & appname.Text & "\downloader32.ini")
        Catch
        End Try
        Try
            File.Delete(fondamental & appname.Text & "\downloader64.ini")
        Catch
        End Try
        Try
            File.Delete(fondamental & appname.Text & "\downloadercustom.ini")
        Catch
        End Try

        If editmode = True Then Exit Sub
        'Elimina le Immagini
        Dim theend As Boolean = False
        Dim Count As Integer = 1
        While theend = False
            If File.Exists(fondamental & appname.Text & "\pic" & Count) Then
                Try
                    File.Delete(fondamental & appname.Text & "\pic" & Count)
                Catch
                End Try
            Else
                theend = True
            End If
            Count += 1
        End While

    End Sub

    Private Sub adv32_CheckedChanged(sender As Object, e As EventArgs) Handles adv32.CheckedChanged
        If z32.Visible = False Then
            Label5.Visible = True
            z32.Visible = True
            Label6.Visible = True
            pz32.Visible = True
            Label7.Visible = True
            v32.Visible = True
        Else
            Label5.Visible = False
            z32.Visible = False
            Label6.Visible = False
            pz32.Visible = False
            Label7.Visible = False
            v32.Visible = False
        End If
    End Sub
    Private Sub adv64_CheckedChanged(sender As Object, e As EventArgs) Handles adv64.CheckedChanged
        If z64.Visible = False Then
            Label8.Visible = True
            z64.Visible = True
            Label9.Visible = True
            pz64.Visible = True
            Label10.Visible = True
            v64.Visible = True
        Else
            Label8.Visible = False
            z64.Visible = False
            Label9.Visible = False
            pz64.Visible = False
            Label10.Visible = False
            v64.Visible = False
        End If
    End Sub
    Private Sub advcust_CheckedChanged(sender As Object, e As EventArgs) Handles advcust.CheckedChanged
        If zcust.Visible = False Then
            Label15.Visible = True
            zcust.Visible = True
            Label16.Visible = True
            pzcust.Visible = True
            Label17.Visible = True
            vcust.Visible = True
        Else
            Label15.Visible = False
            zcust.Visible = False
            Label16.Visible = False
            pzcust.Visible = False
            Label17.Visible = False
            vcust.Visible = False
        End If
    End Sub

    Private Sub newapp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        images = New List(Of String)
        fondamental = onedrive.fondamental
        If editmode = True And alternative = False Then
            appname.ReadOnly = True
            If editmode = True Then
                imagesbtn.Enabled = False
                pic = fondamental & appname.Text & "\image"
            End If
            Try
                description = File.ReadAllText(fondamental & appname.Text & "\description", System.Text.Encoding.Default)
            Catch
            End Try

            LoadItems()
        End If
        If alternative Then loadalternative()
    End Sub

    Private Sub LoadItems()
        Dim lines As String()

        'Per 32
        If File.Exists(fondamental & appname.Text & "\downloader32.ini") Or alternative = True Then
            enable32.Checked = True
            If alternative = False Then
                lines = File.ReadAllLines(fondamental & appname.Text & "\downloader32.ini")
            Else
                lines = File.ReadAllLines(fondamental & percorsoalternativo & nomealternativo & ".ini")
            End If
            For Each line As String In lines
                Dim parts() As String = line.Split(New Char() {"="}, 2)
                If parts(0) = "name" Then
                    name32.Text = parts(1)
                End If
                If parts(0) = "downloader.genericd" Then
                    d32.Text = parts(1)
                End If
                If parts(0) = "downloader.genericp" Then
                    p32.Text = parts(1)
                End If
                If parts(0) = "downloader.genericn" Then
                    n32.Text = parts(1)
                End If
                If parts(0) = "downloader.genericsil" Then
                    sil32.Text = parts(1)
                End If

                If parts(0) = "downloader.genericpz" Then
                    adv32.Checked = True
                    pz32.Text = parts(1)
                End If
                If parts(0) = "downloader.genericdel" Then
                    z32.Text = parts(1)
                End If
                If parts(0) = "downloader.genericv" Then
                    v32.Text = parts(1)
                End If
                If parts(0) = "downloader.genericsp" Then
                    sp32.Text = parts(1)
                End If
                If parts(0) = "downloader.genericcon" Then
                    con32.Text = parts(1)
                End If
                If parts(0) = "downloader.noboot" Then
                    noboot32.Checked = True
                End If
            Next
            If adv32.Checked = True Then
                pz32.Text = Replace(pz32.Text, z32.Text & "\", "", , 1)
            End If
        End If

        'Per 64
        If File.Exists(fondamental & appname.Text & "\downloader64.ini") Then
            enable64.Checked = True
            lines = File.ReadAllLines(fondamental & appname.Text & "\downloader64.ini")
            For Each line As String In lines
                Dim parts() As String = line.Split(New Char() {"="}, 2)
                If parts(0) = "name" Then
                    name64.Text = parts(1)
                End If
                If parts(0) = "downloader.genericd" Then
                    d64.Text = parts(1)
                End If
                If parts(0) = "downloader.genericp" Then
                    p64.Text = parts(1)
                End If
                If parts(0) = "downloader.genericn" Then
                    n64.Text = parts(1)
                End If
                If parts(0) = "downloader.genericsil" Then
                    sil64.Text = parts(1)
                End If

                If parts(0) = "downloader.genericpz" Then
                    adv64.Checked = True
                    pz64.Text = parts(1)
                End If
                If parts(0) = "downloader.genericdel" Then
                    z64.Text = parts(1)
                End If
                If parts(0) = "downloader.genericv" Then
                    v64.Text = parts(1)
                End If
                If parts(0) = "downloader.genericsp" Then
                    sp64.Text = parts(1)
                End If
                If parts(0) = "downloader.genericcon" Then
                    con64.Text = parts(1)
                End If
                If parts(0) = "downloader.noboot" Then
                    noboot64.Checked = True
                End If
            Next
            If adv64.Checked = True Then
                pz64.Text = Replace(pz64.Text, z64.Text & "\", "", , 1)
            End If
        End If

        'Per Custom
        If File.Exists(fondamental & appname.Text & "\downloadercustom.ini") Then
            enablecust.Checked = True
            lines = File.ReadAllLines(fondamental & appname.Text & "\downloadercustom.ini")
            For Each line As String In lines
                Dim parts() As String = line.Split(New Char() {"="}, 2)
                If parts(0) = "name" Then
                    namecust.Text = parts(1)
                End If
                If parts(0) = "downloader.genericd" Then
                    dcust.Text = parts(1)
                End If
                If parts(0) = "downloader.genericp" Then
                    pcust.Text = parts(1)
                End If
                If parts(0) = "downloader.genericn" Then
                    ncust.Text = parts(1)
                End If
                If parts(0) = "downloader.genericsil" Then
                    silcust.Text = parts(1)
                End If

                If parts(0) = "downloader.genericpz" Then
                    advcust.Checked = True
                    pzcust.Text = parts(1)
                End If
                If parts(0) = "downloader.genericdel" Then
                    zcust.Text = parts(1)
                End If
                If parts(0) = "downloader.genericv" Then
                    vcust.Text = parts(1)
                End If
                If parts(0) = "downloader.genericsp" Then
                    spcust.Text = parts(1)
                End If
                If parts(0) = "downloader.genericcon" Then
                    concust.Text = parts(1)
                End If
                If parts(0) = "downloader.noboot" Then
                    nobootcust.Checked = True
                End If
            Next
            If advcust.Checked = True Then
                pzcust.Text = Replace(pzcust.Text, zcust.Text & "\", "", , 1)
            End If
        End If
    End Sub

    Private Sub enable32_CheckedChanged(sender As Object, e As EventArgs) Handles enable32.CheckedChanged
        If GroupBox1.Enabled = False Then
            GroupBox1.Enabled = True
        Else
            GroupBox1.Enabled = False
        End If
    End Sub

    Private Sub enable64_CheckedChanged(sender As Object, e As EventArgs) Handles enable64.CheckedChanged
        If GroupBox2.Enabled = False Then
            GroupBox2.Enabled = True
        Else
            GroupBox2.Enabled = False
        End If
    End Sub

    Private Sub enablecust_CheckedChanged(sender As Object, e As EventArgs) Handles enablecust.CheckedChanged
        If GroupBox3.Enabled = False Then
            GroupBox3.Enabled = True
        Else
            GroupBox3.Enabled = False
        End If
    End Sub

    Private Sub descriptionbtn_Click(sender As Object, e As EventArgs) Handles descriptionbtn.Click
        newappdscr.Close()
        newappdscr.RichTextBox1.Text = description
        newappdscr.Label1.Text = "Descrizione " & appname.Text
        newappdscr.ShowDialog()
    End Sub

    Public alternative As Boolean = False
    Public nomealternativo As String = ""
    Public percorsoalternativo As String = ""

    Private Sub loadalternative()
        cancelbtn.Width = v32.Width
        descriptionbtn.Visible = False
        imagesbtn.Visible = False
        GroupBox4.Left = cancelbtn.Left + cancelbtn.Width + 2
        Label25.Text = "Titolo Configurazione"
        appname.Left = 3
        Label25.Left = appname.Left
        appname.Text = nomealternativo
        GroupBox4.Width = appname.Width + 5
        add.Left = GroupBox4.Left + GroupBox4.Width + 2
        add.Width = sp32.Width
        If nomealternativo <> "" Then LoadItems()
        enable32.Checked = True
        enable32.Visible = False
        enable64.Visible = False
        enablecust.Visible = False
        GroupBox2.Visible = False
        GroupBox3.Visible = False
        GroupBox1.Text = "Proprietà Configurazione"
        Width = add.Left + add.Width + (cancelbtn.Left * 2)
        GroupBox1.Left = Width - (GroupBox1.Width * 1.5)
        Text = "Modifica / Aggiungi Configurazione"
        CenterToScreen()
    End Sub

    Private Async Function ControllaGrandezza(labelspace As TextBox, adv As CheckBox) As Task
        If d.Trim = "" Then Exit Function
        Cursor = Cursors.WaitCursor
        Dim backtext As String = Text
        Text = "Controllo la grandezza del File tramite Internet..."
        Enabled = False
        Dim checkl As Long = 0
        Dim check As New Task(Sub()
                                  Try
                                      Dim obj As New WebClient
                                      Dim s As Stream
                                      s = obj.OpenRead(d)
                                      checkl = Long.Parse(obj.ResponseHeaders("Content-Length").ToString())
                                      obj.CancelAsync()
                                  Catch
                                      checkl = 0
                                  End Try
                              End Sub)
        check.Start()
        Await check
        If Not checkl = 0 Then
            If adv.Checked = True Then checkl = checkl * 2.1
            labelspace.Text = checkl
        End If
        Enabled = True
        Text = backtext
        Cursor = Cursors.Default
    End Function

    Private Sub aggiornatestodrive(sender As Object, e As MouseEventArgs) Handles d32.MouseDoubleClick, d64.MouseDoubleClick, dcust.MouseDoubleClick
        Dim textboxy As TextBox = sender
        Dim testo As String = textboxy.Text

        Try
            testo = testo.Replace("<iframe src=""", "")
            testo = testo.Replace("/embed?", "/download?")
            Dim ueo As String() = testo.Split("""")
            testo = ueo(0)
            textboxy.Text = testo
        Catch
        End Try
    End Sub
End Class