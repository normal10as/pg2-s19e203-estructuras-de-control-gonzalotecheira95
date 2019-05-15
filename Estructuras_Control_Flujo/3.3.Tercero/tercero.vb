Imports System
Module Program
    Sub Main()
        Dim num1, num2, num3, num4, num5 As Short

        Console.WriteLine("Ingrese el numero 1: ")
        num1 = Console.ReadLine()
        Console.WriteLine("Ingrese el numero 2: ")
        num2 = Console.ReadLine()
        Console.WriteLine("Ingrese el numero 3: ")
        num3 = Console.ReadLine()
        Console.WriteLine("Ingrese el numero 4: ")
        num4 = Console.ReadLine()
        Console.WriteLine("Ingrese el numero 5: ")
        num5 = Console.ReadLine()

        If num1 > num2 And num1 > num3 And num1 > num4 And num1 > num5 Then
            Console.WriteLine("El primer numero ingresado es el mayor")
        ElseIf num2 > num1 And num2 > num3 And num2 > num4 And num2 > num5 Then
            Console.WriteLine("El segundo numero ingresado es el mayor")
        ElseIf num3 > num1 And num3 > num2 And num3 > num4 And num3 > num5 Then
            Console.WriteLine("El tercer numero ingresado es el mayor")
        ElseIf num4 > num1 And num4 > num3 And num4 > num2 And num4 > num5 Then
            Console.WriteLine("El cuarto numero ingresado es el mayor")
        ElseIf num5 > num1 And num5 > num3 And num5 > num4 And num5 > num2 Then
            Console.WriteLine("El quinto numero ingresado es el mayor")

        End If
    End Sub
End Module
