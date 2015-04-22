Imports System.Data.SqlClient

Public Class ProductoCD

    Dim metodoDatos As New MetodoDatosCD()

    Public Function ListarDeuda(_idProducto As String) As String
        Dim par(0) As SqlParameter
        par(0) = New SqlParameter("@idProducto", SqlDbType.Int) With {.Value = _idProducto}

        Return metodoDatos.sqlListarScalar("spProducto_ListarDeuda", par)
    End Function


End Class
