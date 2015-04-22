<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCliente))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.lblPais = New System.Windows.Forms.Label()
        Me.lblDepartamento = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblDistrito = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblNumeroDocumento = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblUltimaGestion = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTipoDeudor = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lblDireccionEmpresa = New System.Windows.Forms.Label()
        Me.lblTelefonoEmpresa = New System.Windows.Forms.Label()
        Me.lblRuc = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lblSueldo = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblNombresEmpresa = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgvProducto = New System.Windows.Forms.DataGridView()
        Me.dgvGestion = New System.Windows.Forms.DataGridView()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.gbPromesa = New System.Windows.Forms.GroupBox()
        Me.txtPago = New System.Windows.Forms.TextBox()
        Me.lblResta = New System.Windows.Forms.Label()
        Me.lblDeuda = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.cboTipoGestion = New System.Windows.Forms.ComboBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.RichTextBox()
        Me.cboProducto = New System.Windows.Forms.ComboBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvGestion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPromesa.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.lblPais)
        Me.GroupBox1.Controls.Add(Me.lblDepartamento)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.lblDistrito)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.lblDireccion)
        Me.GroupBox1.Controls.Add(Me.lblTelefono)
        Me.GroupBox1.Controls.Add(Me.lblNumeroDocumento)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblApellidos)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblNombres)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 277)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Personales"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(14, 153)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(52, 13)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "Dirección"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(37, 243)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(29, 13)
        Me.Label26.TabIndex = 13
        Me.Label26.Text = "País"
        '
        'lblPais
        '
        Me.lblPais.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPais.Location = New System.Drawing.Point(72, 239)
        Me.lblPais.Name = "lblPais"
        Me.lblPais.Size = New System.Drawing.Size(219, 20)
        Me.lblPais.TabIndex = 14
        Me.lblPais.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDepartamento
        '
        Me.lblDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDepartamento.Location = New System.Drawing.Point(72, 208)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(219, 20)
        Me.lblDepartamento.TabIndex = 12
        Me.lblDepartamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(33, 212)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(33, 13)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "Dpto."
        '
        'lblDistrito
        '
        Me.lblDistrito.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDistrito.Location = New System.Drawing.Point(72, 178)
        Me.lblDistrito.Name = "lblDistrito"
        Me.lblDistrito.Size = New System.Drawing.Size(219, 20)
        Me.lblDistrito.TabIndex = 12
        Me.lblDistrito.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(27, 183)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 13)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Distrito"
        '
        'lblDireccion
        '
        Me.lblDireccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDireccion.Location = New System.Drawing.Point(72, 149)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(219, 20)
        Me.lblDireccion.TabIndex = 12
        Me.lblDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTelefono
        '
        Me.lblTelefono.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTelefono.Location = New System.Drawing.Point(72, 117)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(219, 20)
        Me.lblTelefono.TabIndex = 11
        Me.lblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNumeroDocumento
        '
        Me.lblNumeroDocumento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNumeroDocumento.Location = New System.Drawing.Point(72, 87)
        Me.lblNumeroDocumento.Name = "lblNumeroDocumento"
        Me.lblNumeroDocumento.Size = New System.Drawing.Size(219, 20)
        Me.lblNumeroDocumento.TabIndex = 11
        Me.lblNumeroDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Telefono"
        '
        'lblApellidos
        '
        Me.lblApellidos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblApellidos.Location = New System.Drawing.Point(72, 58)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(219, 20)
        Me.lblApellidos.TabIndex = 10
        Me.lblApellidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "N° Dcto."
        '
        'lblNombres
        '
        Me.lblNombres.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNombres.Location = New System.Drawing.Point(72, 29)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(219, 20)
        Me.lblNombres.TabIndex = 9
        Me.lblNombres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nombres"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Apellidos"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblUltimaGestion)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lblTipoDeudor)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(867, 55)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Criterios"
        '
        'lblUltimaGestion
        '
        Me.lblUltimaGestion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUltimaGestion.Location = New System.Drawing.Point(656, 22)
        Me.lblUltimaGestion.Name = "lblUltimaGestion"
        Me.lblUltimaGestion.Size = New System.Drawing.Size(132, 20)
        Me.lblUltimaGestion.TabIndex = 10
        Me.lblUltimaGestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(575, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Ultima Gestión"
        '
        'lblTipoDeudor
        '
        Me.lblTipoDeudor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTipoDeudor.Location = New System.Drawing.Point(89, 22)
        Me.lblTipoDeudor.Name = "lblTipoDeudor"
        Me.lblTipoDeudor.Size = New System.Drawing.Size(132, 20)
        Me.lblTipoDeudor.TabIndex = 8
        Me.lblTipoDeudor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo Deudor"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.lblDireccionEmpresa)
        Me.GroupBox3.Controls.Add(Me.lblTelefonoEmpresa)
        Me.GroupBox3.Controls.Add(Me.lblRuc)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.lblSueldo)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.lblNombresEmpresa)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Location = New System.Drawing.Point(330, 73)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(549, 114)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos Laborables"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(16, 88)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(52, 13)
        Me.Label28.TabIndex = 13
        Me.Label28.Text = "Dirección"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(195, 59)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(49, 13)
        Me.Label25.TabIndex = 4
        Me.Label25.Text = "Telefono"
        '
        'lblDireccionEmpresa
        '
        Me.lblDireccionEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDireccionEmpresa.Location = New System.Drawing.Point(74, 84)
        Me.lblDireccionEmpresa.Name = "lblDireccionEmpresa"
        Me.lblDireccionEmpresa.Size = New System.Drawing.Size(396, 20)
        Me.lblDireccionEmpresa.TabIndex = 14
        Me.lblDireccionEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTelefonoEmpresa
        '
        Me.lblTelefonoEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTelefonoEmpresa.Location = New System.Drawing.Point(250, 55)
        Me.lblTelefonoEmpresa.Name = "lblTelefonoEmpresa"
        Me.lblTelefonoEmpresa.Size = New System.Drawing.Size(220, 20)
        Me.lblTelefonoEmpresa.TabIndex = 15
        Me.lblTelefonoEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRuc
        '
        Me.lblRuc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRuc.Location = New System.Drawing.Point(75, 55)
        Me.lblRuc.Name = "lblRuc"
        Me.lblRuc.Size = New System.Drawing.Size(114, 20)
        Me.lblRuc.TabIndex = 13
        Me.lblRuc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(39, 59)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(30, 13)
        Me.Label23.TabIndex = 12
        Me.Label23.Text = "RUC"
        '
        'lblSueldo
        '
        Me.lblSueldo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSueldo.Location = New System.Drawing.Point(385, 29)
        Me.lblSueldo.Name = "lblSueldo"
        Me.lblSueldo.Size = New System.Drawing.Size(85, 20)
        Me.lblSueldo.TabIndex = 11
        Me.lblSueldo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(339, 33)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(40, 13)
        Me.Label21.TabIndex = 10
        Me.Label21.Text = "Sueldo"
        '
        'lblNombresEmpresa
        '
        Me.lblNombresEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNombresEmpresa.Location = New System.Drawing.Point(75, 29)
        Me.lblNombresEmpresa.Name = "lblNombresEmpresa"
        Me.lblNombresEmpresa.Size = New System.Drawing.Size(258, 20)
        Me.lblNombresEmpresa.TabIndex = 11
        Me.lblNombresEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(20, 33)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(49, 13)
        Me.Label19.TabIndex = 10
        Me.Label19.Text = "Nombres"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dgvProducto)
        Me.GroupBox4.Location = New System.Drawing.Point(330, 194)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(549, 156)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos del Producto"
        '
        'dgvProducto
        '
        Me.dgvProducto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducto.Location = New System.Drawing.Point(6, 19)
        Me.dgvProducto.Name = "dgvProducto"
        Me.dgvProducto.Size = New System.Drawing.Size(537, 131)
        Me.dgvProducto.TabIndex = 0
        '
        'dgvGestion
        '
        Me.dgvGestion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvGestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGestion.Location = New System.Drawing.Point(6, 19)
        Me.dgvGestion.Name = "dgvGestion"
        Me.dgvGestion.Size = New System.Drawing.Size(595, 281)
        Me.dgvGestion.TabIndex = 1
        '
        'btnGrabar
        '
        Me.btnGrabar.Image = CType(resources.GetObject("btnGrabar.Image"), System.Drawing.Image)
        Me.btnGrabar.Location = New System.Drawing.Point(783, 271)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(75, 26)
        Me.btnGrabar.TabIndex = 28
        Me.btnGrabar.Text = "&Grabar"
        Me.btnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'gbPromesa
        '
        Me.gbPromesa.Controls.Add(Me.txtPago)
        Me.gbPromesa.Controls.Add(Me.lblResta)
        Me.gbPromesa.Controls.Add(Me.lblDeuda)
        Me.gbPromesa.Controls.Add(Me.Label3)
        Me.gbPromesa.Controls.Add(Me.Label49)
        Me.gbPromesa.Controls.Add(Me.Label48)
        Me.gbPromesa.Enabled = False
        Me.gbPromesa.Location = New System.Drawing.Point(610, 73)
        Me.gbPromesa.Name = "gbPromesa"
        Me.gbPromesa.Size = New System.Drawing.Size(248, 105)
        Me.gbPromesa.TabIndex = 27
        Me.gbPromesa.TabStop = False
        Me.gbPromesa.Text = "Promesa de Pago"
        '
        'txtPago
        '
        Me.txtPago.Location = New System.Drawing.Point(68, 51)
        Me.txtPago.Name = "txtPago"
        Me.txtPago.Size = New System.Drawing.Size(157, 20)
        Me.txtPago.TabIndex = 31
        Me.txtPago.Text = "0.00"
        Me.txtPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblResta
        '
        Me.lblResta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResta.Location = New System.Drawing.Point(68, 76)
        Me.lblResta.Name = "lblResta"
        Me.lblResta.Size = New System.Drawing.Size(157, 20)
        Me.lblResta.TabIndex = 30
        Me.lblResta.Text = "0.00"
        Me.lblResta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDeuda
        '
        Me.lblDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDeuda.Location = New System.Drawing.Point(68, 26)
        Me.lblDeuda.Name = "lblDeuda"
        Me.lblDeuda.Size = New System.Drawing.Size(157, 20)
        Me.lblDeuda.TabIndex = 29
        Me.lblDeuda.Text = "0.00"
        Me.lblDeuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Resta"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(30, 54)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(32, 13)
        Me.Label49.TabIndex = 25
        Me.Label49.Text = "Pago"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(23, 30)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(39, 13)
        Me.Label48.TabIndex = 23
        Me.Label48.Text = "Deuda"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(607, 49)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(67, 13)
        Me.Label47.TabIndex = 22
        Me.Label47.Text = "Tipo Gestión"
        '
        'cboTipoGestion
        '
        Me.cboTipoGestion.FormattingEnabled = True
        Me.cboTipoGestion.Location = New System.Drawing.Point(680, 46)
        Me.cboTipoGestion.Name = "cboTipoGestion"
        Me.cboTipoGestion.Size = New System.Drawing.Size(178, 21)
        Me.cboTipoGestion.TabIndex = 21
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(607, 181)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(67, 13)
        Me.Label46.TabIndex = 20
        Me.Label46.Text = "Observación"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(610, 197)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(248, 68)
        Me.txtDescripcion.TabIndex = 19
        Me.txtDescripcion.Text = ""
        '
        'cboProducto
        '
        Me.cboProducto.FormattingEnabled = True
        Me.cboProducto.Location = New System.Drawing.Point(680, 19)
        Me.cboProducto.Name = "cboProducto"
        Me.cboProducto.Size = New System.Drawing.Size(178, 21)
        Me.cboProducto.TabIndex = 2
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(624, 22)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(50, 13)
        Me.Label45.TabIndex = 1
        Me.Label45.Text = "Producto"
        '
        'btnRegresar
        '
        Me.btnRegresar.Image = CType(resources.GetObject("btnRegresar.Image"), System.Drawing.Image)
        Me.btnRegresar.Location = New System.Drawing.Point(12, 356)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(75, 26)
        Me.btnRegresar.TabIndex = 9
        Me.btnRegresar.Text = "&Regresar"
        Me.btnRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnGrabar)
        Me.GroupBox5.Controls.Add(Me.dgvGestion)
        Me.GroupBox5.Controls.Add(Me.Label46)
        Me.GroupBox5.Controls.Add(Me.txtDescripcion)
        Me.GroupBox5.Controls.Add(Me.gbPromesa)
        Me.GroupBox5.Controls.Add(Me.cboProducto)
        Me.GroupBox5.Controls.Add(Me.Label47)
        Me.GroupBox5.Controls.Add(Me.Label45)
        Me.GroupBox5.Controls.Add(Me.cboTipoGestion)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 388)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(867, 306)
        Me.GroupBox5.TabIndex = 10
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Registrar Gestion"
        '
        'frmCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 704)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmCliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgvProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvGestion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPromesa.ResumeLayout(False)
        Me.gbPromesa.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTipoDeudor As System.Windows.Forms.Label
    Friend WithEvents lblUltimaGestion As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents lblNumeroDocumento As System.Windows.Forms.Label
    Friend WithEvents lblApellidos As System.Windows.Forms.Label
    Friend WithEvents lblNombres As System.Windows.Forms.Label
    Friend WithEvents lblDepartamento As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblDistrito As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents lblRuc As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents lblSueldo As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lblNombresEmpresa As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents lblPais As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents lblTelefonoEmpresa As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents lblDireccionEmpresa As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvProducto As System.Windows.Forms.DataGridView
    Friend WithEvents dgvGestion As System.Windows.Forms.DataGridView
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents cboProducto As System.Windows.Forms.ComboBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.RichTextBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents cboTipoGestion As System.Windows.Forms.ComboBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents gbPromesa As System.Windows.Forms.GroupBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents btnRegresar As System.Windows.Forms.Button
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblDeuda As System.Windows.Forms.Label
    Friend WithEvents lblResta As System.Windows.Forms.Label
    Friend WithEvents txtPago As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
End Class
