Public Class principal
    Dim frmClientes As Clientes

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        frmClientes = New Clientes
        Me.Hide()
        frmClientes.Show()

    End Sub
End Class
