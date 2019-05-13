<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MENUGUI
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MENUGUI))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtAdmi = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeMaterialesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatalogoDeProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PromocionesYCombosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtFecha = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.txtAdmi)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(151, 422)
        Me.Panel1.TabIndex = 0
        '
        'txtAdmi
        '
        Me.txtAdmi.AutoSize = True
        Me.txtAdmi.Location = New System.Drawing.Point(39, 31)
        Me.txtAdmi.Name = "txtAdmi"
        Me.txtAdmi.Size = New System.Drawing.Size(0, 13)
        Me.txtAdmi.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(19, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ADMINISTRADOR"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(13, 24)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DarkCyan
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.HerramientasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(725, 28)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadosToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.ListaDeMaterialesToolStripMenuItem, Me.CatalogoDeProductosToolStripMenuItem, Me.PromocionesYCombosToolStripMenuItem, Me.CompraToolStripMenuItem, Me.VentaToolStripMenuItem})
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(58, 24)
        Me.ToolStripMenuItem1.Text = "Menu"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(234, 24)
        Me.EmpleadosToolStripMenuItem.Text = "Registro de empleados"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(234, 24)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'ListaDeMaterialesToolStripMenuItem
        '
        Me.ListaDeMaterialesToolStripMenuItem.Name = "ListaDeMaterialesToolStripMenuItem"
        Me.ListaDeMaterialesToolStripMenuItem.Size = New System.Drawing.Size(234, 24)
        Me.ListaDeMaterialesToolStripMenuItem.Text = "Lista de Materiales"
        '
        'CatalogoDeProductosToolStripMenuItem
        '
        Me.CatalogoDeProductosToolStripMenuItem.Name = "CatalogoDeProductosToolStripMenuItem"
        Me.CatalogoDeProductosToolStripMenuItem.Size = New System.Drawing.Size(234, 24)
        Me.CatalogoDeProductosToolStripMenuItem.Text = "Catálogo de Productos"
        '
        'PromocionesYCombosToolStripMenuItem
        '
        Me.PromocionesYCombosToolStripMenuItem.Name = "PromocionesYCombosToolStripMenuItem"
        Me.PromocionesYCombosToolStripMenuItem.Size = New System.Drawing.Size(234, 24)
        Me.PromocionesYCombosToolStripMenuItem.Text = "Promociones y Combos"
        '
        'CompraToolStripMenuItem
        '
        Me.CompraToolStripMenuItem.Name = "CompraToolStripMenuItem"
        Me.CompraToolStripMenuItem.Size = New System.Drawing.Size(234, 24)
        Me.CompraToolStripMenuItem.Text = "Compra"
        '
        'VentaToolStripMenuItem
        '
        Me.VentaToolStripMenuItem.Name = "VentaToolStripMenuItem"
        Me.VentaToolStripMenuItem.Size = New System.Drawing.Size(234, 24)
        Me.VentaToolStripMenuItem.Text = "Venta"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.BackColor = System.Drawing.Color.DarkCyan
        Me.HerramientasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem, Me.AcercaToolStripMenuItem})
        Me.HerramientasToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HerramientasToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(63, 24)
        Me.HerramientasToolStripMenuItem.Text = "Ayuda"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(146, 24)
        Me.HelpToolStripMenuItem.Text = "Ver Ayuda"
        '
        'AcercaToolStripMenuItem
        '
        Me.AcercaToolStripMenuItem.Name = "AcercaToolStripMenuItem"
        Me.AcercaToolStripMenuItem.Size = New System.Drawing.Size(146, 24)
        Me.AcercaToolStripMenuItem.Text = "Acerca De"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'txtFecha
        '
        Me.txtFecha.AutoSize = True
        Me.txtFecha.BackColor = System.Drawing.Color.DarkCyan
        Me.txtFecha.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.ForeColor = System.Drawing.Color.Black
        Me.txtFecha.Location = New System.Drawing.Point(526, 5)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(0, 18)
        Me.txtFecha.TabIndex = 5
        Me.txtFecha.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.BackColor = System.Drawing.Color.Green
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(151, 28)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(574, 422)
        Me.Panel2.TabIndex = 6
        '
        'MENUGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 450)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.Cyan
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MENUGUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MENU"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HerramientasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtFecha As Label
    Friend WithEvents txtAdmi As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaDeMaterialesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CatalogoDeProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PromocionesYCombosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentaToolStripMenuItem As ToolStripMenuItem
End Class
