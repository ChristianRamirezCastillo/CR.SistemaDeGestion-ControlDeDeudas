
Public Class BancoCD

    Dim metodoDatos As New MetodoDatosCD()

    Public Function ListarCombo() As DataTable
        Return Me.metodoDatos.sqlListar("spBanco_ListarCombo", Nothing)
    End Function

End Class
