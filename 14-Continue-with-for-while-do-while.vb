' Author : Jaydatt Patel
' VB.Net is not case sensitive.
'the continue statement is used to skip the particular iteration of the loop and continue with the next iteration. Generally, the continue Statement is written inside the body of the For, While and Do While loop with a condition. 

Imports System

module ContinueStatement
    sub main() 
        dim i as integer

        console.writeline("------continue with for-----")
        for i = 1 to 10 step 1
            if i mod 2 then
                continue for ' continue for loop 
            end if 
            console.writeline("i : {0}",i)
        next   

        console.writeline("------continue with while-----")
        i = 0
        while i < 10 
            i += 1
            if i mod 2 then
                continue while ' continue while loop 
            end if 
            console.writeline("i : {0}",i)
        end while

        console.writeline("------continue with do while-----")
        i = 0
        do
            i += 1
            if i mod 2 then
                continue do ' continue do while loop 
            end if 
            console.writeline("i : {0}",i)
            
        loop while i < 10
  
    end sub
end module