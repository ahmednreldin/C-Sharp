using System;

    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please , Enter Your FirstName");
            string fname = Console.ReadLine(); //ReadLine method return data of type string 
            Console.WriteLine("Please , Enter Your LastName");
            string lname = Console.ReadLine(); //ReadLine method return data of type string 
           // Ways to Write to console  Method
           // Method 1 [ Concatination ]  {aka Concatination format }
        Console.WriteLine("Hello " + fname + " "  + lname);
        // Method 2 using placeholder {0} {aka String format }
            Console.WriteLine("Hello {0} {1}", fname, lname);


        // Placeholder is more used the difference is almost entirely about readability

    }
}

