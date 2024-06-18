' Author : Jaydatt Patel
' VB.Net is not case sensitive.

Imports System
Imports System.Math

Module MathFun
    sub Main()  
        console.writeline("-------------")
        console.writeline("Pi: {0}, Expo: {1}", Math.PI, Math.E) 

        console.writeline("-------------")
        console.writeline("Math.Min(5, 10) : {0}", Math.Min(5, 10))
        console.writeline("Math.Max(5, 10) : {0}", Math.Max(5, 10))

        console.writeline("-------------")
        console.writeline("Math.Round(Math.PI, 2) : {0}", Math.Round(Math.PI, 2) ) '2 for fixed decimal
        console.writeline("Math.Round(2.2) : {0}", Math.Round(2.2))
        console.writeline("Math.Round(2.8) : {0}", Math.Round(2.8))

        console.writeline("-------------")
        console.writeline("Math.Ceiling(2.2) : {0}", Math.Ceiling(2.2))
        console.writeline("Math.Ceiling(2.8) : {0}", Math.Ceiling(2.8))

        console.writeline("-------------")
        console.writeline("Math.Floor(2.2) : {0}", Math.Floor(2.2))
        console.writeline("Math.Floor(2.8) : {0}", Math.Floor(2.8))

        console.writeline("-------------")
        console.writeline("Math.Truncate(2.2) : {0}", Math.Truncate(2.2))
        console.writeline("Math.Truncate(2.8) : {0}", Math.Truncate(2.8))

        console.writeline("-------------")
        console.writeline("Math.Pow(2, 3) : {0}", Math.Pow(2, 3))
        console.writeline("Math.Sqrt(144) : {0}", Math.Sqrt(144))
        console.writeline("Math.Exp(2) : {0}", Math.Exp(2))
        console.writeline("Math.Log(100) : {0}", Math.Log(100))
        console.writeline("Math.Log10(100) : {0}", Math.Log10(100))

        console.writeline("-------------")
        console.writeline("Math.Abs(-10) : {0}", Math.Abs(-10))
        console.writeline("Math.Sign(-10) : {0}", Math.Sign(-10))

    end sub  
end Module  