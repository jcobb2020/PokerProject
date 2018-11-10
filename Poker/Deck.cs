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


    }
}
