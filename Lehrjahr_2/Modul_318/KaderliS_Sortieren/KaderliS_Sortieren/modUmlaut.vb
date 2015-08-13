Module modUmlaut
    Public Function Umlaut(ByVal Zeichen As Char) As Char

        Select Case Zeichen
            Case "ä", "à"
                Umlaut = "a"
            Case "Ä", "À"
                Umlaut = "A"
            Case "ö"
                Umlaut = "o"
            Case "Ö"
                Umlaut = "O"
            Case "é", "è", "ë"
                Umlaut = "e"
            Case "ü"
                Umlaut = "u"
            Case "Ü"
                Umlaut = "U"
            Case Else
                Umlaut = Zeichen
        End Select
    End Function
End Module
