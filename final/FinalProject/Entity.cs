using System;

public class Entity
{
    protected string _name;
    protected int _level;
    protected int _coins;
    protected int _health;
    protected int _baseAttack;
    protected int _xp;

    public Entity()
    {
        
    }
    public Entity(string name)
    {
        _name = name;
    }
    public Entity(string name, int level, int coins, int health, int baseAttack, int xp)
    {
        _name = name;
        _level = level;
        _coins = coins;
        _health = health;
        _baseAttack = baseAttack;
        _xp = xp;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public void SetLevel(int level)
    {
        _level = level;
    }
    public void SetCoins(int coins)
    {
        _coins = coins;
    }
    public void SetHealth(int health)
    {
        _health = health;
    }
    public void SetBaseAttack(int baseAttack)
    {
        _baseAttack = baseAttack;
    }
    public void SetXp(int xp)
    {
        _xp = xp;
    }
    public string GetName()
    {
        return _name;
    }
    public int GetLevel()
    {
        return _level;
    }
    public int GetCoins()
    {
        return _coins;
    }
    public int GetHealth()
    {
        return _health;
    }
    public int GetBaseAttack()
    {
        return _baseAttack;
    }
    public int GetXp()
    {
        return _xp;
    }

}