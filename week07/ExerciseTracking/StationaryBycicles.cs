public class StationaryBycicles : Activity
{
    private int _distance;
    private float _minutes;

    private DateTime _date;
    public StationaryBycicles(int distance, float minutes)
    {
        _distance = distance;
        _minutes = minutes;
        _date = DateTime.Now;
    }

    public override int GetDistance()
    {
        return _distance;
    }

    public override float GetSpeed()
    {
        return GetDistance() / _minutes;
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
        return $"{formattedDate} Byclicled ({_minutes} min): - Distanced {GetDistance()}km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}