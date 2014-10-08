Public Class ClassTimer
    Private initTime As DateTime
    Sub New()
        initTime = DateTime.Now
    End Sub

    Function getMsEscaped() As Double
        Return (DateTime.Now - initTime).TotalMilliseconds
    End Function
End Class
