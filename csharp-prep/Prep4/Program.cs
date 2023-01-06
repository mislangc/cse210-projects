using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine("");

        List<int> numbers = new List<int>();
        int sum = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int zero = 1;
        while (zero != 0)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            int num = int.Parse(input);
            if (num > 0)
            {
                numbers.Add(num);
            }
            sum += num;
            zero = num;

        }
        double average = Queryable.Average(numbers.AsQueryable());
        int max = numbers.Max();

        Console.WriteLine("");
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

    }
}