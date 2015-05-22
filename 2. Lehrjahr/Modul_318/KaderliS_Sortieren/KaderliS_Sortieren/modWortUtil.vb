Module modSortWort
    Public Sub WorteLesen(ByRef strSort As String, ByRef Wort() As String)
        strSort = Replace(strSort, vbCrLf, " ")
        strSort = Replace(strSort, vbTab, " ")
        strSort = Replace(strSort, ",", " ")
        strSort = Replace(strSort, ".", " ")
        strSort = Replace(strSort, """", " ")
        While InStr(strSort, "  ") > 0
            strSort = Replace(strSort, "  ", " ")
        End While
        Wort = Split(Trim(strSort), " ")
    End Sub

    Public Sub WorteSchreiben(ByRef strSort As String, ByRef Wort() As String)
        strSort = Join(Wort, " ")
    End Sub
End Module
