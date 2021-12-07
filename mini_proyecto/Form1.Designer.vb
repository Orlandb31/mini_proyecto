<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SumaDeDosEnterosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DivisionDeDosEnterosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncuentraPersonaPorIdToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindpersonidToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetDataSetByNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetListByNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LookupCityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft JhengHei", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(404, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MINI PROYECTO "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(362, 220)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(281, 100)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "INTEGRANTES: CASTILLO,WENCERS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "BORRERO,ORLANDO " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "GREEN,ABRRAHAM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "GUITIERREZ,LUIS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-1LS132-"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SumaDeDosEnterosToolStripMenuItem, Me.DivisionDeDosEnterosToolStripMenuItem, Me.EncuentraPersonaPorIdToolStripMenuItem, Me.FindpersonidToolStripMenuItem, Me.GetDataSetByNameToolStripMenuItem, Me.GetListByNameToolStripMenuItem, Me.LookupCityToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(708, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SumaDeDosEnterosToolStripMenuItem
        '
        Me.SumaDeDosEnterosToolStripMenuItem.Name = "SumaDeDosEnterosToolStripMenuItem"
        Me.SumaDeDosEnterosToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.SumaDeDosEnterosToolStripMenuItem.Text = "AdInteger"
        '
        'DivisionDeDosEnterosToolStripMenuItem
        '
        Me.DivisionDeDosEnterosToolStripMenuItem.Name = "DivisionDeDosEnterosToolStripMenuItem"
        Me.DivisionDeDosEnterosToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.DivisionDeDosEnterosToolStripMenuItem.Text = "DividirInteger"
        '
        'EncuentraPersonaPorIdToolStripMenuItem
        '
        Me.EncuentraPersonaPorIdToolStripMenuItem.Name = "EncuentraPersonaPorIdToolStripMenuItem"
        Me.EncuentraPersonaPorIdToolStripMenuItem.Size = New System.Drawing.Size(12, 20)
        '
        'FindpersonidToolStripMenuItem
        '
        Me.FindpersonidToolStripMenuItem.Name = "FindpersonidToolStripMenuItem"
        Me.FindpersonidToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.FindpersonidToolStripMenuItem.Text = "FindPerson"
        '
        'GetDataSetByNameToolStripMenuItem
        '
        Me.GetDataSetByNameToolStripMenuItem.Name = "GetDataSetByNameToolStripMenuItem"
        Me.GetDataSetByNameToolStripMenuItem.Size = New System.Drawing.Size(122, 20)
        Me.GetDataSetByNameToolStripMenuItem.Text = "GetDataSetByName"
        '
        'GetListByNameToolStripMenuItem
        '
        Me.GetListByNameToolStripMenuItem.Name = "GetListByNameToolStripMenuItem"
        Me.GetListByNameToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.GetListByNameToolStripMenuItem.Text = "GetListByName"
        '
        'LookupCityToolStripMenuItem
        '
        Me.LookupCityToolStripMenuItem.Name = "LookupCityToolStripMenuItem"
        Me.LookupCityToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.LookupCityToolStripMenuItem.Text = "LookupCity"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SumaDeDosEnterosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DivisionDeDosEnterosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncuentraPersonaPorIdToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FindpersonidToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GetDataSetByNameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GetListByNameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LookupCityToolStripMenuItem As ToolStripMenuItem
End Class
