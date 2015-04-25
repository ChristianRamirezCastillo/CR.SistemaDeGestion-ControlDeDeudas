Imports CapaLogica
Imports CapaEntidades

Public Class frmCliente

#Region "Campos"
    Dim clienteCL As New ClienteCL()
    Dim gestionCL As New GestionCL()
    Dim gestion As New Gestion()
    Dim productoCL As New ProductoCL()
#End Region


#Region "Metodos"

    Private Sub LimpiarValores()
        lblNombres.Text = ""
        lblApellidos.Text = ""
        lblNumeroDocumento.Text = ""
        lblTelefono.Text = ""
        lblDireccion.Text = ""
        lblDireccion.Text = ""
        lblDepartamento.Text = ""
        lblPais.Text = ""

        lblDeuda.Text = "0"
    End Sub
    Private Sub ObtenerValoresCliente()
        With frmCartera
            lblNombres.Text = .colNombres.ToString()
            lblApellidos.Text = .colApellidos.ToString()
            lblNumeroDocumento.Text = .colNumeroDocumento.ToString()
            lblTelefono.Text = .colTelefono.ToString()
            lblDireccion.Text = .colDireccion.ToString()
            lblDistrito.Text = [Enum].GetName(GetType(Distrito), .colCodigoDistrito)
            lblDepartamento.Text = [Enum].GetName(GetType(Departamento), .colCodigoDepartamento)
            lblPais.Text = [Enum].GetName(GetType(Pais), .colCodigoPais)

            lblTipoDeudor.Text = [Enum].GetName(GetType(TipoDeudor), .colCodigoTipoDeudor)
        End With
    End Sub
    Private Sub ListarProducto()
        Dim dt As New DataTable()
        dt = Me.clienteCL.ListarProducto(frmCartera.colNumeroDocumento.ToString())

        dt.Columns.Add("Tipo Moneda", GetType(TipoMoneda))
        For Each row As DataRow In dt.Rows
            Dim tipoMoneda As Integer = CInt(row(5))
            row(7) = DirectCast(tipoMoneda, TipoMoneda)
        Next

        With dgvProducto
            .DataSource = dt
            .Columns(1).Visible = False
            .Columns(5).Visible = False
            .Columns(4).DisplayIndex = 0
            .Columns(0).HeaderText = "Producto"
            .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End With
    End Sub
    Private Sub ListarEmpresa()
        Dim dt As New DataTable()
        dt = clienteCL.ListarEmpresa(frmCartera.colNumeroDocumento.ToString())
        lblNombresEmpresa.Text = dt.Rows(0).Item(1).ToString()
        lblSueldo.Text = dt.Rows(0).Item(2).ToString()
        lblRuc.Text = dt.Rows(0).Item(3).ToString()
        lblTelefonoEmpresa.Text = dt.Rows(0).Item(4).ToString()
        lblDireccionEmpresa.Text = dt.Rows(0).Item(5).ToString()
    End Sub
    Private Sub ListarComboProducto()
        Dim dt As New DataTable()
        dt = Me.clienteCL.ListarProducto(frmCartera.colNumeroDocumento, True)

        With cboProducto
            .DropDownStyle = ComboBoxStyle.DropDownList
            .DataSource = dt
            .ValueMember = dt.Columns(0).ToString()
            .DisplayMember = dt.Columns(0).ToString()
        End With


        If dt.Rows.Count <= 0 Then
            lblDeuda.Text = "0"
        Else
            lblDeuda.Text = Me.productoCL.ListarDeuda(dt.Rows(0).Item(0).ToString())
        End If

    End Sub
    Private Sub ListarComboGestion()
        With cboTipoGestion
            Dim lista As New Dictionary(Of String, Integer)
            For Each i As Integer In [Enum].GetValues(GetType(TipoDeudor))
                lista.Add([Enum].GetName(GetType(TipoDeudor), i), i)
            Next

            lista.Remove("SinGestion")
            .DataSource = New BindingSource(lista, Nothing)
            .DisplayMember = "Key"
            .ValueMember = "Value"
            .DropDownStyle = ComboBoxStyle.DropDownList
        End With
    End Sub
    Private Sub ListarGestion()
        Me.gestion.Empleado.CodigoEmpleado = frmMenu.lblCodigoEmpleado.ToString()

        If frmMenu.lblNivel.Text.Equals("Administrador") Then
            dgvGestion.DataSource = Me.gestionCL.Listar(Nothing, frmCartera.colNumeroDocumento.ToString())
            dgvGestion.Columns(4).Visible = True
        Else
            dgvGestion.DataSource = Me.gestionCL.Listar(frmMenu.lblCodigoEmpleado.Text, frmCartera.colNumeroDocumento.ToString())
            dgvGestion.Columns(4).Visible = False
        End If

        dgvGestion.Columns(0).Visible = False
        dgvGestion.Columns(1).Visible = False
        dgvGestion.Columns(2).Visible = False
        dgvGestion.Columns(3).Visible = False
        dgvGestion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
    End Sub
    Private Sub ListarDeuda()
        Dim deuda As String = Me.productoCL.ListarDeuda(cboProducto.Text)
        lblDeuda.Text = IIf(IsDBNull(deuda) = True, "0", deuda)
    End Sub
    Private Sub ListarUltimaGestion()
        lblUltimaGestion.Text = Convert.ToString(Me.gestionCL.ListarUltimaGestion(frmCartera.colNumeroDocumento))
    End Sub

#End Region


#Region "Eventos"

    Private Sub frmCliente_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FormularioHijo(frmCartera, frmMenu)
        LimpiarValores()
    End Sub
    Private Sub frmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarFormulario(Me, "Formulario Cliente", Windows.Forms.FormBorderStyle.FixedDialog,
                              False, FormWindowState.Normal)
        ObtenerValoresCliente()
        Me.CenterToScreen()
        ListarProducto()
        ListarEmpresa()
        ListarComboProducto()
        ListarComboGestion()
        ListarGestion()
        ListarUltimaGestion()
        TablaPersonalizar(dgvGestion)
        TablaPersonalizar(dgvProducto)
    End Sub
    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Close()
        Me.Dispose()
        FormularioHijo(frmCartera, frmMenu)
        LimpiarValores()
    End Sub
    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If cboProducto.Items.Count = False Then
            MensajeError("No existe un producto por asignar")
        Else
            If MensajePregunta("¿Seguro que desea grabar los datos?") = Windows.Forms.DialogResult.Yes Then

                With gestion
                    .Empleado.CodigoEmpleado = frmMenu.lblCodigoEmpleado.Text
                    .CodigoCliente = frmCartera.colNumeroDocumento
                    .CodigoProducto = cboProducto.Text
                    .Descripcion = txtDescripcion.Text
                    .DeudaPagada = txtPago.Text
                    .DeudaRestante = lblResta.Text
                End With

                If Me.gestionCL.Agregar(gestion, (cboTipoGestion.SelectedIndex + 1)) = True Then
                    ListarGestion()
                    frmCartera.ListarTabla()

                    txtDescripcion.Clear()
                    cboTipoGestion.SelectedIndex = 0
                    cboProducto.SelectedIndex = 0

                    MensajeInformacion("Datos registrados")
                    ListarUltimaGestion()
                Else
                    MensajeError("Hubo un error al registrar los datos")
                    Return
                End If
            End If
        End If
    End Sub
    Private Sub cboTipoGestion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoGestion.SelectedIndexChanged

        If cboTipoGestion.SelectedIndex = 0 Then
            txtPago.Text = lblDeuda.Text
        ElseIf cboTipoGestion.SelectedIndex = 2 Then
            gbPromesa.Enabled = True
        Else
            gbPromesa.Enabled = False
            txtPago.Text = "0.00"
            lblResta.Text = "0.00"
        End If
    End Sub
    Private Sub cboProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProducto.SelectedIndexChanged
        ListarDeuda()
    End Sub
    Private Sub txtPago_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPago.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not AscW(e.KeyChar()) = 46 And Not AscW(e.KeyChar()) = 183 Then
            e.Handled = True
        ElseIf e.KeyChar = "." And Not sender.Text.IndexOf(".") Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtPago_TextChanged(sender As Object, e As EventArgs) Handles txtPago.TextChanged

        If lblDeuda.Text.Equals("") Or lblDeuda.Text.Equals("0") Then
            lblDeuda.Text = "0.00"
        End If
        If txtPago.Text.Equals("") Or txtPago.Text.Equals("0") Then
            txtPago.Text = "0.00"
        End If

        lblResta.Text = CStr(Math.Round(CDbl(lblDeuda.Text) - CDbl(txtPago.Text), 2))

    End Sub

#End Region


End Class