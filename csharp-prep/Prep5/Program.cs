using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        Console.WriteLine("");

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        static int PrompUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            return number;
        }
        static int SquareNumber(int num)
        {
            int squared = num * num;
            return squared;
        }
        static void DisplayResult(string user, int number)
        {
            Console.WriteLine($"{user}, the square of your number is {number}");
        }
        DisplayWelcome();
        string usersName = PromptUserName();
        int favoriteNumber = PrompUserNumber();
        int squaredFavoriteNumber = SquareNumber(favoriteNumber);
        DisplayResult(usersName, squaredFavoriteNumber);
    }
}