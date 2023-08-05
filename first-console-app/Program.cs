
namespace first_console_app;
using System;

class Program
{
    /*  BOBSAYS: create simple console-app 
    *   [x]  take input from user
    *   [x]  increment string-counter whenever user enters a string
    *   [x]  display string count when user enters "end"
    */

    static void Main(string[] args)
    {
        int stringCount = 0;

        Console.WriteLine("\n\tWelcome to string telly!");
        Console.WriteLine("\tEnter string to continue or enter \"end\" to quit");

        while (true)
        {
            Console.Write("\t: ");
            string userInput = Console.ReadLine();

            if (userInput.Equals("end"))
            {
                break;
            }
            stringCount++;
        }

        Console.WriteLine("\tString count: " + stringCount);
        Console.WriteLine("\n\tThank You for using our app!");
        Console.ReadKey();
    }
}
