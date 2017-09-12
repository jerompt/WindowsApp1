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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbxOrdinaria = New System.Windows.Forms.TextBox()
        Me.pbx_Picture = New System.Windows.Forms.PictureBox()
        Me.lblNomA = New System.Windows.Forms.Label()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.tbx_Asamblea = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        CType(Me.pbx_Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGenerate
        '
        Me.btnGenerate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.Location = New System.Drawing.Point(12, 289)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(236, 55)
        Me.btnGenerate.TabIndex = 0
        Me.btnGenerate.Text = "Generar Codigos"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(201, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Enumera los puntos"
        '
        'txtbxOrdinaria
        '
        Me.txtbxOrdinaria.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxOrdinaria.Location = New System.Drawing.Point(12, 159)
        Me.txtbxOrdinaria.Multiline = True
        Me.txtbxOrdinaria.Name = "txtbxOrdinaria"
        Me.txtbxOrdinaria.Size = New System.Drawing.Size(256, 107)
        Me.txtbxOrdinaria.TabIndex = 4
        '
        'pbx_Picture
        '
        Me.pbx_Picture.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbx_Picture.Location = New System.Drawing.Point(308, 52)
        Me.pbx_Picture.Name = "pbx_Picture"
        Me.pbx_Picture.Size = New System.Drawing.Size(788, 515)
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
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'tbx_Asamblea
        '
        Me.tbx_Asamblea.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Asamblea.Location = New System.Drawing.Point(12, 85)
        Me.tbx_Asamblea.Name = "tbx_Asamblea"
        Me.tbx_Asamblea.Size = New System.Drawing.Size(256, 32)
        Me.tbx_Asamblea.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 23)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Nombre de la Asamblea"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Century Gothic", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(9, 9)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(501, 40)
        Me.lblNombre.TabIndex = 22
        Me.lblNombre.Text = "Sistema de Votación Cobalto"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1108, 579)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbx_Asamblea)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.lblNomA)
        Me.Controls.Add(Me.pbx_Picture)
        Me.Controls.Add(Me.txtbxOrdinaria)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnGenerate)
        Me.Name = "Form3"
        Me.Text = "Sistema de Votacion Cobalto"
        CType(Me.pbx_Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGenerate As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbxOrdinaria As TextBox
    Friend WithEvents pbx_Picture As PictureBox
    Friend WithEvents lblNomA As Label
    Private WithEvents btnRegresar As Button
    Friend WithEvents tbx_Asamblea As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNombre As Label
End Class
