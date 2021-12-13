Public Class frmresulperson
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmencontrar.txtID.ResetText()
        Me.Close()
    End Sub

    Private Sub frmresulperson_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtnombre.Text = frmencontrar.nomb
        txtssn.Text = frmencontrar.SSN
        txtdob.Text = frmencontrar.DOB
        txtage.Text = frmencontrar.AGE
        txtcolorfav.Text = frmencontrar.FC

        txthcalle.Text = frmencontrar.Hstreet
        txthciudad.Text = frmencontrar.Hcity
        txthestate.Text = frmencontrar.Hstate
        txthzip.Text = frmencontrar.Hzip

        txtocalle.Text = frmencontrar.Ostreet
        txtociudad.Text = frmencontrar.Ocity
        txtoestado.Text = frmencontrar.Ostate
        txtozip.Text = frmencontrar.Ozip
    End Sub
End Class