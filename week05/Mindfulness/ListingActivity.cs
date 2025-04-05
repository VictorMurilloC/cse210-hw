public class ListingActivity : Activity
{

    private List<string> questions = new List<string>([
        "List as many things as you can that make you happy",
        "List as many things as you can that you are grateful for",
        "List as many things as you can that you are proud of",
        "List as many things as you can that you are looking forward to",
    ]);

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area")
    {
    }

    public string GetRandomQuestion()
    {
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

        AnimateMessage("Get ready", 3);

        Console.WriteLine("List as many responses you can to the following prompt:\n");
        Console.WriteLine("----- " + GetRandomQuestion() + " -----\n");
        ShowCounterMessage("You may begin in: ", 4);

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < futureTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
        }
        Console.WriteLine(GetEndingMessage());
        AnimateMessage("Well done! ", 3, false);

        Console.WriteLine("You have completed " + GetDuration() + " seconds of listing.");
        Thread.Sleep(1000);
    }
}