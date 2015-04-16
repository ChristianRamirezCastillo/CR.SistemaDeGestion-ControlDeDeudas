Imports CapaLogica
Imports CapaEntidades
Public Class frmUsuario

#Region "Campos"
    Dim valor As Integer
    Dim codigoUsuario As Integer

    Dim usuario As New Usuario()

    Dim usuarioCL As New UsuarioCL()
    Dim nivelAccesoCL As New NivelAccesoCL()
    Dim empleadoCL As New EmpleadoCL()
    Dim loginCL As New LoginCL()
#End Region


#Region "Metodos"
    Private Sub Botones(nuevo As Boolean, grabar As Boolean, editar As Boolean,
                        borrar As Boolean, buscar As Boolean, cancelar As Boolean)
        btnNuevo.Enabled = nuevo
        btnGrabar.Enabled = grabar
        btnEditar.Enabled = editar
        btnBorrar.Enabled = borrar
        btnBuscar.Enabled = buscar
        btnCancelar.Enabled = cancelar
    End Sub
    Private Sub ListarTabla()
        dgvUsuario.DataSource = Me.usuarioCL.Listar()
    End Sub
    Private Sub ListarComboNivelAcceso()
        Dim dt As New DataTable()
        dt = Me.nivelAccesoCL.Listar()
        With cboNivel
            .DropDownStyle = ComboBoxStyle.DropDownList
            .DataSource = dt
            .DisplayMember = dt.Columns(1).ToString()
            .ValueMember = dt.Columns(0).ToString()
        End With
    End Sub
    Private Sub ListarEmpleado()
        Dim dt As New DataTable()
        dt = Me.empleadoCL.ListarCombo()
        With cboEmpleado
            .DropDownStyle = ComboBoxStyle.DropDownList
            .DataSource = dt
            .DisplayMember = dt.Columns(1).ToString()
            .ValueMember = dt.Columns(0).ToString()
        End With
    End Sub
    Private Sub ObtenerValoresTabla()
        codigoUsuario = dgvUsuario.Rows(dgvUsuario.CurrentRow.Index).Cells(0).Value
        txtUsuario.Text = dgvUsuario.Rows(dgvUsuario.CurrentRow.Index).Cells(1).Value
        cboNivel.SelectedIndex = (dgvUsuario.Rows(dgvUsuario.CurrentRow.Index).Cells(4).Value - 1)
        cboEmpleado.SelectedIndex = (dgvUsuario.Rows(dgvUsuario.CurrentRow.Index).Cells(5).Value - 1)
    End Sub
    Private Sub LimpiarControles()
        txtUsuario.Clear()
        txtPassword.Clear()
        cboNivel.SelectedIndex = 0
        cboEmpleado.SelectedIndex = 0
    End Sub
    Private Sub OculatrColumnas()
        With dgvUsuario
            .Columns(4).Visible = False
            .Columns(5).Visible = False
        End With
    End Sub
#End Region


#Region "Eventos"
    Private Sub frmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarFormulario(Me, "Formulario de Usuario", Windows.Forms.FormBorderStyle.FixedDialog,
                              False, FormWindowState.Normal)
        ListarTabla()
        TablaPersonalizar(dgvUsuario)
        ListarComboNivelAcceso()
        ListarEmpleado()
        OculatrColumnas()
        Botones(True, False, True, True, True, False)
        gbDatos.Enabled = False
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        gbDatos.Enabled = False
        gbDatos.Text = "Datos"
        Botones(True, False, True, True, True, False)
        LimpiarControles()
        ListarTabla()
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        valor = 1
        gbDatos.Enabled = True
        gbDatos.Text = "Datos (Nuevo)"
        txtUsuario.Focus()
        Botones(False, True, False, False, False, True)
    End Sub
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        valor = 2
        gbDatos.Enabled = True
        txtUsuario.Enabled = False
        txtPassword.Focus()
        gbDatos.Text = "Datos (Editar)"
        Botones(False, True, False, False, False, True)
        ObtenerValoresTabla()
    End Sub
    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        With Me.usuario
            .Login = txtUsuario.Text
            .Password = txtPassword.Text
            .CodigoNivelAcceso = cboNivel.SelectedValue
            .Empleado.CodigoEmpleado = cboEmpleado.SelectedValue
            .CodigoUsuario = Me.codigoUsuario
        End With

        If txtUsuario.Text.Equals("") And txtPassword.Text.Equals("") Then
            MensajeError("Los campos no pueden estar vacios")
            Return
        ElseIf txtUsuario.Text.Equals("") Then
            MensajeError("Debe ingresar un usuario")
            Return
        ElseIf txtPassword.Text.Equals("") Then
            MensajeError("Debe ingresar una contraseña")
            Return
        End If

        If valor = 1 Then
            'validamos que no se repita el usuario
            If (Me.loginCL.LoginValidarUsuario(Me.usuario) = True) Then
                MensajeExclamacion("El usuario ya existe en la Base de Datos")
                Return
            Else
                If (Me.usuarioCL.Agregar(Me.usuario) = True) Then
                    MensajeInformacion("Datos registrados")
                    ListarTabla()
                    btnCancelar.PerformClick()
                Else
                    MensajeError("Hubo un error en el registro")
                    Return
                End If
            End If

        ElseIf valor = 2 Then
            If (Me.usuarioCL.Editar(Me.usuario) = True) Then
                MensajeInformacion("Datos modificados")
                ListarTabla()
                btnCancelar.PerformClick()
            Else
                MensajeError("Hubo un error al editar los registros")
                Return
            End If
        End If
    End Sub
    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Me.usuario.CodigoUsuario = dgvUsuario.Rows(dgvUsuario.CurrentRow.Index).Cells(0).Value
        Me.usuario.Login = dgvUsuario.Rows(dgvUsuario.CurrentRow.Index).Cells(1).Value

        If MensajePregunta("¿Esta seguro que desea eliminar el usuario " & Me.usuario.Login & "?") =
                       Windows.Forms.DialogResult.Yes Then

            If (Me.usuarioCL.Borrar(Me.usuario) = True) Then
                MensajeInformacion("Dato borrado")
                ListarTabla()
                btnCancelar.PerformClick()
            Else
                Return
            End If
        End If
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        With Me.usuario
            .Login = txtPorUsuario.Text.Trim()
            .Nivel = txtPorNivel.Text.Trim()
        End With
        dgvUsuario.DataSource = Me.usuarioCL.Buscar(Me.usuario, txtPorEmpleado.Text.Trim())
    End Sub

#End Region

   
    
    
End Class