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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblnumero1 = New System.Windows.Forms.Label()
        Me.lblnumero2 = New System.Windows.Forms.Label()
        Me.numero1 = New System.Windows.Forms.TextBox()
        Me.numero2 = New System.Windows.Forms.TextBox()
        Me.resultado = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(233, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Suma de Dos Numeros"
        '
        'lblnumero1
        '
        Me.lblnumero1.AutoSize = True
        Me.lblnumero1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnumero1.Location = New System.Drawing.Point(234, 148)
        Me.lblnumero1.Name = "lblnumero1"
        Me.lblnumero1.Size = New System.Drawing.Size(109, 27)
        Me.lblnumero1.TabIndex = 1
        Me.lblnumero1.Text = "Numero 1"
        '
        'lblnumero2
        '
        Me.lblnumero2.AutoSize = True
        Me.lblnumero2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnumero2.Location = New System.Drawing.Point(234, 224)
        Me.lblnumero2.Name = "lblnumero2"
        Me.lblnumero2.Size = New System.Drawing.Size(109, 27)
        Me.lblnumero2.TabIndex = 2
        Me.lblnumero2.Text = "Numero 2"
        '
        'numero1
        '
        Me.numero1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numero1.Location = New System.Drawing.Point(384, 148)
        Me.numero1.Name = "numero1"
        Me.numero1.Size = New System.Drawing.Size(121, 34)
        Me.numero1.TabIndex = 3
        '
        'numero2
        '
        Me.numero2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numero2.Location = New System.Drawing.Point(384, 224)
        Me.numero2.Name = "numero2"
        Me.numero2.Size = New System.Drawing.Size(121, 34)
        Me.numero2.TabIndex = 4
        '
        'resultado
        '
        Me.resultado.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultado.Location = New System.Drawing.Point(384, 302)
        Me.resultado.Name = "resultado"
        Me.resultado.Size = New System.Drawing.Size(121, 34)
        Me.resultado.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(237, 305)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 27)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Resultado"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(341, 382)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 43)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Sumar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmsuma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 468)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.resultado)
        Me.Controls.Add(Me.numero2)
        Me.Controls.Add(Me.numero1)
        Me.Controls.Add(Me.lblnumero2)
        Me.Controls.Add(Me.lblnumero1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmsuma"
        Me.Text = "frmsuma"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblnumero1 As Label
    Friend WithEvents lblnumero2 As Label
    Friend WithEvents numero1 As TextBox
    Friend WithEvents numero2 As TextBox
    Friend WithEvents resultado As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
