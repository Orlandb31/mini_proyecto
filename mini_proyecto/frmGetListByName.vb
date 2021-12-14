Imports Newtonsoft.Json
Public Class frmGetListByName
    Dim Servicios As New DemoWS.SOAPDemoSoapClient


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Dim name As String
            Dim dt As DataTable
            name = txtName.Text.ToString()

            Dim JsonData As String = JsonConvert.SerializeObject(Servicios.GetListByName(name))
            dt = TryCast(JsonConvert.DeserializeObject(JsonData, (GetType(DataTable))), DataTable)

            dtgNombre.DataSource = dt
            If dtgNombre.Columns(4).Index = 4 Then
                dtgNombre.Columns(4).Visible = False
            End If

        Catch ex As Exception
            MsgBox("Lo Sentimos, el nombre escrito no existe")
        End Try
    End Sub
End Class