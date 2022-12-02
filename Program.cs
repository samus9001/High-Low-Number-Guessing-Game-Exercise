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

            Console.WriteLine("I'm thinking of a random number between 0 and 100, can you guess it?");
            Console.WriteLine(rndValue);

            while (Guess != rndValue)
            {
                Guess = Convert.ToInt32(Console.ReadLine());

                if (Guess == rndValue)
                {
                    Console.WriteLine("You guessed the correct number!");
                }

                if (Guess == highGuess)
                {
                    Console.WriteLine("You're close!");
                }

                if (Guess == lowGuess)
                {
                    Console.WriteLine("You're close!");
                }

                if (Guess > rndValue)
                {
                    Console.WriteLine("That number is too high, try again");

                }

                if (Guess < rndValue)
                {
                    Console.WriteLine("That number is too low, try again");
                }
            }
        }

    }
}
