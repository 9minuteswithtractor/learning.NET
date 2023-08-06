

namespace AppLogic
{
	public class Method
	{
		// attribute
		private int numberAsInt;

		// constructor
		public Method()
		{
			numberAsInt = 0;
		}

		// methods
		public string GetInput()
		{
			Console.Write("\t: ");

			// optionally => this.numberAsString = Console.ReadLine();
			// then it would be part og object ...then would need to 
			// update main Program class

			string userInput = Console.ReadLine();
			return userInput;

		}

		public bool IsValid(string input)
		{
			// optional 

			// if (input.Equals("end"))
			// {
			// 	return false;
			// }

			// the version below actually could be better as 
			// no need for additional error handling ...

			bool isInt = int.TryParse(input, out this.numberAsInt);
			return isInt;
		}
		public int ConvertStringAsNumber() { return numberAsInt; } // see isVAlid()

		public int CubeNumber(int number)
		{
			return (int)Math.Pow(number, 3);
		}
	}
}
