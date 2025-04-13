public class Swimming : Activity
{
    private float _minutes;
    private int _laps;
    private DateTime _date;

    public Swimming(int laps, float minutes)
    {
        _date = DateTime.Now;
        _minutes = minutes;
        _laps = laps;
    }

    public override int GetDistance()
    {
        return _laps * 50 / 1000;
    }

    public override float GetSpeed()
    {
        return GetDistance() / _minutes * 60;
    }

    public override float GetPace()
    {
        return _minutes / GetDistance();
    }

    public override DateTime GetDateTime()
    {
        return _date;
    }

    public override string GetSummaryLine()
    {
        string formattedDate = _date.ToString("d MMM yyyy");
        return $"{formattedDate} Swimming ({_minutes} min): - Distanced {GetDistance()}km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}