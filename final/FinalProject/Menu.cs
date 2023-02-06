using System;

public class Menu
{
    protected List<string> _options = new List<string>();

    public Menu()
    {
        _options.Add("1.Play");
        _options.Add("2.Save");
        _options.Add("3.Load");
        _options.Add("4.Quit");
    }

    public Menu(List<string> options)
    {
        _options = options;
    }

    public void DisplayMenu() 
    {
        Console.WriteLine("-Main Menu-");
        foreach (string option in _options)
        {
            Console.WriteLine(option);
        }
    }
    public int MenuChoice()
    {
        string input = Console.ReadLine();
        int choice = int.Parse(input);
        return choice;
    }
    public void CC()
    {
        Console.Clear();
    }
}