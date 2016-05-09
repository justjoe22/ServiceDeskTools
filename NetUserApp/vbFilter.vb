Module vbFilter

    Public Class FilterResults

        ' Query Users - Uses this function to filter out user accounts that are by default set to Never Expire.
        Public Shared Function ReturnResults(ByVal strFilter As String, ByVal strID As String, ByVal blFilter As Boolean) As Boolean
            Dim blResult As Boolean = False
            Dim strSearch As String = ""

            If blFilter = True Then

                'Do loop code for filter.
                Do While strFilter <> "" And blResult = False
                    If Len(strFilter) > 0 Then
                        If InStr(strFilter, ",", vbTextCompare) > 0 Then
                            strSearch = Microsoft.VisualBasic.Left(strFilter, InStr(strFilter, ",", vbTextCompare) - 1)
                            strFilter = Microsoft.VisualBasic.Right(strFilter, Len(strFilter) - Len(strSearch) - 1)
                        Else
                            strSearch = strFilter.Trim
                            strFilter = ""
                        End If

                        If InStr(strID, strSearch, vbTextCompare) > 0 Then
                            blResult = True
                        Else
                            blResult = False
                        End If
                    End If
                Loop
            Else
                blResult = False
            End If

            'ReturnResults = True if a match is found and should be filtered out.
            ReturnResults = blResult
        End Function

    End Class

End Module
