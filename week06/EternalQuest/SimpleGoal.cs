public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override string GetDetailsString()
    {
        throw new NotImplementedException();
    }

    public override string GetDetailString()
    {
        throw new NotImplementedException();
    }

    public override bool isComplete()
    {
        return _isComplete;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }
}