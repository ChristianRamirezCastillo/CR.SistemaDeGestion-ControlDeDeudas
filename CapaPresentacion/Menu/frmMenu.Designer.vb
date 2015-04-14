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
        Me.mnuMenuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.mnuClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGestion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGestionUsuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.stpMenu = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblNivel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblIdentificacion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblFecha = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.mnuMenuPrincipal.SuspendLayout()
        Me.stpMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMenuPrincipal
        '
        Me.mnuMenuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClientes, Me.mnuGestion})
        Me.mnuMenuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenuPrincipal.Name = "mnuMenuPrincipal"
        Me.mnuMenuPrincipal.Size = New System.Drawing.Size(791, 24)
        Me.mnuMenuPrincipal.TabIndex = 0
        Me.mnuMenuPrincipal.Text = "MenuStrip1"
        '
        'mnuClientes
        '
        Me.mnuClientes.Name = "mnuClientes"
        Me.mnuClientes.Size = New System.Drawing.Size(61, 20)
        Me.mnuClientes.Text = "Clientes"
        '
        'mnuGestion
        '
        Me.mnuGestion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuGestionUsuario})
        Me.mnuGestion.Name = "mnuGestion"
        Me.mnuGestion.Size = New System.Drawing.Size(59, 20)
        Me.mnuGestion.Text = "Gestión"
        '
        'mnuGestionUsuario
        '
        Me.mnuGestionUsuario.Name = "mnuGestionUsuario"
        Me.mnuGestionUsuario.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.mnuGestionUsuario.Size = New System.Drawing.Size(156, 22)
        Me.mnuGestionUsuario.Text = "Usuario"
        '
        'stpMenu
        '
        Me.stpMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblUsuario, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.lblNivel, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel5, Me.lblIdentificacion, Me.ToolStripStatusLabel6, Me.lblFecha})
        Me.stpMenu.Location = New System.Drawing.Point(0, 415)
        Me.stpMenu.Name = "stpMenu"
        Me.stpMenu.Size = New System.Drawing.Size(791, 22)
        Me.stpMenu.TabIndex = 1
        Me.stpMenu.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(50, 17)
        Me.ToolStripStatusLabel1.Text = "Usuario:"
        '
        'lblUsuario
        '
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(60, 17)
        Me.lblUsuario.Text = "lblUsuario"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripStatusLabel2.Text = "|"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(37, 17)
        Me.ToolStripStatusLabel3.Text = "Nivel:"
        '
        'lblNivel
        '
        Me.lblNivel.Name = "lblNivel"
        Me.lblNivel.Size = New System.Drawing.Size(47, 17)
        Me.lblNivel.Text = "lblNivel"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripStatusLabel4.Text = "|"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(82, 17)
        Me.ToolStripStatusLabel5.Text = "Identificación:"
        '
        'lblIdentificacion
        '
        Me.lblIdentificacion.Name = "lblIdentificacion"
        Me.lblIdentificacion.Size = New System.Drawing.Size(92, 17)
        Me.lblIdentificacion.Text = "lblIdentificacion"
        '
        'lblFecha
        '
        Me.lblFecha.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(52, 17)
        Me.lblFecha.Text = "lblFecha"
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(305, 17)
        Me.ToolStripStatusLabel6.Spring = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 437)
        Me.Controls.Add(Me.stpMenu)
        Me.Controls.Add(Me.mnuMenuPrincipal)
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
End Class
