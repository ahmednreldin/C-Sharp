using System;

namespace LogicalAndShortCircuitOperator
{
class Program
{
    static void Main(string[] args)
    {
            /* According to - C# 4.0 The Complete Reference by Herbert Schildt

             & - Logical AND Operator
             | - Logical OR Operator

             && - Short Circuited AND Operator
             || - Short Circuited OR Operator*/

            int x = 10, y = 20;
            if (x == 10 | y == 20) Console.WriteLine("x 1 "); //  the | operator checks each and every operand
            if (x == 10 || y == 20) Console.WriteLine("x 2"); // || checks only the first operand.

            // The same case applies to '&&' in C#.

            if (x == 10 & y == 20) Console.WriteLine("x == y"); // return x==y and this is wrong
            if (y == 10 & y == 10) Console.WriteLine("y == x "); // will not return y==x cuz it will check first operand


            /* As you might notice for 'AND &&' operations any operand which is false will evaluate the whole expression
             * to false irrespective of any other operands value in the expression. 
             * This short circuited 
             * form helps evaluate the first part 
             * and is smart enough to know if the second part will be necessary*/

/*
            This is slightly different than C or C++ where '&' and '| '
            were bitwise AND and OR operators. 
             However C# also applies the bitwise nature of & and | for int variables only.
 */

        }
    }
}
