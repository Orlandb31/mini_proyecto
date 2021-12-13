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
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ByNameDataSet2 = New mini_proyecto.DemoWS.ByNameDataSet()
        Me.dtgrid = New System.Windows.Forms.DataGridView()
        Me.QueryByNameDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QueryByNameBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BinSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.ByNameDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ByNameDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QueryByNameDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QueryByNameBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BinSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ByNameDataSet1
        '
        Me.ByNameDataSet1.DataSetName = "ByNameDataSet"
        Me.ByNameDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(70, 54)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(155, 13)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Ingrese un nombre para Buscar"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(104, 95)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(76, 20)
        Me.txtNombre.TabIndex = 1
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(114, 149)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(56, 19)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.lblNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(86, 23)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(362, 199)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Formulario"
        '
        'ByNameDataSet2
        '
        Me.ByNameDataSet2.DataSetName = "ByNameDataSet"
        Me.ByNameDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtgrid
        '
        Me.dtgrid.AllowUserToAddRows = False
        Me.dtgrid.AllowUserToDeleteRows = False
        Me.dtgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgrid.Location = New System.Drawing.Point(86, 241)
        Me.dtgrid.Name = "dtgrid"
        Me.dtgrid.ReadOnly = True
        Me.dtgrid.Size = New System.Drawing.Size(653, 295)
        Me.dtgrid.TabIndex = 4
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
        'frmPorNombre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 621)
        Me.Controls.Add(Me.dtgrid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmPorNombre"
        CType(Me.ByNameDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ByNameDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QueryByNameDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QueryByNameBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BinSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ByNameDataSet1 As DemoWS.ByNameDataSet
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ByNameDataSet2 As DemoWS.ByNameDataSet
    Friend WithEvents dtgrid As DataGridView
    Friend WithEvents QueryByNameBindingSource As BindingSource
    Friend WithEvents QueryByNameDataSetBindingSource As BindingSource
    Friend WithEvents BinSource As BindingSource
End Class
