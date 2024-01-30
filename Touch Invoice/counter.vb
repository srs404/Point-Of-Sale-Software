Public Class counter
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub counter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Location = Screen.AllScreens(UBound(Screen.AllScreens)).Bounds.Location

        Me.TopMost = True
    End Sub

    Private Sub textlength_Tick(sender As Object, e As EventArgs) Handles textlength.Tick
        If TextBox1.Text.Length > 6 Then

            TextBox1.Font = New Font("Unispace", 140, FontStyle.Bold)
            'TextBox1.Font = New Font("Unispace", 132, FontStyle.Bold)

            'Unispace, 130.2pt, style = Bold
        Else
            TextBox1.Font = New Font("Unispace", 300, FontStyle.Bold)
        End If
    End Sub
End Class