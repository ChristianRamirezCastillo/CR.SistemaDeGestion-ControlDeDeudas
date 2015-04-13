
Public MustInherit Class Persona

    Private _Nombres As String
    Private _Apellidos As String
    Private _Direccion As String
    Private _Distrito As Distrito
    Private _Departamento As Departamento
    Private _Pais As Pais
    Private _Telefono As String
    Private _Sexo As Sexo

    Sub New(nombres As String, apellidos As String, direccion As String,
            distrito As Distrito, departamento As Departamento, pais As Pais, telefono As String, sexo As Sexo)
        nombres = Me.Nombres
        apellidos = Me.Apellidos
        direccion = Me.Direccion
        distrito = Me.Distrito
        departamento = Me.Departamento
        pais = Me.Pais
        telefono = Me.Pais
        sexo = Me.Sexo
    End Sub

    Public Property Nombres() As String
        Get
            Return _Nombres
        End Get
        Set(ByVal value As String)
            _Nombres = value
        End Set
    End Property
    Public Property Apellidos As String
        Get
            Return _Apellidos
        End Get
        Set(value As String)
            _Apellidos = value
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
    Public Property Departamento As Departamento
        Get
            Return _Departamento
        End Get
        Set(value As Departamento)
            _Departamento = value
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
    Public Property Telefono As String
        Get
            Return _Telefono
        End Get
        Set(value As String)
            _Telefono = value
        End Set
    End Property
    Public Property Sexo As Sexo
        Get
            Return _Sexo
        End Get
        Set(value As Sexo)
            _Sexo = value
        End Set
    End Property

End Class
