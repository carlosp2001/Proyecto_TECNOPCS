<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmproductos
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtdesc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnombreproducto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtidproducto = New System.Windows.Forms.TextBox()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(393, 147)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(180, 21)
        Me.ComboBox1.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(290, 147)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Proveedor"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(393, 94)
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(180, 20)
        Me.NumericUpDown1.TabIndex = 29
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(290, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Cantidad Disponible"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 271)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Descripcion"
        '
        'txtdesc
        '
        Me.txtdesc.Location = New System.Drawing.Point(94, 268)
        Me.txtdesc.Multiline = True
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(403, 99)
        Me.txtdesc.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Marca"
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(94, 229)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(186, 20)
        Me.txtMarca.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Precio"
        '
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(94, 185)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(186, 20)
        Me.txtprecio.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Nombre:"
        '
        'txtnombreproducto
        '
        Me.txtnombreproducto.Location = New System.Drawing.Point(94, 131)
        Me.txtnombreproducto.Multiline = True
        Me.txtnombreproducto.Name = "txtnombreproducto"
        Me.txtnombreproducto.Size = New System.Drawing.Size(186, 37)
        Me.txtnombreproducto.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(275, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 32)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Productos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Id Producto:"
        '
        'txtidproducto
        '
        Me.txtidproducto.Location = New System.Drawing.Point(94, 93)
        Me.txtidproducto.Name = "txtidproducto"
        Me.txtidproducto.Size = New System.Drawing.Size(186, 20)
        Me.txtidproducto.TabIndex = 17
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(592, 211)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(64, 20)
        Me.btneliminar.TabIndex = 34
        Me.btneliminar.Text = "Cancelar"
        Me.btneliminar.UseVisualStyleBackColor = True
        Me.btneliminar.Visible = False
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(592, 118)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(64, 20)
        Me.btnguardar.TabIndex = 32
        Me.btnguardar.Text = "Accion"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(592, 166)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(64, 20)
        Me.btnEditar.TabIndex = 35
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        Me.btnEditar.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.proyecto_de_analisis.My.Resources.Resources.WhatsApp_Image_2021_12_10_at_1_20_30_PM
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(-4, -7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(81, 80)
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'Frmproductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.proyecto_de_analisis.My.Resources.Resources.fondo_white
        Me.ClientSize = New System.Drawing.Size(686, 388)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtdesc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtMarca)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtprecio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtnombreproducto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtidproducto)
        Me.Name = "Frmproductos"
        Me.Text = "Modulo de Productos"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtdesc As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnombreproducto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtidproducto As TextBox
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
