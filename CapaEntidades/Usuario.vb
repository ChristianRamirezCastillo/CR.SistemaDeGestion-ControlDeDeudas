
Public Class Usuario
    Inherits NivelAcceso

    Private _Login As String
    Private _Password As String
    Private _Empleado As Empleado

    Sub New(login As String, password As String,
            codigoNivelAcceso As String, nivel As String)
        MyBase.New(codigoNivelAcceso, nivel)

        login = Me.Login
        password = Me.Password
        codigoNivelAcceso = Me.CodigoNivelAcceso
        nivel = Me.Nivel
    End Sub

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

End Class
