Public Class Fechas
    Public frm1 As Form1

    Private Sub Fechas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFechaActual.Text = Today

    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        Me.Hide()
        frm1.Show()

        If frm1.tiempo <> 0 Then
            frm1.TimerInicio.Start()

        End If
    End Sub

    Private Sub txtFecha_TextChanged(sender As Object, e As EventArgs) Handles txtFecha.TextChanged
        If Not IsDate(txtFecha.Text) Then
            Label1.Text = "Introduce una fecha valida"
            btnCalcular.Enabled = False
            Label1.ForeColor = Color.Red

        Else
            Label1.Text = "La fecha introducida es correcta"
            Label1.ForeColor = Color.Black
            btnCalcular.Enabled = True

        End If
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim fecha1 As Date = Today
        Dim fecha2 As Date = txtFecha.Text

        If chkMeses.Checked Then
            txtMeses.Text = ((fecha1 - fecha2).TotalDays) / 30

        End If

        If chkSemanas.Checked Then
            txtSemanas.Text = ((fecha1 - fecha2).TotalDays) / 7

        End If

        If chkDias.Checked Then
            txtDias.Text = (fecha1 - fecha2).TotalDays
        End If

        If chkHoras.Checked Then
            txtHoras.Text = (fecha1 - fecha2).TotalHours
        End If

        If chkMinutos.Checked Then
            txtMinutos.Text = (fecha1 - fecha2).TotalMinutes
        End If

        If chkSegundos.Checked Then
            txtSegundos.Text = (fecha1 - fecha2).TotalSeconds
        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MessageBox.Show("Estas Seguro? O le has dado sin querer porque eres un torpe", "Estas Seguro?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            frm1.Close()
            End
        Else
            MessageBox.Show("Eso Pensaba", "Definitivamente eres idiota")

        End If

    End Sub
End Class