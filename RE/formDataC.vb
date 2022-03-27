Imports System.Data.SqlClient
Public Class formDataC
    Dim formulario As String
    Public Sub FrmdataC(tipoform As String)
        formulario = tipoform
    End Sub
    Private Sub FrmdataC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formMenu.Hide()
    End Sub


    'Insertar en base de datos
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        If formulario = "ventas" Then
            conectar.Open()
            Dim recuperar1 As SqlDataReader
            Dim ejecutar1 As New SqlCommand
            ejecutar1 = New SqlCommand("select max(idventa) from venta", conectar)
            recuperar1 = ejecutar1.ExecuteReader()
            Dim max As Integer
            If (recuperar1.Read() = True) Then
                Try
                    max = Val(recuperar1(0))
                Catch ex As Exception
                    max = 0
                End Try
            Else

            End If
            formVenta.txtIdVenta.Text = max + 1.ToString()
            recuperar1.Close()
            conectar.Close()
            formVenta.btnAccion.Text = "Guardar"
            formVenta.btnAccion.Visible = True
            formVenta.btnEditar.Visible = False
            formVenta.Show()

            'Habilitar textbox
            formVenta.txtIdVenta.Enabled = False
            formVenta.txtIdEmpleado.Enabled = False
            formVenta.txtidcliente.Enabled = False
            formVenta.txtCantidad.Enabled = True
            formVenta.btnBuscarEmpleado.Visible = True
            formVenta.btnBuscarCliente.Visible = True
            formVenta.btnAgregar.Visible = True
            formVenta.btnSeleccionar.Visible = True

            formVenta.DataGridView1.Enabled = True
            formVenta.datagridviewselect.Visible = False
            formVenta.DataGridView1.Visible = True

        ElseIf formulario = "cliente" Then
            formClientes.btnGuardar.Visible = True
            formClientes.btnGuardar.Text = "Agregar"
            formClientes.btnEditar.Visible = False
            formClientes.dtpFechaRegistro.Enabled = False

            'Habilitar Textbox
            formClientes.txtidcliente.ReadOnly = True
            formClientes.txtNombre.Enabled = True
            formClientes.txtTelefono.Enabled = True
            formClientes.dtpFechaRegistro.Enabled = False
            formClientes.txtDireccion.Enabled = True
            formClientes.txtEmail.Enabled = True
            formClientes.gbxSexo.Enabled = True
            formClientes.dtpFechaNacimiento.Enabled = True


            formClientes.Show()
        ElseIf formulario = "proveedor" Then
            formProveedor.btnGuardar.Visible = True
            formProveedor.btnEditar.Visible = False
            formProveedor.btnGuardar.Text = "Agregar"

            'Habilitar textbox 
            formProveedor.txtId.Enabled = False
            formProveedor.txtNombre.Enabled = True
            formProveedor.txtDireccion.Enabled = True




            formProveedor.Show()
        ElseIf formulario = "producto" Then

            formProductos.btnGuardar.Visible = True
            formProductos.btnEditar.Visible = False
            formProductos.btnGuardar.Text = "Agregar"
            Dim comboxstring As String = "select idproveedor,nombreproveedor from proveedor"
            formProductos.cbxProveedor.DisplayMember = "nombreproveedor"
            formProductos.cbxProveedor.ValueMember = "idproveedor"
            LlenarTComboBox(comboxstring, formProductos.cbxProveedor)

            'Habilitar textbox
            formProductos.txIdProducto.Enabled = False
            formProductos.txtNombreProducto.Enabled = True
            formProductos.txtPrecio.Enabled = True
            formProductos.txtMarca.Enabled = True
            formProductos.txtDescripcion.Enabled = True
            formProductos.nudCantidad.Enabled = True
            formProductos.cbxProveedor.Enabled = True

            formProductos.Show()

        ElseIf formulario = "empleado" Then
            formEmpleados.btnGuardar.Visible = True
            formEmpleados.btnEditar.Visible = False

            'Habiltiar textbox

            formEmpleados.txtId.Enabled = False
            formEmpleados.txtNombre.Enabled = True
            formEmpleados.txtTelefono.Enabled = True
            formEmpleados.dtpFechaNacimiento.Enabled = True
            formEmpleados.txtEmail.Enabled = True
            formEmpleados.txtDireccion.Enabled = True
            formEmpleados.btnGuardar.Text = "Guardar"
            formEmpleados.gbxSexo.Enabled = True
            formEmpleados.Show()


        ElseIf formulario = "pagoempleados" Then
            formPago.btnEditar.Visible = False
            formPago.btnGuardar.Visible = True
            formPago.btnGuardar.Text = "Guardar"

            'Habilitar textbox

            formPago.txtPago.Enabled = False
            formPago.txtIdEmpleado.Enabled = False
            formPago.txtPagoEmpleado.Enabled = True
            formPago.dtpFechaPago.Enabled = False
            formPago.btnBuscarEmpleado.Visible = True
            formPago.Show()


        ElseIf formulario = "historialsoporte" Then

            formHST.Label8.Visible = False
            formHST.btnEditar.Visible = False
            formHST.btnAccion.Text = "Guardar"
            formHST.btnAgregar.Visible = False
            formHST.btnAccion.Visible = True
            formHST.grbDetalle.Visible = False
            formHST.Size = New Size(929, 398)
            'Habilitar textbox
            formHST.gbxEstado.Visible = False
            formHST.txIdSoporte.ReadOnly = True
            formHST.txtIdEmpleado.ReadOnly = False
            formHST.dtpFecha.Enabled = False
            formHST.dtpFecha.Value = DateAndTime.Today
            formHST.btnBuscarProducto.Visible = True
            formHST.btnBuscarEmpleado.Visible = True
            formHST.btnBuscarCliente.Visible = True
            formHST.btnBuscarVenta.Visible = True
            formHST.btnAgregar.Visible = False
            formHST.txtProductoId.ReadOnly = False
            formHST.txtDescripcion.ReadOnly = False
            formHST.txtIdCliente.ReadOnly = False
            formHST.txtIdVenta.ReadOnly = False
            formHST.gbxExistencia.Enabled = True
            formHST.gbxEstado.Enabled = True
            formHST.Show()
        End If
    End Sub


    'Mostrar de base de datos
    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Try
            If formulario = "ventas" Then


                formVenta.btnAccion.Visible = False
                formVenta.btnEditar.Visible = False
                formVenta.btnBuscarEmpleado.Visible = False
                formVenta.btnBuscarCliente.Visible = False
                formVenta.btnAgregar.Visible = False
                formVenta.btnSeleccionar.Visible = False
                formVenta.txtIdVenta.Text = dataGridViewDatos.CurrentRow.Cells(0).Value
                formVenta.txtIdEmpleado.Text = dataGridViewDatos.CurrentRow.Cells(1).Value
                formVenta.txtidcliente.Text = dataGridViewDatos.CurrentRow.Cells(2).Value


                'Inhabilitar text box
                formVenta.txtIdVenta.Enabled = False
                formVenta.txtIdEmpleado.Enabled = False
                formVenta.txtidcliente.Enabled = False
                formVenta.txtCantidad.Enabled = False

                formVenta.DataGridView1.Enabled = False
                formVenta.datagridviewselect.Visible = True
                formVenta.DataGridView1.Visible = False

                LlenarTablaQuery(("select * from detallesventas where idventa=" & formVenta.txtIdVenta.Text), formVenta.datagridviewselect)
                formVenta.Show()


            ElseIf formulario = "cliente" Then
                formClientes.btnGuardar.Visible = False
                formClientes.btnEditar.Visible = False
                formClientes.txtidcliente.Text = dataGridViewDatos.CurrentRow.Cells(0).Value
                formClientes.txtNombre.Text = dataGridViewDatos.CurrentRow.Cells(1).Value
                formClientes.txtTelefono.Text = dataGridViewDatos.CurrentRow.Cells(2).Value
                formClientes.dtpFechaRegistro.Value = dataGridViewDatos.CurrentRow.Cells(3).Value
                formClientes.txtDireccion.Text = dataGridViewDatos.CurrentRow.Cells(4).Value
                formClientes.txtEmail.Text = dataGridViewDatos.CurrentRow.Cells(5).Value
                If dataGridViewDatos.CurrentRow.Cells(6).Value = 1 Then
                    formClientes.rdbMujer.Checked = True
                Else
                    formClientes.rdbHombre.Checked = True
                End If
                formClientes.dtpFechaNacimiento.Value = dataGridViewDatos.CurrentRow.Cells(7).Value
                'Inhabilitar textbox
                formClientes.txtidcliente.Enabled = False
                formClientes.txtNombre.Enabled = False
                formClientes.txtTelefono.Enabled = False
                formClientes.dtpFechaRegistro.Enabled = False
                formClientes.txtDireccion.Enabled = False
                formClientes.txtEmail.Enabled = False
                formClientes.gbxSexo.Enabled = False
                formClientes.dtpFechaNacimiento.Enabled = False

                formClientes.Show()



            ElseIf formulario = "proveedor" Then
                formProveedor.btnGuardar.Visible = False
                formProveedor.btnEditar.Visible = False
                formProveedor.txtId.Text = dataGridViewDatos.CurrentRow.Cells(0).Value
                formProveedor.txtNombre.Text = dataGridViewDatos.CurrentRow.Cells(1).Value
                formProveedor.txtDireccion.Text = dataGridViewDatos.CurrentRow.Cells(2).Value



                'Inhabilitar text box
                formProveedor.txtId.Enabled = False
                formProveedor.txtNombre.Enabled = False
                formProveedor.txtDireccion.Enabled = False

                formProveedor.Show()


            ElseIf formulario = "producto" Then
                formProductos.btnGuardar.Visible = False
                formProductos.btnEditar.Visible = False
                formProductos.txIdProducto.Text = dataGridViewDatos.CurrentRow.Cells(0).Value
                formProductos.txtNombreProducto.Text = dataGridViewDatos.CurrentRow.Cells(1).Value
                formProductos.txtPrecio.Text = dataGridViewDatos.CurrentRow.Cells(2).Value
                formProductos.txtMarca.Text = dataGridViewDatos.CurrentRow.Cells(3).Value
                formProductos.txtDescripcion.Text = dataGridViewDatos.CurrentRow.Cells(4).Value
                formProductos.nudCantidad.Value = dataGridViewDatos.CurrentRow.Cells(5).Value
                Dim comboxstring As String = "select idproveedor,nombreproveedor from proveedor where idproveedor= " & dataGridViewDatos.CurrentRow.Cells(6).Value
                formProductos.cbxProveedor.DisplayMember = "nombreproveedor"
                formProductos.cbxProveedor.ValueMember = "idproveedor"
                LlenarTComboBox(comboxstring, formProductos.cbxProveedor)

                'Inhabilitar textbox
                formProductos.txIdProducto.Enabled = False
                formProductos.txtNombreProducto.Enabled = False
                formProductos.txtPrecio.Enabled = False
                formProductos.txtMarca.Enabled = False
                formProductos.txtDescripcion.Enabled = False
                formProductos.nudCantidad.Enabled = False
                formProductos.cbxProveedor.Enabled = False

                formProductos.Show()


            ElseIf formulario = "empleado" Then
                formEmpleados.btnGuardar.Visible = False
                formEmpleados.btnEditar.Visible = False
                formEmpleados.txtId.Text = dataGridViewDatos.CurrentRow.Cells(0).Value
                formEmpleados.txtNombre.Text = dataGridViewDatos.CurrentRow.Cells(1).Value
                formEmpleados.txtTelefono.Text = dataGridViewDatos.CurrentRow.Cells(2).Value
                formEmpleados.dtpFechaNacimiento.Value = dataGridViewDatos.CurrentRow.Cells(3).Value
                formEmpleados.txtEmail.Text = dataGridViewDatos.CurrentRow.Cells(4).Value
                formEmpleados.txtDireccion.Text = dataGridViewDatos.CurrentRow.Cells(5).Value
                If dataGridViewDatos.CurrentRow.Cells(6).Value = 1 Then
                    formEmpleados.rdbMujer.Checked = True
                Else
                    formEmpleados.rdbHombre.Checked = True
                End If

                'Inhabiltiar textbox

                formEmpleados.txtId.Enabled = False
                formEmpleados.txtNombre.Enabled = False
                formEmpleados.txtTelefono.Enabled = False
                formEmpleados.dtpFechaNacimiento.Enabled = False
                formEmpleados.txtEmail.Enabled = False
                formEmpleados.txtDireccion.Enabled = False
                formEmpleados.gbxSexo.Enabled = False
                formEmpleados.Show()


            ElseIf formulario = "pagoempleados" Then
                formPago.btnEditar.Visible = False
                formPago.btnGuardar.Visible = False
                formPago.txtPago.Text = dataGridViewDatos.CurrentRow.Cells(0).Value
                formPago.txtIdEmpleado.Text = dataGridViewDatos.CurrentRow.Cells(1).Value
                formPago.txtPagoEmpleado.Text = dataGridViewDatos.CurrentRow.Cells(2).Value
                formPago.dtpFechaPago.Value = dataGridViewDatos.CurrentRow.Cells(3).Value

                'Inhabilitar textbox
                formPago.btnBuscarEmpleado.Visible = False
                formPago.txtPago.Enabled = False
                formPago.txtIdEmpleado.Enabled = False
                formPago.txtPagoEmpleado.Enabled = False
                formPago.dtpFechaPago.Enabled = False

                formPago.Show()
            ElseIf formulario = "historialsoporte" Then
                formHST.grbDetalle.Visible = False
                formHST.Size = New Size(929, 717)
                formHST.Label8.Visible = True
                formHST.gbxEstado.Visible = True
                formHST.btnAccion.Visible = False
                formHST.btnEditar.Visible = False
                formHST.txIdSoporte.Text = dataGridViewDatos.CurrentRow.Cells(0).Value
                formHST.txtIdEmpleado.Text = dataGridViewDatos.CurrentRow.Cells(1).Value
                formHST.dtpFecha.Value = dataGridViewDatos.CurrentRow.Cells(3).Value
                formHST.txtProductoId.Text = dataGridViewDatos.CurrentRow.Cells(4).Value
                formHST.txtDescripcion.Text = dataGridViewDatos.CurrentRow.Cells(6).Value
                formHST.txtIdCliente.Text = dataGridViewDatos.CurrentRow.Cells(7).Value
                If dataGridViewDatos.CurrentRow.Cells(9).Value = 1 Then
                    formHST.rbReparacion.Checked = True
                ElseIf dataGridViewDatos.CurrentRow.Cells(9).Value = 2 Then
                    formHST.rbEntregado.Checked = True
                Else
                    formHST.rbNoReparado.Checked = True
                End If
                formHST.txtIdVenta.Text = dataGridViewDatos.CurrentRow.Cells(10).Value

                'Inhabiltar textbox

                formHST.txIdSoporte.Enabled = False
                formHST.txtIdEmpleado.Enabled = False
                formHST.dtpFecha.Enabled = False
                formHST.txtProductoId.Enabled = False
                formHST.txtDescripcion.Enabled = False
                formHST.txtIdCliente.Enabled = False
                formHST.gbxExistencia.Enabled = False
                formHST.gbxEstado.Enabled = False
                formHST.txtIdVenta.Enabled = False
                formHST.btnBuscarProducto.Visible = False
                formHST.btnBuscarEmpleado.Visible = False
                formHST.btnBuscarCliente.Visible = False
                formHST.btnBuscarVenta.Visible = False
                formHST.btnAgregar.Visible = False

                formHST.Show()
                LlenarTablaQuery(("select * from detalleSoporte where idSoporte=" & dataGridViewDatos.CurrentRow.Cells(0).Value), formHST.dgvHistorialDetalle)
            End If
        Catch ex As Exception
            MessageBox.Show("Seleccione un registro de la tabla", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub


    'Eliminar de base de datos
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If formulario = "ventas" Then
                conectar.Open()
                Dim cmd1 As SqlCommand = New SqlCommand("delete from detallesventas where idventa = @idventa", conectar)
                cmd1.Parameters.AddWithValue("@idventa", dataGridViewDatos.CurrentRow.Cells(0).Value)
                cmd1.ExecuteNonQuery()
                Dim cmd As SqlCommand = New SqlCommand("exec PA_ELIMINAR_VENTA @id", conectar)
                cmd.Parameters.AddWithValue("@id", dataGridViewDatos.CurrentRow.Cells(0).Value)
                cmd.ExecuteNonQuery()
                conectar.Close()
                LlenarTablaQuery("select idventa as 'Id de Venta', idempleado as 'Id del Empleado', idcliente as 'Id del Cliente', 
                subtotal as 'Subtotal'
                from venta", dataGridViewDatos)

            ElseIf formulario = "cliente" Then
                conectar.Open()
                Dim cmd As SqlCommand = New SqlCommand("exec PA_ELIMINAR_CLIENTE @id", conectar)
                cmd.Parameters.AddWithValue("@id", dataGridViewDatos.CurrentRow.Cells(0).Value)
                cmd.ExecuteNonQuery()
                conectar.Close()
                LlenarTablaQuery("select idCliente as 'Identificador', nombreCliente as 'Nombre Completo',
            telefonoCliente as 'Telefono', fechaRegistro as 'Fecha de registro', direccionCliente as 'Direccion', email as 'Email',
            genero as 'Genero', fechaNacimiento as 'Fecha de Nacimiento' from cliente", dataGridViewDatos)

            ElseIf formulario = "proveedor" Then
                conectar.Open()
                Dim cmd As SqlCommand = New SqlCommand("exec PA_ELIMINAR_PROVEEDOR @id", conectar)
                cmd.Parameters.AddWithValue("@id", dataGridViewDatos.CurrentRow.Cells(0).Value)
                cmd.ExecuteNonQuery()
                conectar.Close()
                LlenarTablaQuery("select idproveedor as 'Id Proveedor', nombreproveedor as 'Nombre Proveedor', direccion as 'Direccion'
                from proveedor", dataGridViewDatos)

            ElseIf formulario = "producto" Then
                conectar.Open()
                Dim cmd As SqlCommand = New SqlCommand("exec PA_ELIMINAR_PRODUCTO @id", conectar)
                cmd.Parameters.AddWithValue("@id", dataGridViewDatos.CurrentRow.Cells(0).Value)
                cmd.ExecuteNonQuery()
                conectar.Close()
                LlenarTablaQuery("select idproducto as 'Id del Producto', nombreproducto as 'Nombre del Producto', precioCompra as
                'Precio', marca as 'Marca', descripcion as 'Descripcion', cantidaddisponible as 'Cantidad Disponible',
                idproveedor as 'Id del Proveedor'
                from producto", dataGridViewDatos)

            ElseIf formulario = "empleado" Then
                conectar.Open()
                Dim cmd As SqlCommand = New SqlCommand("exec PA_ELIMINAR_EMPLEADO @id", conectar)
                cmd.Parameters.AddWithValue("@id", dataGridViewDatos.CurrentRow.Cells(0).Value)
                cmd.ExecuteNonQuery()
                conectar.Close()
                LlenarTablaQuery("select idEmpleado as 'Id del Empleado', nombreEmpleado as 'Nombre Completo', telefonoEmpleado as
                'Telefono', fechaNacimiento as 'Fecha de Nacimiento', email as 'Email', direccion as 'Direccion',
                genero as 'Genero'
                from empleado", dataGridViewDatos)

            ElseIf formulario = "pagoempleados" Then
                conectar.Open()
                Dim cmd As SqlCommand = New SqlCommand("exec PA_ELIMINAR_PAGOEMPLEADOS @id", conectar)
                cmd.Parameters.AddWithValue("@id", dataGridViewDatos.CurrentRow.Cells(0).Value)
                cmd.ExecuteNonQuery()
                conectar.Close()
                LlenarTablaQuery("select idPago as 'Id de pago', idEmpleado as 'Id del Empleado', pagoempleado as 'Monto de Pago',
                fechapago as 'Fecha del Pago'
                from pagoempleados", dataGridViewDatos)

            ElseIf formulario = "historialsoporte" Then
                conectar.Open()
                Dim cmd As SqlCommand = New SqlCommand("exec PA_ELIMINAR_HISTORIALSOPORTE @id", conectar)
                cmd.Parameters.AddWithValue("@id", dataGridViewDatos.CurrentRow.Cells(0).Value)
                cmd.ExecuteNonQuery()
                conectar.Close()
                LlenarTablaQuery("exec SELECT_HISTORIALSOPORTETABLA", dataGridViewDatos)
            End If
        Catch ex As Exception
            conectar.Close()
            MessageBox.Show("Seleccione un registro de la tabla o verifique que el dato no tenga ninguna dependencia", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try


    End Sub

    'Editar de base de datos
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            If formulario = "ventas" Then
                formVenta.btnAccion.Visible = False
                formVenta.btnEditar.Visible = True
                formVenta.btnAccion.Visible = False
                formVenta.txtIdVenta.Text = dataGridViewDatos.CurrentRow.Cells(0).Value
                formVenta.txtIdEmpleado.Text = dataGridViewDatos.CurrentRow.Cells(1).Value
                formVenta.txtidcliente.Text = dataGridViewDatos.CurrentRow.Cells(2).Value

                formVenta.datagridviewselect.Visible = True
                formVenta.DataGridView1.Visible = False
                LlenarTablaQuery(("select * from detallesventas where idventa=" & formVenta.txtIdVenta.Text), formVenta.datagridviewselect)

                'Habilitar textbox
                formVenta.txtIdVenta.Enabled = False
                formVenta.txtIdEmpleado.Enabled = False
                formVenta.txtidcliente.Enabled = False
                formVenta.txtCantidad.Enabled = True
                formVenta.btnBuscarEmpleado.Visible = True
                formVenta.btnBuscarCliente.Visible = True
                formVenta.btnAgregar.Visible = True
                formVenta.btnSeleccionar.Visible = True
                formVenta.DataGridView1.Enabled = True

                formVenta.Show()

            ElseIf formulario = "cliente" Then
                formClientes.btnGuardar.Visible = False
                formClientes.btnEditar.Visible = True
                formClientes.txtidcliente.Text = dataGridViewDatos.CurrentRow.Cells(0).Value
                formClientes.txtNombre.Text = dataGridViewDatos.CurrentRow.Cells(1).Value
                formClientes.txtTelefono.Text = dataGridViewDatos.CurrentRow.Cells(2).Value
                formClientes.dtpFechaRegistro.Value = dataGridViewDatos.CurrentRow.Cells(3).Value
                formClientes.txtDireccion.Text = dataGridViewDatos.CurrentRow.Cells(4).Value
                formClientes.txtEmail.Text = dataGridViewDatos.CurrentRow.Cells(5).Value
                If dataGridViewDatos.CurrentRow.Cells(6).Value = 1 Then
                    formClientes.rdbMujer.Checked = True
                Else
                    formClientes.rdbHombre.Checked = True
                End If
                formClientes.dtpFechaNacimiento.Value = dataGridViewDatos.CurrentRow.Cells(7).Value
                'Habilitar Textbox
                formClientes.txtidcliente.Enabled = False
                formClientes.txtNombre.Enabled = True
                formClientes.txtTelefono.Enabled = True
                formClientes.dtpFechaRegistro.Enabled = True
                formClientes.txtDireccion.Enabled = True
                formClientes.txtEmail.Enabled = True
                formClientes.gbxSexo.Enabled = True
                formClientes.dtpFechaNacimiento.Enabled = True
                formClientes.Show()

            ElseIf formulario = "proveedor" Then
                formProveedor.btnEditar.Visible = True
                formProveedor.btnGuardar.Visible = False
                formProveedor.txtId.Text = dataGridViewDatos.CurrentRow.Cells(0).Value
                formProveedor.txtNombre.Text = dataGridViewDatos.CurrentRow.Cells(1).Value
                formProveedor.txtDireccion.Text = dataGridViewDatos.CurrentRow.Cells(2).Value

                'Habilitar textbox 
                formProveedor.txtId.Enabled = False
                formProveedor.txtNombre.Enabled = True
                formProveedor.txtDireccion.Enabled = True
                formProveedor.Show()

            ElseIf formulario = "producto" Then
                formProductos.btnGuardar.Visible = False
                formProductos.btnEditar.Visible = True
                formProductos.txIdProducto.Text = dataGridViewDatos.CurrentRow.Cells(0).Value
                formProductos.txtNombreProducto.Text = dataGridViewDatos.CurrentRow.Cells(1).Value
                formProductos.txtPrecio.Text = dataGridViewDatos.CurrentRow.Cells(2).Value
                formProductos.txtMarca.Text = dataGridViewDatos.CurrentRow.Cells(3).Value
                formProductos.txtDescripcion.Text = dataGridViewDatos.CurrentRow.Cells(4).Value
                formProductos.nudCantidad.Value = dataGridViewDatos.CurrentRow.Cells(5).Value
                Dim comboxstring As String = "select idproveedor,nombreproveedor from proveedor"
                formProductos.cbxProveedor.DisplayMember = "nombreproveedor"
                formProductos.cbxProveedor.ValueMember = "idproveedor"
                LlenarTComboBox(comboxstring, formProductos.cbxProveedor)
                formProductos.cbxProveedor.SelectedValue = dataGridViewDatos.CurrentRow.Cells(6).Value

                'Habilitar textbox
                formProductos.txIdProducto.Enabled = False
                formProductos.txtNombreProducto.Enabled = True
                formProductos.txtPrecio.Enabled = True
                formProductos.txtMarca.Enabled = True
                formProductos.txtDescripcion.Enabled = True
                formProductos.nudCantidad.Enabled = True
                formProductos.cbxProveedor.Enabled = True

                formProductos.Show()

            ElseIf formulario = "empleado" Then
                formEmpleados.btnEditar.Visible = True
                formEmpleados.Label8.Visible = False
                formEmpleados.btnGuardar.Visible = False

                formEmpleados.txtId.Text = dataGridViewDatos.CurrentRow.Cells(0).Value
                formEmpleados.txtNombre.Text = dataGridViewDatos.CurrentRow.Cells(1).Value
                formEmpleados.txtTelefono.Text = dataGridViewDatos.CurrentRow.Cells(2).Value
                formEmpleados.dtpFechaNacimiento.Value = dataGridViewDatos.CurrentRow.Cells(3).Value
                formEmpleados.txtEmail.Text = dataGridViewDatos.CurrentRow.Cells(4).Value
                formEmpleados.txtDireccion.Text = dataGridViewDatos.CurrentRow.Cells(5).Value
                If dataGridViewDatos.CurrentRow.Cells(6).Value = 1 Then
                    formEmpleados.rdbMujer.Checked = True
                Else
                    formEmpleados.rdbHombre.Checked = True
                End If

                'Habiltiar textbox

                formEmpleados.txtId.Enabled = False
                formEmpleados.txtNombre.Enabled = True
                formEmpleados.txtTelefono.Enabled = True
                formEmpleados.dtpFechaNacimiento.Enabled = True
                formEmpleados.txtEmail.Enabled = True
                formEmpleados.txtDireccion.Enabled = True
                formEmpleados.gbxSexo.Enabled = True
                formEmpleados.btnGuardar.Text = "Guardar"


                formEmpleados.Show()

            ElseIf formulario = "pagoempleados" Then
                formPago.btnEditar.Visible = True
                formPago.btnGuardar.Visible = False
                formPago.txtPago.Text = dataGridViewDatos.CurrentRow.Cells(0).Value
                formPago.txtIdEmpleado.Text = dataGridViewDatos.CurrentRow.Cells(1).Value
                formPago.txtPagoEmpleado.Text = dataGridViewDatos.CurrentRow.Cells(2).Value
                formPago.dtpFechaPago.Value = dataGridViewDatos.CurrentRow.Cells(3).Value

                'Habilitar textbox
                formPago.btnBuscarEmpleado.Visible = True
                formPago.txtPago.Enabled = False
                formPago.txtIdEmpleado.Enabled = False
                formPago.txtPagoEmpleado.Enabled = True
                formPago.dtpFechaPago.Enabled = False

                formPago.Show()

            ElseIf formulario = "historialsoporte" Then
                formHST.grbDetalle.Visible = True
                formHST.Size = New Size(929, 717)
                formHST.Label8.Visible = True
                formHST.gbxEstado.Visible = True
                formHST.btnEditar.Visible = True
                formHST.btnAccion.Visible = False
                formHST.txIdSoporte.Text = dataGridViewDatos.CurrentRow.Cells(0).Value
                formHST.txtIdEmpleado.Text = dataGridViewDatos.CurrentRow.Cells(1).Value
                formHST.dtpFecha.Value = dataGridViewDatos.CurrentRow.Cells(3).Value
                formHST.txtProductoId.Text = dataGridViewDatos.CurrentRow.Cells(4).Value
                formHST.txtDescripcion.Text = dataGridViewDatos.CurrentRow.Cells(6).Value
                formHST.txtIdCliente.Text = dataGridViewDatos.CurrentRow.Cells(7).Value
                If dataGridViewDatos.CurrentRow.Cells(9).Value = 1 Then
                    formHST.rbReparacion.Checked = True
                ElseIf dataGridViewDatos.CurrentRow.Cells(9).Value = 2 Then
                    formHST.rbEntregado.Checked = True
                Else
                    formHST.rbNoReparado.Checked = True
                End If
                formHST.txtIdVenta.Text = dataGridViewDatos.CurrentRow.Cells(10).Value
                'Habilitar textbox
                formHST.txIdSoporte.ReadOnly = True
                formHST.txtIdEmpleado.ReadOnly = False
                formHST.dtpFecha.Enabled = False
                formHST.txtProductoId.ReadOnly = False
                formHST.txtDescripcion.ReadOnly = False
                formHST.txtIdCliente.ReadOnly = False
                formHST.txtIdVenta.ReadOnly = False
                formHST.gbxExistencia.Enabled = True
                formHST.gbxEstado.Enabled = True
                formHST.btnAgregar.Visible = True
                formHST.btnBuscarProducto.Visible = True
                formHST.btnBuscarEmpleado.Visible = True
                formHST.btnBuscarCliente.Visible = True
                formHST.btnBuscarVenta.Visible = True

                formHST.Show()
                LlenarTablaQuery(("select * from detalleSoporte where idSoporte=" & dataGridViewDatos.CurrentRow.Cells(0).Value), formHST.dgvHistorialDetalle)
            End If
        Catch ex As Exception
            MessageBox.Show("Seleccione un registro de la tabla", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try


    End Sub

    Private Sub FrmdataC_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        formMenu.Show()

    End Sub


End Class