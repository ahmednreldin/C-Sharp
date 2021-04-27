using System;

/* 
      in C# to Encapsulate & protect fields  => we use Properties instead of getter&setter
 
       - A property with both get&set accessor is a R/W property
       - A property with only get accessor is a Read only property 
       - A property with only set              a write only property 

    Note : the advatnage of properties over traditional Get() ,Set() method is that 
    you can access them as if they were public fields 

    == AutoImplemented Properties 
    if there is no additional logic in the peroperty accessor then we can use 
    of autoImplemented properties  Name{get;set;}
 */
class Student
{
    private int _id;
    private string _name;

    // AutoImpleneted properties

    public string City { get; set; }
    // compiler will create variable and use this variable to do set&get
    // not need to create field _city , cuz compiler will create anonymous field 
    // that can only be accessed through the property's get&set 


    // Get & set with logic 
    public int Id
    {
        set
        {
            if (value < 0) throw new Exception("ID must be positive number");
            this._id = value;
        }
        get
        {
            return this._id;
        }
    }

    // Get & set w/o logic 
    public string Name { get => _name; set => _name = value; }



}

class Program
    {
        static void Main(string[] args)
        {
        Student s1 = new Student();

        s1.Id = 1;
        Console.WriteLine(s1.Id);
        
        s1.Name = "Ahmed";
        Console.WriteLine(s1.Name);
       
        s1.City = "Minya";
        Console.WriteLine(s1.City);

        }
    }