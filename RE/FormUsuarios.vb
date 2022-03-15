Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class FormUsuarios

    Public Function validaciones()
        If validarLargoyEmpty(8, 30, "La contraseña no puede estar en blanco", txtpass.Text) Then
            Return False
        End If
        If validarLargoyEmpty(8, 30, "El usuario no puede estar en blanco", txtid.Text) Then
            Return False
        End If
        If validarVacio("Elija un tipo de usuario", ComboBox1.Text) Then
            Return False
        End If
        Return True
    End Function

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If validaciones() Then

            conectar.Open()
            Dim cmd As SqlCommand = New SqlCommand("insert into usuarios values (@username, @pass, @tipo)", conectar)
            cmd.Parameters.AddWithValue("@username", txtusuario.Text)
            cmd.Parameters.AddWithValue("@pass", txtpass.Text)
            cmd.Parameters.AddWithValue("@tipo", ComboBox1.SelectedIndex + 1)

            cmd.ExecuteNonQuery()
            conectar.Close()
            LlenarTablaQuery("select idusuario as 'Id del Usuario', username as 'Usuario', pass as 'Contraseña', tipo as 
            'Nivel de Usuario' from usuarios", dataGridViewUsuarios.DataGridView1)
            MessageBox.Show("Datos Registrados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BorrarTextBoxForm(Me)
            ComboBox1.SelectedIndex = -1


        Else
            MessageBox.Show("Verifique los datos a ingresar", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        If validaciones() Then

            conectar.Open()
            Dim cmd As SqlCommand = New SqlCommand("update usuarios set username=@username, pass=@pass, tipo=@tipo where idusuario=@idusuario", conectar)
            cmd.Parameters.AddWithValue("@username", txtusuario.Text)
            cmd.Parameters.AddWithValue("@pass", txtpass.Text)
            cmd.Parameters.AddWithValue("@tipo", ComboBox1.SelectedIndex + 1)
            cmd.Parameters.AddWithValue("@idusuario", txtid.Text)

            cmd.ExecuteNonQuery()
            conectar.Close()
            LlenarTablaQuery("select idusuario as 'Id del Usuario', username as 'Usuario', pass as 'Contraseña', tipo as 
            'Nivel de Usuario' from usuarios", dataGridViewUsuarios.DataGridView1)
            MessageBox.Show("Datos Registrados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BorrarTextBoxForm(Me)
            ComboBox1.SelectedIndex = -1
            Me.Close()


        Else
            MessageBox.Show("Verifique los datos a ingresar", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class