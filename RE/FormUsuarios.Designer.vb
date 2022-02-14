<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUsuarios
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(263, 292)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(64, 20)
        Me.btnEditar.TabIndex = 47
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        Me.btnEditar.Visible = False
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(77, 292)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(64, 20)
        Me.btnguardar.TabIndex = 45
        Me.btnguardar.Text = "Agregar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(114, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 21)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Registro Usuario"
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(106, 177)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(221, 20)
        Me.txtpass.TabIndex = 43
        '
        'txtusuario
        '
        Me.txtusuario.Location = New System.Drawing.Point(106, 141)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(221, 20)
        Me.txtusuario.TabIndex = 42
        '
        'txtid
        '
        Me.txtid.Enabled = False
        Me.txtid.Location = New System.Drawing.Point(106, 108)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(221, 20)
        Me.txtid.TabIndex = 41
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 177)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Contraseña"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Usuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Id Usuario:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Tipo de Usuario:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Administrador", "Empleado", "Cliente"})
        Me.ComboBox1.Location = New System.Drawing.Point(120, 215)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(207, 21)
        Me.ComboBox1.TabIndex = 49
        '
        'FormUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 404)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtusuario)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormUsuarios"
        Me.Text = "FormUsuarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEditar As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtpass As TextBox
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents txtid As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
