
namespace TellyClass
{
    public class Telly
    {
        // attributes
        private int stringCount;

        // constructor
        public Telly()
        {
            stringCount = 0;
        }

        // getter
        public int GetCount()
        {
            return stringCount;
        }

        // logic
        public void StartCounting()
        {
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
        }
        public void ShowResult()
        {
            Console.WriteLine("\tString count: " + stringCount);

        }
    }
}
