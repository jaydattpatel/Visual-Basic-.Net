' Author : Jaydatt Patel
' VB.Net is not case sensitive.

Imports System

module IfElseStatement
    sub main()
        dim a,b,c as integer
        a = 5
        b = 10
        c = 8

        if a > b  and a > c then 
            console.writeline("Max: {0}",a)
        elseif b > a and b > c then
            console.writeline("Max: {0}",b)
        else 
            console.writeline("Max: {0}",c)
        end if ' end if statement

    end sub
end module