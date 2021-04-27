using System;


    class Program
    {
        static void Main(string[] args)
        {

        Customer c1 = new Customer
        {
            Gender = Gender.Male,
        };

        Console.WriteLine(c1.Gender);
        
        }
    }

public enum Gender
{
    Male,
    Female,
    Unknown,
}

public class Customer
{
    public Gender Gender { get; set; }
}