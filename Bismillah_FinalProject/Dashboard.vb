Imports MySql.Data.MySqlClient

Public Class Dashboard
    Dim conn As New MySqlConnection
    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        Customer_Form.Show()

        GroupBox1.Hide()
        btnSlideL.Hide()
        btnSlideR.Hide()
        Panel1.Hide()
    End Sub

    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click
        loginform.Show()
        loginform.MdiParent = Me
        GroupBox1.Hide()
        btnSlideL.Hide()
        btnSlideR.Hide()
        Panel1.Hide()
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click
        Customer_Form.Show()
        GroupBox1.Hide()
        btnSlideL.Hide()
        btnSlideR.Hide()
        Panel1.Hide()
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        loginform.Show()
        loginform.MdiParent = Me
        GroupBox1.Hide()
        btnSlideL.Hide()
        btnSlideR.Hide()
        Panel1.Hide()
    End Sub

    Public Sub connect()
        Dim DatabaseName As String = "db_vp"
        Dim server As String = "localhost"
        Dim userName As String = "root"
        Dim password As String = ""
        If Not conn Is Nothing Then conn.Close()
        conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
        Try
            conn.Open()
            MsgBox("Connected")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btnSlideL_Click(sender As Object, e As EventArgs) Handles btnSlideL.Click
        Do While Panel1.Width < 709
            Panel1.Width = Panel1.Width + 1
        Loop
    End Sub

    Private Sub btnSlideR_Click(sender As Object, e As EventArgs) Handles btnSlideR.Click
        Do While Panel1.Width > 36
            Panel1.Width = Panel1.Width - 1
        Loop
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripStatusLabel1.Text = TimeOfDay
    End Sub
End Class