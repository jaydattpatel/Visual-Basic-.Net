Imports System 'System is a Namespace  
Module AreaOfCircle  
    Sub Main()  
        dim radius as Integer
        radius = Integer.Parse(Console.ReadLine())
        Console.WriteLine(System.Math.Round(3.14 * radius * radius , 2))
    End Sub  
End Module  