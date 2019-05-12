Imports System.Data
Imports System.Data.SqlClient
Public Class FormProductosVenta
    Public DbSql As SqlConnection
    'CERRAR FORM
    Private Sub frmProductosVenta_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        DbSql.Close()
    End Sub
    'CARGAR FORM
    Private Sub frmProductosVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DbSql = New SqlConnection("Data Source=LAPTOP-FGA832IT;Initial Catalog=PIZZERIA;Integrated Security=True")
        DbSql.Open()

    End Sub
    'BTN EXIT
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    'BTN ABRIR FORM MATERIALES 
    Private Sub btnMateriales_Click(sender As Object, e As EventArgs) Handles btnMateriales.Click
        If txtNumProducto.Text.ToString().Trim() = "" Then
            MessageBox.Show("PRIMERO INTRODUZCA EL NUMERO DE PRODUCTO", "PIZZAS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        LISTADEMATERIALES.ManejodeListadeMateriales(txtNumProducto.Text.ToString(), txtNombre.Text.ToString())
        ActualizaListaMateriales()

    End Sub
    'BTN AGREGAR PRODUCTOS
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim Comm As SqlCommand = New SqlCommand()
        Comm.Connection = DbSql
        Comm.CommandType = CommandType.StoredProcedure
        Comm.CommandText = "INS_PRODUCTOS"
        Comm.Parameters.Add("@NumProducto", SqlDbType.NVarChar, 15).Value = txtNumProducto.Text.ToString()
        Comm.Parameters.Add("@Nombre", SqlDbType.NVarChar, 150).Value = txtNombre.Text.ToString()
        Comm.Parameters.Add("@Costo", SqlDbType.Decimal).Value = Double.Parse(txtCosto.Text.ToString())
        Comm.Parameters.Add("@Precio", SqlDbType.Decimal).Value = Double.Parse(txtPrecio.Text.ToString())
        Comm.ExecuteNonQuery()
        LimpiaPantalla()

    End Sub
    'FUNCION PARA LIMPIAR CELDAS
    Private Sub LimpiaPantalla()
        txtNumProducto.Text = ""
        txtNombre.Text = ""
        txtCosto.Text = ""
        txtPrecio.Text = ""
    End Sub
    'ACTUALIZAMOS MATERIALES EN DBMS
    Public Sub ActualizaListaMateriales()
        Dim Comm As SqlCommand
        Comm = New SqlCommand()
        Comm.Connection = DbSql
        Comm.CommandType = CommandType.Text
        Comm.CommandText = "Select * from LISTAMATERIALES where NumProducto='" & txtNumProducto.Text.ToString _
       & "' Order by idArticulo"
        Dim SqlDA As SqlDataAdapter = New SqlDataAdapter(Comm)
        Dim tblArticulos As DataTable = New DataTable()
        SqlDA.Fill(tblArticulos)
        dgvArticulos.DataSource = tblArticulos
    End Sub
    'BTN MODIFICAR
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim Comm As SqlCommand = New SqlCommand()
        Comm.Connection = DbSql
        Comm.CommandType = CommandType.StoredProcedure
        Comm.CommandText = "MODIFICAR_PRODUCTOS"
        Comm.Parameters.Add("@NumProducto", SqlDbType.NVarChar, 15).Value = txtNumProducto.Text.ToString()
        Comm.Parameters.Add("@Nombre", SqlDbType.NVarChar, 150).Value = txtNombre.Text.ToString()
        Comm.Parameters.Add("@Costo", SqlDbType.Decimal).Value = Double.Parse(txtCosto.Text.ToString())
        Comm.Parameters.Add("@Precio", SqlDbType.Decimal).Value = Double.Parse(txtPrecio.Text.ToString())
        Comm.ExecuteNonQuery()
        LimpiaPantalla()

    End Sub
    'BTN ELIMINAR
    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Dim Comm As SqlCommand = New SqlCommand()

        Comm.Connection = DbSql
        Comm.CommandType = CommandType.StoredProcedure
        Comm.CommandText = "BORRAR_PRODUCTOS"
        Comm.Parameters.Add("@NumProducto", SqlDbType.NVarChar, 15).Value = txtNumProducto.Text.ToString()

        Comm.ExecuteNonQuery()
        LimpiaPantalla()

    End Sub
    'BTN BUSCAR
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim Comm As SqlCommand = New SqlCommand()
        Comm.Connection = DbSql
        Comm.CommandType = CommandType.Text
        Comm.CommandText = "Select * from Productos where @NumProducto=@NumProducto"
        Comm.Parameters.Add("@NumProducto", SqlDbType.NVarChar, 15).Value = txtNumProducto.Text.ToString()
        Dim Dr As SqlDataReader
        Dr = Comm.ExecuteReader()
        If Dr.Read() Then
            txtNombre.Text = Dr("Nombre").ToString()
            txtCosto.Text = Dr("Costo").ToString()
            txtPrecio.Text = Dr("Precio").ToString()
        Else
            MessageBox.Show("Regitro No Encontrado", "Pizzas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            LimpiaPantalla()
        End If
        Dr.Close()
        ActualizaListaMateriales()

    End Sub
    'BTN PARA OBTENER PRECIOS
    Private Sub btnObtenerCosto_Click(sender As Object, e As EventArgs) Handles btnObtenerCosto.Click
        Dim Comm As SqlCommand = New SqlCommand()
        Comm.Connection = DbSql
        Comm.CommandType = CommandType.Text
        'Comm.CommandText = "Select dbo.fn_CostoProducto(@NumProducto) as Costo"
        Comm.CommandText = "Select * from Productos where @NumProducto=@NumProducto"
        Comm.Parameters.Add("@NumProducto", SqlDbType.NVarChar, 15).Value = txtNumProducto.Text.ToString()
        Dim Dr As SqlDataReader
        Dr = Comm.ExecuteReader
        If Dr.Read() Then
            txtNombre.Text = Dr("Nombre").ToString
            txtCosto.Text = Dr("Costo").ToString()
        End If
        Dr.Close()
    End Sub
    'FUNCION PARA BUSCAR PRODUCTOS DBMS
    Private Sub BuscarProductos()
        Dim Comm As SqlCommand
        Comm = New SqlCommand()
        Comm.Connection = DbSql
        Comm.CommandText = "select * from Productos where nombre like @nombre"
        Comm.Parameters.Add("@nombre", SqlDbType.VarChar, 150).Value = txtNumProducto.Text.ToString() & "%"
        Dim Da As SqlDataAdapter = New SqlDataAdapter(Comm)
        Dim tblProductos As DataTable = New DataTable()
        Da.Fill(tblProductos)
        dgvArticulos.DataSource = tblProductos
        Da.Dispose()
        Comm.Dispose()
    End Sub
End Class