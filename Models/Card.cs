using System;

namespace CardsGame
{
    public class Card
    {   
        private string StringVal;
        private string Suit;
        private int Val;

        public Card(string stringVal, string suit, int val) {
            Suit = suit;
            Val = val;
            StringVal = stringVal;
            // Console.WriteLine($"{StringVal} - {Suit} - {Val}");

        }

        public string Info() {
            return ($"{StringVal} {Suit}");
        }

        public void PrintInfo() {
            Console.WriteLine($"{StringVal} - {Suit} - {Val}");
        }

    }
}
