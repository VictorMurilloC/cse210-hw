public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) {}

    public override void RecordEvent()
    {
        Console.WriteLine($"📖 Eternal progress recorded. You earned {Points} points!");
    }

    public override bool IsComplete() => false;

    public override string GetStatus() => "[∞]";

    public override string SaveToFile()
    {
        return $"EternalGoal|{Name}|{Description}|{Points}";
    }

    public override void LoadFromFile(string line)
    {
        // No extra state to load
    }
}