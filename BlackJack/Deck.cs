using System;

namespace BlackJack
{
	class Deck
	{
		private Card[] deck = new Card[13]; // Создаём массив (колоду) карт

		public Deck()
		{
			for (int i = 0; i < 9; i++)
			{
				deck[i] = new Card($"{i+2}", i+2); // Добавляем в колоду карты с числами (от 2 до 10)
			};

			Card[] deck1 = { new Card("J", 10), new Card("Q", 10), new Card("K", 10), new Card("A", 11) }; // Создаём промежуточный массив с доп. картами
			deck1.CopyTo(deck, 9); // И добавляем его в конец колоды
		}

		// Метод возвращает карту из колоды
		public void GetCards(out Card card)
		{
			Random rnd = new Random();
			card = deck[rnd.Next(0, deck.Length)];
		}
		// Если игрок только начал игру, то должен получить две карты
		public void GetCards(out Card card1, out Card card2)
		{
			Random rnd = new Random();
			card1 = deck[rnd.Next(0, deck.Length)];
			card2 = deck[rnd.Next(0, deck.Length)];
		}
	}
}
