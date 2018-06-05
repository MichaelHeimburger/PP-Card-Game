using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Gameb
{
    class CardDeck
    {
        private int[] deck = new int[52];
        Random cardRand = new Random();

        public int[] Deck
        {
            get { return this.deck; } set { this.deck = value; }
        }

        public CardDeck()
        {
            int cardBuffer;
            
            for (int a = 0; a < deck.Length; a++) // deck creation
            {
                bool reloop = false;
                do
                {
                    int detectorOne = 0;
                    
                    cardBuffer = cardRand.Next(2, 14);

                    for (int b = 0; b < deck.Length; b++)  // check for number one
                    {
                        if (deck.Contains(cardBuffer))
                        {
                            detectorOne++;
                        }
                        if (detectorOne > 4)
                        {
                            reloop = true;
                            break;
                        }
                    }
                }
                while (reloop);

                deck[a] = cardBuffer;
                Console.WriteLine(deck[a]);

            }
        }

        
            

       
}
}
