Imports Newtonsoft.Json
Public Class frmPorNombre
    Dim Servicios As New DemoWS.SOAPDemoSoapClient


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim nombre As String
            Dim ds As New DataSet
            Dim vDS As DataSet = New DataSet()
            Dim result

            nombre = Val(txtnombre.Text)


            Dim JsonData As DemoWS.ByNameDataSet = Servicios.GetDataSetByName(Name)



            '' dt = TryCast(JsonConvert.DeserializeObject(JsonData, (GetType(DataTable))), DataTable)
            '' dtgrid.DataSource = dt


            For Each t As System.Data.DataTable In JsonData.Tables
                Dim vPersons As Persons = New Persons()

                For Each dr As System.Data.DataRow In t.Rows
                    Dim vPerson As PersonData = New PersonData()
                    Dim vtryInt As Integer
                    Integer.TryParse(dr("ID").ToString(), vtryInt)
                    vPerson.ID = vtryInt
                    vPerson.Name = dr("Name").ToString()
                    vPerson.DOB = dr("DOB").ToString()
                    vPerson.SSN = dr("SSN").ToString()
                    vPersons.All.Add(vPerson)
                Next

                dtgrid.DataSource = vPersons
            Next
            Console.WriteLine(txtnombre)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub frmPorNombre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Left = (Me.panel1.Width - Me.Label1.Width) / 2
    End Sub
End Class