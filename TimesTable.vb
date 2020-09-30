Module TimesTable

    Sub Main()
        Dim promt$
        Dim userNumber%

        Console.WriteLine("Enter the number of rows to create a multiplication table:")
        If getUserInput(userNumber%) = "" Then
            TimesTable(userNumber%)
        Else
            Console.WriteLine(getUserInput(userNumber%))
        End If
        Console.Read()
    End Sub

    Function getUserInput(ByRef aNumber%) As String
        Try
            aNumber% = CInt(Console.ReadLine())
            Return ""
        Catch e As Exception
            Return "Input must be a whole number"
        End Try
    End Function


    Sub TimesTable(firstNumber As Integer)
        Dim temp$
        Const padLen% = 6
        Console.Clear()

        'If Console.LargestWindowWidth < ((firstNumber + 1) * padLen) Then
        '    Console.WindowWidth = Console.LargestWindowWidth
        'Else
        '    Console.WindowWidth = ((firstNumber + 1) * padLen)
        'End If

        'If Console.LargestWindowHeight < ((firstNumber + 1)) Then
        '    Console.WindowHeight = Console.LargestWindowHeight
        'Else
        '    Console.WindowHeight = ((firstNumber + 1))
        'End If
        Console.WriteLine($"Enjoy your {firstNumber} x {firstNumber} Multiplication Table:" & vbNewLine)

        For row = 1 To firstNumber
            For column = 1 To firstNumber
                temp = CStr(row * column)
                Console.Write(temp.PadLeft(padLen))
            Next
            Console.WriteLine()
        Next

    End Sub

End Module
