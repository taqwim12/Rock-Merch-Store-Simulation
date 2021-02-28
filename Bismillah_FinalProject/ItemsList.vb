Public Class ItemsList
    Private Sub ItemsList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ContextMenuStrip = ContextMenuStrip1
        AddHandler HideToolStripMenuItem.Click, AddressOf HideToolStripMenuItem_Click
        AddHandler ShowToolStripMenuItem.Click, AddressOf ShowToolStripMenuItem_Click
    End Sub
    Private Sub HideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HideToolStripMenuItem.Click
        TreeView1.Visible = False
    End Sub

    Private Sub ShowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowToolStripMenuItem.Click
        TreeView1.Show()
    End Sub
End Class