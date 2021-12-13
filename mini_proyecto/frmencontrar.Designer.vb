<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmencontrar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.paEncontrar = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.txtID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Button1 = New Guna.UI.WinForms.GunaButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.paEncontrar.SuspendLayout()
        Me.SuspendLayout()
        '
        'paEncontrar
        '
        Me.paEncontrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.paEncontrar.Controls.Add(Me.txtID)
        Me.paEncontrar.Controls.Add(Me.Button1)
        Me.paEncontrar.Controls.Add(Me.Label1)
        Me.paEncontrar.Location = New System.Drawing.Point(70, 66)
        Me.paEncontrar.Name = "paEncontrar"
        Me.paEncontrar.ShadowDecoration.Parent = Me.paEncontrar
        Me.paEncontrar.Size = New System.Drawing.Size(443, 347)
        Me.paEncontrar.TabIndex = 0
        '
        'txtID
        '
        Me.txtID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtID.DefaultText = ""
        Me.txtID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtID.DisabledState.Parent = Me.txtID
        Me.txtID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtID.FocusedState.Parent = Me.txtID
        Me.txtID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtID.HoverState.Parent = Me.txtID
        Me.txtID.Location = New System.Drawing.Point(124, 146)
        Me.txtID.Name = "txtID"
        Me.txtID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtID.PlaceholderText = ""
        Me.txtID.SelectedText = ""
        Me.txtID.ShadowDecoration.Parent = Me.txtID
        Me.txtID.Size = New System.Drawing.Size(200, 36)
        Me.txtID.TabIndex = 10
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
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Nothing
        Me.Button1.ImageSize = New System.Drawing.Size(20, 20)
        Me.Button1.Location = New System.Drawing.Point(124, 269)
        Me.Button1.Name = "Button1"
        Me.Button1.OnHoverBaseColor = System.Drawing.Color.SpringGreen
        Me.Button1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Button1.OnHoverForeColor = System.Drawing.Color.White
        Me.Button1.OnHoverImage = Nothing
        Me.Button1.OnPressedColor = System.Drawing.Color.Black
        Me.Button1.Size = New System.Drawing.Size(209, 42)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Buscar"
        Me.Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(104, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Encontrar Persona con ID"
        '
        'frmencontrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(600, 513)
        Me.Controls.Add(Me.paEncontrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmencontrar"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmencontrar"
        Me.paEncontrar.ResumeLayout(False)
        Me.paEncontrar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents paEncontrar As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents txtID As Guna.UI2.WinForms.Guna2TextBox
End Class
