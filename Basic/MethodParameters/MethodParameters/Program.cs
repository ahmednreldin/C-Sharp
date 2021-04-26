using System;

/*
 * Parameters Type 
    Value Parameters [PassByValue] = i,j pointing to different memory location , operation on one will not effect on other
    Reference Parameters [passByReference] = x,y pointing to the same memory location , operation will be related
    out Parameters => used when you want a method to return more than one value 
    Parameter Arrays : 

    params keyword => lets you specify a method parameter that takes a variable number of arguments 
    parms keyword should be the last one  
    only a parms keyword is premitted in a method decleration 
    parms should be one dimension array

    Method Parameters v.s method Arguments 

    when declear a method (this value here called parameters)

    when call a method (this value pass here called arguments)
 */
namespace MethodParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            passByValue(i);
            Console.WriteLine("pass by value function i = {0}", i);

            int x = 0;
            passByReference(ref x);
            Console.WriteLine("pass by Reference function x = {0}", x);

            // out Parameters 
            int resultSum = 0;
            int resultMultiply = 0;
            Add(5, 2, out resultSum, out resultMultiply);
            Console.WriteLine("Sum result = {0} \nMultiplyResult = {1}", resultSum, resultMultiply);

            // pass array
            int[] numbers = { 1, 2, 3, 4, 5 };
            Print(numbers);

            // parms [ optional arg] one dimension array 
            ParmsMethod(numbers);

        }

        static void passByValue(int j)
        {
            j = 100;
        }

        static void passByReference (ref int y )
        {
            y = 500;
        }

       // if we didnt use return , must type be void 
        static void Add(int firstNum,int secondNum,out int sum , out int multiply)
        {
            sum = firstNum + secondNum;
            multiply = firstNum * secondNum;
        }
        // print values of array 
        static void Print(int []nums)
        {
            Console.WriteLine("there are {0} elements", nums.Length);
            foreach(int i in nums)
            {
                Console.WriteLine(i);
            }
        }

        // Method with Parms [ optional args ]  parms must be a single dimension array 
        static void ParmsMethod(int[] array1 ,params int[] array2 )
        {
            if (array1.Length > 1) Console.WriteLine("array one add");
            if (array2.Length > 1) Console.WriteLine("array two add");
        }

    }
}
