Imports CapaDatos
Imports CapaEntidades

Public Class EmpleadoCL

    Dim empleadoCD As New EmpleadoCD()

    Public Function ListarCombo() As DataTable
        Return Me.empleadoCD.ListarCombo()
    End Function
    Public Function Listar() As DataTable
        Return Me.empleadoCD.Listar()
    End Function
    Public Function Agregar(_empleado As Empleado) As Boolean
        Return Me.empleadoCD.Agregar(_empleado)
    End Function
    Public Function Editar(_empleado As Empleado) As Boolean
        Return Me.empleadoCD.Editar(_empleado)
    End Function
    Public Function Borrar(_empleado As Empleado) As Boolean
        Return Me.empleadoCD.Borrar(_empleado)
    End Function
    Public Function Buscar(_empleado As Empleado) As DataTable
        Return Me.empleadoCD.Buscar(_empleado)
    End Function
End Class
