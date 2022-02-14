Imports System.Data.SqlClient
Public Class FRMLOGIN
    Private Sub FRMLOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Label1.BackColor = Color.Transparent
        Me.Label2.BackColor = Color.Transparent
        Me.Label9.BackColor = Color.Transparent
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conectar.Open()
        Dim recuperar1 As SqlDataReader
        Dim ejecutar1 As New SqlCommand
        ejecutar1 = New SqlCommand("select tipo from usuarios where username=@usuario and pass=@pass", conectar)
        ejecutar1.Parameters.AddWithValue("@usuario", txtusuario.Text)
        ejecutar1.Parameters.AddWithValue("@pass", txtpass.Text)
        recuperar1 = ejecutar1.ExecuteReader()
        Dim tipodeusuario As Integer
        If (recuperar1.Read() = True) Then
            tipodeusuario = Val(recuperar1(0))
            BorrarTextBoxForm(Me)
        Else
            MessageBox.Show("Usuario no encontrado o usuario y contraseña no coinciden", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        recuperar1.Close()
        conectar.Close()
        If tipodeusuario = 3 Then
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
        ElseIf tipodeusuario = 2 Then
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
        ElseIf tipodeusuario = 1 Then
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
        End If
    End Sub

    Private Sub pass_CheckedChanged(sender As Object, e As EventArgs) Handles passcheckbox.CheckedChanged
        If passcheckbox.Checked = True Then
            txtpass.PasswordChar = ""
        Else
            txtpass.PasswordChar = "*"
        End If



    End Sub
End Class