Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SumaDeDosEnterosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SumaDeDosEnterosToolStripMenuItem.Click
        frmsuma.MdiParent = Me
        frmsuma.WindowState = FormWindowState.Maximized
        frmsuma.p1.Left = (frmsuma.Width - frmsuma.p1.Width) / 2
        frmsuma.p1.Top = (frmsuma.Height - frmsuma.p1.Height) / 2
        frmsuma.Show()
        MainPanel.Visible = False

        FrmLookupcity.Close()
        frmencontrar.Close()
        frmdividir.Close()
    End Sub

    Private Sub FindpersonidToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindpersonidToolStripMenuItem.Click
        frmencontrar.MdiParent = Me
        frmencontrar.WindowState = FormWindowState.Maximized
        frmencontrar.paEncontrar.Left = (Me.Width - frmencontrar.paEncontrar.Width) / 2
        frmencontrar.paEncontrar.Top = (Me.Height - frmencontrar.paEncontrar.Height) / 2
        frmencontrar.Show()
        MainPanel.Visible = False
        FrmLookupcity.Close()
        frmdividir.Close()
        frmsuma.Close()

    End Sub

    Private Sub DivisionDeDosEnterosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DivisionDeDosEnterosToolStripMenuItem.Click
        frmdividir.MdiParent = Me
        frmdividir.WindowState = FormWindowState.Maximized
        frmdividir.p1.Left = (frmdividir.Width - frmdividir.p1.Width) / 2
        frmdividir.p1.Top = (frmdividir.Height - frmdividir.p1.Height) / 2
        frmdividir.Show()
        MainPanel.Visible = False
        frmencontrar.Close()
        FrmLookupcity.Close()
        frmsuma.Close()
    End Sub

    Private Sub LookupCityToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LookupCityToolStripMenuItem.Click
        FrmLookupcity.MdiParent = Me
        FrmLookupcity.WindowState = FormWindowState.Maximized
        FrmLookupcity.p1.Left = (Me.Width - FrmLookupcity.p1.Width) / 2
        FrmLookupcity.p1.Top = (Me.Height - FrmLookupcity.p1.Height) / 2
        FrmLookupcity.Show()
        MainPanel.Visible = False
        frmencontrar.Close()
        frmdividir.Close()
        frmsuma.Close()
    End Sub

    Private Sub GetListByNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GetListByNameToolStripMenuItem.Click
        frmGetListByName.MdiParent = Me
        frmGetListByName.WindowState = FormWindowState.Maximized
        frmGetListByName.p1.Left = (Me.Width - frmGetListByName.p1.Width) / 2
        frmGetListByName.p1.Top = (Me.Height - frmGetListByName.p1.Height) / 2
        frmGetListByName.Show()
        MainPanel.Visible = False
        frmencontrar.Close()
        FrmLookupcity.Close()
        frmsuma.Close()
        frmdividir.Close()
    End Sub

    Private Sub GetDataSetByNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GetDataSetByNameToolStripMenuItem.Click
        frmPorNombre.MdiParent = Me
        frmPorNombre.WindowState = FormWindowState.Maximized
        frmPorNombre.panel1.Left = (Me.Width - frmPorNombre.panel1.Width) / 2
        frmPorNombre.panel1.Top = (Me.Height - frmPorNombre.panel1.Height) / 2
        frmPorNombre.Show()
        MainPanel.Visible = False
        frmencontrar.Close()
        FrmLookupcity.Close()
        frmsuma.Close()
        frmdividir.Close()
    End Sub


End Class
