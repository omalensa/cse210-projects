using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    private static List<Goal> _goals = new List<Goal>();
    private static int _score = 0;

    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"Eternal Quest - Your Score: {_score} points");
            Console.WriteLine("========================================");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Record Event");
            Console.WriteLine("  4. Save Goals");
            Console.WriteLine("  5. Load Goals");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            if (choice == "1")
                CreateNewGoal();
            else if (choice == "2")
                ListGoals();
            else if (choice == "3")
                RecordEvent();
            else if (choice == "4")
                SaveGoals();
            else if (choice == "5")
                LoadGoals();
            else if (choice == "6")
            {
                Console.WriteLine("Thank you for using Eternal Quest. Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Press enter to continue...");
                Console.ReadLine();
            }
        }
    }

    static void CreateNewGoal()
    {
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");

        string type = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("Give a short description: ");
        string description = Console.ReadLine();

        Console.Write("How many points is this worth? ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (type == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (type == "3")
        {
            Console.Write("How many times does this need to be done? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus points for completing it? ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
    }

    static void ListGoals()
    {
        Console.WriteLine("\nThe goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
        Console.WriteLine();
    }

    static void RecordEvent()
    {
        ListGoals();
        Console.Write("Which goal did you accomplish? (number): ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            _goals[index].RecordEvent();
            _score += _goals[index].GetPoints();
        }
    }

    static void SaveGoals()
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully!");
    }

    static void LoadGoals()
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            _goals.Clear();
            string[] lines = File.ReadAllLines(filename);

            _score = int.Parse(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] parts = line.Split(':');
                string type = parts[0];
                string[] data = parts[1].Split(',');

                if (type == "SimpleGoal")
                {
                    SimpleGoal g = new SimpleGoal(data[0], data[1], int.Parse(data[2]));
                    if (bool.Parse(data[3])) g.RecordEvent(); // to set as complete
                    _goals.Add(g);
                }
                else if (type == "EternalGoal")
                {
                    _goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
                }
                else if (type == "ChecklistGoal")
                {
                    ChecklistGoal g = new ChecklistGoal(data[0], data[1], int.Parse(data[2]), 
                                                       int.Parse(data[3]), int.Parse(data[4]));
                    for (int j = 0; j < int.Parse(data[5]); j++)
                    {
                        g.RecordEvent();
                    }
                    _goals.Add(g);
                }
            }
            Console.WriteLine("Goals loaded successfully!");
        }
    }
}