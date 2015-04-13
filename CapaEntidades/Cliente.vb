
Public Class Cliente
    Inherits Persona

    Private _CodigoCliente As Integer
    Private _TipoDeudor As TipoDeudor
    Private _Banco As Banco
    Private _Empresa As Empresa

    Sub New(codigoCliente As Integer, tipoDeudor As TipoDeudor, banco As Banco, empresa As Empresa,
            nombres As String, apellidos As String, direccion As String,
            distrito As Distrito, departamento As Departamento, pais As Pais, telefono As String, sexo As Sexo)
        MyBase.New(nombres, apellidos, direccion, distrito, departamento, pais, telefono, sexo)

        codigoCliente = Me.CodigoCliente
        tipoDeudor = Me.TipoDeudor
        banco = Me.Banco
        empresa = Me.Empresa
    End Sub

    Public Property CodigoCliente As Integer
        Get
            Return _CodigoCliente
        End Get
        Set(value As Integer)
            _CodigoCliente = value
        End Set
    End Property

    Public Property TipoDeudor As TipoDeudor
        Get
            Return _TipoDeudor
        End Get
        Set(value As TipoDeudor)
            _TipoDeudor = value
        End Set
    End Property

    Public Property Banco As Banco
        Get
            Return _Banco
        End Get
        Set(value As Banco)
            _Banco = value
        End Set
    End Property

    Public Property Empresa As Empresa
        Get
            Return _Empresa
        End Get
        Set(value As Empresa)
            _Empresa = value
        End Set
    End Property





End Class
