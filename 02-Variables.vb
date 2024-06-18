' Author : Jaydatt Patel
' VB.Net is not case sensitive.

Imports System

module Variables
    sub main()
        dim num as integer = 10
        dim float as double = 3.14
        dim ch as char = "C"
        dim bool as boolean = True
        dim str as string = "Hello"
        
        console.writeline("{0} , {1}, {2}, {3}, {4}", num, float,ch,bool,str)
    end sub
end module