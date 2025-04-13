using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("You have 0 points.\n");
        Console.WriteLine("Menu Controls:");
        Console.WriteLine(" 1. Create a New Goal");
        Console.WriteLine(" 2. List Goals");
        Console.WriteLine(" 3. Save Goals");
        Console.WriteLine(" 4. Load Goals");
        Console.WriteLine(" 5. Record Event");
        Console.WriteLine(" 6. Quit");
        Console.Write("\n\nSelect a choice from the menu: ");
        int choice = int.Parse(Console.ReadLine());
        if (choice == 1) {
            Console.WriteLine("The types of goals are:");
            Console.WriteLine(" 1. Simple Goal");
            Console.WriteLine(" 2. Eternal Goal");
            Console.WriteLine(" 1.  Goal");
            Console.Write("\n\nWhich goal type do you like to create: ");
            int goalType = int.Parse(Console.ReadLine());
            Console.Write("What is the name of your goal? ");
            string goalName = Console.ReadLine();
        }
    }
}