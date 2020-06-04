using System;
using System.Collections.Generic;

namespace CardsGame
{
    public class Player
    {
        private string Name;
        private List<Card> Hand = new List<Card>(){};

        public Player(string name){
            Name = name;
        }

        // Print the players cards
        public void PrintHands() {
            for(int i=0;i<Hand.Count;i++){
                Hand[i].PrintInfo();
            }
        }

        public Card Draw(Deck deck) {
            Card aCard = deck.Deal();
            Hand.Add(aCard);
            return aCard;
        }

        public Card Discard(int index) {
            if(Hand[index] is Card){
                Card aCard = Hand[index];
                Hand.RemoveAt(index);
                return aCard;
            } else {
                return null;
            }
        }
    }
}
