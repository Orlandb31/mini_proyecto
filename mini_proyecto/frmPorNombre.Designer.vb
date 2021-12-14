<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPorNombre
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
        Me.components = New System.ComponentModel.Container()
        Me.ByNameDataSet1 = New mini_proyecto.DemoWS.ByNameDataSet()
        Me.ByNameDataSet2 = New mini_proyecto.DemoWS.ByNameDataSet()
        Me.QueryByNameDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QueryByNameBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BinSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.panel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.btnBuscar = New Guna.UI.WinForms.GunaButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnombre = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.dtgrid = New System.Windows.Forms.DataGridView()
        CType(Me.ByNameDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ByNameDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QueryByNameDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QueryByNameBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BinSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        CType(Me.dtgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ByNameDataSet1
        '
        Me.ByNameDataSet1.DataSetName = "ByNameDataSet"
        Me.ByNameDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ByNameDataSet2
        '
        Me.ByNameDataSet2.DataSetName = "ByNameDataSet"
        Me.ByNameDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QueryByNameDataSetBindingSource
        '
        Me.QueryByNameDataSetBindingSource.DataSource = GetType(mini_proyecto.DemoWS.QueryByName_DataSet)
        Me.QueryByNameDataSetBindingSource.Position = 0
        '
        'QueryByNameBindingSource
        '
        Me.QueryByNameBindingSource.DataMember = "QueryByName"
        Me.QueryByNameBindingSource.DataSource = Me.QueryByNameDataSetBindingSource
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.panel1.Controls.Add(Me.btnBuscar)
        Me.panel1.Controls.Add(Me.Label2)
        Me.panel1.Controls.Add(Me.Label1)
        Me.panel1.Controls.Add(Me.txtnombre)
        Me.panel1.Controls.Add(Me.dtgrid)
        Me.panel1.Location = New System.Drawing.Point(32, 31)
        Me.panel1.Name = "panel1"
        Me.panel1.ShadowDecoration.Parent = Me.panel1
        Me.panel1.Size = New System.Drawing.Size(724, 470)
        Me.panel1.TabIndex = 8
        '
        'btnBuscar
        '
        Me.btnBuscar.Animated = True
        Me.btnBuscar.AnimationHoverSpeed = 0.07!
        Me.btnBuscar.AnimationSpeed = 0.03!
        Me.btnBuscar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnBuscar.BorderColor = System.Drawing.Color.Black
        Me.btnBuscar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnBuscar.FocusedColor = System.Drawing.Color.Empty
        Me.btnBuscar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Image = Nothing
        Me.btnBuscar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnBuscar.Location = New System.Drawing.Point(515, 102)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.OnHoverBaseColor = System.Drawing.Color.SpringGreen
        Me.btnBuscar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnBuscar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnBuscar.OnHoverImage = Nothing
        Me.btnBuscar.OnPressedColor = System.Drawing.Color.Black
        Me.btnBuscar.Size = New System.Drawing.Size(146, 42)
        Me.btnBuscar.TabIndex = 24
        Me.btnBuscar.Text = "Encontrar"
        Me.btnBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Location = New System.Drawing.Point(56, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 23)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Ingrese un nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(266, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 23)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Buscar por Nombre"
        '
        'txtnombre
        '
        Me.txtnombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtnombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtnombre.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txtnombre.HintForeColor = System.Drawing.SystemColors.ControlLight
        Me.txtnombre.HintText = ""
        Me.txtnombre.isPassword = False
        Me.txtnombre.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.txtnombre.LineIdleColor = System.Drawing.Color.Gray
        Me.txtnombre.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.txtnombre.LineThickness = 4
        Me.txtnombre.Location = New System.Drawing.Point(270, 102)
        Me.txtnombre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(167, 38)
        Me.txtnombre.TabIndex = 20
        Me.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'dtgrid
        '
        Me.dtgrid.AllowUserToAddRows = False
        Me.dtgrid.AllowUserToDeleteRows = False
        Me.dtgrid.BackgroundColor = System.Drawing.Color.White
        Me.dtgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgrid.Location = New System.Drawing.Point(60, 176)
        Me.dtgrid.Name = "dtgrid"
        Me.dtgrid.ReadOnly = True
        Me.dtgrid.Size = New System.Drawing.Size(601, 243)
        Me.dtgrid.TabIndex = 11
        '
        'frmPorNombre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(816, 540)
        Me.ControlBox = False
        Me.Controls.Add(Me.panel1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmPorNombre"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.ByNameDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ByNameDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QueryByNameDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QueryByNameBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BinSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.dtgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ByNameDataSet1 As DemoWS.ByNameDataSet
    Friend WithEvents ByNameDataSet2 As DemoWS.ByNameDataSet
    Friend WithEvents QueryByNameBindingSource As BindingSource
    Friend WithEvents QueryByNameDataSetBindingSource As BindingSource
    Friend WithEvents BinSource As BindingSource
    Friend WithEvents panel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents dtgrid As DataGridView
    Friend WithEvents txtnombre As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBuscar As Guna.UI.WinForms.GunaButton
End Class
