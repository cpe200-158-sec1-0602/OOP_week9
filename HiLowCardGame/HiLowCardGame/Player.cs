using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLowCardGame
{
    class Player 
    {
        private List<Card> deck = new List<Card>();
        private List<Card> pile = new List<Card>();
        private string _name;

        public string Name
        {
            get { return _name; }
            
            
        } 

        public Player(string n)
        {
            _name = n;
            
        }

        public void SetUpDeck(int value , int suit)
        {
            Card C = new Card(value, suit);
            deck.Add(C);
        } 
        public List<Card> Pile
        {
            get { return pile; }
            
        }

        public List<Card> Deck
        {
            get { return deck; }
            
        }

        public int score()
        {
            return pile.Count;
        }
        
        public void shuffle()
        {
            Random inrand = new Random();
            Card temp;

            for (int i = 0;i<deck.Count;i++)
            {
                int rand;

                do {
                    rand = inrand.Next(0,deck.Count);
                } while (rand==i);

                temp = deck[i];
                deck[i] = deck[rand];
                deck[rand] = temp;
            }


        }

        public void delDeck(int index)
        {
            deck.RemoveAt(index);
        }

        public void addPile(Card C)
        {
            pile.Add(C);
        }

        public void PrintDeck()
        {
            Console.WriteLine("\nInDeck : "+Name);
            foreach (Card C in deck)
                Console.WriteLine(C);
        }

        public void PrintPile()
        {
            Console.WriteLine("\nInPile : "+Name);
            foreach (Card C in pile)
                Console.WriteLine(C);
        }

        


    }
}
