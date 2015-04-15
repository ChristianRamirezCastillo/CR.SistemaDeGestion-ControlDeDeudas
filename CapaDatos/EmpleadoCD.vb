
Public Class EmpleadoCD
    Dim metodoDatos As New MetodoDatosCD()

    Public Function Listar() As DataTable
        Return metodoDatos.sqlListar("spEmpleado_ListarCombo", Nothing)
    End Function

End Class
