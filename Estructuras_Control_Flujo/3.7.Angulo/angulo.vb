Imports System

Module Program
    Sub Main()
        Dim ingreso As Integer

        Console.WriteLine("Ingrese el tamaño del un angulo: ")
        ingreso = Console.ReadLine()

        Select Case ingreso
            Case Is < 90
                Console.WriteLine("El angulo es agudo.")
            Case Is = 90
                Console.WriteLine("El angulo es recto.")
            Case Is > 90 And ingreso < 180
                Console.WriteLine("El angulo es Obtuso.")
            Case Is = 180
                Console.WriteLine("El angulo es Llano.")
            Case Is > 180 And ingreso < 360
                Console.WriteLine("El angulo es concavo.")
            Case Else
                Console.WriteLine("Error. El grado ingreso no corresponde.")

        End Select
    End Sub
End Module