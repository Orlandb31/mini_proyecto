Imports Newtonsoft.Json
Imports System.IO
Imports System.Linq
Public Class frmencontrar
    Dim Servicios As New DemoWS.SOAPDemoSoapClient
    Public nomb, SSN, DOB, Hstreet, Hcity, Hstate, Hzip, Ocity, Ostreet, Ostate, Ozip, FC, AGE As String

    Private Sub frmencontrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2GradientPanel1.Left = (Me.Width - Guna2GradientPanel1.Width) / 2
        Guna2GradientPanel1.Top = (Me.Height - Guna2GradientPanel1.Height) / 2
        Button1.Left = (Me.Guna2GradientPanel1.Width - Button1.Width) / 2
        Label1.Left = (Me.Guna2GradientPanel1.Width - Label1.Width) / 2
        Label2.Left = (Me.Guna2GradientPanel1.Width - Label2.Width) / 2
        txtID.Left = (Me.Guna2GradientPanel1.Width - txtID.Width) / 2
        txtID.Top = (Me.Guna2GradientPanel1.Height - txtID.Height) / 2
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ID As Integer

        ID = Val(txtID.Text)
        If Trim(txtID.Text) = "" Then
            MsgBox("vacio")
        Else
            Try
                Dim JsonData As Object = Servicios.FindPerson(ID)
                Me.nomb = JsonData.Name.ToString()
                Me.SSN = JsonData.SSN.ToString()
                Me.DOB = JsonData.DOB.ToString()

                Me.Hstreet = JsonData.Home.Street.ToString()
                Me.Hcity = JsonData.Home.City.ToString()
                Me.Hstate = JsonData.Home.State.ToString()
                Me.Hzip = JsonData.Home.Zip.ToString()

                Me.Ostreet = JsonData.Office.Street.ToString()
                Me.Ocity = JsonData.Office.City.ToString()
                Me.Ostate = JsonData.Office.State.ToString()
                Me.Ozip = JsonData.Office.Zip.ToString()

                Me.FC = JsonData.FavoriteColors(0)
                Me.AGE = JsonData.Age.ToString()

                frmresulperson.Show()
            Catch
                MsgBox("Error en ejecutar el servicio")
            End Try
        End If
    End Sub
    Private Sub txtid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtID.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else : e.Handled = True
        End If
    End Sub

End Class