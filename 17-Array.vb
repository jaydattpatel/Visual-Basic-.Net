' Author : Jaydatt Patel
' VB.Net is not case sensitive.

' Array.length
' Array.Clear(array as Array, index as Integer, length as Integer)
' Array.Copy(sourceArray as Array, destinationArray as Array, length as Integer)
' ArraySource.CopyTo(arrayDesti as Array, index as Integer)
' Array.IndexOf(array as Array,value as Object)
' Array.Reverse(array as Array)
' ArrayObj.SetValue(value as Object, index as Integer)
' Array.Sort(array as Array)

Imports System

module ArrayModule
    sub show(arr as integer())
        for each x as integer in arr
            console.write("{0}, ",x)
        next
    end sub

    sub main() 
        console.writeline(vbLf & "------1-----")
        dim numArr() as Integer = New Integer() {1, 2, 3, 4, 5, 6} 
        console.writeline("numArr.length : {0}", numArr.length)
 
        for each x as integer in numArr
            console.write("{0}, ",x)
        next

        console.writeline(vbLf & "-----2------")
        dim charArr() as Char = {"A", "B", "C", "D", "E"} 
        for each x as char in charArr
            console.write("{0}, ",x)
        next

        console.writeline(vbLf & "-----3------")
        dim strArr() as String = {"Peter", "John", "Brock", "James", "Maria"}  
        for each x as string in strArr
            console.write("{0}, ",x)
        next

        console.writeline(vbLf & "-----4------")
        dim objArr() as Object = {"Hello","World", 2024}  
        for each x as object in objArr
            console.write("{0}, ",x)
        next

        console.writeline(vbLf & "-----5------")
        dim arr1 as integer() = {1, 2, 3, 4, 5}
        Array.Clear(arr1, 1, 3) ' Clears elements starting from index 1 up to 3 elements
        show(arr1)
        ' Resulting array: {1, 0, 0, 0, 5}

        console.writeline(vbLf & "-----6------")
        dim arr2 as integer() = {1, 2, 3, 4, 5}
        Array.Clear(arr2, 1, 3) ' Clears elements starting from index 1 up to 3 elements
        show(arr2)
        ' Resulting array: {1, 0, 0, 0, 5}

        console.writeline(vbLf & "-----7------")
        dim source as integer() = {1, 2, 3}
        dim destination(3) as integer
        source.CopyTo(destination, 0)
        ' Resulting destination array: {1, 2, 3}

        console.writeline(vbLf & "-----8------")
        dim arr3 as integer() = {10, 20, 30, 40, 50}
        dim index as integer = Array.IndexOf(arr3, 30)
        show(arr3)
        ' index will be 2

        console.writeline(vbLf & "-----9------")
        dim arr4 as integer() = {1, 2, 3, 4, 5}
        Array.Reverse(arr4)
        show(arr4)
        ' Resulting array: {5, 4, 3, 2, 1}

        console.writeline(vbLf & "-----10------")
        dim arr5 as integer() = {1, 2, 3}
        arr5.SetValue(10, 1)
        show(arr5)
        ' Resulting array: {1, 10, 3}

        console.writeline(vbLf & "-----11------")
        dim arr6 as integer() = {5, 3, 1, 4, 2}
        Array.Sort(arr6)
        show(arr6)
        ' Resulting array: {1, 2, 3, 4, 5}

    end sub
end module

