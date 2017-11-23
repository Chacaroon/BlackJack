using System.Collections.Generic;

namespace BlackJack
{
	class Table
	{
		private Deck deck = new Deck(); // Creates a new deck of cards
		private User user;

		public Table()
		{
			User user = new User(GameConsole.GetName()); // Creates a new player
			user.GetCard += GiveCardToUser;
			user.Winner += UserWin;
			user.Loser += UserLose;

			this.user = user;
		}

		public void Start()
		{
			user.Step();
		}

		// Events handlers
		private void GiveCardToUser(User user)
		{
			user.AddCardToUserDeck(deck.DistributeCard());
		}

		private void UserWin(User user)
		{
			GameConsole.Win(user.Name);
		}

		private void UserLose(User user)
		{
			GameConsole.Lose(user.Name);
		}
	}
}
