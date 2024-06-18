' Author : Jaydatt Patel
' VB.Net is not case sensitive.
'the Exit statement is used to terminate the loop (for, while, do, select case, etc.) or exit the loop and pass control immediately to the next statement of the termination loop.

Imports System

module ExitStatement
    sub main() 
        dim i as integer

        console.writeline("------Exit with for-----")
        for i = 1 to 10 step 1
            if i > 5 then
                exit for ' exit for loop 
            end if 
            console.writeline("i : {0}",i)
        next   

        console.writeline("------Exit with while-----")
        i = 1
        while i < 10
            if i > 5 then
                exit while ' exit while loop 
            end if 
            console.writeline("i : {0}",i)
            i += 1
        end while

        console.writeline("------Exit with do while-----")
        i = 1
        do
            if i > 5 then
                exit do ' exit do while loop 
            end if 
            console.writeline("i : {0}",i)
            i += 1
        loop while i < 10
  
    end sub
end module