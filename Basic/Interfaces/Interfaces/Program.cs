using System;

/* 
    we create interfaces using interface keyword , just like classes interfaces also can contains 
    [ properites , methods , delegates , events ]
    - but only declarations and no implementation 
    
    its a compile error to provide implementation for any interface member 
    
    - interfaces member are public by defualt 
    - interfaces cannot contain fields
    - if a [class - struct ] inherits from an interface 
=> it must provide implementation for all interface members , otherwise we get a compiler error 
    - A [ class,struct ] can inherit from more than one interface at the same time 
=> note a class cannot inhirt from more than once class at the same time 
    - Interfaces can inheirt from other interfaces , A Class that inherits this interface must provide 
implementation for all interface members in the intire interface inheritance chain 

we cannot create an instance of an interface 
=> but an interface reference variable can point to an derived class object 

==> Interface Naming Conversion Interface names a prefixed with Capital I
 */

interface IStudent
{
    public void Print();

    // int _id; // interfaces cannot contain fields
}
// FirstYear doesn't implement interface members
/*class FirstYear : IStudent
{
}*/

class FirstYear : IStudent
{
    public void Print()
    { 
    }
}
//   - A [ class,struct ] can inherit from more than one interface at the same time 

interface I1 { } 
interface I2 { }
class Employee : I1, I2 { };
//- Interfaces can inheirt from other interfaces , A Class that inherits this interface must provide 
//implementation for all interface members in the intire interface inheritance chain 

interface IOne {
    void Print1();
} 
interface ITwo { 
    void Print2();
}

class Numbers : IOne, ITwo
{
    public void Print1()
    {
    }

    public void Print2()
    {
    }
}


class Program
    {
        static void Main(string[] args)
        {
        //we cannot create an instance of an interface 
        //  I1 newInterface = new I1();
        // but an interface reference variable can point to an derived class object 
        I1 newInterface = new Employee();
        
    
    }

    }
