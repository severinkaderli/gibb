Module modSort

    'Ripplesort
    Public Sub rippleSort(ByRef strSort As String)
        Dim blnSwapped As Boolean = False
        Dim n As Integer = strSort.Length

        Do
            blnSwapped = False
            For i As Integer = 1 To strSort.Length - 1

                If Mid(strSort, i, 1) > Mid(strSort, i + 1, 1) Then
                    Dim tmp As Char = Mid(strSort, i + 1, 1)
                    Mid(strSort, i + 1, 1) = Mid(strSort, i, 1)
                    Mid(strSort, i, 1) = tmp
                    blnSwapped = True
                End If
                Application.DoEvents()
            Next
            n -= 1
            Application.DoEvents()
        Loop Until blnSwapped = False
    End Sub

    Public Sub rippleSortUmlaut(ByRef strSort As String)
        Dim blnSwapped As Boolean = False
        Dim n As Integer = strSort.Length

        Do
            blnSwapped = False
            For i As Integer = 1 To strSort.Length - 1

                If Umlaut(Mid(strSort, i, 1)) > Umlaut(Mid(strSort, i + 1, 1)) Then
                    Dim tmp As Char = Mid(strSort, i + 1, 1)
                    Mid(strSort, i + 1, 1) = Mid(strSort, i, 1)
                    Mid(strSort, i, 1) = tmp
                    blnSwapped = True
                End If
                Application.DoEvents()
            Next
            n -= 1
            Application.DoEvents()
        Loop Until blnSwapped = False
    End Sub

    'Quicksort
    Public Sub quickSort(ByRef strSort, ByVal intStart, ByVal intEnd)
        Dim i As Integer = intStart
        Dim j As Integer = intEnd

        Dim x As Char = Mid(strSort, (i + j) \ 2, 1)
        Do
            Do While Mid(strSort, i, 1) < x
                i += 1
            Loop

            Do While x < Mid(strSort, j, 1)
                j -= 1
            Loop

            If i <= j Then
                Dim tmp As Char = Mid(strSort, i, 1)
                Mid(strSort, i, 1) = Mid(strSort, j, 1)
                Mid(strSort, j, 1) = tmp
                i += 1
                j -= 1
            End If
        Loop Until i > j
        If intStart < j Then
            quickSort(strSort, intStart, j)
        End If
        If i < intEnd Then
            quickSort(strSort, i, intEnd)
        End If
    End Sub

    Public Sub quickSortUmlaut(ByRef strSort, ByVal intStart, ByVal intEnd)
        Dim i As Integer = intStart
        Dim j As Integer = intEnd

        Dim x As Char = Umlaut(Mid(strSort, (intStart + intEnd) \ 2, 1))
        Do
            Do While Umlaut(Mid(strSort, i, 1)) < x
                i += 1
            Loop

            Do While x < Umlaut(Mid(strSort, j, 1))
                j -= 1
            Loop

            If i <= j Then
                Dim tmp As Char = Mid(strSort, i, 1)
                Mid(strSort, i, 1) = Mid(strSort, j, 1)
                Mid(strSort, j, 1) = tmp
                i += 1
                j -= 1
            End If
        Loop Until i > j
        If intStart < j Then
            quickSortUmlaut(strSort, intStart, j)
        End If
        If i < intEnd Then
            quickSortUmlaut(strSort, i, intEnd)
        End If
    End Sub

    'Bubblesort
    Public Sub bubbleSort(ByRef strSort As String)
        For i As Integer = 1 To strSort.Length
            For j As Integer = strSort.Length To i + 1 Step -1
                If Mid(strSort, j, 1) < Mid(strSort, j - 1, 1) Then
                    Dim tmp As Char = Mid(strSort, j - 1, 1)
                    Mid(strSort, j - 1, 1) = Mid(strSort, j, 1)
                    Mid(strSort, j, 1) = tmp
                End If
            Next
        Next
    End Sub

    Public Sub bubbleSortUmlaut(ByRef strSort As String)
        For i As Integer = 1 To strSort.Length
            For j As Integer = strSort.Length To i + 1 Step -1
                If Umlaut(Mid(strSort, j, 1)) < Umlaut(Mid(strSort, j - 1, 1)) Then
                    Dim tmp As Char = Mid(strSort, j - 1, 1)
                    Mid(strSort, j - 1, 1) = Mid(strSort, j, 1)
                    Mid(strSort, j, 1) = tmp
                End If
            Next
        Next
    End Sub

    'Insertionsort
    Public Sub insertionSort(ByRef strSort As String)
        Dim tmp As Char
        Dim i As Integer
        Dim j As Integer

        For i = 1 To strSort.Length
            tmp = Mid(strSort, i, 1)
            j = i
            Do While j > 1
                If Mid(strSort, j - 1, 1) > tmp Then
                    Mid(strSort, j, 1) = Mid(strSort, j - 1, 1)
                    Mid(strSort, j - 1, 1) = tmp
                End If
                j -= 1
            Loop
        Next
    End Sub

    Public Sub insertionSortUmlaut(ByRef strSort As String)
        Dim tmp As Char
        Dim i As Integer
        Dim j As Integer

        For i = 1 To strSort.Length
            tmp = Mid(strSort, i, 1)
            j = i
            Do While j > 1
                If Umlaut(Mid(strSort, j - 1, 1)) > Umlaut(tmp) Then
                    Mid(strSort, j, 1) = Mid(strSort, j - 1, 1)
                    Mid(strSort, j - 1, 1) = tmp
                End If
                j -= 1
            Loop
        Next
    End Sub
End Module
