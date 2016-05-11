Imports System
Imports System.IO
Imports System.Collections
Imports System.DirectoryServices
Imports System.Runtime.InteropServices
Imports ServiceDeskTools.vbValidPassword
Imports System.Net
Imports System.Net.Mail
'Imports Outlook = Microsoft.Office.Interop.Outlook
'Imports Office = Microsoft.Office.Core

Public Class frmMain
    Public csvWriter As System.IO.StreamWriter
    Public ResultCount As Integer
    Public ProcessUsr As New Process()
    ' Stopwatch
    Dim Stopwatch As New System.Diagnostics.Stopwatch
    Dim blSwitch As Boolean = False

    <DllImport("user32.dll", EntryPoint:="FlashWindow")>
    Public Shared Function FlashWindow(ByVal hwnd As Integer, ByVal bInvert As Integer) As Integer
    End Function

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' Program Form.Load Events
    ' This runs the proceedures for the programs initial state.
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim verDeployed As System.Version
        Dim strVerDeployed As String = ""

        ' Sets the Network program Version in the Application Title.
        ' If deployed on the network the 'v.#.#.#.#' will show in the Title.
        ' If deployed locally the 'v.n/a Running Local' will show.
        If (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed) Then

            verDeployed = My.Application.Deployment.CurrentVersion
            strVerDeployed = verDeployed.ToString

        Else

            strVerDeployed = "n/a Running Local"

        End If

        Me.Text = Me.Text + " v." + strVerDeployed
        Me.txtCount.SelectionAlignment = HorizontalAlignment.Center


        ' Sets Query User default Export file name.
        Me.txtQRYExport.Text = "Users-NeverExpire-Report-" + Date.Today.Month.ToString + Date.Today.Day.ToString + Date.Today.Year.ToString + ".csv"

        ' Populate Administrator Credentials
        Me.txtADMuser.Text = My.Settings.MyAdm
        Me.txtPassword.Text = My.Settings.MyPass

    End Sub


    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' Reset Button.Click Events
    ' These proceedures reset all the tabs back to default.
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    ' User Info. Reset Button
    Private Sub btnUSRReset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUSRReset.Click

        Me.txtUSRNativeId.Text = ""
        Me.txtUSRResults.Text = ""

    End Sub

    ' Ping Reset Button
    Private Sub btnIPReset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnIPReset.Click

        Me.txtIPAdd.Text = ""
        Me.txtIPResults.Text = ""

    End Sub

    ' Query Users Reset Button
    Private Sub btnQRYReset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnQRYReset.Click

        Me.txtQueryResults.Text = ""
        Me.dgQRYResult.Rows.Clear()
        Me.lblResults.Text = "Returned Results: 0"
        Me.rdoQRY1.Checked = True
        Me.txtQRYQuery.Text = "OU=Users,OU=IT,OU=Alticor,DC=na,DC=intranet,DC=msd"
        Me.txtQRYFilter.Text = "JOB,CMN,LAB,FAX,TEST,SUPER,PUBLIC,QA,COS,LIQ,PCM,HTA,ENG,PCM,POW,PP,USC,USD,USH,USL,USP,VIP,HILO,SSC,PRE,ELE,WAB,LIN,C0,FO,PH,WU,TEST,PHN,SCA,SHI,IV,IU,AUDI,EPL,CFM,WEB,INTE,AAG,HOT,MTS,NATE,USER,WIN,TS,WOL,WS,QCC,REC,HAZ,ILI,JDE,JDU,LCM,TIME,TRAN,DEV,CIT,STAG,TRAIN,GRA,MIX,MAC,BAR,TECH,JDU,MFG,LOG,JBL,NWG,BLEN,C2,C3,LVS,L0,PDL,SDL,VNMWEB,POS,USA,APX511"
        Me.txtQRYFilter.Enabled = True
        Me.chkQRYFilter.Checked = True
        Me.txtQRYExport.Text = "Users-NeverExpire-Report-" + Date.Today.Month.ToString + Date.Today.Day.ToString + Date.Today.Year.ToString + ".csv"
        Me.btnQRYExport.Enabled = False
        Me.lblQRYDone.Visible = False
        Me.pbQRYStatus.Increment(-ResultCount)
        Me.pbQRYStatus.Refresh()
        ResultCount = 0

    End Sub

    ' Actuate Groups Reset Button
    Private Sub btnACTReset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnACTReset.Click

        Me.txtLDAPGroup01.Text = ""
        Me.txtLDAPGroup02.Text = ""
        Me.txtLDAPGroup03.Text = ""
        Me.txtLDAPGroup04.Text = ""
        Me.txtLDAPGroup05.Text = ""
        Me.txtLDAPGroup06.Text = ""
        Me.txtLDAPGroup07.Text = ""
        Me.txtLDAPGroup08.Text = ""
        Me.txtLDAPGroup09.Text = ""
        Me.txtLDAPGroup10.Text = ""
        Me.txtActuateGroups.Text = ""
        Me.txtACTResults.Text = ""

    End Sub

    ' Printer Info. Reset Button
    Private Sub btnPrnReset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrnReset.Click
        Me.txtPRNResult.Text = ""
        Me.txtPRNPrinter.Text = ""
        Me.txtPRNLoc.Text = ""
    End Sub


    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' Ok Button.Click Events
    ' These proceedures process the information entered and return results.
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    ' User Info. Ok Button
    Private Sub btnUSROk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUSROk.Click
        Dim ProcessObj As New Process()

        ProcessObj.StartInfo.FileName = "cmd.exe"
        ProcessObj.StartInfo.Arguments = "/C net user " + Me.txtUSRNativeId.Text + " /domain"

        ProcessObj.StartInfo.UseShellExecute = False
        ProcessObj.StartInfo.CreateNoWindow = True
        ProcessObj.StartInfo.RedirectStandardOutput = True

        ProcessObj.Start()
        ProcessObj.WaitForExit(1000)

        Me.txtUSRResults.Text = ProcessObj.StandardOutput.ReadToEnd()

    End Sub

    ' Ping Ok Button
    Private Sub btnIPOk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnIPOk.Click

        Dim ProcessIP As New Process()

        ProcessIP.StartInfo.FileName = "cmd.exe"
        ProcessIP.StartInfo.Arguments = "/C Ping " + Me.txtIPAdd.Text

        ProcessIP.StartInfo.UseShellExecute = False
        ProcessIP.StartInfo.CreateNoWindow = True
        ProcessIP.StartInfo.RedirectStandardOutput = True

        ProcessIP.Start()
        ProcessIP.WaitForExit(1000)

        Me.txtIPResults.Text = ProcessIP.StandardOutput.ReadToEnd()

    End Sub

    ' Query Users Search Button
    Private Sub btnQRYSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnQRYSearch.Click
        Dim strCmd As String = "", strQuery As String = "", strTrim As String = "", intResults As Integer = 0
        Dim strLine As String = "", strCN As String = "", strName As String = "", strNative As String = "", strLoc As String = ""
        Dim strOU00 As String = "", strOU01 As String = "", strOU02 As String = "", strOU03 As String = "", strOU04 As String = "", strOU05 As String = ""
        'Dim ProcessUsr As New Process()

        If Me.rdoQRY1.Checked = True Then
            strCmd = "dsquery user " + """" + Me.txtQRYQuery.Text + """" + " -limit 0 | dsget user -dn -display -pwdneverexpires"
        ElseIf Me.rdoQRY2.Checked = True Then
            strCmd = "dsquery user domainroot -limit 0 | dsget user -dn -display -pwdneverexpires"
        End If
        ' > temp.txt

        ProcessUsr.Close()

        ProcessUsr.StartInfo.FileName = "cmd.exe"
        ProcessUsr.StartInfo.Arguments = "/C " + strCmd

        ProcessUsr.StartInfo.UseShellExecute = False
        ProcessUsr.StartInfo.CreateNoWindow = True
        ProcessUsr.StartInfo.RedirectStandardOutput = True

        ProcessUsr.Start()
        ProcessUsr.WaitForExit(1000)

        'Process.Start("cmd.exe", "/C " + strCmd).WaitForExit()

        'If IO.File.Exists("temp.txt") Then
        'Dim ioFile As New IO.StreamReader("temp.txt")

        'Do Loop through strQuery to trim results to required items.
        Do While Not ProcessUsr.StandardOutput.EndOfStream  'ioFile.EndOfStream
            strQuery = ProcessUsr.StandardOutput.ReadLine  'ioFile.ReadLine

            If InStr(strQuery, " yes ", vbTextCompare) > 0 Then

                strLine = Trim(strQuery)

                strCN = """" + Microsoft.VisualBasic.Left(strLine, InStr(strLine, "DC=msd", vbTextCompare) + 5).Trim + """"

                strLoc = strCN
                strLoc = Microsoft.VisualBasic.Left(strLoc, InStr(strLoc, "DC=", vbTextCompare) - 1).Trim
                strLoc = Microsoft.VisualBasic.Right(strLoc, Len(strLoc) - InStr(strLoc, "OU=", vbTextCompare) + 1).Trim

                'Parse CN into Location Strings
                If strLoc <> "" Then
                    strOU05 = Microsoft.VisualBasic.Left(strLoc, InStr(strLoc, ",", vbTextCompare)).Trim
                    strOU05 = Microsoft.VisualBasic.Right(strOU05, Len(strOU05) - InStr(strOU05, "=", vbTextCompare)).Trim
                    strOU05 = Microsoft.VisualBasic.Left(strOU05, InStr(strOU05, ",", vbTextCompare) - 1).Trim

                    strLoc = Microsoft.VisualBasic.Right(strLoc, Len(strLoc) - InStr(strLoc, ",", vbTextCompare)).Trim
                Else
                    strOU05 = ""
                End If

                If strLoc <> "" Then
                    strOU04 = Microsoft.VisualBasic.Left(strLoc, InStr(strLoc, ",", vbTextCompare)).Trim
                    strOU04 = Microsoft.VisualBasic.Right(strOU04, Len(strOU04) - InStr(strOU04, "=", vbTextCompare)).Trim
                    strOU04 = Microsoft.VisualBasic.Left(strOU04, InStr(strOU04, ",", vbTextCompare) - 1).Trim

                    strLoc = Microsoft.VisualBasic.Right(strLoc, Len(strLoc) - InStr(strLoc, ",", vbTextCompare)).Trim
                Else
                    strOU04 = ""
                End If

                If strLoc <> "" Then
                    strOU03 = Microsoft.VisualBasic.Left(strLoc, InStr(strLoc, ",", vbTextCompare)).Trim
                    strOU03 = Microsoft.VisualBasic.Right(strOU03, Len(strOU03) - InStr(strOU03, "=", vbTextCompare)).Trim
                    strOU03 = Microsoft.VisualBasic.Left(strOU03, InStr(strOU03, ",", vbTextCompare) - 1).Trim

                    strLoc = Microsoft.VisualBasic.Right(strLoc, Len(strLoc) - InStr(strLoc, ",", vbTextCompare)).Trim
                Else
                    strOU03 = ""
                End If

                If strLoc <> "" Then
                    strOU02 = Microsoft.VisualBasic.Left(strLoc, InStr(strLoc, ",", vbTextCompare)).Trim
                    strOU02 = Microsoft.VisualBasic.Right(strOU02, Len(strOU02) - InStr(strOU02, "=", vbTextCompare)).Trim
                    strOU02 = Microsoft.VisualBasic.Left(strOU02, InStr(strOU02, ",", vbTextCompare) - 1).Trim

                    strLoc = Microsoft.VisualBasic.Right(strLoc, Len(strLoc) - InStr(strLoc, ",", vbTextCompare)).Trim
                Else
                    strOU02 = ""
                End If

                If strLoc <> "" Then
                    strOU01 = Microsoft.VisualBasic.Left(strLoc, InStr(strLoc, ",", vbTextCompare)).Trim
                    strOU01 = Microsoft.VisualBasic.Right(strOU01, Len(strOU01) - InStr(strOU01, "=", vbTextCompare)).Trim
                    strOU01 = Microsoft.VisualBasic.Left(strOU01, InStr(strOU01, ",", vbTextCompare) - 1).Trim

                    strLoc = Microsoft.VisualBasic.Right(strLoc, Len(strLoc) - InStr(strLoc, ",", vbTextCompare)).Trim
                Else
                    strOU01 = ""
                End If

                If strLoc <> "" Then
                    strOU00 = Microsoft.VisualBasic.Left(strLoc, InStr(strLoc, ",", vbTextCompare)).Trim
                    strOU00 = Microsoft.VisualBasic.Right(strOU00, Len(strOU00) - InStr(strOU00, "=", vbTextCompare)).Trim
                    strOU00 = Microsoft.VisualBasic.Left(strOU00, InStr(strOU00, ",", vbTextCompare) - 1).Trim

                    strLoc = Microsoft.VisualBasic.Right(strLoc, Len(strLoc) - InStr(strLoc, ",", vbTextCompare)).Trim
                Else
                    strOU00 = ""
                End If

                strLoc = ""

                'Add Location Strings to Single String
                If strOU05 <> "" Then
                    strLoc = strOU05
                End If

                If strOU04 <> "" Then
                    strLoc = strOU04 + "/" + strLoc
                End If

                If strOU03 <> "" Then
                    strLoc = strOU03 + "/" + strLoc
                End If

                If strOU02 <> "" Then
                    strLoc = strOU02 + "/" + strLoc
                End If

                If strOU01 <> "" Then
                    strLoc = strOU01 + "/" + strLoc
                End If

                If strOU00 <> "" Then
                    strLoc = strOU00 + "/" + strLoc
                End If

                strNative = Microsoft.VisualBasic.Left(strCN, InStr(strCN, ",", vbTextCompare) - 1)
                strNative = Microsoft.VisualBasic.Mid(strNative, 5)

                strName = Microsoft.VisualBasic.Right(strLine, Len(strLine) - InStr(strLine, "DC=msd", vbTextCompare) - 5).Trim
                strName = Microsoft.VisualBasic.Left(strName, Len(strName) - 3).Trim

                If vbFilter.FilterResults.ReturnResults(Me.txtQRYFilter.Text, strNative, Me.chkQRYFilter.Checked) = False Then
                    dgQRYResult.Rows.Add(strNative, strLoc, strName, strCN)

                    strTrim = strTrim + Trim(strQuery) + Environment.NewLine

                    intResults = intResults + 1
                End If
            End If
        Loop

        Me.txtQueryResults.Text = strTrim
        Me.lblResults.Text = "Returned Results: " + intResults.ToString
        ResultCount = intResults
        Me.btnQRYExport.Enabled = True

        'ProcessUsr.StandardOutput.Close() 'ioFile.Close()
        'End If

    End Sub

    ' Query Users Export Button
    Private Sub btnQRYExport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnQRYExport.Click
        Dim FileName As New FolderBrowserDialog, strFileName As String = "C:\"
        Dim strLine As String = "", strCN As String = "", strName As String = "", strNative As String = "", strLoc As String = ""
        Dim strOU00 As String = "", strOU01 As String = "", strOU02 As String = "", strOU03 As String = "", strOU04 As String = "", strOU05 As String = ""
        Dim intResults As Integer = 0

        FileName.Description = "Select Path for Export"
        FileName.ShowNewFolderButton = True

        If FileName.ShowDialog = Windows.Forms.DialogResult.OK Then
            strFileName = FileName.SelectedPath
        Else
            Exit Sub
        End If

        Me.pbQRYStatus.Maximum = ResultCount

        If Me.txtQRYExport.Text = "" Then
            strFileName = strFileName + "Users-NeverExpire-Report-"
            strFileName = strFileName + Date.Today.Month.ToString + Date.Today.Day.ToString + Date.Today.Year.ToString + ".csv"
        Else
            strFileName = strFileName + Me.txtQRYExport.Text
        End If

        csvWriter = My.Computer.FileSystem.OpenTextFileWriter(strFileName, False)

        strLine = "Native ID , Location , Full Name/Description , CN String"
        csvWriter.WriteLine(strLine)

        'If IO.File.Exists("temp.txt") Then
        'Dim ioFile As New IO.StreamReader("temp.txt")

        ProcessUsr.Start()

        'Do Loop through strQuery to trim results to required items.
        Do While Not ProcessUsr.StandardOutput.EndOfStream  'ioFile.EndOfStream
            strLine = ProcessUsr.StandardOutput.ReadLine  'ioFile.ReadLine

            If InStr(strLine, " yes ", vbTextCompare) > 0 Then
                strLine = Trim(strLine)

                strCN = """" + Microsoft.VisualBasic.Left(strLine, InStr(strLine, "DC=msd", vbTextCompare) + 5).Trim + """"

                strLoc = strCN
                strLoc = Microsoft.VisualBasic.Left(strLoc, InStr(strLoc, "DC=", vbTextCompare) - 1).Trim
                strLoc = Microsoft.VisualBasic.Right(strLoc, Len(strLoc) - InStr(strLoc, "OU=", vbTextCompare) + 1).Trim

                'Parse CN into Location Strings
                If strLoc <> "" Then
                    strOU05 = Microsoft.VisualBasic.Left(strLoc, InStr(strLoc, ",", vbTextCompare)).Trim
                    strOU05 = Microsoft.VisualBasic.Right(strOU05, Len(strOU05) - InStr(strOU05, "=", vbTextCompare)).Trim
                    strOU05 = Microsoft.VisualBasic.Left(strOU05, InStr(strOU05, ",", vbTextCompare) - 1).Trim

                    strLoc = Microsoft.VisualBasic.Right(strLoc, Len(strLoc) - InStr(strLoc, ",", vbTextCompare)).Trim
                Else
                    strOU05 = ""
                End If

                If strLoc <> "" Then
                    strOU04 = Microsoft.VisualBasic.Left(strLoc, InStr(strLoc, ",", vbTextCompare)).Trim
                    strOU04 = Microsoft.VisualBasic.Right(strOU04, Len(strOU04) - InStr(strOU04, "=", vbTextCompare)).Trim
                    strOU04 = Microsoft.VisualBasic.Left(strOU04, InStr(strOU04, ",", vbTextCompare) - 1).Trim

                    strLoc = Microsoft.VisualBasic.Right(strLoc, Len(strLoc) - InStr(strLoc, ",", vbTextCompare)).Trim
                Else
                    strOU04 = ""
                End If

                If strLoc <> "" Then
                    strOU03 = Microsoft.VisualBasic.Left(strLoc, InStr(strLoc, ",", vbTextCompare)).Trim
                    strOU03 = Microsoft.VisualBasic.Right(strOU03, Len(strOU03) - InStr(strOU03, "=", vbTextCompare)).Trim
                    strOU03 = Microsoft.VisualBasic.Left(strOU03, InStr(strOU03, ",", vbTextCompare) - 1).Trim

                    strLoc = Microsoft.VisualBasic.Right(strLoc, Len(strLoc) - InStr(strLoc, ",", vbTextCompare)).Trim
                Else
                    strOU03 = ""
                End If

                If strLoc <> "" Then
                    strOU02 = Microsoft.VisualBasic.Left(strLoc, InStr(strLoc, ",", vbTextCompare)).Trim
                    strOU02 = Microsoft.VisualBasic.Right(strOU02, Len(strOU02) - InStr(strOU02, "=", vbTextCompare)).Trim
                    strOU02 = Microsoft.VisualBasic.Left(strOU02, InStr(strOU02, ",", vbTextCompare) - 1).Trim

                    strLoc = Microsoft.VisualBasic.Right(strLoc, Len(strLoc) - InStr(strLoc, ",", vbTextCompare)).Trim
                Else
                    strOU02 = ""
                End If

                If strLoc <> "" Then
                    strOU01 = Microsoft.VisualBasic.Left(strLoc, InStr(strLoc, ",", vbTextCompare)).Trim
                    strOU01 = Microsoft.VisualBasic.Right(strOU01, Len(strOU01) - InStr(strOU01, "=", vbTextCompare)).Trim
                    strOU01 = Microsoft.VisualBasic.Left(strOU01, InStr(strOU01, ",", vbTextCompare) - 1).Trim

                    strLoc = Microsoft.VisualBasic.Right(strLoc, Len(strLoc) - InStr(strLoc, ",", vbTextCompare)).Trim
                Else
                    strOU01 = ""
                End If

                If strLoc <> "" Then
                    strOU00 = Microsoft.VisualBasic.Left(strLoc, InStr(strLoc, ",", vbTextCompare)).Trim
                    strOU00 = Microsoft.VisualBasic.Right(strOU00, Len(strOU00) - InStr(strOU00, "=", vbTextCompare)).Trim
                    strOU00 = Microsoft.VisualBasic.Left(strOU00, InStr(strOU00, ",", vbTextCompare) - 1).Trim

                    strLoc = Microsoft.VisualBasic.Right(strLoc, Len(strLoc) - InStr(strLoc, ",", vbTextCompare)).Trim
                Else
                    strOU00 = ""
                End If

                strLoc = ""

                'Add Location Strings to Single String
                If strOU05 <> "" Then
                    strLoc = strOU05
                End If

                If strOU04 <> "" Then
                    strLoc = strOU04 + "/" + strLoc
                End If

                If strOU03 <> "" Then
                    strLoc = strOU03 + "/" + strLoc
                End If

                If strOU02 <> "" Then
                    strLoc = strOU02 + "/" + strLoc
                End If

                If strOU01 <> "" Then
                    strLoc = strOU01 + "/" + strLoc
                End If

                If strOU00 <> "" Then
                    strLoc = strOU00 + "/" + strLoc
                End If


                strNative = Microsoft.VisualBasic.Left(strCN, InStr(strCN, ",", vbTextCompare) - 1)
                strNative = Microsoft.VisualBasic.Mid(strNative, 5)

                strName = Microsoft.VisualBasic.Right(strLine, Len(strLine) - InStr(strLine, "DC=msd", vbTextCompare) - 5).Trim
                strName = Microsoft.VisualBasic.Left(strName, Len(strName) - 3).Trim

                If vbFilter.FilterResults.ReturnResults(Me.txtQRYFilter.Text, strNative, Me.chkQRYFilter.Checked) = False Then
                    strLine = strNative + " , " + strLoc + " , " + strName + " , " + strCN

                    csvWriter.WriteLine(strLine)

                    intResults = intResults + 1

                    Me.pbQRYStatus.Increment(intResults)
                    Me.pbQRYStatus.Refresh()
                End If

            End If

        Loop

        'ProcessUsr.StandardOutput.Close() 'ioFile.Close()
        'End If

        csvWriter.Close()

        Me.lblQRYDone.Visible = True

    End Sub

    ' Actuate Groups Create Report Button
    Private Sub btnACTReport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnACTReport.Click
        On Error GoTo Err_btnACTReport_Click

        'Merge LDAP Groups and Actuate Groups in tblGroups.
        Dim strActuate As String, strTemp As String

        strTemp = ""
        strActuate = Me.txtActuateGroups.Text
        Me.txtACTResults.Text = ""

        If Me.chkInc.Checked = True Then

            If Me.txtLDAPGroup01.Text <> "" Then
                Me.txtACTResults.Text = Me.txtLDAPGroup01.Text
            End If

            If Me.txtLDAPGroup02.Text <> "" Then
                Me.txtACTResults.Text = Me.txtACTResults.Text + "; " + Me.txtLDAPGroup02.Text
            End If

            If Me.txtLDAPGroup03.Text <> "" Then
                Me.txtACTResults.Text = Me.txtACTResults.Text + "; " + Me.txtLDAPGroup03.Text
            End If

            If Me.txtLDAPGroup04.Text <> "" Then
                Me.txtACTResults.Text = Me.txtACTResults.Text + "; " + Me.txtLDAPGroup04.Text
            End If

            If Me.txtLDAPGroup05.Text <> "" Then
                Me.txtACTResults.Text = Me.txtACTResults.Text + "; " + Me.txtLDAPGroup05.Text
            End If

            If Me.txtLDAPGroup06.Text <> "" Then
                Me.txtACTResults.Text = Me.txtACTResults.Text + "; " + Me.txtLDAPGroup06.Text
            End If

            If Me.txtLDAPGroup07.Text <> "" Then
                Me.txtACTResults.Text = Me.txtACTResults.Text + "; " + Me.txtLDAPGroup07.Text
            End If

            If Me.txtLDAPGroup08.Text <> "" Then
                Me.txtACTResults.Text = Me.txtACTResults.Text + "; " + Me.txtLDAPGroup08.Text
            End If

            If Me.txtLDAPGroup09.Text <> "" Then
                Me.txtACTResults.Text = Me.txtACTResults.Text + "; " + Me.txtLDAPGroup09.Text
            End If

            If Me.txtLDAPGroup10.Text <> "" Then
                Me.txtACTResults.Text = Me.txtACTResults.Text + "; " + Me.txtLDAPGroup10.Text
            End If
        End If

        Do While strActuate <> ""

            If Len(strActuate) > 3 Then
                strTemp = Microsoft.VisualBasic.Left(strActuate, 3)
                strActuate = Microsoft.VisualBasic.Right(strActuate, Len(strActuate) - Len(strTemp) - 1)
            Else
                strTemp = strActuate
                If Len(strActuate) = 3 Then
                    strActuate = "DONE"
                ElseIf strActuate = "DONE" Then
                    strActuate = ""
                End If
            End If

            If strActuate <> "" Then

                If Me.txtLDAPGroup01.Text <> "" Then
                    If Me.txtACTResults.Text = "" Then
                        Me.txtACTResults.Text = Me.txtLDAPGroup01.Text + "-" + strTemp
                    Else
                        Me.txtACTResults.Text = Me.txtACTResults.Text + "; " + Me.txtLDAPGroup01.Text + "-" + strTemp
                    End If
                End If

                If Me.txtLDAPGroup02.Text <> "" Then
                    Me.txtACTResults.Text = Me.txtACTResults.Text + "; " + Me.txtLDAPGroup02.Text + "-" + strTemp
                End If

                If Me.txtLDAPGroup03.Text <> "" Then
                    Me.txtACTResults.Text = Me.txtACTResults.Text + "; " + Me.txtLDAPGroup03.Text + "-" + strTemp
                End If

                If Me.txtLDAPGroup04.Text <> "" Then
                    Me.txtACTResults.Text = Me.txtACTResults.Text + "; " + Me.txtLDAPGroup04.Text + "-" + strTemp
                End If

                If Me.txtLDAPGroup05.Text <> "" Then
                    Me.txtACTResults.Text = Me.txtACTResults.Text + "; " + Me.txtLDAPGroup05.Text + "-" + strTemp
                End If

                If Me.txtLDAPGroup06.Text <> "" Then
                    Me.txtACTResults.Text = Me.txtACTResults.Text + "; " + Me.txtLDAPGroup06.Text + "-" + strTemp
                End If

                If Me.txtLDAPGroup07.Text <> "" Then
                    Me.txtACTResults.Text = Me.txtACTResults.Text + "; " + Me.txtLDAPGroup07.Text + "-" + strTemp
                End If

                If Me.txtLDAPGroup08.Text <> "" Then
                    Me.txtACTResults.Text = Me.txtACTResults.Text + "; " + Me.txtLDAPGroup08.Text + "-" + strTemp
                End If

                If Me.txtLDAPGroup09.Text <> "" Then
                    Me.txtACTResults.Text = Me.txtACTResults.Text + "; " + Me.txtLDAPGroup09.Text + "-" + strTemp
                End If

                If Me.txtLDAPGroup10.Text <> "" Then
                    Me.txtACTResults.Text = Me.txtACTResults.Text + "; " + Me.txtLDAPGroup10.Text + "-" + strTemp
                End If

            End If

        Loop



Exit_btnACTReport_Click:
        Exit Sub

Err_btnACTReport_Click:
        MsgBox(Err.Description)
        Resume Exit_btnACTReport_Click
    End Sub

    ' Password Generator Create Password Button
    Private Sub btnPASCreate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPASCreate.Click

        txtPASPassword.Text = PasswordGenerator.RandomPassword.Generate.ToString
        txtPASPassword.SelectAll()
        txtPASPassword.Copy()
        txtPASPassword.Focus()

    End Sub

    ' Printer Info. Ok Button
    Private Sub btnPrnOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrnOK.Click
        Dim prtList As String = "", strFilter As String = "", strResult As String = ""
        Dim dirEntry As DirectoryEntry
        Dim dirSearcher As DirectorySearcher
        Dim resultCollection As SearchResultCollection
        Dim result As SearchResult

        If Me.txtPRNPrinter.Text <> "" Or Me.txtPRNLoc.Text <> "" Then

            strFilter = "(& (objectCategory=printQueue)"

            If Me.txtPRNPrinter.Text <> "" Then
                strFilter = strFilter + " (printerName=" + Me.txtPRNPrinter.Text + "*)"
            End If

            If Me.txtPRNLoc.Text <> "" Then
                strFilter = strFilter + " (location=" + Me.txtPRNLoc.Text + "*)"
            End If

            strFilter = strFilter + " )"

        Else

            strFilter = "objectCategory=printQueue"

        End If

        Try
            dirEntry = New DirectoryEntry("")
            dirSearcher = New DirectorySearcher(dirEntry)
            With dirSearcher
                .PageSize = 10
                .Filter = strFilter  ' search filter
                .PropertyNamesOnly = True
                .PropertiesToLoad.Add("printerName")
                .PropertiesToLoad.Add("location")
                .PropertiesToLoad.Add("serverName")
                .PropertiesToLoad.Add("description")
                .SearchScope = SearchScope.Subtree
            End With

            resultCollection = dirSearcher.FindAll()

            For Each result In resultCollection
                prtList = result.GetDirectoryEntry.Properties.Item("printerName").Value.ToString

                If result.GetDirectoryEntry.Properties.Item("location").Value IsNot Nothing Then
                    prtList = prtList + " | " + result.GetDirectoryEntry.Properties.Item("location").Value.ToString
                End If

                prtList = prtList + " | " + result.GetDirectoryEntry.Properties.Item("serverName").Value.ToString

                If result.GetDirectoryEntry.Properties.Item("description").Value IsNot Nothing Then
                    prtList = prtList + " | " + result.GetDirectoryEntry.Properties.Item("description").Value.ToString
                End If

                strResult = strResult + Trim(prtList) + Environment.NewLine
            Next

            Me.txtPRNResult.Text = strResult

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub


    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' Checkbox.Click Events
    ' These proceedures control what each checkbox does when checked
    '  or unchecked.
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    ' Query Users Filter Checkbox
    Private Sub chkQRYFilter_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkQRYFilter.Click
        If chkQRYFilter.Checked = False Then
            txtQRYFilter.Enabled = False
        Else
            txtQRYFilter.Enabled = True
        End If
    End Sub


    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' Textbox.KeyPress Events
    ' These proceedures control what each textbox does when a Key is pressed.
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    ' User Info. Native ID Textbox
    Private Sub txtUSRNativeId_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUSRNativeId.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnUSROk_Click(sender, e)
        End If
    End Sub

    ' Printer Info. Printer Textbox
    Private Sub txtPRNPrinter_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPRNPrinter.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnPrnOK_Click(sender, e)
        End If
    End Sub

    ' Printer Info. Location Textbox
    Private Sub txtPRNLoc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPRNLoc.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnPrnOK_Click(sender, e)
        End If
    End Sub

    ' Ping IP Address Textbox
    Private Sub txtIPAdd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIPAdd.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnIPOk_Click(sender, e)
        End If
    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' End of Events
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Private Sub btnSetPassword_Click(sender As Object, e As System.EventArgs) Handles btnSetPassword.Click

        If txtADMuser.Text IsNot "" And txtPassword.Text IsNot "" And txtUserId.Text IsNot "" Then
            If ValidateActiveDirectoryLogin("NA", Me.txtADMuser.Text, Me.txtPassword.Text) Then
                If MessageBox.Show("Are you sure you want to change the password?", "**** Reset User Password ****", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then

                    txtADMuser.BackColor = Color.White
                    txtPassword.BackColor = Color.White
                    txtUserId.BackColor = Color.White
                    lblWrongCred.Visible = False

                    Dim randomPass As String = PasswordGenerator.RandomPassword.Generate.ToString

                    ChangePassword(txtADMuser.Text, txtPassword.Text, txtUserId.Text, randomPass)

                    If lblNativeValid.Visible = False Then
                        txtPASPassword.Text = randomPass
                        txtPASPassword.SelectAll()
                        txtPASPassword.Copy()
                        txtPASPassword.Focus()
                    End If

                End If

            Else

                lblWrongCred.Visible = True

            End If

        Else

            txtADMuser.BackColor = Color.Red
            txtPassword.BackColor = Color.Red
            txtUserId.BackColor = Color.Red

            'lblRequired.Visible = True


        End If

        'Send Email message
        'Dim app As Microsoft.Office.Interop.Outlook.Application = New Microsoft.Office.Interop.Outlook.Application()
        'Dim mailItem As Microsoft.Office.Interop.Outlook.MailItem = app.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem)

        'mailItem.Subject = "This is the subject"
        'mailItem.To = "someone@example.com"
        'mailItem.Body = "This is the message."
        'mailItem.Importance = Microsoft.Office.Tools.Outlook.OlImportance.olImportanceHigh
        'mailItem.Display(False)


    End Sub

    Public Shared Sub ChangePassword(ByVal ADMid As String, ByVal ADMpassword As String, ByVal UserId As String, ByVal NewPassword As String)

        Dim ProcessIP As New Process()

        ProcessIP.StartInfo.FileName = "cmd.exe"
        ProcessIP.StartInfo.Arguments = "/C dsquery user -u " + ADMid + " -p " + ADMpassword + " -name " + UserId

        ProcessIP.StartInfo.UseShellExecute = False
        ProcessIP.StartInfo.CreateNoWindow = True
        ProcessIP.StartInfo.RedirectStandardOutput = True

        ProcessIP.Start()
        ProcessIP.WaitForExit(1000)

        Dim UserDN As String = ProcessIP.StandardOutput.ReadToEnd()

        ProcessIP.Refresh()

        If UserDN IsNot "" Then
            frmMain.lblNativeValid.Visible = False

            ProcessIP.StartInfo.FileName = "cmd.exe"
            ProcessIP.StartInfo.Arguments = "/C dsmod user -u " + ADMid + " -p " + ADMpassword + " " + UserDN.Trim + " -pwd " + NewPassword + " -mustchpwd no"

            ProcessIP.StartInfo.UseShellExecute = False
            ProcessIP.StartInfo.CreateNoWindow = True
            ProcessIP.StartInfo.RedirectStandardOutput = True

            ProcessIP.Start()
            ProcessIP.WaitForExit(1000)

            Dim output As String = ProcessIP.StandardOutput.ReadToEnd()
        Else
            frmMain.lblNativeValid.Visible = True
        End If

    End Sub

    Public Shared Function GetUser(ByVal UserId As String) As DirectoryEntry
        Dim rootPath As String = GetRootPath()

        Dim objRootEntry As New DirectoryEntry(rootPath)
        Dim objAdSearcher As New DirectorySearcher(objRootEntry)

        objAdSearcher.Filter = "((objectClass=user)(cn=" + UserId + "))"

        Dim objResult As SearchResult = objAdSearcher.FindOne()

        If objResult IsNot Nothing Then
            Return objResult.GetDirectoryEntry()
        Else
            Return Nothing
        End If

    End Function

    Public Shared Function IsAccountLocked(ByVal userName As String) As Boolean
        Try
            Dim user As DirectoryEntry = GetUser(userName)
            If user Is Nothing Then
                Return False
            End If
            If CBool(user.InvokeGet("IsAccountLocked")) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw New Exception("Error checking for locked account. " + ex.ToString)
        End Try

    End Function

    Private Shared Function GetRootPath() As String
        Dim DSESearcher As New DirectorySearcher()
        Dim sRootPath As String = DSESearcher.SearchRoot.Path
        DSESearcher.Dispose()
        Return sRootPath
    End Function

    Private Sub btnStart_Click(sender As Object, e As System.EventArgs) Handles btnStart.Click
        Stopwatch.Start()
        tmMain.Interval = 100
        tmMain.Enabled = True

    End Sub

    Sub UpdateDisplay(ByVal ts)

        txtCount.Text = String.Format("{0:0}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10)
        Me.txtCount.SelectionAlignment = HorizontalAlignment.Center

        If ts.Minutes >= txtWarning.Text And ts.Minutes < txtAlarm.Text Then
            Me.txtCount.ForeColor = Color.Black
            Me.txtCount.BackColor = Color.Yellow

        ElseIf ts.Minutes >= txtAlarm.Text Then

            tmFlash.Interval = 500
            tmFlash.Enabled = True

        End If


    End Sub

    Private Sub tmMain_Tick(sender As Object, e As System.EventArgs) Handles tmMain.Tick
        If Stopwatch.IsRunning Then
            ' Get the elapsed time as a TimeSpan value.
            UpdateDisplay(Stopwatch.Elapsed)
        End If
    End Sub

    Private Sub btnStop_Click(sender As Object, e As System.EventArgs) Handles btnStop.Click

        Stopwatch.Stop()
        tmFlash.Enabled = False

    End Sub

    Private Sub btnRst_Click(sender As Object, e As System.EventArgs) Handles btnRst.Click

        Stopwatch.Reset()
        tmMain.Enabled = False
        tmFlash.Enabled = False

        Me.txtCount.Text = "0:00:00"
        Me.txtCount.SelectionAlignment = HorizontalAlignment.Center
        Me.txtCount.ForeColor = Control.DefaultForeColor
        Me.txtCount.BackColor = Control.DefaultBackColor

        Me.txtAlarm.Text = "15"
        Me.txtWarning.Text = "10"

    End Sub

    Private Sub tmFlash_Tick(sender As Object, e As System.EventArgs) Handles tmFlash.Tick
        If blSwitch = True Then
            Me.txtCount.ForeColor = Color.Red
            Me.txtCount.BackColor = Color.Black
            blSwitch = False

            FlashWindow(Me.Handle, 1)

        ElseIf blSwitch = False Then
            Me.txtCount.ForeColor = Color.Black
            Me.txtCount.BackColor = Color.Red
            blSwitch = True

        End If
    End Sub

    Private Sub btnTestPass_Click(sender As Object, e As EventArgs) Handles btnTestPass.Click

        If ValidateActiveDirectoryLogin("NA", Me.txtNativeIDtest.Text, Me.txtPassTest.Text) Then

            Me.txtResultsPassT.Text = "Success!"

        Else

            Me.txtResultsPassT.Text = "Failed, please try again."

        End If

    End Sub

    Private Sub btnResetTestPass_Click(sender As Object, e As EventArgs) Handles btnResetTestPass.Click

        Me.txtResultsPassT.Text = ""
        Me.txtNativeIDtest.Text = ""
        Me.txtPassTest.Text = ""

    End Sub

    Private Sub txtPassTest_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassTest.KeyDown

        If e.KeyCode = Keys.Enter Then

            If ValidateActiveDirectoryLogin("NA", Me.txtNativeIDtest.Text, Me.txtPassTest.Text) Then

                Me.txtResultsPassT.Text = "Success!"

            Else

                Me.txtResultsPassT.Text = "Failed, please try again."

            End If

        End If

    End Sub

    Private Sub txtADMuser_TextChanged(sender As Object, e As EventArgs) Handles txtADMuser.TextChanged
        If txtADMuser.Text IsNot "" Then

            txtADMuser.BackColor = Color.White

            My.Settings.MyAdm = txtADMuser.Text
            My.Settings.Save()

        Else

            txtADMuser.BackColor = Color.Red

            'lblRequired.Visible = True

        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If txtPassword.Text IsNot "" Then

            txtPassword.BackColor = Color.White

            My.Settings.MyPass = txtPassword.Text
            My.Settings.Save()

        Else

            txtPassword.BackColor = Color.Red

            'lblRequired.Visible = True

        End If
    End Sub

    Private Sub txtUserId_TextChanged(sender As Object, e As EventArgs) Handles txtUserId.TextChanged
        If txtUserId.Text IsNot "" Then

            txtUserId.BackColor = Color.White

            'lblRequired.Visible = False

        Else

            txtUserId.BackColor = Color.Red

            'lblRequired.Visible = True

        End If
    End Sub

    Private Sub btnSOver_Click(sender As Object, e As EventArgs) Handles btnSOver.Click

        txtADMuser.Text = My.Settings.MyAdm
        txtPassword.Text = My.Settings.MyPass
        txtUserId.Text = ""
        txtPASPassword.Text = ""

        lblWrongCred.Visible = False
        lblNativeValid.Visible = False

        txtADMuser.BackColor = Color.White
        txtPassword.BackColor = Color.White
        txtUserId.BackColor = Color.White

    End Sub

End Class
