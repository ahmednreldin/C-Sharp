using System;

    class Program

    {
    // static method v.s instance method [ that not contain static keyword ] 

    static void Main(string[] args)
        {
          //Add(5,4); // Return error cuz method not static
                    // An object reference is required for non-static method 
       // Create object 
        Program NewObject = new Program();
        NewObject.Add(5,4);

        // === if method static ===

        //NewObject.Subtracting(5,2);  //accessed by type name [class name]
        Program.Subtracting(5, 2);

        }




    // Method[akn function ] structure
    // access-modifiers [public -priviate..etc ]  , return type[anyDataType or Void = absence of datatype]  , methodName , Parameters[optional]
    /*
        Method Body 
     */

    // Define instance method 
    public int Add(int firstNum,int secondNum)
    {
        return firstNum + secondNum;
    }

    // define static method
    public static int Subtracting (int firstNum,int secondNum)
    {
        return firstNum - secondNum;
    }

    }
