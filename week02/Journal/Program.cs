// EXCEEDING REQUIREMENTS:
// This program goes beyond the core requirements by:
// 1. Using multiple classes (Program, Journal, Entry) to organize the code clearly.
// 2. Providing a list of prompts and selecting a random prompt for each entry.
// 3. Saving and loading journal entries from a file using a structured format.
// 4. Displaying all journal entries in a clean and readable format.
// 5. Improving user experience with clear menu navigation and feedback messages.
//
// These improvements demonstrate understanding of abstraction, file handling,
// and user interaction in C#.



using System;

class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        string choice;

        do
        {
            Console.WriteLine("Journal Program Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    journal.AddEntry();
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    journal.SaveToFile();
                    break;
                case "4":
                    journal.LoadFromFile();
                    break;
                case "5":
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.\n");
                    break;
            }

        } while (choice != "5");
    }
}