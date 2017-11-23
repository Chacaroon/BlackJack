using System;

namespace BlackJack
{
	class StartPoint
	{
		public static void Start()
		{
			if (GameConsole.IsStartGame())
			{
				Table game = new Table(); // Creating a Game Instance
				game.Start(); // Started game
				Start(); // When the player finishes the game, he will be prompted to start again
			}
			else
			{
				Exit();
			}
		}

		public static void Exit()
		{
			Console.WriteLine("Godbye");
			Console.ReadLine();
		}
	}
}
