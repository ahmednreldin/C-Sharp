using System;
/*  
 *  Why use Getter&setter or Properties
 *     Making the class fields public and exposing the external worlds is bad 
 *     as you will not have control over what gets assigned and returned 
 *     
 *    
        Programming languages that doesn't have properties use
        getter and setter methods to encapsulate and protect fields. 
        c# have properties 

    Encapsulation is one of the primary pillars of oop  
 */

class Student
{
    // public modifier 
    public int ID;
    public string Name;
    public int PassMark;

    // Using Getter & setter 
    public void setID(int id)
    {
        if (id < 0) throw new Exception("id should be positive number");
        this.ID = id;
    }
    public int getID()
    {
        return this.ID;
    }

    public void setName(string name)
    {
        if (string.IsNullOrEmpty(name)) this.Name = "No Name";
        else this.Name = name;
    }
    public string getName()
    {
        if (string.IsNullOrEmpty(this.Name)) this.Name =" " ;
            return this.Name;
    }
}
    class Program
    {
        static void Main(string[] args)
        {


        /*      Problem with public fields 
         *      1- id should always be non negative number 
         *      2 - Name Cannot be set to NuLL 
         *      3- IF STUDENT NAME IS MISSING "No Name should be returned ;    
         */
        Student std1 = new Student();
        std1.ID = -101;
        std1.Name = null;
        std1.PassMark = -100;
        Console.WriteLine("ID = {0}, Name = {1} , PassMark = {2}", std1.ID, std1.Name, std1.PassMark);

        // using getter & setter 
        Student std2 = new Student();
        std2.setID(100);
        std2.setName(null);
        Console.WriteLine("ID = {0}, Name = {1} , PassMark", std2.getID(),std2.getName());


    }
}
