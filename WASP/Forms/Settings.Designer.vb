<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.COMPorts = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.P_D = New System.Windows.Forms.ComboBox()
        Me.COM_D = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SB_W = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SB_D = New System.Windows.Forms.TextBox()
        Me.DB_D = New System.Windows.Forms.TextBox()
        Me.COM_W = New System.Windows.Forms.ComboBox()
        Me.P_W = New System.Windows.Forms.ComboBox()
        Me.cb_Waage = New System.Windows.Forms.CheckBox()
        Me.cb_Drucker = New System.Windows.Forms.CheckBox()
        Me.Keys = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Send_W = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Send_D = New System.Windows.Forms.TextBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.BR_W = New System.Windows.Forms.ComboBox()
        Me.BR_D = New System.Windows.Forms.ComboBox()
        Me.DB_W = New System.Windows.Forms.ComboBox()
        Me.Handshake = New System.Windows.Forms.Label()
        Me.HS_W = New System.Windows.Forms.ComboBox()
        Me.TabControl1.SuspendLayout()
        Me.COMPorts.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Keys.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.COMPorts)
        Me.TabControl1.Controls.Add(Me.Keys)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 43)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(627, 270)
        Me.TabControl1.TabIndex = 0
        '
        'COMPorts
        '
        Me.COMPorts.Controls.Add(Me.TableLayoutPanel1)
        Me.COMPorts.Location = New System.Drawing.Point(4, 22)
        Me.COMPorts.Name = "COMPorts"
        Me.COMPorts.Padding = New System.Windows.Forms.Padding(3)
        Me.COMPorts.Size = New System.Drawing.Size(619, 244)
        Me.COMPorts.TabIndex = 0
        Me.COMPorts.Text = "COM-Ports"
        Me.COMPorts.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 8
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.P_D, 5, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.COM_D, 5, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label13, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.SB_W, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 4, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 4, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 4, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.SB_D, 5, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.DB_D, 5, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.COM_W, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.P_W, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cb_Waage, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cb_Drucker, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BR_W, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.BR_D, 5, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.DB_W, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.HS_W, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Handshake, 0, 6)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(613, 238)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'P_D
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.P_D, 2)
        Me.P_D.Dock = System.Windows.Forms.DockStyle.Fill
        Me.P_D.FormattingEnabled = True
        Me.P_D.Items.AddRange(New Object() {"None", "Even", "Odd", "Mark", "Space"})
        Me.P_D.Location = New System.Drawing.Point(422, 93)
        Me.P_D.Name = "P_D"
        Me.P_D.Size = New System.Drawing.Size(137, 24)
        Me.P_D.TabIndex = 26
        '
        'COM_D
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.COM_D, 2)
        Me.COM_D.Dock = System.Windows.Forms.DockStyle.Fill
        Me.COM_D.FormattingEnabled = True
        Me.COM_D.Location = New System.Drawing.Point(422, 33)
        Me.COM_D.Name = "COM_D"
        Me.COM_D.Size = New System.Drawing.Size(137, 24)
        Me.COM_D.TabIndex = 24
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label13.Location = New System.Drawing.Point(309, 30)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(107, 30)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "COM"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Location = New System.Drawing.Point(3, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 30)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "COM"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label1, 2)
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Einstellungen Waage"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label2, 2)
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(309, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Einstellungen Drucker"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(3, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 30)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Stop Bit"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Location = New System.Drawing.Point(3, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 30)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Data Bits"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Location = New System.Drawing.Point(3, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 30)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Parity"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(3, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 30)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Baud Rate"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SB_W
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.SB_W, 2)
        Me.SB_W.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SB_W.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SB_W.Location = New System.Drawing.Point(116, 153)
        Me.SB_W.Name = "SB_W"
        Me.SB_W.Size = New System.Drawing.Size(137, 22)
        Me.SB_W.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Location = New System.Drawing.Point(309, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 30)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Stop Bit"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label12.Location = New System.Drawing.Point(309, 120)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(107, 30)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Data Bits"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Location = New System.Drawing.Point(309, 90)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 30)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Parity"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(309, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 30)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Baud Rate"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SB_D
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.SB_D, 2)
        Me.SB_D.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SB_D.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SB_D.Location = New System.Drawing.Point(422, 153)
        Me.SB_D.Name = "SB_D"
        Me.SB_D.Size = New System.Drawing.Size(137, 22)
        Me.SB_D.TabIndex = 19
        '
        'DB_D
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.DB_D, 2)
        Me.DB_D.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DB_D.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DB_D.Location = New System.Drawing.Point(422, 123)
        Me.DB_D.Name = "DB_D"
        Me.DB_D.Size = New System.Drawing.Size(137, 22)
        Me.DB_D.TabIndex = 17
        '
        'COM_W
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.COM_W, 2)
        Me.COM_W.Dock = System.Windows.Forms.DockStyle.Fill
        Me.COM_W.FormattingEnabled = True
        Me.COM_W.Location = New System.Drawing.Point(116, 33)
        Me.COM_W.Name = "COM_W"
        Me.COM_W.Size = New System.Drawing.Size(137, 24)
        Me.COM_W.TabIndex = 23
        '
        'P_W
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.P_W, 2)
        Me.P_W.Dock = System.Windows.Forms.DockStyle.Fill
        Me.P_W.FormattingEnabled = True
        Me.P_W.Items.AddRange(New Object() {"None", "Even", "Odd", "Mark", "Space"})
        Me.P_W.Location = New System.Drawing.Point(116, 93)
        Me.P_W.Name = "P_W"
        Me.P_W.Size = New System.Drawing.Size(137, 24)
        Me.P_W.TabIndex = 25
        '
        'cb_Waage
        '
        Me.cb_Waage.AutoSize = True
        Me.cb_Waage.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cb_Waage.Checked = True
        Me.cb_Waage.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_Waage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cb_Waage.Location = New System.Drawing.Point(229, 3)
        Me.cb_Waage.Name = "cb_Waage"
        Me.cb_Waage.Size = New System.Drawing.Size(24, 24)
        Me.cb_Waage.TabIndex = 27
        Me.cb_Waage.UseVisualStyleBackColor = True
        '
        'cb_Drucker
        '
        Me.cb_Drucker.AutoSize = True
        Me.cb_Drucker.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cb_Drucker.Checked = True
        Me.cb_Drucker.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_Drucker.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cb_Drucker.Location = New System.Drawing.Point(535, 3)
        Me.cb_Drucker.Name = "cb_Drucker"
        Me.cb_Drucker.Size = New System.Drawing.Size(24, 24)
        Me.cb_Drucker.TabIndex = 28
        Me.cb_Drucker.UseVisualStyleBackColor = True
        '
        'Keys
        '
        Me.Keys.Controls.Add(Me.TableLayoutPanel4)
        Me.Keys.Location = New System.Drawing.Point(4, 22)
        Me.Keys.Name = "Keys"
        Me.Keys.Size = New System.Drawing.Size(619, 244)
        Me.Keys.TabIndex = 2
        Me.Keys.Text = "Keys"
        Me.Keys.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 4
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Label15, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label16, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label17, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Send_W, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label21, 2, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Send_D, 3, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(619, 244)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.TableLayoutPanel4.SetColumnSpan(Me.Label15, 2)
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label15.Location = New System.Drawing.Point(3, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(302, 30)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Einstellungen Waage"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.TableLayoutPanel4.SetColumnSpan(Me.Label16, 2)
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label16.Location = New System.Drawing.Point(311, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(305, 30)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Einstellungen Drucker"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label17.Location = New System.Drawing.Point(3, 30)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(148, 30)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "Senden"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Send_W
        '
        Me.Send_W.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Send_W.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Send_W.Location = New System.Drawing.Point(157, 33)
        Me.Send_W.Name = "Send_W"
        Me.Send_W.Size = New System.Drawing.Size(148, 22)
        Me.Send_W.TabIndex = 18
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label21.Location = New System.Drawing.Point(311, 30)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(148, 30)
        Me.Label21.TabIndex = 5
        Me.Label21.Text = "Senden"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Send_D
        '
        Me.Send_D.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Send_D.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Send_D.Location = New System.Drawing.Point(465, 33)
        Me.Send_D.Name = "Send_D"
        Me.Send_D.Size = New System.Drawing.Size(151, 22)
        Me.Send_D.TabIndex = 19
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "diskette-6.png")
        Me.ImageList1.Images.SetKeyName(1, "Actions-process-stop-icon.png")
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TabControl1, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(633, 316)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btn_cancel, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btn_save, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(627, 34)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'btn_cancel
        '
        Me.btn_cancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_cancel.FlatAppearance.BorderSize = 0
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.ImageKey = "Actions-process-stop-icon.png"
        Me.btn_cancel.ImageList = Me.ImageList1
        Me.btn_cancel.Location = New System.Drawing.Point(590, 3)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(34, 28)
        Me.btn_cancel.TabIndex = 0
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_save.FlatAppearance.BorderSize = 0
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.ImageKey = "diskette-6.png"
        Me.btn_save.ImageList = Me.ImageList1
        Me.btn_save.Location = New System.Drawing.Point(3, 3)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(34, 28)
        Me.btn_save.TabIndex = 1
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'BR_W
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.BR_W, 2)
        Me.BR_W.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BR_W.FormattingEnabled = True
        Me.BR_W.Items.AddRange(New Object() {"1200", "2400", "4800", "9600", "19200"})
        Me.BR_W.Location = New System.Drawing.Point(116, 63)
        Me.BR_W.Name = "BR_W"
        Me.BR_W.Size = New System.Drawing.Size(137, 24)
        Me.BR_W.TabIndex = 29
        '
        'BR_D
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.BR_D, 2)
        Me.BR_D.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BR_D.FormattingEnabled = True
        Me.BR_D.Items.AddRange(New Object() {"1200", "2400", "4800", "9600", "19200"})
        Me.BR_D.Location = New System.Drawing.Point(422, 63)
        Me.BR_D.Name = "BR_D"
        Me.BR_D.Size = New System.Drawing.Size(137, 24)
        Me.BR_D.TabIndex = 30
        '
        'DB_W
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.DB_W, 2)
        Me.DB_W.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DB_W.FormattingEnabled = True
        Me.DB_W.Items.AddRange(New Object() {"5", "6", "7", "8", "9"})
        Me.DB_W.Location = New System.Drawing.Point(116, 123)
        Me.DB_W.Name = "DB_W"
        Me.DB_W.Size = New System.Drawing.Size(137, 24)
        Me.DB_W.TabIndex = 31
        '
        'Handshake
        '
        Me.Handshake.AutoSize = True
        Me.Handshake.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Handshake.Location = New System.Drawing.Point(3, 180)
        Me.Handshake.Name = "Handshake"
        Me.Handshake.Size = New System.Drawing.Size(107, 30)
        Me.Handshake.TabIndex = 32
        Me.Handshake.Text = "Handshake"
        Me.Handshake.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HS_W
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.HS_W, 2)
        Me.HS_W.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HS_W.FormattingEnabled = True
        Me.HS_W.Location = New System.Drawing.Point(116, 183)
        Me.HS_W.Name = "HS_W"
        Me.HS_W.Size = New System.Drawing.Size(137, 24)
        Me.HS_W.TabIndex = 33
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 316)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.TabControl1.ResumeLayout(False)
        Me.COMPorts.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Keys.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents COMPorts As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Keys As TabPage
    Friend WithEvents SB_D As TextBox
    Friend WithEvents SB_W As TextBox
    Friend WithEvents DB_D As TextBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents COM_D As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents COM_W As ComboBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Send_W As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Send_D As TextBox
    Friend WithEvents P_D As ComboBox
    Friend WithEvents P_W As ComboBox
    Friend WithEvents cb_Waage As CheckBox
    Friend WithEvents cb_Drucker As CheckBox
    Friend WithEvents BR_W As ComboBox
    Friend WithEvents BR_D As ComboBox
    Friend WithEvents DB_W As ComboBox
    Friend WithEvents HS_W As ComboBox
    Friend WithEvents Handshake As Label
End Class
