<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Waage
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Waage))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.disconnect = New System.Windows.Forms.Button()
        Me.init = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.F2 = New System.Windows.Forms.Button()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.F1 = New System.Windows.Forms.Button()
        Me.F3 = New System.Windows.Forms.Button()
        Me.F5 = New System.Windows.Forms.Button()
        Me.F9 = New System.Windows.Forms.Button()
        Me.F6 = New System.Windows.Forms.Button()
        Me.F8 = New System.Windows.Forms.Button()
        Me.F7 = New System.Windows.Forms.Button()
        Me.F10 = New System.Windows.Forms.Button()
        Me.F11 = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.MainTab = New System.Windows.Forms.TabControl()
        Me.TAB_RECO = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_R_AS = New System.Windows.Forms.TextBox()
        Me.tb_R_M = New System.Windows.Forms.TextBox()
        Me.tb_R_BS = New System.Windows.Forms.TextBox()
        Me.tb_R_Faktor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.tb_R_Span = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tb_R_Mitt = New System.Windows.Forms.TextBox()
        Me.TAB_Pagendarm = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_P_AS = New System.Windows.Forms.TextBox()
        Me.tb_P_M = New System.Windows.Forms.TextBox()
        Me.tb_P_BS = New System.Windows.Forms.TextBox()
        Me.tb_P_Faktor = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.tb_P_Span = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tb_P_Mitt = New System.Windows.Forms.TextBox()
        Me.TAB_Hotmelt = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tb_N_AS = New System.Windows.Forms.TextBox()
        Me.tb_N_M = New System.Windows.Forms.TextBox()
        Me.tb_N_BS = New System.Windows.Forms.TextBox()
        Me.tb_N_Faktor = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.tb_N_Span = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tb_N_Mitt = New System.Windows.Forms.TextBox()
        Me.SP_Waage = New System.IO.Ports.SerialPort(Me.components)
        Me.SP_Drucker = New System.IO.Ports.SerialPort(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.MainTab.SuspendLayout()
        Me.TAB_RECO.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        Me.TAB_Pagendarm.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.TAB_Hotmelt.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.MainTab, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(955, 467)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Button1, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.disconnect, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.init, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(949, 34)
        Me.TableLayoutPanel2.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ImageKey = "broom-icon.png"
        Me.Button1.ImageList = Me.ImageList1
        Me.Button1.Location = New System.Drawing.Point(80, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 34)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "connect-icon.png")
        Me.ImageList1.Images.SetKeyName(1, "App-edit-icon.png")
        Me.ImageList1.Images.SetKeyName(2, "disconnect-icon.png")
        Me.ImageList1.Images.SetKeyName(3, "broom-icon.png")
        '
        'disconnect
        '
        Me.disconnect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.disconnect.Enabled = False
        Me.disconnect.FlatAppearance.BorderSize = 0
        Me.disconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.disconnect.ImageKey = "disconnect-icon.png"
        Me.disconnect.ImageList = Me.ImageList1
        Me.disconnect.Location = New System.Drawing.Point(40, 0)
        Me.disconnect.Margin = New System.Windows.Forms.Padding(0)
        Me.disconnect.Name = "disconnect"
        Me.disconnect.Size = New System.Drawing.Size(40, 34)
        Me.disconnect.TabIndex = 1
        Me.disconnect.UseVisualStyleBackColor = True
        '
        'init
        '
        Me.init.Dock = System.Windows.Forms.DockStyle.Fill
        Me.init.FlatAppearance.BorderSize = 0
        Me.init.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.init.ImageKey = "connect-icon.png"
        Me.init.ImageList = Me.ImageList1
        Me.init.Location = New System.Drawing.Point(0, 0)
        Me.init.Margin = New System.Windows.Forms.Padding(0)
        Me.init.Name = "init"
        Me.init.Size = New System.Drawing.Size(40, 34)
        Me.init.TabIndex = 0
        Me.init.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 13
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label28, 6, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label27, 5, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label26, 4, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label24, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label23, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.F2, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.F1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.F3, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.F5, 4, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.F9, 9, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.F6, 5, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.F8, 8, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.F7, 6, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.F10, 10, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.F11, 11, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label19, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label20, 8, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label21, 9, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label22, 10, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label25, 11, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 40)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(955, 100)
        Me.TableLayoutPanel3.TabIndex = 9
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(373, 75)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(64, 25)
        Me.Label28.TabIndex = 20
        Me.Label28.Text = "Hotmelt"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(303, 75)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(64, 25)
        Me.Label27.TabIndex = 19
        Me.Label27.Text = "Pagendarm"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(233, 75)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(64, 25)
        Me.Label26.TabIndex = 18
        Me.Label26.Text = "RECO"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(143, 75)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(64, 25)
        Me.Label24.TabIndex = 16
        Me.Label24.Text = "Direktwert"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(73, 75)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(64, 25)
        Me.Label23.TabIndex = 15
        Me.Label23.Text = "Rückwaage"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'F2
        '
        Me.F2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.F2.Enabled = False
        Me.F2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.F2.ImageKey = "blank-keyboard-key-icon.png"
        Me.F2.ImageList = Me.ImageList2
        Me.F2.Location = New System.Drawing.Point(73, 3)
        Me.F2.Name = "F2"
        Me.F2.Size = New System.Drawing.Size(64, 69)
        Me.F2.TabIndex = 1
        Me.F2.Text = "F2"
        Me.F2.UseVisualStyleBackColor = True
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "blank-keyboard-key-icon.png")
        '
        'F1
        '
        Me.F1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.F1.Enabled = False
        Me.F1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.F1.ImageKey = "blank-keyboard-key-icon.png"
        Me.F1.ImageList = Me.ImageList2
        Me.F1.Location = New System.Drawing.Point(3, 3)
        Me.F1.Name = "F1"
        Me.F1.Size = New System.Drawing.Size(64, 69)
        Me.F1.TabIndex = 5
        Me.F1.Text = "F1"
        Me.F1.UseVisualStyleBackColor = True
        '
        'F3
        '
        Me.F3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.F3.Enabled = False
        Me.F3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.F3.ImageKey = "blank-keyboard-key-icon.png"
        Me.F3.ImageList = Me.ImageList2
        Me.F3.Location = New System.Drawing.Point(143, 3)
        Me.F3.Name = "F3"
        Me.F3.Size = New System.Drawing.Size(64, 69)
        Me.F3.TabIndex = 7
        Me.F3.Text = "F3"
        Me.F3.UseVisualStyleBackColor = True
        '
        'F5
        '
        Me.F5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.F5.Enabled = False
        Me.F5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.F5.ImageKey = "blank-keyboard-key-icon.png"
        Me.F5.ImageList = Me.ImageList2
        Me.F5.Location = New System.Drawing.Point(233, 3)
        Me.F5.Name = "F5"
        Me.F5.Size = New System.Drawing.Size(64, 69)
        Me.F5.TabIndex = 6
        Me.F5.Text = "F5"
        Me.F5.UseVisualStyleBackColor = True
        '
        'F9
        '
        Me.F9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.F9.Enabled = False
        Me.F9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F9.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.F9.ImageKey = "blank-keyboard-key-icon.png"
        Me.F9.ImageList = Me.ImageList2
        Me.F9.Location = New System.Drawing.Point(533, 3)
        Me.F9.Name = "F9"
        Me.F9.Size = New System.Drawing.Size(64, 69)
        Me.F9.TabIndex = 4
        Me.F9.Text = "F9"
        Me.F9.UseVisualStyleBackColor = True
        '
        'F6
        '
        Me.F6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.F6.Enabled = False
        Me.F6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.F6.ImageKey = "blank-keyboard-key-icon.png"
        Me.F6.ImageList = Me.ImageList2
        Me.F6.Location = New System.Drawing.Point(303, 3)
        Me.F6.Name = "F6"
        Me.F6.Size = New System.Drawing.Size(64, 69)
        Me.F6.TabIndex = 2
        Me.F6.Text = "F6"
        Me.F6.UseVisualStyleBackColor = True
        '
        'F8
        '
        Me.F8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.F8.Enabled = False
        Me.F8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F8.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.F8.ImageKey = "blank-keyboard-key-icon.png"
        Me.F8.ImageList = Me.ImageList2
        Me.F8.Location = New System.Drawing.Point(463, 3)
        Me.F8.Name = "F8"
        Me.F8.Size = New System.Drawing.Size(64, 69)
        Me.F8.TabIndex = 8
        Me.F8.Text = "F8"
        Me.F8.UseVisualStyleBackColor = True
        '
        'F7
        '
        Me.F7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.F7.Enabled = False
        Me.F7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F7.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.F7.ImageKey = "blank-keyboard-key-icon.png"
        Me.F7.ImageList = Me.ImageList2
        Me.F7.Location = New System.Drawing.Point(373, 3)
        Me.F7.Name = "F7"
        Me.F7.Size = New System.Drawing.Size(64, 69)
        Me.F7.TabIndex = 3
        Me.F7.Text = "F7"
        Me.F7.UseVisualStyleBackColor = True
        '
        'F10
        '
        Me.F10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.F10.Enabled = False
        Me.F10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F10.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.F10.ImageKey = "blank-keyboard-key-icon.png"
        Me.F10.ImageList = Me.ImageList2
        Me.F10.Location = New System.Drawing.Point(603, 3)
        Me.F10.Name = "F10"
        Me.F10.Size = New System.Drawing.Size(64, 69)
        Me.F10.TabIndex = 9
        Me.F10.Text = "F10"
        Me.F10.UseVisualStyleBackColor = True
        '
        'F11
        '
        Me.F11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.F11.Enabled = False
        Me.F11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F11.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.F11.ImageKey = "blank-keyboard-key-icon.png"
        Me.F11.ImageList = Me.ImageList2
        Me.F11.Location = New System.Drawing.Point(673, 3)
        Me.F11.Name = "F11"
        Me.F11.Size = New System.Drawing.Size(64, 69)
        Me.F11.TabIndex = 10
        Me.F11.Text = "F11"
        Me.F11.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(3, 75)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 25)
        Me.Label19.TabIndex = 11
        Me.Label19.Text = "Einwaage"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(463, 75)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(64, 25)
        Me.Label20.TabIndex = 12
        Me.Label20.Text = "Faktor 100"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(533, 75)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(64, 25)
        Me.Label21.TabIndex = 13
        Me.Label21.Text = "Faktor 200"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(603, 75)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(64, 25)
        Me.Label22.TabIndex = 14
        Me.Label22.Text = "Faktor 400"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(673, 75)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(64, 25)
        Me.Label25.TabIndex = 17
        Me.Label25.Text = "Faktor 800"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainTab
        '
        Me.MainTab.Controls.Add(Me.TAB_RECO)
        Me.MainTab.Controls.Add(Me.TAB_Pagendarm)
        Me.MainTab.Controls.Add(Me.TAB_Hotmelt)
        Me.MainTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTab.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainTab.Location = New System.Drawing.Point(3, 143)
        Me.MainTab.Name = "MainTab"
        Me.MainTab.SelectedIndex = 0
        Me.MainTab.Size = New System.Drawing.Size(949, 321)
        Me.MainTab.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.MainTab.TabIndex = 10
        '
        'TAB_RECO
        '
        Me.TAB_RECO.Controls.Add(Me.TableLayoutPanel4)
        Me.TAB_RECO.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TAB_RECO.Location = New System.Drawing.Point(4, 34)
        Me.TAB_RECO.Name = "TAB_RECO"
        Me.TAB_RECO.Padding = New System.Windows.Forms.Padding(3)
        Me.TAB_RECO.Size = New System.Drawing.Size(941, 283)
        Me.TAB_RECO.TabIndex = 0
        Me.TAB_RECO.Text = "RECO"
        Me.TAB_RECO.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel4.Controls.Add(Me.Label4, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.tb_R_AS, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.tb_R_M, 1, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.tb_R_BS, 2, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.tb_R_Faktor, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label2, 2, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel9, 1, 3)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 5
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(935, 277)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(314, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(305, 40)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "M"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(3, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(305, 40)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "AS"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tb_R_AS
        '
        Me.tb_R_AS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_R_AS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tb_R_AS.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_R_AS.Location = New System.Drawing.Point(3, 78)
        Me.tb_R_AS.Name = "tb_R_AS"
        Me.tb_R_AS.Size = New System.Drawing.Size(305, 31)
        Me.tb_R_AS.TabIndex = 0
        Me.tb_R_AS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tb_R_M
        '
        Me.tb_R_M.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_R_M.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tb_R_M.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_R_M.Location = New System.Drawing.Point(314, 78)
        Me.tb_R_M.Name = "tb_R_M"
        Me.tb_R_M.Size = New System.Drawing.Size(305, 31)
        Me.tb_R_M.TabIndex = 1
        Me.tb_R_M.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tb_R_BS
        '
        Me.tb_R_BS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_R_BS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tb_R_BS.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_R_BS.Location = New System.Drawing.Point(625, 78)
        Me.tb_R_BS.Name = "tb_R_BS"
        Me.tb_R_BS.Size = New System.Drawing.Size(307, 31)
        Me.tb_R_BS.TabIndex = 2
        Me.tb_R_BS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tb_R_Faktor
        '
        Me.tb_R_Faktor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_R_Faktor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tb_R_Faktor.Location = New System.Drawing.Point(314, 3)
        Me.tb_R_Faktor.Name = "tb_R_Faktor"
        Me.tb_R_Faktor.Size = New System.Drawing.Size(305, 22)
        Me.tb_R_Faktor.TabIndex = 3
        Me.tb_R_Faktor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(305, 35)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Faktor"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(625, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(307, 40)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "BS"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.ColumnCount = 2
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.tb_R_Span, 1, 1)
        Me.TableLayoutPanel9.Controls.Add(Me.Label17, 0, 1)
        Me.TableLayoutPanel9.Controls.Add(Me.Label18, 0, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.tb_R_Mitt, 1, 0)
        Me.TableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(314, 168)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 2
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(305, 54)
        Me.TableLayoutPanel9.TabIndex = 9
        '
        'tb_R_Span
        '
        Me.tb_R_Span.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_R_Span.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tb_R_Span.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_R_Span.Location = New System.Drawing.Point(155, 30)
        Me.tb_R_Span.Name = "tb_R_Span"
        Me.tb_R_Span.Size = New System.Drawing.Size(147, 17)
        Me.tb_R_Span.TabIndex = 10
        Me.tb_R_Span.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(3, 27)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(146, 27)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "Spannweite"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(3, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(146, 27)
        Me.Label18.TabIndex = 7
        Me.Label18.Text = "Mittelwert"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tb_R_Mitt
        '
        Me.tb_R_Mitt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_R_Mitt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tb_R_Mitt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_R_Mitt.Location = New System.Drawing.Point(155, 3)
        Me.tb_R_Mitt.Name = "tb_R_Mitt"
        Me.tb_R_Mitt.Size = New System.Drawing.Size(147, 17)
        Me.tb_R_Mitt.TabIndex = 9
        Me.tb_R_Mitt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TAB_Pagendarm
        '
        Me.TAB_Pagendarm.Controls.Add(Me.TableLayoutPanel5)
        Me.TAB_Pagendarm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TAB_Pagendarm.Location = New System.Drawing.Point(4, 34)
        Me.TAB_Pagendarm.Name = "TAB_Pagendarm"
        Me.TAB_Pagendarm.Padding = New System.Windows.Forms.Padding(3)
        Me.TAB_Pagendarm.Size = New System.Drawing.Size(941, 283)
        Me.TAB_Pagendarm.TabIndex = 1
        Me.TAB_Pagendarm.Text = "Pagendarm"
        Me.TAB_Pagendarm.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel5.Controls.Add(Me.Label5, 1, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.Label6, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.tb_P_AS, 0, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.tb_P_M, 1, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.tb_P_BS, 2, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.tb_P_Faktor, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label8, 2, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel8, 1, 3)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 5
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(935, 277)
        Me.TableLayoutPanel5.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(314, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(305, 40)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "M"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Location = New System.Drawing.Point(3, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(305, 40)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "AS"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tb_P_AS
        '
        Me.tb_P_AS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_P_AS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tb_P_AS.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_P_AS.Location = New System.Drawing.Point(3, 78)
        Me.tb_P_AS.Name = "tb_P_AS"
        Me.tb_P_AS.Size = New System.Drawing.Size(305, 31)
        Me.tb_P_AS.TabIndex = 0
        Me.tb_P_AS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tb_P_M
        '
        Me.tb_P_M.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_P_M.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tb_P_M.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_P_M.Location = New System.Drawing.Point(314, 78)
        Me.tb_P_M.Name = "tb_P_M"
        Me.tb_P_M.Size = New System.Drawing.Size(305, 31)
        Me.tb_P_M.TabIndex = 1
        Me.tb_P_M.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tb_P_BS
        '
        Me.tb_P_BS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_P_BS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tb_P_BS.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_P_BS.Location = New System.Drawing.Point(625, 78)
        Me.tb_P_BS.Name = "tb_P_BS"
        Me.tb_P_BS.Size = New System.Drawing.Size(307, 31)
        Me.tb_P_BS.TabIndex = 2
        Me.tb_P_BS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tb_P_Faktor
        '
        Me.tb_P_Faktor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_P_Faktor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tb_P_Faktor.Location = New System.Drawing.Point(314, 3)
        Me.tb_P_Faktor.Name = "tb_P_Faktor"
        Me.tb_P_Faktor.Size = New System.Drawing.Size(305, 22)
        Me.tb_P_Faktor.TabIndex = 3
        Me.tb_P_Faktor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Location = New System.Drawing.Point(3, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(305, 35)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Faktor"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Location = New System.Drawing.Point(625, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(307, 40)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "BS"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 2
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.tb_P_Span, 1, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.Label15, 0, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.Label16, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.tb_P_Mitt, 1, 0)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(314, 168)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 2
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(305, 54)
        Me.TableLayoutPanel8.TabIndex = 9
        '
        'tb_P_Span
        '
        Me.tb_P_Span.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_P_Span.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tb_P_Span.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_P_Span.Location = New System.Drawing.Point(155, 30)
        Me.tb_P_Span.Name = "tb_P_Span"
        Me.tb_P_Span.Size = New System.Drawing.Size(147, 17)
        Me.tb_P_Span.TabIndex = 10
        Me.tb_P_Span.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(3, 27)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(146, 27)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Spannweite"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(3, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(146, 27)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "Mittelwert"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tb_P_Mitt
        '
        Me.tb_P_Mitt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_P_Mitt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tb_P_Mitt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_P_Mitt.Location = New System.Drawing.Point(155, 3)
        Me.tb_P_Mitt.Name = "tb_P_Mitt"
        Me.tb_P_Mitt.Size = New System.Drawing.Size(147, 17)
        Me.tb_P_Mitt.TabIndex = 9
        Me.tb_P_Mitt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TAB_Hotmelt
        '
        Me.TAB_Hotmelt.Controls.Add(Me.TableLayoutPanel6)
        Me.TAB_Hotmelt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TAB_Hotmelt.Location = New System.Drawing.Point(4, 34)
        Me.TAB_Hotmelt.Name = "TAB_Hotmelt"
        Me.TAB_Hotmelt.Padding = New System.Windows.Forms.Padding(3)
        Me.TAB_Hotmelt.Size = New System.Drawing.Size(941, 283)
        Me.TAB_Hotmelt.TabIndex = 2
        Me.TAB_Hotmelt.Text = "Hotmelt"
        Me.TAB_Hotmelt.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 3
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel6.Controls.Add(Me.Label9, 1, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.Label10, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.tb_N_AS, 0, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.tb_N_M, 1, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.tb_N_BS, 2, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.tb_N_Faktor, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Label11, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Label12, 2, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.TableLayoutPanel7, 1, 3)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 5
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(935, 277)
        Me.TableLayoutPanel6.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Location = New System.Drawing.Point(314, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(305, 40)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "M"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Location = New System.Drawing.Point(3, 35)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(305, 40)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "AS"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tb_N_AS
        '
        Me.tb_N_AS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_N_AS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tb_N_AS.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_N_AS.Location = New System.Drawing.Point(3, 78)
        Me.tb_N_AS.Name = "tb_N_AS"
        Me.tb_N_AS.Size = New System.Drawing.Size(305, 31)
        Me.tb_N_AS.TabIndex = 0
        Me.tb_N_AS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tb_N_M
        '
        Me.tb_N_M.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_N_M.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tb_N_M.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_N_M.Location = New System.Drawing.Point(314, 78)
        Me.tb_N_M.Name = "tb_N_M"
        Me.tb_N_M.Size = New System.Drawing.Size(305, 31)
        Me.tb_N_M.TabIndex = 1
        Me.tb_N_M.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tb_N_BS
        '
        Me.tb_N_BS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_N_BS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tb_N_BS.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_N_BS.Location = New System.Drawing.Point(625, 78)
        Me.tb_N_BS.Name = "tb_N_BS"
        Me.tb_N_BS.Size = New System.Drawing.Size(307, 31)
        Me.tb_N_BS.TabIndex = 2
        Me.tb_N_BS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tb_N_Faktor
        '
        Me.tb_N_Faktor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_N_Faktor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tb_N_Faktor.Location = New System.Drawing.Point(314, 3)
        Me.tb_N_Faktor.Name = "tb_N_Faktor"
        Me.tb_N_Faktor.Size = New System.Drawing.Size(305, 22)
        Me.tb_N_Faktor.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Location = New System.Drawing.Point(3, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(305, 35)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Faktor"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label12.Location = New System.Drawing.Point(625, 35)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(307, 40)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "BS"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 2
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.tb_N_Span, 1, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.Label14, 0, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.Label13, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.tb_N_Mitt, 1, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(314, 168)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 2
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(305, 54)
        Me.TableLayoutPanel7.TabIndex = 8
        '
        'tb_N_Span
        '
        Me.tb_N_Span.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_N_Span.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tb_N_Span.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_N_Span.Location = New System.Drawing.Point(155, 30)
        Me.tb_N_Span.Name = "tb_N_Span"
        Me.tb_N_Span.Size = New System.Drawing.Size(147, 17)
        Me.tb_N_Span.TabIndex = 10
        Me.tb_N_Span.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(3, 27)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(146, 27)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Spannweite"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(3, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(146, 27)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Mittelwert"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tb_N_Mitt
        '
        Me.tb_N_Mitt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_N_Mitt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tb_N_Mitt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_N_Mitt.Location = New System.Drawing.Point(155, 3)
        Me.tb_N_Mitt.Name = "tb_N_Mitt"
        Me.tb_N_Mitt.Size = New System.Drawing.Size(147, 17)
        Me.tb_N_Mitt.TabIndex = 9
        Me.tb_N_Mitt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SP_Waage
        '
        Me.SP_Waage.Handshake = System.IO.Ports.Handshake.XOnXOff
        '
        'Waage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 467)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "Waage"
        Me.Text = "Waage"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.MainTab.ResumeLayout(False)
        Me.TAB_RECO.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel9.PerformLayout()
        Me.TAB_Pagendarm.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        Me.TAB_Hotmelt.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents init As Button
    Friend WithEvents F2 As Button
    Friend WithEvents SP_Waage As IO.Ports.SerialPort
    Friend WithEvents SP_Drucker As IO.Ports.SerialPort
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents disconnect As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents F3 As Button
    Friend WithEvents ImageList2 As ImageList
    Friend WithEvents F5 As Button
    Friend WithEvents F1 As Button
    Friend WithEvents F9 As Button
    Friend WithEvents F7 As Button
    Friend WithEvents F6 As Button
    Friend WithEvents F8 As Button
    Friend WithEvents MainTab As TabControl
    Friend WithEvents TAB_RECO As TabPage
    Friend WithEvents TAB_Pagendarm As TabPage
    Friend WithEvents TAB_Hotmelt As TabPage
    Friend WithEvents F10 As Button
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_R_AS As TextBox
    Friend WithEvents tb_R_M As TextBox
    Friend WithEvents tb_R_BS As TextBox
    Friend WithEvents tb_R_Faktor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tb_P_AS As TextBox
    Friend WithEvents tb_P_M As TextBox
    Friend WithEvents tb_P_BS As TextBox
    Friend WithEvents tb_P_Faktor As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents tb_N_AS As TextBox
    Friend WithEvents tb_N_M As TextBox
    Friend WithEvents tb_N_BS As TextBox
    Friend WithEvents tb_N_Faktor As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents F11 As Button
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents tb_N_Span As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents tb_N_Mitt As TextBox
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents tb_R_Span As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents tb_R_Mitt As TextBox
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents tb_P_Span As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents tb_P_Mitt As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label25 As Label
End Class
