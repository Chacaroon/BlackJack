using System;
using System.Collections.Generic;

namespace BlackJack
{
	class Deck : IDeck
	{
		private Dictionary<int, Card> deck = new Dictionary<int, Card>(); // Creating an array of cards
		private Random rnd = new Random();

		public Deck()
		{
			for (int i = 0; i < 9; i++)
			{
				deck.Add(i, new Card($"{i+2}", i+2)); // Add to the deck cards with numbers (from 2 to 10)
			}

			deck.Add(9, new Card("J", 10));
			deck.Add(10, new Card("Q", 10));
			deck.Add(11, new Card("K", 10));
			deck.Add(12, new Card("A", 11));
		}

		// The method returns a random card from the deck
		public Card DistributeCard()
		{
			return deck[rnd.Next(0, deck.Count)];
		}
	}
}
