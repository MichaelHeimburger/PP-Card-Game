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
            Deck deck = new Deck();
            bool game = true;
            Console.WriteLine("Welcome to the table cowboy press any key to be dealt your cards");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Heres your two cards buckoo");
            int[] pHand = new int[5];
            int[] dHand = new int[5]; // hand of five cards for each
            int[] pHanda = new int[5];
            int[] dHanda = new int[5]; // hand of five cards which will also check alternate win for aces, may be removed 
            dHand[0] = deck.Draw();
            dHand[1] = deck.Draw();
            pHand[0] = deck.Draw();
            pHand[1] = deck.Draw();
            // drawing cards into hands

            // INSERT CARD READ HERE
            Console.Write("Your "); HandRead(pHand);
            Console.Write("The Dealer's"); HandRead(dHand);
            while(game)
            Options();
            var keyInput = Console.ReadKey();
            switch (keyInput.KeyChar)
            {
                case '1':
                    dHand[3] = deck.Draw();
                    
                    break;
                case '2':
                    break;
                case '3':
                    break;
            }

        } // m

        
        static private void Options() // UI shortcut for neatness
        {
            Console.WriteLine("\n \n What would you like to do?.");
            Console.WriteLine("[1] Draw a card");
            Console.WriteLine("[2] Pass");
            Console.WriteLine("[3] Leave Table");
        }
        static private void HandRead(int[] hand) //Reads off the int[] 
        {
            string[] wordmap = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen" };
            string[] handr = new string[5];
            Console.Write("Hand  reads a ");
            for (int i = 0; hand.Length > i; i++)
            {
                
                if ((i == hand.Length - 1) || (hand[i + 1] == 0))
                {
                    Console.Write(" and a ");
                }
                if (hand[i] == 1)
                {
                    Console.Write("ace");
                }
                else
                {
                    Console.Write(wordmap[hand[i]]);
                    Console.Write(",  ");
                }
                if (hand[i + 1] == 0)
                {
                    break;
                }

            }


            


        }



        static private int[] GameLogicAce(int[] dhand) // sets a different array alongside the main hand to run the code as if there was an ace
        {
            int[] dhanda = new int[5];

            for (int i = 0; dhand.Length - 1 > i; i++)
            {
                if (dhand[i] == 1)
                {
                    dhanda[i] = 11;
                }
                else
                {
                    dhanda[i] = dhand[i];
                }
            }
            return dhanda;

        }
    }// c
}
