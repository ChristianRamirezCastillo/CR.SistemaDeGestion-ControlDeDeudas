Imports CapaDatos

Public Class BancoCL

    Dim bancoCD As New BancoCD()

    Public Function ListarCombo() As DataTable
        Return Me.bancoCD.ListarCombo()
    End Function

End Class
