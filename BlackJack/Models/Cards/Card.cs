using System;

namespace BlackJack
{
	class Card : ICard
	{
		private string name;
		private int points;

		public int Points
		{
			get 
			{
				return points;
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
		}

		public Card(string name, int points)
		{
			this.name = name;
			this.points = points;
		}

		public static explicit operator string(Card card)
		{
			return card.name;
		}
	}
}
