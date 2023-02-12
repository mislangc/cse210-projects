using System;

public class ShopMenu : Menu
{
    Spinner spin = new Spinner();
    public ShopMenu()
    {
        List<string> _shop = new List<string>();
        _shop.Add("1.Buy Health Potion (Cost: 4)");
        _shop.Add("2.Leave Shop");
        _options = _shop;
        _menuName = "-Shop-";
    }
    public void BuyHealthPotion(Player player)
    {
        
        Console.Write("How many would you like to buy? ");
        string input = Console.ReadLine();
        Console.WriteLine("");
        int quantity = int.Parse(input); 
        int cost = quantity * 3;
        if (player.GetCoins() > cost)
        {
            player.SetHealthPotionCount(player.GetHealthPotionCount() + quantity);
            player.SetCoins(player.GetCoins() - (quantity * 3));
            Console.Write($"You bought {quantity} potion(s).");
            spin.ShowSpinner(2);
        }
        else
        {
            InsufficientCoins();
        }
    }
    public void InsufficientCoins()
    {
        Console.Write("You don't have enough coins for that.");
        spin.ShowSpinner(1);
    }
}