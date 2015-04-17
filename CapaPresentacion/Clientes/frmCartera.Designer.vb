<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCartera
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCartera))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.cboBanco = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblPromesaPendiente = New System.Windows.Forms.Label()
        Me.lblInubicable = New System.Windows.Forms.Label()
        Me.lblCobrado = New System.Windows.Forms.Label()
        Me.lblSinGestion = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvCartera = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtNumeroDocumento = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTotalEncontrados = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvCartera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnFiltrar)
        Me.GroupBox1.Controls.Add(Me.cboBanco)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(385, 80)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Criterios de Busqueda"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Image = CType(resources.GetObject("btnFiltrar.Image"), System.Drawing.Image)
        Me.btnFiltrar.Location = New System.Drawing.Point(277, 30)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(75, 26)
        Me.btnFiltrar.TabIndex = 9
        Me.btnFiltrar.Text = "&Filtrar"
        Me.btnFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFiltrar.UseVisualStyleBackColor = True
        '
        'cboBanco
        '
        Me.cboBanco.FormattingEnabled = True
        Me.cboBanco.Location = New System.Drawing.Point(62, 34)
        Me.cboBanco.Name = "cboBanco"
        Me.cboBanco.Size = New System.Drawing.Size(209, 21)
        Me.cboBanco.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Banco"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblPromesaPendiente)
        Me.GroupBox2.Controls.Add(Me.lblInubicable)
        Me.GroupBox2.Controls.Add(Me.lblCobrado)
        Me.GroupBox2.Controls.Add(Me.lblSinGestion)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(403, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(289, 80)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultados"
        '
        'lblPromesaPendiente
        '
        Me.lblPromesaPendiente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPromesaPendiente.Location = New System.Drawing.Point(202, 51)
        Me.lblPromesaPendiente.Name = "lblPromesaPendiente"
        Me.lblPromesaPendiente.Size = New System.Drawing.Size(58, 20)
        Me.lblPromesaPendiente.TabIndex = 7
        Me.lblPromesaPendiente.Text = "0"
        Me.lblPromesaPendiente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInubicable
        '
        Me.lblInubicable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblInubicable.Location = New System.Drawing.Point(84, 51)
        Me.lblInubicable.Name = "lblInubicable"
        Me.lblInubicable.Size = New System.Drawing.Size(58, 20)
        Me.lblInubicable.TabIndex = 7
        Me.lblInubicable.Text = "0"
        Me.lblInubicable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCobrado
        '
        Me.lblCobrado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCobrado.Location = New System.Drawing.Point(202, 21)
        Me.lblCobrado.Name = "lblCobrado"
        Me.lblCobrado.Size = New System.Drawing.Size(58, 20)
        Me.lblCobrado.TabIndex = 7
        Me.lblCobrado.Text = "0"
        Me.lblCobrado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSinGestion
        '
        Me.lblSinGestion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSinGestion.Location = New System.Drawing.Point(84, 22)
        Me.lblSinGestion.Name = "lblSinGestion"
        Me.lblSinGestion.Size = New System.Drawing.Size(58, 20)
        Me.lblSinGestion.TabIndex = 7
        Me.lblSinGestion.Text = "0"
        Me.lblSinGestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(148, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Promesa"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Inubicable"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(148, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Cobrado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Sin Gestión"
        '
        'dgvCartera
        '
        Me.dgvCartera.AllowUserToAddRows = False
        Me.dgvCartera.AllowUserToDeleteRows = False
        Me.dgvCartera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCartera.Location = New System.Drawing.Point(12, 160)
        Me.dgvCartera.Name = "dgvCartera"
        Me.dgvCartera.ReadOnly = True
        Me.dgvCartera.Size = New System.Drawing.Size(680, 343)
        Me.dgvCartera.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtApellidos)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txtNombres)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.btnBuscar)
        Me.GroupBox3.Controls.Add(Me.txtNumeroDocumento)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 98)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(680, 56)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Buscar Cliente"
        '
        'txtApellidos
        '
        Me.txtApellidos.Location = New System.Drawing.Point(544, 24)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(119, 20)
        Me.txtApellidos.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(489, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Apellidos"
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(364, 24)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(119, 20)
        Me.txtNombres.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(309, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Nombres"
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(20, 20)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 26)
        Me.btnBuscar.TabIndex = 8
        Me.btnBuscar.Text = "B&uscar"
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtNumeroDocumento
        '
        Me.txtNumeroDocumento.Location = New System.Drawing.Point(184, 24)
        Me.txtNumeroDocumento.Name = "txtNumeroDocumento"
        Me.txtNumeroDocumento.Size = New System.Drawing.Size(119, 20)
        Me.txtNumeroDocumento.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(101, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "N° Documento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(534, 520)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Total Encontrados"
        '
        'lblTotalEncontrados
        '
        Me.lblTotalEncontrados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalEncontrados.Location = New System.Drawing.Point(634, 516)
        Me.lblTotalEncontrados.Name = "lblTotalEncontrados"
        Me.lblTotalEncontrados.Size = New System.Drawing.Size(58, 20)
        Me.lblTotalEncontrados.TabIndex = 6
        Me.lblTotalEncontrados.Text = "0"
        Me.lblTotalEncontrados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmCartera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 545)
        Me.Controls.Add(Me.lblTotalEncontrados)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.dgvCartera)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmCartera"
        Me.Text = "frmCartera"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvCartera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboBanco As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgvCartera As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNumeroDocumento As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnFiltrar As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblTotalEncontrados As System.Windows.Forms.Label
    Friend WithEvents lblPromesaPendiente As System.Windows.Forms.Label
    Friend WithEvents lblInubicable As System.Windows.Forms.Label
    Friend WithEvents lblCobrado As System.Windows.Forms.Label
    Friend WithEvents lblSinGestion As System.Windows.Forms.Label
    Friend WithEvents txtApellidos As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
