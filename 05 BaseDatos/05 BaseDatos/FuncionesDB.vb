Imports System.Data.OleDb
Module FuncionesBd

    Dim cn As OleDbConnection

    Public Function conectar() As OleDbConnection
        Try
            cn = New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\dam1-ibai\Documents\Ejercicios-Entornos\05 BaseDatos\Neptuno.accdb;Persist Security Info=False;")
            cn.Open()
            Return cn

        Catch ex As Exception
            MessageBox.Show("Error en la conexion a la base de datos. " + ex.Message, "Error")
            Return Nothing
        End Try

    End Function

    Public Function obtenerDatos(strSql As String, cn As OleDbConnection)
        Dim command As OleDbCommand
        Dim dr As OleDbDataReader
        command = New OleDbCommand(strSql, cn)
        dr = command.ExecuteReader()
        Return dr

    End Function
End Module
