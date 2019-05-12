<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EMPLEADOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EMPLEADOS))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBorrarEmpleado = New System.Windows.Forms.Button()
        Me.btnCrearGafete = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnAgregarFoto = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtSalario = New System.Windows.Forms.TextBox()
        Me.txtIdCat = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbCategoria = New System.Windows.Forms.ComboBox()
        Me.txtNac = New System.Windows.Forms.DateTimePicker()
        Me.txtIngreso = New System.Windows.Forms.DateTimePicker()
        Me.btnModificarEmpleado = New System.Windows.Forms.Button()
        Me.btnAgregarEmpleado = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtDir = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtRfc = New System.Windows.Forms.TextBox()
        Me.txtAMa = New System.Windows.Forms.TextBox()
        Me.txtAPA = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PanelCategorias = New System.Windows.Forms.Panel()
        Me.btnAgregarLog = New System.Windows.Forms.Button()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.texto = New System.Windows.Forms.Label()
        Me.btnAgregarCategoria = New System.Windows.Forms.Button()
        Me.txtIdCategoria = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtSal = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtNombreCategoria = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCategorias.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "APELLIDO PATERNO:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(52, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "NOMBRE:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(52, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "APELLIDO MATERNO:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(52, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "DIRECCION:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(52, 274)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "TELEFONO:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(52, 318)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "EMAIL:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(52, 362)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(183, 18)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "FECHA DE NACIMIENTO:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.btnBorrarEmpleado)
        Me.Panel1.Controls.Add(Me.btnCrearGafete)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.btnAgregarFoto)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.txtSalario)
        Me.Panel1.Controls.Add(Me.txtIdCat)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.cmbCategoria)
        Me.Panel1.Controls.Add(Me.txtNac)
        Me.Panel1.Controls.Add(Me.txtIngreso)
        Me.Panel1.Controls.Add(Me.btnModificarEmpleado)
        Me.Panel1.Controls.Add(Me.btnAgregarEmpleado)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnBuscar)
        Me.Panel1.Controls.Add(Me.txtDir)
        Me.Panel1.Controls.Add(Me.txtTel)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.txtRfc)
        Me.Panel1.Controls.Add(Me.txtAMa)
        Me.Panel1.Controls.Add(Me.txtAPA)
        Me.Panel1.Controls.Add(Me.txtNom)
        Me.Panel1.Controls.Add(Me.txtId)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(990, 711)
        Me.Panel1.TabIndex = 8
        '
        'btnBorrarEmpleado
        '
        Me.btnBorrarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBorrarEmpleado.Location = New System.Drawing.Point(336, 644)
        Me.btnBorrarEmpleado.Name = "btnBorrarEmpleado"
        Me.btnBorrarEmpleado.Size = New System.Drawing.Size(89, 55)
        Me.btnBorrarEmpleado.TabIndex = 35
        Me.btnBorrarEmpleado.Text = "BORRAR EMPLEADO"
        Me.btnBorrarEmpleado.UseVisualStyleBackColor = True
        '
        'btnCrearGafete
        '
        Me.btnCrearGafete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCrearGafete.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearGafete.Location = New System.Drawing.Point(485, 427)
        Me.btnCrearGafete.Name = "btnCrearGafete"
        Me.btnCrearGafete.Size = New System.Drawing.Size(327, 29)
        Me.btnCrearGafete.TabIndex = 34
        Me.btnCrearGafete.Text = "CREAR GAFETE"
        Me.btnCrearGafete.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(209, 15)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(274, 25)
        Me.Label18.TabIndex = 33
        Me.Label18.Text = "REGISTRAR EMPLEADO"
        '
        'btnAgregarFoto
        '
        Me.btnAgregarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAgregarFoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarFoto.Location = New System.Drawing.Point(485, 368)
        Me.btnAgregarFoto.Name = "btnAgregarFoto"
        Me.btnAgregarFoto.Size = New System.Drawing.Size(327, 35)
        Me.btnAgregarFoto.TabIndex = 32
        Me.btnAgregarFoto.Text = "AGREGAR FOTO"
        Me.btnAgregarFoto.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(52, 582)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 18)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "SALARIO:"
        '
        'txtSalario
        '
        Me.txtSalario.Location = New System.Drawing.Point(54, 603)
        Me.txtSalario.Name = "txtSalario"
        Me.txtSalario.Size = New System.Drawing.Size(247, 20)
        Me.txtSalario.TabIndex = 30
        '
        'txtIdCat
        '
        Me.txtIdCat.Location = New System.Drawing.Point(55, 559)
        Me.txtIdCat.Name = "txtIdCat"
        Me.txtIdCat.Size = New System.Drawing.Size(247, 20)
        Me.txtIdCat.TabIndex = 29
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(52, 493)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 18)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "CATEGORIA:"
        '
        'cmbCategoria
        '
        Me.cmbCategoria.FormattingEnabled = True
        Me.cmbCategoria.Location = New System.Drawing.Point(55, 514)
        Me.cmbCategoria.Name = "cmbCategoria"
        Me.cmbCategoria.Size = New System.Drawing.Size(246, 21)
        Me.cmbCategoria.TabIndex = 27
        '
        'txtNac
        '
        Me.txtNac.Location = New System.Drawing.Point(55, 383)
        Me.txtNac.Name = "txtNac"
        Me.txtNac.Size = New System.Drawing.Size(247, 20)
        Me.txtNac.TabIndex = 26
        '
        'txtIngreso
        '
        Me.txtIngreso.Location = New System.Drawing.Point(55, 470)
        Me.txtIngreso.Name = "txtIngreso"
        Me.txtIngreso.Size = New System.Drawing.Size(247, 20)
        Me.txtIngreso.TabIndex = 25
        '
        'btnModificarEmpleado
        '
        Me.btnModificarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModificarEmpleado.Location = New System.Drawing.Point(210, 644)
        Me.btnModificarEmpleado.Name = "btnModificarEmpleado"
        Me.btnModificarEmpleado.Size = New System.Drawing.Size(92, 55)
        Me.btnModificarEmpleado.TabIndex = 24
        Me.btnModificarEmpleado.Text = "MODIFICAR EMPLEADO"
        Me.btnModificarEmpleado.UseVisualStyleBackColor = True
        '
        'btnAgregarEmpleado
        '
        Me.btnAgregarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAgregarEmpleado.Location = New System.Drawing.Point(79, 644)
        Me.btnAgregarEmpleado.Name = "btnAgregarEmpleado"
        Me.btnAgregarEmpleado.Size = New System.Drawing.Size(91, 55)
        Me.btnAgregarEmpleado.TabIndex = 23
        Me.btnAgregarEmpleado.Text = "AGREGAR EMPLEADO"
        Me.btnAgregarEmpleado.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(485, 54)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(327, 307)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'btnBuscar
        '
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(336, 75)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(114, 68)
        Me.btnBuscar.TabIndex = 21
        Me.btnBuscar.Text = "BUSCAR EMPLEADO"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtDir
        '
        Me.txtDir.Location = New System.Drawing.Point(55, 251)
        Me.txtDir.Name = "txtDir"
        Me.txtDir.Size = New System.Drawing.Size(247, 20)
        Me.txtDir.TabIndex = 20
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(55, 295)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(247, 20)
        Me.txtTel.TabIndex = 19
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(55, 339)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(247, 20)
        Me.txtEmail.TabIndex = 18
        '
        'txtRfc
        '
        Me.txtRfc.Location = New System.Drawing.Point(55, 427)
        Me.txtRfc.Name = "txtRfc"
        Me.txtRfc.Size = New System.Drawing.Size(247, 20)
        Me.txtRfc.TabIndex = 16
        '
        'txtAMa
        '
        Me.txtAMa.Location = New System.Drawing.Point(55, 207)
        Me.txtAMa.Name = "txtAMa"
        Me.txtAMa.Size = New System.Drawing.Size(247, 20)
        Me.txtAMa.TabIndex = 13
        '
        'txtAPA
        '
        Me.txtAPA.Location = New System.Drawing.Point(55, 163)
        Me.txtAPA.Name = "txtAPA"
        Me.txtAPA.Size = New System.Drawing.Size(247, 20)
        Me.txtAPA.TabIndex = 12
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(55, 119)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(247, 20)
        Me.txtNom.TabIndex = 11
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(55, 75)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(247, 20)
        Me.txtId.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(52, 538)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 18)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "ID CATEGORIA:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(52, 450)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(160, 18)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "FECHA DE INGRESO:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(52, 406)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 18)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "RFC:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PanelCategorias
        '
        Me.PanelCategorias.BackColor = System.Drawing.Color.SteelBlue
        Me.PanelCategorias.Controls.Add(Me.btnAgregarLog)
        Me.PanelCategorias.Controls.Add(Me.txtPass)
        Me.PanelCategorias.Controls.Add(Me.txtLogin)
        Me.PanelCategorias.Controls.Add(Me.Label21)
        Me.PanelCategorias.Controls.Add(Me.Label20)
        Me.PanelCategorias.Controls.Add(Me.texto)
        Me.PanelCategorias.Controls.Add(Me.btnAgregarCategoria)
        Me.PanelCategorias.Controls.Add(Me.txtIdCategoria)
        Me.PanelCategorias.Controls.Add(Me.Label17)
        Me.PanelCategorias.Controls.Add(Me.txtSal)
        Me.PanelCategorias.Controls.Add(Me.Label16)
        Me.PanelCategorias.Controls.Add(Me.Label15)
        Me.PanelCategorias.Controls.Add(Me.txtNombreCategoria)
        Me.PanelCategorias.Controls.Add(Me.Label14)
        Me.PanelCategorias.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelCategorias.Location = New System.Drawing.Point(812, 0)
        Me.PanelCategorias.Name = "PanelCategorias"
        Me.PanelCategorias.Size = New System.Drawing.Size(372, 711)
        Me.PanelCategorias.TabIndex = 33
        '
        'btnAgregarLog
        '
        Me.btnAgregarLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAgregarLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarLog.Location = New System.Drawing.Point(163, 533)
        Me.btnAgregarLog.Name = "btnAgregarLog"
        Me.btnAgregarLog.Size = New System.Drawing.Size(75, 46)
        Me.btnAgregarLog.TabIndex = 13
        Me.btnAgregarLog.Text = "CREAR LOGIN"
        Me.btnAgregarLog.UseVisualStyleBackColor = True
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(76, 494)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(235, 20)
        Me.txtPass.TabIndex = 12
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(76, 418)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(235, 20)
        Me.txtLogin.TabIndex = 11
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(73, 459)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(205, 18)
        Me.Label21.TabIndex = 10
        Me.Label21.Text = "CONTRASEÑA USUARIO:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(73, 385)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(165, 18)
        Me.Label20.TabIndex = 9
        Me.Label20.Text = "NOMBRE USUARIO:"
        '
        'texto
        '
        Me.texto.AutoSize = True
        Me.texto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto.Location = New System.Drawing.Point(110, 356)
        Me.texto.Name = "texto"
        Me.texto.Size = New System.Drawing.Size(222, 24)
        Me.texto.TabIndex = 8
        Me.texto.Text = "REGISTRAR USUARIO"
        '
        'btnAgregarCategoria
        '
        Me.btnAgregarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAgregarCategoria.Location = New System.Drawing.Point(140, 252)
        Me.btnAgregarCategoria.Name = "btnAgregarCategoria"
        Me.btnAgregarCategoria.Size = New System.Drawing.Size(98, 40)
        Me.btnAgregarCategoria.TabIndex = 7
        Me.btnAgregarCategoria.Text = "AGREGAR"
        Me.btnAgregarCategoria.UseVisualStyleBackColor = True
        '
        'txtIdCategoria
        '
        Me.txtIdCategoria.Location = New System.Drawing.Point(76, 89)
        Me.txtIdCategoria.Name = "txtIdCategoria"
        Me.txtIdCategoria.Size = New System.Drawing.Size(200, 20)
        Me.txtIdCategoria.TabIndex = 6
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(73, 63)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(129, 18)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "ID CATEGORIA:"
        '
        'txtSal
        '
        Me.txtSal.Location = New System.Drawing.Point(76, 217)
        Me.txtSal.Name = "txtSal"
        Me.txtSal.Size = New System.Drawing.Size(200, 20)
        Me.txtSal.TabIndex = 4
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(73, 187)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(82, 18)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "SALARIO:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(73, 123)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(186, 18)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "NOMBRE CATEGORIA:"
        '
        'txtNombreCategoria
        '
        Me.txtNombreCategoria.Location = New System.Drawing.Point(76, 154)
        Me.txtNombreCategoria.Name = "txtNombreCategoria"
        Me.txtNombreCategoria.Size = New System.Drawing.Size(200, 20)
        Me.txtNombreCategoria.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(98, 20)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(251, 24)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "REGISTRAR CATEGORIA"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'EMPLEADOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1184, 711)
        Me.Controls.Add(Me.PanelCategorias)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "EMPLEADOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EMPLEADOS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCategorias.ResumeLayout(False)
        Me.PanelCategorias.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtDir As TextBox
    Friend WithEvents txtTel As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtRfc As TextBox
    Friend WithEvents txtAMa As TextBox
    Friend WithEvents txtAPA As TextBox
    Friend WithEvents txtNom As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnModificarEmpleado As Button
    Friend WithEvents btnAgregarEmpleado As Button
    Friend WithEvents txtIngreso As DateTimePicker
    Friend WithEvents txtNac As DateTimePicker
    Friend WithEvents cmbCategoria As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtSalario As TextBox
    Friend WithEvents txtIdCat As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btnAgregarFoto As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PanelCategorias As Panel
    Friend WithEvents txtIdCategoria As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtSal As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtNombreCategoria As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btnAgregarCategoria As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtLogin As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents texto As Label
    Friend WithEvents btnCrearGafete As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents btnAgregarLog As Button
    Friend WithEvents btnBorrarEmpleado As Button
End Class
