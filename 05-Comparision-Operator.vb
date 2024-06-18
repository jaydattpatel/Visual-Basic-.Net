' Author : Jaydatt Patel
' VB.Net is not case sensitive.

' =	: It checks whether the value of the two operands is equal; If yes, it returns a true value, otherwise it shows False.	(A = B)
' <> : It is a Non-Equality Operator that checks whether the value of the two operands is not equal; it returns true; otherwise, it shows false.	(A <> B), check Non-Equality
' >	: A greater than symbol or Operator is used to determine whether the value of the left operand is greater than the value of the right operand; If the condition is true, it returns TRUE; otherwise, it shows FALSE value.	(A > B); if yes, TRUE, Else FALSE
' <	: It is a less than symbol which checks whether the value of the left operand is less than the value of the right operand; If the condition is true, it returns TRUE; otherwise, it shows FALSE value.	(A < B); if the condition is true, returns TRUE else FALSE
' >= : It is greater than equal to which checks two conditions whether the first operand is greater than or equal to the second operand; if yes, it returns TRUE; otherwise, it shows False.	A >= B
' <= : This symbol represents less than equal to which determines the first operand is less than or equal to the second operand, and if the condition is true, it returns TRUE; otherwise, it shows FALSE.	A <= B
' Is : The Is Operator is used to validate whether the two objects reference the same variable or object; If the test is true, it returns True; otherwise, the result is False. In short, it checks the equality of the objects. An Is Operator is also used to determine whether the object refers to a valid object.	result = obj1 Is obj2
' IsNot : The IsNot Operator is similar to Is Operator, except that the two object references the different object; if yes, the result is True; otherwise, the result is False.	Result = obj1 IsNot obj2
' Like :The Like Operator is used to check the pattern expression of string variable; And if the pattern matched, the result is True; otherwise, it returns False.	result = string Like the pattern, the pattern represents the series of characters used by Like Operator.

Imports System

module ComparisionOperators
    sub main()

        dim x as integer = 5  
        dim y as integer = 10  
        dim result, obj1, obj2 as object  
        dim str1, str2 as string  
        str1 = "Apple12345"  
        str2 = "Apple12345"  
        obj1 = 10  
        obj2 = 20

        Console.WriteLine("x = y : {0}", x = y)
        Console.WriteLine("x <> y : {0}", x <> y)

        Console.WriteLine("obj1 = obj2 : {0}", obj1 = obj2)
        Console.WriteLine("obj1 is obj2 : {0}", obj1 is obj2)
        Console.WriteLine("obj1 isnot obj2 : {0}", obj1 isnot obj2)

        Console.WriteLine("str1 = str2 : {0}", str1 = str2)
        Console.WriteLine("str1 is str2 : {0}", str1 is str2)

        result = str1 Like str2  
        Console.WriteLine("str1 Like str2 : {0}", Result)  


    end sub
end module