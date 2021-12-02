Imports Newtonsoft.Json
Public Class frmsuma
    Dim Servicios As New DemoWS.SOAPDemoSoapClient

    Private Sub frmsuma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1, num2 As Integer
        num1 = Val(numero1.Text)
        num2 = Val(numero2.Text)
        resultado.Text = Servicios.AddInteger(num1, num2)
    End Sub
End Class