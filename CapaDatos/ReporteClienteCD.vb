Imports System.Data.SqlClient

Public Class ReporteClienteCD

    Dim metodoDatos As New MetodoDatosCD()

    Public Function Listar(banco As String, empleado As String) As DataTable

        Dim par(1) As SqlParameter
        par(0) = New SqlParameter("@banco", SqlDbType.VarChar) With {.Value = banco}
        par(1) = New SqlParameter("@empleado", SqlDbType.VarChar) With {.Value = empleado}

        Return Me.metodoDatos.sqlListar("spReporteCliente_Listar", par)
    End Function

End Class
