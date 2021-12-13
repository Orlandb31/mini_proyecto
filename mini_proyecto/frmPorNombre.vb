Imports Newtonsoft.Json
Public Class frmPorNombre
    Dim Servicios As New DemoWS.SOAPDemoSoapClient
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim nombre As String
        Dim ds As New DataSet
        Dim result As Object
        nombre = Val(txtNombre.Text)

        result = Servicios.GetDataSetByName(nombre)

        ds = Servicios.GetDataSetByName(nombre)
        '' ds = result.
        If ds Is Nothing Then
            MsgBox("la base de datos no se ha creado")
        Else
            MsgBox("SE ha creado correctamente")
        End If
    End Sub

    Private Sub frmPorNombre_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class