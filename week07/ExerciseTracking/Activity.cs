using System.Dynamic;

public abstract class Activity {
    public abstract int GetDistance();
    public abstract float GetSpeed();
    public abstract float GetPace();
    public abstract DateTime GetDateTime();
    public abstract string GetSummaryLine();
}