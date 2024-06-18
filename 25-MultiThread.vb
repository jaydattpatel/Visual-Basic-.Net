' Author : Jaydatt Patel
' VB.Net is not case sensitive.

' Method: 
' - Abort() : As the name defines, it is used to terminate the execution of a thread.
' - AllocateDataSlot() : It is used to create a slot for unnamed data on all threads.
' - AllocateNamedDatsSlot() : It is used to create a slot for defined data on all threads.
' - Equals() : It is used to check whether the current and defined thread object are equal.
' - Interrupt() : It is used to interrupt a thread from the Wait, sleep, and join thread state.
' - Join() : It is a synchronization method that stops the calling thread until the execution thread completes.
' - Resume() : As the name suggests, a Resume() method is used to resume a thread that has been suspended.
' - Sleep() : It is used to suspend the currently executing thread for a specified time.
' - Start() : It is used to start the execution of thread or change the state of an ongoing instance.
' - Suspend() : It is used to stop the currently executing thread.

Imports System
Imports System.Threading  

Module Multi_thread  
    private sub fun1()  
        For j as integer = 1 To 10
            console.writeline("+")  
        Next  
        console.writeline("fun1 Completed........")  
    end sub  

    private sub fun2()  
        For j as integer = 1 To 10
            console.writeline("-")  
        Next  
        console.writeline("fun2 Completed........")  
    end sub  

    sub Main(ByVal arg as String())

        dim th1 as Thread = new Thread(new ThreadStart(AddressOf fun1))  
        dim th2 as Thread = new Thread(new ThreadStart(AddressOf fun2))  
        th1.Start()  
        th2.Start()  
        console.writeline("Waiting............")
        th1.Join()
        th2.Join()
        console.writeline("Main Completed........")
         
    end sub  

end Module  