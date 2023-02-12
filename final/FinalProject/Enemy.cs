using System;

public class Enemy : Entity
{   

    public Enemy() : base()
    {
        Random random = new Random();
        int enemyNum = random.Next(1,4);
        if (enemyNum == 1)
        {
        _name = "Rat";
        _level = 1;
        _coins = 2;
        _health = 5;
        _baseAttack = 1;
        _xp = 3;
        }
        else if (enemyNum == 2)
        {
        _name = "Bat";
        _level = 1;
        _coins = 2;
        _health = 3;
        _baseAttack = 1;
        _xp = 2;
        }
        else if(enemyNum == 3)
        {
        _name = "Snake";
        _level = 1;
        _coins = 3;
        _health = 6;
        _baseAttack = 2;
        _xp = 4;
        }
    }
    public Enemy(string name, int level, int coins, int health, int attackStats, int xp, string enemy) : base(name, level, coins, health, attackStats, xp)
    {
    
    }
}