<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Venta
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtVentaID = New System.Windows.Forms.TextBox()
        Me.btnVentaNueva = New System.Windows.Forms.Button()
        Me.gpbBuscaProducto = New System.Windows.Forms.GroupBox()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.gpbDetalles = New System.Windows.Forms.GroupBox()
        Me.dgvVentaDetalles = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.mskTxtTotal = New System.Windows.Forms.MaskedTextBox()
        Me.txtTipoProd = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtNumProducto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombreProducto = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btntel = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnLocal = New System.Windows.Forms.Button()
        Me.btnParaLlevar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Fecha = New System.Windows.Forms.Timer(Me.components)
        Me.txtFecha = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.gpbBuscaProducto.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbDetalles.SuspendLayout()
        CType(Me.dgvVentaDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtFecha)
        Me.Panel1.Controls.Add(Me.txtVentaID)
        Me.Panel1.Controls.Add(Me.btnVentaNueva)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1284, 100)
        Me.Panel1.TabIndex = 1
        '
        'txtVentaID
        '
        Me.txtVentaID.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVentaID.Location = New System.Drawing.Point(444, 25)
        Me.txtVentaID.Multiline = True
        Me.txtVentaID.Name = "txtVentaID"
        Me.txtVentaID.Size = New System.Drawing.Size(317, 44)
        Me.txtVentaID.TabIndex = 1
        '
        'btnVentaNueva
        '
        Me.btnVentaNueva.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentaNueva.Location = New System.Drawing.Point(99, 25)
        Me.btnVentaNueva.Name = "btnVentaNueva"
        Me.btnVentaNueva.Size = New System.Drawing.Size(144, 44)
        Me.btnVentaNueva.TabIndex = 0
        Me.btnVentaNueva.Text = "Nueva Venta"
        Me.btnVentaNueva.UseVisualStyleBackColor = True
        '
        'gpbBuscaProducto
        '
        Me.gpbBuscaProducto.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.gpbBuscaProducto.Controls.Add(Me.dgvProductos)
        Me.gpbBuscaProducto.Controls.Add(Me.txtProducto)
        Me.gpbBuscaProducto.Controls.Add(Me.gpbDetalles)
        Me.gpbBuscaProducto.Controls.Add(Me.Panel2)
        Me.gpbBuscaProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpbBuscaProducto.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbBuscaProducto.Location = New System.Drawing.Point(0, 100)
        Me.gpbBuscaProducto.Name = "gpbBuscaProducto"
        Me.gpbBuscaProducto.Size = New System.Drawing.Size(1284, 611)
        Me.gpbBuscaProducto.TabIndex = 2
        Me.gpbBuscaProducto.TabStop = False
        Me.gpbBuscaProducto.Text = "Producto"
        '
        'dgvProductos
        '
        Me.dgvProductos.BackgroundColor = System.Drawing.Color.DeepSkyBlue
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Location = New System.Drawing.Point(6, 60)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.Size = New System.Drawing.Size(1076, 157)
        Me.dgvProductos.TabIndex = 3
        '
        'txtProducto
        '
        Me.txtProducto.Location = New System.Drawing.Point(7, 27)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(448, 27)
        Me.txtProducto.TabIndex = 2
        '
        'gpbDetalles
        '
        Me.gpbDetalles.Controls.Add(Me.dgvVentaDetalles)
        Me.gpbDetalles.Controls.Add(Me.Label5)
        Me.gpbDetalles.Controls.Add(Me.mskTxtTotal)
        Me.gpbDetalles.Controls.Add(Me.txtTipoProd)
        Me.gpbDetalles.Controls.Add(Me.Label4)
        Me.gpbDetalles.Controls.Add(Me.txtCantidad)
        Me.gpbDetalles.Controls.Add(Me.Label3)
        Me.gpbDetalles.Controls.Add(Me.txtPrecio)
        Me.gpbDetalles.Controls.Add(Me.txtNumProducto)
        Me.gpbDetalles.Controls.Add(Me.Label2)
        Me.gpbDetalles.Controls.Add(Me.Label1)
        Me.gpbDetalles.Controls.Add(Me.txtNombreProducto)
        Me.gpbDetalles.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gpbDetalles.Location = New System.Drawing.Point(3, 223)
        Me.gpbDetalles.Name = "gpbDetalles"
        Me.gpbDetalles.Size = New System.Drawing.Size(1085, 385)
        Me.gpbDetalles.TabIndex = 1
        Me.gpbDetalles.TabStop = False
        '
        'dgvVentaDetalles
        '
        Me.dgvVentaDetalles.BackgroundColor = System.Drawing.Color.DeepSkyBlue
        Me.dgvVentaDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentaDetalles.Location = New System.Drawing.Point(10, 81)
        Me.dgvVentaDetalles.Name = "dgvVentaDetalles"
        Me.dgvVentaDetalles.Size = New System.Drawing.Size(1069, 256)
        Me.dgvVentaDetalles.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(890, 351)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 25)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Total: $"
        '
        'mskTxtTotal
        '
        Me.mskTxtTotal.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskTxtTotal.Location = New System.Drawing.Point(967, 343)
        Me.mskTxtTotal.Name = "mskTxtTotal"
        Me.mskTxtTotal.Size = New System.Drawing.Size(100, 33)
        Me.mskTxtTotal.TabIndex = 11
        '
        'txtTipoProd
        '
        Me.txtTipoProd.Location = New System.Drawing.Point(812, 50)
        Me.txtTipoProd.Name = "txtTipoProd"
        Me.txtTipoProd.Size = New System.Drawing.Size(145, 27)
        Me.txtTipoProd.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(764, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Tipo:"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(605, 48)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(153, 27)
        Me.txtCantidad.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(527, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Cantidad:"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(372, 47)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(148, 27)
        Me.txtPrecio.TabIndex = 4
        '
        'txtNumProducto
        '
        Me.txtNumProducto.Location = New System.Drawing.Point(143, 46)
        Me.txtNumProducto.Name = "txtNumProducto"
        Me.txtNumProducto.Size = New System.Drawing.Size(164, 27)
        Me.txtNumProducto.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(313, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Precio:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Numero Producto:"
        '
        'txtNombreProducto
        '
        Me.txtNombreProducto.Location = New System.Drawing.Point(10, 17)
        Me.txtNombreProducto.Name = "txtNombreProducto"
        Me.txtNombreProducto.Size = New System.Drawing.Size(748, 27)
        Me.txtNombreProducto.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel2.Controls.Add(Me.btntel)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.btnLocal)
        Me.Panel2.Controls.Add(Me.btnParaLlevar)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1088, 23)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(193, 585)
        Me.Panel2.TabIndex = 0
        '
        'btntel
        '
        Me.btntel.BackColor = System.Drawing.Color.Transparent
        Me.btntel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btntel.Location = New System.Drawing.Point(6, 330)
        Me.btntel.Name = "btntel"
        Me.btntel.Size = New System.Drawing.Size(181, 57)
        Me.btntel.TabIndex = 14
        Me.btntel.Text = "Teléfono/Recoger en local"
        Me.btntel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btntel.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(6, 457)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(181, 57)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Entrega a Domicilio"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnLocal
        '
        Me.btnLocal.AutoSize = True
        Me.btnLocal.BackColor = System.Drawing.Color.Transparent
        Me.btnLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLocal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLocal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLocal.Location = New System.Drawing.Point(6, 200)
        Me.btnLocal.Name = "btnLocal"
        Me.btnLocal.Size = New System.Drawing.Size(181, 64)
        Me.btnLocal.TabIndex = 11
        Me.btnLocal.Text = "Consumo " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "En Local"
        Me.btnLocal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLocal.UseVisualStyleBackColor = False
        '
        'btnParaLlevar
        '
        Me.btnParaLlevar.AutoSize = True
        Me.btnParaLlevar.BackColor = System.Drawing.Color.Transparent
        Me.btnParaLlevar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnParaLlevar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnParaLlevar.Location = New System.Drawing.Point(6, 95)
        Me.btnParaLlevar.Name = "btnParaLlevar"
        Me.btnParaLlevar.Size = New System.Drawing.Size(181, 40)
        Me.btnParaLlevar.TabIndex = 10
        Me.btnParaLlevar.Text = "Para Llevar"
        Me.btnParaLlevar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnParaLlevar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Coral
        Me.Label6.Location = New System.Drawing.Point(18, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 30)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Tipo De Venta"
        '
        'Fecha
        '
        Me.Fecha.Enabled = True
        '
        'txtFecha
        '
        Me.txtFecha.AutoSize = True
        Me.txtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Location = New System.Drawing.Point(891, 9)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(0, 18)
        Me.txtFecha.TabIndex = 31
        '
        'Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(1284, 711)
        Me.Controls.Add(Me.gpbBuscaProducto)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Venta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Venta"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gpbBuscaProducto.ResumeLayout(False)
        Me.gpbBuscaProducto.PerformLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbDetalles.ResumeLayout(False)
        Me.gpbDetalles.PerformLayout()
        CType(Me.dgvVentaDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtVentaID As TextBox
    Friend WithEvents btnVentaNueva As Button
    Friend WithEvents gpbBuscaProducto As GroupBox
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents txtProducto As TextBox
    Friend WithEvents gpbDetalles As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombreProducto As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtNumProducto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents mskTxtTotal As MaskedTextBox
    Friend WithEvents txtTipoProd As TextBox
    Friend WithEvents dgvVentaDetalles As DataGridView
    Friend WithEvents btntel As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnLocal As Button
    Friend WithEvents btnParaLlevar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Fecha As Timer
    Friend WithEvents txtFecha As Label
End Class
