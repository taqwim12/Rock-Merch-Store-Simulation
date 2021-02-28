Public Class PaymentForm
    Dim sb As New System.Text.StringBuilder

    Private Sub CheckedListBoxPayment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBoxPayment.SelectedIndexChanged
        If CheckedListBoxPayment.SelectedIndex = 0 Then
            MsgBox("Wait until your order ID is printed and bring your money to cashier and pay your bills! \m/", MsgBoxStyle.Information)
            lblResult.Text = "Wait until your order ID is printed and bring your money to cashier and pay your bills! \m/"
        ElseIf CheckedListBoxPayment.SelectedIndex = 1 Then
            MsgBox("Wait until your order ID is printed and bring your phone to cashier, show your OVO barcode and pay your bills! \m/", MsgBoxStyle.Information)
            lblResult.Text = "Wait until your order ID is printed and bring your phone to cashier, show your OVO barcode and pay your bills! \m/"
        ElseIf CheckedListBoxPayment.SelectedIndex = 2 Then
            MsgBox("Wait until your order ID is printed and bring your phone to cashier, show your Gopay barcode and pay your bills! \m/", MsgBoxStyle.Information)
            lblResult.Text = "Wait until your order ID is printed and bring your phone to cashier, show your Gopay barcode and pay your bills! \m/"
        Else
            MsgBox("Wait until your order ID is printed and bring your phone to cashier, show your Dana barcode and pay your bills! \m/", MsgBoxStyle.Information)
            lblResult.Text = "Wait until your order ID is printed and bring your phone to cashier, show your Dana barcode and pay your bills! \m/"
        End If
    End Sub
End Class