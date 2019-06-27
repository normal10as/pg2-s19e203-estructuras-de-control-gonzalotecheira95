Imports System.Math

Module Program
    Sub Main()
        Dim A, B As Short

        ingreso(A, "A")

        ingreso(B, "B")

        Console.WriteLine("La hipotenusa es igual a: " & Hipotenusa(A, B))
    End Sub
    Private Function Hipotenusa(ByRef ladoA As Short, ByRef ladoB As Short) As Short
        Dim hipo As Short
        hipo = Math.Sqrt(ladoA * ladoA + ladoB * ladoB)
        Return hipo
    End Function
    Private Function ingreso(ByRef positivo As Short, ByRef ladostring As String) As Short
        Do
            Console.WriteLine("Ingrese tamaño del lado {0}: ", ladostring)
            positivo = Console.ReadLine()
            If (positivo < 0) Then
                Console.WriteLine("Error ingrese un entero positvo, para el lado {0}.", ladostring)
            End If
        Loop While (positivo < 0)
        Return positivo
    End Function
End Module