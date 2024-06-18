Imports System 'System is a Namespace  
Module OddEven  
  
    Sub Main()  
        dim num as Integer
        num = Integer.Parse(Console.ReadLine())
        If num mod 2 Then
            Console.WriteLine("ODD")
        Else
            Console.WriteLine("EVEN")
        End If
    End Sub  
  
End Module  