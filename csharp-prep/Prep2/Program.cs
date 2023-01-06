using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your Grade Percentage? ");
        string inputGrade = Console.ReadLine();
        int grade = int.Parse(inputGrade);
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
            Console.WriteLine($"Your grade is {letter}.");
        }
        else if (grade >= 80)
        {
            letter = "B";
            Console.WriteLine($"Your grade is {letter}.");
        }
        else if (grade >= 70)
        {
            letter = "C";
            Console.WriteLine($"Your grade is {letter}.");
        }
        else if (grade >= 60)
        {
            letter = "D";
            Console.WriteLine($"Your grade is {letter}.");
        }
        else
        {
            letter = "F";
            Console.WriteLine($"Your grade is {letter}.");
        }

        if (letter == "A" || letter == "B" || letter == "C")
        {
            Console.WriteLine("For having a grade above C, you passed the class! ");
        }
        else
        {
            Console.WriteLine("You did not pass for not reaching a grade at least C. We're sure you'll reach that next time.");
        }
    }
}