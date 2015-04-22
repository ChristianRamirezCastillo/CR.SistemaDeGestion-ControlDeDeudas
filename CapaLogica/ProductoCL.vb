Imports CapaDatos

Public Class ProductoCL

    Dim productoCD As New ProductoCD()

    Public Function ListarDeuda(_idProducto As String) As String
        Return Me.productoCD.ListarDeuda(_idProducto)
    End Function

End Class
