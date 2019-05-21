Imports System

Module Program


    Sub Main()
        Dim a As String
        Dim b, c, e, f As Int16
        Dim d As Decimal

        Console.WriteLine("Que unidad de medida desea convertir: " & vbCrLf)
        Console.WriteLine("1-Conversion de Metro: ")
        Console.WriteLine("2-Conversion de Pulgadas: ")
        Console.WriteLine("3-Conversion de Pies: ")
        Console.WriteLine("4-Conversion de Yardas: ")

        a = Console.ReadLine()
        Select Case a
            Case "1"
                Console.WriteLine("Ingrese los Metros a convertir:")
                b = Console.ReadLine()
                c = b * 100
                d = c / 2.54
                e = d / 12
                f = e / 3
                Console.WriteLine("Resultados:" & vbCrLf & "CM: " & c & vbCrLf & "Pulgadas: " & d & vbCrLf & "Pies: " & e & vbCrLf &
                                  "Yardas: " & f)
            Case "2"
                Console.WriteLine("Ingrese las Pulgadas a convertir:")
                b = Console.ReadLine()

                d = b * 2.54
                c = d / 100
                e = b / 12
                f = e / 3
                Console.WriteLine("Resultados:" & vbCrLf & "CM: " & d & vbCrLf & "Metros: " & c & vbCrLf & "Pies: " & e & vbCrLf &
                                  "Yardas: " & f)
            Case "3"
                Console.WriteLine("Ingrese los Pies a convertir:")
                b = Console.ReadLine()

                e = b * 12
                f = b / 3
                d = e * 2.54
                c = d / 100

                Console.WriteLine("Resultados:" & vbCrLf & "Pulgadas: " & e & vbCrLf & "CM: " & d & vbCrLf & "Metros: " & c & vbCrLf &
                                  "Yardas: " & f)
            Case "4"
                Console.WriteLine("Ingrese las Yardas a convertir:")
                b = Console.ReadLine()

                f = b * 3
                e = f * 12
                d = e * 2.54
                c = d / 100

                Console.WriteLine("Resultados:" & vbCrLf & "Pies: " & f & vbCrLf & "Pulgadas: " & e & vbCrLf & "CM: " & d & vbCrLf &
                                  "Metros: " & f)
        End Select
        Console.ReadKey()
    End Sub
End Module
