using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Let's begin...");

        // Calculate how many breathing cycles we can do
        int cycles = _duration / 6;   // Each cycle (in + out) takes about 6 seconds

        for (int i = 0; i < cycles; i++)
        {
            Console.Write("Breathe in...");
            ShowCountDown(4);

            Console.Write("Breathe out...");
            ShowCountDown(4);
        }

        DisplayEndingMessage();
    }
}