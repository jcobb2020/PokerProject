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
        List<Player> players = new List<Player>();
        Deck deck = new Deck();
        int smallblind;
        



        public void dealCards()
        {
            foreach (Player p in players)
            {
                p.deal(deck);
            }
        }

    }
           
}
