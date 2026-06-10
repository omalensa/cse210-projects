using System;
using library_demo;

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book(); 
        book1.SetAuthor("Samson");
        book1.SetTitle("A Great Book");

        Console.WriteLine(book1.GetBookInfo());

        PictureBook book2 = new PictureBook();
        book2.SetAuthor("Divine");
        book2.SetTitle("Good Book");
        book2.SetIllustrator("Solomon");

        Console.WriteLine(book2.GetBookInfo());
        Console.WriteLine(book2.GetPictureBookInfo());

        Book book3 = new Book("Hannah", "Love at first sight");
        Console.WriteLine(book3.GetBookInfo());

        PictureBook book4 = new PictureBook("Ojone", "I am a lovely baby", "Greatness");
        Console.WriteLine(book4.GetPictureBookInfo());


        Assignment assignment = new Assignment("Samson Omale", "Maths");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment assignment1 = new MathAssignment("Samson Omale", "Fraction", "7.3", "9-12");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine(assignment1.GetHomeworkList());

        WritingAssignment assignment2 = new WritingAssignment("Eze goes to school", "Samson");
        Console.Write(assignment2.GetWritingInformation());
        
    }
}