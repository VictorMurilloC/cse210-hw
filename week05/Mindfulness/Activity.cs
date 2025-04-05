using System.Threading;

public class Activity
{
    private string _name;
    private string _startMessage;
    private string _description;
    private string _endingMessage;
    private int _secondsToPause;
    private int _secondsElapsed;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _secondsElapsed = 0;
        _endingMessage = "Good job! Your mind thank you very much for your effort!";
    }

    public void SetDescription(string description)
    {
        _description = description;
    }
    public string GetDescription()
    {
        return _description;
    }

    public void SetStartMessage(string startMessage)
    {
        _startMessage = startMessage;
    }

    public string GetStartMessage()
    {
        return _startMessage;
    }

    public string GetEndingMessage()
    {
        return _endingMessage;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void Count()
    {
        while (_secondsElapsed < _duration)
        {
            Console.Write("+");
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("-"); // Replace it with the - character
            _secondsElapsed++;
        }
    }

    public void GetDurationFromUser() {
        Console.Write("How long, in seconds, would you like for your session? ");
        int duration = int.Parse(Console.ReadLine());
        SetDuration(duration);
    }

    public void AnimateMessage(string message, int durationInSeconds, bool shouldClear = true) {
        for (int i = 0; i < durationInSeconds; i++) {
            Console.Clear();
            Console.Write(message + "|");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("/"); // Replace it with the - character
            Thread.Sleep(250);
             Console.Write("\b \b");
            Console.Write("-"); // Replace it with the - character
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\"); // Replace it with the - character
            Thread.Sleep(250);
        }
        if (shouldClear) {
            Console.Clear();
        }
    }


    public void ShowCounterMessage(string message, int duration)
    {
        Console.Write(message);
        for (int i = 0; i < duration; i++)
        {
            Console.Write(duration - i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.Write("\n");
    }


}