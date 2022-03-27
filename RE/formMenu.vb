Public Class formMenu
    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        formDataC.Label2.Text = "Registro de Clientes"
        LlenarTablaQuery("select idCliente as 'Identificador', nombreCliente as 'Nombre Completo',
            telefonoCliente as 'Telefono', fechaRegistro as 'Fecha de registro', direccionCliente as 'Direccion', email as 'Email',
            genero as 'Genero', fechaNacimiento as 'Fecha de Nacimiento' from cliente", formDataC.dataGridViewDatos)
        formDataC.FrmdataC("cliente")
        formDataC.Show()
    End Sub

    Private Sub btnrealizarventa_Click(sender As Object, e As EventArgs) Handles btnRealizarVenta.Click
        formDataC.Label2.Text = "Registro de Ventas"
        LlenarTablaQuery("select idventa as 'Id de Venta', idempleado as 'Id del Empleado', idcliente as 'Id del Cliente', 
subtotal as 'Subtotal'
from venta", formDataC.dataGridViewDatos)
        formDataC.FrmdataC("ventas")
        formDataC.Show()

    End Sub

    Private Sub btnProveedores_Click(sender As Object, e As EventArgs) Handles btnProveedores.Click
        formDataC.Label2.Text = "Registro de Proveedores"
        LlenarTablaQuery("select idproveedor as 'Id Proveedor', nombreproveedor as 'Nombre Proveedor', direccion as 'Direccion'
from proveedor", formDataC.dataGridViewDatos)
        formDataC.FrmdataC("proveedor")
        formDataC.Show()
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        formDataC.Label2.Text = "Registro de Productos"
        LlenarTablaQuery("select idproducto as 'Id del Producto', nombreproducto as 'Nombre del Producto', precioCompra as
'Precio', marca as 'Marca', descripcion as 'Descripcion', cantidaddisponible as 'Cantidad Disponible',
idproveedor as 'Id del Proveedor'
from producto", formDataC.dataGridViewDatos)
        formDataC.FrmdataC("producto")
        formDataC.Show()
    End Sub

    Private Sub btnEmpleado_Click(sender As Object, e As EventArgs) Handles btnEmpleado.Click
        formDataC.Label2.Text = "Registro de Empleados"
        LlenarTablaQuery("select idEmpleado as 'Id del Empleado', nombreEmpleado as 'Nombre Completo', telefonoEmpleado as
'Telefono', fechaNacimiento as 'Fecha de Nacimiento', email as 'Email', direccion as 'Direccion',
genero as 'Genero'
from empleado", formDataC.dataGridViewDatos)
        formDataC.FrmdataC("empleado")
        formDataC.Show()
    End Sub

    Private Sub btnPagoEmpleados_Click(sender As Object, e As EventArgs) Handles btnPagoEmpleados.Click
        formDataC.Label2.Text = "Registro de Pago Empleados"
        LlenarTablaQuery("select idPago as 'Id de pago', idEmpleado as 'Id del Empleado', pagoempleado as 'Monto de Pago',
fechapago as 'Fecha del Pago'
from pagoempleados", formDataC.dataGridViewDatos)
        formDataC.FrmdataC("pagoempleados")
        formDataC.Show()
    End Sub

    Private Sub btnRegistrarSoporte_Click(sender As Object, e As EventArgs) Handles btnRegistrarSoporte.Click
        formDataC.Label2.Text = "Registro de Soporte Técnico"
        LlenarTablaQuery("exec SELECT_HISTORIALSOPORTETABLA", formDataC.dataGridViewDatos)
        formDataC.FrmdataC("historialsoporte")
        formDataC.Show()
    End Sub

    Private Sub FrmMENU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Label1.BackColor = Color.Transparent
        formLogin.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        FormMenuReportes.Show()

    End Sub

    Private Sub FrmMENU_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        formLogin.Show()

    End Sub

    Private Sub btnusuario_Click(sender As Object, e As EventArgs) Handles btnUsuario.Click
        dataGridViewUsuarios.Show()

    End Sub

    Private Sub btnEnvios_Click(sender As Object, e As EventArgs) Handles btnEnvios.Click
        FormEnvios.Show()

    End Sub
End Class