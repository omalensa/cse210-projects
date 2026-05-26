using System;

class Program
{
    static void Main(string[] args)
    {
        //Main: 
        DisplayWelcomemess();
        string userName = getusername();
        int userNumber = getuserNumber();
        int square = getsquare(userNumber);

        DisplayResult(userName, square);


    }
    // Prints the welcome message
    static void DisplayWelcomemess()
    {
        Console.WriteLine("Welcome to the my programme");
    }
    //Gets the user's name
    static string getusername()
    {
        Console.Write("Please enter your Name: ");
        string name = Console.ReadLine();
        return name;
    }
    // Gets number input from the user
    static int getuserNumber()
    {
        Console.Write("Please enter your preferred number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    // Calculates the square
    static int getsquare(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string userName, int square)
    {
        Console.WriteLine($"{userName}, the square of your number is: {square}");
    }
}