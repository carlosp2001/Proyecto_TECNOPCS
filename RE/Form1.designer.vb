<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtdesc = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImage = Global.proyecto_de_analisis.My.Resources.Resources.disquete
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Location = New System.Drawing.Point(571, 20)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(78, 76)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.proyecto_de_analisis.My.Resources.Resources.flecha_hacia_atras
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(571, 250)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(78, 75)
        Me.Button3.TabIndex = 3
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(587, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 15)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Guardar"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(591, 328)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 15)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Volver"
        Me.Label11.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 250)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Direcccion:"
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(383, 58)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(142, 20)
        Me.txttelefono.TabIndex = 26
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(59, 181)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(223, 20)
        Me.txtemail.TabIndex = 25
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(59, 120)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(223, 20)
        Me.txtnombre.TabIndex = 24
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(59, 62)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(223, 20)
        Me.txtid.TabIndex = 23
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(288, 127)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(211, 20)
        Me.DateTimePicker1.TabIndex = 22
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(288, 180)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(237, 71)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sexo:"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(130, 34)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(51, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Mujer"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(14, 34)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(62, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Hombre"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Correo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(288, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Fecha de nacimiento:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(288, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Num de telefono:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Identidad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(150, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 15)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Registro de empleados"
        '
        'txtdesc
        '
        Me.txtdesc.Location = New System.Drawing.Point(31, 283)
        Me.txtdesc.Multiline = True
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(411, 97)
        Me.txtdesc.TabIndex = 30
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(587, 215)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 15)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Editar"
        Me.Label8.Visible = False
        '
        'btnEditar
        '
        Me.btnEditar.BackgroundImage = Global.proyecto_de_analisis.My.Resources.Resources.actualizar
        Me.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnEditar.Location = New System.Drawing.Point(571, 138)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(78, 76)
        Me.btnEditar.TabIndex = 31
        Me.btnEditar.UseVisualStyleBackColor = True
        Me.btnEditar.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = Global.proyecto_de_analisis.My.Resources.Resources.fondo_white
        Me.ClientSize = New System.Drawing.Size(686, 390)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.txtdesc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnGuardar)
        Me.Name = "Form1"
        Me.Text = "Modulo de Empleados"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtid As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtdesc As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnEditar As Button
End Class
