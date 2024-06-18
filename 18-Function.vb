' Author : Jaydatt Patel
' VB.Net is not case sensitive.

' The Function statement is used to declare the name, parameter and the body of a function. The syntax for the Function statement is −

' [Modifiers] Function FunctionName [(ParameterList)] As ReturnType
'    [Statements]
' End Function

Imports System

module Fun

    function factorial(num as integer) as integer
        dim result as integer
        If (num = 1) Then
           Return 1
        Else
           return factorial(num - 1) * num
        End If
   End Function

    sub main() 
        console.writeline("Factorial : {0}",factorial(10))  
    end sub
end module