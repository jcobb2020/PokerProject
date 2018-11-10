using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    enum Hands
    {
        HighCard,
        Pair,
        TwoPairs,
        ThreeOfAKind,
        Straight,
        Flush,
        FourOfAKind,
        StraightFlush
    }
    class Hand
    {
        public Hands type;
        public int value;
        public Card highCard;
        public Rank handHigh;
        public Rank secondHandHigh;
       // private List<Card> handCards;
        
        //public Hand(Player p)
        //{
        //    handCards = p.getCards();
        //}

        public static bool checkIfPair(Player p, List<Card> tableCards)
        {

            List<Card> handCards = p.getCards();
            if (handCards[0].getRank()==handCards[1].getRank())
            {
                //handHigh = handCards[0].getRank();
                return true;
            }
            foreach(Card handCard in handCards)
            {
                foreach(Card tableCard in tableCards)
                {
                    if (handCard.getRank() == tableCard.getRank())
                    {
                        //handHigh = tableCard.getRank();
                        return true;                   
                    }
                }
            }
            return false;
           
        }
        
    }

    
}
