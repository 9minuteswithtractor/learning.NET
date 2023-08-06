
/*  bobsays: code simple console-calculation-app

    [ ] - practice spotting code refactor necessaries / options
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
            //INTRO refactor : DisplayIntro()
            Console.WriteLine("\n\tHi and Welcome to Cubes!");
            Console.WriteLine("\tEnter a whole number for calculation.");
            Console.WriteLine("\tEnter \"end\" to exit app.");
            ////////////////////////////////////////////////////////////

            // LOGIC : create class/classes with methods for getting number,
            //          checking, converting, calculating result
            while (true)  /// LOOP method? if we gonna reuse it ...
            {
                Console.Write("\t: ");
                string userInput = Console.ReadLine();

                // refactor: ValidateInput() ////////
                if (userInput.Equals("end"))
                {
                    break;
                }
                //////////////////////////////////////

                // refactor: ConvertToNumber(), CalculateCube(), DisplayResult()
                int result = (int)Math.Pow(int.Parse(userInput), 3);
                Console.WriteLine("\t" + result);
            }

            //refactor:  DisplayOutro() ///////////////////////////
            Console.WriteLine("\n\tThank You for using our app!");
            ////////////////////////////////////////////////////////
            Console.ReadKey();

        }
    }
}
