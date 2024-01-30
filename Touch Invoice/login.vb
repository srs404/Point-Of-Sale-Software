Imports System.IO
Public Class login

    Private Sub analyt_Click(sender As Object, e As EventArgs) Handles analyt.Click
        analyzeform.ShowDialog()
        passwd.Text = Nothing
        Me.Close()
    End Sub

    Private Sub passwd_TextChanged(sender As Object, e As EventArgs) Handles passwd.TextChanged
        If passwd.Text = "12345" Then

            analyt.Visible = True
            pricelist.Visible = True
        Else
            analyt.Visible = False
            pricelist.Visible = False
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        passwd.Text = Nothing
        Me.Close()
    End Sub

    Private Sub pricelist_Click(sender As Object, e As EventArgs) Handles pricelist.Click
        pricelistchange.ShowDialog()
        passwd.Text = Nothing
        Me.Close()
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Me.StartPosition = FormStartPosition.CenterScreen

    End Sub
End Class