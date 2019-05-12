Imports System.Data
Imports System.Data.SqlClient
Public Class Venta
    Public DbSql As SqlConnection
    Public TblDetalleVenta As DataTable
    Public vTotalVenta As Double
    Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DbSql = New SqlConnection("Data Source=LAPTOP-FGA832IT;Initial Catalog=PIZZERIA;Integrated Security=True")
        DbSql.Open()
        GeneraTabladeVenta()
    End Sub
    Private Sub frmVentas_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        DbSql.Close()
    End Sub
    Private Sub BuscarProductos()
        Dim Comm As SqlCommand
        Comm = New SqlCommand()
        Comm.Connection = DbSql
        Comm.CommandText = "select * from ARTICULO where nombre like @nombre"
        Comm.Parameters.Add("@nombre", SqlDbType.VarChar, 150).Value = txtProducto.Text.ToString() & "%"
        Dim Da As SqlDataAdapter = New SqlDataAdapter(Comm)
        Dim tblProductos As DataTable = New DataTable()
        Da.Fill(tblProductos)
        dgvProductos.DataSource = tblProductos
        Da.Dispose()
        Comm.Dispose()
    End Sub

    Private Sub txtProducto_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtProducto.KeyUp
        If txtProducto.Text.ToString().Trim() <> "" Then BuscarProductos()
    End Sub

    Private Sub dgvProductos_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvProductos.DoubleClick
        txtNumProducto.Text = dgvProductos.SelectedRows(0).Cells("IdArticulo").Value.ToString()
        txtNombreProducto.Text = dgvProductos.SelectedRows(0).Cells("nombre").Value.ToString()
        txtPrecio.Text = dgvProductos.SelectedRows(0).Cells("PrecioVenta").Value.ToString()
        txtTipoProd.Text = dgvProductos.SelectedRows(0).Cells("TipoProd").Value.ToString()
        txtProducto.Text = ""
        txtCantidad.Focus()
    End Sub

    Private Sub txtCantidad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Dim vRes As Integer
            If Integer.TryParse(txtCantidad.Text.ToString(), vRes) = True Then
                If txtNumProducto.Text.ToString().Trim() <> "" Then
                    AgregaNuevoRenglon()
                End If
                txtProducto.Focus()
            End If
        End If
    End Sub
    Private Sub btnVentaNueva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVentaNueva.Click
        gpbBuscaProducto.Enabled = True
        gpbDetalles.Enabled = True
        VentaNueva()
    End Sub

    Private Sub AgregaNuevoRenglon()
        Dim MyDataRow As DataRow
        MyDataRow = TblDetalleVenta.NewRow()
        MyDataRow("NumProducto") = txtNumProducto.Text.ToString()
        MyDataRow("Descripcion") = txtNombreProducto.Text.ToString()
        MyDataRow("Cantidad") = Double.Parse(txtCantidad.Text.ToString())
        MyDataRow("Precio") = Double.Parse(txtPrecio.Text.ToString())
        MyDataRow("TipoProducto") = txtTipoProd.Text.ToString()

        Dim vSubtotal As Double = Double.Parse(txtCantidad.Text.ToString()) * Double.Parse(txtPrecio.Text.ToString())
        MyDataRow("Total") = vSubtotal
        vTotalVenta = vTotalVenta + vSubtotal

        TblDetalleVenta.Rows.Add(MyDataRow)
        TblDetalleVenta.AcceptChanges()

        mskTxtTotal.Text = vTotalVenta
        dgvVentaDetalles.DataSource = TblDetalleVenta.DefaultView
        dgvVentaDetalles.Columns(5).Visible = False

    End Sub
    Private Sub VentaNueva()
        vTotalVenta = 0
        TblDetalleVenta.Clear()

        txtVentaID.Text = GetVentaId()
        txtProducto.Text = ""
        dgvProductos.DataSource = Nothing
        dgvVentaDetalles.DataSource = Nothing

        txtNombreProducto.Text = ""
        txtNumProducto.Text = ""
        txtPrecio.Text = ""
        txtCantidad.Text = ""
        mskTxtTotal.Text = "0"

        txtProducto.Focus()
    End Sub
    Private Function GetVentaId() As String
        Dim vVentaID As String = ""
        Dim Comm As SqlCommand = New SqlCommand()
        Comm.Connection = DbSql
        Comm.CommandType = CommandType.Text
        Comm.CommandText = "Select dbo.fn_ObtenerVentaID() as VentaID"
        Dim Dr As SqlDataReader
        Dr = Comm.ExecuteReader
        If Dr.Read() Then
            vVentaID = Dr("VentaID").ToString()
        End If
        Dr.Close()
        Return vVentaID
    End Function

    Private Sub txtProducto_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProducto.Enter
        txtNombreProducto.Text = ""
        txtNumProducto.Text = ""
        txtPrecio.Text = ""
        txtCantidad.Text = ""
    End Sub

    Private Sub GeneraTabladeVenta()
        TblDetalleVenta = New DataTable()

        Dim MyCol1 As DataColumn = New DataColumn()
        MyCol1.DataType = System.Type.GetType("System.String")
        MyCol1.ColumnName = "NumProducto"
        MyCol1.Caption = "NumProducto"
        MyCol1.Unique = False
        TblDetalleVenta.Columns.Add(MyCol1)

        Dim MyCol2 As DataColumn = New DataColumn()
        MyCol2.DataType = System.Type.GetType("System.String")
        MyCol2.ColumnName = "Descripcion"
        MyCol2.Caption = "Descripcion"
        MyCol2.Unique = False
        TblDetalleVenta.Columns.Add(MyCol2)


        Dim MyCol3 As DataColumn = New DataColumn()
        MyCol3.DataType = System.Type.GetType("System.Decimal")
        MyCol3.ColumnName = "Cantidad"
        MyCol3.Caption = "Cantidad"
        MyCol3.Unique = False
        TblDetalleVenta.Columns.Add(MyCol3)


        Dim MyCol4 As DataColumn = New DataColumn()
        MyCol4.DataType = System.Type.GetType("System.Decimal")
        MyCol4.ColumnName = "Precio"
        MyCol4.Caption = "Precio"
        MyCol4.Unique = False
        TblDetalleVenta.Columns.Add(MyCol4)

        Dim MyCol5 As DataColumn = New DataColumn()
        MyCol5.DataType = System.Type.GetType("System.Decimal")
        MyCol5.ColumnName = "Total"
        MyCol5.Caption = "Total"
        MyCol5.Unique = False
        TblDetalleVenta.Columns.Add(MyCol5)

        Dim MyCol6 As DataColumn = New DataColumn()
        MyCol6.DataType = System.Type.GetType("System.String")
        MyCol6.ColumnName = "TipoProducto"
        MyCol6.Caption = "TipoProducto"
        MyCol6.Unique = False
        TblDetalleVenta.Columns.Add(MyCol6)

    End Sub

    Private Sub btnParaLlevar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnParaLlevar.Click
        'MessageBox.Show("IMPRIMIENDO TICKET", "PIZZAS", MessageBoxButtons.OK)
        'VentaNueva()
        'If dgvVentaDetalles.RowCount > 0 Then
        If GrabaVenta("") Then
            MessageBox.Show("IMPRIMIENDO TICKET", "PIZZAS", MessageBoxButtons.OK)
            VentaNueva()
        End If
        'End If
    End Sub
    Private Sub btnLocal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLocal.Click
        If dgvVentaDetalles.RowCount > 0 Then
            If GrabaVenta("") Then
                MessageBox.Show("IMPRIMIENDO TICKET", "PIZZAS", MessageBoxButtons.OK)
                VentaNueva()
            End If
        End If
    End Sub
    Private Sub btntel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntel.Click
        MessageBox.Show("IMPRIMIENDO TICKET", "PIZZAS", MessageBoxButtons.OK)
        'dgvVentaDetalles.RowCount > 0 Then
        'Buscar el Cliente
        If GrabaVenta("") Then
            MessageBox.Show("IMPRIMIENDO TICKET", "PIZZAS", MessageBoxButtons.OK)
            VentaNueva()
        End If
    End Sub

    Public Function GrabaVenta(ByVal vClienteID As String) As Boolean
        Dim vGraba As Boolean = False
        Dim Comm As SqlCommand = New SqlCommand()
        Try
            Comm.Connection = DbSql
            Comm.CommandType = CommandType.StoredProcedure
            Comm.CommandText = "insert into VENTA(VentaID,NumEmpleado,ClienteID,Fecha)" & "values(@VentaID,@NumEmpleado,@ClienteID,@Fecha)"
            Comm.CommandType = CommandType.Text
            Comm.Parameters.Add("@VentaID", SqlDbType.VarChar, 15).Value = txtVentaID.Text.ToString().Trim()
            Comm.Parameters.Add("@NumEmpleado", SqlDbType.NChar, 10).Value = connsql.ToString()
            Comm.Parameters.Add("@ClienteID", SqlDbType.VarChar, 15).Value = vClienteID.ToString().Trim()
            Comm.Parameters.Add("@Fecha", SqlDbType.VarChar, 15).Value = txtFecha.Text.ToString()
            Comm.ExecuteNonQuery()
        Catch sqlEx As SqlException
            MessageBox.Show("Ocurrio un Error " & sqlEx.Message.ToString(), "Pizzas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return vGraba
        Catch ex As Exception
            MessageBox.Show("Ocurrio un Error " & ex.Message.ToString(), "Pizzas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return vGraba
        End Try

        Dim CommDet As SqlCommand = New SqlCommand()
        Dim IRow As Integer
        Try
            CommDet.Connection = DbSql
            CommDet.CommandType = CommandType.StoredProcedure
            For IRow = 0 To dgvVentaDetalles.RowCount - 1
                CommDet.CommandText = "INS_DETALLEVENTA"
                CommDet.Parameters.Clear()
                CommDet.Parameters.Add("@ventaID", SqlDbType.VarChar, 15).Value = txtVentaID.Text.ToString().Trim()
                CommDet.Parameters.Add("@Producto", SqlDbType.VarChar, 15).Value = dgvVentaDetalles.Rows(IRow).Cells("NumProducto").Value.ToString()
                CommDet.Parameters.Add("@Precio", SqlDbType.Decimal).Value = Decimal.Parse(dgvVentaDetalles.Rows(IRow).Cells("Precio").Value.ToString())
                CommDet.Parameters.Add("@Cantidad", SqlDbType.Decimal).Value = Decimal.Parse(dgvVentaDetalles.Rows(IRow).Cells("Cantidad").Value.ToString())
                CommDet.Parameters.Add("@TipoProd", SqlDbType.VarChar, 15).Value = dgvVentaDetalles.Rows(IRow).Cells("TipoProducto").Value.ToString()
                CommDet.ExecuteNonQuery()
            Next
        Catch sqlEx As SqlException
            MessageBox.Show("Ocurrio un Error " & sqlEx.Message.ToString(), "Pizzas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return vGraba
        Catch ex As Exception
            MessageBox.Show("Ocurrio un Error " & ex.Message.ToString(), "Pizzas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return vGraba
        End Try
        vGraba = True
        Return vGraba
    End Function

    Private Sub dgvProductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellContentClick
    End Sub

    Private Sub txtProducto_TextChanged(sender As Object, e As EventArgs) Handles txtProducto.TextChanged

    End Sub
End Class