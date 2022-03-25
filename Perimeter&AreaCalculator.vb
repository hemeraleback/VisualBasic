Imports System
Module Program

    Public area, perimeter, height, base As Integer

    Sub Main()

        Console.Write("Enter the base: ")
        base = Console.ReadLine()

        Console.Write("Enter the height: ")
        height = Console.ReadLine()

        perimeter = (base + height) * 2
        area = base * height

        Console.WriteLine($"The measure of the perimeter is {perimeter}")
        Console.WriteLine($"The measure of the area is {area}")

    End Sub
    
End Module
