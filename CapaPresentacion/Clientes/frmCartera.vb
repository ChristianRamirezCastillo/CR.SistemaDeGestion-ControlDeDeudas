Imports CapaLogica
Imports CapaEntidades

Public Class frmCartera

#Region "Campos"

    Dim existe As Boolean
    Dim bancoCL As New BancoCL()
    Dim clienteCL As New ClienteCL()

#End Region


#Region "Metodos"
    Private Sub OrdenarColumnas()
        With dgvCartera
            .Columns(17).DisplayIndex = 0
        End With
    End Sub
    Private Sub LimpiarTextos()
        txtNumeroDocumento.Clear()
        txtNombres.Clear()
        txtApellidos.Clear()
    End Sub
    Private Sub ObtenerCantidades()
        Dim sinGestion As Integer
        Dim Cobrado As Integer
        Dim Inubicable As Integer
        Dim PromesaPendiente As Integer

        For rows As Integer = 0 To dgvCartera.Rows.Count - 1
            Dim valor As Integer = dgvCartera.Item(12, rows).Value.ToString()
            rows = +rows

            If valor = 0 Then
                sinGestion = sinGestion + 1
            ElseIf valor = 1 Then
                Cobrado = Cobrado + 1
            ElseIf valor = 2 Then
                Inubicable = Inubicable + 1
            ElseIf valor = 3 Then
                PromesaPendiente = PromesaPendiente + 1
            End If

        Next

        lblSinGestion.Text = sinGestion
        lblCobrado.Text = Cobrado
        lblInubicable.Text = Inubicable
        lblPromesaPendiente.Text = PromesaPendiente
        lblTotalEncontrados.Text = dgvCartera.Rows.Count
    End Sub
    Private Sub OcultarColumnas()
        With dgvCartera
            .Columns(0).Visible = False
            .Columns(1).Visible = False

            If frmMenu.lblNivel.Text <> "Administrador" Then
                .Columns(2).Visible = False
                .Columns(3).Visible = False
            End If

            .Columns(7).Visible = False
            .Columns(8).Visible = False
            .Columns(9).Visible = False
            .Columns(10).Visible = False
            .Columns(11).Visible = False
            .Columns(12).Visible = False
            .Columns(13).Visible = False
            .Columns(14).Visible = False
            .Columns(15).Visible = False
        End With
    End Sub
    Private Sub ListarTabla()
        Dim dt As New DataTable()

        If frmMenu.lblNivel.Text <> "Administrador" Then
            dt = Me.clienteCL.Listar(cboBanco.SelectedIndex + 1, frmMenu.lblCodigoEmpleado.Text)
            'dt = Me.clienteCL.Listar(cboBanco.SelectedIndex + 1)
        Else
            dt = Me.clienteCL.Listar(cboBanco.SelectedIndex + 1)
        End If

        dt.Columns.Add("Distrito", GetType(Distrito))
        dt.Columns.Add("Departamento", GetType(Departamento))
        dt.Columns.Add("País", GetType(Pais))
        dt.Columns.Add("Tipo Deudor", GetType(TipoDeudor))

        For Each row As DataRow In dt.Rows
            Dim distrito As Integer = CInt(row(9))
            Dim departamento As Integer = CInt(row(10))
            Dim pais As Integer = CInt(row(11))
            Dim tipoDeudor As Integer = CInt(row(12))

            row(13) = DirectCast(distrito, Distrito)
            row(14) = DirectCast(departamento, Departamento)
            row(15) = DirectCast(pais, Pais)
            row(16) = DirectCast(tipoDeudor, TipoDeudor)
        Next

        dgvCartera.DataSource = dt
        dgvCartera.AutoGenerateColumns = False
        OcultarColumnas()

        If existe = False Then
            Dim btncol As New DataGridViewButtonColumn()
            btncol.HeaderText = "Detalles"
            btncol.Text = "Ver"
            btncol.Width = 75
            btncol.UseColumnTextForButtonValue = True
            dgvCartera.Columns.Add(btncol)
            existe = True
        End If

        OrdenarColumnas()

    End Sub
    Private Sub BuscarTabla()
        Dim dt As New DataTable()

        If frmMenu.lblNivel.Text <> "Administrador" Then
            dt = Me.clienteCL.Buscar(cboBanco.SelectedIndex + 1, frmMenu.lblCodigoEmpleado.Text,
                                     txtNumeroDocumento.Text, txtNombres.Text, txtApellidos.Text)
            'dt = Me.clienteCL.Buscar(cboBanco.SelectedIndex + 1, txtNumeroDocumento.Text,
            '                       txtApellidos.Text, txtApellidos.Text)
        Else
            dt = Me.clienteCL.Buscar(cboBanco.SelectedIndex + 1, txtNumeroDocumento.Text,
                                     txtNombres.Text, txtApellidos.Text)
        End If

        dt.Columns.Add("Distrito", GetType(Distrito))
        dt.Columns.Add("Departamento", GetType(Departamento))
        dt.Columns.Add("País", GetType(Pais))
        dt.Columns.Add("Tipo Deudor", GetType(TipoDeudor))

        For Each row As DataRow In dt.Rows
            Dim distrito As Integer = CInt(row(9))
            Dim departamento As Integer = CInt(row(10))
            Dim pais As Integer = CInt(row(11))
            Dim tipoDeudor As Integer = CInt(row(12))

            row(13) = DirectCast(distrito, Distrito)
            row(14) = DirectCast(departamento, Departamento)
            row(15) = DirectCast(pais, Pais)
            row(16) = DirectCast(tipoDeudor, TipoDeudor)
        Next

        dgvCartera.DataSource = dt
        OcultarColumnas()
    End Sub
    Private Sub ListarComboBanco()
        Dim dt As New DataTable()
        dt = Me.bancoCL.ListarCombo()
        With cboBanco
            .DropDownStyle = ComboBoxStyle.DropDownList
            .DataSource = dt
            .DisplayMember = dt.Columns(1).ToString()
            .ValueMember = dt.Columns(0).ToString()
        End With
    End Sub
#End Region


#Region "Eventos"
    Private Sub frmCartera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarFormulario(Me, "Formulario Cartera de Clientes", Windows.Forms.FormBorderStyle.FixedDialog,
                              False, FormWindowState.Normal)
        ListarComboBanco()
        TablaPersonalizar(dgvCartera)

    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If dgvCartera.Rows.Count.Equals(0) Then
            MensajeError("No hay datos que buscar")
            Return
        End If

        BuscarTabla()
        ObtenerCantidades()
    End Sub
    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        ListarTabla()
        ObtenerCantidades()
        LimpiarTextos()
    End Sub
    Private Sub txtNumeroDocumento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumeroDocumento.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
#End Region


End Class