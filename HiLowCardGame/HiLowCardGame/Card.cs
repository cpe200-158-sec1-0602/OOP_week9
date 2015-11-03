using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLowCardGame
{
    class Card
    {
        private int _suit;
        private int _value;
        private string[] suit = { "Clubs", "Diamonds", "Hearts", "Spades" };
        private string[] value = { "Ace", "Deuce", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
        public int Suit
        {   
            get { return _suit; }
            

        }

        public int Value
        {
            get { return _value; }

        }



        public Card(int value,int suit)
        {
            _value = value;
            _suit = suit;
        }

        public override string ToString()
        {
            return "["+suit[_suit]+","+value[_value]+"]";
        }


    }
}
