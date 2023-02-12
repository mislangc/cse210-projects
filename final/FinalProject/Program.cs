using System;

class Program
{
    static void Main(string[] args)
    {
        Spinner spinner = new Spinner();
        Console.WriteLine("Welcome to -Text RPG- game");
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
            Console.WriteLine("");
            Console.WriteLine($"Welcome {player.GetName()}!");
            Console.WriteLine("");
            Console.Write("Choose your option: ");
            choice = menu.MenuChoice();
            if (choice == 1)
            {
                int decision = 0;
                while (decision != 5)
                {
                    player.CheckLevel();
                    menu.CC();
                    Console.WriteLine($"Level:{player.GetLevel()} (Xp:{player.GetXp()})");
                    Console.WriteLine($"Health: {player.GetHealth()}");
                    Console.WriteLine($"Coins: {player.GetCoins()}");
                    Console.WriteLine($"Health potion(s): {player.GetHealthPotionCount()}");
                    Console.WriteLine("");
                    PlayerMenu playerMenu = new PlayerMenu();
                    playerMenu.DisplayPlayerOptions();
                    Console.Write("What would you like to do? ");
                    decision = playerMenu.MenuChoice();
                    if (decision == 1)
                    {
                        Story story = new Story();
                        story.DisplayIntroduction();
                        story.DisplayChapterOneTitle();
                        story.ChapterOne();
                        story.Tutorial();
                        story.RoomOne();
                    }
                    else if (decision == 2)
                    {
                        menu.CC();
                        int action = 0;
                        Console.WriteLine("Searching for enemy...");
                        spinner.ShowSpinner(4);
                        Enemy enemy = new Enemy();
                        Console.WriteLine($"Enemy {enemy.GetName()} appeared.");
                        spinner.ShowSpinner(2);
                        while (action != 3)
                        {
                            menu.CC();
                            FightingMenu fightMenu = new FightingMenu(); 
                            Console.WriteLine($"Enemy {enemy.GetName()} Health:{enemy.GetHealth()}");
                            Console.WriteLine("");
                            Console.WriteLine($"Level:{player.GetLevel()} (Xp:{player.GetXp()})");
                            Console.WriteLine($"Health: {player.GetHealth()}");
                            Console.WriteLine($"Coins: {player.GetCoins()}");
                            Console.WriteLine($"Health potion(s): {player.GetHealthPotionCount()}");
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
                            else if(action == 2)
                            {
                                fightMenu.UseHealthPotion(player);
                            }
                        }
                    }
                    else if (decision == 3)
                    {
                        int shopChoice = 0;
                        while (shopChoice != 2)
                        {
                        ShopMenu shop = new ShopMenu();
                        shop.DisplayMenu();
                        Console.Write("What would you like to do? ");
                        shopChoice = shop.MenuChoice();
                        if (shopChoice == 1)
                        {
                            shop.BuyHealthPotion(player);
                        }
                        }
                    }
                    else if (decision == 4)
                    {
                        playerMenu.Rest(player);
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