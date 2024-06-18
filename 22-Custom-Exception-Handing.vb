' Author : Jaydatt Patel
' VB.Net is not case sensitive.
'Syntax: 
'           Try
'               [ tryStatements ]
'               [ Exit Try ]
'           [ Catch [ exception [ As type ] ] [ When expression ]
'               [ catchStatements ]
'               [ Exit Try ] ]
'           [ Catch ... ]
'           [ Finally
'               [ FinalStatements ] ]
'           End Try

' System.Exception : Handle all  errors by perticular exception

' ApplicationException : You can also define your own exception. User-defined exception classes are derived from the ApplicationException class.

Imports System

module CustomExceptionModule

    class ageError : inherits ApplicationException
        public sub new(age as integer)
            Mybase.new(string.format("Age not Valid : {0}",age))
        end sub
    end class

    sub validate(age as integer)
        try
           if age < 18 then 
                throw(new ageError(age))
            else
                console.writeline("Age is Valid.")
           end if
        catch err as ageError
           console.writeline("Exception caught: {0}", err)
        finally
           console.writeline("Validation Executed......")
        end try
    end sub

    sub main()
        console.writeline("-------------------------") 
        validate(20)
        console.writeline("-------------------------") 
        validate(15)
        console.writeline("Program Executed Completely")
    end sub
end module