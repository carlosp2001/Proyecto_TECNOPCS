Imports System.Data.SqlClient
Public Class FRMLOGIN
    Private Sub FRMLOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

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
                FrmMENU.btnusuario.Visible = False
                FrmMENU.btnClientes.Visible = False
                FrmMENU.btnEmpleado.Visible = False
                FrmMENU.btnPagoEmpleados.Visible = False
                FrmMENU.btnProductos.Visible = False
                FrmMENU.btnProveedores.Visible = False
                FrmMENU.btnrealizarventa.Visible = False
                FrmMENU.btnRegistrarSoporte.Visible = True
                FrmMENU.btnreportes.Visible = False
                FrmMENU.Show()
            Case 2
                FrmMENU.btnusuario.Visible = False
                FrmMENU.btnClientes.Visible = True
                FrmMENU.btnEmpleado.Visible = False
                FrmMENU.btnPagoEmpleados.Visible = False
                FrmMENU.btnProductos.Visible = True
                FrmMENU.btnProveedores.Visible = False
                FrmMENU.btnrealizarventa.Visible = True
                FrmMENU.btnRegistrarSoporte.Visible = True
                FrmMENU.btnreportes.Visible = False
                FrmMENU.Show()
            Case 1
                FrmMENU.btnusuario.Visible = True
                FrmMENU.btnClientes.Visible = True
                FrmMENU.btnEmpleado.Visible = True
                FrmMENU.btnPagoEmpleados.Visible = True
                FrmMENU.btnProductos.Visible = True
                FrmMENU.btnProveedores.Visible = True
                FrmMENU.btnrealizarventa.Visible = True
                FrmMENU.btnRegistrarSoporte.Visible = True
                FrmMENU.btnreportes.Visible = True
                FrmMENU.Show()
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