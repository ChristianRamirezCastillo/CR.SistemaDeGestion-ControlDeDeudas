Imports CapaEntidades
Imports System.Data.SqlClient
Public Class EmpleadoCD
    Dim metodoDatos As New MetodoDatosCD()

    Public Function ListarCombo() As DataTable
        Return metodoDatos.sqlListar("spEmpleado_ListarCombo", Nothing)
    End Function
    Public Function Listar() As DataTable
        Return metodoDatos.sqlListar("spEmpleado_Listar", Nothing)
    End Function
    Public Function Agregar(_empleado As Empleado) As Boolean
        Dim par(6) As SqlParameter
        par(0) = New SqlParameter("@nombres", SqlDbType.VarChar) With {.Value = _empleado.Nombres}
        par(1) = New SqlParameter("@apellidos", SqlDbType.VarChar) With {.Value = _empleado.Apellidos}
        par(2) = New SqlParameter("@telefono", SqlDbType.VarChar) With {.Value = _empleado.Telefono}
        par(3) = New SqlParameter("@direccion", SqlDbType.VarChar) With {.Value = _empleado.Direccion}
        par(4) = New SqlParameter("@distrito", SqlDbType.Int) With {.Value = _empleado.Distrito}
        par(5) = New SqlParameter("@departamento", SqlDbType.Int) With {.Value = _empleado.Departamento}
        par(6) = New SqlParameter("@pais", SqlDbType.Int) With {.Value = _empleado.Pais}

        Return metodoDatos.sqlEjecutar("spEmpleado_Agregar", par)
    End Function
    Public Function Editar(_empleado As Empleado) As Boolean
        Dim par(7) As SqlParameter
        par(0) = New SqlParameter("@nombres", SqlDbType.VarChar) With {.Value = _empleado.Nombres}
        par(1) = New SqlParameter("@apellidos", SqlDbType.VarChar) With {.Value = _empleado.Apellidos}
        par(2) = New SqlParameter("@telefono", SqlDbType.VarChar) With {.Value = _empleado.Telefono}
        par(3) = New SqlParameter("@direccion", SqlDbType.VarChar) With {.Value = _empleado.Direccion}
        par(4) = New SqlParameter("@distrito", SqlDbType.Int) With {.Value = _empleado.Distrito}
        par(5) = New SqlParameter("@departamento", SqlDbType.Int) With {.Value = _empleado.Departamento}
        par(6) = New SqlParameter("@pais", SqlDbType.Int) With {.Value = _empleado.Pais}
        par(7) = New SqlParameter("@idEmpleado", SqlDbType.Int) With {.Value = _empleado.CodigoEmpleado}

        Return metodoDatos.sqlEjecutar("spEmpleado_Editar", par)
    End Function
    Public Function Borrar(_empleado As Empleado) As Boolean
        Dim par(0) As SqlParameter
        par(0) = New SqlParameter("@idEmpleado", SqlDbType.Int) With {.Value = _empleado.CodigoEmpleado}

        Return metodoDatos.sqlEjecutar("spEmpleado_Borrar", par)
    End Function
    Public Function Buscar(_empleado As Empleado) As DataTable
        Dim par(1) As SqlParameter
        par(0) = New SqlParameter("@nombres", SqlDbType.VarChar) With {.Value = _empleado.Nombres}
        par(1) = New SqlParameter("@apellidos", SqlDbType.VarChar) With {.Value = _empleado.Apellidos}

        Return metodoDatos.sqlListar("spEmpleado_Buscar", par)
    End Function
End Class
