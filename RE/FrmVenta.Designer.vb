<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmVenta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtidcliente = New System.Windows.Forms.TextBox()
        Me.txtidempleado = New System.Windows.Forms.TextBox()
        Me.txtidventa = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.idproducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtidproducto = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnaccion = New System.Windows.Forms.Button()
        Me.btnseleccionar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.datagridviewselect = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtsubtotal = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datagridviewselect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(291, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 25)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Registro de ventas"
        '
        'txtidcliente
        '
        Me.txtidcliente.Location = New System.Drawing.Point(440, 92)
        Me.txtidcliente.Name = "txtidcliente"
        Me.txtidcliente.Size = New System.Drawing.Size(127, 20)
        Me.txtidcliente.TabIndex = 39
        '
        'txtidempleado
        '
        Me.txtidempleado.Location = New System.Drawing.Point(100, 145)
        Me.txtidempleado.Name = "txtidempleado"
        Me.txtidempleado.Size = New System.Drawing.Size(119, 20)
        Me.txtidempleado.TabIndex = 38
        '
        'txtidventa
        '
        Me.txtidventa.Location = New System.Drawing.Point(99, 92)
        Me.txtidventa.Name = "txtidventa"
        Me.txtidventa.Size = New System.Drawing.Size(214, 20)
        Me.txtidventa.TabIndex = 37
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(366, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Id cliente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Id empleado:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Id venta:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idproducto, Me.cantidad, Me.subtotal, Me.Precio})
        Me.DataGridView1.Location = New System.Drawing.Point(30, 319)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(622, 150)
        Me.DataGridView1.TabIndex = 44
        '
        'idproducto
        '
        Me.idproducto.HeaderText = "Id Producto"
        Me.idproducto.Name = "idproducto"
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        '
        'subtotal
        '
        Me.subtotal.HeaderText = "Subtotal"
        Me.subtotal.Name = "subtotal"
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 222)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Detalle de Venta"
        '
        'txtidproducto
        '
        Me.txtidproducto.Enabled = False
        Me.txtidproducto.Location = New System.Drawing.Point(97, 264)
        Me.txtidproducto.Name = "txtidproducto"
        Me.txtidproducto.Size = New System.Drawing.Size(91, 20)
        Me.txtidproducto.TabIndex = 47
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 267)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Id Producto:"
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(266, 264)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(85, 20)
        Me.txtcantidad.TabIndex = 49
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(208, 267)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Cantidad:"
        '
        'txtprecio
        '
        Me.txtprecio.Enabled = False
        Me.txtprecio.Location = New System.Drawing.Point(418, 267)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(61, 20)
        Me.txtprecio.TabIndex = 51
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(375, 267)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Precio"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(573, 265)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 22)
        Me.Button1.TabIndex = 52
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnaccion
        '
        Me.btnaccion.Location = New System.Drawing.Point(25, 509)
        Me.btnaccion.Name = "btnaccion"
        Me.btnaccion.Size = New System.Drawing.Size(64, 20)
        Me.btnaccion.TabIndex = 53
        Me.btnaccion.Text = "Accion"
        Me.btnaccion.UseVisualStyleBackColor = True
        '
        'btnseleccionar
        '
        Me.btnseleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnseleccionar.Location = New System.Drawing.Point(504, 264)
        Me.btnseleccionar.Name = "btnseleccionar"
        Me.btnseleccionar.Size = New System.Drawing.Size(44, 23)
        Me.btnseleccionar.TabIndex = 54
        Me.btnseleccionar.Text = "Buscar"
        Me.btnseleccionar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(116, 509)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(64, 20)
        Me.btnEditar.TabIndex = 55
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(588, 509)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(64, 20)
        Me.btnCancelar.TabIndex = 56
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        Me.btnCancelar.Visible = False
        '
        'datagridviewselect
        '
        Me.datagridviewselect.AllowUserToAddRows = False
        Me.datagridviewselect.AllowUserToDeleteRows = False
        Me.datagridviewselect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewselect.Location = New System.Drawing.Point(31, 319)
        Me.datagridviewselect.Name = "datagridviewselect"
        Me.datagridviewselect.ReadOnly = True
        Me.datagridviewselect.RowTemplate.Height = 25
        Me.datagridviewselect.Size = New System.Drawing.Size(622, 150)
        Me.datagridviewselect.TabIndex = 57
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.proyecto_de_analisis.My.Resources.Resources.WhatsApp_Image_2021_12_10_at_1_20_30_PM
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(-7, -10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(81, 80)
        Me.PictureBox1.TabIndex = 58
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Location = New System.Drawing.Point(242, 145)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(68, 23)
        Me.Button2.TabIndex = 59
        Me.Button2.Text = "Buscar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.Location = New System.Drawing.Point(573, 92)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(79, 23)
        Me.Button3.TabIndex = 60
        Me.Button3.Text = "Buscar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(366, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Subtotal:"
        Me.Label4.Visible = False
        '
        'txtsubtotal
        '
        Me.txtsubtotal.Location = New System.Drawing.Point(440, 149)
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.Size = New System.Drawing.Size(213, 20)
        Me.txtsubtotal.TabIndex = 40
        Me.txtsubtotal.Visible = False
        '
        'FrmVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.proyecto_de_analisis.My.Resources.Resources.fondo_white
        Me.ClientSize = New System.Drawing.Size(683, 553)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.datagridviewselect)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnseleccionar)
        Me.Controls.Add(Me.btnaccion)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtprecio)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtidproducto)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtsubtotal)
        Me.Controls.Add(Me.txtidcliente)
        Me.Controls.Add(Me.txtidempleado)
        Me.Controls.Add(Me.txtidventa)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmVenta"
        Me.Text = "Modulo de Ventas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datagridviewselect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents txtidcliente As TextBox
    Friend WithEvents txtidempleado As TextBox
    Friend WithEvents txtidventa As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents txtidproducto As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnaccion As Button
    Friend WithEvents btnseleccionar As Button
    Friend WithEvents idproducto As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents subtotal As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents datagridviewselect As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtsubtotal As TextBox
End Class
