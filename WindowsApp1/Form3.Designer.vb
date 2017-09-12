<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.pbx_Picture = New System.Windows.Forms.PictureBox()
        Me.lblNomA = New System.Windows.Forms.Label()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.Cbx_fechaAsamblea = New System.Windows.Forms.ComboBox()
        Me.Cbx_Asambleas = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Cbx_Ipuntos = New System.Windows.Forms.CheckedListBox()
        CType(Me.pbx_Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGenerate
        '
        Me.btnGenerate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.Location = New System.Drawing.Point(81, 264)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(236, 55)
        Me.btnGenerate.TabIndex = 0
        Me.btnGenerate.Text = "Generar Codigos"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'pbx_Picture
        '
        Me.pbx_Picture.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbx_Picture.Location = New System.Drawing.Point(391, 52)
        Me.pbx_Picture.Name = "pbx_Picture"
        Me.pbx_Picture.Size = New System.Drawing.Size(705, 515)
        Me.pbx_Picture.TabIndex = 17
        Me.pbx_Picture.TabStop = False
        '
        'lblNomA
        '
        Me.lblNomA.AutoSize = True
        Me.lblNomA.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomA.Location = New System.Drawing.Point(38, 162)
        Me.lblNomA.Name = "lblNomA"
        Me.lblNomA.Size = New System.Drawing.Size(0, 23)
        Me.lblNomA.TabIndex = 18
        '
        'btnRegresar
        '
        Me.btnRegresar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRegresar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegresar.Location = New System.Drawing.Point(12, 529)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(123, 38)
        Me.btnRegresar.TabIndex = 19
        Me.btnRegresar.Text = "Back"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(373, 23)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Selecciona la fecha de la asamblea"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Century Gothic", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(9, 9)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(489, 40)
        Me.lblNombre.TabIndex = 22
        Me.lblNombre.Text = "Sistema de Votación Cobalto"
        '
        'Cbx_fechaAsamblea
        '
        Me.Cbx_fechaAsamblea.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbx_fechaAsamblea.FormattingEnabled = True
        Me.Cbx_fechaAsamblea.Location = New System.Drawing.Point(66, 94)
        Me.Cbx_fechaAsamblea.Name = "Cbx_fechaAsamblea"
        Me.Cbx_fechaAsamblea.Size = New System.Drawing.Size(276, 31)
        Me.Cbx_fechaAsamblea.TabIndex = 23
        '
        'Cbx_Asambleas
        '
        Me.Cbx_Asambleas.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbx_Asambleas.FormattingEnabled = True
        Me.Cbx_Asambleas.Location = New System.Drawing.Point(61, 188)
        Me.Cbx_Asambleas.Name = "Cbx_Asambleas"
        Me.Cbx_Asambleas.Size = New System.Drawing.Size(276, 31)
        Me.Cbx_Asambleas.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(77, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(251, 23)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Selecciona la asamblea"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(141, 542)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(164, 21)
        Me.CheckBox1.TabIndex = 26
        Me.CheckBox1.Text = "Opciones Avanzadas"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Cbx_Ipuntos
        '
        Me.Cbx_Ipuntos.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbx_Ipuntos.FormattingEnabled = True
        Me.Cbx_Ipuntos.Location = New System.Drawing.Point(100, 235)
        Me.Cbx_Ipuntos.Name = "Cbx_Ipuntos"
        Me.Cbx_Ipuntos.Size = New System.Drawing.Size(182, 188)
        Me.Cbx_Ipuntos.TabIndex = 27
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1108, 579)
        Me.Controls.Add(Me.Cbx_Ipuntos)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Cbx_Asambleas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Cbx_fechaAsamblea)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.lblNomA)
        Me.Controls.Add(Me.pbx_Picture)
        Me.Controls.Add(Me.btnGenerate)
        Me.Name = "Form3"
        Me.Text = "Sistema de Votacion Cobalto"
        CType(Me.pbx_Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGenerate As Button
    Friend WithEvents pbx_Picture As PictureBox
    Friend WithEvents lblNomA As Label
    Private WithEvents btnRegresar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents Cbx_fechaAsamblea As ComboBox
    Friend WithEvents Cbx_Asambleas As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Cbx_Ipuntos As CheckedListBox
End Class
