using System;
/* 
    == Structs == 
just like clasess structs can have
1- private Fields 
2- Public Properties
3- Constructors 
4 - Methods 
*/

struct Student
{

    // Fields ( private ) 
    private int _id;
    private string _name;

    // Properties
    public int Id { get => _id; set => _id = value; }
    public string Name { get => _name; set => _name = value; }

    // Constructor 
    public Student(int id , string name)
    {
        this._id = id;
        this._name = name;
    }

    // Methods
    public void print()
    {
        Console.WriteLine("Student ID {0} \nName{1}", this._id, this._name);
    }
}
    class Program
    {
        static void Main(string[] args)
        {

        Student s1 = new Student(1, "Ahmed");
        Student s2 = new(2, "Mo");
        s2.print();

        // object initializer syntax
        Student s3 = new Student{
            Id = 3,
            Name = "Hossam"
        };

    }
    }
