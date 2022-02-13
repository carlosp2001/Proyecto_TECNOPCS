Imports System.Data.SqlClient

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
            If txtnombreproducto.Text <> String.Empty And Decimal.TryParse(txtprecio.Text, vbNull) And txtMarca.Text <> String.Empty And
                txtdesc.Text <> String.Empty And ComboBox1.Text <> String.Empty Then
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
            If txtnombreproducto.Text <> String.Empty And Decimal.TryParse(txtprecio.Text, vbNull) And txtMarca.Text <> String.Empty And
                txtdesc.Text <> String.Empty And ComboBox1.Text <> String.Empty Then
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