﻿Imports System.Data.SqlClient
Public Class Frmpago
    Private Sub txtpagodeempleado_TextChanged(sender As Object, e As EventArgs) Handles txtpagodeempleado.TextChanged

    End Sub



    Private Sub Frmpago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Label4.BackColor = Color.Transparent
        Me.Label1.BackColor = Color.Transparent
        Me.Label2.BackColor = Color.Transparent
        Me.Label3.BackColor = Color.Transparent
        Me.Label5.BackColor = Color.Transparent

    End Sub

    Private Sub btnaccion_Click(sender As Object, e As EventArgs) Handles btnaccion.Click
        Try
            If Decimal.TryParse(txtpagodeempleado.Text, vbNull) And Integer.TryParse(txtidempleado.Text, vbNull) Then
                conectar.Open()
                Dim cmd As SqlCommand = New SqlCommand("exec PA_INSERTAR_PAGOEMPLEADOS @idempleado,@pagoempleado, @fechapago", conectar)
                cmd.Parameters.AddWithValue("@idempleado", txtidempleado.Text)
                cmd.Parameters.AddWithValue("@pagoempleado", txtpago.Text)
                cmd.Parameters.AddWithValue("@fechapago", DateTimePicker1.Value)
                cmd.ExecuteNonQuery()
                conectar.Close()
                MessageBox.Show("Datos Registrados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BorrarTextBoxForm(Me)
                LlenarTabla("pagoempleados", FrmdataC.datagridviewdatos)
            Else

                MessageBox.Show("Ingrese los datos marcados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception

        End Try



    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            If Decimal.TryParse(txtpagodeempleado.Text, vbNull) And Integer.TryParse(txtidempleado.Text, vbNull) Then
                conectar.Open()
                Dim cmd As SqlCommand = New SqlCommand("exec PA_ACTUALIZAR_PAGOEMPLEADOS  @idpago, @idempleado,@pagoempleado, @fechapago", conectar)
                cmd.Parameters.AddWithValue("@idpago", txtpago.Text)
                cmd.Parameters.AddWithValue("@idempleado", txtidempleado.Text)
                cmd.Parameters.AddWithValue("@pagoempleado", txtpago.Text)
                cmd.Parameters.AddWithValue("@fechapago", DateTimePicker1.Value)
                cmd.ExecuteNonQuery()
                conectar.Close()
                LlenarTabla("pagoempleados", FrmdataC.datagridviewdatos)
                MessageBox.Show("Datos Registrados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BorrarTextBoxForm(Me)
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