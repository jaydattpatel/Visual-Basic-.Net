' Author : Jaydatt Patel
' VB.Net is not case sensitive.

' ^	: It is an exponentiation Operator that is used to raises one operand to the power of another operand.	Y ^ X (X to the power Y)
' + : The addition Operator is used to add numeric data, as well as concatenate two string variables.	X + Y
' -	: It is a subtraction Operator, which is used to subtract the second operand from the first operand.	X - Y
' *	: The multiplication Operator is used to multiply the operands	X * Y
' /	: It is a division Operator used to divide one operand by another operand and returns a floating-point result.	X / Y
' \	: It is an integer division Operator, which is similar to division Operator, except that it returns an integer result while dividing one operand to another operand.	X \ Y
' Mod : It is a modulo (Modulus) Operator, which is used to divide two operands and returns only a remainder.	X Mod Y

Imports System

module ArithmeticOperators
    sub main()

    dim a as integer = 5
    dim b as integer = 2
    console.writeline("a/b : {0}", a/b)
    console.writeline("a\b : {0}", a\b)
    console.writeline("a mod b : {0}", a mod b)
    console.writeline("a^b : {0}", a^b)

    end sub
end module