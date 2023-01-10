using System;

public class Menu
    {   
        public int JournalChoices()
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string input = Console.ReadLine();
            int choice = int.Parse(input);

            return choice;
        }
    }