using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        
        List<int> numbers = new List<int>();

        int userNumbers = -1;
        while (userNumbers != 0)
        {
            Console.Write("Enter a list of numbers, type 0 to quit.");
            string userNumber = Console.ReadLine();
            userNumbers = int.Parse(userNumber);
            

            if (userNumbers != 0)
            {
                numbers.Add(userNumbers);
            }
        }

        // To sum 

        int addition = 0;
        foreach (int number in numbers)

        {
            addition += number;
        }
        Console.WriteLine($"The sum is: {addition}");

        float average = (float)addition / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // getting the max

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");

        
        
    }
}