using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
	interface IUser
	{
		string Name { get; }
		void Step();
		LinkedList<Card> Cards { get; }
		void AddCardToUserDeck(Card card);
	}
}
