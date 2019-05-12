Imports System.Data
Imports System.Data.SqlClient
Public Class Compra
    Public DbSql As SqlConnection
    Public TblCOMPRAS As DataTable
    Dim NumPro As String
    Dim NomPro As String
    Dim Precio As Integer
    Public vTotalVenta As Double
    Public Iva As Double
    Public PreNormal, Cantidad, Min, Max As Double
    Public TipoProd As String
    Public NuevaVenta As Boolean = False
    Private Sub COMPRA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DbSql = New SqlConnection("Data Source=LAPTOP-FGA832IT;Initial Catalog=PIZZERIA;Integrated Security=True")
        DbSql.Open()
        GeneraTabladeVenta()
        txtCantidad.Text = 0
        txtCompraID.Text = GetVentaId()
        'dvgListaMostrar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub BuscarProductos()
        Dim Comm As SqlCommand
        Comm = New SqlCommand()
        Comm.Connection = DbSql
        Comm.CommandText = "select * from ARTICULO where nombre like @nombre"
        Comm.Parameters.Add("@nombre", SqlDbType.VarChar, 150).Value = txtCompra.Text.ToString() & "%"
        Dim Da As SqlDataAdapter = New SqlDataAdapter(Comm)
        Dim tblProductos As DataTable = New DataTable()
        Da.Fill(tblProductos)
        dvgListaMostrar.DataSource = tblProductos
        Da.Dispose()
        Comm.Dispose()
    End Sub

    Private Sub txtCompra_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCompra.KeyUp
        If txtCompra.Text.ToString().Trim() <> "" Then BuscarProductos()
    End Sub
    Private Sub dvgListaMostrar_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dvgListaMostrar.DoubleClick
        NumPro = dvgListaMostrar.SelectedRows(0).Cells("IdArticulo").Value.ToString()
        NomPro = dvgListaMostrar.SelectedRows(0).Cells("Nombre").Value.ToString()
        Precio = dvgListaMostrar.SelectedRows(0).Cells("PrecioVenta").Value.ToString()
        TipoProd = dvgListaMostrar.SelectedRows(0).Cells("TipoProd").Value.ToString()
        Cantidad = dvgListaMostrar.SelectedRows(0).Cells("CantidadExistente").Value.ToString()
        Min = dvgListaMostrar.SelectedRows(0).Cells("Max").Value.ToString()
        Max = txtCantidad.Text + Cantidad
        If Max > Min Then
            MessageBox.Show("EXCEDISTE EL LIMITE DE COMPRA", "PIZZERIA")
        Else
            If txtCantidad.Text = 0 Then
                MessageBox.Show("Escribe Cantidad", "PIZZERIA")
                txtCantidad.Focus()
            Else
                AgregaNuevoRenglon()
                'txtCantidad = txtCantidad
                'If NumPro.Trim() <> "" Then
                '    AgregaNuevoRenglon()
                'End If
            End If
            txtCompra.Text = ""
        End If
    End Sub
    Private Sub txtCantidad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Dim vRes As Integer
            If Integer.TryParse(txtCantidad.Text.ToString(), vRes) = True Then
                If NumPro.Trim() <> "" Then
                    AgregaNuevoRenglon()
                End If
                txtCompra.Focus()
            End If
        End If
    End Sub
    Private Sub AgregaNuevoRenglon()
        Dim MyDataRow As DataRow
        MyDataRow = TblCOMPRAS.NewRow()
        MyDataRow("NumProducto") = NumPro
        MyDataRow("Descripcion") = NomPro
        MyDataRow("Cantidad") = Double.Parse(txtCantidad.Text.ToString())
        MyDataRow("Precio") = Double.Parse(Precio)
        MyDataRow("TipoProducto") = TipoProd

        Dim vSubtotal As Double = Double.Parse(txtCantidad.Text.ToString()) * Double.Parse(Precio)
        MyDataRow("Total") = vSubtotal
        vTotalVenta = vTotalVenta + vSubtotal
        Iva = vSubtotal / 100 * 16
        PreNormal = vTotalVenta - Iva
        TblCOMPRAS.Rows.Add(MyDataRow)
        TblCOMPRAS.AcceptChanges()
        mskTxtTotal.Text = "$" & vTotalVenta
        dgvCompra.DataSource = TblCOMPRAS.DefaultView
        dgvCompra.Columns(5).Visible = False

    End Sub
    Private Sub GeneraTabladeVenta()
        TblCOMPRAS = New DataTable()

        Dim MyCol1 As DataColumn = New DataColumn()
        MyCol1.DataType = System.Type.GetType("System.String")
        MyCol1.ColumnName = "NumProducto"
        MyCol1.Caption = "NumProducto"
        MyCol1.Unique = False
        TblCOMPRAS.Columns.Add(MyCol1)

        Dim MyCol2 As DataColumn = New DataColumn()
        MyCol2.DataType = System.Type.GetType("System.String")
        MyCol2.ColumnName = "Descripcion"
        MyCol2.Caption = "Descripcion"
        MyCol2.Unique = False
        TblCOMPRAS.Columns.Add(MyCol2)


        Dim MyCol3 As DataColumn = New DataColumn()
        MyCol3.DataType = System.Type.GetType("System.Decimal")
        MyCol3.ColumnName = "Cantidad"
        MyCol3.Caption = "Cantidad"
        MyCol3.Unique = False
        TblCOMPRAS.Columns.Add(MyCol3)


        Dim MyCol4 As DataColumn = New DataColumn()
        MyCol4.DataType = System.Type.GetType("System.Decimal")
        MyCol4.ColumnName = "Precio"
        MyCol4.Caption = "Precio"
        MyCol4.Unique = False
        TblCOMPRAS.Columns.Add(MyCol4)

        Dim MyCol5 As DataColumn = New DataColumn()
        MyCol5.DataType = System.Type.GetType("System.Decimal")
        MyCol5.ColumnName = "Total"
        MyCol5.Caption = "Total"
        MyCol5.Unique = False
        TblCOMPRAS.Columns.Add(MyCol5)

        Dim MyCol6 As DataColumn = New DataColumn()
        MyCol6.DataType = System.Type.GetType("System.String")
        MyCol6.ColumnName = "TipoProducto"
        MyCol6.Caption = "TipoProducto"
        MyCol6.Unique = False
        TblCOMPRAS.Columns.Add(MyCol6)

    End Sub
    Private Sub btnVenta_Click(sender As Object, e As EventArgs) Handles btnVenta.Click
        Dim CommDet As SqlCommand = New SqlCommand()
        Dim IRow As Integer
        CommDet.Connection = DbSql
        CommDet.CommandType = CommandType.StoredProcedure
        CommDet.CommandText = "DetalleCompra"
        CommDet.Parameters.Add("@Id_Articulo", SqlDbType.NVarChar, 15).Value = NumPro
        CommDet.Parameters.Add("@Cantidad", SqlDbType.Decimal).Value = Double.Parse(txtCantidad.Text.ToString())
        CommDet.ExecuteNonQuery()
        GrabaVenta()
        CompraNueva()

    End Sub
    Private Sub CompraNueva()
        vTotalVenta = 0
        TblCOMPRAS.Clear()

        txtCompraID.Text = GetVentaId()
        txtCompra.Text = ""
        dvgListaMostrar.DataSource = Nothing
        dgvCompra.DataSource = Nothing

        txtCantidad.Text = ""
        mskTxtTotal.Text = "0"

        txtCompra.Focus()
    End Sub

    Private Function GetVentaId() As String
        Dim vCompraID As String = ""
        Dim Comm As SqlCommand = New SqlCommand()
        Comm.Connection = DbSql
        Comm.CommandType = CommandType.Text
        Comm.CommandText = "Select dbo.fn_ObtenerCompraID() as CompraID"
        Dim Dr As SqlDataReader
        Dr = Comm.ExecuteReader
        If Dr.Read() Then
            vCompraID = Dr("CompraID").ToString()
        End If
        Dr.Close()
        Return vCompraID
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Fecha_Hora.Tick
        txtFecha.Text = String.Format("{0:G}", DateTime.Now)
    End Sub
    Public Sub GrabaVenta()
        Dim Comm As SqlCommand = New SqlCommand()
        Comm.Connection = DbSql
        Comm.CommandType = CommandType.StoredProcedure
        Comm.CommandText = "insert into INS_COMPRAS(Id_Orden,IdArticulo,FechaCompra,Cantidad,Status)" & "values(@Id_Orden,@Id_Articulo,@FechaCompra,@Cantidad,@Status)"
        Comm.CommandType = CommandType.Text
        Comm.Parameters.Add("@Id_Orden", SqlDbType.NVarChar, 15).Value = txtCompraID.Text.ToString().Trim()
        Comm.Parameters.Add("@Id_Articulo", SqlDbType.NVarChar, 15).Value = NumPro
        Comm.Parameters.Add("@FechaCompra", SqlDbType.Date).Value = txtFecha.Text.ToString()
        Comm.Parameters.Add("@Cantidad", SqlDbType.Decimal).Value = txtCantidad.Text.ToString()
        Comm.Parameters.Add("@Status", SqlDbType.NChar, 10).Value = NomPro
        Comm.ExecuteNonQuery()
    End Sub
End Class