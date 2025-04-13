public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public string Name => _name;
    public string Description => _description;
    public int Points => _points;

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStatus();
    public abstract string SaveToFile();
    public abstract void LoadFromFile(string line);
}