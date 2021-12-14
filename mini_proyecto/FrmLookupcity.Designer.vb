<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLookupcity
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
        Me.p1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.txtzip = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Button1 = New Guna.UI.WinForms.GunaButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.p1.SuspendLayout()
        Me.SuspendLayout()
        '
        'p1
        '
        Me.p1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.p1.Controls.Add(Me.txtzip)
        Me.p1.Controls.Add(Me.Button1)
        Me.p1.Controls.Add(Me.Label1)
        Me.p1.FillColor = System.Drawing.Color.Transparent
        Me.p1.FillColor2 = System.Drawing.Color.Transparent
        Me.p1.FillColor3 = System.Drawing.Color.Transparent
        Me.p1.FillColor4 = System.Drawing.Color.Transparent
        Me.p1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.p1.Location = New System.Drawing.Point(66, 47)
        Me.p1.Name = "p1"
        Me.p1.ShadowDecoration.Parent = Me.p1
        Me.p1.Size = New System.Drawing.Size(445, 400)
        Me.p1.TabIndex = 0
        '
        'txtzip
        '
        Me.txtzip.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.txtzip.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtzip.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtzip.ForeColor = System.Drawing.Color.White
        Me.txtzip.HintForeColor = System.Drawing.Color.SkyBlue
        Me.txtzip.HintText = ""
        Me.txtzip.isPassword = False
        Me.txtzip.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.txtzip.LineIdleColor = System.Drawing.Color.Gray
        Me.txtzip.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.txtzip.LineThickness = 4
        Me.txtzip.Location = New System.Drawing.Point(106, 166)
        Me.txtzip.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtzip.Name = "txtzip"
        Me.txtzip.Size = New System.Drawing.Size(234, 37)
        Me.txtzip.TabIndex = 21
        Me.txtzip.Text = "Ingrese el codigo zip"
        Me.txtzip.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Nothing
        Me.Button1.ImageSize = New System.Drawing.Size(20, 20)
        Me.Button1.Location = New System.Drawing.Point(106, 310)
        Me.Button1.Name = "Button1"
        Me.Button1.OnHoverBaseColor = System.Drawing.Color.SpringGreen
        Me.Button1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Button1.OnHoverForeColor = System.Drawing.Color.White
        Me.Button1.OnHoverImage = Nothing
        Me.Button1.OnPressedColor = System.Drawing.Color.Black
        Me.Button1.Size = New System.Drawing.Size(209, 42)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Buscar"
        Me.Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(144, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Buscar Ciudad"
        '
        'FrmLookupcity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(584, 476)
        Me.ControlBox = False
        Me.Controls.Add(Me.p1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmLookupcity"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmLookupcity"
        Me.p1.ResumeLayout(False)
        Me.p1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents p1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents txtzip As Bunifu.Framework.UI.BunifuMaterialTextbox
End Class
