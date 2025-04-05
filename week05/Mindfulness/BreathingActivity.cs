public class BreathingActivity : Activity
{
    public BreathingActivity()
    : base("Breathing Activity", "Breathing deeply and slowly can help you relax and focus.")
    {
        SetStartMessage("Welcome to the Breathing Activity!");
    }

    public void Run()
    {
        Console.Clear();
        Console.WriteLine(GetStartMessage() + "\n");
        Console.WriteLine(GetDescription() + "\n");

        GetDurationFromUser();
        
        Console.Clear();

        AnimateMessage("Get ready ", 3);
        for (int i = 0; i < GetDuration(); i++)
        {
            ShowCounterMessage("Breath in...", 3);
            i += 3;
            ShowCounterMessage("Now breath out...", 3);
            i += 2;
            Console.Write("\n");
        }
        Console.WriteLine(GetEndingMessage());
        AnimateMessage("Well done! ", 3, false);
        Console.WriteLine("\b \b");
        Console.Write("\n");
        Console.WriteLine("You have completed " + GetDuration() + " seconds of breathing.");
        Thread.Sleep(1000);
    }
}