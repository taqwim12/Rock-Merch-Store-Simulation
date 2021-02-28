Imports MySql.Data.MySqlClient


Public Class adminform
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

    Private Sub adminform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDatabase()
    End Sub

    Private Sub btnloadrecord_Click_1(sender As Object, e As EventArgs)
        Try
            str = "SELECT * FROM tb_rockmerch"
            Dim da As New MySqlDataAdapter(str, conn)
            Dim dt As DataTable = New DataTable

            da.Fill(dt)
            DataGridView1.DataSource = dt
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()

        End Try
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Try
            str = "SELECT * FROM tb_rockmerch"
            Dim da As New MySqlDataAdapter(str, conn)
            Dim dt As DataTable = New DataTable

            da.Fill(dt)
            DataGridView1.DataSource = dt
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        With OrderForm
            .lblIDForm.Text = DataGridView1.CurrentRow.Cells(0).Value
            .CmbItems.Text = DataGridView1.CurrentRow.Cells(1).Value
            If DataGridView1.CurrentRow.Cells(2).Value = "S" Then
                .CBsizeS.Checked = True
            ElseIf DataGridView1.CurrentRow.Cells(2).Value = "M" Then
                .CBsizeM.Checked = True
            ElseIf DataGridView1.CurrentRow.Cells(2).Value = "L" Then
                .CBsizeL.Checked = True
            End If
            If DataGridView1.CurrentRow.Cells(3).Value = "Short" Then
                .SleeveS.Checked = True
            ElseIf DataGridView1.CurrentRow.Cells(3).Value = "Long" Then
                .SleeveL.Checked = True
            End If
            .NumericUpDown1.Value = DataGridView1.CurrentRow.Cells(4).Value
            .lbltPrice.Text = DataGridView1.CurrentRow.Cells(5).Value
            .btnsave.Text = "Update"
            .Show()
        End With
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim cmd As New MySqlCommand
        Dim result As Integer
        Dim dgresult As New DialogResult
        dgresult = MessageBox.Show("Are you sure you want to perform this action?", "Please Select action", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dgresult = DialogResult.Yes Then
            With cmd
                conn.Open()
                .Connection = conn
                .CommandText = "DELETE FROM tb_rockmerch WHERE ID = " & Val(DataGridView1.CurrentRow.Cells(0).Value) & ""
                result = .ExecuteNonQuery
                If result > 0 Then
                    MsgBox("Record has been deleted successfully!")
                Else
                    MsgBox("No Record has been deleted successfully!")
                End If
                Me.Close()
            End With
        End If
    End Sub

End Class
