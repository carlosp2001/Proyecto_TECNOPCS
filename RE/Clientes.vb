Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Clientes

    Private Function validaciones()
        If validarLargoyEmpty(5, 40, "El largo del nombre no es el correcto o hay espacios en blanco", txtnombre.Text) Then
            Return False
        End If
        If validarLargoyEmpty(10, 40, "EL largo de la direccion no es el correcto o hay espacios en blanoco", txtdesc.Text) Then
            Return False
        End If

        If validarLargoyEmpty(8, 8, "EL largo del telefono no es el correcto o hay espacios en blanoco", txttelefono.Text) Then
            Return False
        End If
        Return True
    End Function

    Private Sub btnAccion_Click(sender As Object, e As EventArgs) Handles btnAccion.Click
        Dtpfecha.Value = DateAndTime.Today

        If validaciones() Then
            conectar.Open()
            Dim cmd As SqlCommand = New SqlCommand("exec PA_INSERTAR_CLIENTE @nombre, @telefono, @fecha, @direccion", conectar)
            cmd.Parameters.AddWithValue("@nombre", txtnombre.Text)
            cmd.Parameters.AddWithValue("@telefono", txttelefono.Text)
            cmd.Parameters.AddWithValue("@fecha", Dtpfecha.Value)
            cmd.Parameters.AddWithValue("@direccion", txtdesc.Text)
            cmd.ExecuteNonQuery()
            conectar.Close()
            LlenarTablaQuery("select idcliente as 'Identificador', nombrecliente as 'Nombre Completo',
                telefono_cliente as 'Telefono', fecharegistro as 'Fecha de registro', direccioncliente as 'Direccion' from cliente", FrmdataC.datagridviewdatos)
            MessageBox.Show("Datos Registrados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BorrarTextBoxForm(Me)

        Else
            MessageBox.Show("Verifique los datos a ingresar", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click



        If validaciones() Then
            conectar.Open()
            Dim cmd As SqlCommand = New SqlCommand("exec PA_ACTUALIZAR_CLIENTE @idcliente, @nombre, @telefono, @fecha, @direccion", conectar)
            cmd.Parameters.AddWithValue("@idcliente", txtidcliente.Text)
            cmd.Parameters.AddWithValue("@nombre", txtnombre.Text)
            cmd.Parameters.AddWithValue("@telefono", txttelefono.Text)
            cmd.Parameters.AddWithValue("@fecha", Dtpfecha.Value)
            cmd.Parameters.AddWithValue("@direccion", txtdesc.Text)
            cmd.ExecuteNonQuery()
            conectar.Close()
            LlenarTablaQuery("select idcliente as 'Identificador', nombrecliente as 'Nombre Completo',
telefono_cliente as 'Telefono', fecharegistro as 'Fecha de registro', direccioncliente as 'Direccion' from cliente", FrmdataC.datagridviewdatos)
            BorrarTextBoxForm(Me)
            MessageBox.Show("Datos Registrados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Verifique los datos a ingresar", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


    End Sub



    Private Sub txtdesc_TextChanged(sender As Object, e As EventArgs) Handles txtdesc.TextChanged
        If validarAlfanumericos(txtdesc.Text, "No ingresar caracteres especiales en la descripcion") Then
            txtdesc.Text = ""
        End If
    End Sub

    Private Sub txtnombre_TextChanged(sender As Object, e As EventArgs) Handles txtnombre.TextChanged
        If validarLetras(txtnombre.Text, "Ingresar solo letras en el nombre") Then
            txtnombre.Text = ""
        End If
    End Sub

    Private Sub txttelefono_TextChanged(sender As Object, e As EventArgs) Handles txttelefono.TextChanged
        If validarSoloNumeros(txttelefono.Text, "Ingresar solo numeros en el Telefono") Then
            txttelefono.Text = ""
        End If
    End Sub
End Class