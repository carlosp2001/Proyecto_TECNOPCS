Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class FormUsuarios
    Private Sub FormUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim resultado As Boolean = False
        'Validacion de password
        If Len(txtpass.Text) < 8 Or Len(txtpass.Text) > 30 Then
            MessageBox.Show("El largo de la contraseña no es el correcto", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            resultado = True
        End If

        'Validacion de Username
        If Len(txtusuario.Text) < 8 Or Len(txtusuario.Text) > 30 Then
            MessageBox.Show("El largo del usuario no es el correcto", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            resultado = True
        End If

        If ComboBox1.SelectedIndex = -1 Then
            resultado = True
            MessageBox.Show("Seleccion un tipo de usuario", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


        If Mid(txtusuario.Text, 1, 1) = " " Or Mid(txtpass.Text, 1, 1) = " " Then
            resultado = True
            MessageBox.Show("No se permiten espacios en blanco", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If resultado = False Then

            conectar.Open()
            Dim cmd As SqlCommand = New SqlCommand("insert into usuarios values (@username, @pass, @tipo)", conectar)
            cmd.Parameters.AddWithValue("@username", txtusuario.Text)
            cmd.Parameters.AddWithValue("@pass", txtpass.Text)
            cmd.Parameters.AddWithValue("@tipo", ComboBox1.SelectedIndex + 1)

            cmd.ExecuteNonQuery()
            conectar.Close()
            LlenarTablaQuery("select idusuario as 'Id del Usuario', username as 'Usuario', pass as 'Contraseña', tipo as 
'Nivel de Usuario' from usuarios", Datagridviewusuario.DataGridView1)
            MessageBox.Show("Datos Registrados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BorrarTextBoxForm(Me)
            ComboBox1.SelectedIndex = -1


        Else
            MessageBox.Show("Verifique los datos solicitados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim resultado As Boolean = False
        'Validacion de password
        If Len(txtpass.Text) < 8 Or Len(txtpass.Text) > 30 Then
            MessageBox.Show("El largo de la contraseña no es el correcto", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            resultado = True
        End If

        'Validacion de Username
        If Len(txtusuario.Text) < 8 Or Len(txtusuario.Text) > 30 Then
            MessageBox.Show("El largo del usuario no es el correcto", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            resultado = True
        End If

        If ComboBox1.SelectedIndex = -1 Then
            resultado = True
            MessageBox.Show("Seleccion un tipo de usuario", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


        If Mid(txtusuario.Text, 1, 1) = " " Or Mid(txtpass.Text, 1, 1) = " " Then
            resultado = True
            MessageBox.Show("No se permiten espacios en blanco", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If resultado = False Then

            conectar.Open()
            Dim cmd As SqlCommand = New SqlCommand("update usuarios set username=@username, pass=@pass, tipo=@tipo where idusuario=@idusuario", conectar)
            cmd.Parameters.AddWithValue("@username", txtusuario.Text)
            cmd.Parameters.AddWithValue("@pass", txtpass.Text)
            cmd.Parameters.AddWithValue("@tipo", ComboBox1.SelectedIndex + 1)
            cmd.Parameters.AddWithValue("@idusuario", txtid.Text)

            cmd.ExecuteNonQuery()
            conectar.Close()
            LlenarTablaQuery("select idusuario as 'Id del Usuario', username as 'Usuario', pass as 'Contraseña', tipo as 
'Nivel de Usuario' from usuarios", Datagridviewusuario.DataGridView1)
            MessageBox.Show("Datos Registrados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BorrarTextBoxForm(Me)
            ComboBox1.SelectedIndex = -1
            Me.Close()


        Else
            MessageBox.Show("Verifique los datos solicitados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class