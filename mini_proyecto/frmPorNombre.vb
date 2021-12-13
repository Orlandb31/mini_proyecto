Imports Newtonsoft.Json
Public Class frmPorNombre
    Dim Servicios As New DemoWS.SOAPDemoSoapClient
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim nombre As String
            Dim ds As New DataSet
            '' Dim dt As DataTable
            Dim result

            nombre = Val(txtNombre.Text)


            Dim JsonData As Object = Servicios.GetDataSetByName(Name)
            result = JsonData
            dtgrid.DataSource = result

            '' dt = TryCast(JsonConvert.DeserializeObject(JsonData, (GetType(DataTable))), DataTable)
            '' dtgrid.DataSource = dt



            Console.WriteLine(txtNombre)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try














    End Sub


    Private Sub frmPorNombre_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class