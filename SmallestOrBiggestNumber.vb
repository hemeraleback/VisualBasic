Module Program
    Public num1, num2 As Double
    Sub Main()

        Console.Write("Enter the first number: ")
        num1 = Console.ReadLine()

        Console.Write("Enter the second number: ")
        num2 = Console.ReadLine()

        If num1 > num2 Then
            Console.Write($"The biggest number is {num1} {vbCrLf}The smallest number is {num2}")
        Else
            Console.Write($"The biggest number is {num2} {vbCrLf}The smallest number is {num1}")
        End If
    End Sub
End Module
