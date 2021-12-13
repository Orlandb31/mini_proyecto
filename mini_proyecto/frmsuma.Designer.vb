<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsuma
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
        Me.p1 = New Guna.UI.WinForms.GunaPanel()
        Me.aviso1 = New System.Windows.Forms.Label()
        Me.aviso = New System.Windows.Forms.Label()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.txtresultado = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnumero2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtnumero1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.p1.SuspendLayout()
        Me.SuspendLayout()
        '
        'p1
        '
        Me.p1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.p1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.p1.Controls.Add(Me.aviso1)
        Me.p1.Controls.Add(Me.aviso)
        Me.p1.Controls.Add(Me.GunaButton1)
        Me.p1.Controls.Add(Me.txtresultado)
        Me.p1.Controls.Add(Me.Label4)
        Me.p1.Controls.Add(Me.txtnumero2)
        Me.p1.Controls.Add(Me.Label3)
        Me.p1.Controls.Add(Me.Label5)
        Me.p1.Controls.Add(Me.txtnumero1)
        Me.p1.Controls.Add(Me.Label6)
        Me.p1.Location = New System.Drawing.Point(152, 43)
        Me.p1.Name = "p1"
        Me.p1.Size = New System.Drawing.Size(352, 444)
        Me.p1.TabIndex = 10
        '
        'aviso1
        '
        Me.aviso1.AutoSize = True
        Me.aviso1.BackColor = System.Drawing.Color.Transparent
        Me.aviso1.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aviso1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.aviso1.Location = New System.Drawing.Point(36, 295)
        Me.aviso1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.aviso1.Name = "aviso1"
        Me.aviso1.Size = New System.Drawing.Size(0, 26)
        Me.aviso1.TabIndex = 19
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
        'GunaButton1
        '
        Me.GunaButton1.Animated = True
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton1.ForeColor = System.Drawing.Color.White
        Me.GunaButton1.Image = Nothing
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(74, 353)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.SpringGreen
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Size = New System.Drawing.Size(209, 42)
        Me.GunaButton1.TabIndex = 17
        Me.GunaButton1.Text = "Sumar"
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.txtresultado.Location = New System.Drawing.Point(151, 233)
        Me.txtresultado.Name = "txtresultado"
        Me.txtresultado.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtresultado.PlaceholderText = ""
        Me.txtresultado.ReadOnly = True
        Me.txtresultado.SelectedText = ""
        Me.txtresultado.ShadowDecoration.Parent = Me.txtresultado
        Me.txtresultado.Size = New System.Drawing.Size(167, 36)
        Me.txtresultado.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Location = New System.Drawing.Point(36, 244)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 26)
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
        Me.txtnumero2.Location = New System.Drawing.Point(151, 157)
        Me.txtnumero2.Name = "txtnumero2"
        Me.txtnumero2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnumero2.PlaceholderText = ""
        Me.txtnumero2.SelectedText = ""
        Me.txtnumero2.ShadowDecoration.Parent = Me.txtnumero2
        Me.txtnumero2.Size = New System.Drawing.Size(167, 36)
        Me.txtnumero2.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Location = New System.Drawing.Point(36, 157)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 26)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Numero 2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.Location = New System.Drawing.Point(36, 84)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 26)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Numero 1"
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
        Me.txtnumero1.Location = New System.Drawing.Point(151, 84)
        Me.txtnumero1.Name = "txtnumero1"
        Me.txtnumero1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnumero1.PlaceholderText = ""
        Me.txtnumero1.SelectedText = ""
        Me.txtnumero1.ShadowDecoration.Parent = Me.txtnumero1
        Me.txtnumero1.Size = New System.Drawing.Size(167, 36)
        Me.txtnumero1.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(77, 26)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(206, 26)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Sumar dos Numeros"
        '
        'frmsuma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(683, 549)
        Me.Controls.Add(Me.p1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmsuma"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmsuma"
        Me.p1.ResumeLayout(False)
        Me.p1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents p1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents aviso As Label
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents txtresultado As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtnumero2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtnumero1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents aviso1 As Label
End Class
