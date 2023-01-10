using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        Console.WriteLine("");
        Journaling();

        static void WriteOnJournal(string filename)
        {

            using (StreamWriter outputFile = File.AppendText(filename))
            {   
                //Get the current date.
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                //List of random Prompts.
                List<string> Prompts = new List<string>();
                Prompts.Add("Who was the most interesting person I interacted today?");
                Prompts.Add("If I had one thing I could do over today, what would it be?");
                Prompts.Add("What was the best part of my day?");
                Prompts.Add("Where did I spend most of my time today?");
                Prompts.Add("When was the time I felt happy today?");
                Prompts.Add("How can I say I accomplished something today?");

                //Store a random Prompt on a variable
                Random rnd = new Random();
                int randomIndex = rnd.Next(Prompts.Count);
                string randomPrompt = Prompts[randomIndex];

                //Get the input from the user.
                Console.Write($"{randomPrompt} ");
                string entry = Console.ReadLine();

                outputFile.WriteLine($"Date: {dateText} - Prompt: {randomPrompt}");
                outputFile.WriteLine(entry);
                outputFile.WriteLine(" ");
            }

        }
        static void DisplayJournal(string filename)
        {
            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach  (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        static string LoadJournal(string filename)
        {
            Console.Write("What is the filename? ");
            string loadedFile = Console.ReadLine();
            filename = loadedFile;
            return filename;
        }
        static string SaveJournal(string filename)
        {
            Console.Write("What is the filename? ");
            string newFileName = Console.ReadLine();
            System.IO.File.Move(filename, newFileName);
            return newFileName;
        }
        static int JournalChoices()
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
        static void Journaling()
        {
            string fileName = "untitled.txt";
            int choice = 0;
            while (choice != 5)
                {
                choice = JournalChoices();
                    if (choice == 1)
                    {
                        WriteOnJournal(fileName);
                    }
                    else if (choice == 2)
                    {
                        DisplayJournal(fileName);
                    }
                    else if (choice == 3)
                    {
                        string fileLoad = LoadJournal(fileName);
                        fileName = fileLoad;
                    }
                    else if (choice == 4)
                    {
                        string newName = SaveJournal(fileName);
                        fileName = newName;
                    }
                }
        }

    }
}