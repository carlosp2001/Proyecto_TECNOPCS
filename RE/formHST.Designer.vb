<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formHST
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAccion = New System.Windows.Forms.Button()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtIdEmpleado = New System.Windows.Forms.TextBox()
        Me.txtIdVenta = New System.Windows.Forms.TextBox()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txIdSoporte = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvHistorialDetalle = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtMaterial = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.gbxExistencia = New System.Windows.Forms.GroupBox()
        Me.rdbNo = New System.Windows.Forms.RadioButton()
        Me.rdbSi = New System.Windows.Forms.RadioButton()
        Me.txtDescDetalle = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtProductoId = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.gbxEstado = New System.Windows.Forms.GroupBox()
        Me.rbNoReparado = New System.Windows.Forms.RadioButton()
        Me.rbEntregado = New System.Windows.Forms.RadioButton()
        Me.rbReparacion = New System.Windows.Forms.RadioButton()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBuscarProducto = New System.Windows.Forms.Button()
        Me.btnBuscarEmpleado = New System.Windows.Forms.Button()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.btnBuscarVenta = New System.Windows.Forms.Button()
        Me.grbDetalle = New System.Windows.Forms.GroupBox()
        CType(Me.dgvHistorialDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxExistencia.SuspendLayout()
        Me.gbxEstado.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(729, 169)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(64, 20)
        Me.btnCancelar.TabIndex = 30
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        Me.btnCancelar.Visible = False
        '
        'btnAccion
        '
        Me.btnAccion.Location = New System.Drawing.Point(729, 93)
        Me.btnAccion.Name = "btnAccion"
        Me.btnAccion.Size = New System.Drawing.Size(64, 20)
        Me.btnAccion.TabIndex = 29
        Me.btnAccion.Text = "Accion"
        Me.btnAccion.UseVisualStyleBackColor = True
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(159, 165)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(235, 20)
        Me.dtpFecha.TabIndex = 28
        '
        'txtIdEmpleado
        '
        Me.txtIdEmpleado.Enabled = False
        Me.txtIdEmpleado.Location = New System.Drawing.Point(159, 126)
        Me.txtIdEmpleado.Name = "txtIdEmpleado"
        Me.txtIdEmpleado.Size = New System.Drawing.Size(98, 20)
        Me.txtIdEmpleado.TabIndex = 27
        '
        'txtIdVenta
        '
        Me.txtIdVenta.Enabled = False
        Me.txtIdVenta.Location = New System.Drawing.Point(159, 294)
        Me.txtIdVenta.Name = "txtIdVenta"
        Me.txtIdVenta.Size = New System.Drawing.Size(149, 20)
        Me.txtIdVenta.TabIndex = 26
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Enabled = False
        Me.txtIdCliente.Location = New System.Drawing.Point(159, 259)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(149, 20)
        Me.txtIdCliente.TabIndex = 25
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(159, 202)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(235, 44)
        Me.txtDescripcion.TabIndex = 24
        '
        'txIdSoporte
        '
        Me.txIdSoporte.Enabled = False
        Me.txIdSoporte.Location = New System.Drawing.Point(159, 90)
        Me.txIdSoporte.Name = "txIdSoporte"
        Me.txIdSoporte.Size = New System.Drawing.Size(168, 20)
        Me.txIdSoporte.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label7.Location = New System.Drawing.Point(66, 301)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 17)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "ID Venta:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Location = New System.Drawing.Point(66, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 17)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Descripción:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.Location = New System.Drawing.Point(66, 266)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 17)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "ID Cliente:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Location = New System.Drawing.Point(66, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 17)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "ID Soporte:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Location = New System.Drawing.Point(66, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 17)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "ID Empleado:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Location = New System.Drawing.Point(66, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Fecha:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(279, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(341, 32)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Historial De Soporte Técnico"
        '
        'dgvHistorialDetalle
        '
        Me.dgvHistorialDetalle.AllowUserToAddRows = False
        Me.dgvHistorialDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvHistorialDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHistorialDetalle.Location = New System.Drawing.Point(10, 458)
        Me.dgvHistorialDetalle.Name = "dgvHistorialDetalle"
        Me.dgvHistorialDetalle.ReadOnly = True
        Me.dgvHistorialDetalle.RowTemplate.Height = 25
        Me.dgvHistorialDetalle.Size = New System.Drawing.Size(891, 210)
        Me.dgvHistorialDetalle.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label8.Location = New System.Drawing.Point(543, 235)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 17)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Estado:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label11.Location = New System.Drawing.Point(54, 384)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 17)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Material Usado:"
        '
        'txtMaterial
        '
        Me.txtMaterial.Location = New System.Drawing.Point(172, 383)
        Me.txtMaterial.Multiline = True
        Me.txtMaterial.Name = "txtMaterial"
        Me.txtMaterial.Size = New System.Drawing.Size(136, 57)
        Me.txtMaterial.TabIndex = 37
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label12.Location = New System.Drawing.Point(371, 393)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 17)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Existencia:"
        '
        'gbxExistencia
        '
        Me.gbxExistencia.BackColor = System.Drawing.Color.Transparent
        Me.gbxExistencia.Controls.Add(Me.rdbNo)
        Me.gbxExistencia.Controls.Add(Me.rdbSi)
        Me.gbxExistencia.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gbxExistencia.Location = New System.Drawing.Point(437, 376)
        Me.gbxExistencia.Name = "gbxExistencia"
        Me.gbxExistencia.Size = New System.Drawing.Size(95, 44)
        Me.gbxExistencia.TabIndex = 39
        Me.gbxExistencia.TabStop = False
        '
        'rdbNo
        '
        Me.rdbNo.AutoSize = True
        Me.rdbNo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rdbNo.Location = New System.Drawing.Point(61, 16)
        Me.rdbNo.Name = "rdbNo"
        Me.rdbNo.Size = New System.Drawing.Size(39, 17)
        Me.rdbNo.TabIndex = 1
        Me.rdbNo.TabStop = True
        Me.rdbNo.Text = "No"
        Me.rdbNo.UseVisualStyleBackColor = True
        '
        'rdbSi
        '
        Me.rdbSi.AutoSize = True
        Me.rdbSi.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rdbSi.Location = New System.Drawing.Point(5, 16)
        Me.rdbSi.Name = "rdbSi"
        Me.rdbSi.Size = New System.Drawing.Size(34, 17)
        Me.rdbSi.TabIndex = 0
        Me.rdbSi.TabStop = True
        Me.rdbSi.Text = "Si"
        Me.rdbSi.UseVisualStyleBackColor = True
        '
        'txtDescDetalle
        '
        Me.txtDescDetalle.Location = New System.Drawing.Point(650, 384)
        Me.txtDescDetalle.Multiline = True
        Me.txtDescDetalle.Name = "txtDescDetalle"
        Me.txtDescDetalle.Size = New System.Drawing.Size(212, 58)
        Me.txtDescDetalle.TabIndex = 41
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label13.Location = New System.Drawing.Point(572, 384)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 17)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "Descripción:"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(10, 419)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(85, 34)
        Me.btnAgregar.TabIndex = 42
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtProductoId
        '
        Me.txtProductoId.Enabled = False
        Me.txtProductoId.Location = New System.Drawing.Point(465, 90)
        Me.txtProductoId.Name = "txtProductoId"
        Me.txtProductoId.Size = New System.Drawing.Size(85, 20)
        Me.txtProductoId.TabIndex = 44
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label14.Location = New System.Drawing.Point(371, 97)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 17)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "Producto ID"
        '
        'gbxEstado
        '
        Me.gbxEstado.BackColor = System.Drawing.Color.Transparent
        Me.gbxEstado.Controls.Add(Me.rbNoReparado)
        Me.gbxEstado.Controls.Add(Me.rbEntregado)
        Me.gbxEstado.Controls.Add(Me.rbReparacion)
        Me.gbxEstado.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gbxEstado.Location = New System.Drawing.Point(614, 235)
        Me.gbxEstado.Name = "gbxEstado"
        Me.gbxEstado.Size = New System.Drawing.Size(184, 75)
        Me.gbxEstado.TabIndex = 45
        Me.gbxEstado.TabStop = False
        '
        'rbNoReparado
        '
        Me.rbNoReparado.AutoSize = True
        Me.rbNoReparado.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rbNoReparado.Location = New System.Drawing.Point(5, 45)
        Me.rbNoReparado.Name = "rbNoReparado"
        Me.rbNoReparado.Size = New System.Drawing.Size(84, 17)
        Me.rbNoReparado.TabIndex = 2
        Me.rbNoReparado.TabStop = True
        Me.rbNoReparado.Text = "No reparado"
        Me.rbNoReparado.UseVisualStyleBackColor = True
        '
        'rbEntregado
        '
        Me.rbEntregado.AutoSize = True
        Me.rbEntregado.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rbEntregado.Location = New System.Drawing.Point(111, 16)
        Me.rbEntregado.Name = "rbEntregado"
        Me.rbEntregado.Size = New System.Drawing.Size(74, 17)
        Me.rbEntregado.TabIndex = 1
        Me.rbEntregado.TabStop = True
        Me.rbEntregado.Text = "Entregado"
        Me.rbEntregado.UseVisualStyleBackColor = True
        '
        'rbReparacion
        '
        Me.rbReparacion.AutoSize = True
        Me.rbReparacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rbReparacion.Location = New System.Drawing.Point(5, 16)
        Me.rbReparacion.Name = "rbReparacion"
        Me.rbReparacion.Size = New System.Drawing.Size(91, 17)
        Me.rbReparacion.TabIndex = 0
        Me.rbReparacion.TabStop = True
        Me.rbReparacion.Text = "En reparacion"
        Me.rbReparacion.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(729, 129)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(64, 20)
        Me.btnEditar.TabIndex = 46
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        Me.btnEditar.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.proyecto_de_analisis.My.Resources.Resources.WhatsApp_Image_2021_12_10_at_1_20_30_PM
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(10, -14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(81, 80)
        Me.PictureBox1.TabIndex = 47
        Me.PictureBox1.TabStop = False
        '
        'btnBuscarProducto
        '
        Me.btnBuscarProducto.Location = New System.Drawing.Point(556, 89)
        Me.btnBuscarProducto.Name = "btnBuscarProducto"
        Me.btnBuscarProducto.Size = New System.Drawing.Size(64, 20)
        Me.btnBuscarProducto.TabIndex = 48
        Me.btnBuscarProducto.Text = "Buscar"
        Me.btnBuscarProducto.UseVisualStyleBackColor = True
        '
        'btnBuscarEmpleado
        '
        Me.btnBuscarEmpleado.Location = New System.Drawing.Point(263, 126)
        Me.btnBuscarEmpleado.Name = "btnBuscarEmpleado"
        Me.btnBuscarEmpleado.Size = New System.Drawing.Size(64, 20)
        Me.btnBuscarEmpleado.TabIndex = 49
        Me.btnBuscarEmpleado.Text = "Buscar"
        Me.btnBuscarEmpleado.UseVisualStyleBackColor = True
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Location = New System.Drawing.Point(330, 259)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(64, 20)
        Me.btnBuscarCliente.TabIndex = 50
        Me.btnBuscarCliente.Text = "Buscar"
        Me.btnBuscarCliente.UseVisualStyleBackColor = True
        '
        'btnBuscarVenta
        '
        Me.btnBuscarVenta.Location = New System.Drawing.Point(330, 294)
        Me.btnBuscarVenta.Name = "btnBuscarVenta"
        Me.btnBuscarVenta.Size = New System.Drawing.Size(64, 20)
        Me.btnBuscarVenta.TabIndex = 51
        Me.btnBuscarVenta.Text = "Buscar"
        Me.btnBuscarVenta.UseVisualStyleBackColor = True
        '
        'grbDetalle
        '
        Me.grbDetalle.BackColor = System.Drawing.Color.Transparent
        Me.grbDetalle.Location = New System.Drawing.Point(5, 364)
        Me.grbDetalle.Name = "grbDetalle"
        Me.grbDetalle.Size = New System.Drawing.Size(905, 317)
        Me.grbDetalle.TabIndex = 52
        Me.grbDetalle.TabStop = False
        '
        'formHST
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.proyecto_de_analisis.My.Resources.Resources.fondo_formulario3
        Me.ClientSize = New System.Drawing.Size(913, 369)
        Me.Controls.Add(Me.btnBuscarVenta)
        Me.Controls.Add(Me.btnBuscarCliente)
        Me.Controls.Add(Me.btnBuscarEmpleado)
        Me.Controls.Add(Me.btnBuscarProducto)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.gbxEstado)
        Me.Controls.Add(Me.txtProductoId)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtDescDetalle)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.gbxExistencia)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtMaterial)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dgvHistorialDetalle)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAccion)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.txtIdEmpleado)
        Me.Controls.Add(Me.txtIdVenta)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txIdSoporte)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grbDetalle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formHST"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modulo de Soporte Tecnico"
        CType(Me.dgvHistorialDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxExistencia.ResumeLayout(False)
        Me.gbxExistencia.PerformLayout()
        Me.gbxEstado.ResumeLayout(False)
        Me.gbxEstado.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAccion As Button
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents txtIdEmpleado As TextBox
    Friend WithEvents txtIdVenta As TextBox
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txIdSoporte As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvHistorialDetalle As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtMaterial As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents gbxExistencia As GroupBox
    Friend WithEvents rdbNo As RadioButton
    Friend WithEvents rdbSi As RadioButton
    Friend WithEvents txtDescDetalle As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtProductoId As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents gbxEstado As GroupBox
    Friend WithEvents rbNoReparado As RadioButton
    Friend WithEvents rbEntregado As RadioButton
    Friend WithEvents rbReparacion As RadioButton
    Friend WithEvents btnEditar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBuscarProducto As Button
    Friend WithEvents btnBuscarEmpleado As Button
    Friend WithEvents btnBuscarCliente As Button
    Friend WithEvents btnBuscarVenta As Button
    Friend WithEvents grbDetalle As GroupBox
End Class
