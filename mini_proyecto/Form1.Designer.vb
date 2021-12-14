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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SumaDeDosEnterosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DivisionDeDosEnterosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindpersonidToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetDataSetByNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetListByNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LookupCityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.l3 = New Guna.UI.WinForms.GunaLabel()
        Me.l2 = New Guna.UI.WinForms.GunaLabel()
        Me.l1 = New Guna.UI.WinForms.GunaLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(377, 151)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 184)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Integrantes:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Castillo,Wencers" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Borrero, Orlando" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Green, Abraham" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Gutierrez, Lu" &
    "is" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     -1LS132-"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AllowMerge = False
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SumaDeDosEnterosToolStripMenuItem, Me.DivisionDeDosEnterosToolStripMenuItem, Me.FindpersonidToolStripMenuItem, Me.GetDataSetByNameToolStripMenuItem, Me.GetListByNameToolStripMenuItem, Me.LookupCityToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(992, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SumaDeDosEnterosToolStripMenuItem
        '
        Me.SumaDeDosEnterosToolStripMenuItem.Name = "SumaDeDosEnterosToolStripMenuItem"
        Me.SumaDeDosEnterosToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.SumaDeDosEnterosToolStripMenuItem.Text = "AdInteger"
        '
        'DivisionDeDosEnterosToolStripMenuItem
        '
        Me.DivisionDeDosEnterosToolStripMenuItem.Name = "DivisionDeDosEnterosToolStripMenuItem"
        Me.DivisionDeDosEnterosToolStripMenuItem.Size = New System.Drawing.Size(97, 20)
        Me.DivisionDeDosEnterosToolStripMenuItem.Text = "DividirInteger"
        '
        'FindpersonidToolStripMenuItem
        '
        Me.FindpersonidToolStripMenuItem.Name = "FindpersonidToolStripMenuItem"
        Me.FindpersonidToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.FindpersonidToolStripMenuItem.Text = "FindPerson"
        '
        'GetDataSetByNameToolStripMenuItem
        '
        Me.GetDataSetByNameToolStripMenuItem.Name = "GetDataSetByNameToolStripMenuItem"
        Me.GetDataSetByNameToolStripMenuItem.Size = New System.Drawing.Size(134, 20)
        Me.GetDataSetByNameToolStripMenuItem.Text = "GetDataSetByName"
        '
        'GetListByNameToolStripMenuItem
        '
        Me.GetListByNameToolStripMenuItem.Name = "GetListByNameToolStripMenuItem"
        Me.GetListByNameToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.GetListByNameToolStripMenuItem.Text = "GetListByName"
        '
        'LookupCityToolStripMenuItem
        '
        Me.LookupCityToolStripMenuItem.Name = "LookupCityToolStripMenuItem"
        Me.LookupCityToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.LookupCityToolStripMenuItem.Text = "LookupCity"
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.MainPanel.Controls.Add(Me.PictureBox1)
        Me.MainPanel.Controls.Add(Me.l3)
        Me.MainPanel.Controls.Add(Me.l2)
        Me.MainPanel.Controls.Add(Me.l1)
        Me.MainPanel.Controls.Add(Me.Label2)
        Me.MainPanel.Location = New System.Drawing.Point(0, 27)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(992, 561)
        Me.MainPanel.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.mini_proyecto.My.Resources.Resources.LogoUTP
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(825, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 123)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'l3
        '
        Me.l3.AutoSize = True
        Me.l3.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.l3.ForeColor = System.Drawing.Color.Silver
        Me.l3.Location = New System.Drawing.Point(475, 103)
        Me.l3.Name = "l3"
        Me.l3.Size = New System.Drawing.Size(67, 20)
        Me.l3.TabIndex = 4
        Me.l3.Text = "Proyecto"
        '
        'l2
        '
        Me.l2.AutoSize = True
        Me.l2.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.l2.ForeColor = System.Drawing.Color.Silver
        Me.l2.Location = New System.Drawing.Point(476, 69)
        Me.l2.Name = "l2"
        Me.l2.Size = New System.Drawing.Size(66, 32)
        Me.l2.TabIndex = 5
        Me.l2.Text = "MINI"
        '
        'l1
        '
        Me.l1.AutoSize = True
        Me.l1.Font = New System.Drawing.Font("Segoe UI", 40.0!, System.Drawing.FontStyle.Bold)
        Me.l1.ForeColor = System.Drawing.Color.Silver
        Me.l1.Location = New System.Drawing.Point(361, 60)
        Me.l1.Name = "l1"
        Me.l1.Size = New System.Drawing.Size(134, 72)
        Me.l1.TabIndex = 3
        Me.l1.Text = "UTP"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 600)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SumaDeDosEnterosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DivisionDeDosEnterosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FindpersonidToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GetDataSetByNameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GetListByNameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LookupCityToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MainPanel As Panel
    Friend WithEvents l3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents l2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents l1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents PictureBox1 As PictureBox
End Class
