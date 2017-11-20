using System;

namespace BlackJack
{
	class StartPoint
	{
		public static void Start()
		{
			if (GameConsole.IsStartGame())
			{
				Console.WriteLine("Start game");
				GameCopy game = new GameCopy(); // Создание сессии игры
				game.FirstStep(); // Запуск игры
				Start(); // Когда игрок закончит игру ему отобразится предложение начать заново
			}
			else
				Exit();
		}

		public static void Exit()
		{
			Console.WriteLine("Godbye");
			Console.ReadLine();
		}
	}
}
