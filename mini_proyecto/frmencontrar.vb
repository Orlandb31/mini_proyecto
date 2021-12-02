Imports Newtonsoft.Json

Public Class frmencontrar
    Dim Servicios As New DemoWS.SOAPDemoSoapClient
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ID As Integer
        Dim datas() As String
        ID = Val(txtID.Text)
        Dim JsonData As String = JsonConvert.SerializeObject(Servicios.FindPerson(ID))
        datas = Split(JsonData, "-")
        MsgBox(JsonData)
    End Sub

    Private Sub frmencontrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class