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
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.lbldob = New System.Windows.Forms.Label()
        Me.lblssn = New System.Windows.Forms.Label()
        Me.lblage = New System.Windows.Forms.Label()
        Me.lblfc = New System.Windows.Forms.Label()
        Me.lblhcalle = New System.Windows.Forms.Label()
        Me.lblhcity = New System.Windows.Forms.Label()
        Me.lblhestado = New System.Windows.Forms.Label()
        Me.lblhzip = New System.Windows.Forms.Label()
        Me.lblocalle = New System.Windows.Forms.Label()
        Me.lblocity = New System.Windows.Forms.Label()
        Me.lbloestado = New System.Windows.Forms.Label()
        Me.lblozip = New System.Windows.Forms.Label()
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
        Me.GroupBox1.Controls.Add(Me.lblhzip)
        Me.GroupBox1.Controls.Add(Me.lblhestado)
        Me.GroupBox1.Controls.Add(Me.lblhcity)
        Me.GroupBox1.Controls.Add(Me.lblhcalle)
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
        Me.GroupBox2.Controls.Add(Me.lblozip)
        Me.GroupBox2.Controls.Add(Me.lbloestado)
        Me.GroupBox2.Controls.Add(Me.lblocity)
        Me.GroupBox2.Controls.Add(Me.lblocalle)
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
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre.Location = New System.Drawing.Point(147, 103)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(26, 16)
        Me.lblnombre.TabIndex = 9
        Me.lblnombre.Text = "***"
        '
        'lbldob
        '
        Me.lbldob.AutoSize = True
        Me.lbldob.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldob.Location = New System.Drawing.Point(123, 170)
        Me.lbldob.Name = "lbldob"
        Me.lbldob.Size = New System.Drawing.Size(26, 16)
        Me.lbldob.TabIndex = 10
        Me.lbldob.Text = "***"
        '
        'lblssn
        '
        Me.lblssn.AutoSize = True
        Me.lblssn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblssn.Location = New System.Drawing.Point(123, 137)
        Me.lblssn.Name = "lblssn"
        Me.lblssn.Size = New System.Drawing.Size(26, 16)
        Me.lblssn.TabIndex = 11
        Me.lblssn.Text = "***"
        '
        'lblage
        '
        Me.lblage.AutoSize = True
        Me.lblage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblage.Location = New System.Drawing.Point(434, 103)
        Me.lblage.Name = "lblage"
        Me.lblage.Size = New System.Drawing.Size(26, 16)
        Me.lblage.TabIndex = 12
        Me.lblage.Text = "***"
        '
        'lblfc
        '
        Me.lblfc.AutoSize = True
        Me.lblfc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfc.Location = New System.Drawing.Point(495, 137)
        Me.lblfc.Name = "lblfc"
        Me.lblfc.Size = New System.Drawing.Size(26, 16)
        Me.lblfc.TabIndex = 13
        Me.lblfc.Text = "***"
        '
        'lblhcalle
        '
        Me.lblhcalle.AutoSize = True
        Me.lblhcalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhcalle.Location = New System.Drawing.Point(130, 35)
        Me.lblhcalle.Name = "lblhcalle"
        Me.lblhcalle.Size = New System.Drawing.Size(26, 16)
        Me.lblhcalle.TabIndex = 14
        Me.lblhcalle.Text = "***"
        '
        'lblhcity
        '
        Me.lblhcity.AutoSize = True
        Me.lblhcity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhcity.Location = New System.Drawing.Point(130, 68)
        Me.lblhcity.Name = "lblhcity"
        Me.lblhcity.Size = New System.Drawing.Size(26, 16)
        Me.lblhcity.TabIndex = 15
        Me.lblhcity.Text = "***"
        '
        'lblhestado
        '
        Me.lblhestado.AutoSize = True
        Me.lblhestado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhestado.Location = New System.Drawing.Point(130, 96)
        Me.lblhestado.Name = "lblhestado"
        Me.lblhestado.Size = New System.Drawing.Size(26, 16)
        Me.lblhestado.TabIndex = 16
        Me.lblhestado.Text = "***"
        '
        'lblhzip
        '
        Me.lblhzip.AutoSize = True
        Me.lblhzip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhzip.Location = New System.Drawing.Point(130, 129)
        Me.lblhzip.Name = "lblhzip"
        Me.lblhzip.Size = New System.Drawing.Size(26, 16)
        Me.lblhzip.TabIndex = 17
        Me.lblhzip.Text = "***"
        '
        'lblocalle
        '
        Me.lblocalle.AutoSize = True
        Me.lblocalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblocalle.Location = New System.Drawing.Point(177, 35)
        Me.lblocalle.Name = "lblocalle"
        Me.lblocalle.Size = New System.Drawing.Size(26, 16)
        Me.lblocalle.TabIndex = 14
        Me.lblocalle.Text = "***"
        '
        'lblocity
        '
        Me.lblocity.AutoSize = True
        Me.lblocity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblocity.Location = New System.Drawing.Point(177, 68)
        Me.lblocity.Name = "lblocity"
        Me.lblocity.Size = New System.Drawing.Size(26, 16)
        Me.lblocity.TabIndex = 15
        Me.lblocity.Text = "***"
        '
        'lbloestado
        '
        Me.lbloestado.AutoSize = True
        Me.lbloestado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbloestado.Location = New System.Drawing.Point(177, 96)
        Me.lbloestado.Name = "lbloestado"
        Me.lbloestado.Size = New System.Drawing.Size(26, 16)
        Me.lbloestado.TabIndex = 16
        Me.lbloestado.Text = "***"
        '
        'lblozip
        '
        Me.lblozip.AutoSize = True
        Me.lblozip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblozip.Location = New System.Drawing.Point(177, 129)
        Me.lblozip.Name = "lblozip"
        Me.lblozip.Size = New System.Drawing.Size(26, 16)
        Me.lblozip.TabIndex = 17
        Me.lblozip.Text = "***"
        '
        'frmresulperson
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(751, 576)
        Me.Controls.Add(Me.lblfc)
        Me.Controls.Add(Me.lblage)
        Me.Controls.Add(Me.lblssn)
        Me.Controls.Add(Me.lbldob)
        Me.Controls.Add(Me.lblnombre)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmresulperson"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmresulperson"
        Me.TransparencyKey = System.Drawing.Color.Gray
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
    Friend WithEvents lblhzip As Label
    Friend WithEvents lblhestado As Label
    Friend WithEvents lblhcity As Label
    Friend WithEvents lblhcalle As Label
    Friend WithEvents lblozip As Label
    Friend WithEvents lbloestado As Label
    Friend WithEvents lblocity As Label
    Friend WithEvents lblocalle As Label
    Friend WithEvents lblnombre As Label
    Friend WithEvents lbldob As Label
    Friend WithEvents lblssn As Label
    Friend WithEvents lblage As Label
    Friend WithEvents lblfc As Label
End Class
