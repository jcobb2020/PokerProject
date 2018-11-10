using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    enum Options
    {
        Check,
        Bet,
        Fold
        
    }
    class Round
    {
        public List<Card> tableCards = new List<Card>();
        public List<Player> players = new List<Player>();
        Deck deck = new Deck();
        int smallBlind;
        int bigBling;


        public void dealCards()
        {
            foreach (Player p in players)
            {
                deck.dealToPlayer(p);
            }
        }

        public void addPlayers(List<Player> players)
        {
            foreach (Player p in players)
            {
                Console.WriteLine("do yo want to add " + p.getName() + "?");
                string response = Console.ReadLine();
                if (response == "y")
                {
                    this.players.Add(p);
                }
            }
        }

        //public void play()
        //{
        //    addPlayers(Program.)
        //}

        public void dealFlop()
        {
            this.tableCards = deck.dealFlop();
        }
        public void displayRound() {
            foreach (Player p in players)    //displays cards and names of all players
            {
                p.printPlayer();
            }
        }

        public void displayTableCards()    //displays all current cards on the table
        {
            foreach(Card c in tableCards)
            {
                c.displayCard();
            }
        }
        // public List<Card> 
        public bool compare(Player p)
        {
            List<Card> handCards = p.getCards();
            if (handCards[0].getRank() > handCards[1].getRank())
            {
                return true;
            }
            return false;
        }
    }
           
}
