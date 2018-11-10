using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    class Player
    {
        private Card card1;
        private Card card2;
        private String name;
        public int money;

        public Player(String playername)
        {
            this.name = playername;
        }

        public void deal(Deck D)
        {
            Random rnd = new Random();
            int size = D.cards.Count();
            int cardToDeal = rnd.Next(0, size);
            size--;
            this.card1 = D.cards[cardToDeal];
            D.cards.Remove(D.cards[cardToDeal]);
            cardToDeal = rnd.Next(0, size);
            size--;
            this.card2 = D.cards[cardToDeal];
            D.cards.Remove(D.cards[cardToDeal]);
        }
        public void printPlayer()
        {
            Console.WriteLine(this.name);
            Console.WriteLine(this.card1.GetSuit());
            Console.WriteLine(this.card1.getRank());
            Console.WriteLine(this.card2.GetSuit());
            Console.WriteLine(this.card2.getRank());
        }
    }


}
