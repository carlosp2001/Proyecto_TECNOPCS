Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class FrmProveedor
    Private Sub FrmProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Label1.BackColor = Color.Transparent
        Me.Label2.BackColor = Color.Transparent
        Me.Label3.BackColor = Color.Transparent
        Me.Label6.BackColor = Color.Transparent
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try
            'Validacion de nombre
            Dim resultado As Boolean
            resultado = False

            Dim nombre As String
            nombre = txtnombre.Text
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

                End If
                If Not Regex.IsMatch(letra, "^[A-Za-z]") Then
                    MessageBox.Show("No ingresar caracteres especiales en el nombre", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    resultado = True
                    Return

                End If
            Next


            'Validacion de Direccion
            Dim direccion As String = txtdireccion.Text
            If Len(direccion) < 10 Or Len(direccion) > 30 Then
                MessageBox.Show("El largo de la direccion no es el correcto", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                resultado = True
            End If
            For Each letra In direccion
                If Not Regex.IsMatch(letra, "^[A-Za-z0-9\s]") Then
                    MessageBox.Show("No ingresar caracteres especiales en la direccion", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    resultado = True
                    Exit For

                End If
            Next


            If Mid(txtdireccion.Text, 1, 1) = " " Or Mid(txtnombre.Text, 1, 1) = " " Then
                MessageBox.Show("Espacios en blanco no son validos", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                resultado = True
            End If

            If txtnombre.Text <> String.Empty And txtdireccion.Text <> String.Empty And resultado = False Then
                conectar.Open()
                Dim cmd As SqlCommand = New SqlCommand("exec PA_INSERTAR_PROVEEDOR @nombre, @direccion", conectar)
                cmd.Parameters.AddWithValue("@nombre", txtnombre.Text)
                cmd.Parameters.AddWithValue("@direccion", txtdireccion.Text)
                cmd.ExecuteNonQuery()
                conectar.Close()
                LlenarTablaQuery("select idproveedor as 'Id Proveedor', nombreproveedor as 'Nombre Proveedor', direccion as 'Direccion'
from proveedor", FrmdataC.datagridviewdatos)
                BorrarTextBoxForm(Me)
                MessageBox.Show("Datos Registrados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else

                MessageBox.Show("Verifique los datos", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            nombre = txtnombre.Text
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

                End If
                If Not Regex.IsMatch(letra, "^[A-Za-z]") Then
                    MessageBox.Show("No ingresar caracteres especiales en el nombre", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    resultado = True
                    Return

                End If
            Next


            'Validacion de Direccion
            Dim direccion As String = txtdireccion.Text
            If Len(direccion) < 10 Or Len(direccion) > 30 Then
                MessageBox.Show("El largo de la direccion no es el correcto", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                resultado = True
            End If
            For Each letra In direccion
                If Not Regex.IsMatch(letra, "^[A-Za-z0-9\s]") Then
                    MessageBox.Show("No ingresar caracteres especiales en la direccion", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    resultado = True
                    Exit For

                End If
            Next

            If Mid(txtdireccion.Text, 1, 1) = " " Or Mid(txtnombre.Text, 1, 1) = " " Then
                MessageBox.Show("Espacios en blanco no son validos", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                resultado = True
            End If

            If txtnombre.Text <> String.Empty And txtdireccion.Text <> String.Empty And resultado = False Then
                conectar.Open()
                Dim cmd As SqlCommand = New SqlCommand("exec PA_ACTUALIZAR_PROVEEDOR @idproveedor, @nombre, @direccion", conectar)
                cmd.Parameters.AddWithValue("@idproveedor", txtid.Text)
                cmd.Parameters.AddWithValue("@nombre", txtnombre.Text)
                cmd.Parameters.AddWithValue("@direccion", txtdireccion.Text)
                cmd.ExecuteNonQuery()
                conectar.Close()

                LlenarTablaQuery("select idproveedor as 'Id Proveedor', nombreproveedor as 'Nombre Proveedor', direccion as 'Direccion'
from proveedor", FrmdataC.datagridviewdatos)
                BorrarTextBoxForm(Me)
                MessageBox.Show("Datos Registrados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()

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