<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmpago
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
        Me.txtpagodeempleado = New System.Windows.Forms.TextBox()
        Me.txtidempleado = New System.Windows.Forms.TextBox()
        Me.txtpago = New System.Windows.Forms.TextBox()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnaccion = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtpagodeempleado
        '
        Me.txtpagodeempleado.Location = New System.Drawing.Point(189, 215)
        Me.txtpagodeempleado.Name = "txtpagodeempleado"
        Me.txtpagodeempleado.Size = New System.Drawing.Size(258, 20)
        Me.txtpagodeempleado.TabIndex = 19
        '
        'txtidempleado
        '
        Me.txtidempleado.Enabled = False
        Me.txtidempleado.Location = New System.Drawing.Point(189, 172)
        Me.txtidempleado.Name = "txtidempleado"
        Me.txtidempleado.ReadOnly = True
        Me.txtidempleado.Size = New System.Drawing.Size(165, 20)
        Me.txtidempleado.TabIndex = 18
        '
        'txtpago
        '
        Me.txtpago.Enabled = False
        Me.txtpago.Location = New System.Drawing.Point(189, 128)
        Me.txtpago.Name = "txtpago"
        Me.txtpago.ReadOnly = True
        Me.txtpago.Size = New System.Drawing.Size(258, 20)
        Me.txtpago.TabIndex = 17
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.SystemColors.Control
        Me.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btncancelar.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.btncancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btncancelar.Location = New System.Drawing.Point(482, 180)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(64, 23)
        Me.btncancelar.TabIndex = 15
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = False
        Me.btncancelar.Visible = False
        '
        'btnaccion
        '
        Me.btnaccion.Location = New System.Drawing.Point(482, 154)
        Me.btnaccion.Name = "btnaccion"
        Me.btnaccion.Size = New System.Drawing.Size(64, 20)
        Me.btnaccion.TabIndex = 14
        Me.btnaccion.Text = "Accion"
        Me.btnaccion.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(189, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(230, 32)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Pago De Empleado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(57, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Pago de Empleado:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(57, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "ID Empleado:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(57, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "ID Pago:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(57, 261)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 17)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Fecha de Pago:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(189, 261)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(258, 20)
        Me.DateTimePicker1.TabIndex = 22
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(482, 128)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(64, 20)
        Me.btnEditar.TabIndex = 23
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        Me.btnEditar.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.proyecto_de_analisis.My.Resources.Resources.WhatsApp_Image_2021_12_10_at_1_20_30_PM
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(-2, -12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(81, 80)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(383, 172)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 20)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Frmpago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.proyecto_de_analisis.My.Resources.Resources.fondo_azul
        Me.ClientSize = New System.Drawing.Size(606, 360)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtpagodeempleado)
        Me.Controls.Add(Me.txtidempleado)
        Me.Controls.Add(Me.txtpago)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnaccion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frmpago"
        Me.Text = "Modulo de Pago de Empleados"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtpagodeempleado As TextBox
    Friend WithEvents txtidempleado As TextBox
    Friend WithEvents txtpago As TextBox
    Friend WithEvents btncancelar As Button
    Friend WithEvents btnaccion As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnEditar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
End Class
