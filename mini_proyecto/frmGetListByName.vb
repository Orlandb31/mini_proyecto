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





        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub frmGetListByName_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''dtgNombre.Visible = False
    End Sub
End Class