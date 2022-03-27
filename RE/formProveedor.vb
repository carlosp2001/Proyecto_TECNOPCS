Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class formProveedor

    Private Function validaciones()
        If validarLargoyEmpty(2, 30, "El largo del nombre no es el correcto o hay espacios en blanco", txtNombre.Text) Then
            Return False
        End If
        If validarLargoyEmpty(10, 30, "El largo de la direccion no es el correcto o hay espacios en blanco", txtDireccion.Text) Then
            Return False
        End If
        Return True
    End Function

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If validaciones() Then
            conectar.Open()
            Dim cmd As SqlCommand = New SqlCommand("exec PA_INSERTAR_PROVEEDOR @nombre, @direccion", conectar)
            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text)
            cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text)
            cmd.ExecuteNonQuery()
            conectar.Close()
            LlenarTablaQuery("select idproveedor as 'Id Proveedor', nombreproveedor as 'Nombre Proveedor', direccion as 'Direccion'
            from proveedor", formDataC.dataGridViewDatos)
            BorrarTextBoxForm(Me)
            MessageBox.Show("Datos Registrados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            MessageBox.Show("Verifique los datos a ingresar", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If validaciones() Then
            conectar.Open()
            Dim cmd As SqlCommand = New SqlCommand("exec PA_ACTUALIZAR_PROVEEDOR @idproveedor, @nombre, @direccion", conectar)
            cmd.Parameters.AddWithValue("@idproveedor", txtId.Text)
            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text)
            cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text)
            cmd.ExecuteNonQuery()
            conectar.Close()

            LlenarTablaQuery("select idproveedor as 'Id Proveedor', nombreproveedor as 'Nombre Proveedor', direccion as 'Direccion'
            from proveedor", formDataC.dataGridViewDatos)
            BorrarTextBoxForm(Me)
            MessageBox.Show("Datos Registrados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Else
            MessageBox.Show("Verifique los datos a ingresar", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Me.Close()
    End Sub

    Private Sub txtnombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        If validarLetras(txtNombre.Text, "El campo de nombre solo puede contener letras") Then
            txtNombre.Text = ""
        End If
    End Sub

    Private Sub txtDireccion_TextChanged(sender As Object, e As EventArgs) Handles txtDireccion.TextChanged
        If validarAlfanumericos(txtDireccion.Text, "El campo de direccion solo puede contener letras y numeros") Then
            txtDireccion.Text = ""
        End If
    End Sub
End Class