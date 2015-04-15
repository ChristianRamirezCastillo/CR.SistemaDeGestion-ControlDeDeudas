

Public Class NivelAccesoCD

    Dim metodoDatos As New MetodoDatosCD()

    Public Function Listar() As DataTable
        Return metodoDatos.sqlListar("spNivelAcceso_Listar", Nothing)
    End Function
End Class
