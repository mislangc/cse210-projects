using System;

public class Load : Filename
{
    public Load()
    {

    }
    public Load(string filename, string message) : base(filename, message)
    {
        
    }
    public override void DoToFile(Player player)
    {
        string lines = File.ReadAllText(_filename);
        string[] parts = lines.Split(",");
        player.SetName(parts[0]);
        player.SetLevel(int.Parse(parts[1]));
        player.SetCoins(int.Parse(parts[2]));
        player.SetHealth(int.Parse(parts[3]));
        player.SetBaseAttack(int.Parse(parts[4]));
        player.SetXp(int.Parse(parts[5]));
        player.SetWeaponAttack(int.Parse(parts[6]));
        player.SetWeaponName(parts[7]);
        player.SetMaxHealth(int.Parse(parts[8]));
        player.SetMaxXp(int.Parse(parts[9]));
        player.SetHealthPotionCount(int.Parse(parts[10]));
        
    }
}