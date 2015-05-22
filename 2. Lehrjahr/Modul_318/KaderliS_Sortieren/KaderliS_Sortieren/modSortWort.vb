Module modWort
    'Bubblesort
    Public Sub bubbleWort(ByRef Wort() As String)
        For i As Integer = LBound(Wort) To Wort.Length
            For j As Integer = Wort.Length - 1 To i + 1 Step -1
                If Wort(j) < Wort(j - 1) Then
                    Dim tmp As String = Wort(j - 1)
                    Wort(j - 1) = Wort(j)
                    Wort(j) = tmp
                End If
            Next
        Next
    End Sub

    'Ripplesort
    Public Sub rippleWort(ByRef Wort() As String)
        Dim blnSwapped As Boolean = False
        Dim n As Integer = Wort.Length
        Do
            blnSwapped = False
            For i As Integer = LBound(Wort) To Wort.Length - 2

                If Wort(i) > Wort(i + 1) Then
                    Dim tmp As String = Wort(i + 1)
                    Wort(i + 1) = Wort(i)
                    Wort(i) = tmp
                    blnSwapped = True
                End If
            Next
            n -= 1
        Loop Until blnSwapped = False
    End Sub

    'Quicksort
    Public Sub quickWort(ByRef Wort() As String, ByVal intStart As Integer, ByVal intEnd As Integer)
        Dim i As Integer = intStart
        Dim j As Integer = intEnd

        Dim x As String = Wort((i + j) \ 2)
        Do
            Do While Wort(i) < x
                i += 1
            Loop

            Do While x < Wort(j)
                j -= 1
            Loop

            If i <= j Then
                Dim tmp As String = Wort(i)
                Wort(i) = Wort(j)
                Wort(j) = tmp
                i += 1
                j -= 1
            End If
        Loop Until i > j
        If intStart < j Then
            quickWort(Wort, intStart, j)
        End If
        If i < intEnd Then
            quickWort(Wort, i, intEnd)
        End If
    End Sub

    'Insertionsort
    Public Sub insertionWort(ByRef Wort() As String)
        Dim tmp As String
        Dim i As Integer
        Dim j As Integer

        For i = 1 To Wort.Length - 1
            j = i
            Do While j > 0 AndAlso Wort(j - 1) > Wort(j)
                tmp = Wort(j)
                Wort(j) = Wort(j - 1)
                Wort(j - 1) = tmp
                j -= 1
            Loop
        Next
    End Sub
End Module
