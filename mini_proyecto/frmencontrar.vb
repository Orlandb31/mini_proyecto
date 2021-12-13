Imports Newtonsoft.Json
Imports System.IO
Imports System.Linq
Public Class frmencontrar
    Dim Servicios As New DemoWS.SOAPDemoSoapClient


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ID As Integer

        ID = Val(txtID.Text)
        Dim JsonData As Object = Servicios.GetByName(ID)


        MsgBox("Nombre: " + JsonData.Name.ToString() & vbNewLine & "SSN: " + JsonData.SSN.ToString() & vbNewLine &
               "DOB: " + JsonData.DOB.ToString() & vbNewLine &
            "Direccion " & vbNewLine &
             "Calle: " + JsonData.Home.Street.ToString()
               )
    End Sub


End Class