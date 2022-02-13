Public Class FrmMENU
    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        FrmdataC.Label2.Text = "Registro de Clientes"
        LlenarTabla("cliente", FrmdataC.datagridviewdatos)
        FrmdataC.FrmdataC("cliente")
        FrmdataC.Show()
    End Sub

    Private Sub btnrealizarventa_Click(sender As Object, e As EventArgs) Handles btnrealizarventa.Click
        FrmdataC.Label2.Text = "Registro de Ventas"
        LlenarTabla("venta", FrmdataC.datagridviewdatos)
        FrmdataC.FrmdataC("ventas")
        FrmdataC.Show()

    End Sub

    Private Sub btnProveedores_Click(sender As Object, e As EventArgs) Handles btnProveedores.Click
        FrmdataC.Label2.Text = "Registro de Proveedores"
        LlenarTabla("proveedor", FrmdataC.datagridviewdatos)
        FrmdataC.FrmdataC("proveedor")
        FrmdataC.Show()
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        FrmdataC.Label2.Text = "Registro de Productos"
        LlenarTabla("producto", FrmdataC.datagridviewdatos)
        FrmdataC.FrmdataC("producto")
        FrmdataC.Show()
    End Sub

    Private Sub btnEmpleado_Click(sender As Object, e As EventArgs) Handles btnEmpleado.Click
        FrmdataC.Label2.Text = "Registro de Empleados"
        LlenarTabla("empleado", FrmdataC.datagridviewdatos)
        FrmdataC.FrmdataC("empleado")
        FrmdataC.Show()
    End Sub

    Private Sub btnPagoEmpleados_Click(sender As Object, e As EventArgs) Handles btnPagoEmpleados.Click
        FrmdataC.Label2.Text = "Registro de Pago Empleados"
        LlenarTabla("pagoempleados", FrmdataC.datagridviewdatos)
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
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnreportes.Click
        FormMenuReportes.Show()

    End Sub
End Class