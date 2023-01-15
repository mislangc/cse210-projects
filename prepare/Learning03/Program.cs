using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Console.WriteLine("");

        Fraction frac1 = new Fraction();
        Fraction frac2 = new Fraction(6);
        Fraction frac3 = new Fraction(3,4);
        
        frac2.SetBottom(10);
        Console.WriteLine(frac2.GetTop());
        Console.WriteLine(frac2.GetBottom());
        Console.WriteLine(frac2.GetFractionString());
        Console.WriteLine(frac2.GetDecimalValue());
        Console.WriteLine(frac3.GetDecimalValue());
        frac1.SetBottom(3);
        Console.WriteLine(frac1.GetDecimalValue());
        frac3.SetBottom(6);
        Console.WriteLine(frac3.GetDecimalValue());
    }
}