Imports System.Data.SqlClient
Imports System.Data

Public Class LoginID
    Private Sub txtIdUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIdUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAcceso.Select()
        End If

    End Sub
    Private Sub txtIdUsuario_Validated(sender As Object, e As EventArgs) Handles txtIdUsuario.Validated
        If txtIdUsuario.Text.Trim() = "" Then
            Exit Sub
        End If
        Dim acc As String = ""
        Dim Comm As New SqlCommand()
        Comm.Connection = connsql
        Comm.CommandText = "AccesoUsuario"
        Comm.CommandType = CommandType.StoredProcedure
        Comm.Parameters.Add("@Id", SqlDbType.NChar, 10).Value = txtIdUsuario.Text.ToString()

        Dim DReader As SqlDataReader = Comm.ExecuteReader
        If DReader.HasRows Then
            While DReader.Read()
                acc = DReader("Nombre_Cat")
            End While
        Else
            MessageBox.Show("Usuario no encontrado", "Acceso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        DReader.Close()

        Select Case acc.Trim()
            Case "ADMINISTRADOR"
                MENUGUI.Show()
            Case "VENDEDOR"
                EMPLEADOS.Show()
            Case ""
                Exit Sub
        End Select
        Me.Hide()
    End Sub

    Private Sub LoginID_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Config.Iniciarconexion()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAcceso_Click(sender As Object, e As EventArgs) Handles btnAcceso.Click
        AccesoManual.Show()
        Me.Hide()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub txtIdUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtIdUsuario.TextChanged

    End Sub
End Class