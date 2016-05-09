Public Class frmActuateMain

    Private Sub cmdClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdClear.Click

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
        Me.txtResults.Text = ""

    End Sub

    Private Sub cmdExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdExit.Click

        End

    End Sub

    Private Sub cmdReport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdReport.Click
        On Error GoTo Err_cmdReport_Click

        'Merge LDAP Groups and Actuate Groups in tblGroups.
        Dim strActuate As String, strTemp As String

        strTemp = ""
        strActuate = Me.txtActuateGroups.Text
        Me.txtResults.Text = ""

        If Me.chkInc.Checked = True Then

            If Me.txtLDAPGroup01.Text <> "" Then
                Me.txtResults.Text = Me.txtLDAPGroup01.Text
            End If

            If Me.txtLDAPGroup02.Text <> "" Then
                Me.txtResults.Text = Me.txtResults.Text + "; " + Me.txtLDAPGroup02.Text
            End If

            If Me.txtLDAPGroup03.Text <> "" Then
                Me.txtResults.Text = Me.txtResults.Text + "; " + Me.txtLDAPGroup03.Text
            End If

            If Me.txtLDAPGroup04.Text <> "" Then
                Me.txtResults.Text = Me.txtResults.Text + "; " + Me.txtLDAPGroup04.Text
            End If

            If Me.txtLDAPGroup05.Text <> "" Then
                Me.txtResults.Text = Me.txtResults.Text + "; " + Me.txtLDAPGroup05.Text
            End If

            If Me.txtLDAPGroup06.Text <> "" Then
                Me.txtResults.Text = Me.txtResults.Text + "; " + Me.txtLDAPGroup06.Text
            End If

            If Me.txtLDAPGroup07.Text <> "" Then
                Me.txtResults.Text = Me.txtResults.Text + "; " + Me.txtLDAPGroup07.Text
            End If

            If Me.txtLDAPGroup08.Text <> "" Then
                Me.txtResults.Text = Me.txtResults.Text + "; " + Me.txtLDAPGroup08.Text
            End If

            If Me.txtLDAPGroup09.Text <> "" Then
                Me.txtResults.Text = Me.txtResults.Text + "; " + Me.txtLDAPGroup09.Text
            End If

            If Me.txtLDAPGroup10.Text <> "" Then
                Me.txtResults.Text = Me.txtResults.Text + "; " + Me.txtLDAPGroup10.Text
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
                    If Me.txtResults.Text = "" Then
                        Me.txtResults.Text = Me.txtLDAPGroup01.Text + "-" + strTemp
                    Else
                        Me.txtResults.Text = Me.txtResults.Text + "; " + Me.txtLDAPGroup01.Text + "-" + strTemp
                    End If
                End If

                If Me.txtLDAPGroup02.Text <> "" Then
                    Me.txtResults.Text = Me.txtResults.Text + "; " + Me.txtLDAPGroup02.Text + "-" + strTemp
                End If

                If Me.txtLDAPGroup03.Text <> "" Then
                    Me.txtResults.Text = Me.txtResults.Text + "; " + Me.txtLDAPGroup03.Text + "-" + strTemp
                End If

                If Me.txtLDAPGroup04.Text <> "" Then
                    Me.txtResults.Text = Me.txtResults.Text + "; " + Me.txtLDAPGroup04.Text + "-" + strTemp
                End If

                If Me.txtLDAPGroup05.Text <> "" Then
                    Me.txtResults.Text = Me.txtResults.Text + "; " + Me.txtLDAPGroup05.Text + "-" + strTemp
                End If

                If Me.txtLDAPGroup06.Text <> "" Then
                    Me.txtResults.Text = Me.txtResults.Text + "; " + Me.txtLDAPGroup06.Text + "-" + strTemp
                End If

                If Me.txtLDAPGroup07.Text <> "" Then
                    Me.txtResults.Text = Me.txtResults.Text + "; " + Me.txtLDAPGroup07.Text + "-" + strTemp
                End If

                If Me.txtLDAPGroup08.Text <> "" Then
                    Me.txtResults.Text = Me.txtResults.Text + "; " + Me.txtLDAPGroup08.Text + "-" + strTemp
                End If

                If Me.txtLDAPGroup09.Text <> "" Then
                    Me.txtResults.Text = Me.txtResults.Text + "; " + Me.txtLDAPGroup09.Text + "-" + strTemp
                End If

                If Me.txtLDAPGroup10.Text <> "" Then
                    Me.txtResults.Text = Me.txtResults.Text + "; " + Me.txtLDAPGroup10.Text + "-" + strTemp
                End If

            End If

        Loop



Exit_cmdReport_Click:
        Exit Sub

Err_cmdReport_Click:
        MsgBox(Err.Description)
        Resume Exit_cmdReport_Click
    End Sub
End Class
