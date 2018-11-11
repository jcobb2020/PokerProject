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
        FullHouse,
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
        public Rank kicker;
        private List<Card> cards = new List<Card>();
        

        //public Hand(Player p)
        //{
        //    handCards = p.getCards();
        //}

        public Hand(Player p, List<Card> tableCards)
        {
            cards = p.getCards();
            foreach(Card c in tableCards)
            {
                cards.Add(c);
            }           
        }
        

       
        public void checkIfPairThreeFourFull()
        {
            int count = 1;
            int countSame1 = 1;
            Rank rankSame1 = new Rank();
            int countSame2 = 1;
            Rank rankSame2 = new Rank();
            int countSame3 = 1;
            Rank rankSame3 = new Rank();


            for(int i=0; i<6; i++)
            {
                while(cards[i].getSuit() == cards[i + 1].getSuit())
                {
                    count++;
                    i++;
                }
                if (countSame1 >1)
                {
                    if (countSame2 > 1)
                    {
                        countSame3 = count;
                        rankSame3 = cards[i].getRank();
                    }
                    else
                    {
                        countSame2 = count;
                        rankSame2 = cards[i].getRank();
                    }
                }
                else
                {
                    countSame1 = count;
                    rankSame1 = cards[i].getRank();
                }
                count = 1;                                                  
            }
            swapCounts(countSame3, countSame1, rankSame3, rankSame1);
            swapCounts(countSame2, countSame1, rankSame2, rankSame1);
            swapCounts(countSame3, countSame2, rankSame3, rankSame2);

            if (countSame1 == 4)
            {
                this.type = Hands.FourOfAKind;
                handHigh = rankSame1;
            }
            else if(countSame1 == 3)
            {
                if(countSame2 > 1)
                {
                    this.type = Hands.FullHouse;
                    this.handHigh = rankSame1;
                    this.secondHandHigh = rankSame2;
                }
                else
                {
                    this.type = Hands.ThreeOfAKind;
                    this.handHigh = rankSame1;
                }
            }
            else if(countSame1 == 2)
            {
                this.handHigh = rankSame1;
                this.type = Hands.Pair;
                if(countSame2== 2)
                {
                    this.secondHandHigh = rankSame2;
                    this.type = Hands.TwoPairs;
                }
            }
            else
            {
                this.type = Hands.HighCard;
            }
        }

        void swap(int a, int b, Rank rA, Rank rB)
        {
            int c = a;
            a = b;
            b = c;
            Rank rC = rA;
            rA = rB;
            rB = rA;
        }

        void swapCounts(int a, int b, Rank rA, Rank rB)   //swap bigger with smaller
        {
            if (a > b)
            {
                swap(a, b, rA, rB);
            }
            else if (a == b)
            {
                if (rA > rB)
                {
                    swap(a, b, rA, rB);
                }
            }
        }

        private void sortHand()
        {
            int size;
            List<Card> SortedCards = new List<Card>();
            size = this.cards.Count();
            Card smallest = this.cards[0];
            for (int j = 0; j < 5; j++)
            {
                smallest = this.cards[0];
                for (int i = 0; i < size; i++)
                {
                    if (this.cards[i].getRank() < smallest.getRank())
                    {
                        smallest = this.cards[i];
                    }
                    else if (this.cards[i].getRank() == smallest.getRank())
                    {
                        if (this.cards[i].getSuit() < smallest.getSuit())
                        {
                            smallest = this.cards[i];
                        }
                    }
                }
                SortedCards.Add(smallest);
                this.cards.Remove(smallest);
                size--;
            }
            this.cards = SortedCards;
        }
        public void displayHand()
        {
            this.sortHand();
            foreach (Card c in cards)
            {
                c.displayCard();
            }
        }
        //public void getHighiestCard()
    }
}
