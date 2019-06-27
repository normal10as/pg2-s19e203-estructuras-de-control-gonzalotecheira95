Imports System

Module Program
    Const interes_anual As Single = 1.36
    Sub Main()
        Dim cap_inicial As Single, cant_meses As UShort
        Dim capital, interes, saldo, total_interes As Decimal

        Console.WriteLine("Ingrese Capital Incial: ")
        cap_inicial = Console.ReadLine()
        Console.WriteLine("Ingrese Cantidad de Meses: ")
        cant_meses = Console.ReadLine()
        capital = cap_inicial

        For i As UShort = 1 To cant_meses
            interes = cap_inicial * (interes_anual / 12)
            capital += saldo
            saldo = capital + interes

            total_interes = total_interes + interes
            Console.WriteLine("Mes {0}", i & " | " & capital & " | " & interes & " | " & saldo)
        Next

        Console.WriteLine("El interes acumulado en todos los meses de es: " & total_interes)
    End Sub
End Module
