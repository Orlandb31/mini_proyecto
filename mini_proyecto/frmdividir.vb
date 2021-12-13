Public Class frmdividir
    Dim Servicios As New DemoWS.SOAPDemoSoapClient
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub frmdividir_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub p1_Paint(sender As Object, e As PaintEventArgs) Handles p1.Paint

    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtnumero1.TextChanged

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nume1 As Integer
        Dim nume2 As Integer
        nume1 = Val(txtnumero1.Text)
        nume2 = Val(txtnumero2.Text)
        If nume1 <= 0 And nume2 <= 0 Then
            aviso.Text = "Camps Invalidos"
        ElseIf nume2 = 0 Then
            aviso.Text = "No se puede dividir entre 0"
        ElseIf nume1 > 0 And nume2 > 0 Then
            aviso.Text = " "
            If nume2 > nume1 Then
                aviso.Text = "Denominador  mayor que el numerador"
            Else
                Try
                    txtresultado.Text = Servicios.DivideInteger(nume1, nume2)
                Catch ex As Exception
                    aviso.Text = "No es posible divisiones de punto decimal"
                End Try
            End If
        End If

    End Sub

    Private Sub txtnumero1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnumero1.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo puede digitar numeros")
        End If
    End Sub

    Private Sub txtnumero2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnumero2.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo puede digitar numeros")
        End If
    End Sub
End Class