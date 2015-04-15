Imports CapaDatos
Imports CapaEntidades

Public Class LoginCL

    Dim login As New LoginCD()

    Public Function LoginValidarUsuario(_usuario As Usuario) As Boolean
        Return Me.login.LoginValidarUsuario(_usuario)
    End Function
    Public Function LoginValidarPassword(_usuario As Usuario) As Boolean
        Return Me.login.LoginValidarPassword(_usuario)
    End Function
    Public Function LoginDatosUsuario(_usuario As Usuario) As DataTable
        Return Me.login.LoginDatosUsuario(_usuario)
    End Function
End Class
