Module Main
    Private Const runTimes As ULong = 100000
    Private uSumLinear As ULong
    Private uSumFormular As ULong

    Public Sub examFunction(funcToExam As Action(Of ULong, ULong), funcName As String)
        Dim initTime As DateTime = DateTime.Now
        Console.WriteLine("[*] Begin {0}", funcName)

        For i As ULong = 1 To runTimes
            funcToExam(1, 100)
        Next

        Console.WriteLine("[*] Finish {0}, time taken {1} ms.",
                          funcName, CULng((DateTime.Now - initTime).TotalMilliseconds))
        Console.WriteLine()
    End Sub

    Public Sub Algo1(startNumber As ULong, endNumber As ULong)
        uSumLinear = 0
        For i As ULong = startNumber To endNumber
            uSumLinear += i
        Next
    End Sub

    Public Sub Algo2(startNumber As ULong, endNumber As ULong)
        uSumFormular = 0
        ' (endNumber - startNumber + 1) is the amount of numbers
        uSumFormular = (startNumber + endNumber) * (endNumber - startNumber + 1) / 2
    End Sub

    Sub Main()
        examFunction(AddressOf Algo1, "Linear Sum")
        examFunction(AddressOf Algo2, "Formular Sum")

        Console.WriteLine ("Linear: {0}, Formular: {1}", uSumLinear, uSumFormular)

        Console.ReadKey()
    End Sub
End Module


