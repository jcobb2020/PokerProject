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
        public IList<Card> cards = new List<Card>();
        List<Player> players = new List<Player>();
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

        //public List<Card> dealFlop()
        //{

        //}
       // public List<Card> 

    }
           
}
