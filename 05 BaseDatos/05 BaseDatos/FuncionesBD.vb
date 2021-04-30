
Imports System.Data.OleDb

Module FuncionesBD
    Dim cn As OleDbConnection

    Public Function conectar() As OleDbConnection
        Try
            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=neptuno.accdb;Persist Security Info=False;")
            cn.Open()
            Return cn
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function obtenerDatos(strSql As String, cn As OleDbConnection)
        Dim command As OleDbCommand
        Dim dr As OleDbDataReader
        'command = New OleDbCommand()
        'command.CommandText = "select * from clientes"
        'command.Connection = cn
        'otra forma
        command = New OleDbCommand(strSql, cn)

        dr = command.ExecuteReader()
        Return dr
    End Function
End Module
