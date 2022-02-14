Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Frmproductos
    Private Sub Frmproductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Label1.BackColor = Color.Transparent
        Me.Label2.BackColor = Color.Transparent
        Me.Label3.BackColor = Color.Transparent
        Me.Label4.BackColor = Color.Transparent
        Me.Label5.BackColor = Color.Transparent
        Me.Label6.BackColor = Color.Transparent
        Me.Label7.BackColor = Color.Transparent
        Me.Label8.BackColor = Color.Transparent
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try
            'Validacion de nombre
            Dim resultado As Boolean
            resultado = False

            Dim nombre As String
            nombre = txtnombreproducto.Text
            Dim letra As Char
            If Len(nombre) < 2 Or Len(nombre) > 30 Then
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

            Next
            'Validacion Precio
            Dim precio As String = txtprecio.Text
            If precio < 1 Then
                resultado = True
                MessageBox.Show("El precio debe ser mayor a 1", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
            'Validacion Marca
            Dim marca As String = txtMarca.Text
            If Len(marca) < 2 Or Len(marca) > 25 Then
                MessageBox.Show("El largo del nombre no es el correcto", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                resultado = True
            End If

            For Each letra In marca
                If Regex.IsMatch(letra, "^[0-9]") Then
                    MessageBox.Show("No ingresar numeros en la marca", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    resultado = True
                    Exit For

                End If
            Next

            'Validacion descripcion
            Dim descripcion As String = txtdesc.Text
            If Len(descripcion) < 5 Or Len(descripcion) > 40 Then
                MessageBox.Show("El largo de la descripcion no es el correcto", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                resultado = True
            End If

            For Each letra In descripcion
                If Regex.IsMatch(letra, "^[0-9]") Then
                    MessageBox.Show("No ingresar numeros en la marca", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    resultado = True
                    Exit For

                End If
            Next






            If txtnombreproducto.Text <> String.Empty And Decimal.TryParse(txtprecio.Text, vbNull) And txtMarca.Text <> String.Empty And
                txtdesc.Text <> String.Empty And ComboBox1.Text <> String.Empty And resultado = False Then
                conectar.Open()
                Dim cmd As SqlCommand = New SqlCommand("exec PA_INSERTAR_PRODUCTO @nombre, @precio, @marca, @descripcion, @cantidad, @idproveedor", conectar)
                cmd.Parameters.AddWithValue("@nombre", txtnombreproducto.Text)
                cmd.Parameters.AddWithValue("@precio", txtprecio.Text)
                cmd.Parameters.AddWithValue("@marca", txtMarca.Text)
                cmd.Parameters.AddWithValue("@descripcion", txtdesc.Text)
                cmd.Parameters.AddWithValue("@cantidad", NumericUpDown1.Value)
                cmd.Parameters.AddWithValue("@idproveedor", ComboBox1.SelectedValue)
                cmd.ExecuteNonQuery()
                conectar.Close()
                LlenarTabla("producto", FrmdataC.datagridviewdatos)
                BorrarTextBoxForm(Me)
                MessageBox.Show("Datos Registrados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else

                MessageBox.Show("Ingrese los datos marcados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            'Validacion de nombre
            Dim resultado As Boolean
            resultado = False

            Dim nombre As String
            nombre = txtnombreproducto.Text
            Dim letra As Char
            If Len(nombre) < 2 Or Len(nombre) > 30 Then
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

            Next
            'Validacion Precio
            Dim precio As String = txtprecio.Text
            If precio < 1 Then
                resultado = True
                MessageBox.Show("El precio debe ser mayor a 1", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
            'Validacion Marca
            Dim marca As String = txtMarca.Text
            If Len(marca) < 2 Or Len(marca) > 25 Then
                MessageBox.Show("El largo del nombre no es el correcto", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                resultado = True
            End If

            For Each letra In marca
                If Regex.IsMatch(letra, "^[0-9]") Then
                    MessageBox.Show("No ingresar numeros en la marca", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    resultado = True
                    Exit For

                End If
            Next

            'Validacion descripcion
            Dim descripcion As String = txtdesc.Text
            If Len(descripcion) < 5 Or Len(descripcion) > 40 Then
                MessageBox.Show("El largo de la descripcion no es el correcto", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                resultado = True
            End If

            For Each letra In descripcion
                If Regex.IsMatch(letra, "^[0-9]") Then
                    MessageBox.Show("No ingresar numeros en la marca", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    resultado = True
                    Exit For

                End If
            Next
            If txtnombreproducto.Text <> String.Empty And Decimal.TryParse(txtprecio.Text, vbNull) And txtMarca.Text <> String.Empty And
                txtdesc.Text <> String.Empty And ComboBox1.Text <> String.Empty And resultado = False Then
                conectar.Open()
                Dim cmd As SqlCommand = New SqlCommand("exec PA_ACTUALIZAR_PRODUCTO @idproducto, @nombre, @precio, @marca, @descripcion, @cantidad, @idproveedor", conectar)
                cmd.Parameters.AddWithValue("@idproducto", txtidproducto.Text)
                cmd.Parameters.AddWithValue("@nombre", txtnombreproducto.Text)
                cmd.Parameters.AddWithValue("@precio", txtprecio.Text)
                cmd.Parameters.AddWithValue("@marca", txtMarca.Text)
                cmd.Parameters.AddWithValue("@descripcion", txtdesc.Text)
                cmd.Parameters.AddWithValue("@cantidad", NumericUpDown1.Value)
                cmd.Parameters.AddWithValue("@idproveedor", ComboBox1.SelectedValue)
                cmd.ExecuteNonQuery()
                conectar.Close()
                LlenarTabla("producto", FrmdataC.datagridviewdatos)
                BorrarTextBoxForm(Me)
                MessageBox.Show("Datos Registrados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else

                MessageBox.Show("Ingrese los datos marcados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception

        End Try



    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Me.Close()

    End Sub
End Class