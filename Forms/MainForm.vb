Imports System
Imports System.Threading
Imports System.IO.Ports
Imports System.ComponentModel

Public Class MainForm
    '------------------------------------------------
    Dim myPort As Array

    '------------------------------------------------
    Private Sub MainForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        OpenForm(Waage, MainPanel)
    End Sub
    '------------------------------------------------


    Private Sub EinstellungenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EinstellungenToolStripMenuItem.Click
        OpenForm(Settings, MainPanel)
    End Sub

    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click
        Me.Close()
    End Sub


End Class
