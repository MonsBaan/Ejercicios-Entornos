Public Class Form1
    Dim tiempo As Integer = 120

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        Dim trimNombre As String
        trimNombre = txtNombre.Text.Trim
        If trimNombre.Length = 0 Then
            MessageBox.Show("Deberias de Escribir algo, no se, llamame loco", "Estas Tonto?")
            Return
        ElseIf lstNombres.Items.Contains(trimNombre) Then
            MessageBox.Show("Sabia que no sabias escribir, pero tio, que esta repetido", "Estas Tonto?")
            Return
        Else
            lstNombres.Items.Add(trimNombre)
            txtNombre.Clear()
            TimerInicio.Start()
            btnVaciar.Enabled = True
        End If



    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        txtNombre.Clear()
        txtNombre.Focus()
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        If txtNombre.TextLength = 0 Then
            btnAñadir.Enabled = False
            btnEliminar.Enabled = False
        Else
            btnAñadir.Enabled = True
            btnEliminar.Enabled = True
        End If

    End Sub

    Private Sub btnVaciar_Click(sender As Object, e As EventArgs) Handles btnVaciar.Click
        If MessageBox.Show("Estas Seguro? O le has dado sin querer porque eres un torpe", "Estas Seguro?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            lstNombres.Items.Clear()
            btnEliminarSel.Enabled = False
            btnVaciar.Enabled = False
            btnPasar.Enabled = False
        End If

    End Sub

    Private Sub lstNombres_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstNombres.SelectedIndexChanged
        btnEliminarSel.Enabled = True
        btnVaciar.Enabled = True
        btnPasar.Enabled = True
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MessageBox.Show("Estas Seguro? O le has dado sin querer porque eres un torpe", "Estas Seguro?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            End
        Else
            MessageBox.Show("Eso Pensaba", "Definitivamente eres idiota")

        End If
    End Sub

    Private Sub btnPasar_Click(sender As Object, e As EventArgs) Handles btnPasar.Click
        If cbNombres.Items.Contains(lstNombres.SelectedItem) Then
            MessageBox.Show("Sabia que no sabias escribir, pero tio, que esta repetido", "Estas Tonto?")

        Else
            cbNombres.Items.Add(lstNombres.SelectedItem)
        End If
    End Sub

    Private Sub btnEliminarSel_Click(sender As Object, e As EventArgs) Handles btnEliminarSel.Click
        Dim indice As Integer

        If lstNombres.Items.Count > 0 Then
            indice = lstNombres.SelectedIndex
            If Not lstNombres.SelectedIndex() = -1 Then
                lstNombres.Items.RemoveAt(indice)

            End If

            If lstNombres.Items.Count = 0 Then
                btnEliminarSel.Enabled = False
                btnVaciar.Enabled = False
                btnPasar.Enabled = False
            End If

        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles TimerInicio.Tick
        tiempo -= 1
        txtTiempo.Text = tiempo \ 60 & " : " & tiempo Mod 60
        If tiempo = 0 Then
            TimerInicio.Stop()
            txtNombre.Enabled = False
            txtNombre.Clear()
        End If
    End Sub
End Class
