using System;

namespace BlackJack
{
	class GameCopy
	{
		private int points = 0;
		private string cards = "";
		private Deck deck = new Deck();

		public void FirstStep()
		{
			deck.GetCards(out Card card1, out Card card2); // Взять две карты из колоды
			points += card1.Points + card2.Points;
			cards += $"{card1.Name} {card2.Name}";

			if (GameConsole.IsContinueGame(cards, points)) // Предложить игроку продолжить игру или сдаться
			{
				NextStep();
			}
			else
			{
				return;
			}
		}

		public void NextStep()
		{
			deck.GetCards(out Card card);
			points += card.Points;
			cards += $" {card.Name}";

			if (points <= 21 && GameConsole.IsContinueGame(cards, points))
			{
				NextStep();
			}
			else
			{
				GameConsole.WrireResultBeforeExit(cards, points);
				return;
			}
		}
	}
}
