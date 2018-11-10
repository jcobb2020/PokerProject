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
