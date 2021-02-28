Public Class loginform
    Private Sub txtAdmin_TextChanged(sender As Object, e As EventArgs) Handles txtAdmin.TextChanged

    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim pass As Integer
        txtPass.Text = pass
        If txtAdmin.Text = "admin" And pass = "00000" Then
            Timer1.Start()
            Label2.Text = "Please Wait"
        Else
            Label2.Text = "please try again"
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(5)
        If ProgressBar1.Value = 100 Then

            Timer1.Stop()
            adminform.Show()
        End If
    End Sub
    Private Sub loginform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripStatusLabel1.Text = Today
    End Sub
End Class