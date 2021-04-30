Imports System.Data.OleDb
Public Class BuscarProductos
    Dim op As String
    Dim cn As OleDbConnection
    Dim dr As OleDbDataReader

    Private Sub BuscarProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        op = ">"
        'establecer la conexion (llamada a funcion)
        cn = conectar()
    End Sub


    Private Sub rb_Click(sender As Object, e As EventArgs) Handles rbMayor.Click, rbMenor.Click, rbMayorIgual.Click, rbMenorIgual.Click, rbIgual.Click, rbDiferente.Click
        Dim rb As RadioButton
        rb = sender
        op = rb.Text
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim strSentencia As String
        'preparar la select y obtener un datareader con los datos
        If rbTodos.Checked Then
            strSentencia = "Select * From productos"
        Else
            strSentencia = "Select * From productos where idProducto " & op & Val(txtBuscar.Text)
        End If
        dr = obtenerDatos(strSentencia, cn)
        'recorrer el dataReader añadiendo los datos al listbox (IdProducto y el nombre separadas por un guion)
        lstProductos.Items.Clear()
        Do While dr.Read()
            lstProductos.Items.Add(dr.Item("IdProducto") & " - " & dr.Item("NombreProducto"))
        Loop
    End Sub

    Private Sub txtBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscar.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> Convert.ToChar(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
End Class