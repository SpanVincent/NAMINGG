<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compra
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCompraID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtCompra = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dvgListaMostrar = New System.Windows.Forms.DataGridView()
        Me.dgvCompra = New System.Windows.Forms.DataGridView()
        Me.btnVenta = New System.Windows.Forms.Button()
        Me.mskTxtTotal = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.Label()
        Me.Fecha_Hora = New System.Windows.Forms.Timer(Me.components)
        CType(Me.dvgListaMostrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(709, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 25)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Orden"
        '
        'txtCompraID
        '
        Me.txtCompraID.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompraID.Location = New System.Drawing.Point(709, 33)
        Me.txtCompraID.Name = "txtCompraID"
        Me.txtCompraID.Size = New System.Drawing.Size(239, 33)
        Me.txtCompraID.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(591, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 25)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Cantidad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 25)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Nombre Del Producto"
        '
        'txtCantidad
        '
        Me.txtCantidad.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(591, 34)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 33)
        Me.txtCantidad.TabIndex = 20
        '
        'txtCompra
        '
        Me.txtCompra.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompra.Location = New System.Drawing.Point(47, 34)
        Me.txtCompra.Name = "txtCompra"
        Me.txtCompra.Size = New System.Drawing.Size(523, 33)
        Me.txtCompra.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(44, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 25)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Venta"
        '
        'dvgListaMostrar
        '
        Me.dvgListaMostrar.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dvgListaMostrar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dvgListaMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgListaMostrar.Location = New System.Drawing.Point(47, 73)
        Me.dvgListaMostrar.Name = "dvgListaMostrar"
        Me.dvgListaMostrar.Size = New System.Drawing.Size(982, 150)
        Me.dvgListaMostrar.TabIndex = 26
        '
        'dgvCompra
        '
        Me.dgvCompra.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvCompra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical
        Me.dgvCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCompra.Location = New System.Drawing.Point(47, 251)
        Me.dgvCompra.Name = "dgvCompra"
        Me.dgvCompra.Size = New System.Drawing.Size(982, 421)
        Me.dgvCompra.TabIndex = 25
        '
        'btnVenta
        '
        Me.btnVenta.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVenta.Location = New System.Drawing.Point(1054, 623)
        Me.btnVenta.Name = "btnVenta"
        Me.btnVenta.Size = New System.Drawing.Size(231, 52)
        Me.btnVenta.TabIndex = 28
        Me.btnVenta.Text = "Compra"
        Me.btnVenta.UseVisualStyleBackColor = False
        '
        'mskTxtTotal
        '
        Me.mskTxtTotal.BackColor = System.Drawing.SystemColors.Window
        Me.mskTxtTotal.CausesValidation = False
        Me.mskTxtTotal.Enabled = False
        Me.mskTxtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskTxtTotal.ForeColor = System.Drawing.SystemColors.MenuText
        Me.mskTxtTotal.Location = New System.Drawing.Point(1041, 542)
        Me.mskTxtTotal.Multiline = True
        Me.mskTxtTotal.Name = "mskTxtTotal"
        Me.mskTxtTotal.Size = New System.Drawing.Size(231, 75)
        Me.mskTxtTotal.TabIndex = 29
        Me.mskTxtTotal.TabStop = False
        Me.mskTxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFecha
        '
        Me.txtFecha.AutoSize = True
        Me.txtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Location = New System.Drawing.Point(1038, 14)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(0, 18)
        Me.txtFecha.TabIndex = 30
        '
        'Fecha_Hora
        '
        Me.Fecha_Hora.Enabled = True
        '
        'Compra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1284, 711)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.btnVenta)
        Me.Controls.Add(Me.mskTxtTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dvgListaMostrar)
        Me.Controls.Add(Me.dgvCompra)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCompraID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtCompra)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Compra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compra"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dvgListaMostrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents txtCompraID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtCompra As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dvgListaMostrar As DataGridView
    Friend WithEvents dgvCompra As DataGridView
    Friend WithEvents btnVenta As Button
    Friend WithEvents mskTxtTotal As TextBox
    Friend WithEvents txtFecha As Label
    Friend WithEvents Fecha_Hora As Timer
End Class
