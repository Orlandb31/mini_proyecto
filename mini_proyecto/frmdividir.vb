Public Class frmdividir
    Dim Servicios As New DemoWS.SOAPDemoSoapClient
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles numero2.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nume1 As Integer
        Dim nume2 As Integer

        nume1 = Val(numero1.Text)
        nume2 = Val(numero2.Text)
        If nume1 <= 0 And nume2 <= 0 Then
            mensaje.Text = "Error matematico"
        ElseIf nume2 = 0 Then
            mensaje.Text = "No se puede dividir entre 0"
        ElseIf nume1 > 0 And nume2 > 0 Then
            mensaje.Text = " "
            If nume2 > nume1 Then
                mensaje.Text = "El denominador es mayor que el numerador"
            Else
                resultado.Text = Servicios.DivideInteger(nume1, nume2)
            End If
        End If





    End Sub
End Class