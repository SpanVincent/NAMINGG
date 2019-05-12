Imports System.Data
Imports System.Data.SqlClient
Public Class FormArticulos
    Public DbSql As SqlConnection
    Dim TblArticulos As DataTable = New DataTable()
    Public vIDArticuloID As String
    Public vRegistroActual As Integer
    Public vTotalArticulos As Integer
    Public vArticuloNuevo As Boolean = False

    Private Sub frmArticulos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DbSql = New SqlConnection("Data Source=LAPTOP-FGA832IT;Initial Catalog=PIZZERIA;Integrated Security=True")
        DbSql.Open()
        LlenaTablaArticulos()
        HabilitaDeshabilitaTextos(False)
    End Sub
    Private Sub frmArticulos_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        DbSql.Close()
    End Sub
    Private Sub TsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsbSalir.Click
        Me.Close()
    End Sub

    Private Sub LlenaTablaArticulos()
        Dim Comm As SqlCommand
        Comm = New SqlCommand()
        Comm.Connection = DbSql
        Comm.CommandType = CommandType.Text
        Comm.CommandText = "Select * from ARTICULO Order by IdArticulo"
        Dim SqlDA As SqlDataAdapter = New SqlDataAdapter(Comm)
        SqlDA.Fill(TblArticulos)
        DgvArticulos.DataSource = TblArticulos
        vTotalArticulos = TblArticulos.Rows.Count
        If TblArticulos.Rows.Count = 0 Then
            TsbPrimero.Enabled = False
            TsbAnterior.Enabled = False
            TsbSiguiente.Enabled = False
            TsbUltimo.Enabled = False
        Else
            vIDArticuloID = TblArticulos.Rows(0)("IdArticulo").ToString()
            Llena_Textos(0)
        End If
    End Sub
    Private Sub LlenaCombosLista()
        Dim Sql As String = "Select * from ARTICULO order by IdArticulo"
        Dim Comm As SqlCommand = New SqlCommand(Sql, DbSql)
        Dim Da As SqlDataAdapter = New SqlDataAdapter(Comm)
        Dim tblCombos As DataTable = New DataTable()
        Da.Fill(tblCombos)
        DgvArticulos.DataSource = tblCombos.DefaultView
    End Sub

    Private Sub HabilitaDeshabilitaTextos(ByVal vEdicion As Boolean)
        txtIDArticulo.ReadOnly = Not vEdicion
        txtNombre.ReadOnly = Not vEdicion
        cmbUM.Enabled = vEdicion
        NdMinimo.Enabled = vEdicion
        NdMaximo.Enabled = vEdicion
        txtCosto.ReadOnly = Not vEdicion
        cmbStatus.Enabled = vEdicion
        txtCantidadExistente.ReadOnly = Not vEdicion
        txtPrecioVenta.ReadOnly = Not vEdicion

        If vEdicion = True Then
            TsbGrabar.Enabled = True
            TsbCancelar.Enabled = True
            TsbNuevo.Enabled = False
            TsbEditar.Enabled = False
            TsbBorrar.Enabled = False

            TsbPrimero.Enabled = False
            TsbAnterior.Enabled = False
            TsbSiguiente.Enabled = False
            TsbUltimo.Enabled = False

        Else
            vArticuloNuevo = False
            TsbGrabar.Enabled = False
            TsbCancelar.Enabled = False
            TsbNuevo.Enabled = True
            TsbEditar.Enabled = True
            TsbBorrar.Enabled = True

            TsbPrimero.Enabled = True
            TsbAnterior.Enabled = True
            TsbSiguiente.Enabled = True
            TsbUltimo.Enabled = True
        End If
    End Sub


    Private Sub TsbNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsbNuevo.Click
        HabilitaDeshabilitaTextos(True)
        vArticuloNuevo = True
        TabControl1.SelectedIndex = 1

        txtIDArticulo.Text = ""
        txtNombre.Text = ""
        cmbUM.Text = ""
        NdMinimo.Value = 1
        NdMaximo.Value = 1
        txtCosto.Text = ""
        cmbStatus.Text = ""
        txtCantidadExistente.Text = 1
        txtPrecioVenta.Text = 0
        txtTipoProd.Text = ""
        txtIDArticulo.Focus()
    End Sub

    Private Sub Llena_Textos(ByVal vRecord As Integer)
        txtIDArticulo.Text = TblArticulos.Rows(vRecord)("IdArticulo").ToString()
        txtNombre.Text = TblArticulos.Rows(vRecord)("Nombre").ToString()
        cmbUM.Text = TblArticulos.Rows(vRecord)("UnidadMedida").ToString()
        NdMinimo.Value = Decimal.Parse(TblArticulos.Rows(vRecord)("Min").ToString())
        NdMaximo.Value = Decimal.Parse(TblArticulos.Rows(vRecord)("Max").ToString())
        txtCosto.Text = TblArticulos.Rows(vRecord)("Costo").ToString()
        cmbStatus.Text = TblArticulos.Rows(vRecord)("Vigencia").ToString()
        txtCantidadExistente.Text = TblArticulos.Rows(vRecord)("CantidadExistente").ToString()
        txtPrecioVenta.Text = TblArticulos.Rows(vRecord)("PrecioVenta").ToString()
        txtTipoProd.Text = TblArticulos.Rows(vRecord)("TipoProd").ToString()

    End Sub

    Private Sub TsbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsbCancelar.Click
        HabilitaDeshabilitaTextos(False)
    End Sub

    Private Sub TsbPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsbPrimero.Click
        Llena_Textos(0)
    End Sub

    Private Sub TsbAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsbAnterior.Click
        If vRegistroActual > 0 Then
            vRegistroActual = vRegistroActual - 1
            Llena_Textos(vRegistroActual)
        End If
    End Sub

    Private Sub TsbSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsbSiguiente.Click
        If (vRegistroActual + 1) < vTotalArticulos Then
            vRegistroActual = vRegistroActual + 1
            Llena_Textos(vRegistroActual)
        End If
    End Sub

    Private Sub TsbUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsbUltimo.Click
        Llena_Textos(vTotalArticulos - 1)
    End Sub

    Private Sub TsbGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsbGrabar.Click
        Dim vStoreProcedure As String
        If vArticuloNuevo = True Then
            vStoreProcedure = "INS_ARTICULO"
        Else
            vStoreProcedure = "MODIFICAR_ARTICULOS"
        End If
        Dim Comm As SqlCommand = New SqlCommand()
        Comm.Connection = DbSql
        Comm.CommandType = CommandType.StoredProcedure
        Comm.CommandText = vStoreProcedure
        Comm.Parameters.Add("@idArticulo", SqlDbType.NVarChar, 50).Value = txtIDArticulo.Text.ToString()
        Comm.Parameters.Add("@Nombre", SqlDbType.NVarChar, 100).Value = txtNombre.Text.ToString()
        Comm.Parameters.Add("@UnidadMedida", SqlDbType.NVarChar, 50).Value = cmbUM.Text.ToString()
        Comm.Parameters.Add("@Min", SqlDbType.Decimal).Value = NdMinimo.Value
        Comm.Parameters.Add("@Max", SqlDbType.Decimal).Value = NdMaximo.Value
        Comm.Parameters.Add("@Costo", SqlDbType.Decimal).Value = Double.Parse(txtCosto.Text.ToString())
        Comm.Parameters.Add("@CantidadExistente", SqlDbType.Decimal).Value = Double.Parse(txtCantidadExistente.Text.ToString())
        Comm.Parameters.Add("@Vigencia", SqlDbType.Date).Value = cmbStatus.Text.ToString()
        Comm.Parameters.Add("@PrecioVenta", SqlDbType.Decimal).Value = Double.Parse(txtPrecioVenta.Text.ToString())
        Comm.Parameters.Add("@TipoProd", SqlDbType.NVarChar, 15).Value = txtTipoProd.Text.ToString()
        Comm.ExecuteNonQuery()

        LlenaTablaArticulos()
        HabilitaDeshabilitaTextos(False)

    End Sub

    Private Sub DgvArticulos_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvArticulos.RowEnter
        Llena_Textos(e.RowIndex)
    End Sub

    Private Sub TsbBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsbBorrar.Click
        Dim Comm As SqlCommand
        Dim vNombreCombo As String
        If DgvArticulos.SelectedRows.Count > 0 Then
            vNombreCombo = DgvArticulos.SelectedRows(0).Cells("IdArticulo").Value.ToString()
            Comm = New SqlCommand()
            Comm.Connection = DbSql
            Comm.CommandType = CommandType.StoredProcedure
            Comm.CommandText = "BORRAR_ARTICULO"
            Comm.Parameters.Add("@IdArticulo", SqlDbType.NVarChar, 15).Value = vNombreCombo.ToString()
            Comm.ExecuteNonQuery()
            LlenaCombosLista()
            'LlenaTablaArticulos()
            HabilitaDeshabilitaTextos(False)
        End If
    End Sub

    Private Sub cmbUM_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TsbEditar_Click(sender As Object, e As EventArgs) Handles TsbEditar.Click

    End Sub
End Class