' Author : Jaydatt Patel
' VB.Net is not case sensitive.

' File : It is used to perform some changes in files.
' FileInfo : It is used to perform any operation on files.
' FileStream : It is used to apply read or write operations on any location of a file.
' BinaryReader : as the name represents, a Binary reader is used to read primitive data in a binary stream.
' BinaryWriter : It is used to write the data in binary format.
' Directory : It is used to perform some changes or manipulating a directory structure.
' DriveInfo	: It helps to provide the necessary information for the drive.
' BuffredStream : It is a temporary storage area for the collection of steam bytes.
' MemoryStream : It is used to access stored streaming data in memory.
' StreamReader : A StreamReader property is used to read characters from the stream byte.
' Path : It is used to perform operations on the path of a file.
' StreamWriter : A StreamWriter is used to write characters to a stream.
' DirectoryInfo : It is used to perform an operation on the directory.
' StringReader : It is used to read string from a string buffer.

Imports System
Imports System.IO  

module BinWriter  
    sub Main()  
        dim FileWrite as FileStream = new FileStream("File.txt", FileMode.OpenOrCreate, FileAccess.Write)  
        dim wtr as new BinaryWriter(FileWrite)  
        wtr.Write("Welcome to VB.NET" )  
        wtr.Write(3.14)  
        wtr.Write(123)  
        wtr.Close()  
        FileWrite.Close()  

        dim FileRead as FileStream = new FileStream("File.txt", FileMode.Open, FileAccess.Read)  
        dim rdr as new BinaryReader(FileRead)  
        dim str as string = rdr.ReadString()  
        dim float as double = rdr.ReadDouble()  
        dim val as integer = rdr.ReadInt32()  
        console.writeline("{0}",str)  
        console.writeline("{0}",float)  
        console.writeline("{0}",val)  
        rdr.Close()  
        FileRead.Close()  

    end sub
end module
