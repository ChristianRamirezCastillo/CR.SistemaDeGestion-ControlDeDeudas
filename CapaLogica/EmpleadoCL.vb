Imports CapaDatos

Public Class EmpleadoCL

    Dim empleadoCD As New EmpleadoCD()

    Public Function Listar() As DataTable
        Return Me.empleadoCD.Listar()
    End Function

End Class
