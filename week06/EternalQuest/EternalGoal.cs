public class EternalGoal:Goal 
{
    private int _currentProgress;

    public EternalGoal(string name, string description, int points) : base(name, description, points) {
        _currentProgress = 0;
    }

    public override string GetDetailsString() {
        return $"{_shortName} - {_description} - {_points}";
    }
    public override string GetDetailString() {
        return $"{_shortName} - {_description} - {_points}";
    }
    public override bool isComplete() {
        return false;
    }
    public override void RecordEvent() {
        _currentProgress += _points;
    }
}