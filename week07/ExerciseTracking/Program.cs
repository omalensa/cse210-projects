using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        // Add different activities
        activities.Add(new Running("03 Nov 2022", 30, 3.0));
        activities.Add(new Running("04 Nov 2022", 45, 4.5));
        activities.Add(new Cycling("05 Nov 2022", 40, 12.5));
        activities.Add(new Swimming("06 Nov 2022", 30, 20));

        // Display all summaries
        Console.WriteLine("Exercise Tracking Activities\n");
        
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}