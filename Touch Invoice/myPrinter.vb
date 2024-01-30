Public Class myPrinter
    Friend TextToBePrinted As String
    Public Sub print(ByVal text As String)
        TextToBePrinted = text
        Dim prn As New Printing.PrintDocument
        Using (prn)
            prn.PrinterSettings.PrinterName = "RONGTA 58mm Series Printer(2)" 'PrinterSettings.InstalledPrinters.Item(0)
            AddHandler prn.PrintPage, AddressOf Me.PrintPageHandler
            prn.Print()
            RemoveHandler prn.PrintPage, AddressOf Me.PrintPageHandler
        End Using
    End Sub

    Private Sub PrintPageHandler(ByVal sender As Object, ByVal args As Printing.PrintPageEventArgs)

        Dim myFont As New Font("Microsoft San Serif", 14)
        args.Graphics.DrawString(TextToBePrinted, New Font(myFont, FontStyle.Bold), Brushes.Black, 10, 10)
    End Sub
End Class