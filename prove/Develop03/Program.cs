using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Console.WriteLine("");
        Console.WriteLine("1 - John 3:16");
        Console.WriteLine("2 - Proverbs 22:5-6");
        Console.Write("Which scripture do you want to memorize(Type the corresponding number)? ");
        string input = Console.ReadLine();
        int choice = int.Parse(input);
        if (choice == 1)
        {
            Scripture script = new Scripture();
            int length = (script._words).Count();
            string word = "";
            while (word != "quit") 
            {
                Console.Clear();
                Console.WriteLine(script.GetRenderedText());
                Console.WriteLine("");
                Console.WriteLine("Press ENTER to continue until all the words disappear or type 'quit' on the console to leave early.");
                word = Console.ReadLine();
                script.HideWords();
                if (script.IsCompletelyHidden() == true)
                {
                    word = "quit";
                }
            }
        }
        else if (choice == 2)
        {
            string proverbs = "Thorns and snares are in the way of the froward: he that doth keep his soul shall be far from them. Train up a child in the way he should go, and when he is old, he will not depart from it.";
            Scripture script = new Scripture(proverbs, "Proverbs", 22, 5, 6);
            int length = (script._words).Count();
            string word = "";
            while (word != "quit") 
            {
                Console.Clear();
                Console.WriteLine(script.GetRenderedTextTwoVerses());
                Console.WriteLine("");
                Console.WriteLine("Press ENTER to continue until all the words disappear or type 'quit' on the console to leave early.");
                word = Console.ReadLine();
                script.HideWords();
                if (script.IsCompletelyHidden() == true)
                {
                    word = "quit";
                }
            }
        }
        
        

    }
        

}
