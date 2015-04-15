
Public Class Usuario
    Inherits NivelAcceso

    Private _CodigoUsuario As Integer
    Private _Login As String
    Private _Password As String
    Private _Empleado As New Empleado

#Region "Constructor"
    Sub New(codigoUsuario As Integer, login As String, password As String, empleado As Empleado,
           codigoNivelAcceso As String, nivel As String)
        MyBase.New(codigoNivelAcceso, nivel)

        codigoUsuario = Me.CodigoUsuario
        login = Me.Login
        password = Me.Password
        empleado = Me.Empleado
        codigoNivelAcceso = Me.CodigoNivelAcceso
        nivel = Me.Nivel
    End Sub
    Sub New()
    End Sub
#End Region

#Region "Propiedades"
    Public Property CodigoUsuario As Integer
        Get
            Return _CodigoUsuario
        End Get
        Set(value As Integer)
            _CodigoUsuario = value
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
    Public Property Login As String
        Get
            Return _Login
        End Get
        Set(value As String)
            _Login = value
        End Set
    End Property
    Public Property Password As String
        Get
            Return _Password
        End Get
        Set(value As String)
            _Password = value
        End Set
    End Property
#End Region

End Class
