Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class FormUsuarios

    Public Function validaciones()
        If validarLargoyEmpty(8, 30, "La contraseña no puede estar en blanco o no cumple con la cantidad requerida de caracteres", txtPass.Text) Then
            Return False
        End If
        If validarLargoyEmpty(8, 30, "El usuario no puede estar en blanco o no cumple con la cantidad requerida de caracteres", txtUsuario.Text) Then
            Return False
        End If
        If validarVacio("Elija un tipo de usuario", cbxUsuarios.Text) Then
            Return False
        End If
        Return True
    End Function

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If validaciones() Then

            conectar.Open()
            Dim cmd As SqlCommand = New SqlCommand("insert into usuarios values (@username, @pass, @tipo)", conectar)
            cmd.Parameters.AddWithValue("@username", txtUsuario.Text)
            cmd.Parameters.AddWithValue("@pass", txtPass.Text)
            cmd.Parameters.AddWithValue("@tipo", cbxUsuarios.SelectedIndex + 1)

            cmd.ExecuteNonQuery()
            conectar.Close()
            LlenarTablaQuery("select idusuario as 'Id del Usuario', username as 'Usuario', pass as 'Contraseña', tipo as 
            'Nivel de Usuario' from usuarios", dataGridViewUsuarios.dgvUsuarios)
            MessageBox.Show("Datos Registrados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BorrarTextBoxForm(Me)
            cbxUsuarios.SelectedIndex = -1


        Else
            MessageBox.Show("Verifique los datos a ingresar", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        If validaciones() Then

            conectar.Open()
            Dim cmd As SqlCommand = New SqlCommand("update usuarios set username=@username, pass=@pass, tipo=@tipo where idusuario=@idusuario", conectar)
            cmd.Parameters.AddWithValue("@username", txtUsuario.Text)
            cmd.Parameters.AddWithValue("@pass", txtPass.Text)
            cmd.Parameters.AddWithValue("@tipo", cbxUsuarios.SelectedIndex + 1)
            cmd.Parameters.AddWithValue("@idusuario", txtId.Text)

            cmd.ExecuteNonQuery()
            conectar.Close()
            LlenarTablaQuery("select idusuario as 'Id del Usuario', username as 'Usuario', pass as 'Contraseña', tipo as 
            'Nivel de Usuario' from usuarios", dataGridViewUsuarios.dgvUsuarios)
            MessageBox.Show("Datos Registrados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BorrarTextBoxForm(Me)
            cbxUsuarios.SelectedIndex = -1
            Me.Close()


        Else
            MessageBox.Show("Verifique los datos a ingresar", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


End Class