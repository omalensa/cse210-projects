using System;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.getFractionString());
        Console.WriteLine(fraction1.getFraction());

        Fraction fraction2 = new Fraction(5);
        Console.WriteLine(fraction2.getFractionString());
        Console.WriteLine(fraction2.getFraction());

        Fraction fraction3 = new Fraction(3,4);
        Console.WriteLine(fraction3.getFractionString());
        Console.WriteLine(fraction3.getFraction());

        Fraction fraction4 = new Fraction(1,3);
        Console.WriteLine(fraction4.getFractionString());
        Console.WriteLine(fraction4.getFraction());

        
    }
}