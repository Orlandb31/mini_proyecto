Imports Newtonsoft.Json
Public Class frmPorNombre
    Dim Servicios As New DemoWS.SOAPDemoSoapClient
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim nombre As String
        Dim ds As New DataSet

        nombre = Val(txtNombre.Text)

        ds = Servicios.GetDataSetByName(nombre)

        If ds Is Nothing Then
            MsgBox("la base de datos no se ha creado")
        Else
            MsgBox("SE ha creado correctamente")
        End If
    End Sub
End Class