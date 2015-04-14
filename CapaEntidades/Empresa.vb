
Public Class Empresa
    Private _CodigoEmpresa As Integer
    Private _Nombre As String
    Private _Sueldo As Double
    Private _RUC As Integer
    Private _Telefono As String
    Private _Direccion As String
    Private _Distrito As Distrito
    Private _Departamento As Departamento
    Private _Pais As Pais

    Sub New(codigoEmpresa As Integer, departamento As Departamento, direccion As String,
            distrito As Distrito, nombre As String, pais As Pais, ruc As Integer, sueldo As Double, telefono As String)

        codigoEmpresa = Me.CodigoeEmpresa
        departamento = Me.Departamento
        direccion = Me.Direccion
        distrito = Me.Distrito
        nombre = Me.Nombre
        pais = Me.Pais
        ruc = Me.RUC
        sueldo = Me.Sueldo
        telefono = Me.Telefono
    End Sub

    Public Property CodigoeEmpresa As Integer
        Get
            Return _CodigoEmpresa
        End Get
        Set(value As Integer)
            _CodigoEmpresa = value
        End Set
    End Property
    Public Property Departamento As Departamento
        Get
            Return _Departamento
        End Get
        Set(value As Departamento)
            _Departamento = value
        End Set
    End Property
    Public Property Direccion As String
        Get
            Return _Direccion
        End Get
        Set(value As String)
            _Direccion = value
        End Set
    End Property
    Public Property Distrito As Distrito
        Get
            Return _Distrito
        End Get
        Set(value As Distrito)
            _Distrito = value
        End Set
    End Property
    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property
    Public Property Pais As Pais
        Get
            Return _Pais
        End Get
        Set(value As Pais)
            _Pais = value
        End Set
    End Property
    Public Property RUC As Integer
        Get
            Return _RUC
        End Get
        Set(value As Integer)
            _RUC = value
        End Set
    End Property
    Public Property Sueldo As Double
        Get
            Return _Sueldo
        End Get
        Set(value As Double)
            _Sueldo = value
        End Set
    End Property
    Public Property Telefono As String
        Get
            Return _Telefono
        End Get
        Set(value As String)
            _Telefono = value
        End Set
    End Property

End Class
