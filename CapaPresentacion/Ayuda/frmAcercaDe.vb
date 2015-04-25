Public Class frmAcercaDe

    Private Sub frmAcercaDe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarFormulario(Me, "Acerca del Sistema", Windows.Forms.FormBorderStyle.FixedDialog, False, FormWindowState.Normal)
        Me.CenterToScreen()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://chriserc.wix.com/christianramirez#!contacto/c3vn")
    End Sub
End Class