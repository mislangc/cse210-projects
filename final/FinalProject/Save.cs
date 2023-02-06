using System;

public class Save : Filename
{
    public Save()
    {

    }
    public Save(string filename, string message) : base(filename, message)
    {

    }
    public override void DoToFile(Player player)
    {
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            outputFile.WriteLine($"{player.GetName()},{player.GetLevel()},{player.GetCoins()},{player.GetHealth()},{player.GetBaseAttack()},{player.GetXp()},{player.GetWeaponAttack()},{player.GetWeaponName()}");
        }
    }
}