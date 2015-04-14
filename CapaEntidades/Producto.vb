
Public Class Producto
    Private _CodigoProducto As Integer
    Private _LineaCredito As Double
    Private _DiasMora As Integer
    Private _Activo As Boolean
    Private _TipoMoneda As TipoMoneda
    Private _Deuda As Double
    Private _Cliente As Cliente

    Sub New(codigoProducto As Integer, activo As Boolean, deuda As Double,
            diasMora As Integer, lineaCredito As Double, tipoMoneda As TipoMoneda, cliente As Cliente)

        codigoProducto = Me.CodigoProducto
        activo = Me.Activo
        deuda = Me.Deuda
        diasMora = Me.DiasMora
        lineaCredito = Me.LineaCredito
        tipoMoneda = Me.TipoMoneda
        cliente = Me.Cliente
    End Sub

    Public Property Cliente As Cliente
        Get
            Return _Cliente
        End Get
        Set(value As Cliente)
            _Cliente = value
        End Set
    End Property
    Public Property Activo As Boolean
        Get
            Return _Activo
        End Get
        Set(value As Boolean)
            _Activo = value
        End Set
    End Property
    Public Property CodigoProducto As Integer
        Get
            Return _CodigoProducto
        End Get
        Set(value As Integer)
            _CodigoProducto = value
        End Set
    End Property
    Public Property Deuda As Double
        Get
            Return _Deuda
        End Get
        Set(value As Double)
            _Deuda = value
        End Set
    End Property
    Public Property LineaCredito As Double
        Get
            Return _LineaCredito
        End Get
        Set(value As Double)
            _LineaCredito = value
        End Set
    End Property
    Public Property TipoMoneda As TipoMoneda
        Get
            Return _TipoMoneda
        End Get
        Set(value As TipoMoneda)
            _TipoMoneda = value
        End Set
    End Property
    Public Property DiasMora As Integer
        Get
            Return _DiasMora
        End Get
        Set(value As Integer)
            _DiasMora = value
        End Set
    End Property

End Class
