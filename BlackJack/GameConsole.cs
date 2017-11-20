using System;

namespace BlackJack
{
	// В этом классе собраны все методы общения с пользователем
	class GameConsole
	{

		public static bool IsStartGame()
		{
			Console.Write("Would you like to start the game? [Y/n]: ");
			return Answer();
		}

		public static bool IsContinueGame(string cards, int points)
		{
			Console.Write($"Player's cards: \"{cards}\". The number of points is {points}. Do you want to continue the game? [y/n]: ");
			return Answer();
		}

		public static void WrireResultBeforeExit(string cards, int points)
		{
			Console.WriteLine($"Player's cards: \"{cards}\". The number of points is {points}");
		}

		private static bool Answer() // Этот метод служит для валидации ответа пользователя и приведения его к типу bool
		{
			string answer = Console.ReadLine().ToLower();

			if (answer == "y")
			{
				return true;
			}
			else if (answer == "n")
			{
				return false;
			}
			else
			{
				// Метод Answer будет рекурсивно вызывать себя, пока пользователь не даст корректный ответ
				Console.Write("I don't understand what you mean. Please press \"y\" or \"n\": ");
				return Answer();
			}
		}
	}
}
