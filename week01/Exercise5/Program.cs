using System;

class Program
{
    static void Main(string[] args)
    {
          // Call the welcome function
        DisplayWelcome();

        // Get the user's name
        string userName = PromptUserName();

        // Get the user's favorite number
        int userNumber = PromptUserNumber();

        // Square the number
        int squaredNumber = SquareNumber(userNumber);

        // Display the final result
        DisplayResult(userName, squaredNumber);
    }

    // Function to display the welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Function to ask for the user's name and return it
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    // Function to ask for the user's favorite number and return it
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    // Function that receives a number and returns the square of it
    static int SquareNumber(int number)
    {
        int result = number * number;
        return result;
    }

    // Function to display the final message
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine(name + ", the square of your number is " + squaredNumber);
    }
}
