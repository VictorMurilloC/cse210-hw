public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public int BonusPoints => _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _currentCount = 0;
    }

    public override void RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            Console.WriteLine($"✅ Progress made. +{Points} points!");

            if (_currentCount == _targetCount)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"🏁 Checklist complete! You earned a bonus of {_bonusPoints} points!");
                Console.ResetColor();
            }
        }
        else
        {
            Console.WriteLine("This checklist goal is already complete.");
        }
    }

    public override bool IsComplete() => _currentCount >= _targetCount;

    public override string GetStatus()
    {
        return $"[{(_currentCount >= _targetCount ? "X" : " ")}] Completed {_currentCount}/{_targetCount}";
    }

    public override string SaveToFile()
    {
        return $"ChecklistGoal|{Name}|{Description}|{Points}|{_targetCount}|{_currentCount}|{_bonusPoints}";
    }

    public override void LoadFromFile(string line)
    {
        var parts = line.Split("|");
        _targetCount = int.Parse(parts[4]);
        _currentCount = int.Parse(parts[5]);
        _bonusPoints = int.Parse(parts[6]);
    }
}