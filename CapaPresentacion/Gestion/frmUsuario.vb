﻿Imports CapaLogica
Imports CapaEntidades
Public Class frmUsuario

#Region "Campos"
    Dim usuarioCL As New UsuarioCL()
#End Region


#Region "Metodos"
    Private Sub Listar()
        dgvUsuario.DataSource = usuarioCL.Listar()
    End Sub
#End Region


#Region "Eventos"
    Private Sub frmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarFormulario(Me, "Formulario de Usuario", Windows.Forms.FormBorderStyle.FixedSingle,
                              False, FormWindowState.Normal)
        Listar()
    End Sub
#End Region

    
End Class