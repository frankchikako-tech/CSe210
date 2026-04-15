

/*
EXCEEDING REQUIREMENTS:
- Added player level system (Beginner, Warrior, Legend)
- Improved UI with clear display and symbols
- Prevented duplicate scoring for completed simple goals
*/class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}
