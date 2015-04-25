Imports CapaDatos

Public Class ReporteClienteCL

    Dim reporteClienteCD As New ReporteClienteCD()

    Public Function Listar(banco As String, empleado As String) As DataTable
        Return Me.reporteClienteCD.Listar(banco, empleado)
    End Function

End Class
