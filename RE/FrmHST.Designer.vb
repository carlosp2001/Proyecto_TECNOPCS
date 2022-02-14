<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHST
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
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnaccion = New System.Windows.Forms.Button()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.txtidempleado = New System.Windows.Forms.TextBox()
        Me.txtidventa = New System.Windows.Forms.TextBox()
        Me.txtidcliente = New System.Windows.Forms.TextBox()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.txtidsoporte = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtmaterial = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.txtdescdetalle = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtproductoid = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbnoreparado = New System.Windows.Forms.RadioButton()
        Me.rbentregado = New System.Windows.Forms.RadioButton()
        Me.rbreparacion = New System.Windows.Forms.RadioButton()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(729, 169)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(64, 20)
        Me.btncancelar.TabIndex = 30
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        Me.btncancelar.Visible = False
        '
        'btnaccion
        '
        Me.btnaccion.Location = New System.Drawing.Point(729, 93)
        Me.btnaccion.Name = "btnaccion"
        Me.btnaccion.Size = New System.Drawing.Size(64, 20)
        Me.btnaccion.TabIndex = 29
        Me.btnaccion.Text = "Accion"
        Me.btnaccion.UseVisualStyleBackColor = True
        '
        'dtpfecha
        '
        Me.dtpfecha.Location = New System.Drawing.Point(159, 165)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(235, 20)
        Me.dtpfecha.TabIndex = 28
        '
        'txtidempleado
        '
        Me.txtidempleado.Enabled = False
        Me.txtidempleado.Location = New System.Drawing.Point(159, 126)
        Me.txtidempleado.Name = "txtidempleado"
        Me.txtidempleado.Size = New System.Drawing.Size(98, 20)
        Me.txtidempleado.TabIndex = 27
        '
        'txtidventa
        '
        Me.txtidventa.Enabled = False
        Me.txtidventa.Location = New System.Drawing.Point(159, 294)
        Me.txtidventa.Name = "txtidventa"
        Me.txtidventa.Size = New System.Drawing.Size(149, 20)
        Me.txtidventa.TabIndex = 26
        '
        'txtidcliente
        '
        Me.txtidcliente.Enabled = False
        Me.txtidcliente.Location = New System.Drawing.Point(159, 259)
        Me.txtidcliente.Name = "txtidcliente"
        Me.txtidcliente.Size = New System.Drawing.Size(149, 20)
        Me.txtidcliente.TabIndex = 25
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(159, 202)
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(235, 44)
        Me.txtdescripcion.TabIndex = 24
        '
        'txtidsoporte
        '
        Me.txtidsoporte.Enabled = False
        Me.txtidsoporte.Location = New System.Drawing.Point(159, 90)
        Me.txtidsoporte.Name = "txtidsoporte"
        Me.txtidsoporte.Size = New System.Drawing.Size(168, 20)
        Me.txtidsoporte.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText
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
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
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
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
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
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
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
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
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
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
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
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(279, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(341, 32)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Historial De Soporte Técnico"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(10, 458)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(891, 210)
        Me.DataGridView1.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText
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
        Me.Label11.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label11.Location = New System.Drawing.Point(54, 384)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 17)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Material Usado:"
        '
        'txtmaterial
        '
        Me.txtmaterial.Location = New System.Drawing.Point(172, 383)
        Me.txtmaterial.Multiline = True
        Me.txtmaterial.Name = "txtmaterial"
        Me.txtmaterial.Size = New System.Drawing.Size(136, 57)
        Me.txtmaterial.TabIndex = 37
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label12.Location = New System.Drawing.Point(371, 384)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 17)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Existencia:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(437, 367)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(95, 44)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RadioButton2.Location = New System.Drawing.Point(61, 16)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(39, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "No"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RadioButton1.Location = New System.Drawing.Point(5, 16)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(34, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Si"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'txtdescdetalle
        '
        Me.txtdescdetalle.Location = New System.Drawing.Point(650, 384)
        Me.txtdescdetalle.Multiline = True
        Me.txtdescdetalle.Name = "txtdescdetalle"
        Me.txtdescdetalle.Size = New System.Drawing.Size(212, 58)
        Me.txtdescdetalle.TabIndex = 41
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label13.Location = New System.Drawing.Point(572, 384)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 17)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "Descripción:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(10, 419)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 34)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtproductoid
        '
        Me.txtproductoid.Enabled = False
        Me.txtproductoid.Location = New System.Drawing.Point(465, 90)
        Me.txtproductoid.Name = "txtproductoid"
        Me.txtproductoid.Size = New System.Drawing.Size(85, 20)
        Me.txtproductoid.TabIndex = 44
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label14.Location = New System.Drawing.Point(371, 97)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 17)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "Producto ID"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.rbnoreparado)
        Me.GroupBox2.Controls.Add(Me.rbentregado)
        Me.GroupBox2.Controls.Add(Me.rbreparacion)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(614, 235)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(184, 75)
        Me.GroupBox2.TabIndex = 45
        Me.GroupBox2.TabStop = False
        '
        'rbnoreparado
        '
        Me.rbnoreparado.AutoSize = True
        Me.rbnoreparado.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rbnoreparado.Location = New System.Drawing.Point(5, 45)
        Me.rbnoreparado.Name = "rbnoreparado"
        Me.rbnoreparado.Size = New System.Drawing.Size(84, 17)
        Me.rbnoreparado.TabIndex = 2
        Me.rbnoreparado.TabStop = True
        Me.rbnoreparado.Text = "No reparado"
        Me.rbnoreparado.UseVisualStyleBackColor = True
        '
        'rbentregado
        '
        Me.rbentregado.AutoSize = True
        Me.rbentregado.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rbentregado.Location = New System.Drawing.Point(111, 16)
        Me.rbentregado.Name = "rbentregado"
        Me.rbentregado.Size = New System.Drawing.Size(74, 17)
        Me.rbentregado.TabIndex = 1
        Me.rbentregado.TabStop = True
        Me.rbentregado.Text = "Entregado"
        Me.rbentregado.UseVisualStyleBackColor = True
        '
        'rbreparacion
        '
        Me.rbreparacion.AutoSize = True
        Me.rbreparacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rbreparacion.Location = New System.Drawing.Point(5, 16)
        Me.rbreparacion.Name = "rbreparacion"
        Me.rbreparacion.Size = New System.Drawing.Size(91, 17)
        Me.rbreparacion.TabIndex = 0
        Me.rbreparacion.TabStop = True
        Me.rbreparacion.Text = "En reparacion"
        Me.rbreparacion.UseVisualStyleBackColor = True
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
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(556, 89)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(64, 20)
        Me.Button2.TabIndex = 48
        Me.Button2.Text = "Buscar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(263, 126)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(64, 20)
        Me.Button3.TabIndex = 49
        Me.Button3.Text = "Buscar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(330, 259)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(64, 20)
        Me.Button4.TabIndex = 50
        Me.Button4.Text = "Buscar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(330, 294)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(64, 20)
        Me.Button5.TabIndex = 51
        Me.Button5.Text = "Buscar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'FrmHST
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.proyecto_de_analisis.My.Resources.Resources.fondo_formulario3
        Me.ClientSize = New System.Drawing.Size(913, 678)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtproductoid)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtdescdetalle)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtmaterial)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnaccion)
        Me.Controls.Add(Me.dtpfecha)
        Me.Controls.Add(Me.txtidempleado)
        Me.Controls.Add(Me.txtidventa)
        Me.Controls.Add(Me.txtidcliente)
        Me.Controls.Add(Me.txtdescripcion)
        Me.Controls.Add(Me.txtidsoporte)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmHST"
        Me.Text = "Modulo de Soporte Tecnico"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btncancelar As Button
    Friend WithEvents btnaccion As Button
    Friend WithEvents dtpfecha As DateTimePicker
    Friend WithEvents txtidempleado As TextBox
    Friend WithEvents txtidventa As TextBox
    Friend WithEvents txtidcliente As TextBox
    Friend WithEvents txtdescripcion As TextBox
    Friend WithEvents txtidsoporte As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtmaterial As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents txtdescdetalle As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtproductoid As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbnoreparado As RadioButton
    Friend WithEvents rbentregado As RadioButton
    Friend WithEvents rbreparacion As RadioButton
    Friend WithEvents btnEditar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
