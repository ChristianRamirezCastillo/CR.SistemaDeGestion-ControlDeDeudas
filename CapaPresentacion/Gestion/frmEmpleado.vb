Imports CapaEntidades
Imports CapaLogica

Public Class frmEmpleado

#Region "Campos"
    Dim valor As Integer
    Dim codigoEmpleado As Integer

    Dim empleado As New Empleado()
    Dim empleadoCL As New EmpleadoCL()
#End Region


#Region "Metodos"
    Private Sub ListarTabla()
        Dim dt As New DataTable()
        dt = Me.empleadoCL.Listar()
        dt.Columns.Add("Distrito", GetType(Distrito))
        dt.Columns.Add("Departamento", GetType(Departamento))
        dt.Columns.Add("País", GetType(Pais))

        For Each row As DataRow In dt.Rows
            Dim distrito As Integer = CInt(row(5))
            Dim departamento As Integer = CInt(row(6))
            Dim pais As Integer = CInt(row(7))

            row(8) = DirectCast(distrito, Distrito)
            row(9) = DirectCast(departamento, Departamento)
            row(10) = DirectCast(pais, Pais)
        Next

        dgvEmpleado.DataSource = dt
    End Sub
    Private Sub Botones(nuevo As Boolean, grabar As Boolean, editar As Boolean,
                        borrar As Boolean, buscar As Boolean, cancelar As Boolean)
        btnNuevo.Enabled = nuevo
        btnGrabar.Enabled = grabar
        btnEditar.Enabled = editar
        btnBorrar.Enabled = borrar
        btnBuscar.Enabled = buscar
        btnCancelar.Enabled = cancelar
    End Sub
    Private Sub LimpiarControles()
        txtNombres.Clear()
        txtApellidos.Clear()
        txtDireccion.Clear()
        txtTelefono.Clear()
        cboDistrito.SelectedIndex = 0
        cboDepartamento.SelectedIndex = 0
        cboPais.SelectedIndex = 0
    End Sub
    Private Sub ListarComboDistrito()
        With cboDistrito
            Dim lista As New Dictionary(Of String, Integer)
            For Each i As Integer In [Enum].GetValues(GetType(Distrito))
                lista.Add([Enum].GetName(GetType(Distrito), i), i)
            Next

            .DataSource = New BindingSource(lista, Nothing)
            .DisplayMember = "Key"
            .ValueMember = "Value"
            .DropDownStyle = ComboBoxStyle.DropDownList
            .SelectedIndex = 0
        End With
    End Sub
    Private Sub ListarComboDepartamento()
        With cboDepartamento
            Dim lista As New Dictionary(Of String, Integer)
            For Each i As Integer In [Enum].GetValues(GetType(Departamento))
                lista.Add([Enum].GetName(GetType(Departamento), i), i)
            Next

            .DataSource = New BindingSource(lista, Nothing)
            .DisplayMember = "Key"
            .ValueMember = "Value"
            .DropDownStyle = ComboBoxStyle.DropDownList
            .SelectedIndex = 0
        End With
    End Sub
    Private Sub ListarPais()
        With cboPais
            Dim lista As New Dictionary(Of String, Integer)
            For Each i As Integer In [Enum].GetValues(GetType(Pais))
                lista.Add([Enum].GetName(GetType(Pais), i), i)
            Next

            .DataSource = New BindingSource(lista, Nothing)
            .DisplayMember = "Key"
            .ValueMember = "Value"
            .DropDownStyle = ComboBoxStyle.DropDownList
            .SelectedIndex = 0
        End With
    End Sub
    Private Sub ObtenerValoresTabla()
        With dgvEmpleado
            codigoEmpleado = .Rows(.CurrentRow.Index).Cells(0).Value
            txtNombres.Text = .Rows(.CurrentRow.Index).Cells(1).Value
            txtApellidos.Text = (.Rows(.CurrentRow.Index).Cells(2).Value)
            txtTelefono.Text = IIf(IsDBNull(.Rows(.CurrentRow.Index).Cells(3).Value), "", .Rows(.CurrentRow.Index).Cells(3).Value)
            txtDireccion.Text = IIf(IsDBNull(.Rows(.CurrentRow.Index).Cells(4).Value), "", .Rows(.CurrentRow.Index).Cells(4).Value)
            cboDistrito.SelectedIndex = IIf(IsDBNull(.Rows(.CurrentRow.Index).Cells(5).Value), 0, .Rows(.CurrentRow.Index).Cells(5).Value)
            cboDepartamento.SelectedIndex = IIf(IsDBNull(.Rows(.CurrentRow.Index).Cells(6).Value), 0, .Rows(.CurrentRow.Index).Cells(6).Value)
            cboPais.SelectedIndex = IIf(IsDBNull(.Rows(.CurrentRow.Index).Cells(7).Value), 0, .Rows(.CurrentRow.Index).Cells(7).Value)
        End With
    End Sub
    Private Sub OculatrColumnas()
        With dgvEmpleado
            .Columns(5).Visible = False
            .Columns(6).Visible = False
            .Columns(7).Visible = False
        End With
    End Sub
#End Region


#Region "Eventos"
    Private Sub frmEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarFormulario(Me, "Formulario de Empleados", Windows.Forms.FormBorderStyle.FixedDialog, False, FormWindowState.Normal)
        gbDatos.Enabled = False
        ListarTabla()
        TablaPersonalizar(dgvEmpleado)
        OculatrColumnas()
        ListarComboDistrito()
        ListarComboDepartamento()
        ListarPais()
        Botones(True, False, True, True, True, False)
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        valor = 1
        gbDatos.Enabled = True
        gbDatos.Text = "Datos (Nuevo)"
        txtNombres.Focus()
        Botones(False, True, False, False, False, True)
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        gbDatos.Enabled = False
        gbDatos.Text = "Datos"
        Botones(True, False, True, True, True, False)
        LimpiarControles()
        ListarTabla()
    End Sub
    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        With Me.empleado
            .CodigoEmpleado = Me.codigoEmpleado
            .Nombres = txtNombres.Text
            .Apellidos = txtApellidos.Text
            .Telefono = txtTelefono.Text
            .Direccion = txtDireccion.Text
            .Distrito = cboDistrito.SelectedValue
            .Departamento = cboDepartamento.SelectedValue
            .Pais = cboPais.SelectedValue
        End With

        If txtNombres.Text.Equals("") And txtApellidos.Text.Equals("") Then
            MensajeError("Los campos nombres y apellidos son obligatorios")
            Return
        ElseIf txtNombres.Text.Equals("") Then
            MensajeError("Debe ingresar un nombre")
            Return
        ElseIf txtApellidos.Text.Equals("") Then
            MensajeError("Debe ingresar un apellido")
            Return
        End If

        If valor = 1 Then
            If (Me.empleadoCL.Agregar(Me.empleado) = True) Then
                MensajeInformacion("Datos registrados")
                ListarTabla()
                btnCancelar.PerformClick()
            Else
                MensajeError("Hubo un error en el registro")
                Return
            End If
        ElseIf valor = 2 Then
            If (Me.empleadoCL.Editar(Me.empleado) = True) Then
                MensajeInformacion("Datos modificados")
                ListarTabla()
                btnCancelar.PerformClick()
            Else
                MensajeError("Hubo un error al editar los registros")
                Return
            End If
        End If

    End Sub
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        valor = 2
        gbDatos.Enabled = True
        txtNombres.Focus()
        gbDatos.Text = "Datos (Editar)"
        Botones(False, True, False, False, False, True)
        ObtenerValoresTabla()
    End Sub
    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Me.empleado.CodigoEmpleado = dgvEmpleado.Rows(dgvEmpleado.CurrentRow.Index).Cells(0).Value
        Me.empleado.Nombres = dgvEmpleado.Rows(dgvEmpleado.CurrentRow.Index).Cells(1).Value
        Me.empleado.Apellidos = dgvEmpleado.Rows(dgvEmpleado.CurrentRow.Index).Cells(2).Value

        If MensajePregunta("¿Esta seguro que desea eliminar el empleado " &
                           Me.empleado.Nombres & " " & Me.empleado.Apellidos & "?") = Windows.Forms.DialogResult.Yes Then

            If (Me.empleadoCL.Borrar(Me.empleado) = True) Then
                MensajeInformacion("Dato borrado")
                ListarTabla()
                btnCancelar.PerformClick()
            Else
                Return
            End If
        End If
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        With Me.empleado
            .Nombres = txtPorNombres.Text.Trim()
            .Apellidos = txtPorApellidos.Text.Trim()
        End With

        Dim dt As New DataTable()
        dt = Me.empleadoCL.Buscar(Me.empleado)
        dt.Columns.Add("Distrito", GetType(Distrito))
        dt.Columns.Add("Departamento", GetType(Departamento))
        dt.Columns.Add("País", GetType(Pais))

        For Each row As DataRow In dt.Rows
            Dim distrito As Integer = CInt(row(5))
            Dim departamento As Integer = CInt(row(6))
            Dim pais As Integer = CInt(row(7))

            row(8) = DirectCast(distrito, Distrito)
            row(9) = DirectCast(departamento, Departamento)
            row(10) = DirectCast(pais, Pais)
        Next

        dgvEmpleado.DataSource = dt
    End Sub
#End Region

   
    
End Class