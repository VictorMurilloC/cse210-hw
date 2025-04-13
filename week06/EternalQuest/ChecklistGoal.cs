public class ChecklistGoal : Goal
{

    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points) : base(name, description, points)
    {
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
        return _amountCompleted >= _target;
    }

    public override void RecordEvent()
    {
        _amountCompleted += _points;
    }
}