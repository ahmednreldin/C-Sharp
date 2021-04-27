using System;
/* 
        if A Class inherits from 2 interface & both the interface have the same method name 
        How should the class implement the method for both the interfaces ? 
        - using explicit interface implementation technique to solve this problem 
=> note when a class explicity implements , an interface member , the interface member can 
no longer be accessed though class reference variable but only thru the interface reverence variable 

        - Access modifiers are not allowd on explicity implemented interface members 

       == if we want to make one of interface method the defualt , then implement that method noramlly 
and the orther interface method explicity , this makes the defualt method to be accessible thru class instance
 */

interface I1
{
    void Print();
}
interface I2
{
    void Print();
}
class Program : I1,I2

    {
        static void Main(string[] args)
        {
        Program p = new Program();
        //        p.Print();
        //called by casting
        ((I1)p).Print();
        ((I2)p).Print();
        // or using reference 
        I1 pp = new Program();
        pp.Print();

        // or using defualt implementation // define one method as defult 
    
    }

    // which one will be called ?? 
    /*public void Print()
    {
        Console.WriteLine("Interface called ");
    }*/
    // 
     void I1.Print()
    {
        Console.WriteLine("Interface ONE called ");
    }
     void I2.Print()
    {
        Console.WriteLine("Interface TWO called ");
    }

}
