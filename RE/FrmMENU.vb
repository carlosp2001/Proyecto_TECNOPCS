Public Class FrmMENU
    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        FrmdataC.Label2.Text = "Registro de Clientes"
        LlenarTablaQuery("select idcliente as 'Identificador', nombrecliente as 'Nombre Completo',
telefono_cliente as 'Telefono', fecharegistro as 'Fecha de registro',direccioncliente as 'Direccion' from cliente", FrmdataC.datagridviewdatos)
        FrmdataC.FrmdataC("cliente")
        FrmdataC.Show()
    End Sub

    Private Sub btnrealizarventa_Click(sender As Object, e As EventArgs) Handles btnrealizarventa.Click
        FrmdataC.Label2.Text = "Registro de Ventas"
        LlenarTablaQuery("select idventa as 'Id de Venta', idempleado as 'Id del Empleado', idcliente as 'Id del Cliente', 
subtotal as 'Subtotal'
from venta", FrmdataC.datagridviewdatos)
        FrmdataC.FrmdataC("ventas")
        FrmdataC.Show()

    End Sub

    Private Sub btnProveedores_Click(sender As Object, e As EventArgs) Handles btnProveedores.Click
        FrmdataC.Label2.Text = "Registro de Proveedores"
        LlenarTablaQuery("select idproveedor as 'Id Proveedor', nombreproveedor as 'Nombre Proveedor', direccion as 'Direccion'
from proveedor", FrmdataC.datagridviewdatos)
        FrmdataC.FrmdataC("proveedor")
        FrmdataC.Show()
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        FrmdataC.Label2.Text = "Registro de Productos"
        LlenarTablaQuery("select idproducto as 'Id del Producto', nombreproducto as 'Nombre del Producto', precioproducto as
'Precio', marca as 'Marca', descripcion as 'Descripcion', cantidaddisponible as 'Cantidad Disponible',
idproveedor as 'Id del Proveedor'
from producto", FrmdataC.datagridviewdatos)
        FrmdataC.FrmdataC("producto")
        FrmdataC.Show()
    End Sub

    Private Sub btnEmpleado_Click(sender As Object, e As EventArgs) Handles btnEmpleado.Click
        FrmdataC.Label2.Text = "Registro de Empleados"
        LlenarTablaQuery("select idempleado as 'Id del Empleado', nombreempleado as 'Nombre Completo', telefono_empleado as
'Telefono', fechanacimiento as 'Fecha de Nacimiento', email as 'Email', direccion as 'Direccion',
genero as 'Genero'
from empleado", FrmdataC.datagridviewdatos)
        FrmdataC.FrmdataC("empleado")
        FrmdataC.Show()
    End Sub

    Private Sub btnPagoEmpleados_Click(sender As Object, e As EventArgs) Handles btnPagoEmpleados.Click
        FrmdataC.Label2.Text = "Registro de Pago Empleados"
        LlenarTablaQuery("select idpago as 'Id de pago', idempleado as 'Id del Empleado', pagoempleado as 'Monto de Pago',
fechapago as 'Fecha del Pago'
from pagoempleados", FrmdataC.datagridviewdatos)
        FrmdataC.FrmdataC("pagoempleados")
        FrmdataC.Show()
    End Sub

    Private Sub btnRegistrarSoporte_Click(sender As Object, e As EventArgs) Handles btnRegistrarSoporte.Click
        FrmdataC.Label2.Text = "Registro de Soporte Técnico"
        LlenarTablaQuery("exec SELECT_HISTORIALSOPORTETABLA", FrmdataC.datagridviewdatos)
        FrmdataC.FrmdataC("historialsoporte")
        FrmdataC.Show()
    End Sub

    Private Sub FrmMENU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Label1.BackColor = Color.Transparent
        FRMLOGIN.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnreportes.Click
        FormMenuReportes.Show()

    End Sub

    Private Sub FrmMENU_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FRMLOGIN.Show()

    End Sub

    Private Sub btnusuario_Click(sender As Object, e As EventArgs) Handles btnusuario.Click
        Datagridviewusuario.Show()

    End Sub
End Class