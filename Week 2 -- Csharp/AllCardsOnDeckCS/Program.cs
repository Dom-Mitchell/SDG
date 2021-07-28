using System;
using System.Collections.Generic;

namespace AllCardsOnDeckCS
{
    class Program
    {
        static List<string> DeckCreation()
        {
            // Variables
            // 52 cards in a deck
            // 4 suits
            // 13 cards per suit
            var deck = new List<string>();
            var suits = new List<string>();
            var ranks = new List<string>();
            var i = 0;

            // Loop to add values to suites list
            for (i = 0; i < 4; i++)
            {
                // Logic to check if the suites are already in list
                if (!suits.Contains("Clubs") || !suits.Contains("Diamonds") || !suits.Contains("Hearts") || !suits.Contains("Spades"))
                {
                    suits.Add("Clubs");
                    suits.Add("Diamonds");
                    suits.Add("Hearts");
                    suits.Add("Spades");
                }
            }

            // Loop to add values to ranks list
            for (i = 0; i < 13; i++)
            {
                // Logic to check if the ranks are already in list
                if (!ranks.Contains("Ace") || !ranks.Contains("2") || !ranks.Contains("3") || !ranks.Contains("4") || !ranks.Contains("5") || !ranks.Contains("6") || !ranks.Contains("7") || !ranks.Contains("8") || !ranks.Contains("9") || !ranks.Contains("10") || !ranks.Contains("Jack") || !ranks.Contains("Queen") || !ranks.Contains("King"))
                {
                    ranks.Add("Ace");
                    ranks.Add("2");
                    ranks.Add("3");
                    ranks.Add("4");
                    ranks.Add("5");
                    ranks.Add("6");
                    ranks.Add("7");
                    ranks.Add("8");
                    ranks.Add("9");
                    ranks.Add("10");
                    ranks.Add("Jack");
                    ranks.Add("Queen");
                    ranks.Add("King");
                }
            }

            // Loop to make deck with suites and values/ranks
            foreach (var cardRanks in ranks)
            {
                foreach (var cardSuits in suits)
                {
                    // Formatting cards in deck & adding them to the list
                    var card = $"{cardRanks} of {cardSuits}";
                    // Test Case
                    //Console.WriteLine($"{card}");
                    deck.Add(card);
                }
            }

            // Returns deck fully formatted
            return deck;
        }

        static List<string> ShuffleDeck()
        {
            // Variables
            // index & deck
            var i = 0;
            var deck = DeckCreation();

            // Shuffling deck
            for (i = deck.Count - 1; i >= 0; i--)
            {
                // indexTwo equal to random # in range 0 to i
                var indexTwo = new Random().Next(0, i);

                // Swap i of deck with indexTwo
                var swapCards = deck[i];
                deck[i] = deck[indexTwo];
                deck[indexTwo] = swapCards;
            }

            // Print shuffled deck to screen
            // Test Case
            foreach (var shuffledCard in deck)
            {
                //Console.WriteLine($"{shuffledCard}");
            }

            // Returns shuffled deck
            return deck;
        }

        static void FirstTwoCards(List<string> deck)
        {
            Console.WriteLine($"\nFirst card is {deck[0]} and second card is {deck[1]}");
        }

        static void DealCards(List<string> deck)
        {
            var i = 0;

            // Two Hands of Cards
            Console.Write("How many cards do you want? ");
            var cardNum = int.Parse(Console.ReadLine());

            // 1st Player's hand formatting
            Console.WriteLine("\n1st Player's Hand: \nPlayer 1 has these cards: ");

            // Loop for determining 1st player's hand
            for (i = 0; i < cardNum; i++)
            {
                var player1 = deck[i];
                Console.WriteLine($"{player1}");
                deck.Remove(player1);

            }

            // 2nd Player's hand formatting
            Console.WriteLine("\n2nd Player's Hand: \nPlayer 2 has these cards: ");

            // Loop for determining 2nd player's hand
            for (i = 0; i < cardNum; i++)
            {
                var player2 = deck[i];
                Console.WriteLine($"{player2}");
            }
        }

        static void Main(string[] args)
        {
            // Test Case
            //DeckCreation();

            // Variable used to shuffle cards
            var deck = ShuffleDeck();

            // Ask user if they want to know the first two cards in deck
            Console.WriteLine("Would you like to know the first 2 cards in the deck? (Yes/No)");
            var answer = Console.ReadLine();

            // Logic to determine if user typed yes to previous question
            if (answer == "Yes" || answer == "yes" || answer == "y")
            {
                // Call method to determine first 2 cards in deck
                FirstTwoCards(deck);
            }

            // Call method to deal cards
            DealCards(deck);
        }
    }
}