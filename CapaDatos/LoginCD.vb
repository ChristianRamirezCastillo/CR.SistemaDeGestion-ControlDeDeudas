Imports CapaEntidades
Imports System.Data.SqlClient

Public Class LoginCD
    Private metodoDatos As New MetodoDatosCD()

    Public Function LoginValidarUsuario(_usuario As Usuario) As Boolean
        Try
            Dim par(0) As SqlParameter
            Dim dt As New DataTable

            par(0) = New SqlParameter("@login", SqlDbType.VarChar) With {.Value = _usuario.Login}
            dt = metodoDatos.sqlListar("spLogin_ValidarUsuario", par)

            If dt.Rows.Item(0)(0) = 1 Then
                Return True
            Else
                Return False
            End If

        Catch ex As SqlException
            Return False
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function LoginValidarPassword(_usuario As Usuario) As Boolean
        Try
            Dim par(1) As SqlParameter
            Dim dt As New DataTable

            par(0) = New SqlParameter("@login", SqlDbType.VarChar) With {.Value = _usuario.Login}
            par(1) = New SqlParameter("@password", SqlDbType.VarChar) With {.Value = _usuario.Password}

            dt = metodoDatos.sqlListar("spLogin_ValidarPassword", par)

            If dt.Rows.Item(0)(0) = 1 Then
                Return True
            Else
                Return False
            End If

        Catch ex As SqlException
            Return False
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function LoginDatosUsuario(_usuario As Usuario) As DataTable
        Try
            Dim par(1) As SqlParameter
            Dim dt As New DataTable

            par(0) = New SqlParameter("@login", SqlDbType.VarChar) With {.Value = _usuario.Login}
            par(1) = New SqlParameter("@password", SqlDbType.VarChar) With {.Value = _usuario.Password}

            dt = metodoDatos.sqlListar("spLogin_DatosUsuario", par)
            Return dt
        Catch ex As SqlException
            Return Nothing
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class
