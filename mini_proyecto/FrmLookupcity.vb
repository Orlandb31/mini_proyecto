Imports System.IO
Imports System.Linq
Imports Newtonsoft.Json
Public Class FrmLookupcity
    Dim Servicios As New DemoWS.SOAPDemoSoapClient

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim ZIP As Integer
        '' Dim datas() As String
        ZIP = Val(txtzip.Text)
        Try
            Dim JsonData As String = Servicios.LookupCity(ZIP).ToString()
            ''datas = Split(JsonData, "-")
            MsgBox(JsonData)

        Catch
            MsgBox("Error al encontrar el servicio")
        End Try
    End Sub

    Private Sub txtzip_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtzip.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else : e.Handled = True
        End If
    End Sub

    Private Sub FrmLookupcity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtzip.Left = (Me.p1.Width - Me.txtzip.Width) / 2
        txtzip.Top = (Me.p1.Height - Me.txtzip.Height) / 2
        Button1.Left = (Me.p1.Width - Me.Button1.Width) / 2
        Label1.Left = (Me.p1.Width - Me.Label1.Width) / 2
    End Sub

    Private Sub txtzip_Enter(sender As Object, e As EventArgs) Handles txtzip.Enter
        txtzip.ResetText()
    End Sub
End Class