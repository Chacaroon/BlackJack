using System;
using System.Text.RegularExpressions;

namespace BlackJack
{
	// In this class, all ways to communicate with the user
	class GameConsole
	{
		public static bool IsStartGame()
		{
			Console.Write("Would you like to start the game? [y/n]: ");
			return Answer();
		}

		public static int UsersCount()
		{
			Console.Write("How many players will participate? (1 to 6): ");
			return IntValidator();
		}

		public static string GetName()
		{
			Console.Write("Set a name for the new user: ");
			string name = Console.ReadLine();
			if (Regex.IsMatch(name, @"\S+"))
			{
				return name;
			}
			else
			{
				return "Unnamed";
			}
		}

		public static bool IsGetCard(string cards, int points)
		{
			Console.Write($"Cards: {cards} \nPoints: {points} \nWould you like to take a card? [y/n]: ");
			return Answer();
		}

		public static void Win(string name)
		{
			Console.WriteLine($"{name} won!");
		}

		public static void Lose(string name)
		{
			Console.WriteLine($"{name} lose!");
		}

		public static void WriteResult(string cards, int points)
		{
			Console.WriteLine($"Cards: {cards} \nPoints: {points}");
		}

		private static bool Answer() // This method is used to check the user's response and transfer it to the bool type
		{
			string answer = Console.ReadLine().ToLower();

			if (answer == "y")
			{
				return true;
			}
			if (answer == "n")
			{
				return false;
			}
			// The Answer method will be recursively called until the user gives a correct answer
			Console.Write("I don't understand what you mean. Please press \"y\" or \"n\": ");
			return Answer();
		}

		private static int IntValidator()
		{
			string count = Console.ReadLine();

			if (Int32.TryParse(count, out int result) && result > 0 && result <= 6)
			{
				return result;
			}
			else
			{
				Console.Write("Enter a number between 1 and 6: ");
				return IntValidator();
			}
		}
	}
}
