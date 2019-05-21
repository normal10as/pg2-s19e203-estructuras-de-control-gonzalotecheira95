Imports System

Module Program
    Enum meses
        Enero = 1
        Febrero
        Marzo
        Abril
        Mayo
        Junio
        Julio
        Agosto
        Septiembre
        Octubre
        Noviembre
        Diciembre
    End Enum
    Sub Main()
        Dim ingreso As Byte
        Dim anio As Short

        Console.WriteLine("Ingrese un ano")
        anio = Console.ReadLine()
        Console.WriteLine("Ingrese un numero para ver a que mes corresponde: ")
        ingreso = Console.ReadLine()

        Select Case ingreso
            Case meses.Enero
                Console.WriteLine("El mes corresponde a Enero.")
            Case meses.Febrero
                If Bisiesto(anio) Then
                    Console.WriteLine("El mes de Febrero tiene 29 dias por ser Bisiesto")
                Else
                    Console.WriteLine("El mes de Febrero tiene 28 dias por no ser Bisiesto")
                End If
            Case meses.Marzo
                    Console.WriteLine("El mes corresponde a Marzo.")
            Case meses.Abril
                Console.WriteLine("El mes corresponde a Abril.")
            Case meses.Mayo
                Console.WriteLine("El mes corresponde a Mayo.")
            Case meses.Junio
                Console.WriteLine("El mes corresponde a Junio")
            Case meses.Julio
                Console.WriteLine("El mes corresponde a Julio.")
            Case meses.Agosto
                Console.WriteLine("El mes corresponde a Agosto.")
            Case meses.Septiembre
                Console.WriteLine("El mes corresponde a Septiembre.")
            Case meses.Octubre
                Console.WriteLine("El mes corresponde a Octubre.")
            Case meses.Noviembre
                Console.WriteLine("El mes corresponde a Noviembre.")
            Case meses.Diciembre
                Console.WriteLine("El mes corresponde a Diciembre.")
            Case Else
                Console.WriteLine("El numero ingresado no corresponde a ningun mes.")
        End Select
    End Sub
    Private Function Bisiesto(ByRef numero As Integer) As Boolean
        If numero Mod 4 = 0 Then
            If (numero Mod 100 = 0) And Not (numero Mod 400 = 0) Then
                Bisiesto = False
            Else
                Bisiesto = True
            End If
        End If
        Return Bisiesto
    End Function

End Module