Public Class Customer_Form
    Dim listviewgroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Items Pictures", System.Windows.Forms.HorizontalAlignment.Left)
    Private Sub ItemsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemsToolStripMenuItem.Click
        ItemsList.Show()
        ItemsList.MdiParent = Me
        Label1.Hide()
        DTPcust.Hide()
        ListViewItems.Hide()
    End Sub

    Private Sub TShirtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TShirtToolStripMenuItem.Click
        Market.Show()
        Market.MdiParent = Me
        Label1.Hide()
        DTPcust.Hide()
        ListViewItems.Hide()
    End Sub

    Private Sub Customer_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ListViewItems.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {listviewgroup1})
        listviewgroup1.Name = “Items”
        For i As Integer = 0 To ImageListItems.Images.Count - 1
            ListViewItems.Items.Add(“Items ” & i + 1.ToString)
            ListViewItems.Items(i).ImageKey = ImageListItems.Images.Keys.Item(i).ToString()
            ListViewItems.Items(i).Group = listviewgroup1
        Next
    End Sub

    Private Sub PaymentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaymentToolStripMenuItem.Click
        PaymentForm.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class