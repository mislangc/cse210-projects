using System;

public class PlayerMenu : Menu
{
    private List<string> _playerOptions = new List<string>();
    public PlayerMenu()
    {
        _playerOptions.Add("1.Fight Enemies");
        _playerOptions.Add("2.Shop");
        _playerOptions.Add("3.Back to Main Menu");
    }
    public PlayerMenu(List<string> options) : base(options)
    {

    }
    public void DisplayPlayerOptions()
    {
        foreach (string option in _playerOptions)
        {
            Console.WriteLine(option);
        }
    }
}