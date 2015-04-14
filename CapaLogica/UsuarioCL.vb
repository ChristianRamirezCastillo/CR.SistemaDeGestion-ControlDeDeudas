Imports CapaDatos
Imports CapaEntidades

Public Class UsuarioCL
    Private usuarioCD As New UsuarioCD()
    Private _listUsuario As List(Of Usuario)

    Public Property ListaUsuario As List(Of Usuario)
        Get
            Return _listUsuario
        End Get
        Set(ByVal value As List(Of Usuario))
            _listUsuario = value
        End Set
    End Property
    Public Function Listar() As DataTable
        Return usuarioCD.Listar()
    End Function
End Class
