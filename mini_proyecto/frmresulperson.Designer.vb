<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmresulperson
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtssn = New System.Windows.Forms.TextBox()
        Me.txtdob = New System.Windows.Forms.TextBox()
        Me.txtage = New System.Windows.Forms.TextBox()
        Me.txtcolorfav = New System.Windows.Forms.TextBox()
        Me.txthcalle = New System.Windows.Forms.TextBox()
        Me.txthciudad = New System.Windows.Forms.TextBox()
        Me.txthestate = New System.Windows.Forms.TextBox()
        Me.txthzip = New System.Windows.Forms.TextBox()
        Me.txtocalle = New System.Windows.Forms.TextBox()
        Me.txtociudad = New System.Windows.Forms.TextBox()
        Me.txtoestado = New System.Windows.Forms.TextBox()
        Me.txtozip = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(265, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Datos de la Persona"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(70, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(70, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "SSN :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(69, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "DOB :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txthzip)
        Me.GroupBox1.Controls.Add(Me.txthestate)
        Me.GroupBox1.Controls.Add(Me.txthciudad)
        Me.GroupBox1.Controls.Add(Me.txthcalle)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(73, 216)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(299, 163)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de la Casa"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 129)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 16)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "ZIP :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 16)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Estado :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 16)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Ciudad :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Calle :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(375, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Edad :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(375, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Color Favorito :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtozip)
        Me.GroupBox2.Controls.Add(Me.txtoestado)
        Me.GroupBox2.Controls.Add(Me.txtociudad)
        Me.GroupBox2.Controls.Add(Me.txtocalle)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(378, 216)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(333, 163)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de la Oficina"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 129)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 16)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "ZIP :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 96)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 16)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Estado :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 68)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 16)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Ciudad :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 35)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 16)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Calle :"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(269, 400)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(180, 35)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "CERRAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(148, 100)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.ReadOnly = True
        Me.txtnombre.Size = New System.Drawing.Size(100, 20)
        Me.txtnombre.TabIndex = 9
        '
        'txtssn
        '
        Me.txtssn.Location = New System.Drawing.Point(123, 134)
        Me.txtssn.Name = "txtssn"
        Me.txtssn.ReadOnly = True
        Me.txtssn.Size = New System.Drawing.Size(100, 20)
        Me.txtssn.TabIndex = 10
        '
        'txtdob
        '
        Me.txtdob.Location = New System.Drawing.Point(123, 163)
        Me.txtdob.Name = "txtdob"
        Me.txtdob.ReadOnly = True
        Me.txtdob.Size = New System.Drawing.Size(100, 20)
        Me.txtdob.TabIndex = 11
        '
        'txtage
        '
        Me.txtage.Location = New System.Drawing.Point(434, 100)
        Me.txtage.Name = "txtage"
        Me.txtage.ReadOnly = True
        Me.txtage.Size = New System.Drawing.Size(100, 20)
        Me.txtage.TabIndex = 12
        '
        'txtcolorfav
        '
        Me.txtcolorfav.Location = New System.Drawing.Point(495, 134)
        Me.txtcolorfav.Name = "txtcolorfav"
        Me.txtcolorfav.ReadOnly = True
        Me.txtcolorfav.Size = New System.Drawing.Size(100, 20)
        Me.txtcolorfav.TabIndex = 13
        '
        'txthcalle
        '
        Me.txthcalle.Location = New System.Drawing.Point(109, 32)
        Me.txthcalle.Name = "txthcalle"
        Me.txthcalle.ReadOnly = True
        Me.txthcalle.Size = New System.Drawing.Size(127, 22)
        Me.txthcalle.TabIndex = 14
        '
        'txthciudad
        '
        Me.txthciudad.Location = New System.Drawing.Point(109, 65)
        Me.txthciudad.Name = "txthciudad"
        Me.txthciudad.ReadOnly = True
        Me.txthciudad.Size = New System.Drawing.Size(127, 22)
        Me.txthciudad.TabIndex = 15
        '
        'txthestate
        '
        Me.txthestate.Location = New System.Drawing.Point(109, 93)
        Me.txthestate.Name = "txthestate"
        Me.txthestate.ReadOnly = True
        Me.txthestate.Size = New System.Drawing.Size(127, 22)
        Me.txthestate.TabIndex = 16
        '
        'txthzip
        '
        Me.txthzip.Location = New System.Drawing.Point(109, 126)
        Me.txthzip.Name = "txthzip"
        Me.txthzip.ReadOnly = True
        Me.txthzip.Size = New System.Drawing.Size(127, 22)
        Me.txthzip.TabIndex = 17
        '
        'txtocalle
        '
        Me.txtocalle.Location = New System.Drawing.Point(117, 32)
        Me.txtocalle.Name = "txtocalle"
        Me.txtocalle.ReadOnly = True
        Me.txtocalle.Size = New System.Drawing.Size(160, 22)
        Me.txtocalle.TabIndex = 10
        '
        'txtociudad
        '
        Me.txtociudad.Location = New System.Drawing.Point(117, 65)
        Me.txtociudad.Name = "txtociudad"
        Me.txtociudad.ReadOnly = True
        Me.txtociudad.Size = New System.Drawing.Size(160, 22)
        Me.txtociudad.TabIndex = 11
        '
        'txtoestado
        '
        Me.txtoestado.Location = New System.Drawing.Point(117, 93)
        Me.txtoestado.Name = "txtoestado"
        Me.txtoestado.ReadOnly = True
        Me.txtoestado.Size = New System.Drawing.Size(160, 22)
        Me.txtoestado.TabIndex = 12
        '
        'txtozip
        '
        Me.txtozip.Location = New System.Drawing.Point(117, 126)
        Me.txtozip.Name = "txtozip"
        Me.txtozip.ReadOnly = True
        Me.txtozip.Size = New System.Drawing.Size(160, 22)
        Me.txtozip.TabIndex = 13
        '
        'frmresulperson
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtcolorfav)
        Me.Controls.Add(Me.txtage)
        Me.Controls.Add(Me.txtdob)
        Me.Controls.Add(Me.txtssn)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmresulperson"
        Me.Text = "frmresulperson"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txthzip As TextBox
    Friend WithEvents txthestate As TextBox
    Friend WithEvents txthciudad As TextBox
    Friend WithEvents txthcalle As TextBox
    Friend WithEvents txtozip As TextBox
    Friend WithEvents txtoestado As TextBox
    Friend WithEvents txtociudad As TextBox
    Friend WithEvents txtocalle As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtssn As TextBox
    Friend WithEvents txtdob As TextBox
    Friend WithEvents txtage As TextBox
    Friend WithEvents txtcolorfav As TextBox
End Class
