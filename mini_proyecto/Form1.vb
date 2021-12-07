Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub SumaDeDosEnterosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SumaDeDosEnterosToolStripMenuItem.Click
        frmsuma.MdiParent = Me
        frmsuma.WindowState = FormWindowState.Maximized
        frmsuma.Show()
        Label1.Hide()
        Label2.Hide()

    End Sub

    Private Sub FindpersonidToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindpersonidToolStripMenuItem.Click
        frmencontrar.MdiParent = Me
        frmencontrar.WindowState = FormWindowState.Maximized
        frmencontrar.Show()
        Label1.Hide()
        Label2.Hide()

    End Sub

    Private Sub DivisionDeDosEnterosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DivisionDeDosEnterosToolStripMenuItem.Click
        frmdividir.MdiParent = Me
        frmdividir.WindowState = FormWindowState.Maximized
        frmdividir.Show()
        Label1.Hide()
        Label2.Hide()
    End Sub

    Private Sub LookupCityToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LookupCityToolStripMenuItem.Click
        FrmLookupcity.MdiParent = Me
        FrmLookupcity.WindowState = FormWindowState.Maximized
        FrmLookupcity.Show()
        Label1.Hide()
        Label2.Hide()
    End Sub
End Class
