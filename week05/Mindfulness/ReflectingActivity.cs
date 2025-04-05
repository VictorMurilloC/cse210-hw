public class ReflectingActivity : Activity
{

    List<string> prompts = new List<string>(["Recall a moment when you overcame a major obstacle",
    "Reflect on a moment when you exceeded your own expectations", 
    "Recall a moment when you felt a deep sense of accomplishment"]);
    List<string> questions = new List<string>(["How did you feel when it was complete?", "When did you feel you were at your strongest?", "What did you learn from this experience?"]);
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