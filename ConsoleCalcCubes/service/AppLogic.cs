

namespace AppLogic
{
	public class Calculation
	{
		// attribute
		private int numberAsInt;

		// constructor
		public Calculation()
		{
			numberAsInt = 0;
		}

		// methods
		public string GetInput()
		{
			Console.Write("\t: ");
			string userInput = Console.ReadLine();
			return userInput;
		}

		public bool IsValid(string input)
		{
			bool isInt = int.TryParse(input, out this.numberAsInt);
			return isInt;
		}
		public int GetInt() { return numberAsInt; }

		public int CubeNumber(int number)
		{
			return (int)Math.Pow(number, 3);
		}
	}
}
