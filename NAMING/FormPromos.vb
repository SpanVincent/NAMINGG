Imports System.Data
Imports System.Data.SqlClient

Public Class FormPromos
    Public DbSql As SqlConnection
    Private Sub frmPromCombo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DbSql = New SqlConnection("Data Source=LAPTOP-FGA832IT;Initial Catalog=PIZZERIA;Integrated Security=True")
        DbSql.Open()
        LlenaProductos()
        LlenaCombosLista()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim Comm As SqlCommand = New SqlCommand()
        Comm.Connection = DbSql
        Comm.CommandType = CommandType.StoredProcedure
        Comm.CommandText = "INS_COMBOS"
        Comm.Parameters.Add("@NombreCombo", SqlDbType.NVarChar, 150).Value = txtNombre.Text.ToString()
        Comm.Parameters.Add("@Tipo", SqlDbType.NVarChar, 15).Value = CmbTipo.Text.ToString()
        Comm.Parameters.Add("@FechaInicio", SqlDbType.DateTime).Value = dtpFechaInicio.Value
        Comm.Parameters.Add("@FechaFin", SqlDbType.DateTime).Value = dtpFechaFin.Value
        Comm.Parameters.Add("@Precio", SqlDbType.Decimal).Value = Double.Parse(txtPrecioFinal.Text.ToString())
        Comm.ExecuteNonQuery()

        Dim Sql As String
        Dim ICount As Integer
        Dim vProdID As String = ""
        Dim vTipoProd As String = ""
        For ICount = 0 To lstProductos.Items.Count - 1
            Sql = "Select * from Productos_Venta where Nombre = '" & lstProductos.Items(ICount).ToString() & "'"
            Dim CommD As SqlCommand = New SqlCommand(Sql, DbSql)
            Dim SqlDr As SqlDataReader = CommD.ExecuteReader()
            If SqlDr.Read() Then
                vProdID = SqlDr("NumProducto").ToString()
                vTipoProd = SqlDr("TipoProducto").ToString()
            End If
            SqlDr.Close()
            Dim CommIns As SqlCommand = New SqlCommand()
            CommIns.CommandType = CommandType.StoredProcedure
            CommIns.Connection = DbSql
            CommIns.CommandText = "INS_CombosyOfertasDetalles"
            CommIns.Parameters.Add("@NombreCombo", SqlDbType.VarChar, 150).Value = txtNombre.Text.ToString()
            CommIns.Parameters.Add("@ProductoID", SqlDbType.NVarChar, 15).Value = vProdID.ToString()
            CommIns.Parameters.Add("@TipoProducto", SqlDbType.VarChar, 15).Value = vTipoProd.ToString()
            CommIns.ExecuteNonQuery()
            CommIns.Dispose()

        Next
        lstProductos.Items.Clear()
        txtNombre.Text = ""
        txtPrecioFinal.Text = ""

        LlenaCombosLista()

    End Sub
    Private Sub LlenaProductos()
        Dim Sql As String = "Select * from Productos order by Nombre"
        Dim Comm As SqlCommand = New SqlCommand(Sql, DbSql)
        Dim Da As SqlDataAdapter = New SqlDataAdapter(Comm)
        Dim tblProductos As DataTable = New DataTable()
        Da.Fill(tblProductos)
        cmProducto.ValueMember = "NumProducto"
        cmProducto.DisplayMember = "nombre"
        cmProducto.DataSource = tblProductos
    End Sub

    Private Sub cmProducto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmProducto.SelectedIndexChanged
        Dim Sql As String = "Select Precio from Productos where numproducto = '" _
           & cmProducto.SelectedValue.ToString() & "'"
        Dim Comm As SqlCommand = New SqlCommand(Sql, DbSql)
        Dim SqlDr As SqlDataReader = Comm.ExecuteReader()
        If SqlDr.Read() Then
            txtPrecioNormal.Text = SqlDr("Precio").ToString()
        End If
        SqlDr.Close()
    End Sub
    Private Sub LlenaCombosLista()
        Dim Sql As String = "Select * from CombosyOfertas order by NombreCombo"
        Dim Comm As SqlCommand = New SqlCommand(Sql, DbSql)
        Dim Da As SqlDataAdapter = New SqlDataAdapter(Comm)
        Dim tblCombos As DataTable = New DataTable()
        Da.Fill(tblCombos)
        dgvCombos.DataSource = tblCombos.DefaultView
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Dim Comm As SqlCommand
        Dim Sql As String
        Dim vNombreCombo As String
        If dgvCombos.SelectedRows.Count > 0 Then
            vNombreCombo = dgvCombos.SelectedRows(0).Cells("NombreCombo").Value.ToString()
            Comm = New SqlCommand()
            Comm.Connection = DbSql
            Comm.CommandType = CommandType.StoredProcedure
            Comm.CommandText = "BORRAR_COMBOS"
            Comm.Parameters.Add("@NombreCombo", SqlDbType.VarChar, 150).Value = vNombreCombo.ToString()
            Comm.ExecuteNonQuery()

            LlenaCombosLista()
        Else
            MessageBox.Show("Seleccione el Renglon a Borrar ", "UAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnPasar_Click(sender As Object, e As EventArgs) Handles btnPasar.Click
        lstProductos.Items.Add(cmProducto.Text.ToString())
    End Sub
    Private Sub frmPromCombo_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        DbSql.Close()
    End Sub

End Class