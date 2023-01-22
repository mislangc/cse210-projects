using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Console.WriteLine("");
        //testing Assigment Class
        Assignment assign1 = new Assignment();
        Console.WriteLine(assign1.GetSummary());

        Assignment assign2 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assign2.GetSummary());
        //testing MathAssignment Class
        MathAssignment math1 = new MathAssignment();
        Console.WriteLine(math1.GetHomeworkList());

        MathAssignment math2 = new MathAssignment("Roberto Rodriguez","Fractions","7.3","8-19");
        Console.WriteLine(math2.GetSummary());
        Console.WriteLine(math2.GetHomeworkList());
        //testing WritingAssignment Class
        WritingAssignment write1 = new WritingAssignment();
        Console.WriteLine(write1.GetWritingInformation());

        WritingAssignment write2 = new WritingAssignment("Mary Waters","European History","The Causes of World War II");
        Console.WriteLine(write2.GetSummary());
        Console.WriteLine(write2.GetWritingInformation());
        
    }
}