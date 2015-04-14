Imports CapaLogica
Imports CapaEntidades

Public Class frmLogin

    Dim login As New LoginCL()

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Inicializar(Me, "Acceso al Sistema")
        txtUsuario.Focus()
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

        Dim usuario As New Usuario()
        usuario.Login = txtUsuario.Text
        usuario.Password = txtPassword.Text

        If (txtUsuario.Text.Equals("") And txtPassword.Text.Equals("")) Then
            MensajeError("Los campos no pueden estar vacíos")
            Return
        ElseIf (txtUsuario.Text.Equals("")) Then
            MensajeError("Debe ingresar un usuario")
            Return
        ElseIf (txtPassword.Text.Equals("")) Then
            MensajeError("Debe ingresar una contraseña")
            Return
        Else
            'validamos usuario
            If (login.LoginValidarUsuario(usuario) = True) Then
                If (login.LoginValidarPassword(usuario) = True) Then
                    MensajeInformacion("Bienvenido al Sistema de Gestión")
                Else
                    txtPassword.Clear()
                    txtPassword.Focus()
                    MensajeError("La contraseña no es correcta")
                    Return
                End If
            Else
                MensajeError("El usuario no existe")
                Return
            End If

        End If

    End Sub
End Class