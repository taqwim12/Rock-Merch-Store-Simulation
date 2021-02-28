Imports MySql.Data.MySqlClient

Public Class OrderForm
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim result As Integer 'variable
    Dim str As String
    Dim rad As String
    Dim qty As Integer
    Dim tprice As Integer
    'Dim items As String

    Private Function ttl()
        'Dim tprice
        Return 110000 * qty
    End Function

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click



        Str = " "
        rad = " "

        If CBsizeS.Checked = True Then
            str = CBsizeS.Text
        ElseIf CBsizeM.Checked = True Then
            str = CBsizeM.Text
        ElseIf CBsizeL.Checked = True Then
            str = CBsizeL.Text
        End If

        If SleeveS.Checked = True Then
            rad = SleeveS.Text

        Else
            rad = SleeveL.Text

        End If

        qty = NumericUpDown1.Value

        If CBsizeS.Checked = True And SleeveS.Checked = True Then
            tprice = ttl()
            lbltPrice.Text = tprice
        End If

        If CBsizeM.Checked = True And SleeveS.Checked = True Then
            tprice = ttl()
            lbltPrice.Text = ttl()
        End If

        If CBsizeL.Checked = True And SleeveS.Checked = True Then
            tprice = ttl()
            lbltPrice.Text = ttl()
        End If

        If CBsizeS.Checked = True And SleeveL.Checked = True Then
            tprice = ttl()
            lbltPrice.Text = ttl()
        End If

        If CBsizeM.Checked = True And SleeveL.Checked = True Then
            tprice = ttl()
            lbltPrice.Text = ttl()
        End If

        If CBsizeL.Checked = True And SleeveL.Checked = True Then
            tprice = ttl()
            lbltPrice.Text = ttl()
        End If

        Try
            With cmd
                If btnsave.Text = "Save" Then
                    .Connection = conn
                    .CommandText = "INSERT INTO tb_rockmerch (ID, Items, Size, Sleeve, Quantity, Total_Price) VALUES(NULL,'" & CmbItems.Text & "','" & str & "','" & rad & "','" & qty & "','" & ttl() & "')"
                    result = .ExecuteNonQuery
                    If result > 0 Then
                        MsgBox("New Record has been added successfully!")
                    Else
                        MsgBox("No Record has been added successfully!")
                    End If
                Else
                    .Connection = conn
                    .CommandText = "Update tb_rockmerch set Items ='" & CmbItems.Text & "', Size ='" & str & "', Sleeve='" & rad & "', Quantity =" & qty & ", Total_Price =" & ttl() & "  where ID =" & lblIDForm.Text & ""
                    result = .ExecuteNonQuery
                    If result > 0 Then
                        MsgBox("New Record has been updated successfully!")
                    Else
                        MsgBox("No Record has been updated successfully!")
                    End If

                    Me.Close()

                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Public Sub ConnectDatabase() 'procedure
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

    Private Sub OrderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDatabase() 'call procedure
    End Sub

    Private Sub CBsizeS_Click(sender As Object, e As EventArgs) Handles CBsizeS.Click
        CBsizeM.Checked = False
        CBsizeL.Checked = False
    End Sub

    Private Sub CBsizeM_Click(sender As Object, e As EventArgs) Handles CBsizeM.Click
        CBsizeS.Checked = False
        CBsizeL.Checked = False
    End Sub

    Private Sub CBsizeL_Click(sender As Object, e As EventArgs) Handles CBsizeL.Click
        CBsizeM.Checked = False
        CBsizeS.Checked = False
    End Sub
End Class