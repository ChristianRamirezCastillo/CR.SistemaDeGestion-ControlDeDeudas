Imports System.Data.SqlClient

Public Class ClienteCD

    Dim metodoDatos As New MetodoDatosCD()

    Public Function Listar(idBanco As Integer) As DataTable
        Dim par(0) As SqlParameter
        par(0) = New SqlParameter("@idBanco", SqlDbType.Int) With {.Value = idBanco}

        Return Me.metodoDatos.sqlListar("spCliente_Listar", par)
    End Function
    Public Function Listar(idBanco As Integer, idEmpleado As Integer) As DataTable
        Dim par(1) As SqlParameter
        par(0) = New SqlParameter("@idBanco", SqlDbType.Int) With {.Value = idBanco}
        par(1) = New SqlParameter("@idEmpleado", SqlDbType.Int) With {.Value = idEmpleado}

        Return Me.metodoDatos.sqlListar("spCliente_Listar", par)
    End Function
    Public Function Buscar(idBanco As Integer, idEmpleado As Integer,
                           idCliente As String, nombres As String, apellidos As String) As DataTable
        Dim par(4) As SqlParameter
        par(0) = New SqlParameter("@idBanco", SqlDbType.Int) With {.Value = idBanco}
        par(1) = New SqlParameter("@idEmpleado", SqlDbType.VarChar) With {.Value = idEmpleado}
        par(2) = New SqlParameter("@idCliente", SqlDbType.VarChar) With {.Value = idCliente}
        par(3) = New SqlParameter("@nombres", SqlDbType.VarChar) With {.Value = nombres}
        par(4) = New SqlParameter("@apellidos", SqlDbType.VarChar) With {.Value = apellidos}

        Return Me.metodoDatos.sqlListar("spCliente_Buscar", par)
    End Function

    Public Function Buscar(idBanco As Integer, idEmpleado As String,
                           idCliente As String, nombres As String, apellidos As String, empleado As String) As DataTable
        Dim par(5) As SqlParameter
        par(0) = New SqlParameter("@idBanco", SqlDbType.Int) With {.Value = idBanco}
        par(1) = New SqlParameter("@idEmpleado", SqlDbType.VarChar) With {.Value = idEmpleado}
        par(2) = New SqlParameter("@idCliente", SqlDbType.VarChar) With {.Value = idCliente}
        par(3) = New SqlParameter("@nombres", SqlDbType.VarChar) With {.Value = nombres}
        par(4) = New SqlParameter("@apellidos", SqlDbType.VarChar) With {.Value = apellidos}
        par(5) = New SqlParameter("@empleado", SqlDbType.VarChar) With {.Value = empleado}

        Return Me.metodoDatos.sqlListar("spCliente_Buscar", par)
    End Function

    Public Function ListarProducto(idCliente As Integer) As DataTable
        Dim par(0) As SqlParameter
        par(0) = New SqlParameter("@idCliente", SqlDbType.Int) With {.Value = idCliente}
        Return Me.metodoDatos.sqlListar("spCliente_ListarProducto", par)
    End Function
    Public Function ListarProducto(idCliente As Integer, activo As Boolean) As DataTable
        Dim par(1) As SqlParameter
        par(0) = New SqlParameter("@idCliente", SqlDbType.Int) With {.Value = idCliente}
        par(1) = New SqlParameter("@activo", SqlDbType.Bit) With {.Value = activo}

        Return Me.metodoDatos.sqlListar("spCliente_ListarProducto", par)
    End Function

    Public Function ListarEmpresa(idCliente As Integer) As DataTable
        Dim par(0) As SqlParameter
        par(0) = New SqlParameter("@idCliente", SqlDbType.Int) With {.Value = idCliente}

        Return Me.metodoDatos.sqlListar("spCliente_ListarEmpresa", par)
    End Function
End Class
