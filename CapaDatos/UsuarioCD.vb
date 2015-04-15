Imports System.Data
Imports System.Data.SqlClient
Imports CapaEntidades

Public Class UsuarioCD

    Private metodoDatos As New MetodoDatosCD()

    Public Function Listar() As DataTable
        Return metodoDatos.sqlListar("spUsuario_Listar", Nothing)
    End Function
    Public Function Agregar(_usuario As Usuario) As Boolean
        Dim par(3) As SqlParameter
        par(0) = New SqlParameter("@idNivelAcceso", SqlDbType.Int) With {.Value = _usuario.CodigoNivelAcceso}
        par(1) = New SqlParameter("@idEmpleado", SqlDbType.Int) With {.Value = _usuario.Empleado.CodigoEmpleado}
        par(2) = New SqlParameter("@login", SqlDbType.VarChar) With {.Value = _usuario.Login}
        par(3) = New SqlParameter("@password", SqlDbType.VarChar) With {.Value = _usuario.Password}

        Return Me.metodoDatos.sqlEjecutar("spUsuario_Agregar", par)
    End Function
    Public Function Editar(_usuario As Usuario) As Boolean
        Dim par(4) As SqlParameter
        par(0) = New SqlParameter("@idNivelAcceso", SqlDbType.Int) With {.Value = _usuario.CodigoNivelAcceso}
        par(1) = New SqlParameter("@idEmpleado", SqlDbType.Int) With {.Value = _usuario.Empleado.CodigoEmpleado}
        par(2) = New SqlParameter("@login", SqlDbType.VarChar) With {.Value = _usuario.Login}
        par(3) = New SqlParameter("@password", SqlDbType.VarChar) With {.Value = _usuario.Password}
        par(4) = New SqlParameter("@idUsuario", SqlDbType.Int) With {.Value = _usuario.CodigoUsuario}

        Return Me.metodoDatos.sqlEjecutar("spUsuario_Editar", par)
    End Function
    Public Function Borrar(_usuario As Usuario) As Boolean
        Dim par(0) As SqlParameter
        par(0) = New SqlParameter("@idUsuario", SqlDbType.Int) With {.Value = _usuario.CodigoUsuario}

        Return Me.metodoDatos.sqlEjecutar("spUsuario_Borrar", par)
    End Function
    Public Function Buscar(_usuario As Usuario, _empleado As String) As DataTable
        Dim par(2) As SqlParameter
        par(0) = New SqlParameter("@login", SqlDbType.VarChar) With {.Value = _usuario.Login}
        par(1) = New SqlParameter("@nivelAcceso", SqlDbType.VarChar) With {.Value = _usuario.Nivel}
        par(2) = New SqlParameter("@empleado", SqlDbType.VarChar) With {.Value = _empleado}

        Return Me.metodoDatos.sqlListar("spUsuario_Buscar", par)
    End Function
End Class
