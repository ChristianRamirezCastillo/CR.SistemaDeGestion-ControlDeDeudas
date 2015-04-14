Imports CapaLogica
Imports CapaEntidades

Public Class frmLogin

    Dim login As New LoginCL()

    Private Sub IniciarTextos()
        txtUsuario.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IniciarTextos()
        Me.CenterToScreen()
        InicializarFormulario(Me, "Acceso al Sistema", Windows.Forms.FormBorderStyle.FixedDialog,
                              False, FormWindowState.Normal)
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
                'validamos el password
                If (login.LoginValidarPassword(usuario) = True) Then
                    'reuperamos los datos del usuario
                    Dim dt As New DataTable()
                    dt = login.LoginDatosUsuario(usuario)

                    With frmMenu
                        .lblUsuario.Text = dt.Rows(0).Item(1)
                        .lblNivel.Text = dt.Rows(0).Item(2)
                        .lblIdentificacion.Text = dt.Rows(0).Item(3) & " " & dt.Rows(0).Item(4)
                    End With

                    MensajeInformacion("Bienvenido al Sistema de Gestión")
                    Me.Hide()
                    frmMenu.Show()
                    IniciarTextos()
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