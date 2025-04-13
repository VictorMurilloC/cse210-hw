using System;
using System.Collections.Generic;
using System.IO;

// Exceeding Requirements:
// - Added leveling system: User levels up every 500 points.
// - Added badge system for completing 3 goals.

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int totalScore = 0;
    static int level = 1;

    static void Main(string[] args)
    {
        string choice;
        do
        {
            Console.Clear();
            Console.WriteLine("=== Eternal Quest ===");
            Console.WriteLine($"Score: {totalScore} | Level: {level}");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");
            Console.Write("Select an option: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoals(); break;
                case "3": RecordEvent(); break;
                case "4": SaveGoals(); break;
                case "5": LoadGoals(); break;
                case "6": Console.WriteLine("Goodbye!"); break;
                default: Console.WriteLine("Invalid choice."); break;
            }

            if (totalScore >= level * 500)
            {
                level++;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\n🎉 You leveled up! Welcome to Level {level}!");
                Console.ResetColor();
                Console.ReadKey();
            }

        } while (choice != "6");
    }

    static void CreateGoal()
    {
        Console.WriteLine("\nWhich type of goal?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Choose: ");
        string type = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter description: ");
        string desc = Console.ReadLine();

        Console.Write("Enter point value: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            goals.Add(new SimpleGoal(name, desc, points));
        }
        else if (type == "2")
        {
            goals.Add(new EternalGoal(name, desc, points));
        }
        else if (type == "3")
        {
            Console.Write("How many times to complete: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus for completing all: ");
            int bonus = int.Parse(Console.ReadLine());

            goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }

        Console.WriteLine("Goal created!");
        Console.ReadKey();
    }

    static void ListGoals()
    {
        Console.WriteLine("\nYour Goals:");
        int index = 1;
        foreach (Goal goal in goals)
        {
            Console.WriteLine($"{index}. {goal.GetStatus()} {goal.Name} - {goal.Description}");
            index++;
        }
        Console.ReadKey();
    }

    static void RecordEvent()
    {
        Console.WriteLine("\nWhich goal did you complete?");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Name}");
        }
        Console.Write("Enter number: ");
        int choice = int.Parse(Console.ReadLine()) - 1;

        if (choice >= 0 && choice < goals.Count)
        {
            Goal selectedGoal = goals[choice];
            selectedGoal.RecordEvent();
            totalScore += selectedGoal.Points;

            if (selectedGoal is ChecklistGoal checklist &&
                checklist.IsComplete() &&
                checklist.GetStatus().Contains("X"))
            {
                totalScore += checklist.BonusPoints;
            }

            Console.WriteLine($"Total Score: {totalScore}");
        }
        else
        {
            Console.WriteLine("Invalid goal.");
        }

        if (goals.FindAll(g => g.IsComplete()).Count >= 3)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("🏅 Badge Earned: 'Goal Getter' - 3 goals completed!");
            Console.ResetColor();
        }

        Console.ReadKey();
    }

    static void SaveGoals()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();

        using (StreamWriter output = new StreamWriter(filename))
        {
            output.WriteLine(totalScore);
            output.WriteLine(level);
            foreach (Goal goal in goals)
            {
                output.WriteLine(goal.SaveToFile());
            }
        }

        Console.WriteLine("Goals saved!");
        Console.ReadKey();
    }

    static void LoadGoals()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            Console.ReadKey();
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        totalScore = int.Parse(lines[0]);
        level = int.Parse(lines[1]);
        goals.Clear();

        for (int i = 2; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");
            string type = parts[0];

            switch (type)
            {
                case "SimpleGoal":
                    var sg = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                    sg.LoadFromFile(lines[i]);
                    goals.Add(sg);
                    break;
                case "EternalGoal":
                    var eg = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                    goals.Add(eg);
                    break;
                case "ChecklistGoal":
                    var cg = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[6]));
                    cg.LoadFromFile(lines[i]);
                    goals.Add(cg);
                    break;
            }
        }

        Console.WriteLine("Goals loaded!");
        Console.ReadKey();
    }
}