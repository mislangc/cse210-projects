using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;   
        while (choice != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            choice = number;
            if (choice == 1)
            {
                Console.Clear();
                BreathingActivity breathing = new BreathingActivity();
                Console.WriteLine(breathing.GetWelcomeMessage());
                Console.WriteLine();
                Console.WriteLine(breathing.GetDescription());
                Console.WriteLine();
                Console.Write(breathing.GetDurationMessage());
                string userInput = Console.ReadLine();
                int duration = int.Parse(userInput);
                Console.Clear();
                Console.WriteLine(breathing.GetReadyMessage());
                breathing.ShowSpinner(3);
                int count = 0;
                while (count < duration)
                {
                    Console.WriteLine("");
                    Console.Write(breathing.GetBreatheInMessage());
                    breathing.ShowNumberCountdown(4);
                    count += 3;
                    Console.WriteLine("");
                    Console.Write(breathing.GetBreatheOutMessage());
                    breathing.ShowNumberCountdown(4);
                    count += 4;
                    Console.WriteLine("");
                }
                Console.WriteLine("");
                Console.WriteLine(breathing.GetWellDoneMessage());
                breathing.ShowSpinner(4);
                Console.WriteLine(breathing.GetEndingMessage(duration));
                breathing.ShowSpinner(6);
                choice = 1;
                Console.Clear();
            }
            else if (choice == 2)
            {
                Console.Clear();
                ReflectingActivity reflect = new ReflectingActivity();
                Console.WriteLine(reflect.GetWelcomeMessage());
                Console.WriteLine("");
                Console.WriteLine(reflect.GetDescription());
                Console.WriteLine("");
                Console.Write(reflect.GetDurationMessage());
                string userInput = Console.ReadLine();
                int duration = int.Parse(userInput);
                Console.Clear();
                Console.WriteLine(reflect.GetReadyMessage());
                reflect.ShowSpinner(3);
                Console.WriteLine(reflect.GetConsiderMessage());
                Console.WriteLine();
                Console.WriteLine(reflect.GetRandomPrompt());
                Console.WriteLine();
                Console.WriteLine(reflect.GetInMindMessage());
                Console.ReadLine();
                Console.WriteLine(reflect.GetPonderMessage());
                Console.Write(reflect.GetBeginMessage());
                reflect.ShowNumberCountdown(5);
                Console.Clear();
                int count = 0;
                while (count < duration)
                {
                    Console.Write(reflect.GetRandomReflectQuestion());
                    reflect.ShowSpinner(8);
                    Console.WriteLine();
                    count += 8;
                }
                Console.WriteLine("");
                Console.WriteLine(reflect.GetWellDoneMessage());
                reflect.ShowSpinner(4);
                Console.WriteLine(reflect.GetEndingMessage(duration));
                reflect.ShowSpinner(6);
                choice = 2;
                Console.Clear();
            }
            else if (choice == 3)
            {
                Console.Clear();
                ListingActivity listing = new ListingActivity();
                Console.WriteLine(listing.GetWelcomeMessage());
                Console.WriteLine();
                Console.WriteLine(listing.GetDescription());
                Console.WriteLine();
                Console.Write(listing.GetDurationMessage());
                string userInput = Console.ReadLine();
                int duration = int.Parse(userInput);
                Console.Clear();
                Console.WriteLine(listing.GetReadyMessage());
                listing.ShowSpinner(3);
                Console.WriteLine();
                Console.WriteLine(listing.GetListingIntroMessage());
                Console.WriteLine();
                Console.WriteLine(listing.GetRandomListingPrompt());
                Console.WriteLine();
                Console.Write(listing.GetBeginMessage());
                listing.ShowNumberCountdown(5);
                Console.WriteLine();
                List<string> userInputItems = new List<string>();
                
                DateTime presentTime = DateTime.Now;
                DateTime finishTime = presentTime.AddSeconds(duration);
                DateTime currentTime = DateTime.Now;

                while (currentTime < finishTime)
                {
                    Console.Write("> ");
                    string userItem = Console.ReadLine();
                    userInputItems.Add(userItem);
                    DateTime nowTime = DateTime.Now;
                    currentTime = nowTime;
                }

                Console.WriteLine(listing.GetListedCountMessage(userInputItems.Count));
                Console.WriteLine();
                Console.WriteLine(listing.GetWellDoneMessage());
                Console.WriteLine();
                listing.ShowSpinner(4);
                Console.WriteLine(listing.GetEndingMessage(duration));
                listing.ShowSpinner(6);
                choice = 3;
                Console.Clear();
            }
            else if (choice == 4)
            {
                choice = 4;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Try again...");
                Thread.Sleep(1000);
            }
        }
        Console.WriteLine();
        Console.WriteLine("See you again!");
        

    }
}