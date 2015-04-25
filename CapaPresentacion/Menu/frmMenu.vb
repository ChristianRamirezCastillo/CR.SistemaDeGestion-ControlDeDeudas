
Public Class frmMenu

    Dim cerrar As Boolean

    Private Sub Permisos()
        If lblNivel.Text <> "Administrador" Then
            mnuGestion.Visible = False
            mnuGestionEmpleado.ShortcutKeys = Nothing
            mnuGestionUsuario.ShortcutKeys = Nothing
            mnuGestionReportes.ShortcutKeys = Nothing
        Else
            mnuGestion.Visible = True
            mnuGestion.Enabled = True
        End If


    End Sub

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
        Permisos()
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

    Private Sub mnuAyudaAcercaDe_Click(sender As Object, e As EventArgs) Handles mnuAyudaAcercaDe.Click
        frmAcercaDe.ShowDialog()
    End Sub

    Private Sub mnuGestionReportesClientes_Click(sender As Object, e As EventArgs) Handles mnuGestionReportesClientes.Click
        FormularioHijo(frmReportes, Me)
    End Sub
End Class