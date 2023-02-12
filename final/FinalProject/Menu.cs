using System;

public class Menu
{
    protected List<string> _options = new List<string>();
    protected string _menuName;

    public Menu()
    {
        _menuName = "-Main Menu-";
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
        Console.Clear();
        Console.WriteLine(_menuName);
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