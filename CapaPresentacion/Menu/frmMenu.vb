
Public Class frmMenu

    Private Sub frmMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MensajePregunta("¿Esta seguro que desea salir?") = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarFormulario(Me, "Sistema de Gestión - Control de Deudas",
                              Windows.Forms.FormBorderStyle.Sizable, True, FormWindowState.Maximized)
        lblFecha.Text = Format(Today, "dd \de MMMM \del yyyy")
    End Sub
    Private Sub mnuGestionUsuario_Click(sender As Object, e As EventArgs) Handles mnuGestionUsuario.Click
        FormularioHijo(frmUsuario, Me)
    End Sub
    Private Sub mnuSalir_Click(sender As Object, e As EventArgs) Handles mnuSalir.Click
        If MensajePregunta("¿Esta seguro que desea salir?") = DialogResult.No Then
            Return
        End If
        Application.Exit()
    End Sub
    Private Sub mnuGestionEmpleado_Click(sender As Object, e As EventArgs) Handles mnuGestionEmpleado.Click
        FormularioHijo(frmEmpleado, Me)
    End Sub

End Class