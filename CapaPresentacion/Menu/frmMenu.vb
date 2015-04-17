﻿
Public Class frmMenu

    Dim cerrar As Boolean

    Private Sub frmMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If cerrar = False Then
            If MensajePregunta("¿Esta seguro que desea salir?") = DialogResult.No Then
                e.Cancel = True
            Else
                cerrar = True
                Application.Exit()
            End If
        End If
    End Sub
    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarFormulario(Me, "Sistema de Gestión - Control de Deudas",
                              Windows.Forms.FormBorderStyle.Sizable, True, FormWindowState.Maximized)
        lblFecha.Text = Format(Today, "dd \de MMMM \del yyyy")
        lblCodigoEmpleado.Visible = False
    End Sub
    Private Sub mnuGestionUsuario_Click(sender As Object, e As EventArgs) Handles mnuGestionUsuario.Click
        FormularioHijo(frmUsuario, Me)
    End Sub
    Private Sub mnuSalir_Click(sender As Object, e As EventArgs) Handles mnuSalir.Click
        cerrar = True
        If MensajePregunta("¿Esta seguro que desea salir?") = DialogResult.No Then
            Return
        End If
        Application.Exit()
    End Sub
    Private Sub mnuGestionEmpleado_Click(sender As Object, e As EventArgs) Handles mnuGestionEmpleado.Click
        FormularioHijo(frmEmpleado, Me)
    End Sub
    Private Sub mnuClientesCartera_Click(sender As Object, e As EventArgs) Handles mnuClientesCartera.Click
        FormularioHijo(frmCartera, Me)
    End Sub

    Private Sub mnuClientesCambiarUsuario_Click(sender As Object, e As EventArgs) Handles mnuClientesCambiarUsuario.Click
        If MensajePregunta("¿Es seguro de querer cambiar de usuario?") = Windows.Forms.DialogResult.Yes Then
            Me.Dispose()
            frmLogin.Show()
            frmLogin.txtUsuario.Focus()
        End If
    End Sub
End Class