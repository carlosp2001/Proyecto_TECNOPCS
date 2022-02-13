Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class Clientes
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ValidarCampos()

    End Sub

    Private Sub btnAccion_Click(sender As Object, e As EventArgs) Handles btnAccion.Click
        'Dim letra As Char

        'For Each letra In txtnombre.Text

        '    If (letra = " ") Then

        '        MessageBox.Show("")
        '    Else
        '        Try
        '            If Me.ValidateChildren And txtnombre.Text <> String.Empty And Int(txttelefono.Text) And txtdesc.Text <> String.Empty Then
        '                conectar.Open()
        '                Dim cmd As SqlCommand = New SqlCommand("exec PA_ACTUALIZAR_CLIENTE @idcliente, @nombre, @telefono, @fecha, @direccion", conectar)
        '                cmd.Parameters.AddWithValue("@idcliente", txtidcliente.Text)
        '                cmd.Parameters.AddWithValue("@nombre", txtnombre.Text)
        '                cmd.Parameters.AddWithValue("@telefono", txttelefono.Text)
        '                cmd.Parameters.AddWithValue("@fecha", Dtpfecha.Value)
        '                cmd.Parameters.AddWithValue("@direccion", txtdesc.Text)
        '                cmd.ExecuteNonQuery()
        '    Catch ex As Exception
        '        End Try





        Try
            'Validacion de TxtNombre
            Dim resultado As Boolean
            resultado = False
            Dim resultadonumero As Boolean
            resultadonumero = False
            Dim nombre As String
            nombre = txtnombre.Text
            Dim letra As Char
            For Each letra In nombre
                If (IsNumeric(letra) = True) Then
                    MessageBox.Show("El nombre ingresado es incorrecto", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    resultadonumero = True
                    Return

                End If

                If letra = " " Then



                    resultado = True
                    Continue For

                Else


                End If
                If Not Regex.IsMatch(letra, "^[A-Za-z]") Then
                    MessageBox.Show("No ingresar caracteres especiales en el nombre", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    resultadonumero = True
                    Return

                End If
            Next








            If txtnombre.Text <> String.Empty And Integer.TryParse(txttelefono.Text, vbNull) And txtdesc.Text <> String.Empty And resultadonumero = False And resultado = True Then

                conectar.Open()
                Dim cmd As SqlCommand = New SqlCommand("exec PA_INSERTAR_CLIENTE @nombre, @telefono, @fecha, @direccion", conectar)
                cmd.Parameters.AddWithValue("@nombre", txtnombre.Text)
                cmd.Parameters.AddWithValue("@telefono", txttelefono.Text)
                cmd.Parameters.AddWithValue("@fecha", Dtpfecha.Value)
                cmd.Parameters.AddWithValue("@direccion", txtdesc.Text)
                cmd.ExecuteNonQuery()
                conectar.Close()
                LlenarTabla("cliente", FrmdataC.datagridviewdatos)
                MessageBox.Show("Datos Registrados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BorrarTextBoxForm(Me)


            Else
                MessageBox.Show("Verifique los datos solicitados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception

        End Try



    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            If Me.ValidateChildren And txtnombre.Text <> String.Empty And Int(txttelefono.Text) And txtdesc.Text <> String.Empty Then
                conectar.Open()
                Dim cmd As SqlCommand = New SqlCommand("exec PA_ACTUALIZAR_CLIENTE @idcliente, @nombre, @telefono, @fecha, @direccion", conectar)
                cmd.Parameters.AddWithValue("@idcliente", txtidcliente.Text)
                cmd.Parameters.AddWithValue("@nombre", txtnombre.Text)
                cmd.Parameters.AddWithValue("@telefono", txttelefono.Text)
                cmd.Parameters.AddWithValue("@fecha", Dtpfecha.Value)
                cmd.Parameters.AddWithValue("@direccion", txtdesc.Text)
                cmd.ExecuteNonQuery()
                conectar.Close()
                LlenarTabla("cliente", FrmdataC.datagridviewdatos)
                BorrarTextBoxForm(Me)
                MessageBox.Show("Datos Registrados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Ingrese los datos marcados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()

    End Sub




End Class