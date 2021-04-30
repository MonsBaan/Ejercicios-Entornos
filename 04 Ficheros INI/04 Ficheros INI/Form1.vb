Public Class Form1
    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        If rbWin.Checked Then
            cargarArchivo("C:\Windows\win.ini")
        ElseIf rbSystem.Checked Then
            cargarArchivo("C:\Windows\system.ini")

        ElseIf rbArchivo.Checked Then
            cargarArchivo(txtArchivo.Text)


        End If
    End Sub

    Private Sub cargarArchivo(ruta As String)
        Dim fich As IO.StreamReader
        Try
            fich = New IO.StreamReader(ruta)
        Catch ex As Exception
            MessageBox.Show("Hay que elegir un archivo")
            Return
        End Try
        Dim linea As String
        txtContenido.Text = ""
        lstSecciones.Items.Clear()
        lstSecciones.Items.Add("TODO")
        Do While Not fich.EndOfStream
            linea = fich.ReadLine
            txtContenido.Text = txtContenido.Text + linea + vbCrLf
            If linea.StartsWith("[") Then
                lstSecciones.Items.Add(linea)
            End If

        Loop
        fich.Close()


    End Sub

    Private Sub btnElegir_Click(sender As Object, e As EventArgs) Handles btnElegir.Click
        dlgAbrir.InitialDirectory = Microsoft.VisualBasic.FileIO.SpecialDirectories.ProgramFiles
        dlgAbrir.Filter = "Ficheros INI|*.ini|Todos los ficheros|*.*|Ficheros de Texto|*.txt"
        dlgAbrir.FilterIndex = 1
        If dlgAbrir.ShowDialog() = DialogResult.OK Then
            txtArchivo.Text = dlgAbrir.FileName
        End If



    End Sub
End Class
