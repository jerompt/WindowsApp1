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
        Me.components = New System.ComponentModel.Container()
        Me.dgvAsistencia = New System.Windows.Forms.DataGridView()
        Me.lblAsistenciaTotal = New System.Windows.Forms.Label()
        Me.btnVotacion = New System.Windows.Forms.Button()
        Me.btnGenerarCodigos = New System.Windows.Forms.Button()
        Me.btn_CAsamblea = New System.Windows.Forms.Button()
        Me.Asambleas_dbDataSet = New WindowsApp1.asambleas_dbDataSet()
        Me.ProyectosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProyectosTableAdapter = New WindowsApp1.asambleas_dbDataSetTableAdapters.proyectosTableAdapter()
        Me.PropiedadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PropiedadesTableAdapter = New WindowsApp1.asambleas_dbDataSetTableAdapters.propiedadesTableAdapter()
        Me.lblNombre = New System.Windows.Forms.Label()
        CType(Me.dgvAsistencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Asambleas_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PropiedadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAsistencia
        '
        Me.dgvAsistencia.AllowUserToAddRows = False
        Me.dgvAsistencia.AllowUserToDeleteRows = False
        Me.dgvAsistencia.AllowUserToResizeRows = False
        Me.dgvAsistencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAsistencia.Location = New System.Drawing.Point(16, 64)
        Me.dgvAsistencia.Name = "dgvAsistencia"
        Me.dgvAsistencia.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvAsistencia.RowTemplate.Height = 24
        Me.dgvAsistencia.Size = New System.Drawing.Size(979, 709)
        Me.dgvAsistencia.TabIndex = 0
        '
        'lblAsistenciaTotal
        '
        Me.lblAsistenciaTotal.AutoSize = True
        Me.lblAsistenciaTotal.Location = New System.Drawing.Point(384, 44)
        Me.lblAsistenciaTotal.Name = "lblAsistenciaTotal"
        Me.lblAsistenciaTotal.Size = New System.Drawing.Size(0, 17)
        Me.lblAsistenciaTotal.TabIndex = 2
        '
        'btnVotacion
        '
        Me.btnVotacion.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnVotacion.Location = New System.Drawing.Point(1001, 207)
        Me.btnVotacion.Name = "btnVotacion"
        Me.btnVotacion.Size = New System.Drawing.Size(170, 56)
        Me.btnVotacion.TabIndex = 6
        Me.btnVotacion.Text = "Votación"
        Me.btnVotacion.UseVisualStyleBackColor = True
        '
        'btnGenerarCodigos
        '
        Me.btnGenerarCodigos.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnGenerarCodigos.Location = New System.Drawing.Point(1001, 132)
        Me.btnGenerarCodigos.Name = "btnGenerarCodigos"
        Me.btnGenerarCodigos.Size = New System.Drawing.Size(170, 56)
        Me.btnGenerarCodigos.TabIndex = 7
        Me.btnGenerarCodigos.Text = "Generar Codigos para Asamblea"
        Me.btnGenerarCodigos.UseVisualStyleBackColor = True
        '
        'btn_CAsamblea
        '
        Me.btn_CAsamblea.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_CAsamblea.Location = New System.Drawing.Point(1001, 56)
        Me.btn_CAsamblea.Name = "btn_CAsamblea"
        Me.btn_CAsamblea.Size = New System.Drawing.Size(170, 56)
        Me.btn_CAsamblea.TabIndex = 11
        Me.btn_CAsamblea.Text = "Crear Asamblea"
        Me.btn_CAsamblea.UseVisualStyleBackColor = True
        '
        'Asambleas_dbDataSet
        '
        Me.Asambleas_dbDataSet.DataSetName = "asambleas_dbDataSet"
        Me.Asambleas_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProyectosBindingSource
        '
        Me.ProyectosBindingSource.DataMember = "proyectos"
        Me.ProyectosBindingSource.DataSource = Me.Asambleas_dbDataSet
        '
        'ProyectosTableAdapter
        '
        Me.ProyectosTableAdapter.ClearBeforeFill = True
        '
        'PropiedadesBindingSource
        '
        Me.PropiedadesBindingSource.DataMember = "propiedades"
        Me.PropiedadesBindingSource.DataSource = Me.Asambleas_dbDataSet
        '
        'PropiedadesTableAdapter
        '
        Me.PropiedadesTableAdapter.ClearBeforeFill = True
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Century Gothic", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(12, 9)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(501, 40)
        Me.lblNombre.TabIndex = 5
        Me.lblNombre.Text = "Sistema de Votación Cobalto"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1183, 785)
        Me.Controls.Add(Me.btn_CAsamblea)
        Me.Controls.Add(Me.btnGenerarCodigos)
        Me.Controls.Add(Me.btnVotacion)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblAsistenciaTotal)
        Me.Controls.Add(Me.dgvAsistencia)
        Me.Name = "Form1"
        Me.Text = "Sistema de Votacion Cobalto"
        CType(Me.dgvAsistencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Asambleas_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PropiedadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvAsistencia As DataGridView
    Friend WithEvents lblAsistenciaTotal As Label
    Friend WithEvents btnVotacion As Button
    Friend WithEvents btnGenerarCodigos As Button
    Friend WithEvents btn_CAsamblea As Button
    Friend WithEvents Asambleas_dbDataSet As asambleas_dbDataSet
    Friend WithEvents ProyectosBindingSource As BindingSource
    Friend WithEvents ProyectosTableAdapter As asambleas_dbDataSetTableAdapters.proyectosTableAdapter
    Friend WithEvents PropiedadesBindingSource As BindingSource
    Friend WithEvents PropiedadesTableAdapter As asambleas_dbDataSetTableAdapters.propiedadesTableAdapter
    Friend WithEvents lblNombre As Label
End Class
