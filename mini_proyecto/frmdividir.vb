Public Class frmdividir
    Dim Servicios As New DemoWS.SOAPDemoSoapClient

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

    Private Sub txtnumero1_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo puede digitar numeros")
        End If
    End Sub

    Private Sub txtnumero2_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo puede digitar numeros")
        End If
    End Sub
End Class