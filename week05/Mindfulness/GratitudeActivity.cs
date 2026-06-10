using System;
using System.Collections.Generic;

public class GratitudeActivity : Activity
{
    private List<string> _prompts;

    public GratitudeActivity() 
        : base("Gratitude", "This activity will help you focus on the positive things in your life by expressing gratitude. Gratitude can greatly improve your mood and perspective.")
    {
        _prompts = new List<string>
        {
            "What are you grateful for today?",
            "Who has helped you recently that you're thankful for?",
            "What is something beautiful you saw or experienced lately?",
            "What personal qualities or strengths are you grateful to have?",
            "What simple pleasure made you smile this week?",
            "What is something in nature you're thankful for?",
            "What challenge taught you something valuable?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Let's practice gratitude!\n");
        
        string prompt = GetRandomPrompt();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();

        Console.WriteLine("You may begin listing things you're grateful for.");
        Console.WriteLine("Type 'done' when you are finished.\n");

        List<string> gratitudeList = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();

            if (item.ToLower() == "done")
                break;

            if (!string.IsNullOrWhiteSpace(item))
            {
                gratitudeList.Add(item);
            }
        }

        Console.WriteLine($"\nYou listed {gratitudeList.Count} things you are grateful for!");
        if (gratitudeList.Count >= 3)
        {
            Console.WriteLine("That's wonderful! Gratitude is a powerful practice.");
        }

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}