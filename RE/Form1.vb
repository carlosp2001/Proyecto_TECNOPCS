Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class Form1
    Private Function validarCampos()
        'Validar largo nombre
        If validarLargoyEmpty(5, 40, "El largo del nombre es incorrecto o dejo espacios en blanco", txtNombre.Text) Then
            Return False
        End If

        'Validar largo correo
        If validarLargoyEmpty(10, 30, "El largo de el correo no es correcto o dejo espacios en blanco", txtEmail.Text) Then
            Return False
        End If

        'Validar direccion
        If validarLargoyEmpty(10, 40, "El largo de la direccion no es correcto o dejo espacios en blanco", txtDireccion.Text) Then
            Return False
        End If
        'Validar telefono
        If validarLargoyEmpty(8, 8, "El largo del telefono es incorrecto o dejo espacios en blanco", txtTelefono.Text) Then
            Return False
        End If
        'Validar Edad
        If validarEdad(dtpFechaNacimiento) Then
            Return False
        End If

        'Validar Radio Button
        If validarRadioButton(rdbHombre, rdbMujer) Then
            Return False
        End If

        Return True
    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If Me.ValidateChildren And validarCampos() Then
            conectar.Open()
            Dim genero As Integer
            If rdbHombre.Checked = True Then
                genero = 2
            Else
                genero = 1
            End If
            Dim cmd As SqlCommand = New SqlCommand("exec PA_INSERTAR_EMPLEADO @nombre, @telefono, @fechanacimiento, @email, @genero, @direccion", conectar)
            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text)
            cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text)
            cmd.Parameters.AddWithValue("@fechanacimiento", dtpFechaNacimiento.Value)
            cmd.Parameters.AddWithValue("@email", txtEmail.Text)
            cmd.Parameters.AddWithValue("@genero", genero)
            cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text)
            cmd.ExecuteNonQuery()

            conectar.Close()
            LlenarTablaQuery("select idempleado as 'Id del Empleado', nombreempleado as 'Nombre Completo', telefono_empleado as
            'Telefono', fechanacimiento as 'Fecha de Nacimiento', email as 'Email', direccion as 'Direccion',
            genero as 'Genero'
            from empleado", FrmdataC.datagridviewdatos)
            BorrarTextBoxForm(Me)
            MessageBox.Show("Datos Registrados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If



    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        If Me.ValidateChildren And validarCampos() Then
            Dim genero As Integer
            If rdbHombre.Checked = True Then
                genero = 2
            ElseIf rdbMujer.Checked = True Then
                genero = 1
            End If
            conectar.Open()

            Dim cmd As SqlCommand = New SqlCommand("exec PA_ACTUALIZAR_EMPLEADO @idempleado, @nombre, @telefono, @fechanacimiento, @email, @genero, @direccion", conectar)
            cmd.Parameters.AddWithValue("@idempleado", txtId.Text)
            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text)
            cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text)
            cmd.Parameters.AddWithValue("@fechanacimiento", dtpFechaNacimiento.Value)
            cmd.Parameters.AddWithValue("@email", txtEmail.Text)
            cmd.Parameters.AddWithValue("@genero", genero)
            cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text)
            cmd.ExecuteNonQuery()
            conectar.Close()
            LlenarTablaQuery("select idempleado as 'Id del Empleado', nombreempleado as 'Nombre Completo', telefono_empleado as
            'Telefono', fechanacimiento as 'Fecha de Nacimiento', email as 'Email', direccion as 'Direccion',
            genero as 'Genero'
            from empleado", FrmdataC.datagridviewdatos)
            BorrarTextBoxForm(Me)
            MessageBox.Show("Datos Registrados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Else
            MessageBox.Show("Verifique los datos a ingresar", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub


    Private Sub txtdesc_TextChanged(sender As Object, e As EventArgs) Handles txtDireccion.TextChanged
        If validarAlfanumericos(txtDireccion.Text, "No ingrese caracteres especiales en la direccion") Then
            txtDireccion.Text = ""
        End If
    End Sub

    Private Sub txtnombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        If validarLetras(txtNombre.Text, "Solo debe ingresar letras en el nombre") Then
            txtNombre.Text = ""
        End If

    End Sub


    Private Sub txtTelefono_TextChanged(sender As Object, e As EventArgs) Handles txtTelefono.TextChanged
        If validarSoloNumeros(txtTelefono.Text, "Solo debe ingresar numeros en el telefono") Then
            txtTelefono.Text = ""
        End If
    End Sub
End Class
