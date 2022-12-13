using System;

namespace HighLowNumberGuessing

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a random value between 1 and 100
            Random rnd = new Random();

            int rndValue = rnd.Next(0, 101);
            int guess = -1;
            int highGuess = 5;
            int lowGuess = -5;
            int guessCounter = 0;

            //prompts the user to guess a number
            Console.WriteLine("I'm thinking of a number between 1 and 100. You have 3 chances to guess it\n");
            //while loop that runs until the guess value is equal to the correct number
            while (guess != rndValue)
            {
                //Takes the user input and stores it in the guess variable
                guess = Convert.ToInt32(Console.ReadLine());

                //calculates the value of the difference between the correct number and the guess
                Math.Abs(rndValue - guess);

                //increase value of guessCounter by one
                guessCounter++;

                if (guess == rndValue)
                {
                    Console.WriteLine("You guessed the correct number, congratulations you win!");
                    break;
                }

                if (guess > rndValue)
                {
                    Console.WriteLine("\nThat number is too high\n");
                }

                if (guess < rndValue)
                {
                    Console.WriteLine("\nThat number is too low\n");
                }

                //if the difference is between the ranges of the specified ranges let the user know
                if (Math.Abs(rndValue - guess) >= lowGuess && Math.Abs(rndValue - guess) <= highGuess)
                {
                    Console.WriteLine("Your guess is within 5 of the value!\n");
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