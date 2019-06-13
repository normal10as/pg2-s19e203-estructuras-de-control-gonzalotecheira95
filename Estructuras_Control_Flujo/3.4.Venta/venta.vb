Imports System

Module Program
    Sub Main()
        Dim cantidad, descuento, precio_unitario, monto_descontado As Integer
        Dim total_productos As Integer = 0

        Console.WriteLine("Ingrese la cantidad de productos: ")
        cantidad = Console.ReadLine()
        Console.WriteLine("Ingrese el precio del producto: ")
        precio_unitario = Console.ReadLine()
        total_productos = cantidad * precio_unitario
        Console.WriteLine("El subtotal es de: $" & total_productos)

        If cantidad > 9 And cantidad < 51 Then
            descuento = 5
        ElseIf cantidad > 50 And cantidad < 251 Then
            descuento = 10
        ElseIf cantidad > 250 Then
            descuento = 20
        End If

        monto_descontado = (total_productos * descuento) / 100
        Console.WriteLine("Se desconto un {0}%", descuento)
        Console.WriteLine("El monto descontado es de: $" & monto_descontado)
        Console.WriteLine("El total a pagar es de: $" & (total_productos - monto_descontado))
    End Sub
End Module