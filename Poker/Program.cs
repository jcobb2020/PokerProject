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
            Round round1 = new Round();
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
            round1.addPlayers(players);
            round1.dealCards();
            round1.dealFlop();
            round1.displayRound();
            round1.displayTableCards();
            if (round1.compare(A)){
                Console.WriteLine("first cart of player one is bigger than second");
            }
            foreach(Player p in round1.players)
            {
                if(Hand.checkIfPair(p, round1.tableCards))
                {
                    Console.WriteLine(p.getName() + " has a pair");
                }
            }
            
            Console.ReadLine();

        }

        
    }
}
