Imports System.Data.SqlClient
Imports System.Data
Public Class AccesoManual

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.
    Dim User As String
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If txtLogin.Text.Trim() = "" Then
            Exit Sub
        End If

        Dim acc As String = ""
        Dim pass As String = ""
        Dim Comm As New SqlCommand()
        Comm.Connection = connsql
        Comm.CommandText = "AccesoUserLogin"
        Comm.CommandType = CommandType.StoredProcedure
        Comm.Parameters.Add("@Login", SqlDbType.NChar, 10).Value = txtLogin.Text.ToString()

        Dim DReader As SqlDataReader = Comm.ExecuteReader
        If DReader.HasRows Then
            While DReader.Read()
                acc = DReader("Nombre_Cat")
                pass = DReader("Password")

            End While
        Else
            MessageBox.Show("Usuario no encontrado", "Acceso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        DReader.Close()

        Select Case acc.Trim()
            Case "ADMINISTRADOR"
                MENUGUI.Show()
            Case "VENDEDOR"
                MENUGUI.Show()
            Case ""
                Exit Sub
        End Select

        Me.Close()
        User = txtLogin.Text
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub AccesoManual_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        LoginID.Show()
    End Sub

    Private Sub AccesoManual_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
