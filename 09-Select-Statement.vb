' Author : Jaydatt Patel
' VB.Net is not case sensitive.

Imports System

module SelectCase  

    sub Main()  
        dim Days as string  
        Days = "Thurs"  
        select case Days  
            case "Mon"  
                Console.WriteLine("Monday")  
            case "Tue"  
                Console.WriteLine("Tuesday")  
            case "Wed"  
                Console.WriteLine("Wednesday")  
            case "Thurs"  
                Console.WriteLine("Thursday")  
            case "Fri"  
                Console.WriteLine("Friday")  
            case "Sat"  
                Console.WriteLine("Saturday")  
            case "Sun"  
                Console.WriteLine("Sunday")  
            case else  
                Console.WriteLine("Invalid Input")  
        end select 
    end sub  
end module  