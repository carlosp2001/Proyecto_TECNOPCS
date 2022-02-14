<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporteProductos
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReporteProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New proyecto_de_analisis.DataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ReporteProductosTableAdapter = New proyecto_de_analisis.DataSet1TableAdapters.ReporteProductosTableAdapter()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.ReporteProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReporteProductosBindingSource
        '
        Me.ReporteProductosBindingSource.DataMember = "ReporteProductos"
        Me.ReporteProductosBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.ReporteProductosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "proyecto_de_analisis.ReporteProducto.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 70)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(971, 368)
        Me.ReportViewer1.TabIndex = 0
        '
        'ReporteProductosTableAdapter
        '
        Me.ReporteProductosTableAdapter.ClearBeforeFill = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(211, 26)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(122, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre de Producto:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.proyecto_de_analisis.My.Resources.Resources.WhatsApp_Image_2021_12_10_at_1_20_30_PM
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(923, -7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 71)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'FormReporteProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(995, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FormReporteProductos"
        Me.Text = "Reporte de Productos"
        CType(Me.ReporteProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReporteProductosBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents ReporteProductosTableAdapter As DataSet1TableAdapters.ReporteProductosTableAdapter
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
