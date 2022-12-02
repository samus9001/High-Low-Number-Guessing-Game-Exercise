using System;

namespace HighLowNumberGuessing

{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int rndValue = rnd.Next(100);
            int Guess = 0;
            int highGuess = rndValue + 5;
            int lowGuess = rndValue - 5;
            int guessCounter = 0;

            Console.WriteLine("I'm thinking of a number between 0 and 100. You have 3 chances to guess it\n");

            while (Guess != rndValue)
            {
                Guess = Convert.ToInt32(Console.ReadLine());

                if (Guess == rndValue)
                {
                }

                if (Guess > rndValue)
                {
                    Console.WriteLine("That number is too high\n");
                }

                if (Guess == highGuess)
                {
                    Console.WriteLine("You're close!\n");
                }

                if (Guess < rndValue)
                {
                    Console.WriteLine("That number is too low\n");
                }

                if (Guess == lowGuess)
                {
                    Console.WriteLine("You're close!\n");
                }

                if (Guess > 0)
                {
                    guessCounter++;
                }

                if (guessCounter == 3)
                {
                    Console.WriteLine("\nYou guessed incorrectly too many times. You lose!");
                    break;
                }
            }
        }
    }
}