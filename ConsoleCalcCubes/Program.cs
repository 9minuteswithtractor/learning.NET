
/*  code simple console-calculation-app

    [x] - practice spotting code refactor necessaries / options
    [x] - practice OOP
    [x] - practice clean-code
    flow:
        a. take input from user (whole numbers or string - "end" to exit)
        b. calculate and display cube of number
        c. exit app when string "end" is entered
*/

using System;
using AppLogic;

namespace ConsoleCalcCubes
{
    class Program
    {
        static void Main(string[] args)
        {
            // PreStart processes:
            Calculation process = new Calculation();

            DisplayIntro();

            // Main logic
            RunApp(process);

            DisplayOutro();

            // Cleanup tasks ...
            Console.WriteLine("\tExiting app...");
            Console.ReadKey();

        }
        static void DisplayIntro()
        {
            Console.WriteLine("\n\tHi and Welcome to Cubes!");
            Console.WriteLine("\tEnter a whole number for calculation.");
            Console.WriteLine("\tEnter \"end\" to exit app.");
        }

        static void RunApp(Method process)
        {
            string userInput = process.GetInput();
            bool canContinue = process.IsValid(userInput);

            while (canContinue)
            {
                int number = process.GetInt();
                int cubedNumber = process.CubeNumber(number);

                Console.WriteLine("\t" + cubedNumber);

                userInput = process.GetInput();
                canContinue = process.IsValid(userInput);
            }
        }
        static void DisplayOutro()
        {
            Console.WriteLine("\n\tThank You for using our app!");
        }
    }
}
