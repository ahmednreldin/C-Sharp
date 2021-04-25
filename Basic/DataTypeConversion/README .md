
# DataType Conversion  

- Implicit Conversion
- Explicit Conversion
- difference between Parse(),TryParse()


## Implicit

- Implicit Conversion is done by Compiler

used when 
1- there is no loss of information 
2- there is no possibility of throwing exeption during Conversion

Example  


## Usage/Examples
convert int to float will not loose any data and no exception will be thrown 
hance an implicit conversion can be done 
```C#
int x = 100;
float y = x;
Console.WriteLine(y);

```

when converting a flot to an int , we loose the fractional part 
and also a possiblity of overflow exeption 
in this case an Explicit conversion is required 








## String Conversion 

Parse() , tryParse ()


        // If number is string format 
        string num = "123";
        // == method 1 == Parse 
        int numParse = int.Parse(num);
       /* Console.WriteLine(numParse);*/

        // Drawback of this method if string contain letter  
        num = "123ggg"; //string contain letters
        /*numParse = int.Parse(num); // return exeption 
        Console.WriteLine(numParse);*/

        // == Method 2 == tryParse => solve problem of exception  return bool indicating if conversion done or fail
        int result=0;
        bool isConversionDone = int.TryParse(num, out result); // return type of bool  ,, setting new conversion in => out variable

        if (isConversionDone) Console.WriteLine("Conversion Done");
        if (!isConversionDone) Console.WriteLine("Conversion Fail");
                       
        // Use Parse if sure the value will be valid 
       
  