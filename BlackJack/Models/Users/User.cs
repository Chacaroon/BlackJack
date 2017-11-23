using System;
using System.Collections.Generic;

namespace BlackJack
{
	class User : IUser
	{
		protected string name; // Username
		protected int points; // Total number of player points
		protected string cards; // Name of cards

		// Events
		public delegate void UserDeckHandler(User user);
		public event UserDeckHandler GetCard; // Add a card to the player's deck

		public delegate void GameProcess(User user);
		public event GameProcess Winner;
		public event GameProcess Loser;

		public string Name {
			get
			{
				return name;
			}
		}
		public LinkedList<Card> Cards { get; private set; } = new LinkedList<Card>(); // User's deck
		
		public User(string name)
		{
			this.name = name;
		}

		public void Step()
		{
			if (points == 0) // First call Step
			{
				GetCard(this);
				GetCard(this);
			}
			
			if (points > 21)
			{
				GameConsole.WriteResult(cards, points);
				Loser(this);
				return;
			}

			if (points == 21)
			{
				GameConsole.WriteResult(cards, points);
				Winner(this);
				return;
			}

			if (GameConsole.IsGetCard(cards, points))
			{
				GetCard(this);
				Step();
			}
			else
			{
				Loser(this);
			}
		}

		// The method adds a card to the deck of the player and updates the total number of points
		public void AddCardToUserDeck(Card card)
		{
			points += card.Points;
			cards += (string)card + " ";
			Cards.AddLast(card);
		}
	}
}
