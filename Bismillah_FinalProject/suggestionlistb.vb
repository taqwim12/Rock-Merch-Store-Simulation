Public Class suggestionlistb
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listbSuggestion.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSuggestion.Click
        listbSuggestion.Items.Add(txtOpinion.Text)
        lblConfirm.Text = "Your Suggestion Submitted! Thank You \m/"
    End Sub

    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Private Sub suggestionlistb_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class