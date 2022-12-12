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
            int difference = 0;
            int noDifference = 0;
            int guessCounter = 0;


            //prompts the user to guess a number
            Console.WriteLine("I'm thinking of a number between 1 and 100. You have 3 chances to guess it\n");

            //while loop that runs until the guess value is equal to the correct number
            while (guess != rndValue)
            {
                //Takes the user input and stores it in the guess variable
                guess = Convert.ToInt32(Console.ReadLine());

                //calculates the value of the difference based on the difference between the correct number and the guess
                difference = rndValue - guess;

                //increase value of guessCounter
                guessCounter++;

                //if the guess value is equal to the correct number the game ends and let the user know they win
                if (guess == rndValue)
                {
                    Console.WriteLine("You guessed the correct number, congratulations you win!");
                }

                //if the guess value is greater than the correct number let the user know
                if (guess > rndValue)
                {
                    Console.WriteLine("That number is too high\n");
                }

                //if the guess value is lower than the correct number let the user know
                if (guess < rndValue)
                {
                    Console.WriteLine("That number is too low\n");
                }

                //if the difference is not equal to the correct number and it is between the ranges of the specified ranges let the user know
                if (difference != noDifference && difference >= lowGuess && difference <= highGuess)
                {
                    Console.WriteLine("Your guess is within 5 of the value!\n");
                }

                //if the guess counter is equal to 3 then end the game and let the user know they lose
                if (guessCounter == 3)
                {
                    Console.WriteLine("\nYou guessed incorrectly too many times. You lose!");
                    break;
                }
            }
        }
    }
}