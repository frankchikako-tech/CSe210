using System;

class Program
{
    static void Main(string[] args)
    {
         string playAgain = "yes";

        // Loop to allow the user to play again
        while (playAgain == "yes")
        {
            // Create a random number generator
            Random randomGenerator = new Random();

            // Generate a magic number between 1 and 100
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;
            int guessCount = 0;

            Console.WriteLine("Guess My Number Game!");
            Console.WriteLine("Try to guess the magic number between 1 and 100.");

            // Loop until the user guesses correctly
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                // Count the number of guesses
                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            // Show how many guesses it took
            Console.WriteLine("You guessed the number in " + guessCount + " guesses!");

            // Ask if the player wants to play again
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower();

            Console.WriteLine();
        }

        Console.WriteLine("Thanks for playing!");
    }
}