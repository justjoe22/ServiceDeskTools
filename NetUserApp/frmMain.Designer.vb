<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.QueryUsers1 = New System.Windows.Forms.TabPage()
        Me.txtQRYFilter = New System.Windows.Forms.TextBox()
        Me.chkQRYFilter = New System.Windows.Forms.CheckBox()
        Me.lblExport = New System.Windows.Forms.Label()
        Me.txtQRYExport = New System.Windows.Forms.TextBox()
        Me.txtQRYQuery = New System.Windows.Forms.TextBox()
        Me.lblQRYDone = New System.Windows.Forms.Label()
        Me.pbQRYStatus = New System.Windows.Forms.ProgressBar()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.btnQRYReset = New System.Windows.Forms.Button()
        Me.btnQRYExport = New System.Windows.Forms.Button()
        Me.btnQRYSearch = New System.Windows.Forms.Button()
        Me.rdoQRY2 = New System.Windows.Forms.RadioButton()
        Me.rdoQRY1 = New System.Windows.Forms.RadioButton()
        Me.dgQRYResult = New System.Windows.Forms.DataGridView()
        Me.NativeId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Location1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CNString = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtQueryResults = New System.Windows.Forms.TextBox()
        Me.Ping = New System.Windows.Forms.TabPage()
        Me.btnIPReset = New System.Windows.Forms.Button()
        Me.btnIPOk = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIPResults = New System.Windows.Forms.TextBox()
        Me.txtIPAdd = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NetUser = New System.Windows.Forms.TabPage()
        Me.btnUSRReset = New System.Windows.Forms.Button()
        Me.btnUSROk = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUSRResults = New System.Windows.Forms.TextBox()
        Me.txtUSRNativeId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tab1 = New System.Windows.Forms.TabControl()
        Me.tbPassTest = New System.Windows.Forms.TabPage()
        Me.btnResetTestPass = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnTestPass = New System.Windows.Forms.Button()
        Me.txtPassTest = New System.Windows.Forms.TextBox()
        Me.txtNativeIDtest = New System.Windows.Forms.TextBox()
        Me.WalkIn = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtAlarm = New System.Windows.Forms.TextBox()
        Me.lblWrn = New System.Windows.Forms.Label()
        Me.txtWarning = New System.Windows.Forms.TextBox()
        Me.btnRst = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.txtCount = New System.Windows.Forms.RichTextBox()
        Me.Printers = New System.Windows.Forms.TabPage()
        Me.txtPRNLoc = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnPrnReset = New System.Windows.Forms.Button()
        Me.btnPrnOK = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPRNResult = New System.Windows.Forms.TextBox()
        Me.txtPRNPrinter = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.TabPage()
        Me.btnSetPassword = New System.Windows.Forms.Button()
        Me.txtUserId = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnPASCreate = New System.Windows.Forms.Button()
        Me.txtPASPassword = New System.Windows.Forms.TextBox()
        Me.Actuate = New System.Windows.Forms.TabPage()
        Me.chkInc = New System.Windows.Forms.CheckBox()
        Me.btnACTReset = New System.Windows.Forms.Button()
        Me.btnACTReport = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtActuateGroups = New System.Windows.Forms.TextBox()
        Me.txtLDAPGroup10 = New System.Windows.Forms.TextBox()
        Me.txtLDAPGroup09 = New System.Windows.Forms.TextBox()
        Me.txtLDAPGroup08 = New System.Windows.Forms.TextBox()
        Me.txtLDAPGroup07 = New System.Windows.Forms.TextBox()
        Me.txtLDAPGroup06 = New System.Windows.Forms.TextBox()
        Me.txtLDAPGroup05 = New System.Windows.Forms.TextBox()
        Me.txtLDAPGroup04 = New System.Windows.Forms.TextBox()
        Me.txtLDAPGroup03 = New System.Windows.Forms.TextBox()
        Me.txtLDAPGroup02 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLDAPGroup01 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtACTResults = New System.Windows.Forms.TextBox()
        Me.tmMain = New System.Windows.Forms.Timer(Me.components)
        Me.tmFlash = New System.Windows.Forms.Timer(Me.components)
        Me.txtResultsPassT = New System.Windows.Forms.Label()
        Me.QueryUsers1.SuspendLayout()
        CType(Me.dgQRYResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Ping.SuspendLayout()
        Me.NetUser.SuspendLayout()
        Me.Tab1.SuspendLayout()
        Me.tbPassTest.SuspendLayout()
        Me.WalkIn.SuspendLayout()
        Me.Printers.SuspendLayout()
        Me.Password.SuspendLayout()
        Me.Actuate.SuspendLayout()
        Me.SuspendLayout()
        '
        'QueryUsers1
        '
        Me.QueryUsers1.Controls.Add(Me.txtQRYFilter)
        Me.QueryUsers1.Controls.Add(Me.chkQRYFilter)
        Me.QueryUsers1.Controls.Add(Me.lblExport)
        Me.QueryUsers1.Controls.Add(Me.txtQRYExport)
        Me.QueryUsers1.Controls.Add(Me.txtQRYQuery)
        Me.QueryUsers1.Controls.Add(Me.lblQRYDone)
        Me.QueryUsers1.Controls.Add(Me.pbQRYStatus)
        Me.QueryUsers1.Controls.Add(Me.lblResults)
        Me.QueryUsers1.Controls.Add(Me.btnQRYReset)
        Me.QueryUsers1.Controls.Add(Me.btnQRYExport)
        Me.QueryUsers1.Controls.Add(Me.btnQRYSearch)
        Me.QueryUsers1.Controls.Add(Me.rdoQRY2)
        Me.QueryUsers1.Controls.Add(Me.rdoQRY1)
        Me.QueryUsers1.Controls.Add(Me.dgQRYResult)
        Me.QueryUsers1.Controls.Add(Me.txtQueryResults)
        Me.QueryUsers1.Location = New System.Drawing.Point(4, 22)
        Me.QueryUsers1.Name = "QueryUsers1"
        Me.QueryUsers1.Padding = New System.Windows.Forms.Padding(3)
        Me.QueryUsers1.Size = New System.Drawing.Size(965, 528)
        Me.QueryUsers1.TabIndex = 2
        Me.QueryUsers1.Text = "Query Users - Never Expires"
        Me.QueryUsers1.UseVisualStyleBackColor = True
        '
        'txtQRYFilter
        '
        Me.txtQRYFilter.Location = New System.Drawing.Point(609, 10)
        Me.txtQRYFilter.Name = "txtQRYFilter"
        Me.txtQRYFilter.Size = New System.Drawing.Size(346, 20)
        Me.txtQRYFilter.TabIndex = 4
        Me.txtQRYFilter.Text = resources.GetString("txtQRYFilter.Text")
        '
        'chkQRYFilter
        '
        Me.chkQRYFilter.AutoSize = True
        Me.chkQRYFilter.Checked = True
        Me.chkQRYFilter.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkQRYFilter.Location = New System.Drawing.Point(555, 12)
        Me.chkQRYFilter.Name = "chkQRYFilter"
        Me.chkQRYFilter.Size = New System.Drawing.Size(48, 17)
        Me.chkQRYFilter.TabIndex = 3
        Me.chkQRYFilter.Text = "Filter"
        Me.chkQRYFilter.UseVisualStyleBackColor = True
        '
        'lblExport
        '
        Me.lblExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblExport.AutoSize = True
        Me.lblExport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExport.Location = New System.Drawing.Point(443, 475)
        Me.lblExport.Name = "lblExport"
        Me.lblExport.Size = New System.Drawing.Size(107, 13)
        Me.lblExport.TabIndex = 11
        Me.lblExport.Text = "Export File Name:"
        '
        'txtQRYExport
        '
        Me.txtQRYExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQRYExport.Location = New System.Drawing.Point(555, 472)
        Me.txtQRYExport.Name = "txtQRYExport"
        Me.txtQRYExport.Size = New System.Drawing.Size(319, 20)
        Me.txtQRYExport.TabIndex = 8
        '
        'txtQRYQuery
        '
        Me.txtQRYQuery.Location = New System.Drawing.Point(132, 10)
        Me.txtQRYQuery.Name = "txtQRYQuery"
        Me.txtQRYQuery.Size = New System.Drawing.Size(383, 20)
        Me.txtQRYQuery.TabIndex = 1
        Me.txtQRYQuery.Text = "OU=Users,OU=IT,OU=Alticor,DC=na,DC=intranet,DC=msd"
        '
        'lblQRYDone
        '
        Me.lblQRYDone.AutoSize = True
        Me.lblQRYDone.BackColor = System.Drawing.Color.Transparent
        Me.lblQRYDone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQRYDone.Location = New System.Drawing.Point(442, 502)
        Me.lblQRYDone.Name = "lblQRYDone"
        Me.lblQRYDone.Size = New System.Drawing.Size(73, 13)
        Me.lblQRYDone.TabIndex = 9
        Me.lblQRYDone.Text = "COMPLETE"
        Me.lblQRYDone.Visible = False
        '
        'pbQRYStatus
        '
        Me.pbQRYStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbQRYStatus.ForeColor = System.Drawing.Color.Lime
        Me.pbQRYStatus.Location = New System.Drawing.Point(7, 499)
        Me.pbQRYStatus.Name = "pbQRYStatus"
        Me.pbQRYStatus.Size = New System.Drawing.Size(949, 23)
        Me.pbQRYStatus.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbQRYStatus.TabIndex = 8
        Me.pbQRYStatus.Tag = ""
        '
        'lblResults
        '
        Me.lblResults.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblResults.AutoSize = True
        Me.lblResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResults.Location = New System.Drawing.Point(760, 68)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblResults.Size = New System.Drawing.Size(120, 13)
        Me.lblResults.TabIndex = 7
        Me.lblResults.Text = "Returned Results: 0"
        Me.lblResults.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnQRYReset
        '
        Me.btnQRYReset.Location = New System.Drawing.Point(89, 58)
        Me.btnQRYReset.Name = "btnQRYReset"
        Me.btnQRYReset.Size = New System.Drawing.Size(75, 23)
        Me.btnQRYReset.TabIndex = 6
        Me.btnQRYReset.Text = "&Reset"
        Me.btnQRYReset.UseVisualStyleBackColor = True
        '
        'btnQRYExport
        '
        Me.btnQRYExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQRYExport.Enabled = False
        Me.btnQRYExport.Location = New System.Drawing.Point(880, 470)
        Me.btnQRYExport.Name = "btnQRYExport"
        Me.btnQRYExport.Size = New System.Drawing.Size(75, 23)
        Me.btnQRYExport.TabIndex = 9
        Me.btnQRYExport.Text = "&Export"
        Me.btnQRYExport.UseVisualStyleBackColor = True
        '
        'btnQRYSearch
        '
        Me.btnQRYSearch.Location = New System.Drawing.Point(8, 58)
        Me.btnQRYSearch.Name = "btnQRYSearch"
        Me.btnQRYSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnQRYSearch.TabIndex = 5
        Me.btnQRYSearch.Text = "&Search"
        Me.btnQRYSearch.UseVisualStyleBackColor = True
        '
        'rdoQRY2
        '
        Me.rdoQRY2.AutoSize = True
        Me.rdoQRY2.Location = New System.Drawing.Point(7, 34)
        Me.rdoQRY2.Name = "rdoQRY2"
        Me.rdoQRY2.Size = New System.Drawing.Size(245, 17)
        Me.rdoQRY2.TabIndex = 2
        Me.rdoQRY2.Text = "Query Entire Domain (will take several minutes)"
        Me.rdoQRY2.UseVisualStyleBackColor = True
        '
        'rdoQRY1
        '
        Me.rdoQRY1.AutoSize = True
        Me.rdoQRY1.Checked = True
        Me.rdoQRY1.Location = New System.Drawing.Point(7, 10)
        Me.rdoQRY1.Name = "rdoQRY1"
        Me.rdoQRY1.Size = New System.Drawing.Size(119, 17)
        Me.rdoQRY1.TabIndex = 0
        Me.rdoQRY1.TabStop = True
        Me.rdoQRY1.Text = "Query Specified OU"
        Me.rdoQRY1.UseVisualStyleBackColor = True
        '
        'dgQRYResult
        '
        Me.dgQRYResult.AllowUserToAddRows = False
        Me.dgQRYResult.AllowUserToDeleteRows = False
        Me.dgQRYResult.AllowUserToOrderColumns = True
        Me.dgQRYResult.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgQRYResult.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgQRYResult.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgQRYResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgQRYResult.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NativeId, Me.Location1, Me.NameDesc, Me.CNString})
        Me.dgQRYResult.Location = New System.Drawing.Point(5, 86)
        Me.dgQRYResult.Name = "dgQRYResult"
        Me.dgQRYResult.ReadOnly = True
        Me.dgQRYResult.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgQRYResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgQRYResult.Size = New System.Drawing.Size(951, 374)
        Me.dgQRYResult.TabIndex = 7
        '
        'NativeId
        '
        Me.NativeId.HeaderText = "Native ID"
        Me.NativeId.Name = "NativeId"
        Me.NativeId.ReadOnly = True
        Me.NativeId.Width = 80
        '
        'Location1
        '
        Me.Location1.HeaderText = "Location"
        Me.Location1.Name = "Location1"
        Me.Location1.ReadOnly = True
        Me.Location1.Width = 150
        '
        'NameDesc
        '
        Me.NameDesc.HeaderText = "Full Name/Description"
        Me.NameDesc.Name = "NameDesc"
        Me.NameDesc.ReadOnly = True
        Me.NameDesc.Width = 300
        '
        'CNString
        '
        Me.CNString.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CNString.HeaderText = "CN String"
        Me.CNString.Name = "CNString"
        Me.CNString.ReadOnly = True
        '
        'txtQueryResults
        '
        Me.txtQueryResults.Location = New System.Drawing.Point(7, 88)
        Me.txtQueryResults.Multiline = True
        Me.txtQueryResults.Name = "txtQueryResults"
        Me.txtQueryResults.ReadOnly = True
        Me.txtQueryResults.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtQueryResults.Size = New System.Drawing.Size(712, 371)
        Me.txtQueryResults.TabIndex = 4
        Me.txtQueryResults.Visible = False
        Me.txtQueryResults.WordWrap = False
        '
        'Ping
        '
        Me.Ping.Controls.Add(Me.btnIPReset)
        Me.Ping.Controls.Add(Me.btnIPOk)
        Me.Ping.Controls.Add(Me.Label3)
        Me.Ping.Controls.Add(Me.txtIPResults)
        Me.Ping.Controls.Add(Me.txtIPAdd)
        Me.Ping.Controls.Add(Me.Label4)
        Me.Ping.Location = New System.Drawing.Point(4, 22)
        Me.Ping.Name = "Ping"
        Me.Ping.Padding = New System.Windows.Forms.Padding(3)
        Me.Ping.Size = New System.Drawing.Size(965, 528)
        Me.Ping.TabIndex = 1
        Me.Ping.Text = "Ping"
        Me.Ping.UseVisualStyleBackColor = True
        '
        'btnIPReset
        '
        Me.btnIPReset.Location = New System.Drawing.Point(440, 20)
        Me.btnIPReset.Name = "btnIPReset"
        Me.btnIPReset.Size = New System.Drawing.Size(75, 25)
        Me.btnIPReset.TabIndex = 14
        Me.btnIPReset.Text = "&Reset"
        Me.btnIPReset.UseVisualStyleBackColor = True
        '
        'btnIPOk
        '
        Me.btnIPOk.Location = New System.Drawing.Point(359, 20)
        Me.btnIPOk.Name = "btnIPOk"
        Me.btnIPOk.Size = New System.Drawing.Size(75, 25)
        Me.btnIPOk.TabIndex = 13
        Me.btnIPOk.Text = "&Ok"
        Me.btnIPOk.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Results"
        '
        'txtIPResults
        '
        Me.txtIPResults.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIPResults.Location = New System.Drawing.Point(7, 62)
        Me.txtIPResults.Multiline = True
        Me.txtIPResults.Name = "txtIPResults"
        Me.txtIPResults.ReadOnly = True
        Me.txtIPResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtIPResults.Size = New System.Drawing.Size(949, 457)
        Me.txtIPResults.TabIndex = 15
        '
        'txtIPAdd
        '
        Me.txtIPAdd.Location = New System.Drawing.Point(7, 23)
        Me.txtIPAdd.Name = "txtIPAdd"
        Me.txtIPAdd.Size = New System.Drawing.Size(346, 20)
        Me.txtIPAdd.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "IP Address (DNS Name)"
        '
        'NetUser
        '
        Me.NetUser.Controls.Add(Me.btnUSRReset)
        Me.NetUser.Controls.Add(Me.btnUSROk)
        Me.NetUser.Controls.Add(Me.Label2)
        Me.NetUser.Controls.Add(Me.txtUSRResults)
        Me.NetUser.Controls.Add(Me.txtUSRNativeId)
        Me.NetUser.Controls.Add(Me.Label1)
        Me.NetUser.Location = New System.Drawing.Point(4, 22)
        Me.NetUser.Name = "NetUser"
        Me.NetUser.Padding = New System.Windows.Forms.Padding(3)
        Me.NetUser.Size = New System.Drawing.Size(965, 528)
        Me.NetUser.TabIndex = 0
        Me.NetUser.Text = "User Info."
        Me.NetUser.UseVisualStyleBackColor = True
        '
        'btnUSRReset
        '
        Me.btnUSRReset.Location = New System.Drawing.Point(258, 20)
        Me.btnUSRReset.Name = "btnUSRReset"
        Me.btnUSRReset.Size = New System.Drawing.Size(75, 25)
        Me.btnUSRReset.TabIndex = 3
        Me.btnUSRReset.Text = "&Reset"
        Me.btnUSRReset.UseVisualStyleBackColor = True
        '
        'btnUSROk
        '
        Me.btnUSROk.Location = New System.Drawing.Point(177, 20)
        Me.btnUSROk.Name = "btnUSROk"
        Me.btnUSROk.Size = New System.Drawing.Size(75, 25)
        Me.btnUSROk.TabIndex = 2
        Me.btnUSROk.Text = "&Ok"
        Me.btnUSROk.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Results"
        '
        'txtUSRResults
        '
        Me.txtUSRResults.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUSRResults.Location = New System.Drawing.Point(7, 61)
        Me.txtUSRResults.Multiline = True
        Me.txtUSRResults.Name = "txtUSRResults"
        Me.txtUSRResults.ReadOnly = True
        Me.txtUSRResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtUSRResults.Size = New System.Drawing.Size(949, 458)
        Me.txtUSRResults.TabIndex = 4
        '
        'txtUSRNativeId
        '
        Me.txtUSRNativeId.Location = New System.Drawing.Point(7, 22)
        Me.txtUSRNativeId.Name = "txtUSRNativeId"
        Me.txtUSRNativeId.Size = New System.Drawing.Size(164, 20)
        Me.txtUSRNativeId.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Native ID"
        '
        'Tab1
        '
        Me.Tab1.Controls.Add(Me.NetUser)
        Me.Tab1.Controls.Add(Me.tbPassTest)
        Me.Tab1.Controls.Add(Me.WalkIn)
        Me.Tab1.Controls.Add(Me.Printers)
        Me.Tab1.Controls.Add(Me.Ping)
        Me.Tab1.Controls.Add(Me.Password)
        Me.Tab1.Controls.Add(Me.Actuate)
        Me.Tab1.Controls.Add(Me.QueryUsers1)
        Me.Tab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab1.HotTrack = True
        Me.Tab1.Location = New System.Drawing.Point(0, 0)
        Me.Tab1.Multiline = True
        Me.Tab1.Name = "Tab1"
        Me.Tab1.SelectedIndex = 0
        Me.Tab1.Size = New System.Drawing.Size(973, 554)
        Me.Tab1.TabIndex = 6
        '
        'tbPassTest
        '
        Me.tbPassTest.Controls.Add(Me.txtResultsPassT)
        Me.tbPassTest.Controls.Add(Me.btnResetTestPass)
        Me.tbPassTest.Controls.Add(Me.Label15)
        Me.tbPassTest.Controls.Add(Me.Label14)
        Me.tbPassTest.Controls.Add(Me.Label13)
        Me.tbPassTest.Controls.Add(Me.btnTestPass)
        Me.tbPassTest.Controls.Add(Me.txtPassTest)
        Me.tbPassTest.Controls.Add(Me.txtNativeIDtest)
        Me.tbPassTest.Location = New System.Drawing.Point(4, 22)
        Me.tbPassTest.Name = "tbPassTest"
        Me.tbPassTest.Padding = New System.Windows.Forms.Padding(3)
        Me.tbPassTest.Size = New System.Drawing.Size(965, 528)
        Me.tbPassTest.TabIndex = 7
        Me.tbPassTest.Text = "Verify Password"
        Me.tbPassTest.UseVisualStyleBackColor = True
        '
        'btnResetTestPass
        '
        Me.btnResetTestPass.Location = New System.Drawing.Point(93, 116)
        Me.btnResetTestPass.Name = "btnResetTestPass"
        Me.btnResetTestPass.Size = New System.Drawing.Size(100, 23)
        Me.btnResetTestPass.TabIndex = 7
        Me.btnResetTestPass.Text = "Reset"
        Me.btnResetTestPass.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(231, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 13)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Results"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(26, 62)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Password"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(26, 35)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Native ID"
        '
        'btnTestPass
        '
        Me.btnTestPass.Location = New System.Drawing.Point(93, 86)
        Me.btnTestPass.Name = "btnTestPass"
        Me.btnTestPass.Size = New System.Drawing.Size(100, 23)
        Me.btnTestPass.TabIndex = 2
        Me.btnTestPass.Text = "Test Password"
        Me.btnTestPass.UseVisualStyleBackColor = True
        '
        'txtPassTest
        '
        Me.txtPassTest.Location = New System.Drawing.Point(93, 59)
        Me.txtPassTest.Name = "txtPassTest"
        Me.txtPassTest.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassTest.Size = New System.Drawing.Size(100, 20)
        Me.txtPassTest.TabIndex = 1
        '
        'txtNativeIDtest
        '
        Me.txtNativeIDtest.Location = New System.Drawing.Point(93, 32)
        Me.txtNativeIDtest.Name = "txtNativeIDtest"
        Me.txtNativeIDtest.Size = New System.Drawing.Size(100, 20)
        Me.txtNativeIDtest.TabIndex = 0
        '
        'WalkIn
        '
        Me.WalkIn.Controls.Add(Me.Label12)
        Me.WalkIn.Controls.Add(Me.txtAlarm)
        Me.WalkIn.Controls.Add(Me.lblWrn)
        Me.WalkIn.Controls.Add(Me.txtWarning)
        Me.WalkIn.Controls.Add(Me.btnRst)
        Me.WalkIn.Controls.Add(Me.btnStop)
        Me.WalkIn.Controls.Add(Me.btnStart)
        Me.WalkIn.Controls.Add(Me.txtCount)
        Me.WalkIn.Location = New System.Drawing.Point(4, 22)
        Me.WalkIn.Name = "WalkIn"
        Me.WalkIn.Padding = New System.Windows.Forms.Padding(3)
        Me.WalkIn.Size = New System.Drawing.Size(965, 528)
        Me.WalkIn.TabIndex = 6
        Me.WalkIn.Text = "Walk-In Timer"
        Me.WalkIn.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(51, 267)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(108, 13)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Alarm Time (Minutes):"
        '
        'txtAlarm
        '
        Me.txtAlarm.Location = New System.Drawing.Point(162, 264)
        Me.txtAlarm.Name = "txtAlarm"
        Me.txtAlarm.Size = New System.Drawing.Size(33, 20)
        Me.txtAlarm.TabIndex = 6
        Me.txtAlarm.Text = "15"
        Me.txtAlarm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblWrn
        '
        Me.lblWrn.AutoSize = True
        Me.lblWrn.Location = New System.Drawing.Point(37, 242)
        Me.lblWrn.Name = "lblWrn"
        Me.lblWrn.Size = New System.Drawing.Size(122, 13)
        Me.lblWrn.TabIndex = 5
        Me.lblWrn.Text = "Warning Time (Minutes):"
        '
        'txtWarning
        '
        Me.txtWarning.Location = New System.Drawing.Point(162, 239)
        Me.txtWarning.Name = "txtWarning"
        Me.txtWarning.Size = New System.Drawing.Size(33, 20)
        Me.txtWarning.TabIndex = 4
        Me.txtWarning.Text = "10"
        Me.txtWarning.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnRst
        '
        Me.btnRst.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRst.Location = New System.Drawing.Point(374, 373)
        Me.btnRst.Name = "btnRst"
        Me.btnRst.Size = New System.Drawing.Size(229, 81)
        Me.btnRst.TabIndex = 3
        Me.btnRst.Text = "&Reset"
        Me.btnRst.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.Location = New System.Drawing.Point(374, 286)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(229, 81)
        Me.btnStop.TabIndex = 2
        Me.btnStop.Text = "S&top"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(374, 199)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(229, 81)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "&Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'txtCount
        '
        Me.txtCount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 68.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCount.Location = New System.Drawing.Point(5, 49)
        Me.txtCount.Multiline = False
        Me.txtCount.Name = "txtCount"
        Me.txtCount.ReadOnly = True
        Me.txtCount.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtCount.Size = New System.Drawing.Size(950, 144)
        Me.txtCount.TabIndex = 0
        Me.txtCount.Text = "0:00:00"
        Me.txtCount.WordWrap = False
        '
        'Printers
        '
        Me.Printers.Controls.Add(Me.txtPRNLoc)
        Me.Printers.Controls.Add(Me.Label10)
        Me.Printers.Controls.Add(Me.btnPrnReset)
        Me.Printers.Controls.Add(Me.btnPrnOK)
        Me.Printers.Controls.Add(Me.Label8)
        Me.Printers.Controls.Add(Me.txtPRNResult)
        Me.Printers.Controls.Add(Me.txtPRNPrinter)
        Me.Printers.Controls.Add(Me.Label9)
        Me.Printers.Location = New System.Drawing.Point(4, 22)
        Me.Printers.Name = "Printers"
        Me.Printers.Padding = New System.Windows.Forms.Padding(3)
        Me.Printers.Size = New System.Drawing.Size(965, 528)
        Me.Printers.TabIndex = 5
        Me.Printers.Text = "Printer Info."
        Me.Printers.UseVisualStyleBackColor = True
        '
        'txtPRNLoc
        '
        Me.txtPRNLoc.Location = New System.Drawing.Point(178, 24)
        Me.txtPRNLoc.Name = "txtPRNLoc"
        Me.txtPRNLoc.Size = New System.Drawing.Size(164, 20)
        Me.txtPRNLoc.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(179, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Location"
        '
        'btnPrnReset
        '
        Me.btnPrnReset.Location = New System.Drawing.Point(429, 21)
        Me.btnPrnReset.Name = "btnPrnReset"
        Me.btnPrnReset.Size = New System.Drawing.Size(75, 25)
        Me.btnPrnReset.TabIndex = 15
        Me.btnPrnReset.Text = "&Reset"
        Me.btnPrnReset.UseVisualStyleBackColor = True
        '
        'btnPrnOK
        '
        Me.btnPrnOK.Location = New System.Drawing.Point(348, 21)
        Me.btnPrnOK.Name = "btnPrnOK"
        Me.btnPrnOK.Size = New System.Drawing.Size(75, 25)
        Me.btnPrnOK.TabIndex = 14
        Me.btnPrnOK.Text = "&Ok"
        Me.btnPrnOK.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(5, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Results"
        '
        'txtPRNResult
        '
        Me.txtPRNResult.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPRNResult.Location = New System.Drawing.Point(8, 68)
        Me.txtPRNResult.Multiline = True
        Me.txtPRNResult.Name = "txtPRNResult"
        Me.txtPRNResult.ReadOnly = True
        Me.txtPRNResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPRNResult.Size = New System.Drawing.Size(949, 453)
        Me.txtPRNResult.TabIndex = 16
        '
        'txtPRNPrinter
        '
        Me.txtPRNPrinter.Location = New System.Drawing.Point(8, 24)
        Me.txtPRNPrinter.Name = "txtPRNPrinter"
        Me.txtPRNPrinter.Size = New System.Drawing.Size(164, 20)
        Me.txtPRNPrinter.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Printer Name"
        '
        'Password
        '
        Me.Password.Controls.Add(Me.btnSetPassword)
        Me.Password.Controls.Add(Me.txtUserId)
        Me.Password.Controls.Add(Me.Label11)
        Me.Password.Controls.Add(Me.btnPASCreate)
        Me.Password.Controls.Add(Me.txtPASPassword)
        Me.Password.Location = New System.Drawing.Point(4, 22)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(965, 528)
        Me.Password.TabIndex = 4
        Me.Password.Text = "Password Generator"
        Me.Password.UseVisualStyleBackColor = True
        '
        'btnSetPassword
        '
        Me.btnSetPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetPassword.Location = New System.Drawing.Point(25, 176)
        Me.btnSetPassword.Name = "btnSetPassword"
        Me.btnSetPassword.Size = New System.Drawing.Size(164, 29)
        Me.btnSetPassword.TabIndex = 20
        Me.btnSetPassword.Text = "Set User Password"
        Me.btnSetPassword.UseVisualStyleBackColor = True
        Me.btnSetPassword.Visible = False
        '
        'txtUserId
        '
        Me.txtUserId.Location = New System.Drawing.Point(25, 150)
        Me.txtUserId.Name = "txtUserId"
        Me.txtUserId.Size = New System.Drawing.Size(164, 20)
        Me.txtUserId.TabIndex = 18
        Me.txtUserId.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(26, 134)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Native ID"
        Me.Label11.Visible = False
        '
        'btnPASCreate
        '
        Me.btnPASCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPASCreate.Location = New System.Drawing.Point(25, 23)
        Me.btnPASCreate.Name = "btnPASCreate"
        Me.btnPASCreate.Size = New System.Drawing.Size(114, 29)
        Me.btnPASCreate.TabIndex = 16
        Me.btnPASCreate.Text = "Create Password"
        Me.btnPASCreate.UseVisualStyleBackColor = True
        '
        'txtPASPassword
        '
        Me.txtPASPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPASPassword.Location = New System.Drawing.Point(145, 23)
        Me.txtPASPassword.Name = "txtPASPassword"
        Me.txtPASPassword.ReadOnly = True
        Me.txtPASPassword.Size = New System.Drawing.Size(217, 29)
        Me.txtPASPassword.TabIndex = 17
        '
        'Actuate
        '
        Me.Actuate.Controls.Add(Me.chkInc)
        Me.Actuate.Controls.Add(Me.btnACTReset)
        Me.Actuate.Controls.Add(Me.btnACTReport)
        Me.Actuate.Controls.Add(Me.Label5)
        Me.Actuate.Controls.Add(Me.txtActuateGroups)
        Me.Actuate.Controls.Add(Me.txtLDAPGroup10)
        Me.Actuate.Controls.Add(Me.txtLDAPGroup09)
        Me.Actuate.Controls.Add(Me.txtLDAPGroup08)
        Me.Actuate.Controls.Add(Me.txtLDAPGroup07)
        Me.Actuate.Controls.Add(Me.txtLDAPGroup06)
        Me.Actuate.Controls.Add(Me.txtLDAPGroup05)
        Me.Actuate.Controls.Add(Me.txtLDAPGroup04)
        Me.Actuate.Controls.Add(Me.txtLDAPGroup03)
        Me.Actuate.Controls.Add(Me.txtLDAPGroup02)
        Me.Actuate.Controls.Add(Me.Label6)
        Me.Actuate.Controls.Add(Me.txtLDAPGroup01)
        Me.Actuate.Controls.Add(Me.Label7)
        Me.Actuate.Controls.Add(Me.txtACTResults)
        Me.Actuate.Location = New System.Drawing.Point(4, 22)
        Me.Actuate.Name = "Actuate"
        Me.Actuate.Padding = New System.Windows.Forms.Padding(3)
        Me.Actuate.Size = New System.Drawing.Size(965, 528)
        Me.Actuate.TabIndex = 3
        Me.Actuate.Text = "Actuate Groups"
        Me.Actuate.UseVisualStyleBackColor = True
        '
        'chkInc
        '
        Me.chkInc.AutoSize = True
        Me.chkInc.Location = New System.Drawing.Point(305, 56)
        Me.chkInc.Name = "chkInc"
        Me.chkInc.Size = New System.Drawing.Size(150, 17)
        Me.chkInc.TabIndex = 33
        Me.chkInc.Text = "Include Non-Suffix Groups"
        Me.chkInc.UseVisualStyleBackColor = True
        '
        'btnACTReset
        '
        Me.btnACTReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnACTReset.Location = New System.Drawing.Point(782, 35)
        Me.btnACTReset.Name = "btnACTReset"
        Me.btnACTReset.Size = New System.Drawing.Size(174, 23)
        Me.btnACTReset.TabIndex = 35
        Me.btnACTReset.Text = "&Reset"
        Me.btnACTReset.UseVisualStyleBackColor = True
        '
        'btnACTReport
        '
        Me.btnACTReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnACTReport.Location = New System.Drawing.Point(782, 6)
        Me.btnACTReport.Name = "btnACTReport"
        Me.btnACTReport.Size = New System.Drawing.Size(174, 23)
        Me.btnACTReport.TabIndex = 34
        Me.btnACTReport.Text = "Create LDAP Group Report"
        Me.btnACTReport.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(302, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Acuate Groups - Forecasting:"
        '
        'txtActuateGroups
        '
        Me.txtActuateGroups.Location = New System.Drawing.Point(305, 28)
        Me.txtActuateGroups.Name = "txtActuateGroups"
        Me.txtActuateGroups.Size = New System.Drawing.Size(315, 20)
        Me.txtActuateGroups.TabIndex = 32
        '
        'txtLDAPGroup10
        '
        Me.txtLDAPGroup10.Location = New System.Drawing.Point(7, 262)
        Me.txtLDAPGroup10.Name = "txtLDAPGroup10"
        Me.txtLDAPGroup10.Size = New System.Drawing.Size(263, 20)
        Me.txtLDAPGroup10.TabIndex = 31
        '
        'txtLDAPGroup09
        '
        Me.txtLDAPGroup09.Location = New System.Drawing.Point(7, 236)
        Me.txtLDAPGroup09.Name = "txtLDAPGroup09"
        Me.txtLDAPGroup09.Size = New System.Drawing.Size(263, 20)
        Me.txtLDAPGroup09.TabIndex = 30
        '
        'txtLDAPGroup08
        '
        Me.txtLDAPGroup08.Location = New System.Drawing.Point(7, 210)
        Me.txtLDAPGroup08.Name = "txtLDAPGroup08"
        Me.txtLDAPGroup08.Size = New System.Drawing.Size(263, 20)
        Me.txtLDAPGroup08.TabIndex = 29
        '
        'txtLDAPGroup07
        '
        Me.txtLDAPGroup07.Location = New System.Drawing.Point(7, 184)
        Me.txtLDAPGroup07.Name = "txtLDAPGroup07"
        Me.txtLDAPGroup07.Size = New System.Drawing.Size(263, 20)
        Me.txtLDAPGroup07.TabIndex = 28
        '
        'txtLDAPGroup06
        '
        Me.txtLDAPGroup06.Location = New System.Drawing.Point(7, 158)
        Me.txtLDAPGroup06.Name = "txtLDAPGroup06"
        Me.txtLDAPGroup06.Size = New System.Drawing.Size(263, 20)
        Me.txtLDAPGroup06.TabIndex = 27
        '
        'txtLDAPGroup05
        '
        Me.txtLDAPGroup05.Location = New System.Drawing.Point(7, 132)
        Me.txtLDAPGroup05.Name = "txtLDAPGroup05"
        Me.txtLDAPGroup05.Size = New System.Drawing.Size(263, 20)
        Me.txtLDAPGroup05.TabIndex = 26
        '
        'txtLDAPGroup04
        '
        Me.txtLDAPGroup04.Location = New System.Drawing.Point(7, 106)
        Me.txtLDAPGroup04.Name = "txtLDAPGroup04"
        Me.txtLDAPGroup04.Size = New System.Drawing.Size(263, 20)
        Me.txtLDAPGroup04.TabIndex = 25
        '
        'txtLDAPGroup03
        '
        Me.txtLDAPGroup03.Location = New System.Drawing.Point(7, 80)
        Me.txtLDAPGroup03.Name = "txtLDAPGroup03"
        Me.txtLDAPGroup03.Size = New System.Drawing.Size(263, 20)
        Me.txtLDAPGroup03.TabIndex = 24
        '
        'txtLDAPGroup02
        '
        Me.txtLDAPGroup02.Location = New System.Drawing.Point(7, 54)
        Me.txtLDAPGroup02.Name = "txtLDAPGroup02"
        Me.txtLDAPGroup02.Size = New System.Drawing.Size(263, 20)
        Me.txtLDAPGroup02.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "LDAP Group Name:"
        '
        'txtLDAPGroup01
        '
        Me.txtLDAPGroup01.Location = New System.Drawing.Point(7, 28)
        Me.txtLDAPGroup01.Name = "txtLDAPGroup01"
        Me.txtLDAPGroup01.Size = New System.Drawing.Size(263, 20)
        Me.txtLDAPGroup01.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(4, 288)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Results:"
        '
        'txtACTResults
        '
        Me.txtACTResults.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtACTResults.Location = New System.Drawing.Point(7, 304)
        Me.txtACTResults.Multiline = True
        Me.txtACTResults.Name = "txtACTResults"
        Me.txtACTResults.ReadOnly = True
        Me.txtACTResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtACTResults.Size = New System.Drawing.Size(949, 218)
        Me.txtACTResults.TabIndex = 36
        '
        'tmMain
        '
        '
        'tmFlash
        '
        '
        'txtResultsPassT
        '
        Me.txtResultsPassT.AutoSize = True
        Me.txtResultsPassT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResultsPassT.ForeColor = System.Drawing.Color.Red
        Me.txtResultsPassT.Location = New System.Drawing.Point(240, 59)
        Me.txtResultsPassT.Name = "txtResultsPassT"
        Me.txtResultsPassT.Size = New System.Drawing.Size(0, 13)
        Me.txtResultsPassT.TabIndex = 8
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(973, 554)
        Me.Controls.Add(Me.Tab1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(981, 581)
        Me.Name = "frmMain"
        Me.Text = "Service Desk Tools"
        Me.QueryUsers1.ResumeLayout(False)
        Me.QueryUsers1.PerformLayout()
        CType(Me.dgQRYResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Ping.ResumeLayout(False)
        Me.Ping.PerformLayout()
        Me.NetUser.ResumeLayout(False)
        Me.NetUser.PerformLayout()
        Me.Tab1.ResumeLayout(False)
        Me.tbPassTest.ResumeLayout(False)
        Me.tbPassTest.PerformLayout()
        Me.WalkIn.ResumeLayout(False)
        Me.WalkIn.PerformLayout()
        Me.Printers.ResumeLayout(False)
        Me.Printers.PerformLayout()
        Me.Password.ResumeLayout(False)
        Me.Password.PerformLayout()
        Me.Actuate.ResumeLayout(False)
        Me.Actuate.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents QueryUsers1 As System.Windows.Forms.TabPage
    Friend WithEvents lblExport As System.Windows.Forms.Label
    Friend WithEvents txtQRYExport As System.Windows.Forms.TextBox
    Friend WithEvents txtQRYQuery As System.Windows.Forms.TextBox
    Friend WithEvents lblQRYDone As System.Windows.Forms.Label
    Friend WithEvents pbQRYStatus As System.Windows.Forms.ProgressBar
    Friend WithEvents lblResults As System.Windows.Forms.Label
    Friend WithEvents btnQRYReset As System.Windows.Forms.Button
    Friend WithEvents btnQRYExport As System.Windows.Forms.Button
    Friend WithEvents btnQRYSearch As System.Windows.Forms.Button
    Friend WithEvents rdoQRY2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoQRY1 As System.Windows.Forms.RadioButton
    Friend WithEvents dgQRYResult As System.Windows.Forms.DataGridView
    Friend WithEvents txtQueryResults As System.Windows.Forms.TextBox
    Friend WithEvents Ping As System.Windows.Forms.TabPage
    Friend WithEvents btnIPReset As System.Windows.Forms.Button
    Friend WithEvents btnIPOk As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtIPResults As System.Windows.Forms.TextBox
    Friend WithEvents txtIPAdd As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NetUser As System.Windows.Forms.TabPage
    Friend WithEvents btnUSRReset As System.Windows.Forms.Button
    Friend WithEvents btnUSROk As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUSRResults As System.Windows.Forms.TextBox
    Friend WithEvents txtUSRNativeId As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Tab1 As System.Windows.Forms.TabControl
    Friend WithEvents Actuate As System.Windows.Forms.TabPage
    Friend WithEvents chkInc As System.Windows.Forms.CheckBox
    Friend WithEvents btnACTReset As System.Windows.Forms.Button
    Friend WithEvents btnACTReport As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtActuateGroups As System.Windows.Forms.TextBox
    Friend WithEvents txtLDAPGroup10 As System.Windows.Forms.TextBox
    Friend WithEvents txtLDAPGroup09 As System.Windows.Forms.TextBox
    Friend WithEvents txtLDAPGroup08 As System.Windows.Forms.TextBox
    Friend WithEvents txtLDAPGroup07 As System.Windows.Forms.TextBox
    Friend WithEvents txtLDAPGroup06 As System.Windows.Forms.TextBox
    Friend WithEvents txtLDAPGroup05 As System.Windows.Forms.TextBox
    Friend WithEvents txtLDAPGroup04 As System.Windows.Forms.TextBox
    Friend WithEvents txtLDAPGroup03 As System.Windows.Forms.TextBox
    Friend WithEvents txtLDAPGroup02 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtLDAPGroup01 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtACTResults As System.Windows.Forms.TextBox
    Friend WithEvents Password As System.Windows.Forms.TabPage
    Friend WithEvents btnPASCreate As System.Windows.Forms.Button
    Friend WithEvents txtPASPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtQRYFilter As System.Windows.Forms.TextBox
    Friend WithEvents chkQRYFilter As System.Windows.Forms.CheckBox
    Friend WithEvents Printers As System.Windows.Forms.TabPage
    Friend WithEvents btnPrnReset As System.Windows.Forms.Button
    Friend WithEvents btnPrnOK As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPRNResult As System.Windows.Forms.TextBox
    Friend WithEvents txtPRNPrinter As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPRNLoc As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents NativeId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Location1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CNString As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtUserId As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnSetPassword As System.Windows.Forms.Button
    Friend WithEvents WalkIn As System.Windows.Forms.TabPage
    Friend WithEvents txtCount As System.Windows.Forms.RichTextBox
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents tmMain As System.Windows.Forms.Timer
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnRst As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtAlarm As System.Windows.Forms.TextBox
    Friend WithEvents lblWrn As System.Windows.Forms.Label
    Friend WithEvents txtWarning As System.Windows.Forms.TextBox
    Friend WithEvents tmFlash As System.Windows.Forms.Timer
    Friend WithEvents tbPassTest As TabPage
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnTestPass As Button
    Friend WithEvents txtPassTest As TextBox
    Friend WithEvents txtNativeIDtest As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents btnResetTestPass As Button
    Friend WithEvents txtResultsPassT As Label
End Class
