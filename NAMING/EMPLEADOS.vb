Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing.Printing
Public Class EMPLEADOS
    Dim foto As String
    Private Sub EMPLEADOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Config.Iniciarconexion()
        Dim Comm As New SqlCommand()
        Comm.Connection = connsql
        Comm.CommandText = "Select Id_categoria,Nombre_Cat,Salario from CATEGORIA Order by Nombre_Cat"
        Comm.CommandType = CommandType.Text
        Dim SqlAd As SqlDataAdapter = New SqlDataAdapter(Comm)
        Dim tblCATEGORIA As New DataTable()
        SqlAd.Fill(tblCATEGORIA)
        cmbCategoria.ValueMember = "Id_Categoria"
        cmbCategoria.DisplayMember = "Nombre_Cat"
        cmbCategoria.DataSource = tblCATEGORIA
    End Sub
    'ASIGNAR FOTOGRAFIA
    Private Sub BtnAgregarFoto_Click(sender As Object, e As EventArgs) Handles btnAgregarFoto.Click
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName.ToString().Trim() <> "" Then foto = OpenFileDialog1.FileName
        PictureBox1.Image = Image.FromFile(foto)
    End Sub
    'CODIGO PARA BUSCAR UN EMPLEADO EN NUESTRA BASE DE DATOS
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim Comm As New SqlCommand()
        Comm.Connection = connsql
        Comm.CommandText = "Select EMPLEADOS. * , Acceso. * , CATEGORIA. * from EMPLEADOS inner join Acceso " _
        & "on EMPLEADOS.Id_Usuario=Acceso.Id_Usuario inner join " _
        & "CATEGORIA on EMPLEADOS.Id_Categoria = CATEGORIA.Id_Categoria where EMPLEADOS.Id_Usuario=@Id_Usuario"
        Comm.CommandType = CommandType.Text
        Comm.Parameters.Add("@Id_Usuario", SqlDbType.NChar, 10).Value = txtId.Text.ToString()
        Dim DReader As SqlDataReader = Comm.ExecuteReader
        If (DReader.HasRows) Then
            While DReader.Read()
                txtId.Text = DReader("Id_Usuario")
                'cmbCategoria.SelectedValue = DReader("Id_Categoria")
                txtNom.Text = DReader("Nombre")
                txtAPA.Text = DReader("A_Paterno")
                txtAMa.Text = DReader("A_Materno")
                txtDir.Text = DReader("Direccion")
                txtTel.Text = DReader("Tel")
                txtEmail.Text = DReader("Email")
                txtNac.Value = DReader("F_Nac")
                txtRfc.Text = DReader("RFC")
                txtIngreso.Value = DReader("F_Ingreso")
                txtIdCat.Text = DReader("Id_Categoria")
                txtSalario.Text = DReader("Salario")
                txtLogin.Text = DReader("Login")
                txtPass.Text = DReader("Password")
                'If Not DReader.IsDBNull(DReader.GetOrdinal("Foto")) Then
                'PictureBox1.Image = Image.FromFile(DReader("Foto"))
                ''Else
                'PictureBox1.Image = Nothing
                'End If
            End While
        Else
            MessageBox.Show("No se encontro registro", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtId.Text = " "
        End If

        DReader.Close()

        'btnEliminarAcc.Enabled = True
        btnAgregarCategoria.Enabled = False
        'btnClear.Enabled = True
        'btnActualizarEmp.Enabled = True
        'btnActualizarCat.Enabled = True
        'btnActualizarLog.Enabled = True
        'txtId.ReadOnly = True
        txtIdCat.ReadOnly = True
    End Sub
    'CODIGO PARA AGREGAR UN EMPLEADO
    Private Sub btnAgregarEmpleado_Click(sender As Object, e As EventArgs) Handles btnAgregarEmpleado.Click
        Dim comm As New SqlCommand()
        comm.Connection = connsql
        comm.CommandText = "insert into EMPLEADOS(Id_Usuario,Nombre,A_Paterno,A_Materno,Direccion,Tel,Email,F_Nac,RFC,F_ingreso,Id_Categoria,Foto)" & "values(@Id_Usuario,@Nombre,@A_Paterno,@A_Materno,@Direccion,@Tel,@Email,@F_Nac,@RFC,@F_ingreso,@Id_Categoria,@Foto)"
        comm.CommandType = CommandType.Text
        comm.Parameters.Add("@Id_Usuario", SqlDbType.NChar, 10).Value = txtId.Text.ToString()
        comm.Parameters.Add("@Nombre", SqlDbType.NChar, 20).Value = txtNom.Text.ToString()
        comm.Parameters.Add("@A_Paterno", SqlDbType.NChar, 10).Value = txtAPA.Text.ToString()
        comm.Parameters.Add("@A_Materno", SqlDbType.NChar, 10).Value = txtAMa.Text.ToString()
        comm.Parameters.Add("@Direccion", SqlDbType.VarChar, 50).Value = txtDir.Text.ToString()
        comm.Parameters.Add("@Tel", SqlDbType.VarChar, 10).Value = txtTel.Text.ToString()
        comm.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = txtEmail.Text.ToString()
        comm.Parameters.Add("@F_Nac", SqlDbType.Date).Value = txtNac.Text.ToString()
        comm.Parameters.Add("@RFC", SqlDbType.NChar, 10).Value = txtRfc.Text.ToString()
        comm.Parameters.Add("@F_ingreso", SqlDbType.Date).Value = txtIngreso.Text.ToString()
        comm.Parameters.Add("@Id_Categoria", SqlDbType.NChar, 10).Value = txtIdCat.Text.ToString()
        comm.Parameters.Add("@Foto", SqlDbType.NVarChar, 50).Value = PictureBox1.Text.ToString()
        comm.ExecuteNonQuery()
        comm.Parameters.Clear()

        btnAgregarEmpleado.Enabled = False
        'btnAgregarLog.Enabled = True
        txtId.Text = ""
        txtNom.Text = ""
        txtAPA.Text = ""
        txtAMa.Text = ""
        txtDir.Text = ""
        txtTel.Text = ""
        txtEmail.Text = ""
        txtRfc.Text = ""
        txtIdCat.Text = ""
        txtSalario.Text = " "
        PictureBox1.Image = Nothing
        'txtId.ReadOnly = True
        txtIdCat.ReadOnly = False
    End Sub

    Private Sub btnCrearGafete_Click(sender As Object, e As EventArgs) Handles btnCrearGafete.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub
    'DIBUJAR EL GAFETE
    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawRectangle(Pens.Black, New Rectangle(10, 10, 400, 600))
        e.Graphics.DrawImage(PictureBox1.Image, 100, 30, 200, 170)
        Dim Fuente As Font = New Font("Arial", 14, FontStyle.Bold)
        e.Graphics.DrawString("Nombre: " & txtNom.Text.Trim() & " " & txtAPA.Text.Trim() & " " & txtAMa.Text.Trim(), Fuente, Brushes.Black, New PointF(25, 200))
        e.Graphics.DrawString("Categoria: " & cmbCategoria.Text(), Fuente, Brushes.Black, New Point(25, 230))
        e.Graphics.DrawString("Empleado: ", Fuente, Brushes.Black, New Point(25, 460))
        Fuente = New Font("ABC C39 Tall Text", 16, FontStyle.Regular)
        e.Graphics.DrawString("*" & txtId.Text.Trim() & "*", Fuente, Brushes.Black, New Point(150, 460))
        e.HasMorePages = False
    End Sub
    'REGISTRAR CATEGORIA
    Private Sub btnAgregarCategoria_Click(sender As Object, e As EventArgs) Handles btnAgregarCategoria.Click
        Dim Comm As New SqlCommand()
        Comm.Connection = connsql
        Comm.CommandText = "Insert Into Categoria (Id_Categoria,Nombre_Cat,Salario)" _
            & "values(@Id_Categoria,@Nombre_Cat,@Salario)"
        Comm.Parameters.Add("@Id_Categoria", SqlDbType.NChar, 10).Value = txtIdCategoria.Text.ToString()
        Comm.Parameters.Add("@Nombre_Cat", SqlDbType.NChar, 35).Value = txtNombreCategoria.Text.ToString()
        Comm.Parameters.Add("@Salario", SqlDbType.Decimal).Value = Double.Parse(txtSal.Text.ToString())

        Comm.ExecuteNonQuery()
        Comm.Parameters.Clear()

        'btnAgregarCategoria.Enabled = True
        txtIdCat.ReadOnly = True
        txtSal.Text = ""
        txtIdCategoria.Text = " "
        txtNombreCategoria.Text = " "
        'btnAgregarCategoria.Enabled = False
        Comm.Connection = connsql
        Comm.CommandText = "Select Id_categoria,Nombre_Cat from CATEGORIA Order by Nombre_Cat"
        Comm.CommandType = CommandType.Text
        Dim SqlAd As SqlDataAdapter = New SqlDataAdapter(Comm)
        Dim tblCATEGORIA As New DataTable()
        SqlAd.Fill(tblCATEGORIA)
        cmbCategoria.ValueMember = "Id_Categoria"
        cmbCategoria.DisplayMember = "Nombre_Cat"
        cmbCategoria.DataSource = tblCATEGORIA
    End Sub

    Private Sub cmbCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategoria.SelectedIndexChanged
        Dim Comm As SqlCommand = New SqlCommand()
        Comm.Connection = connsql
        Comm.CommandType = CommandType.Text
        Comm.CommandText = "Select Id_Categoria , Salario from CATEGORIA where Id_Categoria='" & cmbCategoria.SelectedValue.ToString() & "'"
        Dim SqlDR As SqlDataReader
        SqlDR = Comm.ExecuteReader()
        If SqlDR.Read() Then
            txtIdCat.Text = SqlDR("Id_Categoria").ToString()
            txtSalario.Text = SqlDR("Salario").ToString()
        End If
        SqlDR.Close()
        Comm.Dispose()
    End Sub

    Private Sub txtId_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtId.Validating
        If Me.txtId.Text.Length = 0 Then
            ErrorProvider1.SetError(Me.txtId, "Debe tener un valor")
        End If
    End Sub
    'AGREGAR USUARIO Y CONTRASEÑA
    Private Sub btnAgregarLog_Click(sender As Object, e As EventArgs) Handles btnAgregarLog.Click
        Dim Comm As New SqlCommand()
        Comm.Connection = connsql
        Comm.CommandText = "Insert Into Acceso (Id_Usuario,Login,Password)" _
            & "values(@Id_Usuario,@Login,@Password)"
        Comm.Parameters.Add("@Id_Usuario", SqlDbType.NChar, 10).Value = txtId.Text.ToString()
        Comm.Parameters.Add("@Login", SqlDbType.NChar, 25).Value = txtLogin.Text.ToString()
        Comm.Parameters.Add("@Password", SqlDbType.NChar, 35).Value = txtPass.Text.ToString()

        Comm.ExecuteNonQuery()
        Comm.Parameters.Clear()

        btnAgregarCategoria.Enabled = True
        btnAgregarLog.Enabled = False
        txtLogin.Text = ""
        txtPass.Text = ""
        txtId.Text = ""
        txtId.ReadOnly = False
    End Sub
    'ACTUALIZAR EMPLEADO
    Private Sub btnModificarEmpleado_Click(sender As Object, e As EventArgs) Handles btnModificarEmpleado.Click
        Dim Comm As New SqlCommand()
        Comm.Connection = connsql
        Comm.CommandText = "UpDate EMPLEADOS set Id_Usuario=@Id_Usuario, Nombre=@Nombre, A_Paterno=@A_Paterno,A_Materno=A_Materno,Direccion=@Direccion,Tel=@Tel,Email=@Email,F_Nac=@F_Nac,RFC=@RFC,F_Ingreso=@F_Ingreso,Id_Categoria=@Id_Categoria,Foto=@Foto where Empleados.Id_Usuario = @Id_Usuario"
        '_
        '   & "values(@Id_Usuario,@Nombre,@A_Paterno,@A_Materno,@Direccion,@Tel,@E_mail,@F_Nac,@Rfc,@F_Ingreso,@Id_Categoria,@Fotografia where Empleados.Id_Usuario = @Id_Usuario)"
        Comm.CommandType = CommandType.Text
        Comm.Parameters.Add("@Id_Usuario", SqlDbType.NChar, 10).Value = txtId.Text.ToString()
        Comm.Parameters.Add("@Nombre", SqlDbType.NChar, 20).Value = txtNom.Text.ToString()
        Comm.Parameters.Add("@A_Paterno", SqlDbType.NChar, 30).Value = txtAPA.Text.ToString()
        Comm.Parameters.Add("@A_Materno", SqlDbType.NChar, 30).Value = txtAMa.Text.ToString()
        Comm.Parameters.Add("@Direccion", SqlDbType.NChar, 50).Value = txtDir.Text.ToString()
        Comm.Parameters.Add("@Tel", SqlDbType.NChar, 12).Value = txtTel.Text.ToString()
        Comm.Parameters.Add("@EMail", SqlDbType.NVarChar, 50).Value = txtEmail.Text.ToString()
        Comm.Parameters.Add("@F_Nac", SqlDbType.Date).Value = txtNac.Text.ToString()
        Comm.Parameters.Add("@RFC", SqlDbType.NChar, 30).Value = txtRfc.Text.ToString()
        Comm.Parameters.Add("@F_Ingreso", SqlDbType.Date).Value = txtIngreso.Text.ToString()
        Comm.Parameters.Add("@Id_Categoria", SqlDbType.NChar, 8).Value = cmbCategoria.Text.ToString()
        If (btnAgregarFoto.Focus = True) Then
            Comm.Parameters.Add("@Foto", SqlDbType.NVarChar, 50).Value = OpenFileDialog1.FileName.ToString().Trim
        End If
        Comm.ExecuteNonQuery()
        Comm.Parameters.Clear()
    End Sub
    'BORRAR EMPLEADO CODIGO
    Private Sub btnBorrarEmpleado_Click(sender As Object, e As EventArgs) Handles btnBorrarEmpleado.Click
        Dim Comm As New SqlCommand()
        Comm.Connection = connsql
        Comm.CommandText = "Delete From EMPLEADOS, Acceso where EMPLEADOS.Id_Usuario=@Id_Usuario, Acceso.Id_Usuario=@Id_Usuario"
        MessageBox.Show("Empleado Eliminado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Comm.Parameters.Add("@Id_Usuario", SqlDbType.NChar, 10).Value = txtId.Text.ToString()
        Comm.ExecuteNonQuery()
        Comm.Parameters.Clear()
    End Sub

    Private Sub EMPLEADOS_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MENUGUI.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
