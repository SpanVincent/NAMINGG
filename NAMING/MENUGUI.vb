Public Class MENUGUI
    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        EMPLEADOS.Show()
        Me.Close()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtFecha.Text = String.Format("{0:G}", DateTime.Now)
    End Sub

    Private Sub MENUGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAdmi.Text = AccesoManual.txtLogin.Text
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        FormArticulos.Show()
    End Sub

    Private Sub ListaDeMaterialesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeMaterialesToolStripMenuItem.Click
        LISTADEMATERIALES.Show()
    End Sub

    Private Sub CatalogoDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CatalogoDeProductosToolStripMenuItem.Click
        FormProductosVenta.Show()
    End Sub

    Private Sub PromocionesYCombosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PromocionesYCombosToolStripMenuItem.Click
        FormPromos.Show()
    End Sub

    Private Sub CompraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompraToolStripMenuItem.Click
        Compra.Show()
    End Sub

    Private Sub VentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentaToolStripMenuItem.Click
        Venta.Show()
    End Sub
End Class