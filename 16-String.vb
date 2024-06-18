' Author : Jaydatt Patel
' VB.Net is not case sensitive.

Imports System

module StringFunctions

    sub main() 
        dim str1, str2, str3 as string

        console.writeline("-------1-------")
        str1 = "Hello"
        str2 = "World"
        console.writeline("{0} {1}", str1, str2)   

        console.writeline("-------2-------")
        ' get length of string
        str3 = str1 + " " + str2
        console.writeline(str3.length)     

        console.writeline("-------3-------")
        ' string copy
        str3 = string.copy(str1)
        console.writeline(str3)  

        console.writeline("-------4-------")
        ' iterate using index 
        For i as integer = 0 To str3.Length - 1
            console.writeline(str3(i))  
        Next   

        console.writeline("-------5-------")
        ' convert to upper and lower case
        console.writeline("str3.toupper : {0}", str3.toupper)  
        console.writeline("str3.tolower : {0}", str3.tolower)  


        console.writeline("-------6-------")
        ' string compare
        console.writeline("string.compare(str1,str2) : {0}",string.compare(str1,str2))

        console.writeline("-------7-------")
        ' get substring (start index, count)
        str3 = "Welcome to VB.NET Language."
        str3 = str3.substring(11,6)
        console.writeline(str3)


        console.writeline("-------8-------")
        ' string contains check
        str3 = "Welcome to VB.NET Language."
        console.writeline("str3.cointains('vb.net') : {0}",str3.contains("vb.net"))
        console.writeline("str3.cointains('VB.NET') : {0}",str3.contains("VB.NET"))

        console.writeline("-------9-------")
        ' find indexof string
        str3 = "Welcome to VB.NET Language."
        console.writeline("str3.indexof('VB') : {0}",str3.indexof("VB"))

        console.writeline("-------10-------")
        ' insert string
        str3 = "Welcome to .NET Language."
        console.writeline("str3.insert(11,'VB'): {0}", str3.insert(11,"VB"))

        console.writeline("-------11-------")
        ' replace string
        str3 = "Welcome to .NET Language."
        console.writeline("str3.('Language','Programming'): {0}", str3.replace("Language","Programming"))

        console.writeline("-------12-------")
        dim chararr1() as char = {"$","@","&","#"}
        str3 = "   Hello World  "
        console.writeline("str3.trim() : {0}", str3.trim())
        str3 = "$$##  VB.NET  &&&@@@"
        console.writeline("str3.trim(chararr) : {0}", str3.trim(chararr1))


        console.writeline("-------13-------")
        ' Char to String
         dim chararr2() as char= {"2", "0", "2", "4"} 
        str3 = new string(chararr2)
        console.writeline(str3)

        console.writeline("-------14-------")
        ' Join strings
        dim stringarr() as string = {"Welcome", "To", "VB.Net"}
        str3 = string.join("-",stringarr)
        console.writeline(str3) 

        console.writeline("-------15-------")
        ' split strings
        str3 = "Welcome-To-VB.Net-2024"
        stringarr = str3.split("-")
        for each obj as string in stringarr
            console.writeline(obj) 
        next

        console.writeline("-------16-------")
        ' String formate
        dim time as datetime = new date(2024, 6, 18, 18, 48, 2)  
        str3 = string.format("String Format {0:t}  {0:D}", time)    
        console.writeline(str3) 

    end sub
end module

