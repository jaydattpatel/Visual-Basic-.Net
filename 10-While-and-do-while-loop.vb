' Author : Jaydatt Patel
' VB.Net is not case sensitive.

Imports System

module whileLoops
    sub main()  
        dim i As integer = 1  

        console.writeline("-----do-while-----")  

        do  
            console.writeline("I is : {0}", i)  
            i = i + 1 
        loop while i <= 5

        i = 1
        console.writeline("-----while-----") 
        while i <= 5
            console.writeline("I is : {0}", i)  
            i = i + 1 
        end while 
    end sub
end module
