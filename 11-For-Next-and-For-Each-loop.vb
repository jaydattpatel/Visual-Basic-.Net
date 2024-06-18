' Author : Jaydatt Patel
' VB.Net is not case sensitive.

Imports System

module forLoops
    sub main() 
        console.writeline("------for-next------")  
        for i As integer = 1 To 5 step 1  
            console.writeline(" I is {0} ", i)  
        next  

        console.writeline("------for-each------")  
        dim arr() as integer = {11, 12, 13, 14, 15}  
        dim obj as integer
  
        for each obj as integer in arr 
            console.writeline("obj is {0}", obj)  
        next  

    end sub
end module