Imports System

Module Program
    Sub Main(args As String())
        Descuento()
    End Sub

    Sub Descuento()
        Dim cant_prod As UShort, precio_unit As Single
        Dim total As Single, sub_total As Single, descuento As UShort, monto_descontado As Single
        Dim total_descuento As Single, acumu_total As Single, acumu_descuento As Single

        Do
            Console.WriteLine("Ingresar cantidad de Productos(0 para salir): ")
            cant_prod = Console.ReadLine()
            If (cant_prod = 0) Then
                Exit Do
            End If
            Console.WriteLine("Ingresar precio de Productos: ")
            precio_unit = Console.ReadLine()

            sub_total = cant_prod * precio_unit
            Console.WriteLine("El subtotal es de: $" & sub_total)
            descuento = 0
            If cant_prod >= 10 And cant_prod <= 49 Then
                descuento = 5
            ElseIf cant_prod >= 50 And cant_prod <= 249 Then
                descuento = 10
            ElseIf cant_prod >= 250 Then
                descuento = 20
            End If

            monto_descontado = (sub_total * descuento) / 100
            total = sub_total - monto_descontado

            Console.WriteLine("Se desconto un {0}%", descuento)
            Console.WriteLine("El monto descontado es de: $" & monto_descontado)

            total_descuento = sub_total - monto_descontado
            Console.WriteLine("El total con descuento aplicado: " & total_descuento)
            acumu_descuento = acumu_descuento + monto_descontado
            acumu_total = acumu_total + total_descuento
        Loop While (cant_prod <> 0)

        Console.WriteLine("El total de montos descontados por compra es de: " & acumu_descuento)
        Console.WriteLine("El total a pagar es de: $" & acumu_total)

        Console.ReadKey()
    End Sub
End Module
