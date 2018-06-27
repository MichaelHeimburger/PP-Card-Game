using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Gameb
{
    class Deck
    {
        public int[] CardArray { get; set; }
        private int counter;
        private bool reloop;
        private bool[] isCardDrawn=new bool[52];
        private static readonly Random getrandom = new Random();
        private static int GetRandomNumber(int min, int max)
        {
            lock (getrandom)
            {
                return getrandom.Next(min, max);
            }
        }


        public Deck()
        {
            CardArray = new int[52];
            DeckSet();
            for (int i = 0; isCardDrawn.Length - 1 > i; i++)
            {
                isCardDrawn[i] = false;
            }
        }

        private void DeckSet()
        {
            // for as long as the decks length this block generates a random number checks it
            //against existing number to make sure only 4 exist then assigns it to the index
            for (int i = 0; CardArray.Length - 1 > i; i++) 
            {
                int num;
                do
                {
                    reloop = false;
                    counter = 0;
                    num = GetRandomNumber(2, 15);
                    foreach (int cardcheck in CardArray)
                    {
                        if (cardcheck == num)
                        {
                            counter++;
                            if (counter == 4)
                            {
                                reloop = true;
                                break;
                            }
                        } // Nested if statement that checks that there is only 4 of a given number, counting each instance of an int
                    }
                }
                while (reloop);
                CardArray[i] = num;
                //Console.WriteLine(num); // for testing
            }
            SetValue();
        } // end deckset

        private void SetValue() // sets actual blackjack values for each of the cards
        {
            for(int c =0; CardArray.Length-1>c;c++)
            {
                if((CardArray[c] > 10 ) && (CardArray[c] < 14)) // jack/king/queen value
                {
                    CardArray[c] = 10;
                }
                else if (CardArray[c] == 14) // ace value
                {
                    CardArray[c] = 1;
                }
                       
            }

        }
        public int Draw()
        {
            do
            {
                int num = GetRandomNumber(0, 51);
                if (isCardDrawn[num] == false)
                {
                    isCardDrawn[num] = true;
                    return CardArray[num];
                }
            }
            while (true);

        }
    } // c
}
