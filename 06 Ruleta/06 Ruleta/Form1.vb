Public Class Ruleta
    Dim desplegado As Boolean
    Dim ruleta As Boolean
    Dim arrayLabel(19) As Label
    Dim numAnterior As Integer = 20
    Dim numActual As Integer = 1
    Dim contTick As Integer = 0
    Dim contTimerExtra As Integer = 20
    Dim strList As String
    Dim numString As String


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If desplegado = False Then
            timerVentana.Start()
            PictureBox1.Image = My.Resources.ResourceManager.GetObject("BotonNoActivo")

        End If


    End Sub

    Private Sub timerVentana_Tick(sender As Object, e As EventArgs) Handles timerVentana.Tick
        If desplegado = False Then
            Width += 10
            If Width >= 555 Then
                desplegado = True
                timerVentana.Stop()

                iniciarRuleta()
            End If
        ElseIf desplegado = True Then
            Width -= 10
            If Width <= 205 Then
                If LabelRes.Text.StartsWith("Per") Then
                    strList = numString + " - Perdiste - " + labelNumero.Text
                ElseIf LabelRes.Text.StartsWith("Gan") Then
                    strList = numString + " - Ganaste - " + labelNumero.Text
                End If

                ListBox1.Items.Add(strList)


                desplegado = False
                    PictureBox1.Image = My.Resources.ResourceManager.GetObject("BotonActivo")
                    timerVentana.Stop()
                    LabelRes.Text = ""


            End If

            End If




    End Sub


    Private Sub Ruleta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim control As Control
        Dim arrayListNumeros = New ArrayList

        For Each control In Me.Controls
            If control.Name.Contains("lbl") Then
                arrayListNumeros.Add(control)
            End If
        Next
        arrayListNumeros.Reverse()

        Dim tamArray = arrayLabel.Length


        For i As Integer = 0 To tamArray
            If Not i = 20 Then
                arrayLabel(i) = arrayListNumeros.Item(i)
            End If
        Next

    End Sub

    Private Sub timerRuleta_Tick(sender As Object, e As EventArgs) Handles timerRuleta.Tick
        contTick += 1

        numAnterior = numActual
        numActual += 1

        If numActual > 19 Then
            numActual = 0
        End If
        arrayLabel(numAnterior).BackColor() = Color.Transparent
        arrayLabel(numActual).BackColor() = Color.Red


        labelNumero.Text = arrayLabel(numActual).Text

        If contTick >= 100 Then
            contTick = 0
            timerRuleta.Stop()
            timerExtra.Start()
            If NumericUpDown1.Value < 10 Then
                numString = "0" + NumericUpDown1.Value.ToString
            Else
                numString = NumericUpDown1.Value.ToString
            End If

            If numString = labelNumero.Text Then
                LabelRes.Text = "Ganaste!"
                LabelRes.ForeColor = Color.Green
            Else
                LabelRes.Text = "Perdiste :("
                LabelRes.ForeColor = Color.Red

            End If
        End If

    End Sub
    Private Sub timerExtra_Tick(sender As Object, e As EventArgs) Handles timerExtra.Tick
        If contTimerExtra = 0 Then
            timerExtra.Stop()
            contTimerExtra = 20

            finRuleta()

        Else
            contTimerExtra -= 1
        End If
    End Sub


    Private Sub finRuleta()
        timerVentana.Start()

        For i As Integer = 0 To arrayLabel.Length - 1
            arrayLabel(i).BackColor = Color.Transparent
        Next
    End Sub

    Private Sub iniciarRuleta()
        Dim numeroRandom As New Random
        numActual = numeroRandom.Next(1, 20)

        timerRuleta.Start()

    End Sub
End Class
