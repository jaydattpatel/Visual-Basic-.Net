' Author : Jaydatt Patel
' VB.Net is not case sensitive.

' &	: It is an ampersand symbol that is used to bind two or more operand together. Furthermore, a nonstring operand can also be concatenated with a string variable ( but in that case, Option Strict is on).	Result = Wel & come, Result = Welcome
' +	: It is also used to add or concatenate two number or string.	Result = Wel + come, Result = Welcome

Imports System

module ConcateOperands
    sub main()
        dim a as integer = 10
        dim b as integer = 20
        dim str1 As string = "Wel"  
        dim str2 As string = "come"  
        console.writeline("a & b : {0}", a & b)
        console.writeline("a + b : {0}", a + b)
        console.writeline("str1 & str2 : {0}", str1 & str2)
        console.writeline("str1 + str2 : {0}", str1 + str2)
    end sub
end module