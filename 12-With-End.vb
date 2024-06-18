' Author : Jaydatt Patel
' VB.Net is not case sensitive.

Imports System

module Withend
    class Student  
       public name as string
       public course as string  
       public rollno as integer  
    end class  

    sub main() 
        dim std as new Student()  
  
        ' To define the member of an object using With Statement  
        with std  
            .name = " Mr. Jaydatt"  
            .course = "Computer"  
            .rollno = 1 
        end with  
          
        with std  
            ' use std as a reference  
            console.writeline("Name is : {0}", .name)  
            console.writeline("Course Name is : {0}", .course)  
            console.writeline("RollNo. is : {0}", .rollno)  
        end with
 
    end sub
end module