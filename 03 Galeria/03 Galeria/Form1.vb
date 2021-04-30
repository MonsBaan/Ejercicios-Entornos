Public Class Form1
    Dim arrayFotos As ArrayList
    Dim indexActual As Integer = 0
    Dim ventanaMax As Boolean = False
    Private Sub btnCarpeta_Click(sender As Object, e As EventArgs) Handles btnCarpeta.Click
        Dim fich As String

        dlgCarpeta.RootFolder = Environment.SpecialFolder.MyPictures
        If dlgCarpeta.ShowDialog = DialogResult.Cancel Then
            Return
        End If

        txtCarpeta.Text = dlgCarpeta.SelectedPath + "\"
        If dlgCarpeta.SelectedPath.Length > 2 Then
            dlgCarpeta.SelectedPath = dlgCarpeta.SelectedPath & "\"
        End If

        fich = Dir(txtCarpeta.Text)
        txtArchivo.Text = fich

        Try
            arrayFotos.Add(fich)
        Catch ex As Exception
        End Try

        Do While fich <> ""
            fich = Dir()
            Try
                arrayFotos.Add(fich)
            Catch ex As Exception
            End Try
        Loop

        btnPrimero.Enabled = True
        btnAnterior.Enabled = True
        btnSiguiente.Enabled = True
        btnUltimo.Enabled = True
        panelModo.Enabled = True

        cargarFoto(0)
        ProgressBar1.Maximum = arrayFotos.Count - 2

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        arrayFotos = New ArrayList
    End Sub


    Private Sub cargarFoto(numImg As Integer)

        Try
            If indexActual = 0 Then
                btnPrimero.Enabled = False
                btnAnterior.Enabled = False
                btnSiguiente.Enabled = True
                btnUltimo.Enabled = True

            ElseIf indexActual = arrayFotos.count - 2 Then
                btnUltimo.Enabled = False
                btnSiguiente.Enabled = False
                btnPrimero.Enabled = True
                btnAnterior.Enabled = True

            Else
                btnPrimero.Enabled = True
                btnAnterior.Enabled = True
                btnSiguiente.Enabled = True
                btnUltimo.Enabled = True
            End If

            picFoto.Load(dlgCarpeta.SelectedPath & arrayFotos.Item(numImg))
            txtArchivo.Text = arrayFotos.Item(numImg)
        Catch ex As Exception
        End Try


    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        indexActual = 0
        cargarFoto(indexActual)
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        indexActual = indexActual - 1
        cargarFoto(indexActual)
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        indexActual = indexActual + 1
        cargarFoto(indexActual)
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        indexActual = arrayFotos.Count - 2
        cargarFoto(indexActual)
    End Sub

    Private Sub BarraHorizontal_Scroll(sender As Object, e As ScrollEventArgs) Handles BarraHorizontal.Scroll
        picFoto.Width = BarraHorizontal.Value

        If chkCuadrado.Checked Then
            BarraVertical.Value = BarraHorizontal.Value
            picFoto.Height = BarraVertical.Value

        End If

    End Sub

    Private Sub BarraVertical_Scroll(sender As Object, e As ScrollEventArgs) Handles BarraVertical.Scroll
        picFoto.Height = BarraVertical.Value

        If chkCuadrado.Checked Then
            BarraHorizontal.Value = BarraVertical.Value
            picFoto.Width = BarraHorizontal.Value
        End If
    End Sub


    Private Sub chkAjustar_CheckedChanged(sender As Object, e As EventArgs) Handles chkAjustar.CheckedChanged
        If chkAjustar.Checked Then
            picFoto.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            picFoto.SizeMode = PictureBoxSizeMode.Normal
        End If
    End Sub

    Private Sub btnAmpliar_Click(sender As Object, e As EventArgs) Handles btnAmpliar.Click
        timerVentana.Start()
        btnAmpliar.Enabled = False
    End Sub

    Private Sub timerVentana_Tick(sender As Object, e As EventArgs) Handles timerVentana.Tick

        If ventanaMax Then
            Me.Width = Me.Width - 10
            If Me.Width <= 655 Then
                ventanaMax = False
                btnAmpliar.Enabled = True
                btnAmpliar.Text = ">>"
                timerVentana.Stop()

            End If
        Else
            Me.Width = Me.Width + 10
            If Me.Width >= 900 Then
                ventanaMax = True
                btnAmpliar.Enabled = True
                btnAmpliar.Text = "<<"
                timerVentana.Stop()

            End If
        End If
    End Sub

    Private Sub rbManual_Click(sender As Object, e As EventArgs) Handles rbManual.Click
        panelManual.Enabled = True
        panelAuto.Enabled = False
        timerAuto.Stop()
    End Sub

    Private Sub rbAuto_Click(sender As Object, e As EventArgs) Handles rbAuto.Click
        panelAuto.Enabled = True
        panelManual.Enabled = False
    End Sub

    Private Sub numTiempo_ValueChanged(sender As Object, e As EventArgs) Handles numTiempo.ValueChanged
        timerAuto.Interval = numTiempo.Value * 1000
    End Sub

    Private Sub btnEmpezar_Click(sender As Object, e As EventArgs) Handles btnEmpezar.Click
        If btnEmpezar.Text = "Empezar" Then
            timerAuto.Start()
            btnEmpezar.Text = "Pausar"
        ElseIf btnEmpezar.Text = "Pausar" Then
            timerAuto.Stop()
            btnEmpezar.Text = "Empezar"
        End If

    End Sub

    Private Sub timerAuto_Tick(sender As Object, e As EventArgs) Handles timerAuto.Tick
        indexActual = indexActual + 1
        cargarFoto(indexActual)
        ProgressBar1.Value = indexActual
        If indexActual = arrayFotos.Count - 2 Then
            indexActual = -1
        End If

    End Sub

    Private Sub btnReiniciar_Click(sender As Object, e As EventArgs) Handles btnReiniciar.Click
        indexActual = 0
        cargarFoto(indexActual)
        numTiempo.Value = 1
        timerAuto.Stop()
        ProgressBar1.Value = 0
        btnEmpezar.Text = "Empezar"
    End Sub
End Class
