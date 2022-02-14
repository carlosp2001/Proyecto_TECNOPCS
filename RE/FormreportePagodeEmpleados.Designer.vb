<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormreportePagodeEmpleados
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportePagoEmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New proyecto_de_analisis.DataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReportePagoEmpleadosTableAdapter = New proyecto_de_analisis.DataSet1TableAdapters.ReportePagoEmpleadosTableAdapter()
        CType(Me.ReportePagoEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportePagoEmpleadosBindingSource
        '
        Me.ReportePagoEmpleadosBindingSource.DataMember = "ReportePagoEmpleados"
        Me.ReportePagoEmpleadosBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ReportePagoEmpleadosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "proyecto_de_analisis.ReportePagodeEmpleados.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 75)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(776, 363)
        Me.ReportViewer1.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(131, 25)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre de Empleado:"
        '
        'ReportePagoEmpleadosTableAdapter
        '
        Me.ReportePagoEmpleadosTableAdapter.ClearBeforeFill = True
        '
        'FormreportePagodeEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FormreportePagodeEmpleados"
        Me.Text = "Reporte Pago de Empleados"
        CType(Me.ReportePagoEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ReportePagoEmpleadosBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents ReportePagoEmpleadosTableAdapter As DataSet1TableAdapters.ReportePagoEmpleadosTableAdapter
End Class
