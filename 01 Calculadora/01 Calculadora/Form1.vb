Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtNum2.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        If Not IsNumeric(txtNum1.Text) Then
            MessageBox.Show("Nick no esta feliz. Eso no es un numero", "Dios no existe")
            txtNum1.Focus()
            txtNum1.SelectAll()
            Return

        End If

        If Not IsNumeric(txtNum2.Text) Then
            MessageBox.Show("Nick no esta feliz. Eso no es un numero", "Dios no existe")
            txtNum2.Focus()
            txtNum2.SelectAll()

            Return
        End If



        Dim num1 As Integer = txtNum1.Text
        Dim num2 As Integer = txtNum2.Text
        Dim res As Double = 0


        Select Case True
            Case rbSuma.Checked
                res = num1 + num2

                txtRes.Text() = res
            Case rbResta.Checked
                res = num1 - num2

                txtRes.Text() = res
            Case rbMulti.Checked
                res = num1 * num2

                txtRes.Text() = res
            Case rbDiv.Checked
                If num2 = 0 Then
                    MessageBox.Show("Eres Debil, tus trucos no funcionan", "Dios no existe")
                    Return
                End If
                res = num1 / num2

                txtRes.Text() = res
        End Select


    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        MessageBox.Show("Nunca limpiaras tus pecados", "Dios no existe")

        txtNum1.Clear()
        txtNum2.Clear()
        txtRes.Clear()

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles btnSalir.Click

        If MessageBox.Show("No puedes escapar para siempre", "Dios no existe", MessageBoxButtons.YesNo) = DialogResult.Yes Then

            Close()

        End If


    End Sub

    Private Sub txtNum1_TextChanged(sender As Object, e As EventArgs) Handles txtNum1.TextChanged

    End Sub
End Class
