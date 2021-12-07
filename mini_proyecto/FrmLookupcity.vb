Imports Newtonsoft.Json
Public Class FrmLookupcity
    Dim Servicios As New DemoWS.SOAPDemoSoapClient

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ZIP As Integer
        Dim datas() As String
        ZIP = Val(txtzip.Text)
        Try
            Dim JsonData As String = JsonConvert.SerializeObject(Servicios.LookupCity(ZIP))
            datas = Split(JsonData, "-")
            MsgBox(JsonData)

        Catch
            MsgBox("Error al encontrar el servicio")
        End Try
    End Sub

End Class