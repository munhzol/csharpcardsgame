using System;
using System.Collections.Generic;

namespace CardsGame
{
    public class Deck
    {   
        public List<Card> Cards = new List<Card>(){};
        private string[] CardNames = {"Ace","2","3","4","5","6","7","8","9","10","Jack","Queen","King"};
        private string[] Suits = {"Clubs", "Spades", "Hearts", "Diamonds"};

        public Deck() {
            Reset();
            // Show();
            // Console.WriteLine("*****************************************");
            Shuffle();
            // Show();
        }

        public Card Deal() {
            if(Cards.Count==0)
                return null;
            Card aCard = Cards[Cards.Count-1];
            Cards.RemoveAt(Cards.Count-1);
            return aCard;
        }

        public void Show() {
            foreach(Card card in Cards){
                card.PrintInfo();
            }
        }

        public void Reset() {
            Card aCard;
            for(int i=0;i<Suits.Length;i++){
                for(int j=0;j<CardNames.Length;j++){
                    aCard = new Card(CardNames[j],Suits[i],j+1); 
                    Cards.Add(aCard);
                }   
            }
        }

        public void Shuffle() {
            List<Card> aNewCards = new List<Card>();
            Random rand = new Random();

            while(Cards.Count>0){
                int r = rand.Next(0,Cards.Count);
                aNewCards.Add(Cards[r]);
                Cards.RemoveAt(r);
            }
            
            Cards = aNewCards;
        }

    }
}
