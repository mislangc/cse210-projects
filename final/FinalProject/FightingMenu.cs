using System;

public class FightingMenu : Menu
{
    private List<string> _fightingOptions = new List<string>();
    public FightingMenu()
    {
        _fightingOptions.Add("1.Attack");
        _fightingOptions.Add("2.Flee");
    }
    public void DisplayFightOptions()
    {
        foreach (string option in _fightingOptions)
        {
            Console.WriteLine(option);
        }
        Console.Write("Choose your action: ");
    }
    public int Attack(Player player, Enemy enemy)
    {
        enemy.SetHealth(enemy.GetHealth() - player.GetBaseAttack());
        if (enemy.GetHealth() > 0)
        {
            player.SetHealth(player.GetHealth() - enemy.GetBaseAttack());
        }
        else if (enemy.GetHealth() <= 0)
        {
            return EnemyDefeated(player, enemy);
        }
        return 0;
        
    }
    public int EnemyDefeated(Player player, Enemy enemy)
    {
        Menu menu = new Menu();
        menu.CC();
        Console.Write("Fight has ended...");
        Spinner spinner = new Spinner();
        Console.WriteLine($"{enemy.GetName()} defeated.");
        spinner.ShowSpinner(3);
        Console.WriteLine($"You obtained {enemy.GetXp()} xp");
        spinner.ShowSpinner(2);
        Console.WriteLine($"and {enemy.GetCoins()} coins."); 
        spinner.ShowSpinner(2);
        player.SetXp(player.GetXp() + enemy.GetXp());
        player.SetCoins(player.GetCoins() + enemy.GetCoins());
        return 2;
    }
}