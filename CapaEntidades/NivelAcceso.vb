
Public MustInherit Class NivelAcceso
    Private _CodigoNivelAcceso As Integer
    Private _Nivel As String

#Region "Constructor"
    Sub New(codigoNivelAcceso As Integer, nivel As String)
        codigoNivelAcceso = Me.CodigoNivelAcceso
        nivel = Me.Nivel
    End Sub
    Sub New()
    End Sub
#End Region

#Region "Propiedades"
    Public Property CodigoNivelAcceso As Integer
        Get
            Return _CodigoNivelAcceso
        End Get
        Set(value As Integer)
            _CodigoNivelAcceso = value
        End Set
    End Property
    Public Property Nivel As String
        Get
            Return _Nivel
        End Get
        Set(value As String)
            _Nivel = value
        End Set
    End Property
#End Region

End Class
