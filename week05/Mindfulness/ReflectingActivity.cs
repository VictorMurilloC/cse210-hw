public class ReflectingActivity : Activity
{

    List<string> prompts = new List<string>(["Think of a time when you did something really difficult",
    "Think of a time when you impressed yourself", 
    "Think of a time when you were really proud of yourself"]);
    List<string> questions = new List<string>(["How did you feel when it was complete?", "When did you felt you were at your strongest?", "What did you learn from this experience?"]);
    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it on other aspects of your life.")
    {
        SetStartMessage("Welcome to the Reflecting Activity!");
    }

    public string GetRandomPrompt() {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }

    public string GetRandomQuestion() {
        Random random = new Random();
        int index = random.Next(questions.Count);
        return questions[index];
    }

    public void Run()
    {
        Console.Clear();
        Console.WriteLine(GetStartMessage() + "\n");
        Console.WriteLine(GetDescription() + "\n");

        GetDurationFromUser();

        Console.Clear();

        AnimateMessage("Get ready ", 3);

        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine("----- " + GetRandomPrompt() + " -----\n");
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();
        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience");
        ShowCounterMessage("You may begin in: ", 4);
        Console.Clear();
        for (int i = 0; i < GetDuration(); i++) {
            AnimateMessage("> " + GetRandomQuestion(), 5, false);
            i += 4;
        }
        Console.WriteLine("\n"+GetEndingMessage());
        Console.Write("\n");
        Console.WriteLine("You have completed " + GetDuration() + " seconds of breathing.");
        Thread.Sleep(1000);
    }
}