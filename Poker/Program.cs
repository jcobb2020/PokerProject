using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();

            //Console.WriteLine("WH");
            Card c = new Card(Suit.Clubs, Rank.Ace);
            //Rank s = c.getRank();
            Console.WriteLine(c.getRank());

            String TestString;
            //createDeck();
            TestString = Console.ReadLine();
            Deck deck1 = new Deck();
            Player A = new Player("Andrzej");
            Player B = new Player("Bartek");
            Player C = new Player("Celina");
            players.Add(A);
            players.Add(B);
            players.Add(C);
            foreach (Player p in players)
            {
                p.deal(deck1);
                p.printPlayer();
            }
            Console.ReadLine();

        }

        
    }
}
