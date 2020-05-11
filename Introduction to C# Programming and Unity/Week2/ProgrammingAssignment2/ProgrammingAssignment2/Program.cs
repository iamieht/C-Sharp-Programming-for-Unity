using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment2
{
    /// <summary>
    /// Programming Assignment 2 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Deals 2 cards to 3 players and displays cards for players
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // print welcome message
            Console.WriteLine("Welcome to Nothing Like Blackjack");
            Console.WriteLine();

            // create and shuffle a deck
            Deck deck = new Deck();
            deck.Shuffle();

            // deal 2 cards each to 3 players (deal properly, dealing
            // the first card to each player before dealing the
            // second card to each player)
            Card card1PlayerOne = deck.TakeTopCard();
            Card card1PlayerTwo = deck.TakeTopCard();
            Card card1PlayerThree = deck.TakeTopCard();

            Card card2PlayerOne = deck.TakeTopCard();
            Card card2PlayerTwo = deck.TakeTopCard();
            Card card2PlayerThree = deck.TakeTopCard();

            // flip all the cards over
            card1PlayerOne.FlipOver();
            card2PlayerOne.FlipOver();
            card1PlayerTwo.FlipOver();
            card2PlayerTwo.FlipOver();
            card1PlayerThree.FlipOver();
            card2PlayerThree.FlipOver();

            // print the cards for player 1
            Console.WriteLine("Player 1 Cards are: " + card1PlayerOne.Rank + " " + card1PlayerOne.Suit + " and " + card2PlayerOne.Rank + " " + card2PlayerOne.Suit);

            // print the cards for player 2
            Console.WriteLine("Player 2 Cards are: " + card1PlayerTwo.Rank + " " + card1PlayerTwo.Suit + " and " + card2PlayerTwo.Rank + " " + card2PlayerTwo.Suit);

            // print the cards for player 3
            Console.WriteLine("Player 3 Cards are: " + card1PlayerThree.Rank + " " + card1PlayerThree.Suit + " and " + card2PlayerThree.Rank + " " + card2PlayerThree.Suit);

            Console.WriteLine();
        }
    }
}
