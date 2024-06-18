' Author : Jaydatt Patel
' VB.Net is not case sensitive.
'Syntax: 
'           Try
'               [ tryStatements ]
'               [ Exit Try ]
'           [ Catch [ exception [ As type ] ] [ When expression ]
'               [ catchStatements ]
'               [ Exit Try ] ]
'           [ Catch ... ]
'           [ Finally
'               [ FinalStatements ] ]
'           End Try

' System.Exception : Handle all  errors by perticular exception

' System.IO.IOException : Handles I/O errors.
' System.IndexOutOfRangeException : Handles errors generated when a method refers to an array index out of range.
' System.ArrayTypeMismatchException : Handles errors generated when type is mismatched with the array type.
' System.NullReferenceException : Handles errors generated from deferencing a null object.
' System.DivideByZeroException : Handles errors generated from dividing a dividend with zero.
' System.InvalidCastException : Handles errors generated during typecasting.
' System.OutOfMemoryException : Handles errors generated from insufficient free memory.
' System.StackOverflowException : Handles errors generated from stack overflow.

Imports System

module ExceptionModule

    sub divide(num1 as integer,num2 as integer)
        dim result as integer
        try
           result = num1 \ num2
           console.writeline("Result: {0}", result)
        catch err as DivideByZeroException
           console.writeline("Exception caught: {0}", err)
        finally
           console.writeline("divide Executed......")
        end try
    end sub
 
    Sub allHnadleFun()  
        dim str as string = Nothing
        try  
            if str.Length > 0 Then ' it thows and exception  
                console.writeline("String is {0}", str)  
            end if  
        catch ex as exception  ' it cacthes an exception  
            console.writeline(" Catch exception in a proram : {0}", ex)  
        finally
            console.writeline("allHnadleFun Executed......")
        end try
    End Sub  

    sub main()
        console.writeline("-------------------------") 
        divide(10,0)  
        console.writeline("-------------------------") 
        allHnadleFun()
        console.writeline("-------------------------") 
        console.writeline("Program Executed Completely")
    end sub
end module