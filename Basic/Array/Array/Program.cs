using System;


    class Program
    {
        static void Main(string[] args)
        {

        // Array => An array is a collection of simillar datatype
        // Declaring Array 
        int[] EvenNumber = new int[3]; // define size of array as 3 element start from zero to 2

        // Assign Value
        EvenNumber[0] = 0;
        EvenNumber[1] = 2; 
        EvenNumber[2] = 4; 
    
    
        Console.WriteLine(EvenNumber[2]);

        // Advantage of array [ array are Strongly typed ] all value same data type

        //EvenNumber[2] = "Number four"; // return an error  

        //DisAdvantage of array 
        // 1 - Arrays cannot grow in size once initialized  [ static size ]
        //EvenNumber[3] = 6; //  return expetion outOfRange 
        // 2 - Access by integerValue => index 

    }
}