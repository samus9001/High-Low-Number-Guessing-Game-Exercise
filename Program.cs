using System;

namespace HighLowNumberGuessing

{
    internal class Program

    {
        const int GUESSES = 5;

        static void Main(string[] args)
        {
            Random rnd = new Random();

            //create a random value between 0 and 100
            int rndValue = rnd.Next(-1, 101);

            //variables that track the game state
            int guess = -1;
            int closeGuess = 5;
            int guessCounter = 5;
            char endGame;

            //prompts the user to guess a number
            Console.WriteLine($"I'm thinking of a number between 0 and 100. You have {GUESSES} chances to guess the number!\n");

            //while loop that runs until the guess value is equal to the correct number
            while (guess != rndValue)
            {
                //Takes the user input and stores it in the guess variable
                guess = Convert.ToInt32(Console.ReadLine());

                //decrease value of guessCounter by one
                guessCounter--;

                if (guess > rndValue)
                {
                    Console.WriteLine($"\nThat number is too high. Try again!\nYou have {guessCounter} guesses left\n");
                }

                if (guess < rndValue)
                {
                    Console.WriteLine($"\nThat number is too low. Try again!\nYou have {guessCounter} guesses left\n");
                }

                //if the difference is between the ranges of the specified ranges let the user know
                if (Math.Abs(rndValue - guess) <= closeGuess)
                {
                    Console.WriteLine($"Your guess is within 5 of the value. Keep going!\n");
                }

                //game over check
                if (guessCounter <= 0)
                {
                    Console.Clear();
                    Console.WriteLine($"\nYou ran out of guesses. You lose!\nThe number was {rndValue}\n\nIf you would like to play again press Y or press N to exit");
                    break;
                }
            }

            //game won check
            if (guess == rndValue)
            {
                Console.Clear();
                Console.WriteLine("You guessed the correct number. Congratulations you win!\n\nIf you would like to play again press Y or press N to exit");
            }

            //prompts user to restart or exit game
            endGame = Console.ReadKey().KeyChar;

            if (endGame == 'Y')
            {
                Console.Clear();
                Main(args);
            }

            else if (endGame == 'N')
            {
                return;
            }
        }
    }
}