' Author : Jaydatt Patel
' VB.Net is not case sensitive.

' [ <attributelist> ] [ accessmodifier ] [ Shadows ] [ MustInherit | NotInheritable ] [ Partial ] _
' Class name [ ( Of typelist ) ]
'    [ Inherits classname ]
'    [ Implements interfacenames ]
'    [ statements ]
' End Class

' - attributelist is a list of attributes that apply to the class. Optional.
' - accessmodifier defines the access levels of the class, it has values as - Public, Protected, Friend, Protected Friend and Private. Optional.
' - Shadows indicate that the variable re-declares and hides an identically named element, or set of overloaded elements, in a base class. Optional.
' - MustInherit specifies that the class can be used only as a base class and that you cannot create an object directly from it, i.e., an abstract class. Optional.
' - NotInheritable specifies that the class cannot be used as a base class.
' - Partial indicates a partial definition of the class.
' - Inherits specifies the base class it is inheriting from.
' - Implements specifies the interfaces the class is inheriting from.
Imports System

module ClassModule

    ' base class
    class person

        protected dim name as string
        protected dim age as integer

        'constructor
        public sub new(str as string, ag as integer)
        ' "me" keyword use to point to current instance like 'this' keyword
            me.name = str
            me.age = ag
            Console.WriteLine("Person Object is being created")
        end sub

        'destructor
        protected overrides sub Finalize()  ' overrides destructure 
            Console.WriteLine("Person Object is being deleted")
        end sub

        public overridable function show()  
            console.writeline("{0}, {1}",me.name, me.age)
        end function

    end class

    ' derived class make it notinheritable furthur
    NotInheritable class student : inherits person

        private dim rollnum as integer 
        public dim university as string
        public dim course as string

        public sub new(name as string, age as integer, roll as integer, college as string, crs as string)
            mybase.new(name,age)
            me.rollnum = roll
            me.university = college
            me.course = crs
        end sub

        protected overrides sub Finalize()  ' overrides destructure 
            Console.WriteLine("Student Object is being deleted")
        end sub

        public overrides function show()
            console.writeline("{0}, {1}, {2}, {3}, {4}",me.name, me.age,me.rollnum, me.university, me.course)
        end function

    end class


    public sub main()
        console.writeline("---------------")
        dim per as person = new person("Rahul", 22)
        per.show()

        console.writeline("---------------")
        dim std as student = new student("Amit", 23, 01, "World", "Computer")
        std.show()

        console.writeline("---------------")

    end sub

end module