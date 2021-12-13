Public Class frmresulperson

    Private Sub frmresulperson_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblnombre.Text = frmencontrar.nomb
        lblssn.Text = frmencontrar.SSN
        lbldob.Text = frmencontrar.DOB
        lblage.Text = frmencontrar.AGE
        lblfc.Text = frmencontrar.FC

        lblhcalle.Text = frmencontrar.Hstreet
        lblhcity.Text = frmencontrar.Hcity
        lblhestado.Text = frmencontrar.Hstate
        lblhzip.Text = frmencontrar.Hzip

        lblocalle.Text = frmencontrar.Ostreet
        lblocity.Text = frmencontrar.Ocity
        lbloestado.Text = frmencontrar.Ostate
        lblozip.Text = frmencontrar.Ozip
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        frmencontrar.txtID.ResetText()
        Me.Close()
    End Sub
End Class