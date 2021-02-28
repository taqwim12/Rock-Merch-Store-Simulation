Imports MySql.Data.MySqlClient
Public Class Market
    Dim conn As New MySqlConnection
    Dim str As String
    Public Sub ConnectDatabase()
        Dim DatabaseName As String = "db_vp"
        Dim server As String = "Localhost"
        Dim userName As String = "root"
        Dim password As String = ""
        If Not conn Is Nothing Then conn.Close()
        conn.ConnectionString = "Server=" & server & ";user=" & userName & "; Password=" & password & " ; database=" & DatabaseName & ""
        Try
            conn.Open()
            ' MsgBox("Connected!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnTshirt_Click(sender As Object, e As EventArgs) Handles btnTshirt.Click
        TabControl1.SelectTab(0)
    End Sub

    Private Sub btnPosters_Click(sender As Object, e As EventArgs) Handles btnPosters.Click
        TabControl1.SelectTab(1)
    End Sub

    Private Sub Market_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripLabel1.Text = TimeOfDay
        Timer1.Start()
        Timer1.Interval = 50
        ConnectDatabase()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If lblWelcome.Location.X + lblWelcome.Width < 0 Then
            lblWelcome.Location = New Point(Me.Width, lblWelcome.Location.Y)
        Else
            lblWelcome.Location = New Point(lblWelcome.Location.X - 3, lblWelcome.Location.Y)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOpinion.Click
        suggestionlistb.Show()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnBuy.Click
        OrderForm.Show()
    End Sub

    Private Sub HelpToolStripButton_Click(sender As Object, e As EventArgs) Handles HelpToolStripButton.Click
        MsgBox("Market by Taqwim Bagus", MsgBoxStyle.Information)
    End Sub
End Class