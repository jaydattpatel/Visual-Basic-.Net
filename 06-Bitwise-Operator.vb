' Author : Jaydatt Patel
' VB.Net is not case sensitive.

' And : The And Operator represents, whether both the operands are true; the result is True.	(A And B), result = False
' Or : It is an Or Operator that returns a true value; if anyone operand is true from both the operands.	(A Or B), result = True
' Not : The Not Operator is used to reverse the logical condition. For example, if the operand's logic is True, it reveres the condition and makes it False.	Not A Or Not(A And B) is True
' Xor : It is an Exclusive OR Operator that represents, whether both the expression is true or false, the result is True; otherwise, the result is False.	A Xor B is True
' AndAlso : It is a logical AND Operator that performs short-circuit operation on the variables, and if both the operands are true, the result is True else the result is False.	A AndAlso B = False
' OrElse : It is a logical OR Operator that perform short-circuit operation on Boolean data. If anyone of the operand is true, the result is True else the result is False.	A OrElse B = True
' IsFalse : The IsFalse Operator is used to determine whether an expression is False.	
' IsTrue : The IsTrue Operator is used to determine whether an expression is True.

Imports System

module BitwiseOperators
    sub main()
        dim a as boolean = true
        dim b as boolean = false
        console.writeline("a and b : {0}", a and b)
        console.writeline("a or b : {0}", a or b)
        console.writeline("a xor b : {0}", a xor b)
        console.writeline("not(a and b) : {0}", not (a and b))

    end sub
end module