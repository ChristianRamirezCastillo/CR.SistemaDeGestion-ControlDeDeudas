
Public Class Gestion
    Private _Fecha As Date
    Private _Descripcion As String
    Private _DeudaPagada As Double
    Private _DeudaRestante As Double
    Private _Empleado As Empleado
    Private _Cliente As Cliente
    Private _Producto As Producto
    Private _CodigoGestion As Integer

    Sub New(codigoGestion As Integer, descripcion As String, deudaPagada As Double,
            deudaRestante As Double, fecha As Date, empleado As Empleado, cliente As Cliente, producto As Producto)

        codigoGestion = Me.CodigoGestion
        descripcion = Me.Descripcion
        deudaPagada = Me.DeudaPagada
        deudaRestante = Me.DeudaRestante
        fecha = Me.Fecha
        empleado = Me.Empleado
        cliente = Me.Cliente
        producto = Me.Producto
    End Sub

    Public Property Fecha As Date
        Get
            Return _Fecha
        End Get
        Set(value As Date)
            _Fecha = value
        End Set
    End Property
    Public Property Descripcion As String
        Get
            Return _Descripcion
        End Get
        Set(value As String)
            _Descripcion = value
        End Set
    End Property
    Public Property DeudaPagada As Double
        Get
            Return _DeudaPagada
        End Get
        Set(value As Double)
            _DeudaPagada = value
        End Set
    End Property
    Public Property DeudaRestante As Double
        Get
            Return _DeudaRestante
        End Get
        Set(value As Double)
            _DeudaRestante = value
        End Set
    End Property
    Public Property Empleado As Empleado
        Get
            Return _Empleado
        End Get
        Set(value As Empleado)
            _Empleado = value
        End Set
    End Property
    Public Property Cliente As Cliente
        Get
            Return _Cliente
        End Get
        Set(value As Cliente)
            _Cliente = value
        End Set
    End Property
    Public Property Producto As Producto
        Get
            Return _Producto
        End Get
        Set(value As Producto)
            _Producto = value
        End Set
    End Property
    Public Property CodigoGestion As Integer
        Get
            Return _CodigoGestion
        End Get
        Set(value As Integer)
            _CodigoGestion = value
        End Set
    End Property

End Class
