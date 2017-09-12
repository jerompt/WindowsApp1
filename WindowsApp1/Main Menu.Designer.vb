<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCargarProyecto = New System.Windows.Forms.Button()
        Me.btn_addProy = New System.Windows.Forms.Button()
        Me.tbx_nombre = New System.Windows.Forms.TextBox()
        Me.tbx_num = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Century Gothic", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(12, 9)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(501, 40)
        Me.lblNombre.TabIndex = 6
        Me.lblNombre.Text = "Sistema de Votación Cobalto"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(556, 330)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(288, 31)
        Me.ComboBox1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(655, 290)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 23)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Proyecto"
        '
        'btnCargarProyecto
        '
        Me.btnCargarProyecto.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargarProyecto.Location = New System.Drawing.Point(605, 382)
        Me.btnCargarProyecto.Name = "btnCargarProyecto"
        Me.btnCargarProyecto.Size = New System.Drawing.Size(197, 39)
        Me.btnCargarProyecto.TabIndex = 9
        Me.btnCargarProyecto.Text = "Cargar Proyecto"
        Me.btnCargarProyecto.UseVisualStyleBackColor = True
        '
        'btn_addProy
        '
        Me.btn_addProy.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addProy.Location = New System.Drawing.Point(601, 543)
        Me.btn_addProy.Name = "btn_addProy"
        Me.btn_addProy.Size = New System.Drawing.Size(197, 39)
        Me.btn_addProy.TabIndex = 10
        Me.btn_addProy.Text = "Agregar Proyecto"
        Me.btn_addProy.UseVisualStyleBackColor = True
        '
        'tbx_nombre
        '
        Me.tbx_nombre.Enabled = False
        Me.tbx_nombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_nombre.Location = New System.Drawing.Point(700, 467)
        Me.tbx_nombre.Name = "tbx_nombre"
        Me.tbx_nombre.Size = New System.Drawing.Size(361, 32)
        Me.tbx_nombre.TabIndex = 11
        '
        'tbx_num
        '
        Me.tbx_num.Enabled = False
        Me.tbx_num.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_num.Location = New System.Drawing.Point(700, 505)
        Me.tbx_num.Name = "tbx_num"
        Me.tbx_num.Size = New System.Drawing.Size(72, 32)
        Me.tbx_num.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(457, 470)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(222, 23)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nombre del Proyecto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(428, 508)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(251, 23)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Número de Propiedades"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1499, 794)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbx_num)
        Me.Controls.Add(Me.tbx_nombre)
        Me.Controls.Add(Me.btn_addProy)
        Me.Controls.Add(Me.btnCargarProyecto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lblNombre)
        Me.Name = "Form2"
        Me.Text = "Sistema de Votacion Cobalto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNombre As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCargarProyecto As Button
    Friend WithEvents btn_addProy As Button
    Friend WithEvents tbx_nombre As TextBox
    Friend WithEvents tbx_num As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
