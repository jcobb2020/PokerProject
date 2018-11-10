using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    enum Suit
    {
        Diamonds,
        Clubs,
        Hearts,
        Spades
    }

    enum Rank
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
    class Card
    {
        private readonly Rank rank;
        private readonly Suit suit;
        public Card(Suit s, Rank r)
        {
            this.rank = r;
            this.suit = s;
        }

        public Rank getRank()
        {
            return this.rank;
        }
        public Suit getSuit()
        {
            return this.suit;
        }
        public void displayCard()
        {
            Console.WriteLine("------");
            Console.WriteLine(this.suit);
            Console.WriteLine(this.rank);
            Console.WriteLine("------");
        }
    }

   
}
