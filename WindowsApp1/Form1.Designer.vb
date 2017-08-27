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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvAsistencia = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblAsistenciaTotal = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.btnVotacion = New System.Windows.Forms.Button()
        Me.btnGenerarCodigos = New System.Windows.Forms.Button()
        CType(Me.dgvAsistencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAsistencia
        '
        Me.dgvAsistencia.AllowUserToAddRows = False
        Me.dgvAsistencia.AllowUserToDeleteRows = False
        Me.dgvAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAsistencia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgvAsistencia.Location = New System.Drawing.Point(16, 56)
        Me.dgvAsistencia.Name = "dgvAsistencia"
        Me.dgvAsistencia.RowTemplate.Height = 24
        Me.dgvAsistencia.Size = New System.Drawing.Size(979, 692)
        Me.dgvAsistencia.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Departamento"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Torre"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Propietario"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 250
        '
        'Column4
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft
        DataGridViewCellStyle1.Format = "N4"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column4.HeaderText = "Indiviso"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Asistencia"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'lblAsistenciaTotal
        '
        Me.lblAsistenciaTotal.AutoSize = True
        Me.lblAsistenciaTotal.Location = New System.Drawing.Point(384, 44)
        Me.lblAsistenciaTotal.Name = "lblAsistenciaTotal"
        Me.lblAsistenciaTotal.Size = New System.Drawing.Size(0, 17)
        Me.lblAsistenciaTotal.TabIndex = 2
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(12, 9)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(301, 23)
        Me.lblNombre.TabIndex = 5
        Me.lblNombre.Text = "Sistema de Votación Cobalto"
        '
        'btnVotacion
        '
        Me.btnVotacion.Location = New System.Drawing.Point(1001, 207)
        Me.btnVotacion.Name = "btnVotacion"
        Me.btnVotacion.Size = New System.Drawing.Size(170, 56)
        Me.btnVotacion.TabIndex = 6
        Me.btnVotacion.Text = "Votación"
        Me.btnVotacion.UseVisualStyleBackColor = True
        '
        'btnGenerarCodigos
        '
        Me.btnGenerarCodigos.Location = New System.Drawing.Point(1001, 132)
        Me.btnGenerarCodigos.Name = "btnGenerarCodigos"
        Me.btnGenerarCodigos.Size = New System.Drawing.Size(170, 56)
        Me.btnGenerarCodigos.TabIndex = 7
        Me.btnGenerarCodigos.Text = "Generar Codigos para Asamblea"
        Me.btnGenerarCodigos.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1469, 785)
        Me.Controls.Add(Me.btnGenerarCodigos)
        Me.Controls.Add(Me.btnVotacion)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblAsistenciaTotal)
        Me.Controls.Add(Me.dgvAsistencia)
        Me.Name = "Form1"
        Me.Text = "Sistema de Votacion Cobalto"
        CType(Me.dgvAsistencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvAsistencia As DataGridView
    Friend WithEvents lblAsistenciaTotal As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents lblNombre As Label
    Friend WithEvents btnVotacion As Button
    Friend WithEvents btnGenerarCodigos As Button
End Class
