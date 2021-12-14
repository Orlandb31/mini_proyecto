<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdividir
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
        Me.mensaje = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.p1 = New Guna.UI.WinForms.GunaPanel()
        Me.txtresultado = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtnumero2 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtnumero1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.aviso = New System.Windows.Forms.Label()
        Me.Button1 = New Guna.UI.WinForms.GunaButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.p1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mensaje
        '
        Me.mensaje.AutoSize = True
        Me.mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mensaje.ForeColor = System.Drawing.Color.Red
        Me.mensaje.Location = New System.Drawing.Point(159, 315)
        Me.mensaje.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.mensaje.Name = "mensaje"
        Me.mensaje.Size = New System.Drawing.Size(0, 20)
        Me.mensaje.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(132, 52)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dividir dos Numeros"
        '
        'p1
        '
        Me.p1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.p1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.p1.Controls.Add(Me.txtresultado)
        Me.p1.Controls.Add(Me.txtnumero2)
        Me.p1.Controls.Add(Me.txtnumero1)
        Me.p1.Controls.Add(Me.aviso)
        Me.p1.Controls.Add(Me.Button1)
        Me.p1.Controls.Add(Me.Label4)
        Me.p1.Controls.Add(Me.Label3)
        Me.p1.Controls.Add(Me.Label2)
        Me.p1.Controls.Add(Me.Label1)
        Me.p1.Location = New System.Drawing.Point(68, 43)
        Me.p1.Name = "p1"
        Me.p1.Size = New System.Drawing.Size(445, 400)
        Me.p1.TabIndex = 9
        '
        'txtresultado
        '
        Me.txtresultado.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtresultado.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtresultado.ForeColor = System.Drawing.Color.White
        Me.txtresultado.HintForeColor = System.Drawing.Color.SkyBlue
        Me.txtresultado.HintText = ""
        Me.txtresultado.isPassword = False
        Me.txtresultado.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.txtresultado.LineIdleColor = System.Drawing.Color.Gray
        Me.txtresultado.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.txtresultado.LineThickness = 4
        Me.txtresultado.Location = New System.Drawing.Point(196, 254)
        Me.txtresultado.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtresultado.Name = "txtresultado"
        Me.txtresultado.Size = New System.Drawing.Size(167, 38)
        Me.txtresultado.TabIndex = 21
        Me.txtresultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtnumero2
        '
        Me.txtnumero2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnumero2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtnumero2.ForeColor = System.Drawing.Color.White
        Me.txtnumero2.HintForeColor = System.Drawing.Color.SkyBlue
        Me.txtnumero2.HintText = ""
        Me.txtnumero2.isPassword = False
        Me.txtnumero2.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.txtnumero2.LineIdleColor = System.Drawing.Color.Gray
        Me.txtnumero2.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.txtnumero2.LineThickness = 4
        Me.txtnumero2.Location = New System.Drawing.Point(196, 170)
        Me.txtnumero2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtnumero2.Name = "txtnumero2"
        Me.txtnumero2.Size = New System.Drawing.Size(167, 38)
        Me.txtnumero2.TabIndex = 20
        Me.txtnumero2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtnumero1
        '
        Me.txtnumero1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnumero1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtnumero1.ForeColor = System.Drawing.Color.White
        Me.txtnumero1.HintForeColor = System.Drawing.Color.SkyBlue
        Me.txtnumero1.HintText = ""
        Me.txtnumero1.isPassword = False
        Me.txtnumero1.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.txtnumero1.LineIdleColor = System.Drawing.Color.Gray
        Me.txtnumero1.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.txtnumero1.LineThickness = 4
        Me.txtnumero1.Location = New System.Drawing.Point(196, 97)
        Me.txtnumero1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtnumero1.Name = "txtnumero1"
        Me.txtnumero1.Size = New System.Drawing.Size(167, 38)
        Me.txtnumero1.TabIndex = 19
        Me.txtnumero1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'aviso
        '
        Me.aviso.AutoSize = True
        Me.aviso.BackColor = System.Drawing.Color.Transparent
        Me.aviso.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aviso.ForeColor = System.Drawing.Color.Red
        Me.aviso.Location = New System.Drawing.Point(58, 295)
        Me.aviso.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.aviso.Name = "aviso"
        Me.aviso.Size = New System.Drawing.Size(0, 26)
        Me.aviso.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.Animated = True
        Me.Button1.AnimationHoverSpeed = 0.07!
        Me.Button1.AnimationSpeed = 0.03!
        Me.Button1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Button1.BorderColor = System.Drawing.Color.Black
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Button1.FocusedColor = System.Drawing.Color.Empty
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Nothing
        Me.Button1.ImageSize = New System.Drawing.Size(20, 20)
        Me.Button1.Location = New System.Drawing.Point(105, 341)
        Me.Button1.Name = "Button1"
        Me.Button1.OnHoverBaseColor = System.Drawing.Color.SpringGreen
        Me.Button1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Button1.OnHoverForeColor = System.Drawing.Color.White
        Me.Button1.OnHoverImage = Nothing
        Me.Button1.OnPressedColor = System.Drawing.Color.Black
        Me.Button1.Size = New System.Drawing.Size(200, 40)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Dividir"
        Me.Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Location = New System.Drawing.Point(76, 272)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 23)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Resultado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Location = New System.Drawing.Point(76, 185)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 23)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Numero 2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Location = New System.Drawing.Point(76, 112)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 23)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Numero 1"
        '
        'frmdividir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(600, 515)
        Me.ControlBox = False
        Me.Controls.Add(Me.p1)
        Me.Controls.Add(Me.mensaje)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmdividir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmdividir"
        Me.p1.ResumeLayout(False)
        Me.p1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mensaje As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents p1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents aviso As Label
    Friend WithEvents txtnumero1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtresultado As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtnumero2 As Bunifu.Framework.UI.BunifuMaterialTextbox
End Class
