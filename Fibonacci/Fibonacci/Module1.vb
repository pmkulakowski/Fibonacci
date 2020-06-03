Module Module1


    Sub Main()
        Dim x As Integer
        Console.Write("Program oblicza Ciab Fibonacciego")
        Console.Write("Podaj cyfre: ")
        x = Console.ReadLine()
        Console.WriteLine("Metoda iteracyjna")
        Console.WriteLine(x & " element ciagu wynosi: " & Fibb(x))
        Console.WriteLine("Metoda pobierania wczesniej zapisanych elementow z listy")
        Console.WriteLine(x & " element ciagu wynosi: " & Fibb2(x))

        Console.ReadKey()
    End Sub


    'max for n = 92
    Function Fibb(ByVal n As Integer) As ULong

        Dim a As ULong = 0
        Dim b As ULong = 1

        For i As Integer = 0 To n - 1
            Dim temp As ULong = a
            a = b
            b = temp + b
        Next

        Return a

    End Function

    ' max for n=93
    Function Fibb2(ByVal n As Integer) As ULong

        Dim f As New List(Of ULong)
        Dim wynik As ULong

        f.Add(0)
        f.Add(1)

        If n >= 2 Then
            For i As Integer = 2 To n
                wynik = f(i - 2) + f(i - 1)
                f.Add(wynik)
            Next
        End If

        Return f(n)

    End Function

End Module
