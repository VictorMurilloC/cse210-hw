public class Running : Activity
{
    private int _distance;
    private float _minutes;
    private DateTime _date;

    public Running(int distance, float minutes)
    {
        _date = DateTime.Now;
        _distance = distance;
        _minutes = minutes;
    }

    public override int GetDistance()
    {
        return _distance;
    }

    public override float GetSpeed()
    {
        return _distance / (_minutes / 60);
    }

    public override float GetPace()
    {
        return _minutes / _distance;
    }

    public override DateTime GetDateTime()
    {
        return _date;
    }

    public override string GetSummaryLine()
    {
        string formattedDate = _date.ToString("d MMM yyyy");
        return $"{formattedDate} Running ({_minutes} min): - Distanced {GetDistance()}km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}