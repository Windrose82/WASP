Imports System
Imports System.Threading
Imports System.IO.Ports
Imports System.ComponentModel

Public Class Waage
    Delegate Sub SetTextCallback(ByVal [text] As String) 'Added to prevent threading errors during receiveing of data
    Private Sub Init_Click(sender As Object, e As EventArgs) Handles init.Click
        Dim w_parity As Parity
        Dim d_parity As Parity
        Dim hs_w As Handshake
        If My.Settings.Hand_Shake_W = "RequestToSend" Then
            hs_w = IO.Ports.Handshake.RequestToSend
        ElseIf My.Settings.Hand_Shake_W = "None" Then
            hs_w = IO.Ports.Handshake.None
        ElseIf My.Settings.Hand_Shake_W = "RequestToSendXOnXOff" Then
            hs_w = IO.Ports.Handshake.RequestToSendXOnXOff
        ElseIf My.Settings.Hand_Shake_W = "XOnXOff" Then
            hs_w = IO.Ports.Handshake.XOnXOff
        End If

        If My.Settings.Parity_Waage = "Even" Then
            w_parity = IO.Ports.Parity.Even
        ElseIf My.Settings.Parity_Waage = "Odd" Then
            w_parity = IO.Ports.Parity.Odd
        ElseIf My.Settings.Parity_Waage = "Mark" Then
            w_parity = IO.Ports.Parity.Mark
        ElseIf My.Settings.Parity_Waage = "Space" Then
            w_parity = IO.Ports.Parity.Space
        Else
            w_parity = IO.Ports.Parity.None
        End If
        If My.Settings.Parity_Drucker = "Even" Then
            d_parity = IO.Ports.Parity.Even
        ElseIf My.Settings.Parity_Drucker = "Odd" Then
            d_parity = IO.Ports.Parity.Odd
        ElseIf My.Settings.Parity_Drucker = "Mark" Then
            d_parity = IO.Ports.Parity.Mark
        ElseIf My.Settings.Parity_Drucker = "Space" Then
            d_parity = IO.Ports.Parity.Space
        Else
            d_parity = IO.Ports.Parity.None
        End If
        If My.Settings.D_on = True Then
            Try
                SP_Drucker.PortName = My.Settings.COM_Drucker
                SP_Drucker.BaudRate = My.Settings.Baud_Rate_Drucker
                SP_Drucker.Parity = d_parity
                SP_Drucker.DataBits = My.Settings.Data_Bits_Drucker
                SP_Drucker.StopBits = My.Settings.Stop_Bits_Drucker
                SP_Drucker.Open()
                init.Enabled = False
                F1.Enabled = True
                F2.Enabled = True
                F3.Enabled = True
                F5.Enabled = True
                F6.Enabled = True
                F7.Enabled = True
                F8.Enabled = True
                F9.Enabled = True
                F10.Enabled = True
                F11.Enabled = True
                disconnect.Enabled = True
            Catch ex As Exception
                ' Show the exception's message.
                MessageBox.Show("Auf Drucker kann nicht zugegriffen werden!")
            End Try
        End If
        If My.Settings.W_on = True Then
            Try
                SP_Waage.PortName = My.Settings.COM_Waage
                SP_Waage.BaudRate = My.Settings.Baud_Rate_Waage
                SP_Waage.Parity = w_parity
                SP_Waage.DataBits = My.Settings.Data_Bits_Waage
                SP_Waage.StopBits = My.Settings.Stop_Bits_Waage
                SP_Waage.Handshake = hs_w
                SP_Waage.Open()
                init.Enabled = False
                F1.Enabled = True
                F2.Enabled = True
                F3.Enabled = True
                F5.Enabled = True
                F6.Enabled = True
                F7.Enabled = True
                F8.Enabled = True
                F9.Enabled = True
                F10.Enabled = True
                F11.Enabled = True
                disconnect.Enabled = True
            Catch ex As Exception
                ' Show the exception's message.
                MessageBox.Show("Auf Waage kann nicht zugegriffen werden!")
            End Try
        End If
    End Sub

    'Private Sub SP_Drucker_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SP_Drucker.DataReceived
    '    ReceivedTextD(SP_Drucker.ReadExisting())
    'End Sub

    'Private Sub ReceivedTextD(ByVal [text] As String) 'input from ReadExisting
    '    If Aktueller_Wert.InvokeRequired Then
    '        Dim x As New SetTextCallback(AddressOf ReceivedTextD)
    '        Me.Invoke(x, New Object() {(text)})
    '    Else
    '        Aktueller_Wert.Wert = [text] 'append text
    '    End If

    'End Sub

    Private Sub SP_Waage_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SP_Waage.DataReceived
        Me.Invoke(Sub() Aktueller_Wert.Wert = (Me.SP_Waage.ReadLine))
        Dim str As String = Aktueller_Wert.Wert
        Dim out As String
        For i = 1 To str.Length - 1
            If IsNumeric(str.Substring(i, 1)) Then
                out = out & str.Substring(i, 1)
            ElseIf str.Substring(i, 1) = "." Then
                out = out & ","
            End If
        Next
        Aktueller_Wert.Wert = out
        Debug.Print(out)
        'ReceivedTextW(SP_Waage.ReadExisting())
    End Sub

    'Private Sub ReceivedTextW(ByVal [text] As String) 'input from ReadExisting


    '    If Me.TB_Waage.InvokeRequired Then
    '        Dim x As New SetTextCallback(AddressOf ReceivedTextW)
    '        Me.Invoke(x, New Object() {(text)})
    '    Else
    '        Me.TB_Waage.Text = [text] 'append text
    '        Debug.Print([text])
    '    End If

    'End Sub

    Private Sub Disconnect_Click(sender As Object, e As EventArgs) Handles disconnect.Click
        SP_Waage.Close()
        SP_Drucker.Close()
        init.Enabled = True
        F1.Enabled = False
        F2.Enabled = False
        F3.Enabled = False
        F5.Enabled = False
        F6.Enabled = False
        F7.Enabled = False
        F8.Enabled = False
        F9.Enabled = False
        F10.Enabled = False
        F11.Enabled = False
        disconnect.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'TB_Drucker.Clear()
        'TB_Waage.Clear()
        If MainTab.SelectedTab.TabIndex = 0 Then
            tb_R_AS.Clear()
            tb_R_M.Clear()
            tb_R_BS.Clear()
            tb_R_Mitt.Clear()
            tb_R_Span.Clear()
        ElseIf MainTab.SelectedTab.TabIndex = 1 Then
            tb_P_AS.Clear()
            tb_P_M.Clear()
            tb_P_BS.Clear()
            tb_P_Mitt.Clear()
            tb_P_Span.Clear()
        ElseIf MainTab.SelectedTab.TabIndex = 2 Then
            tb_N_AS.Clear()
            tb_N_M.Clear()
            tb_N_BS.Clear()
            tb_N_Mitt.Clear()
            tb_N_Span.Clear()
        End If
    End Sub

    Private Sub F5_Click(sender As Object, e As EventArgs) Handles F5.Click
        MainTab.SelectTab(0)
    End Sub

    Private Sub F6_Click(sender As Object, e As EventArgs) Handles F6.Click
        MainTab.SelectTab(1)
    End Sub

    Private Sub F7_Click(sender As Object, e As EventArgs) Handles F7.Click
        MainTab.SelectTab(2)
    End Sub

    Private Sub Waage_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'TEst
        If e.KeyValue = 112 Or e.KeyValue = 113 Or e.KeyValue = 114 Then
            Aktueller_Wert.TYP = e.KeyValue
            SP_Waage.Write(My.Settings.Send_Waage & vbLf & vbCr) 'concatenate with \n
        ElseIf e.KeyValue = 116 Then
            MainTab.SelectTab(0)
        ElseIf e.KeyValue = 117 Then
            MainTab.SelectTab(1)
        ElseIf e.KeyValue = 118 Then
            MainTab.SelectTab(2)
        ElseIf e.KeyValue = 119 Then
            If MainTab.SelectedTab.TabIndex = 0 Then
                RECO.FAKTOR = 100
                tb_R_Faktor.Text = 100
            ElseIf MainTab.SelectedTab.TabIndex = 1 Then
                PAGENDARM.FAKTOR = 100
                tb_P_Faktor.Text = 100
            ElseIf MainTab.SelectedTab.TabIndex = 2 Then
                NORDSON.FAKTOR = 100
                tb_N_Faktor.Text = 100
            End If
        ElseIf e.KeyValue = 120 Then
            If MainTab.SelectedTab.TabIndex = 0 Then
                RECO.FAKTOR = 200
                tb_R_Faktor.Text = 200
            ElseIf MainTab.SelectedTab.TabIndex = 1 Then
                PAGENDARM.FAKTOR = 200
                tb_P_Faktor.Text = 200
            ElseIf MainTab.SelectedTab.TabIndex = 2 Then
                NORDSON.FAKTOR = 200
                tb_N_Faktor.Text = 200
            End If
        ElseIf e.KeyValue = 121 Then
            If MainTab.SelectedTab.TabIndex = 0 Then
                RECO.FAKTOR = 400
                tb_R_Faktor.Text = 400
            ElseIf MainTab.SelectedTab.TabIndex = 1 Then
                PAGENDARM.FAKTOR = 400
                tb_P_Faktor.Text = 400
            ElseIf MainTab.SelectedTab.TabIndex = 2 Then
                NORDSON.FAKTOR = 400
                tb_N_Faktor.Text = 400
            End If
        ElseIf e.KeyValue = 122 Then
            If MainTab.SelectedTab.TabIndex = 0 Then
                RECO.FAKTOR = 800
                tb_R_Faktor.Text = 800
            ElseIf MainTab.SelectedTab.TabIndex = 1 Then
                PAGENDARM.FAKTOR = 800
                tb_P_Faktor.Text = 800
            ElseIf MainTab.SelectedTab.TabIndex = 2 Then
                NORDSON.FAKTOR = 800
                tb_N_Faktor.Text = 800
            End If
        End If
        If e.KeyValue = 49 And MainTab.SelectedTab.TabIndex = 0 Then
            If Aktueller_Wert.TYP = 112 Then
                RECO.ANTRIEB_E = Aktueller_Wert.Wert
            ElseIf Aktueller_Wert.TYP = 113 Then
                RECO.ANTRIEB_R = Aktueller_Wert.Wert
                tb_R_AS.Text = RECO.Antrieb()
            ElseIf Aktueller_Wert.TYP = 114 Then
                RECO.ANTRIEB_R = 0
                RECO.ANTRIEB_E = Aktueller_Wert.Wert
                tb_R_AS.Text = RECO.Antrieb()
            End If
        ElseIf e.KeyValue = 50 And MainTab.SelectedTab.TabIndex = 0 Then
            If Aktueller_Wert.TYP = 112 Then
                RECO.MITTE_E = Aktueller_Wert.Wert
            ElseIf Aktueller_Wert.TYP = 113 Then
                RECO.MITTE_R = Aktueller_Wert.Wert
                tb_R_M.Text = RECO.Mitte()
            ElseIf Aktueller_Wert.TYP = 114 Then
                RECO.MITTE_R = 0
                RECO.MITTE_E = Aktueller_Wert.Wert
                tb_R_M.Text = RECO.Mitte()
            End If
        ElseIf e.KeyValue = 51 And MainTab.SelectedTab.TabIndex = 0 Then
            If Aktueller_Wert.TYP = 112 Then
                RECO.BEDIEN_E = Aktueller_Wert.Wert
            ElseIf Aktueller_Wert.TYP = 113 Then
                RECO.BEDIEN_R = Aktueller_Wert.Wert
                tb_R_BS.Text = RECO.Mitte()
                tb_R_Mitt.Text = RECO.Mittelwert
                tb_R_Span.Text = RECO.Spannweite
            ElseIf Aktueller_Wert.TYP = 114 Then
                RECO.BEDIEN_R = 0
                RECO.BEDIEN_E = Aktueller_Wert.Wert
                tb_R_BS.Text = RECO.Mitte()
                tb_R_Mitt.Text = RECO.Mittelwert
                tb_R_Span.Text = RECO.Spannweite
            End If
        ElseIf e.KeyValue = 49 And MainTab.SelectedTab.TabIndex = 1 Then
            If Aktueller_Wert.TYP = 112 Then
                PAGENDARM.ANTRIEB_E = Aktueller_Wert.Wert
            ElseIf Aktueller_Wert.TYP = 113 Then
                PAGENDARM.ANTRIEB_R = Aktueller_Wert.Wert
                tb_P_AS.Text = PAGENDARM.Antrieb()
            ElseIf Aktueller_Wert.TYP = 114 Then
                PAGENDARM.ANTRIEB_R = 0
                PAGENDARM.ANTRIEB_E = Aktueller_Wert.Wert
                tb_P_AS.Text = PAGENDARM.Antrieb()
            End If
        ElseIf e.KeyValue = 50 And MainTab.SelectedTab.TabIndex = 1 Then
            If Aktueller_Wert.TYP = 112 Then
                PAGENDARM.MITTE_E = Aktueller_Wert.Wert
            ElseIf Aktueller_Wert.TYP = 113 Then
                PAGENDARM.MITTE_R = Aktueller_Wert.Wert
                tb_P_M.Text = PAGENDARM.Mitte()
            ElseIf Aktueller_Wert.TYP = 114 Then
                PAGENDARM.MITTE_R = 0
                PAGENDARM.MITTE_E = Aktueller_Wert.Wert
                tb_P_M.Text = PAGENDARM.Mitte()
            End If
        ElseIf e.KeyValue = 51 And MainTab.SelectedTab.TabIndex = 1 Then
            If Aktueller_Wert.TYP = 112 Then
                PAGENDARM.BEDIEN_E = Aktueller_Wert.Wert
            ElseIf Aktueller_Wert.TYP = 113 Then
                PAGENDARM.BEDIEN_R = Aktueller_Wert.Wert
                tb_P_BS.Text = PAGENDARM.Mitte()
                tb_P_Mitt.Text = PAGENDARM.Mittelwert
                tb_P_Span.Text = PAGENDARM.Spannweite
            ElseIf Aktueller_Wert.TYP = 114 Then
                PAGENDARM.BEDIEN_R = 0
                PAGENDARM.BEDIEN_E = Aktueller_Wert.Wert
                tb_P_BS.Text = PAGENDARM.Mitte()
                tb_P_Mitt.Text = PAGENDARM.Mittelwert
                tb_P_Span.Text = PAGENDARM.Spannweite
            End If
        ElseIf e.KeyValue = 49 And MainTab.SelectedTab.TabIndex = 2 Then
            If Aktueller_Wert.TYP = 112 Then
                NORDSON.ANTRIEB_E = Aktueller_Wert.Wert
            ElseIf Aktueller_Wert.TYP = 113 Then
                NORDSON.ANTRIEB_R = Aktueller_Wert.Wert
                tb_N_AS.Text = NORDSON.Antrieb()
            ElseIf Aktueller_Wert.TYP = 114 Then
                NORDSON.ANTRIEB_R = 0
                NORDSON.ANTRIEB_E = Aktueller_Wert.Wert
                tb_N_AS.Text = NORDSON.Antrieb()
            End If
        ElseIf e.KeyValue = 50 And MainTab.SelectedTab.TabIndex = 2 Then
            If Aktueller_Wert.TYP = 112 Then
                NORDSON.MITTE_E = Aktueller_Wert.Wert
            ElseIf Aktueller_Wert.TYP = 113 Then
                NORDSON.MITTE_R = Aktueller_Wert.Wert
                tb_N_M.Text = NORDSON.Mitte()
            ElseIf Aktueller_Wert.TYP = 114 Then
                NORDSON.MITTE_R = 0
                NORDSON.MITTE_E = Aktueller_Wert.Wert
                tb_N_M.Text = NORDSON.Mitte()
            End If
        ElseIf e.KeyValue = 51 And MainTab.SelectedTab.TabIndex = 2 Then
            If Aktueller_Wert.TYP = 112 Then
                NORDSON.BEDIEN_E = Aktueller_Wert.Wert
            ElseIf Aktueller_Wert.TYP = 113 Then
                NORDSON.BEDIEN_R = Aktueller_Wert.Wert
                tb_N_BS.Text = NORDSON.Mitte()
                tb_N_Mitt.Text = NORDSON.Mittelwert
                tb_N_Span.Text = NORDSON.Spannweite
            ElseIf Aktueller_Wert.TYP = 114 Then
                NORDSON.BEDIEN_R = 0
                NORDSON.BEDIEN_E = Aktueller_Wert.Wert
                tb_N_BS.Text = NORDSON.Mitte()
                tb_N_Mitt.Text = NORDSON.Mittelwert
                tb_N_Span.Text = NORDSON.Spannweite
            End If
        End If
    End Sub

    Private Sub F1_Click(sender As Object, e As EventArgs) Handles F1.Click
        Aktueller_Wert.TYP = 112
        SP_Waage.Write(vbLf & My.Settings.Send_Waage & vbCr) 'concatenate with \n
    End Sub

    Private Sub F2_Click(sender As Object, e As EventArgs) Handles F2.Click
        Aktueller_Wert.TYP = 113
        SP_Waage.Write(vbLf & My.Settings.Send_Waage & vbCr) 'concatenate with \n
    End Sub

    Private Sub F3_Click(sender As Object, e As EventArgs) Handles F3.Click
        Aktueller_Wert.TYP = 114
        SP_Waage.Write(vbLf & My.Settings.Send_Waage & vbCr) 'concatenate with \n
    End Sub

    Private Sub F8_Click(sender As Object, e As EventArgs) Handles F8.Click
        If MainTab.SelectedTab.TabIndex = 0 Then
            RECO.FAKTOR = 100
            tb_R_Faktor.Text = 100
        ElseIf MainTab.SelectedTab.TabIndex = 1 Then
            PAGENDARM.FAKTOR = 100
            tb_P_Faktor.Text = 100
        ElseIf MainTab.SelectedTab.TabIndex = 2 Then
            NORDSON.FAKTOR = 100
            tb_N_Faktor.Text = 100
        End If
    End Sub

    Private Sub F9_Click(sender As Object, e As EventArgs) Handles F9.Click
        If MainTab.SelectedTab.TabIndex = 0 Then
            RECO.FAKTOR = 200
            tb_R_Faktor.Text = 200
        ElseIf MainTab.SelectedTab.TabIndex = 1 Then
            PAGENDARM.FAKTOR = 200
            tb_P_Faktor.Text = 200
        ElseIf MainTab.SelectedTab.TabIndex = 2 Then
            NORDSON.FAKTOR = 200
            tb_N_Faktor.Text = 200
        End If
    End Sub

    Private Sub F10_Click(sender As Object, e As EventArgs) Handles F10.Click
        If MainTab.SelectedTab.TabIndex = 0 Then
            RECO.FAKTOR = 400
            tb_R_Faktor.Text = 400
        ElseIf MainTab.SelectedTab.TabIndex = 1 Then
            PAGENDARM.FAKTOR = 400
            tb_P_Faktor.Text = 400
        ElseIf MainTab.SelectedTab.TabIndex = 2 Then
            NORDSON.FAKTOR = 400
            tb_N_Faktor.Text = 400
        End If
    End Sub

    Private Sub F11_Click(sender As Object, e As EventArgs) Handles F11.Click
        If MainTab.SelectedTab.TabIndex = 0 Then
            RECO.FAKTOR = 800
            tb_R_Faktor.Text = 800
        ElseIf MainTab.SelectedTab.TabIndex = 1 Then
            PAGENDARM.FAKTOR = 800
            tb_P_Faktor.Text = 800
        ElseIf MainTab.SelectedTab.TabIndex = 2 Then
            NORDSON.FAKTOR = 800
            tb_N_Faktor.Text = 800
        End If
    End Sub

    Private Sub Waage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RECO.FAKTOR = 100
        PAGENDARM.FAKTOR = 100
        NORDSON.FAKTOR = 200
        tb_R_Faktor.Text = RECO.FAKTOR
        tb_P_Faktor.Text = PAGENDARM.FAKTOR
        tb_N_Faktor.Text = NORDSON.FAKTOR
    End Sub


End Class