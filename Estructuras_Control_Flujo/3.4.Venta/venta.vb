Imports System

Module Program
    Sub Main()
        Dim cantidad, precio_unitario, monto_descontado As Integer
        Dim total_productos As Integer = 0

        Console.WriteLine("Ingrese la cantidad de productos: ")
        cantidad = Console.ReadLine()
        Console.WriteLine("Ingrese el precio del producto: ")
        precio_unitario = Console.ReadLine()
        total_productos = cantidad * precio_unitario

        Console.WriteLine("El subtotal es de: $" & total_productos)

        If cantidad > 9 And cantidad < 51 Then
            Console.WriteLine("Se desconto el %5")
            monto_descontado = (total_productos * 5) / 100
        ElseIf cantidad > 50 And cantidad < 251 Then
            Console.WriteLine("Se desconto el 10%")
            monto_descontado = (total_productos * 10) / 100
        ElseIf cantidad > 250 Then
            Console.WriteLine("Se desconto el 20%")
            monto_descontado = (total_productos * 15) / 100
        End If

        Console.WriteLine("El monto descontado es de: $" & monto_descontado)
        Console.WriteLine("El total a pagar es de: $" & (total_productos - monto_descontado))
    End Sub
End Module