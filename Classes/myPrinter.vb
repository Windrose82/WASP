Public Class myPrinter
    Friend TextToBePrinted As String
    Public Sub prt(ByVal text As String)
        TextToBePrinted = text
        Dim prn As New Printing.PrintDocument
        Using (prn)
            prn.PrinterSettings.PrinterName _
               = My.Settings.Drucker
            AddHandler prn.PrintPage,
               AddressOf Me.PrintPageHandler
            prn.Print()
            RemoveHandler prn.PrintPage,
               AddressOf Me.PrintPageHandler
        End Using
    End Sub
    Private Sub PrintPageHandler(ByVal sender As Object,
       ByVal args As Printing.PrintPageEventArgs)
        Dim myFont As New Font("Microsoft San Serif", 10)
        args.Graphics.DrawString(TextToBePrinted,
           New Font(myFont, FontStyle.Regular),
           Brushes.Black, 50, 50)
    End Sub
End Class
