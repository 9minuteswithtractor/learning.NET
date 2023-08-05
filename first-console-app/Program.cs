
namespace first_console_app;
using System;
using TellyClass;

class Program
{
    /*  BOBSAYS: refactor this console-app 
    *   [ ]  improve code readability 
    *   [ ]  implement OOP
    *   [ ]  use methods
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
