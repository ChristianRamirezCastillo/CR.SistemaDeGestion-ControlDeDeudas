Imports CapaLogica
Imports CapaEntidades

Public Class frmLogin


    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Inicializar(Me, "Acceso al Sistema")
        txtUsuario.Focus()
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
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
            If () Then

            End If

        End If
    End Sub
End Class