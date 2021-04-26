using System;


    class Program
    {
     /*
      * Goto you can either jump to another case statement or to a specific label 
      * warning : using goto is bad programming style , we can should avoid goto by all means ( ex itrative method ) 
      */
        static void Main(string[] args)
        {
        int totalCoffeCost = 0;
        start:
        Console.WriteLine("1-small , 2-Medium , 3-Large");
        int userChoice = int.Parse(Console.ReadLine());

        switch(userChoice)
        {
            case 1:
                totalCoffeCost += 1;
                break;
            case 2:
                totalCoffeCost += 2;
                // you can goto another case e.g goto case1
                break;
            case 3:
                totalCoffeCost += 3;
                break;
            default:
                Console.WriteLine("Your Choice {0} is invalid", userChoice);
                break;
        }

        decision:
        Console.WriteLine("Do you want Another Coffe 0 - Yes or No");

        string userDecision = Console.ReadLine();

        switch(userDecision.ToUpper())
        {
            case "YES":
                goto start; // start label 
            case "NO":
                break;
            default:
                Console.WriteLine("Your choice {0} is invalid ", userDecision);
                goto decision; // decision label 
        }
            

        Console.WriteLine("Thank you for Shopping with us ");
        Console.WriteLine("Bill Amount = {0}",totalCoffeCost);

        }
    }

