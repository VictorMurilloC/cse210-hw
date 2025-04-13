using System;

class Program
{
    static void Main(string[] args)
    {
        var running1 = new Running(5, 30);
        var running2 = new Running(7, 45);
        var cycling1 = new StationaryBycicles(60, 20);
        var swimming1 = new Swimming(30, 15);
        var swimming2 = new Swimming(45, 25);

        Console.WriteLine(running1.GetSummaryLine());
        Console.WriteLine(running2.GetSummaryLine());
        Console.WriteLine(cycling1.GetSummaryLine());
        Console.WriteLine(swimming1.GetSummaryLine());
        Console.WriteLine(swimming2.GetSummaryLine());
    }
}