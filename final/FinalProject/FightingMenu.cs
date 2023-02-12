using System;

public class FightingMenu : Menu
{
    Spinner spinner = new Spinner();
    private List<string> _fightingOptions = new List<string>();
    public FightingMenu()
    {
        _fightingOptions.Add("1.Attack");
        _fightingOptions.Add("2.Use Health Potion");
        _fightingOptions.Add("3.Flee");
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
        
        Console.WriteLine($"{enemy.GetName()} defeated.");
        spinner.ShowSpinner(3);
        Console.WriteLine($"You obtained {enemy.GetXp()} xp");
        spinner.ShowSpinner(2);
        Console.WriteLine($"and {enemy.GetCoins()} coins."); 
        spinner.ShowSpinner(2);
        player.SetXp(player.GetXp() + enemy.GetXp());
        player.SetCoins(player.GetCoins() + enemy.GetCoins());
        return 3;
    }
    public void UseHealthPotion(Player player)
    {
        if (player.GetHealthPotionCount() > 0)
        {
            if (player.GetHealth() < player.GetMaxHealth())
            {
                Console.WriteLine("You used a health potion. You gained 5 health.");
                Thread.Sleep(1500);
                player.SetHealth(player.GetHealth() + 5);
                if (player.GetHealth() > player.GetMaxHealth())
                {
                    player.SetHealth(player.GetMaxHealth());
                    Console.WriteLine("Maximum health reached.");
                    Thread.Sleep(1500);
                }
            }
            else if(player.GetHealth() == player.GetMaxHealth())
            {
                Console.WriteLine("You health is full.");
                Thread.Sleep(1000);
            }
        }
        else
        {
            Console.WriteLine("You don't have any potion.");
            Thread.Sleep(1000);
        }
    }
}