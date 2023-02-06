using System;

public class Enemy : Entity
{   

    public Enemy() : base()
    {
        _name = "Rat";
        _level = 1;
        _coins = 2;
        _health = 3;
        _baseAttack = 1;
        _xp = 2;
    }
    public Enemy(string name, int level, int coins, int health, int attackStats, int xp, string enemy) : base(name, level, coins, health, attackStats, xp)
    {
    
    }
}