Imports System
Imports System.Threading
Imports System.IO.Ports
Imports System.ComponentModel
Imports System.Drawing.Printing


Public Class Settings
    Dim myPort As Array
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        My.Settings.COM_Waage = COM_W.Text
        My.Settings.Baud_Rate_Waage = BR_W.Text
        My.Settings.Parity_Waage = P_W.Text
        My.Settings.Data_Bits_Waage = DB_W.Text
        My.Settings.Stop_Bits_Waage = SB_W.Text
        My.Settings.Drucker = Drucker.Text
        My.Settings.Drucker = Drucker.Text
        My.Settings.D_on = cb_Drucker.Checked
        My.Settings.W_on = cb_Waage.Checked
        OpenForm(Waage, MainForm.MainPanel)
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myPort = IO.Ports.SerialPort.GetPortNames()
        'Waage einrichten
        HS_W.Items.Add(IO.Ports.Handshake.None)
        HS_W.Items.Add(IO.Ports.Handshake.RequestToSend)
        HS_W.Items.Add(IO.Ports.Handshake.RequestToSendXOnXOff)
        HS_W.Items.Add(IO.Ports.Handshake.XOnXOff)
        COM_W.Items.AddRange(myPort)
        COM_W.Text = My.Settings.COM_Waage
        BR_W.Text = My.Settings.Baud_Rate_Waage
        P_W.Text = My.Settings.Parity_Waage
        DB_W.Text = My.Settings.Data_Bits_Waage
        SB_W.Text = My.Settings.Stop_Bits_Waage
        cb_Drucker.Checked = My.Settings.D_on
        cb_Waage.Checked = My.Settings.W_on
        'Drucker einrichten
        For Each sPrinter As String In PrinterSettings.InstalledPrinters
            Drucker.Items.Add(sPrinter)
        Next

        Drucker.Text = My.Settings.Drucker
    End Sub

    Private Sub Settings_FormClosing(sender As Object, e As FormClosingEventArgs)
        OpenForm(Waage, MainForm.MainPanel)
    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs)
    '    Dim printer As New myPrinter
    '    printer.prt("Hello World")
    'End Sub
End Class