Imports System.Data.SqlClient
Public Class FrmProveedor
    Private Sub FrmProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Label1.BackColor = Color.Transparent
        Me.Label2.BackColor = Color.Transparent
        Me.Label3.BackColor = Color.Transparent
        Me.Label6.BackColor = Color.Transparent
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try
            If txtnombre.Text <> String.Empty And txtdireccion.Text <> String.Empty Then
                conectar.Open()
                Dim cmd As SqlCommand = New SqlCommand("exec PA_INSERTAR_PROVEEDOR @nombre, @direccion", conectar)
                cmd.Parameters.AddWithValue("@nombre", txtnombre.Text)
                cmd.Parameters.AddWithValue("@direccion", txtdireccion.Text)
                cmd.ExecuteNonQuery()
                conectar.Close()
                LlenarTabla("proveedor", FrmdataC.datagridviewdatos)
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
            If txtnombre.Text <> String.Empty And txtdireccion.Text <> String.Empty Then
                conectar.Open()
                Dim cmd As SqlCommand = New SqlCommand("exec PA_ACTUALIZAR_PROVEEDOR @idproveedor, @nombre, @direccion", conectar)
                cmd.Parameters.AddWithValue("@idproveedor", txtid.Text)
                cmd.Parameters.AddWithValue("@nombre", txtnombre.Text)
                cmd.Parameters.AddWithValue("@direccion", txtdireccion.Text)
                cmd.ExecuteNonQuery()
                conectar.Close()

                LlenarTabla("proveedor", FrmdataC.datagridviewdatos)
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