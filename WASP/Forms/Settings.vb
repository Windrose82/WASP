Imports System
Imports System.Threading
Imports System.IO.Ports
Imports System.ComponentModel

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
        My.Settings.COM_Drucker = COM_D.Text
        My.Settings.Baud_Rate_Drucker = BR_D.Text
        My.Settings.Parity_Drucker = P_D.Text
        My.Settings.Data_Bits_Drucker = DB_D.Text
        My.Settings.Stop_Bits_Drucker = SB_D.Text
        My.Settings.Send_Waage = Send_W.Text
        My.Settings.Send_Drucker = Send_D.Text
        My.Settings.W_on = cb_Waage.Checked
        My.Settings.D_on = cb_Drucker.Checked
        OpenForm(Waage, MainForm.MainPanel)
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myPort = IO.Ports.SerialPort.GetPortNames()
        HS_W.Items.Add(IO.Ports.Handshake.None)
        HS_W.Items.Add(IO.Ports.Handshake.RequestToSend)
        HS_W.Items.Add(IO.Ports.Handshake.RequestToSendXOnXOff)
        HS_W.Items.Add(IO.Ports.Handshake.XOnXOff)
        COM_W.Items.AddRange(myPort)
        COM_D.Items.AddRange(myPort)
        COM_W.Text = My.Settings.COM_Waage
        BR_W.Text = My.Settings.Baud_Rate_Waage
        P_W.Text = My.Settings.Parity_Waage
        DB_W.Text = My.Settings.Data_Bits_Waage
        SB_W.Text = My.Settings.Stop_Bits_Waage
        COM_D.Text = My.Settings.COM_Drucker
        BR_D.Text = My.Settings.Baud_Rate_Drucker
        P_D.Text = My.Settings.Parity_Drucker
        DB_D.Text = My.Settings.Data_Bits_Drucker
        SB_D.Text = My.Settings.Stop_Bits_Drucker
        Send_W.Text = My.Settings.Send_Waage
        Send_D.Text = My.Settings.Send_Drucker
        cb_Waage.Checked = My.Settings.W_on
        cb_Drucker.Checked = My.Settings.D_on
    End Sub

    Private Sub Settings_FormClosing(sender As Object, e As FormClosingEventArgs)
        OpenForm(Waage, MainForm.MainPanel)
    End Sub
End Class