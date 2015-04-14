
Public Class Banco
    Private _CodigoBanco As Integer
    Private _Nombre As String

    Sub New(codigoBanco As Integer, nombre As String)
        codigoBanco = Me.CodigoBanco
        nombre = Me.Nombre
    End Sub

    Public Property CodigoBanco As Integer
        Get
            Return _CodigoBanco
        End Get
        Set(value As Integer)
            _CodigoBanco = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

End Class
