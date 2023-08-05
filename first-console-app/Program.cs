
namespace first_console_app;
using System;
using TellyClass;

class Program
{
    /*  BOBSAYS: refactor this console-app 
    *   [x]  improve code readability 
    *   [x]  implement OOP
    *   [x]  use methods
    */

    static void Main(string[] args)
    {
        Telly stringCounter = new Telly();

        DisplayIntro();

        stringCounter.StartCounting();
        stringCounter.ShowResult();

        DisplayOutro();

        Console.ReadKey();

    }

    static void DisplayIntro()
    {
        Console.WriteLine("\n\tWelcome to string telly!");
        Console.WriteLine("\tEnter string to continue or enter \"end\" to quit");
    }

    static void DisplayOutro()
    {
        Console.WriteLine("\n\tThank You for using our app!");
    }
}
