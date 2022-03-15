Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Frmproductos

    Private Function validaciones()
        If validarLargoyEmpty(2, 30, "El largo del nombre no es el correcto o hay espacios en blanco", txtNombreProducto.Text) Then
            Return False
        End If
        If validarLargoyEmptyNumero(1, 99999, "El precio del producto no es correcto", txtPrecio.Text) Then
            Return False
        End If
        If validarLargoyEmpty(2, 25, "El largo de la marca no es el correcto o hay espacios en blanco", txtMarca.Text) Then
            Return False
        End If
        If validarLargoyEmpty(5, 40, "El largo de la descripcion no es el correcto o hay espacios en blanco", txtDescripcion.Text) Then
            Return False
        End If

        If validarVacio("El Proveedor no puede estar vacio", cbxProveedor.Text) Then
            Return False
        End If
        Return True
    End Function
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If validaciones() Then
            conectar.Open()
            Dim cmd As SqlCommand = New SqlCommand("exec PA_INSERTAR_PRODUCTO @nombre, @precio, @marca, @descripcion, @cantidad, @idproveedor", conectar)
            cmd.Parameters.AddWithValue("@nombre", txtNombreProducto.Text)
            cmd.Parameters.AddWithValue("@precio", txtPrecio.Text)
            cmd.Parameters.AddWithValue("@marca", txtMarca.Text)
            cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text)
            cmd.Parameters.AddWithValue("@cantidad", nudCantidad.Value)
            cmd.Parameters.AddWithValue("@idproveedor", cbxProveedor.SelectedValue)
            cmd.ExecuteNonQuery()
            conectar.Close()
            LlenarTablaQuery("select idproducto as 'Id del Producto', nombreproducto as 'Nombre del Producto', precioproducto as
            'Precio', marca as 'Marca', descripcion as 'Descripcion', cantidaddisponible as 'Cantidad Disponible',
            idproveedor as 'Id del Proveedor'
            from producto", FrmdataC.datagridviewdatos)
            BorrarTextBoxForm(Me)
            MessageBox.Show("Datos Registrados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else

            MessageBox.Show("Verifique los datos a ingresar", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If



    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click


        If validaciones() Then
            conectar.Open()
            Dim cmd As SqlCommand = New SqlCommand("exec PA_ACTUALIZAR_PRODUCTO @idproducto, @nombre, @precio, @marca, @descripcion, @cantidad, @idproveedor", conectar)
            cmd.Parameters.AddWithValue("@idproducto", txtidproducto.Text)
            cmd.Parameters.AddWithValue("@nombre", txtNombreProducto.Text)
            cmd.Parameters.AddWithValue("@precio", txtPrecio.Text)
            cmd.Parameters.AddWithValue("@marca", txtMarca.Text)
            cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text)
            cmd.Parameters.AddWithValue("@cantidad", nudCantidad.Value)
            cmd.Parameters.AddWithValue("@idproveedor", cbxProveedor.SelectedValue)
            cmd.ExecuteNonQuery()
            conectar.Close()
            LlenarTablaQuery("select idproducto as 'Id del Producto', nombreproducto as 'Nombre del Producto', precioproducto as
            'Precio', marca as 'Marca', descripcion as 'Descripcion', cantidaddisponible as 'Cantidad Disponible',
            idproveedor as 'Id del Proveedor'
            from producto", FrmdataC.datagridviewdatos)
            BorrarTextBoxForm(Me)
            MessageBox.Show("Datos Registrados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Else

            MessageBox.Show("Verifique los datos a ingresar", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If




    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Me.Close()

    End Sub

    Private Sub txtnombreproducto_TextChanged(sender As Object, e As EventArgs) Handles txtNombreProducto.TextChanged
        If validarAlfanumericos(txtNombreProducto.Text, "El campo de nombre no puede contener caracteres especiales") Then
            txtNombreProducto.Text = ""
        End If
    End Sub

    Private Sub txtPrecio_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged
        If Not Mid(txtPrecio.Text, 1, 1) = "" Then
            If validarDecimals(txtPrecio.Text) Then
                txtPrecio.Text = ""
            End If
        End If
    End Sub




End Class