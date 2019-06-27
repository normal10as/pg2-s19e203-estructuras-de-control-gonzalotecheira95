Imports System

Module Program
    Enum Operaciones
        Suma = 1
        Resta
        Multiplicacion
        Division
    End Enum

    Sub Main()
        Resultado(Operaciones.Suma, 5, 8)
        Resultado(Operaciones.Resta, 70, 8, 6)
        Resultado(Operaciones.Division, 105, 8, 2)
        Resultado(Operaciones.Multiplicacion, 9, 2, 5, 7)
        Resultado(Operaciones.Division, 100, 2, 2, 7)
    End Sub

    Private Sub Resultado(operaciones As Operaciones, ByRef val1 As Integer, ByRef val2 As Integer)
        'Llamada a funcion por 2 valores
        Select Case operaciones
            Case Operaciones.Suma
                Console.WriteLine(val1 & " + " & val2 & " = " & Calcular(Operaciones.Suma, val1, val2))
            Case Operaciones.Resta
                Console.WriteLine(val1 & " - " & val2 & " = " & Calcular(Operaciones.Resta, val1, val2))
            Case Operaciones.Multiplicacion
                Console.WriteLine(val1 & " x " & val2 & " = " & Calcular(Operaciones.Multiplicacion, val1, val2))
            Case Operaciones.Division
                Console.WriteLine(val1 & " div " & val2 & " = " & Calcular(Operaciones.Division, val1, val2))
        End Select
    End Sub
    Private Sub Resultado(operaciones As Operaciones, ByRef val1 As Integer, ByRef val2 As Integer, ByRef val3 As Integer)
        'Llamada a precedimiento 3 valores
        Select Case operaciones
            Case Operaciones.Suma
                Console.WriteLine(val1 & " + " & val2 & " + " & val3 & " = " & Calcular(Operaciones.Suma, val1, val2, val3))
            Case Operaciones.Resta
                Console.WriteLine(val1 & " - " & val2 & " - " & val3 & " = " & Calcular(Operaciones.Resta, val1, val2, val3))
            Case Operaciones.Multiplicacion
                Console.WriteLine(val1 & " x " & val2 & " x " & val3 & " = " & Calcular(Operaciones.Multiplicacion, val1, val2, val3))
            Case Operaciones.Division
                Console.WriteLine(val1 & " div " & val2 & " div " & val3 & " = " & Calcular(Operaciones.Division, val1, val2, val3))
        End Select
    End Sub
    Private Sub Resultado(operaciones As Operaciones, ByRef val1 As Integer, ByRef val2 As Integer, ByRef val3 As Integer, ByRef val4 As Integer)
        'Llamada a precedimiento 4 valores
        Select Case operaciones
            Case Operaciones.Suma
                Console.WriteLine(val1 & " + " & val2 & " + " & val3 & " + " & " = " & Calcular(Operaciones.Suma, val1, val2, val3, val4))
            Case Operaciones.Resta
                Console.WriteLine(val1 & " - " & val2 & " - " & val3 & " - " & " = " & Calcular(Operaciones.Resta, val1, val2, val3, val4))
            Case Operaciones.Multiplicacion
                Console.WriteLine(val1 & " x " & val2 & " x " & val3 & " x " & val4 & " = " & Calcular(Operaciones.Multiplicacion, val1, val2, val3, val4))
            Case Operaciones.Division
                Console.WriteLine(val1 & " div " & val2 & " div " & val3 & " div " & val4 & " = " & Calcular(Operaciones.Division, val1, val2, val3, val4))
        End Select
    End Sub
    Private Function Calcular(ByRef val1 As Integer, ByRef val2 As Integer) As Decimal
            Dim resultado As Integer
            resultado = val1 + val2
            Return resultado
        End Function
        Private Function Calcular(ByRef opc As Byte, ByRef val1 As Integer, ByRef val2 As Integer) As Decimal
            Dim resultado As Decimal
            Select Case opc
                Case Operaciones.Suma
                    resultado = val1 + val2
                Case Operaciones.Resta
                    resultado = val1 - val2
                Case Operaciones.Multiplicacion
                    resultado = val1 * val2
                Case Operaciones.Division
                    resultado = val1 / val2
            End Select

            Return resultado
        End Function

        Private Function Calcular(ByRef opc As Byte, ByRef val1 As Integer, ByRef val2 As Integer, ByRef val3 As Integer) As Decimal
            Dim resultado As Decimal
            Select Case opc
                Case Operaciones.Suma
                    resultado = val1 + val2 + val3
                Case Operaciones.Resta
                    resultado = val1 - val2 * val3
                Case Operaciones.Multiplicacion
                    resultado = val1 * val2 * val3
                Case Operaciones.Division
                    resultado = val1 / val2 / val3
            End Select

            Return resultado
        End Function
    Private Function Calcular(ByRef opc As Byte, ByRef val1 As Integer, ByRef val2 As Integer, ByRef val3 As Integer, ByRef val4 As Integer) As Decimal
        Dim resultado As Decimal
        Select Case opc
            Case Operaciones.Suma
                resultado = val1 + val2 + val3 + val4
            Case Operaciones.Resta
                resultado = val1 - val2 - val3 - val4
            Case Operaciones.Multiplicacion
                resultado = val1 * val2 * val3 * val4
            Case Operaciones.Division
                resultado = val1 / val2 / val3 / val4
        End Select

        Return resultado
    End Function
End Module
