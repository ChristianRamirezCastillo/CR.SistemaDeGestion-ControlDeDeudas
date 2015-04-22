Imports System.Data.SqlClient
Imports CapaEntidades

Public Class GestionCD

    Dim metodosDatos As New MetodoDatosCD()

    Public Function Listar(_idEmpleado As String, _idCliente As String) As DataTable
        Dim par(1) As SqlParameter
        par(0) = New SqlParameter("@idEmpleado", SqlDbType.VarChar) With {.Value = _idEmpleado}
        par(1) = New SqlParameter("@idCliente", SqlDbType.VarChar) With {.Value = _idCliente}

        Return metodosDatos.sqlListar("spGeston_Listar", par)
    End Function
    Public Function ListarUltimaGestion(_idCliente As Integer) As String
        Dim par(0) As SqlParameter
        par(0) = New SqlParameter("@idCliente", SqlDbType.Int) With {.Value = _idCliente}

        Return metodosDatos.sqlListarScalar("spGestion_ListarUltimaFecha", par)
    End Function
    Public Function Agregar(_gestion As Gestion, _tipoDeudor As Integer) As Boolean
        Dim par(6) As SqlParameter
        par(0) = New SqlParameter("@idEmpleado", SqlDbType.Int) With {.Value = _gestion.Empleado.CodigoEmpleado}
        par(1) = New SqlParameter("@idCliente", SqlDbType.Int) With {.Value = _gestion.CodigoCliente}
        par(2) = New SqlParameter("@idProducto", SqlDbType.Int) With {.Value = _gestion.CodigoProducto}
        par(3) = New SqlParameter("@descripcion", SqlDbType.VarChar) With {.Value = _gestion.Descripcion}
        par(4) = New SqlParameter("@deudaPagada", SqlDbType.Decimal) With {.Value = _gestion.DeudaPagada}
        par(5) = New SqlParameter("@deudaRestante", SqlDbType.Decimal) With {.Value = _gestion.DeudaRestante}
        par(6) = New SqlParameter("@tipoDeudor", SqlDbType.Int) With {.Value = _tipoDeudor}

        Return metodosDatos.sqlEjecutar("spGestion_Agregar", par)

    End Function
End Class
