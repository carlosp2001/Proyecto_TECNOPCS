Imports System.Data.SqlClient
Public Class formLogin

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        conectar.Open()
        Dim recuperar1 As SqlDataReader
        Dim ejecutar1 As New SqlCommand
        ejecutar1 = New SqlCommand("select tipo from usuarios where username=@usuario and pass=@pass", conectar)
        ejecutar1.Parameters.AddWithValue("@usuario", txtUsuario.Text)
        ejecutar1.Parameters.AddWithValue("@pass", txtPass.Text)
        recuperar1 = ejecutar1.ExecuteReader()
        Dim tipoUsuario As Integer
        If (recuperar1.Read() = True) Then
            tipoUsuario = Val(recuperar1(0))
            BorrarTextBoxForm(Me)
        Else
            MessageBox.Show("Usuario no encontrado o usuario y contraseña no coinciden", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        recuperar1.Close()
        conectar.Close()
        Select Case tipoUsuario
            Case 3
                formMenu.btnUsuario.Visible = False
                formMenu.btnClientes.Visible = False
                formMenu.btnEmpleado.Visible = False
                formMenu.btnPagoEmpleados.Visible = False
                formMenu.btnProductos.Visible = False
                formMenu.btnProveedores.Visible = False
                formMenu.btnRealizarVenta.Visible = False
                formMenu.btnRegistrarSoporte.Visible = True
                formMenu.btnReportes.Visible = False
                formMenu.Show()
            Case 2
                formMenu.btnUsuario.Visible = False
                formMenu.btnClientes.Visible = True
                formMenu.btnEmpleado.Visible = False
                formMenu.btnPagoEmpleados.Visible = False
                formMenu.btnProductos.Visible = True
                formMenu.btnProveedores.Visible = False
                formMenu.btnRealizarVenta.Visible = True
                formMenu.btnRegistrarSoporte.Visible = True
                formMenu.btnReportes.Visible = False
                formMenu.Show()
            Case 1
                formMenu.btnUsuario.Visible = True
                formMenu.btnClientes.Visible = True
                formMenu.btnEmpleado.Visible = True
                formMenu.btnPagoEmpleados.Visible = True
                formMenu.btnProductos.Visible = True
                formMenu.btnProveedores.Visible = True
                formMenu.btnRealizarVenta.Visible = True
                formMenu.btnRegistrarSoporte.Visible = True
                formMenu.btnReportes.Visible = True
                formMenu.Show()
        End Select
    End Sub

    Private Sub pass_CheckedChanged(sender As Object, e As EventArgs) Handles passCheckbox.CheckedChanged
        If passCheckbox.Checked = True Then
            txtPass.PasswordChar = ""
        Else
            txtPass.PasswordChar = "*"
        End If



    End Sub
End Class