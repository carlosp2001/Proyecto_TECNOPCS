Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class formVenta

    Private Function validaciones()
        If validarVacio(txtidcliente.Text, "El id del Cliente no puede estar vacio") Then
            Return False
        End If
        If validarVacio(txtIdEmpleado.Text, "El id del Empleado no puede estar vacio") Then
            Return False
        End If

        Return True


    End Function

    Public Function validacionesCompra()
        If validarVacio(txtIdProducto.Text, "El id del Producto no puede estar vacio") Then
            Return False
        End If

        If validarVacio(txtPrecio.Text, "El precio no puede estar vacio") Then
            Return False
        End If
        If validarLargoyEmptyNumero(1, 99999, "Verifique la cantidad a ingresar", txtCantidad.Text) Then
            Return False
        End If
        Return True
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        If validacionesCompra() Then
            Dim precio, cantidad, subtotal, cantidaddisponible As Integer
            cantidad = Val(txtCantidad.Text)
            conectar.Open()
            Dim consulta As String = "select cantidaddisponible from producto where idproducto=" & txtIdProducto.Text
            Dim recuperar As SqlDataReader
            Dim ejecutar As New SqlCommand
            ejecutar = New SqlCommand(consulta, conectar)
            recuperar = ejecutar.ExecuteReader()
            If (recuperar.Read() = True) Then

                cantidaddisponible = Val(recuperar(0))
            Else

                System.Console.WriteLine("No se encontro ese producto")
            End If

            If cantidaddisponible > cantidad Then
                DataGridView1.Rows.Add(txtIdProducto.Text, txtCantidad.Text, (Val(txtCantidad.Text) * Val(txtPrecio.Text)), txtPrecio.Text)
            Else
                MessageBox.Show("La cantidad de producto que quiere comprar no esta disponible", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End If
            conectar.Close()


        Else
            MessageBox.Show("Verifique los datos a ingresar", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If



    End Sub

    Private Sub btnseleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        selectproducto.Show()
    End Sub

    Private Sub btnaccion_Click(sender As Object, e As EventArgs) Handles btnAccion.Click

        If validaciones() Then
            Dim subtotal As Decimal
            subtotal = 0
            conectar.Open()

            Dim registros As DataGridViewRow = New DataGridViewRow()

            'Calcular el subtotal

            For Each registros In DataGridView1.Rows
                subtotal = subtotal + registros.Cells("subtotal").Value
            Next


            'Ingresar venta
            Dim cmd As SqlCommand = New SqlCommand("exec PA_INSERTAR_VENTA @idventa,@idempleado,@idcliente, @subtotal, @isv, @descuento", conectar)
            cmd.Parameters.AddWithValue("@idventa", txtIdVenta.Text)
            cmd.Parameters.AddWithValue("@idempleado", txtIdEmpleado.Text)
            cmd.Parameters.AddWithValue("@idcliente", txtidcliente.Text)
            cmd.Parameters.AddWithValue("@subtotal", subtotal)
            cmd.Parameters.AddWithValue("@isv", (subtotal - txtDescuento.Text) * 0.15)
            cmd.Parameters.AddWithValue("@descuento", txtDescuento.Text)
            cmd.ExecuteNonQuery()

            For Each registros In DataGridView1.Rows
                Dim insertard As String = "exec PA_INSERTAR_DETALLESVENTAS @idventa, @idproducto, @cantidad, @subtotal, @precio"
                Dim insertar_detalle = New SqlCommand(insertard, conectar)
                insertar_detalle.Parameters.Clear()
                insertar_detalle.Parameters.AddWithValue("@idventa", txtIdVenta.Text)
                insertar_detalle.Parameters.AddWithValue("@idproducto", registros.Cells("idproducto").Value)
                insertar_detalle.Parameters.AddWithValue("@precio", registros.Cells("Precio").Value)
                insertar_detalle.Parameters.AddWithValue("@cantidad", registros.Cells("cantidad").Value)
                insertar_detalle.Parameters.AddWithValue("@subtotal", registros.Cells("subtotal").Value)
                insertar_detalle.ExecuteNonQuery()

                Dim consulta As String = "select cantidaddisponible from producto where idproducto=" & registros.Cells("idproducto").Value
                Dim recuperar1 As SqlDataReader
                Dim ejecutar1 As New SqlCommand
                ejecutar1 = New SqlCommand(consulta, conectar)
                recuperar1 = ejecutar1.ExecuteReader()
                Dim stock As Integer
                If (recuperar1.Read() = True) Then
                    stock = Val(recuperar1(0))
                Else
                    System.Console.WriteLine("No encontrado")
                End If
                recuperar1.Close()

                stock = stock - Val(registros.Cells("cantidad").Value)


                Dim actualizar1 As String = "update producto set cantidaddisponible=@stock where idproducto=@codproducto"
                Dim ejactualizar1 As New SqlCommand(actualizar1, conectar)
                ejactualizar1.Parameters.Clear()
                ejactualizar1.Parameters.AddWithValue("@codproducto", registros.Cells("idproducto").Value)
                ejactualizar1.Parameters.AddWithValue("@stock", stock)
                ejactualizar1.ExecuteNonQuery()


            Next


            conectar.Close()
            FormGenerarFacturacion.Show()

            LlenarTablaQuery("select idventa as 'Id de Venta', idempleado as 'Id del Empleado', idcliente as 'Id del Cliente', 
            subtotal as 'Subtotal'
            from venta", formDataC.dataGridViewDatos)
            BorrarTextBoxForm(Me)

            MessageBox.Show("Datos Registrados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Verifique los datos a ingresar", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If validaciones() Then
            conectar.Open()

            Dim cmd As SqlCommand = New SqlCommand("exec PA_ACTUALIZAR_VENTA @idventa, @idempleado,@idcliente, @subtotal", conectar)
            cmd.Parameters.AddWithValue("@idventa", txtIdVenta.Text)
            cmd.Parameters.AddWithValue("@idempleado", txtIdEmpleado.Text)
            cmd.Parameters.AddWithValue("@idcliente", txtidcliente.Text)
            cmd.Parameters.AddWithValue("@subtotal", txtsubtotal.Text)
            cmd.ExecuteNonQuery()

            conectar.Close()
            LlenarTablaQuery("select idventa as 'Id de Venta', idempleado as 'Id del Empleado', idcliente as 'Id del Cliente', 
                subtotal as 'Subtotal'
                from venta", formDataC.dataGridViewDatos)

            MessageBox.Show("Datos Registrados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Verifique los datos a ingresar", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If




    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnBuscarEmpleado.Click
        selectempleado.selectempleado("ventas")
        selectempleado.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        selectcliente.Show()
    End Sub

    Private Sub txtcantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        If validarSoloNumeros(txtCantidad.Text, "Solo ingresar numeros en la cantidad") Then
            txtCantidad.Text = ""
        End If
    End Sub

    Private Sub txtsubtotal_TextChanged(sender As Object, e As EventArgs) Handles txtsubtotal.TextChanged
        If validarSoloNumeros(txtDescuento.Text, "Solo ingresar numeros en el descuento") Then
            txtDescuento.Text = ""
        End If
    End Sub
End Class