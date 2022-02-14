Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class Form1
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Label1.BackColor = Color.Transparent
        Me.Label2.BackColor = Color.Transparent
        Me.Label3.BackColor = Color.Transparent
        Me.Label4.BackColor = Color.Transparent
        Me.Label5.BackColor = Color.Transparent
        Me.Label6.BackColor = Color.Transparent
        Me.Label7.BackColor = Color.Transparent
        Me.Label9.BackColor = Color.Transparent

        Me.GroupBox1.BackColor = Color.Transparent
        Me.Label11.BackColor = Color.Transparent

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            'Validacion de TxtNombre
            Dim resultado As Boolean
            resultado = False

            Dim nombre As String
            nombre = txtnombre.Text
            Dim letra As Char
            If Len(nombre) < 5 Or Len(nombre) > 40 Then
                MessageBox.Show("El largo del nombre no es el correcto", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                resultado = True
            End If
            For Each letra In nombre
                If (IsNumeric(letra) = True) Then
                    MessageBox.Show("El nombre ingresado es incorrecto", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    resultado = True
                    Return

                End If
                If letra = " " Then



                    resultado = True
                    Continue For

                Else


                End If
                If Not Regex.IsMatch(letra, "^[A-Za-z]") Then
                    MessageBox.Show("No ingresar caracteres especiales en el nombre", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    resultado = True
                    Exit For

                End If
            Next





            'Validacion de correo
            If Len(txtemail.Text) < 10 Or Len(nombre) > 30 Then
                MessageBox.Show("El largo del correo no es el correcto", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                resultado = True
            End If
            For Each letra In txtemail.Text
                If letra = "@" Then
                    resultado = False
                    Exit For
                Else
                    resultado = True
                End If
            Next
            If resultado = True Then
                MessageBox.Show("El correo debe contener @", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            'Validacion Direccion
            Dim direccion As String = txtdesc.Text
            If Len(direccion) < 10 Or Len(direccion) > 40 Then
                MessageBox.Show("El largo de la direccion no es el correcto", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                resultado = True
            End If
            For Each letra In direccion
                If Not Regex.IsMatch(letra, "^[A-Za-z0-9\s]") Then
                    MessageBox.Show("No ingresar caracteres especiales en la direccion", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    resultado = True
                    Return

                End If
            Next


            'Validacion de telefono
            Dim telefono As String = txttelefono.Text
            If Len(telefono) <> 8 Then
                MessageBox.Show("El largo del numero telefonico no es el correcto", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                resultado = True
            End If
            If RadioButton1.Checked = False And RadioButton2.Checked = False Then
                resultado = True
                MessageBox.Show("No ha seleccionado ninguna opcion", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            'Validacion de Edad
            If DateAndTime.Today.Year - DateTimePicker1.Value.Year < 18 Then
                Console.WriteLine(DateAndTime.Today.Year - DateTimePicker1.Value.Year)
                resultado = True
                MessageBox.Show("No cumples con los requisitos de edad", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            If Mid(txtnombre.Text, 1, 1) = " " Or Mid(txttelefono.Text, 1, 1) = " " Or Mid(txtdesc.Text, 1, 1) = " " Or Mid(txtemail.Text, 1, 1) = " " Then
                MessageBox.Show("Espacios en blanco no son validos", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                resultado = True
            End If

            If Me.ValidateChildren And txtnombre.Text <> String.Empty And Int(txttelefono.Text) And txtdesc.Text <> String.Empty And txtemail.Text <> String.Empty And resultado = False Then
                conectar.Open()
                Dim genero As Integer
                If RadioButton1.Checked = True Then
                    genero = 2
                Else
                    genero = 1
                End If
                Dim cmd As SqlCommand = New SqlCommand("exec PA_INSERTAR_EMPLEADO @nombre, @telefono, @fechanacimiento, @email, @genero, @direccion", conectar)
                cmd.Parameters.AddWithValue("@nombre", txtnombre.Text)
                cmd.Parameters.AddWithValue("@telefono", txttelefono.Text)
                cmd.Parameters.AddWithValue("@fechanacimiento", DateTimePicker1.Value)
                cmd.Parameters.AddWithValue("@email", txtemail.Text)
                cmd.Parameters.AddWithValue("@genero", genero)
                cmd.Parameters.AddWithValue("@direccion", txtdesc.Text)
                cmd.ExecuteNonQuery()

                conectar.Close()
                LlenarTabla("empleado", FrmdataC.datagridviewdatos)
                BorrarTextBoxForm(Me)
                MessageBox.Show("Datos Registrados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Verifique los datos solicitados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            'Validacion de TxtNombre
            Dim resultado As Boolean
            resultado = False

            Dim nombre As String
            nombre = txtnombre.Text
            Dim letra As Char
            If Len(nombre) < 5 Or Len(nombre) > 40 Then
                MessageBox.Show("El largo del nombre no es el correcto", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                resultado = True
            End If
            For Each letra In nombre
                If (IsNumeric(letra) = True) Then
                    MessageBox.Show("El nombre ingresado es incorrecto", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    resultado = True
                    Return

                End If
                If letra = " " Then



                    resultado = True
                    Continue For

                Else


                End If
                If Not Regex.IsMatch(letra, "^[A-Za-z]") Then
                    MessageBox.Show("No ingresar caracteres especiales en el nombre", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    resultado = True
                    Return

                End If
            Next

            'Validacion de Edad
            If DateAndTime.Today.Year - DateTimePicker1.Value.Year < 18 Then
                Console.WriteLine(DateAndTime.Today.Year - DateTimePicker1.Value.Year)
                resultado = True
                MessageBox.Show("No cumples con los requisitos de edad", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            'Validacion de correo
            If Len(txtemail.Text) < 10 Or Len(nombre) > 30 Then
                MessageBox.Show("El largo del correo no es el correcto", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                resultado = True
            End If
            For Each letra In txtemail.Text
                If letra = "@" Then
                    resultado = False
                    Exit For
                Else
                    resultado = True
                End If
            Next
            If resultado = True Then
                MessageBox.Show("El correo debe contener @", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            'Validacion Direccion
            Dim direccion As String = txtdesc.Text
            If Len(direccion) < 10 Or Len(direccion) > 40 Then
                MessageBox.Show("El largo de la direccion no es el correcto", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                resultado = True
            End If
            For Each letra In direccion
                If Not Regex.IsMatch(letra, "^[A-Za-z0-9\s]") Then
                    MessageBox.Show("No ingresar caracteres especiales en la direccion", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    resultado = True
                    Return

                End If
            Next


            'Validacion de telefono
            Dim telefono As String = txttelefono.Text
            If Len(telefono) <> 8 Then
                MessageBox.Show("El largo del numero telefonico no es el correcto", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                resultado = True
            End If
            If RadioButton1.Checked = False And RadioButton2.Checked = False Then
                resultado = True
                MessageBox.Show("No ha seleccionado ninguna opcion", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


            'Validacion de Edad
            If DateAndTime.Today.Year - DateTimePicker1.Value.Year < 18 Then
                Console.WriteLine(DateAndTime.Today.Year - DateTimePicker1.Value.Year)
                resultado = True
                MessageBox.Show("No cumples con los requisitos de edad", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            If Mid(txtnombre.Text, 1, 1) = " " Or Mid(txttelefono.Text, 1, 1) = " " Or Mid(txtdesc.Text, 1, 1) = " " Or Mid(txtemail.Text, 1, 1) = " " Then
                MessageBox.Show("Espacios en blanco no son validos", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                resultado = True
            End If

            If Me.ValidateChildren And txtnombre.Text <> String.Empty And Int(txttelefono.Text) And txtdesc.Text <> String.Empty And txtemail.Text <> String.Empty And resultado = False Then
                conectar.Open()
                Dim genero As Integer
                If RadioButton1.Checked = True Then
                    genero = 2
                Else
                    genero = 1
                End If
                Dim cmd As SqlCommand = New SqlCommand("exec PA_ACTUALIZAR_EMPLEADO @idempleado, @nombre, @telefono, @fechanacimiento, @email, @genero, @direccion", conectar)
                cmd.Parameters.AddWithValue("@idempleado", txtid.Text)
                cmd.Parameters.AddWithValue("@nombre", txtnombre.Text)
                cmd.Parameters.AddWithValue("@telefono", txttelefono.Text)
                cmd.Parameters.AddWithValue("@fechanacimiento", DateTimePicker1.Value)
                cmd.Parameters.AddWithValue("@email", txtemail.Text)
                cmd.Parameters.AddWithValue("@genero", genero)
                cmd.Parameters.AddWithValue("@direccion", txtdesc.Text)
                cmd.ExecuteNonQuery()
                conectar.Close()
                LlenarTabla("empleado", FrmdataC.datagridviewdatos)
                BorrarTextBoxForm(Me)
                MessageBox.Show("Datos Registrados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()

            Else
                MessageBox.Show("Ingrese los datos marcados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtdesc_TextChanged(sender As Object, e As EventArgs) Handles txtdesc.TextChanged

    End Sub
End Class
