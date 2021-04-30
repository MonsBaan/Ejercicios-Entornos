Imports System.Data.OleDb

Public Class Clientes
    Private cn As OleDbConnection
    Private daCli As OleDbDataAdapter
    Private dsCli As DataSet
    Private dr As OleDbDataReader
    Private arrayText(9) As TextBox
    Private regActual As Integer



    Private Sub inicializar()
        arrayText(0) = txtId
        arrayText(0).ReadOnly = True
        arrayText(1) = txtCompañia
        arrayText(2) = txtContacto
        arrayText(3) = txtCargo
        arrayText(4) = txtDir
        arrayText(5) = txtCiudad
        arrayText(6) = txtRegion
        arrayText(7) = txtCp
        arrayText(8) = txtPais
        arrayText(9) = txtTlf

        cambiarEstado(True)

    End Sub

    Private Sub Clientes_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

        inicializar()

        cn = conectar()

        If cn Is Nothing Then
            Return
        End If

        regActual = 0
        dsCli = New DataSet
        daCli = New OleDbDataAdapter()
        daCli.SelectCommand = New OleDbCommand("SELECT * FROM clientes", cn)
        daCli.Fill(dsCli, "Cli")

        cargarDatos()

    End Sub


    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If regActual < dsCli.Tables("Cli").Rows.Count - 1 Then
            regActual += 1
            cargarDatos()

        End If
    End Sub
    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If regActual > 0 Then
            regActual -= 1
            cargarDatos()

        End If
    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        regActual = 0
        cargarDatos()

    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        regActual = dsCli.Tables("Cli").Rows.Count - 1
        cargarDatos()
    End Sub


    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        cambiarEstado(False)
        btnModificar.Enabled = False
        btnActualizar.Enabled = True
        Panel1.Enabled = False
    End Sub

    Private Sub cambiarEstado(estado As Boolean)
        For i As Integer = 1 To arrayText.Length - 1
            arrayText(i).ReadOnly = estado

        Next
    End Sub

    Private Sub cargarDatos()
        For i As Integer = 0 To arrayText.Count - 1
            arrayText(i).Text = dsCli.Tables("Cli").Rows(regActual).Item(i).ToString

        Next i
        lblPos.Text = regActual + 1

        If regActual = 0 Then
            btnAnterior.Enabled = False
            btnPrimero.Enabled = False
        Else
            btnAnterior.Enabled = True
            btnPrimero.Enabled = True
        End If

        If regActual = dsCli.Tables("Cli").Rows.Count - 1 Then
            btnSiguiente.Enabled = False
            btnUltimo.Enabled = False
        Else
            btnSiguiente.Enabled = True
            btnUltimo.Enabled = True
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim cmd As OleDbCommand
        Dim cadena As String = "UPDATE clientes SET "

        cambiarEstado(False)
        btnModificar.Enabled = True
        btnActualizar.Enabled = False
        Panel1.Enabled = True

        For i As Integer = 1 To arrayText.Length - 1
            cadena += dsCli.Tables("Cli").Columns(i).ColumnName.ToString + "=" + arrayText(i).Text

            If i <> arrayText.Length - 1 Then
                cadena += ", "
            End If
        Next

        cadena += " WHERE idCliente=" + arrayText(0).Text

        cmd = New OleDbCommand(cadena, cn)

        If cmd.ExecuteNonQuery() <> 1 Then
            MessageBox.Show("Error al Actualizar")
        End If

    End Sub
End Class