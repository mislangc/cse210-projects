using System;

public class PlayerMenu : Menu
{
    private List<string> _playerOptions = new List<string>();
    public PlayerMenu()
    {
        _playerOptions.Add("1.Play Story");
        _playerOptions.Add("2.Fight Enemies");
        _playerOptions.Add("3.Shop");
        _playerOptions.Add("4.Rest");
        _playerOptions.Add("5.Back to Main Menu");
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
    public void Rest(Player player)
    {
        if (player.GetHealth() != player.GetMaxHealth())
        {
        Console.Clear();
        Spinner spinner = new Spinner();
        Console.WriteLine("You rest for a while...");
        spinner.ShowSpinner(3);

        player.SetHealth(player.GetMaxHealth());

        Console.WriteLine("You feel refreshed. You health is now full.");
        spinner.ShowSpinner(3);
        }
        else
        {
            FullHealth();
        }
    }
    public void FullHealth()
    {
        Console.WriteLine("Your health is full you can't rest for now.");
        Thread.Sleep(1500);
    }
}