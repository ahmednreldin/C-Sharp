using System;


    class Program
{
    static void Main(string[] args)
    {
        // foreach deal with collection of iteams that has same data types 

        int[] number = { 1, 2, 3, 4, 5, 6 };

        // define variable as same data type for collection 
        // compile will go to collection of numbers 
        // take first value and put it in => i
        // until collection finish 
        foreach (int i in number)
            Console.WriteLine(i);
        
        // benefit of foreach we don't deal with index 
    }
}
