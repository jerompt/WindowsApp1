<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarAsamblea
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvAsamblea = New System.Windows.Forms.DataGridView()
        Me.tbx_nombreA = New System.Windows.Forms.TextBox()
        Me.tbx_FechaA = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbx_Asambleas = New System.Windows.Forms.ComboBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.dgv_numPunto = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbx_punto = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.dgvAsamblea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_numPunto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(30, 166)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(154, 41)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "+ Asamblea"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgvAsamblea
        '
        Me.dgvAsamblea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAsamblea.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAsamblea.Location = New System.Drawing.Point(30, 226)
        Me.dgvAsamblea.Name = "dgvAsamblea"
        Me.dgvAsamblea.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvAsamblea.RowTemplate.Height = 24
        Me.dgvAsamblea.Size = New System.Drawing.Size(865, 560)
        Me.dgvAsamblea.TabIndex = 1
        '
        'tbx_nombreA
        '
        Me.tbx_nombreA.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_nombreA.Location = New System.Drawing.Point(144, 90)
        Me.tbx_nombreA.Name = "tbx_nombreA"
        Me.tbx_nombreA.Size = New System.Drawing.Size(332, 32)
        Me.tbx_nombreA.TabIndex = 2
        '
        'tbx_FechaA
        '
        Me.tbx_FechaA.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_FechaA.Location = New System.Drawing.Point(144, 128)
        Me.tbx_FechaA.Name = "tbx_FechaA"
        Me.tbx_FechaA.Size = New System.Drawing.Size(332, 32)
        Me.tbx_FechaA.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nombre: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Fecha:"
        '
        'cbx_Asambleas
        '
        Me.cbx_Asambleas.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_Asambleas.FormattingEnabled = True
        Me.cbx_Asambleas.Location = New System.Drawing.Point(929, 91)
        Me.cbx_Asambleas.Name = "cbx_Asambleas"
        Me.cbx_Asambleas.Size = New System.Drawing.Size(446, 31)
        Me.cbx_Asambleas.TabIndex = 6
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Century Gothic", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(12, 9)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(489, 40)
        Me.lblNombre.TabIndex = 7
        Me.lblNombre.Text = "Sistema de Votación Cobalto"
        '
        'dgv_numPunto
        '
        Me.dgv_numPunto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 10.2!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_numPunto.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_numPunto.Location = New System.Drawing.Point(914, 226)
        Me.dgv_numPunto.Name = "dgv_numPunto"
        Me.dgv_numPunto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgv_numPunto.RowTemplate.Height = 24
        Me.dgv_numPunto.Size = New System.Drawing.Size(495, 560)
        Me.dgv_numPunto.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(926, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 23)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Número"
        '
        'tbx_punto
        '
        Me.tbx_punto.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_punto.Location = New System.Drawing.Point(1043, 128)
        Me.tbx_punto.Name = "tbx_punto"
        Me.tbx_punto.Size = New System.Drawing.Size(332, 32)
        Me.tbx_punto.TabIndex = 10
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(930, 166)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(154, 41)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "+ Punto"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(926, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(252, 23)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Selecciona la Asamblea"
        '
        'btn_refresh
        '
        Me.btn_refresh.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_refresh.Location = New System.Drawing.Point(1283, 15)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(154, 41)
        Me.btn_refresh.TabIndex = 14
        Me.btn_refresh.Text = "refresh"
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(1283, 795)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(154, 41)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Back"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'AgregarAsamblea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1449, 848)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbx_punto)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.dgv_numPunto)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.cbx_Asambleas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbx_FechaA)
        Me.Controls.Add(Me.tbx_nombreA)
        Me.Controls.Add(Me.dgvAsamblea)
        Me.Controls.Add(Me.Button1)
        Me.Name = "AgregarAsamblea"
        Me.Text = "AgregarAsamblea"
        CType(Me.dgvAsamblea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_numPunto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents dgvAsamblea As DataGridView
    Friend WithEvents tbx_nombreA As TextBox
    Friend WithEvents tbx_FechaA As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbx_Asambleas As ComboBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents dgv_numPunto As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents tbx_punto As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_refresh As Button
    Friend WithEvents Button3 As Button
End Class
