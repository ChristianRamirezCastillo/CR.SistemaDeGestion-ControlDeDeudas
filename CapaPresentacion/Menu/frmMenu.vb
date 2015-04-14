
Public Class frmMenu

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarFormulario(Me, "Sistema de Gestión - Control de Deudas",
                              Windows.Forms.FormBorderStyle.Sizable, True, FormWindowState.Maximized)
        lblFecha.Text = Format(Today, "dd \de MMMM \del yyyy")
    End Sub
End Class