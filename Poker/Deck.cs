using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    class Deck
    {
        public IList<Card> cards = new List<Card>();
        private int size = 54;
        public Random rnd = new Random();

        public Deck()
        {
            this.createDeck();
        }

        public void createDeck()
        {
            string TestString;
            int count = 0;

               
            foreach (string suit in Enum.GetNames(typeof(Suit)))
            {

                foreach (string rank in Enum.GetNames(typeof(Rank)))
                {
                    //Suit s;
                    //Rank r;
                    Enum.TryParse(suit, out Suit s);
                    Enum.TryParse(rank, out Rank r);
                    this.cards.Add(new Card(s, r));
                    //Console.WriteLine(cards[count].GetSuit());
                    //count++;
                    //TestString = Console.ReadLine();
                }


            }
            //for (int i = 0; i < count; i++)
            //{
            //    Console.WriteLine(cards[0].GetSuit());
            //}
        }
        public void dealToPlayer(Player p)
        {
            size = this.cards.Count();
            int cardToDeal = rnd.Next(0, size);
            size--;
            p.setCard1(this.cards[cardToDeal]);
            this.cards.Remove(this.cards[cardToDeal]);
            cardToDeal = rnd.Next(0, size);
            size--;
            p.setCard2(this.cards[cardToDeal]);
            this.cards.Remove(this.cards[cardToDeal]);
        }
    
        public List<Card> dealFlop()
        {
            List<Card> tableCards = new List<Card>();
            for (int i = 0; i < 3; i++)
            {
                int cardToAdd = rnd.Next(0, size);
                tableCards.Add(this.cards[cardToAdd]);
                cards.Remove(this.cards[cardToAdd]);
                size--;
            }
            return tableCards;
        }

        public void dealTurnOrRiver (List<Card> flop)
        {
            int cardToAdd = rnd.Next(0, size);
            flop.Add(this.cards[cardToAdd]);
            cards.Remove(this.cards[cardToAdd]);
            size--;
        }


    }
}
