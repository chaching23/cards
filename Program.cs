using System;
using System.Collections.Generic;


namespace cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck newDeck = new Deck();
            newDeck.shuffle();

            Player kian = new Player("kiannnn");
            kian.draw(newDeck);
            kian.draw(newDeck);
            kian.draw(newDeck);
            
            kian.discard(2);


        }
         class Card
        {
            public string stringVal;
            public string suit;
            public int val;

            public Card(String stringVal, String suit, int val){
                this.stringVal = stringVal;
                this.suit = suit;
                this.val =val;
            }
        }
        class Deck
        {
            public List<Card> cards
             { get;, set; }


        public Deck(){
            reset();
        }
            
            public Card deal(){ 
                System.Console.WriteLine(cards.Count);
                Card dealt_card = cards[cards.Count-1];
                cards.Remove(dealt_card);
                System.Console.WriteLine("Dealt a " + dealt_card.stringVal + " of " + dealt_card.suit);
                return dealt_card;
            }


            public void reset (){

        
                Cards = new List<Card>();

                string[] stringVal = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
                string[] suit = {"Clubs", "Spades", "Hearts", "Diamonds"};
        
                foreach(string suit in suits){


                for(int i = 0; i < strVals.Length; i++){
                    Card newCard = new Card(strVals[i], suit, i+1);
                    cards.Add(newCard);
                }
            }

                foreach(var card in cards){
                    System.Console.WriteLine(card.stringVal + " of " + card.suit);
                }
            }



            public void shuffle(){
                Random rand = new Random();
                
                for(int i = cards.Count; i > 0; i--){
                    int rand_num = rand.Next(0, cards.Count);
                    
                    cards.Add(cards[rand_num]);
                    cards.Remove(cards[rand_num]);
                }

                foreach(var card in cards){
                    System.Console.WriteLine(card.stringVal + " of " + card.suit);
                }
            }

        }




         class Player
        {
            public string name;
            public List<Card> hand;

            public Player(string name){
                this.name = name;
                this.hand = new List<Card>();
            }

            public Card draw ( Deck deck){
                Card card = deck.deal;
                hand.Add(card);
                System.Console.WriteLine("Player drew: " + card.stringVal + " of " + card.suit);
            return card;
        }




        public Card discard(int i){
            if(i >= 0 && i < hand.Count){
                Card remove_card = hand[i];
                hand.RemoveAt(i);
                System.Console.WriteLine("Removed card: " + remove_card.stringVal + " of " + remove_card.suit);
                return remove_card;
            } else {
                System.Console.WriteLine("Returning null");
                return null;
            }
        }
    }
}
