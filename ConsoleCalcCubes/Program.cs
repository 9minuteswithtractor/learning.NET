
/*  bobsays: code simple console-calculation-app
    [ ] - follow app requirements
    [ ] - code simple version first to test app flow and logic
    [ ] - practice OOP
    [ ] - practice clean-code
    flow:
        a. take input from user (whole numbers or string - "end" to exit)
        b. calculate and display cube of number
        c. exit app when string "end" is entered
*/

using System;

namespace ConsoleCalcCubes
{
    class Program
    {
        static void Main(string[] args)
        {
            //INTRO 
            Console.WriteLine("\n\tHi and Welcome to Cubes!");
            Console.WriteLine("\tEnter a whole number for calculation.");
            Console.WriteLine("\tEnter \"end\" to exit app.");

            // LOGIC
            while (true)
            {
                Console.Write("\t: ");
                string userInput = Console.ReadLine();

                if (userInput.Equals("end"))
                {
                    break;
                }

                int result = (int)Math.Pow(int.Parse(userInput), 3);
                Console.WriteLine("\t" + result);
            }

            //OUTRO
            Console.WriteLine("\n\tThank You for using our app!");
            Console.ReadKey();

        }
    }
}
