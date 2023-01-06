using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Console.WriteLine("");
        Console.WriteLine("Guess the Number");
        Console.WriteLine("");

        string answer = "yes";
        while (answer == "yes")
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);
            Console.WriteLine($"I now have the magic number...");

            int guess = 0;
            int numberOfGuesses = 0;

            while (guess != number)
            {
            Console.Write("What is your guess? ");
            string input = Console.ReadLine();
            guess = int.Parse(input);
            numberOfGuesses += 1;

            if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess == number)
            {
                Console.WriteLine($"You got it in {numberOfGuesses} guesses!");
            }
            }
            Console.Write("Do you want to play again? ");
            answer = Console.ReadLine();
            Console.WriteLine("");
        }
        if (answer == "no")
        {
            Console.WriteLine("Thank you for playing!");
        }
        

    }
}