Imports CapaDatos

Public Class NivelAccesoCL

    Dim nivelAcceso As New NivelAccesoCD()

    Public Function Listar() As DataTable
        Return nivelAcceso.Listar()
    End Function

End Class
