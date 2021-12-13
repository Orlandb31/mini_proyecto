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
        Me.aviso = New System.Windows.Forms.Label()
        Me.Button1 = New Guna.UI.WinForms.GunaButton()
        Me.txtresultado = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnumero2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnumero1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.p1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mensaje
        '
        Me.mensaje.AutoSize = True
        Me.mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mensaje.ForeColor = System.Drawing.Color.Red
        Me.mensaje.Location = New System.Drawing.Point(212, 388)
        Me.mensaje.Name = "mensaje"
        Me.mensaje.Size = New System.Drawing.Size(0, 25)
        Me.mensaje.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(135, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dividir dos Numeros"
        '
        'p1
        '
        Me.p1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.p1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.p1.Controls.Add(Me.aviso)
        Me.p1.Controls.Add(Me.Button1)
        Me.p1.Controls.Add(Me.txtresultado)
        Me.p1.Controls.Add(Me.Label4)
        Me.p1.Controls.Add(Me.txtnumero2)
        Me.p1.Controls.Add(Me.Label3)
        Me.p1.Controls.Add(Me.Label2)
        Me.p1.Controls.Add(Me.txtnumero1)
        Me.p1.Controls.Add(Me.Label1)
        Me.p1.Location = New System.Drawing.Point(217, 40)
        Me.p1.Margin = New System.Windows.Forms.Padding(4)
        Me.p1.Name = "p1"
        Me.p1.Size = New System.Drawing.Size(490, 533)
        Me.p1.TabIndex = 9
        '
        'aviso
        '
        Me.aviso.AutoSize = True
        Me.aviso.BackColor = System.Drawing.Color.Transparent
        Me.aviso.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aviso.ForeColor = System.Drawing.Color.Red
        Me.aviso.Location = New System.Drawing.Point(78, 363)
        Me.aviso.Name = "aviso"
        Me.aviso.Size = New System.Drawing.Size(0, 31)
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
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Nothing
        Me.Button1.ImageSize = New System.Drawing.Size(20, 20)
        Me.Button1.Location = New System.Drawing.Point(120, 423)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.OnHoverBaseColor = System.Drawing.Color.SpringGreen
        Me.Button1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Button1.OnHoverForeColor = System.Drawing.Color.White
        Me.Button1.OnHoverImage = Nothing
        Me.Button1.OnPressedColor = System.Drawing.Color.Black
        Me.Button1.Size = New System.Drawing.Size(279, 52)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Dividir"
        Me.Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtresultado
        '
        Me.txtresultado.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtresultado.DefaultText = ""
        Me.txtresultado.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtresultado.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtresultado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtresultado.DisabledState.Parent = Me.txtresultado
        Me.txtresultado.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtresultado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtresultado.FocusedState.Parent = Me.txtresultado
        Me.txtresultado.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtresultado.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtresultado.HoverState.Parent = Me.txtresultado
        Me.txtresultado.Location = New System.Drawing.Point(201, 287)
        Me.txtresultado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtresultado.Name = "txtresultado"
        Me.txtresultado.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtresultado.PlaceholderText = ""
        Me.txtresultado.ReadOnly = True
        Me.txtresultado.SelectedText = ""
        Me.txtresultado.ShadowDecoration.Parent = Me.txtresultado
        Me.txtresultado.Size = New System.Drawing.Size(223, 44)
        Me.txtresultado.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Location = New System.Drawing.Point(48, 300)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 31)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Resultado"
        '
        'txtnumero2
        '
        Me.txtnumero2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnumero2.DefaultText = ""
        Me.txtnumero2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtnumero2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtnumero2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtnumero2.DisabledState.Parent = Me.txtnumero2
        Me.txtnumero2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtnumero2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtnumero2.FocusedState.Parent = Me.txtnumero2
        Me.txtnumero2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtnumero2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtnumero2.HoverState.Parent = Me.txtnumero2
        Me.txtnumero2.Location = New System.Drawing.Point(201, 193)
        Me.txtnumero2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnumero2.Name = "txtnumero2"
        Me.txtnumero2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnumero2.PlaceholderText = ""
        Me.txtnumero2.SelectedText = ""
        Me.txtnumero2.ShadowDecoration.Parent = Me.txtnumero2
        Me.txtnumero2.Size = New System.Drawing.Size(223, 44)
        Me.txtnumero2.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Location = New System.Drawing.Point(48, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 31)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Numero 2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Location = New System.Drawing.Point(48, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 31)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Numero 1"
        '
        'txtnumero1
        '
        Me.txtnumero1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnumero1.DefaultText = ""
        Me.txtnumero1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtnumero1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtnumero1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtnumero1.DisabledState.Parent = Me.txtnumero1
        Me.txtnumero1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtnumero1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtnumero1.FocusedState.Parent = Me.txtnumero1
        Me.txtnumero1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtnumero1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtnumero1.HoverState.Parent = Me.txtnumero1
        Me.txtnumero1.Location = New System.Drawing.Point(201, 103)
        Me.txtnumero1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnumero1.Name = "txtnumero1"
        Me.txtnumero1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnumero1.PlaceholderText = ""
        Me.txtnumero1.SelectedText = ""
        Me.txtnumero1.ShadowDecoration.Parent = Me.txtnumero1
        Me.txtnumero1.Size = New System.Drawing.Size(223, 44)
        Me.txtnumero1.TabIndex = 11
        '
        'frmdividir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(956, 640)
        Me.Controls.Add(Me.p1)
        Me.Controls.Add(Me.mensaje)
        Me.Name = "frmdividir"
        Me.Text = "frmdividir"
        Me.p1.ResumeLayout(False)
        Me.p1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mensaje As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents p1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents txtnumero1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtresultado As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtnumero2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents aviso As Label
End Class
