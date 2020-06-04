using System;

namespace CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Player p1 = new Player("p1");
        
            p1.Draw(deck);
            p1.Draw(deck);
            p1.Draw(deck);
            p1.Draw(deck);
            p1.Draw(deck);
            p1.Draw(deck);

            // Print the player's card
            p1.PrintHands();

            Console.WriteLine("*******************");
            p1.Discard(2);
            p1.PrintHands();

        }
    }
}
