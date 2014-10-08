Public Class ClassAlgorithm
    Sub sumUp1()
        Dim timer As New ClassTimer()

        Dim uSums As ULong

        Console.WriteLine("[*] Begin sumup using method (1)")

        For times As Integer = 1 To 100000

            ' Start
            uSums = 0
            For i As Integer = 1 To 100
                uSums += i
            Next
            ' End

        Next

        Console.WriteLine("[*] Finish sumup using method (1), time taken {0} ms.", timer.getMsEscaped())
    End Sub


    Sub sumUp2()
        Dim timer As New ClassTimer()
        Dim uSums As ULong

        Console.WriteLine("[*] Begin sumup using method (2)")

        For times As Integer = 1 To 100000

            ' Start
            uSums = 0
            uSums = (1 + 100) * 100 / 2
            ' End

        Next

        Console.WriteLine("[*] Finish sumup using method (2), time taken {0} ms.", timer.getMsEscaped())
    End Sub
End Class
