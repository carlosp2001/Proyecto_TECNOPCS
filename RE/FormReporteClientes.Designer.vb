<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporteClientes
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
        Me.ReportehistorialclBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New proyecto_de_analisis.DataSet1()
        Me.rpvClientes = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ReportehistorialclTableAdapter = New proyecto_de_analisis.DataSet1TableAdapters.ReportehistorialclTableAdapter()
        CType(Me.ReportehistorialclBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportehistorialclBindingSource
        '
        Me.ReportehistorialclBindingSource.DataMember = "Reportehistorialcl"
        Me.ReportehistorialclBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rpvClientes
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ReportehistorialclBindingSource
        Me.rpvClientes.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rpvClientes.LocalReport.ReportEmbeddedResource = "proyecto_de_analisis.ReporteRegistroClientes.rdlc"
        Me.rpvClientes.Location = New System.Drawing.Point(12, 12)
        Me.rpvClientes.Name = "rpvClientes"
        Me.rpvClientes.ServerReport.BearerToken = Nothing
        Me.rpvClientes.Size = New System.Drawing.Size(776, 426)
        Me.rpvClientes.TabIndex = 0
        '
        'ReportehistorialclTableAdapter
        '
        Me.ReportehistorialclTableAdapter.ClearBeforeFill = True
        '
        'FormReporteClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.rpvClientes)
        Me.Name = "FormReporteClientes"
        Me.Text = "Reporte de Clientes"
        CType(Me.ReportehistorialclBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rpvClientes As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReportehistorialclBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents ReportehistorialclTableAdapter As DataSet1TableAdapters.ReportehistorialclTableAdapter
End Class
