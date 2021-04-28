using System;
using System.Collections.Generic;

/*
        Attribute [] Allow you to add declarative infromation to your programs, this information can then be queried at runtime using reflection.
 There are severel pre-defined Attributes provided by .net , also possible to use your own Custom Attributes 
ex [Obsolete]
Obsolete => marks types and type member outdated
WebMethod => to expose a mthod as an XML Web Service method
Seriializable => indicates that a class can be serialized 

it as possible to customize the attribute using parameters 
an atrribute is a class that inheirts from System.Attribute base class 
 */
class Program
    {
        static void Main(string[] args)
        {

        Calculator c1 = new Calculator();

        c1.Add(2, 5);
        c1.Add(new List<int> { 1, 2, 3, 4, 5, 6 });
        }
    }

class  Calculator
{
    #region outOfDataFunction
    //[Obsolete]
    // pass parameters 
    //[Obsolete("This function is outofdata use public int Add(List<int> ls) ")]
    // restrict developers from use it 
    [Obsolete("function ou tofdata",true)]
    public int Add(int firstNum,int secondNum)
    {
        return firstNum + secondNum;
    }
    #endregion
    #region newVersionFunctionAddMultipleNumber
    public int Add(List<int> ls)
    {
        int sum = 0;
        foreach(int num in ls)
        {
            sum += num;
        }
        return sum;
    }
    #endregion

}