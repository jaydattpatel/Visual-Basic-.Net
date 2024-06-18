' Author : Jaydatt Patel
' VB.Net is not case sensitive.

Imports System

module IOConsole
    sub main()
        dim num as integer
        dim float as double
        dim ch as char
        dim bool as boolean
        dim str as string
        
        console.writeline("Enter integer : ")
        num = integer.parse(console.readline())
        console.writeline("Enter double : ")
        float = double.parse(console.readline())
        console.writeline("Enter character : ")
        ch = console.readline()
        console.writeline("Enter boolean (True or False) : ")
        bool = boolean.parse(console.readline())
        console.writeline("Enter String : ")
        str = console.readline()

        console.writeline("{0} , {1}, {2}, {3}, {4}", num, float,ch,bool,str)

        console.writeline("Enter any key to exit...........")
        console.readkey()
        
    end sub
end module