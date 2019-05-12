Imports System.Data
Imports System.Data.SqlClient
Public Class LISTADEMATERIALES
    Private Sub ListaDeMateriales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DbSql = New SqlConnection("Data Source=LAPTOP-FGA832IT;Initial Catalog=PIZZERIA;Integrated Security=True")
        DbSql.Open()
        Dim Comm As SqlCommand = New SqlCommand()
        Comm.Connection = DbSql
        Comm.CommandType = CommandType.Text
        Comm.CommandText = "Select Nombre,IdArticulo from ARTICULO Order by Nombre"
        Dim SqlDa As SqlDataAdapter = New SqlDataAdapter(Comm)
        Dim tblArticulos As DataTable = New DataTable()
        SqlDa.Fill(tblArticulos)
        CmbArticuloID.ValueMember = "IdArticulo"
        CmbArticuloID.DisplayMember = "Nombre"
        CmbArticuloID.DataSource = tblArticulos
        Comm.Dispose()
    End Sub
    Public DbSql As SqlConnection
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtNombre.Text = "" Then
            MsgBox("Falta Rellenar")
        Else
            Dim Comm As SqlCommand = New SqlCommand()
            Comm.Connection = DbSql
            Comm.CommandType = CommandType.Text
            Comm.CommandText = "Insert into LISTAMATERIALES(NumProducto,IdArticulo,UnidadMedida,Cantidad) " _
              & "Values(@NumProducto,@IdArticulo,@UnidadMedida,@Cantidad) "
            Comm.Parameters.Add("@NumProducto", SqlDbType.NVarChar, 15).Value = txtNumProducto.Text.ToString()
            Comm.Parameters.Add("@IdArticulo", SqlDbType.NVarChar, 15).Value = CmbArticuloID.SelectedValue.ToString()
            Comm.Parameters.Add("@UnidadMedida", SqlDbType.NVarChar, 15).Value = txtUnidadMedida.Text.ToString()
            Comm.Parameters.Add("@Cantidad", SqlDbType.NVarChar, 15).Value = Decimal.Parse(txtCantidad.Text.ToString())
            Comm.ExecuteNonQuery()

            txtCantidad.Text = 0
            ActualizaLista()
        End If
    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        Dim Comm As SqlCommand = New SqlCommand()
        Comm.Connection = DbSql
        Comm.CommandText = CommandType.Text
        Comm.CommandType = "Update LISTAMATERIALES set Cantidad= @Cantidad where NumProducto=@NumProducto and " _
           & "IdArticulo=@IdArticulo "
        Comm.Parameters.Add("@NumProducto", SqlDbType.NVarChar, 15).Value = txtNumProducto.Text.ToString()
        Comm.Parameters.Add("@IdArticulo", SqlDbType.NVarChar, 15).Value = CmbArticuloID.SelectedValue.ToString()
        Comm.Parameters.Add("@Cantidad", SqlDbType.NVarChar, 15).Value = Decimal.Parse(txtCantidad.Text.ToString())
        Comm.ExecuteNonQuery()
        txtCantidad.Text = 0
        ActualizaLista()
    End Sub
    Public Function ManejodeListadeMateriales(ByVal vProducto As String, ByVal vNombre As String) As DialogResult
        txtNumProducto.Text = vProducto
        txtNombre.Text = vNombre
        Me.Show()
        'frmProductosVenta.ActualizaListaMateriales()
        Return btnExit.DialogResult
    End Function
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim Comm As SqlCommand = New SqlCommand()
        Comm.Connection = DbSql
        Comm.CommandType = CommandType.Text
        Comm.CommandText = "Delete from  LISTAMATERIALES where NumProducto=@NumProducto and " _
           & "IdArticulo=@IdArticulo "
        Comm.Parameters.Add("@NumProducto", SqlDbType.NVarChar, 15).Value = txtNumProducto.Text.ToString()
        Comm.Parameters.Add("@IdArticulo", SqlDbType.NVarChar, 15).Value = CmbArticuloID.SelectedValue.ToString()
        Comm.Parameters.Add("@Cantidad", SqlDbType.NVarChar, 15).Value = Decimal.Parse(txtCantidad.Text.ToString())
        Comm.ExecuteNonQuery()

        txtCantidad.Text = 0
        ActualizaLista()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        btnExit.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub ListaDeMateriales_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        DbSql.Close()
    End Sub
    Private Sub CmbArticuloID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbArticuloID.SelectedIndexChanged
        txtNombreArt.Text = CmbArticuloID.SelectedValue.ToString()
        Dim Comm As SqlCommand = New SqlCommand()
        Comm.Connection = DbSql
        Comm.CommandType = CommandType.Text
        Comm.CommandText = "Select UnidadMedida from ARTICULO where IdArticulo='" & CmbArticuloID.SelectedValue.ToString() & "'"
        Dim SqlDR As SqlDataReader
        SqlDR = Comm.ExecuteReader()
        If SqlDR.Read() Then
            txtUnidadMedida.Text = SqlDR("UnidadMedida").ToString()
        End If
        SqlDR.Close()
        Comm.Dispose()

    End Sub
    Private Sub ActualizaLista()
        Dim Comm As SqlCommand
        Comm = New SqlCommand()
        Comm.Connection = DbSql
        Comm.CommandType = CommandType.Text
        Comm.CommandText = "Select * from LISTAMATERIALES where NumProducto='" & txtNumProducto.Text.ToString _
           & "' Order by IdArticulo"
        Dim SqlDA As SqlDataAdapter = New SqlDataAdapter(Comm)
        Dim tblArticulos As DataTable = New DataTable()
        SqlDA.Fill(tblArticulos)
        DgvLista.DataSource = tblArticulos
    End Sub

End Class