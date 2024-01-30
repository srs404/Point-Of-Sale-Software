Public Class message
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub updateui_Tick(sender As Object, e As EventArgs) Handles updateui.Tick
        Try
            'unittext.Text = My.Settings.ordercountday - 1
            LiqfinalBindingSource.Filter = String.Format("OrderDate = #{0:dd/MMM/yy}#", Today)
            With LiqfinalDataGridView
                .DataSource = LiqfinalBindingSource
            End With
            Try
                totprice.Text = (From row As DataGridViewRow In LiqfinalDataGridView.Rows
                                 Where row.Cells(6).FormattedValue.ToString() <> String.Empty
                                 Select Convert.ToInt32(row.Cells(6).FormattedValue)
                             ).Sum().ToString
                unittext.Text = (From row As DataGridViewRow In LiqfinalDataGridView.Rows
                                 Where row.Cells(51).FormattedValue.ToString() <> String.Empty
                                 Select Convert.ToInt32(row.Cells(51).FormattedValue)
                             ).Sum().ToString
            Catch ex As Exception

            End Try
        Catch ex As Exception

        End Try

    End Sub

    Private Sub message_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LiqfinalDataGridView.Size = Size.Empty
        'TODO: This line of code loads data into the 'Liqdbase.liqfinal' table. You can move, or remove it, as needed.
        Form1.LiqfinalTableAdapter.Fill(Me.Liqdbase.liqfinal)
        Me.TopMost = True


    End Sub
End Class