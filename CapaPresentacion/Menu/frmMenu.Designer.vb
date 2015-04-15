<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.mnuMenuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.mnuClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGestion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGestionUsuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAyuda = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAyudaAcercaDe = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.stpMenu = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblNivel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblIdentificacion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblFecha = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.mnuMenuPrincipal.SuspendLayout()
        Me.stpMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMenuPrincipal
        '
        Me.mnuMenuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClientes, Me.mnuGestion, Me.mnuAyuda, Me.mnuSalir})
        Me.mnuMenuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenuPrincipal.Name = "mnuMenuPrincipal"
        Me.mnuMenuPrincipal.Size = New System.Drawing.Size(791, 32)
        Me.mnuMenuPrincipal.TabIndex = 0
        Me.mnuMenuPrincipal.Text = "MenuStrip1"
        '
        'mnuClientes
        '
        Me.mnuClientes.ForeColor = System.Drawing.Color.Black
        Me.mnuClientes.Image = CType(resources.GetObject("mnuClientes.Image"), System.Drawing.Image)
        Me.mnuClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuClientes.Name = "mnuClientes"
        Me.mnuClientes.Size = New System.Drawing.Size(85, 28)
        Me.mnuClientes.Text = "Clientes"
        '
        'mnuGestion
        '
        Me.mnuGestion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuGestionUsuario})
        Me.mnuGestion.ForeColor = System.Drawing.Color.Black
        Me.mnuGestion.Image = CType(resources.GetObject("mnuGestion.Image"), System.Drawing.Image)
        Me.mnuGestion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuGestion.Name = "mnuGestion"
        Me.mnuGestion.Size = New System.Drawing.Size(83, 28)
        Me.mnuGestion.Text = "Gestión"
        '
        'mnuGestionUsuario
        '
        Me.mnuGestionUsuario.Name = "mnuGestionUsuario"
        Me.mnuGestionUsuario.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.mnuGestionUsuario.Size = New System.Drawing.Size(156, 22)
        Me.mnuGestionUsuario.Text = "Usuario"
        '
        'mnuAyuda
        '
        Me.mnuAyuda.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAyudaAcercaDe})
        Me.mnuAyuda.Image = CType(resources.GetObject("mnuAyuda.Image"), System.Drawing.Image)
        Me.mnuAyuda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuAyuda.Name = "mnuAyuda"
        Me.mnuAyuda.Size = New System.Drawing.Size(77, 28)
        Me.mnuAyuda.Text = "Ayuda"
        '
        'mnuAyudaAcercaDe
        '
        Me.mnuAyudaAcercaDe.Name = "mnuAyudaAcercaDe"
        Me.mnuAyudaAcercaDe.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.mnuAyudaAcercaDe.Size = New System.Drawing.Size(169, 22)
        Me.mnuAyudaAcercaDe.Text = "Acerca De"
        '
        'mnuSalir
        '
        Me.mnuSalir.Image = CType(resources.GetObject("mnuSalir.Image"), System.Drawing.Image)
        Me.mnuSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuSalir.Name = "mnuSalir"
        Me.mnuSalir.Size = New System.Drawing.Size(65, 28)
        Me.mnuSalir.Text = "Salir"
        '
        'stpMenu
        '
        Me.stpMenu.BackgroundImage = CType(resources.GetObject("stpMenu.BackgroundImage"), System.Drawing.Image)
        Me.stpMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblUsuario, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.lblNivel, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel5, Me.lblIdentificacion, Me.ToolStripStatusLabel6, Me.lblFecha})
        Me.stpMenu.Location = New System.Drawing.Point(0, 415)
        Me.stpMenu.Name = "stpMenu"
        Me.stpMenu.Size = New System.Drawing.Size(791, 22)
        Me.stpMenu.TabIndex = 1
        Me.stpMenu.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(50, 17)
        Me.ToolStripStatusLabel1.Text = "Usuario:"
        '
        'lblUsuario
        '
        Me.lblUsuario.ForeColor = System.Drawing.Color.White
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(60, 17)
        Me.lblUsuario.Text = "lblUsuario"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripStatusLabel2.Text = "|"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(37, 17)
        Me.ToolStripStatusLabel3.Text = "Nivel:"
        '
        'lblNivel
        '
        Me.lblNivel.ForeColor = System.Drawing.Color.White
        Me.lblNivel.Name = "lblNivel"
        Me.lblNivel.Size = New System.Drawing.Size(47, 17)
        Me.lblNivel.Text = "lblNivel"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripStatusLabel4.Text = "|"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(82, 17)
        Me.ToolStripStatusLabel5.Text = "Identificación:"
        '
        'lblIdentificacion
        '
        Me.lblIdentificacion.ForeColor = System.Drawing.Color.White
        Me.lblIdentificacion.Name = "lblIdentificacion"
        Me.lblIdentificacion.Size = New System.Drawing.Size(92, 17)
        Me.lblIdentificacion.Text = "lblIdentificacion"
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.BackgroundImage = CType(resources.GetObject("ToolStripStatusLabel6.BackgroundImage"), System.Drawing.Image)
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(337, 17)
        Me.ToolStripStatusLabel6.Spring = True
        '
        'lblFecha
        '
        Me.lblFecha.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(51, 17)
        Me.lblFecha.Text = "lblFecha"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.Top
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 32)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(791, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(791, 437)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.stpMenu)
        Me.Controls.Add(Me.mnuMenuPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnuMenuPrincipal
        Me.Name = "frmMenu"
        Me.Text = "frmMenu"
        Me.mnuMenuPrincipal.ResumeLayout(False)
        Me.mnuMenuPrincipal.PerformLayout()
        Me.stpMenu.ResumeLayout(False)
        Me.stpMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuMenuPrincipal As System.Windows.Forms.MenuStrip
    Friend WithEvents stpMenu As System.Windows.Forms.StatusStrip
    Friend WithEvents mnuClientes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuGestion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuGestionUsuario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblUsuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblNivel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblIdentificacion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblFecha As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents mnuAyuda As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAyudaAcercaDe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
End Class
