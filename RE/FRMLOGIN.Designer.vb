<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMLOGIN
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
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.passcheckbox = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(188, 129)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(109, 20)
        Me.txtpass.TabIndex = 9
        '
        'txtusuario
        '
        Me.txtusuario.Location = New System.Drawing.Point(188, 87)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(109, 20)
        Me.txtusuario.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(129, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(129, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Usuario"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(188, 206)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 20)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Ingresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(197, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 15)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "LOGIN"
        '
        'passcheckbox
        '
        Me.passcheckbox.AutoSize = True
        Me.passcheckbox.BackColor = System.Drawing.Color.Transparent
        Me.passcheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.passcheckbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.passcheckbox.Location = New System.Drawing.Point(185, 167)
        Me.passcheckbox.Name = "passcheckbox"
        Me.passcheckbox.Size = New System.Drawing.Size(118, 17)
        Me.passcheckbox.TabIndex = 11
        Me.passcheckbox.Text = "Mostrar Contraseña"
        Me.passcheckbox.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.proyecto_de_analisis.My.Resources.Resources.WhatsApp_Image_2021_12_10_at_1_20_30_PM
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(2, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(81, 80)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'FRMLOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.proyecto_de_analisis.My.Resources.Resources.fondo_formulario3
        Me.ClientSize = New System.Drawing.Size(376, 284)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.passcheckbox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtusuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FRMLOGIN"
        Me.Text = "Ingreso de Usuarios"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtpass As TextBox
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents passcheckbox As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
