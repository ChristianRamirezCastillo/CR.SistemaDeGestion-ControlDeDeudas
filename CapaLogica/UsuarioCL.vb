Imports CapaDatos
Imports CapaEntidades

Public Class UsuarioCL
    Private usuarioCD As New UsuarioCD()

    Public Function Listar() As DataTable
        Return Me.usuarioCD.Listar()
    End Function
    Public Function Agregar(_usuario As Usuario) As Boolean
        Return Me.usuarioCD.Agregar(_usuario)
    End Function
    Public Function Editar(_usuario As Usuario) As Boolean
        Return Me.usuarioCD.Editar(_usuario)
    End Function
    Public Function Borrar(_usuario As Usuario) As Boolean
        Return Me.usuarioCD.Borrar(_usuario)
    End Function
    Public Function Buscar(_usuario As Usuario, _empleado As String) As DataTable
        Return Me.usuarioCD.Buscar(_usuario, _empleado)
    End Function
End Class
