using System;

class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }

    public Entry(string prompt, string response, string date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
        Console.WriteLine("---------------------------");
    }

    // Convert entry to a string for saving to file
    public string ToFileString()
    {
        return $"{Date}|{Prompt}|{Response}";
    }

    // Create entry from string read from file
    public static Entry FromFileString(string line)
    {
        string[] parts = line.Split('|');
        return new Entry(parts[1], parts[2], parts[0]);
    }
}