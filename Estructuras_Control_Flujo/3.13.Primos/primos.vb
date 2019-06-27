Imports System.Math

Module Program
    Sub Main()
        BuscarPrimos(1000)
    End Sub

    Sub BuscarPrimos(ByVal MaxNum As Integer)
        Dim i As Integer, y As Integer, x As Integer

        For i = 1 To MaxNum
            y = Sqrt(i) + 1
            x = 2
            Do While (((i Mod x) > 0) And (x <= y))
                x = x + 1
            Loop
            If ((x - 1) = y) Then
                Console.WriteLine("{0} es primoy", i)
            End If
        Next i
    End Sub
End Module
