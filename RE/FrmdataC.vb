Imports System.Data.SqlClient
Public Class FrmdataC
    Dim formulario As String
    Public Sub FrmdataC(tipoform As String)
        formulario = tipoform
    End Sub
    Private Sub FrmdataC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmMENU.Hide()
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
            FrmVenta.txtidventa.Text = max + 1.ToString()
            recuperar1.Close()
            conectar.Close()
            FrmVenta.btnaccion.Text = "Guardar"
            FrmVenta.btnaccion.Visible = True
            FrmVenta.btnEditar.Visible = False
            FrmVenta.Show()

            'Habilitar textbox
            FrmVenta.txtidventa.Enabled = False
            FrmVenta.txtidempleado.Enabled = False
            FrmVenta.txtidcliente.Enabled = False
            FrmVenta.txtcantidad.Enabled = True
            FrmVenta.Button2.Visible = True
            FrmVenta.Button3.Visible = True
            FrmVenta.Button1.Visible = True
            FrmVenta.btnseleccionar.Visible = True

            FrmVenta.DataGridView1.Enabled = True
            FrmVenta.datagridviewselect.Visible = False
            FrmVenta.DataGridView1.Visible = True

        ElseIf formulario = "cliente" Then
            Clientes.btnAccion.Visible = True
            Clientes.btnAccion.Text = "Agregar"
            Clientes.btnEditar.Visible = False
            Clientes.Dtpfecha.Enabled = False

            'Habilitar Textbox
            Clientes.txtidcliente.ReadOnly = True
            Clientes.txtnombre.ReadOnly = False
            Clientes.txttelefono.ReadOnly = False
            Clientes.Dtpfecha.Enabled = False
            Clientes.txtdesc.ReadOnly = False


            Clientes.Show()
        ElseIf formulario = "proveedor" Then
            FrmProveedor.btnguardar.Visible = True
            FrmProveedor.btnEditar.Visible = False
            FrmProveedor.btnguardar.Text = "Agregar"

            'Habilitar textbox 
            FrmProveedor.txtId.Enabled = False
            FrmProveedor.txtNombre.Enabled = True
            FrmProveedor.txtDireccion.Enabled = True




            FrmProveedor.Show()
        ElseIf formulario = "producto" Then

            Frmproductos.btnguardar.Visible = True
            Frmproductos.btnEditar.Visible = False
            Frmproductos.btnguardar.Text = "Agregar"
            Dim comboxstring As String = "select idproveedor,nombreproveedor from proveedor"
            Frmproductos.cbxProveedor.DisplayMember = "nombreproveedor"
            Frmproductos.cbxProveedor.ValueMember = "idproveedor"
            LlenarTComboBox(comboxstring, Frmproductos.cbxProveedor)

            'Habilitar textbox
            Frmproductos.txtidproducto.Enabled = False
            Frmproductos.txtNombreProducto.Enabled = True
            Frmproductos.txtPrecio.Enabled = True
            Frmproductos.txtMarca.Enabled = True
            Frmproductos.txtDescripcion.Enabled = True
            Frmproductos.nudCantidad.Enabled = True
            Frmproductos.cbxProveedor.Enabled = True

            Frmproductos.Show()

        ElseIf formulario = "empleado" Then
            Form1.btnGuardar.Visible = True
            Form1.btnEditar.Visible = False

            'Habiltiar textbox

            Form1.txtId.ReadOnly = True
            Form1.txtNombre.ReadOnly = False
            Form1.txtTelefono.ReadOnly = False
            Form1.dtpFechaNacimiento.Enabled = True
            Form1.txtEmail.ReadOnly = False
            Form1.txtDireccion.ReadOnly = False
            Form1.btnGuardar.Text = "Guardar"
            Form1.Show()


        ElseIf formulario = "pagoempleados" Then
            Frmpago.btnEditar.Visible = False
            Frmpago.btnGuardar.Visible = True
            Frmpago.btnGuardar.Text = "Guardar"

            'Habilitar textbox

            Frmpago.txtPago.Enabled = False
            Frmpago.txtIdEmpleado.Enabled = False
            Frmpago.txtPagoEmpleado.Enabled = True
            Frmpago.dtpFechaPago.Enabled = False
            Frmpago.Button1.Visible = True
            Frmpago.Show()


        ElseIf formulario = "historialsoporte" Then

            FrmHST.Label8.Visible = False
            FrmHST.btnEditar.Visible = False
            FrmHST.btnAccion.Text = "Guardar"
            FrmHST.btnAgregar.Visible = False
            FrmHST.btnAccion.Visible = True

            'Habilitar textbox
            FrmHST.GroupBox2.Visible = False
            FrmHST.txIdSoporte.ReadOnly = True
            FrmHST.txtIdEmpleado.ReadOnly = False
            FrmHST.dtpFecha.Enabled = False
            FrmHST.dtpFecha.Value = DateAndTime.Today
            FrmHST.Button2.Visible = True
            FrmHST.Button3.Visible = True
            FrmHST.Button4.Visible = True
            FrmHST.Button5.Visible = True
            FrmHST.btnAgregar.Visible = False
            FrmHST.txtProductoId.ReadOnly = False
            FrmHST.txtDescripcion.ReadOnly = False
            FrmHST.txtIdCliente.ReadOnly = False
            FrmHST.txtIdVenta.ReadOnly = False
            FrmHST.GroupBox1.Enabled = True
            FrmHST.GroupBox2.Enabled = True
            FrmHST.Show()
        End If
    End Sub


    'Mostrar de base de datos
    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Try
            If formulario = "ventas" Then


                FrmVenta.btnaccion.Visible = False
                FrmVenta.btnEditar.Visible = False
                FrmVenta.Button2.Visible = False
                FrmVenta.Button3.Visible = False
                FrmVenta.Button1.Visible = False
                FrmVenta.btnseleccionar.Visible = False
                FrmVenta.txtidventa.Text = datagridviewdatos.CurrentRow.Cells(0).Value
                FrmVenta.txtidempleado.Text = datagridviewdatos.CurrentRow.Cells(1).Value
                FrmVenta.txtidcliente.Text = datagridviewdatos.CurrentRow.Cells(2).Value


                'Inhabilitar text box
                FrmVenta.txtidventa.Enabled = False
                FrmVenta.txtidempleado.Enabled = False
                FrmVenta.txtidcliente.Enabled = False
                FrmVenta.txtcantidad.Enabled = False

                FrmVenta.DataGridView1.Enabled = False
                FrmVenta.datagridviewselect.Visible = True
                FrmVenta.DataGridView1.Visible = False

                LlenarTablaQuery(("select * from detallesventas where idventa=" & FrmVenta.txtidventa.Text), FrmVenta.datagridviewselect)
                FrmVenta.Show()


            ElseIf formulario = "cliente" Then
                Clientes.btnAccion.Visible = False
                Clientes.btnEditar.Visible = False
                Clientes.txtidcliente.Text = datagridviewdatos.CurrentRow.Cells(0).Value
                Clientes.txtnombre.Text = datagridviewdatos.CurrentRow.Cells(1).Value
                Clientes.txttelefono.Text = datagridviewdatos.CurrentRow.Cells(2).Value
                Clientes.Dtpfecha.Value = datagridviewdatos.CurrentRow.Cells(3).Value
                Clientes.txtdesc.Text = datagridviewdatos.CurrentRow.Cells(4).Value
                'Inhabilitar textbox
                Clientes.txtidcliente.ReadOnly = True
                Clientes.txtnombre.ReadOnly = True
                Clientes.txttelefono.ReadOnly = True
                Clientes.Dtpfecha.Enabled = False
                Clientes.txtdesc.ReadOnly = True

                Clientes.Show()


            ElseIf formulario = "proveedor" Then
                FrmProveedor.btnguardar.Visible = False
                FrmProveedor.btnEditar.Visible = False
                FrmProveedor.txtId.Text = datagridviewdatos.CurrentRow.Cells(0).Value
                FrmProveedor.txtNombre.Text = datagridviewdatos.CurrentRow.Cells(1).Value
                FrmProveedor.txtDireccion.Text = datagridviewdatos.CurrentRow.Cells(2).Value
                FrmProveedor.txtId.Text = datagridviewdatos.CurrentRow.Cells(0).Value
                FrmProveedor.txtNombre.Text = datagridviewdatos.CurrentRow.Cells(1).Value
                FrmProveedor.txtDireccion.Text = datagridviewdatos.CurrentRow.Cells(2).Value

                'Inhabilitar text box
                FrmProveedor.txtId.Enabled = False
                FrmProveedor.txtNombre.Enabled = False
                FrmProveedor.txtDireccion.Enabled = False

                FrmProveedor.Show()


            ElseIf formulario = "producto" Then
                Frmproductos.btnguardar.Visible = False
                Frmproductos.btnEditar.Visible = False
                Frmproductos.txtidproducto.Text = datagridviewdatos.CurrentRow.Cells(0).Value
                Frmproductos.txtNombreProducto.Text = datagridviewdatos.CurrentRow.Cells(1).Value
                Frmproductos.txtPrecio.Text = datagridviewdatos.CurrentRow.Cells(2).Value
                Frmproductos.txtMarca.Text = datagridviewdatos.CurrentRow.Cells(3).Value
                Frmproductos.txtDescripcion.Text = datagridviewdatos.CurrentRow.Cells(4).Value
                Frmproductos.nudCantidad.Value = datagridviewdatos.CurrentRow.Cells(5).Value
                Dim comboxstring As String = "select idproveedor,nombreproveedor from proveedor where idproveedor= " & datagridviewdatos.CurrentRow.Cells(6).Value
                Frmproductos.cbxProveedor.DisplayMember = "nombreproveedor"
                Frmproductos.cbxProveedor.ValueMember = "idproveedor"
                LlenarTComboBox(comboxstring, Frmproductos.cbxProveedor)

                'Inhabilitar textbox
                Frmproductos.txtidproducto.Enabled = False
                Frmproductos.txtNombreProducto.Enabled = False
                Frmproductos.txtPrecio.Enabled = False
                Frmproductos.txtMarca.Enabled = False
                Frmproductos.txtDescripcion.Enabled = False
                Frmproductos.nudCantidad.Enabled = False
                Frmproductos.cbxProveedor.Enabled = False

                Frmproductos.Show()


            ElseIf formulario = "empleado" Then
                Form1.btnGuardar.Visible = False
                Form1.btnEditar.Visible = False
                Form1.txtId.Text = datagridviewdatos.CurrentRow.Cells(0).Value
                Form1.txtNombre.Text = datagridviewdatos.CurrentRow.Cells(1).Value
                Form1.txtTelefono.Text = datagridviewdatos.CurrentRow.Cells(2).Value
                Form1.dtpFechaNacimiento.Value = datagridviewdatos.CurrentRow.Cells(3).Value
                Form1.txtEmail.Text = datagridviewdatos.CurrentRow.Cells(4).Value
                Form1.txtDireccion.Text = datagridviewdatos.CurrentRow.Cells(5).Value
                If datagridviewdatos.CurrentRow.Cells(6).Value = 1 Then
                    Form1.rdbMujer.Checked = True
                Else
                    Form1.rdbHombre.Checked = True
                End If

                'Inhabiltiar textbox

                Form1.txtId.ReadOnly = True
                Form1.txtNombre.ReadOnly = True
                Form1.txtTelefono.ReadOnly = True
                Form1.dtpFechaNacimiento.Enabled = False
                Form1.txtEmail.ReadOnly = True
                Form1.txtDireccion.ReadOnly = True
                Form1.Show()


            ElseIf formulario = "pagoempleados" Then
                Frmpago.btnEditar.Visible = False
                Frmpago.btnGuardar.Visible = False
                Frmpago.txtPago.Text = datagridviewdatos.CurrentRow.Cells(0).Value
                Frmpago.txtIdEmpleado.Text = datagridviewdatos.CurrentRow.Cells(1).Value
                Frmpago.txtPagoEmpleado.Text = datagridviewdatos.CurrentRow.Cells(2).Value
                Frmpago.dtpFechaPago.Value = datagridviewdatos.CurrentRow.Cells(3).Value

                'Inhabilitar textbox
                Frmpago.Button1.Visible = False
                Frmpago.txtPago.Enabled = False
                Frmpago.txtIdEmpleado.Enabled = False
                Frmpago.txtPagoEmpleado.Enabled = False
                Frmpago.dtpFechaPago.Enabled = False

                Frmpago.Show()
            ElseIf formulario = "historialsoporte" Then
                FrmHST.Label8.Visible = True
                FrmHST.GroupBox2.Visible = True
                FrmHST.btnAccion.Visible = False
                FrmHST.btnEditar.Visible = False
                FrmHST.txIdSoporte.Text = datagridviewdatos.CurrentRow.Cells(0).Value
                FrmHST.txtIdEmpleado.Text = datagridviewdatos.CurrentRow.Cells(1).Value
                FrmHST.dtpFecha.Value = datagridviewdatos.CurrentRow.Cells(3).Value
                FrmHST.txtProductoId.Text = datagridviewdatos.CurrentRow.Cells(4).Value
                FrmHST.txtDescripcion.Text = datagridviewdatos.CurrentRow.Cells(6).Value
                FrmHST.txtIdCliente.Text = datagridviewdatos.CurrentRow.Cells(7).Value
                If datagridviewdatos.CurrentRow.Cells(9).Value = 1 Then
                    FrmHST.rbreparacion.Checked = True
                ElseIf datagridviewdatos.CurrentRow.Cells(9).Value = 2 Then
                    FrmHST.rbentregado.Checked = True
                Else
                    FrmHST.rbnoreparado.Checked = True
                End If
                FrmHST.txtIdVenta.Text = datagridviewdatos.CurrentRow.Cells(10).Value

                'Inhabiltar textbox

                FrmHST.txIdSoporte.Enabled = False
                FrmHST.txtIdEmpleado.Enabled = False
                FrmHST.dtpFecha.Enabled = False
                FrmHST.txtProductoId.Enabled = False
                FrmHST.txtDescripcion.Enabled = False
                FrmHST.txtIdCliente.Enabled = False
                FrmHST.GroupBox1.Enabled = False
                FrmHST.GroupBox2.Enabled = False
                FrmHST.txtIdVenta.Enabled = False
                FrmHST.Button2.Visible = False
                FrmHST.Button3.Visible = False
                FrmHST.Button4.Visible = False
                FrmHST.Button5.Visible = False
                FrmHST.btnAgregar.Visible = False

                FrmHST.Show()
                LlenarTablaQuery(("select * from detalle_soporte where idsoporte=" & datagridviewdatos.CurrentRow.Cells(0).Value), FrmHST.DataGridView1)
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
                cmd1.Parameters.AddWithValue("@idventa", datagridviewdatos.CurrentRow.Cells(0).Value)
                cmd1.ExecuteNonQuery()
                Dim cmd As SqlCommand = New SqlCommand("exec PA_ELIMINAR_VENTA @id", conectar)
                cmd.Parameters.AddWithValue("@id", datagridviewdatos.CurrentRow.Cells(0).Value)
                cmd.ExecuteNonQuery()
                conectar.Close()
                LlenarTabla("venta", datagridviewdatos)

            ElseIf formulario = "cliente" Then
                conectar.Open()
                Dim cmd As SqlCommand = New SqlCommand("exec PA_ELIMINAR_CLIENTE @id", conectar)
                cmd.Parameters.AddWithValue("@id", datagridviewdatos.CurrentRow.Cells(0).Value)
                cmd.ExecuteNonQuery()
                conectar.Close()
                LlenarTabla("cliente", datagridviewdatos)

            ElseIf formulario = "proveedor" Then
                conectar.Open()
                Dim cmd As SqlCommand = New SqlCommand("exec PA_ELIMINAR_PROVEEDOR @id", conectar)
                cmd.Parameters.AddWithValue("@id", datagridviewdatos.CurrentRow.Cells(0).Value)
                cmd.ExecuteNonQuery()
                conectar.Close()
                LlenarTabla("proveedor", datagridviewdatos)

            ElseIf formulario = "producto" Then
                conectar.Open()
                Dim cmd As SqlCommand = New SqlCommand("exec PA_ELIMINAR_PRODUCTO @id", conectar)
                cmd.Parameters.AddWithValue("@id", datagridviewdatos.CurrentRow.Cells(0).Value)
                cmd.ExecuteNonQuery()
                conectar.Close()
                LlenarTabla("producto", datagridviewdatos)

            ElseIf formulario = "empleado" Then
                conectar.Open()
                Dim cmd As SqlCommand = New SqlCommand("exec PA_ELIMINAR_EMPLEADO @id", conectar)
                cmd.Parameters.AddWithValue("@id", datagridviewdatos.CurrentRow.Cells(0).Value)
                cmd.ExecuteNonQuery()
                conectar.Close()
                LlenarTabla("empleado", datagridviewdatos)

            ElseIf formulario = "pagoempleados" Then
                conectar.Open()
                Dim cmd As SqlCommand = New SqlCommand("exec PA_ELIMINAR_PAGOEMPLEADOS @id", conectar)
                cmd.Parameters.AddWithValue("@id", datagridviewdatos.CurrentRow.Cells(0).Value)
                cmd.ExecuteNonQuery()
                conectar.Close()
                LlenarTabla("pagoempleados", datagridviewdatos)

            ElseIf formulario = "historialsoporte" Then
                conectar.Open()
                Dim cmd As SqlCommand = New SqlCommand("exec PA_ELIMINAR_HISTORIALSOPORTE @id", conectar)
                cmd.Parameters.AddWithValue("@id", datagridviewdatos.CurrentRow.Cells(0).Value)
                cmd.ExecuteNonQuery()
                conectar.Close()
                LlenarTabla("historialsoporte", datagridviewdatos)
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
                FrmVenta.btnaccion.Visible = False
                FrmVenta.btnEditar.Visible = True
                FrmVenta.btnaccion.Visible = False
                FrmVenta.txtidventa.Text = datagridviewdatos.CurrentRow.Cells(0).Value
                FrmVenta.txtidempleado.Text = datagridviewdatos.CurrentRow.Cells(1).Value
                FrmVenta.txtidcliente.Text = datagridviewdatos.CurrentRow.Cells(2).Value

                FrmVenta.datagridviewselect.Visible = True
                FrmVenta.DataGridView1.Visible = False
                LlenarTablaQuery(("select * from detallesventas where idventa=" & FrmVenta.txtidventa.Text), FrmVenta.datagridviewselect)

                'Habilitar textbox
                FrmVenta.txtidventa.Enabled = False
                FrmVenta.txtidempleado.Enabled = False
                FrmVenta.txtidcliente.Enabled = False
                FrmVenta.txtcantidad.Enabled = True
                FrmVenta.Button2.Visible = True
                FrmVenta.Button3.Visible = True
                FrmVenta.Button1.Visible = True
                FrmVenta.btnseleccionar.Visible = True
                FrmVenta.DataGridView1.Enabled = True

                FrmVenta.Show()

            ElseIf formulario = "cliente" Then
                Clientes.btnAccion.Visible = False
                Clientes.btnEditar.Visible = True
                Clientes.txtidcliente.Text = datagridviewdatos.CurrentRow.Cells(0).Value
                Clientes.txtnombre.Text = datagridviewdatos.CurrentRow.Cells(1).Value
                Clientes.txttelefono.Text = datagridviewdatos.CurrentRow.Cells(2).Value
                Clientes.Dtpfecha.Value = datagridviewdatos.CurrentRow.Cells(3).Value
                Clientes.txtdesc.Text = datagridviewdatos.CurrentRow.Cells(4).Value

                'Habilitar Textbox
                Clientes.txtidcliente.ReadOnly = True
                Clientes.txtnombre.ReadOnly = False
                Clientes.txttelefono.ReadOnly = False
                Clientes.Dtpfecha.Enabled = True
                Clientes.txtdesc.ReadOnly = False
                Clientes.Show()

            ElseIf formulario = "proveedor" Then
                FrmProveedor.btnEditar.Visible = True
                FrmProveedor.btnguardar.Visible = False
                FrmProveedor.txtId.Text = datagridviewdatos.CurrentRow.Cells(0).Value
                FrmProveedor.txtNombre.Text = datagridviewdatos.CurrentRow.Cells(1).Value
                FrmProveedor.txtDireccion.Text = datagridviewdatos.CurrentRow.Cells(2).Value

                'Habilitar textbox 
                FrmProveedor.txtId.Enabled = False
                FrmProveedor.txtNombre.Enabled = True
                FrmProveedor.txtDireccion.Enabled = True
                FrmProveedor.Show()

            ElseIf formulario = "producto" Then
                Frmproductos.btnguardar.Visible = False
                Frmproductos.btnEditar.Visible = True
                Frmproductos.txtidproducto.Text = datagridviewdatos.CurrentRow.Cells(0).Value
                Frmproductos.txtNombreProducto.Text = datagridviewdatos.CurrentRow.Cells(1).Value
                Frmproductos.txtPrecio.Text = datagridviewdatos.CurrentRow.Cells(2).Value
                Frmproductos.txtMarca.Text = datagridviewdatos.CurrentRow.Cells(3).Value
                Frmproductos.txtDescripcion.Text = datagridviewdatos.CurrentRow.Cells(4).Value
                Frmproductos.nudCantidad.Value = datagridviewdatos.CurrentRow.Cells(5).Value
                Dim comboxstring As String = "select idproveedor,nombreproveedor from proveedor where idproveedor= " & datagridviewdatos.CurrentRow.Cells(6).Value
                Frmproductos.cbxProveedor.DisplayMember = "nombreproveedor"
                Frmproductos.cbxProveedor.ValueMember = "idproveedor"
                LlenarTComboBox(comboxstring, Frmproductos.cbxProveedor)

                'Habilitar textbox
                Frmproductos.txtidproducto.Enabled = False
                Frmproductos.txtNombreProducto.Enabled = True
                Frmproductos.txtPrecio.Enabled = True
                Frmproductos.txtMarca.Enabled = True
                Frmproductos.txtDescripcion.Enabled = True
                Frmproductos.nudCantidad.Enabled = True
                Frmproductos.cbxProveedor.Enabled = True

                Frmproductos.Show()

            ElseIf formulario = "empleado" Then
                Form1.btnEditar.Visible = True
                Form1.Label8.Visible = False
                Form1.btnGuardar.Visible = False

                Form1.txtId.Text = datagridviewdatos.CurrentRow.Cells(0).Value
                Form1.txtNombre.Text = datagridviewdatos.CurrentRow.Cells(1).Value
                Form1.txtTelefono.Text = datagridviewdatos.CurrentRow.Cells(2).Value
                Form1.dtpFechaNacimiento.Value = datagridviewdatos.CurrentRow.Cells(3).Value
                Form1.txtEmail.Text = datagridviewdatos.CurrentRow.Cells(4).Value
                Form1.txtDireccion.Text = datagridviewdatos.CurrentRow.Cells(5).Value
                If datagridviewdatos.CurrentRow.Cells(6).Value = 1 Then
                    Form1.rdbMujer.Checked = True
                Else
                    Form1.rdbHombre.Checked = True
                End If

                'Habiltiar textbox

                Form1.txtId.ReadOnly = True
                Form1.txtNombre.ReadOnly = False
                Form1.txtTelefono.ReadOnly = False
                Form1.dtpFechaNacimiento.Enabled = True
                Form1.txtEmail.ReadOnly = False
                Form1.txtDireccion.ReadOnly = False
                Form1.btnGuardar.Text = "Guardar"


                Form1.Show()

            ElseIf formulario = "pagoempleados" Then
                Frmpago.btnEditar.Visible = True
                Frmpago.btnGuardar.Visible = False
                Frmpago.txtPago.Text = datagridviewdatos.CurrentRow.Cells(0).Value
                Frmpago.txtIdEmpleado.Text = datagridviewdatos.CurrentRow.Cells(1).Value
                Frmpago.txtPagoEmpleado.Text = datagridviewdatos.CurrentRow.Cells(2).Value
                Frmpago.dtpFechaPago.Value = datagridviewdatos.CurrentRow.Cells(3).Value

                'Habilitar textbox
                Frmpago.Button1.Visible = True
                Frmpago.txtPago.Enabled = False
                Frmpago.txtIdEmpleado.Enabled = False
                Frmpago.txtPagoEmpleado.Enabled = True
                Frmpago.dtpFechaPago.Enabled = False

                Frmpago.Show()

            ElseIf formulario = "historialsoporte" Then
                FrmHST.Label8.Visible = True
                FrmHST.GroupBox2.Visible = True
                FrmHST.btnEditar.Visible = True
                FrmHST.btnAccion.Visible = False
                FrmHST.txIdSoporte.Text = datagridviewdatos.CurrentRow.Cells(0).Value
                FrmHST.txtIdEmpleado.Text = datagridviewdatos.CurrentRow.Cells(1).Value
                FrmHST.dtpFecha.Value = datagridviewdatos.CurrentRow.Cells(3).Value
                FrmHST.txtProductoId.Text = datagridviewdatos.CurrentRow.Cells(4).Value
                FrmHST.txtDescripcion.Text = datagridviewdatos.CurrentRow.Cells(6).Value
                FrmHST.txtIdCliente.Text = datagridviewdatos.CurrentRow.Cells(7).Value
                If datagridviewdatos.CurrentRow.Cells(9).Value = 1 Then
                    FrmHST.rbreparacion.Checked = True
                ElseIf datagridviewdatos.CurrentRow.Cells(9).Value = 2 Then
                    FrmHST.rbentregado.Checked = True
                Else
                    FrmHST.rbnoreparado.Checked = True
                End If
                FrmHST.txtIdVenta.Text = datagridviewdatos.CurrentRow.Cells(10).Value
                'Habilitar textbox
                FrmHST.txIdSoporte.ReadOnly = True
                FrmHST.txtIdEmpleado.ReadOnly = False
                FrmHST.dtpFecha.Enabled = False
                FrmHST.txtProductoId.ReadOnly = False
                FrmHST.txtDescripcion.ReadOnly = False
                FrmHST.txtIdCliente.ReadOnly = False
                FrmHST.txtIdVenta.ReadOnly = False
                FrmHST.GroupBox1.Enabled = True
                FrmHST.GroupBox2.Enabled = True
                FrmHST.btnAgregar.Visible = True
                FrmHST.Button2.Visible = True
                FrmHST.Button3.Visible = True
                FrmHST.Button4.Visible = True
                FrmHST.Button5.Visible = True

                FrmHST.Show()
                LlenarTablaQuery(("select * from detalle_soporte where idsoporte=" & datagridviewdatos.CurrentRow.Cells(0).Value), FrmHST.DataGridView1)
            End If
        Catch ex As Exception
            MessageBox.Show("Seleccione un registro de la tabla", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try


    End Sub

    Private Sub FrmdataC_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FrmMENU.Show()

    End Sub
End Class