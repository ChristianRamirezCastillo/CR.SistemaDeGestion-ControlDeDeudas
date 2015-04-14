Imports System.Data
Imports System.Data.SqlClient
Imports CapaEntidades
Public Class UsuarioCD
    Private metodoDatos As New MetodoDatosCD()

    Public Function Listar() As DataTable
        Return metodoDatos.sqlListar("spUsuario_Listar", Nothing)
    End Function
End Class
