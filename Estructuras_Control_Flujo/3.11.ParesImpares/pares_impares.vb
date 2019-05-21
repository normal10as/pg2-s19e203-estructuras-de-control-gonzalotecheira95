Imports System

Module Program
    Sub Main()
        Dim ingreso As Integer
        Dim acum_par, acum_impar As UShort

        Do
            Console.WriteLine("Ingrese un numero (0-Para Salir): ")
            ingreso = Console.ReadLine()
            If (ingreso Mod 2) = 0 And ingreso <> 0 Then
                acum_par = acum_par + 1
            ElseIf Not (ingreso Mod 2) = 0 And ingreso <> 0 Then
                acum_impar = acum_impar + 1
            End If
        Loop While (ingreso <> 0)

        Console.WriteLine("El total de numero pares es de: " & acum_par)
        Console.WriteLine("El total de numeros impares es de: " & acum_impar)
    End Sub
End Module
