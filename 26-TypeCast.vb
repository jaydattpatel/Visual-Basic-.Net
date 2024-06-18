' Author : Jaydatt Patel
' VB.Net is not case sensitive.

' CBool(expression): It is used to convert an expression into a Boolean data type.
' CByte(expression): It is used to convert an expression to a Byte data type.
' CChar(expression): It is used to convert an expression to a Char data type.
' CDate(expression): It is used to convert an expression to a Date data type.
' CDbl(expression): It is used to convert an expression into a Double data type.
' CDec(expression): It is used to convert an expression into a Decimal data type.
' CInt(expression): It is used to convert an expression to an Integer data type.
' CLng(expression): It is used to convert an expression to a Long data type.
' CObj(expression): It is used to convert an expression to an Object data type.
' CSByte(expression): It is used to convert an expression to an SByte data type.
' CShort(expression): It is used to convert an expression to a Short data type.
' CSng(expression): It is used to convert an expression into a Single data type.
' CStr(expression): It is used to convert an expression into a String data type.
' CUInt(expression): It is used to convert an expression to a UInt data type.
' CULng(expression): It is used to convert an expression to a ULng data type.
' CUShort(expression): It is used to convert an expression into a UShort data type.

Imports System

module Typecast
    sub Main()
        ' dim num as string = "123"
        ' console.writeline("IsNumeric(num) : {0}",IsNumeric(num))

        
        console.writeline("---------------------CStr() for convert to String--------")
        console.writeline("{0} : {1} , {2} : {3}",(123) , (123).getType(), CStr(123), CStr(123).getType())
        console.writeline("{0} : {1} , {2} : {3}",(3.14) , (3.14).getType(), CStr(3.14), CStr(3.14).getType())
        console.writeline("{0} : {1} , {2} : {3}",(true) , (true).getType(), CStr(true), CStr(true).getType())
        console.writeline("{0} : {1} , {2} : {3}",(false) , (false).getType(), CStr(false), CStr(false).getType())

        console.writeline("---------------------CInt() for convert to Integer--------")
        console.writeline("{0} : {1} , {2} : {3}",("-123") , ("-123").getType(), CInt("-123"), CInt("-123").getType())
        console.writeline("{0} : {1} , {2} : {3}",(3.14) , (3.14).getType(), CInt(3.14), CInt(3.14).getType())
        console.writeline("{0} : {1} , {2} : {3}",(true) , (true).getType(), CInt(true), CInt(true).getType())
        console.writeline("{0} : {1} , {2} : {3}",(false) , (false).getType(), CInt(false), CInt(false).getType())

        console.writeline("---------------------CDbl() for convert to Double--------")
        console.writeline("{0} : {1} , {2} : {3}",("-3.14") , ("-3.14").getType(), CDbl("-3.14"), CDbl("-3.14").getType())
        console.writeline("{0} : {1} , {2} : {3}",(123) , (123).getType(), CDbl(123), CDbl(123).getType())
        console.writeline("{0} : {1} , {2} : {3}",(true) , (true).getType(), CDbl(true), CDbl(true).getType())
        console.writeline("{0} : {1} , {2} : {3}",(false) , (false).getType(), CDbl(false), CDbl(false).getType())

        
    end sub
end module