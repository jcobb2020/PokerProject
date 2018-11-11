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
        public Hand playerHand; 
        private String name;
        public int money;

        public Player(String playername)
        {
            this.name = playername;
        }

        public void setCard1(Card card)
        {
            this.card1 = card;
        }
        public void setCard2(Card card)
        {
            this.card2 = card;
        }

        public String getName()
        {
            return this.name;
        }

        public List<Card> getCards()
        {
            List < Card > cards = new List<Card>();
            cards.Add(card1);
            cards.Add(card2);
            return cards;
        }
     
        public void printPlayer()
        {
            Console.WriteLine(this.name);
            Console.WriteLine("------");
            Console.WriteLine(this.card1.getSuit());
            Console.WriteLine(this.card1.getRank());
            Console.WriteLine("------");
            Console.WriteLine(this.card2.getSuit());
            Console.WriteLine(this.card2.getRank());
            Console.WriteLine("------");

        }
        public bool comparePlayersCards()
        {
            if (card1.getRank() > card2.getRank())
            {
                return true;
            }
            return false;
        }

    }
}
