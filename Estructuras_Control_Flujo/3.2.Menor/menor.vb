Imports System

Module Program
    Sub Main()
        Dim num1, num2, num3 As Short

        Console.WriteLine("Ingrese un valor: ")
        num1 = Console.ReadLine()
        Console.WriteLine("Ingrese otro valor: ")
        num2 = Console.ReadLine()
        Console.WriteLine("Ingrese el ultimo valor: ")
        num3 = Console.ReadLine()

        If num1 < num2 And num1 < num3 Then
            Console.WriteLine("El primer valor es el menor.")
        ElseIf num2 < num1 And num2 < num3 Then
            Console.WriteLine("El segundo valor es el menor.")
        ElseIf num3 < num1 And num3 < num2 Then
            Console.WriteLine("El tercer valor es el menor.")
        End If

    End Sub
End Module
