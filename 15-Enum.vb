' Author : Jaydatt Patel
' VB.Net is not case sensitive.

Imports System

module EnumVar
    enum Number   
        One  
        Two = 2 
        Three  
        Four = 4
        Five  
        Six  
    End Enum  

    sub main() 
        console.writeline("Number.One : {0}", Number.One)  
        console.writeline("Number.Two : {0}", cint(Number.Two))  
        console.writeline("Number.Three : {0}", Number.Three)  
        console.writeline("Number.Four : {0}", cint(Number.Four))  
        console.writeline("Number.Five : {0}", Number.Five)  
        console.writeline("Number.Six : {0}", Number.Six)  
    end sub
end module