Imports System 'System is a Namespace  
Module Factorial  
    Function fact(n As Integer) As Integer
        If (n = 0) Or (n = 1) Then
            Return 1
        Else 
            Return n * fact(n-1)
        End If
    End Function
    
    Sub Main()
        dim num As Integer
        dim factorial As Integer
        num = Integer.Parse(Console.ReadLine())
        factorial = fact(num)
        Console.WriteLine(factorial)  
    End Sub  
  
End Module  
