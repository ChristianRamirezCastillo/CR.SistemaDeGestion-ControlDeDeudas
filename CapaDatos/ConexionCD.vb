Imports System.Data.SqlClient
Imports System.Configuration

Public MustInherit Class ConexionCD
    Private cadena As String = ConfigurationManager.ConnectionStrings("conexionDB").ConnectionString.ToString()
    Private cn As New SqlConnection(cadena)

    Public Function conectar() As SqlConnection
        Try
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If
            Return cn
        Catch ex As SqlException
            Return Nothing
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function desconectar() As SqlConnection
        Try
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            Return cn
        Catch ex As SqlException
            Return Nothing
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class
