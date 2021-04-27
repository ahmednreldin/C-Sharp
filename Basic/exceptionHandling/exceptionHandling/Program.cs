using System;
using System.IO;

class Program
    {
        static void Main(string[] args)
        {
        StreamReader sr = null;
        try
        {
             sr = new StreamReader(@"D:\C#\data.txt");

            string readAllFile = sr.ReadToEnd();

            Console.WriteLine(readAllFile);
        }
        catch (Exception ex) {
            Console.WriteLine(ex.Message);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(ex.StackTrace);
        }
        finally
        {   // Clean&free resources that the class was holding onto during the program execution , finally block gurnanted to execute whether there exception or not 
            if (sr != null)
            {
                sr.Close();
            }
        }
        }
    }
