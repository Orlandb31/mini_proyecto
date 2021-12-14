
Public Class frmsuma
    Dim Servicios As New DemoWS.SOAPDemoSoapClient

    Private Sub frmsuma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GunaButton1.Left = (Me.p1.Width - Me.GunaButton1.Width) / 2
        Label6.Left = (Me.p1.Width - Me.Label6.Width) / 2
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Dim num1, num2 As Integer
        num1 = Val(txtnumero1.Text)
        num2 = Val(txtnumero2.Text)

        If num1 <= 0 And num2 <= 0 Then
            aviso.Text = "Campos en blanco "
        Else
            Try
                txtresultado.Text = Servicios.AddInteger(num1, num2)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If


    End Sub

    Private Sub txtnumero1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnumero1.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo puede digitar numeros")
        End If
    End Sub

    Private Sub txtnumero2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnumero2.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo puede digitar numeros")
        End If
    End Sub
End Class