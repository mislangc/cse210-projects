using System;

class Program
{
    static void Main(string[] args)
    {
        Spinner spinner = new Spinner();
        Console.WriteLine("Welcome to -Name of RPG Game-");
        Console.WriteLine("");
        Console.Write("What's your name? ");
        string newName = Console.ReadLine();
        Player player = new Player(newName);
        int choice = 0;
        while (choice != 4)
        {
            Menu menu = new Menu();
            menu.CC();
            menu.DisplayMenu();
            Console.Write("Choose your option: ");
            choice = menu.MenuChoice();
            if (choice == 1)
            {
                int decision = 0;
                while (decision != 3)
                {
                    menu.CC();
                    Console.WriteLine($"Level:{player.GetLevel()} (Xp:{player.GetXp()})");
                    Console.WriteLine($"Health: {player.GetHealth()}");
                    Console.WriteLine($"Coins: {player.GetCoins()}");
                    Console.WriteLine("");
                    PlayerMenu playerMenu = new PlayerMenu();
                    playerMenu.DisplayPlayerOptions();
                    Console.Write("What would you like to do? ");
                    decision = playerMenu.MenuChoice();
                    if (decision == 1)
                    {
                        menu.CC();
                        int action = 0;
                        Console.WriteLine("Searching for enemy...");
                        spinner.ShowSpinner(4);
                        Enemy enemy = new Enemy();
                        
                        while (action != 2)
                        {
                            menu.CC();
                            FightingMenu fightMenu = new FightingMenu(); 
                            Console.WriteLine($"Enemy {enemy.GetName()} appeared.");
                            Console.WriteLine($"Enemy Health:{enemy.GetHealth()}");
                            Console.WriteLine("");
                            Console.WriteLine($"Level:{player.GetLevel()} (Xp:{player.GetXp()})");
                            Console.WriteLine($"Health: {player.GetHealth()}");
                            Console.WriteLine($"Coins: {player.GetCoins()}");
                            Console.WriteLine();
                            fightMenu.DisplayFightOptions();
                            action = fightMenu.MenuChoice();
                            if (action == 1)
                            {
                                menu.CC();
                                Console.Write("Fighting in progress...");
                                spinner.ShowSpinner(4);
                                action = fightMenu.Attack(player, enemy);
                            }
                        }
                    }
                }
            }
            else if (choice == 2) 
            {   
                menu.CC();
                Save save = new Save();
                save.GetSetFileName();
                save.DoToFile(player);
            }
            else if (choice == 3)
            {
                menu.CC();
                Load load = new Load();
                load.GetSetFileName();
                load.DoToFile(player);
            }
        }
    }
}