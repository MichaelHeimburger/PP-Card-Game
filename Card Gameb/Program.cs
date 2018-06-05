using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Gameb
{
    class Program
    {
        static void Main(string[] args)
        {
            CardDeck deckOne = new CardDeck();
            for (int i = 0; i < deckOne.Deck.Length; i++)
            {
                Console.WriteLine(deckOne.Deck[i]);

            }




        }
    }
}
