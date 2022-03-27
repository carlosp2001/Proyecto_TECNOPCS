Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class formClientes

    Private Function validaciones()
        If validarLargoyEmpty(5, 40, "El largo del nombre no es el correcto o hay espacios en blanco", txtNombre.Text) Then
            Return False
        End If
        If validarLargoyEmpty(8, 8, "EL largo del telefono no es el correcto o hay espacios en blanoco", txtTelefono.Text) Then
            Return False
        End If
        If validarLargoyEmpty(10, 40, "El largo del correo no es el correcto o hay espacios en blanoco", txtEmail.Text) Then
            Return False
        End If
        If validarLargoyEmpty(10, 40, "El largo de la direccion no es el correcto o hay espacios en blanoco", txtDireccion.Text) Then
            Return False
        End If
        'Validar Radio Button
        If validarRadioButton(rdbHombre, rdbMujer) Then
            Return False
        End If
        If Not DateAndTime.Today.Year - dtpFechaNacimiento.Value.Year >= 12 Then
            MessageBox.Show("El cliente debe tener al menos 12 años de edad", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If


        Return True
    End Function

    Private Sub btnAccion_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        dtpFechaRegistro.Value = DateAndTime.Today

        If validaciones() Then
            Dim genero As Integer
            If rdbHombre.Checked = True Then
                genero = 2
            Else
                genero = 1
            End If
            conectar.Open()
            Dim cmd As SqlCommand = New SqlCommand("exec PA_INSERTAR_CLIENTE @nombre, @telefono, @fecha, @direccion, @email, @genero, @fechaNacimiento", conectar)
            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text)
            cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text)
            cmd.Parameters.AddWithValue("@fecha", dtpFechaRegistro.Value)
            cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text)
            cmd.Parameters.AddWithValue("@email", txtEmail.Text)
            cmd.Parameters.AddWithValue("@genero", genero)
            cmd.Parameters.AddWithValue("@fechaNacimiento", dtpFechaNacimiento.Value)
            cmd.ExecuteNonQuery()
            conectar.Close()
            LlenarTablaQuery("select idCliente as 'Identificador', nombreCliente as 'Nombre Completo',
            telefonoCliente as 'Telefono', fechaRegistro as 'Fecha de registro', direccionCliente as 'Direccion', email as 'Email',
            genero as 'Genero', fechaNacimiento as 'Fecha de Nacimiento' from cliente", formDataC.dataGridViewDatos)
            MessageBox.Show("Datos Registrados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BorrarTextBoxForm(Me)
            Me.Close()
        Else
            MessageBox.Show("Verifique los datos a ingresar", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click


        If validaciones() Then
            Dim genero As Integer
            If rdbHombre.Checked = True Then
                genero = 2
            Else
                genero = 1
            End If
            conectar.Open()
            Dim cmd As SqlCommand = New SqlCommand("exec PA_ACTUALIZAR_CLIENTE @idcliente, @nombre, @telefono, @fecha, @direccion, @email, @genero, @fechaNacimiento", conectar)
            cmd.Parameters.AddWithValue("@idcliente", txtidcliente.Text)
            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text)
            cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text)
            cmd.Parameters.AddWithValue("@fecha", dtpFechaRegistro.Value)
            cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text)
            cmd.Parameters.AddWithValue("@email", txtEmail.Text)
            cmd.Parameters.AddWithValue("@genero", genero)
            cmd.Parameters.AddWithValue("@fechaNacimiento", dtpFechaNacimiento.Value)
            cmd.ExecuteNonQuery()
            conectar.Close()
            LlenarTablaQuery("select idCliente as 'Identificador', nombreCliente as 'Nombre Completo',
            telefonoCliente as 'Telefono', fechaRegistro as 'Fecha de registro', direccionCliente as 'Direccion', email as 'Email',
            genero as 'Genero', fechaNacimiento as 'Fecha de Nacimiento' from cliente", formDataC.dataGridViewDatos)
            BorrarTextBoxForm(Me)
            MessageBox.Show("Datos Registrados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Verifique los datos a ingresar", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub



    Private Sub txtdesc_TextChanged(sender As Object, e As EventArgs) Handles txtDireccion.TextChanged
        If validarAlfanumericos(txtDireccion.Text, "No ingresar caracteres especiales en la descripcion") Then
            txtDireccion.Text = ""
        End If
    End Sub

    Private Sub txtnombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        If validarLetras(txtNombre.Text, "Ingresar solo letras en el nombre") Then
            txtNombre.Text = ""
        End If
    End Sub

    Private Sub txttelefono_TextChanged(sender As Object, e As EventArgs) Handles txtTelefono.TextChanged
        If validarSoloNumeros(txtTelefono.Text, "Ingresar solo numeros en el Telefono") Then
            txtTelefono.Text = ""
        End If
    End Sub
End Class