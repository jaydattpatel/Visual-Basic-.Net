' Author : Jaydatt Patel
' VB.Net is not case sensitive.

' Sub procedures are procedures that do not return any value. The Sub statement is used to declare the name, parameter and the body of a sub procedure.

' [Modifiers] Sub SubName [(ParameterList)] 
'    [Statements]
' End Sub
Imports System

module SubProcedure

    sub proc(num as integer)
        console.writeline(num)
   end sub

    sub main() 
        proc(10)  
    end sub
end module