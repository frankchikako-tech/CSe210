using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people you appreciate?",
        "What are your personal strengths?",
        "Who have you helped recently?",
        "Who are your heroes?"
    };

    public ListingActivity()
        : base("Listing Activity",
        "List as many positive things as you can.") { }

    public void Run()
    {
        StartMessage();

        Random rand = new Random();
        Console.WriteLine($"\n{_prompts[rand.Next(_prompts.Count)]}");

        Console.WriteLine("\nStart listing in:");
        ShowCountdown(5);

        int count = 0;
        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"\nYou listed {count} items!");
        EndMessage();
    }
}