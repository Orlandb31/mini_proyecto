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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.numero1 = New System.Windows.Forms.TextBox()
        Me.numero2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.resultado = New System.Windows.Forms.TextBox()
        Me.mensaje = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(195, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(311, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dividir dos Numeros"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(196, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Numero 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(197, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 27)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Numero 2"
        '
        'numero1
        '
        Me.numero1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numero1.Location = New System.Drawing.Point(328, 146)
        Me.numero1.Name = "numero1"
        Me.numero1.Size = New System.Drawing.Size(126, 34)
        Me.numero1.TabIndex = 3
        '
        'numero2
        '
        Me.numero2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numero2.Location = New System.Drawing.Point(328, 226)
        Me.numero2.Name = "numero2"
        Me.numero2.Size = New System.Drawing.Size(126, 34)
        Me.numero2.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(328, 438)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 32)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Dividir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(200, 312)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 27)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Resultado"
        '
        'resultado
        '
        Me.resultado.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultado.Location = New System.Drawing.Point(328, 312)
        Me.resultado.Name = "resultado"
        Me.resultado.Size = New System.Drawing.Size(126, 34)
        Me.resultado.TabIndex = 7
        '
        'mensaje
        '
        Me.mensaje.AutoSize = True
        Me.mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mensaje.Location = New System.Drawing.Point(212, 388)
        Me.mensaje.Name = "mensaje"
        Me.mensaje.Size = New System.Drawing.Size(23, 25)
        Me.mensaje.TabIndex = 8
        Me.mensaje.Text = "a"
        '
        'frmdividir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 542)
        Me.Controls.Add(Me.mensaje)
        Me.Controls.Add(Me.resultado)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.numero2)
        Me.Controls.Add(Me.numero1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmdividir"
        Me.Text = "frmdividir"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents numero1 As TextBox
    Friend WithEvents numero2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents resultado As TextBox
    Friend WithEvents mensaje As Label
End Class
