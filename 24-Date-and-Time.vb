' Author : Jaydatt Patel
' VB.Net is not case sensitive.

Imports System
Imports System.DateTime

module DateNTime  
    sub Main()  
        console.writeline("------------------------------------")
        dim DefaultDT as DateTime = New DateTime()  
        console.writeline("Default Date and Time is :{0}", DefaultDT)  
        console.writeline() 

        console.writeline("------------------------------------")
        ' To get the Max Value of DateTime  
        dim MAXDT as DateTime = DateTime.MaxValue  
        console.writeline(" Max value of Date and Time is {0}", MAXDT)  
        ' To get the Min Value of DateTime  
        dim MinDT as DateTime = DateTime.MinValue  
        console.writeline(" Min value of Date and Time is {0}", MinDT)   
          
        console.writeline("------------------------------------")
        console.writeline(" Different function of DateTime: ")  
        dim DT as DateTime = New Date(1998, 9, 7, 12, 22, 30)  '(year,month,day,hour,min,sec)
        console.writeline(" Day is : {0}", DT.Day)  
        console.writeline(" Month is : {0}", DT.Month)  
        console.writeline(" Year is : {0}", DT.Year)  
        console.writeline(" Hour is : {0}", DT.Hour)  
        console.writeline(" Minute is : {0}", DT.Minute)  
        console.writeline(" Second is : {0}", DT.Second)  
        console.writeline(" Day of Week is : {0}", DT.DayOfWeek)  
        console.writeline(" Day Of year is : {0}", DT.DayOfYear)  
        console.writeline(" Time of Day is : {0}", DT.TimeOfDay)  
 

        console.writeline("------------------------------------")
        dim CT as DateTime = DateTime.now ' Use of Now  
        console.writeline(" Current Date and Time is {0}", CT)   
        dim UT as DateTime = DateTime.UTCNow ' Use of UtcNow  
        console.writeline(" Current UtC Date and Time Zone is {0}", UT)  

        console.writeline("------------------------------------")
        dim DOB as DateTime = new DateTime() 
        DOB = "1990-02-15"
        dim age as TimeSpan = DateTime.now - DOB  
        console.writeline("Age : {0}", Math.Floor(age.Days / 365))  
        console.writeline("Days: {0} days , Hours : {1}", age.TotalDays, age.TotalHours)  
  
    end sub
end module