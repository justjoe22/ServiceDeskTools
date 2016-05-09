<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActuateMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmActuateMain))
        Me.txtResults = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLDAPGroup01 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLDAPGroup02 = New System.Windows.Forms.TextBox()
        Me.txtLDAPGroup03 = New System.Windows.Forms.TextBox()
        Me.txtLDAPGroup04 = New System.Windows.Forms.TextBox()
        Me.txtLDAPGroup05 = New System.Windows.Forms.TextBox()
        Me.txtLDAPGroup06 = New System.Windows.Forms.TextBox()
        Me.txtLDAPGroup07 = New System.Windows.Forms.TextBox()
        Me.txtLDAPGroup08 = New System.Windows.Forms.TextBox()
        Me.txtLDAPGroup09 = New System.Windows.Forms.TextBox()
        Me.txtLDAPGroup10 = New System.Windows.Forms.TextBox()
        Me.txtActuateGroups = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdReport = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.chkInc = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtResults
        '
        Me.txtResults.Location = New System.Drawing.Point(6, 319)
        Me.txtResults.Multiline = True
        Me.txtResults.Name = "txtResults"
        Me.txtResults.ReadOnly = True
        Me.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtResults.Size = New System.Drawing.Size(620, 241)
        Me.txtResults.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 303)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Results:"
        '
        'txtLDAPGroup01
        '
        Me.txtLDAPGroup01.Location = New System.Drawing.Point(6, 31)
        Me.txtLDAPGroup01.Name = "txtLDAPGroup01"
        Me.txtLDAPGroup01.Size = New System.Drawing.Size(263, 20)
        Me.txtLDAPGroup01.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "LDAP Group Name:"
        '
        'txtLDAPGroup02
        '
        Me.txtLDAPGroup02.Location = New System.Drawing.Point(6, 57)
        Me.txtLDAPGroup02.Name = "txtLDAPGroup02"
        Me.txtLDAPGroup02.Size = New System.Drawing.Size(263, 20)
        Me.txtLDAPGroup02.TabIndex = 4
        '
        'txtLDAPGroup03
        '
        Me.txtLDAPGroup03.Location = New System.Drawing.Point(6, 83)
        Me.txtLDAPGroup03.Name = "txtLDAPGroup03"
        Me.txtLDAPGroup03.Size = New System.Drawing.Size(263, 20)
        Me.txtLDAPGroup03.TabIndex = 5
        '
        'txtLDAPGroup04
        '
        Me.txtLDAPGroup04.Location = New System.Drawing.Point(6, 109)
        Me.txtLDAPGroup04.Name = "txtLDAPGroup04"
        Me.txtLDAPGroup04.Size = New System.Drawing.Size(263, 20)
        Me.txtLDAPGroup04.TabIndex = 6
        '
        'txtLDAPGroup05
        '
        Me.txtLDAPGroup05.Location = New System.Drawing.Point(6, 135)
        Me.txtLDAPGroup05.Name = "txtLDAPGroup05"
        Me.txtLDAPGroup05.Size = New System.Drawing.Size(263, 20)
        Me.txtLDAPGroup05.TabIndex = 7
        '
        'txtLDAPGroup06
        '
        Me.txtLDAPGroup06.Location = New System.Drawing.Point(6, 161)
        Me.txtLDAPGroup06.Name = "txtLDAPGroup06"
        Me.txtLDAPGroup06.Size = New System.Drawing.Size(263, 20)
        Me.txtLDAPGroup06.TabIndex = 8
        '
        'txtLDAPGroup07
        '
        Me.txtLDAPGroup07.Location = New System.Drawing.Point(6, 187)
        Me.txtLDAPGroup07.Name = "txtLDAPGroup07"
        Me.txtLDAPGroup07.Size = New System.Drawing.Size(263, 20)
        Me.txtLDAPGroup07.TabIndex = 9
        '
        'txtLDAPGroup08
        '
        Me.txtLDAPGroup08.Location = New System.Drawing.Point(6, 213)
        Me.txtLDAPGroup08.Name = "txtLDAPGroup08"
        Me.txtLDAPGroup08.Size = New System.Drawing.Size(263, 20)
        Me.txtLDAPGroup08.TabIndex = 10
        '
        'txtLDAPGroup09
        '
        Me.txtLDAPGroup09.Location = New System.Drawing.Point(6, 239)
        Me.txtLDAPGroup09.Name = "txtLDAPGroup09"
        Me.txtLDAPGroup09.Size = New System.Drawing.Size(263, 20)
        Me.txtLDAPGroup09.TabIndex = 11
        '
        'txtLDAPGroup10
        '
        Me.txtLDAPGroup10.Location = New System.Drawing.Point(6, 265)
        Me.txtLDAPGroup10.Name = "txtLDAPGroup10"
        Me.txtLDAPGroup10.Size = New System.Drawing.Size(263, 20)
        Me.txtLDAPGroup10.TabIndex = 12
        '
        'txtActuateGroups
        '
        Me.txtActuateGroups.Location = New System.Drawing.Point(304, 31)
        Me.txtActuateGroups.Name = "txtActuateGroups"
        Me.txtActuateGroups.Size = New System.Drawing.Size(315, 20)
        Me.txtActuateGroups.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(301, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Acuate Groups - Forecasting:"
        '
        'cmdReport
        '
        Me.cmdReport.Location = New System.Drawing.Point(379, 84)
        Me.cmdReport.Name = "cmdReport"
        Me.cmdReport.Size = New System.Drawing.Size(174, 23)
        Me.cmdReport.TabIndex = 15
        Me.cmdReport.Text = "Create LDAP Group Report"
        Me.cmdReport.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.Location = New System.Drawing.Point(379, 113)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(174, 23)
        Me.cmdClear.TabIndex = 16
        Me.cmdClear.Text = "Clear Results"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(417, 142)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(99, 23)
        Me.cmdExit.TabIndex = 17
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'chkInc
        '
        Me.chkInc.AutoSize = True
        Me.chkInc.Location = New System.Drawing.Point(304, 59)
        Me.chkInc.Name = "chkInc"
        Me.chkInc.Size = New System.Drawing.Size(150, 17)
        Me.chkInc.TabIndex = 18
        Me.chkInc.Text = "Include Non-Prefix Groups"
        Me.chkInc.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 565)
        Me.Controls.Add(Me.chkInc)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdReport)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtActuateGroups)
        Me.Controls.Add(Me.txtLDAPGroup10)
        Me.Controls.Add(Me.txtLDAPGroup09)
        Me.Controls.Add(Me.txtLDAPGroup08)
        Me.Controls.Add(Me.txtLDAPGroup07)
        Me.Controls.Add(Me.txtLDAPGroup06)
        Me.Controls.Add(Me.txtLDAPGroup05)
        Me.Controls.Add(Me.txtLDAPGroup04)
        Me.Controls.Add(Me.txtLDAPGroup03)
        Me.Controls.Add(Me.txtLDAPGroup02)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtLDAPGroup01)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtResults)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Actuate Reports"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtResults As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLDAPGroup01 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLDAPGroup02 As System.Windows.Forms.TextBox
    Friend WithEvents txtLDAPGroup03 As System.Windows.Forms.TextBox
    Friend WithEvents txtLDAPGroup04 As System.Windows.Forms.TextBox
    Friend WithEvents txtLDAPGroup05 As System.Windows.Forms.TextBox
    Friend WithEvents txtLDAPGroup06 As System.Windows.Forms.TextBox
    Friend WithEvents txtLDAPGroup07 As System.Windows.Forms.TextBox
    Friend WithEvents txtLDAPGroup08 As System.Windows.Forms.TextBox
    Friend WithEvents txtLDAPGroup09 As System.Windows.Forms.TextBox
    Friend WithEvents txtLDAPGroup10 As System.Windows.Forms.TextBox
    Friend WithEvents txtActuateGroups As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdReport As System.Windows.Forms.Button
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents chkInc As System.Windows.Forms.CheckBox

End Class
